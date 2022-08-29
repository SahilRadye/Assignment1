using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLib
{
    public class Product
    {

        #region Field And Properties
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }   
            set { price = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        #endregion

        #region Constructor
        public Product(string _productname, int _quantity, double _price)
        {
            ProductName = _productname;
            Price = _price;
            Quantity = _quantity;
        }
        #endregion

        #region Method
        public double GetProductCost()
        {
            return quantity * price;
        }

        public override string ToString()
        {
            return String.Format($"ProuctName = {ProductName},  Price = {Price} ,Quantity = {Quantity}, Cost = {Quantity*Price}");
        }
        #endregion


    }
}
