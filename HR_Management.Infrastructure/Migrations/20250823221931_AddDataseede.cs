using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR_Management.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDataseede : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "DateOfBirth", "DepartmentId", "Email", "FullName", "HireDate", "PhoneNumber", "Salary", "Title" },
                values: new object[,]
                {
                    { 1, "Castle Rd", new DateTime(1996, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "ahmed.ali@example.com", "Ahmed Ali", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "011111111111", 15000m, "Software Engineer" },
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
