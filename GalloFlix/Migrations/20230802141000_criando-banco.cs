using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalloFlix.Migrations
{
    public partial class criandobanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2184a8d3-d06c-4e95-b787-727c0cb79970");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e8f02e5a-8403-4f21-ab8d-f78ee22fc46f");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "42e1a6cc-5c24-450c-b1da-05cf5306238c", "0ebcba5d-0616-463e-a987-f3354e481702" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "42e1a6cc-5c24-450c-b1da-05cf5306238c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0ebcba5d-0616-463e-a987-f3354e481702");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e29f37c-4689-4406-9901-4477a2ac91e6", "ce8f3aca-b446-4e95-9ee6-344ed72440bb", "Moderador", "MODERADOR" },
                    { "28458763-b611-4efa-b9ec-2063c5a8e4e9", "3f8f91ee-02db-418d-b9f0-d0af67718867", "Usuário", " USUÁRIO" },
                    { "6a2f77c2-fe92-41da-a5a9-5354133ade63", "92d59941-9cf9-4fd1-9852-126f6b86a733", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "beceb905-0db7-44c0-bfda-e060f64c1bcc", 0, "1011ddc5-c51c-4ee8-9632-5fc51d5372c7", new DateTime(2005, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "admin@gmail.com", true, false, null, "Seu Nome Completo", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEBeFXzGKNxObzqEPTbWTXL9hFXVwN4Hc8OaWkLtfpe4N8HClLlXO9GjSR2GL+aNLUw==", "14912345678", true, "/img/users/avatar.png", "25b8363f-cc0f-42b5-99c8-d03702e0b946", false, "Admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6a2f77c2-fe92-41da-a5a9-5354133ade63", "beceb905-0db7-44c0-bfda-e060f64c1bcc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1e29f37c-4689-4406-9901-4477a2ac91e6");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "28458763-b611-4efa-b9ec-2063c5a8e4e9");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6a2f77c2-fe92-41da-a5a9-5354133ade63", "beceb905-0db7-44c0-bfda-e060f64c1bcc" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6a2f77c2-fe92-41da-a5a9-5354133ade63");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "beceb905-0db7-44c0-bfda-e060f64c1bcc");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2184a8d3-d06c-4e95-b787-727c0cb79970", "81dec6aa-0ab5-49b3-81d0-8e4ca82fb173", "Usuário", "USUÁRIO" },
                    { "42e1a6cc-5c24-450c-b1da-05cf5306238c", "5a52fcd3-c476-4d9d-982d-0485fb9f81f9", "Administrador", "ADMINISTRADOR" },
                    { "e8f02e5a-8403-4f21-ab8d-f78ee22fc46f", "4451ca90-9c31-4b58-8668-bd756c7c0e5c", "Moderador", "MODERADOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0ebcba5d-0616-463e-a987-f3354e481702", 0, "a893163b-5d1f-4cf0-a952-813c01d98e7c", new DateTime(1981, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "gallojunior@gmail.com", true, false, null, "José Antonio Gallo Junior", "GALLOJUNIOR@GMAIL.COM", "GALLOJUNIOR", "AQAAAAEAACcQAAAAEBhGik+SDPMpeQXx8EsZhJP72H0GxpyEf8a5BB5xtK2EvRoRouNhUf/rGbyYn90FfQ==", "14981544857", true, "/img/users/avatar.png", "6d8f2535-b238-4e82-aafa-f629830a317c", false, "GalloJunior" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "42e1a6cc-5c24-450c-b1da-05cf5306238c", "0ebcba5d-0616-463e-a987-f3354e481702" });
        }
    }
}
