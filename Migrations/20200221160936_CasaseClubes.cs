using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nova_pasta.Migrations
{
    public partial class CasaseClubes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Categorias_CategoriaId",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_Shows_Categorias_CategoriaId",
                table: "Shows");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Shows_CategoriaId",
                table: "Shows");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_CategoriaId",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Eventos");

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Shows",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Eventos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Eventos");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Shows",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Data",
                table: "Shows",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Eventos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shows_CategoriaId",
                table: "Shows",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_CategoriaId",
                table: "Eventos",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Categorias_CategoriaId",
                table: "Eventos",
                column: "CategoriaId",
                principalTable: "Categorias",
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
    }
}
