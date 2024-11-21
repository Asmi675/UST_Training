namespace DoctorPatientDemo2.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Phone_No { get; set; }

        public Doctor doctor { get; set; }  //to add foreign key
    }
}
