using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET_CORE_PDF.Models
{
    public class AppDbContext : DbContext
    {
        //ct, pasamos la cadena de conexion 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Persona>().ToTable("Persona");
        }

        public DbSet<Persona> Personas { get; set; }

    }
}
