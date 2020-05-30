using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClientWeb.Models
{
    public class FilePersonDTO
    {
        [Key]
        public int FilePersonKey { get; set; }
        public int PersonId { get; set; }
        public PersonDTO Person { get; set; }

        public int FileId { get; set; }
        public FileDTO File { get; set; }

    }
}
