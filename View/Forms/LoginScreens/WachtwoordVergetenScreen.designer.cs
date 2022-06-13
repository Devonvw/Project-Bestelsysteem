namespace View.Forms
{
    partial class WachtwoordVergetenScreen
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.btnHerstelWachtwoord = new System.Windows.Forms.Button();
            this.lblWachtwoordVergeten = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Myanmar Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(86, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(124, 65);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(97, 165);
            this.txtBoxEmail.MaxLength = 100;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(266, 58);
            this.txtBoxEmail.TabIndex = 3;
            // 
            // btnHerstelWachtwoord
            // 
            this.btnHerstelWachtwoord.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerstelWachtwoord.Location = new System.Drawing.Point(120, 265);
            this.btnHerstelWachtwoord.Name = "btnHerstelWachtwoord";
            this.btnHerstelWachtwoord.Size = new System.Drawing.Size(221, 75);
            this.btnHerstelWachtwoord.TabIndex = 5;
            this.btnHerstelWachtwoord.Text = "Herstel Wachtwoord";
            this.btnHerstelWachtwoord.UseVisualStyleBackColor = true;
            this.btnHerstelWachtwoord.Click += new System.EventHandler(this.btnHerstelWachtwoord_Click);
            // 
            // lblWachtwoordVergeten
            // 
            this.lblWachtwoordVergeten.AutoSize = true;
            this.lblWachtwoordVergeten.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWachtwoordVergeten.ForeColor = System.Drawing.Color.White;
            this.lblWachtwoordVergeten.Location = new System.Drawing.Point(91, 21);
            this.lblWachtwoordVergeten.Name = "lblWachtwoordVergeten";
            this.lblWachtwoordVergeten.Size = new System.Drawing.Size(299, 36);
            this.lblWachtwoordVergeten.TabIndex = 7;
            this.lblWachtwoordVergeten.Text = "Vul hieronder uw email-adress in";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "om een nieuw wachtwoord in te stellen";
            // 
            // WachtwoordVergetenScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(434, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWachtwoordVergeten);
            this.Controls.Add(this.btnHerstelWachtwoord);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Name = "WachtwoordVergetenScreen";
            this.Text = "WachtwoordVergetenScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Button btnHerstelWachtwoord;
        private System.Windows.Forms.Label lblWachtwoordVergeten;
        private System.Windows.Forms.Label label1;
    }
}