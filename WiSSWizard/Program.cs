using System;
using System.Threading;
using System.Windows.Forms;
using Actemium.Diagnostics;

namespace Actemium.WiSSWizard
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      try
      {
        SetupTracing(true);
      }
      catch
      {
        MessageBox.Show("Setup tracing failed!", "Trace Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());

    }

    private static void SetupTracing(bool WatchAppConfigFileForChanges)
    {
      try
      {
        Trace.AddTraceSource(new TraceSource("AppTraceSource"));
        
        if (WatchAppConfigFileForChanges)
        {
          ConfigTraceSwitchWatcher AppConfigWatcher = new ConfigTraceSwitchWatcher();
          AppConfigWatcher.Changed += new ConfigTraceSwitchWatcher.FileChangedHandler(ConfigTraceSwitchWatcher_Changed);
        }

        Trace.UpdateConfigurationAttributes();
      }
      catch (Exception ex)
      {
        throw new Exception("Error raised while trying to update the traceSources by their config file settings", ex);
      }
    }

    private static void ConfigTraceSwitchWatcher_Changed(object sender, EventArgs e)
    {
      Trace.UpdateConfigurationAttributes();
    }
  }
}
