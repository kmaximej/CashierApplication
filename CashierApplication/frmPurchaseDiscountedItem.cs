using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private DiscountedItem discountedItem;
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            string item = textBoxItem.Text;
            double price, discount;
            price = Convert.ToDouble(textBoxPrice.Text);
            discount = Convert.ToDouble(textBoxDiscount.Text);
            int quantity = Convert.ToInt32(textBoxQuanty.Text);

            discountedItem = new DiscountedItem(item, price, quantity, discount);
            double TotalPrice = discountedItem.GetTotalPrice();
            labelTotal.Text = TotalPrice.ToString();
        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string item = textBoxItem.Text;
            double price, discount;
            price = Convert.ToDouble(textBoxPrice.Text);
            discount = Convert.ToDouble(textBoxDiscount.Text);
            int quantity = Convert.ToInt32(textBoxQuanty.Text);

            DiscountedItem items = new DiscountedItem(item, price, quantity, discount);
            items.setPayment(Convert.ToDouble(textBoxPayment.Text));
            labelChange.Text = items.getChange().ToString();

        }
    }
}
