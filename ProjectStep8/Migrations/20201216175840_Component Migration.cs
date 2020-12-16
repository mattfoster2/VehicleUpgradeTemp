using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectStep8.Migrations
{
    public partial class ComponentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PurchaseDate",
                table: "Vehicle",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Component",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    VehicleId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ComponentName = table.Column<string>(nullable: true),
                    ComponentCategory = table.Column<string>(nullable: true),
                    ComponentCondition = table.Column<string>(nullable: true),
                    ReplacedMileage = table.Column<int>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: true),
                    ComponentCost = table.Column<decimal>(nullable: false),
                    ComponentManufacturer = table.Column<string>(nullable: true),
                    PurchaseVendor = table.Column<string>(nullable: true),
                    LaborCost = table.Column<decimal>(nullable: false),
                    WarrantyExpiration = table.Column<DateTime>(nullable: true),
                    AftermarketOrOem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Component", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Component_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_EmailAddress",
                table: "User",
                column: "EmailAddress",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Component_VehicleId",
                table: "Component",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Component");

            migrationBuilder.DropIndex(
                name: "IX_User_EmailAddress",
                table: "User");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PurchaseDate",
                table: "Vehicle",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
