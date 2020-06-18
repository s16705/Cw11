using Microsoft.EntityFrameworkCore.Migrations;

namespace Cw11.Migrations
{
    public partial class relationsToPrescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoctorsIdDoctor",
                table: "Prescription",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdDoctor",
                table: "Prescription",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPatient",
                table: "Prescription",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatiensIdPatient",
                table: "Prescription",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_DoctorsIdDoctor",
                table: "Prescription",
                column: "DoctorsIdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_PatiensIdPatient",
                table: "Prescription",
                column: "PatiensIdPatient");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Doctor_DoctorsIdDoctor",
                table: "Prescription",
                column: "DoctorsIdDoctor",
                principalTable: "Doctor",
                principalColumn: "IdDoctor",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Patient_PatiensIdPatient",
                table: "Prescription",
                column: "PatiensIdPatient",
                principalTable: "Patient",
                principalColumn: "IdPatient",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Doctor_DoctorsIdDoctor",
                table: "Prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Patient_PatiensIdPatient",
                table: "Prescription");

            migrationBuilder.DropIndex(
                name: "IX_Prescription_DoctorsIdDoctor",
                table: "Prescription");

            migrationBuilder.DropIndex(
                name: "IX_Prescription_PatiensIdPatient",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "DoctorsIdDoctor",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "IdDoctor",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "IdPatient",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "PatiensIdPatient",
                table: "Prescription");
        }
    }
}
