﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Actemium.Diagnostics;
using Actemium.WiSSWizard.Pages;
using Actemium.WiSSWizard.Support;
using CubicOrange.Windows.Forms.ActiveDirectory;
using Microsoft.Win32;


namespace Actemium.WiSSWizard
{

  public partial class CtrlHome : BaseFormPage
  {
    //parameters
    private const string CLASSNAME = "CtrlHome";
    private string _logFilePath = "";
    private FileHandling _fh;
    private ScriptHandling _scriptHandling;
    private EncryptionPassword _encryptionPassword;
    private List<PictureBox> _pbList = new List<PictureBox>();
    private List<string> _globalGroupMembers = new List<string>();
    private List<string> _localGroupMembers = new List<string>();
    private List<string> _localUserMembers = new List<string>();

    public static OSVersions os;
    private bool _autoLogonPasswordisValid = false;
    private bool _MBSAfindPathTryAgain = false;
    private bool _savePasswordinLogFileAsked = false;

    //private List<FireWallException> _allFirewallExceptions = new List<FireWallException>();




    //XML handler

    public XMLhandler GetXMLhandler
    {
      get
      {
        return _xmlHandler;
      }

    }
    private XMLhandler _xmlHandler;
    public static ConfigClass GetConfigClass
    {
      get
      {
        return _configClass;

      }
      set
      {
        _configClass = value;
      }
    }private static ConfigClass _configClass;

    //constructor
    public CtrlHome()
    {
      InitializeComponent();
      this.TopLevel = false;
      this._navigationItem = NavigationItems.Home;
      this._title = "Welcome";
      _configClass = new ConfigClass();
      _scriptHandling = _configClass.GetScriptHandling;
      InitSettings();
      _encryptionPassword = new EncryptionPassword(_configClass);
      _configClass.ConfSetDefaultInformation.ComputerName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();

    }

    //properties
    public string LogFilePath // contains path incl. file name
    {
      get { return _logFilePath; }
      set { _logFilePath = value; }
    }
    public string LogFileFolder // contains path excl. file name 
    {
      get { return _logFileFolder; }
      set { _logFileFolder = value; }
    } private string _logFileFolder = "";

    public static OSVersions osVersion
    {
      get { return os; }
    }

    #region initialization
    public void CheckIfPowerShellIsInstalled()
    {
      RegistryKey RK = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\PowerShell\\1");
      if (RK == null)
      {
        DialogResult result = MessageBox.Show("In order to use the Security Checklist application service you must install Microsoft PowerShell", "Microsoft PowerShell is not installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        if (result == System.Windows.Forms.DialogResult.OK)
        {
          Application.Exit();
        }
      }

    }

    public void InitSettings()
    {
      CheckIfPowerShellIsInstalled();
      #region createLogfile init
      LogFileFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\logging\";
      _fh = new FileHandling(_configClass);
      _fh.FilePath = LogFileFolder + _fh.CreateFileName(".xml");

      DateTime dt = DateTime.Now;
      string dateTime = dt.DayOfWeek + " " + dt.Day + "-" + dt.Month + "-" + dt.Year;
      _configClass.ConfSetDefaultInformation.ConfigDateTime = dateTime;
      #endregion createLogfile init
      #region Remember default Settings
      RememberDefaultsAuditPolicy();
      RememberDefaultIIS();
      RememberDefaultMailSrv();
      RemeberDefaultsFirewall();
      RememberDefaultsAutoPlayWindowsExplorer();
      RememberDefaultsLogonShutdownRemoteDesktop();
      RememberDefaultsMBSA();
      RememberDefaultWizardPageType();
      #endregion Remember default Settings
      #region MainProgram images init
      _pbList.Add(pbConfigCheck0);
      _pbList.Add(pbConfigCheck1);
      _pbList.Add(pbConfigCheck2);
      _pbList.Add(pbConfigCheck3);
      _pbList.Add(pbConfigCheck4);
      _pbList.Add(pbConfigCheck5);
      _pbList.Add(pbConfigCheck6);
      _pbList.Add(pbConfigCheck7);
      _pbList.Add(pbConfigCheck8);
      _pbList.Add(pbConfigCheck9);
      _pbList.Add(pbConfigCheck10);
      _pbList.Add(pbConfigCheck11);
      _pbList.Add(pbConfigCheck12);
      _pbList.Add(pbConfigCheck13);
      _pbList.Add(pbConfigCheck14);
      _pbList.Add(pbConfigCheck15);
      _pbList.Add(pbConfigCheck16);
      _pbList.Add(pbConfigCheck17);
      _pbList.Add(pbConfigCheck18);
      _pbList.Add(pbConfigCheck19);
      _pbList.Add(pbConfigCheck20);
      foreach (PictureBox pb in _pbList)
      {
        pb.Image = checkImages.Images[3];
      }

      #endregion MainProgram images init
      #region select name and system init
      wpSelectNameAndSystem.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.True;
      cbOperatingSystemPnStart.Visible = false;
      lbOperatingSystem.Text = setOSVersion();
      lbOperatingSystem.Location = new Point(cbOperatingSystemPnStart.Location.X, cbOperatingSystemPnStart.Location.Y);



      #endregion select name and system init
      #region AutoLogon init
      combAutoLogonUser.Enabled = false;
      tbAutoLogonPasword.Enabled = false;
      #endregion AutoLogon init
      #region installedSoftware init
      pbInstalledSoftware1.Image = checkImages.Images[3];
      pbInstalledSoftware2.Image = checkImages.Images[3];
      pbInstalledSoftware3.Image = checkImages.Images[3];
      pbInstalledSoftware4.Image = checkImages.Images[3];
      pbInstalledSoftware6.Image = checkImages.Images[3];
      pbInstalledSoftware5.Image = checkImages.Images[3];
      pbInstalled.Image = checkImages.Images[0];
      pbNotInstalled.Image = checkImages.Images[3];
      #endregion installedSoftware init
      #region UsersGroups init
      RefreshListViewUsersGroups();
      if (_configClass.ConfSetWindowsUsergroup.CheckIfUserGroupExist("Administrators", _configClass))
      {
        cbAddgroupAdministrators.Enabled = false;
      }
      else
      {
        cbAddgroupAdministrators.Enabled = true;
        cbAddgroupAdministrators.Checked = true;
      }
      if (_configClass.ConfSetWindowsUsergroup.CheckIfUserGroupExist("Actemium Engineers", _configClass))
      {
        cbAddgroupActemiumEngineers.Enabled = false;
      }
      else
      {
        cbAddgroupActemiumEngineers.Enabled = true;
        cbAddgroupActemiumEngineers.Checked = true;
      }
      if (_configClass.ConfSetWindowsUsergroup.CheckIfUserGroupExist("FTP_Users", _configClass))
      {
        cbAddGroupFTP_users.Enabled = false;
      }
      else
      {

        cbAddGroupFTP_users.Enabled = true;
      }
      #endregion UsersGroups init
      #region BlockDefaultUsers init
      string Guest;
      #region language

      string oslanguage = System.Globalization.CultureInfo.CurrentCulture.DisplayName;
      if (oslanguage.Contains("Nederland"))
      {
        Guest = "Gast";
      }
      else
      {

        Guest = "Guest";
      }
      #endregion language

      if (!_configClass.ConfSetWindowsUsers.CheckIfUserExist(Guest, _configClass))
      {
        tbChangePasswDefAccoGuest.Enabled = false;
        tbChangeConfirmPasswDefAccoGuest.Enabled = false;
        cbRandomPWChangeDefAccoGuest.Enabled = false;
        cbBlockDefAccoGuest.Enabled = false;
      }
      else
      {
        _configClass.ConfSetWindowsUsers.DefaultGuestAccountInUse = true;
      }

      if (_configClass.ConfSetWindowsUsers.CheckIfSUPPORTaccountExist(_configClass) == "")
      {
        tbChangePasswDefAccoSUPPORT.Enabled = false;
        tbChangeConfirmPasswDefAccoSUPPORT.Enabled = false;
        cbRandomPWChangeDefAccoSUPPORT.Enabled = false;
        cbBlockDefAccoSUPPORT.Enabled = false;
      }
      else
      {
        _configClass.ConfSetWindowsUsers.DefaultSupportAccountInUse = true;
        lbChangeDefaultAccountSUPPORT.Text = _configClass.ConfSetWindowsUsers.CheckIfSUPPORTaccountExist(_configClass);
      }

      if (!_configClass.ConfSetWindowsUsers.CheckIfUserExist("Administrator", _configClass))
      {
        tbChangePasswDefAccoAdministrator.Enabled = false;
        tbChangeConfirmPasswDefAccoAdministrator.Enabled = false;
        cbRandomPWChangeDefAccoAdministrator.Enabled = false;
        cbBlockDefAccoAdministrator.Enabled = false;
      }
      else
      {
        _configClass.ConfSetWindowsUsers.DefaultAdministratorAccountInUse = true;
      }



      #endregion BlockDefaultUsers init
      #region Users init
      RefreshListViewUsers();
      if (_configClass.ConfSetWindowsUsers.CheckIfUserExist("Actemium", _configClass))
      {
        cbCreateActemiumUser.Enabled = false;
      }
      if (_configClass.ConfSetWindowsUsers.CheckIfUserExist("Admin", _configClass))
      {
        cbCreateAdminUser.Enabled = false;
      }
      #endregion Users init
      #region autoPlay init
      if (!rbDisabledAP.Checked)
      {
        cbAutoplaydrives.Enabled = false;
      }
      #endregion
      #region Shutdown eventTracker init
      if (os == OSVersions.WindowsXP32)
      {
        combShutDEventTracker.Enabled = false;
        pbConfigCheck8.Image = checkImages.Images[5];
      }
      #endregion Shutdown eventTracker init
      #region Remote Desktop init
      if (os == OSVersions.WindowsXP32 || os == OSVersions.WindowsXP || os == OSVersions.WindowsXP64 || os == OSVersions.W2003 || os == OSVersions.W2003R2)
      {
        rbRemoteDesktopOnMoreSecure.Enabled = false;
      }
      #endregion Remote Desktop init
      #region IIS init
      if (!rbWebLogSizeReach.Checked)
      {
        nudWebLogSize.Enabled = false;
      }
      else
      {
        nudWebLogSize.Enabled = true;
      }
      #endregion IIS init
      #region FTPConfig init
      if (!rbFTPLogSizeReach.Checked)
      {
        nudFTPLogSize.Enabled = false;
      }
      else
      {
        nudFTPLogSize.Enabled = true;
      }



      #endregion FTPConfig init
      #region Firewall
      if (os == OSVersions.WindowsXP32 || os == OSVersions.WindowsXP || os == OSVersions.WindowsXP64)
      {
        rbFwProgramInbound.Enabled = false;
        rbFwProgramInbound.Visible = false;
        rbFwProgramOutbound.Enabled = false;
        rbFwProgramOutbound.Visible = false;
        btFwModify.Enabled = false;
        btFwModify.Visible = false;
        rbPortInbound.Enabled = false;
        rbPortInbound.Visible = false;
        rbPortOutbound.Enabled = false;
        rbPortOutbound.Visible = false;

      }
      else
      {
        rbFwProgramInbound.Enabled = false;
        rbFwProgramInbound.Visible = true;
        rbFwProgramOutbound.Enabled = false;
        rbFwProgramOutbound.Visible = true;
        btFwModify.Enabled = true;
        btFwModify.Visible = true;
        rbPortInbound.Enabled = false;
        rbPortInbound.Visible = true;
        rbPortOutbound.Enabled = false;
        rbPortOutbound.Visible = true;
      }
      #endregion Firewall
      #region MBSA init
      string mbsaLog = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\MBSAlog.txt";
      if (File.Exists(mbsaLog))
      {
        File.Delete(mbsaLog);
      }
      wpMBSA.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;

      #endregion MBSA init
      #region WPFinish init
      wpFinish.BackButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
      lbLogfilePathWPFinish.Text = _fh.FilePath;
      #endregion WPFinish init
    }
    #region OsVersion
    public string setOSVersion()
    {
      #region XP
      if (OSVersionInfo.Name == "Windows XP")
      {
        if (OSVersionInfo.OSBits.ToString() == "Bit32")
        {
          os = OSVersions.WindowsXP32;
          return OSVersionInfo.Name + " 32 Bit";
        }
        else if (OSVersionInfo.OSBits.ToString() == "Bit64")
        {
          os = OSVersions.WindowsXP64;
          return OSVersionInfo.Name + " 64 Bit";
        }
        else
        {
          os = OSVersions.WindowsXP;
          return OSVersionInfo.Name;
        }
      }
      #endregion XP
      #region W2003
      if (OSVersionInfo.Name == "Windows Server 2003")
      {
        if (OSVersionInfo.OSBits.ToString() == "Bit32")
        {
          os = OSVersions.W2003;
          return OSVersionInfo.Name + " 32 Bit";
        }
        else if (OSVersionInfo.OSBits.ToString() == "Bit64")
        {
          os = OSVersions.W2003;
          return OSVersionInfo.Name + " 64 Bit";
        }
        else
        {
          os = OSVersions.W2003;
          return OSVersionInfo.Name;
        }
      }
      #endregion W2003
      #region W2003R2
      if (OSVersionInfo.Name == "Windows Server 2003 R2")
      {
        if (OSVersionInfo.OSBits.ToString() == "Bit32")
        {
          os = OSVersions.W2003R2;
          return OSVersionInfo.Name + " 32 Bit";
        }
        else if (OSVersionInfo.OSBits.ToString() == "Bit64")
        {
          os = OSVersions.W2003R2;
          return OSVersionInfo.Name + " 64 Bit";
        }
        else
        {
          os = OSVersions.W2003R2;
          return OSVersionInfo.Name;
        }
      }
      #endregion W2003R2
      #region Wvista
      if (OSVersionInfo.Name == "Windows Vista")
      {
        if (OSVersionInfo.OSBits.ToString() == "Bit32")
        {
          os = OSVersions.WindowsVista;
          return OSVersionInfo.Name + " 32 Bit";
        }
        else if (OSVersionInfo.OSBits.ToString() == "Bit64")
        {
          os = OSVersions.WindowsVista;
          return OSVersionInfo.Name + " 64 Bit";
        }
        else
        {
          os = OSVersions.WindowsVista;
          return OSVersionInfo.Name;
        }
      }
      #endregion Wvista
      #region W7
      if (OSVersionInfo.Name == "Windows 7")
      {
        if (OSVersionInfo.OSBits.ToString() == "Bit32")
        {
          os = OSVersions.Windows7;
          return OSVersionInfo.Name + " 32 Bit";
        }
        else if (OSVersionInfo.OSBits.ToString() == "Bit64")
        {
          os = OSVersions.Windows7;
          return OSVersionInfo.Name + " 64 Bit";
        }
        else
        {
          os = OSVersions.Windows7;
          return OSVersionInfo.Name;
        }
      }
      #endregion W7
      #region W2008
      if (OSVersionInfo.Name == "Windows Server 2008")
      {
        if (OSVersionInfo.OSBits.ToString() == "Bit32")
        {
          os = OSVersions.W2008;
          return OSVersionInfo.Name + " 32 Bit";
        }
        else if (OSVersionInfo.OSBits.ToString() == "Bit64")
        {
          os = OSVersions.W2008;
          return OSVersionInfo.Name + " 64 Bit";
        }
        else
        {
          os = OSVersions.W2008;
          return OSVersionInfo.Name;
        }
      }
      #endregion W2008
      #region W2008R2
      if (OSVersionInfo.Name == "Windows Server 2008 R2")
      {
        if (OSVersionInfo.OSBits.ToString() == "Bit32")
        {
          os = OSVersions.W2008R2;
          return OSVersionInfo.Name + " 32 Bit";
        }
        else if (OSVersionInfo.OSBits.ToString() == "Bit64")
        {
          os = OSVersions.W2008R2;
          return OSVersionInfo.Name + " 64 Bit";
        }
        else
        {
          os = OSVersions.W2008R2;
          return OSVersionInfo.Name;
        }
      }
      #endregion W2008R2
      return "This application can not regconize this Operating system";
    }
    #endregion OsVersion
    #endregion initialization
    #region tooltips
    private string GetToolTipTextFromResource(string name)
    {
      try
      {
        if (Actemium.WiSSWizard.Support.ResourceHelper.GettoolTipText(name) != null)
        {
          return Actemium.WiSSWizard.Support.ResourceHelper.GettoolTipText(name);
        }
      }
      catch
      { }
      return "No information available.";
    }

    public void CreateToolTips(object sender)
    {
      try
      {
        ToolTip tooltip = InitToolTip();
        tooltip.SetToolTip(((PictureBox)sender), GetToolTipTextFromResource(((PictureBox)sender).Name));
      }
      catch
      { }
    }
    private ToolTip InitToolTip()
    {
      ToolTip buttonToolTip = new ToolTip();
      buttonToolTip.ToolTipIcon = ToolTipIcon.Info;
      buttonToolTip.ToolTipTitle = "Information";
      buttonToolTip.UseFading = true;
      buttonToolTip.UseAnimation = true;
      buttonToolTip.IsBalloon = true;
      buttonToolTip.ShowAlways = true;
      buttonToolTip.AutoPopDelay = 20000;
      buttonToolTip.InitialDelay = 5;
      buttonToolTip.ReshowDelay = 10000;
      return buttonToolTip;
    }

    private void toolTip_Click(object sender, EventArgs e)
    {
      CreateToolTips(sender);
    }
    #endregion tooltips
    #region Log not default choises
    #region AuditPolicy
    private string defaultcombControlPolicy1 = "";
    private string defaultcombControlPolicy2 = "";
    private string defaultcombControlPolicy3 = "";
    private string defaultcombControlPolicy4 = "";
    private string defaultcombControlPolicy5 = "";
    private string defaultcombControlPolicy6 = "";
    private string defaultcombControlPolicy7 = "";
    private string defaultcombControlPolicy8 = "";
    private string defaultcombControlPolicy9 = "";
    private List<TextBox> NotDefaultChoisesAuditControl = new List<TextBox>();
    public void RememberDefaultsAuditPolicy()
    {
      NotDefaultChoisesAuditControl.Add(tbControlPolicy1);
      NotDefaultChoisesAuditControl.Add(tbControlPolicy2);
      NotDefaultChoisesAuditControl.Add(tbControlPolicy3);
      NotDefaultChoisesAuditControl.Add(tbControlPolicy4);
      NotDefaultChoisesAuditControl.Add(tbControlPolicy5);
      NotDefaultChoisesAuditControl.Add(tbControlPolicy6);
      NotDefaultChoisesAuditControl.Add(tbControlPolicy7);
      NotDefaultChoisesAuditControl.Add(tbControlPolicy8);
      NotDefaultChoisesAuditControl.Add(tbControlPolicy9);

      defaultcombControlPolicy1 = combControlPolicy1.Text;
      defaultcombControlPolicy2 = combControlPolicy2.Text;
      defaultcombControlPolicy3 = combControlPolicy3.Text;
      defaultcombControlPolicy4 = combControlPolicy4.Text;
      defaultcombControlPolicy5 = combControlPolicy5.Text;
      defaultcombControlPolicy6 = combControlPolicy6.Text;
      defaultcombControlPolicy7 = combControlPolicy7.Text;
      defaultcombControlPolicy8 = combControlPolicy8.Text;
      defaultcombControlPolicy9 = combControlPolicy9.Text;
    }
    public void showLabel()
    {
      bool show = false;
      foreach (TextBox tb in NotDefaultChoisesAuditControl)
      {
        if (tb.Visible)
        {
          show = true;
          break;
        }
      }
      lbAuditPolicyNotStandard.Visible = show;

    }
    private void combControlPolicyX_SelectedValueChanged(object sender, EventArgs e)
    {
      ComboBox cb = (ComboBox)sender;

      switch (cb.Name)
      {
        case "combControlPolicy1":
          #region combControlPolicy1
          if (combControlPolicy1.Text == defaultcombControlPolicy1)
          {
            tbControlPolicy1.Visible = false;
          }
          else
          {
            tbControlPolicy1.Visible = true;
          }
          showLabel();
          #endregion combControlPolicy1
          break;
        case "combControlPolicy2":
          #region combControlPolicy2
          if (combControlPolicy2.Text == defaultcombControlPolicy2)
          {
            tbControlPolicy2.Visible = false;
          }
          else
          {
            tbControlPolicy2.Visible = true;
          }
          showLabel();
          #endregion combControlPolicy2
          break;
        case "combControlPolicy3":
          #region combControlPolicy3
          if (combControlPolicy3.Text == defaultcombControlPolicy3)
          {
            tbControlPolicy3.Visible = false;
          }
          else
          {
            tbControlPolicy3.Visible = true;
          }
          showLabel();
          #endregion combControlPolicy3
          break;
        case "combControlPolicy4":
          #region combControlPolicy4
          if (combControlPolicy4.Text == defaultcombControlPolicy4)
          {
            tbControlPolicy4.Visible = false;
          }
          else
          {
            tbControlPolicy4.Visible = true;
          }
          showLabel();
          #endregion combControlPolicy4
          break;
        case "combControlPolicy5":
          #region combControlPolicy5
          if (combControlPolicy5.Text == defaultcombControlPolicy5)
          {
            tbControlPolicy5.Visible = false;
          }
          else
          {
            tbControlPolicy5.Visible = true;
          }
          showLabel();
          #endregion combControlPolicy5
          break;
        case "combControlPolicy6":
          #region combControlPolicy6
          if (combControlPolicy6.Text == defaultcombControlPolicy6)
          {
            tbControlPolicy6.Visible = false;
          }
          else
          {
            tbControlPolicy6.Visible = true;
          }
          showLabel();
          #endregion combControlPolicy6
          break;
        case "combControlPolicy7":
          #region combControlPolicy7
          if (combControlPolicy7.Text == defaultcombControlPolicy7)
          {
            tbControlPolicy7.Visible = false;
          }
          else
          {
            tbControlPolicy7.Visible = true;
          }
          showLabel();
          #endregion combControlPolicy7
          break;
        case "combControlPolicy8":
          #region combControlPolicy8
          if (combControlPolicy8.Text == defaultcombControlPolicy8)
          {
            tbControlPolicy8.Visible = false;
          }
          else
          {
            tbControlPolicy8.Visible = true;
          }
          showLabel();
          #endregion combControlPolicy8
          break;
        case "combControlPolicy9":
          #region combControlPolicy9
          if (combControlPolicy9.Text == defaultcombControlPolicy9)
          {
            tbControlPolicy9.Visible = false;
          }
          else
          {
            tbControlPolicy9.Visible = true;
          }
          showLabel();
          #endregion combControlPolicy1
          break;
      }
    }
    #endregion AuditPolicy
    #region Autoplay and WindowsExplorer
    private bool defaultrbEnabeledAutoPlay;
    private string defaultcbAutoplaydrives;

    private bool defaultcbWesASNFP;
    private bool defaultcbWesDCSF;
    private bool defaultcbWesDFPAB;
    private bool defaultcbWesSHFF;
    private bool defaultcbWesHEKF;
    private bool defaultcbWesHPOSF;
    private bool defaultcbWesREFS;
    private bool defaultcbWesSECFC;
    private List<TextBox> NotDefaultChoisesAutoPlayWindowsExplorer = new List<TextBox>();
    public void RememberDefaultsAutoPlayWindowsExplorer()
    {
      if (os == OSVersions.W2008 || os == OSVersions.W2008R2 || os == OSVersions.Windows7)
      {
        cbWesASNFP.Enabled = false;
        cbWesASNFP.Checked = false;

        // cbWesDCSF.Enabled = false;
        // cbWesDCSF.Checked = false;
        cbWesREFS.Enabled = false;
        cbWesREFS.Checked = false;
      }
      NotDefaultChoisesAutoPlayWindowsExplorer.Add(tbAutoPlayNotDefault); //Auto play

      NotDefaultChoisesAutoPlayWindowsExplorer.Add(tbWesASNFP);   //ASNFP = Automatically search for network folders and printers
      NotDefaultChoisesAutoPlayWindowsExplorer.Add(tbWesDCSF);    //DCSF = Display the contents of system folders 
      NotDefaultChoisesAutoPlayWindowsExplorer.Add(tbWesDFPAB);   //DFPAB = Display the full path in the address bar
      NotDefaultChoisesAutoPlayWindowsExplorer.Add(tbWesSHFF);    //SHFF = show hidden files and folders
      NotDefaultChoisesAutoPlayWindowsExplorer.Add(tbWesHEKF);    //HEKF = Hide extensions fot known file types
      NotDefaultChoisesAutoPlayWindowsExplorer.Add(tbWesHPOSF);   //HPOSF = hide protected operating system files 
      NotDefaultChoisesAutoPlayWindowsExplorer.Add(tbWesREFS);    //REFS = Remember each folder view settings
      NotDefaultChoisesAutoPlayWindowsExplorer.Add(tbWesSECFC);   //SECFC = show encrypted or compressed NTFS files in color

      defaultrbEnabeledAutoPlay = rbDisabledAP.Checked;
      defaultcbAutoplaydrives = cbAutoplaydrives.Text;

      defaultcbWesASNFP = cbWesASNFP.Checked;
      defaultcbWesDCSF = cbWesDCSF.Checked;
      defaultcbWesDFPAB = cbWesDFPAB.Checked;
      defaultcbWesSHFF = cbWesSHFF.Checked;
      defaultcbWesHEKF = cbWesHEKF.Checked;
      defaultcbWesHPOSF = cbWesHPOSF.Checked;
      defaultcbWesREFS = cbWesREFS.Checked;
      defaultcbWesSECFC = cbWesSECFC.Checked;
    }
    private void cbAutoplaydrives_SelectedValueChanged(object sender, EventArgs e)
    {
      if (cbAutoplaydrives.Text == defaultcbAutoplaydrives)
      {
        if (rbDisabledAP.Checked == defaultrbEnabeledAutoPlay)
        {
          tbAutoPlayNotDefault.Visible = false;
        }
      }
      else
      {
        tbAutoPlayNotDefault.Visible = true;
      }
    }
    private void cbWesASNFP_CheckedChanged(object sender, EventArgs e)
    {
      if (cbWesASNFP.Checked == defaultcbWesASNFP)
      {
        tbWesASNFP.Visible = false;
        lbWesASNFP.Visible = false;
      }
      else
      {
        tbWesASNFP.Visible = true;
        lbWesASNFP.Visible = true;
      }
    }
    private void cbWesDCSF_CheckedChanged(object sender, EventArgs e)
    {
      if (cbWesDCSF.Checked == defaultcbWesDCSF)
      {
        tbWesDCSF.Visible = false;
        lbWesDCSF.Visible = false;
      }
      else
      {
        tbWesDCSF.Visible = true;
        lbWesDCSF.Visible = true;
      }

    }
    private void cbWesDFPAB_CheckedChanged(object sender, EventArgs e)
    {
      if (cbWesDFPAB.Checked == defaultcbWesDCSF)
      {
        tbWesDFPAB.Visible = false;
        lbWesDFPAB.Visible = false;
      }
      else
      {
        tbWesDFPAB.Visible = true;
        lbWesDFPAB.Visible = true;
      }
    }
    private void cbWesSHFF_CheckedChanged(object sender, EventArgs e)
    {
      if (cbWesSHFF.Checked == defaultcbWesDFPAB)
      {
        tbWesSHFF.Visible = false;
        lbWesSHFF.Visible = false;
      }
      else
      {
        tbWesSHFF.Visible = true;
        lbWesSHFF.Visible = true;
      }
    }
    private void cbWesHEKF_CheckedChanged(object sender, EventArgs e)
    {
      if (cbWesHEKF.Checked == defaultcbWesHEKF)
      {
        tbWesHEKF.Visible = false;
        lbWesHEKF.Visible = false;
      }
      else
      {
        tbWesHEKF.Visible = true;
        lbWesHEKF.Visible = true;
      }
    }
    private void cbWesHPOSF_CheckedChanged(object sender, EventArgs e)
    {
      if (cbWesHPOSF.Checked == defaultcbWesHPOSF)
      {
        tbWesHPOSF.Visible = false;
        lbWesHPOSF.Visible = false;
      }
      else
      {
        tbWesHPOSF.Visible = true;
        lbWesHPOSF.Visible = true;
      }
    }
    private void cbWesREFS_CheckedChanged(object sender, EventArgs e)
    {
      if (cbWesREFS.Checked == defaultcbWesREFS)
      {
        tbWesREFS.Visible = false;
        lbWesREFS.Visible = false;
      }
      else
      {
        tbWesREFS.Visible = true;
        lbWesREFS.Visible = true;
      }
    }
    private void cbWesSECFC_CheckedChanged(object sender, EventArgs e)
    {
      if (cbWesSECFC.Checked == defaultcbWesSECFC)
      {
        tbWesSECFC.Visible = false;
        lbWesSECFC.Visible = false;
      }
      else
      {
        tbWesSECFC.Visible = true;
        lbWesSECFC.Visible = true;
      }
    }
    #endregion Autoplay and WindowsExplorer
    #region AutoLogon shutdown event tracker and remote desktop
    private bool defaultAutoLogOn;
    private string defaultShutDownEventTracker;
    private bool defaultRemoteDesktop;

    private List<TextBox> NotDefaultChoisesLogonShutdownRemoteDesktop = new List<TextBox>();
    public void RememberDefaultsLogonShutdownRemoteDesktop()
    {
      NotDefaultChoisesLogonShutdownRemoteDesktop.Add(tbAutoLogonNotDefault);
      NotDefaultChoisesLogonShutdownRemoteDesktop.Add(tbShutDownEventTrackerNotDefault);
      NotDefaultChoisesLogonShutdownRemoteDesktop.Add(tbRemoteDesktopNotDefault);


      defaultAutoLogOn = cbAutoLogon.Checked;
      defaultShutDownEventTracker = combShutDEventTracker.Text;
      defaultRemoteDesktop = rbRemoteDesktopOff.Checked;
    }
    private void combShutDEventTracker_SelectedValueChanged(object sender, EventArgs e)
    {
      if (combShutDEventTracker.Text == defaultShutDownEventTracker)
      {
        lbShutDownEventTrackerNotDefault.Visible = false;
        tbShutDownEventTrackerNotDefault.Visible = false;
      }
      else
      {
        lbShutDownEventTrackerNotDefault.Visible = true;
        tbShutDownEventTrackerNotDefault.Visible = true;
      }
    }

    #endregion AutoLogon shutdown event tracker and remote desktop
    #region Firewall
    private List<string> defaultlistViewFireWallExceptions = new List<string>();

    private bool defaultFireWallState;

    public void RemeberDefaultsFirewall()
    {
      defaultlistViewFireWallExceptions.Clear();
      foreach (string st in libFireWallExceptions.Items)
      {
        defaultlistViewFireWallExceptions.Add(st);
      }
      defaultFireWallState = cbFireWallOnOff.Checked;
    }
    public void CheckFireWallDefaults()
    {

      foreach (string st in libFireWallExceptions.Items)
      {
        if (defaultlistViewFireWallExceptions.Contains(st))
        {

          lbFirewallNotDefault.Visible = false;
          tbFirewallNotDefault.Visible = false;

        }
        else
        {
          lbFirewallNotDefault.Visible = true;
          tbFirewallNotDefault.Visible = true;
        }
      }
      foreach (string strDelete in defaultlistViewFireWallExceptions)
      {
        if (!libFireWallExceptions.Items.Contains(strDelete))
        {
          lbFirewallNotDefault.Visible = true;
          tbFirewallNotDefault.Visible = true;
        }
        else
        {
          lbFirewallNotDefault.Visible = false;
          tbFirewallNotDefault.Visible = false;
        }
      }



    }

    #endregion Firewall
    #region MBSA
    private bool defaultMBSA;
    public void RememberDefaultsMBSA()
    {
      defaultMBSA = cbMBSA.Checked;
    }
    #endregion MBSA
    #region IIS
    private bool defaultIISState;
    private bool defaultcbWebAllowAnonymous;
    private bool defaultcbWebScriptSourceAccess;
    private bool defaultcbWebServerRead;
    private bool defaultcbWebServerWrite;
    private bool defaultcbWebDirBrowse;
    private bool defaultcbWebLogVisit;
    private bool defaultcbWebIndexResource;
    private bool defaultcbWebServExec;
    private List<TextBox> NotDefaultIIS = new List<TextBox>();
    private void btAddWebSrv_Click(object sender, EventArgs e)
    {
      using (Pages.AddWebServer popupDialog = new Pages.AddWebServer())
      {
        DialogResult dialogResult = popupDialog.ShowDialog(this);
      }

    }

    public void RememberDefaultIIS()
    {
      cbIISOnOff.Checked = true;

      defaultIISState = cbIISOnOff.Checked;
      NotDefaultIIS.Add(tbIISNotDefault);

    }

    private void cbIISOnOff_CheckedChanged(object sender, EventArgs e)
    {
      if (cbIISOnOff.Checked == defaultIISState)
      {

        lbIISNotDefault.Visible = false;
        tbIISNotDefault.Visible = false;


      }
      else
      {

        lbIISNotDefault.Visible = true;
        tbIISNotDefault.Visible = true;
      }
    }

    private void cbLoginAuthorOnOff_CheckedChanged(object sender, EventArgs e)
    {
      if (cbLoginAuthorOnOff.Checked == false)
      {
        label6.Enabled = false;
        cboWebActiveLogFormat.Enabled = false;
        groupBox7.Enabled = false;
        groupBox9.Enabled = false;

      }
      else
      {
        label6.Enabled = true;
        cboWebActiveLogFormat.Enabled = true;
        groupBox7.Enabled = true;
        groupBox9.Enabled = true;
      }

    }
    private void rbIISLocalSystemAccount_CheckedChanged(object sender, EventArgs e)
    {
      if (rbIISLocalSystemAccount.Checked)
      {
        tbIISCustomAccount.Enabled = false;
        tbIISCustomAccountPass.Enabled = false;
        btIISBrowse.Enabled = false;
        btIISServiceLogin.Enabled = false;
      }
      else
      {
        tbIISCustomAccount.Enabled = true;
        tbIISCustomAccountPass.Enabled = true;
        btIISBrowse.Enabled = true;
        btIISServiceLogin.Enabled = true;
      }

    }

    #endregion IIS
    #region Mail Server
    private bool defaultcbMailSrvConfOnOrOff;
    private bool defaultcbMailSrvAllowAnonym;
    private bool defaultcbMailSrvRelay;
    private bool defaultcbLoggingMailOnOff;
    private bool defaultcbMailLogDelete;
    private bool defaultrbMailLogDay;
    private List<TextBox> NotDefaultMailSrv = new List<TextBox>();
    public void RememberDefaultMailSrv()
    {
      cbMailSrvConfOnOrOff.Checked = false;
      cbMailSrvAllowAnonym.Checked = false;
      cbMailSrvRelay.Checked = false;
      cbMailSrvRelayAllowSuccessAuthen.Checked = false;
      cbLoggingMailOnOff.Checked = false;
      cbMailLogDelete.Checked = true;
      rbMailLogDay.Checked = true;
      defaultcbMailSrvAllowAnonym = cbMailSrvAllowAnonym.Checked;
      defaultcbMailSrvConfOnOrOff = cbMailSrvConfOnOrOff.Checked;
      defaultcbMailSrvRelay = cbMailSrvRelay.Checked;
      defaultcbLoggingMailOnOff = cbLoggingMailOnOff.Checked;
      defaultcbMailLogDelete = cbMailLogDelete.Checked;
      defaultrbMailLogDay = rbMailLogDay.Checked;
      NotDefaultMailSrv.Add(tbMailSrvNotDefault);
    }
    private void cbMailSrvConfOnOrOff_CheckedChanged(object sender, EventArgs e)
    {
      if (cbMailSrvConfOnOrOff.Checked == defaultcbMailSrvConfOnOrOff)
      {
        lbMailSrvNotDefault.Visible = false;
        tbMailSrvNotDefault.Visible = false;
        cbMailSrvAllowAnonym.Enabled = false;
        cbMailSrvRelay.Enabled = false;
      }
      else
      {
        lbMailSrvNotDefault.Visible = true;
        tbMailSrvNotDefault.Visible = true;
        cbMailSrvAllowAnonym.Enabled = true;
        cbMailSrvRelay.Enabled = true;
      }

    }
    private void cbMailSrvAllowAnonym_CheckedChanged(object sender, EventArgs e)
    {
      if (cbMailSrvAllowAnonym.Checked == defaultcbWebAllowAnonymous)
      {
        lbMailSrvNotDefault.Visible = false;
        tbMailSrvNotDefault.Visible = false;
      }
      else
      {
        lbMailSrvNotDefault.Visible = true;
        tbMailSrvNotDefault.Visible = true;
      }

    }
    private void cbMailSrvRelay_CheckedChanged(object sender, EventArgs e)
    {
      if (cbMailSrvRelay.Checked == defaultcbMailSrvRelay)
      {
        lbMailSrvNotDefault.Visible = false;
        tbMailSrvNotDefault.Visible = false;
        gbMailSrvRelay.Enabled = false;

      }
      else
      {
        lbMailSrvNotDefault.Visible = true;
        tbMailSrvNotDefault.Visible = true;
        gbMailSrvRelay.Enabled = true;
      }


    }
    private void cbLoggingMailOnOff_CheckedChanged(object sender, EventArgs e)
    {
      if (cbLoggingMailOnOff.Checked == defaultcbLoggingMailOnOff)
      {
        lbMailSrvNotDefault.Visible = false;
        tbMailSrvNotDefault.Visible = false;
      }
      else
      {
        lbMailSrvNotDefault.Visible = true;
        tbMailSrvNotDefault.Visible = true;
      }

    }

    private void rbMailLogSizeReach_CheckedChanged(object sender, EventArgs e)
    {
      if (!rbMailLogSizeReach.Checked)
      {
        nudMailLogSize.Enabled = false;
      }
      else
      {
        nudMailLogSize.Enabled = true;
      }

    }


    #endregion Mail Server
    #region FTP


    private void cbFTPLoggingOnOff_CheckedChanged(object sender, EventArgs e)
    {

      if (cbFTPLoggingOnOff.Checked == false)
      {
        cboFTPLogFormat.Enabled = false;
        rbFTPLogDay.Enabled = false;
        rbFTPLogHour.Enabled = false;
        rbFTPLogMonth.Enabled = false;
        rbFTPLogSizeReach.Enabled = false;
        rbFTPLogUnlimit.Enabled = false;
        rbFTPLogWeek.Enabled = false;
        tbFTPLogLocation.Enabled = false;
        btFTPLogBrowse.Enabled = false;
        cbFTPLogDelete.Enabled = false;

      }
      else
      {
        cboFTPLogFormat.Enabled = true;
        rbFTPLogDay.Enabled = true;
        rbFTPLogHour.Enabled = true;
        rbFTPLogMonth.Enabled = true;
        rbFTPLogSizeReach.Enabled = true;
        rbFTPLogUnlimit.Enabled = true;
        rbFTPLogWeek.Enabled = true;
        tbFTPLogLocation.Enabled = true;
        btFTPLogBrowse.Enabled = true;
        cbFTPLogDelete.Enabled = true;
      }
    }
    private void rbFTPLocalLocated_Click(object sender, EventArgs e)
    {
      lbFTPNet.Visible = false;
      cbFTPDir.Visible = true;
      btFtpShareConnect.Visible = false;
      lbFTPLocal.Visible = true;
      tbFTPPath.Visible = false;
      btRemoveFtpSrv.Visible = true;
      btAddFtpSrv.Visible = true;

    }
    private void rbFtpShareLocated_Click(object sender, EventArgs e)
    {
      lbFTPLocal.Visible = false;
      tbFTPPath.Visible = true;
      btFtpShareConnect.Visible = true;
      lbFTPNet.Visible = true;
      cbFTPDir.Visible = false;
      btRemoveFtpSrv.Visible = false;
      btAddFtpSrv.Visible = false;

    }


    #endregion FTP

    #region Network configuration
    private void rbIPAutoObtain_CheckedChanged(object sender, EventArgs e)
    {
      if (rbIPManual.Checked)
      {
        rbDNSAuto.Enabled = false;
        rbDNSManual.Checked = true;
        lbIPaddress.Enabled = true;
        lbSubnetMask.Enabled = true;
        lbDefaultGateway.Enabled = true;
        tbIPaddress.Enabled = true;
        tbSubnetMask.Enabled = true;
        tbDefaultGateway.Enabled = true;
        _configClass.ConfigureSetNetwork.IpAutoAssign = false;

      }
      else if (!rbIPManual.Checked)
      {
        lbIPaddress.Enabled = false;
        lbSubnetMask.Enabled = false;
        lbDefaultGateway.Enabled = false;
        tbIPaddress.Enabled = false;
        tbSubnetMask.Enabled = false;
        tbDefaultGateway.Enabled = false;
        rbDNSAuto.Enabled = true;
        rbDNSAuto.Checked = true;
        _configClass.ConfigureSetNetwork.IpAutoAssign = true;
      }
    }


    private void rbDNSAuto_CheckedChanged(object sender, EventArgs e)
    {
      if (!rbDNSManual.Checked)
      {
        lbDNSAlt.Enabled = false;
        lbDNSPre.Enabled = false;
        tbDNSAlt.Enabled = false;
        tbDNSPre.Enabled = false;
        _configClass.ConfigureSetNetwork.DnsAutoAssign = true;
      }
      else
      {
        lbDNSAlt.Enabled = true;
        lbDNSPre.Enabled = true;
        tbDNSAlt.Enabled = true;
        tbDNSPre.Enabled = true;
        _configClass.ConfigureSetNetwork.DnsAutoAssign = false;
      }

    }
    #endregion Network configuration

    #endregion Log not default choises
    public List<string> globalGroupMembers
    {
      get
      {
        return _globalGroupMembers;
      }
      set
      {
        _globalGroupMembers = value;
      }
    }
    public List<string> localGroupMembers
    {
      get
      { return _localGroupMembers; }
      set
      { _localGroupMembers = value; }
    }
    public List<string> localUserMembers
    {
      get { return _localUserMembers; }
      set { _localUserMembers = value; }
    }

    /// <summary>
    /// Get or set FinalListOfExceptions
    /// </summary>
    public List<string> FinalListOfExceptions
    {
      get { return _finalListOfExceptions; }
      set { _finalListOfExceptions = value; }
    } private List<string> _finalListOfExceptions = new List<string>();

    /// <summary>
    /// Get or set ListOfAllFirewallExceptions
    /// </summary>
    public List<string> ListOfAllFirewallExceptions
    {
      get { return _listOfAllFirewallExceptions; }
      set { _listOfAllFirewallExceptions = value; }
    } private List<string> _listOfAllFirewallExceptions = new List<string>();

    public List<string> ListOfModifiedNewFirewallRules
    {
      get
      { return _listOfModifiedNewFirewallRules; }
      set
      { _listOfModifiedNewFirewallRules = value; }
    }private List<string> _listOfModifiedNewFirewallRules = new List<string>();

    public List<string> ListOfModifiedOldFirewallRule
    {
      get
      { return _listOfModifiedOldFirewallRule; }
      set
      { _listOfModifiedOldFirewallRule = value;}

    }private List<string> _listOfModifiedOldFirewallRule = new List<string>();

    #region Main

    #region wizard buttons

    /// <summary>
    /// Get or set CurrentWissWizardMode
    /// </summary>
    public WiSSWizardMode CurrentWissWizardMode
    {
      get { return _currentWissWizardMode; }
      set { _currentWissWizardMode = value; }
    } private WiSSWizardMode _currentWissWizardMode = WiSSWizardMode.All;

    private void wizard1_CancelButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      bool d = backgroundWorker1.IsBusy;
      backgroundWorker1.WorkerSupportsCancellation = true;
      backgroundWorker1.CancelAsync();

      Actemium.WiSSWizard.MainForm.ActiveForm.Close();

    }
    private void wizard1_FinishButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      string message1 = "The computer must be restarted \n for the changes to take effect.\n\nDo you want to restart?";
      string caption1 = "Restart";
      string message2 = "Save all your works\nClick OK to restart the system";


      MessageBoxButtons buttons = MessageBoxButtons.YesNo;
      DialogResult result;
      // Displays the MessageBox.
      result = MessageBox.Show(message1, caption1, buttons);

      if (result == System.Windows.Forms.DialogResult.Yes)
      {
        buttons = MessageBoxButtons.OK;
        result = MessageBox.Show(message2, caption1, buttons);
        if (result == System.Windows.Forms.DialogResult.OK)
        {
          System.Diagnostics.Process.Start("ShutDown", "/r");
        }

      }
      if (result == System.Windows.Forms.DialogResult.No)
      {
        Application.Exit();
      }

    }
    #endregion wizard buttons
    #region Specify Wizard Page types


    public void RememberDefaultWizardPageType()
    {
      this.wpSelectNameAndSystem.PageWiSSWizardMode = WiSSWizardMode.All;
      this.wpInstalledApllications.PageWiSSWizardMode = WiSSWizardMode.All;
      this.wpPasswordPolicy.PageWiSSWizardMode = WiSSWizardMode.Security;
      this.wpControlPolicy.PageWiSSWizardMode = WiSSWizardMode.Security;
      this.wpGroups.PageWiSSWizardMode = WiSSWizardMode.Security;
      this.wpDefaultAccounts.PageWiSSWizardMode = WiSSWizardMode.SecurityAndLockdown;
      this.wpUsers.PageWiSSWizardMode = WiSSWizardMode.Security;
      this.wpAutoPlayAndWExplorer.PageWiSSWizardMode = WiSSWizardMode.SecurityAndLockdown;
      this.wpAutoLogonAndEventTracker.PageWiSSWizardMode = WiSSWizardMode.Security;
      this.wpSQLConfig.PageWiSSWizardMode = WiSSWizardMode.Security;
      this.wpPCAnywhere.PageWiSSWizardMode = WiSSWizardMode.Lockdown;
      this.wpIIS.PageWiSSWizardMode = WiSSWizardMode.Security;
      this.wpFireWall.PageWiSSWizardMode = WiSSWizardMode.SecurityAndLockdown;
      this.wpBlockKey.PageWiSSWizardMode = WiSSWizardMode.Lockdown;
      this.wpSharedFolderConfig.PageWiSSWizardMode = WiSSWizardMode.Lockdown;
      this.wpNetworkConfigure.PageWiSSWizardMode = WiSSWizardMode.Security;
      this.wpMBSA.PageWiSSWizardMode = WiSSWizardMode.All;
      this.wpAcceptSettings.PageWiSSWizardMode = WiSSWizardMode.All;
      this.wpConfigurationCheck.PageWiSSWizardMode = WiSSWizardMode.All;
      this.wpConfigErrorOverview.PageWiSSWizardMode = WiSSWizardMode.All;
      this.wpMBSAlogOverview.PageWiSSWizardMode = WiSSWizardMode.All;
      this.wpFinish.PageWiSSWizardMode = WiSSWizardMode.All;
    }
    #endregion Specify Wizard Page Type
    #region select name and system
    private void tbFirstNamePnStart_TextChanged(object sender, EventArgs e)
    {
      if (ValidUserName())
      {
        wpSelectNameAndSystem.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.True;
      }
      else
      {
        wpSelectNameAndSystem.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
      }
    }
    private void tbFamilyNamePnStart_TextChanged(object sender, EventArgs e)
    {
      if (ValidUserName())
      {
        wpSelectNameAndSystem.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.True;
      }
      else
      {
        wpSelectNameAndSystem.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
      }
    }
    private void wpSelectNameAndSystem_BackButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      btCheckCurrentSettings.Visible = true;
      ttCheckCurrentSettings.Visible = true;
    }
    private bool ValidUserName()
    {
      bool firstname = false;
      bool lastname = false;

      const string ALLVALIDCHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789~!@#$%^&*_-+=`|(){}[]:;'<>,.?";
      for (int i = 0; i < ALLVALIDCHARS.Length; i++)
      {
        if (!firstname && tbFirstNamePnStart.Text.Contains(ALLVALIDCHARS[i]))
        {
          firstname = true;
          if (lastname)
          {
            return true;
          }
        }
        if (!lastname && tbFamilyNamePnStart.Text.Contains(ALLVALIDCHARS[i]))
        {
          lastname = true;
          if (firstname)
          {
            return true;
          }
        }
      }

      return false;
    }
    private void rbLoadTemplate_CheckedChanged(object sender, EventArgs e)
    {
      if (!rbLoadTemplate.Checked)
      {
        gbSelectTemplate.Visible = false;
      }
      else
      {
        _currentWissWizardMode = WiSSWizardMode.Template;
        gbSelectTemplate.Visible = true;
      }

    }
    private void rbAllsettingsPnStart_CheckedChanged(object sender, EventArgs e)
    {
      if (rbAllsettingsPnStart.Checked)
      {
        _currentWissWizardMode = WiSSWizardMode.SecurityAndLockdown;
      }

    }
    private void rbSecurityPnStart_CheckedChanged(object sender, EventArgs e)
    {
      if (rbSecurityPnStart.Checked)
      {
        _currentWissWizardMode = WiSSWizardMode.Security;
      }

    }
    private void rbLockDownPnStart_CheckedChanged(object sender, EventArgs e)
    {
      if (rbLockDownPnStart.Checked)
      {
        _currentWissWizardMode = WiSSWizardMode.Lockdown;
      }

    }

    private void btSelectTemplate_Click(object sender, EventArgs e)
    {
      string Filename = "";
      using (OpenFileDialog ofLoadTemplateStart = new OpenFileDialog())
      {
        ofLoadTemplateStart.Filter = "XML (*xml)|*.xml|" +
        "All Files(*.*)|*.*";
        if (ofLoadTemplateStart.ShowDialog() == DialogResult.OK)
        {
          Filename = ofLoadTemplateStart.FileName;
        }

      }

    }

    #endregion select name and system

    #region Get current password policy
    /// <summary>
    /// Get all the current password policies
    /// by running method GetAllCurrentPasswordPolicy which will call 
    /// the script from class ScriptHandling which actually do the job 
    /// with powershell script
    /// </summary>
    /// <returns>return the type of PasswordPolicy</returns>
    //private PasswordPolicy GetCurrentPasswordPolicy()
    //{
    //  const string FUNCTIONNAME = "GetCurrentPasswordPolicy";

    //  Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
    //  PasswordPolicy passwordPolicy = _configClass.ConfSetPasswordPolicy;
    //  passwordPolicy.GetAllCurrentPasswordPolicy();
    //  tbCurrentMaximumPwAge.Text = passwordPolicy.MaximumPasswordAge.ToString();
    //  tbCurrentMinimumPwAge.Text = passwordPolicy.MinimumPasswordAge.ToString();
    //  tbCurrentMinimumPwLength.Text = passwordPolicy.MinimumPasswordLength.ToString();
    //  tbCurrentNoOfSavedPw.Text = passwordPolicy.PasswordHistorySize.ToString();
    //  cbCurrentComplexityPW.Text = passwordPolicy.PasswordComplexity.ToString();
    //  if (cbCurrentComplexityPW.Text == "0")
    //    cbCurrentComplexityPW.Text = "Disabled";
    //  else if (cbCurrentComplexityPW.Text == "1")
    //    cbCurrentComplexityPW.Text = "Enabled";
    //  cbCurrentEncryptionPW.Text = passwordPolicy.ClearTextPassword.ToString();
    //  if (cbCurrentEncryptionPW.Text == "0")
    //    cbCurrentEncryptionPW.Text = "Disabled";
    //  else if (cbCurrentEncryptionPW.Text == "1")
    //    cbCurrentEncryptionPW.Text = "Enabled";
    //  return passwordPolicy;
    //}
    private void GetAllCurrentPasswordPolicies()
    {
      const string FUNCTIONNAME = "GetAllCurrentPasswordPolicies";

      Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
      _scriptHandling.GetPWPoliciesAndAuditPolicies();
      tbCurrentMaximumPwAge.Text = _scriptHandling.MaximumPasswordAge;
      tbCurrentMinimumPwAge.Text = _scriptHandling.MinimumPasswordAge;
      tbCurrentMinimumPwLength.Text = _scriptHandling.MinimumPasswordLength;
      tbCurrentNoOfSavedPw.Text = _scriptHandling.PasswordHistorySize;
      bool passwordComplex = false;
      passwordComplex = _scriptHandling.PasswordComplexity;
      if (passwordComplex == true)
        cbCurrentComplexityPW.Text = "Enabled";
      else
        cbCurrentComplexityPW.Text = "Disabled";

      bool passwordReversibleEncryp = false;
      passwordReversibleEncryp = _scriptHandling.ClearTextPassword;
      if (passwordReversibleEncryp == true)
        cbCurrentEncryptionPW.Text = "Enabled";
      else
        cbCurrentEncryptionPW.Text = "Disabled";     
    }
    #endregion Get current password policy
    #region Get all current Audit policies

    private void GetAllCurrentAuditPolicies()
    {
      const string FUNCTIONNAME = "GetAllCurrentAuditPolicies";
      Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
      _scriptHandling.GetPWPoliciesAndAuditPolicies();
      tbAuditAccLogEvents.Text = _scriptHandling.AuditAccountLogon;
      tbAuditAccManage.Text = _scriptHandling.AuditAccountManage;
      tbAuditDirSerAccess.Text = _scriptHandling.AuditDSAccess;
      tbAuditLogEvents.Text = _scriptHandling.AuditLogonEvents;
      tbAuditObjectAccess.Text = _scriptHandling.AuditObjectAccess;
      tbAuditPolicyChange.Text = _scriptHandling.AuditPolicyChange;
      tbAuditPrivilegeUse.Text = _scriptHandling.AuditPrivilegeUse;
      tbAuditProcessTracking.Text = _scriptHandling.AuditProcessTracking;
      tbAuditSystemEvents.Text = _scriptHandling.AuditSystemEvents;
    }
    #endregion Get all current Audit policies
    #region Get all windows explorer settings
    /// <summary>
    /// This will call GetAllCurrentWindowsSettings method which will call
    /// ShowCurrentWindowsSettings in ScriptHandling class
    /// </summary>
    /// <returns>return the type of WindowsExplorerSettings</returns>
    private WindowsExplorerSettings GetCurrentWindowsSettings()
    {
      const string FUNCTIONNAME = "GetCurrentWindowsSettings";
      Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
      WindowsExplorerSettings windowsExplorer = _configClass.ConfSetwindowsExplorerSettings;
      windowsExplorer.GetAllCurrentWindowsSettings(_configClass);
      if (windowsExplorer.DisplayContentOfSystemFolder)
        cbWesDCSF.Checked = true;
      else
        cbWesDCSF.Checked = false;
      if (windowsExplorer.DisplayFullPathInAddressBar)
        cbWesDFPAB.Checked = true;
      else
        cbWesDFPAB.Checked = false;
      if (windowsExplorer.ShowHiddenFolders)
        cbWesSHFF.Checked = true;
      else
        cbWesSHFF.Checked = false;
      if (windowsExplorer.AutomaticallySearchNetworkFoldersAndPrinters)
        cbWesASNFP.Checked = true;
      else
        cbWesASNFP.Checked = false;
      if (windowsExplorer.HideExtensions)
        cbWesHEKF.Checked = true;
      else
        cbWesHEKF.Checked = false;
      if (windowsExplorer.HideProtectedOSFiles)
        cbWesHPOSF.Checked = true;
      else
        cbWesHPOSF.Checked = false;
      if (windowsExplorer.RememberEachFoldersViewSetting)
        cbWesREFS.Checked = true;
      else
        cbWesREFS.Checked = false;
      if (windowsExplorer.ShowNTFSFilesInColor)
        cbWesSECFC.Checked = true;
      else
        cbWesSECFC.Checked = false;
      if (windowsExplorer.AutoplayCD)
        rbEnabledAP.Checked = true;
      else
        rbDisabledAP.Checked = true;
      return windowsExplorer;
    }

    #endregion Get all windows explorer settings

#warning next version will correct this
    public bool IsIpAddress(String strNumber)
    {
      Regex objNotNaturalPattern = new Regex("[^0-9]");
      //3 number and 1 dot and 4 times
      Regex ipPattern = new Regex("\\b\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\b");
      Regex objNaturalPattern = new Regex("0*[1-9][0-9]*");
      return !objNotNaturalPattern.IsMatch(strNumber) &&
      objNaturalPattern.IsMatch(strNumber) && ipPattern.IsMatch(strNumber);
    }

    /// <summary>
    /// Get or set AllFirewallExceptions
    /// </summary>
    //public List<FireWallException> AllFirewallExceptions
    //{
    //  get { return _allFirewallExceptions; }
    //  set { _allFirewallExceptions = value; }
    //}

    #region wizardpages next button clicks
    private void wpStartUp_NextButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      Trace.WriteInformation("()", "wpStartUp_NextButtonClick", CLASSNAME);
      btCheckCurrentSettings.Visible = false;
      ttCheckCurrentSettings.Visible = false;
      tbFirstNamePnStart.Focus();
    }
    private void wpSelectNameAndSystem_NextButtonClick(object sender, CancelEventArgs e)
    {
      const string FUNCTIONNAME = "wpSelectNameAndSystem_NextButtonClick";
      try
      {
        Trace.WriteInformation("()", FUNCTIONNAME, CLASSNAME);
        if (ValidUserName())
        {
          _configClass.ConfSetDefaultInformation.ApplicationUserName = tbFirstNamePnStart.Text;
          _configClass.ConfSetDefaultInformation.ApplicationFamilyName = tbFamilyNamePnStart.Text;
          _configClass.ConfSetDefaultInformation.Operatingsystem = cbOperatingSystemPnStart.Text;

          if (cbOperatingSystemPnStart.Visible)
          {
            _configClass.ConfSetDefaultInformation.Operatingsystem = cbOperatingSystemPnStart.Text;
          }
          else
          {
            _configClass.ConfSetDefaultInformation.Operatingsystem = setOSVersion();
          }

          if (rbSecurityPnStart.Checked)
          {
            _configClass.ConfSetDefaultInformation.SecurityConfiguration = true;
            _configClass.ConfSetDefaultInformation.AdvancedConfiguration = false;
            _configClass.ConfSetDefaultInformation.LockDownConfiguration = false;
          }
          else
          {
            _configClass.ConfSetDefaultInformation.SecurityConfiguration = false;
            _configClass.ConfSetDefaultInformation.AdvancedConfiguration = true;
            _configClass.ConfSetDefaultInformation.LockDownConfiguration = true;
          }
          if (rbLockDownPnStart.Checked)
          {
            _configClass.ConfSetDefaultInformation.LockDownConfiguration = true;
            _configClass.ConfSetDefaultInformation.AdvancedConfiguration = false;
            _configClass.ConfSetDefaultInformation.SecurityConfiguration = false;
          }
          else
          {
            _configClass.ConfSetDefaultInformation.LockDownConfiguration = false;
            _configClass.ConfSetDefaultInformation.AdvancedConfiguration = true;
            _configClass.ConfSetDefaultInformation.SecurityConfiguration = true;
          }
          if (rbLoadTemplate.Checked)
          {
            _configClass.ConfSetDefaultInformation.SecurityConfiguration = false;
            _configClass.ConfSetDefaultInformation.AdvancedConfiguration = false;
            _configClass.ConfSetDefaultInformation.LockDownConfiguration = false;
          }

          if (_configClass.ConfInstalledSoftware.IsApplicationInstalled("Symantec pcAnywhere"))
          {
            pbInstalledSoftware1.Image = checkImages.Images[0];
            _configClass.ConfInstalledSoftware.PcAnywhere = true;
          }

          if (_configClass.ConfInstalledSoftware.IsApplicationInstalled("BlockKeys"))
          {
            pbInstalledSoftware2.Image = checkImages.Images[0];
            _configClass.ConfInstalledSoftware.BlockKeys = true;
          }
          if (_configClass.ConfInstalledSoftware.IsApplicationInstalled("Microsoft SQL Server"))
          {
            pbInstalledSoftware3.Image = checkImages.Images[0];
            _configClass.ConfInstalledSoftware.SQLServer = true;
          }
          if (_configClass.ConfInstalledSoftware.IsApplicationInstalled("IIS"))
          {
            pbInstalledSoftware4.Image = checkImages.Images[0];
            _configClass.ConfInstalledSoftware.IIS = true;
          }
          if (_configClass.ConfInstalledSoftware.IsApplicationInstalled("Microsoft Baseline Security Analyzer"))
          {
            pbInstalledSoftware5.Image = checkImages.Images[0];
            _configClass.ConfInstalledSoftware.MBSA = true;
          }
          if (_configClass.ConfInstalledSoftware.IsApplicationInstalled("McAfee VirusScan Enterprise"))
          {
            pbInstalledSoftware6.Image = checkImages.Images[0];
            _configClass.ConfInstalledSoftware.AntiVirus = true;
            label69.Text = "McAfee VirusScan Enterprise";

          }
          else if (_configClass.ConfInstalledSoftware.IsApplicationInstalled("Kaspersky"))
          {
            pbInstalledSoftware6.Image = checkImages.Images[0];
            _configClass.ConfInstalledSoftware.AntiVirus = true;
            label69.Text = "Kaspersky anti-virus";
          }
          else if (_configClass.ConfInstalledSoftware.IsApplicationInstalled("Bit Defender"))
          {
            pbInstalledSoftware6.Image = checkImages.Images[0];
            _configClass.ConfInstalledSoftware.AntiVirus = true;
            label69.Text = "Bit Defender Anti-virus";

          }
          else if (_configClass.ConfInstalledSoftware.IsApplicationInstalled("Norton Antivirus"))
          {
            pbInstalledSoftware6.Image = checkImages.Images[0];
            _configClass.ConfInstalledSoftware.AntiVirus = true;
            label69.Text = "Norton Anti-virus";

          }
          else if (_configClass.ConfInstalledSoftware.IsApplicationInstalled("Avast"))
          {
            pbInstalledSoftware6.Image = checkImages.Images[0];
            _configClass.ConfInstalledSoftware.AntiVirus = true;
            label69.Text = "Avast Anti-virus";

          }
          else
          {
            label76.Text = "No anti-virus program has been found, it is recommended that you install an anti-virus program";
            pbInstalledSoftware6.Visible = false;
            label69.Visible = false;
          }


        }
        else
        {
          e.Cancel = true;
          MessageBox.Show("Not all required fields are checked!", "Not completed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("()", FUNCTIONNAME, CLASSNAME, ex);
        MessageBox.Show(ex.Message);
      }


    }
    private void wpInstalledApllications_NextButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      Trace.WriteInformation("()", "wpInstalledApllications_NextButtonClick", CLASSNAME);

      wpConfigErrorOverview.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
      wpPasswordPolicy.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.True;
      //GetCurrentPasswordPolicy();
    }
    private void wpPasswordPolicy_NextButtonClick(object sender, CancelEventArgs e)
    {
      Trace.WriteInformation("()", "wpPasswordPolicy_NextButtonClick", CLASSNAME);
      if (nudMinPaswordTime.Value < nudMaxPaswordTime.Value)
      {
        //Maximum password age
        _configClass.ConfSetPasswordPolicy.MaximumPasswordAge = Convert.ToInt32(
          nudMaxPaswordTime.Value);

        //Minimum password age
        _configClass.ConfSetPasswordPolicy.MinimumPasswordAge = Convert.ToInt32(nudMinPaswordTime.Value);

        //Maximum password length
        _configClass.ConfSetPasswordPolicy.MinimumPasswordLength = Convert.ToInt32(nudMinPaswordlength.Value);

        //Number of used passwords remembered
        _configClass.ConfSetPasswordPolicy.PasswordHistorySize = Convert.ToInt32(nudNrOfRememberedPasw.Value);
        //password comply with complexity requirements
        if (cbComplexityPW.Text.Contains("Enabled"))
        {
          _configClass.ConfSetPasswordPolicy.PasswordComplexity = 1;
        }
        else if (cbComplexityPW.Text.Contains("Disabled"))
        {
          _configClass.ConfSetPasswordPolicy.PasswordComplexity = 0;
        }
        //Store password using reversible encryption
        if (cbEncryptionPW.Text.Contains("Enabled"))
        {
          _configClass.ConfSetPasswordPolicy.ClearTextPassword = 1;
        }
        else if (cbEncryptionPW.Text.Contains("Disabled"))
        {
          _configClass.ConfSetPasswordPolicy.ClearTextPassword = 0;
        }
      }
      else
      {
        e.Cancel = true;
        MessageBox.Show("The Minimum password age must be less than the Maximum password age", "Check password length", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      //GetCurrentAuditPolicies();
    }
    private void wpControlPolicy_NextButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      Trace.WriteInformation("()", "wpControlPolicy_NextButtonClick", CLASSNAME);
      errorProvider.Clear();
      foreach (TextBox tb in NotDefaultChoisesAuditControl)
      {
        if (tb.Visible && tb.Text.Length == 0)
        {
          errorProvider.SetError(tb, "Not all required fields are filled");
          e.Cancel = true;
        }
      }
      /*
      "Not checked" 0
      "Successful" 1      
      "Failed" 2
      "Successful, Failed" 3
       */

      //AuditLogonEvents
      _configClass.ConfSetAuditPolicy.AuditLogonEvents = combControlPolicy1.SelectedIndex;
      AddNoDefaultToLog(combControlPolicy1, tbControlPolicy1, "AuditLogonEvents");
      //AuditAccountLogon
      _configClass.ConfSetAuditPolicy.AuditAccountLogon = combControlPolicy2.SelectedIndex;
      AddNoDefaultToLog(combControlPolicy2, tbControlPolicy2, "AuditAccountLogon");
      //AuditAccountManage
      _configClass.ConfSetAuditPolicy.AuditAccountManage = combControlPolicy3.SelectedIndex;
      AddNoDefaultToLog(combControlPolicy3, tbControlPolicy3, "AuditAccountManage");
      //AuditDSAccess
      _configClass.ConfSetAuditPolicy.AuditDSAccess = combControlPolicy4.SelectedIndex;
      AddNoDefaultToLog(combControlPolicy4, tbControlPolicy4, "AuditDSAccess");
      //AuditPolicyChange
      _configClass.ConfSetAuditPolicy.AuditPolicyChange = combControlPolicy5.SelectedIndex;
      AddNoDefaultToLog(combControlPolicy5, tbControlPolicy5, "AuditPolicyChange");
      //AuditPrivilegeUse
      _configClass.ConfSetAuditPolicy.AuditPrivilegeUse = combControlPolicy6.SelectedIndex;
      AddNoDefaultToLog(combControlPolicy6, tbControlPolicy6, "AuditPrivilegeUse");
      //AuditObjectAccess
      _configClass.ConfSetAuditPolicy.AuditObjectAccess = combControlPolicy7.SelectedIndex;
      AddNoDefaultToLog(combControlPolicy7, tbControlPolicy7, "AuditObjectAccess");
      //AuditProcessTracking
      _configClass.ConfSetAuditPolicy.AuditProcessTracking = combControlPolicy8.SelectedIndex;
      AddNoDefaultToLog(combControlPolicy8, tbControlPolicy8, "AuditProcessTracking");
      //AuditSystemEvents
      _configClass.ConfSetAuditPolicy.AuditSystemEvents = combControlPolicy9.SelectedIndex;
      AddNoDefaultToLog(combControlPolicy9, tbControlPolicy9, "AuditSystemEvents");
      _scriptHandling.ShowListOfUsersInRDU();
      
      
    }
    private void wpGroups_NextButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      Trace.WriteInformation("()", "wpGroups_NextButtonClick", CLASSNAME);
      _scriptHandling.putAllLocalGroupsToList();

      if (tbAddUserGroupName.Text.Length != 0)
      {
        MessageBox.Show("Users will only be added after clicking on the button \"Add\"", "Click on Add button.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        e.Cancel = true;

      }

    }
    private void wpDefaultAccounts_NextButtonClick(object sender, CancelEventArgs e)
    {
      errorProvider.Clear();
      if (_configClass.ConfSetWindowsUsers.DefaultGuestAccountInUse)
      {
        if (tbChangePasswDefAccoGuest.Text.Length != 0 || tbChangeConfirmPasswDefAccoGuest.Text.Length != 0)
        {
          if (tbChangePasswDefAccoGuest.Text == tbChangeConfirmPasswDefAccoGuest.Text)
          {
            if (CheckPasswordPolicy(tbChangePasswDefAccoGuest.Text))
            {
              if (CheckPasswordIsNotontheBadList(tbChangePasswDefAccoGuest.Text))
              {
                string name = "";
                string ChangePwNextLogon = "No";
                string PasswordCantBeChanged = "No";
                List<string> userGroupList = new List<string>();
                string PasswordNeverExpires = "No";
                string AccountDisabled = "";
                string modifyOtherSettings = "Yes";
                string NewPassword = "-1";

                #region language
                string oslanguage = System.Globalization.CultureInfo.CurrentCulture.DisplayName;
                if (oslanguage.Contains("Nederland"))
                {
                  name = "Gast";
                }
                else
                {

                  name = "Guest";
                }
                #endregion language
                if (cbBlockDefAccoGuest.Checked)
                {
                  AccountDisabled = "Yes";
                }
                else
                {
                  AccountDisabled = "No";
                }
                if (tbChangeConfirmPasswDefAccoGuest.Text.Length != 0)
                {
                  NewPassword = tbChangePasswDefAccoGuest.Text;
                }
                else
                {
                  NewPassword = "-1";
                }

                ModfiedUser modifyuser = new ModfiedUser(name, "", "", userGroupList, ChangePwNextLogon, PasswordCantBeChanged, PasswordNeverExpires, AccountDisabled, NewPassword, modifyOtherSettings);
                _configClass.ConfSetWindowsUsers.AddModifiedUser = modifyuser;
              }
              else
              {

                errorProvider.SetError(tbChangePasswDefAccoGuest, "The chosen password is on the banned list password\nPlease choose another password.");
                e.Cancel = true;
              }
            }
            else
            {

              errorProvider.SetError(tbChangePasswDefAccoGuest, "The password does not meet the password policy requirements.\n controleer de minimale lengte en wachtwoordcomplexiteit.");
              e.Cancel = true;

            }
          }
          else
          {

            errorProvider.SetError(tbChangePasswDefAccoGuest, "The entered password do not match");
            e.Cancel = true;

          }
        }
      }
      if (_configClass.ConfSetWindowsUsers.DefaultSupportAccountInUse)
      {
        string name = "";
        string ChangePwNextLogon = "No";
        string PasswordCantBeChanged = "No";
        string PasswordNeverExpires = "No";
        string AccountDisabled = "";
        List<string> userGroupList = new List<string>();
        string modifyOtherSettings = "Yes";
        string NewPassword = "-1";

        if (tbChangePasswDefAccoSUPPORT.Text.Length != 0 || tbChangeConfirmPasswDefAccoSUPPORT.Text.Length != 0)
        {
          if (tbChangePasswDefAccoSUPPORT.Text == tbChangeConfirmPasswDefAccoSUPPORT.Text)
          {
            if (CheckPasswordPolicy(tbChangePasswDefAccoSUPPORT.Text))
            {
              if (CheckPasswordIsNotontheBadList(tbChangePasswDefAccoSUPPORT.Text))
              {
                name = _configClass.ConfSetWindowsUsers.CheckIfSUPPORTaccountExist(_configClass);
                if (cbBlockDefAccoSUPPORT.Checked)
                {
                  AccountDisabled = "Yes";
                }
                else
                {
                  AccountDisabled = "No";
                }
                if (tbChangeConfirmPasswDefAccoSUPPORT.Text.Length != 0)
                {
                  NewPassword = tbChangePasswDefAccoSUPPORT.Text;
                }
                else
                {
                  NewPassword = "-1";
                }
                ModfiedUser modifyuser = new ModfiedUser(name, "", "", userGroupList, ChangePwNextLogon, PasswordCantBeChanged, PasswordNeverExpires, AccountDisabled, NewPassword, modifyOtherSettings);
                _configClass.ConfSetWindowsUsers.AddModifiedUser = modifyuser;
              }
              else
              {

                errorProvider.SetError(tbChangePasswDefAccoSUPPORT, "The chosen password is on the banned list password\nPlease choose another password.");
                e.Cancel = true;
              }
            }
            else
            {

              errorProvider.SetError(tbChangePasswDefAccoSUPPORT, "The password does not meet the password policy requirements. \n Check the minimum password length and complexity.");
              e.Cancel = true;

            }

          }

          else
          {

            errorProvider.SetError(tbChangePasswDefAccoSUPPORT, "The entered password does not match");
            e.Cancel = true;
          }
        }
      }
      if (_configClass.ConfSetWindowsUsers.DefaultAdministratorAccountInUse)
      {
        string name = "";
        string ChangePwNextLogon = "No";
        string PasswordCantBeChanged = "No";
        string PasswordNeverExpires = "No";
        string AccountDisabled = "";
        List<string> userGroupList = new List<string>();
        string modifyOtherSettings = "Yes";
        string NewPassword = "-1";
        if (tbChangePasswDefAccoAdministrator.Text.Length != 0 || tbChangeConfirmPasswDefAccoAdministrator.Text.Length != 0)
        {
          if (tbChangePasswDefAccoAdministrator.Text == tbChangeConfirmPasswDefAccoAdministrator.Text)
          {
            if (CheckPasswordPolicy(tbChangePasswDefAccoAdministrator.Text))
            {
              if (CheckPasswordIsNotontheBadList(tbChangePasswDefAccoAdministrator.Text))
              {

                name = "Administrator";
                if (cbBlockDefAccoAdministrator.Checked)
                {
                  AccountDisabled = "Yes";
                }
                else
                {
                  AccountDisabled = "No";
                }
                if (tbChangeConfirmPasswDefAccoAdministrator.Text.Length != 0)
                {
                  NewPassword = tbChangePasswDefAccoAdministrator.Text;
                }
                else
                {
                  NewPassword = "-1";
                }
                // NewPassword = tbChangePasswDefAccoAdministrator.Text;
                ModfiedUser modifyuser = new ModfiedUser(name, "", "", userGroupList, ChangePwNextLogon, PasswordCantBeChanged, PasswordNeverExpires, AccountDisabled, NewPassword, modifyOtherSettings);
                _configClass.ConfSetWindowsUsers.AddModifiedUser = modifyuser;
              }
              else
              {

                errorProvider.SetError(tbChangePasswDefAccoAdministrator, "The chosen password is on the banned list passwords \nPlease choose a different password.");
                e.Cancel = true;
              }
            }
            else
            {

              errorProvider.SetError(tbChangePasswDefAccoAdministrator, "The password does not meet the password policy requirements. \n Check the password minimum length and complexity.");
              e.Cancel = true;

            }
          }
          else
          {

            errorProvider.SetError(tbChangePasswDefAccoAdministrator, "The entered password does not match");
            e.Cancel = true;
          }
        }
      }


    }
    private void wpUsers_NextButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      Trace.WriteInformation("()", "wpUsers_NextButtonClick", CLASSNAME);
      if (cbSavePasswordInLogFile.Checked)
      {
        _configClass.ConfSetWindowsUsers.SavePasswordsInLogfile = true;
      }
      else
      {
        _configClass.ConfSetWindowsUsers.SavePasswordsInLogfile = false;
      }

      if (!cbCreateAdminUser.Checked && cbBlockDefAccoAdministrator.Checked)
      {
        if (cbCreateAdminUser.Enabled)
        {
          e.Cancel = true;
          MessageBox.Show("It is not possible to proceed without an Admin account \n the admins account is disabled.", "Admin account", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      #region validate Actemium account
      if (cbCreateActemiumUser.Checked)
      {
        if ((tbPWActemium.Text != ""))
        {
          if ((tbPWActemium.Text == tbPWcomfimActemium.Text))
          {
            if (CheckPasswordPolicy(tbPWActemium.Text))
            {
              if (CheckPasswordIsNotontheBadList(tbPWActemium.Text))
              {
                NewUser temp = new NewUser();
                foreach (NewUser user in _configClass.ConfSetWindowsUsers.NewUsers)
                {
                  if (user.Name == "Actemium")
                  {
                    temp = user;
                    temp.Password = tbPWActemium.Text;
                    _configClass.ConfSetWindowsUsers.NewUsers.Remove(user);
                    break;
                  }
                }
                _configClass.ConfSetWindowsUsers.AddNewUser = temp;
              }
              else
              {
                e.Cancel = true;
                MessageBox.Show("The selected password acount \"Actemium \" is on the banned list passwords \nPlease choose a different password.", "Check the password.", MessageBoxButtons.OK, MessageBoxIcon.Error);

              }
            }
            else
            {
              e.Cancel = true;
              MessageBox.Show("The acount password \"Actemium \" does not meet the password policy requirements. \n controller the minimum password length and complexity.", "Check password policy.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
          else
          {
            e.Cancel = true;
            MessageBox.Show("The acount passwords \"Actemium \" do not match", "Check the password");
          }
        }
        else
        {
          e.Cancel = true;
          MessageBox.Show("The password field of acount \"Actemium \" must not be empty ", "Type in a password");
        }
      }
      #endregion validate Actemium account
      #region validate Admin account
      if (cbCreateAdminUser.Checked)
      {
        if ((tbPWAdmin.Text != ""))
        {
          if ((tbPWAdmin.Text == tbPWcomfimAdmin.Text))
          {
            if (CheckPasswordPolicy(tbPWAdmin.Text))
            {
              if (CheckPasswordIsNotontheBadList(tbPWAdmin.Text))
              {
                NewUser temp = new NewUser();
                foreach (NewUser user in _configClass.ConfSetWindowsUsers.NewUsers)
                {
                  if (user.Name == "Admin")
                  {
                    temp = user;
                    temp.Password = tbPWAdmin.Text;
                    _configClass.ConfSetWindowsUsers.NewUsers.Remove(user);
                    break;
                  }
                }
                _configClass.ConfSetWindowsUsers.AddNewUser = temp;

              }
              else
              {
                e.Cancel = true;
                MessageBox.Show("The selected password acount \"Admin \" is on the banned list passwords \nPlease choose a different password.", "Check the password.", MessageBoxButtons.OK, MessageBoxIcon.Error);

              }
            }
            else
            {
              e.Cancel = true;
              MessageBox.Show("The acount password \"Admin \" does not meet the requirements for the password policy. \n controller the minimum password length and complexity.", "Check password policy.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
          else
          {
            e.Cancel = true;
            MessageBox.Show("The acount passwords \"Admin \" do not match", "Check the passwords");
          }
        }
        else
        {
          e.Cancel = true;
          MessageBox.Show("The password field of acount \"Admin \" must not be empty ", "Fill in the password");
        }
      }
      #endregion validate Admin account

      if (tbAddUserUserName.Text != "" || tbAddUserFullName.Text != "" || tbAddUserDescription.Text != "" ||
          tbAddUserPasword1.Text != "" || tbAddUserPasword2.Text != "")
      {
        MessageBox.Show("User will only be added after clicking on the button \"Add \"", "Click on Add button.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        e.Cancel = true;

      }

      _configClass.ConfSetWindowsUsers.CheckIfPassWordsAreEncrypted(_configClass.ConfSetWindowsUsers.SavePasswordsInLogfile);

      if (os == OSVersions.W2008 || os == OSVersions.W2008R2 || os == OSVersions.Windows7)
      {
        cbWesASNFP.Enabled = false;
        cbWesASNFP.Checked = false;

        //  cbWesDCSF.Enabled = false;
        //  cbWesDCSF.Checked = false;
        cbWesREFS.Enabled = false;
        cbWesREFS.Checked = false;
      }
      btWindowsCurrent.Visible = true;
      btWindowsRecommend.Visible = true;
    }
    private void wpAutoPlayAndWExplorer_NextButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      Trace.WriteInformation("()", "wpAutoPlayAndWExplorer_NextButtonClick", CLASSNAME);
      foreach (TextBox tb in NotDefaultChoisesAutoPlayWindowsExplorer)
      {
        if (tb.Visible && tb.Text.Length == 0)
        {
          MessageBox.Show("Not all required fields are completed", "Check the required fields", MessageBoxButtons.OK, MessageBoxIcon.Error);

          e.Cancel = true;
        }
      }

      #region AutoPlay settings
      if (rbDisabledAP.Checked)
      {
        _configClass.ConfSetAutoPlaySettings.AutoPlayOff = true;
        _configClass.ConfSetAutoPlaySettings.AutoPlaySetting = cbAutoplaydrives.SelectedIndex;
        // 0 = CD-ROM and removable media drives
        // 1 = All drives 
      }
      if (rbEnabledAP.Checked)
      {
        _configClass.ConfSetAutoPlaySettings.AutoPlayOff = false;
      }
      if (tbAutoPlayNotDefault.Visible)
      {
        _configClass.ConfSetAutoPlaySettings.AddNoDefaultSettingsToList = new NoDefaultSettingsLog("AutoPlaySettings", tbAutoPlayNotDefault.Text);
      }
      #endregion AutoPlay settings

      #region Windows explorer settings


      if (cbWesASNFP.Enabled)
      {
        //ASNFP = Automatically search for network folders and printers
        _configClass.ConfSetwindowsExplorerSettings.AutomaticallySearchNetworkFoldersAndPrinters = cbWesASNFP.Checked;
      }
      if (tbWesASNFP.Visible)
      {
        _configClass.ConfSetwindowsExplorerSettings.AddNoDefaultSettingsToList = new NoDefaultSettingsLog("Automatically search for network folders and printers", tbWesASNFP.Text);
      }
      if (cbWesDCSF.Enabled)
      {
        //DCSF = Display the contents of system folders 
        _configClass.ConfSetwindowsExplorerSettings.DisplayContentOfSystemFolder = cbWesDCSF.Checked;
      }
      if (tbWesDCSF.Visible)
      {
        _configClass.ConfSetwindowsExplorerSettings.AddNoDefaultSettingsToList = new NoDefaultSettingsLog("Display the contents of system folders", tbWesDCSF.Text);
      }
      if (cbWesDFPAB.Enabled)
      {
        //DFPAB = Display the full path in the address bar
        _configClass.ConfSetwindowsExplorerSettings.DisplayFullPathInAddressBar = cbWesDFPAB.Checked;
      }
      if (tbWesDFPAB.Visible)
      {
        _configClass.ConfSetwindowsExplorerSettings.AddNoDefaultSettingsToList = new NoDefaultSettingsLog("Display the full path in the address bar", tbWesDFPAB.Text);
      }
      if (cbWesSHFF.Enabled)
      {
        //SHFF = show hidden files and folders
        _configClass.ConfSetwindowsExplorerSettings.ShowHiddenFolders = cbWesSHFF.Checked;
      }
      if (tbWesSHFF.Visible)
      {
        _configClass.ConfSetwindowsExplorerSettings.AddNoDefaultSettingsToList = new NoDefaultSettingsLog("show hidden files and folders", tbWesSHFF.Text);
      }
      if (cbWesHEKF.Enabled)
      {
        //HEKF = Hide extensions fot known file types
        _configClass.ConfSetwindowsExplorerSettings.HideExtensions = cbWesHEKF.Checked;

      }
      if (tbWesHEKF.Visible)
      {
        _configClass.ConfSetwindowsExplorerSettings.AddNoDefaultSettingsToList = new NoDefaultSettingsLog("Hide extensions fot known file types", tbWesHEKF.Text);
      }
      if (cbWesHPOSF.Enabled)
      {
        //HPOSF = hide protected operating system files 
        _configClass.ConfSetwindowsExplorerSettings.HideProtectedOSFiles = cbWesHPOSF.Checked;

      }
      if (tbWesHPOSF.Visible)
      {
        _configClass.ConfSetwindowsExplorerSettings.AddNoDefaultSettingsToList = new NoDefaultSettingsLog("hide protected operating system files ", tbWesHPOSF.Text);
      }
      if (cbWesREFS.Enabled)
      {
        //REFS = Remember each folder view settings 
        _configClass.ConfSetwindowsExplorerSettings.RememberEachFoldersViewSetting = cbWesREFS.Checked;

      }
      if (tbWesREFS.Visible)
      {
        _configClass.ConfSetwindowsExplorerSettings.AddNoDefaultSettingsToList = new NoDefaultSettingsLog("Remember each folder view settings ", tbWesREFS.Text);
      }
      if (cbWesSECFC.Enabled)
      {
        //SECFC = show encrypted or compressed NTFS files in color
        _configClass.ConfSetwindowsExplorerSettings.ShowNTFSFilesInColor = cbWesSECFC.Checked;
      }
      if (tbWesSECFC.Visible)
      {
        _configClass.ConfSetwindowsExplorerSettings.AddNoDefaultSettingsToList = new NoDefaultSettingsLog("show encrypted or compressed NTFS files in color", tbWesSECFC.Text);
      }

      #endregion Windows explorer settings

      #region Autologon
      SelectedAutologonUserChanged();
      #endregion Autologon
      btWindowsCurrent.Visible = false;
      btWindowsRecommend.Visible = false;

    }
    private void wpAutoLogonAndEventTracker_NextButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      errorProvider.Clear();
      Trace.WriteInformation("()", "wpAutoLogonAndEventTracker", CLASSNAME);
      foreach (TextBox tb in NotDefaultChoisesLogonShutdownRemoteDesktop)
      {
        if (tb.Visible && tb.Text.Length == 0)
        {
          errorProvider.SetError(tb, "Field can not be empty");
          e.Cancel = true;
        }
      }

      #region AutoLogon settings
      if (cbAutoLogon.Checked && _autoLogonPasswordisValid)
      {
        if (tbAutoLogonPasword.Text.Length != 0 && combAutoLogonUser.Text.Length != 0)
        {
          _configClass.ConfSetLoginShutdownSettings.AutologonInUse = true;
          _configClass.ConfSetLoginShutdownSettings.UsernameAutoLogon = combAutoLogonUser.Text;
          if (cbSavePasswordInLogFile.Checked)
          {
            _configClass.ConfSetLoginShutdownSettings.PasswordAutoLogon = tbAutoLogonPasword.Text;
          }
          else
          {
            _encryptionPassword.AddKey("AutoLogon", tbAutoLogonPasword.Text);
            _configClass.ConfSetLoginShutdownSettings.PasswordAutoLogon = "PassWordIsEncrypted";
          }
        }
        else
        {
          if (combAutoLogonUser.Text.Length == 0)
          {
            errorProvider.SetError(combAutoLogonUser, "Field can not be empty");
          }
          if (tbAutoLogonPasword.Text.Length != 0)
          {
            errorProvider.SetError(tbAutoLogonPasword, "Field can not be empty");
          }

          e.Cancel = true;
        }
      }
      else
      {
        if (!cbAutoLogon.Checked)
        {
          _configClass.ConfSetLoginShutdownSettings.AutologonInUse = false;
        }
        else
        {
          errorProvider.SetError(tbAutoLogonPasword, "The completed password for automatic login is not correct");
          e.Cancel = true;
        }
      }
      if (tbAutoLogonNotDefault.Visible)
      {
        _configClass.ConfSetLoginShutdownSettings.AddNoDefaultSettingsToList = new NoDefaultSettingsLog("AutoLogon", tbAutoLogonNotDefault.Text);
      }
      #endregion AutoLogon settings
      #region Shutdown event tracker
      if (combShutDEventTracker.Text == "On")
      {
        _configClass.ConfSetLoginShutdownSettings.ShutDownEventTrackerInUse = true;
      }
      else if (combShutDEventTracker.Text == "Off ")
      {
        _configClass.ConfSetLoginShutdownSettings.ShutDownEventTrackerInUse = false;
      }
      if (tbShutDownEventTrackerNotDefault.Visible)
      {
        _configClass.ConfSetLoginShutdownSettings.AddNoDefaultSettingsToList = new NoDefaultSettingsLog("shutDownEventTracker", tbShutDownEventTrackerNotDefault.Text);
      }

      #endregion Shutdown event tracker
      #region Remote Desktop

      if (rbRemoteDesktopOff.Checked)
      {
        _configClass.ConfSetRemotedesktop.RemoteDesktopDisabled = true;
        _configClass.ConfSetRemotedesktop.RemoteDesktopEnabledForAllPCs = false;
        _configClass.ConfSetRemotedesktop.RemoteDesktopEnabledOnlyForPCsWithNLA = false;
        cbFwRemoteDesktop.Checked = false;
        cbFwRemoteDesktop.Enabled = true;
      }
      else
      {
        cbFwRemoteDesktop.Checked = true;
        //cbFwRemoteDesktop.Enabled = false;
      }
      if (rbRemoteDesktopOnLessSecure.Checked)
      {
        _configClass.ConfSetRemotedesktop.RemoteDesktopDisabled = false;
        _configClass.ConfSetRemotedesktop.RemoteDesktopEnabledForAllPCs = true;
        _configClass.ConfSetRemotedesktop.RemoteDesktopEnabledOnlyForPCsWithNLA = false;
      }
      if (rbRemoteDesktopOnMoreSecure.Checked)
      {
        _configClass.ConfSetRemotedesktop.RemoteDesktopDisabled = false;
        _configClass.ConfSetRemotedesktop.RemoteDesktopEnabledForAllPCs = true;
        _configClass.ConfSetRemotedesktop.RemoteDesktopEnabledOnlyForPCsWithNLA = true;
      }

      if (!rbRemoteDesktopOff.Checked)
      {
        List<RemoteDesktopUser> remotedesktopUsers = new List<RemoteDesktopUser>();
        List<RemoteDesktopGroup> remotedesktopGroups = new List<RemoteDesktopGroup>();
        if (listbRemoteDesktopUsers.Items.Count != 0)
        {
          foreach (string listboxItem in listbRemoteDesktopUsers.Items)
          {
            foreach (string strGroup in globalGroupMembers)
            {
              if (strGroup == listboxItem)
              {
                RemoteDesktopGroup rdg = new RemoteDesktopGroup(listboxItem);
                remotedesktopGroups.Add(rdg);
                break;
              }
            }
            foreach (string strUser in localUserMembers)
            {
              if (strUser == listboxItem)
              {
                RemoteDesktopUser rdu = new RemoteDesktopUser(listboxItem);
                remotedesktopUsers.Add(rdu);
                break;
              }

            }
          }

        }
        _configClass.ConfSetRemotedesktop.RemoteDesktopGroups = remotedesktopGroups;
        _configClass.ConfSetRemotedesktop.RemoteDesktopUsers = remotedesktopUsers;
      }
      if (tbRemoteDesktopNotDefault.Visible)
      {
        _configClass.ConfSetRemotedesktop.AddNoDefaultSettingsToList = new NoDefaultSettingsLog("RemoteDesktop", tbRemoteDesktopNotDefault.Text);
      }

      #endregion Remote Desktop
      #region init wpFirewall
      if (!_configClass.ConfInstalledSoftware.IsApplicationInstalled("Symantec pcAnywhere"))
      {
        cbFwPcAnywhere.Enabled = false;
      }
      if (!_configClass.ConfInstalledSoftware.IsApplicationInstalled("IIS"))
      {
        cbFwFtpServer.Enabled = false;
        cbFwWebServerHTTP.Enabled = false;
        cbFwWebServerHTTPs.Enabled = false;
      }
      if (!_configClass.ConfInstalledSoftware.IsApplicationInstalled("Microsoft SQL Server"))
      {
        cbFwSqlServer.Enabled = false;
      }

      RemeberDefaultsFirewall();
      CheckFireWallDefaults();
      #endregion init wpFirewall

    }
    private void wpSQLConfig_NextButtonClick(object sender, CancelEventArgs e)
    {
      _scriptHandling.ShowAllWebStatus();
      _scriptHandling.ShowCurrentIPSetting();
      foreach (string ipInfoString in _scriptHandling.ShowAllCurrentIPSettings)
      {
        listBCurrentIPSettings.Items.Add(ipInfoString);
      }
      _configClass.ConfigureSetNetwork.GetAllNic();
      foreach (string NicString in _configClass.ConfigureSetNetwork.CaptionList)
      {
        cbNicAdapter.Items.Add(NicString);
      }
      _scriptHandling.startIISServiceIfStopped();

    }

    private void wpIIS_NextButtonClick(object sender, CancelEventArgs e)
    {

      Trace.WriteInformation("()", "wpIIS_NextButtonClick", CLASSNAME);
      TextBox tb = tbIISNotDefault;
      if (tb.Visible && tb.Text.Length == 0)
      {
        errorProvider.SetError(tb, "Not all required fields are filled");
        e.Cancel = true;
      }


    }
    /// <summary>
    /// Get or set AddFirewallExceptions
    /// </summary>
    public List<FireWallException> AddFirewallExceptions
    {
      get { return _addFirewallExceptions; }
      set { _addFirewallExceptions = value; }
    }private List<FireWallException> _addFirewallExceptions = new List<FireWallException>();

    /// <summary>
    /// Get or set DeleteFirewallExceptions
    /// </summary>
    public List<FireWallException> DeleteFirewallExceptions
    {
      get { return _deleteFirewallExceptions; }
      set { _deleteFirewallExceptions = value; }
    }private List<FireWallException> _deleteFirewallExceptions = new List<FireWallException>();

    private void wpFireWall_NextButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      Trace.WriteInformation("()", "wpFireWall_NextButtonClick", CLASSNAME);
      if (tbFirewallNotDefault.Visible && tbFirewallNotDefault.Text.Length == 0)
      {
        MessageBox.Show("Not all required fields are completed", "Check the required fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
        e.Cancel = true;
      }
      else
      {
        #region Windows XP

        if (os == OSVersions.WindowsXP || os == OSVersions.WindowsXP32 || os == OSVersions.WindowsXP64)
        {
          if (cbFireWallOnOff.Checked)
          {
            _configClass.ConfSetWindowsFirewall.FireWallOn = true;

            _finalListOfExceptions.Clear();
            foreach (string itemsFinal in libFireWallExceptions.Items)
            {
              _finalListOfExceptions.Add(itemsFinal);
            }

            if (_finalListOfExceptions.Count != 0)
            {
              foreach (string newItem in FinalListOfExceptions)
              {
                #region Wouter's codes

                //    if (_scriptHandling.GetAllCurrentFirewallExceptions.Find(tempException => tempException == newItem) == null
                //        && _scriptHandling.ListOfAllowedPrograms.Find(tempException => tempException == newItem) == null)
                //    {
                //      FireWallException exception = new FireWallException(newItem);
                //      _addFirewallExceptions.Add(exception);
                //    }
                //  }

                //  foreach (string currentItem in _scriptHandling.GetAllCurrentFirewallExceptions)
                //  {
                //    if (FinalListOfExceptions.Find(tempException => tempException == currentItem) == null
                //        && _scriptHandling.ListOfAllowedPrograms.Find(tempException => tempException == currentItem) == null)
                //    {
                //      FireWallException deleteException = new FireWallException(currentItem);
                //      _deleteFirewallExceptions.Add(deleteException);
                //    }
                //  }

                //  foreach (string currentItem in FinalListOfExceptions)
                //  {
                //    FireWallException exception = new FireWallException(currentItem);
                //    _allFirewallExceptions.Add(exception);

                //  }
                //}

                //_configClass.ConfSetWindowsFirewall.AddFireWallExceptions = _addFirewallExceptions;
                //_configClass.ConfSetWindowsFirewall.DeleteFireWallExceptions = _deleteFirewallExceptions;
                //_configClass.ConfSetWindowsFirewall.FireWallExceptions = _allFirewallExceptions;
                #endregion Wouter's codes
                if (!ListOfAllFirewallExceptions.Contains(newItem))
                {
                  FireWallException addException = new FireWallException(newItem);
                  _addFirewallExceptions.Add(addException);
                }

              }
              foreach (string oldItem in _listOfAllFirewallExceptions)
              {

                if (!FinalListOfExceptions.Contains(oldItem))
                {
                  FireWallException deleteException = new FireWallException(oldItem);
                  _deleteFirewallExceptions.Add(deleteException);
                }

              }
              _configClass.ConfSetWindowsFirewall.AddFireWallExceptions = _addFirewallExceptions;
              _configClass.ConfSetWindowsFirewall.DeleteFireWallExceptions = _deleteFirewallExceptions;
            }

            else
            {
              _configClass.ConfSetWindowsFirewall.FireWallOn = false;
            }
            if (tbFirewallNotDefault.Visible)
            {
              _configClass.ConfSetWindowsFirewall.AddNoDefaultSettingsToList = new NoDefaultSettingsLog("WindowsFireWall", tbFirewallNotDefault.Text);
            }

            if (_configClass.ConfInstalledSoftware.MBSA)
            {
              bgwCheckMBSApath.RunWorkerAsync();
            }
            else
            {

              _fh.CreateFile(_fh.FilePath.ToString());
              XMLhandler.WriteConfigToFile("ConfigOverview", _fh.FilePath, LogFileFolder, _configClass);
              Uri uri = new Uri(_fh.FilePath);
              webBrowser1.Url = uri;
              pbConfigCheck19.Image = checkImages.Images[5];
              wizard1.SelectedPageIndex = 11;
            }
          }
        }
        #endregion Windows XP
        #region windows with version higher than XP
        else
        {

          foreach (string exceptInOutboundStr in libFireWallExceptions.Items)
          { _finalListOfExceptions.Add(exceptInOutboundStr); }

          if (_finalListOfExceptions.Count != 0)
          {
            foreach (string newItem in FinalListOfExceptions)
            {
              if (!ListOfAllFirewallExceptions.Contains(newItem))
              {
                if (!ListOfModifiedNewFirewallRules.Contains(newItem))
                {
                  FireWallException addException = new FireWallException(newItem);
                  _addFirewallExceptions.Add(addException);
                }
              }

            }
            foreach (string oldItem in _listOfAllFirewallExceptions)
            {

              if (!FinalListOfExceptions.Contains(oldItem))
              {
                if (!ListOfModifiedOldFirewallRule.Contains(oldItem))
                {
                  FireWallException deleteException = new FireWallException(oldItem);
                  _deleteFirewallExceptions.Add(deleteException);
                }
              }

            }
            _configClass.ConfSetWindowsFirewall.AddFireWallExceptions = _addFirewallExceptions;
            _configClass.ConfSetWindowsFirewall.DeleteFireWallExceptions = _deleteFirewallExceptions;
          }
        #endregion windows with version higher than XP

          else
          {
            _configClass.ConfSetWindowsFirewall.FireWallOn = false;
          }
          if (tbFirewallNotDefault.Visible)
          {
            _configClass.ConfSetWindowsFirewall.AddNoDefaultSettingsToList = new NoDefaultSettingsLog("WindowsFireWall", tbFirewallNotDefault.Text);
          }

          if (_configClass.ConfInstalledSoftware.MBSA)
          {
            bgwCheckMBSApath.RunWorkerAsync();
          }
          else
          {

            _fh.CreateFile(_fh.FilePath.ToString());
            XMLhandler.WriteConfigToFile("ConfigOverview", _fh.FilePath, LogFileFolder, _configClass);
            Uri uri = new Uri(_fh.FilePath);
            webBrowser1.Url = uri;
            pbConfigCheck19.Image = checkImages.Images[5];
            wizard1.SelectedPageIndex = 11;
          }
        }


      }
    }

    private void wpMBSA_NextButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      _configClass.ConfSetMicrosoftBaslineSecurityAnalyzer.MBSAchecked = cbMBSA.Checked;
      if (!cbMBSA.Checked || !_configClass.ConfInstalledSoftware.IsApplicationInstalled("Microsoft Baseline Security Analyzer"))
      {
        pbConfigCheck19.Image = checkImages.Images[5];
      }
      Trace.WriteInformation("()", "wpMBSA_NextButtonClick", CLASSNAME);
      if (tbMBSAnotDefault.Visible && tbMBSAnotDefault.Text.Length == 0)
      {
        MessageBox.Show("Not all required fields are completed", "Check the required fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
        e.Cancel = true;
      }
      else
      {
        if (cbMBSA.Checked && wpMBSA.Enabled)
        {
          _configClass.ConfSetMicrosoftBaslineSecurityAnalyzer.RunMBSA = true;
          _configClass.ConfSetMicrosoftBaslineSecurityAnalyzer.PathMBSA = lbMBSAinstallationFolder.Text;
        }
        else if (!cbMBSA.Checked && wpMBSA.Enabled)
        {
          _configClass.ConfSetMicrosoftBaslineSecurityAnalyzer.RunMBSA = false;
        }

        if (tbMBSAnotDefault.Visible)
        {
          _configClass.ConfSetMicrosoftBaslineSecurityAnalyzer.AddNoDefaultSettingsToList = new NoDefaultSettingsLog("MicrosoftBaslineSecurityAnalyzer", tbMBSAnotDefault.Text);
        }
        _fh.CreateFile(_fh.FilePath.ToString());
        XMLhandler.WriteConfigToFile("ConfigOverview", _fh.FilePath, LogFileFolder, _configClass);
        Uri uri = new Uri(_fh.FilePath);
        webBrowser1.Url = uri;
        wizard1.NextButtonText = "Complete";
      }

    }
    private void wpAcceptSettings_NextButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      Trace.WriteInformation("()", "wpAcceptSettings_NextButtonClick", CLASSNAME);
      wpConfigurationCheck.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
      wpConfigurationCheck.BackButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
      wpConfigurationCheck.CancelButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
      _configClass = XMLhandler.ReadConfigFromFile(_fh.FilePath);

      backgroundWorker1.RunWorkerAsync();
    }
    private void wpConfigurationCheck_NextButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      
    }
    private void wpConfigErrorOverview_NextButtonClick(object sender, CancelEventArgs e)
    {
      //word afgehandeld in wizard1_WizardPageChanging
      _configClass.ErrorOverviewComment = tbErrorOverviewComment.Text;
    }
    private void wpMBSAlogOverview_NextButtonClick(object sender, CancelEventArgs e)
    {
      _configClass.ConfSetMicrosoftBaslineSecurityAnalyzer.MBSAoverviewComment = tbMBSAcomments.Text;
      Trace.WriteInformation("()", "wpMBSAlogOverview_NextButtonClick", CLASSNAME);
    }

    const string PCANYWHERE_STRING = "PcAnywhere";
    const string REMOTEDESKTOP_STRING = "Remote Desktop TCP 3389";
    const string FTPSERVER_STRING = "FTPServer TCP 21";
    const string WEB_SERVER_HTTP_STRING = "Web Server http TCP 80";
    const string WEB_SERVER_HTTPS_STRING = "Web Server https TCP 443";
    const string SQLSERVER_STRING = "SQL Server TCP 1433";

    private void RefreshSharedFolderWizardPage()
    {
      listVSharedFolders.Items.Clear();
      _scriptHandling.GetAllSharedFolders();
      foreach (string strShare in _scriptHandling.ListOfAllSharedFolders)
      {
        string name = "";
        string secondpart = "";
        string path = "";
        string description = "";
        int indexOfSplit = strShare.IndexOf("Path:");
        int indexOfDesc = strShare.IndexOf("Description:");
        if (strShare.Contains("IPC$ Description: Remote IPC"))
        {
          int indexForSplit = strShare.IndexOf("Description:");
          name = strShare.Substring(0, indexForSplit - 1).Trim();
          description = strShare.Substring(indexForSplit, strShare.Length - indexForSplit);

        }
        else
        {
          name = strShare.Substring(0, indexOfSplit - 1).Trim();
          description = strShare.Substring(indexOfDesc, strShare.Length - indexOfDesc);
          secondpart = strShare.Substring(indexOfSplit, strShare.Length - indexOfSplit - description.Length);
          int indexPath = secondpart.IndexOf("Path:");
          path = secondpart.Substring(indexPath + 6, secondpart.Length - (indexPath + 6));
          int indexDes = description.IndexOf(":");
          description = description.Substring(indexDes + 2, description.Length - (indexDes + 2));

        }

        ListViewItem lvi = new ListViewItem(new[] { name, path, description });
        listVSharedFolders.Items.Add(lvi);
      }
    }
    private void RefreshRemoteDesktopWizardPage()
    {
      listbRemoteDesktopUsers.Items.Clear();
      foreach (string rdpGroupOrUserName in _scriptHandling.ListOfUsersInRDU)
      {
        string temp = rdpGroupOrUserName.Replace("\r", string.Empty);
        listbRemoteDesktopUsers.Items.Add(temp);
      }
      foreach (NewUser newUser in _configClass.ConfSetWindowsUsers.NewUsers)
      {
        foreach (string groupString in newUser.UserGroupList)
        {

          if (groupString == "Remote Desktop Users")
            listbRemoteDesktopUsers.Items.Add(newUser.Name);
        }
      }
      foreach (DeletedUser deleteUser in _configClass.ConfSetWindowsUsers.DeletedUsers)
      { 
        listbRemoteDesktopUsers.Items.Remove(deleteUser.Name);        
      }
    }
    #region Get all current exceptions XP

    private void GetAllCurrentOpeningPorts()
    {

      _scriptHandling.putCurrentFireWallExceptionsToList();
      List<string> ListOfCurrentExceptions = new List<string>();
      ListOfCurrentExceptions = _scriptHandling.GetAllCurrentFirewallExceptions;
      foreach (string str in ListOfCurrentExceptions)
      {
        libFireWallExceptions.Items.Add(str);
        _listOfAllFirewallExceptions.Add(str);
      }
    }
    private void GetAllCurrentAllowedPrograms()
    {
      _scriptHandling.putCurrentFireWallProgramsExceptionsToList();
      foreach (string stringProgram in _scriptHandling.ListOfAllowedPrograms)
      {
        libFireWallExceptions.Items.Add(stringProgram);
        _listOfAllFirewallExceptions.Add(stringProgram);
      }
    }
    #endregion Get all current exception XP
    #region Get Firewall rules Inbound & Outbound for windows other than XP
    private void GetAllCurrentFirewallRuleInOut()
    {
      _scriptHandling.GetAllCurrentFireWallExceptionsWinServer();
      foreach (string str in _scriptHandling.AllCurrentFwExceptionsRuleInOut)
      {
        libFireWallExceptions.Items.Add(str);
        _listOfAllFirewallExceptions.Add(str);
      }
    }

    #endregion Get Firewall rules Inbound & Outbound for windows other than XP
    private void RefreshFirewallWizardPage()
    {
      //this will get all the current opening ports of windows firewall
      //ready to show at Firewall Wizard page
      if (os == OSVersions.WindowsXP32 || os == OSVersions.WindowsXP || os == OSVersions.WindowsXP64)
      {
        libFireWallExceptions.Items.Clear();
        GetAllCurrentAllowedPrograms();
        GetAllCurrentOpeningPorts();
        RemeberDefaultsFirewall();
        //check if the list already had the following exceptions
        //if had then set the checkbox to true

        cbFwPcAnywhere.Checked = false;
        cbFwRemoteDesktop.Checked = false;
        cbFwFtpServer.Checked = false;
        cbFwWebServerHTTP.Checked = false;
        cbFwWebServerHTTPs.Checked = false;
        cbFwSqlServer.Checked = false;


        foreach (string localFirewallException in _scriptHandling.GetAllCurrentFirewallExceptions)
        {
          if (localFirewallException.Contains(PCANYWHERE_STRING))
            cbFwPcAnywhere.Checked = true;
          if (localFirewallException.Contains(REMOTEDESKTOP_STRING))
            cbFwRemoteDesktop.Checked = true;
          if (localFirewallException.Contains(FTPSERVER_STRING))
            cbFwFtpServer.Checked = true;
          if (localFirewallException.Contains(WEB_SERVER_HTTP_STRING))
            cbFwWebServerHTTP.Checked = true;
          if (localFirewallException.Contains(WEB_SERVER_HTTPS_STRING))
            cbFwWebServerHTTPs.Checked = true;
          if (localFirewallException.Contains(SQLSERVER_STRING))
            cbFwSqlServer.Checked = true;
        }
        foreach (FireWallException exceptionAdded in _configClass.ConfSetWindowsFirewall.AddFireWallExceptions)
        {
          libFireWallExceptions.Items.Add(exceptionAdded.ExceptionName);
        }
        foreach (FireWallException exceptionDeleted in _configClass.ConfSetWindowsFirewall.DeleteFireWallExceptions)
        {
          libFireWallExceptions.Items.Remove(exceptionDeleted.ExceptionName);
        }
      }
      else
      {
        libFireWallExceptions.Items.Clear();
        GetAllCurrentFirewallRuleInOut();
        foreach (string localFirewallException in libFireWallExceptions.Items)
        {
          if (localFirewallException.Contains(PCANYWHERE_STRING))
            cbFwPcAnywhere.Checked = true;
          if (localFirewallException.Contains(REMOTEDESKTOP_STRING))
            cbFwRemoteDesktop.Checked = true;
          if (localFirewallException.Contains(FTPSERVER_STRING))
            cbFwFtpServer.Checked = true;
          if (localFirewallException.Contains(WEB_SERVER_HTTP_STRING))
            cbFwWebServerHTTP.Checked = true;
          if (localFirewallException.Contains(WEB_SERVER_HTTPS_STRING))
            cbFwWebServerHTTPs.Checked = true;
          if (localFirewallException.Contains(SQLSERVER_STRING))
            cbFwSqlServer.Checked = true;

        }
        foreach (FireWallException exceptionAdded in _configClass.ConfSetWindowsFirewall.AddFireWallExceptions)
        {
          libFireWallExceptions.Items.Add(exceptionAdded.ExceptionName);
        }
        foreach (FireWallException exceptionDeleted in _configClass.ConfSetWindowsFirewall.DeleteFireWallExceptions)
        {
          libFireWallExceptions.Items.Remove(exceptionDeleted.ExceptionName);
        }
      }
    }

    /// <summary>
    /// Check if the wizardPageMode of the currentPage is allowed
    /// </summary>
    /// <param name="currentPage"></param>
    /// <returns>If allowed return true, else false</returns>
    private bool AllowedToDisplayPage(BaseWiSSWizardPage currentPage)
    {
      const string FUNCTIONNAME = "AllowedToDisplayPage";
      try
      {
        Trace.WriteVerbose("(currentPage: {0})", FUNCTIONNAME, CLASSNAME, currentPage);

        switch (CurrentWissWizardMode)
        {
          case WiSSWizardMode.All:
            return true;
          case WiSSWizardMode.Lockdown:
            if (currentPage.PageWiSSWizardMode == WiSSWizardMode.Lockdown
              || currentPage.PageWiSSWizardMode == WiSSWizardMode.SecurityAndLockdown
              || currentPage.PageWiSSWizardMode == WiSSWizardMode.All)
              return true;
            else
              return false;

          case WiSSWizardMode.Security:
            if (currentPage.PageWiSSWizardMode == WiSSWizardMode.Security
              || currentPage.PageWiSSWizardMode == WiSSWizardMode.SecurityAndLockdown
              || currentPage.PageWiSSWizardMode == WiSSWizardMode.All)
              return true;
            else
              return false;
          case WiSSWizardMode.Template:
            if (currentPage.PageWiSSWizardMode == WiSSWizardMode.Template
              || currentPage.PageWiSSWizardMode == WiSSWizardMode.All)
              return true;
            else
              return false;
        }
        return false;
      }
      catch (Exception ex)
      {
        Trace.WriteError("(currentPage: {0})", FUNCTIONNAME, CLASSNAME, ex, currentPage);
        throw;
      }
    }

    /// <summary>
    /// if pages aren't not allowed to be displayed, skip these pages
    /// </summary>
    /// <param name="currentIndex">index of the current page</param>
    /// <param name="pageChangeSource">direction</param>
    /// <returns>a page that is allowed to be displayed</returns>
    private BaseWiSSWizardPage SkipPagesForwardOrBackward(int currentIndex, DevComponents.DotNetBar.eWizardPageChangeSource pageChangeSource)
    {
      const string FUNCTIONNAME = "SkipPagesForwardOrBackward";
      try
      {
        Trace.WriteVerbose("(currentIndex: {0}, pageChangeSource: {1})", FUNCTIONNAME, CLASSNAME, currentIndex, pageChangeSource);

        if (pageChangeSource == DevComponents.DotNetBar.eWizardPageChangeSource.NextButton)
          currentIndex++;
        else if (pageChangeSource == DevComponents.DotNetBar.eWizardPageChangeSource.BackButton)
          currentIndex--;
        //else
        //  throw new Exception("Page change not allowed");

        BaseWiSSWizardPage toSelectPage = (BaseWiSSWizardPage)wizard1.WizardPages[currentIndex];

        bool allowed = AllowedToDisplayPage(toSelectPage);
        bool installed = IsSoftwareInstalledOfWizardPage(toSelectPage);
        if (allowed && installed)
          return toSelectPage;
        else
          return SkipPagesForwardOrBackward(currentIndex, pageChangeSource);
      }
      catch (Exception ex)
      {
        Trace.WriteError("(currentIndex: {0}, pageChangeSource: {1})", FUNCTIONNAME, CLASSNAME, ex, currentIndex, pageChangeSource);
        throw;
      }
    }

    /// <summary>
    /// Check if the third party softwares are installed or not 
    /// </summary>
    /// <param name="currentWizardPage">the current page</param>
    /// <returns>if installed return true, else false</returns>
    private bool IsSoftwareInstalledOfWizardPage(BaseWiSSWizardPage currentWizardPage)
    {
      const string FUNCTIONNAME = "IsSoftwareInstalledOfWizardPage";
      try
      {
        Trace.WriteVerbose("(currentWizardPage: {0})", FUNCTIONNAME, CLASSNAME, currentWizardPage);

        // If currenWizardPage is not for a third party software it is a part of Windows return true
        if (currentWizardPage != wpPCAnywhere
          && currentWizardPage != wpIIS
          && currentWizardPage != wpSQLConfig
          && currentWizardPage != wpBlockKey
          && currentWizardPage != wpMBSA)
          return true;

        // If currentWizardPage for a third party software check if its installed
        if ((currentWizardPage == wpPCAnywhere && _configClass.ConfInstalledSoftware.PcAnywhere == true)
          || (currentWizardPage == wpIIS && _configClass.ConfInstalledSoftware.IIS == true && os != OSVersions.WindowsXP32)
          || (currentWizardPage == wpSQLConfig && _configClass.ConfInstalledSoftware.SQLServer == true)
          || (currentWizardPage == wpBlockKey && _configClass.ConfInstalledSoftware.BlockKeys == true)
          || (currentWizardPage == wpMBSA && _configClass.ConfInstalledSoftware.MBSA == true))
        {
          return true;
        }
        else
        {
          return false;
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("(currentWizardPage: {0})", FUNCTIONNAME, CLASSNAME, ex, currentWizardPage);
        throw;
      }
    }

    /// <summary>
    /// event that happen everytime page changing
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void wizard1_WizardPageChanging(object sender, DevComponents.DotNetBar.WizardCancelPageChangeEventArgs e)
    {
      const string FUNCTIONNAME = "wizard1_WizardPageChanging";
      try
      {
        Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);

        e.NewPage = SkipPagesForwardOrBackward(wizard1.SelectedPageIndex, e.PageChangeSource);

        #region Installed Software
        if (e.NewPage == wpInstalledApllications)
        {
          if (os == OSVersions.WindowsXP || os == OSVersions.WindowsXP32 || os == OSVersions.WindowsXP64)
          {
            lbNoteListOfInstalledSoftware.Visible = true;
            lbNoteExlaintListOfInstalledSoftware.Visible = true;
          }
          else
          {
            lbNoteListOfInstalledSoftware.Visible = false;
            lbNoteExlaintListOfInstalledSoftware.Visible = false;
          }
        }
        #endregion Installed Software
        #region PasswordPolicies
        if (e.NewPage == wpPasswordPolicy)
          GetAllCurrentPasswordPolicies();
        #endregion PasswordPolicies
        #region AuditPolicies
        if (e.NewPage == wpControlPolicy)
        {
          btGetAllCurrentAuditPolicies.Visible = true;
          GetAllCurrentAuditPolicies();
        }
        else
          btGetAllCurrentAuditPolicies.Visible = false;
        
        #endregion AuditPolicies
        #region wpConfigurationCheck
        if (e.OldPage == wpConfigurationCheck && e.PageChangeSource == DevComponents.DotNetBar.eWizardPageChangeSource.NextButton)
        {

          if (_configClass.ErrorList.Count != 0)
          {
            ErrorOverview();
            e.NewPage = wpConfigErrorOverview;
          }
          else
          {
            string mbsaLog = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\MBSAlog.txt";
            if (File.Exists(mbsaLog))
            {
              MBSAOverview();
              e.NewPage = wpMBSAlogOverview;
            }
            else
            {
              e.NewPage = wpFinish;
            }
          }
        }
        #endregion wpConfigurationCheck
        #region Remote Desktop
        if (e.NewPage == wpAutoLogonAndEventTracker)
          RefreshRemoteDesktopWizardPage();
        #endregion Remote Desktop
        #region Firewall
        if (e.NewPage == wpFireWall)
        {
          RefreshFirewallWizardPage();
        }

        #endregion Firewall
        #region SharedFolder
        if (e.NewPage == wpSharedFolderConfig)
        {          
          RefreshSharedFolderWizardPage();
        }          
        #endregion SharedFolder
        #region IP Settings
        if (e.NewPage == wpNetworkConfigure)
          RefreshlistBCurrentIPSettings();
        #endregion IP Settings
        #region wpConfigErrorOverview
        if (e.OldPage == wpConfigErrorOverview && e.PageChangeSource == DevComponents.DotNetBar.eWizardPageChangeSource.NextButton)
        {
          if (_configClass.ConfSetMicrosoftBaslineSecurityAnalyzer.MBSAstate == true)
          {
            MBSAOverview();
            e.NewPage = wpMBSAlogOverview;
          }
          else
          {
            e.NewPage = wpFinish;
          }
        }
        #endregion wpConfigErrorOverview
        #region wpFinish
        if (e.NewPage == wpFinish)
        {
          if (File.Exists(_fh.FilePath))
          {
            File.Delete(_fh.FilePath);
          }
          _fh.CreateFile(_fh.FilePath.ToString());
          XMLhandler.WriteConfigToFile("TotalOverview", _fh.FilePath, LogFileFolder, _configClass);
        }
        #endregion wpFinish
      }
      catch (Exception ex)
      {

        Trace.WriteError("()", FUNCTIONNAME, CLASSNAME, ex);
        MessageBox.Show(ex.Message);
      }


    }

    #endregion wizardpages next button clicks
    private void btGetCurrentPasswordPolicies_Click(object sender, EventArgs e)
    {
      GetAllCurrentPasswordPolicies();
    }
    #region Audit Policy
    public void AddNoDefaultToLog(ComboBox cb, TextBox tb, string setting)
    {
      if (tb.Visible)
      {
        foreach (NoDefaultSettingsLog log in _configClass.ConfSetAuditPolicy.NoDefaultSettingsLog)
        {
          if (log.Setting == setting)
          {
            _configClass.ConfSetAuditPolicy.NoDefaultSettingsLog.Remove(log);
            break;
          }
        }
        _configClass.ConfSetAuditPolicy.AddNoDefaultSettingsToList = new NoDefaultSettingsLog(setting, tb.Text);

      }
    }
    private void btGetAllCurrentAuditPolicies_Click(object sender, EventArgs e)
    {
      GetAllCurrentAuditPolicies();
    }
    #endregion Audit Policy

    #region addUsergroups
    private void btAddUserGroup_Click(object sender, EventArgs e)
    {
      string usergroupName = tbAddUserGroupName.Text;
      string usergroupDescription = tbAddUserGroupDescription.Text;
      bool groupNotExist = true;
      bool groupIsNotInNewList = true;
      errorProvider.Clear();

      #region Check if there is not a group with this name
      if (_configClass.ConfSetWindowsUsergroup.CheckIfUserGroupExist(usergroupName, _configClass))
      {
        groupNotExist = false;
        foreach (UserGroup deletedGroup in _configClass.ConfSetWindowsUsergroup.DeletedUserGroups)
        {
          if (deletedGroup.Name == usergroupName)
          {
            groupNotExist = true;
            break;
          }
        }
      }
      #endregion Check if there is not a group with this name

      #region Check if group is already in new list
      foreach (UserGroup newGroup in _configClass.ConfSetWindowsUsergroup.NewUserGroups)
      {
        if (newGroup.Name == usergroupName)
        {
          groupIsNotInNewList = false;
          break;
        }
      }

      #endregion Check if group is already in new list

      if (tbAddUserGroupName.Text.Length != 0)
      {
        if (groupNotExist && groupIsNotInNewList)
        {
          if (!_configClass.ConfSetWindowsUsers.CheckIfUserExist(usergroupName, _configClass))
          {
            _configClass.ConfSetWindowsUsergroup.NewUserGroups.Add(new UserGroup(usergroupName, usergroupDescription));
          }
          else
          {
            MessageBox.Show("The user account is already taken \"" + usergroupName + " \"", "Check chosen name.", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
        else
        {
          MessageBox.Show("The user group with that name is taken \"" + usergroupName + " \"", "Check chosen name.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      else
      {
        errorProvider.SetError(tbAddUserGroupName, "The field group name can not be empty");
      }

      tbAddUserGroupName.Text = "";
      tbAddUserGroupDescription.Text = "";
      RefreshListViewUsersGroups();
    }
    private void btDeleteGroup_Click(object sender, EventArgs e)
    {
      try
      {
        bool groupIsNew = false;


        foreach (ListViewItem lviAllgroups in lvUsergroups.Items)
        {
          if (lviAllgroups.Selected)
          {
            #region Check if item to delete is a new one
            foreach (UserGroup newGroup in _configClass.ConfSetWindowsUsergroup.NewUserGroups)
            {
              if (newGroup.Name == lviAllgroups.Text)
              {
                groupIsNew = true;
              }
            }
            #endregion Check if item to delete is a new one

            #region Check if group is "Administrators"
            if (lviAllgroups.Text == "Administrators")
            {
              cbAddgroupAdministrators.Enabled = true;
              cbAddgroupAdministrators.Checked = false;
            }
            #endregion Check if group is "Administrators"

            #region Check if group is "Actemium Engineers"
            if (lviAllgroups.Text == "Actemium Engineers")
            {

              cbAddgroupActemiumEngineers.Enabled = true;
              cbAddgroupActemiumEngineers.Checked = false;
            }
            #endregion Check if group is "Actemium Engineers"

            #region Check if group is "FTP_Users"
            if (lviAllgroups.Text == "FTP_Users")
            {
              cbAddGroupFTP_users.Enabled = true;
              cbAddGroupFTP_users.Checked = false;
            }
            #endregion Check if group is "FTP_Users"

            if (groupIsNew)
            {
              foreach (UserGroup newGroup in _configClass.ConfSetWindowsUsergroup.NewUserGroups)
              {
                if (newGroup.Name == lviAllgroups.Text)
                {
                  _configClass.ConfSetWindowsUsergroup.NewUserGroups.Remove(newGroup);
                  break;
                }
              }
            }
            else
            {
              UserGroup itemToRemove = new UserGroup(lviAllgroups.SubItems[0].Text, lviAllgroups.SubItems[1].Text);
              _configClass.ConfSetWindowsUsergroup.DeletedUserGroups.Add(itemToRemove);
            }

            break;
          }
        }
        RefreshListViewUsersGroups();
      }
      catch (ArgumentOutOfRangeException ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "btDeleteGroup_Click", CLASSNAME, ex);
        lbSelectGroupFirst.Visible = true;
      }
    }
    private void cbAddgroupAdministrators_CheckedChanged(object sender, EventArgs e)
    {
      bool groupIsNew = false;
      string groupName = "Administrators";
      string groupDescription = "Administrators";
      if (cbAddgroupAdministrators.Checked)
      {
        _configClass.ConfSetWindowsUsergroup.NewUserGroups.Add(new UserGroup(groupName, groupDescription));
      }
      else
      {
        #region Check if item to delete is a new one
        foreach (UserGroup newGroup in _configClass.ConfSetWindowsUsergroup.NewUserGroups)
        {
          if (newGroup.Name == groupName)
          {
            groupIsNew = true;
          }
        }
        #endregion Check if item to delete is a new one

        if (groupIsNew)
        {
          foreach (UserGroup group in _configClass.ConfSetWindowsUsergroup.NewUserGroups)
          {
            if (group.Name == groupName)
            {
              _configClass.ConfSetWindowsUsergroup.NewUserGroups.Remove(group);
              break;
            }
          }
        }
        else
        {
          _configClass.ConfSetWindowsUsergroup.DeletedUserGroups.Add(new UserGroup(groupName, groupDescription));
        }
      }
      RefreshListViewUsersGroups();
    }
    private void cbAddgroupActemiumEngineers_CheckedChanged(object sender, EventArgs e)
    {
      bool groupIsNew = false;
      string groupName = "Actemium Engineers";
      string groupDescription = "Actemium Engineers";
      if (cbAddgroupActemiumEngineers.Checked)
      {
        _configClass.ConfSetWindowsUsergroup.NewUserGroups.Add(new UserGroup(groupName, groupDescription));
      }
      else
      {
        #region Check if item to delete is a new one
        foreach (UserGroup newGroup in _configClass.ConfSetWindowsUsergroup.NewUserGroups)
        {
          if (newGroup.Name == groupName)
          {
            groupIsNew = true;
          }
        }
        #endregion Check if item to delete is a new one

        if (groupIsNew)
        {
          foreach (UserGroup group in _configClass.ConfSetWindowsUsergroup.NewUserGroups)
          {
            if (group.Name == groupName)
            {
              _configClass.ConfSetWindowsUsergroup.NewUserGroups.Remove(group);
              break;
            }
          }
        }
        else
        {
          _configClass.ConfSetWindowsUsergroup.DeletedUserGroups.Add(new UserGroup(groupName, groupDescription));
        }
      }
      RefreshListViewUsersGroups();
    }
    private void cbAddGroupFTP_users_CheckedChanged(object sender, EventArgs e)
    {
      bool groupIsNew = false;
      string groupName = "FTP_Users";
      string groupDescription = "FTP_Users";
      if (cbAddGroupFTP_users.Checked)
      {
        _configClass.ConfSetWindowsUsergroup.NewUserGroups.Add(new UserGroup(groupName, groupDescription));
      }
      else
      {
        #region Check if item to delete is a new one
        foreach (UserGroup newGroup in _configClass.ConfSetWindowsUsergroup.NewUserGroups)
        {
          if (newGroup.Name == groupName)
          {
            groupIsNew = true;
          }
        }
        #endregion Check if item to delete is a new one

        if (groupIsNew)
        {
          foreach (UserGroup group in _configClass.ConfSetWindowsUsergroup.NewUserGroups)
          {
            if (group.Name == groupName)
            {
              _configClass.ConfSetWindowsUsergroup.NewUserGroups.Remove(group);
              break;
            }
          }
        }
        else
        {
          _configClass.ConfSetWindowsUsergroup.DeletedUserGroups.Add(new UserGroup(groupName, groupDescription));
        }
      }
      RefreshListViewUsersGroups();
    }

    private void RefreshlistBCurrentIPSettings()
    {
      const string FUNCTIONNAME = "RefreshlistbCurrentIPSettings";
      try
      {
        Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
        listBCurrentIPSettings.Items.Clear();
        _scriptHandling.ShowCurrentIPSetting();
        foreach (string ipInfoString in _scriptHandling.ShowAllCurrentIPSettings)
        {
          listBCurrentIPSettings.Items.Add(ipInfoString);
        }


      }
      catch (Exception ex)
      {
        Trace.WriteError("()", FUNCTIONNAME, CLASSNAME, ex);
        throw;
      }
    }

    private void RefreshListViewUsersGroups()
    {
      List<string> combItems = new List<string>();
      combItems.Clear();

      lvUsergroups.Items.Clear();
      foreach (UserGroup existeduserGroup in _configClass.ConfSetWindowsUsergroup.ExistedUserGroups(_configClass))
      {
        ListViewItem lvi = new ListViewItem(new[] { existeduserGroup.Name, existeduserGroup.Description });
        lvUsergroups.Items.Add(lvi);
        combItems.Add(existeduserGroup.Name);
      }
      foreach (UserGroup deletedUserGroup in _configClass.ConfSetWindowsUsergroup.DeletedUserGroups)
      {
        foreach (ListViewItem user in lvUsergroups.Items)
        {
          if (deletedUserGroup.Name == user.Text)
          {
            lvUsergroups.Items.Remove(user);
            combItems.Remove(deletedUserGroup.Name);
            break;
          }
        }
      }
      foreach (UserGroup newusergroup in _configClass.ConfSetWindowsUsergroup.NewUserGroups)
      {
        ListViewItem lvi = new ListViewItem(new[] { newusergroup.Name, newusergroup.Description });
        lvUsergroups.Items.Add(lvi);
        combItems.Add(newusergroup.Name);
      }

      lvUsergroups.Sorting = System.Windows.Forms.SortOrder.Ascending;
      lvUsergroups.Sort();

      #region fill in CheckCombobox, combRemoteDesktopUsers and chkListBUserGroups with userGroups

      combItems.Sort();

      foreach (string str in combItems)
      {
        chkListBUserGroups.Items.Add(str);
        _localGroupMembers.Add(str);

      }
      _scriptHandling.putAllGlobalGroupsToList();
      foreach (string globalGroupString in _scriptHandling.ListOfGlobalGroup)
      {
        combRemoteDesktopUsers.Items.Add(globalGroupString);
        _globalGroupMembers.Add(globalGroupString);
      }
      #endregion fill in CheckCombobox, combRemoteDesktopUsers and chkListBUserGroups with userGroups
    }
    #endregion addUsergroups

    #region changeDefaultAccounts

    private void cbChangeDefaultAccountsSavePasswordInLogFile_CheckedChanged(object sender, EventArgs e)
    {
      if (cbChangeDefaultAccountsSavePasswordInLogFile.Checked)
      {
        cbSavePasswordInLogFile.Checked = true;
      }
      else
      {
        cbSavePasswordInLogFile.Checked = false;
      }

    }

    private void cbRandomPWChangeDefAccoGuest_CheckedChanged(object sender, EventArgs e)
    {
      int defaultLength = 8;
      if (nudMinPaswordlength.Value > defaultLength)
      {
        defaultLength = (int)nudMinPaswordlength.Value;
      }
      PasswordGenerator pw = new PasswordGenerator();
      string password = pw.GeneratePassword(defaultLength);
      if (cbRandomPWChangeDefAccoGuest.Checked)
      {
        AskSavePasswordInLogfile();
        if (cbSavePasswordInLogFile.Checked)
        {
          SetPasswordFields(true);
        }
        else
        {
          SetPasswordFields(false);
        }

        tbChangePasswDefAccoGuest.Text = password;
        tbChangeConfirmPasswDefAccoGuest.Text = password;
        tbChangePasswDefAccoGuest.Enabled = false;
        tbChangeConfirmPasswDefAccoGuest.Enabled = false;
      }
      else
      {
        tbChangePasswDefAccoGuest.PasswordChar = '*';
        tbChangeConfirmPasswDefAccoGuest.PasswordChar = '*';
        tbChangePasswDefAccoGuest.Text = "";
        tbChangeConfirmPasswDefAccoGuest.Text = "";
        tbChangePasswDefAccoGuest.Enabled = true;
        tbChangeConfirmPasswDefAccoGuest.Enabled = true;
      }
    }

    private void cbRandomPWChangeDefAccoSUPPORT_CheckedChanged(object sender, EventArgs e)
    {
      int defaultLength = 8;
      if (nudMinPaswordlength.Value > defaultLength)
      {
        defaultLength = (int)nudMinPaswordlength.Value;
      }
      PasswordGenerator pw = new PasswordGenerator();
      string password = pw.GeneratePassword(defaultLength);
      if (cbRandomPWChangeDefAccoSUPPORT.Checked)
      {
        AskSavePasswordInLogfile();
        if (cbSavePasswordInLogFile.Checked)
        {
          SetPasswordFields(true);
        }
        else
        {
          SetPasswordFields(false);
        }

        tbChangePasswDefAccoSUPPORT.Text = password;
        tbChangeConfirmPasswDefAccoSUPPORT.Text = password;
        tbChangePasswDefAccoSUPPORT.Enabled = false;
        tbChangeConfirmPasswDefAccoSUPPORT.Enabled = false;
      }
      else
      {
        tbChangePasswDefAccoSUPPORT.PasswordChar = '*';
        tbChangeConfirmPasswDefAccoSUPPORT.PasswordChar = '*';
        tbChangePasswDefAccoSUPPORT.Text = "";
        tbChangeConfirmPasswDefAccoSUPPORT.Text = "";
        tbChangePasswDefAccoSUPPORT.Enabled = true;
        tbChangeConfirmPasswDefAccoSUPPORT.Enabled = true;
      }
    }

    private void cbRandomPWChangeDefAccoAdministrator_CheckedChanged(object sender, EventArgs e)
    {
      int defaultLength = 8;
      if (nudMinPaswordlength.Value > defaultLength)
      {
        defaultLength = (int)nudMinPaswordlength.Value;
      }
      PasswordGenerator pw = new PasswordGenerator();
      string password = pw.GeneratePassword(defaultLength);
      if (cbRandomPWChangeDefAccoAdministrator.Checked)
      {
        AskSavePasswordInLogfile();
        if (cbSavePasswordInLogFile.Checked)
        {
          SetPasswordFields(true);
        }
        else
        {
          SetPasswordFields(false);
        }

        tbChangePasswDefAccoAdministrator.Text = password;
        tbChangeConfirmPasswDefAccoAdministrator.Text = password;
        tbChangePasswDefAccoAdministrator.Enabled = false;
        tbChangeConfirmPasswDefAccoAdministrator.Enabled = false;
      }
      else
      {
        tbChangePasswDefAccoAdministrator.PasswordChar = '*';
        tbChangeConfirmPasswDefAccoAdministrator.PasswordChar = '*';
        tbChangePasswDefAccoAdministrator.Text = "";
        tbChangeConfirmPasswDefAccoAdministrator.Text = "";
        tbChangePasswDefAccoAdministrator.Enabled = true;
        tbChangeConfirmPasswDefAccoAdministrator.Enabled = true;
      }
    }

    #endregion changeDefaultAccounts

    #region addUsers
    private void cbCreateActemiumUser_CheckedChanged(object sender, EventArgs e)
    {
      List<string> usergroupList = new List<string>();
      usergroupList.Add("Actemium Engineers");
      NewUser newActemium = new NewUser("Actemium", "Actemium", "This is an Actemium account", usergroupList, "No", "No", "Yes", "No", "empty");
      if (cbCreateActemiumUser.Checked)
      {
        _configClass.ConfSetWindowsUsers.AddNewUser = newActemium;
        lbPWActemium.Enabled = true;
        lbPWcomfimActemium.Enabled = true;
        tbPWActemium.Enabled = true;
        tbPWcomfimActemium.Enabled = true;
        cbRandomPWActemium.Enabled = true;
      }
      else
      {
        _configClass.ConfSetWindowsUsers.RemoveNewUserFromList(newActemium, _configClass);
        lbPWActemium.Enabled = false;
        lbPWcomfimActemium.Enabled = false;
        tbPWActemium.Enabled = false;
        tbPWcomfimActemium.Enabled = false;
        cbRandomPWActemium.Enabled = false;
        tbPWActemium.Text = "";
        tbPWcomfimActemium.Text = "";
        cbRandomPWActemium.Checked = false;
        cbRandomPWActemium.Enabled = false;
      }
      RefreshListViewUsers();
    }

    private void cbCreateAdminUser_CheckedChanged(object sender, EventArgs e)
    {
      List<string> usergroupList = new List<string>();
      usergroupList.Add("Administrators");
      NewUser newAdmin = new NewUser("Admin", "Admin", "This is an Admin account", usergroupList, "Yes", "No", "No", "No", tbPWAdmin.Text);
      if (cbCreateAdminUser.Checked)
      {
        _configClass.ConfSetWindowsUsers.AddNewUser = newAdmin;
        lbPWAdmin.Enabled = true;
        lbPWcomfimAdmin.Enabled = true;
        tbPWAdmin.Enabled = true;
        tbPWcomfimAdmin.Enabled = true;
        cbRandomPWAdmin.Enabled = true;
      }
      else
      {
        _configClass.ConfSetWindowsUsers.RemoveNewUserFromList(newAdmin, _configClass);
        lbPWAdmin.Enabled = false;
        lbPWcomfimAdmin.Enabled = false;
        tbPWAdmin.Enabled = false;
        tbPWcomfimAdmin.Enabled = false;
        cbRandomPWAdmin.Enabled = false;
        tbPWAdmin.Text = "";
        tbPWcomfimAdmin.Text = "";
        cbRandomPWAdmin.Checked = false;
        cbRandomPWAdmin.Enabled = false;
      }
      RefreshListViewUsers();
    }
    private void btAddUser_Click(object sender, EventArgs e)
    {
      CheckUserCanBeAdded();
    }
    public void CheckUserCanBeAdded()
    {
      string userName = tbAddUserUserName.Text.TrimEnd(new char[] { ' ' });
      string fullName = tbAddUserFullName.Text;
      string description = tbAddUserDescription.Text;
      string password = tbAddUserPasword1.Text;
      string passwordConfirm = tbAddUserPasword2.Text;

      bool nameContainsinNewUser = false;
      bool nameContainsinDeletedUser = false;
      #region check user contains in new users list
      foreach (NewUser newUser in _configClass.ConfSetWindowsUsers.NewUsers)
      {
        if (string.Equals(newUser.Name, userName, StringComparison.OrdinalIgnoreCase))
        {
          nameContainsinNewUser = true;
          break;
        }
      }
      #endregion check user contains in new users list
      #region check user contains in deleted users list
      foreach (DeletedUser deletedUser in _configClass.ConfSetWindowsUsers.DeletedUsers)
      {
        if (string.Equals(deletedUser.Name, userName, StringComparison.OrdinalIgnoreCase))
        {
          nameContainsinDeletedUser = true;
        }
      }
      #endregion check user contains in deleted users list
      bool userCanBeAdded = true;

      if (_configClass.ConfSetWindowsUsers.CheckIfUserExist(userName, _configClass))
      {
        if (nameContainsinDeletedUser)
        {
          userCanBeAdded = true;
        }
        else
        {
          userCanBeAdded = false;
        }

      }

      if (userCanBeAdded && !nameContainsinNewUser)
      {
        if (!_configClass.ConfSetWindowsUsergroup.CheckIfUserGroupExist(userName, _configClass))
        {
          if (userName != "" && fullName != "" && description != "" && password != "" && passwordConfirm != "")
          {
            if (!userName.Contains("|"))
            {
              if (password == passwordConfirm)
              {
                if (CheckPasswordPolicy(password))
                {
                  if (CheckPasswordIsNotontheBadList(password))
                  {
                    AddUser();
                  }
                  else
                  {
                    MessageBox.Show("The chosen password is on the banned list passwords \nPlease choose a different password.", "Check your password.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
                }
                else
                {
                  MessageBox.Show("The password does not meet the password policy requirements. \n Check the password minimum length and complexity.", "Check password policy.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              }
              else
              {
                MessageBox.Show("The completed password does not match the confirmation", "Passwords do not match.", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }

            }
            else
            {
              MessageBox.Show("Can't use character \"|\" for name  ", "The name contains incorrect character.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
          else
          {
            MessageBox.Show("Not all fields are filled in correctly", "Check the input fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
        else
        {
          MessageBox.Show("The name of a user can not be the same with a groupuser name", "Check the name", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      else
      {
        MessageBox.Show("The username " + userName + " has been already taken on this system.", "User already exists.", MessageBoxButtons.OK, MessageBoxIcon.Error);

      }

    }
    /// <summary>
    /// Get or set GroupsToBeChecked
    /// </summary>
    public List<string> GroupsToBeChecked
    {
      get { return _groupsToBeChecked; }
      set { _groupsToBeChecked = value; }
    } private List<string> _groupsToBeChecked = new List<string>();
    public void AddUser()
    {
      string userName = tbAddUserUserName.Text.TrimEnd(new char[] { ' ' });
      string fullName = tbAddUserFullName.Text;
      string description = tbAddUserDescription.Text;
      //List<string> listOfCheckedItemsinchkListB = new List<string>();
      List<string> usergroupList = new List<string>();

      //foreach (string checkedItemString in chkListBUserGroups.CheckedItems)
      //{
      //  listOfCheckedItemsinchkListB.Add(checkedItemString);
      //}
      _groupsToBeChecked.Clear();
      foreach (string userGroupsItem in chkListBUserGroups.CheckedItems)
      {
        usergroupList.Add(userGroupsItem);
        _groupsToBeChecked.Add(userGroupsItem);
      }

      string changePwNextLogon = "";
      string passwordCantBeChanged = "";
      string passwordNeverExpires = "";
      string accountDisabled = "";
      string password = tbAddUserPasword1.Text;
      string passwordConfirm = tbAddUserPasword2.Text;
      if (cbChangePwNextLogon.Checked == true) { changePwNextLogon = "Yes"; } else { changePwNextLogon = "No"; }
      if (cbPaswordCantBeChanged.Checked == true) { passwordCantBeChanged = "Yes"; } else { passwordCantBeChanged = "No"; }
      if (cbPaswordNeverExpires.Checked == true) { passwordNeverExpires = "Yes"; } else { passwordNeverExpires = "No"; }
      if (cbAccountDisabled.Checked == true) { accountDisabled = "Yes"; } else { accountDisabled = "No"; }

      NewUser user = new NewUser(userName, fullName, description, usergroupList, changePwNextLogon, passwordCantBeChanged, passwordNeverExpires, accountDisabled, password);
      _configClass.ConfSetWindowsUsers.AddNewUser = user;
      //After add new user, check if he belong to RDU
      foreach (string groupString in usergroupList)
      {

        if (groupString == "Remote Desktop Users")
          listbRemoteDesktopUsers.Items.Add(user.Name);
      }
      tbAddUserUserName.Text = "";
      tbAddUserFullName.Text = "";
      tbAddUserDescription.Text = "";
      tbAddUserPasword1.Text = "";
      tbAddUserPasword2.Text = "";
      cbRandomPaswordUsers.Checked = false;
      chkListBUserGroups.Refresh();
      RefreshListViewUsers();
    }
    private void btModifyUser_Click(object sender, EventArgs e)
    {
      string name = "";
      string fullname = "";
      string description = "";
      List<string> groups = new List<string>();
      string ChangePwNextLogon = "No";
      string PasswordCantBeChanged = "No";
      string PasswordNeverExpires = "No";
      string AccountDisabled = "No";
      string modifyOtherSettings = "No";
      string newPassword = "";
      bool isnew = false;
      bool ismodified = false;
      //List<bool> isGroupChecked = new List<bool>();      
      foreach (string userGroupsString in chkListBUserGroups.CheckedItems)
      {
        groups.Add(userGroupsString);
      }

      try
      {
        foreach (ListViewItem lvAll in lvUsers.Items)
        {
          if (lvAll.Selected)
          {
            #region check if user is in newList
            foreach (NewUser lvNew in _configClass.ConfSetWindowsUsers.NewUsers)
            {
              if (lvNew.Name == lvAll.Text)
              {
                isnew = true;
                break;
              }
            }
            #endregion check if user is in newList
            #region check if user is in modifyList
            foreach (ModfiedUser lvModified in _configClass.ConfSetWindowsUsers.ModifiedUsers)
            {
              if (lvModified.Name == lvAll.Text)
              {
                ismodified = true;
                break;
              }
            }
            #endregion check if user is in modifyList

            if (!isnew && !ismodified)
            {
              #region modify existed user
              using (Pages.ModifyUser popupDialog = new Pages.ModifyUser(lvAll.Text, this))
              {
                DialogResult dialogResult = popupDialog.ShowDialog(this);
                if (dialogResult == DialogResult.OK)
                {
                  name = lvAll.Text;
                  fullname = popupDialog.ChangeFullname;
                  description = popupDialog.ChangeDescription;
                  foreach (string userGroupsString2 in popupDialog.ChangeGroup)
                  {
                    groups.Add(userGroupsString2);
                  }

                  ChangePwNextLogon = "No";
                  PasswordCantBeChanged = "No";
                  PasswordNeverExpires = "No";
                  AccountDisabled = "No";
                  modifyOtherSettings = "No";
                  if (popupDialog.ChangePassword.Length != 0)
                  {
                    newPassword = popupDialog.ChangePassword;
                  }
                  else
                  {
                    newPassword = "-1";
                  }

                  if (popupDialog.ChangePasswordChangeNextLogon)
                  {
                    ChangePwNextLogon = "Yes";
                  }
                  if (popupDialog.ChangePasswordCantBeChanged)
                  {
                    PasswordCantBeChanged = "Yes";
                  }
                  if (popupDialog.ChangePasswordNeverExpires)
                  {
                    PasswordNeverExpires = "Yes";
                  }
                  if (popupDialog.ChangeAccountDisabled)
                  {
                    AccountDisabled = "Yes";
                  }
                  if (popupDialog.ModifyOtherSettings)
                  {
                    modifyOtherSettings = "Yes";
                  }
                  ModfiedUser modifyuser = new ModfiedUser(name, fullname, description, groups, ChangePwNextLogon, PasswordCantBeChanged, PasswordNeverExpires, AccountDisabled, newPassword, modifyOtherSettings);
                  _configClass.ConfSetWindowsUsers.AddModifiedUser = modifyuser;
                }
              }
              RefreshListViewUsers();
              #endregion modify existed user
            }
            else if (isnew)
            {
              #region modify new user
              foreach (NewUser newUser in _configClass.ConfSetWindowsUsers.NewUsers)
              {
                if (lvAll.Text == newUser.Name)
                {
                  name = newUser.Name;
                  fullname = newUser.Fullname;
                  description = newUser.Description;
                  groups = newUser.UserGroupList;
                  if (newUser.Password == "PassWordIsEncrypted")
                  {
                    newPassword = _encryptionPassword.GetKey(name);
                  }
                  else
                  {
                    newPassword = newUser.Password;
                  }
                  bool boolChangePwNextLogon = false;
                  bool boolPasswordCantBeChanged = false;
                  bool boolPasswordNeverExpires = false;
                  bool boolAccountDisabled = false;
                  if (newUser.ChangePwNextLogon == "Yes")
                  {
                    boolChangePwNextLogon = true;
                  }

                  if (newUser.PasswordCantBeChanged == "Yes")
                  {
                    boolPasswordCantBeChanged = true;
                  }

                  if (newUser.PasswordNeverExpires == "Yes")
                  {
                    boolPasswordNeverExpires = true;
                  }
                  if (newUser.AccountDisabled == "Yes")
                  {
                    boolAccountDisabled = true;
                  }
                  object[] usergroups = new object[chkListBUserGroups.Items.Count];
                  chkListBUserGroups.Items.CopyTo(usergroups, 0);
                  using (Pages.ModifyUser popupDialog = new Pages.ModifyUser(name, fullname, description, groups, boolChangePwNextLogon, boolPasswordCantBeChanged, boolPasswordNeverExpires, boolAccountDisabled, newPassword, this, usergroups))
                  {
                    DialogResult dialogResult = popupDialog.ShowDialog(this);
                    if (dialogResult == DialogResult.OK)
                    {
                      name = lvAll.Text;
                      fullname = popupDialog.ChangeFullname;
                      description = popupDialog.ChangeDescription;

                      ChangePwNextLogon = "No";
                      PasswordCantBeChanged = "No";
                      PasswordNeverExpires = "No";
                      AccountDisabled = "No";
                      modifyOtherSettings = "No";
                      newPassword = popupDialog.ChangePassword;

                      if (popupDialog.ChangePasswordChangeNextLogon)
                      {
                        ChangePwNextLogon = "Yes";
                      }
                      if (popupDialog.ChangePasswordCantBeChanged)
                      {
                        PasswordCantBeChanged = "Yes";
                      }
                      if (popupDialog.ChangePasswordNeverExpires)
                      {
                        PasswordNeverExpires = "Yes";
                      }
                      if (popupDialog.ChangeAccountDisabled)
                      {
                        AccountDisabled = "Yes";
                      }
                      if (popupDialog.ModifyOtherSettings)
                      {
                        modifyOtherSettings = "Yes";
                      }
                      NewUser newuser = new NewUser(name, fullname, description, groups, ChangePwNextLogon, PasswordCantBeChanged, PasswordNeverExpires, AccountDisabled, newPassword);
                      foreach (NewUser user in _configClass.ConfSetWindowsUsers.NewUsers)
                      {
                        if (user.Name == newuser.Name)
                        {
                          _configClass.ConfSetWindowsUsers.NewUsers.Remove(user);
                          _configClass.ConfSetWindowsUsers.AddNewUser = newuser;
                          break;
                        }
                      }

                    }
                  }

                  break;
                }

              }
              RefreshListViewUsers();
              #endregion modify new user
            }
            else if (ismodified)
            {
              #region modify modified user
              foreach (ModfiedUser modifiedUser in _configClass.ConfSetWindowsUsers.ModifiedUsers)
              {
                if (lvAll.Text == modifiedUser.Name)
                {
                  name = modifiedUser.Name;
                  fullname = modifiedUser.Fullname;
                  description = modifiedUser.Description;
                  groups = modifiedUser.UserGroupList;
                  if (modifiedUser.Password != "-1")
                  {
                    if (modifiedUser.Password == "PassWordIsEncrypted")
                    {
                      newPassword = _encryptionPassword.GetKey(name);
                    }
                    else
                    {
                      newPassword = modifiedUser.Password;
                    }
                  }
                  else
                  {
                    newPassword = "";
                  }
                  bool boolChangePwNextLogon = false;
                  bool boolPasswordCantBeChanged = false;
                  bool boolPasswordNeverExpires = false;
                  bool boolAccountDisabled = false;
                  if (modifiedUser.ChangePwNextLogon == "Yes")
                  {
                    boolChangePwNextLogon = true;
                  }

                  if (modifiedUser.PasswordCantBeChanged == "Yes")
                  {
                    boolPasswordCantBeChanged = true;
                  }

                  if (modifiedUser.PasswordNeverExpires == "Yes")
                  {
                    boolPasswordNeverExpires = true;
                  }
                  if (modifiedUser.AccountDisabled == "Yes")
                  {
                    boolAccountDisabled = true;
                  }
                  //object[] usergroups = new object[combUserGroups.Items.Count];
                  object[] usergroups = new object[chkListBUserGroups.Items.Count];
                  chkListBUserGroups.Items.CopyTo(usergroups, 0);
                  //combUserGroups.Items.CopyTo(usergroups, 0);
                  using (Pages.ModifyUser popupDialog = new Pages.ModifyUser(name, fullname, description, groups, boolChangePwNextLogon, boolPasswordCantBeChanged, boolPasswordNeverExpires, boolAccountDisabled, newPassword, this, usergroups))
                  {
                    DialogResult dialogResult = popupDialog.ShowDialog(this);
                    if (dialogResult == DialogResult.OK)
                    {
                      name = lvAll.Text;
                      fullname = popupDialog.ChangeFullname;
                      description = popupDialog.ChangeDescription;
                      ChangePwNextLogon = "No";
                      PasswordCantBeChanged = "No";
                      PasswordNeverExpires = "No";
                      AccountDisabled = "No";
                      modifyOtherSettings = "No";
                      if (popupDialog.ChangePassword.Length != 0)
                      {
                        newPassword = popupDialog.ChangePassword;
                      }
                      else
                      {
                        newPassword = "-1";
                      }

                      if (popupDialog.ChangePasswordChangeNextLogon)
                      {
                        ChangePwNextLogon = "Yes";
                      }
                      if (popupDialog.ChangePasswordCantBeChanged)
                      {
                        PasswordCantBeChanged = "Yes";
                      }
                      if (popupDialog.ChangePasswordNeverExpires)
                      {
                        PasswordNeverExpires = "Yes";
                      }
                      if (popupDialog.ChangeAccountDisabled)
                      {
                        AccountDisabled = "Yes";
                      }
                      if (popupDialog.ModifyOtherSettings)
                      {
                        modifyOtherSettings = "Yes";
                      }
                      ModfiedUser modifyuser = new ModfiedUser(name, fullname, description, groups, ChangePwNextLogon, PasswordCantBeChanged, PasswordNeverExpires, AccountDisabled, newPassword, modifyOtherSettings);
                      foreach (ModfiedUser user in _configClass.ConfSetWindowsUsers.ModifiedUsers)
                      {
                        if (user.Name == modifyuser.Name)
                        {
                          _configClass.ConfSetWindowsUsers.ModifiedUsers.Remove(user);
                          _configClass.ConfSetWindowsUsers.AddModifiedUser = modifyuser;
                          break;
                        }
                      }

                    }
                  }

                  break;
                }

              }
              RefreshListViewUsers();
              #endregion modify modified user
            }
          }
        }

      }
      catch (ArgumentOutOfRangeException ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "btModifyUser_Click", CLASSNAME, ex);
        lbSelectUserFirst.Visible = true;
      }

    }
    public bool CheckPasswordPolicy(string password)
    {
      int minLength = Convert.ToInt32(nudMinPaswordlength.Value);
      string complexcityReq = cbComplexityPW.Text;
      /// -----------------PasswordRequirements-------------------
      /// Passwords must contain characters from three of the following five categories: 
      /// Uppercase characters of European languages (A through Z, with diacritic marks, Greek and Cyrillic characters)
      /// Lowercase characters of European languages (a through z, sharp-s, with diacritic marks, Greek and Cyrillic characters)
      /// Base 10 digits (0 through 9)
      /// Nonalphanumeric characters: ~!@#$%^&*_-+=`|\(){}[]:;"'<>,.?/
      /// Any Unicode character that is categorized as an alphabetic character but is not uppercase or lowercase. This includes Unicode characters from Asian languages.

      if (complexcityReq == "Enabled")
      {
        int count = 0;
        if (password.Length < minLength)
        {
          return false;
        }
        if (password.Length >= 10) //password length is at least 10 chars
        {
          count++;
        }
        if (Regex.IsMatch(password, @"[A-Z]")) // password Contains Uppercase character
        {
          count++;
        }
        if (Regex.IsMatch(password, @"[a-z]")) // password Contains Lowercase character
        {
          count++;
        }
        if (Regex.IsMatch(password, @"\d")) // password Contains a number
        {
          count++;
        }
        if (Regex.IsMatch(password, @"[\W]")) // password Contains symbol
        {
          count++;
        }
        if (Regex.IsMatch(password, @"[^\u0000-\u007F]")) // password Contains unicode Character
        {
          count++;
        }

        if (count >= 3)
        {
          return true;
        }
      }
      else
      {
        if (password.Length >= minLength)
        {
          return true;
        }
      }
      return false;
    }
    public bool CheckPasswordIsNotontheBadList(string password)
    {
      bool isValid = true;
      List<string> badWordList = new List<string>();
      badWordList.Add("muimetca");
      badWordList.Add("actemium");
      badWordList.Add("muim3tc@");
      badWordList.Add("@ct3mium");

      foreach (string str in badWordList)
      {
        if (string.Equals(str, password, StringComparison.OrdinalIgnoreCase))
        {
          isValid = false;
          return isValid;
        }

      }

      if (password.Contains("mui") && password.Contains("tc"))
      {
        isValid = false;
        return isValid;
      }


      return isValid;
    }
    private void btDeleteUser_Click(object sender, EventArgs e)
    {
      string selectedName = "";
      bool selecteditemIsNewUser = false;
      bool selecteditemIsAdmin = false;
      bool selecteditemIsModifiedUser = false;
      NewUser newUserToDelete = new NewUser();
      ModfiedUser modifiedUserToDelete = new ModfiedUser();
      try
      {
        foreach (ListViewItem lviAll in lvUsers.Items)
        {

          if (lviAll.Selected)
          {
            selectedName = lviAll.Text;
            if (!_configClass.ConfSetWindowsUsers.CheckAccountIsBuiltIn(selectedName))
            {
              if (selectedName == "Admin") { selecteditemIsAdmin = true; }
              if (selectedName == "Actemium") { DeleteActemiumUser(); }

              foreach (ModfiedUser modifiedUser in _configClass.ConfSetWindowsUsers.ModifiedUsers)
              {
                if (lviAll.Text == modifiedUser.Name)
                {
                  selecteditemIsModifiedUser = true;
                  modifiedUserToDelete = modifiedUser;
                  break;
                }
              }
              foreach (NewUser newUser in _configClass.ConfSetWindowsUsers.NewUsers)
              {
                if (lviAll.Text == newUser.Name)
                {
                  selecteditemIsNewUser = true;
                  newUserToDelete = newUser;
                  break;
                }
              }

              #region if user is new
              if (selecteditemIsNewUser)
              {
                if (selecteditemIsAdmin)
                {
                  if (DeleteAdminUser())
                  {
                    _configClass.ConfSetWindowsUsers.RemoveNewUserFromList(newUserToDelete, _configClass);
                  }
                }
                else
                {
                  _configClass.ConfSetWindowsUsers.RemoveNewUserFromList(newUserToDelete, _configClass);
                }
              }
              #endregion if user is new
              #region if user is modified
              if (selecteditemIsModifiedUser)
              {
                if (selecteditemIsAdmin)
                {
                  if (DeleteAdminUser())
                  {
                    _configClass.ConfSetWindowsUsers.RemoveModifiedUserFromList(modifiedUserToDelete, _configClass);
                    foreach (ExistedUser existedUser in _configClass.ConfSetWindowsUsers.ExistedUsers(_configClass))
                    {
                      if (modifiedUserToDelete.Name == existedUser.Name)
                      {
                        DeletedUser deletedUser = new DeletedUser(existedUser.Name);
                        _configClass.ConfSetWindowsUsers.AddDeletedUser = deletedUser;
                      }
                    }
                  }
                }
                else
                {
                  _configClass.ConfSetWindowsUsers.RemoveModifiedUserFromList(modifiedUserToDelete, _configClass);
                  foreach (ExistedUser existedUser in _configClass.ConfSetWindowsUsers.ExistedUsers(_configClass))
                  {
                    if (modifiedUserToDelete.Name == existedUser.Name)
                    {

                      DeletedUser deletedUser = new DeletedUser(existedUser.Name);
                      _configClass.ConfSetWindowsUsers.AddDeletedUser = deletedUser;

                    }
                  }
                }

              }
              #endregion if user is modified
              #region if user not is new and not is modified
              if (!selecteditemIsNewUser && !selecteditemIsModifiedUser)
              {
                if (selecteditemIsAdmin)
                {
                  if (DeleteAdminUser())
                  {
                    DeletedUser deletedUser = new DeletedUser(selectedName);
                    _configClass.ConfSetWindowsUsers.AddDeletedUser = deletedUser;
                  }
                }
                else
                {
                  DeletedUser deletedUser = new DeletedUser(selectedName);
                  _configClass.ConfSetWindowsUsers.AddDeletedUser = deletedUser;
                }

              }
              #endregion if user not is new and not is modified

              RefreshListViewUsers();
              break;
            }
            else
            {
              MessageBox.Show("The selected user is a built-in account and can not be removed", "Account can not be removed");

            }
          }
        }


      }
      catch (ArgumentOutOfRangeException ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "btDeleteUser_Click", CLASSNAME, ex);
        lbSelectUserFirst.Visible = true;
      }
    }
    public void DeleteActemiumUser()
    {
      cbCreateActemiumUser.Checked = false;
      lbSelectUserFirst.Visible = false;
      lbPWActemium.Enabled = true;
      lbPWcomfimActemium.Enabled = true;
      tbPWActemium.Enabled = true;
      tbPWcomfimActemium.Enabled = true;
      cbCreateActemiumUser.Enabled = true;
      cbRandomPWActemium.Enabled = true;
    }
    public bool DeleteAdminUser()
    {
      MessageBoxButtons buttons2 = MessageBoxButtons.YesNo;
      DialogResult result2;

      // Displays the MessageBox.
      if (cbBlockDefAccoAdministrator.Checked)
      {
        result2 = MessageBox.Show("CAUTION! You have chosen account \"Administrator\" to be locked, the system should contain one active Admin or Administrator account, would you like to continue? ", "Admin account", buttons2, MessageBoxIcon.Warning);
      }
      else
      {
        result2 = System.Windows.Forms.DialogResult.Yes;
      }
      if (result2 == System.Windows.Forms.DialogResult.Yes)
      {
        cbCreateAdminUser.Checked = false;
        lbSelectUserFirst.Visible = false;
        lbPWAdmin.Enabled = true;
        lbPWcomfimAdmin.Enabled = true;
        tbPWAdmin.Enabled = true;
        tbPWcomfimAdmin.Enabled = true;
        cbCreateAdminUser.Enabled = true;
        cbRandomPWAdmin.Enabled = true;
        return true;
      }
      else
      {
        return false;
      }
    }

    private void cbChangePwNextLogon_CheckedChanged(object sender, EventArgs e)
    {
      if (cbChangePwNextLogon.Checked == true)
      {
        cbPaswordCantBeChanged.Enabled = false;
        cbPaswordCantBeChanged.Checked = false;
        cbPaswordNeverExpires.Enabled = false;
        cbPaswordNeverExpires.Checked = false;
      }
      else
      {
        cbPaswordCantBeChanged.Enabled = true;
        cbPaswordNeverExpires.Enabled = true;
      }
    }
    private void cbPaswordCantBeChanged_CheckedChanged(object sender, EventArgs e)
    {
      if (cbPaswordCantBeChanged.Checked == true)
      {
        cbChangePwNextLogon.Enabled = false;
        cbChangePwNextLogon.Checked = false;
      }
      else
      {
        if (!cbPaswordNeverExpires.Checked)
        {
          cbChangePwNextLogon.Enabled = true;
        }
      }
    }
    private void cbPaswordNeverExpires_CheckedChanged(object sender, EventArgs e)
    {
      if (cbPaswordNeverExpires.Checked == true)
      {
        cbChangePwNextLogon.Enabled = false;
        cbChangePwNextLogon.Checked = false;
      }
      else
      {
        if (!cbPaswordCantBeChanged.Checked)
        {
          cbChangePwNextLogon.Enabled = true;
        }
      }
    }
    private void cbRandomPaswordUsers_CheckedChanged(object sender, EventArgs e)
    {
      int defaultLength = 8;
      if (nudMinPaswordlength.Value > defaultLength)
      {
        defaultLength = (int)nudMinPaswordlength.Value;
      }
      PasswordGenerator pw = new PasswordGenerator();
      string password = pw.GeneratePassword(defaultLength);
      if (cbRandomPaswordUsers.Checked)
      {
        AskSavePasswordInLogfile();
        if (cbSavePasswordInLogFile.Checked)
        {
          SetPasswordFields(true);
        }
        else
        {
          SetPasswordFields(false);
        }


        tbAddUserPasword1.Text = password;
        tbAddUserPasword2.Text = password;
        tbAddUserPasword1.Enabled = false;
        tbAddUserPasword2.Enabled = false;
      }
      else
      {
        tbAddUserPasword1.PasswordChar = '*';
        tbAddUserPasword2.PasswordChar = '*';
        tbAddUserPasword1.Text = "";
        tbAddUserPasword2.Text = "";
        tbAddUserPasword1.Enabled = true;
        tbAddUserPasword2.Enabled = true;
      }
    }
    private void cbRandomPWActemium_CheckedChanged(object sender, EventArgs e)
    {
      int defaultLength = 8;
      if (nudMinPaswordlength.Value > defaultLength)
      {
        defaultLength = (int)nudMinPaswordlength.Value;
      }
      PasswordGenerator pw = new PasswordGenerator();
      string password = pw.GeneratePassword(defaultLength);
      if (cbRandomPWActemium.Checked)
      {
        AskSavePasswordInLogfile();
        if (cbSavePasswordInLogFile.Checked)
        {
          SetPasswordFields(true);
        }
        else
        {
          SetPasswordFields(false);
        }


        tbPWActemium.Text = password;
        tbPWcomfimActemium.Text = password;
        tbPWActemium.Enabled = false;
        tbPWcomfimActemium.Enabled = false;
      }
      else
      {
        tbPWActemium.PasswordChar = '*';
        tbPWcomfimActemium.PasswordChar = '*';
        tbPWActemium.Text = "";
        tbPWcomfimActemium.Text = "";
        tbPWActemium.Enabled = true;
        tbPWcomfimActemium.Enabled = true;
      }
    }
    private void cbRandomPWAdmin_CheckedChanged(object sender, EventArgs e)
    {
      int defaultLength = 8;
      if (nudMinPaswordlength.Value > defaultLength)
      {
        defaultLength = (int)nudMinPaswordlength.Value;
      }
      PasswordGenerator pw = new PasswordGenerator();
      string password = pw.GeneratePassword(defaultLength);

      if (cbRandomPWAdmin.Checked)
      {
        AskSavePasswordInLogfile();
        if (cbSavePasswordInLogFile.Checked)
        {
          SetPasswordFields(true);
        }
        else
        {
          SetPasswordFields(false);
        }
        tbPWAdmin.Text = password;
        tbPWcomfimAdmin.Text = password;
        tbPWAdmin.Enabled = false;
        tbPWcomfimAdmin.Enabled = false;

      }
      else
      {
        tbPWAdmin.PasswordChar = '*';
        tbPWcomfimAdmin.PasswordChar = '*';
        tbPWAdmin.Text = "";
        tbPWcomfimAdmin.Text = "";
        tbPWAdmin.Enabled = true;
        tbPWcomfimAdmin.Enabled = true;
      }
    }
    private void cbSavePasswordInLogFile_CheckedChanged(object sender, EventArgs e)
    {
      if (cbSavePasswordInLogFile.Checked)
      {
        _configClass.ConfSetWindowsUsers.SavePasswordsInLogfile = true;
        cbChangeDefaultAccountsSavePasswordInLogFile.Checked = true;
      }
      else
      {
        _configClass.ConfSetWindowsUsers.SavePasswordsInLogfile = false;
        cbChangeDefaultAccountsSavePasswordInLogFile.Checked = false;
      }
      SetPasswordFields(cbSavePasswordInLogFile.Checked);
    }
    public void AskSavePasswordInLogfile()
    {
      if (!_savePasswordinLogFileAsked)
      {
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        DialogResult result;

        // Displays the MessageBox.
        result = MessageBox.Show("Do you want to save the selected passwords in the log?", "Password remember", buttons);

        if (result == System.Windows.Forms.DialogResult.Yes)
        {
          cbSavePasswordInLogFile.Checked = true;
          cbChangeDefaultAccountsSavePasswordInLogFile.Checked = true;
        }
        else
        {
          cbSavePasswordInLogFile.Checked = false;
          cbChangeDefaultAccountsSavePasswordInLogFile.Checked = false;
        }
        _savePasswordinLogFileAsked = true;
      }
    }

    public void SetPasswordFields(bool saveInLogFile)
    {
      if (saveInLogFile)
      {
        tbSaPass.PasswordChar = '*';
        tbSaConfPass.PasswordChar = '*';
        tbPWActemium.PasswordChar = '*';
        tbPWcomfimActemium.PasswordChar = '*';
        tbPWAdmin.PasswordChar = '*';
        tbPWcomfimAdmin.PasswordChar = '*';
        tbAddUserPasword1.PasswordChar = '*';
        tbAddUserPasword2.PasswordChar = '*';

        tbChangePasswDefAccoGuest.PasswordChar = '*';
        tbChangeConfirmPasswDefAccoGuest.PasswordChar = '*';
        tbChangePasswDefAccoSUPPORT.PasswordChar = '*';
        tbChangeConfirmPasswDefAccoSUPPORT.PasswordChar = '*';
        tbChangePasswDefAccoAdministrator.PasswordChar = '*';
        tbChangeConfirmPasswDefAccoAdministrator.PasswordChar = '*';
      }
      else
      {
        if (cbSqlRandomPass.Checked)
        {
          tbSaPass.PasswordChar = '\0';
          tbSaConfPass.PasswordChar = '0';
        }
        if (cbRandomPWActemium.Checked)
        {
          tbPWActemium.PasswordChar = '\0';
          tbPWcomfimActemium.PasswordChar = '\0';
        }
        if (cbRandomPWAdmin.Checked)
        {
          tbPWAdmin.PasswordChar = '\0';
          tbPWcomfimAdmin.PasswordChar = '\0';
        }
        if (cbRandomPaswordUsers.Checked)
        {
          tbAddUserPasword1.PasswordChar = '\0';
          tbAddUserPasword2.PasswordChar = '\0';
        }

        if (cbRandomPWChangeDefAccoGuest.Checked)
        {
          tbChangePasswDefAccoGuest.PasswordChar = '\0';
          tbChangeConfirmPasswDefAccoGuest.PasswordChar = '\0';
        }
        if (cbRandomPWChangeDefAccoSUPPORT.Checked)
        {
          tbChangePasswDefAccoSUPPORT.PasswordChar = '\0';
          tbChangeConfirmPasswDefAccoSUPPORT.PasswordChar = '\0';
        }
        if (cbRandomPWChangeDefAccoAdministrator.Checked)
        {
          tbChangePasswDefAccoAdministrator.PasswordChar = '\0';
          tbChangeConfirmPasswDefAccoAdministrator.PasswordChar = '\0';
        }
      }
    }
    private void RefreshListViewUsers()
    {
      chkListBUserGroups.ClearSelected();
      List<string> combItems = new List<string>();
      combItems.Clear();

      lvUsers.Items.Clear();
      foreach (ExistedUser existeduser in _configClass.ConfSetWindowsUsers.ExistedUsers(_configClass))
      {
        ListViewItem lvi = new ListViewItem(new[] { existeduser.Name, existeduser.Fullname, existeduser.Description, existeduser.Groups });
        lvUsers.Items.Add(lvi);
        combItems.Add(existeduser.Name);
      }
      foreach (DeletedUser deletedUser in _configClass.ConfSetWindowsUsers.DeletedUsers)
      {
        foreach (ListViewItem user in lvUsers.Items)
        {
          if (deletedUser.Name == user.Text)
          {
            lvUsers.Items.Remove(user);
            combItems.Remove(deletedUser.Name);
            break;
          }
        }
      }
      foreach (NewUser newuser in _configClass.ConfSetWindowsUsers.NewUsers)
      {
        ListViewItem lvi = new ListViewItem(new[] { newuser.Name, newuser.Fullname, newuser.Description });
        lvUsers.Items.Add(lvi);
        combItems.Add(newuser.Name);
      }
      foreach (ModfiedUser modifieduser in _configClass.ConfSetWindowsUsers.ModifiedUsers)
      {
        foreach (ListViewItem user in lvUsers.Items)
        {
          if (modifieduser.Name == user.Text)
          {
            lvUsers.Items.Remove(user);
            combItems.Remove(modifieduser.Name);
            ListViewItem lvi = new ListViewItem(new[] { modifieduser.Name, modifieduser.Fullname, modifieduser.Description });
            lvUsers.Items.Add(lvi);
            combItems.Add(modifieduser.Name);

            break;
          }
        }
      }

      lvUsers.Sorting = System.Windows.Forms.SortOrder.Ascending;
      lvUsers.Sort();

      #region putUsers to combAutoLogonUser and combRemoteDesktopUsers
      combItems.Sort();
      //combAutoLogonUser.Items.Clear();      
      combAutoLogonUser.Items.Add("<none>");
      //combRemoteDesktopUsers.Items.Add("<none>");

      foreach (string str in combItems)
      {
        combAutoLogonUser.Items.Add(str);
        combRemoteDesktopUsers.Items.Add(str);
        _localUserMembers.Add(str);

      }


      #endregion putUsers to combAutoLogonUser and combRemoteDesktopUsers


    }
    #endregion addUsers

    #region AutoPlay Settings
    private void btWindowsRecommend_Click(object sender, EventArgs e)
    {
      cbWesDCSF.Checked = true;
      cbWesDFPAB.Checked = true;
      cbWesSHFF.Checked = true;
      cbWesASNFP.Checked = false;
      cbWesHEKF.Checked = false;
      cbWesHPOSF.Checked = false;
      cbWesREFS.Checked = false;
      cbWesSECFC.Checked = true;
      if (rbEnabledAP.Checked)
      {
        rbDisabledAP.Checked = true;
        rbEnabledAP.Checked = false;
      }

    }
    private void btWindowsCurrent_Click(object sender, EventArgs e)
    {
      GetCurrentWindowsSettings();
    }

    private void rbDisabledAP_CheckedChanged(object sender, EventArgs e)
    {
      if (rbDisabledAP.Checked)
      {
        cbAutoplaydrives.Enabled = true;
      }
      else
      {
        cbAutoplaydrives.Enabled = false;
      }

      if (rbDisabledAP.Checked == defaultrbEnabeledAutoPlay)
      {
        if (cbAutoplaydrives.Text == defaultcbAutoplaydrives)
        {
          lbAutoPlayNotDefault.Visible = false;
          tbAutoPlayNotDefault.Visible = false;
        }
      }
      else
      {
        lbAutoPlayNotDefault.Visible = true;
        tbAutoPlayNotDefault.Visible = true;
      }
    }
    private void wpAutoLogonAndEventTracker_BackButtonClick(object sender, CancelEventArgs e)
    {
      btWindowsCurrent.Visible = true;
      btWindowsRecommend.Visible = true;

    }
    private void wpAutoPlayAndWExplorer_BackButtonClick(object sender, CancelEventArgs e)
    {
      btWindowsCurrent.Visible = false;
      btWindowsRecommend.Visible = false;

    }



    #endregion AutoPlay Settings

    #region login shutdown and remote desktop

    #region autologon
    private void cbAutoLogon_CheckedChanged(object sender, EventArgs e)
    {
      if (cbAutoLogon.Checked == true)
      {
        combAutoLogonUser.Enabled = true;
      }
      else
      {
        errorProvider.Clear();
        combAutoLogonUser.Enabled = false;
        tbAutoLogonPasword.Enabled = false;
        tbAutoLogonPasword.Text = "";
        combAutoLogonUser.Text = "";
        combAutoLogonUser.SelectedIndex = 0;
        pbValidatePassWordAutoLogon.Visible = false;
      }

      if (cbAutoLogon.Checked == defaultAutoLogOn)
      {
        lbAutoLogonNotDefault.Visible = false;
        tbAutoLogonNotDefault.Visible = false;
      }
      else
      {
        lbAutoLogonNotDefault.Visible = true;
        tbAutoLogonNotDefault.Visible = true;
      }
    }
    private void combAutoLogonUser_SelectedIndexChanged(object sender, EventArgs e)
    {
      SelectedAutologonUserChanged();

    }
    private void tbAutoLogonPasword_TextChanged(object sender, EventArgs e)
    {
      if (ValidatePassword(combAutoLogonUser.Text, tbAutoLogonPasword.Text) == "PasswordCorrect")
      {
        pbValidatePassWordAutoLogon.Image = checkImages.Images[0];
        _autoLogonPasswordisValid = true;
      }
      else if (ValidatePassword(combAutoLogonUser.Text, tbAutoLogonPasword.Text) == "PasswordInCorrect")
      {
        pbValidatePassWordAutoLogon.Image = checkImages.Images[2];
        _autoLogonPasswordisValid = false;
      }
      else if (ValidatePassword(combAutoLogonUser.Text, tbAutoLogonPasword.Text) == "PasswordUnusable")
      {
        tbAutoLogonPasword.Enabled = false;
        tbAutoLogonPasword.Text = "";
        lbPasswordKnow.Visible = false;
        pbValidatePassWordAutoLogon.Visible = false;
        MessageBox.Show("The settings of the selected user are not suitable for automatic login. \nCheck whether the user is not blocked or password need to be changed", "Setting can not be configured", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public void SelectedAutologonUserChanged()
    {
      bool userIsExisted = false;
      bool userIsDeleted = false;
      bool userIsNew = false;
      bool userIsModified = false;
      _autoLogonPasswordisValid = false;
      pbValidatePassWordAutoLogon.Visible = false;
      lbPasswordKnow.Visible = false;
      tbAutoLogonPasword.Text = "";

      if (combAutoLogonUser.Text != "<none>")
      {
        pbValidatePassWordAutoLogon.Image = checkImages.Images[2];
        pbValidatePassWordAutoLogon.Visible = true;
        #region check if user is a existed user
        foreach (ExistedUser existeduser in _configClass.ConfSetWindowsUsers.ExistedUsers(_configClass))
        {
          if (existeduser.Name == combAutoLogonUser.Text)
          {
            userIsExisted = true;
            break;
          }
        }
        #endregion check if user is a existed user
        #region check if user is a deleted user
        foreach (DeletedUser deleteduser in _configClass.ConfSetWindowsUsers.DeletedUsers)
        {
          if (deleteduser.Name == combAutoLogonUser.Text)
          {
            userIsDeleted = true;
            break;
          }
        }
        #endregion check if user is a deleted user
        #region check if user is a new user
        foreach (NewUser newuser in _configClass.ConfSetWindowsUsers.NewUsers)
        {
          if (newuser.Name == combAutoLogonUser.Text)
          {
            userIsNew = true;
            break;
          }
        }
        #endregion check if user is a new user
        #region check if user is a modified user
        foreach (ModfiedUser modifieduser in _configClass.ConfSetWindowsUsers.ModifiedUsers)
        {
          if (modifieduser.Name == combAutoLogonUser.Text)
          {
            userIsModified = true;
            break;
          }
        }
        #endregion check if user is a modified user

        if (userIsExisted && !userIsDeleted && !userIsModified) //bestaande gebruiker wachtwoord moet worden ingevuld
        {
          foreach (ExistedUser existeduser in _configClass.ConfSetWindowsUsers.ExistedUsers(_configClass))
          {
            if (existeduser.Name == combAutoLogonUser.Text)
            {
              tbAutoLogonPasword.Enabled = true;
              ValidatePassword(existeduser.Name, tbAutoLogonPasword.Text);
              break;
            }
            else
            {
              tbAutoLogonPasword.Enabled = false;
            }
          }

        }
        else if (userIsNew) //nieuwe gebruiker dus wachtwoord is bekend
        {
          foreach (NewUser newuser in _configClass.ConfSetWindowsUsers.NewUsers)
          {
            if (newuser.Name == combAutoLogonUser.Text)
            {
              if (newuser.ChangePwNextLogon == "No" && newuser.AccountDisabled == "No")
              {
                string password = "";

                if (newuser.Password == "PassWordIsEncrypted")
                {
                  password = _encryptionPassword.GetKey(newuser.Name);
                }
                else
                {
                  password = newuser.Password;
                }
                tbAutoLogonPasword.Text = password;

                tbAutoLogonPasword.Enabled = false;
                pbValidatePassWordAutoLogon.Image = checkImages.Images[0];
                lbPasswordKnow.Visible = true;
              }
              else
              {
                tbAutoLogonPasword.Enabled = false;
                tbAutoLogonPasword.Text = "";
                lbPasswordKnow.Visible = false;
                pbValidatePassWordAutoLogon.Visible = false;
                MessageBox.Show("The settings of the selected user is not suitable for automatic login.\nVerify that the user is not blocked or password need to be changed", "Setting can not be configured", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              break;
            }
          }
          _autoLogonPasswordisValid = true;

        }
        else if (userIsModified)//aangepaste gebruiker, wachtwoord is alleen bekend als wachtwoord niet -1 bevat
        {
          foreach (ModfiedUser modifieduser in _configClass.ConfSetWindowsUsers.ModifiedUsers)
          {
            if (modifieduser.Name == combAutoLogonUser.Text)
            {
              if (modifieduser.ChangePwNextLogon == "No" && modifieduser.AccountDisabled == "No")
              {
                string password = "";
                if (modifieduser.Password != "-1")
                {
                  if (modifieduser.Password == "PassWordIsEncrypted")
                  {
                    password = _encryptionPassword.GetKey(modifieduser.Name);
                  }
                  else
                  {
                    password = modifieduser.Password;
                  }
                  tbAutoLogonPasword.Text = password;
                  tbAutoLogonPasword.Enabled = false;
                  pbValidatePassWordAutoLogon.Image = checkImages.Images[0];
                  lbPasswordKnow.Visible = true;
                  _autoLogonPasswordisValid = true;
                }
                else
                {
                  tbAutoLogonPasword.Enabled = true;
                }
              }
              else
              {
                tbAutoLogonPasword.Enabled = false;
                tbAutoLogonPasword.Text = "";
                lbPasswordKnow.Visible = false;
                pbValidatePassWordAutoLogon.Visible = false;
                MessageBox.Show("The settings of the selected user are not suitable for automatic login.\nVerify that the user is not blocked or password need to be changed", "Setting can not be configured", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              break;
            }
          }

        }

      }
    }
    public string ValidatePassword(string username, string password)
    {
      bool autoLogonPasswordisValid;

      using (PrincipalContext pc = new PrincipalContext(ContextType.Machine))
      {
        try
        {
          if (autoLogonPasswordisValid = pc.ValidateCredentials(username, password))
          {
            return "PasswordCorrect";
          }
          else
          {
            return "PasswordInCorrect";
          }
        }
        catch (PrincipalOperationException ex)
        {
          Actemium.Diagnostics.Trace.WriteError("({0})", "tbAutoLogonPasword_TextChanged", CLASSNAME, ex);
          MessageBox.Show("The user's password must be changed if this is your first time logging.", "Setting can not be configured", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return "PasswordUnusable";
        }
      };
    }

    #endregion autologon

    #region remote desktop
    private void btAddUserGroupToRD_Click(object sender, EventArgs e)
    {
      if (listbRemoteDesktopUsers.Items.Count == 0)
      {
        listbRemoteDesktopUsers.Items.Add(combRemoteDesktopUsers.SelectedItem);
      }
      else
      {
        bool checkExist = false;
        foreach (string str in listbRemoteDesktopUsers.Items)
        {
          if (str == combRemoteDesktopUsers.SelectedItem.ToString())
          {
            checkExist = true;
            break;
          }
        }
        if (!checkExist)
        {
          listbRemoteDesktopUsers.Items.Add(combRemoteDesktopUsers.SelectedItem);
        }
      }

    }

    private void combRemoteDesktopUsers_SelectedIndexChanged(object sender, EventArgs e)
    {

      if (listbRemoteDesktopUsers.Items.Count == 0)
      {
        listbRemoteDesktopUsers.Items.Add(combRemoteDesktopUsers.SelectedItem);
      }
      else
      {
        bool checkExist = false;
        foreach (string str in listbRemoteDesktopUsers.Items)
        {
          if (str == combRemoteDesktopUsers.SelectedItem.ToString())
          {
            checkExist = true;
            break;
          }
        }
        if (!checkExist)
        {
          listbRemoteDesktopUsers.Items.Add(combRemoteDesktopUsers.SelectedItem);
        }
      }
    }
    private void btRemoveRemoteDesktopUser_Click(object sender, EventArgs e)
    {
      listbRemoteDesktopUsers.Items.Remove(listbRemoteDesktopUsers.SelectedItem);
    }
    private void rbRemoteDesktopOff_CheckedChanged(object sender, EventArgs e)
    {
      if (rbRemoteDesktopOff.Checked)
      {
        combRemoteDesktopUsers.Enabled = false;

        btRemoveRemoteDesktopUser.Enabled = false;
        listbRemoteDesktopUsers.Enabled = false;
      }
      else
      {
        combRemoteDesktopUsers.Enabled = true;

        btRemoveRemoteDesktopUser.Enabled = true;
        listbRemoteDesktopUsers.Enabled = true;
      }

      if (rbRemoteDesktopOff.Checked == defaultRemoteDesktop)
      {
        lbRemoteDesktopNotDefault.Visible = false;
        tbRemoteDesktopNotDefault.Visible = false;
      }
      else
      {
        lbRemoteDesktopNotDefault.Visible = true;
        tbRemoteDesktopNotDefault.Visible = true;
      }
    }
    #endregion remote desktop

    #endregion login shutdown and remote desktop
    #region FTP
    private void btAddFtpSrv_Click(object sender, EventArgs e)
    {
      Pages.AddWebServer popupDialog = new Pages.AddWebServer();
      popupDialog.ShowDialog();

    }
    private void btWeblogBrowse_Click(object sender, EventArgs e)
    {
      using (FolderBrowserDialog ofSelectDir = new FolderBrowserDialog())
      {
        if (ofSelectDir.ShowDialog() == DialogResult.OK)
        {
          btWeblogBrowse.Text = ofSelectDir.SelectedPath;
        }

      }
    }
    private void btFTPLogBrowse_Click(object sender, EventArgs e)
    {
      using (FolderBrowserDialog ofSelectDir = new FolderBrowserDialog())
      {
        if (ofSelectDir.ShowDialog() == DialogResult.OK)
        {
          btFTPLogBrowse.Text = ofSelectDir.SelectedPath;
        }

      }
    }
    private void btMailLogBrowse_Click(object sender, EventArgs e)
    {
      using (FolderBrowserDialog ofSelectDir = new FolderBrowserDialog())
      {
        if (ofSelectDir.ShowDialog() == DialogResult.OK)
        {
          btMailLogBrowse.Text = ofSelectDir.SelectedPath;
        }

      }
    }
    private void btAddFtpUser_Click(object sender, EventArgs e)
    {
      //using (Pages.AddFTPUser popupDialog = new Pages.AddFTPUser())
      //{
      //    DialogResult dialogResult = popupDialog.ShowDialog(this);
      //}
      ////or we can use this 
      ////Pages.AddFTPUser newform = new Pages.AddFTPUser();
      ////newform.ShowDialog();

    }
    #endregion FTP
    #region Firewall



    private void cbFireWallOnOff_CheckedChanged(object sender, EventArgs e)
    {
      if (cbFireWallOnOff.Checked)
      {
        gbFireWall.Enabled = true;
      }
      else
      {
        gbFireWall.Enabled = false;
      }

      if (cbFireWallOnOff.Checked == defaultFireWallState)
      {
        lbFirewallNotDefault.Visible = false;
        tbFirewallNotDefault.Visible = false;
      }
      else
      {
        lbFirewallNotDefault.Visible = true;
        tbFirewallNotDefault.Visible = true;
      }
    }
    private void btFwBrowse_Click(object sender, EventArgs e)
    {

      using (OpenFileDialog ofdAddFireWallExceptions = new OpenFileDialog())
      {
        ofdAddFireWallExceptions.Filter = "EXE (*.exe)|*.exe|" + "COM (*com)|*.com|" + "ICD (*icd)|*.icd|" +
        "All Files(*.*)|*.*";
        if (ofdAddFireWallExceptions.ShowDialog() == DialogResult.OK)
        {

          tbFwProgramPath.Text = ofdAddFireWallExceptions.FileName;

        }
        CheckFireWallDefaults();
      }

    }
    private void btFwAddProgram_Click(object sender, EventArgs e)
    {
      string Filename = "";
      Filename = tbFwProgramPath.Text;
      if (os == OSVersions.WindowsXP || os == OSVersions.WindowsXP32 || os == OSVersions.WindowsXP64)
      {
        libFireWallExceptions.Items.Add(String.Format("Executable Path: {0}", Filename));
      }
      else
      {
        if (rbFwProgramInbound.Checked)
          libFireWallExceptions.Items.Add(String.Format("Executable Path: {0}", Filename + " Direction = IN"));
        else if (rbFwProgramOutbound.Checked)
          libFireWallExceptions.Items.Add(String.Format("Executable Path: {0}", Filename + " Direction = OUT"));
      }
    }
    private void btFwAdd_Click(object sender, EventArgs e)
    {
      #region Windows XP

      if (os == OSVersions.WindowsXP || os == OSVersions.WindowsXP32 || os == OSVersions.WindowsXP64)
      {
        string protocol = "";
        string proType = "";
        if (cbUDP.Checked && !cbTCP.Checked)
        {
          protocol = " Protocol = UDP";
          proType = "UDP";
        }
        if (!cbUDP.Checked && cbTCP.Checked)
        {
          protocol = " Protocol = TCP";
          proType = "TCP";
        }
        if (cbUDP.Checked && cbTCP.Checked)
        {
          protocol = " Protocol = ALL";
          proType = "ALL";
        }

        if ((tbFwName.Text != "" && tbFwPortnr.Text != "") && (cbTCP.Checked || cbUDP.Checked))
        {
          try
          {
            int port;
            port = Convert.ToInt32(tbFwPortnr.Text);
            if (_configClass.ConfSetWindowsFirewall.CheckFireWallPortisFree(port, proType, _configClass))
            {
              if (port < 1 || port > 65536)
              {
                MessageBox.Show("The chosen port number must be between 1 and 65535", "Check the port number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFwPortnr.Text = "";
              }
              else
              {

                string addException = "Exception " + tbFwName.Text + " PortNo: " + tbFwPortnr.Text + protocol;
                if (protocol != " Protocol = ALL")
                {
                  libFireWallExceptions.Items.Add(addException);
                  _configClass.ConfSetWindowsFirewall.AddFireWallPort = tbFwPortnr.Text + " " + protocol;
                }
                else
                {
                  addException = "Exception " + tbFwName.Text + " PortNo: " + tbFwPortnr.Text + " Protocol = TCP";
                  libFireWallExceptions.Items.Add(addException);
                  _configClass.ConfSetWindowsFirewall.AddFireWallPort = tbFwPortnr.Text + " " + "Protocol = TCP";
                  addException = "Exception " + tbFwName.Text + " PortNo: " + tbFwPortnr.Text + " Protocol = UDP";
                  libFireWallExceptions.Items.Add(addException);
                  _configClass.ConfSetWindowsFirewall.AddFireWallPort = tbFwPortnr.Text + " " + "Protocol = UDP";

                }
                tbFwName.Text = "";
                tbFwPortnr.Text = "";
                cbTCP.Checked = false;
                cbUDP.Checked = false;
              }
            }
            else
            {
              MessageBox.Show("The chosen port number can not be added. There is already an entry for the same port", "Choose another port no", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          }
          catch (FormatException ex)
          {
            Actemium.Diagnostics.Trace.WriteError("({0})", "btFwAdd_Click", CLASSNAME, ex);
            MessageBox.Show("The chosen port number is not correct", "Check the port number", MessageBoxButtons.OK, MessageBoxIcon.Error);

          }
        }
        else
        {
          MessageBox.Show("Not all fields are filled in correctly", "Check the input fields", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        CheckFireWallDefaults();
      }
      #endregion Windows XP
      #region Windows with version higher than XP
      else
      {
        string protocol = "";
        string proType = "";
        if (cbUDP.Checked && !cbTCP.Checked)
        {
          protocol = " Protocol = UDP";
          proType = "UDP";
        }
        if (!cbUDP.Checked && cbTCP.Checked)
        {
          protocol = " Protocol = TCP";
          proType = "TCP";
        }
        if (cbUDP.Checked && cbTCP.Checked)
        {
          protocol = " Protocol = ANY";
          proType = "ANY";
        }

        if ((tbFwName.Text != "" && tbFwPortnr.Text != "") && (cbTCP.Checked || cbUDP.Checked))
        {
          try
          {
            int port;
            port = Convert.ToInt32(tbFwPortnr.Text);
            if (_configClass.ConfSetWindowsFirewall.CheckFireWallPortisFree(port, proType, _configClass))
            {
              if (port < 1 || port > 65536)
              {
                MessageBox.Show("The chosen port number must be between 1 and 65535", "Check the port number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFwPortnr.Text = "";
              }
              else
              {
                if (rbPortInbound.Checked)
                {
                  string addException = "Exception " + tbFwName.Text + " Direction= IN" + " PortNo: " + tbFwPortnr.Text + protocol;
                  if (protocol != " Protocol = ANY")
                  {
                    libFireWallExceptions.Items.Add(addException);
                    _configClass.ConfSetWindowsFirewall.AddFireWallPort = "Direction= IN " + tbFwPortnr.Text + " " + protocol;
                  }
                  else
                  {
                    addException = "Exception " + tbFwName.Text + " Direction= IN" + " PortNo: " + tbFwPortnr.Text + " Protocol = TCP";
                    libFireWallExceptions.Items.Add(addException);
                    _configClass.ConfSetWindowsFirewall.AddFireWallPort = "Direction= IN " + tbFwPortnr.Text + " " + "Protocol = TCP";
                    addException = "Exception " + tbFwName.Text + " Direction= IN" + " PortNo: " + tbFwPortnr.Text + " Protocol = UDP";
                    libFireWallExceptions.Items.Add(addException);
                    _configClass.ConfSetWindowsFirewall.AddFireWallPort = "Direction= IN " + tbFwPortnr.Text + " " + "Protocol = UDP";

                  }
                  tbFwName.Text = "";
                  tbFwPortnr.Text = "";
                  cbTCP.Checked = false;
                  cbUDP.Checked = false;
                  rbPortInbound.Checked = true;
                }
                else if (rbPortOutbound.Checked)
                {
                  string addException = "Exception " + tbFwName.Text + " Direction= OUT" + " PortNo: " + tbFwPortnr.Text + protocol;
                  if (protocol != " Protocol = ANY")
                  {
                    libFireWallExceptions.Items.Add(addException);
                    _configClass.ConfSetWindowsFirewall.AddFireWallPort = "Direction= OUT " + tbFwPortnr.Text + " " + protocol;
                  }
                  else
                  {
                    addException = "Exception " + tbFwName.Text + " Direction= OUT" + " PortNo: " + tbFwPortnr.Text + " Protocol = TCP";
                    libFireWallExceptions.Items.Add(addException);
                    _configClass.ConfSetWindowsFirewall.AddFireWallPort = "Direction= OUT " + tbFwPortnr.Text + " " + "Protocol = TCP";
                    addException = "Exception " + tbFwName.Text + " Direction= OUT" + " PortNo: " + tbFwPortnr.Text + " Protocol = UDP";
                    libFireWallExceptions.Items.Add(addException);
                    _configClass.ConfSetWindowsFirewall.AddFireWallPort = "Direction= OUT " + tbFwPortnr.Text + " " + "Protocol = UDP";
                  }
                  tbFwName.Text = "";
                  tbFwPortnr.Text = "";
                  cbTCP.Checked = false;
                  cbUDP.Checked = false;
                  rbPortInbound.Checked = true;
                }
              }
            }
            else
            {
              MessageBox.Show("The chosen port number can not be added. There is already an entry for the same port", "Choose another port no", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          }
          catch (FormatException ex)
          {
            Actemium.Diagnostics.Trace.WriteError("({0})", "btFwAdd_Click", CLASSNAME, ex);
            MessageBox.Show("The chosen port number is not correct", "Check the port number", MessageBoxButtons.OK, MessageBoxIcon.Error);

          }
        }
        else
        {
          MessageBox.Show("Not all fields are filled in correctly", "Check the input fields", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        CheckFireWallDefaults();
      }
      #endregion Windows with version higher than XP
    }
    private void btFwDelete_Click(object sender, EventArgs e)
    {
      lbfwSelectedItem.Text = "";
      try
      {
        string selectedItem = libFireWallExceptions.SelectedItem.ToString();
        #region Windows XP

        if (os == OSVersions.WindowsXP || os == OSVersions.WindowsXP32 || os == OSVersions.WindowsXP64)
        {
          if (selectedItem != "")
          {

            if (selectedItem.Contains(PCANYWHERE_STRING))
            {
              //libFireWallExceptions.Items.Remove(libFireWallExceptions.SelectedItem);
              cbFwPcAnywhere.Checked = false;
            }
            else if (selectedItem.Contains(REMOTEDESKTOP_STRING))
            {
              cbFwRemoteDesktop.Checked = false;
            }
            else if (selectedItem.Contains(FTPSERVER_STRING))
            {
              cbFwFtpServer.Checked = false;
            }

            else if (selectedItem.ToString() == WEB_SERVER_HTTP_STRING)
            {
              cbFwWebServerHTTP.Checked = false;
            }
            else if (selectedItem.ToString() ==WEB_SERVER_HTTPS_STRING)
            {
              cbFwWebServerHTTPs.Checked = false;
            }
            else if (selectedItem.Contains(SQLSERVER_STRING))
              cbFwSqlServer.Checked = false;
            if (selectedItem.Contains("Exception") && selectedItem.Contains("PortNo:"))
            {
              libFireWallExceptions.Items.Remove(libFireWallExceptions.SelectedItem);
              string[] select = selectedItem.Split(' ');
              string port = "";
              string protocol = "";
              List<string> ports = new List<string>();
              for (int i = 0; i < select.Length; i++)
              {
                if (select[i] == "PortNo:")
                {
                  port = select[i + 1];
                }
                if (select[i] == "=")
                {
                  protocol = select[i + 1];
                }
              }
              if (port.Length != 0 && protocol.Length != 0)
              {
                foreach (string str in _configClass.ConfSetWindowsFirewall.GetOwnAddedFireWallPorts)
                {
                  if (!str.Contains(port) || !str.Contains(protocol))
                  {
                    ports.Add(str);
                  }
                }
                _configClass.ConfSetWindowsFirewall.ClearListOwnAddedFireWallPorts();
                foreach (string str in ports)
                {
                  _configClass.ConfSetWindowsFirewall.AddFireWallPort = str;
                }
              }
            }

            if (cbFwRemoteDesktop.Text != selectedItem)
            {
              lbfwSelectedItem.Text = "";
              libFireWallExceptions.Items.Remove(libFireWallExceptions.SelectedItem);
              CheckFireWallDefaults();
            }
          }
          else
          {
            lbfwSelectedItem.Text = "*Select an item";
          }

        }
        #endregion Windows XP
        #region Windows with version higher than XP

        else
        {
          if (selectedItem != "")
          {

            if (selectedItem.Contains(PCANYWHERE_STRING))
            {
              //libFireWallExceptions.Items.Remove(libFireWallExceptions.SelectedItem);
              cbFwPcAnywhere.Checked = false;
            }
            else if (selectedItem.Contains(REMOTEDESKTOP_STRING))
            {
              cbFwRemoteDesktop.Checked = false;
            }
            else if (selectedItem.Contains(FTPSERVER_STRING))
            {
              cbFwFtpServer.Checked = false;
            }

            else if (selectedItem.Contains(cbFwWebServerHTTP.Text))
            {
              cbFwWebServerHTTP.Checked = false;
            }
            else if (selectedItem.Contains(cbFwWebServerHTTPs.Text))
            {
              cbFwWebServerHTTPs.Checked = false;
            }

            if (selectedItem.Contains("Exception") && selectedItem.Contains("PortNo:"))
            {
              libFireWallExceptions.Items.Remove(libFireWallExceptions.SelectedItem);
              string[] select = selectedItem.Split(' ');
              string port = "";
              string protocol = "";
              string direction = "";
              List<string> ports = new List<string>();
              for (int i = 0; i < select.Length; i++)
              {
                if (select[i] == "Direction=")
                {
                  direction = select[i + 1];
                }
                if (select[i] == "PortNo:")
                {
                  port = select[i + 1];
                }
                if (select[i] == "=")
                {
                  protocol = select[i + 1];
                }
              }
              if (direction.Length != 0 && port.Length != 0 && protocol.Length != 0)
              {
                foreach (string str in _configClass.ConfSetWindowsFirewall.GetOwnAddedFireWallPorts)
                {
                  if (!str.Contains(direction) || !str.Contains(port) || !str.Contains(protocol))
                  {
                    ports.Add(str);
                  }
                }
                _configClass.ConfSetWindowsFirewall.ClearListOwnAddedFireWallPorts();
                foreach (string str in ports)
                {
                  _configClass.ConfSetWindowsFirewall.AddFireWallPort = str;
                }
              }
            }

            if (cbFwRemoteDesktop.Text != selectedItem)
            {
              lbfwSelectedItem.Text = "";
              libFireWallExceptions.Items.Remove(libFireWallExceptions.SelectedItem);
              CheckFireWallDefaults();
            }
          }
          else
          {
            lbfwSelectedItem.Text = "*Select an item";
          }
        }
        #endregion Windows with version higher than XP
      }
      catch (NullReferenceException ex)
      {
        lbfwSelectedItem.Text = "*Select an item";
        Actemium.Diagnostics.Trace.WriteError("({0})", "btFwDelete_Click", CLASSNAME, ex);
      }

    }
    public string FwRuleName
    {
      get
      { return _fwRuleName; }
      set
      { _fwRuleName = value; }
    }private string _fwRuleName = "";

    public string FwRuleDirection
    {
      get
      { return _fwRuleDirection; }
      set
      { _fwRuleDirection = value; }
    }private string _fwRuleDirection = "";

    public string FwRuleEnable
    {
      get
      { return _fwRuleEnable; }
      set
      { _fwRuleEnable = value; }
    }private string _fwRuleEnable = "";

    public string FwRuleProtocol
    {
      get
      { return _fwRuleProtocol; }
      set
      { _fwRuleProtocol = value; }
    }private string _fwRuleProtocol = "";

    public string FwRulePort
    {
      get
      { return _fwRulePort; }
      set
      { _fwRulePort = value; }
    }private string _fwRulePort = "";

    public string FwRuleAction
    {
      get
      { return _fwRuleAction; }
      set
      { _fwRuleAction = value; }
    }private string _fwRuleAction = "";

    private void btFwModify_Click(object sender, EventArgs e)
    {
      string selectedItemForName = libFireWallExceptions.SelectedItem.ToString();
      _fwRuleName = string.Empty;
      string[] splitForName = selectedItemForName.Split(' ');
      for (int j = 0; j <= splitForName.Length - 1; j++)
      {
        //j++;
        for (int k = 0; k <= splitForName.Length - 1; k++)
        {
          if (splitForName[j + k] != "Enabled")
          {
            _fwRuleName = _fwRuleName + splitForName[j + k];
            _fwRuleName = _fwRuleName + " ";
          }

          else
          {
            break;
          }
        }
        break;
      }
      _fwRuleName = _fwRuleName.Trim();
      string selectedItem = libFireWallExceptions.SelectedItem.ToString();
      string[] split = selectedItem.Split(' ');
      for (int i = 0; i <= split.Length-1; i++)
      {
        if (split[i].Contains("Enabled"))
        {
          _fwRuleEnable = split[i + 2];
        }
        if (split[i].Contains("Direction"))
        {
          _fwRuleDirection = split[i + 2];
        }
        if (split[i].Contains("Protocol"))
        {
          _fwRuleProtocol = split[i + 2];
        }
        if (split[i].Contains("Port"))
        {
          _fwRulePort = split[i + 2];
          _fwRuleAction = split[i + 3];
        }

      }

      Pages.FrmModifyFirewallRules frmModifyFirewallRules = new Pages.FrmModifyFirewallRules(_fwRuleName,        
        _fwRuleEnable,
        _fwRuleDirection,
        _fwRuleProtocol,
        _fwRulePort,
        _fwRuleAction);

      DialogResult dialogResult = frmModifyFirewallRules.ShowDialog(this);
      if (dialogResult == DialogResult.OK)
      {
        libFireWallExceptions.Items.Remove(libFireWallExceptions.SelectedItem);
        libFireWallExceptions.Items.Add(frmModifyFirewallRules.NewRuleName +
          " Enable - " + frmModifyFirewallRules.RuleEnable +
          " Direction - " + frmModifyFirewallRules.RuleDirection +
          " Protocol - " + frmModifyFirewallRules.RuleProtocol +
          " Localport - " + frmModifyFirewallRules.RulePort +
          " Action - " + frmModifyFirewallRules.RuleAction);
        
        string oldRuleName = "";
        string newRuleName = "";
        string ruleNewEnable = "";
        string ruleNewDirection = "";
        string ruleNewProtocol = "";
        string ruleNewPort = "";
        string ruleNewAction = "";
        oldRuleName = frmModifyFirewallRules.OldRuleName;
        newRuleName = frmModifyFirewallRules.NewRuleName;
        ruleNewEnable = frmModifyFirewallRules.RuleEnable;
        ruleNewDirection = frmModifyFirewallRules.RuleDirection;
        ruleNewProtocol = frmModifyFirewallRules.RuleProtocol;
        ruleNewPort = frmModifyFirewallRules.RulePort;
        ruleNewAction = frmModifyFirewallRules.RuleAction;
        ModifyFirewall modifyFirewallRule = new ModifyFirewall(oldRuleName,newRuleName,ruleNewEnable,ruleNewDirection,ruleNewProtocol,ruleNewPort,ruleNewAction);
        _configClass.ConfSetWindowsFirewall.ModifyFirewallRule.Add(modifyFirewallRule);
        _listOfModifiedNewFirewallRules.Add(newRuleName +
          " Enable - " + ruleNewEnable +
          " Direction - " + ruleNewDirection +
          " Protocol - " + ruleNewProtocol +
          " Localport - " + ruleNewPort +
          " Action - " + ruleNewAction);
        _listOfModifiedOldFirewallRule.Add(modifyFirewallRule.oldRuleName + 
          " Enabled - "+ _fwRuleEnable + 
          " Direction - " + _fwRuleDirection + 
          " Protocol - " +_fwRuleProtocol + 
          " Port - " + _fwRulePort + " " +_fwRuleAction);
      }



      //using (Pages.FrmModifyFirewallRules frmModifyFirewallRules = new Pages.FrmModifyFirewallRules())
      //{
      //  string ruleName = "";
      //  string ruleEnable = "";
      //  string ruleDirection = "";
      //  string ruleProtocol = "";
      //  string rulePort = "";
      //  string ruleAction = "";
      //  DialogResult dialogResult = frmModifyFirewallRules.ShowDialog(this);
      //  if (dialogResult == DialogResult.OK)
      //  {
      //    libFireWallExceptions.Items.Remove(libFireWallExceptions.SelectedItem);
      //    ruleName = frmModifyFirewallRules.NewRuleName;
      //    ruleEnable = frmModifyFirewallRules.RuleEnable;
      //    ruleDirection = frmModifyFirewallRules.RuleDirection;
      //    ruleProtocol = frmModifyFirewallRules.RuleProtocol;
      //    rulePort = frmModifyFirewallRules.RulePort;
      //    ruleAction = frmModifyFirewallRules.RuleAction;
      //    libFireWallExceptions.Items.Add(ruleName + "Enable: " + ruleEnable + " Direction: " + ruleDirection + " Protocol: " + ruleProtocol + " Localport: " + rulePort + " Action: " + ruleAction);
      //  }
      //}

    }



    private void cbFwPcAnywhere_CheckedChanged(object sender, EventArgs e)
    {

      if (cbFwPcAnywhere.Checked == true)
      {

        if (_configClass.ConfInstalledSoftware.GetInstallationPathOfApplication("pcAnywhere") != "")
        {
          string path = _configClass.ConfInstalledSoftware.GetInstallationPathOfApplication("pcAnywhere");

          if (!path.Contains("The install location"))
          {
            if (!libFireWallExceptions.Items.Contains(String.Format("Executable Path: {0}", path) + "awhost32.exe"))
              libFireWallExceptions.Items.Add(String.Format("Executable Path: {0}", path) + "awhost32.exe");
          }
          else
          {
            MessageBox.Show(path + "\n pcAnywhere can't find  \"awhost32.exe\".", "Installation path not found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cbFwPcAnywhere.Enabled = false;
          }
        }
      }
      else
      {
        if (_configClass.ConfInstalledSoftware.GetInstallationPathOfApplication("pcAnywhere") != "")
        {
          string path = _configClass.ConfInstalledSoftware.GetInstallationPathOfApplication("pcAnywhere");
          libFireWallExceptions.Items.Remove(String.Format("Executable Path: {0}", path) + "awhost32.exe");
        }
      }
      CheckFireWallDefaults();
    }
    private void cbFwRemoteDesktop_CheckedChanged(object sender, EventArgs e)
    {
      //RemeberDefaultsFirewall();
      //if the list box of firewall exceptions already had 
      if (cbFwRemoteDesktop.Checked == true)
      {
        //check again if list box doesn't contain item then add
        if (!libFireWallExceptions.Items.Contains(REMOTEDESKTOP_STRING))
          libFireWallExceptions.Items.Add(REMOTEDESKTOP_STRING);

      }
      else
      {
        libFireWallExceptions.Items.Remove(REMOTEDESKTOP_STRING);
      }
      CheckFireWallDefaults();
    }
    private void cbFwFtpServer_CheckedChanged(object sender, EventArgs e)
    {
      //RemeberDefaultsFirewall();
      if (cbFwFtpServer.Checked == true)
      {
        if (!libFireWallExceptions.Items.Contains(FTPSERVER_STRING))
          libFireWallExceptions.Items.Add(FTPSERVER_STRING);
      }
      else
        libFireWallExceptions.Items.Remove(FTPSERVER_STRING);

      CheckFireWallDefaults();
    }
    private void cbFwWebServerHTTP_CheckedChanged(object sender, EventArgs e)
    {
      if (cbFwWebServerHTTP.Checked == true)
      {
        if (!libFireWallExceptions.Items.Contains(WEB_SERVER_HTTP_STRING))
          libFireWallExceptions.Items.Add(WEB_SERVER_HTTP_STRING);
      }
      else
      {
        libFireWallExceptions.Items.Remove(WEB_SERVER_HTTP_STRING);
      }
      CheckFireWallDefaults();
    }
    private void cbFwWebServerHTTPs_CheckedChanged(object sender, EventArgs e)
    {
      if (cbFwWebServerHTTPs.Checked == true)
      {
        if (!libFireWallExceptions.Items.Contains(WEB_SERVER_HTTPS_STRING)/* && !libFireWallExceptions.Items.Contains()*/)
          libFireWallExceptions.Items.Add(WEB_SERVER_HTTPS_STRING);
      }
      else
      {
        libFireWallExceptions.Items.Remove(WEB_SERVER_HTTPS_STRING);

      }
      CheckFireWallDefaults();
    }
    private void cbFwSqlServer_CheckedChanged(object sender, EventArgs e)
    {
      RemeberDefaultsFirewall();
      if (cbFwSqlServer.Checked == true)
      {
        if (!libFireWallExceptions.Items.Contains(SQLSERVER_STRING))
          libFireWallExceptions.Items.Add(SQLSERVER_STRING);
        CheckFireWallDefaults();
      }
      else
      {
        libFireWallExceptions.Items.Remove(SQLSERVER_STRING);
        CheckFireWallDefaults();
      }
      CheckFireWallDefaults();
    }
    private void cbFwAddPort_CheckedChanged(object sender, EventArgs e)
    {
      if (cbFwAddPort.Checked)
      {
        if (os == OSVersions.WindowsXP || os == OSVersions.WindowsXP32 || os == OSVersions.WindowsXP64)
        {
          tbFwName.Enabled = true;
          tbFwPortnr.Enabled = true;
          cbTCP.Enabled = true;
          cbUDP.Enabled = true;
          btFwAdd.Enabled = true;
          lbFwName.Enabled = true;
          lbFwPort.Enabled = true;
          rbPortInbound.Enabled = false;
          rbPortOutbound.Enabled = false;
        }
        else
        {
          tbFwName.Enabled = true;
          tbFwPortnr.Enabled = true;
          cbTCP.Enabled = true;
          cbUDP.Enabled = true;
          btFwAdd.Enabled = true;
          lbFwName.Enabled = true;
          lbFwPort.Enabled = true;
          rbPortInbound.Enabled = true;
          rbPortOutbound.Enabled = true;
        }
      }
      else
      {
        tbFwName.Enabled = false;
        tbFwPortnr.Enabled = false;
        cbTCP.Enabled = false;
        cbUDP.Enabled = false;
        btFwAdd.Enabled = false;
        lbFwName.Enabled = false;
        lbFwPort.Enabled = false;
        rbPortInbound.Enabled = false;
        rbPortOutbound.Enabled = false;
      }
    }
    private void cbFwAddApplication_CheckedChanged(object sender, EventArgs e)
    {
      if (!cbFwAddApplication.Checked)
      {
        lbFwAppLoc.Enabled = false;
        tbFwProgramPath.Enabled = false;
        btFwBrowse.Enabled = false;
        btFwAddProgram.Enabled = false;
        rbFwProgramInbound.Enabled = false;
        rbFwProgramOutbound.Enabled = false;

      }
      else
      {
        if (os == OSVersions.WindowsXP || os == OSVersions.WindowsXP32 || os == OSVersions.WindowsXP64)
        {
          lbFwAppLoc.Enabled = true;
          tbFwProgramPath.Enabled = true;
          btFwBrowse.Enabled = true;
          btFwAddProgram.Enabled = true;
          rbFwProgramInbound.Enabled = false;
          rbFwProgramOutbound.Enabled = false;
        }
        else
        {
          lbFwAppLoc.Enabled = true;
          tbFwProgramPath.Enabled = true;
          btFwBrowse.Enabled = true;
          btFwAddProgram.Enabled = true;
          rbFwProgramInbound.Enabled = true;
          rbFwProgramOutbound.Enabled = true;
        }
      }

    }


    #endregion
    #region SQL Server
    private void rbSqlMixMode_CheckedChanged(object sender, EventArgs e)
    {
      if (!rbSqlMixMode.Checked)
      {
        gbChangeSaPass.Enabled = false;
      }
      else
      {
        gbChangeSaPass.Enabled = true;
      }

    }
    private void cbSqlSavePassToLog_CheckedChanged(object sender, EventArgs e)
    {
      if (cbSqlSavePassToLog.Checked)
      {
        _configClass.ConfigureSQLServer.SavePasswordsInLogfile = true;
      }
      else
      {
        _configClass.ConfigureSQLServer.SavePasswordsInLogfile = false;
      }
      SetPasswordFields(cbSqlSavePassToLog.Checked);
    }
    private void cbSqlRandomPass_CheckedChanged(object sender, EventArgs e)
    {
      int defaultLength = 8;
      if (nudMinPaswordlength.Value > defaultLength)
      {
        defaultLength = (int)nudMinPaswordlength.Value;
      }
      PasswordGenerator pw = new PasswordGenerator();
      string password = pw.GeneratePassword(defaultLength);
      if (cbSqlRandomPass.Checked)
      {
        AskSavePasswordInLogfile();
        if (cbSqlSavePassToLog.Checked)
        {
          SetPasswordFields(true);
        }
        else
        {
          SetPasswordFields(false);
        }


        tbSaPass.Text = password;
        tbSaConfPass.Text = password;
        tbSaConfPass.Enabled = false;
        tbSaPass.Enabled = false;

      }
      else
      {
        tbSaPass.PasswordChar = '*';
        tbSaConfPass.PasswordChar = '*';
        tbSaConfPass.Text = "";
        tbSaPass.Text = "";
        tbSaPass.Enabled = true;
        tbSaConfPass.Enabled = true;
      }

    }

    private void btAddSQLAdmins_Click(object sender, EventArgs e)
    {
      using (Pages.AddOrModifySqlServerUser popupForm = new Pages.AddOrModifySqlServerUser())
      {
        //DialogResult dialogResult = popupForm.ShowDialog(this);
        popupForm.ShowDialog(this);
      }

    }
    #endregion SQL Server
    #region SharedFolders
    private void btAddShare_Click(object sender, EventArgs e)
    {
      using (Pages.AddShare popupDialog = new Pages.AddShare())
      {
        DialogResult dialogResult = popupDialog.ShowDialog(this);
      }
    }
    #endregion SharedFolders
    #region Network
    private void btAddWirelessNet_Click(object sender, EventArgs e)
    {
      using (Pages.Wireless popupForm = new Pages.Wireless())
      {
        popupForm.ShowDialog(this);
      }
    }
    private void btSetIp_Click(object sender, EventArgs e)
    {
      //need check ifIpAddress, next version will correct this
      string newIpAddress = "";
      string newSubnetMask = "";
      string newDefaultGateway = "";
      string captionString = "";
      List<string> newDNSServers = new List<string>();
      if (cbNicAdapter.SelectedItem.ToString().Length != 0)
        captionString = cbNicAdapter.SelectedItem.ToString();
      if (tbDNSPre.Enabled == true)
      {
        if (tbDNSAlt.Text.Length != 0 && tbDNSPre.Text.Length != 0)
        {
          newDNSServers.Add(tbDNSPre.Text);
          newDNSServers.Add(tbDNSAlt.Text);
        }
        else if (tbDNSAlt.Text.Length == 0 && tbDNSPre.Text.Length != 0)
          newDNSServers.Add(tbDNSPre.Text);
        else if (tbDNSAlt.Text.Length != 0 && tbDNSPre.Text.Length == 0)
          newDNSServers.Add(tbDNSAlt.Text);
      }
      //if (IsIpAddress(tbIPaddress.Text))
      if (tbIPaddress.Enabled == true && tbIPaddress.Text.Length != 0)
        newIpAddress = tbIPaddress.Text;
      //if (IsIpAddress(tbSubnetMask.Text))
      if (tbSubnetMask.Enabled == true && tbSubnetMask.Text.Length != 0)
        newSubnetMask = tbSubnetMask.Text;
      //if (IsIpAddress(tbDefaultGateway.Text))
      if (tbDefaultGateway.Enabled == true && tbDefaultGateway.Text.Length != 0)
        newDefaultGateway = tbDefaultGateway.Text;
      NewNetwork newNetwork = new NewNetwork(newIpAddress, newSubnetMask, newDefaultGateway, newDNSServers, captionString);
      //I need to check if there is already a network available before add to "todo-list"
      _configClass.ConfigureSetNetwork.AddNewNetwork = newNetwork;
      cbNicAdapter.SelectedIndexChanged += new System.EventHandler(cbNicAdapter_SelectedIndexChanged);
    }
    private void cbNicAdapter_SelectedIndexChanged(object sender, EventArgs e)
    {
      rbIPAutoObtain.Checked = true;
      rbDNSAuto.Checked = true;

    }




    #endregion Network


    #region MBSA
    private void bgwCheckMBSApath_DoWork(object sender, DoWorkEventArgs e)
    {

    }
    private void bgwCheckMBSApath_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      string path = _configClass.ConfSetMicrosoftBaslineSecurityAnalyzer.FindMBSAexePath("Microsoft Baseline Security Analyzer", _configClass);
      if (cbMBSA.Checked && wpMBSA.Enabled)
      {

        if (path != null)
        {
          lbMBSAinstallationFolder.Text = path;
        }
      }
      DialogResult result2;
      if (path == null && lbMBSAinstallationFolder.Text == "Unknown" && wpMBSA.Enabled)
      {
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        DialogResult result = System.Windows.Forms.DialogResult.No;

        if (!_MBSAfindPathTryAgain)
        {
          result = MessageBox.Show("The installation path MBSA is not found. Would you like to select the path?", "MBSA path not found", buttons);
        }
        if (result == System.Windows.Forms.DialogResult.Yes || _MBSAfindPathTryAgain)
        {
          string Filename = "";
          using (System.Windows.Forms.FolderBrowserDialog fbdAddMBSApath = new FolderBrowserDialog())
          {
            if (fbdAddMBSApath.ShowDialog() == DialogResult.OK)
            {
              Filename = fbdAddMBSApath.SelectedPath;

              DirectoryInfo dir2 = new DirectoryInfo(Filename);
              string appName = null;
              foreach (FileInfo f in dir2.GetFiles("*.*"))
              {
                if (f.Name.Contains("mbsacli.exe"))
                {
                  appName = f.Name;
                  lbMBSAinstallationFolder.Text = Filename;
                }
              }
              if (appName == null)
              {
                result2 = MessageBox.Show("This folder does not contain the executable mbsacli.exe", "Invalid path", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result2 == System.Windows.Forms.DialogResult.Retry)
                {
                  bgwCheckMBSApath.RunWorkerAsync();
                  _MBSAfindPathTryAgain = true;
                }
              }
            }

          }


          wpMBSA.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.True;
        }
        else
        {
          cbMBSA.Checked = false;
          wpMBSA.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.True;
        }
      }

      wpMBSA.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.True;

    }

    private void cbMBSA_CheckedChanged(object sender, EventArgs e)
    {
      if (cbMBSA.Checked)
      {
        _configClass.ConfSetMicrosoftBaslineSecurityAnalyzer.MBSAchecked = true;
        bgwCheckMBSApath.RunWorkerAsync();
      }
      else
      {
        _configClass.ConfSetMicrosoftBaslineSecurityAnalyzer.MBSAchecked = false;
      }

      if (cbMBSA.Checked == defaultMBSA)
      {
        lbMBSAnotDefault.Visible = false;
        tbMBSAnotDefault.Visible = false;
      }
      else
      {
        lbMBSAnotDefault.Visible = true;
        tbMBSAnotDefault.Visible = true;
      }

    }


    #endregion MBSA

    #region MainProgram

    public void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      try
      {
        MainProgram main = new MainProgram(_configClass);
        main.CancelMakeSettings = false;
        main.updateConfigOverview += new MainProgram.UpdateConfigEvent(_mainProgram_updateConfigOverview);
        //main.makeSettings(MainProgram.mainSteps.start, os);
        if (rbAllsettingsPnStart.Checked)
          main.makeSettingsAll(main.MainstepAll, os);
        else if (rbSecurityPnStart.Checked)
          main.makeSettingsSecurity(main.MainstepSecurity, os);
        else if (rbLockDownPnStart.Checked)
          main.makeSettingsLock(main.MainstepLock, os);

      }
      catch (Exception ex)
      {
        if (ex.Message == "cancel")
        {
          MessageBox.Show("Configuration is aborted", "Abort", MessageBoxButtons.OK);
        }
        else
        {
          Actemium.Diagnostics.Trace.WriteError("()", "backgroundWorker1_DoWork", CLASSNAME, ex);
          MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
      MainProgram main = new MainProgram(_configClass);

      if (!main.CancelMakeSettings)
      {
        wpConfigurationCheck.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.True;
      }
      wpConfigurationCheck.CancelButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.True;
    }
    private void _mainProgram_updateConfigOverview(MainProgram m, UpdateConfigEventArgs e)
    {
      try
      {
        foreach (PictureBox pb in _pbList)
        {
          if (pb.Name == e.PictureBox)
          {
            pb.Image = checkImages.Images[e.Image];
            break;
          }
        }
      }
      catch
      {

      }
    }
    private void btCancelMakeSettings_Click(object sender, EventArgs e)
    {

      MessageBoxButtons buttons = MessageBoxButtons.YesNo;
      DialogResult result;
      // Displays the MessageBox.
      result = MessageBox.Show("Are you sure you want to abort the configuration?", "Abort?", buttons);

      if (result == System.Windows.Forms.DialogResult.Yes)
      {
        _configClass.ConfSetMicrosoftBaslineSecurityAnalyzer.KillMBSAProcessesByClosing("mbsacli");
        MainProgram main = new MainProgram(_configClass);
        main.CancelMakeSettings = true;
        btCancelMakeSettings.Enabled = false;
      }


    }
    #endregion MainProgram

    #region Error overview
    private void cbReadErrorLog_CheckedChanged(object sender, EventArgs e)
    {
      if (cbReadErrorLog.Checked)
      {
        wpConfigErrorOverview.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.True;
      }
      else
      {
        wpConfigErrorOverview.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
      }
    }
    public void ErrorOverview()
    {
      wpConfigErrorOverview.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
      string errorFolder = LogFilePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\ErrorOverview\";
      string errorfile = errorFolder + @"error.xml";
      if (!Directory.Exists(errorFolder))
      {
        Directory.CreateDirectory(errorFolder);
        string stylesheetPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\stylesheets\";
        File.Copy(stylesheetPath + "error.png", errorFolder + "\\error.png");
      }
      _fh.CreateFile(errorfile);
      XMLhandler.WriteConfigToFile("ErrorOverview", errorfile, errorFolder, _configClass);
      Uri uri = new Uri(errorfile);
      webBrowser2.Url = uri;

    }
    #endregion Error overview

    #region MBSA log overview
    private void cbReadMBSAlog_CheckedChanged(object sender, EventArgs e)
    {
      if (cbReadMBSAlog.Checked)
      {
        wpMBSAlogOverview.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.True;
      }
      else
      {
        wpMBSAlogOverview.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
      }
    }
    public void MBSAOverview()
    {
      wpMBSAlogOverview.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
      string mbsaLog = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\MBSAlog.txt";
      string tempLog = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\viewMBSAlog.txt";
      bool checkFaileddetected = false;
      _configClass.ConfSetMicrosoftBaslineSecurityAnalyzer.ReadMBSAlog(_configClass);
      foreach (string str in _fh.ReadWholeFile(mbsaLog))
      {
        if (str.Contains("Check failed"))
        {
          checkFaileddetected = true;
        }
        _fh.AddLineToEndFile(tempLog, str);

      }
      richTextBoxMBSAlog.LoadFile(tempLog, RichTextBoxStreamType.PlainText);
      if (checkFaileddetected)
      {
        MessageBox.Show("The MBSA scan has 1 or more failed checks detected, \ncheck the list for possible significant risks.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }
    public List<MBSAlogItem> MBSAlogs
    {
      get
      {
        return _mbsaLog;
      }
      set
      {
        _mbsaLog = value;
      }
    } private List<MBSAlogItem> _mbsaLog = new List<MBSAlogItem>();
    #endregion MBSA log overview

    #region finish
    private void btSaveWpFinish_Click(object sender, EventArgs e)
    {
      SaveFileDialog sfdSaveFinalLog = new SaveFileDialog();

      sfdSaveFinalLog.InitialDirectory = _fh.FilePath;
      sfdSaveFinalLog.DefaultExt = ".xml";
      sfdSaveFinalLog.FileName = _fh.FilePath;
      sfdSaveFinalLog.Filter = "XML Files (*.xml)|*.xml|" +
      "Text Files (*.txt)|*.txt|" +
      "All Files|";

      if (sfdSaveFinalLog.ShowDialog() == DialogResult.OK)
      {
        _fh.CreateFile(sfdSaveFinalLog.FileName);
        string[] folder = sfdSaveFinalLog.FileName.Split('\\');

        string newPath = "";
        for (int i = 0; i < folder.Length - 1; i++)
        {
          newPath += folder[i] + "/";
        }
        XMLhandler.WriteConfigToFile("TotalOverview", sfdSaveFinalLog.FileName, newPath, _configClass);
        File.Delete(_fh.FilePath);
        _fh.FilePath = sfdSaveFinalLog.FileName;
        MessageBox.Show("The log is saved successfully.", "Save");
      }
      else
      {
        MessageBox.Show("Something went wrong when saving the log.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }
    private void btViewLog_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start(_fh.FilePath);

    }
    #endregion finish

    #endregion main

    #region check current settings
    private void btCheckCurrentSettings_Click(object sender, EventArgs e)
    {
      Pages.CheckCurrentSafety CS = new Pages.CheckCurrentSafety(this, _configClass);
      CS.Show();

    }
    #endregion check current settings



































































  }

}
