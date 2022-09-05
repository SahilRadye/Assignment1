using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public abstract class Employee
    {
        #region Field And Property

        public string Name { get; set; }

        public string Address { get; set; }       

        public int EmpNo { get; set; }  //Auto Implemented Property

        public string TypeEmployee { get; set; }

        #endregion

        #region Constructor

        public Employee()
        {
            EmpNo = Count;
            Count++;
        }

        public Employee(string name , string address) : this()
        {

            Name = name;
            Address = address;
        }

        #endregion

        #region Method

        public abstract double CalculateSalary();

        public override string ToString()
        {
            return String.Format($"Empno : {EmpNo} ,Name : {Name} , Address : {Address} , TypeEmployee : {TypeEmployee}");
        }
        
        #endregion

        #region Static Member

        private static int count;

        public static int Count
        {
            get { return count; }
            private set { count = value; }
        }


        static Employee()  //Using static 
        {
            count = 101;
        }
        #endregion
    }
}
