using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebDBLybrary.Models;

namespace WebApplication2.Pages.Contributions
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication2.Data.WebApplication2Context _context;

        public IndexModel(WebApplication2.Data.WebApplication2Context context)
        {
            _context = context;
        }

        public IList<Contribution> Contribution { get;set; }

        public async Task OnGetAsync()
        {
            Contribution = await _context.contributions
                .Include(c => c.currerncy)
                .Include(c => c.depositor)
                .Include(c => c.employee).ToListAsync();
        }
    }
}
