using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDanielEx.Core.Data.Migrations
{
    public partial class BaseEnderecoNova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_endereco_idCliente",
                table: "endereco");

            migrationBuilder.AlterColumn<int>(
                name: "idCliente",
                table: "endereco",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_endereco_idCliente",
                table: "endereco",
                column: "idCliente",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_endereco_idCliente",
                table: "endereco");

            migrationBuilder.AlterColumn<int>(
                name: "idCliente",
                table: "endereco",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_endereco_idCliente",
                table: "endereco",
                column: "idCliente",
                unique: true,
                filter: "[idCliente] IS NOT NULL");
        }
    }
}
