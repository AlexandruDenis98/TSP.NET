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

namespace ClientWeb.Pages.Keyword
{
    public class EditModel : PageModel
    {
        private readonly ClientWeb.Data.ClientWebContext _context;

        public EditModel(ClientWeb.Data.ClientWebContext context)
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
           ViewData["FileId"] = new SelectList(_context.FileDTO, "FileId", "FileId");
           ViewData["KeywordId"] = new SelectList(_context.Set<KeywordDTO>(), "Id", "Id");
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

            _context.Attach(FileKeywordDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FileKeywordDTOExists(FileKeywordDTO.FIleKeywordId))
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

        private bool FileKeywordDTOExists(int id)
        {
            return _context.FileKeywordDTO.Any(e => e.FIleKeywordId == id);
        }
    }
}
