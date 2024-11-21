using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCAppDemo.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "doctorId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_doctorId",
                table: "Patients",
                column: "doctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Doctors_doctorId",
                table: "Patients",
                column: "doctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Doctors_doctorId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_doctorId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "doctorId",
                table: "Patients");
        }
    }
}
