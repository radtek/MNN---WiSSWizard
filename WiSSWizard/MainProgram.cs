using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;
using Actemium.WiSSWizard.Support;
using Actemium.Diagnostics;
using Actemium.Security;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.ComponentModel;

namespace Actemium.WiSSWizard
{
  public class UpdateConfigEventArgs : EventArgs
  {
    public string PictureBox { get; private set; }
    public int Image { get; private set; }
    public string Label { get; private set; }

    public UpdateConfigEventArgs(string pictureBox, int image, string label)
    {
      PictureBox = pictureBox;
      Image = image;
      Label = label;
    }
  }

  public class MainProgram
  {
    const string CLASSNAME = "MainProgram";
    //parameters
    public static bool _checkIfthereAreChanges = false;
    public event UpdateConfigEvent updateConfigOverview;
    public EventArgs e = null;
    public delegate void UpdateConfigEvent(MainProgram m, UpdateConfigEventArgs e);

    private FileHandling _fileHandling;
    private ConfigClass _configClass;
    private EncryptionPassword _encryptionPassword;

    private bool _mainRunning = true;
    public enum mainStepsAll
    {
      start,
      passWordPolicy,
      controlPolicy,
      addUserGroup,
      addUser,
      autoPlaySettings,
      explorerMapOptions,
      logInShutDownSettings,
      remoteDesktop,
      fireWall,
      configSQLserver,
      configPcAnywhere,
      configWebserver,
      configMailServer,
      configFTPserver,
      configBlockKeys,
      sharing,
      ipConfig,
      configMBSA,
      checkMBSA,
      end
    };
    public enum mainStepsSecurity
    {
      start,
      passWordPolicy,
      controlPolicy,
      addUserGroup,
      addUser,
      autoPlaySettings,
      explorerMapOptions,
      logInShutDownSettings,
      remoteDesktop,
      fireWall,
      configSQLserver,
      configWebserver,
      configMailServer,
      configFTPserver,
      ipConfig,
      configMBSA,
      checkMBSA,
      end
    };
    public enum mainStepsLock
    {
      start,
      autoPlaySettings,
      explorerMapOptions,
      fireWall,
      configPcAnywhere,
      configBlockKeys,
      sharing,
      configMBSA,
      checkMBSA,
      end
    };
    public enum mainStepsLoad
    {
      
      start,
      passWordPolicy,
      controlPolicy,
      addUserGroup,
      addUser,
      autoPlaySettings,
      explorerMapOptions,
      logInShutDownSettings,
      remoteDesktop,
      fireWall,
      configSQLserver,
      configPcAnywhere,
      configWebserver,
      configMailServer,
      configFTPserver,
      configBlockKeys,
      sharing,
      ipConfig,
      configMBSA,
      checkMBSA,
      end
    };
    private bool _MBSAchecked = false;

    public bool MBSAisReady
    {
      get
      {
        return _mbsaisready;
      }
      set
      {
        _mbsaisready = value;
      }
    }private bool _mbsaisready = false;

    //constructor
    public MainProgram()
    { }
    public MainProgram(ConfigClass configClass)
    {
      _configClass = configClass;
      _fileHandling = new FileHandling(_configClass);
      _encryptionPassword = new EncryptionPassword(configClass);
      if (!File.Exists(_encryptionPassword.FilePath))
      {
        _encryptionPassword.CreateEncryptedKeyFile();
      }

    }

    private void UpdateConfigEventHandler(UpdateConfigEventArgs ev)
    {
      if (this.updateConfigOverview != null)
        updateConfigOverview(this, ev);
    }

    //properties

    public bool StopRunning
    {
      set
      {
        _mainRunning = value;
      }
    }
    public static bool CheckIfthereAreChanges
    {
      get
      {
        return _checkIfthereAreChanges;
      }
    }
    public bool CancelMakeSettings
    {
      get
      {
        return _cancelMakeSettings;
      }
      set
      {
        _cancelMakeSettings = value;
      }
    } private static bool _cancelMakeSettings = false;
    public mainStepsAll MainstepAll
    {
      get
      {
        return _mainstepAll;
      }
      set
      {
        _mainstepAll = value;
      }
    } private mainStepsAll _mainstepAll = mainStepsAll.start;

    public mainStepsSecurity MainstepSecurity
    {
      get
      {
        return _mainstepSecurity;
      }
      set
      {
        _mainstepSecurity = value;
      }
    } private mainStepsSecurity _mainstepSecurity = mainStepsSecurity.start;
    public mainStepsLock MainstepLock
    {
      get
      {
        return _mainstepLock;
      }
      set
      {
        _mainstepLock = value;
      }
    } private mainStepsLock _mainstepLock = mainStepsLock.start;
    public mainStepsLoad MainstepLoad
    {
      get
      {
        return _mainstepLoad;
      }
      set
      {
        _mainstepLoad = value;
      }
    } private mainStepsLoad _mainstepLoad = mainStepsLoad.start;

    //Main program

    public void makeSettingsAll(mainStepsAll ms, OSVersions os)
    {
      if (_cancelMakeSettings)
      {
        _mainstepAll = ms;
        throw new Exception("cancel");
      }

      if (_mainRunning)
      {

        switch (ms)
        {
          case mainStepsAll.start:
            string mbsaLog = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\MBSAlog.txt";
            if (File.Exists(mbsaLog))
            {
              File.Delete(mbsaLog);
            }
            #region
            UpdateConfigEventArgs updtEvPb0s = new UpdateConfigEventArgs("pbConfigCheck0", 1, "");

            UpdateConfigEventHandler(updtEvPb0s);

            _configClass.CreateWindowsRestorePoint();

            if (_configClass.CheckWindowsRestorePointisCreated())
            {
              UpdateConfigEventArgs updtEvPb0t = new UpdateConfigEventArgs("pbConfigCheck0", 0, "");
              UpdateConfigEventHandler(updtEvPb0t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb0f = new UpdateConfigEventArgs("pbConfigCheck0", 2, "");
              UpdateConfigEventHandler(updtEvPb0f);
              string message1 = "It is not possible to create a Windows restore point\n Do you want to continue?";
              string caption1 = "System Restore disabled";
              MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
              DialogResult result;
              // Displays the MessageBox.
              result = MessageBox.Show(message1, caption1, buttons);

              if (result == System.Windows.Forms.DialogResult.Cancel)
              {
                Application.Exit();
              }
            }
            _checkIfthereAreChanges = true;
            makeSettingsAll(mainStepsAll.passWordPolicy, os);
            #endregion
            break;
          case mainStepsAll.passWordPolicy:
            #region
            PasswordPolicy pp = _configClass.ConfSetPasswordPolicy;
            UpdateConfigEventArgs updtEvPb1s = new UpdateConfigEventArgs("pbConfigCheck1", 1, "");
            UpdateConfigEventHandler(updtEvPb1s);
            pp.SetPasswordPolicy(_configClass);
            if (pp.CheckPasswordPolicy(_configClass))
            {
              UpdateConfigEventArgs updtEvPb1t = new UpdateConfigEventArgs("pbConfigCheck1", 0, "");
              UpdateConfigEventHandler(updtEvPb1t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb1f = new UpdateConfigEventArgs("pbConfigCheck1", 2, "");
              UpdateConfigEventHandler(updtEvPb1f);
            }
            makeSettingsAll(mainStepsAll.controlPolicy, os);
            #endregion
            break;
          case mainStepsAll.controlPolicy:
            #region
            AuditPolicy ap = _configClass.ConfSetAuditPolicy;
            UpdateConfigEventArgs updtEvPb2s = new UpdateConfigEventArgs("pbConfigCheck2", 1, "");
            UpdateConfigEventHandler(updtEvPb2s);
            ap.CompleteAuditPolicy(_configClass);
            if (ap.CheckAuditPolicy(_configClass))
            {
              UpdateConfigEventArgs updtEvPb1t = new UpdateConfigEventArgs("pbConfigCheck2", 0, "");
              UpdateConfigEventHandler(updtEvPb1t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb1f = new UpdateConfigEventArgs("pbConfigCheck2", 2, "");
              UpdateConfigEventHandler(updtEvPb1f);
            }

            makeSettingsAll(mainStepsAll.addUserGroup, os);
            #endregion
            break;
          case mainStepsAll.addUserGroup:
            #region
            WindowsUsergroup wug = _configClass.ConfSetWindowsUsergroup;
            UpdateConfigEventArgs updtEvPb3s = new UpdateConfigEventArgs("pbConfigCheck3", 1, "");
            UpdateConfigEventHandler(updtEvPb3s);
            bool created = false;
            bool deleted = false;
            wug.DeleteUserGroups(_configClass);
            if (wug.CheckUsergroupDeleted(_configClass))
            {
              deleted = true;
            }
            wug.AddUserGroups(_configClass);
            if (wug.CheckUsergroupCreated(_configClass))
            {
              created = true;
            }

            if (created && deleted)
            {
              UpdateConfigEventArgs updtEvPb3t = new UpdateConfigEventArgs("pbConfigCheck3", 0, "");
              UpdateConfigEventHandler(updtEvPb3t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb3f = new UpdateConfigEventArgs("pbConfigCheck3", 2, "");
              UpdateConfigEventHandler(updtEvPb3f);
            }
            makeSettingsAll(mainStepsAll.addUser, os);
            #endregion
            break;
          case mainStepsAll.addUser:
            #region
            UpdateConfigEventArgs updtEvPb4s = new UpdateConfigEventArgs("pbConfigCheck4", 1, "");
            UpdateConfigEventHandler(updtEvPb4s);
            WindowsUsers wu = _configClass.ConfSetWindowsUsers;
            wu.DeleteUsers(_configClass);
            wu.AddUsers(_configClass, _encryptionPassword);
            wu.ModifyUsers(_configClass, _encryptionPassword);
            if (wu.CheckUserDeleted(_configClass) && wu.CheckUserCreated(_configClass) && wu.CheckUserModified(_configClass))
            {
              UpdateConfigEventArgs updtEvPb4t = new UpdateConfigEventArgs("pbConfigCheck4", 0, "");
              UpdateConfigEventHandler(updtEvPb4t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb4f = new UpdateConfigEventArgs("pbConfigCheck4", 2, "");
              UpdateConfigEventHandler(updtEvPb4f);
            }

            makeSettingsAll(mainStepsAll.autoPlaySettings, os);
            #endregion
            break;
          case mainStepsAll.autoPlaySettings:
            #region
            UpdateConfigEventArgs updtEvPb5s = new UpdateConfigEventArgs("pbConfigCheck5", 1, "");
            UpdateConfigEventHandler(updtEvPb5s);
            AutoPlaySettings aps = _configClass.ConfSetAutoPlaySettings;
            aps.MakeAutoplaySettings(os, _configClass);
            if (aps.CheckAutoPlaySettings(os, _configClass))
            {
              UpdateConfigEventArgs updtEvPb5t = new UpdateConfigEventArgs("pbConfigCheck5", 0, "");
              UpdateConfigEventHandler(updtEvPb5t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb5f = new UpdateConfigEventArgs("pbConfigCheck5", 2, "");
              UpdateConfigEventHandler(updtEvPb5f);
            }
            makeSettingsAll(mainStepsAll.explorerMapOptions, os);
            #endregion
            break;
          case mainStepsAll.explorerMapOptions:
            #region
            UpdateConfigEventArgs updtEvPb6s = new UpdateConfigEventArgs("pbConfigCheck6", 1, "");
            UpdateConfigEventHandler(updtEvPb6s);
            WindowsExplorerSettings WES = _configClass.ConfSetwindowsExplorerSettings;
            WES.SetExplorerMapOptions(os, _configClass);
            if (WES.CheckexplorerMapOptions(os, _configClass))
            {
              UpdateConfigEventArgs updtEvPb6t = new UpdateConfigEventArgs("pbConfigCheck6", 0, "");
              UpdateConfigEventHandler(updtEvPb6t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb6f = new UpdateConfigEventArgs("pbConfigCheck6", 2, "");
              UpdateConfigEventHandler(updtEvPb6f);
            }
            makeSettingsAll(mainStepsAll.logInShutDownSettings, os);
            #endregion
            break;
          case mainStepsAll.logInShutDownSettings:
            #region autologon
            LoginShutdownSettings LISD = _configClass.ConfSetLoginShutdownSettings;
            UpdateConfigEventArgs updtEvPb7s = new UpdateConfigEventArgs("pbConfigCheck7", 1, "");
            UpdateConfigEventHandler(updtEvPb7s);
            LISD.AutlogonSettings(os, _configClass);

            if (LISD.CheckAutoLogonSettings(os, _configClass))
            {
              UpdateConfigEventArgs updtEvPb7t = new UpdateConfigEventArgs("pbConfigCheck7", 0, "");
              UpdateConfigEventHandler(updtEvPb7t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb7f = new UpdateConfigEventArgs("pbConfigCheck7", 2, "");
              UpdateConfigEventHandler(updtEvPb7f);
            }
            #endregion autologon
            if (os != OSVersions.WindowsXP32) //Shutdown event tracker is not working in WinXP 32 bit
            {
              #region ShutDownEventTracker
              UpdateConfigEventArgs updtEvPb8s = new UpdateConfigEventArgs("pbConfigCheck8", 1, "");
              UpdateConfigEventHandler(updtEvPb8s);
              LISD.SetShutDownEventTracker(os, _configClass);
              if (LISD.CheckSetShutDownEventTracker(os, _configClass))
              {
                UpdateConfigEventArgs updtEvPb8t = new UpdateConfigEventArgs("pbConfigCheck8", 0, "");
                UpdateConfigEventHandler(updtEvPb8t);
              }
              else
              {
                UpdateConfigEventArgs updtEvPb8f = new UpdateConfigEventArgs("pbConfigCheck8", 2, "");
                UpdateConfigEventHandler(updtEvPb8f);
              }
              #endregion ShutDownEventTracker
            }
            makeSettingsAll(mainStepsAll.remoteDesktop, os);
            break;
          case mainStepsAll.remoteDesktop:
            #region
            Remotedesktop RD = _configClass.ConfSetRemotedesktop;
            UpdateConfigEventArgs updtEvPb9s = new UpdateConfigEventArgs("pbConfigCheck9", 1, "");
            UpdateConfigEventHandler(updtEvPb9s);
            RD.SetRemoteDesktopSettings(os, _configClass);
            if (RD.CheckRemoteDesktopSettings(os, _configClass))
            {
              UpdateConfigEventArgs updtEvPb9t = new UpdateConfigEventArgs("pbConfigCheck9", 0, "");
              UpdateConfigEventHandler(updtEvPb9t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb9f = new UpdateConfigEventArgs("pbConfigCheck9", 2, "");
              UpdateConfigEventHandler(updtEvPb9f);
            }
            makeSettingsAll(mainStepsAll.fireWall, os);
            #endregion
            break;
          case mainStepsAll.fireWall:
            #region
            WindowsFirewall WFW = _configClass.ConfSetWindowsFirewall;
            UpdateConfigEventArgs updtEvPb10s = new UpdateConfigEventArgs("pbConfigCheck10", 1, "");
            UpdateConfigEventHandler(updtEvPb10s);
            if (os == OSVersions.WindowsXP || os == OSVersions.WindowsXP32 || os == OSVersions.WindowsXP64)
            {
              WFW.SetFireWall(_configClass);
              WFW.DeleteFirewall(_configClass);
            }
            else
            {
              WFW.SetFireWall(_configClass);
              WFW.DeleteFirewall(_configClass);
              WFW.ModifyFirewallRules(_configClass);
            }
            if (WFW.CheckFirewallExeceptions(_configClass))
            {
              UpdateConfigEventArgs updtEvPb10t = new UpdateConfigEventArgs("pbConfigCheck10", 0, "");
              UpdateConfigEventHandler(updtEvPb10t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb10f = new UpdateConfigEventArgs("pbConfigCheck10", 2, "");
              UpdateConfigEventHandler(updtEvPb10f);
            }
            makeSettingsAll(mainStepsAll.configSQLserver, os);
            #endregion
            break;
          case mainStepsAll.configSQLserver:
            #region SQL Server
            SQLServer SQLSrv = _configClass.ConfigureSQLServer;
            UpdateConfigEventArgs updtEvPb11s = new UpdateConfigEventArgs("pbConfigCheck11", 1, "");
            UpdateConfigEventHandler(updtEvPb11s);
            //do the job for SQL
            UpdateConfigEventArgs updtEvPb11t = new UpdateConfigEventArgs("pbConfigCheck11", 0, "");
            UpdateConfigEventArgs updtEvPb11f = new UpdateConfigEventArgs("pbConfigCheck11", 2, "");
            UpdateConfigEventHandler(updtEvPb11f);
            makeSettingsAll(mainStepsAll.configPcAnywhere, os);
            #endregion SQL Server
            break;
          case mainStepsAll.configPcAnywhere:
            if (_configClass.ConfInstalledSoftware.IsApplicationInstalled("PC Anywhere"))
            {
              #region PC Anywhere
              //initiate PcAnywhere Class

              UpdateConfigEventArgs updtEvPb12s = new UpdateConfigEventArgs("pbConfigCheck12", 1, "");
              UpdateConfigEventHandler(updtEvPb12s);
              //do the PC Anywhere job
              UpdateConfigEventArgs updtEvPb12t = new UpdateConfigEventArgs("pbConfigCheck12", 0, "");
              UpdateConfigEventHandler(updtEvPb12t);           
              #endregion PC Anywhere
            }
            makeSettingsAll(mainStepsAll.configWebserver, os);
            break;
          case mainStepsAll.configWebserver:
            #region Web Server
            UpdateConfigEventArgs updtEvPb13s = new UpdateConfigEventArgs("pbConfigCheck13", 1, "");
            UpdateConfigEventHandler(updtEvPb13s);
            //Do the Web Server job
            WebServer ws = _configClass.ConfigureWebServer;
            ws.AddWebServer(_configClass);
            UpdateConfigEventArgs updtEvPb13t = new UpdateConfigEventArgs("pbConfigCheck13", 0, "");
            UpdateConfigEventArgs updtEvPb13f = new UpdateConfigEventArgs("pbConfigCheck13", 2, "");
            UpdateConfigEventHandler(updtEvPb13t);
            makeSettingsAll(mainStepsAll.configMailServer, os);
            #endregion Web Server
            break;
          case mainStepsAll.configMailServer:
            #region Mail Server
            UpdateConfigEventArgs updtEvPb14s = new UpdateConfigEventArgs("pbConfigCheck14", 1, "");
            UpdateConfigEventHandler(updtEvPb14s);
            //Do the job 
            UpdateConfigEventArgs updtEvPb14t = new UpdateConfigEventArgs("pbConfigCheck14", 0, "");
            UpdateConfigEventArgs updtEvPb14f = new UpdateConfigEventArgs("pbConfigCheck14", 2, "");
            UpdateConfigEventHandler(updtEvPb14f);
            makeSettingsAll(mainStepsAll.configFTPserver, os);
            #endregion Mail Server
            break;
          case mainStepsAll.configFTPserver:
            #region FTP Server
            UpdateConfigEventArgs updtEvPb15s = new UpdateConfigEventArgs("pbConfigCheck15", 1, "");
            UpdateConfigEventHandler(updtEvPb15s);
            //Do the job for FTP Server
            UpdateConfigEventArgs updtEvPb15t = new UpdateConfigEventArgs("pbConfigCheck15", 0, "");
            UpdateConfigEventArgs updtEvPb15f = new UpdateConfigEventArgs("pbConfigCheck15", 2, "");
            UpdateConfigEventHandler(updtEvPb15f);
            makeSettingsAll(mainStepsAll.configBlockKeys, os);

            #endregion FTP Server
            break;
          case mainStepsAll.configBlockKeys:
            if (_configClass.ConfInstalledSoftware.IsApplicationInstalled("BlockKeys"))
            {
              #region Configure BlockKeys
              UpdateConfigEventArgs updtEvPb16s = new UpdateConfigEventArgs("pbConfigCheck16", 1, "");
              UpdateConfigEventHandler(updtEvPb16s);
              //Do the job for BlockKeys
              UpdateConfigEventArgs updtEvPb16t = new UpdateConfigEventArgs("pbConfigCheck16", 0, "");
              UpdateConfigEventArgs updtEvPb16f = new UpdateConfigEventArgs("pbConfigCheck16", 2, "");

              UpdateConfigEventHandler(updtEvPb16t);
              #endregion Configure BlockKeys
            }
            makeSettingsAll(mainStepsAll.sharing, os);   
            break;
          case mainStepsAll.sharing:
            #region sharing
            UpdateConfigEventArgs updtEvPb17s = new UpdateConfigEventArgs("pbConfigCheck17", 1, "");
            UpdateConfigEventHandler(updtEvPb17s);
            //Do the job for sharing 
            SharedFolder sf = _configClass.ConfigureSharedFolders;
            sf.AddSharedFolder(_configClass);
            UpdateConfigEventArgs updtEvPb17t = new UpdateConfigEventArgs("pbConfigCheck17", 0, "");
            UpdateConfigEventArgs updtEvPb17f = new UpdateConfigEventArgs("pbConfigCheck17", 2, "");
            UpdateConfigEventHandler(updtEvPb17t);
            makeSettingsAll(mainStepsAll.ipConfig, os);
            #endregion sharing
            break;
          case mainStepsAll.ipConfig:
            #region IP Config
            UpdateConfigEventArgs updtEvPb18s = new UpdateConfigEventArgs("pbConfigCheck18", 1, "");
            UpdateConfigEventHandler(updtEvPb18s);
            //Do the job
            SetNetwork sw = _configClass.ConfigureSetNetwork;
            sw.SetNetworkStaticConfigure(os,_configClass);
            UpdateConfigEventArgs updtEvPb18t = new UpdateConfigEventArgs("pbConfigCheck18", 0, "");
            UpdateConfigEventArgs updtEvPb18f = new UpdateConfigEventArgs("pbConfigCheck18", 2, "");
            UpdateConfigEventHandler(updtEvPb18t);
            makeSettingsAll(mainStepsAll.configMBSA, os);
            #endregion IP Config
            break;
          case mainStepsAll.configMBSA:
            #region
            if (_configClass.ConfSetMicrosoftBaslineSecurityAnalyzer.MBSAchecked && _configClass.ConfInstalledSoftware.IsApplicationInstalled("Microsoft Baseline Security Analyzer"))
            {
              MicrosoftBaslineSecurityAnalyzer MBSA = _configClass.ConfSetMicrosoftBaslineSecurityAnalyzer;

              UpdateConfigEventArgs updtEvPb19s = new UpdateConfigEventArgs("pbConfigCheck19", 1, "");
              UpdateConfigEventHandler(updtEvPb19s);

              if (MBSA.SetMBSA(_configClass))
              {
                UpdateConfigEventArgs updtEvPb19t = new UpdateConfigEventArgs("pbConfigCheck19", 0, "");
                UpdateConfigEventHandler(updtEvPb19t);
                MBSA.MBSAstate = true;
                MBSAisReady = true;

                if (MBSA.MBSAkilled)
                {
                  UpdateConfigEventArgs updtEvPb19f = new UpdateConfigEventArgs("pbConfigCheck19", 2, "");
                  UpdateConfigEventHandler(updtEvPb19f);
                }
              }
              else
              {
                UpdateConfigEventArgs updtEvPb19f = new UpdateConfigEventArgs("pbConfigCheck19", 2, "");
                UpdateConfigEventHandler(updtEvPb19f);
              }
            }
            else
            {
              UpdateConfigEventArgs updtEvPb19f = new UpdateConfigEventArgs("pbConfigCheck19", 5, "");
              UpdateConfigEventHandler(updtEvPb19f);
            }

            makeSettingsAll(mainStepsAll.end, os);

            #endregion
            break;
          case mainStepsAll.end:
            #region
            string encryptionPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\ConfigFiles\configPw.dat";

            if (File.Exists(encryptionPath))
            {
              File.Delete(encryptionPath);
            }
            CreateStartupProcessForOtherAccounts CSPA = _configClass.ConfSetCreateStartupProcessForOtherAccounts;
            UpdateConfigEventArgs updtEvPb20s = new UpdateConfigEventArgs("pbConfigCheck20", 1, "");
            UpdateConfigEventHandler(updtEvPb20s);
            CSPA.CreateRegFileAndStartupBatchFile(os, _configClass);
            if (CSPA.CheckEndCreateRegFileAndStartupBatchFile(os, _configClass))
            {
              UpdateConfigEventArgs updtEvPb20t = new UpdateConfigEventArgs("pbConfigCheck20", 0, "");
              UpdateConfigEventHandler(updtEvPb20t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb20f = new UpdateConfigEventArgs("pbConfigCheck20", 2, "");
              UpdateConfigEventHandler(updtEvPb20f);
            }
            #endregion
            _mainRunning = false;
            break;

        }
      }
    }

    public void makeSettingsSecurity(mainStepsSecurity mss, OSVersions os)
    {
      if (_cancelMakeSettings)
      {
        _mainstepSecurity = mss;
        throw new Exception("cancel");
      }

      if (_mainRunning)
      {
        switch (mss)
        {
          case mainStepsSecurity.start:
            string mbsaLog = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\MBSAlog.txt";
            if (File.Exists(mbsaLog))
            {
              File.Delete(mbsaLog);
            }
            #region
            UpdateConfigEventArgs updtEvPb0s = new UpdateConfigEventArgs("pbConfigCheck0", 1, "");

            UpdateConfigEventHandler(updtEvPb0s);

            _configClass.CreateWindowsRestorePoint();

            if (_configClass.CheckWindowsRestorePointisCreated())
            {
              UpdateConfigEventArgs updtEvPb0t = new UpdateConfigEventArgs("pbConfigCheck0", 0, "");
              UpdateConfigEventHandler(updtEvPb0t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb0f = new UpdateConfigEventArgs("pbConfigCheck0", 2, "");
              UpdateConfigEventHandler(updtEvPb0f);
              string message1 = "It is not possible to create a Windows restore point\n Do you want to continue?";
              string caption1 = "System Restore disabled";
              MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
              DialogResult result;
              // Displays the MessageBox.
              result = MessageBox.Show(message1, caption1, buttons);

              if (result == System.Windows.Forms.DialogResult.Cancel)
              {
                Application.Exit();
              }
            }
            _checkIfthereAreChanges = true;
            makeSettingsSecurity(mainStepsSecurity.passWordPolicy, os);
            #endregion
            break;
          case mainStepsSecurity.passWordPolicy:
            #region
            PasswordPolicy pp = _configClass.ConfSetPasswordPolicy;
            UpdateConfigEventArgs updtEvPb1s = new UpdateConfigEventArgs("pbConfigCheck1", 1, "");
            UpdateConfigEventHandler(updtEvPb1s);
            pp.SetPasswordPolicy(_configClass);
            if (pp.CheckPasswordPolicy(_configClass))
            {
              UpdateConfigEventArgs updtEvPb1t = new UpdateConfigEventArgs("pbConfigCheck1", 0, "");
              UpdateConfigEventHandler(updtEvPb1t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb1f = new UpdateConfigEventArgs("pbConfigCheck1", 2, "");
              UpdateConfigEventHandler(updtEvPb1f);
            }
            makeSettingsSecurity(mainStepsSecurity.controlPolicy, os);
            #endregion
            break;
          case mainStepsSecurity.controlPolicy:
            #region
            AuditPolicy ap = _configClass.ConfSetAuditPolicy;
            UpdateConfigEventArgs updtEvPb2s = new UpdateConfigEventArgs("pbConfigCheck2", 1, "");
            UpdateConfigEventHandler(updtEvPb2s);
            ap.CompleteAuditPolicy(_configClass);
            if (ap.CheckAuditPolicy(_configClass))
            {
              UpdateConfigEventArgs updtEvPb1t = new UpdateConfigEventArgs("pbConfigCheck2", 0, "");
              UpdateConfigEventHandler(updtEvPb1t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb1f = new UpdateConfigEventArgs("pbConfigCheck2", 2, "");
              UpdateConfigEventHandler(updtEvPb1f);
            }

            makeSettingsSecurity(mainStepsSecurity.addUserGroup, os);
            #endregion
            break;
          case mainStepsSecurity.addUserGroup:
            #region
            WindowsUsergroup wug = _configClass.ConfSetWindowsUsergroup;
            UpdateConfigEventArgs updtEvPb3s = new UpdateConfigEventArgs("pbConfigCheck3", 1, "");
            UpdateConfigEventHandler(updtEvPb3s);
            bool created = false;
            bool deleted = false;
            wug.DeleteUserGroups(_configClass);
            if (wug.CheckUsergroupDeleted(_configClass))
            {
              deleted = true;
            }
            wug.AddUserGroups(_configClass);
            if (wug.CheckUsergroupCreated(_configClass))
            {
              created = true;
            }

            if (created && deleted)
            {
              UpdateConfigEventArgs updtEvPb3t = new UpdateConfigEventArgs("pbConfigCheck3", 0, "");
              UpdateConfigEventHandler(updtEvPb3t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb3f = new UpdateConfigEventArgs("pbConfigCheck3", 2, "");
              UpdateConfigEventHandler(updtEvPb3f);
            }
            makeSettingsSecurity(mainStepsSecurity.addUser, os);
            #endregion
            break;
          case mainStepsSecurity.addUser:
            #region
            UpdateConfigEventArgs updtEvPb4s = new UpdateConfigEventArgs("pbConfigCheck4", 1, "");
            UpdateConfigEventHandler(updtEvPb4s);
            WindowsUsers wu = _configClass.ConfSetWindowsUsers;
            wu.DeleteUsers(_configClass);
            wu.AddUsers(_configClass, _encryptionPassword);
            wu.ModifyUsers(_configClass, _encryptionPassword);
            if (wu.CheckUserDeleted(_configClass) && wu.CheckUserCreated(_configClass) && wu.CheckUserModified(_configClass))
            {
              UpdateConfigEventArgs updtEvPb4t = new UpdateConfigEventArgs("pbConfigCheck4", 0, "");
              UpdateConfigEventHandler(updtEvPb4t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb4f = new UpdateConfigEventArgs("pbConfigCheck4", 2, "");
              UpdateConfigEventHandler(updtEvPb4f);
            }

            makeSettingsSecurity(mainStepsSecurity.autoPlaySettings, os);
            #endregion
            break;
          case mainStepsSecurity.autoPlaySettings:
            #region
            UpdateConfigEventArgs updtEvPb5s = new UpdateConfigEventArgs("pbConfigCheck5", 1, "");
            UpdateConfigEventHandler(updtEvPb5s);
            AutoPlaySettings aps = _configClass.ConfSetAutoPlaySettings;
            aps.MakeAutoplaySettings(os, _configClass);
            if (aps.CheckAutoPlaySettings(os, _configClass))
            {
              UpdateConfigEventArgs updtEvPb5t = new UpdateConfigEventArgs("pbConfigCheck5", 0, "");
              UpdateConfigEventHandler(updtEvPb5t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb5f = new UpdateConfigEventArgs("pbConfigCheck5", 2, "");
              UpdateConfigEventHandler(updtEvPb5f);
            }
            makeSettingsSecurity(mainStepsSecurity.explorerMapOptions, os);
            #endregion
            break;
          case mainStepsSecurity.explorerMapOptions:
            #region
            UpdateConfigEventArgs updtEvPb6s = new UpdateConfigEventArgs("pbConfigCheck6", 1, "");
            UpdateConfigEventHandler(updtEvPb6s);
            WindowsExplorerSettings WES = _configClass.ConfSetwindowsExplorerSettings;
            WES.SetExplorerMapOptions(os, _configClass);
            if (WES.CheckexplorerMapOptions(os, _configClass))
            {
              UpdateConfigEventArgs updtEvPb6t = new UpdateConfigEventArgs("pbConfigCheck6", 0, "");
              UpdateConfigEventHandler(updtEvPb6t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb6f = new UpdateConfigEventArgs("pbConfigCheck6", 2, "");
              UpdateConfigEventHandler(updtEvPb6f);
            }
            makeSettingsSecurity(mainStepsSecurity.logInShutDownSettings, os);
            #endregion
            break;
          case mainStepsSecurity.logInShutDownSettings:
            #region autologon
            LoginShutdownSettings LISD = _configClass.ConfSetLoginShutdownSettings;
            UpdateConfigEventArgs updtEvPb7s = new UpdateConfigEventArgs("pbConfigCheck7", 1, "");
            UpdateConfigEventHandler(updtEvPb7s);
            LISD.AutlogonSettings(os, _configClass);

            if (LISD.CheckAutoLogonSettings(os, _configClass))
            {
              UpdateConfigEventArgs updtEvPb7t = new UpdateConfigEventArgs("pbConfigCheck7", 0, "");
              UpdateConfigEventHandler(updtEvPb7t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb7f = new UpdateConfigEventArgs("pbConfigCheck7", 2, "");
              UpdateConfigEventHandler(updtEvPb7f);
            }
            #endregion autologon
            if (os != OSVersions.WindowsXP32) //Shutdown event tracker is not working in WinXP 32 bit
            {
              #region ShutDownEventTracker
              UpdateConfigEventArgs updtEvPb8s = new UpdateConfigEventArgs("pbConfigCheck8", 1, "");
              UpdateConfigEventHandler(updtEvPb8s);
              LISD.SetShutDownEventTracker(os, _configClass);
              if (LISD.CheckSetShutDownEventTracker(os, _configClass))
              {
                UpdateConfigEventArgs updtEvPb8t = new UpdateConfigEventArgs("pbConfigCheck8", 0, "");
                UpdateConfigEventHandler(updtEvPb8t);
              }
              else
              {
                UpdateConfigEventArgs updtEvPb8f = new UpdateConfigEventArgs("pbConfigCheck8", 2, "");
                UpdateConfigEventHandler(updtEvPb8f);
              }
              #endregion ShutDownEventTracker
            }
            makeSettingsSecurity(mainStepsSecurity.remoteDesktop, os);
            break;
          case mainStepsSecurity.remoteDesktop:
            #region
            Remotedesktop RD = _configClass.ConfSetRemotedesktop;
            UpdateConfigEventArgs updtEvPb9s = new UpdateConfigEventArgs("pbConfigCheck9", 1, "");
            UpdateConfigEventHandler(updtEvPb9s);
            RD.SetRemoteDesktopSettings(os, _configClass);
            if (RD.CheckRemoteDesktopSettings(os, _configClass))
            {
              UpdateConfigEventArgs updtEvPb9t = new UpdateConfigEventArgs("pbConfigCheck9", 0, "");
              UpdateConfigEventHandler(updtEvPb9t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb9f = new UpdateConfigEventArgs("pbConfigCheck9", 2, "");
              UpdateConfigEventHandler(updtEvPb9f);
            }
            makeSettingsSecurity(mainStepsSecurity.fireWall, os);
            #endregion
            break;
          case mainStepsSecurity.fireWall:
            #region
            WindowsFirewall WFW = _configClass.ConfSetWindowsFirewall;
            UpdateConfigEventArgs updtEvPb10s = new UpdateConfigEventArgs("pbConfigCheck10", 1, "");
            UpdateConfigEventHandler(updtEvPb10s);
            WFW.SetFireWall(_configClass);
            if (WFW.CheckFirewallExeceptions(_configClass))
            {
              UpdateConfigEventArgs updtEvPb10t = new UpdateConfigEventArgs("pbConfigCheck10", 0, "");
              UpdateConfigEventHandler(updtEvPb10t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb10f = new UpdateConfigEventArgs("pbConfigCheck10", 2, "");
              UpdateConfigEventHandler(updtEvPb10f);
            }
            makeSettingsSecurity(mainStepsSecurity.configSQLserver, os);
            #endregion
            break;
          case mainStepsSecurity.configSQLserver:
            #region SQL Server
            SQLServer SQLSrv = _configClass.ConfigureSQLServer;
            UpdateConfigEventArgs updtEvPb11s = new UpdateConfigEventArgs("pbConfigCheck11", 1, "");
            UpdateConfigEventHandler(updtEvPb11s);
            //do the job for SQL
            UpdateConfigEventArgs updtEvPb11t = new UpdateConfigEventArgs("pbConfigCheck11", 0, "");
            UpdateConfigEventArgs updtEvPb11f = new UpdateConfigEventArgs("pbConfigCheck11", 2, "");
            UpdateConfigEventHandler(updtEvPb11f);
            makeSettingsSecurity(mainStepsSecurity.configWebserver, os);
            #endregion SQL Server
            break;

          case mainStepsSecurity.configWebserver:
            #region Web Server
            UpdateConfigEventArgs updtEvPb13s = new UpdateConfigEventArgs("pbConfigCheck13", 1, "");
            UpdateConfigEventHandler(updtEvPb13s);
            //Do the Web Server job
            UpdateConfigEventArgs updtEvPb13t = new UpdateConfigEventArgs("pbConfigCheck13", 0, "");
            UpdateConfigEventArgs updtEvPb13f = new UpdateConfigEventArgs("pbConfigCheck13", 2, "");
            UpdateConfigEventHandler(updtEvPb13f);
            makeSettingsSecurity(mainStepsSecurity.configMailServer, os);
            #endregion Web Server
            break;
          case mainStepsSecurity.configMailServer:
            #region Mail Server
            UpdateConfigEventArgs updtEvPb14s = new UpdateConfigEventArgs("pbConfigCheck14", 1, "");
            UpdateConfigEventHandler(updtEvPb14s);
            //Do the job 
            UpdateConfigEventArgs updtEvPb14t = new UpdateConfigEventArgs("pbConfigCheck14", 0, "");
            UpdateConfigEventArgs updtEvPb14f = new UpdateConfigEventArgs("pbConfigCheck14", 2, "");
            UpdateConfigEventHandler(updtEvPb14f);
            makeSettingsSecurity(mainStepsSecurity.configFTPserver, os);
            #endregion Mail Server
            break;
          case mainStepsSecurity.configFTPserver:
            #region FTP Server
            UpdateConfigEventArgs updtEvPb15s = new UpdateConfigEventArgs("pbConfigCheck15", 1, "");
            UpdateConfigEventHandler(updtEvPb15s);
            //Do the job for FTP Server
            UpdateConfigEventArgs updtEvPb15t = new UpdateConfigEventArgs("pbConfigCheck15", 0, "");
            UpdateConfigEventArgs updtEvPb15f = new UpdateConfigEventArgs("pbConfigCheck15", 2, "");
            UpdateConfigEventHandler(updtEvPb15f);
            makeSettingsSecurity(mainStepsSecurity.ipConfig, os);
            #endregion FTP Server
            break;

          case mainStepsSecurity.ipConfig:
            #region IP Config
            UpdateConfigEventArgs updtEvPb18s = new UpdateConfigEventArgs("pbConfigCheck18", 1, "");
            UpdateConfigEventHandler(updtEvPb18s);
            //Do the job
            UpdateConfigEventArgs updtEvPb18t = new UpdateConfigEventArgs("pbConfigCheck18", 0, "");
            UpdateConfigEventArgs updtEvPb18f = new UpdateConfigEventArgs("pbConfigCheck18", 2, "");
            UpdateConfigEventHandler(updtEvPb18f);
            makeSettingsSecurity(mainStepsSecurity.configMBSA, os);
            #endregion IP Config
            break;
          case mainStepsSecurity.configMBSA:
            #region
            if (_configClass.ConfSetMicrosoftBaslineSecurityAnalyzer.MBSAchecked && _configClass.ConfInstalledSoftware.IsApplicationInstalled("Microsoft Baseline Security Analyzer"))
            {
              MicrosoftBaslineSecurityAnalyzer MBSA = _configClass.ConfSetMicrosoftBaslineSecurityAnalyzer;

              UpdateConfigEventArgs updtEvPb19s = new UpdateConfigEventArgs("pbConfigCheck19", 1, "");
              UpdateConfigEventHandler(updtEvPb19s);

              if (MBSA.SetMBSA(_configClass))
              {
                UpdateConfigEventArgs updtEvPb19t = new UpdateConfigEventArgs("pbConfigCheck19", 0, "");
                UpdateConfigEventHandler(updtEvPb19t);
                MBSA.MBSAstate = true;
                MBSAisReady = true;

                if (MBSA.MBSAkilled)
                {
                  UpdateConfigEventArgs updtEvPb19f = new UpdateConfigEventArgs("pbConfigCheck19", 2, "");
                  UpdateConfigEventHandler(updtEvPb19f);
                }
              }
              else
              {
                UpdateConfigEventArgs updtEvPb19f = new UpdateConfigEventArgs("pbConfigCheck19", 2, "");
                UpdateConfigEventHandler(updtEvPb19f);
              }
            }
            else
            {
              UpdateConfigEventArgs updtEvPb19f = new UpdateConfigEventArgs("pbConfigCheck19", 5, "");
              UpdateConfigEventHandler(updtEvPb19f);
            }

            makeSettingsSecurity(mainStepsSecurity.end, os);

            #endregion
            break;
          case mainStepsSecurity.end:
            #region
            string encryptionPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\ConfigFiles\configPw.dat";

            if (File.Exists(encryptionPath))
            {
              File.Delete(encryptionPath);
            }
            CreateStartupProcessForOtherAccounts CSPA = _configClass.ConfSetCreateStartupProcessForOtherAccounts;
            UpdateConfigEventArgs updtEvPb20s = new UpdateConfigEventArgs("pbConfigCheck20", 1, "");
            UpdateConfigEventHandler(updtEvPb20s);
            CSPA.CreateRegFileAndStartupBatchFile(os, _configClass);
            if (CSPA.CheckEndCreateRegFileAndStartupBatchFile(os, _configClass))
            {
              UpdateConfigEventArgs updtEvPb20t = new UpdateConfigEventArgs("pbConfigCheck20", 0, "");
              UpdateConfigEventHandler(updtEvPb20t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb20f = new UpdateConfigEventArgs("pbConfigCheck20", 2, "");
              UpdateConfigEventHandler(updtEvPb20f);
            }
            #endregion
            _mainRunning = false;
            break;

        }
      }
    }
    public void makeSettingsLock(mainStepsLock msl, OSVersions os)
    {
      if (_cancelMakeSettings)
      {
        _mainstepLock = msl;
        throw new Exception("cancel");
      }

      if (_mainRunning)
      {

        switch (msl)
        {
          case mainStepsLock.start:
            string mbsaLog = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\MBSAlog.txt";
            if (File.Exists(mbsaLog))
            {
              File.Delete(mbsaLog);
            }
            #region
            UpdateConfigEventArgs updtEvPb0s = new UpdateConfigEventArgs("pbConfigCheck0", 1, "");

            UpdateConfigEventHandler(updtEvPb0s);

            _configClass.CreateWindowsRestorePoint();

            if (_configClass.CheckWindowsRestorePointisCreated())
            {
              UpdateConfigEventArgs updtEvPb0t = new UpdateConfigEventArgs("pbConfigCheck0", 0, "");
              UpdateConfigEventHandler(updtEvPb0t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb0f = new UpdateConfigEventArgs("pbConfigCheck0", 2, "");
              UpdateConfigEventHandler(updtEvPb0f);
              string message1 = "It is not possible to create a Windows restore point\n Do you want to continue?";
              string caption1 = "System Restore disabled";
              MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
              DialogResult result;
              // Displays the MessageBox.
              result = MessageBox.Show(message1, caption1, buttons);

              if (result == System.Windows.Forms.DialogResult.Cancel)
              {
                Application.Exit();
              }
            }
            _checkIfthereAreChanges = true;
            makeSettingsLock(mainStepsLock.autoPlaySettings, os);
            #endregion
            break;



          case mainStepsLock.autoPlaySettings:
            #region
            UpdateConfigEventArgs updtEvPb5s = new UpdateConfigEventArgs("pbConfigCheck5", 1, "");
            UpdateConfigEventHandler(updtEvPb5s);
            AutoPlaySettings aps = _configClass.ConfSetAutoPlaySettings;
            aps.MakeAutoplaySettings(os, _configClass);
            if (aps.CheckAutoPlaySettings(os, _configClass))
            {
              UpdateConfigEventArgs updtEvPb5t = new UpdateConfigEventArgs("pbConfigCheck5", 0, "");
              UpdateConfigEventHandler(updtEvPb5t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb5f = new UpdateConfigEventArgs("pbConfigCheck5", 2, "");
              UpdateConfigEventHandler(updtEvPb5f);
            }
            makeSettingsLock(mainStepsLock.explorerMapOptions, os);
            #endregion
            break;
          case mainStepsLock.explorerMapOptions:
            #region
            UpdateConfigEventArgs updtEvPb6s = new UpdateConfigEventArgs("pbConfigCheck6", 1, "");
            UpdateConfigEventHandler(updtEvPb6s);
            WindowsExplorerSettings WES = _configClass.ConfSetwindowsExplorerSettings;
            WES.SetExplorerMapOptions(os, _configClass);
            if (WES.CheckexplorerMapOptions(os, _configClass))
            {
              UpdateConfigEventArgs updtEvPb6t = new UpdateConfigEventArgs("pbConfigCheck6", 0, "");
              UpdateConfigEventHandler(updtEvPb6t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb6f = new UpdateConfigEventArgs("pbConfigCheck6", 2, "");
              UpdateConfigEventHandler(updtEvPb6f);
            }
            makeSettingsLock(mainStepsLock.fireWall, os);
            #endregion
            break;


          case mainStepsLock.fireWall:
            #region
            WindowsFirewall WFW = _configClass.ConfSetWindowsFirewall;
            UpdateConfigEventArgs updtEvPb10s = new UpdateConfigEventArgs("pbConfigCheck10", 1, "");
            UpdateConfigEventHandler(updtEvPb10s);
            WFW.SetFireWall(_configClass);
            if (WFW.CheckFirewallExeceptions(_configClass))
            {
              UpdateConfigEventArgs updtEvPb10t = new UpdateConfigEventArgs("pbConfigCheck10", 0, "");
              UpdateConfigEventHandler(updtEvPb10t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb10f = new UpdateConfigEventArgs("pbConfigCheck10", 2, "");
              UpdateConfigEventHandler(updtEvPb10f);
            }
            makeSettingsLock(mainStepsLock.configPcAnywhere, os);
            #endregion
            break;
          
          case mainStepsLock.configPcAnywhere:
            if (_configClass.ConfInstalledSoftware.IsApplicationInstalled("PC Anywhere"))
            {
              #region PC Anywhere

              //initiate PcAnywhere Class

              UpdateConfigEventArgs updtEvPb12s = new UpdateConfigEventArgs("pbConfigCheck12", 1, "");
              UpdateConfigEventHandler(updtEvPb12s);
              //do the PC Anywhere job
              UpdateConfigEventArgs updtEvPb12t = new UpdateConfigEventArgs("pbConfigCheck12", 0, "");
              UpdateConfigEventArgs updtEvPb12f = new UpdateConfigEventArgs("pbConfigCheck12", 2, "");


              #endregion PC Anywhere
            }
            makeSettingsLock(mainStepsLock.configBlockKeys, os);
            break;

          case mainStepsLock.configBlockKeys:
            if (_configClass.ConfInstalledSoftware.IsApplicationInstalled("BlockKeys"))
            {
              #region Configure BlockKeys
              UpdateConfigEventArgs updtEvPb16s = new UpdateConfigEventArgs("pbConfigCheck16", 1, "");
              UpdateConfigEventHandler(updtEvPb16s);
              //Do the job for BlockKeys
              UpdateConfigEventArgs updtEvPb16t = new UpdateConfigEventArgs("pbConfigCheck16", 0, "");
              UpdateConfigEventArgs updtEvPb16f = new UpdateConfigEventArgs("pbConfigCheck16", 2, "");
              UpdateConfigEventHandler(updtEvPb16f);
              #endregion Configure BlockKeys
            }
            makeSettingsLock(mainStepsLock.sharing, os);
            break;
          case mainStepsLock.sharing:
            #region sharing
            UpdateConfigEventArgs updtEvPb17s = new UpdateConfigEventArgs("pbConfigCheck17", 1, "");
            UpdateConfigEventHandler(updtEvPb17s);
            //Do the job for sharing 
            UpdateConfigEventArgs updtEvPb17t = new UpdateConfigEventArgs("pbConfigCheck17", 0, "");
            UpdateConfigEventArgs updtEvPb17f = new UpdateConfigEventArgs("pbConfigCheck17", 2, "");
            UpdateConfigEventHandler(updtEvPb17f);
            makeSettingsLock(mainStepsLock.configMBSA, os);
            #endregion sharing
            break;

          case mainStepsLock.configMBSA:
            #region
            if (_configClass.ConfSetMicrosoftBaslineSecurityAnalyzer.MBSAchecked && _configClass.ConfInstalledSoftware.IsApplicationInstalled("Microsoft Baseline Security Analyzer"))
            {
              MicrosoftBaslineSecurityAnalyzer MBSA = _configClass.ConfSetMicrosoftBaslineSecurityAnalyzer;

              UpdateConfigEventArgs updtEvPb19s = new UpdateConfigEventArgs("pbConfigCheck19", 1, "");
              UpdateConfigEventHandler(updtEvPb19s);

              if (MBSA.SetMBSA(_configClass))
              {
                UpdateConfigEventArgs updtEvPb19t = new UpdateConfigEventArgs("pbConfigCheck19", 0, "");
                UpdateConfigEventHandler(updtEvPb19t);
                MBSA.MBSAstate = true;
                MBSAisReady = true;

                if (MBSA.MBSAkilled)
                {
                  UpdateConfigEventArgs updtEvPb19f = new UpdateConfigEventArgs("pbConfigCheck19", 2, "");
                  UpdateConfigEventHandler(updtEvPb19f);
                }
              }
              else
              {
                UpdateConfigEventArgs updtEvPb19f = new UpdateConfigEventArgs("pbConfigCheck19", 2, "");
                UpdateConfigEventHandler(updtEvPb19f);
              }
            }
            else
            {
              UpdateConfigEventArgs updtEvPb19f = new UpdateConfigEventArgs("pbConfigCheck19", 5, "");
              UpdateConfigEventHandler(updtEvPb19f);
            }

            makeSettingsLock(mainStepsLock.end, os);

            #endregion
            break;
          case mainStepsLock.end:
            #region
            string encryptionPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\ConfigFiles\configPw.dat";

            if (File.Exists(encryptionPath))
            {
              File.Delete(encryptionPath);
            }
            CreateStartupProcessForOtherAccounts CSPA = _configClass.ConfSetCreateStartupProcessForOtherAccounts;
            UpdateConfigEventArgs updtEvPb20s = new UpdateConfigEventArgs("pbConfigCheck20", 1, "");
            UpdateConfigEventHandler(updtEvPb20s);
            CSPA.CreateRegFileAndStartupBatchFile(os, _configClass);
            if (CSPA.CheckEndCreateRegFileAndStartupBatchFile(os, _configClass))
            {
              UpdateConfigEventArgs updtEvPb20t = new UpdateConfigEventArgs("pbConfigCheck20", 0, "");
              UpdateConfigEventHandler(updtEvPb20t);
            }
            else
            {
              UpdateConfigEventArgs updtEvPb20f = new UpdateConfigEventArgs("pbConfigCheck20", 2, "");
              UpdateConfigEventHandler(updtEvPb20f);
            }
            #endregion
            _mainRunning = false;
            break;

        }
      }
    }


  }
}