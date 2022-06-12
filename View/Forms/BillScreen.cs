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
        private BillController billController;
        private List<OrderItem> orderItems;
        private Bill bill;
        private Table table;
        private TableController tableController;

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
        public BillScreen(Table table, BillController billController)
        {
            this.table = table;
            this.billController = billController;
            orderItems = new List<OrderItem>();
            tableController = new TableController();

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
        private void btnSave_Click(object sender, EventArgs e)
        {
            bill.Comment = string.IsNullOrEmpty(txtOpmerkingInput.Text) ? "" : txtOpmerkingInput.Text;
            bill.Tip = (float)numTip.Value;
            if (rbContant.Checked) bill.PaymentMethod = PaymentMethod.Cash;
            else if (rbPin.Checked) bill.PaymentMethod = PaymentMethod.Pin;
            else if (rbCreditcard.Checked) bill.PaymentMethod = PaymentMethod.Creditcard;
            else if (rbCashPin.Checked) bill.PaymentMethod = PaymentMethod.CashPin;
            else if (rbCashCreditcard.Checked) bill.PaymentMethod = PaymentMethod.CashCreditcard;
            else bill.PaymentMethod = PaymentMethod.None;

            try
            {
                billController.CloseBill(bill);
                table.Id = bill.TableId;
                table.Occupied = false;
                tableController.ChangeOccupied(table);
                MessageBox.Show("Rekening succesvol gesloten, de tafel is weer open.");
                
            }
            catch (Exception err)
            {
                MessageBox.Show("Het was niet gelukt om de rekening te sluiten: " + err.Message);
            }
        }
        private void numSplit_ValueChanged(object sender, EventArgs e)
        {
            if (numSplit.Value == 1) lblSplitPrice.Text = "";
            else lblSplitPrice.Text = $"€{Math.Round(bill.TotalPrice / (float)numSplit.Value, 2)}";
        }

        private void lblRekening_Click(object sender, EventArgs e)
        {

        }

        private void lblOpmerkingen_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}