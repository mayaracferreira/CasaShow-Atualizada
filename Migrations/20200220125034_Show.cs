using Microsoft.EntityFrameworkCore.Migrations;

namespace Nova_pasta.Migrations
{
    public partial class Show : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Casa",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Shows");

            migrationBuilder.AddColumn<int>(
                name: "CasaseClubesId",
                table: "Shows",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Shows",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shows_CasaseClubesId",
                table: "Shows",
                column: "CasaseClubesId");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_CategoriaId",
                table: "Shows",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shows_Casas_CasaseClubesId",
                table: "Shows",
                column: "CasaseClubesId",
                principalTable: "Casas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shows_Categorias_CategoriaId",
                table: "Shows",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shows_Casas_CasaseClubesId",
                table: "Shows");

            migrationBuilder.DropForeignKey(
                name: "FK_Shows_Categorias_CategoriaId",
                table: "Shows");

            migrationBuilder.DropIndex(
                name: "IX_Shows_CasaseClubesId",
                table: "Shows");

            migrationBuilder.DropIndex(
                name: "IX_Shows_CategoriaId",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "CasaseClubesId",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Shows");

            migrationBuilder.AddColumn<string>(
                name: "Casa",
                table: "Shows",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Shows",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
