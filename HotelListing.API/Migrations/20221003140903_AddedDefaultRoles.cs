using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "51b76511-d9b6-40bd-b3ef-3da636e41a3a", "c3cc80c3-2a11-4b42-8747-bfebb409cbc5", "Administrator", "ADMINISTRATOR" },
                    { "b9c7d0c2-8a36-4482-b716-5ea6a5a9a630", "5f8cc964-9aa0-42c5-ba28-90fab1573956", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51b76511-d9b6-40bd-b3ef-3da636e41a3a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9c7d0c2-8a36-4482-b716-5ea6a5a9a630");
        }
    }
}
