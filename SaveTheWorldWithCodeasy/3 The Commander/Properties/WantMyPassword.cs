using System;

namespace Properties
{
    class WantMyPassword
    {
        private string _password;
        private string _userName;

        public string Password 
        {
            get
            {
                if (_userName == "admin")
                    return _password;
                else
                    return string.Empty; 
            }
        }
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (value == "admin")
                    _userName = value;
            }
        }

    }
}

