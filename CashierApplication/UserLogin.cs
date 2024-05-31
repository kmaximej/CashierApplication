using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        private Cashier cashier;

        private void button1_Click(object sender, EventArgs e)
        {
            cashier = new Cashier("Kate Maxime", "Finance", textBoxUser.Text, textBoxPass.Text);

            if (cashier.validateLogin(textBoxUser.Text, textBoxPass.Text))
            {
                MessageBox.Show("Welcome " + cashier.getFullName() + " of " + cashier.getDepartment(), "Success", MessageBoxButtons.OK);
                frmPurchaseDiscountedItem frm = new frmPurchaseDiscountedItem();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Login Failed", "", MessageBoxButtons.OK);
            }
        }
    }
}
