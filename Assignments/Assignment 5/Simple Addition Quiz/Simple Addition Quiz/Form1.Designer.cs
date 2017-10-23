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
            this.solutionGenerator = new System.Windows.Forms.Button();
            this.equalSignLabel = new System.Windows.Forms.Label();
            this.newQuestionButton = new System.Windows.Forms.Button();
            this.closeFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // randomNumOneLabel
            // 
            this.randomNumOneLabel.Location = new System.Drawing.Point(12, 9);
            this.randomNumOneLabel.Name = "randomNumOneLabel";
            this.randomNumOneLabel.Size = new System.Drawing.Size(35, 23);
            this.randomNumOneLabel.TabIndex = 0;
            this.randomNumOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // randomNumTwoLabel
            // 
            this.randomNumTwoLabel.Location = new System.Drawing.Point(71, 9);
            this.randomNumTwoLabel.Name = "randomNumTwoLabel";
            this.randomNumTwoLabel.Size = new System.Drawing.Size(35, 23);
            this.randomNumTwoLabel.TabIndex = 1;
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
            // solutionGenerator
            // 
            this.solutionGenerator.Location = new System.Drawing.Point(12, 36);
            this.solutionGenerator.Name = "solutionGenerator";
            this.solutionGenerator.Size = new System.Drawing.Size(260, 23);
            this.solutionGenerator.TabIndex = 4;
            this.solutionGenerator.Text = "Check Answer";
            this.solutionGenerator.UseVisualStyleBackColor = true;
            this.solutionGenerator.Click += new System.EventHandler(this.solutionGenerator_Click);
            // 
            // equalSignLabel
            // 
            this.equalSignLabel.Location = new System.Drawing.Point(112, 13);
            this.equalSignLabel.Name = "equalSignLabel";
            this.equalSignLabel.Size = new System.Drawing.Size(12, 15);
            this.equalSignLabel.TabIndex = 5;
            this.equalSignLabel.Text = "=";
            // 
            // newQuestionButton
            // 
            this.newQuestionButton.Location = new System.Drawing.Point(12, 65);
            this.newQuestionButton.Name = "newQuestionButton";
            this.newQuestionButton.Size = new System.Drawing.Size(129, 23);
            this.newQuestionButton.TabIndex = 6;
            this.newQuestionButton.Text = "New Question";
            this.newQuestionButton.UseVisualStyleBackColor = true;
            this.newQuestionButton.Click += new System.EventHandler(this.newQuestionButton_Click);
            // 
            // closeFormButton
            // 
            this.closeFormButton.Location = new System.Drawing.Point(147, 65);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(125, 23);
            this.closeFormButton.TabIndex = 7;
            this.closeFormButton.Text = "Close";
            this.closeFormButton.UseVisualStyleBackColor = true;
            this.closeFormButton.Click += new System.EventHandler(this.closeFormButton_Click);
            // 
            // simpleAdditionQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 97);
            this.Controls.Add(this.closeFormButton);
            this.Controls.Add(this.newQuestionButton);
            this.Controls.Add(this.equalSignLabel);
            this.Controls.Add(this.solutionGenerator);
            this.Controls.Add(this.inputNumberTextBox);
            this.Controls.Add(this.additionSignLabel);
            this.Controls.Add(this.randomNumTwoLabel);
            this.Controls.Add(this.randomNumOneLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button solutionGenerator;
        private System.Windows.Forms.Label equalSignLabel;
        private System.Windows.Forms.Button newQuestionButton;
        private System.Windows.Forms.Button closeFormButton;
    }
}

