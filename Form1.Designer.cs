namespace Conde_Activity10_SimpleApplication
{
    partial class Form1
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
            this.lblHello = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbFinancialManagement = new System.Windows.Forms.PictureBox();
            this.llblFinancialManagement = new System.Windows.Forms.LinkLabel();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.cbOccupation = new System.Windows.Forms.ComboBox();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pbUserPicture = new System.Windows.Forms.PictureBox();
            this.pnlBalanceGroup = new System.Windows.Forms.Panel();
            this.gbSavings = new System.Windows.Forms.GroupBox();
            this.lblExpense = new System.Windows.Forms.Label();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.gbIncome = new System.Windows.Forms.GroupBox();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinancialManagement)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).BeginInit();
            this.pnlBalanceGroup.SuspendLayout();
            this.gbSavings.SuspendLayout();
            this.gbIncome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(221, 35);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(255, 27);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Hello, Welcome Back";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(221, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(207, 34);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "<insert name>";
            // 
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.rbFemale);
            this.pnlProfile.Controls.Add(this.rbMale);
            this.pnlProfile.Controls.Add(this.btnBack);
            this.pnlProfile.Controls.Add(this.pbFinancialManagement);
            this.pnlProfile.Controls.Add(this.llblFinancialManagement);
            this.pnlProfile.Controls.Add(this.txtAge);
            this.pnlProfile.Controls.Add(this.lblAge);
            this.pnlProfile.Controls.Add(this.txtName);
            this.pnlProfile.Controls.Add(this.lblProfileName);
            this.pnlProfile.Controls.Add(this.cbOccupation);
            this.pnlProfile.Controls.Add(this.lblOccupation);
            this.pnlProfile.Controls.Add(this.lblGender);
            this.pnlProfile.Location = new System.Drawing.Point(0, 114);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(745, 641);
            this.pnlProfile.TabIndex = 6;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(227, 149);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(80, 27);
            this.rbMale.TabIndex = 11;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(13, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 70);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbFinancialManagement
            // 
            this.pbFinancialManagement.Image = global::Conde_Activity10_SimpleApplication.Properties.Resources.Profile_PNG;
            this.pbFinancialManagement.Location = new System.Drawing.Point(135, 268);
            this.pbFinancialManagement.Name = "pbFinancialManagement";
            this.pbFinancialManagement.Size = new System.Drawing.Size(508, 243);
            this.pbFinancialManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFinancialManagement.TabIndex = 9;
            this.pbFinancialManagement.TabStop = false;
            // 
            // llblFinancialManagement
            // 
            this.llblFinancialManagement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblFinancialManagement.Location = new System.Drawing.Point(135, 527);
            this.llblFinancialManagement.Name = "llblFinancialManagement";
            this.llblFinancialManagement.Size = new System.Drawing.Size(508, 23);
            this.llblFinancialManagement.TabIndex = 8;
            this.llblFinancialManagement.TabStop = true;
            this.llblFinancialManagement.Text = "Learn the importance of Financial Management";
            this.llblFinancialManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llblFinancialManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblFinancialManagement_LinkClicked);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(567, 45);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(76, 32);
            this.txtAge.TabIndex = 7;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(504, 48);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(57, 23);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(213, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 32);
            this.txtName.TabIndex = 5;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileName.Location = new System.Drawing.Point(131, 50);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(76, 23);
            this.lblProfileName.TabIndex = 4;
            this.lblProfileName.Text = "Name:";
            // 
            // cbOccupation
            // 
            this.cbOccupation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOccupation.FormattingEnabled = true;
            this.cbOccupation.Items.AddRange(new object[] {
            "Student",
            "Working"});
            this.cbOccupation.Location = new System.Drawing.Point(270, 97);
            this.cbOccupation.Name = "cbOccupation";
            this.cbOccupation.Size = new System.Drawing.Size(216, 31);
            this.cbOccupation.TabIndex = 3;
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupation.Location = new System.Drawing.Point(131, 100);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(133, 23);
            this.lblOccupation.TabIndex = 2;
            this.lblOccupation.Text = "Occupation:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(131, 151);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(90, 23);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Gender:";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackgroundImage = global::Conde_Activity10_SimpleApplication.Properties.Resources.Random_Backgrounds;
            this.pnlFooter.Controls.Add(this.btnProfile);
            this.pnlFooter.Controls.Add(this.btnEdit);
            this.pnlFooter.Location = new System.Drawing.Point(-3, 594);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(748, 164);
            this.pnlFooter.TabIndex = 5;
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(390, 43);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(223, 70);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(142, 43);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(223, 70);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "CASH/IN";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // pbUserPicture
            // 
            this.pbUserPicture.Image = global::Conde_Activity10_SimpleApplication.Properties.Resources.Person_Icon;
            this.pbUserPicture.Location = new System.Drawing.Point(137, 35);
            this.pbUserPicture.Name = "pbUserPicture";
            this.pbUserPicture.Size = new System.Drawing.Size(70, 70);
            this.pbUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserPicture.TabIndex = 4;
            this.pbUserPicture.TabStop = false;
            // 
            // pnlBalanceGroup
            // 
            this.pnlBalanceGroup.BackgroundImage = global::Conde_Activity10_SimpleApplication.Properties.Resources.Random_Backgrounds;
            this.pnlBalanceGroup.Controls.Add(this.gbSavings);
            this.pnlBalanceGroup.Controls.Add(this.lblTotalBalance);
            this.pnlBalanceGroup.Controls.Add(this.gbIncome);
            this.pnlBalanceGroup.Controls.Add(this.lblBalance);
            this.pnlBalanceGroup.Location = new System.Drawing.Point(73, 187);
            this.pnlBalanceGroup.Name = "pnlBalanceGroup";
            this.pnlBalanceGroup.Size = new System.Drawing.Size(603, 323);
            this.pnlBalanceGroup.TabIndex = 1;
            // 
            // gbSavings
            // 
            this.gbSavings.Controls.Add(this.lblExpense);
            this.gbSavings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSavings.Location = new System.Drawing.Point(312, 157);
            this.gbSavings.Name = "gbSavings";
            this.gbSavings.Size = new System.Drawing.Size(225, 100);
            this.gbSavings.TabIndex = 7;
            this.gbSavings.TabStop = false;
            this.gbSavings.Text = "SAVINGS";
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.Location = new System.Drawing.Point(33, 43);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(119, 23);
            this.lblExpense.TabIndex = 12;
            this.lblExpense.Text = "<balance>";
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBalance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalance.ForeColor = System.Drawing.Color.White;
            this.lblTotalBalance.Location = new System.Drawing.Point(0, 35);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(603, 27);
            this.lblTotalBalance.TabIndex = 3;
            this.lblTotalBalance.Text = "TOTAL BALANCE";
            this.lblTotalBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbIncome
            // 
            this.gbIncome.Controls.Add(this.lblIncome);
            this.gbIncome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIncome.Location = new System.Drawing.Point(64, 157);
            this.gbIncome.Name = "gbIncome";
            this.gbIncome.Size = new System.Drawing.Size(225, 100);
            this.gbIncome.TabIndex = 6;
            this.gbIncome.TabStop = false;
            this.gbIncome.Text = "INCOME";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.Location = new System.Drawing.Point(33, 43);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(119, 23);
            this.lblIncome.TabIndex = 9;
            this.lblIncome.Text = "<balance>";
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(180, 84);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(269, 37);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "<balance>";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(313, 149);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(105, 27);
            this.rbFemale.TabIndex = 12;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 753);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pbUserPicture);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlBalanceGroup);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.pnlProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinancialManagement)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).EndInit();
            this.pnlBalanceGroup.ResumeLayout(false);
            this.gbSavings.ResumeLayout(false);
            this.gbSavings.PerformLayout();
            this.gbIncome.ResumeLayout(false);
            this.gbIncome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Panel pnlBalanceGroup;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbIncome;
        private System.Windows.Forms.GroupBox gbSavings;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox pbUserPicture;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.ComboBox cbOccupation;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.LinkLabel llblFinancialManagement;
        private System.Windows.Forms.PictureBox pbFinancialManagement;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
    }
}

