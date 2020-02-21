using Microsoft.EntityFrameworkCore.Migrations;

namespace Nova_pasta.Migrations
{
    public partial class Ingressos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShowId",
                table: "Shows",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Shows",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_Shows_ShowId",
                table: "Shows",
                column: "ShowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shows_Shows_ShowId",
                table: "Shows",
                column: "ShowId",
                principalTable: "Shows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shows_Shows_ShowId",
                table: "Shows");

            migrationBuilder.DropIndex(
                name: "IX_Shows_ShowId",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "ShowId",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Shows");
        }
    }
}
