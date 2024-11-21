using Microsoft.EntityFrameworkCore;

namespace DoctorPatientDemo4.Models
{
    public class DoctorContext : DbContext
    {
        public DoctorContext(DbContextOptions<DoctorContext> options) : base(options)

        {

        }
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }

    }
}
