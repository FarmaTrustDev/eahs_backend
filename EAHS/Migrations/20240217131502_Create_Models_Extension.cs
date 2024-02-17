using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EAHS.Migrations
{
    public partial class Create_Models_Extension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isIncluded",
                table: "Rules",
                newName: "IsIncluded");

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    ISO = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    GlobalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 1,
                column: "GlobalId",
                value: new Guid("4568ef31-6ce4-48ee-9e89-d93f590c80be"));

            migrationBuilder.UpdateData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 2,
                column: "GlobalId",
                value: new Guid("aff395a3-0c9f-4762-82bf-6aef40b7d0b3"));

            migrationBuilder.UpdateData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 3,
                column: "GlobalId",
                value: new Guid("68848752-7c7a-4171-ae45-a32da6a8d2f1"));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "GlobalId",
                value: new Guid("e50a97c8-f8fd-4f7e-8f7d-b85b48dc094c"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.RenameColumn(
                name: "IsIncluded",
                table: "Rules",
                newName: "isIncluded");

            migrationBuilder.UpdateData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 1,
                column: "GlobalId",
                value: new Guid("b254fc83-fd6b-44d8-9656-958e6dce83aa"));

            migrationBuilder.UpdateData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 2,
                column: "GlobalId",
                value: new Guid("0d050ef6-7646-4498-9380-48dab02c2be1"));

            migrationBuilder.UpdateData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 3,
                column: "GlobalId",
                value: new Guid("87eab1cc-dda5-4acc-9db3-cb62d07b9dbb"));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "GlobalId",
                value: new Guid("d4de95a5-bbba-4f61-9d9f-f186850dc55b"));
        }
    }
}
