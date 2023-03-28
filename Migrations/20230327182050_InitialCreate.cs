using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StaffApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    EmployerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(type: "TEXT", nullable: true),
                    Prenom = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<string>(type: "TEXT", nullable: true),
                    Salaire = table.Column<string>(type: "TEXT", nullable: true),
                    Poste = table.Column<string>(type: "TEXT", nullable: true),
                    Transport = table.Column<bool>(type: "INTEGER", nullable: false),
                    Cantine = table.Column<bool>(type: "INTEGER", nullable: false),
                    Caps = table.Column<bool>(type: "INTEGER", nullable: false),
                    Ostie = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.EmployerID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employers");
        }
    }
}
