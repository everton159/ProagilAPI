using Microsoft.EntityFrameworkCore.Migrations;

namespace Proagil.API.Migrations
{
    public partial class CampoImagemUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagemURL",
                table: "Eventos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagemURL",
                table: "Eventos");
        }
    }
}
