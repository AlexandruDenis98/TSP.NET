using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClientWeb.Data;
using ClientWeb.Models;

namespace ClientWeb.Pages.Keyword
{
    public class CreateModel : PageModel
    {
        private readonly ClientWeb.Data.ClientWebContext _context;

        public CreateModel(ClientWeb.Data.ClientWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["FileId"] = new SelectList(_context.FileDTO, "FileId", "FileId");
        ViewData["KeywordId"] = new SelectList(_context.Set<KeywordDTO>(), "Id", "Id");
            return Page();
        }

        [BindProperty]
        public FileKeywordDTO FileKeywordDTO { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FileKeywordDTO.Add(FileKeywordDTO);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
