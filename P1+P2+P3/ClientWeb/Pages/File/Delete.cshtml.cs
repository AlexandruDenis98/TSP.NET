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
    public class DeleteModel : PageModel
    {
        private readonly ClientWeb.Data.ClientWebContext _context;

        public DeleteModel(ClientWeb.Data.ClientWebContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FileDTO = await _context.FileDTO.FindAsync(id);

            if (FileDTO != null)
            {
                _context.FileDTO.Remove(FileDTO);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
