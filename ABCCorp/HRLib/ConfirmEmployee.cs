using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class ConfirmEmployee : Employee 
    {
        #region Field And Property

        private double basic;

        public double Basic
        {
            get { return basic; }           
            //set { basic = value; }
            set
            {
                basic = value;
                if (basic < 5000)
                {
                    throw new ArgumentException("Your Basic Salary minimum should be 5000");
                }
                else
                {
                    basic = value;
                }
            }
                
        }

        public string Designation { get; set; }


        //public string EmpNo { get; set; }

        #endregion

        #region Constructor
        public ConfirmEmployee()
        {
            Basic = 20000;
            Designation = "Developer";

        }

        public ConfirmEmployee(string name, string address, double basic, string designation) : base(name, address)
        {
            Basic = basic;
            Designation = designation;
            
        }

        #endregion

        #region Method
        public override string ToString()
        {
            return base.ToString() + $", Basic Salary : {Basic} , Designation : {Designation}";
        }

        public override double CalculateSalary()
        {
            double hra = 0, conv = 0, pf = 0, netSalary;

            if (Basic >= 30000)
            {
                hra = Basic * 0.3;
                conv = Basic * 0.3;
                pf = Basic * 0.3;
            }
            else if (Basic >= 20000)
            {
                hra = Basic * 0.2;
                conv = Basic * 0.2;
                pf = Basic * 0.2;
            }
            else
            {
                hra = Basic * 0.1;
                conv = Basic * 0.1;
                pf = Basic * 0.1;
            }

            netSalary = Basic + hra + conv - pf;

            return netSalary;
        }



        #endregion
    }
}
