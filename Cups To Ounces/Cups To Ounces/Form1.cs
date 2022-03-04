using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CupsToOz(double cups)
        {
            return cups * 8.0;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //variables to hold values of cups, oz etc
            double cups, oz;

            //get no of cups
            if (double.TryParse(cupsTextBox.Text, out cups))
            {
                //convert c to oz
                oz = CupsToOz(cups);

                //display oz
                ouncesLabel.Text = oz.ToString("n1");
            }
            else
            {
                //display non numerical val error
                MessageBox.Show("Please enter a numerical value.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //clear data in the boxes
            cupsTextBox.Text = "";
            ouncesLabel.Text = "";

            //display a message explaining what is happening
            MessageBox.Show("Clearing entered data, closing the program");

            //exit the program/form
            this.Close();
        }
    }
}
