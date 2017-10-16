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
            this.SuspendLayout();
            // 
            // arrayOutputListbox
            // 
            this.arrayOutputListbox.FormattingEnabled = true;
            this.arrayOutputListbox.ItemHeight = 20;
            this.arrayOutputListbox.Location = new System.Drawing.Point(12, 75);
            this.arrayOutputListbox.Name = "arrayOutputListbox";
            this.arrayOutputListbox.Size = new System.Drawing.Size(569, 364);
            this.arrayOutputListbox.TabIndex = 0;
            // 
            // insertArrayButton
            // 
            this.insertArrayButton.Location = new System.Drawing.Point(12, 12);
            this.insertArrayButton.Name = "insertArrayButton";
            this.insertArrayButton.Size = new System.Drawing.Size(137, 57);
            this.insertArrayButton.TabIndex = 1;
            this.insertArrayButton.Text = "Insert File";
            this.insertArrayButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 486);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(137, 57);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(195, 445);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(207, 98);
            this.SortButton.TabIndex = 3;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            // 
            // exitProgramButton
            // 
            this.exitProgramButton.Location = new System.Drawing.Point(444, 486);
            this.exitProgramButton.Name = "exitProgramButton";
            this.exitProgramButton.Size = new System.Drawing.Size(137, 57);
            this.exitProgramButton.TabIndex = 4;
            this.exitProgramButton.Text = "Exit";
            this.exitProgramButton.UseVisualStyleBackColor = true;
            // 
            // salesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 555);
            this.Controls.Add(this.exitProgramButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.insertArrayButton);
            this.Controls.Add(this.arrayOutputListbox);
            this.Name = "salesAnalysis";
            this.Text = "Sales Analysis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox arrayOutputListbox;
        private System.Windows.Forms.Button insertArrayButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button exitProgramButton;
    }
}

