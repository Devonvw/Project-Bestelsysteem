namespace View.Forms.ManagementScreens
{
    partial class StockManagement
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
            this.lblInventory = new System.Windows.Forms.Label();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.lblMenuItemName = new System.Windows.Forms.Label();
            this.btnAdd6 = new View.CustomControls.CustomButton();
            this.btnAdd24 = new View.CustomControls.CustomButton();
            this.btnAdd12 = new View.CustomControls.CustomButton();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new View.CustomControls.CustomButton();
            this.ltvStockItems = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Myanmar Text", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.ForeColor = System.Drawing.Color.White;
            this.lblInventory.Location = new System.Drawing.Point(795, 9);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(312, 113);
            this.lblInventory.TabIndex = 9;
            this.lblInventory.Text = "Voorraad";
            // 
            // pnlInputs
            // 
            this.pnlInputs.BackColor = System.Drawing.Color.White;
            this.pnlInputs.Controls.Add(this.lblMenuItemName);
            this.pnlInputs.Controls.Add(this.btnAdd6);
            this.pnlInputs.Controls.Add(this.btnAdd24);
            this.pnlInputs.Controls.Add(this.btnAdd12);
            this.pnlInputs.Controls.Add(this.numStock);
            this.pnlInputs.Controls.Add(this.btnSave);
            this.pnlInputs.Location = new System.Drawing.Point(1070, 187);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Size = new System.Drawing.Size(772, 628);
            this.pnlInputs.TabIndex = 12;
            // 
            // lblMenuItemName
            // 
            this.lblMenuItemName.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.lblMenuItemName.Location = new System.Drawing.Point(59, 26);
            this.lblMenuItemName.Name = "lblMenuItemName";
            this.lblMenuItemName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMenuItemName.Size = new System.Drawing.Size(635, 78);
            this.lblMenuItemName.TabIndex = 34;
            this.lblMenuItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd6
            // 
            this.btnAdd6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd6.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd6.BorderRadius = 20;
            this.btnAdd6.BorderSize = 0;
            this.btnAdd6.FlatAppearance.BorderSize = 0;
            this.btnAdd6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd6.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd6.ForeColor = System.Drawing.Color.White;
            this.btnAdd6.Location = new System.Drawing.Point(59, 142);
            this.btnAdd6.Name = "btnAdd6";
            this.btnAdd6.Size = new System.Drawing.Size(166, 91);
            this.btnAdd6.TabIndex = 33;
            this.btnAdd6.Text = "+6";
            this.btnAdd6.TextColor = System.Drawing.Color.White;
            this.btnAdd6.UseVisualStyleBackColor = false;
            this.btnAdd6.Click += new System.EventHandler(this.btnAdd6_Click);
            // 
            // btnAdd24
            // 
            this.btnAdd24.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd24.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd24.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd24.BorderRadius = 20;
            this.btnAdd24.BorderSize = 0;
            this.btnAdd24.FlatAppearance.BorderSize = 0;
            this.btnAdd24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd24.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd24.ForeColor = System.Drawing.Color.White;
            this.btnAdd24.Location = new System.Drawing.Point(528, 142);
            this.btnAdd24.Name = "btnAdd24";
            this.btnAdd24.Size = new System.Drawing.Size(166, 91);
            this.btnAdd24.TabIndex = 32;
            this.btnAdd24.Text = "+24";
            this.btnAdd24.TextColor = System.Drawing.Color.White;
            this.btnAdd24.UseVisualStyleBackColor = false;
            this.btnAdd24.Click += new System.EventHandler(this.btnAdd24_Click);
            // 
            // btnAdd12
            // 
            this.btnAdd12.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd12.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd12.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd12.BorderRadius = 20;
            this.btnAdd12.BorderSize = 0;
            this.btnAdd12.FlatAppearance.BorderSize = 0;
            this.btnAdd12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd12.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd12.ForeColor = System.Drawing.Color.White;
            this.btnAdd12.Location = new System.Drawing.Point(287, 142);
            this.btnAdd12.Name = "btnAdd12";
            this.btnAdd12.Size = new System.Drawing.Size(166, 91);
            this.btnAdd12.TabIndex = 31;
            this.btnAdd12.Text = "+12";
            this.btnAdd12.TextColor = System.Drawing.Color.White;
            this.btnAdd12.UseVisualStyleBackColor = false;
            this.btnAdd12.Click += new System.EventHandler(this.btnAdd12_Click);
            // 
            // numStock
            // 
            this.numStock.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStock.Location = new System.Drawing.Point(252, 296);
            this.numStock.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(236, 99);
            this.numStock.TabIndex = 27;
            this.numStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numStock.ValueChanged += new System.EventHandler(this.numStock_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(149, 502);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(443, 63);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Opslaan";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ltvStockItems
            // 
            this.ltvStockItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ltvStockItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltvStockItems.FullRowSelect = true;
            this.ltvStockItems.GridLines = true;
            this.ltvStockItems.HideSelection = false;
            this.ltvStockItems.Location = new System.Drawing.Point(98, 148);
            this.ltvStockItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltvStockItems.Name = "ltvStockItems";
            this.ltvStockItems.Size = new System.Drawing.Size(847, 741);
            this.ltvStockItems.TabIndex = 11;
            this.ltvStockItems.UseCompatibleStateImageBehavior = false;
            this.ltvStockItems.View = System.Windows.Forms.View.Details;
            this.ltvStockItems.SelectedIndexChanged += new System.EventHandler(this.ltvStockItems_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kort";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Volledige naam";
            this.columnHeader3.Width = 335;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Voorraad";
            this.columnHeader4.Width = 161;
            // 
            // StockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1922, 948);
            this.Controls.Add(this.pnlInputs);
            this.Controls.Add(this.ltvStockItems);
            this.Controls.Add(this.lblInventory);
            this.Name = "StockManagement";
            this.Text = "StockManagement";
            this.Load += new System.EventHandler(this.StockManagement_Load);
            this.pnlInputs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Panel pnlInputs;
        protected System.Windows.Forms.NumericUpDown numStock;
        private CustomControls.CustomButton btnSave;
        private System.Windows.Forms.ListView ltvStockItems;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private CustomControls.CustomButton btnAdd6;
        private CustomControls.CustomButton btnAdd24;
        private CustomControls.CustomButton btnAdd12;
        private System.Windows.Forms.Label lblMenuItemName;
    }
}