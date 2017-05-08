using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _3312Final.Data.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClimbData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Vclmb = table.Column<int>(nullable: false),
                    Vfri10 = table.Column<int>(nullable: false),
                    Vfri15 = table.Column<int>(nullable: false),
                    Vfri5 = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClimbData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flap10Landing",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Vapp = table.Column<int>(nullable: false),
                    Vga = table.Column<int>(nullable: false),
                    Vref = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flap10Landing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flap5Landing",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Vapp = table.Column<int>(nullable: false),
                    Vga = table.Column<int>(nullable: false),
                    Vref = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flap5Landing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flaps15Landing",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Vapp = table.Column<int>(nullable: false),
                    Vga = table.Column<int>(nullable: false),
                    Vref = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flaps15Landing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flaps35Landing",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Vapp = table.Column<int>(nullable: false),
                    Vga = table.Column<int>(nullable: false),
                    Vref = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flaps35Landing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flaps5Takeoff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Altitude = table.Column<int>(nullable: false),
                    OAT = table.Column<int>(nullable: false),
                    V2 = table.Column<int>(nullable: false),
                    Vr = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flaps5Takeoff", x => x.Id);
                });

            migrationBuilder.AddColumn<string>(
                name: "Pilot",
                table: "Airplane",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pilot",
                table: "Airplane");

            migrationBuilder.DropTable(
                name: "ClimbData");

            migrationBuilder.DropTable(
                name: "Flap10Landing");

            migrationBuilder.DropTable(
                name: "Flap5Landing");

            migrationBuilder.DropTable(
                name: "Flaps15Landing");

            migrationBuilder.DropTable(
                name: "Flaps35Landing");

            migrationBuilder.DropTable(
                name: "Flaps5Takeoff");
        }
    }
}
