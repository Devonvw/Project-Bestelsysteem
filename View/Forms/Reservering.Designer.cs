namespace View.Forms
{
    partial class Reservering
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
            this.pnlChild = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlChild
            // 
            this.pnlChild.Location = new System.Drawing.Point(57, 96);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(726, 931);
            this.pnlChild.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnBack.BackgroundImage = global::View.Properties.Resources.icons8_arrow_96;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnBack.Location = new System.Drawing.Point(52, 25);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 59);
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Reservering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(852, 1055);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlChild);
            this.Name = "Reservering";
            this.Text = "Reservering";
            this.Load += new System.EventHandler(this.Reservering_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChild;
        private System.Windows.Forms.Button btnBack;
    }
}