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
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.rbtnChef = new System.Windows.Forms.RadioButton();
            this.rbtnWaiter = new System.Windows.Forms.RadioButton();
            this.rbtnBartender = new System.Windows.Forms.RadioButton();
            this.lblRole = new System.Windows.Forms.Label();
            this.rbtnManager = new System.Windows.Forms.RadioButton();
            this.lblBirthdate = new System.Windows.Forms.Label();
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
            this.pnlInputs.SuspendLayout();
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
            this.pnlInputs.Controls.Add(this.btnRemove);
            this.pnlInputs.Controls.Add(this.btnSave);
            this.pnlInputs.Controls.Add(this.tbxEmail);
            this.pnlInputs.Controls.Add(this.lblEmail);
            this.pnlInputs.Controls.Add(this.rbtnChef);
            this.pnlInputs.Controls.Add(this.rbtnWaiter);
            this.pnlInputs.Controls.Add(this.rbtnBartender);
            this.pnlInputs.Controls.Add(this.lblRole);
            this.pnlInputs.Controls.Add(this.rbtnManager);
            this.pnlInputs.Controls.Add(this.lblBirthdate);
            this.pnlInputs.Controls.Add(this.lblFullName);
            this.pnlInputs.Controls.Add(this.tbxLastname);
            this.pnlInputs.Controls.Add(this.tbxShortName);
            this.pnlInputs.Controls.Add(this.lblShortName);
            this.pnlInputs.Location = new System.Drawing.Point(1383, 160);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Size = new System.Drawing.Size(479, 741);
            this.pnlInputs.TabIndex = 10;
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
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxEmail.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(17, 596);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(444, 41);
            this.tbxEmail.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(20, 563);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(276, 30);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email";
            // 
            // rbtnChef
            // 
            this.rbtnChef.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChef.Location = new System.Drawing.Point(27, 497);
            this.rbtnChef.Name = "rbtnChef";
            this.rbtnChef.Size = new System.Drawing.Size(443, 45);
            this.rbtnChef.TabIndex = 20;
            this.rbtnChef.TabStop = true;
            this.rbtnChef.Text = "Chef";
            this.rbtnChef.UseVisualStyleBackColor = true;
            // 
            // rbtnWaiter
            // 
            this.rbtnWaiter.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnWaiter.Location = new System.Drawing.Point(27, 446);
            this.rbtnWaiter.Name = "rbtnWaiter";
            this.rbtnWaiter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbtnWaiter.Size = new System.Drawing.Size(443, 45);
            this.rbtnWaiter.TabIndex = 19;
            this.rbtnWaiter.TabStop = true;
            this.rbtnWaiter.Text = "Serveren";
            this.rbtnWaiter.UseVisualStyleBackColor = true;
            // 
            // rbtnBartender
            // 
            this.rbtnBartender.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBartender.Location = new System.Drawing.Point(27, 395);
            this.rbtnBartender.Name = "rbtnBartender";
            this.rbtnBartender.Size = new System.Drawing.Size(443, 45);
            this.rbtnBartender.TabIndex = 18;
            this.rbtnBartender.TabStop = true;
            this.rbtnBartender.Text = "Bar";
            this.rbtnBartender.UseVisualStyleBackColor = true;
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(20, 311);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(276, 30);
            this.lblRole.TabIndex = 17;
            this.lblRole.Text = "Functie";
            // 
            // rbtnManager
            // 
            this.rbtnManager.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnManager.Location = new System.Drawing.Point(27, 344);
            this.rbtnManager.Name = "rbtnManager";
            this.rbtnManager.Size = new System.Drawing.Size(443, 45);
            this.rbtnManager.TabIndex = 13;
            this.rbtnManager.TabStop = true;
            this.rbtnManager.Text = "Manager";
            this.rbtnManager.UseVisualStyleBackColor = true;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthdate.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(20, 211);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(276, 30);
            this.lblBirthdate.TabIndex = 12;
            this.lblBirthdate.Text = "Geboortedatum";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel pnlInputs;
        private CustomControls.CustomButton btnRemove;
        private CustomControls.CustomButton btnSave;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.RadioButton rbtnChef;
        private System.Windows.Forms.RadioButton rbtnWaiter;
        private System.Windows.Forms.RadioButton rbtnBartender;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.RadioButton rbtnManager;
        private System.Windows.Forms.Label lblBirthdate;
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
    }
}