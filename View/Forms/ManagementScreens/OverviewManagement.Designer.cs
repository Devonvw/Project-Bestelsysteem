namespace View.Forms.ManagementScreens
{
    partial class OverviewManagement
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
            this.cbtnInventory = new View.CustomControls.CustomButton();
            this.cbtnMenu = new View.CustomControls.CustomButton();
            this.cbtnWerknemers = new View.CustomControls.CustomButton();
            this.SuspendLayout();
            // 
            // cbtnInventory
            // 
            this.cbtnInventory.BackColor = System.Drawing.Color.Transparent;
            this.cbtnInventory.BackgroundColor = System.Drawing.Color.Transparent;
            this.cbtnInventory.BackgroundImage = global::View.Properties.Resources.inventory2;
            this.cbtnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbtnInventory.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cbtnInventory.BorderRadius = 15;
            this.cbtnInventory.BorderSize = 0;
            this.cbtnInventory.FlatAppearance.BorderSize = 0;
            this.cbtnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnInventory.Font = new System.Drawing.Font("Myanmar Text", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtnInventory.ForeColor = System.Drawing.Color.White;
            this.cbtnInventory.Location = new System.Drawing.Point(1297, 316);
            this.cbtnInventory.Name = "cbtnInventory";
            this.cbtnInventory.Size = new System.Drawing.Size(497, 325);
            this.cbtnInventory.TabIndex = 5;
            this.cbtnInventory.Text = "Voorraad";
            this.cbtnInventory.TextColor = System.Drawing.Color.White;
            this.cbtnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cbtnInventory.UseVisualStyleBackColor = false;
            // 
            // cbtnMenu
            // 
            this.cbtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.cbtnMenu.BackgroundColor = System.Drawing.Color.Transparent;
            this.cbtnMenu.BackgroundImage = global::View.Properties.Resources.louis_hansel_lXLct9D_ARE_unsplash;
            this.cbtnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbtnMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cbtnMenu.BorderRadius = 15;
            this.cbtnMenu.BorderSize = 0;
            this.cbtnMenu.FlatAppearance.BorderSize = 0;
            this.cbtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnMenu.Font = new System.Drawing.Font("Myanmar Text", 22F, System.Drawing.FontStyle.Bold);
            this.cbtnMenu.ForeColor = System.Drawing.Color.White;
            this.cbtnMenu.Location = new System.Drawing.Point(698, 313);
            this.cbtnMenu.Name = "cbtnMenu";
            this.cbtnMenu.Size = new System.Drawing.Size(554, 330);
            this.cbtnMenu.TabIndex = 4;
            this.cbtnMenu.Text = "Menu";
            this.cbtnMenu.TextColor = System.Drawing.Color.White;
            this.cbtnMenu.UseVisualStyleBackColor = false;
            this.cbtnMenu.Click += new System.EventHandler(this.cbtnMenu_Click);
            // 
            // cbtnWerknemers
            // 
            this.cbtnWerknemers.BackColor = System.Drawing.Color.Transparent;
            this.cbtnWerknemers.BackgroundColor = System.Drawing.Color.Transparent;
            this.cbtnWerknemers.BackgroundImage = global::View.Properties.Resources.waitressSmall2;
            this.cbtnWerknemers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbtnWerknemers.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cbtnWerknemers.BorderRadius = 15;
            this.cbtnWerknemers.BorderSize = 0;
            this.cbtnWerknemers.FlatAppearance.BorderSize = 0;
            this.cbtnWerknemers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnWerknemers.Font = new System.Drawing.Font("Myanmar Text", 22F, System.Drawing.FontStyle.Bold);
            this.cbtnWerknemers.ForeColor = System.Drawing.Color.White;
            this.cbtnWerknemers.Location = new System.Drawing.Point(168, 316);
            this.cbtnWerknemers.Name = "cbtnWerknemers";
            this.cbtnWerknemers.Size = new System.Drawing.Size(495, 325);
            this.cbtnWerknemers.TabIndex = 3;
            this.cbtnWerknemers.Text = "Werknemers";
            this.cbtnWerknemers.TextColor = System.Drawing.Color.White;
            this.cbtnWerknemers.UseVisualStyleBackColor = false;
            this.cbtnWerknemers.Click += new System.EventHandler(this.cbtnWerknemers_Click);
            // 
            // OverviewManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1927, 946);
            this.Controls.Add(this.cbtnInventory);
            this.Controls.Add(this.cbtnMenu);
            this.Controls.Add(this.cbtnWerknemers);
            this.Name = "OverviewManagement";
            this.Text = "OverviewManagement";
            this.Load += new System.EventHandler(this.OverviewManagement_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.CustomButton cbtnInventory;
        private CustomControls.CustomButton cbtnMenu;
        private CustomControls.CustomButton cbtnWerknemers;
    }
}