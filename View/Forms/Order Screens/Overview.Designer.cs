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
            this.bonOverzichtListView = new System.Windows.Forms.ListView();
            this.MenuItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bonOverzichtLabel = new System.Windows.Forms.Label();
            this.inBereidingOverzichtListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.customButton1 = new View.CustomControls.CustomButton();
            this.SuspendLayout();
            // 
            // bonOverzichtListView
            // 
            this.bonOverzichtListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MenuItem,
            this.Amount,
            this.Comment});
            this.bonOverzichtListView.HideSelection = false;
            this.bonOverzichtListView.Location = new System.Drawing.Point(10, 31);
            this.bonOverzichtListView.Name = "bonOverzichtListView";
            this.bonOverzichtListView.Size = new System.Drawing.Size(406, 405);
            this.bonOverzichtListView.TabIndex = 3;
            this.bonOverzichtListView.UseCompatibleStateImageBehavior = false;
            this.bonOverzichtListView.View = System.Windows.Forms.View.Details;
            // 
            // MenuItem
            // 
            this.MenuItem.Text = "Item";
            this.MenuItem.Width = 100;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 48;
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            this.Comment.Width = 246;
            // 
            // bonOverzichtLabel
            // 
            this.bonOverzichtLabel.AutoSize = true;
            this.bonOverzichtLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.bonOverzichtLabel.Location = new System.Drawing.Point(10, 12);
            this.bonOverzichtLabel.Name = "bonOverzichtLabel";
            this.bonOverzichtLabel.Size = new System.Drawing.Size(74, 13);
            this.bonOverzichtLabel.TabIndex = 4;
            this.bonOverzichtLabel.Text = "Bon Overzicht";
            // 
            // inBereidingOverzichtListView
            // 
            this.inBereidingOverzichtListView.HideSelection = false;
            this.inBereidingOverzichtListView.Location = new System.Drawing.Point(10, 456);
            this.inBereidingOverzichtListView.Name = "inBereidingOverzichtListView";
            this.inBereidingOverzichtListView.Size = new System.Drawing.Size(406, 113);
            this.inBereidingOverzichtListView.TabIndex = 5;
            this.inBereidingOverzichtListView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "In Bereiding";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.SystemColors.Control;
            this.customButton1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.customButton1.BorderRadius = 20;
            this.customButton1.BorderSize = 10;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(10, 594);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(181, 70);
            this.customButton1.TabIndex = 7;
            this.customButton1.Text = "customButton1";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(428, 795);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inBereidingOverzichtListView);
            this.Controls.Add(this.bonOverzichtLabel);
            this.Controls.Add(this.bonOverzichtListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Overview";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView bonOverzichtListView;
        private System.Windows.Forms.ColumnHeader MenuItem;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.Label bonOverzichtLabel;
        private System.Windows.Forms.ListView inBereidingOverzichtListView;
        private System.Windows.Forms.Label label1;
        private CustomControls.CustomButton customButton1;
    }
}