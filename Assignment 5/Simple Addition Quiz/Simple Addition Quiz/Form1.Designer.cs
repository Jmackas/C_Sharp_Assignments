namespace Simple_Addition_Quiz
{
    partial class simpleAdditionQuizForm
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
            this.randomNumOneLabel = new System.Windows.Forms.Label();
            this.randomNumTwoLabel = new System.Windows.Forms.Label();
            this.additionSignLabel = new System.Windows.Forms.Label();
            this.inputNumberTextBox = new System.Windows.Forms.TextBox();
            this.solutionGeneratorButton = new System.Windows.Forms.Button();
            this.equalSignLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // randomNumOneLabel
            // 
            this.randomNumOneLabel.Location = new System.Drawing.Point(12, 9);
            this.randomNumOneLabel.Name = "randomNumOneLabel";
            this.randomNumOneLabel.Size = new System.Drawing.Size(35, 23);
            this.randomNumOneLabel.TabIndex = 0;
            this.randomNumOneLabel.Text = "111";
            this.randomNumOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // randomNumTwoLabel
            // 
            this.randomNumTwoLabel.Location = new System.Drawing.Point(71, 9);
            this.randomNumTwoLabel.Name = "randomNumTwoLabel";
            this.randomNumTwoLabel.Size = new System.Drawing.Size(35, 23);
            this.randomNumTwoLabel.TabIndex = 1;
            this.randomNumTwoLabel.Text = "111";
            this.randomNumTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // additionSignLabel
            // 
            this.additionSignLabel.Location = new System.Drawing.Point(53, 13);
            this.additionSignLabel.Name = "additionSignLabel";
            this.additionSignLabel.Size = new System.Drawing.Size(12, 15);
            this.additionSignLabel.TabIndex = 2;
            this.additionSignLabel.Text = "+";
            // 
            // inputNumberTextBox
            // 
            this.inputNumberTextBox.Location = new System.Drawing.Point(130, 10);
            this.inputNumberTextBox.Name = "inputNumberTextBox";
            this.inputNumberTextBox.Size = new System.Drawing.Size(142, 20);
            this.inputNumberTextBox.TabIndex = 3;
            // 
            // solutionGeneratorButton
            // 
            this.solutionGeneratorButton.Location = new System.Drawing.Point(12, 226);
            this.solutionGeneratorButton.Name = "solutionGeneratorButton";
            this.solutionGeneratorButton.Size = new System.Drawing.Size(260, 23);
            this.solutionGeneratorButton.TabIndex = 4;
            this.solutionGeneratorButton.Text = "Check Answer";
            this.solutionGeneratorButton.UseVisualStyleBackColor = true;
//            this.solutionGeneratorButton.Click += new System.EventHandler(this.solutionGenerator_Click);
            // 
            // equalSignLabel
            // 
            this.equalSignLabel.Location = new System.Drawing.Point(112, 13);
            this.equalSignLabel.Name = "equalSignLabel";
            this.equalSignLabel.Size = new System.Drawing.Size(12, 15);
            this.equalSignLabel.TabIndex = 5;
            this.equalSignLabel.Text = "=";
            // 
            // simpleAdditionQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.equalSignLabel);
            this.Controls.Add(this.solutionGeneratorButton);
            this.Controls.Add(this.inputNumberTextBox);
            this.Controls.Add(this.additionSignLabel);
            this.Controls.Add(this.randomNumTwoLabel);
            this.Controls.Add(this.randomNumOneLabel);
            this.Name = "simpleAdditionQuizForm";
            this.Text = "Simple Addition Quiz Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label randomNumOneLabel;
        private System.Windows.Forms.Label randomNumTwoLabel;
        private System.Windows.Forms.Label additionSignLabel;
        private System.Windows.Forms.TextBox inputNumberTextBox;
        private System.Windows.Forms.Button solutionGeneratorButton;
        private System.Windows.Forms.Label equalSignLabel;
    }
}

