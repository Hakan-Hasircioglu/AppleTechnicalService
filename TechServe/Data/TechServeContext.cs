using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechServe.Model;

namespace TechServe.Data
{
    public class TechServeContext : DbContext
    {
        public TechServeContext (DbContextOptions<TechServeContext> options)
            : base(options)
        {
        }

        public DbSet<TechServe.Model.Master> Master { get; set; } = default!;
        public DbSet<TechServe.Model.Devices> Devices { get; set; } = default!;
        public DbSet<TechServe.Model.Costumers> Costumers { get; set; } = default!;
        public DbSet<TechServe.Model.DetailsTable> Details { get; set; } = default!;
        public DbSet<TechServe.Model.SpareParts> SpareParts { get; set; } = default!;
        public DbSet<TechServe.Model.BuySpareParts> BuySpareParts { get; set; } = default!;
    }
}
