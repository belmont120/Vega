using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Vega.Migrations
{
    public partial class SeedingFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES('ABS')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES('ESP')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES('Traction Control')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES('V8 Engine')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES('Auto Headlight')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES('Automatic')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE Features");
        }
    }
}
