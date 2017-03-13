using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Actemium.Diagnostics;

namespace Actemium.WiSSWizard.Pages
{
  public partial class BaseWiSSWizardPage : DevComponents.DotNetBar.WizardPage
  {
    private const string CLASSNAME = "BaseWiSSWizardPage";

    public BaseWiSSWizardPage()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Get or set PageWiSSWizardMode 
    /// </summary>
    public WiSSWizardMode PageWiSSWizardMode 
    {
      get { return _pageWiSSWizardMode; }
      set { _pageWiSSWizardMode = value;} 
    } private WiSSWizardMode _pageWiSSWizardMode = WiSSWizardMode.All;

    public override string ToString()
    {
      return Name;
    }
    
  }

  public enum WiSSWizardMode
  {
    Security,
    Lockdown,
    SecurityAndLockdown,
    Template,
    All,
  }
  
}
