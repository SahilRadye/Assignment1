using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//PascalCase : ProjName, ClassName, MethodName , PropertyName , EventName
//camelCase :

namespace OOPsDemoApp
{
    internal class Rectangle
    {
        //member field and method

        //field

        #region Fields And Properties
        private int length; //camelCase

        public int Length  // PascalCase
        {
            get { return length; }   //reading
            set { length = value; }  //assignment
        }

        private int width; //camelCase

        public int Width  // PascalCase
        {
            get { return width; }   //reading
            set { width = value; }  //assignment
        }
        #endregion

        #region Methods
        public int GetArea()
        {
            return length * width;
        }

        public override string ToString()
        {
            //Traditional
            //return "Length = " + Length + "Width = " + Width;

            //Formatted 
            //return String.Format("Length = {0} Width = {1}", Length , Width);

            //String interpolation
            return String.Format($"Length = {Length} Width = {Width}");
        }

        #endregion

        #region Constructor
        public Rectangle()
        {
            Length = 1;
            Width = 1;
            count++;
        }

        // parameterized constructor  

        public Rectangle(int _length, int _width) :this()
        {
            Length = _length;
            Width = _width;
        }

        #endregion

        #region Static Members

        private static int count;

        public static int Counter
        {
            get { return count; }   
        }

        //static constructor
        static Rectangle()
        {
            count = 100;
        }
        #endregion
    }
}
