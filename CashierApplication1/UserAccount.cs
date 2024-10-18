namespace UserAccountNamespace
{
    public class UserAccount
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public UserAccount(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public virtual bool ValidateCredentials(string username, string password)
        {
            return Username == username && Password == password;
        }
    }
}
