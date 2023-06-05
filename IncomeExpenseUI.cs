using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conde_Activity10_SimpleApplication
{
    public partial class IncomeExpenseUI : Form
    {
        public int CashIn;
        public int CashOut;
        public int Deposit;
        public double Budget20;
        public IncomeExpenseUI()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void IncomeExpenseUI_Load(object sender, EventArgs e)
        {
            pnlCashInOut.Visible = true;
            pnlSavings.Visible = false;
            pnlIncome.Visible = false;
        }

        private void txtUserIncome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                Form1.Income = int.Parse(txtUserIncome.Text);

                double Budget50;
                double Budget30;

                Budget50 = Form1.Income * 0.5;
                Budget30 = Form1.Income * 0.3;
                Budget20 = Form1.Income * 0.2;

                lbl50Budget.Text = String.Format("₱ " + Budget50);
                lbl30Budget.Text = String.Format("₱ " + Budget30);
                lbl20Budget.Text = String.Format("₱ " + Budget20);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 Form1 = new Form1();
            Form1.BringToFront();
            Form1.Visible = true;

        }

        private void txtCashIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCashIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                CashIn = int.Parse(txtCashIn.Text);
                Form1.Balance = Form1.Balance + CashIn;

                txtCashIn.Clear();

                MessageBox.Show("You have successfully cashed in! \nCheck your balance.");
            }
        }

        private void txtCashOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                CashOut = int.Parse(txtCashOut.Text);

                if(CashOut > Form1.Balance)
                {
                    txtCashOut.Clear();
                    MessageBox.Show("You do not have enough balance. Try again.");
                }
                else
                {
                    txtCashOut.Clear();
                    Form1.Balance = Form1.Balance - CashOut;
                    MessageBox.Show("You have successfully cashed out! \nCheck your balance.");
                }
            }
        }

        private void txtCashInS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCashInS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                Deposit = int.Parse(txtDeposit.Text);

                if (Deposit > Form1.Balance)
                {
                    txtDeposit.Clear();
                    MessageBox.Show("You do not have enough balance. Try again.");
                }
                else
                {
                    txtDeposit.Clear();
                    Form1.Balance = Form1.Balance - Deposit;
                    Form1.Savings = Deposit;
                    MessageBox.Show("You have successfully deposited in your Savings! \nCheck your balance.");
                }

                txtSavings.Text = Form1.Savings.ToString();
            }
        }

        private void pnlSavings_Paint(object sender, PaintEventArgs e)
        {
            lblBudgetforSavings.Text = String.Format("₱ " + Budget20.ToString());
            txtSavings.Text = String.Format("₱ " + Form1.Savings);
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            pnlIncome.BringToFront();
            pnlIncome.Visible = true;

            pnlSavings.Visible = false;
            pnlCashInOut.Visible = false;
        }

        private void btnSavings_Click(object sender, EventArgs e)
        {
            pnlSavings.BringToFront();
            pnlSavings.Visible = true;

            pnlIncome.Visible = false;
            pnlCashInOut.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCashInOut_Click(object sender, EventArgs e)
        {
            pnlCashInOut.BringToFront();
            pnlCashInOut.Visible = true;

            pnlIncome.Visible = false;
            pnlSavings.Visible = false;
        }
    }
}