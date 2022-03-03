using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TurnLightOn()
        {
            //display the light on image
            lightOnPictureBox.Visible = true;

            //hide light off image
            lightOffPictureBox.Visible = false;

            //update label under bulbs
            lightStateLabel.Text = "ON";
        }

        private void TurnLightOff()
        {
            //hide light on image
            lightOnPictureBox.Visible = false;

            //display light off image
            lightOffPictureBox.Visible = true;

            //update label under bulbs
            lightStateLabel.Text = "OFF";
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            //Display the proper image for the button click
            if (lightOnPictureBox.Visible == true)
            {
                TurnLightOff();
            }
            else
            {
                TurnLightOn();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
