using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LotusPark.Data.Migrations
{
    public partial class ReservasVagas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vagas_Reservas_ReservaFK",
                table: "Vagas");

            migrationBuilder.AddForeignKey(
                name: "FK_Vagas_Reservas_ReservaFK",
                table: "Vagas",
                column: "ReservaFK",
                principalTable: "Reservas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vagas_Reservas_ReservaFK",
                table: "Vagas");

            migrationBuilder.AddForeignKey(
                name: "FK_Vagas_Reservas_ReservaFK",
                table: "Vagas",
                column: "ReservaFK",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
