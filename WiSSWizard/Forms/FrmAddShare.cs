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
  public partial class AddShare : BaseFormPage
  {
    public AddShare()
    {
      InitializeComponent();
    }

    private void rbSharedMaximum_CheckedChanged(object sender, EventArgs e)
    {
      if (rbSharedMaximum.Checked)
      {
        nudSharedUsers.Enabled = false;
      }
      else
      {
        nudSharedUsers.Enabled = true;
      }
    }

    private void btSharedBrowse_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      DialogResult result = folderBrowserDialog.ShowDialog(this);

      if (result == System.Windows.Forms.DialogResult.OK)
        tbShareFolder.Text = folderBrowserDialog.SelectedPath;
    }
    
    private void btSharedOK_Click(object sender, EventArgs e)
    {
      if (SetValues())
      {

        this.DialogResult = DialogResult.OK;
      }
      else
      {
        this.DialogResult = DialogResult.None;
      }

    }
    private bool SetValues()
    {
      bool check = false;
      string sharePath = tbShareFolder.Text;
      string shareName = tbShareName.Text;
      string shareComment = tbShareComment.Text;
      string simultaneousLimit ="";
      if (rbSharedAllowNumberOfUser.Checked)
        simultaneousLimit = nudSharedUsers.Value.ToString();
      else if (rbSharedMaximum.Checked)
        simultaneousLimit = int.MaxValue.ToString();
      ConfigClass configClass = new ConfigClass();
      NewSharedFolder sharedFolder = new NewSharedFolder(sharePath, shareName, simultaneousLimit, shareComment);      
      configClass.ConfigureSharedFolders.AddNewSharedFolder = sharedFolder;
      if (configClass.ConfigureSharedFolders.ListOfNewSharedFolder.Contains(sharedFolder))
      {
        check = true;
      }
      else check = false;
      return check;
    }

    private void btSharedCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
