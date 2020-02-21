using Microsoft.EntityFrameworkCore.Migrations;

namespace Nova_pasta.Migrations
{
    public partial class Aux : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Aux",
                table: "Shows",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aux",
                table: "Shows");
        }
    }
}
