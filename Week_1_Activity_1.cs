using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_WEEK_1_ACTIVITY_1
{
    //This class is deticated the the wxDaniel analytics pay calculator application
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Main logic of program with user enter data. Hourly rate and worked hours giving gross pay amount. Also a try and catch 
        //to be more user friendly when wrong information in fields is entered
        public void calculatePay_Click(object sender, EventArgs e)
        {
            try
            {
                string fullname;
                //Parse string data to double variables - hours worked 
                var hoursWorked = double.Parse(hoursWorkedInput.Text);
                //parse string data to double variables - hourly rate
                var hourlyRate = double.Parse(hourlyRateInput.Text);
                //multiple hours * rate
                var grossPay = hoursWorked * hourlyRate;
                //Display data for user:
                fullname = "Employee Name: " + employeeFirstName.Text + " " + employeeLastName.Text + "    Identification Number: " + employeeNumber.Text + "    Week Gross Pay: " + grossPay.ToString("c");
                displayRequestedInfo.Text = fullname;
                MessageBox.Show("Please tell the Employee that Overtime is not Permitted! This may result in Discplinary Action");


            }
            catch
            {
                MessageBox.Show("Please only enter valid numbers");
            }
            }
        //User warning not to click image
        private void blackBox_Click(object sender, EventArgs e)
        {
            dontClickImage.Text = "Please do not click on this image!";
        }
        //Exit the Program
        private void cancelRequest_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
    }
}
