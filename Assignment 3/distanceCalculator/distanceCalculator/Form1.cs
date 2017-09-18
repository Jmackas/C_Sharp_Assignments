using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distanceCalculator
{
    public partial class distanceCalculator : Form
    {
        public distanceCalculator()
        {
            InitializeComponent();
        }

        // I have acknowledged the name violation below, but am not quite sure why its occuring.
        private void calculateValues_Click(object sender, EventArgs e)
        {
            try
            {
                // Clears the current data in the list boxes (if there is any), before the essential components of the program are executed.
                vVehicleDistance.Items.Clear();

                // Variable declarations
                    // Declaration of input variables.
                    int vSpeed, vHours;

                    // Declaration of output variables.
                    int vDistance;

                    // Declaration of loop counter.
                    int count = 1;

                // Input parsing fields
                    // Input value 'speed' assigned to variable.
                    vSpeed = int.Parse(inputSpeed.Text);

                    // Input value 'hours' assigned to a variable.
                    vHours = int.Parse(inputHours.Text);

                // Input validation checks
                    // Realistic input validation for 'inputSpeed'. 
                    if ((vSpeed >= 500 || vSpeed <= 0))
                    {
                        MessageBox.Show("Please enter a realistic speed.");
                    }

                    // Realistic Input validation for 'inputHours'. 
                    if ((vHours >= 400 || vHours <= 0))
                    {
                        MessageBox.Show("Please enter a realistic amount of time travelled.");
                    }


                // Commencement of while loop.
                while (count <= vHours)
                { 

					// Algorithm to determine vehicle distance travelled for each hour.
				    vDistance = + vSpeed * count;
                
                    // Outputting the hours travelled and its respective kilometres travelled.
                    vVehicleDistance.Items.Add("The " + "distance " + "travelled " + "in " + count.ToString() + " hour/s" + " is " + vDistance.ToString() + " kms");

                    // Repeats the loop via incrementation of each hour.
                    count++;
                }

            }
            // Failsafe to the program potentially crashing.
            catch
            {
                MessageBox.Show("Please enter valid character");
            }
        }

        private void exitProgram_Click(object sender, EventArgs e)
        {
            // Close the program on button select.
            Close();
        }
    }
}
