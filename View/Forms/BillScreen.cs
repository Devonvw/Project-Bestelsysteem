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
        private BillController controller;
        private Bill bill;
        public BillScreen() //Table table
        {
            controller = new BillController();
            bill = controller.GetCurrentBillByTable(new Table(1, true));
            InitializeComponent();
        }

        private void BillScreen_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bill.Comment = string.IsNullOrEmpty(txtOpmerkingInput.Text) ? txtOpmerkingInput.Text : null;
            bill.Comment = string.IsNullOrEmpty(txtOpmerkingInput.Text) ? txtOpmerkingInput.Text : null;

            controller.CloseBill(bill);
        }

        private void rbContant_CheckedChanged(object sender, EventArgs e)
        {
            if (rbContant.Checked)
            {
                Enum.TryParse("Active", out PaymentMethod paymentMethod);
                bill.PaymentMethod = paymentMethod;
            }
        }
    }
}
