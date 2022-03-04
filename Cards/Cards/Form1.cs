using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowCard(string card)
        {
            //set up the switch for whatever card is chosen in the list box
            //calling the method set for that card.
            switch (card)
            {
                case "Ace of Spades":
                    ShowAceSpades();

                    break;

                case "10 of Hearts":
                    ShowTenHearts();

                    break;

                case "King of Clubs":
                    ShowKingClubs();

                    break;
            }
        }
        
        //method for making Ace of Spades visible
        private void ShowAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }

        //method for makng Ten of Hearts visible
        private void ShowTenHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }

        //method for making King of Clubs visible
        private void ShowKingClubs()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            //to check value of selected list box item.
            //no -1 index for list box, means nothing is selected.
            if (cardListBox.SelectedIndex != -1)
            {
                //if an item is selected
                ShowCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                //if an item is not selected
                MessageBox.Show("Please select a card from " +
                    "the list.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //message boxes to say thanks to the user and goodbye
            MessageBox.Show("Thank you for playing!");
            MessageBox.Show("Goodbye");

            //close the form/program
            this.Close();
        }
    }
}
