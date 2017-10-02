using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Addition_Quiz
{
    public partial class simpleAdditionQuizForm : Form
    {
        // Initialisation of the random number addition output
        private int correctResultNumber;

        public simpleAdditionQuizForm()
        {
            InitializeComponent();
            // Loads the intial random numbers
            preloadData();
        }

        private void solutionGenerator_Click(object sender, EventArgs e)
        {
            // Select 
            buttonSelectTwo_Click();
            Application.Restart();
        }

        private void preloadData()
        {
                // Initialisation of the two random addition variables
                int randomNumOne, randomNumTwo;

                // Generate random numbers
                Random rand = new Random();

                // Generate random number between 0-100 and assign to randNumOne variable
                randomNumOne = rand.Next(100, 500 + 1);

                // Generate random number between 0-100 and assign to randNumOne variable
                randomNumTwo = rand.Next(100, 500 + 1);

                // Output the random number to randomNumOneLabel
                randomNumOneLabel.Text = randomNumOne.ToString();

                // Output the random number to randomNumTwoLabel
                randomNumTwoLabel.Text = randomNumTwo.ToString();

                // Formula to find the result of the random number
                correctResultNumber = randomNumOne + randomNumTwo;

        }

        private void buttonSelectTwo_Click()
        {
            try
            {
                // Initialisation of the input variable
                int inputNumberText;

                // Conversion of input string to integer
                int.TryParse(inputNumberTextBox.Text, out inputNumberText);

                if (inputNumberText == correctResultNumber)
                {
                    MessageBox.Show("Correct");
                }

                else
                {
                    MessageBox.Show("Incorrect, the answer is " + correctResultNumber);
                }
            }

            catch
            {
                MessageBox.Show("Please enter an integer value.");
            }

        }


    }
}
