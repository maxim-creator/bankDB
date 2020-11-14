using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebDBLybrary.Models;

namespace WebApplication2.Data
{
    public class WebApplication2Context : DbContext
    {
        public WebApplication2Context (DbContextOptions<WebApplication2Context> options)
            : base(options)
        {
        }

        public DbSet<WebDBLybrary.Models.Contribution>  contributions { get; set; }

        public DbSet<WebDBLybrary.Models.Employee> employees { get; set; }

        public DbSet<WebDBLybrary.Models.Currency> currencies { get; set; }

        public DbSet<WebDBLybrary.Models.Position> Position { get; set; }

        public DbSet<WebDBLybrary.Models.Depositor> Publisher { get; set; }

        
    }
}
