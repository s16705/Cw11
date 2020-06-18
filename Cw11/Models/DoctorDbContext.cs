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

        //public DbSet<Prescription_Medicament> Prescription_Medicament { get; set; }



        public DoctorDbContext() { }
        public DoctorDbContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
