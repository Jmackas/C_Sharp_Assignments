using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadsorTails
{
    public partial class headsOrTailsForm : Form
    {
        public headsOrTailsForm()
        {
            InitializeComponent();
        }
        
        private void showHeadsButton_Click(object sender, EventArgs e)
        {
            // 'Tails' image hides on click
            tailsPictureBox.Visible = false;
            // while 'Heads' image shows on click
            headsPictureBox.Visible = true;
        }

        private void showTailsButton_Click(object sender, EventArgs e)
        {
            // 'Tails' image shows on click
            tailsPictureBox.Visible = true;
            // while 'Heads' image hides on click
            headsPictureBox.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Form closes on click
            this.Close();
        }
    }
}
