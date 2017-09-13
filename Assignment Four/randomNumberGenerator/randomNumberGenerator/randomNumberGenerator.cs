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

namespace randomNumberGenerator
{
    public partial class randomNumberGenerator : Form
    {
        private object saveFile;

        public randomNumberGenerator()
        {
            InitializeComponent();
        }

        // I am using Camel Case for the naming, but Visual Studio seems to have an issue with the lowercase first word and uppercase last word. What are the usual best practices?

        // Calculations
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaration of variables
                int maxNum;
                int count = 1;

                // Convert user input to text
                maxNum = int.Parse(inputMaximumLabel.Text);

                // Input validation, ensuring the user has entered a number greater than 0.
                if (maxNum <= 0)
                {
                    MessageBox.Show("Please enter a number above 0");
                    inputMaximumLabel.Text = "";
                }

                // Random number object
                // Declaration of random number
                Random rand = new Random();

                // Declaration of the StreamWriter variable
                StreamWriter outputFile;

                // Output file creation 
                outputFile = File.CreateText("Numbers.Text");


                SaveFileDialog saveFileControl = new SaveFileDialog();

                // Forcing the user to output the file type '.txt'
                saveFileControl.Filter = "Text Files | *.txt";

                // If statement that opens the save dialog
                if (saveFileControl.ShowDialog() == DialogResult.OK)
                {
                    // Save dialog to create a new file
                    using (Stream s = File.Open(saveFileControl.FileName, FileMode.CreateNew))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        // Loop that outputs the randomly generated numbers to file
                        while (count <= maxNum)
                        {
                            // The counter variable (declared initially above)
                            count++;
                            // Output of the randomly generated + line space
                            sw.Write(rand.Next(100) + Environment.NewLine);
                        }

                    }
                }

                // Exit of the saving 
                outputFile.Close();
            }

            catch
            {
                // Fallback to a broken 
                MessageBox.Show("Please enter an integer value.");
            }
        }

        // Exit program on button select
        private void exitProgramButton_Click(object sender, EventArgs e)
        {
            // Close the form on button select
            this.Close();
        }

        // Clear the input on button select
        private void clearForm_Click(object sender, EventArgs e)
        {
            // Clear the input label on button select
            inputMaximumLabel.Text = "";
        }
    }
}
