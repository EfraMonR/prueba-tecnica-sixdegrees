using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Entities;
using Microsoft.EntityFrameworkCore;

namespace CapaAccesoDatos
{
    public class PruebaSDDbContext : DbContext
    {
        public PruebaSDDbContext(DbContextOptions<PruebaSDDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PruebaSDDbContext).Assembly);
        }
    }
}
