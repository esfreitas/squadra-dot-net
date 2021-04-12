using Microsoft.EntityFrameworkCore.Migrations;

namespace B3.Migrations
{
    public partial class Inserindotiponatabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "tipo",
                table: "ativo",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tipo",
                table: "ativo");
        }
    }
}
