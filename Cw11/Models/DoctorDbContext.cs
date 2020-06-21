using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Cw11.Models
{
    public class DoctorDbContext : DbContext
    {
        public DbSet<Doctor> Doctor { get; set; }

        public DbSet<Patient> Patient { get; set; }

        public DbSet<Prescription> Prescription { get; set; }

        public DbSet<Medicament> Medicament { get; set; }

        public DbSet<Prescription_Medicament> Prescription_Medicament { get; set; }



        public DoctorDbContext() { }
        public DoctorDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Fluent API
            modelBuilder.Entity<Prescription_Medicament>().HasKey(e =>
            new {

                e.IdMedicament,
                e.IdPrescription

            });

            modelBuilder.Entity<Prescription_Medicament>()
                .HasOne(e => e.Prescriptions)
                .WithMany(e => e.Prescription_Medicaments)
                .HasForeignKey(e => e.IdPrescription); 
            
            modelBuilder.Entity<Prescription_Medicament>()
                .HasOne(e => e.Medicaments)
                .WithMany(e => e.Prescription_Medicaments)
                .HasForeignKey(e => e.IdMedicament);


            // Data
            var doctors = new List<Doctor>();
            doctors.Add(new Doctor { IdDoctor = 1, FirstName = "Eryk", LastName = "Kowalski", Email = "e.kowalski@mail.com" });
            doctors.Add(new Doctor { IdDoctor = 2, FirstName = "Jan", LastName = "Nowak", Email = "j.nowak@mail.com" });
            doctors.Add(new Doctor { IdDoctor = 3, FirstName = "Andrzej", LastName = "Majczyna", Email = "a.majczyna@mail.com" });

            modelBuilder.Entity<Doctor>().HasData(doctors);

            var patients = new List<Patient>();
            patients.Add(new Patient { IdPatient = 1, FirstName = "Janusz", LastName = "Typowy", Birthdate = new DateTime(1997, 10, 10) });
            patients.Add(new Patient { IdPatient = 2, FirstName = "Mirek", LastName = "Handlarz", Birthdate = new DateTime(1985, 06, 06) });

            modelBuilder.Entity<Patient>().HasData(patients);

            var prescriptions = new List<Prescription>();
            prescriptions.Add(new Prescription { IdPrescription = 1, Date = new DateTime(2020, 06, 10), DueDate = new DateTime(2020, 08, 10), IdDoctor = 1, IdPatient = 1 });
            prescriptions.Add(new Prescription { IdPrescription = 2, Date = new DateTime(2020, 06, 15), DueDate = new DateTime(2020, 08, 15), IdDoctor = 3, IdPatient = 2 });
            prescriptions.Add(new Prescription { IdPrescription = 3, Date = new DateTime(2020, 06, 15), DueDate = new DateTime(2020, 08, 15), IdDoctor = 2, IdPatient = 2 });

            modelBuilder.Entity<Prescription>().HasData(prescriptions);

            var medicaments = new List<Medicament>();
            medicaments.Add(new Medicament { IdMedicament = 1, Name = "Ibuprom", Descripiton = "Przeciwbolowy", Type = "Lek" });
            medicaments.Add(new Medicament { IdMedicament = 2, Name = "Apap", Descripiton = "Przeciwbolowy", Type = "Lek" });
            medicaments.Add(new Medicament { IdMedicament = 3, Name = "Witamin C", Descripiton = "Witaminy", Type = "Witaminy" });

            modelBuilder.Entity<Medicament>().HasData(medicaments);

            var prescriptionsMedicament = new List<Prescription_Medicament>();
            prescriptionsMedicament.Add(new Prescription_Medicament { IdMedicament = 1, IdPrescription = 1, Dose = 2, Details = "2 tabletki dziennie" });
            prescriptionsMedicament.Add(new Prescription_Medicament { IdMedicament = 2, IdPrescription = 2, Dose = 2, Details = "2 tabletki dziennie" });

            modelBuilder.Entity<Prescription_Medicament>().HasData(prescriptionsMedicament);
        }
    }
}
