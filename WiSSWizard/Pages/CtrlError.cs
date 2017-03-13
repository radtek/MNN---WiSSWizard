using System;
using System.Drawing;

namespace Actemium.WiSSWizard
{
  public partial class CtrlError : BaseFormPage
  {
    private const string CLASSNAME = "CtrlError";

    public CtrlError(bool error)
    {
      InitializeComponent();
      this.TopLevel = false;

      this._navigationItem = NavigationItems.Error;
      this._title = "Error";

      // TEMP
      if (error)
          lblTemp.Text = "An unknown error occurred while navigating...";
      else
          lblTemp.Text = "The page you requested could not be found...";
    }

    private void CtrlLogon_Resize(object sender, EventArgs e)
    {
      lblTemp.Location = new Point((this.Size.Width - lblTemp.Size.Width) / 2, (this.Size.Height - lblTemp.Size.Height) / 2);
    }
  }
}