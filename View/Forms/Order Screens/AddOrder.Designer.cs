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
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubCategorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuTextLabel = new System.Windows.Forms.Label();
            this.addedItemLabel = new System.Windows.Forms.Label();
            this.addedOrderItemsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.menuItemsListView.ItemActivate += new System.EventHandler(this.menuItemsListView_ItemActivate);
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
            this.addedItemLabel.Size = new System.Drawing.Size(139, 13);
            this.addedItemLabel.TabIndex = 4;
            this.addedItemLabel.Text = "Toegevoegd aan bestelling:";
            // 
            // addedOrderItemsListView
            // 
            this.addedOrderItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.addedOrderItemsListView.FullRowSelect = true;
            this.addedOrderItemsListView.GridLines = true;
            this.addedOrderItemsListView.HideSelection = false;
            this.addedOrderItemsListView.Location = new System.Drawing.Point(12, 503);
            this.addedOrderItemsListView.Name = "addedOrderItemsListView";
            this.addedOrderItemsListView.Size = new System.Drawing.Size(388, 124);
            this.addedOrderItemsListView.TabIndex = 5;
            this.addedOrderItemsListView.UseCompatibleStateImageBehavior = false;
            this.addedOrderItemsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 195;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Categorie";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SubCategorie";
            this.columnHeader3.Width = 117;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(412, 756);
            this.Controls.Add(this.addedOrderItemsListView);
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
        private System.Windows.Forms.ListView addedOrderItemsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader ID;
    }
}