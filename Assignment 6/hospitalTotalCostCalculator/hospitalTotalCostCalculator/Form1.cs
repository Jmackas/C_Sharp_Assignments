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
        public hospitalTotalCostCalculator()
        {
            InitializeComponent();
        }

        /* On 'calculate' button select method */
        private void calculateTotalCostButton_Click(object sender, EventArgs e)
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
                /* Variable declaration for user input days spent in the hospital */
                decimal amountOfDays;
                /* Constant declaration for static price of day at hospital */
                const decimal oneDayCost = 350;
                /* Output cost for living at the hospital */
                decimal totalHospitalCost;

                /* Parsing user input */
                amountOfDays = decimal.Parse(amountOfDaysText.Text);

                /* Algorithm to determine the final cost (for this method) */
                totalHospitalCost = amountOfDays * oneDayCost;
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
            /* Variable declaration for medication, surgical, lab, and rehabilitation fee input */
            decimal medicationCharges, surgicalCharges, labFees, rehabilitationFees;

            /* Variable declaration for output of added costs */
            decimal totalMiscCharges;

            /* Parsing user input */
            medicationCharges = decimal.Parse(medicationChargesText.Text);
            surgicalCharges = decimal.Parse(surgicalChargesText.Text);
            labFees = decimal.Parse(labFeesText.Text);
            rehabilitationFees = decimal.Parse(rehabilitationFeesText.Text);

            /* Algorithm to determine the final cost (for this method) */
            totalMiscCharges = medicationCharges + surgicalCharges + labFees + rehabilitationFees;
        }

        /* Method for calculating the added costs of the methods CalcStayCharge() and CalcMiscCharges() */
        private void CalcTotalCharges()
        {

        }

        private void exitFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}