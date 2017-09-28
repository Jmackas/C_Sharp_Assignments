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
        public simpleAdditionQuizForm()
        {
            InitializeComponent();
        }

        private void solutionGenerator_Click(object sender, EventArgs e)
        {
            // Try catch block to 'catch' any errors
            try
            {
                // Initialisation of the two random addition variables
                int randomNumOne, randomNumTwo;

                // Initialisation of the input variable
                int inputNumberText;

                // Conversion of input string to integer
                inputNumberText = int.Parse(inputNumberTextBox.Text);

                // Generate random numbers
                Random rand = new Random();

                // Generate random number between 0-100 and assign to randNumOne variable
                randomNumOne = rand.Next(100 + 1);




                randomNumOneLabel.Text = randomNumOne.ToString();
            }

            catch
            {
                // Fallback to a broken solution 
                MessageBox.Show("Please enter an integer value.");
            }
        }
    }
}



// Random rand = new Random();