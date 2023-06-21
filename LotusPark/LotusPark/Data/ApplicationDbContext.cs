using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LotusPark.Models;
using Microsoft.AspNetCore.Identity;

namespace LotusPark.Data {

    /// <summary>
    /// esta classe representa a base de dados do projeto
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }

        // Criação das tabelas

        public DbSet<LotusPark.Models.Vagas> Vagas { get; set; }
        public DbSet<LotusPark.Models.Reservas> Reservas { get; set; }
        public DbSet<LotusPark.Models.Clientes> Clientes { get; set; }
        public DbSet<LotusPark.Models.Funcionarios> Funcionarios { get; set; }
        public DbSet<LotusPark.Models.Estados>? Estados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(
                 new IdentityRole { Id = "a", Name = "Administrador", NormalizedName = "ADMINISTRADOR" },
                 new IdentityRole { Id = "c", Name = "Cliente", NormalizedName = "CLIENTE" },
                 new IdentityRole { Id = "f", Name = "Funcionario", NormalizedName = "FUNCIONARIO" }
            );
        }

    }
}