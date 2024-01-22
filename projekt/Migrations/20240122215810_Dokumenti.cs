using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projekt.Migrations
{
    /// <inheritdoc />
    public partial class Dokumenti : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dokumenti",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    obrazec = table.Column<byte[]>(type: "BLOB", nullable: false),
                    pravnaPodlaga = table.Column<byte[]>(type: "BLOB", nullable: false),
                    dodato = table.Column<byte[]>(type: "BLOB", nullable: false),
                    UporabnikId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dokumenti", x => x.id);
                    table.ForeignKey(
                        name: "FK_Dokumenti_Uporabniki_UporabnikId",
                        column: x => x.UporabnikId,
                        principalTable: "Uporabniki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dokumenti_UporabnikId",
                table: "Dokumenti",
                column: "UporabnikId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dokumenti");
        }
    }
}
