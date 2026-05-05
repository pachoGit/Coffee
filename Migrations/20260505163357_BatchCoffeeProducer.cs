using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coffe.Migrations
{
    /// <inheritdoc />
    public partial class BatchCoffeeProducer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "coffee_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coffee_type", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "coffee_variety",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coffee_variety", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "batch_coffee_producer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    score_sca = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    screen_size = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    coffee_variety_id = table.Column<int>(type: "int", nullable: true),
                    coffee_type_id = table.Column<int>(type: "int", nullable: false),
                    humidity = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    coffee_producer_id = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    CoffeTypeId = table.Column<int>(type: "int", nullable: false),
                    CoffeVarietyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_batch_coffee_producer", x => x.id);
                    table.ForeignKey(
                        name: "FK_batch_coffee_producer_coffee_producer_coffee_producer_id",
                        column: x => x.coffee_producer_id,
                        principalTable: "coffee_producer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_batch_coffee_producer_coffee_type_CoffeTypeId",
                        column: x => x.CoffeTypeId,
                        principalTable: "coffee_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_batch_coffee_producer_coffee_variety_CoffeVarietyId",
                        column: x => x.CoffeVarietyId,
                        principalTable: "coffee_variety",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_batch_coffee_producer_CoffeTypeId",
                table: "batch_coffee_producer",
                column: "CoffeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_batch_coffee_producer_CoffeVarietyId",
                table: "batch_coffee_producer",
                column: "CoffeVarietyId");

            migrationBuilder.CreateIndex(
                name: "IX_batch_coffee_producer_coffee_producer_id",
                table: "batch_coffee_producer",
                column: "coffee_producer_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "batch_coffee_producer");

            migrationBuilder.DropTable(
                name: "coffee_type");

            migrationBuilder.DropTable(
                name: "coffee_variety");
        }
    }
}
