using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LotusPark.Data {
    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }

        // Criação das tabelas

        public DbSet<LotusPark.Models.Vagas> Vagas { get; set; }
        public DbSet<LotusPark.Models.Reservas> Reservas { get; set; }
        public DbSet<LotusPark.Models.Clientes> Clientes { get; set; }
        public DbSet<LotusPark.Models.Funcionarios> Funcionarios { get; set; }

    }
}