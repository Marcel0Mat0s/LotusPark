using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LotusPark.Data.Migrations
{
    public partial class VagasCorretion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Vagas_Estados_EstadoFK",
            //    table: "Vagas");

            migrationBuilder.AlterColumn<int>(
                name: "EstadoFK",
                table: "Vagas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Vagas_Estados_EstadoFK",
                table: "Vagas",
                column: "EstadoFK",
                principalTable: "Estados",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vagas_Estados_EstadoFK",
                table: "Vagas");

            migrationBuilder.AlterColumn<int>(
                name: "EstadoFK",
                table: "Vagas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vagas_Estados_EstadoFK",
                table: "Vagas",
                column: "EstadoFK",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
