using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Inicial13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RECEITAS_ADICIONAIS",
                table: "RECEITAS_ADICIONAIS");

            migrationBuilder.RenameTable(
                name: "RECEITAS_ADICIONAIS",
                newName: "RECEITAS_EXTRAS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RECEITAS_EXTRAS",
                table: "RECEITAS_EXTRAS",
                column: "ReceitaExtraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RECEITAS_EXTRAS",
                table: "RECEITAS_EXTRAS");

            migrationBuilder.RenameTable(
                name: "RECEITAS_EXTRAS",
                newName: "RECEITAS_ADICIONAIS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RECEITAS_ADICIONAIS",
                table: "RECEITAS_ADICIONAIS",
                column: "ReceitaExtraId");
        }
    }
}
