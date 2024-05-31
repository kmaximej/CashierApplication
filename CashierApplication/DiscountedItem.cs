using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_amount;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            this.Item_name = name;
            this.change = price;
            this.Item_quantity = quantity;
            this.item_discount = discount;
        }
        public override double GetTotalPrice()
        {
            item_discount = item_discount * 0.01;
            discounted_amount = Item_price - (item_discount * Item_price);
            Item_TotalPrice = discounted_amount * Item_quantity;
            return Item_TotalPrice;
        }
        public override void setPayment(double amount) 
        {
            payment_amount = amount;
        }
        public double getChange() 
        {
            change = payment_amount - GetTotalPrice();
            return change;
        }
    } 
}
