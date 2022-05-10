using System;
using Microsoft.EntityFrameworkCore;
using ReservaRestaurante.App.Dominio;

namespace ReservaRestaurante.App.Persistencia.Context
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente>? Clientes { get; set; }

        public DbSet<Mesa>? Mesas { get; set; }

        public DbSet<Mesero>? Meseros { get; set; }

        //public DbSet<Persona> Personas { get; set; }

        public DbSet<Reserva>? Reservas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opciones)
        {
            if (!opciones.IsConfigured)
            {
                opciones
                    .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=ReservaRestaurante");
            }
        }

        //permite volver atributos como unicos
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cliente>().HasIndex(u => u.Cedula).IsUnique();
            builder.Entity<Mesero>().HasIndex(u => u.Cedula).IsUnique();
            builder.Entity<Mesa>().HasIndex(u => u.numero).IsUnique();
        }
    }
}
