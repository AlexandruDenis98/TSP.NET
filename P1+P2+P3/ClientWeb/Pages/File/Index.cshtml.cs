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

namespace ClientWeb.Pages.File
{
    public class IndexModel : PageModel
    {
        private readonly ClientWeb.Data.ClientWebContext _context;
        FilePersonKeywordClient client = new FilePersonKeywordClient();
        public List<FileDTO> fileDTOList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string FilterKeyword { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FilterLocation { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Number { get; set; }
        public IndexModel(ClientWeb.Data.ClientWebContext context)
        {
            _context = context;
            fileDTOList = new List<FileDTO>();
        }

        public IList<FileDTO> FileDTO { get;set; }

        public async Task OnGetAsync()
        {
            var files = await client.GetAllFilesAsync();
            foreach(var file in files)
            {
                
                FileDTO fileDTO = new FileDTO();
                fileDTO.FileId = file.FileId;
                fileDTO.Created_at = file.Created_at;
                fileDTO.Location = file.Location;
                fileDTO.Path = file.Path;
                fileDTO.Type = file.Type;
                fileDTO.Path_changed= file.Path_changed;
                ServiceReferenceClientWeb.Keyword[] keywordList=  await client.GetKeywordsOfFileAsync(file.Path);
                foreach (var keyword in keywordList)
                {
                    FileKeywordDTO fkDTO = new FileKeywordDTO();
                    KeywordDTO keywordDTO = new KeywordDTO();
                    keywordDTO.Id = keyword.Id;
                    keywordDTO.Kword = keyword.Kword;
                    fkDTO.File = fileDTO;
                    fkDTO.FileId = fileDTO.FileId;
                    fkDTO.FIleKeywordId = keywordDTO.Id;
                    fkDTO.Keyword = keywordDTO;
                    fileDTO.Keywords.Add(fkDTO);
                }
                if(FilterLocation == null && FilterKeyword == null)
                    fileDTOList.Add(fileDTO);
                else
                {
                    if( FilterLocation == null)
                    {
                        bool find = false;
                            foreach (var item in fileDTO.Keywords)
       
                                if (item.Keyword.Kword == FilterKeyword)
                                    find = true;
                        if (find) fileDTOList.Add(fileDTO);
                    }
                    else if(FilterKeyword == null)
                    {
                        if(fileDTO.Location == FilterLocation)
                            fileDTOList.Add(fileDTO);
                    }
                    else
                    {
                        bool find = false;
                        foreach (var item in fileDTO.Keywords)

                            if (item.Keyword.Kword == FilterKeyword && fileDTO.Location == FilterLocation)
                                find = true;
                        if (find) fileDTOList.Add(fileDTO);
                    }
                }
                Number = fileDTOList.Count.ToString();

            }
        }
    }
}
