using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP.OOP_2_dars
{
    internal class Account
    {
        private string _name;
        private string _password;
        private int _age;
        private string _email;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 5 && value.All(char.IsLetter))
                {
                    _name = value;
                    Console.WriteLine("Name is valid   true");
                }
                else
                {
                    Console.WriteLine("Name is not valid");
                }
            }
        }
        public string Password
        {
            private get
            {
                return _password;
            }
            set
            {
                if (value.Length > 5 && value.Any(char.IsLetter) && value.Any(char.IsDigit))
                {
                    _password = value;
                    Console.WriteLine("Password is valid");
                }
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value < 75)
                {
                    _age = value;
                    Console.WriteLine("Age is valid ");
                }
                else
                {
                    Console.WriteLine("Age is not valid");
                }
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                if (value.Length > 7 && value.Any(char.IsUpper) && value.Any(char.IsDigit) && value.Any(char.IsNumber)
                    && value.Any(char.IsLetter))
                {
                    _email = value;
                    Console.WriteLine("Email is valid true !!");
                }
                else
                {
                    Console.WriteLine("Email is not valid");
                }
            }
        }
        public void Accounts1(string password)
        {
            if (Password == password)
            {
                Console.WriteLine("Siz kiritgan password to'g'ri");
            }
            else
            {
                Console.WriteLine("Siz noto'g'ri password kiritdingiz");
            }
        }
    }
}
