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
        private Tablet mainForm;
        ReservationController reservationController;
        TableController tableController;
        Reservation reservation;
        private BillController billController;
        private List<Table> tables;
        private Staff currentUser;
        public ReservationScreen(Tablet mainForm, BillController billController, Staff staff)
        {
            reservationController = new ReservationController();
            tableController = new TableController();
            reservation = new Reservation();
            this.currentUser = staff;
            this.mainForm = mainForm;
            this.billController = billController;
            this.billController.AddObserver(this);
            InitializeComponent();
            HidePanels();
            TableOccupied();  
        }
        public void UpdateForm()
        {
            TableOccupied();
        }
         
        private void TableOccupied()
        {
            List<Button> buttons = FillButtonList();
            tables = tableController.GetAllTables();
            
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
            lblTafel.Text = $"Tafel {reservation.TableId}";
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
            tables = tableController.GetAllTables();
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
        private void btnTable_Click(object sender, EventArgs e)
        {
            LoadTableInfo(int.Parse((sender as Button).Text));
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
            DialogResult dr = MessageBox.Show("Weet u zeker dat u de tafel wilt bezetten?", "Tafel Bezetten", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Table table = new Table();
                    string[] tableName = lblTafel.Text.Split(' ');
                    table.Id = int.Parse(tableName[1]);
                    table.Occupied = true;
                    BillController billController = new BillController();

                    //Aanpassen naar goede staff id 
                    billController.CreateBill(table, currentUser);
                    tableController.ChangeOccupied(table);
                    TableOccupied();
                    TimeSeated(table.Id);
                    LoadTableInfo(table.Id);
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

        private void btnBetalen_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new BillScreen(new Table(1, true), billController), sender);
        }
    }
}
