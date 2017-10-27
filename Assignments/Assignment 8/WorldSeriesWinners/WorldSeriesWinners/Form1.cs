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

// I am also aware that this is probably the worst way to go about the program, but it does work to the user's request.

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
            // Invoke method on item select
            ListboxToLabel();

            // Invoke method to determine how many wins the team has incurred
            howManyWinsToLabel();
        }

        // Outputs the listbox item selected to label
        private void ListboxToLabel()
        {
            // Selected item and convert to string
            string selected = teamsListBox.Text;

            // Selected item to output to label
            outputValueLabel.Text = selected.ToString();
        }

        private void howManyWinsToLabel()
        {
            // Outputs how many wins Anaheim Angels have incurred
            if (outputValueLabel.Text == "Anaheim Angels")
            {
                // Declaration of wins
                int wins = 1;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Arizona Diamondbacks have incurred
            else if (outputValueLabel.Text == "Arizona Diamondbacks")
            {
                // Declaration of wins
                int wins = 1;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Atlanta Braves have incurred
            else if (outputValueLabel.Text == "Atlanta Braves")
            {
                // Declaration of wins
                int wins = 1;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Baltimore Orioles have incurred
            else if (outputValueLabel.Text == "Baltimore Orioles")
            {
                // Declaration of wins
                int wins = 3;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Boston Americans have incurred
            else if (outputValueLabel.Text == "Boston Americans")
            {
                // Declaration of wins
                int wins = 1;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Boston Braves have incurred
            else if (outputValueLabel.Text == "Boston Braves")
            {
                // Declaration of wins
                int wins = 1;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Boston Red Sox have incurred
            else if (outputValueLabel.Text == "Boston Red Sox")
            {
                // Declaration of wins
                int wins = 6;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Brooklyn Dodgers have incurred
            else if (outputValueLabel.Text == "Brooklyn Dodgers")
            {
                // Declaration of wins
                int wins = 1;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Chicago Cubs have incurred
            else if (outputValueLabel.Text == "Chicago Cubs")
            {
                // Declaration of wins
                int wins = 2;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Chicago White Sox have incurred
            else if (outputValueLabel.Text == "Chicago White Sox")
            {
                // Declaration of wins
                int wins = 3;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Cincinnati Reds have incurred
            else if (outputValueLabel.Text == "Cincinnati Reds")
            {
                // Declaration of wins
                int wins = 5;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Cleveland Indians have incurred
            else if (outputValueLabel.Text == "Cleveland Indians")
            {
                // Declaration of wins
                int wins = 2;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Detroit Tigers have incurred
            else if (outputValueLabel.Text == "Detroit Tigers")
            {
                // Declaration of wins
                int wins = 4;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Florida Marlins have incurred
            else if (outputValueLabel.Text == "Florida Marlins")
            {
                // Declaration of wins
                int wins = 2;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Kansas City Royals have incurred
            else if (outputValueLabel.Text == "Kansas City Royals")
            {
                // Declaration of wins
                int wins = 1;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Los Angeles Dodgers have incurred
            else if (outputValueLabel.Text == "Los Angeles Dodgers")
            {
                // Declaration of wins
                int wins = 5;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Milwaukee Braves have incurred
            else if (outputValueLabel.Text == "Milwaukee Braves")
            {
                // Declaration of wins
                int wins = 1;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Minnesota Twins have incurred
            else if (outputValueLabel.Text == "Minnesota Twins")
            {
                // Declaration of wins
                int wins = 2;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins New York Giants have incurred
            else if (outputValueLabel.Text == "New York Giants")
            {
                // Declaration of wins
                int wins = 7;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins New York Mets have incurred
            else if (outputValueLabel.Text == "New York Mets")
            {
                // Declaration of wins
                int wins = 2;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins New York Yankees have incurred
            else if (outputValueLabel.Text == "New York Yankees")
            {
                // Declaration of wins
                int wins = 27;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Oakland Athletics have incurred
            else if (outputValueLabel.Text == "Oakland Athletics")
            {
                // Declaration of wins
                int wins = 4;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Philadelphia Athletics have incurred
            else if (outputValueLabel.Text == "Philadelphia Athletics")
            {
                // Declaration of wins
                int wins = 7;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Pittsburgh Pirates have incurred
            else if (outputValueLabel.Text == "Pittsburgh Pirates")
            {
                // Declaration of wins
                int wins = 5;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins San Francisco Giants have incurred
            else if (outputValueLabel.Text == "San Francisco Giants")
            {
                // Declaration of wins
                int wins = 2;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins San Francisco Giants have incurred
            else if (outputValueLabel.Text == "St. Louis Cardinals")
            {
                // Declaration of wins
                int wins = 11;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Toronto Blue Jays have incurred
            else if (outputValueLabel.Text == "Toronto Blue Jays")
            {
                // Declaration of wins
                int wins = 2;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Washington Senators have incurred
            else if (outputValueLabel.Text == "Washington Senators")
            {
                // Declaration of wins
                int wins = 1;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }

            // Outputs how many wins Pittsburgh Pirates have incurred
            else if (outputValueLabel.Text == "Philadelphia Phillies")
            {
                // Declaration of wins
                int wins = 0;
                // Output to label
                outputValueLabel.Text = wins.ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the application on button select
            this.Close();
        }
    }
}
