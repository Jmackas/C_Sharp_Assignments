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

                // Parsing of the variable
                inputNumberText = int.Parse(inputNumberText.Text);

            }

            catch
            {
                // Fallback to a broken solution 
                MessageBox.Show("Please enter an integer value.");
            }
        }
    }
}
