using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace M3S9_jogos.webApi.Migrations
{
    /// <inheritdoc />
    public partial class DtosCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogosos_Estudios_EstudioId",
                table: "Jogosos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jogosos",
                table: "Jogosos");

            migrationBuilder.RenameTable(
                name: "Jogosos",
                newName: "Jogos");

            migrationBuilder.RenameIndex(
                name: "IX_Jogosos_EstudioId",
                table: "Jogos",
                newName: "IX_Jogos_EstudioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jogos",
                table: "Jogos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Estudios_EstudioId",
                table: "Jogos",
                column: "EstudioId",
                principalTable: "Estudios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Estudios_EstudioId",
                table: "Jogos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jogos",
                table: "Jogos");

            migrationBuilder.RenameTable(
                name: "Jogos",
                newName: "Jogosos");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_EstudioId",
                table: "Jogosos",
                newName: "IX_Jogosos_EstudioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jogosos",
                table: "Jogosos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogosos_Estudios_EstudioId",
                table: "Jogosos",
                column: "EstudioId",
                principalTable: "Estudios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
