using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Models
{
    public class DoctorDbContext : DbContext
    {
        public DbSet<Doctor> Doctor { get; set; }
        public DoctorDbContext() { }
        public DoctorDbContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
