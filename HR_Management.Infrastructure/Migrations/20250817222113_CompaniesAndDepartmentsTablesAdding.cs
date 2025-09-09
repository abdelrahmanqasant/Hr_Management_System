using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR_Management.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CompaniesAndDepartmentsTablesAdding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "Industry", "Name" },
                values: new object[,]
                {
                    { 1, "", "Technology", "Technology Company 1" },
                    { 2, "", "Technology", "Technology Company 2" },
                    { 3, "", "Technology", "Technology Company 3" },
                    { 4, "", "Technology", "Technology Company 4" },
                    { 5, "", "Technology", "Technology Company 5" },
                    { 6, "", "Technology", "Technology Company 6" },
                    { 7, "", "Technology", "Technology Company 7" },
                    { 8, "", "Technology", "Technology Company 8" },
                    { 9, "", "Technology", "Technology Company 9" },
                    { 10, "", "Technology", "Technology Company 10" },
                    { 11, "", "Pharmaceuticals", "Pharmaceuticals Company 1" },
                    { 12, "", "Pharmaceuticals", "Pharmaceuticals Company 2" },
                    { 13, "", "Pharmaceuticals", "Pharmaceuticals Company 3" },
                    { 14, "", "Pharmaceuticals", "Pharmaceuticals Company 4" },
                    { 15, "", "Pharmaceuticals", "Pharmaceuticals Company 5" },
                    { 16, "", "Pharmaceuticals", "Pharmaceuticals Company 6" },
                    { 17, "", "Pharmaceuticals", "Pharmaceuticals Company 7" },
                    { 18, "", "Pharmaceuticals", "Pharmaceuticals Company 8" },
                    { 19, "", "Pharmaceuticals", "Pharmaceuticals Company 9" },
                    { 20, "", "Pharmaceuticals", "Pharmaceuticals Company 10" },
                    { 21, "", "Laboratory Equipment", "Laboratory Equipment Company 1" },
                    { 22, "", "Laboratory Equipment", "Laboratory Equipment Company 2" },
                    { 23, "", "Laboratory Equipment", "Laboratory Equipment Company 3" },
                    { 24, "", "Laboratory Equipment", "Laboratory Equipment Company 4" },
                    { 25, "", "Laboratory Equipment", "Laboratory Equipment Company 5" },
                    { 26, "", "Laboratory Equipment", "Laboratory Equipment Company 6" },
                    { 27, "", "Laboratory Equipment", "Laboratory Equipment Company 7" },
                    { 28, "", "Laboratory Equipment", "Laboratory Equipment Company 8" },
                    { 29, "", "Laboratory Equipment", "Laboratory Equipment Company 9" },
                    { 30, "", "Laboratory Equipment", "Laboratory Equipment Company 10" },
                    { 31, "", "Real Estate", "Real Estate Company 1" },
                    { 32, "", "Real Estate", "Real Estate Company 2" },
                    { 33, "", "Real Estate", "Real Estate Company 3" },
                    { 34, "", "Real Estate", "Real Estate Company 4" },
                    { 35, "", "Real Estate", "Real Estate Company 5" },
                    { 36, "", "Real Estate", "Real Estate Company 6" },
                    { 37, "", "Real Estate", "Real Estate Company 7" },
                    { 38, "", "Real Estate", "Real Estate Company 8" },
                    { 39, "", "Real Estate", "Real Estate Company 9" },
                    { 40, "", "Real Estate", "Real Estate Company 10" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CompanyId", "CreatedAt", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(4968), "", "Software" },
                    { 2, 1, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5023), "", "Hardware" },
                    { 3, 1, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5026), "", "AI" },
                    { 4, 2, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5032), "", "Software" },
                    { 5, 2, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5035), "", "Hardware" },
                    { 6, 2, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5047), "", "AI" },
                    { 7, 3, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5059), "", "Software" },
                    { 8, 3, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5062), "", "Hardware" },
                    { 9, 3, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5064), "", "AI" },
                    { 10, 4, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5071), "", "Software" },
                    { 11, 4, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5080), "", "Hardware" },
                    { 12, 4, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5083), "", "AI" },
                    { 13, 5, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5088), "", "Software" },
                    { 14, 5, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5091), "", "Hardware" },
                    { 15, 5, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5102), "", "AI" },
                    { 16, 6, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5126), "", "Software" },
                    { 17, 6, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5130), "", "Hardware" },
                    { 18, 6, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5134), "", "AI" },
                    { 19, 7, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5139), "", "Software" },
                    { 20, 7, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5141), "", "Hardware" },
                    { 21, 7, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5143), "", "AI" },
                    { 22, 8, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5148), "", "Software" },
                    { 23, 8, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5155), "", "Hardware" },
                    { 24, 8, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5158), "", "AI" },
                    { 25, 9, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5163), "", "Software" },
                    { 26, 9, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5165), "", "Hardware" },
                    { 27, 9, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5170), "", "AI" },
                    { 28, 10, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5175), "", "Software" },
                    { 29, 10, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5178), "", "Hardware" },
                    { 30, 10, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5184), "", "AI" },
                    { 31, 11, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5215), "", "Research" },
                    { 32, 11, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5219), "", "Manufacturing" },
                    { 33, 11, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5221), "", "Distribution" },
                    { 34, 12, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5228), "", "Research" },
                    { 35, 12, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5231), "", "Manufacturing" },
                    { 36, 12, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5233), "", "Distribution" },
                    { 37, 13, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5238), "", "Research" },
                    { 38, 13, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5240), "", "Manufacturing" },
                    { 39, 13, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5243), "", "Distribution" },
                    { 40, 14, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5248), "", "Research" },
                    { 41, 14, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5250), "", "Manufacturing" },
                    { 42, 14, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5253), "", "Distribution" },
                    { 43, 15, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5258), "", "Research" },
                    { 44, 15, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5260), "", "Manufacturing" },
                    { 45, 15, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5263), "", "Distribution" },
                    { 46, 16, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5268), "", "Research" },
                    { 47, 16, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5270), "", "Manufacturing" },
                    { 48, 16, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5273), "", "Distribution" },
                    { 49, 17, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5278), "", "Research" },
                    { 50, 17, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5281), "", "Manufacturing" },
                    { 51, 17, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5283), "", "Distribution" },
                    { 52, 18, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5288), "", "Research" },
                    { 53, 18, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5290), "", "Manufacturing" },
                    { 54, 18, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5294), "", "Distribution" },
                    { 55, 19, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5299), "", "Research" },
                    { 56, 19, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5302), "", "Manufacturing" },
                    { 57, 19, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5304), "", "Distribution" },
                    { 58, 20, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5309), "", "Research" },
                    { 59, 20, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5312), "", "Manufacturing" },
                    { 60, 20, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5314), "", "Distribution" },
                    { 61, 21, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5319), "", "Microscopes" },
                    { 62, 21, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5322), "", "Testing Kits" },
                    { 63, 21, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5325), "", "Protective Gear" },
                    { 64, 22, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5330), "", "Microscopes" },
                    { 65, 22, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5332), "", "Testing Kits" },
                    { 66, 22, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5336), "", "Protective Gear" },
                    { 67, 23, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5341), "", "Microscopes" },
                    { 68, 23, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5344), "", "Testing Kits" },
                    { 69, 23, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5346), "", "Protective Gear" },
                    { 70, 24, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5351), "", "Microscopes" },
                    { 71, 24, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5354), "", "Testing Kits" },
                    { 72, 24, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5357), "", "Protective Gear" },
                    { 73, 25, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5369), "", "Microscopes" },
                    { 74, 25, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5372), "", "Testing Kits" },
                    { 75, 25, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5374), "", "Protective Gear" },
                    { 76, 26, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5382), "", "Microscopes" },
                    { 77, 26, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5385), "", "Testing Kits" },
                    { 78, 26, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5387), "", "Protective Gear" },
                    { 79, 27, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5392), "", "Microscopes" },
                    { 80, 27, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5395), "", "Testing Kits" },
                    { 81, 27, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5397), "", "Protective Gear" },
                    { 82, 28, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5402), "", "Microscopes" },
                    { 83, 28, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5405), "", "Testing Kits" },
                    { 84, 28, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5407), "", "Protective Gear" },
                    { 85, 29, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5412), "", "Microscopes" },
                    { 86, 29, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5415), "", "Testing Kits" },
                    { 87, 29, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5417), "", "Protective Gear" },
                    { 88, 30, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5422), "", "Microscopes" },
                    { 89, 30, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5425), "", "Testing Kits" },
                    { 90, 30, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5427), "", "Protective Gear" },
                    { 91, 31, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5432), "", "Residential" },
                    { 92, 31, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5435), "", "Commercial" },
                    { 93, 31, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5437), "", "Industrial" },
                    { 94, 32, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5442), "", "Residential" },
                    { 95, 32, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5445), "", "Commercial" },
                    { 96, 32, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5447), "", "Industrial" },
                    { 97, 33, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5452), "", "Residential" },
                    { 98, 33, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5455), "", "Commercial" },
                    { 99, 33, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5457), "", "Industrial" },
                    { 100, 34, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5462), "", "Residential" },
                    { 101, 34, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5465), "", "Commercial" },
                    { 102, 34, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5467), "", "Industrial" },
                    { 103, 35, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5472), "", "Residential" },
                    { 104, 35, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5475), "", "Commercial" },
                    { 105, 35, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5478), "", "Industrial" },
                    { 106, 36, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5482), "", "Residential" },
                    { 107, 36, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5485), "", "Commercial" },
                    { 108, 36, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5488), "", "Industrial" },
                    { 109, 37, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5493), "", "Residential" },
                    { 110, 37, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5495), "", "Commercial" },
                    { 111, 37, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5498), "", "Industrial" },
                    { 112, 38, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5503), "", "Residential" },
                    { 113, 38, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5505), "", "Commercial" },
                    { 114, 38, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5508), "", "Industrial" },
                    { 115, 39, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5513), "", "Residential" },
                    { 116, 39, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5515), "", "Commercial" },
                    { 117, 39, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5518), "", "Industrial" },
                    { 118, 40, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5523), "", "Residential" },
                    { 119, 40, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5525), "", "Commercial" },
                    { 120, 40, new DateTime(2025, 8, 18, 1, 21, 11, 817, DateTimeKind.Local).AddTicks(5528), "", "Industrial" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CompanyId",
                table: "Departments",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
