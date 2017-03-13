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

namespace Actemium.WiSSWizard.Pages
{
  public partial class ModifyUser : BaseFormPage
  {
    //Parameters
    PrincipalContext domain = new PrincipalContext(ContextType.Machine);
    UserPrincipal userPrincipal;
    private string _changeFullname = "";
    private string _changeDescription = "";
    private List<string> _changeGroup = new List<string>();
    private string _changePassword = "";
    private bool _changePasswordChangeNextLogon = false;
    private bool _changePasswordCantBeChanged = false;
    private bool _changePasswordNeverExpires = false;
    private bool _changeAccountDisabled = false;
    private bool _modifyOtherSettings = false;
    private CtrlHome _ctrlhome = new CtrlHome();
    //constuctors
    public ModifyUser()
    {
      InitializeComponent();
    }

    public ModifyUser(string userName, CtrlHome ctrl)
    {
      InitializeComponent();
      try
      {        
        userPrincipal = UserPrincipal.FindByIdentity(domain, IdentityType.Name, userName);
        lbUserName.Text = userPrincipal.Name;
        tbUserFullName.Text = userPrincipal.DisplayName;
        foreach (string strGroup in _ctrlhome.localGroupMembers)
        {
          chkListBChangeGroups.Items.Add(strGroup);
        }
        
        tbUserDescription.Text = userPrincipal.Description;
        cbPaswordNeverExpires.Checked = userPrincipal.PasswordNeverExpires;
        cbPaswordCantBeChanged.Checked = userPrincipal.UserCannotChangePassword;
        cbAccountDisabled.Checked = userPrincipal.IsAccountLockedOut();
        _ctrlhome = ctrl;
      }
      catch (Exception ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "ModifyUser","ModifyUser",ex, userName);

      }
    }
    public ModifyUser(string name, string fullname, string description, List<string> groupList, bool ChangePwNextLogon, bool PasswordCantBeChanged, bool PasswordNeverExpires, bool AccountDisabled, string password, CtrlHome ch, object[] comboBoxItems)
    {
      InitializeComponent();
      ConfigClass _configClass = new ConfigClass();
      ScriptHandling _scriptHandling = new ScriptHandling();       
      int indexForChecked = 0;
      foreach (string userGroupsString in _ctrlhome.localGroupMembers)
      {
        chkListBChangeGroups.Items.Add(userGroupsString);
        indexForChecked++;
        {
          foreach (string checkedString in _ctrlhome.GroupsToBeChecked)
          {
            if (checkedString == userGroupsString)
              chkListBChangeGroups.SetItemChecked(indexForChecked - 1, true);
          }
        }
      }
      if (chkListBChangeGroups.CheckedItems.Count != 0)
      {
        foreach (string checkedItemsString in chkListBChangeGroups.CheckedItems)
        { groupList.Add(checkedItemsString); }
      }
      lbUserName.Text = name;
      tbUserFullName.Text = fullname;
      tbUserDescription.Text = description;
      tbNewPasword1.Text = password;
      tbNewPasword2.Text = password;
      cbChangePwNextLogon.Checked = ChangePwNextLogon;
      cbPaswordCantBeChanged.Checked = PasswordCantBeChanged;
      cbPaswordNeverExpires.Checked = PasswordNeverExpires;
      cbAccountDisabled.Checked = AccountDisabled;
      _ctrlhome = ch;
    }

    //Properties
    public string ChangeFullname
    {
      get
      { return _changeFullname; }
    }
    public string ChangeDescription
    {
      get
      { return _changeDescription; }
    }
    public string ChangePassword
    {
      get
      { return _changePassword; }
    }

    public List<string> ChangeGroup
    {
      get
      { return _changeGroup; }
    }
    public bool ChangePasswordChangeNextLogon
    {
      get
      { return _changePasswordChangeNextLogon; }
    }
    public bool ChangePasswordCantBeChanged
    {
      get
      { return _changePasswordCantBeChanged; }
    }
    public bool ChangePasswordNeverExpires
    {
      get
      { return _changePasswordNeverExpires; }
    }
    public bool ChangeAccountDisabled
    {
      get
      { return _changeAccountDisabled; }
    }
    public bool ModifyOtherSettings
    {
      get
      { return _modifyOtherSettings; }
    }

    //Methods

    private void cbChangePwNextLogon_CheckedChanged(object sender, EventArgs e)
    {
      if (cbChangePwNextLogon.Checked == true)
      {
        cbPaswordCantBeChanged.Enabled = false;
        cbPaswordCantBeChanged.Checked = false;
        cbPaswordNeverExpires.Enabled = false;
        cbPaswordNeverExpires.Checked = false;
      }
      else
      {
        cbPaswordCantBeChanged.Enabled = true;
        cbPaswordNeverExpires.Enabled = true;
      }
    }
    private void cbPaswordCantBeChanged_CheckedChanged(object sender, EventArgs e)
    {
      if (cbPaswordCantBeChanged.Checked == true)
      {
        cbChangePwNextLogon.Enabled = false;
        cbChangePwNextLogon.Checked = false;
      }
      else
      {
        if (!cbPaswordNeverExpires.Checked)
        {
          cbChangePwNextLogon.Enabled = true;
        }
      }
    }
    private void cbPaswordNeverExpires_CheckedChanged(object sender, EventArgs e)
    {
      if (cbPaswordNeverExpires.Checked == true)
      {
        cbChangePwNextLogon.Enabled = false;
        cbChangePwNextLogon.Checked = false;
      }
      else
      {
        if (!cbPaswordCantBeChanged.Checked)
        {
          cbChangePwNextLogon.Enabled = true;
        }
      }
    }



    private void btModifyUser_Click(object sender, EventArgs e)
    {
      if (SetValues())
      {

        this.DialogResult = DialogResult.OK;
      }
      else
      {
        this.DialogResult = DialogResult.None;
      }

      //this.DialogResult = DialogResult.OK;


    }

    public bool SetValues()
    {

      bool check = true;
      errorProvider1.Clear();
      _changeFullname = tbUserFullName.Text;
      _changeDescription = tbUserDescription.Text;

      foreach (string checkedItemsString in chkListBChangeGroups.CheckedItems)
      {        
          _changeGroup.Add(checkedItemsString);
      }
      _changePassword = "";
      _changePasswordChangeNextLogon = cbChangePwNextLogon.Checked;
      _changePasswordCantBeChanged = cbPaswordCantBeChanged.Checked;
      _changePasswordNeverExpires = cbPaswordNeverExpires.Checked;
      _changeAccountDisabled = cbAccountDisabled.Checked;
      _modifyOtherSettings = cbMakeOtherSettings.Checked;

      if (tbNewPasword1.Text.Length != 0 || tbNewPasword2.Text.Length != 0)
      {
        if (tbNewPasword1.Text.Length != 0 && tbNewPasword2.Text.Length != 0 && tbNewPasword1.Text == tbNewPasword2.Text)
        {
          if (_ctrlhome.CheckPasswordPolicy(tbNewPasword1.Text))
          {
            if (_ctrlhome.CheckPasswordIsNotontheBadList(tbNewPasword1.Text))
            {
              _changePassword = tbNewPasword1.Text;
              btModifyUser.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
              errorProvider1.SetError(tbNewPasword1, "The chosen password is on the banned list passwords \nPlease choose a different password.");
              check = false;
            }
          }
          else
          {
            errorProvider1.SetError(tbNewPasword1, "The password does not meet the password policy requirements.");
            check = false;
          }
        }
        else
        {
          // wachtwoorden komen niet overeen
          errorProvider1.SetError(tbNewPasword1, "The entered password does not match");
          check = false;
        }
      }
      return check;
    }

    private void cbMakeOtherSettings_CheckedChanged(object sender, EventArgs e)
    {
      if (cbMakeOtherSettings.Checked)
      {
        gbSettings.Enabled = true;
      }
      else
      {
        gbSettings.Enabled = false;
      }
    }

  }
}
