using Microsoft.EntityFrameworkCore.Migrations;

namespace pfe.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comptes",
                columns: table => new
                {
                    CompteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CO = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Lib = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    DB = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    CR = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    TypeCompte = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    CompteDB = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    OuvertDB = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    OuvertCR = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comptes", x => x.CompteId);
                });

            migrationBuilder.CreateTable(
                name: "DepBancaires",
                columns: table => new
                {
                    DepBanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    NCH = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    CO = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Tiers = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Montant = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    MVT = table.Column<string>(type: "nvarchar(8)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepBancaires", x => x.DepBanId);
                });

            migrationBuilder.CreateTable(
                name: "DepCaisses",
                columns: table => new
                {
                    DepBanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Recu = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    CO = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Tiers = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Montant = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    MVT = table.Column<string>(type: "nvarchar(8)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepCaisses", x => x.DepBanId);
                });

            migrationBuilder.CreateTable(
                name: "RecBancaires",
                columns: table => new
                {
                    DepBanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    NCH = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    CO = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Tiers = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Montant = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    MVT = table.Column<string>(type: "nvarchar(8)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecBancaires", x => x.DepBanId);
                });

            migrationBuilder.CreateTable(
                name: "RecCaisses",
                columns: table => new
                {
                    DepBanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Recu = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    CO = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Tiers = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Montant = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    MVT = table.Column<string>(type: "nvarchar(8)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecCaisses", x => x.DepBanId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comptes");

            migrationBuilder.DropTable(
                name: "DepBancaires");

            migrationBuilder.DropTable(
                name: "DepCaisses");

            migrationBuilder.DropTable(
                name: "RecBancaires");

            migrationBuilder.DropTable(
                name: "RecCaisses");
        }
    }
}
