﻿using System;
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

        // Calculations
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {

                // Declaration of variables
                int maxNum;
                int count = 1;

                // Input parsing fields
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

                // While 
                while (count <= maxNum)
                {

                    outputFile.WriteLine(rand.Next(100));
                    count++;
                }


                SaveFileDialog saveFileControl = new SaveFileDialog();

                saveFileControl.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileControl.FilterIndex = 2;
                saveFileControl.RestoreDirectory = true;

                if (saveFileControl.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("You clicked the Open button.");
                }
                else
                {
                    MessageBox.Show("You clicked the Cancel button.");
                }


                outputFile.Close();






            }

            catch
            {
                MessageBox.Show("Please enter an integer value.");
            }
        }

        // Exit program on button select
        private void exitProgramButton_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        // Clear the input on button select
        private void clearForm_Click(object sender, EventArgs e)
        {
            inputMaximumLabel.Text = "";
        }


    }
}
