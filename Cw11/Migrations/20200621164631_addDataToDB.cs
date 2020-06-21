using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cw11.Migrations
{
    public partial class addDataToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "e.kowalski@mail.com", "Eryk", "Kowalski" },
                    { 2, "j.nowak@mail.com", "Jan", "Nowak" },
                    { 3, "a.majczyna@mail.com", "Andrzej", "Majczyna" }
                });

            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "IdMedicament", "Descripiton", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Przeciwbolowy", "Ibuprom", "Lek" },
                    { 2, "Przeciwbolowy", "Apap", "Lek" },
                    { 3, "Witaminy", "Witamin C", "Witaminy" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janusz", "Typowy" },
                    { 2, new DateTime(1985, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mirek", "Handlarz" }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DoctorsIdDoctor", "DueDate", "IdDoctor", "IdPatient", "PatiensIdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null },
                    { 2, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, null },
                    { 3, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 1, 1, "2 tabletki dziennie", 2 });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[] { 2, 2, "2 tabletki dziennie", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2);
        }
    }
}
