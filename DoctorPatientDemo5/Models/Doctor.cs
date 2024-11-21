using System.ComponentModel.DataAnnotations;

namespace DoctorPatientDemo5.Models
{
    public class Doctor
    {
        public Doctor()
        {
            Patients = new List<Patient>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Last_Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Specialization { get; set; } // Fixed typo from "Specilization" to "Specialization"

        [Required]
        public long PhoneNo { get; set; } // Changed int to long for better phone number support

        public IList<Patient> Patients { get; set; } // Navigation property
    }
}
