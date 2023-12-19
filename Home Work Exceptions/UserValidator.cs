using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_Exceptions
{
    public class UserValidator
    {
        public static bool Validate(string login, string password, string confirmPassword)
        {
            if (login.Length >= 20 || login.Contains(" "))
            {
                throw new WrongLoginException("Login должен быть меньше 20 символов и не должен содержать пробелы");
            }

            if (password.Length >= 20 || password.Contains(" ") || !password.Any(char.IsDigit) || password != confirmPassword)
            {
                throw new WrongPasswordException("Password должен быть меньше 20 символов, не должен содержать пробелом и должен содержать хотя бы одну цифру. Также password и confirmPassword должны быть равны.");
            }

            return true;
        }
    }
}
