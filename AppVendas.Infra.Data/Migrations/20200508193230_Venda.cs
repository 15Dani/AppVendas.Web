using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppVendas.Infra.Data.Migrations
{
    public partial class Venda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    Nm_cliente = table.Column<string>(nullable: true),
                    Dt_venda = table.Column<DateTime>(nullable: false),
                    Endereco = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Sn_ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
