namespace Conde_Activity10_SimpleApplication
{
    partial class IncomeExpenseUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeExpenseUI));
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnCashInOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSavings = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.pnlIncome = new System.Windows.Forms.Panel();
            this.lblBudgetDescription = new System.Windows.Forms.Label();
            this.lbl20Budget = new System.Windows.Forms.Label();
            this.txtUserIncome = new System.Windows.Forms.TextBox();
            this.lbl30Budget = new System.Windows.Forms.Label();
            this.lblIdealBudget = new System.Windows.Forms.Label();
            this.lbl50Budget = new System.Windows.Forms.Label();
            this.lblEnterIncome = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.lbl30 = new System.Windows.Forms.Label();
            this.txtCashOut = new System.Windows.Forms.TextBox();
            this.lblCashOut = new System.Windows.Forms.Label();
            this.txtCashIn = new System.Windows.Forms.TextBox();
            this.lblCashIn = new System.Windows.Forms.Label();
            this.pnlSavings = new System.Windows.Forms.Panel();
            this.lblSavingsNote = new System.Windows.Forms.Label();
            this.lblBudgetforSavings = new System.Windows.Forms.Label();
            this.lblIdealSavings = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtSavings = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblSavings = new System.Windows.Forms.Label();
            this.pnlCashInOut = new System.Windows.Forms.Panel();
            this.pnlFooter.SuspendLayout();
            this.pnlIncome.SuspendLayout();
            this.pnlSavings.SuspendLayout();
            this.pnlCashInOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackgroundImage = global::Conde_Activity10_SimpleApplication.Properties.Resources.Random_Backgrounds;
            this.pnlFooter.Controls.Add(this.btnCashInOut);
            this.pnlFooter.Controls.Add(this.btnBack);
            this.pnlFooter.Controls.Add(this.btnSavings);
            this.pnlFooter.Controls.Add(this.btnIncome);
            this.pnlFooter.Location = new System.Drawing.Point(-3, -1);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(748, 123);
            this.pnlFooter.TabIndex = 6;
            // 
            // btnCashInOut
            // 
            this.btnCashInOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashInOut.Location = new System.Drawing.Point(635, 26);
            this.btnCashInOut.Name = "btnCashInOut";
            this.btnCashInOut.Size = new System.Drawing.Size(91, 70);
            this.btnCashInOut.TabIndex = 6;
            this.btnCashInOut.Text = "+/-";
            this.btnCashInOut.UseVisualStyleBackColor = true;
            this.btnCashInOut.Click += new System.EventHandler(this.btnCashInOut_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(15, 26);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 70);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSavings
            // 
            this.btnSavings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavings.Location = new System.Drawing.Point(390, 26);
            this.btnSavings.Name = "btnSavings";
            this.btnSavings.Size = new System.Drawing.Size(223, 70);
            this.btnSavings.TabIndex = 4;
            this.btnSavings.Text = "SAVINGS";
            this.btnSavings.UseVisualStyleBackColor = true;
            this.btnSavings.Click += new System.EventHandler(this.btnSavings_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.Location = new System.Drawing.Point(142, 26);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(223, 70);
            this.btnIncome.TabIndex = 3;
            this.btnIncome.Text = "INCOME";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // pnlIncome
            // 
            this.pnlIncome.BackColor = System.Drawing.Color.White;
            this.pnlIncome.Controls.Add(this.lblBudgetDescription);
            this.pnlIncome.Controls.Add(this.lbl20Budget);
            this.pnlIncome.Controls.Add(this.txtUserIncome);
            this.pnlIncome.Controls.Add(this.lbl30Budget);
            this.pnlIncome.Controls.Add(this.lblIdealBudget);
            this.pnlIncome.Controls.Add(this.lbl50Budget);
            this.pnlIncome.Controls.Add(this.lblEnterIncome);
            this.pnlIncome.Controls.Add(this.lbl20);
            this.pnlIncome.Controls.Add(this.lbl50);
            this.pnlIncome.Controls.Add(this.lbl30);
            this.pnlIncome.Location = new System.Drawing.Point(131, 143);
            this.pnlIncome.Name = "pnlIncome";
            this.pnlIncome.Size = new System.Drawing.Size(487, 466);
            this.pnlIncome.TabIndex = 7;
            // 
            // lblBudgetDescription
            // 
            this.lblBudgetDescription.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetDescription.Location = new System.Drawing.Point(54, 334);
            this.lblBudgetDescription.Name = "lblBudgetDescription";
            this.lblBudgetDescription.Size = new System.Drawing.Size(379, 95);
            this.lblBudgetDescription.TabIndex = 17;
            this.lblBudgetDescription.Text = resources.GetString("lblBudgetDescription.Text");
            // 
            // lbl20Budget
            // 
            this.lbl20Budget.AutoSize = true;
            this.lbl20Budget.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20Budget.Location = new System.Drawing.Point(324, 226);
            this.lbl20Budget.Name = "lbl20Budget";
            this.lbl20Budget.Size = new System.Drawing.Size(0, 27);
            this.lbl20Budget.TabIndex = 16;
            // 
            // txtUserIncome
            // 
            this.txtUserIncome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserIncome.Location = new System.Drawing.Point(184, 54);
            this.txtUserIncome.Name = "txtUserIncome";
            this.txtUserIncome.Size = new System.Drawing.Size(201, 32);
            this.txtUserIncome.TabIndex = 9;
            this.txtUserIncome.TextChanged += new System.EventHandler(this.txtUserIncome_TextChanged);
            this.txtUserIncome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserIncome_KeyPress);
            // 
            // lbl30Budget
            // 
            this.lbl30Budget.AutoSize = true;
            this.lbl30Budget.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl30Budget.Location = new System.Drawing.Point(186, 226);
            this.lbl30Budget.Name = "lbl30Budget";
            this.lbl30Budget.Size = new System.Drawing.Size(0, 27);
            this.lbl30Budget.TabIndex = 15;
            // 
            // lblIdealBudget
            // 
            this.lblIdealBudget.AutoSize = true;
            this.lblIdealBudget.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdealBudget.Location = new System.Drawing.Point(88, 113);
            this.lblIdealBudget.Name = "lblIdealBudget";
            this.lblIdealBudget.Size = new System.Drawing.Size(303, 23);
            this.lblIdealBudget.TabIndex = 10;
            this.lblIdealBudget.Text = "Ideal Budget for your Income:";
            // 
            // lbl50Budget
            // 
            this.lbl50Budget.AutoSize = true;
            this.lbl50Budget.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl50Budget.Location = new System.Drawing.Point(41, 226);
            this.lbl50Budget.Name = "lbl50Budget";
            this.lbl50Budget.Size = new System.Drawing.Size(0, 27);
            this.lbl50Budget.TabIndex = 14;
            // 
            // lblEnterIncome
            // 
            this.lblEnterIncome.AutoSize = true;
            this.lblEnterIncome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterIncome.Location = new System.Drawing.Point(88, 57);
            this.lblEnterIncome.Name = "lblEnterIncome";
            this.lblEnterIncome.Size = new System.Drawing.Size(92, 23);
            this.lblEnterIncome.TabIndex = 8;
            this.lblEnterIncome.Text = "Income:";
            // 
            // lbl20
            // 
            this.lbl20.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20.Location = new System.Drawing.Point(324, 165);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(128, 23);
            this.lbl20.TabIndex = 13;
            this.lbl20.Text = "20% Savings";
            this.lbl20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl50
            // 
            this.lbl50.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl50.Location = new System.Drawing.Point(41, 165);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(126, 23);
            this.lbl50.TabIndex = 11;
            this.lbl50.Text = "50% Needs";
            this.lbl50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl30
            // 
            this.lbl30.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl30.Location = new System.Drawing.Point(186, 165);
            this.lbl30.Name = "lbl30";
            this.lbl30.Size = new System.Drawing.Size(116, 23);
            this.lbl30.TabIndex = 12;
            this.lbl30.Text = "30% Wants";
            this.lbl30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCashOut
            // 
            this.txtCashOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashOut.Location = new System.Drawing.Point(185, 108);
            this.txtCashOut.Name = "txtCashOut";
            this.txtCashOut.Size = new System.Drawing.Size(201, 32);
            this.txtCashOut.TabIndex = 21;
            this.txtCashOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashOut_KeyPress);
            // 
            // lblCashOut
            // 
            this.lblCashOut.AutoSize = true;
            this.lblCashOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashOut.Location = new System.Drawing.Point(72, 111);
            this.lblCashOut.Name = "lblCashOut";
            this.lblCashOut.Size = new System.Drawing.Size(107, 23);
            this.lblCashOut.TabIndex = 20;
            this.lblCashOut.Text = "Cash Out:";
            // 
            // txtCashIn
            // 
            this.txtCashIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashIn.Location = new System.Drawing.Point(185, 57);
            this.txtCashIn.Name = "txtCashIn";
            this.txtCashIn.Size = new System.Drawing.Size(201, 32);
            this.txtCashIn.TabIndex = 19;
            this.txtCashIn.TextChanged += new System.EventHandler(this.txtCashIn_TextChanged);
            this.txtCashIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashIn_KeyPress);
            // 
            // lblCashIn
            // 
            this.lblCashIn.AutoSize = true;
            this.lblCashIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashIn.Location = new System.Drawing.Point(89, 60);
            this.lblCashIn.Name = "lblCashIn";
            this.lblCashIn.Size = new System.Drawing.Size(90, 23);
            this.lblCashIn.TabIndex = 18;
            this.lblCashIn.Text = "Cash In:";
            // 
            // pnlSavings
            // 
            this.pnlSavings.BackColor = System.Drawing.Color.White;
            this.pnlSavings.Controls.Add(this.lblSavingsNote);
            this.pnlSavings.Controls.Add(this.lblBudgetforSavings);
            this.pnlSavings.Controls.Add(this.lblIdealSavings);
            this.pnlSavings.Controls.Add(this.txtDeposit);
            this.pnlSavings.Controls.Add(this.txtSavings);
            this.pnlSavings.Controls.Add(this.lblDeposit);
            this.pnlSavings.Controls.Add(this.lblSavings);
            this.pnlSavings.Location = new System.Drawing.Point(131, 140);
            this.pnlSavings.Name = "pnlSavings";
            this.pnlSavings.Size = new System.Drawing.Size(487, 466);
            this.pnlSavings.TabIndex = 18;
            this.pnlSavings.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSavings_Paint);
            // 
            // lblSavingsNote
            // 
            this.lblSavingsNote.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavingsNote.Location = new System.Drawing.Point(78, 316);
            this.lblSavingsNote.Name = "lblSavingsNote";
            this.lblSavingsNote.Size = new System.Drawing.Size(342, 95);
            this.lblSavingsNote.TabIndex = 22;
            this.lblSavingsNote.Text = "Note: Once you deposit in your savings, you cannot withdraw until the time limit." +
    "";
            // 
            // lblBudgetforSavings
            // 
            this.lblBudgetforSavings.AutoSize = true;
            this.lblBudgetforSavings.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetforSavings.Location = new System.Drawing.Point(188, 242);
            this.lblBudgetforSavings.Name = "lblBudgetforSavings";
            this.lblBudgetforSavings.Size = new System.Drawing.Size(0, 27);
            this.lblBudgetforSavings.TabIndex = 22;
            // 
            // lblIdealSavings
            // 
            this.lblIdealSavings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdealSavings.Location = new System.Drawing.Point(103, 175);
            this.lblIdealSavings.Name = "lblIdealSavings";
            this.lblIdealSavings.Size = new System.Drawing.Size(293, 23);
            this.lblIdealSavings.TabIndex = 22;
            this.lblIdealSavings.Text = "Ideal Amount for Savings:";
            this.lblIdealSavings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.Location = new System.Drawing.Point(195, 111);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(201, 32);
            this.txtDeposit.TabIndex = 23;
            this.txtDeposit.TextChanged += new System.EventHandler(this.txtCashInS_TextChanged);
            this.txtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashInS_KeyPress);
            // 
            // txtSavings
            // 
            this.txtSavings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSavings.Location = new System.Drawing.Point(195, 51);
            this.txtSavings.Name = "txtSavings";
            this.txtSavings.ReadOnly = true;
            this.txtSavings.Size = new System.Drawing.Size(201, 32);
            this.txtSavings.TabIndex = 9;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(99, 114);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(89, 23);
            this.lblDeposit.TabIndex = 22;
            this.lblDeposit.Text = "Deposit:";
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavings.Location = new System.Drawing.Point(99, 54);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(88, 23);
            this.lblSavings.TabIndex = 8;
            this.lblSavings.Text = "Savings:";
            // 
            // pnlCashInOut
            // 
            this.pnlCashInOut.BackColor = System.Drawing.Color.White;
            this.pnlCashInOut.Controls.Add(this.lblCashIn);
            this.pnlCashInOut.Controls.Add(this.txtCashOut);
            this.pnlCashInOut.Controls.Add(this.txtCashIn);
            this.pnlCashInOut.Controls.Add(this.lblCashOut);
            this.pnlCashInOut.Location = new System.Drawing.Point(131, 137);
            this.pnlCashInOut.Name = "pnlCashInOut";
            this.pnlCashInOut.Size = new System.Drawing.Size(487, 466);
            this.pnlCashInOut.TabIndex = 18;
            this.pnlCashInOut.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // IncomeExpenseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 753);
            this.Controls.Add(this.pnlCashInOut);
            this.Controls.Add(this.pnlSavings);
            this.Controls.Add(this.pnlIncome);
            this.Controls.Add(this.pnlFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IncomeExpenseUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncomeExpenseUI";
            this.Load += new System.EventHandler(this.IncomeExpenseUI_Load);
            this.pnlFooter.ResumeLayout(false);
            this.pnlIncome.ResumeLayout(false);
            this.pnlIncome.PerformLayout();
            this.pnlSavings.ResumeLayout(false);
            this.pnlSavings.PerformLayout();
            this.pnlCashInOut.ResumeLayout(false);
            this.pnlCashInOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSavings;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Panel pnlIncome;
        private System.Windows.Forms.Label lblEnterIncome;
        private System.Windows.Forms.TextBox txtUserIncome;
        private System.Windows.Forms.Label lblIdealBudget;
        private System.Windows.Forms.Label lbl20Budget;
        private System.Windows.Forms.Label lbl30Budget;
        private System.Windows.Forms.Label lbl50Budget;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lbl50;
        private System.Windows.Forms.Label lbl30;
        private System.Windows.Forms.Label lblBudgetDescription;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlSavings;
        private System.Windows.Forms.TextBox txtSavings;
        private System.Windows.Forms.Label lblSavings;
        private System.Windows.Forms.TextBox txtCashIn;
        private System.Windows.Forms.Label lblCashIn;
        private System.Windows.Forms.TextBox txtCashOut;
        private System.Windows.Forms.Label lblCashOut;
        private System.Windows.Forms.Label lblSavingsNote;
        private System.Windows.Forms.Label lblBudgetforSavings;
        private System.Windows.Forms.Label lblIdealSavings;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Panel pnlCashInOut;
        private System.Windows.Forms.Button btnCashInOut;
    }
}