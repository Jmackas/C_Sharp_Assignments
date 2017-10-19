namespace salesAnalysis
{
    partial class salesAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.arrayOutputListbox = new System.Windows.Forms.ListBox();
            this.insertArrayButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.exitProgramButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // arrayOutputListbox
            // 
            this.arrayOutputListbox.FormattingEnabled = true;
            this.arrayOutputListbox.Location = new System.Drawing.Point(8, 62);
            this.arrayOutputListbox.Margin = new System.Windows.Forms.Padding(2);
            this.arrayOutputListbox.Name = "arrayOutputListbox";
            this.arrayOutputListbox.Size = new System.Drawing.Size(381, 212);
            this.arrayOutputListbox.TabIndex = 0;
            // 
            // insertArrayButton
            // 
            this.insertArrayButton.Location = new System.Drawing.Point(8, 8);
            this.insertArrayButton.Margin = new System.Windows.Forms.Padding(2);
            this.insertArrayButton.Name = "insertArrayButton";
            this.insertArrayButton.Size = new System.Drawing.Size(91, 37);
            this.insertArrayButton.TabIndex = 1;
            this.insertArrayButton.Text = "Insert File";
            this.insertArrayButton.UseVisualStyleBackColor = true;
            this.insertArrayButton.Click += new System.EventHandler(this.insertArrayButton_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(8, 316);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(91, 37);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(130, 289);
            this.SortButton.Margin = new System.Windows.Forms.Padding(2);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(138, 64);
            this.SortButton.TabIndex = 3;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // exitProgramButton
            // 
            this.exitProgramButton.Location = new System.Drawing.Point(296, 316);
            this.exitProgramButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitProgramButton.Name = "exitProgramButton";
            this.exitProgramButton.Size = new System.Drawing.Size(91, 37);
            this.exitProgramButton.TabIndex = 4;
            this.exitProgramButton.Text = "Exit";
            this.exitProgramButton.UseVisualStyleBackColor = true;
            this.exitProgramButton.Click += new System.EventHandler(this.exitProgramButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // salesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitProgramButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.insertArrayButton);
            this.Controls.Add(this.arrayOutputListbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "salesAnalysis";
            this.Text = "Sales Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox arrayOutputListbox;
        private System.Windows.Forms.Button insertArrayButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button exitProgramButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
    }
}

