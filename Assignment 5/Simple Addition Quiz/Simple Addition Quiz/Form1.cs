using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Input validation isn't essential for this, as the program will remind the user an error is present. 

namespace Simple_Addition_Quiz
{
    public partial class simpleAdditionQuizForm : Form
    {
        // Initialisation of the random number addition output
        private int correctResultNumber;

        public simpleAdditionQuizForm()
        {
            InitializeComponent();
            
            // Loads the intial random numbers generated
            preloadData();
        }

        private void solutionGenerator_Click(object sender, EventArgs e)
        {
            // Start the algorithm to check the user's answer
            buttonSelectTwo_Click();

            // Restart form to reset the values
            Application.Restart();
        }

        private void preloadData()
        {
            // No try catch necessary as no user input therefore no exceptions expected

                // Initialisation of the two random addition variables
                int randomNumOne, randomNumTwo;

                // Generate random numbers
                Random rand = new Random();

                // Generate random number between 100-500 and assign to randNumOne variable
                randomNumOne = rand.Next(100, 500 + 1);

                // Generate random number between 100-500 and assign to randNumOne variable
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
                // Initialisation of the user input variable
                int inputNumberText;

                // Conversion of input string to integer
                int.TryParse(inputNumberTextBox.Text, out inputNumberText);

                // If-else to determine if the user input is correct
                if (inputNumberText == correctResultNumber)
                {
                    // If user answer is correct, then display 'Correct'
                    MessageBox.Show("Correct");
                }

                else
                {
                    // If user answer is not correct, then tell them the answer is incorrect, and display the correct answer
                    MessageBox.Show("Incorrect, the answer is " + correctResultNumber);
                }
            }

            catch
            {
                // Catch potential error if an exception is thrown via the user input
                MessageBox.Show("Please enter a whole, positive, number.");
            }

        }


    }
}
