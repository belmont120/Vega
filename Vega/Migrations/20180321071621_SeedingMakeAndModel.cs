using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Vega.Migrations
{
    public partial class SeedingMakeAndModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Ford')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Mazda')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Toyota')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) SELECT 'Focus' Name, M.Id MakeId FROM Makes M WHERE M.Name = 'Ford'");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) SELECT 'Fiesta' Name, M.Id MakeId FROM Makes M WHERE M.Name = 'Ford'");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) SELECT 'Ranger' Name, M.Id MakeId FROM Makes M WHERE M.Name = 'Ford'");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) SELECT 'RX-8' Name, M.Id MakeId FROM Makes M WHERE M.Name = 'Mazda'");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) SELECT 'MX-5' Name, M.Id MakeId FROM Makes M WHERE M.Name = 'Mazda'");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) SELECT '3 Series' Name, M.Id MakeId FROM Makes M WHERE M.Name = 'Mazda'");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) SELECT 'Corolla' Name, M.Id MakeId FROM Makes M WHERE M.Name = 'Toyota'");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) SELECT 'Hilux' Name, M.Id MakeId FROM Makes M WHERE M.Name = 'Toyota'");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) SELECT 'Camry' Name, M.Id MakeId FROM Makes M WHERE M.Name = 'Toyota'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE Models");
            migrationBuilder.Sql("TRUNCATE TABLE Makes");
        }
    }
}
