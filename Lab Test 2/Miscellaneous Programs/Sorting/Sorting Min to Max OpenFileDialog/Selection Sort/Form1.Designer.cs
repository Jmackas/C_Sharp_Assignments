namespace Selection_Sort
{
    partial class Form1
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
            this.originalOrderLabel = new System.Windows.Forms.Label();
            this.sortedOrderLabel = new System.Windows.Forms.Label();
            this.originalListBox = new System.Windows.Forms.ListBox();
            this.sortedListBox = new System.Windows.Forms.ListBox();
            this.goButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // originalOrderLabel
            // 
            this.originalOrderLabel.AutoSize = true;
            this.originalOrderLabel.Location = new System.Drawing.Point(18, 14);
            this.originalOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.originalOrderLabel.Name = "originalOrderLabel";
            this.originalOrderLabel.Size = new System.Drawing.Size(106, 20);
            this.originalOrderLabel.TabIndex = 0;
            this.originalOrderLabel.Text = "Original Order";
            // 
            // sortedOrderLabel
            // 
            this.sortedOrderLabel.AutoSize = true;
            this.sortedOrderLabel.Location = new System.Drawing.Point(228, 14);
            this.sortedOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortedOrderLabel.Name = "sortedOrderLabel";
            this.sortedOrderLabel.Size = new System.Drawing.Size(101, 20);
            this.sortedOrderLabel.TabIndex = 1;
            this.sortedOrderLabel.Text = "Sorted Order";
            // 
            // originalListBox
            // 
            this.originalListBox.FormattingEnabled = true;
            this.originalListBox.ItemHeight = 20;
            this.originalListBox.Location = new System.Drawing.Point(18, 38);
            this.originalListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.originalListBox.Name = "originalListBox";
            this.originalListBox.Size = new System.Drawing.Size(178, 144);
            this.originalListBox.TabIndex = 2;
            // 
            // sortedListBox
            // 
            this.sortedListBox.FormattingEnabled = true;
            this.sortedListBox.ItemHeight = 20;
            this.sortedListBox.Location = new System.Drawing.Point(228, 38);
            this.sortedListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortedListBox.Name = "sortedListBox";
            this.sortedListBox.Size = new System.Drawing.Size(178, 144);
            this.sortedListBox.TabIndex = 3;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(96, 202);
            this.goButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(112, 35);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(218, 202);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 35);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 255);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.sortedListBox);
            this.Controls.Add(this.originalListBox);
            this.Controls.Add(this.sortedOrderLabel);
            this.Controls.Add(this.originalOrderLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Selection Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originalOrderLabel;
        private System.Windows.Forms.Label sortedOrderLabel;
        private System.Windows.Forms.ListBox originalListBox;
        private System.Windows.Forms.ListBox sortedListBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

