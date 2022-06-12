using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Model;
using Controller;
using System.Diagnostics;

namespace View.Forms
{
    public partial class OrderScreenParent : Form, IObserver
    {
        private BillController billController;
        private OrderController orderController = new OrderController();
        private TableController tableController;
        private Bill bill;
        private Staff staff;             
        private Form activeForm;
        private List<OrderItem> orderItems;
        private Label[] LastOrderedLabels;
        private LoginScreen loginScreen;

        public OrderScreenParent(BillController billController, Staff currentUser, LoginScreen loginScreen) // staff moet meegegeven vanuit UI / login
        {
            this.billController = billController;
            billController.AddObserver(this);
            InitializeComponent();
            this.staff = currentUser;
            tableController = new TableController();
            staffNameLabel.Text = $"Medewerker: {staff.FirstName}";
            LastOrderedLabels = new Label[10];
            FillLabelList();
            TableOccupied();
            this.loginScreen = loginScreen;
        }
        public void UpdateForm()
        {
            TableOccupied();
        }
        // Open childform into panel
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.childFormPanel.Controls.Add(childForm);
            this.childFormPanel.Tag = childForm;
            childForm.Size = childFormPanel.Size;
            childForm.BringToFront();
            childForm.Show();
        }
        
        // methods
        private bool TableHasBill(Table table)
        {
            // check for more open bills that arent closed yet
            try
            {
                this.bill = billController.GetCurrentBillByTable(table);
            }
            catch
            {
                return false;
            }
            return true;
        }

        //openen van een tafel
        private void OpenTable(Table table)
        {
            if (TableHasBill(table))
            {
                this.orderItems = orderController.GetOrderItemsForOverview(bill);
            }
            else
            {                
                billController.CreateBill(table, staff); 
                this.bill = billController.GetCurrentBillByTable(table);               
            }
            OpenChildForm(new Order_Screens.Overview(orderItems, bill, staff, tableNumberLabel, this));
        }


        // option to drag the screen by topPanel (eigk alleen voor gebruik op pc handig ofcourse maar werkt lekker tijdens developen)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // table clicks
        private void btnTable_Click(object sender, EventArgs e)
        {
            SelectTable(int.Parse((sender as Button).Text));
        }
        private void SelectTable(int tableNumber)
        {
            Table table = new Table(tableNumber, true);
            tableNumberLabel.Text = $"Tafel {table.Id}";
            OpenTable(table);
        }

        //checken of een tafel bezet is en wanneer laatste order is gedaan
        private void TableOccupied()
        {
            List<Button> buttons = FillButtonList();
            List<Table> tables = tableController.GetAllTables();
            Debug.WriteLine("kaas");

            foreach (Table t in tables)
            {
                foreach (Button b in buttons)

                    if (b.Text == t.Id.ToString())
                    {
                        if (t.Occupied == false)
                        {
                            b.Enabled = false;
                            LastOrderedLabels[t.Id-1].Enabled = false;
                            LastOrderedLabels[t.Id - 1].Text = "";
                        }
                        else if (t.Occupied == true)
                        {
                            b.Enabled = true;
                            if (tableController.TableHasOrdered(t) == true)
                            {
                                LastOrderedLabels[t.Id - 1].Enabled = true;
                                LastOrderPerTable(t);
                            } 
                            else
                            {
                                LastOrderedLabels[t.Id - 1].Enabled = false;
                            }
                        }
                    }     
            }
        }
        
        //vult de lijst met labels
        private void FillLabelList()
        {
            LastOrderedLabels[0] = lblLaatsteBestelling1;
            LastOrderedLabels[1] = lblLaatsteBestelling2;
            LastOrderedLabels[2] = lblLaatsteBestelling3;
            LastOrderedLabels[3] = lblLaatsteBestelling4;
            LastOrderedLabels[4] = lblLaatsteBestelling5;
            LastOrderedLabels[5] = lblLaatsteBestelling6;
            LastOrderedLabels[6] = lblLaatsteBestelling7;
            LastOrderedLabels[7] = lblLaatsteBestelling8;
            LastOrderedLabels[8] = lblLaatsteBestelling9;
            LastOrderedLabels[9] = lblLaatsteBestelling10;
        }

        //wanneer de laatste bestelling is gedaan van deze tafel 
        private void LastOrderPerTable(Table table)
        {
            TableController tableController = new TableController();
            Table tableLastOrdered = tableController.GetLastOrdered(table);
            for (int i = 0; i < LastOrderedLabels.Length; i++)
            {
                if (table.Id-1 == i)
                {
                    LastOrderedLabels[i].Text = tableLastOrdered?.LastOrdered.ToString("HH:mm");
                }
            }    
        }

        //vult een lijst met buttons
        private List<Button> FillButtonList()
        {
            List<Button> buttons = new List<Button>();
            buttons.Add(table1Button);
            buttons.Add(table2Button);
            buttons.Add(table3Button);
            buttons.Add(table4Button);
            buttons.Add(table5Button);
            buttons.Add(table6Button);
            buttons.Add(table7Button);
            buttons.Add(table8Button);
            buttons.Add(table9Button);
            buttons.Add(table10Button);
            return buttons;
        }

        //uitloggen
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            loginScreen.Logout();
        }
    }
}
