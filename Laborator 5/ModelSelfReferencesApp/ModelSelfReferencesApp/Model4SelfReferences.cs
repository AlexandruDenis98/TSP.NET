using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ModelSelfReferencesApp
{
    class Model4SelfReferences : DbContext
    {
        public virtual DbSet<Business> Businesses { get; set; }

    }
    [Table("Bussiness", Schema = "Model4SelfReferences")]
    public class Business
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessId { get; protected set; }
        public string Name { get; set; }
        public string LicenseNumber { get; set; }

    }
    [Table("eCommerce", Schema = "Model4SelfReferences")]
    public class eCommerce : Business
    {
        public string URL { get; set; }

    }
    [Table("Retail", Schema = "Model4SelfReferences")]
    public class Retail : Business 
    { 
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIPCode { get; set; }

    }

}
