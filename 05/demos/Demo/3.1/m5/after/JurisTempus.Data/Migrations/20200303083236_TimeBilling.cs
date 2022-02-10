using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JurisTempus.Data.Migrations
{
    public partial class TimeBilling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TimeBills",
                columns: new[] { "Id", "CaseId", "EmployeeId", "InvoiceId", "Rate", "TimeSegments", "WorkDate", "WorkDescription" },
                values: new object[] { 1, 1, 1, null, 175.00m, 5, new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "Entered data for the client" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TimeBills",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
