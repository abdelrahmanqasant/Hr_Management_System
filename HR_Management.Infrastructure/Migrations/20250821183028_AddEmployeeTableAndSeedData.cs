using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR_Management.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeTableAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 307, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 308, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 308, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 21, 21, 30, 26, 308, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "DateOfBirth", "DepartmentId", "Email", "FullName", "HireDate", "PhoneNumber", "Salary", "Title" },
                values: new object[,]
                {
                    { 1, "Castle Rd", new DateTime(1996, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "ahmed.ali@example.com", "Ahmed Ali", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "011111111111", 15000m, "Software Engineer" },
                    { 2, "Pear St", new DateTime(1997, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "mona.hassan@example.com", "Mona Hassan", new DateTime(2018, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "011111111111", 18000m, "HR Manager" },
                    { 3, "Cedar St", new DateTime(1998, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "omar.khaled@example.com", "Omar Khaled", new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "011111111111", 14000m, "Frontend Developer" },
                    { 4, "Castle Rd", new DateTime(1991, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "sara.ibrahim@example.com", "Sara Ibrahim", new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "011111111111", 15500m, "Backend Developer" },
                    { 5, "Castle Rd", new DateTime(1992, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "youssef.mohamed@example.com", "Youssef Mohamed", new DateTime(2016, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "011111111111", 22000m, "Team Lead" },
                    { 6, "Birch St", new DateTime(1988, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "nadia.fathy@example.com", "Nadia Fathy", new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "011111111111", 12000m, "Recruiter" },
                    { 7, "Peach St", new DateTime(1989, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "karim.adel@example.com", "Karim Adel", new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "011111111111", 13500m, "QA Engineer" },
                    { 8, "Castle Rd", new DateTime(1987, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "laila.samir@example.com", "Laila Samir", new DateTime(2019, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "011111111111", 16000m, "UI/UX Designer" },
                    { 9, "Plum St", new DateTime(1995, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "hossam.ezzat@example.com", "Hossam Ezzat", new DateTime(2015, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "011111111111", 25000m, "Project Manager" },
                    { 10, "Berry St", new DateTime(1994, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "mai.tarek@example.com", "Mai Tarek", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "011111111111", 5000m, "Intern" },
                    { 11, "Stone Rd", new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "adel.magdy@example.com", "Adel Magdy", new DateTime(2019, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "011111111111", 14500m, "System Administrator" },
                    { 12, "Bridge Rd", new DateTime(1996, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "nourhan.ahmed@example.com", "Nourhan Ahmed", new DateTime(2020, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "011111111111", 13000m, "Marketing Specialist" },
                    { 13, "Tower St", new DateTime(1991, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "mohamed.reda@example.com", "Mohamed Reda", new DateTime(2017, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "011111111111", 20000m, "Senior Developer" },
                    { 14, "Castle Rd", new DateTime(1993, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "aya.gamal@example.com", "Aya Gamal", new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "011111111111", 11000m, "Content Writer" },
                    { 15, "Castle Rd", new DateTime(1998, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "tamer.saad@example.com", "Tamer Saad", new DateTime(2014, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "011111111111", 24000m, "Finance Manager" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 8, 18, 1, 49, 46, 943, DateTimeKind.Local).AddTicks(7224));
        }
    }
}
