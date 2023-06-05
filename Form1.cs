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
    public partial class Form1 : Form
    {
        public static int Balance = 0;
        public static int Income = 0;
        public static int Savings = 0;
        //public static string Name;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName.Text = LoginUI.Username;
            lblBalance.Text = String.Format("₱ " + Balance);
            lblIncome.Text = String.Format("₱ " + Income);
            lblExpense.Text = String.Format("₱ " + Savings);

            pnlProfile.Visible = false;
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            IncomeExpenseUI Form2 = new IncomeExpenseUI();

            Form2.Visible = true;
            Form2.BringToFront();

            this.Visible = false;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlProfile.BringToFront();
            pnlProfile.Visible = true;
        }

        private void llblFinancialManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://www.mygreatlearning.com/blog/financial-management-introduction-guide/");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlProfile.SendToBack();
            pnlProfile.Visible = false;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                string Name;
                Name = txtName.Text;
                lblName.Text = Name;
            }
        }
    }
}
