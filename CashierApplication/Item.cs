using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal abstract class Item
    {
        protected string Item_name;
        protected double Item_price;
        protected int Item_quantity;
        protected double Item_TotalPrice;

        public Item(string name, double price, int quantity) 
        {
            Item_name = name;
            Item_price = price;
            Item_quantity = quantity;
        }
       public abstract double GetTotalPrice();
       public abstract void setPayment(double amount);
    }
}
