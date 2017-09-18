namespace paintEstimator
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
            this.components = new System.ComponentModel.Container();
            this.inputPaintArea = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inputPaintPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputPaintRequired = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSolveValues = new System.Windows.Forms.Button();
            this.outputLaborHours = new System.Windows.Forms.Label();
            this.outputPaintCost = new System.Windows.Forms.Label();
            this.outputLaborCost = new System.Windows.Forms.Label();
            this.outputOverallCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputPaintArea
            // 
            this.inputPaintArea.Location = new System.Drawing.Point(172, 6);
            this.inputPaintArea.Name = "inputPaintArea";
            this.inputPaintArea.Size = new System.Drawing.Size(100, 20);
            this.inputPaintArea.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // inputPaintPrice
            // 
            this.inputPaintPrice.Location = new System.Drawing.Point(172, 43);
            this.inputPaintPrice.Name = "inputPaintPrice";
            this.inputPaintPrice.Size = new System.Drawing.Size(100, 20);
            this.inputPaintPrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wall space to be painted (m^2)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price of Paint (AUD)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Paint Required for the Job";
            // 
            // outputPaintRequired
            // 
            this.outputPaintRequired.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputPaintRequired.Location = new System.Drawing.Point(172, 133);
            this.outputPaintRequired.Name = "outputPaintRequired";
            this.outputPaintRequired.Size = new System.Drawing.Size(100, 15);
            this.outputPaintRequired.TabIndex = 6;
            this.outputPaintRequired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "The hours of labor required";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "The labor charges";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "The cost of the paint";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "The total cost of the paint job";
            // 
            // btnSolveValues
            // 
            this.btnSolveValues.Location = new System.Drawing.Point(172, 78);
            this.btnSolveValues.Name = "btnSolveValues";
            this.btnSolveValues.Size = new System.Drawing.Size(75, 23);
            this.btnSolveValues.TabIndex = 14;
            this.btnSolveValues.Text = "Find Values";
            this.btnSolveValues.UseVisualStyleBackColor = true;
            this.btnSolveValues.Click += new System.EventHandler(this.btnSolveValues_Click);
            // 
            // outputLaborHours
            // 
            this.outputLaborHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLaborHours.Location = new System.Drawing.Point(172, 166);
            this.outputLaborHours.Name = "outputLaborHours";
            this.outputLaborHours.Size = new System.Drawing.Size(100, 15);
            this.outputLaborHours.TabIndex = 17;
            this.outputLaborHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputPaintCost
            // 
            this.outputPaintCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputPaintCost.Location = new System.Drawing.Point(172, 196);
            this.outputPaintCost.Name = "outputPaintCost";
            this.outputPaintCost.Size = new System.Drawing.Size(100, 15);
            this.outputPaintCost.TabIndex = 18;
            this.outputPaintCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLaborCost
            // 
            this.outputLaborCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLaborCost.Location = new System.Drawing.Point(172, 224);
            this.outputLaborCost.Name = "outputLaborCost";
            this.outputLaborCost.Size = new System.Drawing.Size(100, 15);
            this.outputLaborCost.TabIndex = 19;
            this.outputLaborCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputOverallCost
            // 
            this.outputOverallCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputOverallCost.Location = new System.Drawing.Point(172, 253);
            this.outputOverallCost.Name = "outputOverallCost";
            this.outputOverallCost.Size = new System.Drawing.Size(100, 15);
            this.outputOverallCost.TabIndex = 20;
            this.outputOverallCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 283);
            this.Controls.Add(this.outputOverallCost);
            this.Controls.Add(this.outputLaborCost);
            this.Controls.Add(this.outputPaintCost);
            this.Controls.Add(this.outputLaborHours);
            this.Controls.Add(this.btnSolveValues);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outputPaintRequired);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputPaintPrice);
            this.Controls.Add(this.inputPaintArea);
            this.Name = "Form1";
            this.Text = "Paint Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPaintArea;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox inputPaintPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label outputPaintRequired;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSolveValues;
        private System.Windows.Forms.Label outputLaborHours;
        private System.Windows.Forms.Label outputPaintCost;
        private System.Windows.Forms.Label outputLaborCost;
        private System.Windows.Forms.Label outputOverallCost;
    }
}

