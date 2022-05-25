namespace View.Forms.ManagementScreens
{
    partial class MenuManagement
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.btnRemove = new View.CustomControls.CustomButton();
            this.btnSave = new View.CustomControls.CustomButton();
            this.lblInMenu = new System.Windows.Forms.Label();
            this.lblSubcategory = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.tbxLastname = new System.Windows.Forms.TextBox();
            this.tbxShortName = new System.Windows.Forms.TextBox();
            this.lblShortName = new System.Windows.Forms.Label();
            this.ltvMenuItems = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.cbxSubcategory = new System.Windows.Forms.ComboBox();
            this.numPriceEx = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnInMenuTrue = new System.Windows.Forms.RadioButton();
            this.rbtnInMenuFalse = new System.Windows.Forms.RadioButton();
            this.pnlInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceEx)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Myanmar Text", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(823, 42);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(210, 113);
            this.lblMenu.TabIndex = 8;
            this.lblMenu.Text = "Menu";
            // 
            // pnlInputs
            // 
            this.pnlInputs.BackColor = System.Drawing.Color.White;
            this.pnlInputs.Controls.Add(this.rbtnInMenuFalse);
            this.pnlInputs.Controls.Add(this.rbtnInMenuTrue);
            this.pnlInputs.Controls.Add(this.label1);
            this.pnlInputs.Controls.Add(this.numPriceEx);
            this.pnlInputs.Controls.Add(this.cbxSubcategory);
            this.pnlInputs.Controls.Add(this.cbxCategory);
            this.pnlInputs.Controls.Add(this.btnRemove);
            this.pnlInputs.Controls.Add(this.btnSave);
            this.pnlInputs.Controls.Add(this.lblInMenu);
            this.pnlInputs.Controls.Add(this.lblSubcategory);
            this.pnlInputs.Controls.Add(this.lblCategory);
            this.pnlInputs.Controls.Add(this.lblFullName);
            this.pnlInputs.Controls.Add(this.tbxLastname);
            this.pnlInputs.Controls.Add(this.tbxShortName);
            this.pnlInputs.Controls.Add(this.lblShortName);
            this.pnlInputs.Location = new System.Drawing.Point(1383, 160);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Size = new System.Drawing.Size(479, 741);
            this.pnlInputs.TabIndex = 10;
            this.pnlInputs.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInputs_Paint);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.BackgroundColor = System.Drawing.Color.Red;
            this.btnRemove.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemove.BorderRadius = 20;
            this.btnRemove.BorderSize = 0;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(241, 660);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(220, 63);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "Verwijder";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemove.TextColor = System.Drawing.Color.White;
            this.btnRemove.UseVisualStyleBackColor = false;
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
            this.btnSave.Location = new System.Drawing.Point(17, 660);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 63);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Opslaan";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblInMenu
            // 
            this.lblInMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblInMenu.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInMenu.Location = new System.Drawing.Point(20, 516);
            this.lblInMenu.Name = "lblInMenu";
            this.lblInMenu.Size = new System.Drawing.Size(276, 30);
            this.lblInMenu.TabIndex = 21;
            this.lblInMenu.Text = "In Menu";
            // 
            // lblSubcategory
            // 
            this.lblSubcategory.BackColor = System.Drawing.Color.Transparent;
            this.lblSubcategory.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubcategory.Location = new System.Drawing.Point(20, 311);
            this.lblSubcategory.Name = "lblSubcategory";
            this.lblSubcategory.Size = new System.Drawing.Size(276, 30);
            this.lblSubcategory.TabIndex = 17;
            this.lblSubcategory.Text = "Subcategory";
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(20, 211);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(276, 30);
            this.lblCategory.TabIndex = 12;
            this.lblCategory.Text = "Category";
            // 
            // lblFullName
            // 
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(20, 118);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(276, 30);
            this.lblFullName.TabIndex = 10;
            this.lblFullName.Text = "Volledige naam";
            // 
            // tbxLastname
            // 
            this.tbxLastname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxLastname.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastname.Location = new System.Drawing.Point(17, 151);
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(444, 41);
            this.tbxLastname.TabIndex = 9;
            // 
            // tbxShortName
            // 
            this.tbxShortName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxShortName.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxShortName.Location = new System.Drawing.Point(17, 53);
            this.tbxShortName.Name = "tbxShortName";
            this.tbxShortName.Size = new System.Drawing.Size(444, 41);
            this.tbxShortName.TabIndex = 0;
            // 
            // lblShortName
            // 
            this.lblShortName.BackColor = System.Drawing.Color.Transparent;
            this.lblShortName.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortName.Location = new System.Drawing.Point(20, 20);
            this.lblShortName.Name = "lblShortName";
            this.lblShortName.Size = new System.Drawing.Size(276, 30);
            this.lblShortName.TabIndex = 1;
            this.lblShortName.Text = "Korte naam";
            // 
            // ltvMenuItems
            // 
            this.ltvMenuItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader1});
            this.ltvMenuItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltvMenuItems.FullRowSelect = true;
            this.ltvMenuItems.GridLines = true;
            this.ltvMenuItems.HideSelection = false;
            this.ltvMenuItems.Location = new System.Drawing.Point(63, 160);
            this.ltvMenuItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltvMenuItems.Name = "ltvMenuItems";
            this.ltvMenuItems.Size = new System.Drawing.Size(1179, 741);
            this.ltvMenuItems.TabIndex = 9;
            this.ltvMenuItems.UseCompatibleStateImageBehavior = false;
            this.ltvMenuItems.View = System.Windows.Forms.View.Details;
            this.ltvMenuItems.SelectedIndexChanged += new System.EventHandler(this.ltvMenuItems_SelectedIndexChanged);
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
            this.columnHeader4.Text = "Category";
            this.columnHeader4.Width = 161;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Subcategory";
            this.columnHeader5.Width = 166;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Prijs Ex";
            this.columnHeader6.Width = 129;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "In menu";
            this.columnHeader1.Width = 70;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(17, 244);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(444, 28);
            this.cbxCategory.TabIndex = 25;
            // 
            // cbxSubcategory
            // 
            this.cbxSubcategory.FormattingEnabled = true;
            this.cbxSubcategory.Location = new System.Drawing.Point(17, 344);
            this.cbxSubcategory.Name = "cbxSubcategory";
            this.cbxSubcategory.Size = new System.Drawing.Size(444, 28);
            this.cbxSubcategory.TabIndex = 26;
            // 
            // numPriceEx
            // 
            this.numPriceEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numPriceEx.Location = new System.Drawing.Point(17, 442);
            this.numPriceEx.Name = "numPriceEx";
            this.numPriceEx.Size = new System.Drawing.Size(183, 39);
            this.numPriceEx.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "Prijs Ex";
            // 
            // rbtnInMenuTrue
            // 
            this.rbtnInMenuTrue.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInMenuTrue.Location = new System.Drawing.Point(17, 561);
            this.rbtnInMenuTrue.Name = "rbtnInMenuTrue";
            this.rbtnInMenuTrue.Size = new System.Drawing.Size(161, 45);
            this.rbtnInMenuTrue.TabIndex = 29;
            this.rbtnInMenuTrue.TabStop = true;
            this.rbtnInMenuTrue.Text = "Ja";
            this.rbtnInMenuTrue.UseVisualStyleBackColor = true;
            // 
            // rbtnInMenuFalse
            // 
            this.rbtnInMenuFalse.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInMenuFalse.Location = new System.Drawing.Point(282, 561);
            this.rbtnInMenuFalse.Name = "rbtnInMenuFalse";
            this.rbtnInMenuFalse.Size = new System.Drawing.Size(161, 45);
            this.rbtnInMenuFalse.TabIndex = 30;
            this.rbtnInMenuFalse.TabStop = true;
            this.rbtnInMenuFalse.Text = "Nee";
            this.rbtnInMenuFalse.UseVisualStyleBackColor = true;
            // 
            // MenuManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1925, 948);
            this.Controls.Add(this.pnlInputs);
            this.Controls.Add(this.ltvMenuItems);
            this.Controls.Add(this.lblMenu);
            this.Name = "MenuManagement";
            this.Text = "MenuManagement";
            this.Load += new System.EventHandler(this.MenuManagement_Load);
            this.pnlInputs.ResumeLayout(false);
            this.pnlInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceEx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel pnlInputs;
        private CustomControls.CustomButton btnRemove;
        private CustomControls.CustomButton btnSave;
        private System.Windows.Forms.Label lblInMenu;
        private System.Windows.Forms.Label lblSubcategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox tbxLastname;
        private System.Windows.Forms.TextBox tbxShortName;
        private System.Windows.Forms.Label lblShortName;
        private System.Windows.Forms.ListView ltvMenuItems;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.ComboBox cbxSubcategory;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.NumericUpDown numPriceEx;
        private System.Windows.Forms.RadioButton rbtnInMenuFalse;
        private System.Windows.Forms.RadioButton rbtnInMenuTrue;
    }
}