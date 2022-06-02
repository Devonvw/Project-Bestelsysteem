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
    public partial class ReserveringToevoegen : Form
    {
        ReservationController reservationController;
        Reservation reservation;
        public ReserveringToevoegen()
        {
            reservation = new Reservation();
            reservationController = new ReservationController();
            InitializeComponent();
            loadForms();
        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            try
            {
                reservation.Name = txtboxNaam.Text;
                reservation.DateTime = DateTime.Parse($"{dateTimePicker1.Value.ToString("yyyy/MM/dd")} {comboBoxUren.SelectedItem.ToString()}:{comboBoxMinuten.SelectedItem.ToString()}");
                reservation.TableId = int.Parse(comboBoxTafel.SelectedItem.ToString());
                reservation.Persons = int.Parse(comboBoxPersonen.SelectedItem.ToString());
                reservationController.AddReservation(reservation);
                MessageBox.Show($"Reservering toegevoegd! {reservation.Name}, tafel {reservation.TableId} op {reservation.DateTime.ToString("dd/MM/yyyy HH:mm")}");
                DateTime gewensteTijd = DateTime.Parse($"{dateTimePicker1.Value.ToString("yyyy/MM/dd")} {comboBoxUren.SelectedItem.ToString()}:{comboBoxMinuten.SelectedItem.ToString()}");
                LoadListView1(reservation, gewensteTijd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niet alle velden zijn ingevuld, vul alle velden in om de reservering toe te kunnen voegen");
            }
            ClearItems();
        }     
        private void loadForms()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            FillComboboxTafel();
            FillComboBoxPersonen();
            FillComboboxTijdUrenZoeken();
            FIllComboboxTijdMinutenZoeken();
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
        private void FillComboboxTijdUrenZoeken()
        {
            for (int i = 10; i <= 21; i++)
            {
                comboBoxUren.Items.Add(i.ToString());
            }
        }

        private void FIllComboboxTijdMinutenZoeken()
        {
            for (int i = 0; i <= 45; i += 15)
            {
                comboBoxMinuten.Items.Add(i.ToString());
            }
        }

        private void btnCheckBeschikbaarheid_Click(object sender, EventArgs e)
        {
            try
            {
                reservation.DateTime = DateTime.Parse(dateTimePicker1.Value.ToString("yyyy/MM/dd"));
                DateTime gewensteTijd  = DateTime.Parse($"{dateTimePicker1.Value.ToString("yyyy/MM/dd")} {comboBoxUren.SelectedItem.ToString()}:{comboBoxMinuten.SelectedItem.ToString()}");
                LoadListView1(reservation, gewensteTijd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niet alle velden zijn ingevuld om de beschikbaarheid te kunnen controleren, vul alle velden in om te kijken of er nog tafels beschikbaar zijn voor uw gewenste tijdslot");
            }
            
        }

        private void LoadListView1(Reservation reservation, DateTime gewensteTijd)
        {
            List<Reservation> reservationList = reservationController.GetReservationByTime(reservation);
            listViewBestaandeReserveringen.Items.Clear();
            try
            {
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
                        listViewBestaandeReserveringen.Items.Add(li);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niet alle velden zijn ingevuld, vul alle velden in om de reserveringen in het gewenste tijdslot te bekijken.");
            }
        }
        private void ClearItems()
        {
            txtboxNaam.Text = null;
            comboBoxPersonen.SelectedIndex = -1;
            comboBoxTafel.SelectedIndex = -1;
            comboBoxMinuten.SelectedIndex = -1;
            comboBoxUren.SelectedIndex = -1;
        }
    }
}
