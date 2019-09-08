using ControleFinanceiro.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Persistencia.Context
{
    public class EFContext : DbContext
    {

        public DbSet<CompraParcelada> ComprasParceladas { get; set; }
        public DbSet<CompraFixa> ComprasFixas { get; set; }
        public DbSet<CompraMensal> ComprasMensais { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\kelvi\Google Drive\Microsoft .NET\Projetos\ControleFinanceiro\ControleFinanceiro\App_Data\CONTROLE_FINANCEIRO.mdf; Integrated Security = True; Connect Timeout = 90");
        }

        //Define o nome das Tabelas no Banco.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompraParcelada>().ToTable("COMPRAS_PARCELADAS");
            modelBuilder.Entity<CompraFixa>().ToTable("COMPRAS_FIXAS");
            modelBuilder.Entity<CompraMensal>().ToTable("COMPRAS_MENSAIS");
        }

    }
}