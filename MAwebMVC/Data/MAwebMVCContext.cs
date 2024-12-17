using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MAwebMVC.Models;

namespace MAwebMVC.Data
{
    public class MAwebMVCContext : DbContext
    {
        public MAwebMVCContext (DbContextOptions<MAwebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MAwebMVC.Models.Burger> Burger { get; set; } = default!;
    }
}
