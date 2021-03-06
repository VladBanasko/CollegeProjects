﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2VladyslavBanasko
{
    public partial class Form1 : Form
    {

        //dictionary to hold records of employees
        Dictionary<string, Employee> dictEmps = new Dictionary<string, Employee>();


        public Form1()
        {
            InitializeComponent();
        }

        private void rbCommisionBased_CheckedChanged(object sender, EventArgs e)
        {
            // change labels according to Employee type
            lblHoursWorked.Text = "Gross Sales";
            lblHourlyWage.Text = "Commision Rate";
            lblHourlyWage.Show();
            txtboxHourlyWage.Show();

        }

        private void rbHourlyRate_CheckedChanged(object sender, EventArgs e)
        {
            // change labels according to Employee type
            lblHoursWorked.Text = "Hours Worked";
            lblHourlyWage.Text = "Hourly Wage";
            lblHourlyWage.Show();
            txtboxHourlyWage.Show();

        }

        private void rbWeeklySalary_CheckedChanged(object sender, EventArgs e)
        {
            // change labels according to Employee type
            lblHoursWorked.Text = "Weekly Salary";
            lblHourlyWage.Hide();
            txtboxHourlyWage.Hide();
        }


        private bool HourlyValid() //method to check valid input for Hourly Employee
        {
            bool result = false;
            if (txtboxName.Text == "" || txtboxHoursWorked.Text == "" || txtboxHourlyWage.Text == "")
            {
                MessageBox.Show("All fields are required");
                result = true;
            }
            else if (dictEmps.ContainsKey(txtboxName.Text))
            {
                MessageBox.Show("Name already exist in list , please provide unique Name");
                result = true;
            }
            else if (int.Parse(txtboxHoursWorked.Text) < 0 || int.Parse(txtboxHoursWorked.Text) > 80)
            {
                MessageBox.Show("Hours worked can't must be positive number no more then 80");
                result = true;

            }
            else if (int.Parse(txtboxHoursWorked.Text) < 0 || int.Parse(txtboxHourlyWage.Text) < 0)
            {
                MessageBox.Show("hourly wage have to be a positive real number.");
                result = true;
            }

            return result;
        }

        private bool CommisionValid() //method to check valid input for Commision Employee
        {
            bool result = false;
            if (txtboxName.Text == "" || txtboxHoursWorked.Text == "" || txtboxHourlyWage.Text == "")
            {
                MessageBox.Show("All fields are required");
                result = true;
            }
            else if (dictEmps.ContainsKey(txtboxName.Text))
            {
                MessageBox.Show("Name already exist in list , please provide unique Name");
                result = true;
            }
            else if (int.Parse(txtboxHoursWorked.Text) < 0 || int.Parse(txtboxHourlyWage.Text) < 0)
            {
                MessageBox.Show(" commission rate or gross sales have to be a positive real number.");
                result = true;
            }

            return result;
        }

        private bool WeeklyValid() //method to check valid input for Salary Employee
        {
            bool result = false;
            if (String.IsNullOrEmpty(txtboxName.Text) || String.IsNullOrEmpty(txtboxHoursWorked.Text))
            {
                MessageBox.Show("All fields are required");
                result = true;
            }
            else if (dictEmps.ContainsKey(txtboxName.Text))
            {
                MessageBox.Show("Name already exist in list , please provide unique Name");
                result = true;
            }
            else if (int.Parse(txtboxHoursWorked.Text) < 0)
            {
                MessageBox.Show("weekly salary have to be a positive real number.");
                result = true;
            }

            return result;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rbHourlyRate.Checked) 
            {

                if (HourlyValid() == true) // validation for Hourly Employee
                {
                    txtboxName.Text = "";
                    txtboxHoursWorked.Text = "";
                    txtboxHourlyWage.Text = "";
                }
                else //If validation successful ,creation of new Hourly Employee, storing into Dictionary, adding to combobox of available Employees
                {

                    HourlyEmployee emp = new HourlyEmployee(txtboxName.Text, EmployeeType.Hourly_Rate, int.Parse(txtboxHoursWorked.Text), double.Parse(txtboxHourlyWage.Text));

                    dictEmps.Add(emp.Name, emp);

                    comboBox1.Items.Add(emp.Name);

                    txtboxTax.Text = $" {emp.Tax:C}";
                    txtboxNet.Text = $"{emp.NetEarnings:C}";
                    txtboxGross.Text = $"{emp.GrossEarnings:C}";
                }
            }
            if (rbCommisionBased.Checked) 
            {
                if (CommisionValid() == true) // validation of input
                {
                    txtboxName.Text = "";
                    txtboxHoursWorked.Text = "";
                    txtboxHourlyWage.Text = "";
                }
                else //If validation successful ,creation of new Commision Employee, storing into Dictionary, adding to combobox of available Employees
                {
                    CommissionEmployee emp = new CommissionEmployee(txtboxName.Text, EmployeeType.Commision_Based, int.Parse(txtboxHoursWorked.Text), double.Parse(txtboxHourlyWage.Text));

                    dictEmps.Add(emp.Name, emp);

                    comboBox1.Items.Add(emp.Name);

                    txtboxTax.Text = $" {emp.Tax:C}";
                    txtboxNet.Text = $"{emp.NetEarnings:C}";
                    txtboxGross.Text = $"{emp.GrossEarnings:C}";
                }
            }
            if (rbWeeklySalary.Checked)
            {
                if (WeeklyValid() == true)
                {
                    txtboxName.Text = "";
                    txtboxHoursWorked.Text = "";
                }
                else //If validation successful ,creation of new Weekly Salary Employee, storing into Dictionary, adding to combobox of available Employees
                {
                    SalariedEmployee emp = new SalariedEmployee(txtboxName.Text, EmployeeType.Weekly_Salary, double.Parse(txtboxHoursWorked.Text));

                    dictEmps.Add(emp.Name, emp);

                    comboBox1.Items.Add(emp.Name);

                    txtboxTax.Text = $" {emp.Tax:C}";
                    txtboxNet.Text = $"{emp.NetEarnings:C}";
                    txtboxGross.Text = $"{emp.GrossEarnings:C}";
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        { // clear all fields
            txtboxName.Clear();
            txtboxHourlyWage.Clear();
            txtboxHoursWorked.Clear();
            txtboxNet.Clear();
            txtboxGross.Clear();
            txtboxTax.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            String name = (String)comboBox1.SelectedItem; // retreiving name of Employee 

            if (dictEmps.TryGetValue(name, out Employee emp)) // if Employee exists, show his information
            {
                txtboxName.Text = emp.Name;
                if (emp.TypeOfEmployee.Equals(EmployeeType.Hourly_Rate))
                {
                    rbHourlyRate.Checked = true;

                    txtboxHoursWorked.Text = $"{emp.HoursWorked}";
                    txtboxHourlyWage.Text = $"{emp.HourlyWage}";


                    txtboxGross.Text = $"{emp.GrossEarnings:C}";
                    txtboxTax.Text = $"{emp.Tax}";
                    txtboxNet.Text = $"{emp.NetEarnings}";

                }
                else if (emp.TypeOfEmployee.Equals(EmployeeType.Commision_Based))
                {
                    rbCommisionBased.Checked = true;

                    txtboxHoursWorked.Text = $"{emp.GrossSales}";
                    txtboxHourlyWage.Text = $"{emp.CommissionRate}";

                    txtboxGross.Text = $"{emp.GrossEarnings:C}";
                    txtboxTax.Text = $"{emp.Tax:C}";
                    txtboxNet.Text = $"{emp.NetEarnings:C}";
                }
                else if (emp.TypeOfEmployee.Equals(EmployeeType.Weekly_Salary))
                {
                    rbWeeklySalary.Checked = true;

                    txtboxHoursWorked.Text = $"{emp.GrossEarnings:C}";

                    txtboxGross.Text = $"{emp.GrossEarnings:C}";
                    txtboxTax.Text = $"{emp.Tax:C}";
                    txtboxNet.Text = $"{emp.NetEarnings:C}";
                }




            }


        }
    }
}

