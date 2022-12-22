using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpDesk.Persistence.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupportDepartments",
                columns: table => new
                {
                    SupportDepartmentId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportDepartments", x => x.SupportDepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "SupportSpecialists",
                columns: table => new
                {
                    SupportSpecialistId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    SupportDepartmentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportSpecialists", x => x.SupportSpecialistId);
                    table.ForeignKey(
                        name: "FK_SupportSpecialists_SupportDepartments_SupportDepartmentId",
                        column: x => x.SupportDepartmentId,
                        principalTable: "SupportDepartments",
                        principalColumn: "SupportDepartmentId");
                });

            migrationBuilder.CreateTable(
                name: "SupportRequests",
                columns: table => new
                {
                    SupportRequestId = table.Column<Guid>(nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    RequestStatus = table.Column<int>(nullable: false),
                    SupportSpecialistId = table.Column<Guid>(nullable: false),
                    SupportDepartmentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportRequests", x => x.SupportRequestId);
                    table.ForeignKey(
                        name: "FK_SupportRequests_SupportDepartments_SupportDepartmentId",
                        column: x => x.SupportDepartmentId,
                        principalTable: "SupportDepartments",
                        principalColumn: "SupportDepartmentId");
                    table.ForeignKey(
                        name: "FK_SupportRequests_SupportSpecialists_SupportSpecialistId",
                        column: x => x.SupportSpecialistId,
                        principalTable: "SupportSpecialists",
                        principalColumn: "SupportSpecialistId");
                });

            migrationBuilder.InsertData(
                table: "SupportDepartments",
                columns: new[] { "SupportDepartmentId", "Name" },
                values: new object[] { new Guid("1d5b9219-9b8c-4996-8a35-51a27feaa74b"), "Backend" });

            migrationBuilder.InsertData(
                table: "SupportDepartments",
                columns: new[] { "SupportDepartmentId", "Name" },
                values: new object[] { new Guid("dee22e09-d91c-4037-8ad5-dd4213efe33f"), "Catalog" });

            migrationBuilder.InsertData(
                table: "SupportDepartments",
                columns: new[] { "SupportDepartmentId", "Name" },
                values: new object[] { new Guid("122a1127-6afb-4cc6-976e-148eed423dcd"), "Checkout" });

            migrationBuilder.InsertData(
                table: "SupportSpecialists",
                columns: new[] { "SupportSpecialistId", "Name", "SupportDepartmentId" },
                values: new object[,]
                {
                    { new Guid("0389124d-f199-4856-b965-2d38184cc0e8"), "Adam", new Guid("1d5b9219-9b8c-4996-8a35-51a27feaa74b") },
                    { new Guid("61a01264-0d20-46f0-bcd1-36cd20a41123"), "Rayan", new Guid("1d5b9219-9b8c-4996-8a35-51a27feaa74b") },
                    { new Guid("18f522b6-697d-4c96-ae91-018d3374ed14"), "Yurena", new Guid("1d5b9219-9b8c-4996-8a35-51a27feaa74b") },
                    { new Guid("c95501a5-b529-4caa-a199-98da01e3ccfd"), "Antía", new Guid("dee22e09-d91c-4037-8ad5-dd4213efe33f") },
                    { new Guid("fd782f05-2e58-4367-bd4c-e734fdcdedc3"), "Irati", new Guid("dee22e09-d91c-4037-8ad5-dd4213efe33f") },
                    { new Guid("7fd58309-c943-42f6-9355-1c6c0be87d90"), "Xosé", new Guid("dee22e09-d91c-4037-8ad5-dd4213efe33f") },
                    { new Guid("aacb0189-d28c-40f9-97c5-dd5073961771"), "Martina", new Guid("122a1127-6afb-4cc6-976e-148eed423dcd") },
                    { new Guid("c6fdf17d-a495-4685-8eff-1d95d97fdf59"), "Hugo", new Guid("122a1127-6afb-4cc6-976e-148eed423dcd") },
                    { new Guid("93575465-e1ba-4d73-a085-3d100001cfe7"), "Amira", new Guid("122a1127-6afb-4cc6-976e-148eed423dcd") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupportRequests_SupportDepartmentId",
                table: "SupportRequests",
                column: "SupportDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportRequests_SupportSpecialistId",
                table: "SupportRequests",
                column: "SupportSpecialistId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportSpecialists_SupportDepartmentId",
                table: "SupportSpecialists",
                column: "SupportDepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupportRequests");

            migrationBuilder.DropTable(
                name: "SupportSpecialists");

            migrationBuilder.DropTable(
                name: "SupportDepartments");
        }
    }
}
