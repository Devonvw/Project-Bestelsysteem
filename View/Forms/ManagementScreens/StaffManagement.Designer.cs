namespace View.Forms.ManagementScreens
{
    partial class StaffManagement
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
            this.ltvStaff = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblWerknemers = new System.Windows.Forms.Label();
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
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblLastname = new System.Windows.Forms.Label();
            this.tbxLastname = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltvStaff
            // 
            this.ltvStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ltvStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltvStaff.FullRowSelect = true;
            this.ltvStaff.GridLines = true;
            this.ltvStaff.HideSelection = false;
            this.ltvStaff.Location = new System.Drawing.Point(33, 163);
            this.ltvStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltvStaff.Name = "ltvStaff";
            this.ltvStaff.Size = new System.Drawing.Size(1164, 741);
            this.ltvStaff.TabIndex = 6;
            this.ltvStaff.UseCompatibleStateImageBehavior = false;
            this.ltvStaff.View = System.Windows.Forms.View.Details;
            this.ltvStaff.SelectedIndexChanged += new System.EventHandler(this.ltvStaff_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Voornaam";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Achternaam";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Geboortedatum";
            this.columnHeader4.Width = 161;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Functie";
            this.columnHeader5.Width = 133;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            this.columnHeader6.Width = 180;
            // 
            // lblWerknemers
            // 
            this.lblWerknemers.AutoSize = true;
            this.lblWerknemers.Font = new System.Drawing.Font("Myanmar Text", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWerknemers.ForeColor = System.Drawing.Color.White;
            this.lblWerknemers.Location = new System.Drawing.Point(722, 33);
            this.lblWerknemers.Name = "lblWerknemers";
            this.lblWerknemers.Size = new System.Drawing.Size(401, 113);
            this.lblWerknemers.TabIndex = 7;
            this.lblWerknemers.Text = "Werknemers";
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
            this.pnlInputs.Controls.Add(this.dtpBirthdate);
            this.pnlInputs.Controls.Add(this.lblLastname);
            this.pnlInputs.Controls.Add(this.tbxLastname);
            this.pnlInputs.Controls.Add(this.tbxFirstName);
            this.pnlInputs.Controls.Add(this.lblFirstName);
            this.pnlInputs.Location = new System.Drawing.Point(1353, 163);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Size = new System.Drawing.Size(479, 741);
            this.pnlInputs.TabIndex = 8;
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
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxEmail.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(17, 596);
            this.tbxEmail.MaxLength = 100;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(444, 48);
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
            // dtpBirthdate
            // 
            this.dtpBirthdate.CalendarFont = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Location = new System.Drawing.Point(17, 244);
            this.dtpBirthdate.MaxDate = System.DateTime.Today;
            this.dtpBirthdate.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(422, 26);
            this.dtpBirthdate.TabIndex = 11;
            this.dtpBirthdate.Value = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            // 
            // lblLastname
            // 
            this.lblLastname.BackColor = System.Drawing.Color.Transparent;
            this.lblLastname.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(20, 118);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(276, 30);
            this.lblLastname.TabIndex = 10;
            this.lblLastname.Text = "Achternaam";
            // 
            // tbxLastname
            // 
            this.tbxLastname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxLastname.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastname.Location = new System.Drawing.Point(17, 151);
            this.tbxLastname.MaxLength = 50;
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(444, 48);
            this.tbxLastname.TabIndex = 9;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxFirstName.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(17, 53);
            this.tbxFirstName.MaxLength = 50;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(444, 48);
            this.tbxFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(20, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(276, 30);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Voornaam";
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1927, 948);
            this.Controls.Add(this.pnlInputs);
            this.Controls.Add(this.lblWerknemers);
            this.Controls.Add(this.ltvStaff);
            this.Name = "StaffManagement";
            this.Text = "StaffManagement";
            this.Load += new System.EventHandler(this.StaffManagement_Load);
            this.pnlInputs.ResumeLayout(false);
            this.pnlInputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ltvStaff;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblWerknemers;
        private System.Windows.Forms.Panel pnlInputs;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox tbxLastname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.RadioButton rbtnManager;
        private CustomControls.CustomButton btnSave;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.RadioButton rbtnChef;
        private System.Windows.Forms.RadioButton rbtnWaiter;
        private System.Windows.Forms.RadioButton rbtnBartender;
        private CustomControls.CustomButton btnRemove;
    }
}