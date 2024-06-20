using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pi.Models;

namespace Pi.Data
{
    public class PiContext : DbContext
    {
        public PiContext (DbContextOptions<PiContext> options)
            : base(options)
        {
        }

        public DbSet<Pi.Models.Furniture> Furniture { get; set; } = default!;
    }
}
