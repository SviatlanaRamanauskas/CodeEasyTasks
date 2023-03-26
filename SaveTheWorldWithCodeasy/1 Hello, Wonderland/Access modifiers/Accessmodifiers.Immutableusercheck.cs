using System;

namespace AccessModifiers
{
    class HackedUser
    {
        private string _login;
        private string _password;

        public string GetLogin()
        {
            _login = "admin";
            return _login;
        }

        public string GetPassword()
        {
            _password = "VerySecretPassword";
            return _password;
        }
    }

    class ImmutableUserCheck
    {
        static void Main()
        {
            var user = new HackedUser();

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