namespace View.Forms
{
    partial class OrderScreenParent
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.tableNumberLabel = new System.Windows.Forms.Label();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.tableNumberLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(571, 123);
            this.topPanel.TabIndex = 0;
            // 
            // tableNumberLabel
            // 
            this.tableNumberLabel.AutoSize = true;
            this.tableNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tableNumberLabel.Location = new System.Drawing.Point(170, 39);
            this.tableNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableNumberLabel.Name = "tableNumberLabel";
            this.tableNumberLabel.Size = new System.Drawing.Size(140, 54);
            this.tableNumberLabel.TabIndex = 0;
            this.tableNumberLabel.Text = "Table";
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(0, 123);
            this.childFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(571, 979);
            this.childFormPanel.TabIndex = 2;
            // 
            // OrderScreenParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 1102);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderScreenParent";
            this.Text = "Order screen";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Label tableNumberLabel;
    }
}