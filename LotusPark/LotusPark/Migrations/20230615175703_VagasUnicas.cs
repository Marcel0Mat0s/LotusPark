using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LotusPark.Migrations
{
    public partial class VagasUnicas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vagas_Reservas_ReservaFK",
                table: "Vagas");

            migrationBuilder.AlterColumn<int>(
                name: "ReservaFK",
                table: "Vagas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AlterColumn<int>(
                name: "ReservaFK",
                table: "Vagas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
