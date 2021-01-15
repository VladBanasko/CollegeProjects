using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1VladyslavBanasko
{
    public partial class Form1 : Form
    {

        private double subtotal = 0.0;
        private double tax = 0.0;
        private double total = 0.0;
        public Form1()
        {
            InitializeComponent();
        }
        //function to add items to list and add prices to total
        private void makeBill(ComboBox cmb)
        {
            if (cmb.SelectedIndex > 0)
            {
                //add item to list
                listBox1.Items.Add(cmb.SelectedItem);
                //retrive price from list
                string[] price = cmb.Text.Split('$');
                double price2 = double.Parse(price[1]);
                //add amount to subtotal, calculate tax and total
                subtotal += price2;
                tax = subtotal * 0.13;
                total = subtotal + tax;
                //show price
                txtSubtotal.Text = subtotal.ToString("C");
                txtTax.Text = tax.ToString("C");
                txtTotal.Text = total.ToString("C");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // arreys with items of products
            string[] bevareges = { "Soda - $1,95", "Tea - $1,50", "Coffee - $1,25", "Mineral Water  - $2,95", "Juice - $2,50" };
            string[] appetaizers = { "Buffalo Wings - $5,95", "Buffalo Fingers - $6,95", "Nachos - $8,95", "Mushroom Caps - $10,95", "Chips and Salsa - $6,95" };
            string[] main = { "Chicken Alfredo - $13,95", "Turckey Club - $11,95", "Prime Rib - $20,95", "Turckey Dinner - $13,95", "Stuffed Chiken - $14,95" };
            string[] desserts = { "Apple Pie - $5,95", "Sundae - $3,95", "Carrot Cake - $5,95", "Apple Crisp - $5,95" };
            // adding select option as first option
            cmbBeverages.Items.Insert(0, "Select Beverages");
            cmbAppetizers.Items.Insert(0, "Select Appetizers");
            cmbMain.Items.Insert(0, "Select Main");
            cmbDeserts.Items.Insert(0, "Select Desert");
            // adding arreys to comboboxes
            cmbBeverages.Items.AddRange(bevareges);
            cmbAppetizers.Items.AddRange(appetaizers);
            cmbMain.Items.AddRange(main);
            cmbDeserts.Items.AddRange(desserts);
            // selecting first option as default
            cmbBeverages.SelectedIndex = 0;
            cmbAppetizers.SelectedIndex = 0;
            cmbMain.SelectedIndex = 0;
            cmbDeserts.SelectedIndex = 0;
            // showing 0.00 as default
            txtSubtotal.Text = subtotal.ToString("C");
            txtTax.Text = tax.ToString("C");
            txtTotal.Text = total.ToString("C");



        }

        private void cmbBeverages_SelectedIndexChanged(object sender, EventArgs e)
        {
            makeBill(cmbBeverages);
        }

        private void cmbAppetizers_SelectedIndexChanged(object sender, EventArgs e)
        {
            makeBill(cmbAppetizers);
        }

        private void cmbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            makeBill(cmbMain);
        }

        private void cmbDeserts_SelectedIndexChanged(object sender, EventArgs e)
        {
            makeBill(cmbDeserts);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // set all field to default and clear list
            subtotal = 0.0;
            tax = 0.0;
            total = 0.0;
            txtSubtotal.Text = subtotal.ToString("C");
            txtTax.Text = tax.ToString("C");
            txtTotal.Text = total.ToString("C");
            listBox1.Items.Clear();
            cmbBeverages.SelectedIndex = 0;
            cmbAppetizers.SelectedIndex = 0;
            cmbMain.SelectedIndex = 0;
            cmbDeserts.SelectedIndex = 0;
        }
    }


}

