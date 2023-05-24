using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LotusPark.Models;

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

    }
}