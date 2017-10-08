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

        private void exitFormButton_Click(object sender, EventArgs e)
        {
            // Close the application on button select
            this.Close();
        }
    }
}
