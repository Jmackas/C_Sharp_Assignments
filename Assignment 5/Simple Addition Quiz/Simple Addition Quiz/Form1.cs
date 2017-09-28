using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Addition_Quiz
{
    public partial class simpleAdditionQuizForm : Form
    {
        public simpleAdditionQuizForm()
        {
            InitializeComponent();
        }

        private void solutionGenerator_Click(object sender, EventArgs e)
        {
            // Try catch block to 'catch' any errors
            try
            {
                int inputNumOne, inputNumTwo;



            }

            catch
            {
                // Fallback to a broken solution 
                MessageBox.Show("Please enter an integer value.");
            }
        }
    }
}
