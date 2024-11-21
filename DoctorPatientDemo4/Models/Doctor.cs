namespace DoctorPatientDemo4.Models
{
    public class Doctor
    {
        public Doctor()
        {
            Patients = new List<Patient>();
        }
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Specilization { get; set; }
        public int PhoneNo { get; set; }

        public IList<Patient> Patients { get; set; }
    }
}
