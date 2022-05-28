using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanPatrick.Identity.Migrations
{
    public partial class ChangeUserNameToEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "770a289f-e1be-4cfe-93e7-d70fbd5297a2",
                column: "ConcurrencyStamp",
                value: "af200b87-cfff-49a0-a3da-d3f7cf7e8edd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "383a363b-fa7e-4f40-9727-9aec581f3901",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6f8a6f4-74da-4b6b-8ba1-725cc4543bfe", "AQAAAAEAACcQAAAAELkn07jng3Z04sb1KXoTu4HThv3FnhH0s4MS1xaA+uQkqi/HG7hOVXd+G3AFiHBHFw==", "8088261c-db91-44f7-9f01-1ccf0b906fdf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
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
                columns: new[] { "ConcurrencyStamp", "ConfirmPassword", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d43f939-f851-4266-b200-e1d6194046a2", "", "AQAAAAEAACcQAAAAEGqLQDu+wCMwMfJtuFxzZnYZELEKH5ZkKCdZyatiQqq/3NODPZw7hctf0BnDdQFRtA==", "7e093693-aa41-4457-b023-1ffd0a8d51ec" });
        }
    }
}
