﻿namespace _11_04_2022_part_2
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
            this.CB_TimB = new System.Windows.Forms.ComboBox();
            this.CB_TimA = new System.Windows.Forms.ComboBox();
            this.Label_ManagerA = new System.Windows.Forms.Label();
            this.Label_VS = new System.Windows.Forms.Label();
            this.Label_CaptainA = new System.Windows.Forms.Label();
            this.Label_OutputManagerA = new System.Windows.Forms.Label();
            this.Label_OutputCaptainA = new System.Windows.Forms.Label();
            this.Label_ManagerB = new System.Windows.Forms.Label();
            this.Label_CaptainB = new System.Windows.Forms.Label();
            this.Label_OutputManagerB = new System.Windows.Forms.Label();
            this.Label_OutputCaptain2 = new System.Windows.Forms.Label();
            this.Label_Stadium = new System.Windows.Forms.Label();
            this.Label_Capacity = new System.Windows.Forms.Label();
            this.Label_OutputStadium = new System.Windows.Forms.Label();
            this.Label_OutputCapacity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_TimB
            // 
            this.CB_TimB.FormattingEnabled = true;
            this.CB_TimB.Location = new System.Drawing.Point(250, 27);
            this.CB_TimB.Name = "CB_TimB";
            this.CB_TimB.Size = new System.Drawing.Size(187, 21);
            this.CB_TimB.TabIndex = 0;
            this.CB_TimB.SelectedIndexChanged += new System.EventHandler(this.CB_TimB_SelectedIndexChanged);
            // 
            // CB_TimA
            // 
            this.CB_TimA.FormattingEnabled = true;
            this.CB_TimA.Location = new System.Drawing.Point(12, 27);
            this.CB_TimA.Name = "CB_TimA";
            this.CB_TimA.Size = new System.Drawing.Size(187, 21);
            this.CB_TimA.TabIndex = 1;
            this.CB_TimA.SelectedIndexChanged += new System.EventHandler(this.CB_TimA_SelectedIndexChanged);
            // 
            // Label_ManagerA
            // 
            this.Label_ManagerA.AutoSize = true;
            this.Label_ManagerA.Location = new System.Drawing.Point(12, 90);
            this.Label_ManagerA.Name = "Label_ManagerA";
            this.Label_ManagerA.Size = new System.Drawing.Size(55, 13);
            this.Label_ManagerA.TabIndex = 2;
            this.Label_ManagerA.Text = "Manager :";
            // 
            // Label_VS
            // 
            this.Label_VS.AutoSize = true;
            this.Label_VS.Location = new System.Drawing.Point(214, 30);
            this.Label_VS.Name = "Label_VS";
            this.Label_VS.Size = new System.Drawing.Size(21, 13);
            this.Label_VS.TabIndex = 3;
            this.Label_VS.Text = "VS";
            // 
            // Label_CaptainA
            // 
            this.Label_CaptainA.AutoSize = true;
            this.Label_CaptainA.Location = new System.Drawing.Point(12, 117);
            this.Label_CaptainA.Name = "Label_CaptainA";
            this.Label_CaptainA.Size = new System.Drawing.Size(49, 13);
            this.Label_CaptainA.TabIndex = 4;
            this.Label_CaptainA.Text = "Captain :";
            // 
            // Label_OutputManagerA
            // 
            this.Label_OutputManagerA.AutoSize = true;
            this.Label_OutputManagerA.Location = new System.Drawing.Point(67, 90);
            this.Label_OutputManagerA.Name = "Label_OutputManagerA";
            this.Label_OutputManagerA.Size = new System.Drawing.Size(16, 13);
            this.Label_OutputManagerA.TabIndex = 5;
            this.Label_OutputManagerA.Text = "...";
            this.Label_OutputManagerA.Click += new System.EventHandler(this.Label_OutputManagerA_Click);
            // 
            // Label_OutputCaptainA
            // 
            this.Label_OutputCaptainA.AutoSize = true;
            this.Label_OutputCaptainA.Location = new System.Drawing.Point(67, 117);
            this.Label_OutputCaptainA.Name = "Label_OutputCaptainA";
            this.Label_OutputCaptainA.Size = new System.Drawing.Size(16, 13);
            this.Label_OutputCaptainA.TabIndex = 6;
            this.Label_OutputCaptainA.Text = "...";
            // 
            // Label_ManagerB
            // 
            this.Label_ManagerB.AutoSize = true;
            this.Label_ManagerB.Location = new System.Drawing.Point(247, 90);
            this.Label_ManagerB.Name = "Label_ManagerB";
            this.Label_ManagerB.Size = new System.Drawing.Size(55, 13);
            this.Label_ManagerB.TabIndex = 7;
            this.Label_ManagerB.Text = "Manager :";
            // 
            // Label_CaptainB
            // 
            this.Label_CaptainB.AutoSize = true;
            this.Label_CaptainB.Location = new System.Drawing.Point(247, 117);
            this.Label_CaptainB.Name = "Label_CaptainB";
            this.Label_CaptainB.Size = new System.Drawing.Size(49, 13);
            this.Label_CaptainB.TabIndex = 8;
            this.Label_CaptainB.Text = "Captain :";
            // 
            // Label_OutputManagerB
            // 
            this.Label_OutputManagerB.AutoSize = true;
            this.Label_OutputManagerB.Location = new System.Drawing.Point(308, 90);
            this.Label_OutputManagerB.Name = "Label_OutputManagerB";
            this.Label_OutputManagerB.Size = new System.Drawing.Size(16, 13);
            this.Label_OutputManagerB.TabIndex = 9;
            this.Label_OutputManagerB.Text = "...";
            this.Label_OutputManagerB.Click += new System.EventHandler(this.Label_OutputManagerB_Click);
            // 
            // Label_OutputCaptain2
            // 
            this.Label_OutputCaptain2.AutoSize = true;
            this.Label_OutputCaptain2.Location = new System.Drawing.Point(302, 117);
            this.Label_OutputCaptain2.Name = "Label_OutputCaptain2";
            this.Label_OutputCaptain2.Size = new System.Drawing.Size(16, 13);
            this.Label_OutputCaptain2.TabIndex = 10;
            this.Label_OutputCaptain2.Text = "...";
            // 
            // Label_Stadium
            // 
            this.Label_Stadium.AutoSize = true;
            this.Label_Stadium.Location = new System.Drawing.Point(163, 199);
            this.Label_Stadium.Name = "Label_Stadium";
            this.Label_Stadium.Size = new System.Drawing.Size(51, 13);
            this.Label_Stadium.TabIndex = 11;
            this.Label_Stadium.Text = "Stadium :";
            this.Label_Stadium.Click += new System.EventHandler(this.label9_Click);
            // 
            // Label_Capacity
            // 
            this.Label_Capacity.AutoSize = true;
            this.Label_Capacity.Location = new System.Drawing.Point(163, 225);
            this.Label_Capacity.Name = "Label_Capacity";
            this.Label_Capacity.Size = new System.Drawing.Size(54, 13);
            this.Label_Capacity.TabIndex = 12;
            this.Label_Capacity.Text = "Capacity :";
            // 
            // Label_OutputStadium
            // 
            this.Label_OutputStadium.AutoSize = true;
            this.Label_OutputStadium.Location = new System.Drawing.Point(229, 199);
            this.Label_OutputStadium.Name = "Label_OutputStadium";
            this.Label_OutputStadium.Size = new System.Drawing.Size(16, 13);
            this.Label_OutputStadium.TabIndex = 13;
            this.Label_OutputStadium.Text = "...";
            // 
            // Label_OutputCapacity
            // 
            this.Label_OutputCapacity.AutoSize = true;
            this.Label_OutputCapacity.Location = new System.Drawing.Point(229, 225);
            this.Label_OutputCapacity.Name = "Label_OutputCapacity";
            this.Label_OutputCapacity.Size = new System.Drawing.Size(16, 13);
            this.Label_OutputCapacity.TabIndex = 14;
            this.Label_OutputCapacity.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 266);
            this.Controls.Add(this.Label_OutputCapacity);
            this.Controls.Add(this.Label_OutputStadium);
            this.Controls.Add(this.Label_Capacity);
            this.Controls.Add(this.Label_Stadium);
            this.Controls.Add(this.Label_OutputCaptain2);
            this.Controls.Add(this.Label_OutputManagerB);
            this.Controls.Add(this.Label_CaptainB);
            this.Controls.Add(this.Label_ManagerB);
            this.Controls.Add(this.Label_OutputCaptainA);
            this.Controls.Add(this.Label_OutputManagerA);
            this.Controls.Add(this.Label_CaptainA);
            this.Controls.Add(this.Label_VS);
            this.Controls.Add(this.Label_ManagerA);
            this.Controls.Add(this.CB_TimA);
            this.Controls.Add(this.CB_TimB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_TimB;
        private System.Windows.Forms.ComboBox CB_TimA;
        private System.Windows.Forms.Label Label_ManagerA;
        private System.Windows.Forms.Label Label_VS;
        private System.Windows.Forms.Label Label_CaptainA;
        private System.Windows.Forms.Label Label_OutputManagerA;
        private System.Windows.Forms.Label Label_OutputCaptainA;
        private System.Windows.Forms.Label Label_ManagerB;
        private System.Windows.Forms.Label Label_CaptainB;
        private System.Windows.Forms.Label Label_OutputManagerB;
        private System.Windows.Forms.Label Label_OutputCaptain2;
        private System.Windows.Forms.Label Label_Stadium;
        private System.Windows.Forms.Label Label_Capacity;
        private System.Windows.Forms.Label Label_OutputStadium;
        private System.Windows.Forms.Label Label_OutputCapacity;
    }
}

