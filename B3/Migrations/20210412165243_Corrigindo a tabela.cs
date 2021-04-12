using Microsoft.EntityFrameworkCore.Migrations;

namespace B3.Migrations
{
    public partial class Corrigindoatabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "valor",
                table: "ativo");

            migrationBuilder.RenameColumn(
                name: "codigoB3",
                table: "ativo",
                newName: "codigob3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "codigob3",
                table: "ativo",
                newName: "codigoB3");

            migrationBuilder.AddColumn<int>(
                name: "valor",
                table: "ativo",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
