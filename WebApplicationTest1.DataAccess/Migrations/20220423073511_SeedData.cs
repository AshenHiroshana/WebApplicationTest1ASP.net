using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationTest1.DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description", "DueDate", "Status", "Title" },
                values: new object[] { 1, new DateTime(2022, 4, 23, 13, 5, 11, 759, DateTimeKind.Local).AddTicks(4906), "A aa", new DateTime(2022, 4, 28, 13, 5, 11, 759, DateTimeKind.Local).AddTicks(4915), 0, "A" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
