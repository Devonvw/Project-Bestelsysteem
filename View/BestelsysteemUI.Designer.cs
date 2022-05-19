namespace View
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
            this.pnlForms.Controls.Add(this.orderScreenButton);
            this.pnlForms.Location = new System.Drawing.Point(-4, -3);
            this.pnlForms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(1707, 864);
            this.pnlForms.TabIndex = 0;
            // 
            // orderScreenButton
            // 
            this.orderScreenButton.Location = new System.Drawing.Point(29, 15);
            this.orderScreenButton.Name = "orderScreenButton";
            this.orderScreenButton.Size = new System.Drawing.Size(253, 151);
            this.orderScreenButton.TabIndex = 0;
            this.orderScreenButton.Text = "Order Screen";
            this.orderScreenButton.UseVisualStyleBackColor = true;
            this.orderScreenButton.Click += new System.EventHandler(this.orderScreenButton_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.Button orderScreenButton;
    }
}