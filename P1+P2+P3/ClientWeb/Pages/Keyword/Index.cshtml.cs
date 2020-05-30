using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClientWeb.Data;
using ClientWeb.Models;
using ServiceReferenceClientWeb;

namespace ClientWeb.Pages.Keyword
{
    public class IndexModel : PageModel
    {
        private readonly ClientWeb.Data.ClientWebContext _context;
        FilePersonKeywordClient client = new FilePersonKeywordClient();
        public List<KeywordDTO> KeywordDTOList { get; set; }


        public IndexModel(ClientWeb.Data.ClientWebContext context)
        {
            _context = context;
            KeywordDTOList = new List<KeywordDTO>();
        }

        public async Task OnGetAsync()
        {
            var keywords = await client.GetAllKeywordsAsync();
            foreach(var keyword in keywords.OrderBy(k => k.Kword))
            {
                KeywordDTO keywordDTO = new KeywordDTO();
                keywordDTO.Id = keyword.Id;
                keywordDTO.Kword = keyword.Kword;
                KeywordDTOList.Add(keywordDTO);
            }
        }
    }
}
