using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bovino.Application.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoNomeTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bolvinos",
                table: "Bolvinos");

            migrationBuilder.RenameTable(
                name: "Bolvinos",
                newName: "Bovinos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bovinos",
                table: "Bovinos",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bovinos",
                table: "Bovinos");

            migrationBuilder.RenameTable(
                name: "Bovinos",
                newName: "Bolvinos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bolvinos",
                table: "Bolvinos",
                column: "Id");
        }
    }
}
