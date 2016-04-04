namespace Echo.Data.Repository.Models
{
    //To transfer login information to its corresponding form upon login
    //For user privilege
    public class LoginInfo
    {
        public string username { get; set; }
        public string fullName { get; set; }
        public string accountType { get; set; }
    }
}

