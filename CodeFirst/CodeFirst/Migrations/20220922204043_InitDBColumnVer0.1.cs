using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.Migrations
{
    public partial class InitDBColumnVer01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Cli_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cli_Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cli_Apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cli_Tel = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    Cli_Direccion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Cli_Status = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Cli_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
