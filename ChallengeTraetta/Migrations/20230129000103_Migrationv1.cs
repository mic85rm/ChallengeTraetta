using Microsoft.EntityFrameworkCore.Migrations;

namespace ChallengeTraetta.Migrations
{
    public partial class Migrationv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaMerceologica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCategoria = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaMerceologica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Compagnia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCompagnia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compagnia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoContatto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContatto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prodotto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProdotto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantitaProdotto = table.Column<int>(type: "int", nullable: false),
                    CategoriaMerceologicaId = table.Column<int>(type: "int", nullable: false),
                    CompagniaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prodotto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prodotto_CategoriaMerceologica_CategoriaMerceologicaId",
                        column: x => x.CategoriaMerceologicaId,
                        principalTable: "CategoriaMerceologica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Indirizzo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Via = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NCivico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompagniaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indirizzo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Indirizzo_Compagnia_CompagniaID",
                        column: x => x.CompagniaID,
                        principalTable: "Compagnia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MezzoDiContatto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoContattoID = table.Column<int>(type: "int", nullable: false),
                    IndirizzoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MezzoDiContatto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MezzoDiContatto_Indirizzo_IndirizzoID",
                        column: x => x.IndirizzoID,
                        principalTable: "Indirizzo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MezzoDiContatto_TipoContatto_TipoContattoID",
                        column: x => x.TipoContattoID,
                        principalTable: "TipoContatto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Indirizzo_CompagniaID",
                table: "Indirizzo",
                column: "CompagniaID");

            migrationBuilder.CreateIndex(
                name: "IX_MezzoDiContatto_IndirizzoID",
                table: "MezzoDiContatto",
                column: "IndirizzoID");

            migrationBuilder.CreateIndex(
                name: "IX_MezzoDiContatto_TipoContattoID",
                table: "MezzoDiContatto",
                column: "TipoContattoID");

            migrationBuilder.CreateIndex(
                name: "IX_Prodotto_CategoriaMerceologicaId",
                table: "Prodotto",
                column: "CategoriaMerceologicaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MezzoDiContatto");

            migrationBuilder.DropTable(
                name: "Prodotto");

            migrationBuilder.DropTable(
                name: "Indirizzo");

            migrationBuilder.DropTable(
                name: "TipoContatto");

            migrationBuilder.DropTable(
                name: "CategoriaMerceologica");

            migrationBuilder.DropTable(
                name: "Compagnia");
        }
    }
}
