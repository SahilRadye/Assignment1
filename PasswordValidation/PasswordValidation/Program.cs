using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Password Length should be more Than 5 , Contain Atleast One UpperCase , One LowerCase , One Digit , One Special Character");
            Console.WriteLine();
            Console.WriteLine("Create a New Password");
            string password = Console.ReadLine();

            PasswordCheck passwordCheck = new PasswordCheck();
            passwordCheck.PasswordVerify(password);


            Console.ReadLine();
        }

    }
}
