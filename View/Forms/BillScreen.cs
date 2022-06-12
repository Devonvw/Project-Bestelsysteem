using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;
using System.Diagnostics;

namespace View.Forms
{
    public partial class BillScreen : Form
    {
        private Tablet mainForm;
        private BillController billController;
        private List<OrderItem> orderItems;
        private Bill bill;
        private Table table;
        private TableController tableController;
        private Staff currentUser;

        //For reloading the bill list
        private void Reload()
        {
            orderItems = billController.GetOrderItems(bill);
            ltvBillItems.Items.Clear();
            orderItems.ForEach(menuItem =>
            {
                ListViewItem listViewItem = new ListViewItem(menuItem.MenuItem.ShortName);
                listViewItem.SubItems.Add(menuItem.Amount.ToString());
                listViewItem.SubItems.Add(menuItem.TotalPrice.ToString());
                listViewItem.Tag = menuItem;
                ltvBillItems.Items.Add(listViewItem);
            });
        }
        public BillScreen(Table table, BillController billController, Tablet mainform, Staff currentUser)
        {
            this.table = table;
            this.billController = billController;
            mainForm = mainform;       
            orderItems = new List<OrderItem>();
            tableController = new TableController();
            this.currentUser = currentUser;

            InitializeComponent();
        }
        private void BillScreen_Load(object sender, EventArgs e)
        {
            lblRekening.Text = $"{lblRekening.Text} {table.Id}";
            bill = billController.GetCurrentBillByTable(table);
            Reload();

            lblLowBtwOutput.Text = $"€{bill.LowBtwPrice.ToString("0.00")}";
            lblHighBtwOutput.Text = $"€{bill.HighBtwPrice.ToString("0.00")}";
            lblTotalOutput.Text = $"€{bill.TotalPrice.ToString("0.00")}";
        }
        //Close the bill
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bill.Comment = string.IsNullOrEmpty(txtOpmerkingInput.Text) ? "" : txtOpmerkingInput.Text;
                bill.Tip = (float)numTip.Value;
                bill.PaymentMethod = rbContant.Checked ? PaymentMethod.Cash : rbPin.Checked ? PaymentMethod.Pin : rbCreditcard.Checked ? PaymentMethod.Creditcard : rbCashPin.Checked ? PaymentMethod.CashPin : rbCashCreditcard.Checked ? PaymentMethod.CashCreditcard : PaymentMethod.None;

                billController.CloseBill(bill);
                MessageBox.Show("Rekening succesvol gesloten, de tafel is weer open.");
                mainForm.OpenChildForm(new ReservationScreen(mainForm, billController, currentUser), sender);
            }
            catch (Exception err) { MessageBox.Show("Het was niet gelukt om de rekening te sluiten: " + err.Message); }
        }
        //Handle splitting the bill
        private void numSplit_ValueChanged(object sender, EventArgs e)
        {
            if (numSplit.Value == 1) lblSplitPrice.Text = "";
            else lblSplitPrice.Text = $"€{Math.Round(bill.TotalPrice / (float)numSplit.Value, 2)}";
        }
    }
}