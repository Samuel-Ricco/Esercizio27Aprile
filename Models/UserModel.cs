namespace Esercizio27Aprile.Models
{
    public static class UserModel
    {

        public static bool LogIn(string email, string password)
        {
            if (email == null || password == null) { return false; }

            var user = new User(email, password);
            if (UserList.Users.Contains(user)) 
            {
                return true;
            }
            return false;
        }


    }

    public static class UserList 
    {
        public static List<User> Users = new List<User>();

        public static void AddUser(User user) 
        {
            Users.Add(user);
        }

        public static void CreateUser(string email, string password) 
        {
            User user = new User(email,password);
            AddUser(user);
        }   
    }

}
