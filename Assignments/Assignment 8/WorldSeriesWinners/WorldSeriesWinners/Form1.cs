using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WorldSeriesWinners
{
    public partial class worldSeriesWinnersForm : Form
    {
        public worldSeriesWinnersForm()
        {
            InitializeComponent();
        }

        private void worldSeriesWinnersForm_Load(object sender, EventArgs e)
        {
            /* Import the list into the program */
            TeamLoadOnOpen();
        }

        private void TeamLoadOnOpen()
        {

        }
    }
}
