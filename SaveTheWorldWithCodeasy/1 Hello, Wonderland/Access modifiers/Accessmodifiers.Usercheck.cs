using System;

namespace AccessModifiers
{
    class User
    {
        private string _login;
        private string _password;

        public string GetLogin()
        {
            return _login;
        }

        public string GetPassword()
        {
            return _password;
        }
    }

    class UserCheck
    {
        static void Main()
        {
            var user = new User();

            var login = user.GetLogin();
            var password = user.GetPassword();

            if (login == "admin" && password == "VerySecretPassword")
            {
                Console.WriteLine("Access granted");
            }
            else
            {
                Console.WriteLine("Access denied");
            }
        }
    }
}