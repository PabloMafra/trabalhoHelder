using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoGuardaChuva.Migrations
{
    public partial class ColunaGenero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Funcionarios");
        }
    }
}
