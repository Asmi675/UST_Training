namespace WebAPICRUD.Model
{
    public class AddUpdateEnduser
    {
        public required string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public bool isActive { get; set; } = true;
    }
}
