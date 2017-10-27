using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Some of this code was taken from the resources folder on Blackboard 

namespace WorldSeriesWinners
{
    public partial class worldSeriesWinnersForm : Form
    {

        public worldSeriesWinnersForm()
        {
            InitializeComponent();
        }

        private void worldSeriesWinnersForm_Load(object sender, EventArgs e)
        {
            // Import the list into the program
            TeamLoadOnOpen();
        }

        // Import the teams into the present listbox
        private void TeamLoadOnOpen()
        {
            // Imported items assigned to variable
            string teams;

            // A StreamReader variable.
            StreamReader inputFile;

            // Open the file and get a StreamReader object.
            inputFile = File.OpenText("Teams.txt");

            //Clear anything in list box
            teamsListBox.Items.Clear();

            //Read the contents using loop
            while (!inputFile.EndOfStream)
            {
                //Get teams from file
                teams = inputFile.ReadLine();

                // Add teams to listbox
                teamsListBox.Items.Add(teams);
            }
            
        }

        // Method to control what happens on label select
        private void teamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Selected item and convert to string
            string selected = teamsListBox.Text;

            // Selected item to output to label
            outputValueLabel.Text = selected.ToString();

            if (outputValueLabel.Text == "Boston Americans")
            {
                MessageBox.Show("Boston Americans");
            }

        }
    }
}
