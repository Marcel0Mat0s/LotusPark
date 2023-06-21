using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LotusPark.Data.Migrations
{
    public partial class Testing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropTable(
                name: "ReservasVagas");*/

            /*migrationBuilder.AddColumn<int>(
                name: "ReservaFK",
                table: "Vagas",
                type: "int",
                nullable: false,
                defaultValue: 0);*/

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Funcionarios",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Funcionarios",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NIF",
                table: "Funcionarios",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Morada",
                table: "Funcionarios",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Funcionarios",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CodPostal",
                table: "Funcionarios",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Cargo",
                table: "Funcionarios",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            /*migrationBuilder.CreateIndex(
                name: "IX_Vagas_ReservaFK",
                table: "Vagas",
                column: "ReservaFK");*/

            /*migrationBuilder.AddForeignKey(
                name: "FK_Vagas_Reservas_ReservaFK",
                table: "Vagas",
                column: "ReservaFK",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vagas_Reservas_ReservaFK",
                table: "Vagas");

            migrationBuilder.DropIndex(
                name: "IX_Vagas_ReservaFK",
                table: "Vagas");

            migrationBuilder.DropColumn(
                name: "ReservaFK",
                table: "Vagas");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "NIF",
                table: "Funcionarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "Morada",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "CodPostal",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Cargo",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateTable(
                name: "ReservasVagas",
                columns: table => new
                {
                    ListaReservasId = table.Column<int>(type: "int", nullable: false),
                    ListaVagasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservasVagas", x => new { x.ListaReservasId, x.ListaVagasId });
                    table.ForeignKey(
                        name: "FK_ReservasVagas_Reservas_ListaReservasId",
                        column: x => x.ListaReservasId,
                        principalTable: "Reservas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservasVagas_Vagas_ListaVagasId",
                        column: x => x.ListaVagasId,
                        principalTable: "Vagas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservasVagas_ListaVagasId",
                table: "ReservasVagas",
                column: "ListaVagasId");
        }
    }
}
