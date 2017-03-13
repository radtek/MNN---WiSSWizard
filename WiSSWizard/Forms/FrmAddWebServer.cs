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
  public partial class AddWebServer : BaseFormPage
  {
    public AddWebServer()
    {
      InitializeComponent();
    }

    private void btBrowseDirectory_Click(object sender, EventArgs e)
    {
      
      using (FolderBrowserDialog ofSelectDir = new FolderBrowserDialog())
      { 
        if (ofSelectDir.ShowDialog() == DialogResult.OK)
        {
          tbLocation.Text = ofSelectDir.SelectedPath;
        }

      }

    }
    
    private void btOK_Click(object sender, EventArgs e)
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
      string webLocation = tbLocation.Text;
      string websiteName = tbSiteName.Text;
      string webProtocol = cbProtocolType.Text;
      string webPort = tbPort.Text;
      string webIpAddress = tbIpAddress.Text;
      string webHostName = tbHostname.Text;
      string webApplicationPool = tbApplicationPool.Text;
      ConfigClass configClass = new ConfigClass();

      NewWebServer webServer = new NewWebServer(websiteName, webProtocol, webIpAddress, webPort, webHostName, webApplicationPool, webLocation);
      configClass.ConfigureWebServer.AddNewWebserver = webServer;
      if (configClass.ConfigureWebServer.NewWebServerList.Contains(webServer))
      {
        check = true;
      }
      else check = false;
      return check;
    }

    private void btCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void cbProtocolType_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cbProtocolType.SelectedText == "http")
        tbPort.Text = "80";
      else if (cbProtocolType.SelectedText == "https")
        tbPort.Text = "443";
    }

  }
}

