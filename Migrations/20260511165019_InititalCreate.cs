using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coffe.Migrations
{
    /// <inheritdoc />
    public partial class InititalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "coffee_producer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    firstname = table.Column<string>(type: "varchar(140)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lastname = table.Column<string>(type: "varchar(140)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    document_number = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coffee_producer", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "coffee_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(4)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                    code = table.Column<string>(type: "varchar(4)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coffee_variety", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "measurement_unit_coffee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(type: "varchar(5)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_measurement_unit_coffee", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "purchase_coffee_producer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    purchase_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    coffee_producer_id = table.Column<int>(type: "int", nullable: false),
                    total_price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_coffee_producer", x => x.id);
                    table.ForeignKey(
                        name: "FK_purchase_coffee_producer_coffee_producer_coffee_producer_id",
                        column: x => x.coffee_producer_id,
                        principalTable: "coffee_producer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true)
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
                        name: "FK_batch_coffee_producer_coffee_type_coffee_type_id",
                        column: x => x.coffee_type_id,
                        principalTable: "coffee_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_batch_coffee_producer_coffee_variety_coffee_variety_id",
                        column: x => x.coffee_variety_id,
                        principalTable: "coffee_variety",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "detail_purchase_coffee_producer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    purchase_coffee_producer_id = table.Column<int>(type: "int", nullable: false),
                    coffee_producer_id = table.Column<int>(type: "int", nullable: false),
                    batch_coffee_producer_id = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detail_purchase_coffee_producer", x => x.id);
                    table.ForeignKey(
                        name: "FK_detail_purchase_coffee_producer_batch_coffee_producer_batch_~",
                        column: x => x.batch_coffee_producer_id,
                        principalTable: "batch_coffee_producer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detail_purchase_coffee_producer_coffee_producer_coffee_produ~",
                        column: x => x.coffee_producer_id,
                        principalTable: "coffee_producer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detail_purchase_coffee_producer_purchase_coffee_producer_pur~",
                        column: x => x.purchase_coffee_producer_id,
                        principalTable: "purchase_coffee_producer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "purchase_batch_coffee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    measurement_unit_coffee_id = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    coffee_market_price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    batch_purchase_price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    expected_batch_selling_price = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    batch_coffee_producer_id = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_batch_coffee", x => x.id);
                    table.ForeignKey(
                        name: "FK_purchase_batch_coffee_batch_coffee_producer_batch_coffee_pro~",
                        column: x => x.batch_coffee_producer_id,
                        principalTable: "batch_coffee_producer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_purchase_batch_coffee_measurement_unit_coffee_measurement_un~",
                        column: x => x.measurement_unit_coffee_id,
                        principalTable: "measurement_unit_coffee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_batch_coffee_producer_coffee_producer_id",
                table: "batch_coffee_producer",
                column: "coffee_producer_id");

            migrationBuilder.CreateIndex(
                name: "IX_batch_coffee_producer_coffee_type_id",
                table: "batch_coffee_producer",
                column: "coffee_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_batch_coffee_producer_coffee_variety_id",
                table: "batch_coffee_producer",
                column: "coffee_variety_id");

            migrationBuilder.CreateIndex(
                name: "IX_detail_purchase_coffee_producer_batch_coffee_producer_id",
                table: "detail_purchase_coffee_producer",
                column: "batch_coffee_producer_id");

            migrationBuilder.CreateIndex(
                name: "IX_detail_purchase_coffee_producer_coffee_producer_id",
                table: "detail_purchase_coffee_producer",
                column: "coffee_producer_id");

            migrationBuilder.CreateIndex(
                name: "IX_detail_purchase_coffee_producer_purchase_coffee_producer_id",
                table: "detail_purchase_coffee_producer",
                column: "purchase_coffee_producer_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_batch_coffee_batch_coffee_producer_id",
                table: "purchase_batch_coffee",
                column: "batch_coffee_producer_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_purchase_batch_coffee_measurement_unit_coffee_id",
                table: "purchase_batch_coffee",
                column: "measurement_unit_coffee_id");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_coffee_producer_coffee_producer_id",
                table: "purchase_coffee_producer",
                column: "coffee_producer_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detail_purchase_coffee_producer");

            migrationBuilder.DropTable(
                name: "purchase_batch_coffee");

            migrationBuilder.DropTable(
                name: "purchase_coffee_producer");

            migrationBuilder.DropTable(
                name: "batch_coffee_producer");

            migrationBuilder.DropTable(
                name: "measurement_unit_coffee");

            migrationBuilder.DropTable(
                name: "coffee_producer");

            migrationBuilder.DropTable(
                name: "coffee_type");

            migrationBuilder.DropTable(
                name: "coffee_variety");
        }
    }
}
