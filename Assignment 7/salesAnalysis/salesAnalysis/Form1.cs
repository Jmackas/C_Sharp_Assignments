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

namespace salesAnalysis
{
    public partial class salesAnalysis : Form
    {
        public salesAnalysis()
        {
            InitializeComponent();
        }

        /* Method encapsulation for opening the file's contents and converting to C# */
        private void insertArrayButton_Click(object sender, EventArgs e)
        {
            /* Invoke methods on select */
            InsertionOfFile();
            ListboxToArray();
        }

        /* Method for opening the file dialog and importing into the project*/
        private void InsertionOfFile()
        {

        }

        /* Method for converting the listbox contents to an array */
        private void ListboxToArray()
        {

        }

        /* Method for clearing the form input */
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear listbox
            arrayOutputListbox.Items.Clear();
        }

        /* Method for sorting the code */
        private void SortButton_Click(object sender, EventArgs e)
        {

        }

        /* Method for closing the program */
        private void exitProgramButton_Click(object sender, EventArgs e)
        {
            /* Close Program */
            this.Close();
        }
    }
}
