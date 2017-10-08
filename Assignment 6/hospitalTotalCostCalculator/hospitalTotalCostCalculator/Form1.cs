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

        }
        
        /* Method for calculating the base charge for staying at the hospital */
        private void CalcStayCharge()
        {
            
        }

        /* Method for calculating the medication, surgical, lab, and rehabilitation fees */
        private void CalcMiscCharges()
        {

        }

        /* Method for calculating the added costs of the methods CalcStayCharge() and CalcMiscCharges() */
        private void CalcTotalCharges()
        {

        }


        private void exitFormButton_Click(object sender, EventArgs e)
        {
            /* Close the application on button select */
            this.Close();
        }
    }
}
