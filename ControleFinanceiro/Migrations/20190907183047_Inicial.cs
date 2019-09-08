using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleFinanceiro.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "COMPRAS_FIXAS",
                columns: table => new
                {
                    CompraFixaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeItem = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    DataHora = table.Column<DateTime>(nullable: false),
                    Categoria = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPRAS_FIXAS", x => x.CompraFixaId);
                });

            migrationBuilder.CreateTable(
                name: "COMPRAS_MENSAIS",
                columns: table => new
                {
                    CompraMensalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeItem = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    DataHora = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPRAS_MENSAIS", x => x.CompraMensalId);
                });

            migrationBuilder.CreateTable(
                name: "COMPRAS_PARCELADAS",
                columns: table => new
                {
                    CompraParceladaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeItem = table.Column<string>(nullable: true),
                    ValorParcela = table.Column<double>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    DataHora = table.Column<DateTime>(nullable: false),
                    QuantidadeParcela = table.Column<int>(nullable: false),
                    Categoria = table.Column<string>(nullable: true),
                    StatusPagamento = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPRAS_PARCELADAS", x => x.CompraParceladaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "COMPRAS_FIXAS");

            migrationBuilder.DropTable(
                name: "COMPRAS_MENSAIS");

            migrationBuilder.DropTable(
                name: "COMPRAS_PARCELADAS");
        }
    }
}
