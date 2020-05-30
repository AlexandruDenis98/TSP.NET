using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClientWeb.Models
{
    public class FileKeywordDTO
    {
        [Key]
        public int FIleKeywordId { get; set; }

        public int KeywordId { get; set; }
        public Models.KeywordDTO Keyword { get; set;}
        
        public int FileId { get; set; }
        public Models.FileDTO File { get; set; }

    }
}
