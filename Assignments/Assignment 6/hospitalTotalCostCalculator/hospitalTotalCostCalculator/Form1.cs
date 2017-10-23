using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalTotalCostCalculator {
    public partial class hospitalTotalCostCalculator : Form {
        /* Variable declaration for amount of days at hospital, medication, surgical, lab, and rehabilitation fee input */
        decimal amountOfDays, medicationCharges, surgicalCharges, labFees, rehabilitationFees;

        /* Constant declaration for static price of day at hospital */
        const decimal ONEDAYCOST = 350;

        /* Variable declaration for output of added costs */
        decimal totalMiscCharges;

        /* Variable declaration for output cost for living at the hospital */
        decimal totalHospitalStayCost;

        /* Variable declaration for the overall cost */
        decimal totalHospitalCost;

        public hospitalTotalCostCalculator () {
            InitializeComponent ();
        }

        /* On 'calculate' button select method */
        private void calculateTotalCostButton_Click_1 (object sender, EventArgs e) {

            /* Validation of all user input */
            DataValidation ();

            /* Invokes the 'CalcStayCharge' method */
            CalcStayCharge ();

            /* Invokes the 'CalcMiscCharges' method */
            CalcMiscCharges ();

            /* Invokes the 'CalcTotalCharges' method */
            CalcTotalCharges ();
        }

        private void DataValidation () {
            try {
                /* Parsing user input */
                decimal.TryParse (amountOfDaysText.Text, out amountOfDays);
                decimal.TryParse (medicationChargesText.Text, out medicationCharges);
                decimal.TryParse (surgicalChargesText.Text, out surgicalCharges);
                decimal.TryParse (labFeesText.Text, out labFees);
                decimal.TryParse (rehabilitationFeesText.Text, out rehabilitationFees);

                /* If statement that checks if the user has entered a number less than 0 for any of the inputs. If they have, then restart the program */
                if (amountOfDays < 0 && medicationCharges < 0 && surgicalCharges < 0 && labFees < 0 && rehabilitationFees < 0) {
                    MessageBox.Show ("Please don't enter a negative number");
                    Application.Restart ();
                }

                /* Try catch block to 'catch' any exceptions */
            } catch {
                MessageBox.Show ("Please enter a valid number");
            }
        }

        /* Method for calculating the base charge for staying at the hospital */
        private void CalcStayCharge () {

            /* Algorithm to determine the final cost (for this method) */
            totalHospitalStayCost = amountOfDays * ONEDAYCOST;
        }

        /* Method for calculating the medication, surgical, lab, and rehabilitation fees */
        private void CalcMiscCharges () {
            /* Algorithm to determine the final cost (for this method) */
            totalMiscCharges = medicationCharges + surgicalCharges + labFees + rehabilitationFees;
        }

        /* Method for calculating the added costs of the methods CalcStayCharge() and CalcMiscCharges() */
        private void CalcTotalCharges () {
            /* Algorithm to collate the final costs of the other methods and output to user */
            totalHospitalCost = totalMiscCharges + totalHospitalStayCost;

            /* Output to user */
            finalCostOutputLabel.Text = totalHospitalCost.ToString ("c");
        }

        private void exitFormButton_Click (object sender, EventArgs e) {
            /* Close the program on button select */
            this.Close ();
        }

        private void clearValuesButton_Click (object sender, EventArgs e) {
            /* Clear all the input/output labels on button select */
            amountOfDaysText.Text = "";
            medicationChargesText.Text = "";
            surgicalChargesText.Text = "";
            labFeesText.Text = "";
            rehabilitationFeesText.Text = "";
            finalCostOutputLabel.Text = "";
        }
    }
}