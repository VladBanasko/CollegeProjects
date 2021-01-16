using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTFVladyslavBanasko
{
    public partial class Form1 : Form


    {

        public static CreditCard CardInfo { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Month arrey
            string[] month = { "Month", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            cmbMonth.Items.AddRange(month);

            cmbMonth.SelectedIndex = 0;

            //year array
            int startYear = DateTime.Today.Year;
            int endYear = startYear + 5;

            while (startYear < endYear)
            {
                cmbYear.Items.Add(startYear);
                startYear++;
            }
            cmbYear.Items.Insert(0, "Year");
            cmbYear.SelectedIndex = 0;


        }

        private void btnProceed_Click(object sender, EventArgs e)
        { // read values fro Credit Card
            CardType type;
            if (rbVisa.Checked)
            {
                type = CardType.Visa;
            }
            else
            {
                type = CardType.Mastercard;
            }
            String name = txtboxName.Text;
            long number = long.Parse(txtboxNumber.Text);
            string dateMonth = cmbMonth.SelectedItem.ToString();
            string dateYear = cmbYear.SelectedItem.ToString();
            string expire = dateMonth + "/" + dateYear;
            int ccv = int.Parse(txtboxCCV.Text);
            // create credid card
            CreditCard card = new CreditCard(type, name, number, expire, ccv);
            // assign credit card to static value
            CardInfo = card;
            //load form 2
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }
        //method to check if all fields are filled
        private void ValidateForm()
        {
            if ((rbVisa.Checked || rbMaster.Checked) && txtboxName.Text.Trim() != "" && txtboxNumber.Text.Trim() != "" && cmbMonth.SelectedIndex != 0 && cmbYear.SelectedIndex != 0 && txtboxCCV.Text.Trim() != "")
            {
                btnProceed.Enabled = true;
            }
            else
            {
                btnProceed.Enabled = false;
            }
        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void txtboxNumber_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void txtboxCCV_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
