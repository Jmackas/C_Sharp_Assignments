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

namespace openListFromFile
{
    public partial class listOfNumbersForm : Form
    {
        public listOfNumbersForm()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
           
            //Declare varible for numbers
            string numberList;
            //Declare vairble for streamreader
            StreamReader inputFile;

            // Restrict file name type in open dialog
            numberOpenFileDia.Filter = "Text Files | *.txt";
            // Set file default name to text type in open dialog
            numberOpenFileDia.DefaultExt = "txt";

            //Declear open file
            OpenFileDialog open = new OpenFileDialog();


            //Show open dialog and when file is path is selected run
            if (numberOpenFileDia.ShowDialog() == DialogResult.OK)
            {


                //open the file and get a streamreader object
                inputFile = (File.OpenText(numberOpenFileDia.FileName));

                //Clear anything in list box
                numberListBox.Items.Clear();


                //Read the contents using loop
                while (!inputFile.EndOfStream)
                {
                    //Get number from file
                    numberList = inputFile.ReadLine();
                    // Add numbers to listbox
                    numberListBox.Items.Add(numberList);
                }

                // Calculate Total Sum code sourced from https://social.msdn.microsoft.com/Forums/vstudio/en-US/4a0db1d6-8e79-4285-a550-0f4e474a7299/getting-the-sum-of-the-items-in-a-list-box?forum=csharpgeneral
                int i = 0, result = 0;
                //Peform Loop to calculate total sum
                while (i < numberListBox.Items.Count)
                {
                    result += Convert.ToInt32(numberListBox.Items[i++]);
                }
                // Converts items from listbox to int value
                totalSumTextBox.Text = Convert.ToString((int)result / i);



                //close
                inputFile.Close();

            }
            // If user selects cancel in open dialog
            else
            {
                
            }
        
    }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close Program
            this.Close();
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear listbox
            numberListBox.Items.Clear();
            //Clear Textbox
            totalSumTextBox.Text = "";
            
        }
    }
}
