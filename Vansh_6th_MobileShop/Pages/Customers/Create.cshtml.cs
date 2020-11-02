﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vansh_6th_MobileShop.BussinessLayer;
using Vansh_6th_MobileShop.Data;

namespace Vansh_6th_MobileShop.Pages.Customers
{
    public class CreateModel : PageModel
    {
        private readonly Vansh_6th_MobileShop.Data.ApplicationDbContext _context;

        public CreateModel(Vansh_6th_MobileShop.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ModelID"] = new SelectList(_context.Models, "ID", "Name");
        ViewData["PriceID"] = new SelectList(_context.Prices, "ID", "Rate");
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customers.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
