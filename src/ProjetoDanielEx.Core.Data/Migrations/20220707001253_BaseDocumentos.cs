using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDanielEx.Core.Data.Migrations
{
    public partial class BaseDocumentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "documento",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "varchar(1000)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(255)", nullable: true),
                    idCliente = table.Column<int>(type: "int", nullable: true),
                    nome = table.Column<string>(type: "varchar(255)", nullable: false),
                    dt_inclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dt_alteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    dt_exclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento", x => x.id);
                    table.ForeignKey(
                        name: "FK_documento_cliente_idCliente",
                        column: x => x.idCliente,
                        principalSchema: "dbo",
                        principalTable: "cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_documento_idCliente",
                schema: "dbo",
                table: "documento",
                column: "idCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "documento",
                schema: "dbo");
        }
    }
}
