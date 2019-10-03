using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DESPESAS_FIXAS",
                columns: table => new
                {
                    DespesaFixaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeItem = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    DataHora = table.Column<DateTime>(nullable: false),
                    Categoria = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DESPESAS_FIXAS", x => x.DespesaFixaId);
                });

            migrationBuilder.CreateTable(
                name: "DESPESAS_MENSAIS",
                columns: table => new
                {
                    DespesaMensalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeItem = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    DataHora = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DESPESAS_MENSAIS", x => x.DespesaMensalId);
                });

            migrationBuilder.CreateTable(
                name: "DESPESAS_PARCELADAS",
                columns: table => new
                {
                    DespesaParceladaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeItem = table.Column<string>(nullable: true),
                    ValorParcela = table.Column<double>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    DataHora = table.Column<DateTime>(nullable: false),
                    QuantidadeParcela = table.Column<int>(nullable: false),
                    Categoria = table.Column<string>(nullable: true),
                    StatusPagamento = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DESPESAS_PARCELADAS", x => x.DespesaParceladaId);
                });

            migrationBuilder.CreateTable(
                name: "RECEITAS_ADICIONAIS",
                columns: table => new
                {
                    ReceitaAdicionalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeItem = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    DataHora = table.Column<DateTime>(nullable: false),
                    TipoReceita = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RECEITAS_ADICIONAIS", x => x.ReceitaAdicionalId);
                });

            migrationBuilder.CreateTable(
                name: "RECEITAS_MENSAIS",
                columns: table => new
                {
                    ReceitaMensalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeReceita = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    DataHora = table.Column<DateTime>(nullable: false),
                    TipoReceita = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RECEITAS_MENSAIS", x => x.ReceitaMensalId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DESPESAS_FIXAS");

            migrationBuilder.DropTable(
                name: "DESPESAS_MENSAIS");

            migrationBuilder.DropTable(
                name: "DESPESAS_PARCELADAS");

            migrationBuilder.DropTable(
                name: "RECEITAS_ADICIONAIS");

            migrationBuilder.DropTable(
                name: "RECEITAS_MENSAIS");
        }
    }
}
