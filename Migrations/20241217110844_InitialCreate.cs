using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nepremicnine__.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uporabniki",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ime = table.Column<string>(type: "TEXT", nullable: false),
                    DatumRojstva = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Geslo = table.Column<string>(type: "TEXT", nullable: false),
                    TipUporabnika = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uporabniki", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nepremicnine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naziv = table.Column<string>(type: "TEXT", nullable: false),
                    Naslov = table.Column<string>(type: "TEXT", nullable: false),
                    Posta = table.Column<string>(type: "TEXT", nullable: false),
                    PostnaSt = table.Column<int>(type: "INTEGER", nullable: false),
                    Povrsina = table.Column<double>(type: "REAL", nullable: false),
                    Vrednost = table.Column<double>(type: "REAL", nullable: false),
                    LetoIzgradnje = table.Column<int>(type: "INTEGER", nullable: false),
                    LastnikId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nepremicnine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nepremicnine_Uporabniki_LastnikId",
                        column: x => x.LastnikId,
                        principalTable: "Uporabniki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oglasi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DatumObjave = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DatumPoteka = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NepremicninaId = table.Column<int>(type: "INTEGER", nullable: false),
                    ObjavilId = table.Column<int>(type: "INTEGER", nullable: false),
                    TipOglasa = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oglasi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oglasi_Nepremicnine_NepremicninaId",
                        column: x => x.NepremicninaId,
                        principalTable: "Nepremicnine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oglasi_Uporabniki_ObjavilId",
                        column: x => x.ObjavilId,
                        principalTable: "Uporabniki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pogodbe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdNepremicnine = table.Column<int>(type: "INTEGER", nullable: false),
                    NepremicninaId = table.Column<int>(type: "INTEGER", nullable: false),
                    NajemnikId = table.Column<int>(type: "INTEGER", nullable: false),
                    NajemodajalecId = table.Column<int>(type: "INTEGER", nullable: false),
                    DatumSklenitve = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ZnesekNajemnine = table.Column<double>(type: "REAL", nullable: false),
                    ZnesekVarscine = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pogodbe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pogodbe_Nepremicnine_NepremicninaId",
                        column: x => x.NepremicninaId,
                        principalTable: "Nepremicnine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pogodbe_Uporabniki_NajemnikId",
                        column: x => x.NajemnikId,
                        principalTable: "Uporabniki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pogodbe_Uporabniki_NajemodajalecId",
                        column: x => x.NajemodajalecId,
                        principalTable: "Uporabniki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Placila",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Mesec = table.Column<int>(type: "INTEGER", nullable: false),
                    PogodbaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Znesek = table.Column<double>(type: "REAL", nullable: false),
                    PlaciloIdZunanji = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placila", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Placila_Pogodbe_PogodbaId",
                        column: x => x.PogodbaId,
                        principalTable: "Pogodbe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nepremicnine_LastnikId",
                table: "Nepremicnine",
                column: "LastnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Oglasi_NepremicninaId",
                table: "Oglasi",
                column: "NepremicninaId");

            migrationBuilder.CreateIndex(
                name: "IX_Oglasi_ObjavilId",
                table: "Oglasi",
                column: "ObjavilId");

            migrationBuilder.CreateIndex(
                name: "IX_Placila_PogodbaId",
                table: "Placila",
                column: "PogodbaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pogodbe_NajemnikId",
                table: "Pogodbe",
                column: "NajemnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Pogodbe_NajemodajalecId",
                table: "Pogodbe",
                column: "NajemodajalecId");

            migrationBuilder.CreateIndex(
                name: "IX_Pogodbe_NepremicninaId",
                table: "Pogodbe",
                column: "NepremicninaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oglasi");

            migrationBuilder.DropTable(
                name: "Placila");

            migrationBuilder.DropTable(
                name: "Pogodbe");

            migrationBuilder.DropTable(
                name: "Nepremicnine");

            migrationBuilder.DropTable(
                name: "Uporabniki");
        }
    }
}
