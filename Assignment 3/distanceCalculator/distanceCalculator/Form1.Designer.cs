namespace distanceCalculator
{
    partial class distanceCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputSpeed = new System.Windows.Forms.TextBox();
            this.inputHours = new System.Windows.Forms.TextBox();
            this.calculateValues = new System.Windows.Forms.Button();
            this.exitProgram = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vVehicleDistance = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Speed in KPH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hours Traveled:";
            // 
            // inputSpeed
            // 
            this.inputSpeed.Location = new System.Drawing.Point(200, 9);
            this.inputSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputSpeed.Name = "inputSpeed";
            this.inputSpeed.Size = new System.Drawing.Size(148, 26);
            this.inputSpeed.TabIndex = 2;
            // 
            // inputHours
            // 
            this.inputHours.Location = new System.Drawing.Point(200, 49);
            this.inputHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputHours.Name = "inputHours";
            this.inputHours.Size = new System.Drawing.Size(148, 26);
            this.inputHours.TabIndex = 3;
            // 
            // calculateValues
            // 
            this.calculateValues.Location = new System.Drawing.Point(92, 349);
            this.calculateValues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculateValues.Name = "calculateValues";
            this.calculateValues.Size = new System.Drawing.Size(112, 35);
            this.calculateValues.TabIndex = 5;
            this.calculateValues.Text = "Calculate";
            this.calculateValues.UseVisualStyleBackColor = true;
            this.calculateValues.Click += new System.EventHandler(this.calculateValues_Click);
            // 
            // exitProgram
            // 
            this.exitProgram.Location = new System.Drawing.Point(213, 349);
            this.exitProgram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitProgram.Name = "exitProgram";
            this.exitProgram.Size = new System.Drawing.Size(112, 35);
            this.exitProgram.TabIndex = 6;
            this.exitProgram.Text = "Exit";
            this.exitProgram.UseVisualStyleBackColor = true;
            this.exitProgram.Click += new System.EventHandler(this.exitProgram_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // vVehicleDistance
            // 
            this.vVehicleDistance.FormattingEnabled = true;
            this.vVehicleDistance.ItemHeight = 20;
            this.vVehicleDistance.Location = new System.Drawing.Point(15, 95);
            this.vVehicleDistance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vVehicleDistance.Name = "vVehicleDistance";
            this.vVehicleDistance.Size = new System.Drawing.Size(391, 244);
            this.vVehicleDistance.TabIndex = 7;
            // 
            // distanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 403);
            this.Controls.Add(this.vVehicleDistance);
            this.Controls.Add(this.exitProgram);
            this.Controls.Add(this.calculateValues);
            this.Controls.Add(this.inputHours);
            this.Controls.Add(this.inputSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "distanceCalculator";
            this.Text = "Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputSpeed;
        private System.Windows.Forms.TextBox inputHours;
        private System.Windows.Forms.Button calculateValues;
        private System.Windows.Forms.Button exitProgram;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox vVehicleDistance;
    }
}

