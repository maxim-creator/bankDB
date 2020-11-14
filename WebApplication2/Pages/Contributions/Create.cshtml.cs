﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Data;
using WebDBLybrary.Models;

namespace WebApplication2.Pages.Contributions

{
    public class CreateModel : PageModel
    {
        private readonly WebApplication2.Data.WebApplication2Context _context;

        public CreateModel(WebApplication2.Data.WebApplication2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CurrencyID"] = new SelectList(_context.currencies, "ID", "ID");
        ViewData["DepositorID"] = new SelectList(_context.Publisher, "ID", "ID");
        ViewData["EmployeeID"] = new SelectList(_context.employees, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Contribution Contribution { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.contributions.Add(Contribution);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
