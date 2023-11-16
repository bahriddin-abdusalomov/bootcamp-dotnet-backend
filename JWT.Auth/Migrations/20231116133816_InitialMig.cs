using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JWT.Auth.Migrations
{
    /// <inheritdoc />
    public partial class InitialMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PassportData",
                columns: table => new
                {
                    PassportDataId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FistName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "First name"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Last name"),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PassportNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassportData", x => x.PassportDataId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "Bahriddin_"),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValue: "bahriddin2003"),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassportDataId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_PassportData_UserId",
                        column: x => x.UserId,
                        principalTable: "PassportData",
                        principalColumn: "PassportDataId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Car"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UserId",
                table: "Cars",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PassportData_PassportNumber",
                table: "PassportData",
                column: "PassportNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "PassportData");
        }
    }
}
