using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public class Calculator
    {

        #region Fields And Properties
        private int num1;

        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        private int num2;
        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
        #endregion

        #region Methods
        public int Addition()
        {
            return (num1 + num2);
        }

        public int Subtraction()
        {
            return (num1 - num2);
        }
        public int Multiply()
        {
            return (num1 * num2);
        }
        public int Division()
        {
            return (num1 / num2);
        }
        #endregion
    }
}
