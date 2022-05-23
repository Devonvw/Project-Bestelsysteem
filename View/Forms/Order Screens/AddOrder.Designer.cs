namespace View.Forms.Order_Screens
{
    partial class AddOrder
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
            this.menuItemsListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubCategorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuTextLabel = new System.Windows.Forms.Label();
            this.addedItemLabel = new System.Windows.Forms.Label();
            this.newOrderItemsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountLabel = new System.Windows.Forms.Label();
            this.minusButton = new View.CustomControls.CustomButton();
            this.plusButton = new View.CustomControls.CustomButton();
            this.addItemButton = new View.CustomControls.CustomButton();
            this.backToOverviewButton = new View.CustomControls.CustomButton();
            this.insertOrderButton = new View.CustomControls.CustomButton();
            this.SuspendLayout();
            // 
            // menuItemsListView
            // 
            this.menuItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Item,
            this.Categorie,
            this.SubCategorie});
            this.menuItemsListView.FullRowSelect = true;
            this.menuItemsListView.GridLines = true;
            this.menuItemsListView.HideSelection = false;
            this.menuItemsListView.Location = new System.Drawing.Point(12, 22);
            this.menuItemsListView.Name = "menuItemsListView";
            this.menuItemsListView.Size = new System.Drawing.Size(388, 433);
            this.menuItemsListView.TabIndex = 0;
            this.menuItemsListView.UseCompatibleStateImageBehavior = false;
            this.menuItemsListView.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 120;
            // 
            // Categorie
            // 
            this.Categorie.Text = "Categorie";
            this.Categorie.Width = 71;
            // 
            // SubCategorie
            // 
            this.SubCategorie.Text = "SubCategorie";
            this.SubCategorie.Width = 117;
            // 
            // menuTextLabel
            // 
            this.menuTextLabel.AutoSize = true;
            this.menuTextLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.menuTextLabel.Location = new System.Drawing.Point(13, 6);
            this.menuTextLabel.Name = "menuTextLabel";
            this.menuTextLabel.Size = new System.Drawing.Size(34, 13);
            this.menuTextLabel.TabIndex = 1;
            this.menuTextLabel.Text = "Menu";
            // 
            // addedItemLabel
            // 
            this.addedItemLabel.AutoSize = true;
            this.addedItemLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.addedItemLabel.Location = new System.Drawing.Point(13, 487);
            this.addedItemLabel.Name = "addedItemLabel";
            this.addedItemLabel.Size = new System.Drawing.Size(73, 13);
            this.addedItemLabel.TabIndex = 4;
            this.addedItemLabel.Text = "Nieuwe order:";
            // 
            // newOrderItemsListView
            // 
            this.newOrderItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.newOrderItemsListView.FullRowSelect = true;
            this.newOrderItemsListView.GridLines = true;
            this.newOrderItemsListView.HideSelection = false;
            this.newOrderItemsListView.Location = new System.Drawing.Point(12, 503);
            this.newOrderItemsListView.Name = "newOrderItemsListView";
            this.newOrderItemsListView.Size = new System.Drawing.Size(388, 124);
            this.newOrderItemsListView.TabIndex = 5;
            this.newOrderItemsListView.UseCompatibleStateImageBehavior = false;
            this.newOrderItemsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 241;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Aantal";
            this.columnHeader2.Width = 140;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.amountLabel.Location = new System.Drawing.Point(148, 461);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(37, 39);
            this.amountLabel.TabIndex = 9;
            this.amountLabel.Text = "1";
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.Tomato;
            this.minusButton.BackgroundColor = System.Drawing.Color.Tomato;
            this.minusButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.minusButton.BorderRadius = 23;
            this.minusButton.BorderSize = 0;
            this.minusButton.FlatAppearance.BorderSize = 0;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.ForeColor = System.Drawing.Color.Black;
            this.minusButton.Location = new System.Drawing.Point(191, 461);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(44, 37);
            this.minusButton.TabIndex = 8;
            this.minusButton.Text = "-";
            this.minusButton.TextColor = System.Drawing.Color.Black;
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.PaleGreen;
            this.plusButton.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.plusButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plusButton.BorderRadius = 25;
            this.plusButton.BorderSize = 0;
            this.plusButton.FlatAppearance.BorderSize = 0;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.ForeColor = System.Drawing.Color.Black;
            this.plusButton.Location = new System.Drawing.Point(241, 461);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(44, 37);
            this.plusButton.TabIndex = 7;
            this.plusButton.Text = "+";
            this.plusButton.TextColor = System.Drawing.Color.Black;
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addItemButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addItemButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addItemButton.BorderRadius = 20;
            this.addItemButton.BorderSize = 0;
            this.addItemButton.FlatAppearance.BorderSize = 0;
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemButton.ForeColor = System.Drawing.Color.White;
            this.addItemButton.Location = new System.Drawing.Point(291, 461);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(109, 37);
            this.addItemButton.TabIndex = 6;
            this.addItemButton.Text = "Voeg Toe";
            this.addItemButton.TextColor = System.Drawing.Color.White;
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // backToOverviewButton
            // 
            this.backToOverviewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.backToOverviewButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.backToOverviewButton.BorderColor = System.Drawing.Color.White;
            this.backToOverviewButton.BorderRadius = 20;
            this.backToOverviewButton.BorderSize = 1;
            this.backToOverviewButton.FlatAppearance.BorderSize = 0;
            this.backToOverviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToOverviewButton.ForeColor = System.Drawing.Color.White;
            this.backToOverviewButton.Location = new System.Drawing.Point(216, 664);
            this.backToOverviewButton.Name = "backToOverviewButton";
            this.backToOverviewButton.Size = new System.Drawing.Size(184, 70);
            this.backToOverviewButton.TabIndex = 12;
            this.backToOverviewButton.Text = "Terug naar bon overzicht";
            this.backToOverviewButton.TextColor = System.Drawing.Color.White;
            this.backToOverviewButton.UseVisualStyleBackColor = false;
            this.backToOverviewButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // insertOrderButton
            // 
            this.insertOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.insertOrderButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.insertOrderButton.BorderColor = System.Drawing.Color.White;
            this.insertOrderButton.BorderRadius = 20;
            this.insertOrderButton.BorderSize = 1;
            this.insertOrderButton.FlatAppearance.BorderSize = 0;
            this.insertOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertOrderButton.ForeColor = System.Drawing.Color.White;
            this.insertOrderButton.Location = new System.Drawing.Point(12, 664);
            this.insertOrderButton.Name = "insertOrderButton";
            this.insertOrderButton.Size = new System.Drawing.Size(183, 70);
            this.insertOrderButton.TabIndex = 11;
            this.insertOrderButton.Text = "Plaats bestelling";
            this.insertOrderButton.TextColor = System.Drawing.Color.White;
            this.insertOrderButton.UseVisualStyleBackColor = false;
            this.insertOrderButton.Click += new System.EventHandler(this.insertOrderButton_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(412, 756);
            this.Controls.Add(this.backToOverviewButton);
            this.Controls.Add(this.insertOrderButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.newOrderItemsListView);
            this.Controls.Add(this.addedItemLabel);
            this.Controls.Add(this.menuTextLabel);
            this.Controls.Add(this.menuItemsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrder";
            this.Text = "AddOrderScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView menuItemsListView;
        private System.Windows.Forms.Label menuTextLabel;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Categorie;
        private System.Windows.Forms.ColumnHeader SubCategorie;
        private System.Windows.Forms.Label addedItemLabel;
        private System.Windows.Forms.ListView newOrderItemsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader ID;
        private CustomControls.CustomButton addItemButton;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private CustomControls.CustomButton plusButton;
        private CustomControls.CustomButton minusButton;
        private System.Windows.Forms.Label amountLabel;
        private CustomControls.CustomButton backToOverviewButton;
        private CustomControls.CustomButton insertOrderButton;
    }
}