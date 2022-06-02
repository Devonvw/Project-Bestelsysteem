namespace View.Forms
{
    partial class ReserveringToevoegen
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
            this.lblReserveringToevoegen = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.txtboxNaam = new System.Windows.Forms.TextBox();
            this.listViewBestaandeReserveringen = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tijd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tafel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBestaandeReserveringen = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnBevestigen = new System.Windows.Forms.Button();
            this.lblTafel = new System.Windows.Forms.Label();
            this.lblPersonen = new System.Windows.Forms.Label();
            this.comboBoxPersonen = new System.Windows.Forms.ComboBox();
            this.comboBoxTafel = new System.Windows.Forms.ComboBox();
            this.btnCheckBeschikbaarheid = new System.Windows.Forms.Button();
            this.comboBoxMinuten = new System.Windows.Forms.ComboBox();
            this.comboBoxUren = new System.Windows.Forms.ComboBox();
            this.lblTijdZoeken = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReserveringToevoegen
            // 
            this.lblReserveringToevoegen.AutoSize = true;
            this.lblReserveringToevoegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.lblReserveringToevoegen.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserveringToevoegen.ForeColor = System.Drawing.Color.White;
            this.lblReserveringToevoegen.Location = new System.Drawing.Point(116, -6);
            this.lblReserveringToevoegen.Name = "lblReserveringToevoegen";
            this.lblReserveringToevoegen.Size = new System.Drawing.Size(335, 53);
            this.lblReserveringToevoegen.TabIndex = 0;
            this.lblReserveringToevoegen.Text = "Reservering Toevoegen";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.ForeColor = System.Drawing.Color.White;
            this.lblNaam.Location = new System.Drawing.Point(14, 388);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(71, 36);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Naam:";
            // 
            // txtboxNaam
            // 
            this.txtboxNaam.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNaam.Location = new System.Drawing.Point(12, 426);
            this.txtboxNaam.MaxLength = 255;
            this.txtboxNaam.Name = "txtboxNaam";
            this.txtboxNaam.Size = new System.Drawing.Size(243, 39);
            this.txtboxNaam.TabIndex = 2;
            // 
            // listViewBestaandeReserveringen
            // 
            this.listViewBestaandeReserveringen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.datum,
            this.tijd,
            this.personen,
            this.tafel});
            this.listViewBestaandeReserveringen.HideSelection = false;
            this.listViewBestaandeReserveringen.Location = new System.Drawing.Point(12, 227);
            this.listViewBestaandeReserveringen.Name = "listViewBestaandeReserveringen";
            this.listViewBestaandeReserveringen.Size = new System.Drawing.Size(514, 158);
            this.listViewBestaandeReserveringen.TabIndex = 3;
            this.listViewBestaandeReserveringen.UseCompatibleStateImageBehavior = false;
            this.listViewBestaandeReserveringen.View = System.Windows.Forms.View.Details;
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
            // lblBestaandeReserveringen
            // 
            this.lblBestaandeReserveringen.AutoSize = true;
            this.lblBestaandeReserveringen.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestaandeReserveringen.ForeColor = System.Drawing.Color.White;
            this.lblBestaandeReserveringen.Location = new System.Drawing.Point(12, 183);
            this.lblBestaandeReserveringen.Name = "lblBestaandeReserveringen";
            this.lblBestaandeReserveringen.Size = new System.Drawing.Size(280, 41);
            this.lblBestaandeReserveringen.TabIndex = 4;
            this.lblBestaandeReserveringen.Text = "Bestaande Reserveringen:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 39);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.Color.White;
            this.lblDatum.Location = new System.Drawing.Point(14, 57);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(78, 36);
            this.lblDatum.TabIndex = 6;
            this.lblDatum.Text = "Datum:";
            // 
            // btnBevestigen
            // 
            this.btnBevestigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnBevestigen.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBevestigen.ForeColor = System.Drawing.Color.White;
            this.btnBevestigen.Location = new System.Drawing.Point(12, 554);
            this.btnBevestigen.Name = "btnBevestigen";
            this.btnBevestigen.Size = new System.Drawing.Size(514, 79);
            this.btnBevestigen.TabIndex = 7;
            this.btnBevestigen.Text = "Bevestigen";
            this.btnBevestigen.UseVisualStyleBackColor = false;
            this.btnBevestigen.Click += new System.EventHandler(this.btnBevestigen_Click);
            // 
            // lblTafel
            // 
            this.lblTafel.AutoSize = true;
            this.lblTafel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTafel.ForeColor = System.Drawing.Color.White;
            this.lblTafel.Location = new System.Drawing.Point(13, 468);
            this.lblTafel.Name = "lblTafel";
            this.lblTafel.Size = new System.Drawing.Size(60, 36);
            this.lblTafel.TabIndex = 10;
            this.lblTafel.Text = "Tafel:";
            // 
            // lblPersonen
            // 
            this.lblPersonen.AutoSize = true;
            this.lblPersonen.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonen.ForeColor = System.Drawing.Color.White;
            this.lblPersonen.Location = new System.Drawing.Point(272, 468);
            this.lblPersonen.Name = "lblPersonen";
            this.lblPersonen.Size = new System.Drawing.Size(99, 36);
            this.lblPersonen.TabIndex = 12;
            this.lblPersonen.Text = "Personen:";
            // 
            // comboBoxPersonen
            // 
            this.comboBoxPersonen.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPersonen.FormattingEnabled = true;
            this.comboBoxPersonen.Location = new System.Drawing.Point(278, 500);
            this.comboBoxPersonen.Name = "comboBoxPersonen";
            this.comboBoxPersonen.Size = new System.Drawing.Size(243, 38);
            this.comboBoxPersonen.TabIndex = 15;
            // 
            // comboBoxTafel
            // 
            this.comboBoxTafel.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTafel.FormattingEnabled = true;
            this.comboBoxTafel.Location = new System.Drawing.Point(12, 500);
            this.comboBoxTafel.Name = "comboBoxTafel";
            this.comboBoxTafel.Size = new System.Drawing.Size(244, 38);
            this.comboBoxTafel.TabIndex = 16;
            // 
            // btnCheckBeschikbaarheid
            // 
            this.btnCheckBeschikbaarheid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCheckBeschikbaarheid.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBeschikbaarheid.ForeColor = System.Drawing.Color.White;
            this.btnCheckBeschikbaarheid.Location = new System.Drawing.Point(20, 141);
            this.btnCheckBeschikbaarheid.Name = "btnCheckBeschikbaarheid";
            this.btnCheckBeschikbaarheid.Size = new System.Drawing.Size(506, 39);
            this.btnCheckBeschikbaarheid.TabIndex = 17;
            this.btnCheckBeschikbaarheid.Text = "Check beschikbaarheid";
            this.btnCheckBeschikbaarheid.UseVisualStyleBackColor = false;
            this.btnCheckBeschikbaarheid.Click += new System.EventHandler(this.btnCheckBeschikbaarheid_Click);
            // 
            // comboBoxMinuten
            // 
            this.comboBoxMinuten.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMinuten.FormattingEnabled = true;
            this.comboBoxMinuten.Location = new System.Drawing.Point(407, 86);
            this.comboBoxMinuten.Name = "comboBoxMinuten";
            this.comboBoxMinuten.Size = new System.Drawing.Size(114, 38);
            this.comboBoxMinuten.TabIndex = 22;
            // 
            // comboBoxUren
            // 
            this.comboBoxUren.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUren.FormattingEnabled = true;
            this.comboBoxUren.Location = new System.Drawing.Point(275, 86);
            this.comboBoxUren.Name = "comboBoxUren";
            this.comboBoxUren.Size = new System.Drawing.Size(117, 38);
            this.comboBoxUren.TabIndex = 21;
            // 
            // lblTijdZoeken
            // 
            this.lblTijdZoeken.AutoSize = true;
            this.lblTijdZoeken.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTijdZoeken.ForeColor = System.Drawing.Color.White;
            this.lblTijdZoeken.Location = new System.Drawing.Point(272, 57);
            this.lblTijdZoeken.Name = "lblTijdZoeken";
            this.lblTijdZoeken.Size = new System.Drawing.Size(51, 36);
            this.lblTijdZoeken.TabIndex = 20;
            this.lblTijdZoeken.Text = "Tijd:";
            // 
            // ReserveringToevoegen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(533, 643);
            this.Controls.Add(this.comboBoxMinuten);
            this.Controls.Add(this.comboBoxUren);
            this.Controls.Add(this.lblTijdZoeken);
            this.Controls.Add(this.btnCheckBeschikbaarheid);
            this.Controls.Add(this.comboBoxTafel);
            this.Controls.Add(this.comboBoxPersonen);
            this.Controls.Add(this.lblPersonen);
            this.Controls.Add(this.lblTafel);
            this.Controls.Add(this.btnBevestigen);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblBestaandeReserveringen);
            this.Controls.Add(this.listViewBestaandeReserveringen);
            this.Controls.Add(this.txtboxNaam);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblReserveringToevoegen);
            this.Name = "ReserveringToevoegen";
            this.Text = "ReserveringToevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReserveringToevoegen;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.TextBox txtboxNaam;
        private System.Windows.Forms.ListView listViewBestaandeReserveringen;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader tijd;
        private System.Windows.Forms.ColumnHeader personen;
        private System.Windows.Forms.ColumnHeader tafel;
        private System.Windows.Forms.Label lblBestaandeReserveringen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnBevestigen;
        private System.Windows.Forms.Label lblTafel;
        private System.Windows.Forms.Label lblPersonen;
        private System.Windows.Forms.ComboBox comboBoxPersonen;
        private System.Windows.Forms.ComboBox comboBoxTafel;
        private System.Windows.Forms.Button btnCheckBeschikbaarheid;
        private System.Windows.Forms.ComboBox comboBoxMinuten;
        private System.Windows.Forms.ComboBox comboBoxUren;
        private System.Windows.Forms.Label lblTijdZoeken;
    }
}