using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClientWeb.Data;
using ClientWeb.Models;

namespace ClientWeb.Pages.File
{
    public class DetailsModel : PageModel
    {
        private readonly ClientWeb.Data.ClientWebContext _context;

        public DetailsModel(ClientWeb.Data.ClientWebContext context)
        {
            _context = context;
        }

        public FileDTO FileDTO { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FileDTO = await _context.FileDTO.FirstOrDefaultAsync(m => m.FileId == id);

            if (FileDTO == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
