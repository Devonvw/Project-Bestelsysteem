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
        private Table currentTable;
        private Table table;
        public ReservationScreen(Tablet mainForm, BillController billController, Staff staff)
        {
            reservationController = new ReservationController();
            tableController = new TableController();
            reservation = new Reservation();
            currentTable = new Table();
            table = new Table();
            this.currentUser = staff;
            this.mainForm = mainForm;
            this.billController = billController;
            this.billController.AddObserver(this);
            InitializeComponent();
            HidePanels();
            TableOccupied();  
        }

        //Update de form
        public void UpdateForm()
        {
            TableOccupied();
        }
         
        //checkt of een tafel bezet is
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

        //vult een lijst met alle buttons
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
      
        //vult de listview met reserveringen van een tafel
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

        //hide de panel met de reserveringen
        private void HidePanels()
        {
            pnlReservations.Hide();
        }
        
        //Laat zien vanaf wanneer een tafel is bezet
        private void TimeSeated(int button)
        {
            tables = tableController.GetAllTables();
            int UTC2Timezone = 2;
            foreach (Table t in tables)
            {
                if (t.Id == button)
                {
                    if (t.Occupied)
                    {
                        lblTafelBezetVanaf.Text = $"Bezet vanaf: {t.TimeSeated.AddHours(UTC2Timezone):HH:mm}";
                    }
                    else
                    {
                        lblTafelBezetVanaf.Text = null;
                    }
                }
            }
        }
        //alle button clicks
        private void btnTable_Click(object sender, EventArgs e)
        {
            currentTable.Id = int.Parse((sender as Button).Text);
            LoadTableInfo(currentTable.Id);
        }

        //laadt de info van het overzicht van een tafel
        private void LoadTableInfo(int tafelId)
        {
            reservation.TableId = tafelId;
            fillListViewTables(reservation);
            TimeSeated(reservation.TableId);
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

        //bevestigen van het bezetten van een tafel;
        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Weet u zeker dat u de tafel wilt bezetten?", "Tafel Bezetten", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    string[] tableName = lblTafel.Text.Split(' ');
                    table.Id = int.Parse(tableName[1]);
                    table.Occupied = true;

                    //Aanpassen naar goede staff id 
                    tableController.ChangeOccupied(table);
                    billController.CreateBill(table, currentUser);
                    TableOccupied();
                    TimeSeated(table.Id);
                    LoadTableInfo(table.Id);
                    break;
                case DialogResult.No:
                    break;

            }
            
        }

        //openen childform reservering toevoegen
        private void btnReserveringToevoegen_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new ReserveringToevoegen(), sender);
        }

        //openen childform reservering verwijderen
        private void btnReserveringVerwijderen_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new ReserveringVerwijderenScreen(), sender); 
        }

        //openen childform reservering aanpassen
        private void btnReserveringAanpassen_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new ReserveringAanpassenScreen(), sender);
        }
         
        //openen childform betalen
        private void btnBetalen_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new BillScreen(new Table(currentTable.Id, true), billController, mainForm, currentUser), sender);
        }
    }
}
