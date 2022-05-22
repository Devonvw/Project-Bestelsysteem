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
            this.backButton = new View.CustomControls.CustomButton();
            this.changeOrderButton = new View.CustomControls.CustomButton();
            this.changeBillButton = new View.CustomControls.CustomButton();
            this.newOrderButton = new View.CustomControls.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toggleButton2 = new View.CustomControls.ToggleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.toggleButton1 = new View.CustomControls.ToggleButton();
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
            this.bonOverzichtListView.Size = new System.Drawing.Size(406, 456);
            this.bonOverzichtListView.TabIndex = 3;
            this.bonOverzichtListView.UseCompatibleStateImageBehavior = false;
            this.bonOverzichtListView.View = System.Windows.Forms.View.Details;
            // 
            // MenuItem
            // 
            this.MenuItem.Text = "Item";
            this.MenuItem.Width = 200;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 48;
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            this.Comment.Width = 100;
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
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.backButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.backButton.BorderColor = System.Drawing.Color.White;
            this.backButton.BorderRadius = 20;
            this.backButton.BorderSize = 1;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(224, 684);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(192, 70);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Terug naar overzicht";
            this.backButton.TextColor = System.Drawing.Color.White;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // changeOrderButton
            // 
            this.changeOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.changeOrderButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.changeOrderButton.BorderColor = System.Drawing.Color.White;
            this.changeOrderButton.BorderRadius = 20;
            this.changeOrderButton.BorderSize = 1;
            this.changeOrderButton.FlatAppearance.BorderSize = 0;
            this.changeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeOrderButton.ForeColor = System.Drawing.Color.White;
            this.changeOrderButton.Location = new System.Drawing.Point(10, 684);
            this.changeOrderButton.Name = "changeOrderButton";
            this.changeOrderButton.Size = new System.Drawing.Size(193, 70);
            this.changeOrderButton.TabIndex = 9;
            this.changeOrderButton.Text = "Wijzig laatste bestelling";
            this.changeOrderButton.TextColor = System.Drawing.Color.White;
            this.changeOrderButton.UseVisualStyleBackColor = false;
            // 
            // changeBillButton
            // 
            this.changeBillButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.changeBillButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.changeBillButton.BorderColor = System.Drawing.Color.White;
            this.changeBillButton.BorderRadius = 20;
            this.changeBillButton.BorderSize = 1;
            this.changeBillButton.FlatAppearance.BorderSize = 0;
            this.changeBillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBillButton.ForeColor = System.Drawing.Color.White;
            this.changeBillButton.Location = new System.Drawing.Point(224, 599);
            this.changeBillButton.Name = "changeBillButton";
            this.changeBillButton.Size = new System.Drawing.Size(192, 70);
            this.changeBillButton.TabIndex = 8;
            this.changeBillButton.Text = "Wijzig Bon";
            this.changeBillButton.TextColor = System.Drawing.Color.White;
            this.changeBillButton.UseVisualStyleBackColor = false;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.newOrderButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.newOrderButton.BorderColor = System.Drawing.Color.White;
            this.newOrderButton.BorderRadius = 20;
            this.newOrderButton.BorderSize = 1;
            this.newOrderButton.FlatAppearance.BorderSize = 0;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.ForeColor = System.Drawing.Color.White;
            this.newOrderButton.Location = new System.Drawing.Point(10, 599);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(193, 70);
            this.newOrderButton.TabIndex = 7;
            this.newOrderButton.Text = "Nieuwe bestelling";
            this.newOrderButton.TextColor = System.Drawing.Color.White;
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Groepeer dezelfde items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 14;
            // 
            // toggleButton2
            // 
            this.toggleButton2.Location = new System.Drawing.Point(315, 523);
            this.toggleButton2.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton2.Name = "toggleButton2";
            this.toggleButton2.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton2.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleButton2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton2.Size = new System.Drawing.Size(101, 23);
            this.toggleButton2.TabIndex = 15;
            this.toggleButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Laat producten in bereiding zien";
            // 
            // toggleButton1
            // 
            this.toggleButton1.Location = new System.Drawing.Point(315, 497);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.Size = new System.Drawing.Size(101, 23);
            this.toggleButton1.TabIndex = 17;
            this.toggleButton1.UseVisualStyleBackColor = true;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(428, 795);
            this.Controls.Add(this.toggleButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toggleButton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.changeOrderButton);
            this.Controls.Add(this.changeBillButton);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.bonOverzichtLabel);
            this.Controls.Add(this.bonOverzichtListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private CustomControls.CustomButton newOrderButton;
        private CustomControls.CustomButton changeBillButton;
        private CustomControls.CustomButton backButton;
        private CustomControls.CustomButton changeOrderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.ToggleButton toggleButton2;
        private System.Windows.Forms.Label label4;
        private CustomControls.ToggleButton toggleButton1;
    }
}