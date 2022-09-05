using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Trainee : Employee
    {

        #region Field And Property

        public int NoOfDays { get; set; }

        public double RatePerDay { get; set; }

        //public string EmpNo { get; set; }

        #endregion

        #region Constructor
        public Trainee()
        {
            NoOfDays = 1;
            RatePerDay = 1000;

        }

        public Trainee(string name, string address, int days ,double ratePerDay1) : base(name, address)
        {
            NoOfDays = days;
            RatePerDay = ratePerDay1;

        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString() + $", Number of day : {NoOfDays} , Rate Per Day : {RatePerDay}";
        }
        public override double CalculateSalary()
        {
            return NoOfDays*RatePerDay ;
        }


        #endregion

    }
}
