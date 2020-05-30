using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using ServiceReferenceClientWeb;

namespace ClientWeb.Models

{
    [DataContract(IsReference = true)]
    public  class PersonDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonDTO()
        {
            this.Files = new List<FilePersonDTO>();
        }

        [DataMember]
        [Key]
        public int Id { get; set; }

        [DataMember]
        public string First_name { get; set; }

        [DataMember]
        public string Last_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual List<FilePersonDTO> Files { get; set; }
    }
}
