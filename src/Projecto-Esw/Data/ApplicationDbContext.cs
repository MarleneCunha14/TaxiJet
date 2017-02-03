using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projecto_Esw.Models;


namespace Projecto_Esw.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Companhia> Companhia { get; set; }
        public DbSet<TipoJato> Tipojato { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<Destino> Destino { get; set; }
        public DbSet<ReservaIda> ReservaIda { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().ToTable("Utilizador");
            builder.Entity<Companhia>().ToTable("Companhia");
            builder.Entity<TipoJato>().ToTable("TipoJato");
            builder.Entity<Reserva>().ToTable("Reserva");
            builder.Entity<Destino>().ToTable("Destino");
            builder.Entity<ReservaIda>().ToTable("ReservaIda");
            

        }
        

        public DbSet<Help> Help { get; set; }
        

        public DbSet<HelpReserva> HelpReserva { get; set; }
}
}
