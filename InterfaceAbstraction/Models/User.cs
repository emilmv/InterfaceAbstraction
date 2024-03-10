using InterfaceAbstraction.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstraction.Models
{
    internal class User : IAccount
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        private string _password;
        private string Password
        {
            get => _password;
            set
            {
                if (!PasswordChecker(value)) return;
                _password = value;
            }
        }
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public bool PasswordChecker(string password)
        {
            if (password.Length < 8) return false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    foreach (char c2 in password)
                        if (char.IsLower(c2))
                            foreach (char c3 in password)
                                if (char.IsDigit(c3)) return true;
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"e-mail address: {Email}");
            Console.WriteLine($"Password: {Password}");
        }
    }
}
