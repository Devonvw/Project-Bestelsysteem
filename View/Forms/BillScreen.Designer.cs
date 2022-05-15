namespace View.Forms
{
    partial class BillScreen
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtOpmerkingInput = new System.Windows.Forms.TextBox();
            this.lblOpmerkingen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPaymentMethod = new System.Windows.Forms.Panel();
            this.rbCreditcard = new System.Windows.Forms.RadioButton();
            this.rbPin = new System.Windows.Forms.RadioButton();
            this.rbContant = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.numTip = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.pnlPaymentMethod.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTip)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(42, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(881, 744);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtOpmerkingInput
            // 
            this.txtOpmerkingInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOpmerkingInput.BackColor = System.Drawing.Color.Silver;
            this.txtOpmerkingInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtOpmerkingInput.Location = new System.Drawing.Point(23, 85);
            this.txtOpmerkingInput.Name = "txtOpmerkingInput";
            this.txtOpmerkingInput.Size = new System.Drawing.Size(549, 39);
            this.txtOpmerkingInput.TabIndex = 1;
            // 
            // lblOpmerkingen
            // 
            this.lblOpmerkingen.BackColor = System.Drawing.Color.White;
            this.lblOpmerkingen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpmerkingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblOpmerkingen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.lblOpmerkingen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblOpmerkingen.Location = new System.Drawing.Point(0, 0);
            this.lblOpmerkingen.Name = "lblOpmerkingen";
            this.lblOpmerkingen.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblOpmerkingen.Size = new System.Drawing.Size(218, 66);
            this.lblOpmerkingen.TabIndex = 2;
            this.lblOpmerkingen.Text = "Opmerking";
            this.lblOpmerkingen.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtOpmerkingInput);
            this.panel1.Controls.Add(this.lblOpmerkingen);
            this.panel1.Location = new System.Drawing.Point(1032, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 166);
            this.panel1.TabIndex = 7;
            // 
            // pnlPaymentMethod
            // 
            this.pnlPaymentMethod.BackColor = System.Drawing.Color.White;
            this.pnlPaymentMethod.Controls.Add(this.rbCreditcard);
            this.pnlPaymentMethod.Controls.Add(this.rbPin);
            this.pnlPaymentMethod.Controls.Add(this.rbContant);
            this.pnlPaymentMethod.Controls.Add(this.label1);
            this.pnlPaymentMethod.Location = new System.Drawing.Point(1032, 329);
            this.pnlPaymentMethod.Name = "pnlPaymentMethod";
            this.pnlPaymentMethod.Size = new System.Drawing.Size(601, 219);
            this.pnlPaymentMethod.TabIndex = 8;
            // 
            // rbCreditcard
            // 
            this.rbCreditcard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.rbCreditcard.FlatAppearance.BorderSize = 2;
            this.rbCreditcard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.rbCreditcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rbCreditcard.Location = new System.Drawing.Point(23, 161);
            this.rbCreditcard.Name = "rbCreditcard";
            this.rbCreditcard.Size = new System.Drawing.Size(183, 40);
            this.rbCreditcard.TabIndex = 5;
            this.rbCreditcard.TabStop = true;
            this.rbCreditcard.Text = "Creditcard";
            this.rbCreditcard.UseVisualStyleBackColor = true;
            this.rbCreditcard.CheckedChanged += new System.EventHandler(this.rbCreditcard_CheckedChanged);
            // 
            // rbPin
            // 
            this.rbPin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.rbPin.FlatAppearance.BorderSize = 2;
            this.rbPin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.rbPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rbPin.Location = new System.Drawing.Point(23, 115);
            this.rbPin.Name = "rbPin";
            this.rbPin.Size = new System.Drawing.Size(126, 40);
            this.rbPin.TabIndex = 4;
            this.rbPin.TabStop = true;
            this.rbPin.Text = "Pin";
            this.rbPin.UseVisualStyleBackColor = true;
            this.rbPin.CheckedChanged += new System.EventHandler(this.rbPin_CheckedChanged);
            // 
            // rbContant
            // 
            this.rbContant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.rbContant.FlatAppearance.BorderSize = 2;
            this.rbContant.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.rbContant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rbContant.Location = new System.Drawing.Point(23, 69);
            this.rbContant.Name = "rbContant";
            this.rbContant.Size = new System.Drawing.Size(151, 40);
            this.rbContant.TabIndex = 3;
            this.rbContant.TabStop = true;
            this.rbContant.Text = "Contant";
            this.rbContant.UseVisualStyleBackColor = true;
            this.rbContant.CheckedChanged += new System.EventHandler(this.rbContant_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(279, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "Betaalmethode";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.numTip);
            this.panel3.Controls.Add(this.lblTip);
            this.panel3.Location = new System.Drawing.Point(1032, 587);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(601, 142);
            this.panel3.TabIndex = 9;
            // 
            // lblTip
            // 
            this.lblTip.BackColor = System.Drawing.Color.White;
            this.lblTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.lblTip.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTip.Location = new System.Drawing.Point(0, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblTip.Size = new System.Drawing.Size(218, 50);
            this.lblTip.TabIndex = 2;
            this.lblTip.Text = "Tip";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnSave.Location = new System.Drawing.Point(1032, 793);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(600, 83);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numTip
            // 
            this.numTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numTip.Location = new System.Drawing.Point(23, 69);
            this.numTip.Name = "numTip";
            this.numTip.Size = new System.Drawing.Size(183, 39);
            this.numTip.TabIndex = 3;
            this.numTip.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // BillScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1711, 956);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlPaymentMethod);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Name = "BillScreen";
            this.Text = "c";
            this.Load += new System.EventHandler(this.BillScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPaymentMethod.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtOpmerkingInput;
        private System.Windows.Forms.Label lblOpmerkingen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPaymentMethod;
        private System.Windows.Forms.RadioButton rbCreditcard;
        private System.Windows.Forms.RadioButton rbPin;
        private System.Windows.Forms.RadioButton rbContant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Button btnSave;
        protected System.Windows.Forms.NumericUpDown numTip;
    }
}