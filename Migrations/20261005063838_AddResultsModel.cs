using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lablink.app.Migrations
{
    /// <inheritdoc />
    public partial class AddResultsModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PatientsId = table.Column<int>(type: "int", nullable: true),
                    TestType = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    ResultStatus = table.Column<int>(type: "int", nullable: false),
                    ReadyAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClaimedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_Patients_PatientsId",
                        column: x => x.PatientsId,
                        principalTable: "Patients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Results_PatientsId",
                table: "Results",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_ReferenceNo",
                table: "Results",
                column: "ReferenceNo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Results");
        }
    }
}
