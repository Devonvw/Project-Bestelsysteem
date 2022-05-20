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
            this.tableNumberLabel = new System.Windows.Forms.Label();
            this.childFormPanel = new System.Windows.Forms.Panel();
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
            this.topPanel.Controls.Add(this.tableNumberLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(571, 123);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // tableNumberLabel
            // 
            this.tableNumberLabel.AutoSize = true;
            this.tableNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tableNumberLabel.Location = new System.Drawing.Point(204, 36);
            this.tableNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableNumberLabel.Name = "tableNumberLabel";
            this.tableNumberLabel.Size = new System.Drawing.Size(164, 54);
            this.tableNumberLabel.TabIndex = 0;
            this.tableNumberLabel.Text = "Tables";
            this.tableNumberLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.childFormPanel.Controls.Add(this.table4Button);
            this.childFormPanel.Controls.Add(this.table3Button);
            this.childFormPanel.Controls.Add(this.table2Button);
            this.childFormPanel.Controls.Add(this.table1Button);
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(0, 123);
            this.childFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(571, 979);
            this.childFormPanel.TabIndex = 2;
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
            this.table4Button.Location = new System.Drawing.Point(336, 161);
            this.table4Button.Name = "table4Button";
            this.table4Button.Size = new System.Drawing.Size(140, 69);
            this.table4Button.TabIndex = 3;
            this.table4Button.Text = "4";
            this.table4Button.TextColor = System.Drawing.Color.White;
            this.table4Button.UseVisualStyleBackColor = false;
            this.table4Button.Click += new System.EventHandler(this.table4Button_Click);
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
            this.table3Button.Location = new System.Drawing.Point(83, 161);
            this.table3Button.Name = "table3Button";
            this.table3Button.Size = new System.Drawing.Size(140, 69);
            this.table3Button.TabIndex = 2;
            this.table3Button.Text = "3";
            this.table3Button.TextColor = System.Drawing.Color.White;
            this.table3Button.UseVisualStyleBackColor = false;
            this.table3Button.Click += new System.EventHandler(this.table3Button_Click);
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
            this.table2Button.Location = new System.Drawing.Point(336, 55);
            this.table2Button.Name = "table2Button";
            this.table2Button.Size = new System.Drawing.Size(140, 69);
            this.table2Button.TabIndex = 1;
            this.table2Button.Text = "2";
            this.table2Button.TextColor = System.Drawing.Color.White;
            this.table2Button.UseVisualStyleBackColor = false;
            this.table2Button.Click += new System.EventHandler(this.table2Button_Click);
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
            this.table1Button.Location = new System.Drawing.Point(83, 55);
            this.table1Button.Name = "table1Button";
            this.table1Button.Size = new System.Drawing.Size(140, 69);
            this.table1Button.TabIndex = 0;
            this.table1Button.Text = "1";
            this.table1Button.TextColor = System.Drawing.Color.White;
            this.table1Button.UseVisualStyleBackColor = false;
            this.table1Button.Click += new System.EventHandler(this.table1Button_Click_1);
            // 
            // OrderScreenParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 1102);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderScreenParent";
            this.Text = "Order screen";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.childFormPanel.ResumeLayout(false);
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
    }
}