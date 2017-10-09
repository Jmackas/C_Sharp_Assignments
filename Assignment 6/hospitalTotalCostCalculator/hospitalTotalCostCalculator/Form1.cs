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
        /* Variable declaration for amount of days at hospital, medication, surgical, lab, and rehabilitation fee input */
        decimal amountOfDays, medicationCharges, surgicalCharges, labFees, rehabilitationFees;

        /* Constant declaration for static price of day at hospital */
        const decimal ONEDAYCOST = 350;

        /* Variable declaration for output of added costs */
        private decimal totalMiscCharges;

        /* Variable declaration for output cost for living at the hospital */
        private decimal totalHospitalStayCost;

        public hospitalTotalCostCalculator()
        {
            InitializeComponent();
        }

        /* On 'calculate' button select method */
        private void calculateTotalCostButton_Click_1(object sender, EventArgs e)
        {
            /* Invokes the 'CalcStayCharge' method */
            CalcStayCharge();

            /* Invokes the 'CalcMiscCharges' method */
            CalcMiscCharges();

            /* Invokes the 'CalcTotalCharges' method */
            CalcTotalCharges();
        }

        /* Method for calculating the base charge for staying at the hospital */
        private void CalcStayCharge()
        {
            try
            {
                /* Parsing user input */
                amountOfDays = decimal.Parse(amountOfDaysText.Text);

                /* Data validation ensuring the number entered is positive */
                if (amountOfDays < 0)
                {
                    MessageBox.Show("Please don't enter a negative number");
                    Application.Restart();
                }

                /* Algorithm to determine the final cost (for this method) */
                totalHospitalStayCost = amountOfDays * ONEDAYCOST;

            }

            /* Try catch block to catch any exceptions encountered from the user input */
            catch
            {
                MessageBox.Show("Please enter a positive number.");
            }
        }

        /* Method for calculating the medication, surgical, lab, and rehabilitation fees */
        private void CalcMiscCharges()
        {
            try
            {
                /* Parsing user input */
                medicationCharges = decimal.Parse(medicationChargesText.Text);
                surgicalCharges = decimal.Parse(surgicalChargesText.Text);
                labFees = decimal.Parse(labFeesText.Text);
                rehabilitationFees = decimal.Parse(rehabilitationFeesText.Text);

                /* Algorithm to determine the final cost (for this method) */
                totalMiscCharges = medicationCharges + surgicalCharges + labFees + rehabilitationFees;

                /* Data validation ensuring the number entered is positive */
                if (medicationCharges < 0 || surgicalCharges < 0 || labFees < 0 || rehabilitationFees < 0)
                {
                    MessageBox.Show("Please don't enter a negative number");
                    Application.Restart();
                }

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
            /* Close the program on button select */
            this.Close();
        }

        private void clearValuesButton_Click(object sender, EventArgs e)
        {
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