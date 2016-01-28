using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace CampPlanner.Migrations
{
    public partial class addCampPlannerUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Camp",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Camp",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "EndDate", table: "Camp");
            migrationBuilder.DropColumn(name: "StartDate", table: "Camp");
        }
    }
}
