﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherStation.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherStations",
                columns: table => new
                {
                    WeatherStationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherStations", x => x.WeatherStationId);
                });

            migrationBuilder.InsertData(
                "WeatherStations",
                new[] { "WeatherStationId", "Name" },
                new object[] { Guid.NewGuid(), "Vilnius" });

            migrationBuilder.InsertData(
                "WeatherStations",
                new[] { "WeatherStationId", "Name" },
                new object[] { Guid.NewGuid(), "Kaunas" });

            migrationBuilder.InsertData(
                "WeatherStations",
                new[] { "WeatherStationId", "Name" },
                new object[] { Guid.NewGuid(), "Zarasai" });

            migrationBuilder.InsertData(
                "WeatherStations",
                new[] { "WeatherStationId", "Name" },
                new object[] { Guid.NewGuid(), "Klaipėda" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherStations");
        }
    }
}
