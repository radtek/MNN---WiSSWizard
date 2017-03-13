using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Actemium.WiSSWizard.Support;
using System.DirectoryServices.AccountManagement;
using Actemium.Diagnostics;

namespace Actemium.WiSSWizard.Pages
{
  public partial class FrmModifyFirewallRules : BaseFormPage
  {
    private const string CLASSNAME = "FrmModifyFirewallRules";

    //private CtrlHome _ctrlhome = new CtrlHome();

    /// <summary>
    /// Default contructor for designer
    /// </summary>
    public FrmModifyFirewallRules()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="oldRuleName"></param>    
    /// <param name="ruleEnable"></param>
    /// <param name="ruleDirection"></param>
    /// <param name="ruleProtocol"></param>
    /// <param name="rulePort"></param>
    /// <param name="ruleAction"></param>
    public FrmModifyFirewallRules(string oldRuleName, string ruleEnable, string ruleDirection, string ruleProtocol, string rulePort, string ruleAction)
      : this()
    {
      const string FUNCTIONNAME = "Contructor";

      try
      {
        OldRuleName = oldRuleName;        
        RuleEnable = ruleEnable;
        RuleDirection = ruleDirection;
        RuleProtocol = ruleProtocol;
        RulePort = rulePort;
        RuleAction = ruleAction;
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", CLASSNAME, FUNCTIONNAME, ex);
        throw;
      }
    }

    /// <summary>
    /// Initalize the form, called from onload
    /// </summary>
    private void Initialize()
    {
      const string FUNCTIONNAME = "Initialize";
      try
      {
        tbRuleName.Text = OldRuleName;
        tbPortNo.Text = RulePort;

        if (RuleEnable == "Yes")
          rbEnableYes.Checked = true;

        if (RuleEnable == "No")
          rbEnableNo.Checked = true;

        if (RuleDirection == "In")
          rbDirIN.Checked = true;

        if (RuleDirection == "Out")
          rbDirOUT.Checked = true;

        if (RuleProtocol == "TCP")
          rbProtocolTCP.Checked = true;

        if (RuleProtocol == "UDP")
          rbProtocolUDP.Checked = true;

        if (RuleAction == "Allow")
          rbActionAllow.Checked = true;

        if (RuleAction == "Block")
          rbActionBlock.Checked = true;
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", CLASSNAME, FUNCTIONNAME, ex);
        throw;
      }
    }

    private void ConfirmValues()
    {
      //bool check = false;
      ConfigClass configClass = new ConfigClass();

      NewRuleName = tbRuleName.Text;
      if (rbEnableYes.Checked)
        RuleEnable = "Yes";

      if (rbEnableNo.Checked)
        RuleEnable = "No";

      if (rbDirIN.Checked)
        RuleDirection = "In";

      if (rbDirOUT.Checked)
        RuleDirection = "Out";

      if (rbProtocolTCP.Checked)
        RuleProtocol = "TCP";

      if (rbProtocolUDP.Checked)
        RuleProtocol = "UDP";

      RulePort = tbPortNo.Text;

      if (rbActionAllow.Checked)
        RuleAction = "Allow";

      if (rbActionBlock.Checked)
        RuleAction = "Block";
      //if (cbProtocolTCP.Checked)
      //ModifyFirewall modifyFirewallRules = new ModifyFirewall();
      
      
      
      
    }

    #region Propeties

    public string OldRuleName
    {
      get { return _oldRuleName; }
      set { _oldRuleName = value; }
    } private string _oldRuleName = string.Empty;

    public string NewRuleName
    {
      get
      { return _newRuleName; }
      set
      { _newRuleName = value; }
    }private string _newRuleName = string.Empty;

    public string RuleEnable
    {
      get
      { return _ruleEnable; }
      set
      { _ruleEnable = value; }
    } private string _ruleEnable = string.Empty;

    public string RuleDirection
    {
      get { return _ruleDirection; }
      set { _ruleDirection = value; }
    } private string _ruleDirection = string.Empty;

    public string RuleProtocol
    {
      get
      { return _ruleProtocol; }
      set
      {
        _ruleProtocol = value;
      }
    } private string _ruleProtocol = string.Empty;

    public string RulePort
    {
      get
      { return _rulePort; }
      set
      { _rulePort = value; }
    } private string _rulePort = string.Empty;

    public string RuleAction
    {
      get
      { return _ruleAction; }

      set
      { _ruleAction = value; }
    } private string _ruleAction = string.Empty;

    #endregion

    #region Events

    
    

    private void btSave_Click(object sender, EventArgs e)
    {
      ConfirmValues();
      this.Close();
    }
    

    private void FrmModifyFirewallRules_Load(object sender, EventArgs e)
    {
      Initialize();
    }

    #endregion

   
  }
}
