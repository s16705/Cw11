﻿// <auto-generated />
using System;
using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cw11.Migrations
{
    [DbContext(typeof(DoctorDbContext))]
    [Migration("20200621164631_addDataToDB")]
    partial class addDataToDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cw11.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdDoctor");

                    b.ToTable("Doctor");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "e.kowalski@mail.com",
                            FirstName = "Eryk",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "j.nowak@mail.com",
                            FirstName = "Jan",
                            LastName = "Nowak"
                        },
                        new
                        {
                            IdDoctor = 3,
                            Email = "a.majczyna@mail.com",
                            FirstName = "Andrzej",
                            LastName = "Majczyna"
                        });
                });

            modelBuilder.Entity("Cw11.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripiton")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdMedicament");

                    b.ToTable("Medicament");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Descripiton = "Przeciwbolowy",
                            Name = "Ibuprom",
                            Type = "Lek"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Descripiton = "Przeciwbolowy",
                            Name = "Apap",
                            Type = "Lek"
                        },
                        new
                        {
                            IdMedicament = 3,
                            Descripiton = "Witaminy",
                            Name = "Witamin C",
                            Type = "Witaminy"
                        });
                });

            modelBuilder.Entity("Cw11.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdPatient");

                    b.ToTable("Patient");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            Birthdate = new DateTime(1997, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Janusz",
                            LastName = "Typowy"
                        },
                        new
                        {
                            IdPatient = 2,
                            Birthdate = new DateTime(1985, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mirek",
                            LastName = "Handlarz"
                        });
                });

            modelBuilder.Entity("Cw11.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DoctorsIdDoctor")
                        .HasColumnType("int");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.Property<int?>("PatiensIdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription");

                    b.HasIndex("DoctorsIdDoctor");

                    b.HasIndex("PatiensIdPatient");

                    b.ToTable("Prescription");

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 1,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPrescription = 2,
                            Date = new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 3,
                            IdPatient = 2
                        },
                        new
                        {
                            IdPrescription = 3,
                            Date = new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdDoctor = 2,
                            IdPatient = 2
                        });
                });

            modelBuilder.Entity("Cw11.Models.Prescription_Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPrescription");

                    b.HasIndex("IdPrescription");

                    b.ToTable("Prescription_Medicament");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            IdPrescription = 1,
                            Details = "2 tabletki dziennie",
                            Dose = 2
                        },
                        new
                        {
                            IdMedicament = 2,
                            IdPrescription = 2,
                            Details = "2 tabletki dziennie",
                            Dose = 2
                        });
                });

            modelBuilder.Entity("Cw11.Models.Prescription", b =>
                {
                    b.HasOne("Cw11.Models.Doctor", "Doctors")
                        .WithMany("Prescriptions")
                        .HasForeignKey("DoctorsIdDoctor");

                    b.HasOne("Cw11.Models.Patient", "Patiens")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PatiensIdPatient");
                });

            modelBuilder.Entity("Cw11.Models.Prescription_Medicament", b =>
                {
                    b.HasOne("Cw11.Models.Medicament", "Medicaments")
                        .WithMany("Prescription_Medicaments")
                        .HasForeignKey("IdMedicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cw11.Models.Prescription", "Prescriptions")
                        .WithMany("Prescription_Medicaments")
                        .HasForeignKey("IdPrescription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
