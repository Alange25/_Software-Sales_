using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Software_Sales_
{
    public partial class SoftwareSalesApplication : Form
    {
        public SoftwareSalesApplication()
        {
            InitializeComponent();
        }

        private void CalculateTotal_btn_Click(object sender, EventArgs e)
        {
           
                // Declaring the variables.
                double ONE_PACKAGE = 99;
                double discount = 0;
                double totalPurchase = 0;
                int numPackages = 0;

                // Get value from the packageTxt box and convert to integer.
                numPackages = Convert.ToInt32(packageTxt.Text);

                // Setting the discount value.
                if (numPackages >= 10 && numPackages <= 19)
                    discount = 0.20;
                else if (numPackages >= 20 && numPackages <= 49)
                    discount = 0.30;
                else if (numPackages >= 50 && numPackages <= 99)
                    discount = 0.40;
                else
                    discount = 0.50;

                // Calculate the total purchase.
                totalPurchase = ONE_PACKAGE * numPackages;

                // Calculate the discount amount.
                double discountAmt = totalPurchase * discount;

                // Set discount to discount label.
                discountLbl.Text = discountAmt.ToString("C2");

                // Set total purchase after discount to total purchase label.
                totalPurchaseLbl.Text = (totalPurchase - discountAmt).ToString("C2");


            }
       
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            // Clear all the text fields.
            packageTxt.Text = "";
            discountLbl.Text = "";
            totalPurchaseLbl.Text = "";

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            // The exit button.
            this.Close();
        }
    }
}
