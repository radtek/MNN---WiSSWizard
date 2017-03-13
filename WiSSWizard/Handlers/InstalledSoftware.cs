using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace Actemium.WiSSWizard
{
  public class InstalledSoftware
  {
    //parameters
    private const string CLASSNAME = "InstalledSoftware";

    //properties
    public bool AntiVirus
    {
      get
      {
        return _antiVirus;
      }
      set
      {
        _antiVirus = value;
      }

    } private bool _antiVirus = false;
    public bool PcAnywhere
    {
      get
      {
        return _pcAnywhere;
      }
      set
      {
        _pcAnywhere = value;
      }

    } private bool _pcAnywhere = false;
    public bool BlockKeys
    {
      get
      {
        return _BlockKeys;
      }
      set
      {
        _BlockKeys = value;
      }

    }  private bool _BlockKeys = false;
    public bool SQLServer
    {
      get
      {
        return _SQLServer;
      }
      set
      {
        _SQLServer = value;
      }

    } private bool _SQLServer = false;
    public bool IIS
    {
      get
      {
        return _IIS;
      }
      set
      {
        _IIS = value;
      }

    } private bool _IIS = false;
    public bool MBSA
    {
      get
      {
        return _MBSA;
      }
      set
      {
        _MBSA = value;
      }

    } private bool _MBSA = false;

    //methods
    public string GetInstallationPathOfApplication(string application)
    {
      List<string> app = new List<string>();
      string Software = null;
      string SoftwareKey1 = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
      string SoftwareKey2 = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

      using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(SoftwareKey1))
      {
        try
        {
          foreach (string skName in rk.GetSubKeyNames())
          {
            using (RegistryKey sk = rk.OpenSubKey(skName))
            {
              try
              {
                if (!(sk.GetValue("InstallLocation") == null))
                {
                  Software = sk.GetValue("InstallLocation") + "";
                  app.Add(Software);
                }

              }
              catch (Exception ex)
              {

                Actemium.Diagnostics.Trace.WriteError("({0},{1})", "GetInstallationPathOfApplication", CLASSNAME, ex, application);
              }
            }
          }

        }
        catch (Exception ex)
        {
          Actemium.Diagnostics.Trace.WriteError("({0},{1})", "GetInstallationPathOfApplication", CLASSNAME, ex, application);

        }
      }
      using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(SoftwareKey2))
      {
        try
        {
          foreach (string skName in rk.GetSubKeyNames())
          {
            using (RegistryKey sk = rk.OpenSubKey(skName))
            {
              try
              {
                if (!(sk.GetValue("InstallLocation") == null))
                {
                  Software = sk.GetValue("InstallLocation") + "";
                  app.Add(Software);
                }
              }
              catch (Exception ex)
              {
                Actemium.Diagnostics.Trace.WriteError("({0})", "GetInstallationPathOfApplication", CLASSNAME, ex, application);

              }
            }
          }
        }
        catch (Exception ex)
        {
          Actemium.Diagnostics.Trace.WriteError("({0})", "GetInstallationPathOfApplication", CLASSNAME, ex, application);

        }
      }
      foreach (string str in app)
      {

        if (str.Contains(application))
        {
          return str;
        }

      }

      return "The installation location of " + application + "  is not found. Fill the location yourself using the button \"browse \"";
    }
    public bool IsApplicationInstalled(string application)
    {

      List<string> app = new List<string>();
      string Software = null;
      string SoftwareKey1 = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
      string SoftwareKey2 = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
      string SoftwareKey3 = @"Software\Microsoft\InetStp";
      using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(SoftwareKey1))
      {
        //Let's go through the registry keys and get the info we need:
        try
        {
          foreach (string skName in rk.GetSubKeyNames())
          {

            using (RegistryKey sk = rk.OpenSubKey(skName))
            {
              try
              {
                //If the key has value, continue, if not, skip it:
                if (!(sk.GetValue("DisplayName") == null))
                {
                  Software = sk.GetValue("DisplayName") + "";
                  app.Add(Software);
                }
              }
              catch (Exception ex)
              {
                Actemium.Diagnostics.Trace.WriteError("({0},{1})", "IsApplicationInstalled", CLASSNAME, ex, application);

              }
            }
          }

        }
        catch (Exception ex)
        {
          Actemium.Diagnostics.Trace.WriteError("({0},{1})", "IsApplicationInstalled", CLASSNAME, ex, application);

        }

      }
      using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(SoftwareKey2))
      {
        try
        {
          foreach (string skName in rk.GetSubKeyNames())
          {
            using (RegistryKey sk = rk.OpenSubKey(skName))
            {
              try
              {
                if (!(sk.GetValue("DisplayName") == null))
                {
                  Software = sk.GetValue("DisplayName") + "";
                  app.Add(Software);
                }
              }
              catch (Exception ex)
              {
                Actemium.Diagnostics.Trace.WriteError("({0})", "IsApplicationInstalled", CLASSNAME, ex, application);

              }
            }
          }
        }
        catch (Exception ex)
        {
          Actemium.Diagnostics.Trace.WriteError("({0})", "IsApplicationInstalled", CLASSNAME, ex, application);

        }

      }
      using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(SoftwareKey3))
      {
        try
        {
          if (rk != null)
          {
            int majorVersion = (int)rk.GetValue("MajorVersion", -1);
            if (majorVersion != -1)
            {
              app.Add("IIS");
            }
          }
        }
        catch (Exception ex)
        {
          Actemium.Diagnostics.Trace.WriteError("({0},{1})", "IsApplicationInstalled", CLASSNAME, ex, application);

        }

      }

      foreach (string str in app)
      {
        if (str.Contains(application))
        {
          return true;
        }
      }

      return false;
    }
  }
}
