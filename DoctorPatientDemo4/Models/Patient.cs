namespace DoctorPatientDemo4.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public long Phone_No { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
