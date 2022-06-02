using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace View.Forms
{
    public partial class ReservationScreen : Form, IObserver
    {
        private Reservering mainForm;
        ReservationController reservationController;
        TableController tableController;
        Reservation reservation;
        public ReservationScreen(Reservering mainForm, BillController billController)
        {
            reservationController = new ReservationController();
            tableController = new TableController();
            reservation = new Reservation();
            this.mainForm = mainForm;
            billController.AddObserver(this);
            InitializeComponent();
            HidePanels();
            TableOccupied();  
        }
        public void UpdateForm()
        {
            Debug.WriteLine("Kaas");
            TableOccupied();
        }

        private void TableOccupied()
        {
            List<Button> buttons = FillButtonList();
            List<Table> tables = tableController.GetAllTables();
            
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
            LoadTableInfo(int.Parse(btnTable1.Text));
        }
        private void btnTable2_Click(object sender, EventArgs e)
        {
            LoadTableInfo(int.Parse(btnTable2.Text));
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            LoadTableInfo(int.Parse(btnTable3.Text));
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            LoadTableInfo(int.Parse(btnTable4.Text));
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            LoadTableInfo(int.Parse(btnTable5.Text));
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            LoadTableInfo(int.Parse(btnTable6.Text));
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            LoadTableInfo(int.Parse(btnTable7.Text));
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            LoadTableInfo(int.Parse(btnTable8.Text));
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            LoadTableInfo(int.Parse(btnTable9.Text));
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            LoadTableInfo(int.Parse(btnTable10.Text));
        }
        private void LoadTableInfo(int tafelId)
        {
            reservation.TableId = tafelId;
            fillListViewTables(reservation);
            TimeSeated(reservation.TableId);

            BillController billController = new BillController();
            Table table = new Table();
            table.Id = tafelId;
            bool billExists = billController.BillExist(table);
            if (billExists)
            {
                btnBetalen.Enabled = true;
                btnBevestigen.Enabled = false;
            }
            else
            {
                btnBetalen.Enabled = false;
                btnBevestigen.Enabled = true;
            }
        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Weet u zeker dat u de tafel wilt bezetten?", "Tafel Beztten", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Table table = new Table();
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
                    break;
                case DialogResult.No:
                    break;
            }
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
