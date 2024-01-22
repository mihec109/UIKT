using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projekt.Migrations
{
    /// <inheritdoc />
    public partial class Dokumenti2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dokumenti_Uporabniki_UporabnikId",
                table: "Dokumenti");

            migrationBuilder.DropIndex(
                name: "IX_Dokumenti_UporabnikId",
                table: "Dokumenti");

            migrationBuilder.RenameColumn(
                name: "UporabnikId",
                table: "Dokumenti",
                newName: "Uporabnik");

            migrationBuilder.AddColumn<int>(
                name: "UporabnikModelId",
                table: "Dokumenti",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dokumenti_UporabnikModelId",
                table: "Dokumenti",
                column: "UporabnikModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dokumenti_Uporabniki_UporabnikModelId",
                table: "Dokumenti",
                column: "UporabnikModelId",
                principalTable: "Uporabniki",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dokumenti_Uporabniki_UporabnikModelId",
                table: "Dokumenti");

            migrationBuilder.DropIndex(
                name: "IX_Dokumenti_UporabnikModelId",
                table: "Dokumenti");

            migrationBuilder.DropColumn(
                name: "UporabnikModelId",
                table: "Dokumenti");

            migrationBuilder.RenameColumn(
                name: "Uporabnik",
                table: "Dokumenti",
                newName: "UporabnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Dokumenti_UporabnikId",
                table: "Dokumenti",
                column: "UporabnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dokumenti_Uporabniki_UporabnikId",
                table: "Dokumenti",
                column: "UporabnikId",
                principalTable: "Uporabniki",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
