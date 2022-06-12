namespace View.Forms
{
    partial class OrderScreenParent
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.staffNameLabel = new System.Windows.Forms.Label();
            this.tableNumberLabel = new System.Windows.Forms.Label();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.lblLaatsteBestelling10 = new System.Windows.Forms.Label();
            this.lblLaatsteBestelling9 = new System.Windows.Forms.Label();
            this.lblLaatsteBestelling8 = new System.Windows.Forms.Label();
            this.lblLaatsteBestelling7 = new System.Windows.Forms.Label();
            this.lblLaatsteBestelling6 = new System.Windows.Forms.Label();
            this.lblLaatsteBestelling5 = new System.Windows.Forms.Label();
            this.lblLaatsteBestelling4 = new System.Windows.Forms.Label();
            this.lblLaatsteBestelling2 = new System.Windows.Forms.Label();
            this.lblLaatsteBestelling3 = new System.Windows.Forms.Label();
            this.lblLaatsteBestelling1 = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.table10Button = new View.CustomControls.CustomButton();
            this.table9Button = new View.CustomControls.CustomButton();
            this.table8Button = new View.CustomControls.CustomButton();
            this.table7Button = new View.CustomControls.CustomButton();
            this.table6Button = new View.CustomControls.CustomButton();
            this.table5Button = new View.CustomControls.CustomButton();
            this.table4Button = new View.CustomControls.CustomButton();
            this.table3Button = new View.CustomControls.CustomButton();
            this.table2Button = new View.CustomControls.CustomButton();
            this.table1Button = new View.CustomControls.CustomButton();
            this.topPanel.SuspendLayout();
            this.childFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.topPanel.Controls.Add(this.btn_Logout);
            this.topPanel.Controls.Add(this.staffNameLabel);
            this.topPanel.Controls.Add(this.tableNumberLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(571, 123);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // staffNameLabel
            // 
            this.staffNameLabel.AutoSize = true;
            this.staffNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.staffNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.staffNameLabel.Location = new System.Drawing.Point(16, 11);
            this.staffNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffNameLabel.Name = "staffNameLabel";
            this.staffNameLabel.Size = new System.Drawing.Size(85, 16);
            this.staffNameLabel.TabIndex = 1;
            this.staffNameLabel.Text = "Medewerker:";
            // 
            // tableNumberLabel
            // 
            this.tableNumberLabel.AutoSize = true;
            this.tableNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tableNumberLabel.Location = new System.Drawing.Point(204, 36);
            this.tableNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableNumberLabel.Name = "tableNumberLabel";
            this.tableNumberLabel.Size = new System.Drawing.Size(151, 54);
            this.tableNumberLabel.TabIndex = 0;
            this.tableNumberLabel.Text = "Tafels";
            this.tableNumberLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.childFormPanel.Controls.Add(this.lblLaatsteBestelling10);
            this.childFormPanel.Controls.Add(this.lblLaatsteBestelling9);
            this.childFormPanel.Controls.Add(this.lblLaatsteBestelling8);
            this.childFormPanel.Controls.Add(this.lblLaatsteBestelling7);
            this.childFormPanel.Controls.Add(this.lblLaatsteBestelling6);
            this.childFormPanel.Controls.Add(this.lblLaatsteBestelling5);
            this.childFormPanel.Controls.Add(this.lblLaatsteBestelling4);
            this.childFormPanel.Controls.Add(this.lblLaatsteBestelling2);
            this.childFormPanel.Controls.Add(this.lblLaatsteBestelling3);
            this.childFormPanel.Controls.Add(this.lblLaatsteBestelling1);
            this.childFormPanel.Controls.Add(this.table10Button);
            this.childFormPanel.Controls.Add(this.table9Button);
            this.childFormPanel.Controls.Add(this.table8Button);
            this.childFormPanel.Controls.Add(this.table7Button);
            this.childFormPanel.Controls.Add(this.table6Button);
            this.childFormPanel.Controls.Add(this.table5Button);
            this.childFormPanel.Controls.Add(this.table4Button);
            this.childFormPanel.Controls.Add(this.table3Button);
            this.childFormPanel.Controls.Add(this.table2Button);
            this.childFormPanel.Controls.Add(this.table1Button);
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(0, 123);
            this.childFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(571, 977);
            this.childFormPanel.TabIndex = 2;
            // 
            // lblLaatsteBestelling10
            // 
            this.lblLaatsteBestelling10.AutoSize = true;
            this.lblLaatsteBestelling10.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblLaatsteBestelling10.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaatsteBestelling10.Location = new System.Drawing.Point(381, 771);
            this.lblLaatsteBestelling10.Name = "lblLaatsteBestelling10";
            this.lblLaatsteBestelling10.Size = new System.Drawing.Size(0, 30);
            this.lblLaatsteBestelling10.TabIndex = 25;
            // 
            // lblLaatsteBestelling9
            // 
            this.lblLaatsteBestelling9.AutoSize = true;
            this.lblLaatsteBestelling9.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblLaatsteBestelling9.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaatsteBestelling9.Location = new System.Drawing.Point(129, 771);
            this.lblLaatsteBestelling9.Name = "lblLaatsteBestelling9";
            this.lblLaatsteBestelling9.Size = new System.Drawing.Size(0, 30);
            this.lblLaatsteBestelling9.TabIndex = 24;
            // 
            // lblLaatsteBestelling8
            // 
            this.lblLaatsteBestelling8.AutoSize = true;
            this.lblLaatsteBestelling8.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblLaatsteBestelling8.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaatsteBestelling8.Location = new System.Drawing.Point(381, 616);
            this.lblLaatsteBestelling8.Name = "lblLaatsteBestelling8";
            this.lblLaatsteBestelling8.Size = new System.Drawing.Size(0, 30);
            this.lblLaatsteBestelling8.TabIndex = 23;
            // 
            // lblLaatsteBestelling7
            // 
            this.lblLaatsteBestelling7.AutoSize = true;
            this.lblLaatsteBestelling7.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblLaatsteBestelling7.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaatsteBestelling7.Location = new System.Drawing.Point(129, 616);
            this.lblLaatsteBestelling7.Name = "lblLaatsteBestelling7";
            this.lblLaatsteBestelling7.Size = new System.Drawing.Size(0, 30);
            this.lblLaatsteBestelling7.TabIndex = 22;
            // 
            // lblLaatsteBestelling6
            // 
            this.lblLaatsteBestelling6.AutoSize = true;
            this.lblLaatsteBestelling6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblLaatsteBestelling6.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaatsteBestelling6.Location = new System.Drawing.Point(381, 456);
            this.lblLaatsteBestelling6.Name = "lblLaatsteBestelling6";
            this.lblLaatsteBestelling6.Size = new System.Drawing.Size(0, 30);
            this.lblLaatsteBestelling6.TabIndex = 21;
            // 
            // lblLaatsteBestelling5
            // 
            this.lblLaatsteBestelling5.AutoSize = true;
            this.lblLaatsteBestelling5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblLaatsteBestelling5.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaatsteBestelling5.Location = new System.Drawing.Point(129, 456);
            this.lblLaatsteBestelling5.Name = "lblLaatsteBestelling5";
            this.lblLaatsteBestelling5.Size = new System.Drawing.Size(0, 30);
            this.lblLaatsteBestelling5.TabIndex = 20;
            // 
            // lblLaatsteBestelling4
            // 
            this.lblLaatsteBestelling4.AutoSize = true;
            this.lblLaatsteBestelling4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblLaatsteBestelling4.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaatsteBestelling4.Location = new System.Drawing.Point(381, 291);
            this.lblLaatsteBestelling4.Name = "lblLaatsteBestelling4";
            this.lblLaatsteBestelling4.Size = new System.Drawing.Size(0, 30);
            this.lblLaatsteBestelling4.TabIndex = 19;
            // 
            // lblLaatsteBestelling2
            // 
            this.lblLaatsteBestelling2.AutoSize = true;
            this.lblLaatsteBestelling2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblLaatsteBestelling2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaatsteBestelling2.Location = new System.Drawing.Point(381, 132);
            this.lblLaatsteBestelling2.Name = "lblLaatsteBestelling2";
            this.lblLaatsteBestelling2.Size = new System.Drawing.Size(0, 30);
            this.lblLaatsteBestelling2.TabIndex = 18;
            // 
            // lblLaatsteBestelling3
            // 
            this.lblLaatsteBestelling3.AutoSize = true;
            this.lblLaatsteBestelling3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblLaatsteBestelling3.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaatsteBestelling3.Location = new System.Drawing.Point(129, 291);
            this.lblLaatsteBestelling3.Name = "lblLaatsteBestelling3";
            this.lblLaatsteBestelling3.Size = new System.Drawing.Size(0, 30);
            this.lblLaatsteBestelling3.TabIndex = 17;
            // 
            // lblLaatsteBestelling1
            // 
            this.lblLaatsteBestelling1.AutoSize = true;
            this.lblLaatsteBestelling1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblLaatsteBestelling1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaatsteBestelling1.Location = new System.Drawing.Point(129, 132);
            this.lblLaatsteBestelling1.Name = "lblLaatsteBestelling1";
            this.lblLaatsteBestelling1.Size = new System.Drawing.Size(0, 30);
            this.lblLaatsteBestelling1.TabIndex = 16;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Logout.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(429, 37);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(120, 53);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // table10Button
            // 
            this.table10Button.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.table10Button.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.table10Button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.table10Button.BorderRadius = 20;
            this.table10Button.BorderSize = 0;
            this.table10Button.FlatAppearance.BorderSize = 0;
            this.table10Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.table10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table10Button.ForeColor = System.Drawing.Color.White;
            this.table10Button.Location = new System.Drawing.Point(315, 691);
            this.table10Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table10Button.Name = "table10Button";
            this.table10Button.Size = new System.Drawing.Size(187, 131);
            this.table10Button.TabIndex = 15;
            this.table10Button.Text = "10";
            this.table10Button.TextColor = System.Drawing.Color.White;
            this.table10Button.UseVisualStyleBackColor = false;
            this.table10Button.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // table9Button
            // 
            this.table9Button.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.table9Button.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.table9Button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.table9Button.BorderRadius = 20;
            this.table9Button.BorderSize = 0;
            this.table9Button.FlatAppearance.BorderSize = 0;
            this.table9Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.table9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table9Button.ForeColor = System.Drawing.Color.White;
            this.table9Button.Location = new System.Drawing.Point(62, 691);
            this.table9Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table9Button.Name = "table9Button";
            this.table9Button.Size = new System.Drawing.Size(187, 131);
            this.table9Button.TabIndex = 14;
            this.table9Button.Text = "9";
            this.table9Button.TextColor = System.Drawing.Color.White;
            this.table9Button.UseVisualStyleBackColor = false;
            this.table9Button.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // table8Button
            // 
            this.table8Button.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.table8Button.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.table8Button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.table8Button.BorderRadius = 20;
            this.table8Button.BorderSize = 0;
            this.table8Button.FlatAppearance.BorderSize = 0;
            this.table8Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.table8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table8Button.ForeColor = System.Drawing.Color.White;
            this.table8Button.Location = new System.Drawing.Point(315, 527);
            this.table8Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table8Button.Name = "table8Button";
            this.table8Button.Size = new System.Drawing.Size(187, 131);
            this.table8Button.TabIndex = 13;
            this.table8Button.Text = "8";
            this.table8Button.TextColor = System.Drawing.Color.White;
            this.table8Button.UseVisualStyleBackColor = false;
            this.table8Button.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // table7Button
            // 
            this.table7Button.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.table7Button.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.table7Button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.table7Button.BorderRadius = 20;
            this.table7Button.BorderSize = 0;
            this.table7Button.FlatAppearance.BorderSize = 0;
            this.table7Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.table7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table7Button.ForeColor = System.Drawing.Color.White;
            this.table7Button.Location = new System.Drawing.Point(62, 527);
            this.table7Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table7Button.Name = "table7Button";
            this.table7Button.Size = new System.Drawing.Size(187, 131);
            this.table7Button.TabIndex = 12;
            this.table7Button.Text = "7";
            this.table7Button.TextColor = System.Drawing.Color.White;
            this.table7Button.UseVisualStyleBackColor = false;
            this.table7Button.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // table6Button
            // 
            this.table6Button.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.table6Button.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.table6Button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.table6Button.BorderRadius = 20;
            this.table6Button.BorderSize = 0;
            this.table6Button.FlatAppearance.BorderSize = 0;
            this.table6Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.table6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table6Button.ForeColor = System.Drawing.Color.White;
            this.table6Button.Location = new System.Drawing.Point(315, 367);
            this.table6Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table6Button.Name = "table6Button";
            this.table6Button.Size = new System.Drawing.Size(187, 131);
            this.table6Button.TabIndex = 11;
            this.table6Button.Text = "6";
            this.table6Button.TextColor = System.Drawing.Color.White;
            this.table6Button.UseVisualStyleBackColor = false;
            this.table6Button.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // table5Button
            // 
            this.table5Button.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.table5Button.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.table5Button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.table5Button.BorderRadius = 20;
            this.table5Button.BorderSize = 0;
            this.table5Button.FlatAppearance.BorderSize = 0;
            this.table5Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.table5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table5Button.ForeColor = System.Drawing.Color.White;
            this.table5Button.Location = new System.Drawing.Point(62, 367);
            this.table5Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table5Button.Name = "table5Button";
            this.table5Button.Size = new System.Drawing.Size(187, 131);
            this.table5Button.TabIndex = 10;
            this.table5Button.Text = "5";
            this.table5Button.TextColor = System.Drawing.Color.White;
            this.table5Button.UseVisualStyleBackColor = false;
            this.table5Button.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // table4Button
            // 
            this.table4Button.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.table4Button.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.table4Button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.table4Button.BorderRadius = 20;
            this.table4Button.BorderSize = 0;
            this.table4Button.FlatAppearance.BorderSize = 0;
            this.table4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.table4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table4Button.ForeColor = System.Drawing.Color.White;
            this.table4Button.Location = new System.Drawing.Point(315, 209);
            this.table4Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table4Button.Name = "table4Button";
            this.table4Button.Size = new System.Drawing.Size(187, 131);
            this.table4Button.TabIndex = 3;
            this.table4Button.Text = "4";
            this.table4Button.TextColor = System.Drawing.Color.White;
            this.table4Button.UseVisualStyleBackColor = false;
            this.table4Button.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // table3Button
            // 
            this.table3Button.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.table3Button.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.table3Button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.table3Button.BorderRadius = 20;
            this.table3Button.BorderSize = 0;
            this.table3Button.FlatAppearance.BorderSize = 0;
            this.table3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.table3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table3Button.ForeColor = System.Drawing.Color.White;
            this.table3Button.Location = new System.Drawing.Point(62, 209);
            this.table3Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table3Button.Name = "table3Button";
            this.table3Button.Size = new System.Drawing.Size(187, 131);
            this.table3Button.TabIndex = 2;
            this.table3Button.Text = "3";
            this.table3Button.TextColor = System.Drawing.Color.White;
            this.table3Button.UseVisualStyleBackColor = false;
            this.table3Button.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // table2Button
            // 
            this.table2Button.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.table2Button.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.table2Button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.table2Button.BorderRadius = 20;
            this.table2Button.BorderSize = 0;
            this.table2Button.FlatAppearance.BorderSize = 0;
            this.table2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.table2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table2Button.ForeColor = System.Drawing.Color.White;
            this.table2Button.Location = new System.Drawing.Point(315, 48);
            this.table2Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table2Button.Name = "table2Button";
            this.table2Button.Size = new System.Drawing.Size(187, 131);
            this.table2Button.TabIndex = 1;
            this.table2Button.Text = "2";
            this.table2Button.TextColor = System.Drawing.Color.White;
            this.table2Button.UseVisualStyleBackColor = false;
            this.table2Button.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // table1Button
            // 
            this.table1Button.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.table1Button.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.table1Button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.table1Button.BorderRadius = 20;
            this.table1Button.BorderSize = 0;
            this.table1Button.FlatAppearance.BorderSize = 0;
            this.table1Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.table1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table1Button.ForeColor = System.Drawing.Color.White;
            this.table1Button.Location = new System.Drawing.Point(62, 48);
            this.table1Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table1Button.Name = "table1Button";
            this.table1Button.Size = new System.Drawing.Size(187, 131);
            this.table1Button.TabIndex = 0;
            this.table1Button.Text = "1";
            this.table1Button.TextColor = System.Drawing.Color.White;
            this.table1Button.UseVisualStyleBackColor = false;
            this.table1Button.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // OrderScreenParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 1100);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderScreenParent";
            this.Text = "        ";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.childFormPanel.ResumeLayout(false);
            this.childFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Label tableNumberLabel;
        private CustomControls.CustomButton table4Button;
        private CustomControls.CustomButton table3Button;
        private CustomControls.CustomButton table2Button;
        private CustomControls.CustomButton table1Button;
        private System.Windows.Forms.Label staffNameLabel;
        private CustomControls.CustomButton table10Button;
        private CustomControls.CustomButton table9Button;
        private CustomControls.CustomButton table8Button;
        private CustomControls.CustomButton table7Button;
        private CustomControls.CustomButton table6Button;
        private CustomControls.CustomButton table5Button;
        private System.Windows.Forms.Label lblLaatsteBestelling1;
        private System.Windows.Forms.Label lblLaatsteBestelling4;
        private System.Windows.Forms.Label lblLaatsteBestelling2;
        private System.Windows.Forms.Label lblLaatsteBestelling3;
        private System.Windows.Forms.Label lblLaatsteBestelling10;
        private System.Windows.Forms.Label lblLaatsteBestelling9;
        private System.Windows.Forms.Label lblLaatsteBestelling8;
        private System.Windows.Forms.Label lblLaatsteBestelling7;
        private System.Windows.Forms.Label lblLaatsteBestelling6;
        private System.Windows.Forms.Label lblLaatsteBestelling5;
        private System.Windows.Forms.Button btn_Logout;
    }
}