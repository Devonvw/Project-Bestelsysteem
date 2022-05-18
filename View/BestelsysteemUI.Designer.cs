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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForms
            // 
            this.pnlForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForms.BackColor = System.Drawing.Color.Transparent;
            this.pnlForms.Controls.Add(this.button2);
            this.pnlForms.Controls.Add(this.button1);
            this.pnlForms.Location = new System.Drawing.Point(-3, -3);
            this.pnlForms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(1280, 702);
            this.pnlForms.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Order Screen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "Bill Screen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BestelsysteemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1280, 690);
            this.Controls.Add(this.pnlForms);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BestelsysteemUI";
            this.Text = "BestelsysteemUI";
            this.pnlForms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}