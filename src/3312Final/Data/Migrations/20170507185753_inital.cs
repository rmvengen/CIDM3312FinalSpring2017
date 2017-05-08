using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _3312Final.Data.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airplane",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Altitude = table.Column<int>(nullable: false),
                    FlapSetting = table.Column<int>(nullable: false),
                    Ice = table.Column<bool>(nullable: false),
                    Rain = table.Column<bool>(nullable: false),
                    RunwayDirection = table.Column<int>(nullable: false),
                    Snow = table.Column<bool>(nullable: false),
                    TripDistance = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    WindDirection = table.Column<int>(nullable: false),
                    WindSpeed = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airplane", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airplane");
        }
    }
}
