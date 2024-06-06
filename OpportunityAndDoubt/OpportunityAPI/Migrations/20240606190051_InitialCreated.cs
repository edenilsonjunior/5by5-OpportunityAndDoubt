using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpportunityAPI.Migrations
{
    public partial class InitialCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Opportunity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SurgeLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoursQuantity = table.Column<int>(type: "int", nullable: false),
                    ErrorsQuantity = table.Column<long>(type: "bigint", nullable: false),
                    LearningLevel = table.Column<long>(type: "bigint", nullable: false),
                    HoursOfSleep = table.Column<long>(type: "bigint", nullable: false),
                    HoursOff = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opportunity", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Opportunity");
        }
    }
}
