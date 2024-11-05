
using Dominio.Modelos;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;

namespace InfraEstructura.Context
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext(DbContextOptions<ConnectionContext> options) : base(options) { }
        //crear dbsets
        public DbSet<Exito> Exitos { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exito>(e =>
            {
                e.HasNoKey();
            });
            modelBuilder.Entity<Login>(e =>
            {
                e.HasNoKey();
            });
            modelBuilder.Entity<Empleados>(e =>
            {
                e.HasNoKey(); ;
            });


        }
    }
}
