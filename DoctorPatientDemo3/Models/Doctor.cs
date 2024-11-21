using System.ComponentModel.DataAnnotations;

namespace DoctorPatientDemo3.Models
{
    //parent
    //primary key
    public class Doctor
    {
        public Doctor()
        {
            Patient = new List<Patient>();
        }
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public String Specilization { get; set; }
        public int PhoneNo { get; set; }

        public IList<Patient> Patient { get; set; }

    }
}
