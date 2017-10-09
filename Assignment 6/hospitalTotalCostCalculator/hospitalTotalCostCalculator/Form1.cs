using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalTotalCostCalculator
{
    public partial class hospitalTotalCostCalculator : Form
    {
        /* Public variable declarations */
        /* Variable declaration for output of added costs */
        private decimal totalMiscCharges;

        /* Output cost for living at the hospital */
        private decimal totalHospitalStayCost;

        public hospitalTotalCostCalculator()
        {
            InitializeComponent();
        }

        /* On 'calculate' button select method */
        private void calculateTotalCostButton_Click_1(object sender, EventArgs e)
        {
            /* Invokes the 'DataValidation' method */
            DataValidation();

            /* Invokes the 'CalcStayCharge' method */
            CalcStayCharge();

            /* Invokes the 'CalcMiscCharges' method */
            CalcMiscCharges();

            /* Invokes the 'CalcTotalCharges' method */
            CalcTotalCharges();
        }

        private void DataValidation()
        {
            /* The purpose of this method is strictly to test the input data */

            /* Declaration of variables */
            decimal amountOfDays, medicationCharges, surgicalCharges, labFees, rehabilitationFees;

            /* Parsing all variables */
            amountOfDays = decimal.Parse(amountOfDaysText.Text);
            medicationCharges = decimal.Parse(medicationChargesText.Text);
            surgicalCharges = decimal.Parse(surgicalChargesText.Text);
            labFees = decimal.Parse(labFeesText.Text);
            rehabilitationFees = decimal.Parse(rehabilitationFeesText.Text);

            /* If statement to test that all variables are above 0 */
            if (medicationCharges <= 0 || surgicalCharges <= 0 || labFees <= 0 || rehabilitationFees <= 0)
            {
                MessageBox.Show("Please enter a number above 0");
            }
        }


        /* Method for calculating the base charge for staying at the hospital */
        private void CalcStayCharge()
        {
            try
            {
                /* Variable declaration for user input days spent in the hospital */
                decimal amountOfDays;

                /* Constant declaration for static price of day at hospital */
                const decimal ONEDAYCOST = 350;

                /* Parsing user input */
                amountOfDays = decimal.Parse(amountOfDaysText.Text);

                /* Algorithm to determine the final cost (for this method) */
                totalHospitalStayCost = amountOfDays * ONEDAYCOST;

            }

            /* Try catch block to catch any exceptions encountered from the user input */
            catch
            {
                MessageBox.Show("Please enter a number");
            }
        }

        /* Method for calculating the medication, surgical, lab, and rehabilitation fees */
        private void CalcMiscCharges()
        {
            try
            {
                /* Variable declaration for medication, surgical, lab, and rehabilitation fee input */
                decimal medicationCharges, surgicalCharges, labFees, rehabilitationFees;

                /* Parsing user input */
                medicationCharges = decimal.Parse(medicationChargesText.Text);
                surgicalCharges = decimal.Parse(surgicalChargesText.Text);
                labFees = decimal.Parse(labFeesText.Text);
                rehabilitationFees = decimal.Parse(rehabilitationFeesText.Text);

                /* Algorithm to determine the final cost (for this method) */
                totalMiscCharges = medicationCharges + surgicalCharges + labFees + rehabilitationFees;

            }
            catch
            {
                MessageBox.Show("Please enter a positive number.");
            }
        }

        /* Method for calculating the added costs of the methods CalcStayCharge() and CalcMiscCharges() */
        private void CalcTotalCharges()
        {
                /* Declaration of the final hospital cost */
                decimal totalHospitalCost;

                /* Algorithm to collate the final costs of the other methods and output to user */
                totalHospitalCost = totalMiscCharges + totalHospitalStayCost;

                /* Output to user */
                finalCostOutputLabel.Text = totalHospitalCost.ToString();
        }

        private void exitFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}