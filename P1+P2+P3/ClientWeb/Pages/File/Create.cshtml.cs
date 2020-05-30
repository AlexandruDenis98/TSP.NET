using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClientWeb.Data;
using ClientWeb.Models;

namespace ClientWeb.Pages.File
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
            return Page();
        }

        [BindProperty]
        public FileDTO FileDTO { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FileDTO.Add(FileDTO);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
