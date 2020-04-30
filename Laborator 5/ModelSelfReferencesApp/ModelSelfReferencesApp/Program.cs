using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSelfReferencesApp
{
    class Program
    {
        static void model2_insert_fetch()
        {
            // COMENTAT PENTRU CA AM ADAUGAT DEJA INTREGISTRARILE CU ID-URILE RESPECTIVE

            //using (var context = new Model2SelfReferences())
            //{
            //    var product = new Product
            //    {
            //        SKU = 147,
            //        Description = "Expandable Hydration Pack",
            //        Price = 19.97M,
            //        ImageURL = "/pack147.jpg"
            //    };
            //    context.Products.Add(product);
            //    product = new Product
            //    {
            //        SKU = 178,
            //        Description = "Rugged Ranger Duffel Bag",
            //        Price = 39.97M,
            //        ImageURL = "/pack178.jpg"
            //    };
            //    context.Products.Add(product);
            //    product = new Product
            //    {
            //        SKU = 186,
            //        Description = "Range Field Pack",
            //        Price = 98.97M,
            //        ImageURL = "/noimage.jp"
            //    };
            //    context.Products.Add(product);
            //    product = new Product
            //    {
            //        SKU = 202,
            //        Description = "Small Deployment Back Pack",
            //        Price = 29.97M,
            //        ImageURL = "/pack202.jpg"
            //    };
            //    context.Products.Add(product);
            //    context.SaveChanges();
            //}
            using (var context = new Model2SelfReferences())
{
                foreach (var p in context.Products)
                {
                    Console.WriteLine("{0} {1} {2} {3}", p.SKU, p.Description,
                    p.Price.ToString("C"), p.ImageURL);
                }
            }
        }
        static void model3_insert_fetch()
        {
            byte[] thumbBits = new byte[100];
            byte[] fullBits = new byte[2000];
            using (var context = new Model3SelfReferences())
            {
                var photo = new Photograph
                {
                    Title = "My Dog",
                    ThumbnailBits = thumbBits
                };
                var fullImage = new PhotographFullImage
                {
                    HighResolutionBits =
                fullBits
                };
                photo.PhotographFullImage = fullImage;
                context.Photographs.Add(photo);
                context.SaveChanges();
            }
            using (var context = new Model3SelfReferences())
            {
                foreach (var photo in context.Photographs)
                {
                    Console.WriteLine("Photo: {0}, ThumbnailSize {1} bytes",
                    photo.Title, photo.ThumbnailBits.Length);
                    // explicitly load the "expensive" entity,
                    context.Entry(photo)
                    .Reference(p => p.PhotographFullImage).Load();
                    Console.WriteLine("Full Image Size: {0} bytes",
                    photo.PhotographFullImage.HighResolutionBits.Length);
                }
            }
        }

        static void model4_insert_fetch()
        {
            using (var context = new Model4SelfReferences())
{
                var business = new Business
                {
                    Name = "Corner Dry Cleaning",
                    LicenseNumber = "100x1"
                };
                context.Businesses.Add(business);
                var retail = new Retail
                {
                    Name = "Shop and Save",
                    LicenseNumber = "200C",
                    Address = "101 Main",
                    City = "Anytown",
                    State = "TX",
                    ZIPCode = "76106"
                };
                context.Businesses.Add(retail);
                var web = new eCommerce
                {
                    Name = "BuyNow.com",
                    LicenseNumber = "300AB",
                    URL = "www.buynow.com"
                };
                context.Businesses.Add(web);
                context.SaveChanges();
            }
            using (var context = new Model4SelfReferences())
{
                Console.WriteLine("\n--- All Businesses ---");
                foreach (var b in context.Businesses)
                {
                    Console.WriteLine("{0} (#{1})", b.Name, b.LicenseNumber);
                }
                Console.WriteLine("\n--- Retail Businesses ---");
                foreach (var r in context.Businesses.OfType<Retail>())
                {
                    Console.WriteLine("{0} (#{1})", r.Name, r.LicenseNumber);
                    Console.WriteLine("{0}", r.Address);
                    Console.WriteLine("{0}, {1} {2}", r.City, r.State, r.ZIPCode);
                }
                Console.WriteLine("\n--- eCommerce Businesses ---");
                foreach (var e in context.Businesses.OfType<eCommerce>())
                {
                    Console.WriteLine("{0} (#{1})", e.Name, e.LicenseNumber);
                    Console.WriteLine("Online address is: {0}", e.URL);
                }
            }
        }
        static void Main(string[] args)
        {
            using (var context = new ModelSelfReferences())
            {
                //Deleting records from SelfReferences table
                List<SelfReference> myList = context.SelfReferences.Take(context.SelfReferences.Count()).ToList();
                context.SelfReferences.RemoveRange(myList);
                context.SaveChanges();

                var selfReference1 = new SelfReference
                {
                    Name = "parentReference"
                };
                context.SelfReferences.Add(selfReference1);
                var selfReference2 = new SelfReference
                {
                    Name = "childReference1",
                    ParentSelfReference = selfReference1

                };var selfReference3 = new SelfReference
                {
                    Name = "childReference2",
                    ParentSelfReference = selfReference1

                };
                context.SelfReferences.Add(selfReference2);
                context.SelfReferences.Add(selfReference3);
                context.SaveChanges();

                //Viewing records from SelfReferences table
                var selfReferences = (from sRs in context.SelfReferences select sRs).ToList();
                foreach (var sR in selfReferences)
                {
                    Console.WriteLine("ID : {0}, Name : {1}, Parent : {2} ",sR.SelfReferenceId, sR.Name, sR.ParentSelfReferenceId);
                    foreach(var sRChild in sR.References)
                    {
                        Console.WriteLine("[+] Child ID : {0}, Name : {1}", sRChild.SelfReferenceId, sRChild.Name);
                    }
                }
            }
            model2_insert_fetch();
            model3_insert_fetch();
            model4_insert_fetch();
        }
    }
}
