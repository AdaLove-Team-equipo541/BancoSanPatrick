using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanPatrick.Identity.Migrations
{
    public partial class ChangeRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "770a289f-e1be-4cfe-93e7-d70fbd5297a2",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1d94d2b-095d-40f3-bb18-41dafbd0675c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "770a289f-e1be-4cfe-93e7-d70fbd5297a3", "a9f0dbd9-0e29-48ca-9b2b-e59ba536e3fb", "Employee", "EMPLOYEE" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "383a363b-fa7e-4f40-9727-9aec581f3901",
                columns: new[] { "Citizenship", "ConcurrencyStamp", "Email", "FirstName", "LastName", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Sudafricano", "e3800ded-6f49-4842-abfa-b4d66f795c65", "customer@mail.com", "Elon", "", "Musk", "CUSTOMER@MAIL.COM", "CUSTOMER@MAIL.COM", "AQAAAAEAACcQAAAAEKEyQom7/kzXUb+5bxAVoAleEgpQmP/oernPKrTUAOLf2xMsP1Ti6XP/TfAaG9DUYg==", "bdd9cbca-f77d-4372-bd61-5e8cb3bc7a3e", "customer@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarString", "BirthDate", "Citizenship", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MaritalStatus", "MiddleName", "NormalizedEmail", "NormalizedUserName", "Occupation", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "383a363b-fa7e-4f40-9727-9aec581f3922", 0, "", "", "", "Estadounidense", "", "61a2e24d-365a-4e83-9ba7-d39bc18755ab", "", "employee@mail.com", true, "Jeff", "", false, null, 0, "Bezos", "EMPLOYEE@MAIL.COM", "EMPLOYEE@MAIL.COM", "", "", "AQAAAAEAACcQAAAAEFB8a1bQtmIEWpnWtET9L0YgQi2ckry8GIb+6XzE5ImFJuUyd1wouOE7Ah0bSgVNuQ==", "7352096019", true, "3c22b24a-11cd-400b-8fa6-dfbdd6210f9b", false, "employee@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "770a289f-e1be-4cfe-93e7-d70fbd5297a3", "383a363b-fa7e-4f40-9727-9aec581f3922" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "770a289f-e1be-4cfe-93e7-d70fbd5297a3", "383a363b-fa7e-4f40-9727-9aec581f3922" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "770a289f-e1be-4cfe-93e7-d70fbd5297a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "383a363b-fa7e-4f40-9727-9aec581f3922");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "770a289f-e1be-4cfe-93e7-d70fbd5297a2",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af200b87-cfff-49a0-a3da-d3f7cf7e8edd", "BasicCustomer", "BasicCustomer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "383a363b-fa7e-4f40-9727-9aec581f3901",
                columns: new[] { "Citizenship", "ConcurrencyStamp", "Email", "FirstName", "LastName", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Mexicana", "e6f8a6f4-74da-4b6b-8ba1-725cc4543bfe", "basic@mail.com", "Jose", "Sandoval", "Luis", "basic@mail.com", "client", "AQAAAAEAACcQAAAAELkn07jng3Z04sb1KXoTu4HThv3FnhH0s4MS1xaA+uQkqi/HG7hOVXd+G3AFiHBHFw==", "8088261c-db91-44f7-9f01-1ccf0b906fdf", "client" });
        }
    }
}
