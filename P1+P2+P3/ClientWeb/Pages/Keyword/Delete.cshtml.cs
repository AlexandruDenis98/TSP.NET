using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClientWeb.Data;
using ClientWeb.Models;

namespace ClientWeb.Pages.Keyword
{
    public class DeleteModel : PageModel
    {
        private readonly ClientWeb.Data.ClientWebContext _context;

        public DeleteModel(ClientWeb.Data.ClientWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FileKeywordDTO FileKeywordDTO { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FileKeywordDTO = await _context.FileKeywordDTO
                .Include(f => f.File)
                .Include(f => f.Keyword).FirstOrDefaultAsync(m => m.FIleKeywordId == id);

            if (FileKeywordDTO == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FileKeywordDTO = await _context.FileKeywordDTO.FindAsync(id);

            if (FileKeywordDTO != null)
            {
                _context.FileKeywordDTO.Remove(FileKeywordDTO);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
