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

namespace View.Forms
{
    public partial class OrderScreenParent : Form
    {
        private BillController billController = new BillController();
        private OrderController orderController = new OrderController();
        private Bill bill;        
        private Staff staff = new Staff(1, "Jacky", "Eichenberger", DateTime.Now, Roles.Waiter, "test", "test");               
        private Form activeForm;
        private List<OrderItem> orderItems;
        //private Table[] tables;

        public OrderScreenParent() // staff moet meegegeven vanuit UI / login
        {
            InitializeComponent();
            staffNameLabel.Text = $"Medewerker: {staff.FirstName}";   
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
            try
            {
                Bill bill = billController.GetCurrentOpenBillByTable(table);
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
            OpenChildForm(new Order_Screens.Overview(orderItems, bill, staff));
        }


        // table clicks
        private void table1Button_Click_1(object sender, EventArgs e)
        {
            Table table = new Table(1, true);
            tableNumberLabel.Text = $"Tafel {table.Id}";
            OpenTable(table);
        }

        private void table2Button_Click(object sender, EventArgs e)
        {
            Table table = new Table(2, true);
            tableNumberLabel.Text = $"Tafel {table.Id}";
            OpenTable(table);
        }
        private void table3Button_Click(object sender, EventArgs e)
        {
            Table table = new Table(3, true);
            tableNumberLabel.Text = $"Tafel {table.Id}";
            OpenTable(table);
        }
        private void table4Button_Click(object sender, EventArgs e)
        {
            Table table = new Table(4, true);
            tableNumberLabel.Text = $"Tafel {table.Id}";
            OpenTable(table);
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
    }
}
