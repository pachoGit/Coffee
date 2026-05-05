using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coffe.Migrations
{
    /// <inheritdoc />
    public partial class AddCodeForVarietyAndTypeCoffee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "coffee_variety",
                type: "varchar(4)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "coffee_type",
                type: "varchar(4)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "code",
                table: "coffee_variety");

            migrationBuilder.DropColumn(
                name: "code",
                table: "coffee_type");
        }
    }
}
