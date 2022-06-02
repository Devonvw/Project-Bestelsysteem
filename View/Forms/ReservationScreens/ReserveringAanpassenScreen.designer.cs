namespace View.Forms
{
    partial class ReserveringAanpassenScreen
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
            this.comboBoxMinuten = new System.Windows.Forms.ComboBox();
            this.comboBoxUren = new System.Windows.Forms.ComboBox();
            this.comboBoxTafel = new System.Windows.Forms.ComboBox();
            this.comboBoxPersonen = new System.Windows.Forms.ComboBox();
            this.lblTijd = new System.Windows.Forms.Label();
            this.lblPersonen = new System.Windows.Forms.Label();
            this.lblTafel = new System.Windows.Forms.Label();
            this.btnBevestigen = new System.Windows.Forms.Button();
            this.lblBestaandeReserveringen = new System.Windows.Forms.Label();
            this.listViewReserveringen = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tijd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tafel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtboxNaam = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblReserveringAanpassen = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnZoekReserveringOpDatum = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnZoekReserveringOpNaam = new System.Windows.Forms.Button();
            this.txtBoxZoekNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTijdMinutenZoeken = new System.Windows.Forms.ComboBox();
            this.comboBoxTijdUrenZoeken = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxMinuten
            // 
            this.comboBoxMinuten.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMinuten.FormattingEnabled = true;
            this.comboBoxMinuten.Location = new System.Drawing.Point(410, 432);
            this.comboBoxMinuten.Name = "comboBoxMinuten";
            this.comboBoxMinuten.Size = new System.Drawing.Size(114, 38);
            this.comboBoxMinuten.TabIndex = 36;
            // 
            // comboBoxUren
            // 
            this.comboBoxUren.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUren.FormattingEnabled = true;
            this.comboBoxUren.Location = new System.Drawing.Point(281, 432);
            this.comboBoxUren.Name = "comboBoxUren";
            this.comboBoxUren.Size = new System.Drawing.Size(114, 38);
            this.comboBoxUren.TabIndex = 35;
            // 
            // comboBoxTafel
            // 
            this.comboBoxTafel.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTafel.FormattingEnabled = true;
            this.comboBoxTafel.Location = new System.Drawing.Point(10, 517);
            this.comboBoxTafel.Name = "comboBoxTafel";
            this.comboBoxTafel.Size = new System.Drawing.Size(243, 38);
            this.comboBoxTafel.TabIndex = 33;
            // 
            // comboBoxPersonen
            // 
            this.comboBoxPersonen.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPersonen.FormattingEnabled = true;
            this.comboBoxPersonen.Location = new System.Drawing.Point(281, 517);
            this.comboBoxPersonen.Name = "comboBoxPersonen";
            this.comboBoxPersonen.Size = new System.Drawing.Size(243, 38);
            this.comboBoxPersonen.TabIndex = 32;
            // 
            // lblTijd
            // 
            this.lblTijd.AutoSize = true;
            this.lblTijd.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTijd.ForeColor = System.Drawing.Color.White;
            this.lblTijd.Location = new System.Drawing.Point(275, 404);
            this.lblTijd.Name = "lblTijd";
            this.lblTijd.Size = new System.Drawing.Size(51, 36);
            this.lblTijd.TabIndex = 31;
            this.lblTijd.Text = "Tijd:";
            // 
            // lblPersonen
            // 
            this.lblPersonen.AutoSize = true;
            this.lblPersonen.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonen.ForeColor = System.Drawing.Color.White;
            this.lblPersonen.Location = new System.Drawing.Point(270, 478);
            this.lblPersonen.Name = "lblPersonen";
            this.lblPersonen.Size = new System.Drawing.Size(99, 36);
            this.lblPersonen.TabIndex = 30;
            this.lblPersonen.Text = "Personen:";
            // 
            // lblTafel
            // 
            this.lblTafel.AutoSize = true;
            this.lblTafel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTafel.ForeColor = System.Drawing.Color.White;
            this.lblTafel.Location = new System.Drawing.Point(4, 478);
            this.lblTafel.Name = "lblTafel";
            this.lblTafel.Size = new System.Drawing.Size(60, 36);
            this.lblTafel.TabIndex = 29;
            this.lblTafel.Text = "Tafel:";
            // 
            // btnBevestigen
            // 
            this.btnBevestigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnBevestigen.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBevestigen.ForeColor = System.Drawing.Color.White;
            this.btnBevestigen.Location = new System.Drawing.Point(10, 573);
            this.btnBevestigen.Name = "btnBevestigen";
            this.btnBevestigen.Size = new System.Drawing.Size(514, 67);
            this.btnBevestigen.TabIndex = 27;
            this.btnBevestigen.Text = "Bevestigen";
            this.btnBevestigen.UseVisualStyleBackColor = false;
            this.btnBevestigen.Click += new System.EventHandler(this.btnBevestigen_Click);
            // 
            // lblBestaandeReserveringen
            // 
            this.lblBestaandeReserveringen.AutoSize = true;
            this.lblBestaandeReserveringen.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestaandeReserveringen.ForeColor = System.Drawing.Color.White;
            this.lblBestaandeReserveringen.Location = new System.Drawing.Point(4, 231);
            this.lblBestaandeReserveringen.Name = "lblBestaandeReserveringen";
            this.lblBestaandeReserveringen.Size = new System.Drawing.Size(236, 36);
            this.lblBestaandeReserveringen.TabIndex = 24;
            this.lblBestaandeReserveringen.Text = "Bestaande Reserveringen:";
            // 
            // listViewReserveringen
            // 
            this.listViewReserveringen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.datum,
            this.tijd,
            this.personen,
            this.tafel});
            this.listViewReserveringen.FullRowSelect = true;
            this.listViewReserveringen.HideSelection = false;
            this.listViewReserveringen.Location = new System.Drawing.Point(10, 270);
            this.listViewReserveringen.Name = "listViewReserveringen";
            this.listViewReserveringen.Size = new System.Drawing.Size(514, 121);
            this.listViewReserveringen.TabIndex = 23;
            this.listViewReserveringen.UseCompatibleStateImageBehavior = false;
            this.listViewReserveringen.View = System.Windows.Forms.View.Details;
            this.listViewReserveringen.Click += new System.EventHandler(this.listViewReserveringen_Click);
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 70;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.Width = 70;
            // 
            // tijd
            // 
            this.tijd.Text = "Tijd";
            this.tijd.Width = 50;
            // 
            // personen
            // 
            this.personen.Text = "Personen";
            this.personen.Width = 80;
            // 
            // tafel
            // 
            this.tafel.Text = "Tafel";
            this.tafel.Width = 45;
            // 
            // txtboxNaam
            // 
            this.txtboxNaam.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNaam.Location = new System.Drawing.Point(10, 432);
            this.txtboxNaam.MaxLength = 255;
            this.txtboxNaam.Name = "txtboxNaam";
            this.txtboxNaam.Size = new System.Drawing.Size(243, 39);
            this.txtboxNaam.TabIndex = 22;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.ForeColor = System.Drawing.Color.White;
            this.lblNaam.Location = new System.Drawing.Point(4, 404);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(71, 36);
            this.lblNaam.TabIndex = 21;
            this.lblNaam.Text = "Naam:";
            // 
            // lblReserveringAanpassen
            // 
            this.lblReserveringAanpassen.AutoSize = true;
            this.lblReserveringAanpassen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.lblReserveringAanpassen.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserveringAanpassen.ForeColor = System.Drawing.Color.White;
            this.lblReserveringAanpassen.Location = new System.Drawing.Point(113, -7);
            this.lblReserveringAanpassen.Name = "lblReserveringAanpassen";
            this.lblReserveringAanpassen.Size = new System.Drawing.Size(329, 53);
            this.lblReserveringAanpassen.TabIndex = 20;
            this.lblReserveringAanpassen.Text = "Reservering Aanpassen";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(10, 174);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(157, 39);
            this.dateTimePicker.TabIndex = 42;
            // 
            // btnZoekReserveringOpDatum
            // 
            this.btnZoekReserveringOpDatum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnZoekReserveringOpDatum.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoekReserveringOpDatum.ForeColor = System.Drawing.Color.White;
            this.btnZoekReserveringOpDatum.Location = new System.Drawing.Point(353, 174);
            this.btnZoekReserveringOpDatum.Name = "btnZoekReserveringOpDatum";
            this.btnZoekReserveringOpDatum.Size = new System.Drawing.Size(168, 39);
            this.btnZoekReserveringOpDatum.TabIndex = 41;
            this.btnZoekReserveringOpDatum.Text = "Zoek reservering op datum";
            this.btnZoekReserveringOpDatum.UseVisualStyleBackColor = false;
            this.btnZoekReserveringOpDatum.Click += new System.EventHandler(this.btnZoekReserveringOpDatum_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.Color.White;
            this.lblDatum.Location = new System.Drawing.Point(4, 147);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(153, 36);
            this.lblDatum.TabIndex = 40;
            this.lblDatum.Text = "Zoek op datum:";
            // 
            // btnZoekReserveringOpNaam
            // 
            this.btnZoekReserveringOpNaam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnZoekReserveringOpNaam.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoekReserveringOpNaam.ForeColor = System.Drawing.Color.White;
            this.btnZoekReserveringOpNaam.Location = new System.Drawing.Point(281, 105);
            this.btnZoekReserveringOpNaam.Name = "btnZoekReserveringOpNaam";
            this.btnZoekReserveringOpNaam.Size = new System.Drawing.Size(243, 39);
            this.btnZoekReserveringOpNaam.TabIndex = 39;
            this.btnZoekReserveringOpNaam.Text = "Zoek reservering op naam";
            this.btnZoekReserveringOpNaam.UseVisualStyleBackColor = false;
            this.btnZoekReserveringOpNaam.Click += new System.EventHandler(this.btnZoekReserveringOpNaam_Click);
            // 
            // txtBoxZoekNaam
            // 
            this.txtBoxZoekNaam.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxZoekNaam.Location = new System.Drawing.Point(10, 105);
            this.txtBoxZoekNaam.MaxLength = 255;
            this.txtBoxZoekNaam.Name = "txtBoxZoekNaam";
            this.txtBoxZoekNaam.Size = new System.Drawing.Size(243, 39);
            this.txtBoxZoekNaam.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 36);
            this.label1.TabIndex = 37;
            this.label1.Text = "Zoek op naam:";
            // 
            // comboBoxTijdMinutenZoeken
            // 
            this.comboBoxTijdMinutenZoeken.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTijdMinutenZoeken.FormattingEnabled = true;
            this.comboBoxTijdMinutenZoeken.Location = new System.Drawing.Point(276, 177);
            this.comboBoxTijdMinutenZoeken.Name = "comboBoxTijdMinutenZoeken";
            this.comboBoxTijdMinutenZoeken.Size = new System.Drawing.Size(51, 38);
            this.comboBoxTijdMinutenZoeken.TabIndex = 45;
            // 
            // comboBoxTijdUrenZoeken
            // 
            this.comboBoxTijdUrenZoeken.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTijdUrenZoeken.FormattingEnabled = true;
            this.comboBoxTijdUrenZoeken.Location = new System.Drawing.Point(202, 177);
            this.comboBoxTijdUrenZoeken.Name = "comboBoxTijdUrenZoeken";
            this.comboBoxTijdUrenZoeken.Size = new System.Drawing.Size(51, 38);
            this.comboBoxTijdUrenZoeken.TabIndex = 44;
            // 
            // ReserveringAanpassenScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(533, 643);
            this.Controls.Add(this.comboBoxTijdMinutenZoeken);
            this.Controls.Add(this.comboBoxTijdUrenZoeken);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnZoekReserveringOpDatum);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.btnZoekReserveringOpNaam);
            this.Controls.Add(this.txtBoxZoekNaam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMinuten);
            this.Controls.Add(this.comboBoxUren);
            this.Controls.Add(this.comboBoxTafel);
            this.Controls.Add(this.comboBoxPersonen);
            this.Controls.Add(this.lblTijd);
            this.Controls.Add(this.lblPersonen);
            this.Controls.Add(this.lblTafel);
            this.Controls.Add(this.btnBevestigen);
            this.Controls.Add(this.lblBestaandeReserveringen);
            this.Controls.Add(this.listViewReserveringen);
            this.Controls.Add(this.txtboxNaam);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblReserveringAanpassen);
            this.Name = "ReserveringAanpassenScreen";
            this.Text = "ReserveringAanpassenScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMinuten;
        private System.Windows.Forms.ComboBox comboBoxUren;
        private System.Windows.Forms.ComboBox comboBoxTafel;
        private System.Windows.Forms.ComboBox comboBoxPersonen;
        private System.Windows.Forms.Label lblTijd;
        private System.Windows.Forms.Label lblPersonen;
        private System.Windows.Forms.Label lblTafel;
        private System.Windows.Forms.Button btnBevestigen;
        private System.Windows.Forms.Label lblBestaandeReserveringen;
        private System.Windows.Forms.ListView listViewReserveringen;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader tijd;
        private System.Windows.Forms.ColumnHeader personen;
        private System.Windows.Forms.ColumnHeader tafel;
        private System.Windows.Forms.TextBox txtboxNaam;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblReserveringAanpassen;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnZoekReserveringOpDatum;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnZoekReserveringOpNaam;
        private System.Windows.Forms.TextBox txtBoxZoekNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTijdMinutenZoeken;
        private System.Windows.Forms.ComboBox comboBoxTijdUrenZoeken;
    }
}