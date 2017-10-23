using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paintEstimator
{

    public partial class Form1 : Form
    { 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolveValues_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Declaration of top two input fields
                decimal paintArea, paintPrice;

                // Declaration of output variables
                decimal paintRequired, laborHours, paintCost, laborCost, overallCost;

                // Input values of inputPaintArea assigned to paintArea
                paintArea = decimal.Parse(inputPaintArea.Text);

                // Input values of inputPaintPrice assigned to paintPrice
                paintPrice = decimal.Parse(inputPaintPrice.Text);


                // Algorithm for 'Paint Required for the Job'
                    // Formula
                    paintRequired = paintArea / 115;
                    // Output
                    outputPaintRequired.Text = paintRequired.ToString();

                // Algorithm for 'The hours of labor required'
                // Formula
                laborHours = paintRequired * 8;
                    // Output
                    outputLaborHours.Text = laborHours.ToString();

                // Algorithm for 'The cost of the paint'
                    // Formula
                    paintCost = paintRequired * paintPrice;
                    // Output
                    outputPaintCost.Text = paintCost.ToString("c");

                // Algorithm for 'The labor charges'
                    // Formula
                    laborCost = laborHours * 20;
                    // Output
                    outputLaborCost.Text = laborCost.ToString("c");

                // Algorithm for 'The overall cost'
                    // Formula
                    overallCost = paintCost + laborCost;
                    // Output
                    outputOverallCost.Text = overallCost.ToString("c");

            

            }
            catch
            {
                MessageBox.Show("Please input both values.");
            }

        }
    }
}
