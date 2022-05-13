using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.FormUI.Migrations
{
    public partial class SigmaDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SigmaDates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    StepOneDate = table.Column<int>(type: "int", nullable: false),
                    StepTwoDate = table.Column<int>(type: "int", nullable: false),
                    StepThreeDate = table.Column<int>(type: "int", nullable: false),
                    StepFourDate = table.Column<int>(type: "int", nullable: false),
                    StepFiveDate = table.Column<int>(type: "int", nullable: false),
                    StepSixDate = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValue: new Guid("5b4be8b8-a338-4446-ac09-36864dfdbe8d")),
                    UpdatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SigmaDates", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SigmaDates");
        }
    }
}
