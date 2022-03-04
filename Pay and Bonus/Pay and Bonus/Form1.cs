using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        //const field for contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        //boolean to return true if value can convert properly (input is good). 
        private bool InputIsValid(ref decimal pay, ref decimal bonus)
        {
            //set variable to false to start before checking if val is good.
            bool inputGood = false;

            //tryparse to check if value is decimal
            if (decimal.TryParse(grossPayTextBox.Text, out pay))
            {
                if (decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    //if both are parse-able, input is good
                    inputGood = true;
                }
                else
                {
                    inputGood = false;
                    //display input error msg for bonus
                    MessageBox.Show("Bonus amount entered is not a numerical value.");
                }
            }
            else
            {
                inputGood = false;
                //display input error msg for pay
                MessageBox.Show("Gross pay entered is not a numerical value.");
            }
            return inputGood;
        }

        private void ClearAllClose()
        {
            //clear entered data and printed data
            contributionLabel.Text = "";
            grossPayTextBox.Text = "";
            bonusTextBox.Text = "";

            //display msg to tell user program is closing and clearing data
            MessageBox.Show("Clearing entered & printed data. Closing program.");
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //variables for gross pay, bonus and contributions
            decimal pay = 0m, bonus = 0m, contrib = 0m;
            if (InputIsValid(ref pay, ref bonus))
            {
                //calc amt of contribution
                contrib = (pay + bonus) * CONTRIB_RATE;

                //display contribution
                contributionLabel.Text = contrib.ToString("c");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //clear and close function
            ClearAllClose();

            //close the form/prog
            this.Close();
        }
    }
}
