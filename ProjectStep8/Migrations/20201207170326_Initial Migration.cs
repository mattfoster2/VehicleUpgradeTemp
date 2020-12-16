using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectStep8.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailAddress = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Make = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Trim = table.Column<string>(nullable: true),
                    Mileage = table.Column<int>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    EngineType = table.Column<string>(nullable: true),
                    EngineDescription = table.Column<string>(nullable: true),
                    Horsepower = table.Column<string>(nullable: true),
                    Torque = table.Column<string>(nullable: true),
                    TransmissionType = table.Column<string>(nullable: true),
                    DrivetrainType = table.Column<string>(nullable: true),
                    SteeringType = table.Column<string>(nullable: true),
                    FrontSuspensionType = table.Column<string>(nullable: true),
                    RearSuspensionType = table.Column<string>(nullable: true),
                    BrakeType = table.Column<string>(nullable: true),
                    AboutVehicle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
