namespace Actemium.WiSSWizard.Pages
{
    partial class ModifyUser
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyUser));
      this.cbAccountDisabled = new System.Windows.Forms.CheckBox();
      this.cbPaswordNeverExpires = new System.Windows.Forms.CheckBox();
      this.cbPaswordCantBeChanged = new System.Windows.Forms.CheckBox();
      this.cbChangePwNextLogon = new System.Windows.Forms.CheckBox();
      this.tbNewPasword2 = new System.Windows.Forms.TextBox();
      this.label31 = new System.Windows.Forms.Label();
      this.tbNewPasword1 = new System.Windows.Forms.TextBox();
      this.label30 = new System.Windows.Forms.Label();
      this.tbUserDescription = new System.Windows.Forms.TextBox();
      this.label29 = new System.Windows.Forms.Label();
      this.tbUserFullName = new System.Windows.Forms.TextBox();
      this.label28 = new System.Windows.Forms.Label();
      this.lbUserName = new System.Windows.Forms.Label();
      this.btModifyUser = new System.Windows.Forms.Button();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.gbSettings = new System.Windows.Forms.GroupBox();
      this.cbMakeOtherSettings = new System.Windows.Forms.CheckBox();
      this.chkListBChangeGroups = new System.Windows.Forms.CheckedListBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.gbSettings.SuspendLayout();
      this.SuspendLayout();
      // 
      // cbAccountDisabled
      // 
      this.cbAccountDisabled.AutoSize = true;
      this.cbAccountDisabled.Location = new System.Drawing.Point(6, 83);
      this.cbAccountDisabled.Name = "cbAccountDisabled";
      this.cbAccountDisabled.Size = new System.Drawing.Size(135, 17);
      this.cbAccountDisabled.TabIndex = 60;
      this.cbAccountDisabled.Text = "Account is deactivated";
      this.cbAccountDisabled.UseVisualStyleBackColor = true;
      // 
      // cbPaswordNeverExpires
      // 
      this.cbPaswordNeverExpires.AutoSize = true;
      this.cbPaswordNeverExpires.Location = new System.Drawing.Point(6, 62);
      this.cbPaswordNeverExpires.Name = "cbPaswordNeverExpires";
      this.cbPaswordNeverExpires.Size = new System.Drawing.Size(133, 17);
      this.cbPaswordNeverExpires.TabIndex = 59;
      this.cbPaswordNeverExpires.Text = "Password never expire";
      this.cbPaswordNeverExpires.UseVisualStyleBackColor = true;
      this.cbPaswordNeverExpires.CheckedChanged += new System.EventHandler(this.cbPaswordNeverExpires_CheckedChanged);
      // 
      // cbPaswordCantBeChanged
      // 
      this.cbPaswordCantBeChanged.AutoSize = true;
      this.cbPaswordCantBeChanged.Location = new System.Drawing.Point(6, 39);
      this.cbPaswordCantBeChanged.Name = "cbPaswordCantBeChanged";
      this.cbPaswordCantBeChanged.Size = new System.Drawing.Size(179, 17);
      this.cbPaswordCantBeChanged.TabIndex = 58;
      this.cbPaswordCantBeChanged.Text = "User can\'t change the password";
      this.cbPaswordCantBeChanged.UseVisualStyleBackColor = true;
      this.cbPaswordCantBeChanged.CheckedChanged += new System.EventHandler(this.cbPaswordCantBeChanged_CheckedChanged);
      // 
      // cbChangePwNextLogon
      // 
      this.cbChangePwNextLogon.AutoSize = true;
      this.cbChangePwNextLogon.Location = new System.Drawing.Point(6, 19);
      this.cbChangePwNextLogon.Name = "cbChangePwNextLogon";
      this.cbChangePwNextLogon.Size = new System.Drawing.Size(212, 17);
      this.cbChangePwNextLogon.TabIndex = 57;
      this.cbChangePwNextLogon.Text = "User must change password next logon";
      this.cbChangePwNextLogon.UseVisualStyleBackColor = true;
      this.cbChangePwNextLogon.CheckedChanged += new System.EventHandler(this.cbChangePwNextLogon_CheckedChanged);
      // 
      // tbNewPasword2
      // 
      this.tbNewPasword2.Location = new System.Drawing.Point(131, 99);
      this.tbNewPasword2.Name = "tbNewPasword2";
      this.tbNewPasword2.PasswordChar = '*';
      this.tbNewPasword2.Size = new System.Drawing.Size(88, 20);
      this.tbNewPasword2.TabIndex = 56;
      // 
      // label31
      // 
      this.label31.AutoSize = true;
      this.label31.Location = new System.Drawing.Point(11, 104);
      this.label31.Name = "label31";
      this.label31.Size = new System.Drawing.Size(119, 13);
      this.label31.TabIndex = 55;
      this.label31.Text = "Confirm new password: ";
      // 
      // tbNewPasword1
      // 
      this.tbNewPasword1.Location = new System.Drawing.Point(131, 77);
      this.tbNewPasword1.Name = "tbNewPasword1";
      this.tbNewPasword1.PasswordChar = '*';
      this.tbNewPasword1.Size = new System.Drawing.Size(88, 20);
      this.tbNewPasword1.TabIndex = 54;
      // 
      // label30
      // 
      this.label30.AutoSize = true;
      this.label30.Location = new System.Drawing.Point(11, 83);
      this.label30.Name = "label30";
      this.label30.Size = new System.Drawing.Size(83, 13);
      this.label30.TabIndex = 53;
      this.label30.Text = "New password: ";
      // 
      // tbUserDescription
      // 
      this.tbUserDescription.Location = new System.Drawing.Point(104, 55);
      this.tbUserDescription.Name = "tbUserDescription";
      this.tbUserDescription.Size = new System.Drawing.Size(115, 20);
      this.tbUserDescription.TabIndex = 52;
      // 
      // label29
      // 
      this.label29.AutoSize = true;
      this.label29.Location = new System.Drawing.Point(12, 59);
      this.label29.Name = "label29";
      this.label29.Size = new System.Drawing.Size(66, 13);
      this.label29.TabIndex = 51;
      this.label29.Text = "Description: ";
      // 
      // tbUserFullName
      // 
      this.tbUserFullName.Location = new System.Drawing.Point(104, 33);
      this.tbUserFullName.Name = "tbUserFullName";
      this.tbUserFullName.Size = new System.Drawing.Size(115, 20);
      this.tbUserFullName.TabIndex = 50;
      // 
      // label28
      // 
      this.label28.AutoSize = true;
      this.label28.Location = new System.Drawing.Point(11, 38);
      this.label28.Name = "label28";
      this.label28.Size = new System.Drawing.Size(58, 13);
      this.label28.TabIndex = 49;
      this.label28.Text = "Full name: ";
      // 
      // lbUserName
      // 
      this.lbUserName.AutoSize = true;
      this.lbUserName.Location = new System.Drawing.Point(11, 16);
      this.lbUserName.Name = "lbUserName";
      this.lbUserName.Size = new System.Drawing.Size(61, 13);
      this.lbUserName.TabIndex = 47;
      this.lbUserName.Text = "Username: ";
      // 
      // btModifyUser
      // 
      this.btModifyUser.BackColor = System.Drawing.SystemColors.Control;
      this.btModifyUser.Location = new System.Drawing.Point(267, 228);
      this.btModifyUser.Name = "btModifyUser";
      this.btModifyUser.Size = new System.Drawing.Size(75, 23);
      this.btModifyUser.TabIndex = 63;
      this.btModifyUser.Text = "Save";
      this.btModifyUser.UseVisualStyleBackColor = false;
      this.btModifyUser.Click += new System.EventHandler(this.btModifyUser_Click);
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // gbSettings
      // 
      this.gbSettings.Controls.Add(this.cbChangePwNextLogon);
      this.gbSettings.Controls.Add(this.cbPaswordCantBeChanged);
      this.gbSettings.Controls.Add(this.cbPaswordNeverExpires);
      this.gbSettings.Controls.Add(this.cbAccountDisabled);
      this.gbSettings.Enabled = false;
      this.gbSettings.Location = new System.Drawing.Point(1, 144);
      this.gbSettings.Name = "gbSettings";
      this.gbSettings.Size = new System.Drawing.Size(220, 107);
      this.gbSettings.TabIndex = 66;
      this.gbSettings.TabStop = false;
      this.gbSettings.Text = "Other settings: ";
      // 
      // cbMakeOtherSettings
      // 
      this.cbMakeOtherSettings.AutoSize = true;
      this.cbMakeOtherSettings.Location = new System.Drawing.Point(1, 125);
      this.cbMakeOtherSettings.Name = "cbMakeOtherSettings";
      this.cbMakeOtherSettings.Size = new System.Drawing.Size(129, 17);
      this.cbMakeOtherSettings.TabIndex = 61;
      this.cbMakeOtherSettings.Text = "Change other settings";
      this.cbMakeOtherSettings.UseVisualStyleBackColor = true;
      this.cbMakeOtherSettings.CheckedChanged += new System.EventHandler(this.cbMakeOtherSettings_CheckedChanged);
      // 
      // chkListBChangeGroups
      // 
      this.chkListBChangeGroups.FormattingEnabled = true;
      this.chkListBChangeGroups.Location = new System.Drawing.Point(225, 12);
      this.chkListBChangeGroups.Name = "chkListBChangeGroups";
      this.chkListBChangeGroups.Size = new System.Drawing.Size(153, 214);
      this.chkListBChangeGroups.TabIndex = 67;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(185, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 13);
      this.label1.TabIndex = 68;
      this.label1.Text = "Group:";
      // 
      // ModifyUser
      // 
      this.AcceptButton = this.btModifyUser;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(385, 258);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.chkListBChangeGroups);
      this.Controls.Add(this.cbMakeOtherSettings);
      this.Controls.Add(this.gbSettings);
      this.Controls.Add(this.btModifyUser);
      this.Controls.Add(this.tbNewPasword2);
      this.Controls.Add(this.label31);
      this.Controls.Add(this.tbNewPasword1);
      this.Controls.Add(this.label30);
      this.Controls.Add(this.tbUserDescription);
      this.Controls.Add(this.label29);
      this.Controls.Add(this.tbUserFullName);
      this.Controls.Add(this.label28);
      this.Controls.Add(this.lbUserName);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(393, 291);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(393, 291);
      this.Name = "ModifyUser";
      this.Text = "Customize users";
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.gbSettings.ResumeLayout(false);
      this.gbSettings.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbAccountDisabled;
        private System.Windows.Forms.CheckBox cbPaswordNeverExpires;
        private System.Windows.Forms.CheckBox cbPaswordCantBeChanged;
        private System.Windows.Forms.CheckBox cbChangePwNextLogon;
        private System.Windows.Forms.TextBox tbNewPasword2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tbNewPasword1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbUserDescription;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbUserFullName;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btModifyUser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox cbMakeOtherSettings;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkListBChangeGroups;
        

    }
}