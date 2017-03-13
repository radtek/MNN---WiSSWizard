using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Actemium.WiSSWizard.Support;
using System.IO;
using System.Windows.Forms;

namespace Actemium.WiSSWizard
{
  public class CreateStartupProcessForOtherAccounts
  {
    //properties
    private const string CLASSNAME = "CreateStartupProcessForOtherAccounts";
    private string _regFilepath = "";
    private List<bool> _checkRegKeySettingsForOtherUsers = new List<bool>();


    //constructor
    public CreateStartupProcessForOtherAccounts()
    {

    }

    //methods
    public void CreateRegFileAndStartupBatchFile(OSVersions os, ConfigClass configClass)
    {
      try
      {
        string driveLetter = Environment.GetEnvironmentVariable("SystemRoot");
        driveLetter = driveLetter.Substring(0, 3);
        _regFilepath = driveLetter + "Actemium";
        DirectoryInfo di = Directory.CreateDirectory(_regFilepath);
        di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;

        configClass.GetScriptHandling.AddRegistrySettingsToFile(_regFilepath + @"\firstLogon.reg");

        string firstLogonEXEpath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\ConfigFiles\FirstLogon\firstLogon.exe";
        string firstLogonBATpath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\ConfigFiles\FirstLogon\firstLogon.bat";
        if (!File.Exists(firstLogonEXEpath))
        {

          DialogResult result = MessageBox.Show("firstLogon.exe is not found in the root of this application", "Executable not found", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
          if (result == DialogResult.Retry)
          {
            CreateRegFileAndStartupBatchFile(os, configClass);
          }
        }
        if (!File.Exists(firstLogonBATpath))
        {
          DialogResult result = MessageBox.Show("firstLogon.bat is not found in the root of this application", "Executable not found", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
          if (result == DialogResult.Retry)
          {
            CreateRegFileAndStartupBatchFile(os, configClass);
          }
        }
        if (!File.Exists(_regFilepath + @"\firstLogon.exe"))
        {
          File.Copy(firstLogonEXEpath, _regFilepath + @"\firstLogon.exe");
        }

        if (!File.Exists(_regFilepath + @"\firstLogon.bat"))
        {
          File.Copy(firstLogonBATpath, _regFilepath + @"\firstLogon.bat");
        }

        string regPath = "";
        string regKey = "";
        string value = _regFilepath + @"\firstLogon.exe";
        string propertyType = "String";

        if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "FirstLogonPath") != null)
        {
          regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "FirstLogonPath");
        }
        else
        {
          regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "FirstLogonPath");
        }
        regKey = "SetCurrentUserSettingsActemium";
        configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
      }
      catch (Exception ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0},{1})", "MainEndCreateRegFileAndStartupBatchFile", CLASSNAME, ex, os);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Create start up files for other accounts", ex.Message));
      }

    }
    public bool CheckEndCreateRegFileAndStartupBatchFile(OSVersions os, ConfigClass configClass)
    {
      bool totalcheck = true;
      try
      {
        if (File.Exists(_regFilepath + @"\firstLogon.exe"))
        {
          _checkRegKeySettingsForOtherUsers.Add(true);
        }
        else
        {
          _checkRegKeySettingsForOtherUsers.Add(false);
        }
        if (File.Exists(_regFilepath + @"\firstLogon.bat"))
        {
          _checkRegKeySettingsForOtherUsers.Add(true);
        }
        else
        {
          _checkRegKeySettingsForOtherUsers.Add(false);
        }

        FileHandling _fileHandling = new FileHandling();
        List<string> regSettings = new List<string>();
        regSettings = _fileHandling.ReadWholeFile(_regFilepath + @"\firstLogon.reg");

        foreach (string str in configClass.GetScriptHandling.RegistrySettings)
        {
          if (regSettings.Contains(str))
          {
            _checkRegKeySettingsForOtherUsers.Add(true);
          }
          else
          {
            _checkRegKeySettingsForOtherUsers.Add(false);
          }
        }

        foreach (bool b in _checkRegKeySettingsForOtherUsers)
        {
          if (!b)
          {
            totalcheck = false;
            return totalcheck;
          }
        }

      }
      catch (Exception ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "Check start up files for accounts are created", CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check start up files for accounts are created", ex.Message));

      }
      return totalcheck;
    }


  }
}
