using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDJ_API.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cdj-custumer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(name: "first-name", type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    lastname = table.Column<string>(name: "last-name", type: "VARCHAR(60)", maxLength: 60, nullable: false),
                    phonenumber = table.Column<string>(name: "phone-number", type: "VARCHAR(11)", maxLength: 11, nullable: false),
                    birthdaydate = table.Column<DateOnly>(name: "birthday-date", type: "DATE", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cdj-custumer", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cdj-custumer");
        }
    }
}
