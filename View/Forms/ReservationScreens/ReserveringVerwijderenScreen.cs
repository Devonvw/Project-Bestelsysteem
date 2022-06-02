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
    public partial class ReserveringVerwijderenScreen : Form
    {
        public ReserveringVerwijderenScreen()
        {
            InitializeComponent();
        }

        private void btnZoekReserveringOpNaam_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            ReservationController reservationController = new ReservationController();
            reservation.Name = txtboxNaam.Text;
            List<Reservation> reservationList = reservationController.GetReservationByName(reservation);
            listViewReserveringen.Items.Clear();
            loadListview(reservationList);
        }

        private void btnZoekReserveringOpDatum_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.DateTime = DateTime.Parse(dateTimePicker.Value.ToString("yyyy/MM/dd"));
            ReservationController reservationController = new ReservationController();
            List<Reservation> reservationList = reservationController.GetReservationByTime(reservation);
            listViewReserveringen.Items.Clear();
            loadListview(reservationList);
        }

        private void loadListview(List<Reservation> reservationList)
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

        private void btnReserveringVerwijderen_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation reservation = new Reservation();
                reservation.Name = listViewReserveringen.SelectedItems[0].SubItems[0].Text;
                string date = listViewReserveringen.SelectedItems[0].SubItems[1].Text;
                string time = listViewReserveringen.SelectedItems[0].SubItems[2].Text;
                reservation.DateTime = DateTime.Parse($"{date} {time}");
                reservation.Persons = int.Parse(listViewReserveringen.SelectedItems[0].SubItems[3].Text);
                reservation.TableId = int.Parse(listViewReserveringen.SelectedItems[0].SubItems[4].Text);
                ReservationController reservationController = new ReservationController();
                reservationController.DeleteReservation(reservation);
                listViewReserveringen.SelectedItems[0].Remove();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Selecteer een reservering die u zou willen verwijderen");
            }
        }
    }
}
