﻿namespace View
{
    partial class BestelsysteemUI
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
            this.pnlForms = new System.Windows.Forms.Panel();
            this.customButton1 = new View.CustomControls.CustomButton();
            this.toggleButton1 = new View.CustomControls.ToggleButton();
            this.billScreenButton = new System.Windows.Forms.Button();
            this.orderScreenButton = new System.Windows.Forms.Button();
            this.pnlForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForms
            // 
            this.pnlForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForms.BackColor = System.Drawing.Color.Transparent;
            this.pnlForms.Controls.Add(this.customButton1);
            this.pnlForms.Controls.Add(this.toggleButton1);
            this.pnlForms.Controls.Add(this.billScreenButton);
            this.pnlForms.Controls.Add(this.orderScreenButton);
            this.pnlForms.Location = new System.Drawing.Point(-4, -3);
            this.pnlForms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(1707, 864);
            this.pnlForms.TabIndex = 0;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 40;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(684, 86);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(397, 73);
            this.customButton1.TabIndex = 3;
            this.customButton1.Text = "customButton1";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // toggleButton1
            // 
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.Location = new System.Drawing.Point(937, 36);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.Size = new System.Drawing.Size(45, 22);
            this.toggleButton1.TabIndex = 2;
            this.toggleButton1.UseVisualStyleBackColor = true;
            // 
            // billScreenButton
            // 
            this.billScreenButton.Location = new System.Drawing.Point(260, 66);
            this.billScreenButton.Name = "billScreenButton";
            this.billScreenButton.Size = new System.Drawing.Size(162, 120);
            this.billScreenButton.TabIndex = 1;
            this.billScreenButton.Text = "BillScreen";
            this.billScreenButton.UseVisualStyleBackColor = true;
            this.billScreenButton.Click += new System.EventHandler(this.billScreenButton_click);
            // 
            // orderScreenButton
            // 
            this.orderScreenButton.Location = new System.Drawing.Point(64, 66);
            this.orderScreenButton.Name = "orderScreenButton";
            this.orderScreenButton.Size = new System.Drawing.Size(162, 120);
            this.orderScreenButton.TabIndex = 0;
            this.orderScreenButton.Text = "OrderScreen";
            this.orderScreenButton.UseVisualStyleBackColor = true;
            this.orderScreenButton.Click += new System.EventHandler(this.orderScreenButton_click);
            // 
            // BestelsysteemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1707, 844);
            this.Controls.Add(this.pnlForms);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BestelsysteemUI";
            this.Text = "BestelsysteemUI";
            this.pnlForms.ResumeLayout(false);
            this.pnlForms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.Button orderScreenButton;
        private System.Windows.Forms.Button billScreenButton;
        private CustomControls.ToggleButton toggleButton1;
        private CustomControls.CustomButton customButton1;
    }
}