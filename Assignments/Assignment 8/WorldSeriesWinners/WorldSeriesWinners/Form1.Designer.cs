namespace WorldSeriesWinners
{
    partial class worldSeriesWinnersForm
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
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.outputValueLabel = new System.Windows.Forms.Label();
            this.prependText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamsListBox
            // 
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.Location = new System.Drawing.Point(8, 8);
            this.teamsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(332, 225);
            this.teamsListBox.TabIndex = 0;
            this.teamsListBox.SelectedIndexChanged += new System.EventHandler(this.teamsListBox_SelectedIndexChanged);
            // 
            // outputValueLabel
            // 
            this.outputValueLabel.Location = new System.Drawing.Point(44, 235);
            this.outputValueLabel.Name = "outputValueLabel";
            this.outputValueLabel.Size = new System.Drawing.Size(35, 13);
            this.outputValueLabel.TabIndex = 1;
            // 
            // prependText
            // 
            this.prependText.AutoSize = true;
            this.prependText.Location = new System.Drawing.Point(12, 235);
            this.prependText.Name = "prependText";
            this.prependText.Size = new System.Drawing.Size(34, 13);
            this.prependText.TabIndex = 2;
            this.prependText.Text = "Wins:";
            // 
            // worldSeriesWinnersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 330);
            this.Controls.Add(this.prependText);
            this.Controls.Add(this.outputValueLabel);
            this.Controls.Add(this.teamsListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "worldSeriesWinnersForm";
            this.Text = "World Series Winners";
            this.Load += new System.EventHandler(this.worldSeriesWinnersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.Label outputValueLabel;
        private System.Windows.Forms.Label prependText;
    }
}

