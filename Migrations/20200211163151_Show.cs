using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CasaShow.Migrations
{
    public partial class Show : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Valor",
                table: "Shows",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AddColumn<DateTime>(
                name: "Hora",
                table: "Shows",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hora",
                table: "Shows");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Shows",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
