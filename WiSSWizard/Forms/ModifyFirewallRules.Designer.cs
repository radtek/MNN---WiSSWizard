namespace Actemium.WiSSWizard.Pages
{
  partial class FrmModifyFirewallRules
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
      this.lbRule = new System.Windows.Forms.Label();
      this.tbRuleName = new System.Windows.Forms.TextBox();
      this.lbEnable = new System.Windows.Forms.Label();
      this.lbDirection = new System.Windows.Forms.Label();
      this.lbProtocol = new System.Windows.Forms.Label();
      this.lbPort = new System.Windows.Forms.Label();
      this.tbPortNo = new System.Windows.Forms.TextBox();
      this.lbAction = new System.Windows.Forms.Label();
      this.btSave = new System.Windows.Forms.Button();
      this.btCancel = new System.Windows.Forms.Button();
      this.rbDirIN = new System.Windows.Forms.RadioButton();
      this.rbDirOUT = new System.Windows.Forms.RadioButton();
      this.panel1 = new System.Windows.Forms.Panel();
      this.rbProtocolTCP = new System.Windows.Forms.RadioButton();
      this.rbProtocolUDP = new System.Windows.Forms.RadioButton();
      this.panel2 = new System.Windows.Forms.Panel();
      this.rbActionBlock = new System.Windows.Forms.RadioButton();
      this.rbActionAllow = new System.Windows.Forms.RadioButton();
      this.panel3 = new System.Windows.Forms.Panel();
      this.rbEnableNo = new System.Windows.Forms.RadioButton();
      this.rbEnableYes = new System.Windows.Forms.RadioButton();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // lbRule
      // 
      this.lbRule.AutoSize = true;
      this.lbRule.Location = new System.Drawing.Point(12, 18);
      this.lbRule.Name = "lbRule";
      this.lbRule.Size = new System.Drawing.Size(63, 13);
      this.lbRule.TabIndex = 13;
      this.lbRule.Text = "Rule Name:";
      // 
      // tbRuleName
      // 
      this.tbRuleName.Location = new System.Drawing.Point(81, 12);
      this.tbRuleName.Name = "tbRuleName";
      this.tbRuleName.Size = new System.Drawing.Size(133, 20);
      this.tbRuleName.TabIndex = 1;
      // 
      // lbEnable
      // 
      this.lbEnable.AutoSize = true;
      this.lbEnable.Location = new System.Drawing.Point(12, 43);
      this.lbEnable.Name = "lbEnable";
      this.lbEnable.Size = new System.Drawing.Size(43, 13);
      this.lbEnable.TabIndex = 14;
      this.lbEnable.Text = "Enable:";
      // 
      // lbDirection
      // 
      this.lbDirection.AutoSize = true;
      this.lbDirection.Location = new System.Drawing.Point(12, 70);
      this.lbDirection.Name = "lbDirection";
      this.lbDirection.Size = new System.Drawing.Size(52, 13);
      this.lbDirection.TabIndex = 15;
      this.lbDirection.Text = "Direction:";
      // 
      // lbProtocol
      // 
      this.lbProtocol.AutoSize = true;
      this.lbProtocol.Location = new System.Drawing.Point(12, 94);
      this.lbProtocol.Name = "lbProtocol";
      this.lbProtocol.Size = new System.Drawing.Size(49, 13);
      this.lbProtocol.TabIndex = 16;
      this.lbProtocol.Text = "Protocol:";
      // 
      // lbPort
      // 
      this.lbPort.AutoSize = true;
      this.lbPort.Location = new System.Drawing.Point(12, 118);
      this.lbPort.Name = "lbPort";
      this.lbPort.Size = new System.Drawing.Size(29, 13);
      this.lbPort.TabIndex = 17;
      this.lbPort.Text = "Port:";
      // 
      // tbPortNo
      // 
      this.tbPortNo.Location = new System.Drawing.Point(81, 115);
      this.tbPortNo.Name = "tbPortNo";
      this.tbPortNo.Size = new System.Drawing.Size(95, 20);
      this.tbPortNo.TabIndex = 8;
      // 
      // lbAction
      // 
      this.lbAction.AutoSize = true;
      this.lbAction.Location = new System.Drawing.Point(12, 144);
      this.lbAction.Name = "lbAction";
      this.lbAction.Size = new System.Drawing.Size(40, 13);
      this.lbAction.TabIndex = 18;
      this.lbAction.Text = "Action:";
      // 
      // btSave
      // 
      this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btSave.Location = new System.Drawing.Point(88, 178);
      this.btSave.Name = "btSave";
      this.btSave.Size = new System.Drawing.Size(48, 23);
      this.btSave.TabIndex = 11;
      this.btSave.Text = "Save";
      this.btSave.UseVisualStyleBackColor = true;
      this.btSave.Click += new System.EventHandler(this.btSave_Click);
      // 
      // btCancel
      // 
      this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btCancel.Location = new System.Drawing.Point(142, 178);
      this.btCancel.Name = "btCancel";
      this.btCancel.Size = new System.Drawing.Size(53, 23);
      this.btCancel.TabIndex = 12;
      this.btCancel.Text = "Cancel";
      this.btCancel.UseVisualStyleBackColor = true;
      // 
      // rbDirIN
      // 
      this.rbDirIN.AutoSize = true;
      this.rbDirIN.Location = new System.Drawing.Point(81, 67);
      this.rbDirIN.Name = "rbDirIN";
      this.rbDirIN.Size = new System.Drawing.Size(36, 17);
      this.rbDirIN.TabIndex = 4;
      this.rbDirIN.Text = "IN";
      this.rbDirIN.UseVisualStyleBackColor = true;
      // 
      // rbDirOUT
      // 
      this.rbDirOUT.AutoSize = true;
      this.rbDirOUT.Location = new System.Drawing.Point(134, 68);
      this.rbDirOUT.Name = "rbDirOUT";
      this.rbDirOUT.Size = new System.Drawing.Size(48, 17);
      this.rbDirOUT.TabIndex = 5;
      this.rbDirOUT.Text = "OUT";
      this.rbDirOUT.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.rbProtocolUDP);
      this.panel1.Controls.Add(this.rbProtocolTCP);
      this.panel1.Location = new System.Drawing.Point(81, 90);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(114, 22);
      this.panel1.TabIndex = 20;
      // 
      // rbProtocolTCP
      // 
      this.rbProtocolTCP.AutoSize = true;
      this.rbProtocolTCP.Location = new System.Drawing.Point(1, 3);
      this.rbProtocolTCP.Name = "rbProtocolTCP";
      this.rbProtocolTCP.Size = new System.Drawing.Size(46, 17);
      this.rbProtocolTCP.TabIndex = 0;
      this.rbProtocolTCP.TabStop = true;
      this.rbProtocolTCP.Text = "TCP";
      this.rbProtocolTCP.UseVisualStyleBackColor = true;
      // 
      // rbProtocolUDP
      // 
      this.rbProtocolUDP.AutoSize = true;
      this.rbProtocolUDP.Location = new System.Drawing.Point(53, 3);
      this.rbProtocolUDP.Name = "rbProtocolUDP";
      this.rbProtocolUDP.Size = new System.Drawing.Size(48, 17);
      this.rbProtocolUDP.TabIndex = 1;
      this.rbProtocolUDP.TabStop = true;
      this.rbProtocolUDP.Text = "UDP";
      this.rbProtocolUDP.UseVisualStyleBackColor = true;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.rbActionBlock);
      this.panel2.Controls.Add(this.rbActionAllow);
      this.panel2.Location = new System.Drawing.Point(81, 141);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(114, 22);
      this.panel2.TabIndex = 21;
      // 
      // rbActionBlock
      // 
      this.rbActionBlock.AutoSize = true;
      this.rbActionBlock.Location = new System.Drawing.Point(53, 3);
      this.rbActionBlock.Name = "rbActionBlock";
      this.rbActionBlock.Size = new System.Drawing.Size(52, 17);
      this.rbActionBlock.TabIndex = 1;
      this.rbActionBlock.TabStop = true;
      this.rbActionBlock.Text = "Block";
      this.rbActionBlock.UseVisualStyleBackColor = true;
      // 
      // rbActionAllow
      // 
      this.rbActionAllow.AutoSize = true;
      this.rbActionAllow.Location = new System.Drawing.Point(1, 3);
      this.rbActionAllow.Name = "rbActionAllow";
      this.rbActionAllow.Size = new System.Drawing.Size(50, 17);
      this.rbActionAllow.TabIndex = 0;
      this.rbActionAllow.TabStop = true;
      this.rbActionAllow.Text = "Allow";
      this.rbActionAllow.UseVisualStyleBackColor = true;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.rbEnableNo);
      this.panel3.Controls.Add(this.rbEnableYes);
      this.panel3.Location = new System.Drawing.Point(81, 40);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(114, 22);
      this.panel3.TabIndex = 22;
      // 
      // rbEnableNo
      // 
      this.rbEnableNo.AutoSize = true;
      this.rbEnableNo.Location = new System.Drawing.Point(53, 3);
      this.rbEnableNo.Name = "rbEnableNo";
      this.rbEnableNo.Size = new System.Drawing.Size(39, 17);
      this.rbEnableNo.TabIndex = 1;
      this.rbEnableNo.TabStop = true;
      this.rbEnableNo.Text = "No";
      this.rbEnableNo.UseVisualStyleBackColor = true;
      // 
      // rbEnableYes
      // 
      this.rbEnableYes.AutoSize = true;
      this.rbEnableYes.Location = new System.Drawing.Point(1, 3);
      this.rbEnableYes.Name = "rbEnableYes";
      this.rbEnableYes.Size = new System.Drawing.Size(43, 17);
      this.rbEnableYes.TabIndex = 0;
      this.rbEnableYes.TabStop = true;
      this.rbEnableYes.Text = "Yes";
      this.rbEnableYes.UseVisualStyleBackColor = true;
      // 
      // FrmModifyFirewallRules
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGray;
      this.ClientSize = new System.Drawing.Size(233, 213);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.rbDirOUT);
      this.Controls.Add(this.rbDirIN);
      this.Controls.Add(this.btCancel);
      this.Controls.Add(this.btSave);
      this.Controls.Add(this.lbAction);
      this.Controls.Add(this.tbPortNo);
      this.Controls.Add(this.lbPort);
      this.Controls.Add(this.lbProtocol);
      this.Controls.Add(this.lbDirection);
      this.Controls.Add(this.lbEnable);
      this.Controls.Add(this.tbRuleName);
      this.Controls.Add(this.lbRule);
      this.MaximumSize = new System.Drawing.Size(241, 246);
      this.MinimumSize = new System.Drawing.Size(241, 246);
      this.Name = "FrmModifyFirewallRules";
      this.Text = "Modify Rule";
      this.Load += new System.EventHandler(this.FrmModifyFirewallRules_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbRule;
    private System.Windows.Forms.TextBox tbRuleName;
    private System.Windows.Forms.Label lbEnable;
    private System.Windows.Forms.Label lbDirection;
    private System.Windows.Forms.Label lbProtocol;
    private System.Windows.Forms.Label lbPort;
    private System.Windows.Forms.TextBox tbPortNo;
    private System.Windows.Forms.Label lbAction;
    private System.Windows.Forms.Button btSave;
    private System.Windows.Forms.Button btCancel;
    private System.Windows.Forms.RadioButton rbDirIN;
    private System.Windows.Forms.RadioButton rbDirOUT;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.RadioButton rbProtocolUDP;
    private System.Windows.Forms.RadioButton rbProtocolTCP;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.RadioButton rbActionBlock;
    private System.Windows.Forms.RadioButton rbActionAllow;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.RadioButton rbEnableNo;
    private System.Windows.Forms.RadioButton rbEnableYes;
  }
}