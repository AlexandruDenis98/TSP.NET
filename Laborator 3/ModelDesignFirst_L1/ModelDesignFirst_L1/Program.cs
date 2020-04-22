using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            TestPerson();
            TesTOneToMany();
            TestManyToMany();
            Console.ReadKey();
        }
        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                string firstName = Console.ReadLine();
                string lastName = Console.ReadLine();
                string middleName = Console.ReadLine();
                string telephonNumber = Console.ReadLine();

                Person p = new Person()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    MiddleName = middleName,
                    TelephonNumber = telephonNumber
                };
                context.People.Add(p);
                context.SaveChanges();
                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
            }
        }
        static void TesTOneToMany()
        {
            Console.WriteLine("One to many association");
            string name, city;
            decimal totalValue;
            DateTime date;
            using (Model1Container context =
           new Model1Container())
            {
                Console.WriteLine("Insert the name of the customer: ");
                name = Console.ReadLine();
                Console.WriteLine("Insert the city of the customer: ");
                city = Console.ReadLine();
                Customer c = new Customer()
                {
                    Name = name,
                    City = city
                };
                Console.WriteLine("Insert the totalValue of the order: ");
                totalValue = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Insert the date of the order: ");
                date = DateTime.Parse(Console.ReadLine());
                Order o1 = new Order()
                {
                    TotalValue = totalValue,
                    Date = date,
                    Customer = c
                };
                Console.WriteLine("Insert the totalValue of the order: ");
                totalValue = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Insert the date of the order: ");
                date = Convert.ToDateTime(Console.ReadLine());
                Order o2 = new Order()
                {
                    TotalValue = totalValue,
                    Date = date,
                    Customer = c
                };
                context.Customers.Add(c);
                context.Orders.Add(o1);
                context.Orders.Add(o2);
                context.SaveChanges();
                var items = context.Customers;
                foreach (var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}",
                   x.CustomerId, x.Name, x.City);
                    foreach (var ox in x.Orders)
                        Console.WriteLine("\tOrders: {0}, {1}, {2}",
                       ox.OrderId, ox.Date, ox.TotalValue);
                }
            }
        }
        static void TestManyToMany()
        {
            Console.WriteLine("Many to many association");
            //string albumName, firstName, lastName;

            using (Model1Container context =
           new Model1Container())
            {
                //Console.WriteLine("Insert the name of the album: ");
                //albumName = Console.ReadLine();
                Album album1 = new Album()
                {
                    AlbumName = "album1"
                };
                Album album2 = new Album()
                {
                    AlbumName = "album2"
                };

                //Console.WriteLine("Insert the first name of the artist: ");
                //firstName= Console.ReadLine();
                //Console.WriteLine("Insert the last name of the artist: ");
                //lastName = Console.ReadLine();

                Artist artist1 = new Artist()
                {
                     FirstName = "firstName1",
                     LastName = "lastName1"
                };
                Artist artist2 = new Artist()
                {
                    FirstName = "firstName2",
                    LastName = "lastName2"
                };

                context.Artists.Add(artist1);
                context.Artists.Add(artist2);
                context.Albums.Add(album1);
                context.Albums.Add(album2);
                context.SaveChanges();

                //context.Albums.Add(album);
                var artists = context.Artists;
                foreach (var artist in artists)
                {
                    Console.WriteLine("Artist : {0}, {1}, {2}",
                   artist.ArtistId, artist.FirstName, artist.LastName);
                }
                var albums = context.Albums;
                foreach (var album in albums)
                    Console.WriteLine("\tOrders: {0}, {1}",
                   album.AlbumId, album.AlbumName);
            }
        }

    }

}
