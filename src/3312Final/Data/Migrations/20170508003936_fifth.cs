using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3312Final.Data.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OutsideAirTemp",
                table: "Airplane",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OutsideAirTemp",
                table: "Airplane");
        }
    }
}
