using apiFuncionarios.Data.Map;
using apiFuncionarios.Models;
using Microsoft.EntityFrameworkCore;

namespace apiFuncionarios.Data
{
    public class SistemaDBContext : DbContext
    {
        public SistemaDBContext(DbContextOptions<SistemaDBContext> options)
            : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Setor> Setor { get; set; }
        public DbSet<Estoque> Estoque { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
            modelBuilder.ApplyConfiguration(new SetorMap());
            modelBuilder.ApplyConfiguration(new EstoqueMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
