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
        private Bill bill;        
        private Staff staff = new Staff(1, "Jacky", "Eichenberger", DateTime.Now, Roles.Waiter, "test", "test", true);               
        private Form activeForm;
        private List<OrderItem> orderItems;
        //private Table[] tables;

        public OrderScreenParent(BillController billController) // staff moet meegegeven vanuit UI / login
        {
            this.billController = billController;
            billController.AddObserver(this);
            InitializeComponent();
            staffNameLabel.Text = $"Medewerker: {staff.FirstName}";   
        }
        public void UpdateForm()
        {
            Debug.WriteLine("Joost");
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
                Bill bill = billController.GetCurrentBillByTable(table);
                this.bill = bill;
            }
            catch
            {
                return false;
            }
            return true;
        }

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
            OpenChildForm(new Order_Screens.Overview(orderItems, bill, staff, tableNumberLabel));
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
        private void SelectTable(int tableNumber)
        {
            Table table = new Table(tableNumber, true);
            tableNumberLabel.Text = $"Tafel {table.Id}";
            OpenTable(table);
        }
        private void table1Button_Click_1(object sender, EventArgs e)
        {
            SelectTable(int.Parse(table1Button.Text));
        }

        private void table2Button_Click(object sender, EventArgs e)
        {
            SelectTable(int.Parse(table2Button.Text));
        }
        private void table3Button_Click(object sender, EventArgs e)
        {
            SelectTable(int.Parse(table3Button.Text));
        }
        private void table4Button_Click(object sender, EventArgs e)
        {
            SelectTable(int.Parse(table4Button.Text));
        }

        private void table5Button_Click(object sender, EventArgs e)
        {
            SelectTable(int.Parse(table5Button.Text));
        }

        private void table6Button_Click(object sender, EventArgs e)
        {
            SelectTable(int.Parse(table6Button.Text));
        }

        private void table7Button_Click(object sender, EventArgs e)
        {
            SelectTable(int.Parse(table7Button.Text));
        }

        private void table8Button_Click(object sender, EventArgs e)
        {
            SelectTable(int.Parse(table8Button.Text));
        }

        private void table9Button_Click(object sender, EventArgs e)
        {
            SelectTable(int.Parse(table9Button.Text));
        }

        private void table10Button_Click(object sender, EventArgs e)
        {
            SelectTable(int.Parse(table10Button.Text));
        }
    }
}
