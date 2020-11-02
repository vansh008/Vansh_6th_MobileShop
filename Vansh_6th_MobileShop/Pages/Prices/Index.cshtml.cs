using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vansh_6th_MobileShop.BussinessLayer;
using Vansh_6th_MobileShop.Data;

namespace Vansh_6th_MobileShop.Pages.Prices
{
    public class IndexModel : PageModel
    {
        private readonly Vansh_6th_MobileShop.Data.ApplicationDbContext _context;

        public IndexModel(Vansh_6th_MobileShop.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Price> Price { get;set; }

        public async Task OnGetAsync()
        {
            Price = await _context.Prices.ToListAsync();
        }
    }
}
