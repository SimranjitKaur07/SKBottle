using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SKBottle.Models;

namespace SKBottle.Data
{
    public class SKBottleContext : DbContext
    {
        public SKBottleContext (DbContextOptions<SKBottleContext> options)
            : base(options)
        {
        }

        public DbSet<SKBottle.Models.Bottle> Bottle { get; set; }
    }
}
