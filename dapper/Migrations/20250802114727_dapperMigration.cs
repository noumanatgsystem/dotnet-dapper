using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dapperwebapi.Migrations
{
    /// <inheritdoc />
    public partial class dapperMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dapper",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dapper", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dapper");
        }
    }
}
