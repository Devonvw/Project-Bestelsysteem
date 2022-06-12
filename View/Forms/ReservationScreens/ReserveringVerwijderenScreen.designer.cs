namespace View.Forms
{
    partial class ReserveringVerwijderenScreen
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
            this.lblReserveringVerwijderen = new System.Windows.Forms.Label();
            this.listViewReserveringen = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tijd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tafel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtboxNaam = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.btnZoekReserveringOpNaam = new System.Windows.Forms.Button();
            this.btnZoekReserveringOpDatum = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnReserveringVerwijderen = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblReserveringVerwijderen
            // 
            this.lblReserveringVerwijderen.AutoSize = true;
            this.lblReserveringVerwijderen.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserveringVerwijderen.ForeColor = System.Drawing.Color.White;
            this.lblReserveringVerwijderen.Location = new System.Drawing.Point(114, 9);
            this.lblReserveringVerwijderen.Name = "lblReserveringVerwijderen";
            this.lblReserveringVerwijderen.Size = new System.Drawing.Size(344, 53);
            this.lblReserveringVerwijderen.TabIndex = 1;
            this.lblReserveringVerwijderen.Text = "Reservering Verwijderen";
            // 
            // listViewReserveringen
            // 
            this.listViewReserveringen.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewReserveringen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.datum,
            this.tijd,
            this.personen,
            this.tafel});
            this.listViewReserveringen.FullRowSelect = true;
            this.listViewReserveringen.HideSelection = false;
            this.listViewReserveringen.Location = new System.Drawing.Point(10, 286);
            this.listViewReserveringen.Name = "listViewReserveringen";
            this.listViewReserveringen.Size = new System.Drawing.Size(514, 218);
            this.listViewReserveringen.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewReserveringen.TabIndex = 4;
            this.listViewReserveringen.UseCompatibleStateImageBehavior = false;
            this.listViewReserveringen.View = System.Windows.Forms.View.Details;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 120;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.Width = 100;
            // 
            // tijd
            // 
            this.tijd.Text = "Tijd";
            this.tijd.Width = 100;
            // 
            // personen
            // 
            this.personen.Text = "Personen";
            this.personen.Width = 100;
            // 
            // tafel
            // 
            this.tafel.Text = "Tafel";
            this.tafel.Width = 100;
            // 
            // txtboxNaam
            // 
            this.txtboxNaam.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNaam.Location = new System.Drawing.Point(10, 125);
            this.txtboxNaam.MaxLength = 255;
            this.txtboxNaam.Name = "txtboxNaam";
            this.txtboxNaam.Size = new System.Drawing.Size(243, 39);
            this.txtboxNaam.TabIndex = 6;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.ForeColor = System.Drawing.Color.White;
            this.lblNaam.Location = new System.Drawing.Point(6, 86);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(144, 36);
            this.lblNaam.TabIndex = 5;
            this.lblNaam.Text = "Zoek op naam:";
            // 
            // btnZoekReserveringOpNaam
            // 
            this.btnZoekReserveringOpNaam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnZoekReserveringOpNaam.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoekReserveringOpNaam.ForeColor = System.Drawing.Color.White;
            this.btnZoekReserveringOpNaam.Location = new System.Drawing.Point(269, 125);
            this.btnZoekReserveringOpNaam.Name = "btnZoekReserveringOpNaam";
            this.btnZoekReserveringOpNaam.Size = new System.Drawing.Size(255, 39);
            this.btnZoekReserveringOpNaam.TabIndex = 18;
            this.btnZoekReserveringOpNaam.Text = "Zoek reservering op naam";
            this.btnZoekReserveringOpNaam.UseVisualStyleBackColor = false;
            this.btnZoekReserveringOpNaam.Click += new System.EventHandler(this.btnZoekReserveringOpNaam_Click);
            // 
            // btnZoekReserveringOpDatum
            // 
            this.btnZoekReserveringOpDatum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnZoekReserveringOpDatum.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoekReserveringOpDatum.ForeColor = System.Drawing.Color.White;
            this.btnZoekReserveringOpDatum.Location = new System.Drawing.Point(269, 219);
            this.btnZoekReserveringOpDatum.Name = "btnZoekReserveringOpDatum";
            this.btnZoekReserveringOpDatum.Size = new System.Drawing.Size(255, 39);
            this.btnZoekReserveringOpDatum.TabIndex = 21;
            this.btnZoekReserveringOpDatum.Text = "Zoek reservering op datum";
            this.btnZoekReserveringOpDatum.UseVisualStyleBackColor = false;
            this.btnZoekReserveringOpDatum.Click += new System.EventHandler(this.btnZoekReserveringOpDatum_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.Color.White;
            this.lblDatum.Location = new System.Drawing.Point(4, 180);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(153, 36);
            this.lblDatum.TabIndex = 19;
            this.lblDatum.Text = "Zoek op datum:";
            // 
            // btnReserveringVerwijderen
            // 
            this.btnReserveringVerwijderen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnReserveringVerwijderen.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserveringVerwijderen.ForeColor = System.Drawing.Color.White;
            this.btnReserveringVerwijderen.Location = new System.Drawing.Point(7, 558);
            this.btnReserveringVerwijderen.Name = "btnReserveringVerwijderen";
            this.btnReserveringVerwijderen.Size = new System.Drawing.Size(514, 73);
            this.btnReserveringVerwijderen.TabIndex = 22;
            this.btnReserveringVerwijderen.Text = "Reservering verwijderen";
            this.btnReserveringVerwijderen.UseVisualStyleBackColor = false;
            this.btnReserveringVerwijderen.Click += new System.EventHandler(this.btnReserveringVerwijderen_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 219);
            this.dateTimePicker.MinDate = new System.DateTime(2022, 6, 12, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(238, 39);
            this.dateTimePicker.TabIndex = 24;
            // 
            // ReserveringVerwijderenScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(533, 643);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnReserveringVerwijderen);
            this.Controls.Add(this.btnZoekReserveringOpDatum);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.btnZoekReserveringOpNaam);
            this.Controls.Add(this.txtboxNaam);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.listViewReserveringen);
            this.Controls.Add(this.lblReserveringVerwijderen);
            this.Name = "ReserveringVerwijderenScreen";
            this.Text = "ReserveringVerwijderenScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReserveringVerwijderen;
        private System.Windows.Forms.ListView listViewReserveringen;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader tijd;
        private System.Windows.Forms.ColumnHeader personen;
        private System.Windows.Forms.ColumnHeader tafel;
        private System.Windows.Forms.TextBox txtboxNaam;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Button btnZoekReserveringOpNaam;
        private System.Windows.Forms.Button btnZoekReserveringOpDatum;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnReserveringVerwijderen;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}