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
            this.txtOpmerkingInput = new System.Windows.Forms.TextBox();
            this.lblOpmerkingen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPaymentMethod = new System.Windows.Forms.Panel();
            this.rbCashPin = new System.Windows.Forms.RadioButton();
            this.rbCashCreditcard = new System.Windows.Forms.RadioButton();
            this.rbCreditcard = new System.Windows.Forms.RadioButton();
            this.rbPin = new System.Windows.Forms.RadioButton();
            this.rbContant = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numTip = new System.Windows.Forms.NumericUpDown();
            this.lblTip = new System.Windows.Forms.Label();
            this.ltvBillItems = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRekening = new System.Windows.Forms.Label();
            this.btnSave = new View.CustomControls.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSplitPrice = new System.Windows.Forms.Label();
            this.numSplit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalOutput = new System.Windows.Forms.Label();
            this.lblHighBtwOutput = new System.Windows.Forms.Label();
            this.lblLowBtwOutput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlPaymentMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTip)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSplit)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOpmerkingInput
            // 
            this.txtOpmerkingInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOpmerkingInput.BackColor = System.Drawing.Color.Silver;
            this.txtOpmerkingInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtOpmerkingInput.Location = new System.Drawing.Point(166, 14);
            this.txtOpmerkingInput.MaxLength = 255;
            this.txtOpmerkingInput.Name = "txtOpmerkingInput";
            this.txtOpmerkingInput.Size = new System.Drawing.Size(513, 39);
            this.txtOpmerkingInput.TabIndex = 1;
            // 
            // lblOpmerkingen
            // 
            this.lblOpmerkingen.BackColor = System.Drawing.Color.White;
            this.lblOpmerkingen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpmerkingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpmerkingen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.lblOpmerkingen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblOpmerkingen.Location = new System.Drawing.Point(0, 6);
            this.lblOpmerkingen.Name = "lblOpmerkingen";
            this.lblOpmerkingen.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblOpmerkingen.Size = new System.Drawing.Size(174, 47);
            this.lblOpmerkingen.TabIndex = 2;
            this.lblOpmerkingen.Text = "Opmerking";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtOpmerkingInput);
            this.panel1.Controls.Add(this.lblOpmerkingen);
            this.panel1.Location = new System.Drawing.Point(34, 593);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 66);
            this.panel1.TabIndex = 7;
            // 
            // pnlPaymentMethod
            // 
            this.pnlPaymentMethod.BackColor = System.Drawing.Color.White;
            this.pnlPaymentMethod.Controls.Add(this.rbCashPin);
            this.pnlPaymentMethod.Controls.Add(this.rbCashCreditcard);
            this.pnlPaymentMethod.Controls.Add(this.rbCreditcard);
            this.pnlPaymentMethod.Controls.Add(this.rbPin);
            this.pnlPaymentMethod.Controls.Add(this.rbContant);
            this.pnlPaymentMethod.Controls.Add(this.label1);
            this.pnlPaymentMethod.Location = new System.Drawing.Point(34, 694);
            this.pnlPaymentMethod.Name = "pnlPaymentMethod";
            this.pnlPaymentMethod.Size = new System.Drawing.Size(713, 154);
            this.pnlPaymentMethod.TabIndex = 8;
            // 
            // rbCashPin
            // 
            this.rbCashPin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.rbCashPin.FlatAppearance.BorderSize = 2;
            this.rbCashPin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.rbCashPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCashPin.Location = new System.Drawing.Point(209, 50);
            this.rbCashPin.Name = "rbCashPin";
            this.rbCashPin.Size = new System.Drawing.Size(212, 40);
            this.rbCashPin.TabIndex = 7;
            this.rbCashPin.TabStop = true;
            this.rbCashPin.Text = "Contant + Pin";
            this.rbCashPin.UseVisualStyleBackColor = true;
            // 
            // rbCashCreditcard
            // 
            this.rbCashCreditcard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.rbCashCreditcard.FlatAppearance.BorderSize = 2;
            this.rbCashCreditcard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.rbCashCreditcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCashCreditcard.Location = new System.Drawing.Point(427, 50);
            this.rbCashCreditcard.Name = "rbCashCreditcard";
            this.rbCashCreditcard.Size = new System.Drawing.Size(265, 40);
            this.rbCashCreditcard.TabIndex = 6;
            this.rbCashCreditcard.TabStop = true;
            this.rbCashCreditcard.Text = "Contact + Creditcard";
            this.rbCashCreditcard.UseVisualStyleBackColor = true;
            // 
            // rbCreditcard
            // 
            this.rbCreditcard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.rbCreditcard.FlatAppearance.BorderSize = 2;
            this.rbCreditcard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.rbCreditcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCreditcard.Location = new System.Drawing.Point(209, 96);
            this.rbCreditcard.Name = "rbCreditcard";
            this.rbCreditcard.Size = new System.Drawing.Size(183, 40);
            this.rbCreditcard.TabIndex = 5;
            this.rbCreditcard.TabStop = true;
            this.rbCreditcard.Text = "Creditcard";
            this.rbCreditcard.UseVisualStyleBackColor = true;
            // 
            // rbPin
            // 
            this.rbPin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.rbPin.FlatAppearance.BorderSize = 2;
            this.rbPin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.rbPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPin.Location = new System.Drawing.Point(23, 96);
            this.rbPin.Name = "rbPin";
            this.rbPin.Size = new System.Drawing.Size(126, 40);
            this.rbPin.TabIndex = 4;
            this.rbPin.TabStop = true;
            this.rbPin.Text = "Pin";
            this.rbPin.UseVisualStyleBackColor = true;
            // 
            // rbContant
            // 
            this.rbContant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.rbContant.FlatAppearance.BorderSize = 2;
            this.rbContant.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.rbContant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContant.Location = new System.Drawing.Point(23, 50);
            this.rbContant.Name = "rbContant";
            this.rbContant.Size = new System.Drawing.Size(151, 40);
            this.rbContant.TabIndex = 3;
            this.rbContant.TabStop = true;
            this.rbContant.Text = "Contant";
            this.rbContant.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(279, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Betaalmethode";
            // 
            // numTip
            // 
            this.numTip.DecimalPlaces = 2;
            this.numTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numTip.Location = new System.Drawing.Point(397, 41);
            this.numTip.Name = "numTip";
            this.numTip.Size = new System.Drawing.Size(183, 39);
            this.numTip.TabIndex = 3;
            // 
            // lblTip
            // 
            this.lblTip.BackColor = System.Drawing.Color.White;
            this.lblTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.lblTip.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTip.Location = new System.Drawing.Point(383, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblTip.Size = new System.Drawing.Size(218, 50);
            this.lblTip.TabIndex = 2;
            this.lblTip.Text = "Tip";
            // 
            // ltvBillItems
            // 
            this.ltvBillItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.ltvBillItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltvBillItems.FullRowSelect = true;
            this.ltvBillItems.GridLines = true;
            this.ltvBillItems.HideSelection = false;
            this.ltvBillItems.Location = new System.Drawing.Point(34, 81);
            this.ltvBillItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltvBillItems.Name = "ltvBillItems";
            this.ltvBillItems.Size = new System.Drawing.Size(716, 360);
            this.ltvBillItems.TabIndex = 11;
            this.ltvBillItems.UseCompatibleStateImageBehavior = false;
            this.ltvBillItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kort";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hoeveel";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Totaal";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 133;
            // 
            // lblRekening
            // 
            this.lblRekening.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRekening.ForeColor = System.Drawing.Color.White;
            this.lblRekening.Location = new System.Drawing.Point(34, 9);
            this.lblRekening.Name = "lblRekening";
            this.lblRekening.Size = new System.Drawing.Size(713, 67);
            this.lblRekening.TabIndex = 12;
            this.lblRekening.Text = "Rekening";
            this.lblRekening.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSave.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(34, 1027);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(713, 96);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Opslaan";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.numTip);
            this.panel2.Controls.Add(this.lblSplitPrice);
            this.panel2.Controls.Add(this.lblTip);
            this.panel2.Controls.Add(this.numSplit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(37, 886);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 99);
            this.panel2.TabIndex = 10;
            // 
            // lblSplitPrice
            // 
            this.lblSplitPrice.AutoSize = true;
            this.lblSplitPrice.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplitPrice.Location = new System.Drawing.Point(244, 44);
            this.lblSplitPrice.Name = "lblSplitPrice";
            this.lblSplitPrice.Size = new System.Drawing.Size(0, 43);
            this.lblSplitPrice.TabIndex = 4;
            // 
            // numSplit
            // 
            this.numSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numSplit.Location = new System.Drawing.Point(20, 41);
            this.numSplit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSplit.Name = "numSplit";
            this.numSplit.Size = new System.Drawing.Size(183, 39);
            this.numSplit.TabIndex = 3;
            this.numSplit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSplit.ValueChanged += new System.EventHandler(this.numSplit_ValueChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(218, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Split";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblTotalOutput);
            this.panel4.Controls.Add(this.lblHighBtwOutput);
            this.panel4.Controls.Add(this.lblLowBtwOutput);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(34, 440);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(716, 115);
            this.panel4.TabIndex = 14;
            // 
            // lblTotalOutput
            // 
            this.lblTotalOutput.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOutput.Location = new System.Drawing.Point(534, 78);
            this.lblTotalOutput.Name = "lblTotalOutput";
            this.lblTotalOutput.Size = new System.Drawing.Size(179, 36);
            this.lblTotalOutput.TabIndex = 5;
            this.lblTotalOutput.Text = "Laag btw";
            this.lblTotalOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHighBtwOutput
            // 
            this.lblHighBtwOutput.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighBtwOutput.Location = new System.Drawing.Point(534, 42);
            this.lblHighBtwOutput.Name = "lblHighBtwOutput";
            this.lblHighBtwOutput.Size = new System.Drawing.Size(179, 36);
            this.lblHighBtwOutput.TabIndex = 4;
            this.lblHighBtwOutput.Text = "Laag btw";
            this.lblHighBtwOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLowBtwOutput
            // 
            this.lblLowBtwOutput.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowBtwOutput.Location = new System.Drawing.Point(534, 6);
            this.lblLowBtwOutput.Name = "lblLowBtwOutput";
            this.lblLowBtwOutput.Size = new System.Drawing.Size(179, 36);
            this.lblLowBtwOutput.TabIndex = 3;
            this.lblLowBtwOutput.Text = "Laag btw";
            this.lblLowBtwOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Totaal";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hoog btw";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Laag btw";
            // 
            // BillScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(792, 1135);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRekening);
            this.Controls.Add(this.ltvBillItems);
            this.Controls.Add(this.pnlPaymentMethod);
            this.Controls.Add(this.panel1);
            this.Name = "BillScreen";
            this.Text = "c";
            this.Load += new System.EventHandler(this.BillScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPaymentMethod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTip)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSplit)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtOpmerkingInput;
        private System.Windows.Forms.Label lblOpmerkingen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPaymentMethod;
        private System.Windows.Forms.RadioButton rbCreditcard;
        private System.Windows.Forms.RadioButton rbPin;
        private System.Windows.Forms.RadioButton rbContant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTip;
        protected System.Windows.Forms.NumericUpDown numTip;
        private System.Windows.Forms.ListView ltvBillItems;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblRekening;
        private CustomControls.CustomButton btnSave;
        private System.Windows.Forms.RadioButton rbCashPin;
        private System.Windows.Forms.RadioButton rbCashCreditcard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSplitPrice;
        protected System.Windows.Forms.NumericUpDown numSplit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalOutput;
        private System.Windows.Forms.Label lblHighBtwOutput;
        private System.Windows.Forms.Label lblLowBtwOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}