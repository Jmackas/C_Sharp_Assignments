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
            this.inputNumberText = new System.Windows.Forms.TextBox();
            this.solutionGenerator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // randomNumOneLabel
            // 
            this.randomNumOneLabel.Location = new System.Drawing.Point(12, 9);
            this.randomNumOneLabel.Name = "randomNumOneLabel";
            this.randomNumOneLabel.Size = new System.Drawing.Size(35, 23);
            this.randomNumOneLabel.TabIndex = 0;
            // 
            // randomNumTwoLabel
            // 
            this.randomNumTwoLabel.Location = new System.Drawing.Point(71, 9);
            this.randomNumTwoLabel.Name = "randomNumTwoLabel";
            this.randomNumTwoLabel.Size = new System.Drawing.Size(35, 23);
            this.randomNumTwoLabel.TabIndex = 1;
            // 
            // additionSignLabel
            // 
            this.additionSignLabel.Location = new System.Drawing.Point(53, 13);
            this.additionSignLabel.Name = "additionSignLabel";
            this.additionSignLabel.Size = new System.Drawing.Size(12, 15);
            this.additionSignLabel.TabIndex = 2;
            this.additionSignLabel.Text = "+";
            // 
            // inputNumberText
            // 
            this.inputNumberText.Location = new System.Drawing.Point(112, 10);
            this.inputNumberText.Name = "inputNumberText";
            this.inputNumberText.Size = new System.Drawing.Size(160, 20);
            this.inputNumberText.TabIndex = 3;
            // 
            // solutionGenerator
            // 
            this.solutionGenerator.Location = new System.Drawing.Point(12, 226);
            this.solutionGenerator.Name = "solutionGenerator";
            this.solutionGenerator.Size = new System.Drawing.Size(260, 23);
            this.solutionGenerator.TabIndex = 4;
            this.solutionGenerator.Text = "Solution";
            this.solutionGenerator.UseVisualStyleBackColor = true;
            this.solutionGenerator.Click += new System.EventHandler(this.solutionGenerator_Click);
            // 
            // simpleAdditionQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.solutionGenerator);
            this.Controls.Add(this.inputNumberText);
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
        private System.Windows.Forms.TextBox inputNumberText;
        private System.Windows.Forms.Button solutionGenerator;
    }
}

