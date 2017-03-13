namespace Actemium.WiSSWizard.Pages
{
    partial class Wireless
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wireless));
      this.lbNetworkName = new System.Windows.Forms.Label();
      this.tbWirelessName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.cboSecurityType = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.cboEncrypType = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tbSecurityKey = new System.Windows.Forms.TextBox();
      this.cbHideCharacters = new System.Windows.Forms.CheckBox();
      this.cbStartWirelessAuto = new System.Windows.Forms.CheckBox();
      this.cbConnectWirelessNotBroad = new System.Windows.Forms.CheckBox();
      this.label5 = new System.Windows.Forms.Label();
      this.btOKWireless = new System.Windows.Forms.Button();
      this.btCancelWireless = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lbNetworkName
      // 
      this.lbNetworkName.AutoSize = true;
      this.lbNetworkName.Location = new System.Drawing.Point(12, 28);
      this.lbNetworkName.Name = "lbNetworkName";
      this.lbNetworkName.Size = new System.Drawing.Size(81, 13);
      this.lbNetworkName.TabIndex = 0;
      this.lbNetworkName.Text = "Network Name:";
      // 
      // tbWirelessName
      // 
      this.tbWirelessName.Location = new System.Drawing.Point(123, 25);
      this.tbWirelessName.Name = "tbWirelessName";
      this.tbWirelessName.Size = new System.Drawing.Size(149, 20);
      this.tbWirelessName.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 66);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(75, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Security Type:";
      // 
      // cboSecurityType
      // 
      this.cboSecurityType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cboSecurityType.FormattingEnabled = true;
      this.cboSecurityType.Items.AddRange(new object[] {
            "No Authentication (Open)",
            "WEP",
            "WPA2-Personal",
            "WPA-Personal",
            "WPA2-Enterprise",
            "WPA-Enterprise",
            "802.1x"});
      this.cboSecurityType.Location = new System.Drawing.Point(123, 63);
      this.cboSecurityType.Name = "cboSecurityType";
      this.cboSecurityType.Size = new System.Drawing.Size(149, 21);
      this.cboSecurityType.TabIndex = 3;
      this.cboSecurityType.Text = "[Choose an option]";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 105);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(87, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Encryption Type:";
      // 
      // cboEncrypType
      // 
      this.cboEncrypType.FormattingEnabled = true;
      this.cboEncrypType.Items.AddRange(new object[] {
            "TKIP",
            "AES"});
      this.cboEncrypType.Location = new System.Drawing.Point(123, 102);
      this.cboEncrypType.Name = "cboEncrypType";
      this.cboEncrypType.Size = new System.Drawing.Size(149, 21);
      this.cboEncrypType.TabIndex = 5;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 153);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(69, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Security Key:";
      // 
      // tbSecurityKey
      // 
      this.tbSecurityKey.Location = new System.Drawing.Point(123, 150);
      this.tbSecurityKey.Name = "tbSecurityKey";
      this.tbSecurityKey.Size = new System.Drawing.Size(149, 20);
      this.tbSecurityKey.TabIndex = 7;
      // 
      // cbHideCharacters
      // 
      this.cbHideCharacters.AutoSize = true;
      this.cbHideCharacters.Location = new System.Drawing.Point(278, 152);
      this.cbHideCharacters.Name = "cbHideCharacters";
      this.cbHideCharacters.Size = new System.Drawing.Size(102, 17);
      this.cbHideCharacters.TabIndex = 8;
      this.cbHideCharacters.Text = "Hide Characters";
      this.cbHideCharacters.UseVisualStyleBackColor = true;
      // 
      // cbStartWirelessAuto
      // 
      this.cbStartWirelessAuto.AutoSize = true;
      this.cbStartWirelessAuto.Location = new System.Drawing.Point(34, 193);
      this.cbStartWirelessAuto.Name = "cbStartWirelessAuto";
      this.cbStartWirelessAuto.Size = new System.Drawing.Size(187, 17);
      this.cbStartWirelessAuto.TabIndex = 9;
      this.cbStartWirelessAuto.Text = "Start this connection automatically";
      this.cbStartWirelessAuto.UseVisualStyleBackColor = true;
      // 
      // cbConnectWirelessNotBroad
      // 
      this.cbConnectWirelessNotBroad.AutoSize = true;
      this.cbConnectWirelessNotBroad.Location = new System.Drawing.Point(34, 216);
      this.cbConnectWirelessNotBroad.Name = "cbConnectWirelessNotBroad";
      this.cbConnectWirelessNotBroad.Size = new System.Drawing.Size(252, 17);
      this.cbConnectWirelessNotBroad.TabIndex = 10;
      this.cbConnectWirelessNotBroad.Text = "Connect even if the network is not broadcasting";
      this.cbConnectWirelessNotBroad.UseVisualStyleBackColor = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(42, 236);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(349, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Warning: If you select this option, your computer\'s privacymight be at risk";
      // 
      // btOKWireless
      // 
      this.btOKWireless.Location = new System.Drawing.Point(316, 23);
      this.btOKWireless.Name = "btOKWireless";
      this.btOKWireless.Size = new System.Drawing.Size(75, 23);
      this.btOKWireless.TabIndex = 12;
      this.btOKWireless.Text = "OK";
      this.btOKWireless.UseVisualStyleBackColor = true;
      // 
      // btCancelWireless
      // 
      this.btCancelWireless.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btCancelWireless.Location = new System.Drawing.Point(316, 56);
      this.btCancelWireless.Name = "btCancelWireless";
      this.btCancelWireless.Size = new System.Drawing.Size(75, 23);
      this.btCancelWireless.TabIndex = 13;
      this.btCancelWireless.Text = "Cancel";
      this.btCancelWireless.UseVisualStyleBackColor = true;
      // 
      // Wireless
      // 
      this.AcceptButton = this.btOKWireless;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGray;
      this.CancelButton = this.btCancelWireless;
      this.ClientSize = new System.Drawing.Size(403, 282);
      this.Controls.Add(this.btCancelWireless);
      this.Controls.Add(this.btOKWireless);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.cbConnectWirelessNotBroad);
      this.Controls.Add(this.cbStartWirelessAuto);
      this.Controls.Add(this.cbHideCharacters);
      this.Controls.Add(this.tbSecurityKey);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.cboEncrypType);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.cboSecurityType);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbWirelessName);
      this.Controls.Add(this.lbNetworkName);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(411, 314);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(411, 314);
      this.Name = "Wireless";
      this.Text = "Add a wireless network";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNetworkName;
        private System.Windows.Forms.TextBox tbWirelessName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSecurityType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEncrypType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSecurityKey;
        private System.Windows.Forms.CheckBox cbHideCharacters;
        private System.Windows.Forms.CheckBox cbStartWirelessAuto;
        private System.Windows.Forms.CheckBox cbConnectWirelessNotBroad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btOKWireless;
        private System.Windows.Forms.Button btCancelWireless;
    }
}