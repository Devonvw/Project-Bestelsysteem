using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Forms
{
    public partial class ReserveringAanpassenScreen : Form
    {
        ReservationController reservationController;
        Reservation reservation;
        public ReserveringAanpassenScreen()
        {
            reservation = new Reservation();
            reservationController = new ReservationController();
            InitializeComponent();
            LoadForms();
            HideAllBoxes();
        }

        private void btnZoekReserveringOpNaam_Click(object sender, EventArgs e)
        {
            reservation.Name = txtBoxZoekNaam.Text;  
            LoadListViewOpNaam(reservation);
        }
        private void LoadListViewOpNaam(Reservation reservation)
        {
            listViewReserveringen.Enabled = true;
            List<Reservation> reservationList = reservationController.GetReservationByName(reservation);
            listViewReserveringen.Items.Clear();
            LoadListview(reservationList);
        }


        private void LoadListview(List<Reservation> reservationList)
        {
            foreach (Reservation r in reservationList)
            {
                ListViewItem li = new ListViewItem(r.Name.ToString());
                li.SubItems.Add(r.DateTime.ToString("dd-MM-yyyy"));
                li.SubItems.Add(r.DateTime.ToString("HH:mm"));
                li.SubItems.Add(r.Persons.ToString());
                li.SubItems.Add(r.TableId.ToString());
                listViewReserveringen.Items.Add(li);
            }
        }



        private void btnZoekReserveringOpDatum_Click(object sender, EventArgs e)
        {
            listViewReserveringen.Enabled = true;
            reservation.DateTime = DateTime.Parse(dateTimePicker.Value.ToString("yyyy/MM/dd"));
            List<Reservation> reservationList = reservationController.GetReservationByTime(reservation);
            listViewReserveringen.Items.Clear();
            try
            {
                DateTime gewensteTijd = DateTime.Parse($"{dateTimePicker.Value.ToString("yyyy/MM/dd")} {comboBoxTijdUrenZoeken.SelectedItem.ToString()}:{comboBoxTijdMinutenZoeken.SelectedItem.ToString()}");
                int tijdslot = 2;
                DateTime minimaleTijd = gewensteTijd.AddHours(-tijdslot);
                DateTime maximaleTijd = gewensteTijd.AddHours(tijdslot);
                foreach (Reservation r in reservationList)
                {
                    if (r.DateTime > minimaleTijd && r.DateTime < maximaleTijd)
                    {
                        ListViewItem li = new ListViewItem(r.Name.ToString());
                        li.SubItems.Add(r.DateTime.ToString("dd-MM-yyyy"));
                        li.SubItems.Add(r.DateTime.ToString("HH:mm"));
                        li.SubItems.Add(r.Persons.ToString());
                        li.SubItems.Add(r.TableId.ToString());
                        listViewReserveringen.Items.Add(li);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niet alle velden zijn ingevuld, vul alle velden in om de reserveringen in het gewenste tijdslot te bekijken.");
            }
        }
        private void ShowAllBoxes()
        {
            listViewReserveringen.Enabled = true;
            txtboxNaam.Enabled = true;
            comboBoxUren.Enabled = true;
            comboBoxMinuten.Enabled = true;
            comboBoxTafel.Enabled = true;
            comboBoxPersonen.Enabled = true;
            btnBevestigen.Enabled = true;
        }

        private void listViewReserveringen_Click(object sender, EventArgs e)
        {
            ShowAllBoxes();
            txtboxNaam.Text = listViewReserveringen.SelectedItems[0].SubItems[0].Text;
            dateTimePicker.Value = DateTime.Parse(listViewReserveringen.SelectedItems[0].SubItems[1].Text);
            string time = listViewReserveringen.SelectedItems[0].SubItems[2].Text;
            string[] timeSplit = time.Split(':');
            comboBoxUren.SelectedIndex = int.Parse(timeSplit[0]) - 10;

            if (timeSplit[1] == "00")
            {
                comboBoxMinuten.SelectedIndex = 0;
            }
            else if(timeSplit[1] == "15")
            {
                comboBoxMinuten.SelectedIndex=1;
            }
            else if(timeSplit[1] == "30"){
                comboBoxMinuten.SelectedIndex=2;
            }
            else if (timeSplit[1] == "45")
            {
                comboBoxMinuten.SelectedIndex = 3;
            }
            comboBoxPersonen.SelectedIndex = int.Parse(listViewReserveringen.SelectedItems[0].SubItems[3].Text)-1;
            comboBoxTafel.SelectedIndex = int.Parse(listViewReserveringen.SelectedItems[0].SubItems[4].Text)-1;
        }
        private void LoadForms()
        {
            FillComboBoxMinuten();
            FillComboBoxPersonen();
            FillComboboxTafel();
            FillComboBoxUren();
            FillComboboxTijdUrenZoeken();
            FillComboboxTijdMinutenZoeken();
        }
        
        private void HideAllBoxes()
        { 
            listViewReserveringen.Enabled=false;
            txtboxNaam.Enabled = false; 
            comboBoxUren.Enabled = false;
            comboBoxMinuten.Enabled = false;
            comboBoxTafel.Enabled=false;
            comboBoxPersonen.Enabled=false;
            btnBevestigen.Enabled = false;
        }
        private void FillComboboxTafel()
        {
            TableController tableController = new TableController();
            List<Table> tableList = tableController.GetAllTables();
            foreach (Table t in tableList)
            {
                comboBoxTafel.Items.Add(t.Id);
            }
        }
        private void FillComboBoxPersonen()
        {
            for (int i = 1; i <= 4; i++)
            {
                comboBoxPersonen.Items.Add(i);
            }
        }
        public void FillComboBoxUren()
        {
            for (int i = 10; i <= 21; i++)
            {
                comboBoxUren.Items.Add(i.ToString());
            }
        }
        public void FillComboBoxMinuten()
        {
            for (int i = 0; i <= 45; i += 15)
            {
                comboBoxMinuten.Items.Add(i.ToString());
            }
        }
        private void FillComboboxTijdUrenZoeken()
        {
            for (int i = 10; i <= 21; i++)
            {
                comboBoxTijdUrenZoeken.Items.Add(i.ToString());
            }
        }

        private void FillComboboxTijdMinutenZoeken()
        {
            for (int i = 0; i <= 45; i += 15)
            {
                comboBoxTijdMinutenZoeken.Items.Add(i.ToString());
            }
        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            ReserveringVerwijderen();
            ReserveringToevoegen();
            reservation.Name = txtboxNaam.Text;
            LoadListViewOpNaam(reservation);
        }
        private void ReserveringToevoegen()
        {
            try
            {
                reservation.Name = txtboxNaam.Text;
                reservation.DateTime = DateTime.Parse($"{dateTimePicker.Value.ToString("yyyy/MM/dd")} {comboBoxUren.SelectedItem.ToString()}:{comboBoxMinuten.SelectedItem.ToString()}");
                reservation.TableId = int.Parse(comboBoxTafel.SelectedItem.ToString());
                reservation.Persons = int.Parse(comboBoxPersonen.SelectedItem.ToString());
                reservationController.AddReservation(reservation);
                MessageBox.Show($"Reservering aangepast! {reservation.Name}, tafel {reservation.TableId} op {reservation.DateTime.ToString("dd/MM/yyyy HH:mm")}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niet alle velden zijn ingevuld, vul alle velden in om de reservering toe te kunnen voegen");
            }
        }
        private void ReserveringVerwijderen()
        {
            reservation.Name = listViewReserveringen.SelectedItems[0].SubItems[0].Text;
            string date = listViewReserveringen.SelectedItems[0].SubItems[1].Text;
            string time = listViewReserveringen.SelectedItems[0].SubItems[2].Text;
            reservation.DateTime = DateTime.Parse($"{date} {time}");
            reservation.Persons = int.Parse(listViewReserveringen.SelectedItems[0].SubItems[3].Text);
            reservation.TableId = int.Parse(listViewReserveringen.SelectedItems[0].SubItems[4].Text);
            reservationController.DeleteReservation(reservation);
            listViewReserveringen.SelectedItems.Clear();
        }

    }
}
