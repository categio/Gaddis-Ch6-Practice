using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetFileName(out string selectedFile)
        {
            //if the user selected a file
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //open that selected file and hold in the variable selectedFile
                selectedFile = openFile.FileName;
            }
            else
            {
                //else selectedFile is blank
                selectedFile = "";

                //display a message to tell the user that file opening was cancelled
                MessageBox.Show("User cancelled file opening operation");
            }
        }
        private void GetCountries(string filename)
        {
            try
            {
                //create a string to hold the country names from the file
                string countryName;

                //declare StreamReader variable
                StreamReader inputFile;

                //opens file and creates a StreamReader obj
                inputFile = File.OpenText(filename);

                //clear contents of list box
                countriesListBox.Items.Clear();

                //while the file still has data to read
                while (!inputFile.EndOfStream)
                {
                    //variable holds the data of each line of the file
                    countryName = inputFile.ReadLine();

                    //variable adds the data from each line of the file to 
                    //the listbox
                    countriesListBox.Items.Add(countryName);
                }

                //close the file pulled by dialog box
                inputFile.Close();
            }
            catch (Exception ex)
            {
                //error message will display
                MessageBox.Show(ex.Message);
            }
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            //holds value of filename entered by user
            string filename;

            //get user entered filename
            GetFileName(out filename);

            //get countries from the text filename entered by user
            GetCountries(filename);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //clear list box
            countriesListBox.Items.Clear();

            //tell user what is happening
            MessageBox.Show("Clearing the entries to the list, exiting program.");

            //close the form
            this.Close();
        }
    }
}
