using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class addemail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "45bd6e22-135c-4bea-b109-2d97366d9afe", "250ecb96-6509-428e-9365-75a15408a6ce", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa9f6713-90ae-48e0-8925-f7ea7eaed599", "8699961a-bf85-4b83-8bed-9de5eb51f1c4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2acd16a0-d99a-453c-8515-f10fd8e73980", 0, "c7f86c23-a0bf-439f-9731-03b051e17a15", "admin@test.com", false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEIKvPm/C2Wiqi7fL8kQpN9ITG7pCYf5TM3wzQZPeaHzcV3OfQuOpPsYGK6VKwwEivg==", null, false, "4c175a20-5aa0-4580-85fb-e6ffdd413314", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d5f94269-ac03-4442-ad63-bb9101c75ab0", 0, "6cd189f3-701d-4970-9684-fe7a341db01b", "user@test.com", false, false, null, null, "MEMBER", "AQAAAAEAACcQAAAAEGNJ3hVzx7yNP/GYScCIGkC4CaelCbZGXDlMT9zYrUjtptSyb6LM1WBEeVburpTdSw==", null, false, "e4f2fd2c-2d6d-4f6c-a700-578694b902fd", false, "user" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45bd6e22-135c-4bea-b109-2d97366d9afe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa9f6713-90ae-48e0-8925-f7ea7eaed599");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2acd16a0-d99a-453c-8515-f10fd8e73980");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5f94269-ac03-4442-ad63-bb9101c75ab0");

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
    }
}
