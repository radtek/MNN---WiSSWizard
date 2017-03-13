namespace Actemium.WiSSWizard.Pages
{
    partial class AddWebServer
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWebServer));
      this.lbLocation = new System.Windows.Forms.Label();
      this.lbSiteName = new System.Windows.Forms.Label();
      this.tbSiteName = new System.Windows.Forms.TextBox();
      this.tbLocation = new System.Windows.Forms.TextBox();
      this.btBrowseDirectory = new System.Windows.Forms.Button();
      this.btOK = new System.Windows.Forms.Button();
      this.btCancel = new System.Windows.Forms.Button();
      this.lbProtocol = new System.Windows.Forms.Label();
      this.tbPort = new System.Windows.Forms.TextBox();
      this.lbPort = new System.Windows.Forms.Label();
      this.tbIpAddress = new System.Windows.Forms.TextBox();
      this.lbIpAddress = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.tbApplicationPool = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lbExample = new System.Windows.Forms.Label();
      this.cbProtocolType = new System.Windows.Forms.ComboBox();
      this.tbHostname = new System.Windows.Forms.TextBox();
      this.lbHostname = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lbLocation
      // 
      this.lbLocation.AutoSize = true;
      this.lbLocation.Location = new System.Drawing.Point(15, 37);
      this.lbLocation.Name = "lbLocation";
      this.lbLocation.Size = new System.Drawing.Size(74, 13);
      this.lbLocation.TabIndex = 0;
      this.lbLocation.Text = "Physical Path:";
      // 
      // lbSiteName
      // 
      this.lbSiteName.AutoSize = true;
      this.lbSiteName.Location = new System.Drawing.Point(15, 11);
      this.lbSiteName.Name = "lbSiteName";
      this.lbSiteName.Size = new System.Drawing.Size(56, 13);
      this.lbSiteName.TabIndex = 1;
      this.lbSiteName.Text = "SiteName:";
      // 
      // tbSiteName
      // 
      this.tbSiteName.Location = new System.Drawing.Point(95, 6);
      this.tbSiteName.Name = "tbSiteName";
      this.tbSiteName.Size = new System.Drawing.Size(127, 20);
      this.tbSiteName.TabIndex = 2;
      // 
      // tbLocation
      // 
      this.tbLocation.Location = new System.Drawing.Point(95, 32);
      this.tbLocation.Name = "tbLocation";
      this.tbLocation.Size = new System.Drawing.Size(127, 20);
      this.tbLocation.TabIndex = 3;
      // 
      // btBrowseDirectory
      // 
      this.btBrowseDirectory.Location = new System.Drawing.Point(228, 30);
      this.btBrowseDirectory.Name = "btBrowseDirectory";
      this.btBrowseDirectory.Size = new System.Drawing.Size(67, 23);
      this.btBrowseDirectory.TabIndex = 4;
      this.btBrowseDirectory.Text = "Browse";
      this.btBrowseDirectory.UseVisualStyleBackColor = true;
      this.btBrowseDirectory.Click += new System.EventHandler(this.btBrowseDirectory_Click);
      // 
      // btOK
      // 
      this.btOK.Location = new System.Drawing.Point(187, 233);
      this.btOK.Name = "btOK";
      this.btOK.Size = new System.Drawing.Size(50, 23);
      this.btOK.TabIndex = 5;
      this.btOK.Text = "Save";
      this.btOK.UseVisualStyleBackColor = true;
      this.btOK.Click += new System.EventHandler(this.btOK_Click);
      // 
      // btCancel
      // 
      this.btCancel.Location = new System.Drawing.Point(243, 233);
      this.btCancel.Name = "btCancel";
      this.btCancel.Size = new System.Drawing.Size(50, 23);
      this.btCancel.TabIndex = 6;
      this.btCancel.Text = "Cancel";
      this.btCancel.UseVisualStyleBackColor = true;
      this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
      // 
      // lbProtocol
      // 
      this.lbProtocol.AutoSize = true;
      this.lbProtocol.Location = new System.Drawing.Point(6, 32);
      this.lbProtocol.Name = "lbProtocol";
      this.lbProtocol.Size = new System.Drawing.Size(34, 13);
      this.lbProtocol.TabIndex = 7;
      this.lbProtocol.Text = "Type:";
      // 
      // tbPort
      // 
      this.tbPort.Location = new System.Drawing.Point(236, 55);
      this.tbPort.Name = "tbPort";
      this.tbPort.Size = new System.Drawing.Size(34, 20);
      this.tbPort.TabIndex = 10;
      // 
      // lbPort
      // 
      this.lbPort.AutoSize = true;
      this.lbPort.Location = new System.Drawing.Point(206, 58);
      this.lbPort.Name = "lbPort";
      this.lbPort.Size = new System.Drawing.Size(29, 13);
      this.lbPort.TabIndex = 9;
      this.lbPort.Text = "Port:";
      // 
      // tbIpAddress
      // 
      this.tbIpAddress.Location = new System.Drawing.Point(80, 54);
      this.tbIpAddress.Name = "tbIpAddress";
      this.tbIpAddress.Size = new System.Drawing.Size(127, 20);
      this.tbIpAddress.TabIndex = 12;
      // 
      // lbIpAddress
      // 
      this.lbIpAddress.AutoSize = true;
      this.lbIpAddress.Location = new System.Drawing.Point(6, 58);
      this.lbIpAddress.Name = "lbIpAddress";
      this.lbIpAddress.Size = new System.Drawing.Size(61, 13);
      this.lbIpAddress.TabIndex = 11;
      this.lbIpAddress.Text = "IP Address:";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tbApplicationPool);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.lbExample);
      this.groupBox1.Controls.Add(this.cbProtocolType);
      this.groupBox1.Controls.Add(this.tbHostname);
      this.groupBox1.Controls.Add(this.tbPort);
      this.groupBox1.Controls.Add(this.tbIpAddress);
      this.groupBox1.Controls.Add(this.lbHostname);
      this.groupBox1.Controls.Add(this.lbPort);
      this.groupBox1.Controls.Add(this.lbProtocol);
      this.groupBox1.Controls.Add(this.lbIpAddress);
      this.groupBox1.Location = new System.Drawing.Point(12, 59);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(281, 168);
      this.groupBox1.TabIndex = 13;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Binding";
      // 
      // tbApplicationPool
      // 
      this.tbApplicationPool.Location = new System.Drawing.Point(80, 80);
      this.tbApplicationPool.Name = "tbApplicationPool";
      this.tbApplicationPool.Size = new System.Drawing.Size(128, 20);
      this.tbApplicationPool.TabIndex = 19;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 85);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 13);
      this.label1.TabIndex = 18;
      this.label1.Text = "App Pool:";
      // 
      // lbExample
      // 
      this.lbExample.AutoSize = true;
      this.lbExample.Location = new System.Drawing.Point(7, 133);
      this.lbExample.Name = "lbExample";
      this.lbExample.Size = new System.Drawing.Size(269, 13);
      this.lbExample.TabIndex = 17;
      this.lbExample.Text = "Example: www.contoso.com or marketting.contoso.com";
      // 
      // cbProtocolType
      // 
      this.cbProtocolType.FormattingEnabled = true;
      this.cbProtocolType.Items.AddRange(new object[] {
            "http",
            "https"});
      this.cbProtocolType.Location = new System.Drawing.Point(79, 28);
      this.cbProtocolType.Name = "cbProtocolType";
      this.cbProtocolType.Size = new System.Drawing.Size(128, 21);
      this.cbProtocolType.TabIndex = 14;
      this.cbProtocolType.SelectedIndexChanged += new System.EventHandler(this.cbProtocolType_SelectedIndexChanged);
      // 
      // tbHostname
      // 
      this.tbHostname.Location = new System.Drawing.Point(80, 105);
      this.tbHostname.Name = "tbHostname";
      this.tbHostname.Size = new System.Drawing.Size(128, 20);
      this.tbHostname.TabIndex = 16;
      // 
      // lbHostname
      // 
      this.lbHostname.AutoSize = true;
      this.lbHostname.Location = new System.Drawing.Point(6, 110);
      this.lbHostname.Name = "lbHostname";
      this.lbHostname.Size = new System.Drawing.Size(60, 13);
      this.lbHostname.TabIndex = 15;
      this.lbHostname.Text = "HostName:";
      // 
      // AddWebServer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGray;
      this.ClientSize = new System.Drawing.Size(307, 268);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btCancel);
      this.Controls.Add(this.btOK);
      this.Controls.Add(this.btBrowseDirectory);
      this.Controls.Add(this.tbLocation);
      this.Controls.Add(this.tbSiteName);
      this.Controls.Add(this.lbSiteName);
      this.Controls.Add(this.lbLocation);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(315, 301);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(315, 301);
      this.Name = "AddWebServer";
      this.Text = "Add Web Server";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbSiteName;
        private System.Windows.Forms.TextBox tbSiteName;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Button btBrowseDirectory;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbProtocol;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox tbIpAddress;
        private System.Windows.Forms.Label lbIpAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbExample;
        private System.Windows.Forms.TextBox tbHostname;
        private System.Windows.Forms.Label lbHostname;
        private System.Windows.Forms.ComboBox cbProtocolType;
        private System.Windows.Forms.TextBox tbApplicationPool;
        private System.Windows.Forms.Label label1;
    }
}