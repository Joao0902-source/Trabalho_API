using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_CONTA.Migrations
{
    public partial class VersaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_credor = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Data_vencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Val_pagar = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Data_pagamento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contas");
        }
    }
}
