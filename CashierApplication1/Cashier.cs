namespace UserAccountNamespace
{
    public class Cashier : UserAccount
    {
        public string FullName { get; set; }
        public string Department { get; set; }

        public Cashier(string username, string password, string fullName, string department)
            : base(username, password)
        {
            FullName = fullName;
            Department = department;
        }
    }
}
