namespace Actemium.WiSSWizard.Pages
{
    partial class AddOrModifySqlServerUser
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrModifySqlServerUser));
      this.label1 = new System.Windows.Forms.Label();
      this.rbSQLAddUserWAM = new System.Windows.Forms.RadioButton();
      this.rbSQLAddSqlUser = new System.Windows.Forms.RadioButton();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.chkListbSQLRoleSelect = new System.Windows.Forms.CheckedListBox();
      this.lvUsers = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.btSqlAddUser = new System.Windows.Forms.Button();
      this.gbSQLServerAddUser = new System.Windows.Forms.GroupBox();
      this.cbSavePwToLog = new System.Windows.Forms.CheckBox();
      this.cbRandomPw = new System.Windows.Forms.CheckBox();
      this.tbConfirmPw = new System.Windows.Forms.TextBox();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.tbUsername = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.gbSQLServerAddUser.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(184, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Choose type of user you wish to add: ";
      // 
      // rbSQLAddUserWAM
      // 
      this.rbSQLAddUserWAM.AutoSize = true;
      this.rbSQLAddUserWAM.Location = new System.Drawing.Point(24, 50);
      this.rbSQLAddUserWAM.Name = "rbSQLAddUserWAM";
      this.rbSQLAddUserWAM.Size = new System.Drawing.Size(170, 17);
      this.rbSQLAddUserWAM.TabIndex = 1;
      this.rbSQLAddUserWAM.Text = "Windows Authentication Mode";
      this.rbSQLAddUserWAM.UseVisualStyleBackColor = true;
      // 
      // rbSQLAddSqlUser
      // 
      this.rbSQLAddSqlUser.AutoSize = true;
      this.rbSQLAddSqlUser.Checked = true;
      this.rbSQLAddSqlUser.Location = new System.Drawing.Point(24, 73);
      this.rbSQLAddSqlUser.Name = "rbSQLAddSqlUser";
      this.rbSQLAddSqlUser.Size = new System.Drawing.Size(71, 17);
      this.rbSQLAddSqlUser.TabIndex = 2;
      this.rbSQLAddSqlUser.TabStop = true;
      this.rbSQLAddSqlUser.Text = "SQL User";
      this.rbSQLAddSqlUser.UseVisualStyleBackColor = true;
      this.rbSQLAddSqlUser.CheckedChanged += new System.EventHandler(this.rbSQLAddSqlUser_CheckedChanged);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.chkListbSQLRoleSelect);
      this.groupBox1.Location = new System.Drawing.Point(24, 212);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(156, 101);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Select roles :";
      // 
      // chkListbSQLRoleSelect
      // 
      this.chkListbSQLRoleSelect.FormattingEnabled = true;
      this.chkListbSQLRoleSelect.Items.AddRange(new object[] {
            "bulkadmin",
            "dacreator",
            "diskadmin",
            "processadmin",
            "public",
            "securityadmin",
            "serveradmin",
            "setupadmin",
            "sysadmin"});
      this.chkListbSQLRoleSelect.Location = new System.Drawing.Point(6, 16);
      this.chkListbSQLRoleSelect.Name = "chkListbSQLRoleSelect";
      this.chkListbSQLRoleSelect.Size = new System.Drawing.Size(143, 79);
      this.chkListbSQLRoleSelect.TabIndex = 2;
      // 
      // lvUsers
      // 
      this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
      this.lvUsers.FullRowSelect = true;
      this.lvUsers.GridLines = true;
      this.lvUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lvUsers.Location = new System.Drawing.Point(24, 96);
      this.lvUsers.Name = "lvUsers";
      this.lvUsers.Size = new System.Drawing.Size(326, 110);
      this.lvUsers.TabIndex = 29;
      this.lvUsers.UseCompatibleStateImageBehavior = false;
      this.lvUsers.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Name";
      this.columnHeader1.Width = 92;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Fullname";
      this.columnHeader2.Width = 105;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Description";
      this.columnHeader3.Width = 210;
      // 
      // btSqlAddUser
      // 
      this.btSqlAddUser.Location = new System.Drawing.Point(275, 284);
      this.btSqlAddUser.Name = "btSqlAddUser";
      this.btSqlAddUser.Size = new System.Drawing.Size(75, 23);
      this.btSqlAddUser.TabIndex = 30;
      this.btSqlAddUser.Text = "Add";
      this.btSqlAddUser.UseVisualStyleBackColor = true;
      // 
      // gbSQLServerAddUser
      // 
      this.gbSQLServerAddUser.Controls.Add(this.cbSavePwToLog);
      this.gbSQLServerAddUser.Controls.Add(this.cbRandomPw);
      this.gbSQLServerAddUser.Controls.Add(this.tbConfirmPw);
      this.gbSQLServerAddUser.Controls.Add(this.tbPassword);
      this.gbSQLServerAddUser.Controls.Add(this.tbUsername);
      this.gbSQLServerAddUser.Controls.Add(this.label4);
      this.gbSQLServerAddUser.Controls.Add(this.label3);
      this.gbSQLServerAddUser.Controls.Add(this.label2);
      this.gbSQLServerAddUser.Location = new System.Drawing.Point(24, 96);
      this.gbSQLServerAddUser.Name = "gbSQLServerAddUser";
      this.gbSQLServerAddUser.Size = new System.Drawing.Size(312, 93);
      this.gbSQLServerAddUser.TabIndex = 31;
      this.gbSQLServerAddUser.TabStop = false;
      this.gbSQLServerAddUser.Text = "SQL Server User";
      // 
      // cbSavePwToLog
      // 
      this.cbSavePwToLog.AutoSize = true;
      this.cbSavePwToLog.Location = new System.Drawing.Point(192, 66);
      this.cbSavePwToLog.Name = "cbSavePwToLog";
      this.cbSavePwToLog.Size = new System.Drawing.Size(97, 17);
      this.cbSavePwToLog.TabIndex = 7;
      this.cbSavePwToLog.Text = "Save pw to log";
      this.cbSavePwToLog.UseVisualStyleBackColor = true;
      this.cbSavePwToLog.CheckedChanged += new System.EventHandler(this.cbSavePwToLog_CheckedChanged);
      // 
      // cbRandomPw
      // 
      this.cbRandomPw.AutoSize = true;
      this.cbRandomPw.Location = new System.Drawing.Point(192, 39);
      this.cbRandomPw.Name = "cbRandomPw";
      this.cbRandomPw.Size = new System.Drawing.Size(114, 17);
      this.cbRandomPw.TabIndex = 6;
      this.cbRandomPw.Text = "Random password";
      this.cbRandomPw.UseVisualStyleBackColor = true;
      this.cbRandomPw.CheckedChanged += new System.EventHandler(this.cbRandomPw_CheckedChanged);
      // 
      // tbConfirmPw
      // 
      this.tbConfirmPw.Location = new System.Drawing.Point(81, 67);
      this.tbConfirmPw.Name = "tbConfirmPw";
      this.tbConfirmPw.Size = new System.Drawing.Size(100, 20);
      this.tbConfirmPw.TabIndex = 5;
      // 
      // tbPassword
      // 
      this.tbPassword.Location = new System.Drawing.Point(81, 41);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.Size = new System.Drawing.Size(100, 20);
      this.tbPassword.TabIndex = 4;
      // 
      // tbUsername
      // 
      this.tbUsername.Location = new System.Drawing.Point(81, 15);
      this.tbUsername.Name = "tbUsername";
      this.tbUsername.Size = new System.Drawing.Size(100, 20);
      this.tbUsername.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(9, 70);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(62, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "Confirm pw:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(15, 43);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(56, 13);
      this.label3.TabIndex = 1;
      this.label3.Text = "Password:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 18);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(58, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Username:";
      // 
      // AddOrModifySqlServerUser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGray;
      this.ClientSize = new System.Drawing.Size(370, 322);
      this.Controls.Add(this.gbSQLServerAddUser);
      this.Controls.Add(this.btSqlAddUser);
      this.Controls.Add(this.lvUsers);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.rbSQLAddSqlUser);
      this.Controls.Add(this.rbSQLAddUserWAM);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(378, 355);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(378, 355);
      this.Name = "AddOrModifySqlServerUser";
      this.Text = "Add Or Modify Sql Server User";
      this.groupBox1.ResumeLayout(false);
      this.gbSQLServerAddUser.ResumeLayout(false);
      this.gbSQLServerAddUser.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSQLAddUserWAM;
        private System.Windows.Forms.RadioButton rbSQLAddSqlUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btSqlAddUser;
        private System.Windows.Forms.GroupBox gbSQLServerAddUser;
        private System.Windows.Forms.CheckBox cbSavePwToLog;
        private System.Windows.Forms.CheckBox cbRandomPw;
        private System.Windows.Forms.TextBox tbConfirmPw;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chkListbSQLRoleSelect;
    }
}