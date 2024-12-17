using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDJ_API.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cdj-produtos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productname = table.Column<string>(name: "product-name", type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    unittype = table.Column<string>(name: "unit-type", type: "VARCHAR(5)", maxLength: 5, nullable: false),
                    unitcount = table.Column<int>(name: "unit-count", type: "INT", nullable: false),
                    unitprice = table.Column<decimal>(name: "unit-price", type: "SMALLMONEY", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cdj-produtos", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cdj-produtos");
        }
    }
}
