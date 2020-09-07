namespace CORE_TestAPP
{
    public class Contact
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int ContactNumber { get; set; }
        public string status { get; set; } = "Active";
        public int ClientID { get; set; }
    }
}