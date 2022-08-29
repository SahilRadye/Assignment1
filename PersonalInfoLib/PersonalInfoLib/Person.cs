using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInfoLib
{
    public class Person
    {

        #region Field
        private string fname;

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        private string lname;

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        #endregion

        #region Constructor
        public Person(string _fname, string _lname, string _email, DateTime _dateTime)
        {
            Fname = _fname;
            Lname = _lname;
            Email = _email;
            DateOfBirth = _dateTime;
        }

        #endregion

        #region Method
        public override string ToString()
        {
            return String.Format($"First Name : {Fname} , Last Name : {Lname} , Email : {Email} , Date of birth : {DateOfBirth}");
        }

        public bool IsAdult()
        {
            
            int result = (DateTime.Now.Year) - (dateOfBirth.Year);
            if (result >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Bday()
        {
            int day = DateTime.Now.Day;
            int day1 = dateOfBirth.Day;
            int month1 = DateTime.Now.Month;
            int month2 = dateOfBirth.Month;

            if (day == day1 &&  month1 == month2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string SunSign()
        {
            int day = dateOfBirth.Day;
            int month = dateOfBirth.Month;

            if (((month == 3) && (day >= 21 || day <= 31)) || ((month == 4) && (day >= 1 || day <= 19)))
            {
                return "Aires";
            }
            else if(((month == 4) && (day >= 20 || day <= 30)) || ((month == 5) && (day >= 1 || day <= 20)))
            {
                return "Taurus";
            }
            else if (((month == 5) && (day >= 21 || day <= 31)) || ((month == 6) && (day >= 1 || day <= 21)))
            {
                return "Gemini";
            }
            else if (((month == 6) && (day >= 22 || day <= 30)) || ((month == 7) && (day >= 1 || day <= 22)))
            {
                return "Cancer";
            }
            else if (((month == 7) && (day >= 23 || day <= 31)) || ((month == 8) && (day >= 1 || day <= 22)))
            {
                return "Leo";
            }
            else if (((month == 8) && (day >= 23 || day <= 31)) || ((month == 9) && (day >= 1 || day <= 22)))
            {
                return "Virgo";
            }
            else if (((month == 9) && (day >= 23 || day <= 30)) || ((month == 10) && (day >= 1 || day <= 23)))
            {
                return "Libra";
            }
            else if (((month == 10) && (day >= 24 || day <= 31)) || ((month == 11) && (day >= 1 || day <= 21)))
            {
                return "Scorpius";
            }
            else if (((month == 11) && (day >= 22 || day <= 30)) || ((month == 12) && (day >= 1 || day <= 21)))
            {
                return "Sagittarius";
            }
            else if (((month == 12) && (day >= 22 || day <= 31)) || ((month == 1) && (day >= 1 || day <= 19)))
            {
                return "Capricornus";
            }
            else if (((month == 1) && (day >= 20 || day <= 31)) || ((month == 2) && (day >= 1 || day <= 18)))
            {
                return "Aquarius";
            }
            else
            {
                return "Pisces";
            }

        }


        #endregion

    }
}

