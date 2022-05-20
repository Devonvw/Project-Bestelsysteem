namespace View.Forms.Order_Screens
{
    partial class Overview
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
            this.BillOverview = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BillOverview
            // 
            this.BillOverview.FormattingEnabled = true;
            this.BillOverview.ItemHeight = 16;
            this.BillOverview.Location = new System.Drawing.Point(12, 12);
            this.BillOverview.MultiColumn = true;
            this.BillOverview.Name = "BillOverview";
            this.BillOverview.Size = new System.Drawing.Size(529, 292);
            this.BillOverview.TabIndex = 2;
            this.BillOverview.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(571, 979);
            this.Controls.Add(this.BillOverview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Overview";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BillOverview;
    }
}