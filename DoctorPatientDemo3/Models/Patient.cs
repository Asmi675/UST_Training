using System.Diagnostics;

namespace DoctorPatientDemo3.Models
{
    //fk will be given here
    //patient is child
    public class Patient
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Phone_No { get; set; }

        public int DocId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
