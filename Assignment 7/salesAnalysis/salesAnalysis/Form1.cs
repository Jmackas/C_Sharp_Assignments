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

/* 
 * OpenFileDialog code was acquired from Leon Tan (with permission), and modified 
 *  
 */

namespace salesAnalysis
{
    public partial class salesAnalysis : Form
    {

        /* Declare varible for numbers */
        string numberList;

        /* Counting number of variables in the array to code */
        string listBoxCounter;

        /* Declaration of the string array */
        string[] listBoxToArray;

        public salesAnalysis()
        {
            InitializeComponent();
        }

        /* Method encapsulation for opening the file's contents and converting to C# */
        private void insertArrayButton_Click_1(object sender, EventArgs e)
        {
            /* Invoke methods on select */
            InsertionOfFile();
            ListboxToArray();
        }

        /* Method for opening the file dialog and importing into the project*/
        private void InsertionOfFile()
        {

            /* Declaration of variable for the streamreader */
            StreamReader inputFile;

            /* Restrict the file type for the open file dialog */
            openFileDialog.Filter = "Text Files | *.txt";

            /* Assign the default file type to be selected as a .txt */
            openFileDialog.DefaultExt = "txt";

            /* Declaration of open file dialog */
            OpenFileDialog open = new OpenFileDialog();


            /* Display the open dialog when the filepath is found */
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                /* Open the file to get the streamreader file */
                inputFile = (File.OpenText(openFileDialog.FileName));

                /* Clear anything currently situated in the listbox */
                arrayOutputListbox.Items.Clear();

                /* Read the contents while performing a loop */
                while (!inputFile.EndOfStream)
                {
                    /* Get the number from the file line by line */
                    numberList = inputFile.ReadLine();

                    /* Add the numbers to the listbox */
                    arrayOutputListbox.Items.Add(numberList);
                }

                /* Counting the amount of items present in the listbox, and adding it to a variable */
                listBoxCounter = arrayOutputListbox.Items.Count.ToString();

                /* Close the insertion of files upon completion */
                inputFile.Close();

            }
        }

        /* Method for converting the listbox contents to an array */
        private void ListboxToArray()
        {
            /* Converting the string to a declared array */
            string[] listBoxToArray = numberList.Select(c => c.ToString()).ToArray();
        }

        /* Method for sorting the code */
        private void SortButton_Click(object sender, EventArgs e)
        {
            /*
            FindArrayAverage();
            */
            }

        /* Method for determining the average of the array */
        /*
        private void FindArrayAverage()
        {
            for (int index = 0; index < units.Length; index++)
            {
                total += units[index];
            }

        }
        */
        /* Method for clearing the form input */
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear listbox
            arrayOutputListbox.Items.Clear();
        }

        /* Method for closing the program */
        private void exitProgramButton_Click(object sender, EventArgs e)
        {
            /* Close Program */
            this.Close();
        }
    }
}
