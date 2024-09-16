using Microsoft.EntityFrameworkCore;
using ArgosNet.Models;

namespace ArgosNet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("TB_ARGOS_CLIENTES");
            modelBuilder.Entity<Produtos>().ToTable("TB_ARGOS_PRODUTOS");

            base.OnModelCreating(modelBuilder);
        }
    }
}
