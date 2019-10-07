using Modelo.Entidades;
using Modelo.Tabelas;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Context
{
    public class EFContext : DbContext
    {
        public DbSet<DespesaParcelada> DespesasParceladas { get; set; }
        public DbSet<DespesaDia> DespesasDia { get; set; }
        public DbSet<DespesaMensal> DespesasMensais { get; set; }
        public DbSet<ReceitaMensal> ReceitasMensais { get; set; }
        public DbSet<ReceitaAdicional> ReceitaAdicionals { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fadami\source\repos\ControleFinanceiro\ControleFinanceiro\App_Data\CONTROLE_FINANCEIRO.mdf;Integrated Security=True");
        }

        //Define o nome das Tabelas no Banco.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DespesaParcelada>().ToTable("DESPESAS_PARCELADAS");
            modelBuilder.Entity<DespesaDia>().ToTable("DESPESAS_DIA");
            modelBuilder.Entity<DespesaMensal>().ToTable("DESPESAS_MENSAIS");
            modelBuilder.Entity<ReceitaMensal>().ToTable("RECEITAS_MENSAIS");
            modelBuilder.Entity<ReceitaAdicional>().ToTable("RECEITAS_ADICIONAIS");
        }

    }
}