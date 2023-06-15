using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LotusPark.Data.Migrations
{
    public partial class LotusPark2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) {
            //migrationBuilder.CreateTable(
            //    name: "Clientes",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        NIF = table.Column<int>(type: "int", nullable: false),
            //        Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CodPostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Morada = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Clientes", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Funcionarios",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        NIF = table.Column<int>(type: "int", nullable: false),
            //        Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CodPostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Morada = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Funcionarios", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Reservas",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        DataSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ClienteFK = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Reservas", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Reservas_Clientes_ClienteFK",
            //            column: x => x.ClienteFK,
            //            principalTable: "Clientes",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FuncionariosReservas",
            //    columns: table => new
            //    {
            //        ListaFuncionarioId = table.Column<int>(type: "int", nullable: false),
            //        ListaReservasId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FuncionariosReservas", x => new { x.ListaFuncionarioId, x.ListaReservasId });
            //        table.ForeignKey(
            //            name: "FK_FuncionariosReservas_Funcionarios_ListaFuncionarioId",
            //            column: x => x.ListaFuncionarioId,
            //            principalTable: "Funcionarios",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_FuncionariosReservas_Reservas_ListaReservasId",
            //            column: x => x.ListaReservasId,
            //            principalTable: "Reservas",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Vagas",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ReservaFK = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Vagas", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Vagas_Reservas_ReservaFK",
            //            column: x => x.ReservaFK,
            //            principalTable: "Reservas",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_FuncionariosReservas_ListaReservasId",
            //    table: "FuncionariosReservas",
            //    column: "ListaReservasId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Reservas_ClienteFK",
            //    table: "Reservas",
            //    column: "ClienteFK");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vagas_ReservaFK",
            //    table: "Vagas",
            //    column: "ReservaFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FuncionariosReservas");

            migrationBuilder.DropTable(
                name: "Vagas");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
