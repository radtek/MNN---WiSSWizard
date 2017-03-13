using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Actemium.WiSSWizard.Support;

namespace Actemium.WiSSWizard.Pages
{
    public partial class CheckCurrentSafety : BaseFormPage
    {
        const string CLASSNAME = "CheckCurrentSafety";
        private List<PictureBox> _controlpbList = new List<PictureBox>();
        public enum controlSteps
        {
            start,
            passWordPolicy,
            controlPolicy,
            addUserGroup,
            addUser,
            autoPlaySettings,
            explorerMapOptions,
            AutologInSettings,
            ShutDownEventTracker,
            remoteDesktop,
            sharing,
            fireWall,
            configPcAnywhere,
            configBlockKeys,
            configSQLserver,
            configWebserver,
            configFTPserver,
            configMailserver,
            ipconfig,
            wirelessConfigure,
            configMBSA,
            end
        };
        private FileHandling _fh;
        private ScriptHandling _sh;
        private ConfigClass _configClass;
        private CtrlHome _ctrlHome;
        private MainProgram _mainProgram;
        private string _controlFilePath = "";
        private bool _running = true;
        private BackgroundWorker m_AsyncWorker = new BackgroundWorker();
        string lastStepBeforeQuit = null;
                
        
        public CheckCurrentSafety(CtrlHome ctrlhome , ConfigClass configClass)
        {
            InitializeComponent();
            _ctrlHome = ctrlhome;
            _mainProgram = new MainProgram(CtrlHome.GetConfigClass);
            _sh = CtrlHome.GetConfigClass.GetScriptHandling;
            _configClass = configClass;
            _fh = new FileHandling(_configClass);
            #region MainProgram images init
            _controlpbList.Add(pbConfigCheck1);
            _controlpbList.Add(pbConfigCheck2);
            _controlpbList.Add(pbConfigCheck3);
            _controlpbList.Add(pbConfigCheck4);
            _controlpbList.Add(pbConfigCheck5);
            _controlpbList.Add(pbConfigCheck6);
            _controlpbList.Add(pbConfigCheck7);
            _controlpbList.Add(pbConfigCheck8);
            _controlpbList.Add(pbConfigCheck9);
            _controlpbList.Add(pbConfigCheck10);
            _controlpbList.Add(pbConfigCheck11);
            _controlpbList.Add(pbConfigCheck12);

            _controlpbList[0].Image = checkImages.Images[3];
            setPboxImages(1,true);
            #endregion MainProgram images init
            
        }

        public void setPboxImages(int start, bool init)
        {
            for (int i = start-1; i < _controlpbList.Count; i++)
            {
                if (init)
                {
                    _controlpbList[i].Image = checkImages.Images[3];
                }
                else
                {
                    _controlpbList[i].Image = checkImages.Images[2];
                }

            }


            if (!CtrlHome.GetConfigClass.ConfInstalledSoftware.IsApplicationInstalled("Microsoft Baseline Security Analyzer"))
            {
                pbConfigCheck12.Image = checkImages.Images[5];
            }
        }

        #region Init
        #region ControlfileHeaders
        private string CFHSelectNameAndSystem = "General information:";
        private string CFHInstalledApllications = "Installed Software:";
        private string CFHPasswordPolicy = "Password policy:";
        private string CFHControlPolicy = "Control policy:";
        private string CFHGroups = "Windows user groups";
        private string CFHUsers = "Windows users";
        private string CFHAutoPlay = "Autoplay settings:";
        private string CFHExplorer = "Windows Explorer settings:";
        private string CFHAutoLogon = "AutoLogon settings:";
        private string CFHshutDownEventTracker = "Shutdown eventtracker settings:";
        private string CFHremoteDesktop = "Remote Desktop settings:";
        private string CFHsharing = "wpSharing";
        private string CFHfirewall = "Firewall settings:";
        private string CFHPcAnywhere = "wpPcAnywhere";
        private string CFHBlockKeys = "wpBlockKeys";
        private string CFHSQLserver = "wpSQLserver";
        private string CFHWebServer = "wpWebServer";
        private string CFHFTPserver = "wpFTPserver";
        private string CFHMailServer = "wpMailServer";
        private string CFHNetworkConfig = "wpNetworkConfigure";
        private string CFHMBSA = "wpMBSA";
        #endregion ControlfileHeaders
        public void Init()
        {
            #region createLogfile init
            _controlFilePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\currentControl\";
            _fh = new FileHandling(_configClass);
            _fh.FilePath = _controlFilePath + _fh.CreateFileName(".txt");
            _fh.CreateFile(_fh.FilePath.ToString());

            _controlFilePath = _fh.FilePath;
            DateTime dt = DateTime.Now;
            _fh.AddLineToEndFile(_controlFilePath, "Current security settings of your system");
            _fh.AddLineToEndFile(_controlFilePath, "            " + dt.DayOfWeek + " " + dt.Day + "-" + dt.Month + "-" + dt.Year);

            #endregion createLogfile init

            #region MainProgram images init
                     
            foreach (PictureBox pb in _controlpbList)
            {
                pb.Image = checkImages.Images[3];
            }

            if (!CtrlHome.GetConfigClass.ConfInstalledSoftware.IsApplicationInstalled("Microsoft Baseline Security Analyzer"))
            {
                pbConfigCheck12.Image = checkImages.Images[5];
            }

            #endregion MainProgram images init
        }
        #endregion Init

        private void btStart_Click(object sender, EventArgs e)
        {
            Init();
            btStart.Enabled = false;
            btStop.Enabled = true;
            btClose.Enabled = false;
            _running = true;
            backgroundWorker1.RunWorkerAsync();   
         

        }

        private void btStop_Click(object sender, EventArgs e)
        {
            btStart.Enabled = true;
            btStop.Enabled = false;
            
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
            }
            _running = false;

            btClose.Enabled = true;
            CtrlHome.GetConfigClass.ConfSetMicrosoftBaslineSecurityAnalyzer.KillMBSAProcessesByClosing("mbsacli");
          
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            CtrlHome.GetConfigClass.ConfSetMicrosoftBaslineSecurityAnalyzer.KillMBSAProcessesByClosing("mbsacli");
            string mbsaLog = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\MBSAlog.txt";
            if(File.Exists(mbsaLog))
            {
            File.Delete(mbsaLog);
            }
            this.Close();
        }

        private void btViewRapport_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_controlFilePath);
        }

        public void MakeControl(string logFilePath, controlSteps cs, OSVersions os,ConfigClass configClass)
        {
            if (_running)
            {
                switch (cs)
                {
                    case controlSteps.start:
                        #region
                    MakeControl(logFilePath, controlSteps.passWordPolicy, os, configClass);
                        #endregion
                        break;
                    case controlSteps.passWordPolicy:
                        #region
                        pbConfigCheck1.Image = checkImages.Images[1];
                        if (MakePassWordPolicyControl(logFilePath, os))
                        {
                            pbConfigCheck1.Image = checkImages.Images[0];
                        }
                        else
                        {
                            pbConfigCheck1.Image = checkImages.Images[2];
                        }

                        MakeControl(logFilePath, controlSteps.controlPolicy, os, configClass);
                        #endregion
                        break;
                    case controlSteps.controlPolicy:
                        #region
                        pbConfigCheck2.Image = checkImages.Images[1];
                        if (MakeAuditPolicyControl(logFilePath, os))
                        {
                            pbConfigCheck2.Image = checkImages.Images[0];
                        }
                        else
                        {
                            pbConfigCheck2.Image = checkImages.Images[2];
                        }

                        MakeControl(logFilePath, controlSteps.addUserGroup, os, configClass);
                        #endregion
                        break;
                    case controlSteps.addUserGroup:
                        #region
                        pbConfigCheck3.Image = checkImages.Images[1];
                        if (MakeUserGroupControl(logFilePath, os))
                        {
                            pbConfigCheck3.Image = checkImages.Images[0];
                        }
                        else
                        {
                            pbConfigCheck3.Image = checkImages.Images[2];
                        }
                        MakeControl(logFilePath, controlSteps.addUser, os, configClass);
                        #endregion
                        break;
                    case controlSteps.addUser:
                        #region
                        pbConfigCheck4.Image = checkImages.Images[1];
                        if (MakeUserControl(logFilePath, os))
                        {
                            pbConfigCheck4.Image = checkImages.Images[0];
                        }
                        else
                        {
                            pbConfigCheck4.Image = checkImages.Images[2];
                        }
                        MakeControl(logFilePath, controlSteps.autoPlaySettings, os, configClass);
                        #endregion
                        break;
                    case controlSteps.autoPlaySettings:
                        #region
                        pbConfigCheck5.Image = checkImages.Images[1];
                        if (MakeAutoPlayControl(logFilePath, os))
                        {
                            pbConfigCheck5.Image = checkImages.Images[0];
                        }
                        else
                        {
                            pbConfigCheck5.Image = checkImages.Images[2];
                        }
                        MakeControl(logFilePath, controlSteps.ipconfig, os, configClass);
                        #endregion
                        break;
                    case controlSteps.ipconfig:
                        #region
                        pbConfigCheck11.Image = checkImages.Images[1];
                        if (MakeCurrentIpSettings(logFilePath, os))
                        {
                          pbConfigCheck11.Image = checkImages.Images[0];
                        }
                        else
                        {
                          pbConfigCheck11.Image = checkImages.Images[2];
                        }
                        MakeControl(logFilePath, controlSteps.explorerMapOptions, os, configClass);

                        #endregion
                        break;
                    case controlSteps.explorerMapOptions:
                        #region
                        pbConfigCheck6.Image = checkImages.Images[1];
                        if (MakeExplorerFolderOptionsControl(logFilePath, os))
                        {
                            pbConfigCheck6.Image = checkImages.Images[0];
                        }
                        else
                        {
                            pbConfigCheck6.Image = checkImages.Images[2];
                        }
                        MakeControl(logFilePath, controlSteps.AutologInSettings, os, configClass);
                        #endregion
                        break;
                    case controlSteps.AutologInSettings:
                        #region
                        pbConfigCheck7.Image = checkImages.Images[1];
                        if (MakeAutoLogInControl(logFilePath, os))
                        {
                            pbConfigCheck7.Image = checkImages.Images[0];
                        }
                        else
                        {
                            pbConfigCheck7.Image = checkImages.Images[2];
                            pbConfigCheck8.Image = checkImages.Images[2];
                        }
                        MakeControl(logFilePath, controlSteps.ShutDownEventTracker, os, configClass);
                        #endregion
                        break;
                    case controlSteps.ShutDownEventTracker:
                        #region
                        pbConfigCheck8.Image = checkImages.Images[1];
                        if (MakeShutdownEventTrackerControl(logFilePath, os))
                        {
                            pbConfigCheck8.Image = checkImages.Images[0];
                        }
                        else
                        {
                            pbConfigCheck8.Image = checkImages.Images[2];
                        }
                        MakeControl(logFilePath, controlSteps.remoteDesktop, os, configClass);
                        #endregion
                        break;
                    case controlSteps.remoteDesktop:
                        #region
                        pbConfigCheck9.Image = checkImages.Images[1];
                        if (MakeRemoteDesktopControl(logFilePath, os))
                        {
                            pbConfigCheck9.Image = checkImages.Images[0];
                        }
                        else
                        {
                            pbConfigCheck9.Image = checkImages.Images[2];
                        }
                        MakeControl(logFilePath, controlSteps.fireWall, os, configClass);
                        #endregion
                        break;
                    case controlSteps.fireWall:
                        #region
                        pbConfigCheck10.Image = checkImages.Images[1];
                        if (MakeFireWallControl(logFilePath, os))
                        {
                            pbConfigCheck10.Image = checkImages.Images[0];
                        }
                        else
                        {
                            pbConfigCheck10.Image = checkImages.Images[2];
                        }
                        MakeControl(logFilePath, controlSteps.configMBSA, os, configClass);
                        #endregion
                        break;
                    
                    
                    case controlSteps.configMBSA:
                        #region
                        if (CtrlHome.GetConfigClass.ConfInstalledSoftware.IsApplicationInstalled("Microsoft Baseline Security Analyzer"))
                        {
                            
                            pbConfigCheck12.Image = checkImages.Images[1];
                            setLabel("MBSA system scan (Can take several minutes)");
                            if (MakeMBSAControl(logFilePath, os,configClass))
                            {
                                setLabel("MBSA system scan");
                                pbConfigCheck12.Image = checkImages.Images[0];
                            }
                            else
                            {
                                setLabel("MBSA system scan");
                                pbConfigCheck12.Image = checkImages.Images[2];
                            }
                        }
                        MakeControl(logFilePath, controlSteps.end, os, configClass);
                        #endregion
                        break;
                    
                    case controlSteps.end:
                        break;
                }
            }
            else
            {
                lastStepBeforeQuit = cs.ToString();
                setIconsByclosing(lastStepBeforeQuit);
            }
        }

        /// <summary>
        /// Do check the current password policy and save to log file
        /// </summary>
        /// <param name="logFilePath"></param>
        /// <param name="os"></param>
        /// <returns></returns>
        private bool MakePassWordPolicyControl(string logFilePath, OSVersions os)///////////////
        {
          _configClass.GetScriptHandling.GetPWPoliciesAndAuditPolicies();          
          _fh.AddLineToEndFile(logFilePath, "");
          _fh.AddLineToEndFile(logFilePath, CFHPasswordPolicy);
          _fh.AddLineToEndFile(logFilePath, "");
          string passwordComplexitystring = "";
          string clearTextPwString = "";
          _fh.AddLineToEndFile(logFilePath, "    " + "The following Password Policy are on your system:");
          try
          {
            _fh.AddLineToEndFile(logFilePath, "      " + "Enforce Password History " + _sh.PasswordHistorySize);         
            _fh.AddLineToEndFile(logFilePath, "      " + "Maximum Password Age " + _sh.MaximumPasswordAge);   
            _fh.AddLineToEndFile(logFilePath, "      " + "Minimum Password Age " + _sh.MinimumPasswordAge);  
            _fh.AddLineToEndFile(logFilePath, "      " + "Minimum Password Length " + _sh.MinimumPasswordLength);
            bool passwordComplexity = _sh.PasswordComplexity;
            if (passwordComplexity == true)
              passwordComplexitystring = "Enabled";
            else if (passwordComplexity == false)
              passwordComplexitystring = "Disabled";
            _fh.AddLineToEndFile(logFilePath, "      " + "Password must meet complexity requirements " + passwordComplexitystring);
            bool clearTextPw = _sh.ClearTextPassword;
            if (clearTextPw == true)
              clearTextPwString = "Enabled";
            else if (clearTextPw == false)            
              clearTextPwString = "Disabled";
              _fh.AddLineToEndFile(logFilePath, "      " + "Store password using reversible encryption " + clearTextPwString);
            
            return true;
          }
          catch
          {
            return false;
          }
          
        }
        private bool MakeCurrentIpSettings(string logFilePath, OSVersions os)///////////////
        {
          _sh.ShowCurrentIPSetting();

          _fh.AddLineToEndFile(logFilePath, "");
          _fh.AddLineToEndFile(logFilePath, CFHNetworkConfig);
          _fh.AddLineToEndFile(logFilePath, "");
          _fh.AddLineToEndFile(logFilePath, "    " + "The following Network Interface Cards are installed in your system:");
          try
          {
            foreach (string str in _sh.ShowAllCurrentIPSettings)
            {
              _fh.AddLineToEndFile(logFilePath, "      " + str);
            }
            return true;

          }
          catch
          {
            return false;
          }

        }
        
        private bool MakeAuditPolicyControl(string logFilePath, OSVersions os)//////////////////
        {
          _configClass.GetScriptHandling.GetPWPoliciesAndAuditPolicies();
          _fh.AddLineToEndFile(logFilePath, "");
          _fh.AddLineToEndFile(logFilePath, CFHControlPolicy);
          _fh.AddLineToEndFile(logFilePath, "");
          _fh.AddLineToEndFile(logFilePath, "   " + "The following Audit policies are on your system:");
          try
          {
            _fh.AddLineToEndFile(logFilePath, "     " + "Audit Account Logon Events " + _sh.AuditAccountLogon);            
            _fh.AddLineToEndFile(logFilePath, "     " + "Audit Account Management " + _sh.AuditAccountManage);
            _fh.AddLineToEndFile(logFilePath, "     " + "Audit Directory Service Access " + _sh.AuditDSAccess);
            _fh.AddLineToEndFile(logFilePath, "     " + "Audit Logon Events " + _sh.AuditLogonEvents);
            _fh.AddLineToEndFile(logFilePath, "     " + "Audit Object Access " + _sh.AuditObjectAccess);
            _fh.AddLineToEndFile(logFilePath, "     " + "Audit Policy Change " + _sh.AuditPolicyChange);
            _fh.AddLineToEndFile(logFilePath, "     " + "Audit Privilege Use " + _sh.AuditPrivilegeUse);
            _fh.AddLineToEndFile(logFilePath, "     " + "Audit Process Tracking " + _sh.AuditProcessTracking);
            _fh.AddLineToEndFile(logFilePath, "     " + "Audit System Events " + _sh.AuditSystemEvents);
              
            return true;
          }
          catch
          {
            return false;
          }
        }
        
        private bool MakeUserGroupControl(string logFilePath, OSVersions os)
        {
            _sh.putAllLocalGroupsToList();
            _fh.AddLineToEndFile(logFilePath, "");
            _fh.AddLineToEndFile(logFilePath, CFHGroups);
            _fh.AddLineToEndFile(logFilePath, "");
            _fh.AddLineToEndFile(logFilePath, "    " + "The following user groups are installed on your system:");

            try
            {
                foreach (UserGroup group in _sh.GetAllLocalUsersGroups)
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + group.Name);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool MakeUserControl(string logFilePath, OSVersions os)
        {
            _sh.putAllLocalUsersToList();
            _fh.AddLineToEndFile(logFilePath, "");
            _fh.AddLineToEndFile(logFilePath, CFHUsers);
            _fh.AddLineToEndFile(logFilePath, "");
            _fh.AddLineToEndFile(logFilePath, "    " + "The following users have been installed on your system:");

            try
            {
                foreach (ExistedUser user in _sh.GetAllLocalUsers)
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + user.Name);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool MakeAutoPlayControl(string logFilePath, OSVersions os)
        {

            _fh.AddLineToEndFile(logFilePath, "");
            _fh.AddLineToEndFile(logFilePath, CFHAutoPlay);
            _fh.AddLineToEndFile(logFilePath, "");
            _fh.AddLineToEndFile(logFilePath, "    " + "The Autoplay setting on this system:");

            string regPath = "";
            string regKey = "";
            try
            {
                if (ResourceHelper.GetOSOperations(os, "AutoPlaySettingRegPath") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "AutoPlaySettingRegPath");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoPlaySettingRegPath");
                }

                if (ResourceHelper.GetOSOperations(os, "APRegKeyNoDriveTypeAutoRun") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "APRegKeyNoDriveTypeAutoRun");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "APRegKeyNoDriveTypeAutoRun");
                }

                string value = _sh.GetRegkeyValue(regPath, regKey);
                if (value.Contains("255"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Autoplay is disabled on all drives");
                    return true;
                }
                if (value.Contains("181"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Autoplay is disabled for CD-ROM drives and removable media drives");
                    return true;
                }
                if (value.Contains("NULL"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Autoplay settings are not configured");
                    return true;
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        private bool MakeExplorerFolderOptionsControl(string logFilePath, OSVersions os)
        {
            try
            {
                _fh.AddLineToEndFile(logFilePath, "");
                _fh.AddLineToEndFile(logFilePath, CFHExplorer);
                _fh.AddLineToEndFile(logFilePath, "");
                _fh.AddLineToEndFile(logFilePath, "    " + "The Folder options on this system:");

                string regPath = "";
                string regKey = "";
                string value = "";

                #region Automatically search for network folders and printers check

                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }
                if (ResourceHelper.GetOSOperations(os, "EMONoNetCrawling") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMONoNetCrawling");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMONoNetCrawling");
                }
                value = _sh.GetRegkeyValue(regPath, regKey);
                if (value.Contains("0"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Automatically search for network folders and printers check = ON");

                }
                else if (value.Contains("1"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Automatically search for network folders and printers check = OFF");
                }
                else
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Automatically search for network folders and printers check = VALUE UNKNOWN");
                }

                #endregion Automatically search for network folders and printers check
                #region Show the contents of system folders

                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOWebViewBarricade") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOWebViewBarricade");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOWebViewBarricade");
                }
                value = _sh.GetRegkeyValue(regPath, regKey);
                if (value.Contains("0"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Show the contents of system folders = OFF");

                }
                else if (value.Contains("1"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Show the contents of system folders = ON");
                }
                else
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Show the contents of system folders = VALUE UNKNOWN");
                }

                #endregion
                #region Display the full path in the address bar

                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsCabinetState") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsCabinetState");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsCabinetState");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOFullPathAddress") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOFullPathAddress");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOFullPathAddress");
                }
                value = _sh.GetRegkeyValue(regPath, regKey);
                if (value.Contains("0"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Display the full path in the address bar = OFF");

                }
                else if (value.Contains("1"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Display the full path in the address bar = ON");
                }
                else
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Display the full path in the address bar = VALUE UNKNOWN");
                }

                #endregion
                #region Hidden files and folders

                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOHidden") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOHidden");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOHidden");
                }
                value = _sh.GetRegkeyValue(regPath, regKey);
                if (value.Contains("2"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Hidden files and folders = OFF");

                }
                else if (value.Contains("1"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Hidden files and folders = ON");
                }
                else
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Hidden files and folders = VALUE UNKNOWN");
                }

                #endregion
                #region Hide extensions for known file types

                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOHideFileExt") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOHideFileExt");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOHideFileExt");
                }
                value = _sh.GetRegkeyValue(regPath, regKey);
                if (value.Contains("0"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Hide extensions for known file types = OFF");

                }
                else if (value.Contains("1"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Hide extensions for known file types = ON");
                }
                else
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Hide extensions for known file types = VALUE UNKNOWN");
                }

                #endregion
                #region Hide protected operating system files

                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOShowSuperHidden") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOShowSuperHidden");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOShowSuperHidden");
                }
                value = _sh.GetRegkeyValue(regPath, regKey);
                if (value.Contains("0"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Hide protected operating system files = ON");

                }
                else if (value.Contains("1"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Hide protected operating system files = OFF");
                }
                else
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Hide protected operating system files = VALUE UNKNOWN");
                }
                #endregion
                #region The view settings for each folder

                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOClassicViewState") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOClassicViewState");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOClassicViewState");
                }
                value = _sh.GetRegkeyValue(regPath, regKey);
                if (value.Contains("0"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "The view settings for each folder = ON");

                }
                else if (value.Contains("1"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "The view settings for each folder = OFF");
                }
                else
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "The view settings for each folder = VALUE UNKNOWN");
                }
                #endregion
                #region Show encrypted or compressed NTFS files in color

                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOShowCompColor") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOShowCompColor");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOShowCompColor");
                }
                value = _sh.GetRegkeyValue(regPath, regKey);
                if (value.Contains("0"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Show encrypted or compressed NTFS files in color = OFF");
                }
                else if (value.Contains("1"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Show encrypted or compressed NTFS files in color = ON");
                }
                else
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Show encrypted or compressed NTFS files in color = VALUE UNKNOWN");
                }

                #endregion
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool MakeAutoLogInControl(string logFilePath, OSVersions os)
        {
            try
            {
                _fh.AddLineToEndFile(logFilePath, "");
                _fh.AddLineToEndFile(logFilePath, CFHAutoLogon);
                _fh.AddLineToEndFile(logFilePath, "");
                _fh.AddLineToEndFile(logFilePath, "    " + "The settings for automatic logging into this system:");

                string regPath = "";
                string regKey = "";
                string value = "";
                #region RegPath
                if (ResourceHelper.GetOSOperations(os, "AutoLogonRegPath") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "AutoLogonRegPath");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoLogonRegPath");
                }
                #endregion RegPath

                #region GetAutoLogon
                if (ResourceHelper.GetOSOperations(os, "AutoAdminLogon") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "AutoAdminLogon");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoAdminLogon");
                }
                value = _sh.GetRegkeyValue(regPath, regKey);
                if (value.Contains("0"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Automatic login is disabled");
                }
                else if (value.Contains("1"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Automatic login is disabled for the next user:");
                    #region Username
                    if (ResourceHelper.GetOSOperations(os, "AutoLogonUsername") != null)
                    {
                        regKey = ResourceHelper.GetOSOperations(os, "AutoLogonUsername");
                    }
                    else
                    {
                        regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoLogonUsername");
                    }
                    _fh.AddLineToEndFile(logFilePath, "        " + _sh.GetRegkeyValue(regPath, regKey));
                    #endregion  Username
                }
                else
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Status of automatic login is unknown");
                }
                #endregion GetAutoLogon
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool MakeShutdownEventTrackerControl(string logFilePath, OSVersions os)
        {
            try
            {
                _fh.AddLineToEndFile(logFilePath, "");
                _fh.AddLineToEndFile(logFilePath, CFHshutDownEventTracker);
                _fh.AddLineToEndFile(logFilePath, "");
                _fh.AddLineToEndFile(logFilePath, "    " + "The settings for the shutdown event tracker are:");

                string regPath = "";
                string regKey = "";
                string value = "";

                #region RegPath
                if (ResourceHelper.GetOSOperations(os, "SDEVTRegPath") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "SDEVTRegPath");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "SDEVTRegPath");
                }
                #endregion RegPath

                #region OnShutdownReasonUI
                if (ResourceHelper.GetOSOperations(os, "SDEVTRegKeyOnShutdownReasonUI") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "SDEVTRegKeyOnShutdownReasonUI");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "SDEVTRegKeyOnShutdownReasonUI");
                }
                #endregion OnShutdownReasonUI
               
                value = _sh.GetRegkeyValue(regPath, regKey);
                if (value.Contains("0"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Shutdown event tracker is disabled");
                }
                else if (value.Contains("1"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Shutdown event tracker is enabled");
                }
                else
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Shutdown event tracker is disabled");
                }
                return true;
            }
            catch
            { return false; }
        }

        private bool MakeRemoteDesktopControl(string logFilePath, OSVersions os)
        {

            try
            {
                _fh.AddLineToEndFile(logFilePath, "");
                _fh.AddLineToEndFile(logFilePath, CFHremoteDesktop);
                _fh.AddLineToEndFile(logFilePath, "");
                _fh.AddLineToEndFile(logFilePath, "    " + "The settings for Remote Desktop are:");

                string regPath = "";
                string regKey = "";
                string value1 = "";
                string value2 = "";

                #region RegPath
                if (ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegPath") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegPath");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableLessSecureRegPath");
                }
                #endregion RegPath
                #region RegKeyRemoteDesktop
                if (ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegKey") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegKey");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableLessSecureRegKey");
                }
                #endregion RegKeyRemoteDesktop
                value1 = _sh.GetRegkeyValue(regPath, regKey);

                if (os != OSVersions.WindowsXP && os != OSVersions.WindowsXP32 && os != OSVersions.WindowsXP64 && os != OSVersions.W2003 && os != OSVersions.W2003R2)
                {
                    #region RegPath Network level authentication
                    if (ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegPath") != null)
                    {
                        regPath = ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegPath");
                    }
                    else
                    {
                        regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableMoreSecureRegPath");
                    }
                    #endregion RegPath Network level authentication
                    #region RegKeyRemoteDesktop Network level authentication
                    if (ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegKey") != null)
                    {
                        regKey = ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegKey");
                    }
                    else
                    {
                        regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableMoreSecureRegKey");
                    }
                    #endregion RegKeyRemoteDesktop Network level authentication
                    value2 = _sh.GetRegkeyValue(regPath, regKey);
                }

                if (value1.Contains("1"))
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + "Remote Desktop disabled");
                }
                else if (value1.Contains("0"))
                {
                    if (value2.Contains("1"))
                    {
                        _fh.AddLineToEndFile(logFilePath, "        " + "Remote Desktop enabled, only allows connections from computers using Network Level Authentication");
                    }
                    else
                    {
                        _fh.AddLineToEndFile(logFilePath, "        " + "Remote Desktop enabled, allows all connections from all computers");
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool MakeSharingControl(string logFilePath, OSVersions os)/////////////////
        {
            return false;
        }

        private bool MakeFireWallControl(string logFilePath, OSVersions os)
        {
            _sh.putAllLocalFireWallExceptionsToList();
            _fh.AddLineToEndFile(logFilePath, "");
            _fh.AddLineToEndFile(logFilePath, CFHfirewall);
            _fh.AddLineToEndFile(logFilePath, "");
            try
            {
                foreach (string exception in _sh.GetAllLocalFirewallExceptions)
                {
                    _fh.AddLineToEndFile(logFilePath, "        " + exception);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool MakePcAnyWhereControl(string logFilePath, OSVersions os)////////////////
        {
            return false;
        }

        private bool MakeBlockKeysControl(string logFilePath, OSVersions os)///////////////////
        {
            return false;
        }

        private bool MakeSQLserverControl(string logFilePath, OSVersions os)////////////////////
        {
            return false;
        }

        private bool MakeWebServerControl(string logFilePath, OSVersions os)//////////////////
        {
            return false;
        }

        private bool MakeFTPServerControl(string logFilePath, OSVersions os)/////////////////
        {
            return false;
        }

        private bool MakeMailServerControl(string logFilePath, OSVersions os)//////////////////
        {
            return false;
        }

        private bool MakeMBSAControl(string logFilePath, OSVersions os,ConfigClass configClass)///////////////////
        {
            try
            {
                
                string path = CtrlHome.GetConfigClass.ConfSetMicrosoftBaslineSecurityAnalyzer.FindMBSAexePath("Microsoft Baseline Security Analyzer",configClass);
                string mbsaLog = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\MBSAlog.txt";
                bool check = false;
                File.Delete(mbsaLog);
                if (path != null)
                {
                    _sh.RunMBSA(path, "\"" + mbsaLog + "\"");
                    foreach (string st in _fh.ReadWholeFile(mbsaLog))
                    {
                        _fh.AddLineToEndFile(logFilePath, st);
                    }
                    check = true;
                }
                else
                {
                    check = false;
                }

                return check;
            }
            catch
            {
                return false;
            }
                 
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          MakeControl(_controlFilePath, controlSteps.start, CtrlHome.osVersion, _configClass);

           BackgroundWorker worker = sender as BackgroundWorker;
           {
               if ((worker.CancellationPending == true))
               {
                   e.Cancel = true;
               }
           }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btViewRapport.Enabled = true;
            btStart.Enabled = true;
            btStop.Enabled = false;
            btClose.Enabled = true;
        }
        private delegate void SetTextCallback(string text);
        private void setLabel(string text)
        {
            if (this.lbMBSAscannen.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbMBSAscannen.Text = text;
            }
        }
        private void setIconsByclosing(string controlStep)
        {
            if(controlStep == "start")
            {
            
            }
            if(controlStep == "passWordPolicy")
            {
                setPboxImages(1,false);
            
            }
            if(controlStep == "controlPolicy")
            {
                setPboxImages(2, false);
                
            }
            if(controlStep == "addUserGroup")
            {
                setPboxImages(3, false);
            
            }
            if(controlStep == "addUser")
            {
                setPboxImages(4, false);
           
            }
            if(controlStep == "autoPlaySettings")
            {
                setPboxImages(5, false);
            
            }
            if(controlStep == "explorerMapOptions")
            {
                setPboxImages(6, false);
            
            }
            if(controlStep == "AutologInSettings")
            {
                setPboxImages(7, false);
            
            }
            if(controlStep == "ShutDownEventTracker")
            {
                setPboxImages(8, false);
            
            }
            if(controlStep == "remoteDesktop")
            {
                setPboxImages(9, false);
            }
            if(controlStep == "sharing")
            {
                setPboxImages(10, false);
            }
            if(controlStep == "fireWall")
            {
                setPboxImages(11, false);
            }
            if(controlStep == "configPcAnywhere")
            {
                setPboxImages(12, false);
            }
            if(controlStep == "configBlockKeys")
            {
                setPboxImages(13, false);
            }
            if(controlStep == "configSQLserver")
            {
                setPboxImages(14, false);
            }
            if(controlStep == "configWebserver")
            {
                setPboxImages(15, false);
            }
            if(controlStep == "configFTPserver")
            {
                setPboxImages(16, false);
            }
            if(controlStep == "configMailserver")
            {
                setPboxImages(17, false);
            }
            if(controlStep == "configMBSA")
            {
                setPboxImages(18, false);
            }
            if (controlStep == "end")
            {
                setPboxImages(19, false);
            }
        }

    }
}
