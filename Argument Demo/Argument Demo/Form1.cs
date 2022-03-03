using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argument_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayValue(int value)
        {
            MessageBox.Show(value.ToString());
        }
        private void DemoOne()
        {
            MessageBox.Show("The initial Value of the variable is: ");
        }

        private void DemoTwo()
        {
            MessageBox.Show("The value of the variable when added to 3 is: ");
        }

        private void DemoThree()
        {
            MessageBox.Show("5 message boxes will appear to show a value of the variable "+
                "that is incrementally increasing by 1 as long as the value is less than 5.");
        }

        private void demo1Button_Click(object sender, EventArgs e)
        {
            //call DemoOne to explain the variable value
            DemoOne();

            // Call DisplayValue passing 5 as an argument.
            DisplayValue(5);
        }

        private void demo2Button_Click(object sender, EventArgs e)
        {
            //call DemoTwo to explain the variable value
            DemoTwo();

            // Call DisplayValue passing the expression 3 + 5
            // as an argument.
            DisplayValue(3 + 5);
        }

        private void demo3Button_Click(object sender, EventArgs e)
        {
            // call DemoThree to explain the next sequence of events
            DemoThree();

            // Use a loop to call DisplayValue 5 times.
            for (int count = 0; count < 5; count++)
            {
                DisplayValue(count);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //thank the person for using the form
            MessageBox.Show("Thank you for coming to my Ted Talk.");

            // Close the form.
            this.Close();
        }
    }
}
