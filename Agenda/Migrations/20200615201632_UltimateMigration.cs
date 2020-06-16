using Microsoft.EntityFrameworkCore.Migrations;

namespace Agenda.Migrations
{
    public partial class UltimateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Genero = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    ComplementoC = table.Column<string>(nullable: true),
                    numero = table.Column<string>(nullable: true),
                    cep = table.Column<string>(nullable: true),
                    logradouro = table.Column<string>(nullable: true),
                    complemento = table.Column<string>(nullable: true),
                    bairro = table.Column<string>(nullable: true),
                    localidade = table.Column<string>(nullable: true),
                    uf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientesHospedados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    DiasHospedados = table.Column<string>(nullable: true),
                    DataHospedagem = table.Column<string>(nullable: true),
                    ValorHosp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesHospedados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "hospedagem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Quarto = table.Column<string>(nullable: true),
                    Estadia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hospedagem", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "ClientesHospedados");

            migrationBuilder.DropTable(
                name: "hospedagem");
        }
    }
}
