using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace inSooqWebsite.Services.Migrations
{
    /// <inheritdoc />
    public partial class updateInUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 3, 17, 3, 13, 381, DateTimeKind.Local).AddTicks(3499));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 2, 2, 39, 55, 436, DateTimeKind.Local).AddTicks(8166));
        }
    }
}
