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

namespace View.Forms
{
    public partial class BillScreen : Form
    {
        private BillController billController;
        private List<OrderItem> orderItems;
        private Bill bill;

        private void Reload()
        {
            orderItems = billController.GetOrderItems(bill);
            ltvBillItems.Items.Clear();
            orderItems.ForEach(menuItem =>
            {
                ListViewItem listViewItem = new ListViewItem(menuItem.MenuItem.ShortName);
                listViewItem.SubItems.Add(menuItem.Amount.ToString());
                listViewItem.SubItems.Add(menuItem.TotalPrice.ToString());
                listViewItem.Tag = menuItem.Id;
                ltvBillItems.Items.Add(listViewItem);
            });
        }
        public BillScreen() //Table table
        {
            billController = new BillController();
            orderItems = new List<OrderItem>();

            InitializeComponent();
        }

        private void BillScreen_Load(object sender, EventArgs e)
        {
            bill = billController.GetCurrentBillByTable(new Table(1, true));
            Reload();
            lblLowBtwOutput.Text = $"€{bill.LowBtwPrice.ToString()}";
            lblHighBtwOutput.Text = $"€{bill.HighBtwPrice.ToString()}";
            lblTotalOutput.Text = $"€{bill.TotalPrice.ToString()}";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pnlPaymentMethod_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
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
                MessageBox.Show("Rekening succesvol gesloten, de tafel is weer open.");
            }
            catch (Exception err)
            {
                MessageBox.Show("Het was niet gelukt om de rekening te sluiten: " + err.Message);
            }
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 1) lblSplitPrice.Text = "";
            else lblSplitPrice.Text = $"€{Math.Round(bill.TotalPrice / (float)numericUpDown1.Value, 2).ToString()}";   
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ltvBillItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
