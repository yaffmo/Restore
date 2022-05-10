using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class addroleanduser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2428be8d-9def-4fcc-a625-accdeef0b635");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fadea152-ccb5-42c7-aa6e-b5b2e08c6bd4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62be339c-9e17-43cb-9350-4ba803687bbc", "e59e7eb4-2628-4f15-92c1-3318487565b6", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8d9c6fdd-7b86-4683-8e4f-1e6c7bfc9f7d", "90d09135-7fbe-493b-b822-152ee0c25454", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1f24e70d-1f4d-47ce-8448-ddd6d7605881", 0, "a4744420-36f9-484f-b0c0-0ac26aa6878f", null, false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAENMt1O47+jrJNKnRcyeKK9iafJodQpVJTfk8+w3lmi2hU273fbqKe/lzATSi7ijG0A==", null, false, "583ab2ca-ff40-4ecc-a039-bfe59a5a409d", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "90ff3c02-b762-4750-9aea-12605dc03829", 0, "284b713f-a852-43ec-a58d-452b0f7b8a67", null, false, false, null, null, "MEMBER", "AQAAAAEAACcQAAAAEB/K4agx/XbB7mVt9CV7Hk2soj7D+276us5dHK74Tc1tTxEDVJklAN4fBAMp5E2/eA==", null, false, "66b3b4d5-e265-4fb7-85a1-398f8523dc00", false, "user" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62be339c-9e17-43cb-9350-4ba803687bbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d9c6fdd-7b86-4683-8e4f-1e6c7bfc9f7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f24e70d-1f4d-47ce-8448-ddd6d7605881");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90ff3c02-b762-4750-9aea-12605dc03829");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2428be8d-9def-4fcc-a625-accdeef0b635", "9614b53f-5cb5-4c6e-859d-dd72f41ae136", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fadea152-ccb5-42c7-aa6e-b5b2e08c6bd4", "d95c3ed4-afeb-4f04-9a19-c2589d7b2e5a", "Member", "MEMBER" });
        }
    }
}
