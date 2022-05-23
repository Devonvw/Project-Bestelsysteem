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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.overViewPanel = new System.Windows.Forms.Panel();
            this.orderInPreparationToggle = new View.CustomControls.ToggleButton();
            this.groupItemsToggle = new View.CustomControls.ToggleButton();
            this.backButton = new View.CustomControls.CustomButton();
            this.changeOrderButton = new View.CustomControls.CustomButton();
            this.newOrderButton = new View.CustomControls.CustomButton();
            this.overViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bonOverzichtListView
            // 
            this.bonOverzichtListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MenuItem,
            this.Amount,
            this.Comment});
            this.bonOverzichtListView.HideSelection = false;
            this.bonOverzichtListView.Location = new System.Drawing.Point(10, 25);
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
            this.bonOverzichtLabel.Location = new System.Drawing.Point(10, 9);
            this.bonOverzichtLabel.Name = "bonOverzichtLabel";
            this.bonOverzichtLabel.Size = new System.Drawing.Size(74, 13);
            this.bonOverzichtLabel.TabIndex = 4;
            this.bonOverzichtLabel.Text = "Bon Overzicht";
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
            this.label2.Location = new System.Drawing.Point(12, 496);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Laat bestelling in bereiding zien";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-189, -91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 18;
            // 
            // overViewPanel
            // 
            this.overViewPanel.Controls.Add(this.bonOverzichtLabel);
            this.overViewPanel.Controls.Add(this.orderInPreparationToggle);
            this.overViewPanel.Controls.Add(this.groupItemsToggle);
            this.overViewPanel.Controls.Add(this.backButton);
            this.overViewPanel.Controls.Add(this.bonOverzichtListView);
            this.overViewPanel.Controls.Add(this.changeOrderButton);
            this.overViewPanel.Controls.Add(this.label4);
            this.overViewPanel.Controls.Add(this.newOrderButton);
            this.overViewPanel.Controls.Add(this.label2);
            this.overViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overViewPanel.Location = new System.Drawing.Point(0, 0);
            this.overViewPanel.Name = "overViewPanel";
            this.overViewPanel.Size = new System.Drawing.Size(428, 795);
            this.overViewPanel.TabIndex = 19;
            // 
            // orderInPreparationToggle
            // 
            this.orderInPreparationToggle.Location = new System.Drawing.Point(315, 523);
            this.orderInPreparationToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.orderInPreparationToggle.Name = "orderInPreparationToggle";
            this.orderInPreparationToggle.OffBackColor = System.Drawing.Color.Gray;
            this.orderInPreparationToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.orderInPreparationToggle.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.orderInPreparationToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.orderInPreparationToggle.Size = new System.Drawing.Size(101, 23);
            this.orderInPreparationToggle.TabIndex = 15;
            this.orderInPreparationToggle.UseVisualStyleBackColor = true;
            this.orderInPreparationToggle.CheckedChanged += new System.EventHandler(this.toggleButton2_CheckedChanged);
            // 
            // groupItemsToggle
            // 
            this.groupItemsToggle.Location = new System.Drawing.Point(315, 494);
            this.groupItemsToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.groupItemsToggle.Name = "groupItemsToggle";
            this.groupItemsToggle.OffBackColor = System.Drawing.Color.Gray;
            this.groupItemsToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.groupItemsToggle.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupItemsToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.groupItemsToggle.Size = new System.Drawing.Size(101, 23);
            this.groupItemsToggle.TabIndex = 17;
            this.groupItemsToggle.UseVisualStyleBackColor = true;
            this.groupItemsToggle.CheckedChanged += new System.EventHandler(this.groupItemsToggle_CheckedChanged);
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
            this.backButton.Location = new System.Drawing.Point(13, 697);
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
            this.changeOrderButton.Location = new System.Drawing.Point(223, 612);
            this.changeOrderButton.Name = "changeOrderButton";
            this.changeOrderButton.Size = new System.Drawing.Size(193, 70);
            this.changeOrderButton.TabIndex = 9;
            this.changeOrderButton.Text = "Wijzig bestelling in bereiding";
            this.changeOrderButton.TextColor = System.Drawing.Color.White;
            this.changeOrderButton.UseVisualStyleBackColor = false;
            this.changeOrderButton.Click += new System.EventHandler(this.changeOrderButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.newOrderButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.newOrderButton.BorderColor = System.Drawing.Color.PaleGreen;
            this.newOrderButton.BorderRadius = 20;
            this.newOrderButton.BorderSize = 3;
            this.newOrderButton.FlatAppearance.BorderSize = 0;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.ForeColor = System.Drawing.Color.White;
            this.newOrderButton.Location = new System.Drawing.Point(223, 697);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(193, 70);
            this.newOrderButton.TabIndex = 7;
            this.newOrderButton.Text = "Nieuwe bestelling";
            this.newOrderButton.TextColor = System.Drawing.Color.White;
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(428, 795);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.overViewPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Overview";
            this.Text = "Overview";
            this.overViewPanel.ResumeLayout(false);
            this.overViewPanel.PerformLayout();
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
        private CustomControls.CustomButton backButton;
        private CustomControls.CustomButton changeOrderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.ToggleButton orderInPreparationToggle;
        private System.Windows.Forms.Label label4;
        private CustomControls.ToggleButton groupItemsToggle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel overViewPanel;
    }
}