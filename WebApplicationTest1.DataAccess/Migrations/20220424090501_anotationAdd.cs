using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationTest1.DataAccess.Migrations
{
    public partial class anotationAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AddressNo",
                table: "Authors",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Authors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Authors",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "2", "col1", "3" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressNo", "City", "FullName", "Street" },
                values: new object[] { "4", "Gam", "Indeera Hiroshana", "2" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "AddressNo", "City", "FullName", "Street" },
                values: new object[] { 3, "2", "col1", "Salika Hiroshana", "3" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "DueDate" },
                values: new object[] { new DateTime(2022, 4, 24, 14, 35, 0, 728, DateTimeKind.Local).AddTicks(2654), new DateTime(2022, 4, 29, 14, 35, 0, 728, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "DueDate" },
                values: new object[] { new DateTime(2022, 4, 24, 14, 35, 0, 728, DateTimeKind.Local).AddTicks(2674), new DateTime(2022, 4, 29, 14, 35, 0, 728, DateTimeKind.Local).AddTicks(2675) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AddressNo",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Authors");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "FullName",
                value: "Shalika Hiroshana");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "DueDate" },
                values: new object[] { new DateTime(2022, 4, 24, 13, 49, 1, 714, DateTimeKind.Local).AddTicks(1458), new DateTime(2022, 4, 29, 13, 49, 1, 714, DateTimeKind.Local).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "DueDate" },
                values: new object[] { new DateTime(2022, 4, 24, 13, 49, 1, 714, DateTimeKind.Local).AddTicks(1479), new DateTime(2022, 4, 29, 13, 49, 1, 714, DateTimeKind.Local).AddTicks(1480) });
        }
    }
}
