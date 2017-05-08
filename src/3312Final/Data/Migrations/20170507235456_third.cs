using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3312Final.Data.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "DirectionalWind",
                table: "Airplane",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "Headwind",
                table: "Airplane",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<double>(
                name: "WindDirection",
                table: "Airplane",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DirectionalWind",
                table: "Airplane");

            migrationBuilder.DropColumn(
                name: "Headwind",
                table: "Airplane");

            migrationBuilder.AlterColumn<int>(
                name: "WindDirection",
                table: "Airplane",
                nullable: false);
        }
    }
}
