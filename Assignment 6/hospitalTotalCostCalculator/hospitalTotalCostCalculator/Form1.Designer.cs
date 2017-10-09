namespace hospitalTotalCostCalculator
{
    partial class hospitalTotalCostCalculator
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
            this.overviewLabel = new System.Windows.Forms.Label();
            this.amountOfDaysLabel = new System.Windows.Forms.Label();
            this.amountOfDaysText = new System.Windows.Forms.TextBox();
            this.medicationChargesLabel = new System.Windows.Forms.Label();
            this.medicationChargesText = new System.Windows.Forms.TextBox();
            this.surgicalChargesLabel = new System.Windows.Forms.Label();
            this.surgicalChargesText = new System.Windows.Forms.TextBox();
            this.labFeesLabel = new System.Windows.Forms.Label();
            this.labFeesText = new System.Windows.Forms.TextBox();
            this.rehabilitationFeesLabel = new System.Windows.Forms.Label();
            this.rehabilitationFeesText = new System.Windows.Forms.TextBox();
            this.finalCostLabel = new System.Windows.Forms.Label();
            this.finalCostOutputLabel = new System.Windows.Forms.Label();
            this.clearValuesButton = new System.Windows.Forms.Button();
            this.calculateTotalCostButton = new System.Windows.Forms.Button();
            this.exitFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // overviewLabel
            // 
            this.overviewLabel.AutoSize = true;
            this.overviewLabel.Location = new System.Drawing.Point(12, 9);
            this.overviewLabel.Name = "overviewLabel";
            this.overviewLabel.Size = new System.Drawing.Size(252, 13);
            this.overviewLabel.TabIndex = 0;
            this.overviewLabel.Text = "Cost calculator of the total time spent in the hospital.";
            // 
            // amountOfDaysLabel
            // 
            this.amountOfDaysLabel.AutoSize = true;
            this.amountOfDaysLabel.Location = new System.Drawing.Point(12, 58);
            this.amountOfDaysLabel.Name = "amountOfDaysLabel";
            this.amountOfDaysLabel.Size = new System.Drawing.Size(177, 13);
            this.amountOfDaysLabel.TabIndex = 1;
            this.amountOfDaysLabel.Text = "Amount of days spent in the hospital";
            // 
            // amountOfDaysText
            // 
            this.amountOfDaysText.Location = new System.Drawing.Point(211, 58);
            this.amountOfDaysText.Name = "amountOfDaysText";
            this.amountOfDaysText.Size = new System.Drawing.Size(100, 20);
            this.amountOfDaysText.TabIndex = 2;
            // 
            // medicationChargesLabel
            // 
            this.medicationChargesLabel.AutoSize = true;
            this.medicationChargesLabel.Location = new System.Drawing.Point(12, 101);
            this.medicationChargesLabel.Name = "medicationChargesLabel";
            this.medicationChargesLabel.Size = new System.Drawing.Size(176, 13);
            this.medicationChargesLabel.TabIndex = 3;
            this.medicationChargesLabel.Text = "Total amount of medication charges";
            // 
            // medicationChargesText
            // 
            this.medicationChargesText.Location = new System.Drawing.Point(211, 101);
            this.medicationChargesText.Name = "medicationChargesText";
            this.medicationChargesText.Size = new System.Drawing.Size(100, 20);
            this.medicationChargesText.TabIndex = 4;
            // 
            // surgicalChargesLabel
            // 
            this.surgicalChargesLabel.AutoSize = true;
            this.surgicalChargesLabel.Location = new System.Drawing.Point(12, 144);
            this.surgicalChargesLabel.Name = "surgicalChargesLabel";
            this.surgicalChargesLabel.Size = new System.Drawing.Size(161, 13);
            this.surgicalChargesLabel.TabIndex = 5;
            this.surgicalChargesLabel.Text = "Total amount of surgical charges";
            // 
            // surgicalChargesText
            // 
            this.surgicalChargesText.Location = new System.Drawing.Point(211, 144);
            this.surgicalChargesText.Name = "surgicalChargesText";
            this.surgicalChargesText.Size = new System.Drawing.Size(100, 20);
            this.surgicalChargesText.TabIndex = 6;
            // 
            // labFeesLabel
            // 
            this.labFeesLabel.AutoSize = true;
            this.labFeesLabel.Location = new System.Drawing.Point(12, 186);
            this.labFeesLabel.Name = "labFeesLabel";
            this.labFeesLabel.Size = new System.Drawing.Size(121, 13);
            this.labFeesLabel.TabIndex = 7;
            this.labFeesLabel.Text = "Total amount of lab fees";
            // 
            // labFeesText
            // 
            this.labFeesText.Location = new System.Drawing.Point(211, 186);
            this.labFeesText.Name = "labFeesText";
            this.labFeesText.Size = new System.Drawing.Size(100, 20);
            this.labFeesText.TabIndex = 8;
            // 
            // rehabilitationFeesLabel
            // 
            this.rehabilitationFeesLabel.AutoSize = true;
            this.rehabilitationFeesLabel.Location = new System.Drawing.Point(12, 229);
            this.rehabilitationFeesLabel.Name = "rehabilitationFeesLabel";
            this.rehabilitationFeesLabel.Size = new System.Drawing.Size(166, 13);
            this.rehabilitationFeesLabel.TabIndex = 9;
            this.rehabilitationFeesLabel.Text = "Total amount of rehabilitation fees";
            // 
            // rehabilitationFeesText
            // 
            this.rehabilitationFeesText.Location = new System.Drawing.Point(211, 229);
            this.rehabilitationFeesText.Name = "rehabilitationFeesText";
            this.rehabilitationFeesText.Size = new System.Drawing.Size(100, 20);
            this.rehabilitationFeesText.TabIndex = 10;
            // 
            // finalCostLabel
            // 
            this.finalCostLabel.AutoSize = true;
            this.finalCostLabel.Location = new System.Drawing.Point(14, 268);
            this.finalCostLabel.Name = "finalCostLabel";
            this.finalCostLabel.Size = new System.Drawing.Size(145, 13);
            this.finalCostLabel.TabIndex = 11;
            this.finalCostLabel.Text = "Total cost of the hospital stay";
            // 
            // finalCostOutputLabel
            // 
            this.finalCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalCostOutputLabel.Location = new System.Drawing.Point(211, 268);
            this.finalCostOutputLabel.Name = "finalCostOutputLabel";
            this.finalCostOutputLabel.Size = new System.Drawing.Size(100, 13);
            this.finalCostOutputLabel.TabIndex = 12;
            // 
            // clearValuesButton
            // 
            this.clearValuesButton.Location = new System.Drawing.Point(12, 398);
            this.clearValuesButton.Name = "clearValuesButton";
            this.clearValuesButton.Size = new System.Drawing.Size(100, 23);
            this.clearValuesButton.TabIndex = 13;
            this.clearValuesButton.Text = "Clear";
            this.clearValuesButton.UseVisualStyleBackColor = true;
            // 
            // calculateTotalCostButton
            // 
            this.calculateTotalCostButton.Location = new System.Drawing.Point(211, 300);
            this.calculateTotalCostButton.Name = "calculateTotalCostButton";
            this.calculateTotalCostButton.Size = new System.Drawing.Size(100, 23);
            this.calculateTotalCostButton.TabIndex = 14;
            this.calculateTotalCostButton.Text = "Calculate";
            this.calculateTotalCostButton.UseVisualStyleBackColor = true;
            // 
            // exitFormButton
            // 
            this.exitFormButton.Location = new System.Drawing.Point(212, 398);
            this.exitFormButton.Name = "exitFormButton";
            this.exitFormButton.Size = new System.Drawing.Size(100, 23);
            this.exitFormButton.TabIndex = 15;
            this.exitFormButton.Text = "Exit";
            this.exitFormButton.UseVisualStyleBackColor = true;
            this.exitFormButton.Click += new System.EventHandler(this.exitFormButton_Click);
            // 
            // hospitalTotalCostCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 433);
            this.Controls.Add(this.exitFormButton);
            this.Controls.Add(this.calculateTotalCostButton);
            this.Controls.Add(this.clearValuesButton);
            this.Controls.Add(this.finalCostOutputLabel);
            this.Controls.Add(this.finalCostLabel);
            this.Controls.Add(this.rehabilitationFeesText);
            this.Controls.Add(this.rehabilitationFeesLabel);
            this.Controls.Add(this.labFeesText);
            this.Controls.Add(this.labFeesLabel);
            this.Controls.Add(this.surgicalChargesText);
            this.Controls.Add(this.surgicalChargesLabel);
            this.Controls.Add(this.medicationChargesText);
            this.Controls.Add(this.medicationChargesLabel);
            this.Controls.Add(this.amountOfDaysText);
            this.Controls.Add(this.amountOfDaysLabel);
            this.Controls.Add(this.overviewLabel);
            this.Name = "hospitalTotalCostCalculator";
            this.Text = "Hospital Total Cost Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label overviewLabel;
        private System.Windows.Forms.Label amountOfDaysLabel;
        private System.Windows.Forms.TextBox amountOfDaysText;
        private System.Windows.Forms.Label medicationChargesLabel;
        private System.Windows.Forms.TextBox medicationChargesText;
        private System.Windows.Forms.Label surgicalChargesLabel;
        private System.Windows.Forms.TextBox surgicalChargesText;
        private System.Windows.Forms.Label labFeesLabel;
        private System.Windows.Forms.TextBox labFeesText;
        private System.Windows.Forms.Label rehabilitationFeesLabel;
        private System.Windows.Forms.TextBox rehabilitationFeesText;
        private System.Windows.Forms.Label finalCostLabel;
        private System.Windows.Forms.Label finalCostOutputLabel;
        private System.Windows.Forms.Button clearValuesButton;
        private System.Windows.Forms.Button calculateTotalCostButton;
        private System.Windows.Forms.Button exitFormButton;
    }
}

