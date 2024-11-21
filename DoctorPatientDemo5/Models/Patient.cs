using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorPatientDemo5.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public long Phone_No { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; } // Foreign key

        public Doctor Doctor { get; set; } // Navigation property
    }
}
