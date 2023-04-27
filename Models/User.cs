namespace Esercizio27Aprile.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }

        //testing purpose
        public User()
        {
            
        }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

    }
}
