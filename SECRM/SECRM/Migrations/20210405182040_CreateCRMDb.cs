using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SECRM.Migrations
{
    public partial class CreateCRMDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Machine = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Catalog = table.Column<string>(type: "TEXT", nullable: true),
                    Number = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "Embroideries",
                columns: table => new
                {
                    EmbroideryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Image = table.Column<byte[]>(type: "BLOB", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    StitchesQty = table.Column<int>(type: "INTEGER", nullable: false),
                    ProgrammingPrice = table.Column<double>(type: "REAL", nullable: false),
                    FrontPrice = table.Column<double>(type: "REAL", nullable: false),
                    BackPrice = table.Column<double>(type: "REAL", nullable: false),
                    FrontHight = table.Column<int>(type: "INTEGER", nullable: false),
                    FrontWidth = table.Column<int>(type: "INTEGER", nullable: false),
                    BackHeight = table.Column<int>(type: "INTEGER", nullable: false),
                    BackWidth = table.Column<int>(type: "INTEGER", nullable: false),
                    Observations = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Embroideries", x => x.EmbroideryId);
                });

            migrationBuilder.CreateTable(
                name: "EmbroideryColors",
                columns: table => new
                {
                    EmbroideryColorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmbroideryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ColorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Order = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmbroideryColors", x => x.EmbroideryColorId);
                    table.ForeignKey(
                        name: "FK_EmbroideryColors_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmbroideryColors_Embroideries_EmbroideryId",
                        column: x => x.EmbroideryId,
                        principalTable: "Embroideries",
                        principalColumn: "EmbroideryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmbroideryColors_ColorId",
                table: "EmbroideryColors",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_EmbroideryColors_EmbroideryId",
                table: "EmbroideryColors",
                column: "EmbroideryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "EmbroideryColors");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Embroideries");
        }
    }
}
