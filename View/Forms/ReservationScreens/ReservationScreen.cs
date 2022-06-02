using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace View.Forms
{
    public partial class ReservationScreen : Form
    {
        private Reservering mainForm;
        public ReservationScreen(Reservering mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            HidePanels();
            TableOccupied();  
        }

        private void TableOccupied()
        {
            TableController controller = new TableController();
            List<Button> buttons = FillButtonList();
            List<Table> tables = controller.GetAllTables();
            
            foreach (Table t in tables)
            {
                foreach (Button b in buttons)

                if (b.Text == t.Id.ToString())
                {
                    if (t.Occupied)
                        {
                            b.BackColor = Color.Red;
                        }
                    else if (t.Occupied == false)
                        {
                            b.BackColor = Color.Green;
                        }
                }
            }       
        }
        public void UpdateTables()
        {
            TableOccupied();
        }
        private List<Button> FillButtonList()
        {
            List<Button> buttons = new List<Button>();           
            buttons.Add(btnTable1);
            buttons.Add(btnTable2);
            buttons.Add(btnTable3);
            buttons.Add(btnTable4);
            buttons.Add(btnTable5);
            buttons.Add(btnTable6);
            buttons.Add(btnTable7);
            buttons.Add(btnTable8);
            buttons.Add(btnTable9);
            buttons.Add(btnTable10);
            return buttons;
        }
      
        private void fillListViewTables(Reservation reservation)
        {
            pnlReservations.Show();
            lblTafel1.Text = $"Tafel {reservation.TableId}";
            ReservationController reservationController = new ReservationController();
            List<Reservation> reservationList = reservationController.GetReservationsForTable(reservation);

            listViewTable1.Items.Clear();
            foreach (Reservation r in reservationList)
            {
                if(dateTimePicker.Value.ToString("dd/MM/yyyy") == r.DateTime.ToString("dd/MM/yyyy"))
                {
                    ListViewItem li = new ListViewItem(r.Name);
                    li.SubItems.Add(r.Persons.ToString());
                    li.SubItems.Add(r.DateTime.ToString("HH:mm"));
                    listViewTable1.Items.Add(li);
                }   
            }
        }
        private void HidePanels()
        {
            pnlReservations.Hide();
        }

        private void TimeSeated(int button)
        {
            Table table = new Table();
            TableController tableController = new TableController();
            List<Table> tables = tableController.GetAllTables();
            foreach (Table t in tables)
            {
                if (t.Id == button)
                {
                    if (t.Occupied)
                    {
                        lblTafelBezetVanaf.Text = $"Bezet vanaf: {t.TimeSeated.ToString("HH:mm")}";
                    }
                    else
                    {
                        lblTafelBezetVanaf.Text = null;
                    }
                }
            }
        }
        private void btnTable1_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.TableId = int.Parse(btnTable1.Text);
            fillListViewTables(reservation);
            TimeSeated(reservation.TableId);
        }
        private void btnTable2_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.TableId = int.Parse(btnTable2.Text);
            fillListViewTables(reservation);
            TimeSeated(reservation.TableId);
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.TableId = int.Parse(btnTable3.Text);
            fillListViewTables(reservation);
            TimeSeated(reservation.TableId);
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.TableId = int.Parse(btnTable4.Text);
            fillListViewTables(reservation);
            TimeSeated(reservation.TableId);
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.TableId = int.Parse(btnTable5.Text);
            fillListViewTables(reservation);
            TimeSeated(reservation.TableId);
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.TableId = int.Parse(btnTable6.Text);
            fillListViewTables(reservation);
            TimeSeated(reservation.TableId);
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.TableId = int.Parse(btnTable7.Text);
            fillListViewTables(reservation);
            TimeSeated(reservation.TableId);
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.TableId = int.Parse(btnTable8.Text);
            fillListViewTables(reservation);
            TimeSeated(reservation.TableId);
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.TableId = int.Parse(btnTable9.Text);
            fillListViewTables(reservation);
            TimeSeated(reservation.TableId);
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.TableId = int.Parse(btnTable10.Text);
            fillListViewTables(reservation);
            TimeSeated(reservation.TableId);
        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            TableController tableController = new TableController();
            string[] tableName = lblTafel1.Text.Split(' ');
            table.Id = int.Parse(tableName[1]);
            table.Occupied = true;
            
            BillController billController = new BillController();
            Staff staff = new Staff();
            staff.Id = 1;
            //Aanpassen naar goede staff id 
            billController.CreateBill(table, staff);
            tableController.ChangeOccupied(table);
            TableOccupied();
            TimeSeated(table.Id);
        }

        private void btnReserveringToevoegen_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new ReserveringToevoegen(), sender);
        }

        private void btnReserveringVerwijderen_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new ReserveringVerwijderenScreen(), sender); 
        }

        private void btnReserveringAanpassen_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new ReserveringAanpassenScreen(), sender);
        }
    }
}
