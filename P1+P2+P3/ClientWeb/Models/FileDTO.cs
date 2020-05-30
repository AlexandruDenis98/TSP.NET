
namespace ClientWeb.Models
{ 
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using ServiceReferenceClientWeb;

    [DataContract(IsReference = true)]
    public  class FileDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FileDTO()
        {
            this.Keywords = new List<FileKeywordDTO>();
            this.People = new List<FilePersonDTO>();
        }
        [DataMember]
        [Key]
        public int FileId { get; set; }

        [DataMember]
        public string Path { get; set; }

        [DataMember]
        public System.DateTime Created_at { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public bool Path_changed { get; set; }

        [DataMember]
        public string Location { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual List<FileKeywordDTO> Keywords { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual List<FilePersonDTO> People { get; set; }
    }
}
