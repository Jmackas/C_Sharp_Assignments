﻿namespace File_To_Array
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
            this.getValuesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getValuesButton
            // 
            this.getValuesButton.Location = new System.Drawing.Point(23, 113);
            this.getValuesButton.Name = "getValuesButton";
            this.getValuesButton.Size = new System.Drawing.Size(75, 23);
            this.getValuesButton.TabIndex = 1;
            this.getValuesButton.Text = "Get Values";
            this.getValuesButton.UseVisualStyleBackColor = true;
            this.getValuesButton.Click += new System.EventHandler(this.getValuesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(104, 113);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 148);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getValuesButton);
            this.Name = "Form1";
            this.Text = "File To Array";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button getValuesButton;
        private System.Windows.Forms.Button exitButton;
    }
}

