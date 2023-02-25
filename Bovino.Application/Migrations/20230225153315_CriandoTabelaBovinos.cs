using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bovino.Application.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabelaBovinos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolvinos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Brinco = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    BrincoMae = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    BrincoPai = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Raca = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataPrenhes = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataProximoParto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUltimoParto = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolvinos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bolvinos");
        }
    }
}
