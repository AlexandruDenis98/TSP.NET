using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClientWeb.Data;
using ClientWeb.Models;

namespace ClientWeb.Pages.File
{
    public class EditModel : PageModel
    {
        private readonly ClientWeb.Data.ClientWebContext _context;

        public EditModel(ClientWeb.Data.ClientWebContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FileDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FileDTOExists(FileDTO.FileId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FileDTOExists(int id)
        {
            return _context.FileDTO.Any(e => e.FileId == id);
        }
    }
}
