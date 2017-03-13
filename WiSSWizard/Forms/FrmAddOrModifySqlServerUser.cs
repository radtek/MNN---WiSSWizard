using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Actemium.WiSSWizard.Pages
{
  public partial class AddOrModifySqlServerUser : DevComponents.DotNetBar.Office2007Form
  {
    public AddOrModifySqlServerUser()
    {
      InitializeComponent();
    }
    CtrlHome ctrlHome = new CtrlHome();
    ConfigClass _configClass = new ConfigClass();
    private void rbSQLAddSqlUser_CheckedChanged(object sender, EventArgs e)
    {
      if (rbSQLAddSqlUser.Checked)
      {
        this.lvUsers.Enabled = false;
        this.lvUsers.Visible = false;
        this.gbSQLServerAddUser.Enabled = true;
        this.gbSQLServerAddUser.Visible = true;
      }
      if (rbSQLAddUserWAM.Checked)
      {
        this.lvUsers.Enabled = true;
        this.lvUsers.Visible = true;
        this.gbSQLServerAddUser.Enabled = false;
        this.gbSQLServerAddUser.Visible = false;
      }

    }

    private void cbRandomPw_CheckedChanged(object sender, EventArgs e)
    {
      int defaultLength = 8;
      
      PasswordGenerator pw = new PasswordGenerator();
      string password = pw.GeneratePassword(defaultLength);
      if (cbRandomPw.Checked)
      {
        
        ctrlHome.AskSavePasswordInLogfile();
        if (cbSavePwToLog.Checked)
        {
          ctrlHome.SetPasswordFields(true);
        }
        else
        {
          ctrlHome.SetPasswordFields(false);
        }


        tbPassword.Text = password;
        tbConfirmPw.Text = password;
        tbPassword.Enabled = false;
        tbConfirmPw.Enabled = false;
      }
      else
      {
        tbPassword.PasswordChar = '*';
        tbConfirmPw.PasswordChar = '*';
        tbPassword.Text = "";
        tbConfirmPw.Text = "";
        tbPassword.Enabled = true;
        tbConfirmPw.Enabled = true;
      }
    }

    private void cbSavePwToLog_CheckedChanged(object sender, EventArgs e)
    {
      
      if (cbSavePwToLog.Checked)
      {
        _configClass.ConfSetWindowsUsers.SavePasswordsInLogfile = true;        
      }
      else
      {
        _configClass.ConfSetWindowsUsers.SavePasswordsInLogfile = false;        
      }
      ctrlHome.SetPasswordFields(cbSavePwToLog.Checked);
    }
  }
}
