using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FirstTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Com_Commande",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCommande = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefCommande = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    MontantHT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Taxe = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MontantTTC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LasetUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCreateur = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Com_Commande", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pr_Produit",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prix = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LasetUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCreateur = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pr_Produit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Com_CommandeDetail",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCommande = table.Column<int>(type: "int", nullable: false),
                    IdProduit = table.Column<int>(type: "int", nullable: false),
                    PU = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qnt = table.Column<int>(type: "int", nullable: false),
                    Montant = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LasetUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCreateur = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Com_CommandeDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Com_CommandeDetail_Com_Commande_IdCommande",
                        column: x => x.IdCommande,
                        principalSchema: "dbo",
                        principalTable: "Com_Commande",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Com_CommandeDetail_IdCommande",
                schema: "dbo",
                table: "Com_CommandeDetail",
                column: "IdCommande");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Com_CommandeDetail",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Pr_Produit",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Com_Commande",
                schema: "dbo");
        }
    }
}
