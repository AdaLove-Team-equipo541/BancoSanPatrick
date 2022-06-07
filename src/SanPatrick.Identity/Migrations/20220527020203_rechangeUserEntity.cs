using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanPatrick.Identity.Migrations
{
    public partial class rechangeUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostCode",
                table: "AspNetUsers",
                newName: "Password");

            migrationBuilder.AddColumn<string>(
                name: "AvatarString",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "770a289f-e1be-4cfe-93e7-d70fbd5297a2",
                column: "ConcurrencyStamp",
                value: "bdfc2422-e6c6-451e-b426-49e91b9add04");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "383a363b-fa7e-4f40-9727-9aec581f3901",
                columns: new[] { "AvatarString", "BirthDate", "City", "ConcurrencyStamp", "ConfirmPassword", "Country", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "", "", "", "2d43f939-f851-4266-b200-e1d6194046a2", "", "", "AQAAAAEAACcQAAAAEGqLQDu+wCMwMfJtuFxzZnYZELEKH5ZkKCdZyatiQqq/3NODPZw7hctf0BnDdQFRtA==", "7352096019", "7e093693-aa41-4457-b023-1ffd0a8d51ec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvatarString",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "AspNetUsers",
                newName: "PostCode");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "770a289f-e1be-4cfe-93e7-d70fbd5297a2",
                column: "ConcurrencyStamp",
                value: "e9953f7a-993b-433b-b084-9528e58edc1d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "383a363b-fa7e-4f40-9727-9aec581f3901",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "4b5550a6-3e04-4f4a-b2cc-413b0d210b2c", "AQAAAAEAACcQAAAAEMxkEmOuT/xHFXec7wa2q28PzWFFchQ9e7FN+D5gigBFykLI/iF+dhi8g8QqhAf0yg==", null, "c105118d-c562-455e-b4b8-5d6a50e91890" });
        }
    }
}
