using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital.Persistencia.Migrations
{
    public partial class P2migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnfermeraId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HorasLaborables",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TarjetaProfesional",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EnfermeraId",
                table: "Personas",
                column: "EnfermeraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_EnfermeraId",
                table: "Personas",
                column: "EnfermeraId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_EnfermeraId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_EnfermeraId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "EnfermeraId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "HorasLaborables",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TarjetaProfesional",
                table: "Personas");
        }
    }
}
