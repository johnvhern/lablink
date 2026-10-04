using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lablink.app.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePatientTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Patients",
                newName: "FullName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Patients",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Patients",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Patients",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizeFName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NormalizeLName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NormalizeMName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "NormalizeFName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "NormalizeLName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "NormalizeMName",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Patients",
                newName: "Name");
        }
    }
}
