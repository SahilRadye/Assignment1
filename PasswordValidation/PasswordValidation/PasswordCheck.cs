using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidation
{
    internal class PasswordCheck
    {

        #region Methods
        public bool Length(string password)
        {
            if(password.Length >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsUpper(string password)
        {

            int value = 0;
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] Letter2 = upper.ToCharArray();

            foreach (char c in upper)
            {
                if (password.Contains(c))
                {
                    value = 1;
                    break;
                }
            }
            if(value == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsLower(string password)
        {

            int value = 0;
            string lower = "abcdefghijklmnopqrstuvwxyz";
            char[] Letter2 = lower.ToCharArray();

            foreach (char c in lower)
            {
                if (password.Contains(c))
                {
                    value = 1;
                    break;
                }
            }
            if (value == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsDigit(string password)
        {

            int value = 0;
            string digit = "1234567890";
            char[] Letter2 = digit.ToCharArray();

            foreach (char c in digit)
            {
                if (password.Contains(c))
                {
                    value = 1;
                    break;
                }
            }
            if (value == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSymbol(string password)
        {

            int value = 0;
            string symbolic = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] Symbolic = symbolic.ToCharArray();

            foreach (char c in Symbolic)
            {
                if (password.Contains(c))
                {
                    value = 1;
                    break;
                }
            }
            if (value == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PasswordVerify(string password)
        {
            bool result = Length(password);
            bool result1 = IsUpper(password);
            bool result2 = IsLower(password);
            bool result3 = IsDigit(password);
            bool result4 = IsSymbol(password);

            if(result == false)
            {
                Console.WriteLine("Atleast Length of Password should be 6");
            }
            else if(result1 == false)
            {
                Console.WriteLine("Password should contain Atleast One UpperCase");
            }
            else if (result2 == false)
            {
                Console.WriteLine("Password should contain Atleast One LowerCase");
            }
            else if (result3 == false)
            {
                Console.WriteLine("Password should contain Atleast One Digit");
            }
            else if (result4 == false)
            {
                Console.WriteLine("Password should contain Atleast One Special Character");
            }
            else
            {
                Console.WriteLine("Password is Valid");
            }

        }

        #endregion

    }
}
