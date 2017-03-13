using Actemium.WiSSWizard.Pages;
namespace Actemium.WiSSWizard
{
  partial class CtrlHome
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method met the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlHome));
      this.ofd1 = new System.Windows.Forms.OpenFileDialog();
      this.checkImages = new System.Windows.Forms.ImageList(this.components);
      this.btCheckCurrentSettings = new System.Windows.Forms.Button();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
      this.bgwCheckMBSApath = new System.ComponentModel.BackgroundWorker();
      this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.btWindowsCurrent = new System.Windows.Forms.Button();
      this.btWindowsRecommend = new System.Windows.Forms.Button();
      this.ttCheckCurrentSettings = new System.Windows.Forms.PictureBox();
      this.wizard1 = new DevComponents.DotNetBar.Wizard();
      this.wpStartUp = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.wpSelectNameAndSystem = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.rbSecurityPnStart = new System.Windows.Forms.RadioButton();
      this.rbLoadTemplate = new System.Windows.Forms.RadioButton();
      this.gbSelectTemplate = new System.Windows.Forms.GroupBox();
      this.btSelectTemplate = new System.Windows.Forms.Button();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.rbLockDownPnStart = new System.Windows.Forms.RadioButton();
      this.lbOperatingSystem = new System.Windows.Forms.Label();
      this.label40 = new System.Windows.Forms.Label();
      this.lbInfoPnStart = new System.Windows.Forms.Label();
      this.rbAllsettingsPnStart = new System.Windows.Forms.RadioButton();
      this.label11 = new System.Windows.Forms.Label();
      this.cbOperatingSystemPnStart = new System.Windows.Forms.ComboBox();
      this.tbFamilyNamePnStart = new System.Windows.Forms.TextBox();
      this.tbFirstNamePnStart = new System.Windows.Forms.TextBox();
      this.lbFamilyNamePnStart = new System.Windows.Forms.Label();
      this.lbFirstNamePnStart = new System.Windows.Forms.Label();
      this.wpInstalledApllications = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.groupBox18 = new System.Windows.Forms.GroupBox();
      this.lbNoteListOfInstalledSoftware = new System.Windows.Forms.Label();
      this.lbNoteExlaintListOfInstalledSoftware = new System.Windows.Forms.Label();
      this.label76 = new System.Windows.Forms.Label();
      this.label69 = new System.Windows.Forms.Label();
      this.pbInstalledSoftware6 = new System.Windows.Forms.PictureBox();
      this.pbNotInstalled = new System.Windows.Forms.PictureBox();
      this.pbInstalled = new System.Windows.Forms.PictureBox();
      this.label112 = new System.Windows.Forms.Label();
      this.label113 = new System.Windows.Forms.Label();
      this.label121 = new System.Windows.Forms.Label();
      this.label122 = new System.Windows.Forms.Label();
      this.label124 = new System.Windows.Forms.Label();
      this.label125 = new System.Windows.Forms.Label();
      this.label126 = new System.Windows.Forms.Label();
      this.pbInstalledSoftware5 = new System.Windows.Forms.PictureBox();
      this.pbInstalledSoftware4 = new System.Windows.Forms.PictureBox();
      this.pbInstalledSoftware3 = new System.Windows.Forms.PictureBox();
      this.pbInstalledSoftware2 = new System.Windows.Forms.PictureBox();
      this.pbInstalledSoftware1 = new System.Windows.Forms.PictureBox();
      this.wpPasswordPolicy = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btGetCurrentPasswordPolicies = new System.Windows.Forms.Button();
      this.tbCurrentNoOfSavedPw = new System.Windows.Forms.TextBox();
      this.tbCurrentMinimumPwLength = new System.Windows.Forms.TextBox();
      this.tbCurrentMinimumPwAge = new System.Windows.Forms.TextBox();
      this.tbCurrentMaximumPwAge = new System.Windows.Forms.TextBox();
      this.cbCurrentEncryptionPW = new System.Windows.Forms.ComboBox();
      this.cbCurrentComplexityPW = new System.Windows.Forms.ComboBox();
      this.label129 = new System.Windows.Forms.Label();
      this.label128 = new System.Windows.Forms.Label();
      this.label106 = new System.Windows.Forms.Label();
      this.label108 = new System.Windows.Forms.Label();
      this.label109 = new System.Windows.Forms.Label();
      this.label127 = new System.Windows.Forms.Label();
      this.ttPasswordEncryption = new System.Windows.Forms.PictureBox();
      this.ttPasswordComplexity = new System.Windows.Forms.PictureBox();
      this.cbEncryptionPW = new System.Windows.Forms.ComboBox();
      this.label56 = new System.Windows.Forms.Label();
      this.cbComplexityPW = new System.Windows.Forms.ComboBox();
      this.label57 = new System.Windows.Forms.Label();
      this.label58 = new System.Windows.Forms.Label();
      this.label59 = new System.Windows.Forms.Label();
      this.nudNrOfRememberedPasw = new System.Windows.Forms.NumericUpDown();
      this.label60 = new System.Windows.Forms.Label();
      this.label61 = new System.Windows.Forms.Label();
      this.nudMinPaswordlength = new System.Windows.Forms.NumericUpDown();
      this.label62 = new System.Windows.Forms.Label();
      this.label63 = new System.Windows.Forms.Label();
      this.nudMinPaswordTime = new System.Windows.Forms.NumericUpDown();
      this.label64 = new System.Windows.Forms.Label();
      this.label65 = new System.Windows.Forms.Label();
      this.nudMaxPaswordTime = new System.Windows.Forms.NumericUpDown();
      this.wpControlPolicy = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.gbControlPolicy = new System.Windows.Forms.GroupBox();
      this.tbAuditSystemEvents = new System.Windows.Forms.TextBox();
      this.tbAuditProcessTracking = new System.Windows.Forms.TextBox();
      this.tbAuditPrivilegeUse = new System.Windows.Forms.TextBox();
      this.tbAuditPolicyChange = new System.Windows.Forms.TextBox();
      this.tbAuditObjectAccess = new System.Windows.Forms.TextBox();
      this.tbAuditLogEvents = new System.Windows.Forms.TextBox();
      this.tbAuditDirSerAccess = new System.Windows.Forms.TextBox();
      this.tbAuditAccManage = new System.Windows.Forms.TextBox();
      this.tbAuditAccLogEvents = new System.Windows.Forms.TextBox();
      this.btGetAllCurrentAuditPolicies = new System.Windows.Forms.Button();
      this.label105 = new System.Windows.Forms.Label();
      this.ttAuditSytemEvents = new System.Windows.Forms.PictureBox();
      this.ttAuditProcessTracking = new System.Windows.Forms.PictureBox();
      this.ttAuditObjectAcces = new System.Windows.Forms.PictureBox();
      this.ttAuditPrivilegeUse = new System.Windows.Forms.PictureBox();
      this.ttAuditPolicyChange = new System.Windows.Forms.PictureBox();
      this.tbControlPolicy9 = new System.Windows.Forms.TextBox();
      this.ttAuditActiveDirectoryAcces = new System.Windows.Forms.PictureBox();
      this.tbControlPolicy8 = new System.Windows.Forms.TextBox();
      this.ttAuditAccountManagement = new System.Windows.Forms.PictureBox();
      this.tbControlPolicy6 = new System.Windows.Forms.TextBox();
      this.ttAuditAccountLogon = new System.Windows.Forms.PictureBox();
      this.tbControlPolicy5 = new System.Windows.Forms.TextBox();
      this.ttAuditLogonEvents = new System.Windows.Forms.PictureBox();
      this.tbControlPolicy3 = new System.Windows.Forms.TextBox();
      this.tbControlPolicy2 = new System.Windows.Forms.TextBox();
      this.tbControlPolicy1 = new System.Windows.Forms.TextBox();
      this.label46 = new System.Windows.Forms.Label();
      this.label47 = new System.Windows.Forms.Label();
      this.label48 = new System.Windows.Forms.Label();
      this.label49 = new System.Windows.Forms.Label();
      this.label45 = new System.Windows.Forms.Label();
      this.label44 = new System.Windows.Forms.Label();
      this.label43 = new System.Windows.Forms.Label();
      this.label42 = new System.Windows.Forms.Label();
      this.label41 = new System.Windows.Forms.Label();
      this.tbControlPolicy7 = new System.Windows.Forms.TextBox();
      this.lbAuditPolicyNotStandard = new System.Windows.Forms.Label();
      this.tbControlPolicy4 = new System.Windows.Forms.TextBox();
      this.combControlPolicy9 = new System.Windows.Forms.ComboBox();
      this.label13 = new System.Windows.Forms.Label();
      this.label19 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.combControlPolicy8 = new System.Windows.Forms.ComboBox();
      this.combControlPolicy1 = new System.Windows.Forms.ComboBox();
      this.label20 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.combControlPolicy7 = new System.Windows.Forms.ComboBox();
      this.combControlPolicy2 = new System.Windows.Forms.ComboBox();
      this.label21 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.combControlPolicy6 = new System.Windows.Forms.ComboBox();
      this.combControlPolicy3 = new System.Windows.Forms.ComboBox();
      this.label16 = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.combControlPolicy5 = new System.Windows.Forms.ComboBox();
      this.combControlPolicy4 = new System.Windows.Forms.ComboBox();
      this.label17 = new System.Windows.Forms.Label();
      this.wpGroups = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.cbAddgroupAdministrators = new System.Windows.Forms.CheckBox();
      this.cbAddGroupFTP_users = new System.Windows.Forms.CheckBox();
      this.lbSelectGroupFirst = new System.Windows.Forms.Label();
      this.btDeleteGroup = new System.Windows.Forms.Button();
      this.cbAddgroupActemiumEngineers = new System.Windows.Forms.CheckBox();
      this.label32 = new System.Windows.Forms.Label();
      this.lvUsergroups = new System.Windows.Forms.ListView();
      this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.Discription1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.label24 = new System.Windows.Forms.Label();
      this.tbAddUserGroupDescription = new System.Windows.Forms.TextBox();
      this.label23 = new System.Windows.Forms.Label();
      this.tbAddUserGroupName = new System.Windows.Forms.TextBox();
      this.btAddUserGroup = new System.Windows.Forms.Button();
      this.label22 = new System.Windows.Forms.Label();
      this.wpDefaultAccounts = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.gbAddAdminAndActemiumUsers = new System.Windows.Forms.GroupBox();
      this.cbRandomPWAdmin = new System.Windows.Forms.CheckBox();
      this.lbPWcomfimAdmin = new System.Windows.Forms.Label();
      this.lbPWAdmin = new System.Windows.Forms.Label();
      this.tbPWcomfimAdmin = new System.Windows.Forms.TextBox();
      this.tbPWAdmin = new System.Windows.Forms.TextBox();
      this.cbCreateAdminUser = new System.Windows.Forms.CheckBox();
      this.cbRandomPWActemium = new System.Windows.Forms.CheckBox();
      this.lbPWcomfimActemium = new System.Windows.Forms.Label();
      this.lbPWActemium = new System.Windows.Forms.Label();
      this.tbPWcomfimActemium = new System.Windows.Forms.TextBox();
      this.tbPWActemium = new System.Windows.Forms.TextBox();
      this.cbCreateActemiumUser = new System.Windows.Forms.CheckBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.lbChangeDefaultAccountAdministrator = new System.Windows.Forms.Label();
      this.lbChangeDefaultAccountSUPPORT = new System.Windows.Forms.Label();
      this.lbChangeDefaultAccountGuest = new System.Windows.Forms.Label();
      this.ttChangeDefaultAccountsSavePasswordInLogFile = new System.Windows.Forms.PictureBox();
      this.cbBlockDefAccoAdministrator = new System.Windows.Forms.CheckBox();
      this.cbChangeDefaultAccountsSavePasswordInLogFile = new System.Windows.Forms.CheckBox();
      this.cbRandomPWChangeDefAccoAdministrator = new System.Windows.Forms.CheckBox();
      this.label53 = new System.Windows.Forms.Label();
      this.tbChangeConfirmPasswDefAccoAdministrator = new System.Windows.Forms.TextBox();
      this.tbChangePasswDefAccoAdministrator = new System.Windows.Forms.TextBox();
      this.cbBlockDefAccoSUPPORT = new System.Windows.Forms.CheckBox();
      this.cbRandomPWChangeDefAccoSUPPORT = new System.Windows.Forms.CheckBox();
      this.label51 = new System.Windows.Forms.Label();
      this.tbChangeConfirmPasswDefAccoSUPPORT = new System.Windows.Forms.TextBox();
      this.tbChangePasswDefAccoSUPPORT = new System.Windows.Forms.TextBox();
      this.cbBlockDefAccoGuest = new System.Windows.Forms.CheckBox();
      this.cbRandomPWChangeDefAccoGuest = new System.Windows.Forms.CheckBox();
      this.label33 = new System.Windows.Forms.Label();
      this.label50 = new System.Windows.Forms.Label();
      this.tbChangeConfirmPasswDefAccoGuest = new System.Windows.Forms.TextBox();
      this.tbChangePasswDefAccoGuest = new System.Windows.Forms.TextBox();
      this.wpUsers = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.groupBox11 = new System.Windows.Forms.GroupBox();
      this.chkListBUserGroups = new System.Windows.Forms.CheckedListBox();
      this.btAddUser = new System.Windows.Forms.Button();
      this.tbAddUserPasword2 = new System.Windows.Forms.TextBox();
      this.label31 = new System.Windows.Forms.Label();
      this.tbAddUserPasword1 = new System.Windows.Forms.TextBox();
      this.label30 = new System.Windows.Forms.Label();
      this.tbAddUserDescription = new System.Windows.Forms.TextBox();
      this.label29 = new System.Windows.Forms.Label();
      this.tbAddUserFullName = new System.Windows.Forms.TextBox();
      this.label28 = new System.Windows.Forms.Label();
      this.tbAddUserUserName = new System.Windows.Forms.TextBox();
      this.label27 = new System.Windows.Forms.Label();
      this.btModifyUser = new System.Windows.Forms.Button();
      this.cbRandomPaswordUsers = new System.Windows.Forms.CheckBox();
      this.lbSelectUserFirst = new System.Windows.Forms.Label();
      this.btDeleteUser = new System.Windows.Forms.Button();
      this.ttSavePasswordInLogFile = new System.Windows.Forms.PictureBox();
      this.cbSavePasswordInLogFile = new System.Windows.Forms.CheckBox();
      this.cbAccountDisabled = new System.Windows.Forms.CheckBox();
      this.cbPaswordNeverExpires = new System.Windows.Forms.CheckBox();
      this.cbPaswordCantBeChanged = new System.Windows.Forms.CheckBox();
      this.cbChangePwNextLogon = new System.Windows.Forms.CheckBox();
      this.label26 = new System.Windows.Forms.Label();
      this.lvUsers = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.wpAutoPlayAndWExplorer = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.gbExplorerSettings = new System.Windows.Forms.GroupBox();
      this.lbWesASNFP = new System.Windows.Forms.Label();
      this.lbWesDCSF = new System.Windows.Forms.Label();
      this.tbWesDCSF = new System.Windows.Forms.TextBox();
      this.tbWesASNFP = new System.Windows.Forms.TextBox();
      this.lbWesDFPAB = new System.Windows.Forms.Label();
      this.tbWesDFPAB = new System.Windows.Forms.TextBox();
      this.lbWesSHFF = new System.Windows.Forms.Label();
      this.tbWesSHFF = new System.Windows.Forms.TextBox();
      this.lbWesHEKF = new System.Windows.Forms.Label();
      this.ttAutoSearchFoldersPrinters = new System.Windows.Forms.PictureBox();
      this.cbWesASNFP = new System.Windows.Forms.CheckBox();
      this.tbWesHEKF = new System.Windows.Forms.TextBox();
      this.lbWesHPOSF = new System.Windows.Forms.Label();
      this.tbWesHPOSF = new System.Windows.Forms.TextBox();
      this.lbWesREFS = new System.Windows.Forms.Label();
      this.tbWesREFS = new System.Windows.Forms.TextBox();
      this.lbWesSECFC = new System.Windows.Forms.Label();
      this.tbWesSECFC = new System.Windows.Forms.TextBox();
      this.ttShowNTFSinBlue = new System.Windows.Forms.PictureBox();
      this.ttRembemberViewSettings = new System.Windows.Forms.PictureBox();
      this.ttHideProtectedSysFiles = new System.Windows.Forms.PictureBox();
      this.ttHideExtensions = new System.Windows.Forms.PictureBox();
      this.ttShowHiddenFolders = new System.Windows.Forms.PictureBox();
      this.ttDisplayFullPathAddressBar = new System.Windows.Forms.PictureBox();
      this.ttDisplayContentsSysFolders = new System.Windows.Forms.PictureBox();
      this.cbWesSECFC = new System.Windows.Forms.CheckBox();
      this.cbWesREFS = new System.Windows.Forms.CheckBox();
      this.cbWesHPOSF = new System.Windows.Forms.CheckBox();
      this.cbWesHEKF = new System.Windows.Forms.CheckBox();
      this.cbWesSHFF = new System.Windows.Forms.CheckBox();
      this.cbWesDFPAB = new System.Windows.Forms.CheckBox();
      this.cbWesDCSF = new System.Windows.Forms.CheckBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.lbAutoPlayNotDefault = new System.Windows.Forms.Label();
      this.ttAutoPlay = new System.Windows.Forms.PictureBox();
      this.tbAutoPlayNotDefault = new System.Windows.Forms.TextBox();
      this.cbAutoplaydrives = new System.Windows.Forms.ComboBox();
      this.rbEnabledAP = new System.Windows.Forms.RadioButton();
      this.rbDisabledAP = new System.Windows.Forms.RadioButton();
      this.wpAutoLogonAndEventTracker = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.groupBox15 = new System.Windows.Forms.GroupBox();
      this.lbRemoteDesktopNotDefault = new System.Windows.Forms.Label();
      this.tbRemoteDesktopNotDefault = new System.Windows.Forms.TextBox();
      this.ttRemoteDesktopAddUsers = new System.Windows.Forms.PictureBox();
      this.label34 = new System.Windows.Forms.Label();
      this.btRemoveRemoteDesktopUser = new System.Windows.Forms.Button();
      this.listbRemoteDesktopUsers = new System.Windows.Forms.ListBox();
      this.combRemoteDesktopUsers = new System.Windows.Forms.ComboBox();
      this.rbRemoteDesktopOnMoreSecure = new System.Windows.Forms.RadioButton();
      this.rbRemoteDesktopOnLessSecure = new System.Windows.Forms.RadioButton();
      this.label114 = new System.Windows.Forms.Label();
      this.rbRemoteDesktopOff = new System.Windows.Forms.RadioButton();
      this.groupBox8 = new System.Windows.Forms.GroupBox();
      this.label118 = new System.Windows.Forms.Label();
      this.combAutoLogonUser = new System.Windows.Forms.ComboBox();
      this.lbAutoLogonNotDefault = new System.Windows.Forms.Label();
      this.tbAutoLogonNotDefault = new System.Windows.Forms.TextBox();
      this.lbShutDownEventTrackerNotDefault = new System.Windows.Forms.Label();
      this.lbPasswordKnow = new System.Windows.Forms.Label();
      this.tbShutDownEventTrackerNotDefault = new System.Windows.Forms.TextBox();
      this.pbValidatePassWordAutoLogon = new System.Windows.Forms.PictureBox();
      this.label116 = new System.Windows.Forms.Label();
      this.tbAutoLogonPasword = new System.Windows.Forms.TextBox();
      this.ttShutdownEventTracker = new System.Windows.Forms.PictureBox();
      this.combShutDEventTracker = new System.Windows.Forms.ComboBox();
      this.lbShutDownEventTracker = new System.Windows.Forms.Label();
      this.cbAutoLogon = new System.Windows.Forms.CheckBox();
      this.wpSQLConfig = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.btModifySQLUser = new System.Windows.Forms.Button();
      this.lvSqlAdmins = new System.Windows.Forms.ListView();
      this.btRemoveSQLAdmins = new System.Windows.Forms.Button();
      this.btAddSQLAdmins = new System.Windows.Forms.Button();
      this.label81 = new System.Windows.Forms.Label();
      this.label77 = new System.Windows.Forms.Label();
      this.gbSQL = new System.Windows.Forms.GroupBox();
      this.gbChangeSaPass = new System.Windows.Forms.GroupBox();
      this.cbSqlSavePassToLog = new System.Windows.Forms.CheckBox();
      this.cbSqlRandomPass = new System.Windows.Forms.CheckBox();
      this.tbSaConfPass = new System.Windows.Forms.TextBox();
      this.tbSaPass = new System.Windows.Forms.TextBox();
      this.label75 = new System.Windows.Forms.Label();
      this.label68 = new System.Windows.Forms.Label();
      this.cbSqlChangeSaPass = new System.Windows.Forms.CheckBox();
      this.tbSqlCurrentSaPass = new System.Windows.Forms.TextBox();
      this.label67 = new System.Windows.Forms.Label();
      this.rbSqlMixMode = new System.Windows.Forms.RadioButton();
      this.label66 = new System.Windows.Forms.Label();
      this.rbSqlWinAuthenMode = new System.Windows.Forms.RadioButton();
      this.wpPCAnywhere = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.groupBox23 = new System.Windows.Forms.GroupBox();
      this.checkBox28 = new System.Windows.Forms.CheckBox();
      this.radioButton9 = new System.Windows.Forms.RadioButton();
      this.radioButton10 = new System.Windows.Forms.RadioButton();
      this.radioButton11 = new System.Windows.Forms.RadioButton();
      this.groupBox22 = new System.Windows.Forms.GroupBox();
      this.checkBox27 = new System.Windows.Forms.CheckBox();
      this.radioButton8 = new System.Windows.Forms.RadioButton();
      this.radioButton7 = new System.Windows.Forms.RadioButton();
      this.radioButton6 = new System.Windows.Forms.RadioButton();
      this.groupBox24 = new System.Windows.Forms.GroupBox();
      this.radioButton12 = new System.Windows.Forms.RadioButton();
      this.radioButton13 = new System.Windows.Forms.RadioButton();
      this.groupBox21 = new System.Windows.Forms.GroupBox();
      this.label71 = new System.Windows.Forms.Label();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.label70 = new System.Windows.Forms.Label();
      this.radioButton5 = new System.Windows.Forms.RadioButton();
      this.radioButton4 = new System.Windows.Forms.RadioButton();
      this.groupBox20 = new System.Windows.Forms.GroupBox();
      this.checkBox26 = new System.Windows.Forms.CheckBox();
      this.checkBox25 = new System.Windows.Forms.CheckBox();
      this.checkBox24 = new System.Windows.Forms.CheckBox();
      this.checkBox23 = new System.Windows.Forms.CheckBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.groupBox25 = new System.Windows.Forms.GroupBox();
      this.checkBox29 = new System.Windows.Forms.CheckBox();
      this.radioButton14 = new System.Windows.Forms.RadioButton();
      this.radioButton15 = new System.Windows.Forms.RadioButton();
      this.radioButton16 = new System.Windows.Forms.RadioButton();
      this.groupBox26 = new System.Windows.Forms.GroupBox();
      this.checkBox30 = new System.Windows.Forms.CheckBox();
      this.radioButton17 = new System.Windows.Forms.RadioButton();
      this.radioButton18 = new System.Windows.Forms.RadioButton();
      this.radioButton19 = new System.Windows.Forms.RadioButton();
      this.groupBox27 = new System.Windows.Forms.GroupBox();
      this.radioButton20 = new System.Windows.Forms.RadioButton();
      this.radioButton21 = new System.Windows.Forms.RadioButton();
      this.groupBox28 = new System.Windows.Forms.GroupBox();
      this.label72 = new System.Windows.Forms.Label();
      this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
      this.label73 = new System.Windows.Forms.Label();
      this.radioButton22 = new System.Windows.Forms.RadioButton();
      this.radioButton23 = new System.Windows.Forms.RadioButton();
      this.groupBox29 = new System.Windows.Forms.GroupBox();
      this.checkBox31 = new System.Windows.Forms.CheckBox();
      this.checkBox32 = new System.Windows.Forms.CheckBox();
      this.checkBox33 = new System.Windows.Forms.CheckBox();
      this.checkBox34 = new System.Windows.Forms.CheckBox();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.checkBox40 = new System.Windows.Forms.CheckBox();
      this.checkBox39 = new System.Windows.Forms.CheckBox();
      this.checkBox36 = new System.Windows.Forms.CheckBox();
      this.checkBox35 = new System.Windows.Forms.CheckBox();
      this.textBox14 = new System.Windows.Forms.TextBox();
      this.textBox13 = new System.Windows.Forms.TextBox();
      this.label87 = new System.Windows.Forms.Label();
      this.label86 = new System.Windows.Forms.Label();
      this.label85 = new System.Windows.Forms.Label();
      this.pictureBox13 = new System.Windows.Forms.PictureBox();
      this.wpIIS = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.tabControl2 = new System.Windows.Forms.TabControl();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.groupBox19 = new System.Windows.Forms.GroupBox();
      this.btIISBrowse = new System.Windows.Forms.Button();
      this.btIISServiceLogin = new System.Windows.Forms.Button();
      this.lbIISPass = new System.Windows.Forms.Label();
      this.tbIISCustomAccountPass = new System.Windows.Forms.TextBox();
      this.tbIISCustomAccount = new System.Windows.Forms.TextBox();
      this.rbIIsAccountSelect = new System.Windows.Forms.RadioButton();
      this.rbIISLocalSystemAccount = new System.Windows.Forms.RadioButton();
      this.tpWeb = new System.Windows.Forms.TabPage();
      this.lbIISNotDefault = new System.Windows.Forms.Label();
      this.gbIISLog = new System.Windows.Forms.GroupBox();
      this.groupBox9 = new System.Windows.Forms.GroupBox();
      this.cbWebLogDelete = new System.Windows.Forms.CheckBox();
      this.btWeblogBrowse = new System.Windows.Forms.Button();
      this.tbWebLogLocation = new System.Windows.Forms.TextBox();
      this.groupBox7 = new System.Windows.Forms.GroupBox();
      this.label7 = new System.Windows.Forms.Label();
      this.nudWebLogSize = new System.Windows.Forms.NumericUpDown();
      this.rbWebLogSizeReach = new System.Windows.Forms.RadioButton();
      this.rbWebLogUnlimitSize = new System.Windows.Forms.RadioButton();
      this.rbWebLogMonth = new System.Windows.Forms.RadioButton();
      this.rbWebLogWeek = new System.Windows.Forms.RadioButton();
      this.rbWebLogDay = new System.Windows.Forms.RadioButton();
      this.rbWebLogHour = new System.Windows.Forms.RadioButton();
      this.cboWebActiveLogFormat = new System.Windows.Forms.ComboBox();
      this.cbLoginAuthorOnOff = new System.Windows.Forms.CheckBox();
      this.label6 = new System.Windows.Forms.Label();
      this.tbIISNotDefault = new System.Windows.Forms.TextBox();
      this.gbIIS = new System.Windows.Forms.GroupBox();
      this.lvWebservers = new System.Windows.Forms.ListView();
      this.btAddWebSrv = new System.Windows.Forms.Button();
      this.btRemoveWebSrv = new System.Windows.Forms.Button();
      this.lbWebServers = new System.Windows.Forms.Label();
      this.cbIISOnOff = new System.Windows.Forms.CheckBox();
      this.tabPage5 = new System.Windows.Forms.TabPage();
      this.lbMailSrvNotDefault = new System.Windows.Forms.Label();
      this.tbMailSrvNotDefault = new System.Windows.Forms.TextBox();
      this.gbMailSrvConfigure = new System.Windows.Forms.GroupBox();
      this.gbMailSrvRelay = new System.Windows.Forms.GroupBox();
      this.cbMailSrvRelayAllowSuccessAuthen = new System.Windows.Forms.CheckBox();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.listView2 = new System.Windows.Forms.ListView();
      this.label132 = new System.Windows.Forms.Label();
      this.rbMailSrvRelayAllExceptListBelow = new System.Windows.Forms.RadioButton();
      this.rbMailSrvRelayOnlyListBelow = new System.Windows.Forms.RadioButton();
      this.cbMailSrvRelay = new System.Windows.Forms.CheckBox();
      this.cbMailSrvAllowAnonym = new System.Windows.Forms.CheckBox();
      this.cbMailSrvConfOnOrOff = new System.Windows.Forms.CheckBox();
      this.gbMailSrvLogging = new System.Windows.Forms.GroupBox();
      this.gbMailSrvLogDir = new System.Windows.Forms.GroupBox();
      this.cbMailLogDelete = new System.Windows.Forms.CheckBox();
      this.btMailLogBrowse = new System.Windows.Forms.Button();
      this.tbMailLogLocation = new System.Windows.Forms.TextBox();
      this.gbMailLoggingSchedule = new System.Windows.Forms.GroupBox();
      this.label80 = new System.Windows.Forms.Label();
      this.nudMailLogSize = new System.Windows.Forms.NumericUpDown();
      this.rbMailLogSizeReach = new System.Windows.Forms.RadioButton();
      this.rbMailLogUnlimitedSize = new System.Windows.Forms.RadioButton();
      this.rbMailLogMonth = new System.Windows.Forms.RadioButton();
      this.rbMailLogWeek = new System.Windows.Forms.RadioButton();
      this.rbMailLogDay = new System.Windows.Forms.RadioButton();
      this.rbMailLogH = new System.Windows.Forms.RadioButton();
      this.cboMailActiveLogFormat = new System.Windows.Forms.ComboBox();
      this.cbLoggingMailOnOff = new System.Windows.Forms.CheckBox();
      this.label82 = new System.Windows.Forms.Label();
      this.tabPageFTP = new System.Windows.Forms.TabPage();
      this.groupBox14 = new System.Windows.Forms.GroupBox();
      this.btRemoveFtpSrv = new System.Windows.Forms.Button();
      this.btAddFtpSrv = new System.Windows.Forms.Button();
      this.listView1 = new System.Windows.Forms.ListView();
      this.lbFTPNet = new System.Windows.Forms.Label();
      this.cbFTPDir = new System.Windows.Forms.ComboBox();
      this.btAddFtpUser = new System.Windows.Forms.Button();
      this.btFtpShareConnect = new System.Windows.Forms.Button();
      this.lbFTPLocal = new System.Windows.Forms.Label();
      this.cbDisableFTPAnonymous = new System.Windows.Forms.CheckBox();
      this.cbFTPServerLogs = new System.Windows.Forms.CheckBox();
      this.cbFTPServerWrite = new System.Windows.Forms.CheckBox();
      this.cbFTPServerRead = new System.Windows.Forms.CheckBox();
      this.tbFTPPath = new System.Windows.Forms.TextBox();
      this.label54 = new System.Windows.Forms.Label();
      this.rbFtpShareLocated = new System.Windows.Forms.RadioButton();
      this.rbFTPLocalLocated = new System.Windows.Forms.RadioButton();
      this.groupBox10 = new System.Windows.Forms.GroupBox();
      this.gbFTPLogLocation = new System.Windows.Forms.GroupBox();
      this.label74 = new System.Windows.Forms.Label();
      this.cbFTPLogDelete = new System.Windows.Forms.CheckBox();
      this.btFTPLogBrowse = new System.Windows.Forms.Button();
      this.tbFTPLogLocation = new System.Windows.Forms.TextBox();
      this.gbFTPLogSchedule = new System.Windows.Forms.GroupBox();
      this.label10 = new System.Windows.Forms.Label();
      this.nudFTPLogSize = new System.Windows.Forms.NumericUpDown();
      this.rbFTPLogSizeReach = new System.Windows.Forms.RadioButton();
      this.rbFTPLogUnlimit = new System.Windows.Forms.RadioButton();
      this.rbFTPLogMonth = new System.Windows.Forms.RadioButton();
      this.rbFTPLogWeek = new System.Windows.Forms.RadioButton();
      this.rbFTPLogDay = new System.Windows.Forms.RadioButton();
      this.rbFTPLogHour = new System.Windows.Forms.RadioButton();
      this.cboFTPLogFormat = new System.Windows.Forms.ComboBox();
      this.cbFTPLoggingOnOff = new System.Windows.Forms.CheckBox();
      this.label52 = new System.Windows.Forms.Label();
      this.wpFireWall = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.cbFireWallOnOff = new System.Windows.Forms.CheckBox();
      this.gbFireWall = new System.Windows.Forms.GroupBox();
      this.btFwModify = new System.Windows.Forms.Button();
      this.groupBox13 = new System.Windows.Forms.GroupBox();
      this.rbFwProgramOutbound = new System.Windows.Forms.RadioButton();
      this.rbFwProgramInbound = new System.Windows.Forms.RadioButton();
      this.btFwAddProgram = new System.Windows.Forms.Button();
      this.cbFwAddApplication = new System.Windows.Forms.CheckBox();
      this.tbFwProgramPath = new System.Windows.Forms.TextBox();
      this.lbFwAppLoc = new System.Windows.Forms.Label();
      this.btFwBrowse = new System.Windows.Forms.Button();
      this.rbPortOutbound = new System.Windows.Forms.RadioButton();
      this.rbPortInbound = new System.Windows.Forms.RadioButton();
      this.cbUDP = new System.Windows.Forms.CheckBox();
      this.cbTCP = new System.Windows.Forms.CheckBox();
      this.TTtcpUdp = new System.Windows.Forms.PictureBox();
      this.lbFwPort = new System.Windows.Forms.Label();
      this.lbFwName = new System.Windows.Forms.Label();
      this.tbFwPortnr = new System.Windows.Forms.TextBox();
      this.tbFwName = new System.Windows.Forms.TextBox();
      this.cbFwAddPort = new System.Windows.Forms.CheckBox();
      this.btFwAdd = new System.Windows.Forms.Button();
      this.label35 = new System.Windows.Forms.Label();
      this.cbFwWebServerHTTPs = new System.Windows.Forms.CheckBox();
      this.cbFwSqlServer = new System.Windows.Forms.CheckBox();
      this.cbFwWebServerHTTP = new System.Windows.Forms.CheckBox();
      this.cbFwFtpServer = new System.Windows.Forms.CheckBox();
      this.cbFwRemoteDesktop = new System.Windows.Forms.CheckBox();
      this.cbFwPcAnywhere = new System.Windows.Forms.CheckBox();
      this.lbfwSelectedItem = new System.Windows.Forms.Label();
      this.tbFirewallNotDefault = new System.Windows.Forms.TextBox();
      this.lbFirewallNotDefault = new System.Windows.Forms.Label();
      this.btFwDelete = new System.Windows.Forms.Button();
      this.label36 = new System.Windows.Forms.Label();
      this.libFireWallExceptions = new System.Windows.Forms.ListBox();
      this.ttFireWall = new System.Windows.Forms.PictureBox();
      this.wpBlockKey = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.checkBox38 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.checkBox20 = new System.Windows.Forms.CheckBox();
      this.checkBox19 = new System.Windows.Forms.CheckBox();
      this.checkBox18 = new System.Windows.Forms.CheckBox();
      this.checkBox17 = new System.Windows.Forms.CheckBox();
      this.textBox9 = new System.Windows.Forms.TextBox();
      this.label84 = new System.Windows.Forms.Label();
      this.checkBox16 = new System.Windows.Forms.CheckBox();
      this.checkBox15 = new System.Windows.Forms.CheckBox();
      this.textBox8 = new System.Windows.Forms.TextBox();
      this.label83 = new System.Windows.Forms.Label();
      this.checkBox14 = new System.Windows.Forms.CheckBox();
      this.checkBox13 = new System.Windows.Forms.CheckBox();
      this.checkBox12 = new System.Windows.Forms.CheckBox();
      this.checkBox11 = new System.Windows.Forms.CheckBox();
      this.checkBox10 = new System.Windows.Forms.CheckBox();
      this.checkBox9 = new System.Windows.Forms.CheckBox();
      this.checkBox8 = new System.Windows.Forms.CheckBox();
      this.checkBox7 = new System.Windows.Forms.CheckBox();
      this.checkBox6 = new System.Windows.Forms.CheckBox();
      this.checkBox5 = new System.Windows.Forms.CheckBox();
      this.checkBox4 = new System.Windows.Forms.CheckBox();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.wpSharedFolderConfig = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.groupBox30 = new System.Windows.Forms.GroupBox();
      this.listVSharedFolders = new System.Windows.Forms.ListView();
      this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.btStopShare = new System.Windows.Forms.Button();
      this.btAddShare = new System.Windows.Forms.Button();
      this.wpNetworkConfigure = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.tabControl3 = new System.Windows.Forms.TabControl();
      this.tpIpConfig = new System.Windows.Forms.TabPage();
      this.btSetIp = new System.Windows.Forms.Button();
      this.listBCurrentIPSettings = new System.Windows.Forms.ListBox();
      this.gbUseStaticIPAddress = new System.Windows.Forms.GroupBox();
      this.label130 = new System.Windows.Forms.Label();
      this.cbNicAdapter = new System.Windows.Forms.ComboBox();
      this.rbIPManual = new System.Windows.Forms.RadioButton();
      this.rbIPAutoObtain = new System.Windows.Forms.RadioButton();
      this.tbDefaultGateway = new System.Windows.Forms.TextBox();
      this.tbSubnetMask = new System.Windows.Forms.TextBox();
      this.tbIPaddress = new System.Windows.Forms.TextBox();
      this.lbDefaultGateway = new System.Windows.Forms.Label();
      this.lbSubnetMask = new System.Windows.Forms.Label();
      this.lbIPaddress = new System.Windows.Forms.Label();
      this.gbDNSServers = new System.Windows.Forms.GroupBox();
      this.tbDNSAlt = new System.Windows.Forms.TextBox();
      this.tbDNSPre = new System.Windows.Forms.TextBox();
      this.lbDNSAlt = new System.Windows.Forms.Label();
      this.lbDNSPre = new System.Windows.Forms.Label();
      this.rbDNSManual = new System.Windows.Forms.RadioButton();
      this.rbDNSAuto = new System.Windows.Forms.RadioButton();
      this.tabPage7 = new System.Windows.Forms.TabPage();
      this.btRemoveWirelessNet = new System.Windows.Forms.Button();
      this.btAddWirelessNet = new System.Windows.Forms.Button();
      this.btWirelessConnect = new System.Windows.Forms.Button();
      this.lvWirelessNetworkAvailable = new System.Windows.Forms.ListView();
      this.wpMBSA = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.gbMBSA = new System.Windows.Forms.GroupBox();
      this.lbMBSAnotDefault = new System.Windows.Forms.Label();
      this.lbMBSAinstallationFolder = new System.Windows.Forms.Label();
      this.tbMBSAnotDefault = new System.Windows.Forms.TextBox();
      this.label123 = new System.Windows.Forms.Label();
      this.ttMBSA = new System.Windows.Forms.PictureBox();
      this.label91 = new System.Windows.Forms.Label();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.cbMBSA = new System.Windows.Forms.CheckBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.wpAcceptSettings = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.webBrowser1 = new System.Windows.Forms.WebBrowser();
      this.label93 = new System.Windows.Forms.Label();
      this.label37 = new System.Windows.Forms.Label();
      this.wpConfigurationCheck = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.groupBox12 = new System.Windows.Forms.GroupBox();
      this.label111 = new System.Windows.Forms.Label();
      this.label78 = new System.Windows.Forms.Label();
      this.pbConfigCheck18 = new System.Windows.Forms.PictureBox();
      this.pbConfigCheck17 = new System.Windows.Forms.PictureBox();
      this.label103 = new System.Windows.Forms.Label();
      this.label101 = new System.Windows.Forms.Label();
      this.label92 = new System.Windows.Forms.Label();
      this.label90 = new System.Windows.Forms.Label();
      this.label89 = new System.Windows.Forms.Label();
      this.label88 = new System.Windows.Forms.Label();
      this.pbConfigCheck16 = new System.Windows.Forms.PictureBox();
      this.pbConfigCheck15 = new System.Windows.Forms.PictureBox();
      this.pbConfigCheck14 = new System.Windows.Forms.PictureBox();
      this.pbConfigCheck13 = new System.Windows.Forms.PictureBox();
      this.pbConfigCheck12 = new System.Windows.Forms.PictureBox();
      this.pbConfigCheck11 = new System.Windows.Forms.PictureBox();
      this.btCancelMakeSettings = new System.Windows.Forms.Button();
      this.label117 = new System.Windows.Forms.Label();
      this.pbConfigCheck20 = new System.Windows.Forms.PictureBox();
      this.pbConfigCheck19 = new System.Windows.Forms.PictureBox();
      this.label115 = new System.Windows.Forms.Label();
      this.label119 = new System.Windows.Forms.Label();
      this.lbConfigMBSA = new System.Windows.Forms.Label();
      this.pbConfigCheck10 = new System.Windows.Forms.PictureBox();
      this.label102 = new System.Windows.Forms.Label();
      this.label100 = new System.Windows.Forms.Label();
      this.label99 = new System.Windows.Forms.Label();
      this.label98 = new System.Windows.Forms.Label();
      this.label97 = new System.Windows.Forms.Label();
      this.label96 = new System.Windows.Forms.Label();
      this.label95 = new System.Windows.Forms.Label();
      this.label120 = new System.Windows.Forms.Label();
      this.label94 = new System.Windows.Forms.Label();
      this.pbConfigCheck9 = new System.Windows.Forms.PictureBox();
      this.pbConfigCheck8 = new System.Windows.Forms.PictureBox();
      this.pbConfigCheck7 = new System.Windows.Forms.PictureBox();
      this.pbConfigCheck6 = new System.Windows.Forms.PictureBox();
      this.pbConfigCheck5 = new System.Windows.Forms.PictureBox();
      this.pbConfigCheck4 = new System.Windows.Forms.PictureBox();
      this.pbConfigCheck3 = new System.Windows.Forms.PictureBox();
      this.pbConfigCheck2 = new System.Windows.Forms.PictureBox();
      this.pbConfigCheck0 = new System.Windows.Forms.PictureBox();
      this.pbConfigCheck1 = new System.Windows.Forms.PictureBox();
      this.wpConfigErrorOverview = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.webBrowser2 = new System.Windows.Forms.WebBrowser();
      this.label55 = new System.Windows.Forms.Label();
      this.tbErrorOverviewComment = new System.Windows.Forms.TextBox();
      this.cbReadErrorLog = new System.Windows.Forms.CheckBox();
      this.wpMBSAlogOverview = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.label107 = new System.Windows.Forms.Label();
      this.tbMBSAcomments = new System.Windows.Forms.TextBox();
      this.cbReadMBSAlog = new System.Windows.Forms.CheckBox();
      this.richTextBoxMBSAlog = new System.Windows.Forms.RichTextBox();
      this.wpFinish = new Actemium.WiSSWizard.Pages.BaseWiSSWizardPage();
      this.groupBox17 = new System.Windows.Forms.GroupBox();
      this.btViewLog = new System.Windows.Forms.Button();
      this.lbLogfilePathWPFinish = new System.Windows.Forms.Label();
      this.pictureBox4 = new System.Windows.Forms.PictureBox();
      this.btSaveWpFinish = new System.Windows.Forms.Button();
      this.label110 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttCheckCurrentSettings)).BeginInit();
      this.wizard1.SuspendLayout();
      this.wpStartUp.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.wpSelectNameAndSystem.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.gbSelectTemplate.SuspendLayout();
      this.wpInstalledApllications.SuspendLayout();
      this.groupBox18.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbInstalledSoftware6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbNotInstalled)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbInstalled)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbInstalledSoftware5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbInstalledSoftware4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbInstalledSoftware3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbInstalledSoftware2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbInstalledSoftware1)).BeginInit();
      this.wpPasswordPolicy.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ttPasswordEncryption)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttPasswordComplexity)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudNrOfRememberedPasw)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMinPaswordlength)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMinPaswordTime)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaxPaswordTime)).BeginInit();
      this.wpControlPolicy.SuspendLayout();
      this.gbControlPolicy.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditSytemEvents)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditProcessTracking)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditObjectAcces)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditPrivilegeUse)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditPolicyChange)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditActiveDirectoryAcces)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditAccountManagement)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditAccountLogon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditLogonEvents)).BeginInit();
      this.wpGroups.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.wpDefaultAccounts.SuspendLayout();
      this.gbAddAdminAndActemiumUsers.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ttChangeDefaultAccountsSavePasswordInLogFile)).BeginInit();
      this.wpUsers.SuspendLayout();
      this.groupBox11.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ttSavePasswordInLogFile)).BeginInit();
      this.wpAutoPlayAndWExplorer.SuspendLayout();
      this.gbExplorerSettings.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ttAutoSearchFoldersPrinters)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttShowNTFSinBlue)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttRembemberViewSettings)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttHideProtectedSysFiles)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttHideExtensions)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttShowHiddenFolders)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttDisplayFullPathAddressBar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttDisplayContentsSysFolders)).BeginInit();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ttAutoPlay)).BeginInit();
      this.wpAutoLogonAndEventTracker.SuspendLayout();
      this.groupBox15.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ttRemoteDesktopAddUsers)).BeginInit();
      this.groupBox8.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbValidatePassWordAutoLogon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttShutdownEventTracker)).BeginInit();
      this.wpSQLConfig.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.gbSQL.SuspendLayout();
      this.gbChangeSaPass.SuspendLayout();
      this.wpPCAnywhere.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.groupBox23.SuspendLayout();
      this.groupBox22.SuspendLayout();
      this.groupBox24.SuspendLayout();
      this.groupBox21.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      this.groupBox20.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox25.SuspendLayout();
      this.groupBox26.SuspendLayout();
      this.groupBox27.SuspendLayout();
      this.groupBox28.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
      this.groupBox29.SuspendLayout();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
      this.wpIIS.SuspendLayout();
      this.tabControl2.SuspendLayout();
      this.tabPage4.SuspendLayout();
      this.groupBox19.SuspendLayout();
      this.tpWeb.SuspendLayout();
      this.gbIISLog.SuspendLayout();
      this.groupBox9.SuspendLayout();
      this.groupBox7.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudWebLogSize)).BeginInit();
      this.gbIIS.SuspendLayout();
      this.tabPage5.SuspendLayout();
      this.gbMailSrvConfigure.SuspendLayout();
      this.gbMailSrvRelay.SuspendLayout();
      this.gbMailSrvLogging.SuspendLayout();
      this.gbMailSrvLogDir.SuspendLayout();
      this.gbMailLoggingSchedule.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudMailLogSize)).BeginInit();
      this.tabPageFTP.SuspendLayout();
      this.groupBox14.SuspendLayout();
      this.groupBox10.SuspendLayout();
      this.gbFTPLogLocation.SuspendLayout();
      this.gbFTPLogSchedule.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudFTPLogSize)).BeginInit();
      this.wpFireWall.SuspendLayout();
      this.gbFireWall.SuspendLayout();
      this.groupBox13.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.TTtcpUdp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttFireWall)).BeginInit();
      this.wpBlockKey.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.wpSharedFolderConfig.SuspendLayout();
      this.groupBox30.SuspendLayout();
      this.wpNetworkConfigure.SuspendLayout();
      this.tabControl3.SuspendLayout();
      this.tpIpConfig.SuspendLayout();
      this.gbUseStaticIPAddress.SuspendLayout();
      this.gbDNSServers.SuspendLayout();
      this.tabPage7.SuspendLayout();
      this.wpMBSA.SuspendLayout();
      this.gbMBSA.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ttMBSA)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.wpAcceptSettings.SuspendLayout();
      this.wpConfigurationCheck.SuspendLayout();
      this.groupBox12.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck18)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck17)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck16)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck15)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck14)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck13)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck12)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck11)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck20)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck19)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck10)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck9)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck8)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck0)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck1)).BeginInit();
      this.wpConfigErrorOverview.SuspendLayout();
      this.wpMBSAlogOverview.SuspendLayout();
      this.wpFinish.SuspendLayout();
      this.groupBox17.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
      this.SuspendLayout();
      // 
      // ofd1
      // 
      this.ofd1.FileName = "openFileDialog1";
      // 
      // checkImages
      // 
      this.checkImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("checkImages.ImageStream")));
      this.checkImages.TransparentColor = System.Drawing.Color.Transparent;
      this.checkImages.Images.SetKeyName(0, "check_h2.png");
      this.checkImages.Images.SetKeyName(1, "download.png");
      this.checkImages.Images.SetKeyName(2, "cancel.png");
      this.checkImages.Images.SetKeyName(3, "disallow.png");
      this.checkImages.Images.SetKeyName(4, "btnDelete.png");
      this.checkImages.Images.SetKeyName(5, "disallowGray.png");
      this.checkImages.Images.SetKeyName(6, "disallow.png");
      this.checkImages.Images.SetKeyName(7, "disallowGr.png");
      this.checkImages.Images.SetKeyName(8, "check_h.png");
      // 
      // btCheckCurrentSettings
      // 
      this.btCheckCurrentSettings.BackColor = System.Drawing.SystemColors.Control;
      this.btCheckCurrentSettings.Location = new System.Drawing.Point(204, 385);
      this.btCheckCurrentSettings.Name = "btCheckCurrentSettings";
      this.btCheckCurrentSettings.Size = new System.Drawing.Size(171, 22);
      this.btCheckCurrentSettings.TabIndex = 3;
      this.btCheckCurrentSettings.Text = "Check current security";
      this.btCheckCurrentSettings.UseVisualStyleBackColor = false;
      this.btCheckCurrentSettings.Click += new System.EventHandler(this.btCheckCurrentSettings_Click);
      // 
      // backgroundWorker1
      // 
      this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
      this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
      // 
      // bgwCheckMBSApath
      // 
      this.bgwCheckMBSApath.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCheckMBSApath_DoWork);
      this.bgwCheckMBSApath.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCheckMBSApath_RunWorkerCompleted);
      // 
      // errorProvider
      // 
      this.errorProvider.ContainerControl = this;
      // 
      // btWindowsCurrent
      // 
      this.btWindowsCurrent.BackColor = System.Drawing.SystemColors.Control;
      this.btWindowsCurrent.Location = new System.Drawing.Point(12, 388);
      this.btWindowsCurrent.Name = "btWindowsCurrent";
      this.btWindowsCurrent.Size = new System.Drawing.Size(75, 23);
      this.btWindowsCurrent.TabIndex = 41;
      this.btWindowsCurrent.Text = "Current";
      this.btWindowsCurrent.UseVisualStyleBackColor = false;
      this.btWindowsCurrent.Visible = false;
      this.btWindowsCurrent.Click += new System.EventHandler(this.btWindowsCurrent_Click);
      // 
      // btWindowsRecommend
      // 
      this.btWindowsRecommend.BackColor = System.Drawing.SystemColors.Control;
      this.btWindowsRecommend.Location = new System.Drawing.Point(93, 388);
      this.btWindowsRecommend.Name = "btWindowsRecommend";
      this.btWindowsRecommend.Size = new System.Drawing.Size(89, 23);
      this.btWindowsRecommend.TabIndex = 42;
      this.btWindowsRecommend.Text = "Recommended";
      this.btWindowsRecommend.UseVisualStyleBackColor = false;
      this.btWindowsRecommend.Visible = false;
      this.btWindowsRecommend.Click += new System.EventHandler(this.btWindowsRecommend_Click);
      // 
      // ttCheckCurrentSettings
      // 
      this.ttCheckCurrentSettings.Image = ((System.Drawing.Image)(resources.GetObject("ttCheckCurrentSettings.Image")));
      this.ttCheckCurrentSettings.Location = new System.Drawing.Point(188, 389);
      this.ttCheckCurrentSettings.Name = "ttCheckCurrentSettings";
      this.ttCheckCurrentSettings.Size = new System.Drawing.Size(16, 16);
      this.ttCheckCurrentSettings.TabIndex = 40;
      this.ttCheckCurrentSettings.TabStop = false;
      this.ttCheckCurrentSettings.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // wizard1
      // 
      this.wizard1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
      this.wizard1.BackColor = System.Drawing.Color.Transparent;
      this.wizard1.Cursor = System.Windows.Forms.Cursors.Default;
      this.wizard1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.wizard1.FinishButtonTabIndex = 3;
      // 
      // 
      // 
      this.wizard1.FooterStyle.BackColor = System.Drawing.Color.Transparent;
      this.wizard1.FooterStyle.BackColorGradientAngle = 90;
      this.wizard1.FooterStyle.BorderBottomWidth = 1;
      this.wizard1.FooterStyle.BorderColor = System.Drawing.SystemColors.Control;
      this.wizard1.FooterStyle.BorderLeftWidth = 1;
      this.wizard1.FooterStyle.BorderRightWidth = 1;
      this.wizard1.FooterStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
      this.wizard1.FooterStyle.BorderTopColor = System.Drawing.SystemColors.Control;
      this.wizard1.FooterStyle.BorderTopWidth = 1;
      this.wizard1.FooterStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
      this.wizard1.FooterStyle.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
      this.wizard1.HeaderCaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.wizard1.HeaderImage = ((System.Drawing.Image)(resources.GetObject("wizard1.HeaderImage")));
      this.wizard1.HeaderImageSize = new System.Drawing.Size(50, 50);
      // 
      // 
      // 
      this.wizard1.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.wizard1.HeaderStyle.BackColorGradientAngle = 90;
      this.wizard1.HeaderStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
      this.wizard1.HeaderStyle.BorderBottomWidth = 1;
      this.wizard1.HeaderStyle.BorderColor = System.Drawing.SystemColors.Control;
      this.wizard1.HeaderStyle.BorderLeftWidth = 1;
      this.wizard1.HeaderStyle.BorderRightWidth = 1;
      this.wizard1.HeaderStyle.BorderTopWidth = 1;
      this.wizard1.HeaderStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
      this.wizard1.HeaderStyle.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
      this.wizard1.HelpButtonVisible = false;
      this.wizard1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
      this.wizard1.Location = new System.Drawing.Point(0, 0);
      this.wizard1.Name = "wizard1";
      this.wizard1.NextButtonTabIndex = 1;
      this.wizard1.Size = new System.Drawing.Size(622, 413);
      this.wizard1.TabIndex = 2;
      this.wizard1.WizardPages.AddRange(new DevComponents.DotNetBar.WizardPage[] {
            this.wpStartUp,
            this.wpSelectNameAndSystem,
            this.wpInstalledApllications,
            this.wpPasswordPolicy,
            this.wpControlPolicy,
            this.wpGroups,
            this.wpDefaultAccounts,
            this.wpUsers,
            this.wpAutoPlayAndWExplorer,
            this.wpAutoLogonAndEventTracker,
            this.wpSQLConfig,
            this.wpPCAnywhere,
            this.wpIIS,
            this.wpFireWall,
            this.wpBlockKey,
            this.wpSharedFolderConfig,
            this.wpNetworkConfigure,
            this.wpMBSA,
            this.wpAcceptSettings,
            this.wpConfigurationCheck,
            this.wpConfigErrorOverview,
            this.wpMBSAlogOverview,
            this.wpFinish});
      this.wizard1.FinishButtonClick += new System.ComponentModel.CancelEventHandler(this.wizard1_FinishButtonClick);
      this.wizard1.CancelButtonClick += new System.ComponentModel.CancelEventHandler(this.wizard1_CancelButtonClick);
      this.wizard1.WizardPageChanging += new DevComponents.DotNetBar.WizardCancelPageChangeEventHandler(this.wizard1_WizardPageChanging);
      this.wizard1.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // wpStartUp
      // 
      this.wpStartUp.AllowDrop = true;
      this.wpStartUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpStartUp.BackColor = System.Drawing.Color.White;
      this.wpStartUp.Controls.Add(this.pictureBox1);
      this.wpStartUp.Controls.Add(this.label2);
      this.wpStartUp.Controls.Add(this.label3);
      this.wpStartUp.InteriorPage = false;
      this.wpStartUp.Location = new System.Drawing.Point(0, 0);
      this.wpStartUp.Name = "wpStartUp";
      this.wpStartUp.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.All;
      this.wpStartUp.Size = new System.Drawing.Size(622, 367);
      // 
      // 
      // 
      this.wpStartUp.Style.BackColor = System.Drawing.Color.White;
      this.wpStartUp.Style.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wpStartUp.Style.BackgroundImage")));
      this.wpStartUp.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.TopLeft;
      this.wpStartUp.TabIndex = 7;
      this.wpStartUp.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpStartUp_NextButtonClick);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(151, 101);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(384, 29);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 7;
      this.pictureBox1.TabStop = false;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(210, 185);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(397, 150);
      this.label2.TabIndex = 1;
      this.label2.Text = "This application helps you optimize the security \r\nfor your windows OS";
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.BackColor = System.Drawing.Color.Transparent;
      this.label3.Location = new System.Drawing.Point(238, 335);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(305, 15);
      this.label3.TabIndex = 2;
      this.label3.Text = "Click Next to start ";
      // 
      // wpSelectNameAndSystem
      // 
      this.wpSelectNameAndSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpSelectNameAndSystem.AntiAlias = false;
      this.wpSelectNameAndSystem.BackColor = System.Drawing.Color.Transparent;
      this.wpSelectNameAndSystem.Controls.Add(this.groupBox3);
      this.wpSelectNameAndSystem.Location = new System.Drawing.Point(7, 72);
      this.wpSelectNameAndSystem.Name = "wpSelectNameAndSystem";
      this.wpSelectNameAndSystem.PageDescription = "Fill in your details";
      this.wpSelectNameAndSystem.PageTitle = "Start the wizard";
      this.wpSelectNameAndSystem.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.All;
      this.wpSelectNameAndSystem.Size = new System.Drawing.Size(608, 283);
      this.wpSelectNameAndSystem.TabIndex = 8;
      this.wpSelectNameAndSystem.BackButtonClick += new System.ComponentModel.CancelEventHandler(this.wpSelectNameAndSystem_BackButtonClick);
      this.wpSelectNameAndSystem.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpSelectNameAndSystem_NextButtonClick);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.rbSecurityPnStart);
      this.groupBox3.Controls.Add(this.rbLoadTemplate);
      this.groupBox3.Controls.Add(this.gbSelectTemplate);
      this.groupBox3.Controls.Add(this.rbLockDownPnStart);
      this.groupBox3.Controls.Add(this.lbOperatingSystem);
      this.groupBox3.Controls.Add(this.label40);
      this.groupBox3.Controls.Add(this.lbInfoPnStart);
      this.groupBox3.Controls.Add(this.rbAllsettingsPnStart);
      this.groupBox3.Controls.Add(this.label11);
      this.groupBox3.Controls.Add(this.cbOperatingSystemPnStart);
      this.groupBox3.Controls.Add(this.tbFamilyNamePnStart);
      this.groupBox3.Controls.Add(this.tbFirstNamePnStart);
      this.groupBox3.Controls.Add(this.lbFamilyNamePnStart);
      this.groupBox3.Controls.Add(this.lbFirstNamePnStart);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox3.Location = new System.Drawing.Point(0, 0);
      this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(608, 283);
      this.groupBox3.TabIndex = 5;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Start";
      // 
      // rbSecurityPnStart
      // 
      this.rbSecurityPnStart.AutoSize = true;
      this.rbSecurityPnStart.Location = new System.Drawing.Point(33, 231);
      this.rbSecurityPnStart.Name = "rbSecurityPnStart";
      this.rbSecurityPnStart.Size = new System.Drawing.Size(104, 17);
      this.rbSecurityPnStart.TabIndex = 5;
      this.rbSecurityPnStart.TabStop = true;
      this.rbSecurityPnStart.Text = "Security Settings";
      this.rbSecurityPnStart.UseVisualStyleBackColor = true;
      this.rbSecurityPnStart.CheckedChanged += new System.EventHandler(this.rbSecurityPnStart_CheckedChanged);
      // 
      // rbLoadTemplate
      // 
      this.rbLoadTemplate.AutoSize = true;
      this.rbLoadTemplate.Location = new System.Drawing.Point(34, 185);
      this.rbLoadTemplate.Name = "rbLoadTemplate";
      this.rbLoadTemplate.Size = new System.Drawing.Size(101, 17);
      this.rbLoadTemplate.TabIndex = 3;
      this.rbLoadTemplate.TabStop = true;
      this.rbLoadTemplate.Text = "Load a template";
      this.rbLoadTemplate.UseVisualStyleBackColor = true;
      this.rbLoadTemplate.CheckedChanged += new System.EventHandler(this.rbLoadTemplate_CheckedChanged);
      // 
      // gbSelectTemplate
      // 
      this.gbSelectTemplate.Controls.Add(this.btSelectTemplate);
      this.gbSelectTemplate.Controls.Add(this.textBox6);
      this.gbSelectTemplate.Location = new System.Drawing.Point(197, 174);
      this.gbSelectTemplate.Name = "gbSelectTemplate";
      this.gbSelectTemplate.Size = new System.Drawing.Size(221, 54);
      this.gbSelectTemplate.TabIndex = 22;
      this.gbSelectTemplate.TabStop = false;
      this.gbSelectTemplate.Text = "Select a template:";
      this.gbSelectTemplate.Visible = false;
      // 
      // btSelectTemplate
      // 
      this.btSelectTemplate.Location = new System.Drawing.Point(126, 24);
      this.btSelectTemplate.Name = "btSelectTemplate";
      this.btSelectTemplate.Size = new System.Drawing.Size(75, 23);
      this.btSelectTemplate.TabIndex = 34;
      this.btSelectTemplate.Text = "Browse";
      this.btSelectTemplate.UseVisualStyleBackColor = true;
      this.btSelectTemplate.Click += new System.EventHandler(this.btSelectTemplate_Click);
      // 
      // textBox6
      // 
      this.textBox6.Location = new System.Drawing.Point(20, 24);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(100, 20);
      this.textBox6.TabIndex = 0;
      // 
      // rbLockDownPnStart
      // 
      this.rbLockDownPnStart.AutoSize = true;
      this.rbLockDownPnStart.Location = new System.Drawing.Point(33, 254);
      this.rbLockDownPnStart.Name = "rbLockDownPnStart";
      this.rbLockDownPnStart.Size = new System.Drawing.Size(119, 17);
      this.rbLockDownPnStart.TabIndex = 6;
      this.rbLockDownPnStart.TabStop = true;
      this.rbLockDownPnStart.Text = "Lock Down settings";
      this.rbLockDownPnStart.UseVisualStyleBackColor = true;
      this.rbLockDownPnStart.CheckedChanged += new System.EventHandler(this.rbLockDownPnStart_CheckedChanged);
      // 
      // lbOperatingSystem
      // 
      this.lbOperatingSystem.AutoSize = true;
      this.lbOperatingSystem.Location = new System.Drawing.Point(19, 128);
      this.lbOperatingSystem.Name = "lbOperatingSystem";
      this.lbOperatingSystem.Size = new System.Drawing.Size(91, 13);
      this.lbOperatingSystem.TabIndex = 20;
      this.lbOperatingSystem.Text = "Operating system:";
      // 
      // label40
      // 
      this.label40.AutoSize = true;
      this.label40.Location = new System.Drawing.Point(301, 13);
      this.label40.Name = "label40";
      this.label40.Size = new System.Drawing.Size(273, 143);
      this.label40.TabIndex = 18;
      this.label40.Text = resources.GetString("label40.Text");
      // 
      // lbInfoPnStart
      // 
      this.lbInfoPnStart.AutoSize = true;
      this.lbInfoPnStart.Location = new System.Drawing.Point(19, 24);
      this.lbInfoPnStart.Name = "lbInfoPnStart";
      this.lbInfoPnStart.Size = new System.Drawing.Size(89, 13);
      this.lbInfoPnStart.TabIndex = 17;
      this.lbInfoPnStart.Text = "Fill in your details.";
      // 
      // rbAllsettingsPnStart
      // 
      this.rbAllsettingsPnStart.AutoSize = true;
      this.rbAllsettingsPnStart.Checked = true;
      this.rbAllsettingsPnStart.Location = new System.Drawing.Point(33, 208);
      this.rbAllsettingsPnStart.Name = "rbAllsettingsPnStart";
      this.rbAllsettingsPnStart.Size = new System.Drawing.Size(77, 17);
      this.rbAllsettingsPnStart.TabIndex = 4;
      this.rbAllsettingsPnStart.TabStop = true;
      this.rbAllsettingsPnStart.Text = "All Settings";
      this.rbAllsettingsPnStart.UseVisualStyleBackColor = true;
      this.rbAllsettingsPnStart.CheckedChanged += new System.EventHandler(this.rbAllsettingsPnStart_CheckedChanged);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(19, 128);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(93, 13);
      this.label11.TabIndex = 14;
      this.label11.Text = "Operation System:";
      // 
      // cbOperatingSystemPnStart
      // 
      this.cbOperatingSystemPnStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbOperatingSystemPnStart.FormattingEnabled = true;
      this.cbOperatingSystemPnStart.Location = new System.Drawing.Point(36, 147);
      this.cbOperatingSystemPnStart.Name = "cbOperatingSystemPnStart";
      this.cbOperatingSystemPnStart.Size = new System.Drawing.Size(114, 21);
      this.cbOperatingSystemPnStart.TabIndex = 23;
      this.cbOperatingSystemPnStart.Visible = false;
      // 
      // tbFamilyNamePnStart
      // 
      this.tbFamilyNamePnStart.Location = new System.Drawing.Point(42, 105);
      this.tbFamilyNamePnStart.Name = "tbFamilyNamePnStart";
      this.tbFamilyNamePnStart.Size = new System.Drawing.Size(100, 20);
      this.tbFamilyNamePnStart.TabIndex = 2;
      this.tbFamilyNamePnStart.Text = "test";
      this.tbFamilyNamePnStart.TextChanged += new System.EventHandler(this.tbFamilyNamePnStart_TextChanged);
      // 
      // tbFirstNamePnStart
      // 
      this.tbFirstNamePnStart.Location = new System.Drawing.Point(42, 68);
      this.tbFirstNamePnStart.Name = "tbFirstNamePnStart";
      this.tbFirstNamePnStart.Size = new System.Drawing.Size(100, 20);
      this.tbFirstNamePnStart.TabIndex = 1;
      this.tbFirstNamePnStart.Text = "test";
      this.tbFirstNamePnStart.TextChanged += new System.EventHandler(this.tbFirstNamePnStart_TextChanged);
      // 
      // lbFamilyNamePnStart
      // 
      this.lbFamilyNamePnStart.AutoSize = true;
      this.lbFamilyNamePnStart.Location = new System.Drawing.Point(36, 86);
      this.lbFamilyNamePnStart.Name = "lbFamilyNamePnStart";
      this.lbFamilyNamePnStart.Size = new System.Drawing.Size(56, 13);
      this.lbFamilyNamePnStart.TabIndex = 10;
      this.lbFamilyNamePnStart.Text = "Lastname:";
      // 
      // lbFirstNamePnStart
      // 
      this.lbFirstNamePnStart.AutoSize = true;
      this.lbFirstNamePnStart.Location = new System.Drawing.Point(36, 49);
      this.lbFirstNamePnStart.Name = "lbFirstNamePnStart";
      this.lbFirstNamePnStart.Size = new System.Drawing.Size(55, 13);
      this.lbFirstNamePnStart.TabIndex = 9;
      this.lbFirstNamePnStart.Text = "Firstname:";
      // 
      // wpInstalledApllications
      // 
      this.wpInstalledApllications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpInstalledApllications.AntiAlias = false;
      this.wpInstalledApllications.BackColor = System.Drawing.Color.Transparent;
      this.wpInstalledApllications.Controls.Add(this.groupBox18);
      this.wpInstalledApllications.Location = new System.Drawing.Point(7, 72);
      this.wpInstalledApllications.Name = "wpInstalledApllications";
      this.wpInstalledApllications.PageDescription = "Here is an overview of software installed on this system and may be needed for th" +
    "e complete configuration of this application.";
      this.wpInstalledApllications.PageTitle = "List of installed software";
      this.wpInstalledApllications.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.All;
      this.wpInstalledApllications.Size = new System.Drawing.Size(608, 283);
      this.wpInstalledApllications.TabIndex = 28;
      this.wpInstalledApllications.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpInstalledApllications_NextButtonClick);
      // 
      // groupBox18
      // 
      this.groupBox18.Controls.Add(this.lbNoteListOfInstalledSoftware);
      this.groupBox18.Controls.Add(this.lbNoteExlaintListOfInstalledSoftware);
      this.groupBox18.Controls.Add(this.label76);
      this.groupBox18.Controls.Add(this.label69);
      this.groupBox18.Controls.Add(this.pbInstalledSoftware6);
      this.groupBox18.Controls.Add(this.pbNotInstalled);
      this.groupBox18.Controls.Add(this.pbInstalled);
      this.groupBox18.Controls.Add(this.label112);
      this.groupBox18.Controls.Add(this.label113);
      this.groupBox18.Controls.Add(this.label121);
      this.groupBox18.Controls.Add(this.label122);
      this.groupBox18.Controls.Add(this.label124);
      this.groupBox18.Controls.Add(this.label125);
      this.groupBox18.Controls.Add(this.label126);
      this.groupBox18.Controls.Add(this.pbInstalledSoftware5);
      this.groupBox18.Controls.Add(this.pbInstalledSoftware4);
      this.groupBox18.Controls.Add(this.pbInstalledSoftware3);
      this.groupBox18.Controls.Add(this.pbInstalledSoftware2);
      this.groupBox18.Controls.Add(this.pbInstalledSoftware1);
      this.groupBox18.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox18.Location = new System.Drawing.Point(0, 0);
      this.groupBox18.Name = "groupBox18";
      this.groupBox18.Size = new System.Drawing.Size(608, 283);
      this.groupBox18.TabIndex = 33;
      this.groupBox18.TabStop = false;
      this.groupBox18.Text = "The following software has been found and can be configured:";
      // 
      // lbNoteListOfInstalledSoftware
      // 
      this.lbNoteListOfInstalledSoftware.AutoSize = true;
      this.lbNoteListOfInstalledSoftware.Location = new System.Drawing.Point(395, 35);
      this.lbNoteListOfInstalledSoftware.Name = "lbNoteListOfInstalledSoftware";
      this.lbNoteListOfInstalledSoftware.Size = new System.Drawing.Size(36, 13);
      this.lbNoteListOfInstalledSoftware.TabIndex = 56;
      this.lbNoteListOfInstalledSoftware.Text = "Note: ";
      // 
      // lbNoteExlaintListOfInstalledSoftware
      // 
      this.lbNoteExlaintListOfInstalledSoftware.Location = new System.Drawing.Point(408, 55);
      this.lbNoteExlaintListOfInstalledSoftware.Name = "lbNoteExlaintListOfInstalledSoftware";
      this.lbNoteExlaintListOfInstalledSoftware.Size = new System.Drawing.Size(155, 30);
      this.lbNoteExlaintListOfInstalledSoftware.TabIndex = 55;
      this.lbNoteExlaintListOfInstalledSoftware.Text = "IIS management functions will be disabled on Windows XP";
      // 
      // label76
      // 
      this.label76.AutoSize = true;
      this.label76.Location = new System.Drawing.Point(15, 207);
      this.label76.Name = "label76";
      this.label76.Size = new System.Drawing.Size(199, 13);
      this.label76.TabIndex = 54;
      this.label76.Text = "The following anti-virus program is found:";
      // 
      // label69
      // 
      this.label69.AutoSize = true;
      this.label69.Location = new System.Drawing.Point(40, 233);
      this.label69.Name = "label69";
      this.label69.Size = new System.Drawing.Size(146, 13);
      this.label69.TabIndex = 53;
      this.label69.Text = "McAfee Virus scan Enterprise";
      // 
      // pbInstalledSoftware6
      // 
      this.pbInstalledSoftware6.Location = new System.Drawing.Point(18, 233);
      this.pbInstalledSoftware6.Name = "pbInstalledSoftware6";
      this.pbInstalledSoftware6.Size = new System.Drawing.Size(16, 16);
      this.pbInstalledSoftware6.TabIndex = 52;
      this.pbInstalledSoftware6.TabStop = false;
      // 
      // pbNotInstalled
      // 
      this.pbNotInstalled.Location = new System.Drawing.Point(510, 264);
      this.pbNotInstalled.Name = "pbNotInstalled";
      this.pbNotInstalled.Size = new System.Drawing.Size(16, 16);
      this.pbNotInstalled.TabIndex = 49;
      this.pbNotInstalled.TabStop = false;
      // 
      // pbInstalled
      // 
      this.pbInstalled.Location = new System.Drawing.Point(510, 229);
      this.pbInstalled.Name = "pbInstalled";
      this.pbInstalled.Size = new System.Drawing.Size(16, 16);
      this.pbInstalled.TabIndex = 48;
      this.pbInstalled.TabStop = false;
      // 
      // label112
      // 
      this.label112.AutoSize = true;
      this.label112.Location = new System.Drawing.Point(525, 267);
      this.label112.Name = "label112";
      this.label112.Size = new System.Drawing.Size(77, 13);
      this.label112.TabIndex = 51;
      this.label112.Text = "= Not installed ";
      // 
      // label113
      // 
      this.label113.AutoSize = true;
      this.label113.Location = new System.Drawing.Point(525, 232);
      this.label113.Name = "label113";
      this.label113.Size = new System.Drawing.Size(58, 13);
      this.label113.TabIndex = 50;
      this.label113.Text = "= Installed ";
      // 
      // label121
      // 
      this.label121.AutoSize = true;
      this.label121.Location = new System.Drawing.Point(40, 38);
      this.label121.Name = "label121";
      this.label121.Size = new System.Drawing.Size(177, 13);
      this.label121.TabIndex = 46;
      this.label121.Text = "Microsoft Baseline Security Analyzer";
      // 
      // label122
      // 
      this.label122.AutoSize = true;
      this.label122.Location = new System.Drawing.Point(40, 177);
      this.label122.Name = "label122";
      this.label122.Size = new System.Drawing.Size(142, 13);
      this.label122.TabIndex = 45;
      this.label122.Text = "Internet Information Services";
      // 
      // label124
      // 
      this.label124.AutoSize = true;
      this.label124.Location = new System.Drawing.Point(40, 142);
      this.label124.Name = "label124";
      this.label124.Size = new System.Drawing.Size(108, 13);
      this.label124.TabIndex = 43;
      this.label124.Text = "Microsoft SQL Server";
      // 
      // label125
      // 
      this.label125.AutoSize = true;
      this.label125.Location = new System.Drawing.Point(40, 107);
      this.label125.Name = "label125";
      this.label125.Size = new System.Drawing.Size(57, 13);
      this.label125.TabIndex = 42;
      this.label125.Text = "BlockKeys";
      // 
      // label126
      // 
      this.label126.AutoSize = true;
      this.label126.Location = new System.Drawing.Point(40, 72);
      this.label126.Name = "label126";
      this.label126.Size = new System.Drawing.Size(116, 13);
      this.label126.TabIndex = 41;
      this.label126.Text = "Symantec pcAnywhere";
      // 
      // pbInstalledSoftware5
      // 
      this.pbInstalledSoftware5.Location = new System.Drawing.Point(18, 35);
      this.pbInstalledSoftware5.Name = "pbInstalledSoftware5";
      this.pbInstalledSoftware5.Size = new System.Drawing.Size(16, 16);
      this.pbInstalledSoftware5.TabIndex = 37;
      this.pbInstalledSoftware5.TabStop = false;
      // 
      // pbInstalledSoftware4
      // 
      this.pbInstalledSoftware4.Location = new System.Drawing.Point(18, 174);
      this.pbInstalledSoftware4.Name = "pbInstalledSoftware4";
      this.pbInstalledSoftware4.Size = new System.Drawing.Size(16, 16);
      this.pbInstalledSoftware4.TabIndex = 35;
      this.pbInstalledSoftware4.TabStop = false;
      // 
      // pbInstalledSoftware3
      // 
      this.pbInstalledSoftware3.Location = new System.Drawing.Point(18, 139);
      this.pbInstalledSoftware3.Name = "pbInstalledSoftware3";
      this.pbInstalledSoftware3.Size = new System.Drawing.Size(16, 16);
      this.pbInstalledSoftware3.TabIndex = 34;
      this.pbInstalledSoftware3.TabStop = false;
      // 
      // pbInstalledSoftware2
      // 
      this.pbInstalledSoftware2.Location = new System.Drawing.Point(18, 104);
      this.pbInstalledSoftware2.Name = "pbInstalledSoftware2";
      this.pbInstalledSoftware2.Size = new System.Drawing.Size(16, 16);
      this.pbInstalledSoftware2.TabIndex = 33;
      this.pbInstalledSoftware2.TabStop = false;
      // 
      // pbInstalledSoftware1
      // 
      this.pbInstalledSoftware1.Location = new System.Drawing.Point(18, 69);
      this.pbInstalledSoftware1.Name = "pbInstalledSoftware1";
      this.pbInstalledSoftware1.Size = new System.Drawing.Size(16, 16);
      this.pbInstalledSoftware1.TabIndex = 32;
      this.pbInstalledSoftware1.TabStop = false;
      // 
      // wpPasswordPolicy
      // 
      this.wpPasswordPolicy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpPasswordPolicy.AntiAlias = false;
      this.wpPasswordPolicy.BackColor = System.Drawing.Color.Transparent;
      this.wpPasswordPolicy.Controls.Add(this.groupBox1);
      this.wpPasswordPolicy.Location = new System.Drawing.Point(7, 72);
      this.wpPasswordPolicy.Name = "wpPasswordPolicy";
      this.wpPasswordPolicy.PageDescription = "Enter your password policy:";
      this.wpPasswordPolicy.PageTitle = "Password Policy";
      this.wpPasswordPolicy.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.Security;
      this.wpPasswordPolicy.Size = new System.Drawing.Size(608, 283);
      this.wpPasswordPolicy.TabIndex = 32;
      this.wpPasswordPolicy.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpPasswordPolicy_NextButtonClick);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btGetCurrentPasswordPolicies);
      this.groupBox1.Controls.Add(this.tbCurrentNoOfSavedPw);
      this.groupBox1.Controls.Add(this.tbCurrentMinimumPwLength);
      this.groupBox1.Controls.Add(this.tbCurrentMinimumPwAge);
      this.groupBox1.Controls.Add(this.tbCurrentMaximumPwAge);
      this.groupBox1.Controls.Add(this.cbCurrentEncryptionPW);
      this.groupBox1.Controls.Add(this.cbCurrentComplexityPW);
      this.groupBox1.Controls.Add(this.label129);
      this.groupBox1.Controls.Add(this.label128);
      this.groupBox1.Controls.Add(this.label106);
      this.groupBox1.Controls.Add(this.label108);
      this.groupBox1.Controls.Add(this.label109);
      this.groupBox1.Controls.Add(this.label127);
      this.groupBox1.Controls.Add(this.ttPasswordEncryption);
      this.groupBox1.Controls.Add(this.ttPasswordComplexity);
      this.groupBox1.Controls.Add(this.cbEncryptionPW);
      this.groupBox1.Controls.Add(this.label56);
      this.groupBox1.Controls.Add(this.cbComplexityPW);
      this.groupBox1.Controls.Add(this.label57);
      this.groupBox1.Controls.Add(this.label58);
      this.groupBox1.Controls.Add(this.label59);
      this.groupBox1.Controls.Add(this.nudNrOfRememberedPasw);
      this.groupBox1.Controls.Add(this.label60);
      this.groupBox1.Controls.Add(this.label61);
      this.groupBox1.Controls.Add(this.nudMinPaswordlength);
      this.groupBox1.Controls.Add(this.label62);
      this.groupBox1.Controls.Add(this.label63);
      this.groupBox1.Controls.Add(this.nudMinPaswordTime);
      this.groupBox1.Controls.Add(this.label64);
      this.groupBox1.Controls.Add(this.label65);
      this.groupBox1.Controls.Add(this.nudMaxPaswordTime);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(608, 283);
      this.groupBox1.TabIndex = 8;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Windows Password Policy";
      // 
      // btGetCurrentPasswordPolicies
      // 
      this.btGetCurrentPasswordPolicies.Location = new System.Drawing.Point(519, 224);
      this.btGetCurrentPasswordPolicies.Name = "btGetCurrentPasswordPolicies";
      this.btGetCurrentPasswordPolicies.Size = new System.Drawing.Size(67, 27);
      this.btGetCurrentPasswordPolicies.TabIndex = 54;
      this.btGetCurrentPasswordPolicies.Text = "Current";
      this.btGetCurrentPasswordPolicies.UseVisualStyleBackColor = true;
      this.btGetCurrentPasswordPolicies.Click += new System.EventHandler(this.btGetCurrentPasswordPolicies_Click);
      // 
      // tbCurrentNoOfSavedPw
      // 
      this.tbCurrentNoOfSavedPw.Location = new System.Drawing.Point(263, 134);
      this.tbCurrentNoOfSavedPw.Name = "tbCurrentNoOfSavedPw";
      this.tbCurrentNoOfSavedPw.ReadOnly = true;
      this.tbCurrentNoOfSavedPw.Size = new System.Drawing.Size(33, 20);
      this.tbCurrentNoOfSavedPw.TabIndex = 53;
      // 
      // tbCurrentMinimumPwLength
      // 
      this.tbCurrentMinimumPwLength.Location = new System.Drawing.Point(263, 108);
      this.tbCurrentMinimumPwLength.Name = "tbCurrentMinimumPwLength";
      this.tbCurrentMinimumPwLength.ReadOnly = true;
      this.tbCurrentMinimumPwLength.Size = new System.Drawing.Size(33, 20);
      this.tbCurrentMinimumPwLength.TabIndex = 52;
      // 
      // tbCurrentMinimumPwAge
      // 
      this.tbCurrentMinimumPwAge.Location = new System.Drawing.Point(263, 83);
      this.tbCurrentMinimumPwAge.Name = "tbCurrentMinimumPwAge";
      this.tbCurrentMinimumPwAge.ReadOnly = true;
      this.tbCurrentMinimumPwAge.Size = new System.Drawing.Size(33, 20);
      this.tbCurrentMinimumPwAge.TabIndex = 51;
      // 
      // tbCurrentMaximumPwAge
      // 
      this.tbCurrentMaximumPwAge.Location = new System.Drawing.Point(263, 58);
      this.tbCurrentMaximumPwAge.Name = "tbCurrentMaximumPwAge";
      this.tbCurrentMaximumPwAge.ReadOnly = true;
      this.tbCurrentMaximumPwAge.Size = new System.Drawing.Size(33, 20);
      this.tbCurrentMaximumPwAge.TabIndex = 50;
      // 
      // cbCurrentEncryptionPW
      // 
      this.cbCurrentEncryptionPW.Enabled = false;
      this.cbCurrentEncryptionPW.FormattingEnabled = true;
      this.cbCurrentEncryptionPW.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
      this.cbCurrentEncryptionPW.Location = new System.Drawing.Point(254, 224);
      this.cbCurrentEncryptionPW.Name = "cbCurrentEncryptionPW";
      this.cbCurrentEncryptionPW.Size = new System.Drawing.Size(65, 21);
      this.cbCurrentEncryptionPW.TabIndex = 49;
      this.cbCurrentEncryptionPW.Text = "Disabled";
      // 
      // cbCurrentComplexityPW
      // 
      this.cbCurrentComplexityPW.Enabled = false;
      this.cbCurrentComplexityPW.FormattingEnabled = true;
      this.cbCurrentComplexityPW.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
      this.cbCurrentComplexityPW.Location = new System.Drawing.Point(254, 186);
      this.cbCurrentComplexityPW.Name = "cbCurrentComplexityPW";
      this.cbCurrentComplexityPW.Size = new System.Drawing.Size(65, 21);
      this.cbCurrentComplexityPW.TabIndex = 48;
      this.cbCurrentComplexityPW.Text = "Disabled";
      // 
      // label129
      // 
      this.label129.AutoSize = true;
      this.label129.Location = new System.Drawing.Point(385, 28);
      this.label129.Name = "label129";
      this.label129.Size = new System.Drawing.Size(88, 13);
      this.label129.TabIndex = 47;
      this.label129.Text = "Prefered Settings";
      // 
      // label128
      // 
      this.label128.AutoSize = true;
      this.label128.Location = new System.Drawing.Point(250, 28);
      this.label128.Name = "label128";
      this.label128.Size = new System.Drawing.Size(82, 13);
      this.label128.TabIndex = 46;
      this.label128.Text = "Current Settings";
      // 
      // label106
      // 
      this.label106.AutoSize = true;
      this.label106.Location = new System.Drawing.Point(302, 139);
      this.label106.Name = "label106";
      this.label106.Size = new System.Drawing.Size(63, 13);
      this.label106.TabIndex = 45;
      this.label106.Text = "password(s)";
      // 
      // label108
      // 
      this.label108.AutoSize = true;
      this.label108.Location = new System.Drawing.Point(302, 112);
      this.label108.Name = "label108";
      this.label108.Size = new System.Drawing.Size(57, 13);
      this.label108.TabIndex = 44;
      this.label108.Text = "characters";
      // 
      // label109
      // 
      this.label109.AutoSize = true;
      this.label109.Location = new System.Drawing.Point(302, 86);
      this.label109.Name = "label109";
      this.label109.Size = new System.Drawing.Size(31, 13);
      this.label109.TabIndex = 43;
      this.label109.Text = "Days";
      // 
      // label127
      // 
      this.label127.AutoSize = true;
      this.label127.Location = new System.Drawing.Point(302, 60);
      this.label127.Name = "label127";
      this.label127.Size = new System.Drawing.Size(29, 13);
      this.label127.TabIndex = 42;
      this.label127.Text = "days";
      // 
      // ttPasswordEncryption
      // 
      this.ttPasswordEncryption.Image = ((System.Drawing.Image)(resources.GetObject("ttPasswordEncryption.Image")));
      this.ttPasswordEncryption.Location = new System.Drawing.Point(18, 231);
      this.ttPasswordEncryption.Name = "ttPasswordEncryption";
      this.ttPasswordEncryption.Size = new System.Drawing.Size(16, 16);
      this.ttPasswordEncryption.TabIndex = 37;
      this.ttPasswordEncryption.TabStop = false;
      this.ttPasswordEncryption.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // ttPasswordComplexity
      // 
      this.ttPasswordComplexity.Image = ((System.Drawing.Image)(resources.GetObject("ttPasswordComplexity.Image")));
      this.ttPasswordComplexity.Location = new System.Drawing.Point(20, 190);
      this.ttPasswordComplexity.Name = "ttPasswordComplexity";
      this.ttPasswordComplexity.Size = new System.Drawing.Size(16, 16);
      this.ttPasswordComplexity.TabIndex = 36;
      this.ttPasswordComplexity.TabStop = false;
      this.ttPasswordComplexity.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // cbEncryptionPW
      // 
      this.cbEncryptionPW.FormattingEnabled = true;
      this.cbEncryptionPW.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
      this.cbEncryptionPW.Location = new System.Drawing.Point(388, 224);
      this.cbEncryptionPW.Name = "cbEncryptionPW";
      this.cbEncryptionPW.Size = new System.Drawing.Size(65, 21);
      this.cbEncryptionPW.TabIndex = 7;
      this.cbEncryptionPW.Text = "Disabled";
      // 
      // label56
      // 
      this.label56.AutoSize = true;
      this.label56.Location = new System.Drawing.Point(42, 234);
      this.label56.Name = "label56";
      this.label56.Size = new System.Drawing.Size(208, 13);
      this.label56.TabIndex = 31;
      this.label56.Text = "Store password using reversible encryption";
      // 
      // cbComplexityPW
      // 
      this.cbComplexityPW.FormattingEnabled = true;
      this.cbComplexityPW.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
      this.cbComplexityPW.Location = new System.Drawing.Point(388, 186);
      this.cbComplexityPW.Name = "cbComplexityPW";
      this.cbComplexityPW.Size = new System.Drawing.Size(65, 21);
      this.cbComplexityPW.TabIndex = 6;
      this.cbComplexityPW.Text = "Enabled";
      // 
      // label57
      // 
      this.label57.Location = new System.Drawing.Point(42, 189);
      this.label57.Name = "label57";
      this.label57.Size = new System.Drawing.Size(185, 39);
      this.label57.TabIndex = 29;
      this.label57.Text = "Passwords comply with  complexity requirements";
      // 
      // label58
      // 
      this.label58.AutoSize = true;
      this.label58.Location = new System.Drawing.Point(436, 143);
      this.label58.Name = "label58";
      this.label58.Size = new System.Drawing.Size(63, 13);
      this.label58.TabIndex = 28;
      this.label58.Text = "password(s)";
      // 
      // label59
      // 
      this.label59.AutoSize = true;
      this.label59.Location = new System.Drawing.Point(42, 138);
      this.label59.Name = "label59";
      this.label59.Size = new System.Drawing.Size(120, 26);
      this.label59.TabIndex = 27;
      this.label59.Text = "Number of remembered \npasswords.";
      // 
      // nudNrOfRememberedPasw
      // 
      this.nudNrOfRememberedPasw.BackColor = System.Drawing.Color.White;
      this.nudNrOfRememberedPasw.Location = new System.Drawing.Point(387, 139);
      this.nudNrOfRememberedPasw.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
      this.nudNrOfRememberedPasw.Name = "nudNrOfRememberedPasw";
      this.nudNrOfRememberedPasw.ReadOnly = true;
      this.nudNrOfRememberedPasw.Size = new System.Drawing.Size(43, 20);
      this.nudNrOfRememberedPasw.TabIndex = 5;
      // 
      // label60
      // 
      this.label60.AutoSize = true;
      this.label60.Location = new System.Drawing.Point(436, 113);
      this.label60.Name = "label60";
      this.label60.Size = new System.Drawing.Size(57, 13);
      this.label60.TabIndex = 25;
      this.label60.Text = "characters";
      // 
      // label61
      // 
      this.label61.AutoSize = true;
      this.label61.Location = new System.Drawing.Point(42, 110);
      this.label61.Name = "label61";
      this.label61.Size = new System.Drawing.Size(128, 13);
      this.label61.TabIndex = 24;
      this.label61.Text = "Minimum password length";
      // 
      // nudMinPaswordlength
      // 
      this.nudMinPaswordlength.BackColor = System.Drawing.Color.White;
      this.nudMinPaswordlength.Location = new System.Drawing.Point(387, 109);
      this.nudMinPaswordlength.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
      this.nudMinPaswordlength.Name = "nudMinPaswordlength";
      this.nudMinPaswordlength.ReadOnly = true;
      this.nudMinPaswordlength.Size = new System.Drawing.Size(43, 20);
      this.nudMinPaswordlength.TabIndex = 4;
      this.nudMinPaswordlength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
      // 
      // label62
      // 
      this.label62.AutoSize = true;
      this.label62.Location = new System.Drawing.Point(436, 87);
      this.label62.Name = "label62";
      this.label62.Size = new System.Drawing.Size(31, 13);
      this.label62.TabIndex = 22;
      this.label62.Text = "Days";
      // 
      // label63
      // 
      this.label63.AutoSize = true;
      this.label63.Location = new System.Drawing.Point(42, 84);
      this.label63.Name = "label63";
      this.label63.Size = new System.Drawing.Size(117, 13);
      this.label63.TabIndex = 21;
      this.label63.Text = "Minimum password age";
      // 
      // nudMinPaswordTime
      // 
      this.nudMinPaswordTime.BackColor = System.Drawing.Color.White;
      this.nudMinPaswordTime.Location = new System.Drawing.Point(387, 83);
      this.nudMinPaswordTime.Maximum = new decimal(new int[] {
            998,
            0,
            0,
            0});
      this.nudMinPaswordTime.Name = "nudMinPaswordTime";
      this.nudMinPaswordTime.ReadOnly = true;
      this.nudMinPaswordTime.Size = new System.Drawing.Size(43, 20);
      this.nudMinPaswordTime.TabIndex = 3;
      // 
      // label64
      // 
      this.label64.AutoSize = true;
      this.label64.Location = new System.Drawing.Point(436, 61);
      this.label64.Name = "label64";
      this.label64.Size = new System.Drawing.Size(29, 13);
      this.label64.TabIndex = 19;
      this.label64.Text = "days";
      // 
      // label65
      // 
      this.label65.AutoSize = true;
      this.label65.Location = new System.Drawing.Point(42, 58);
      this.label65.Name = "label65";
      this.label65.Size = new System.Drawing.Size(120, 13);
      this.label65.TabIndex = 18;
      this.label65.Text = "Maximum password age";
      // 
      // nudMaxPaswordTime
      // 
      this.nudMaxPaswordTime.BackColor = System.Drawing.Color.White;
      this.nudMaxPaswordTime.Location = new System.Drawing.Point(387, 57);
      this.nudMaxPaswordTime.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.nudMaxPaswordTime.Name = "nudMaxPaswordTime";
      this.nudMaxPaswordTime.ReadOnly = true;
      this.nudMaxPaswordTime.Size = new System.Drawing.Size(43, 20);
      this.nudMaxPaswordTime.TabIndex = 2;
      this.nudMaxPaswordTime.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
      // 
      // wpControlPolicy
      // 
      this.wpControlPolicy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpControlPolicy.AntiAlias = false;
      this.wpControlPolicy.BackColor = System.Drawing.Color.Transparent;
      this.wpControlPolicy.Controls.Add(this.gbControlPolicy);
      this.wpControlPolicy.Location = new System.Drawing.Point(7, 72);
      this.wpControlPolicy.Name = "wpControlPolicy";
      this.wpControlPolicy.PageDescription = "Enter your audit policy";
      this.wpControlPolicy.PageTitle = "Audit Policy";
      this.wpControlPolicy.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.Security;
      this.wpControlPolicy.Size = new System.Drawing.Size(608, 283);
      this.wpControlPolicy.TabIndex = 10;
      this.wpControlPolicy.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpControlPolicy_NextButtonClick);
      // 
      // gbControlPolicy
      // 
      this.gbControlPolicy.Controls.Add(this.tbAuditSystemEvents);
      this.gbControlPolicy.Controls.Add(this.tbAuditProcessTracking);
      this.gbControlPolicy.Controls.Add(this.tbAuditPrivilegeUse);
      this.gbControlPolicy.Controls.Add(this.tbAuditPolicyChange);
      this.gbControlPolicy.Controls.Add(this.tbAuditObjectAccess);
      this.gbControlPolicy.Controls.Add(this.tbAuditLogEvents);
      this.gbControlPolicy.Controls.Add(this.tbAuditDirSerAccess);
      this.gbControlPolicy.Controls.Add(this.tbAuditAccManage);
      this.gbControlPolicy.Controls.Add(this.tbAuditAccLogEvents);
      this.gbControlPolicy.Controls.Add(this.btGetAllCurrentAuditPolicies);
      this.gbControlPolicy.Controls.Add(this.label105);
      this.gbControlPolicy.Controls.Add(this.ttAuditSytemEvents);
      this.gbControlPolicy.Controls.Add(this.ttAuditProcessTracking);
      this.gbControlPolicy.Controls.Add(this.ttAuditObjectAcces);
      this.gbControlPolicy.Controls.Add(this.ttAuditPrivilegeUse);
      this.gbControlPolicy.Controls.Add(this.ttAuditPolicyChange);
      this.gbControlPolicy.Controls.Add(this.tbControlPolicy9);
      this.gbControlPolicy.Controls.Add(this.ttAuditActiveDirectoryAcces);
      this.gbControlPolicy.Controls.Add(this.tbControlPolicy8);
      this.gbControlPolicy.Controls.Add(this.ttAuditAccountManagement);
      this.gbControlPolicy.Controls.Add(this.tbControlPolicy6);
      this.gbControlPolicy.Controls.Add(this.ttAuditAccountLogon);
      this.gbControlPolicy.Controls.Add(this.tbControlPolicy5);
      this.gbControlPolicy.Controls.Add(this.ttAuditLogonEvents);
      this.gbControlPolicy.Controls.Add(this.tbControlPolicy3);
      this.gbControlPolicy.Controls.Add(this.tbControlPolicy2);
      this.gbControlPolicy.Controls.Add(this.tbControlPolicy1);
      this.gbControlPolicy.Controls.Add(this.label46);
      this.gbControlPolicy.Controls.Add(this.label47);
      this.gbControlPolicy.Controls.Add(this.label48);
      this.gbControlPolicy.Controls.Add(this.label49);
      this.gbControlPolicy.Controls.Add(this.label45);
      this.gbControlPolicy.Controls.Add(this.label44);
      this.gbControlPolicy.Controls.Add(this.label43);
      this.gbControlPolicy.Controls.Add(this.label42);
      this.gbControlPolicy.Controls.Add(this.label41);
      this.gbControlPolicy.Controls.Add(this.tbControlPolicy7);
      this.gbControlPolicy.Controls.Add(this.lbAuditPolicyNotStandard);
      this.gbControlPolicy.Controls.Add(this.tbControlPolicy4);
      this.gbControlPolicy.Controls.Add(this.combControlPolicy9);
      this.gbControlPolicy.Controls.Add(this.label13);
      this.gbControlPolicy.Controls.Add(this.label19);
      this.gbControlPolicy.Controls.Add(this.label12);
      this.gbControlPolicy.Controls.Add(this.combControlPolicy8);
      this.gbControlPolicy.Controls.Add(this.combControlPolicy1);
      this.gbControlPolicy.Controls.Add(this.label20);
      this.gbControlPolicy.Controls.Add(this.label14);
      this.gbControlPolicy.Controls.Add(this.combControlPolicy7);
      this.gbControlPolicy.Controls.Add(this.combControlPolicy2);
      this.gbControlPolicy.Controls.Add(this.label21);
      this.gbControlPolicy.Controls.Add(this.label15);
      this.gbControlPolicy.Controls.Add(this.combControlPolicy6);
      this.gbControlPolicy.Controls.Add(this.combControlPolicy3);
      this.gbControlPolicy.Controls.Add(this.label16);
      this.gbControlPolicy.Controls.Add(this.label18);
      this.gbControlPolicy.Controls.Add(this.combControlPolicy5);
      this.gbControlPolicy.Controls.Add(this.combControlPolicy4);
      this.gbControlPolicy.Controls.Add(this.label17);
      this.gbControlPolicy.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gbControlPolicy.Location = new System.Drawing.Point(0, 0);
      this.gbControlPolicy.Name = "gbControlPolicy";
      this.gbControlPolicy.Size = new System.Drawing.Size(608, 283);
      this.gbControlPolicy.TabIndex = 6;
      this.gbControlPolicy.TabStop = false;
      this.gbControlPolicy.Text = "Windows Audit Policy";
      // 
      // tbAuditSystemEvents
      // 
      this.tbAuditSystemEvents.Location = new System.Drawing.Point(197, 255);
      this.tbAuditSystemEvents.Name = "tbAuditSystemEvents";
      this.tbAuditSystemEvents.Size = new System.Drawing.Size(106, 20);
      this.tbAuditSystemEvents.TabIndex = 96;
      // 
      // tbAuditProcessTracking
      // 
      this.tbAuditProcessTracking.Location = new System.Drawing.Point(197, 230);
      this.tbAuditProcessTracking.Name = "tbAuditProcessTracking";
      this.tbAuditProcessTracking.Size = new System.Drawing.Size(106, 20);
      this.tbAuditProcessTracking.TabIndex = 95;
      // 
      // tbAuditPrivilegeUse
      // 
      this.tbAuditPrivilegeUse.Location = new System.Drawing.Point(197, 204);
      this.tbAuditPrivilegeUse.Name = "tbAuditPrivilegeUse";
      this.tbAuditPrivilegeUse.Size = new System.Drawing.Size(106, 20);
      this.tbAuditPrivilegeUse.TabIndex = 94;
      // 
      // tbAuditPolicyChange
      // 
      this.tbAuditPolicyChange.Location = new System.Drawing.Point(197, 179);
      this.tbAuditPolicyChange.Name = "tbAuditPolicyChange";
      this.tbAuditPolicyChange.Size = new System.Drawing.Size(106, 20);
      this.tbAuditPolicyChange.TabIndex = 93;
      // 
      // tbAuditObjectAccess
      // 
      this.tbAuditObjectAccess.Location = new System.Drawing.Point(197, 154);
      this.tbAuditObjectAccess.Name = "tbAuditObjectAccess";
      this.tbAuditObjectAccess.Size = new System.Drawing.Size(106, 20);
      this.tbAuditObjectAccess.TabIndex = 92;
      // 
      // tbAuditLogEvents
      // 
      this.tbAuditLogEvents.Location = new System.Drawing.Point(197, 128);
      this.tbAuditLogEvents.Name = "tbAuditLogEvents";
      this.tbAuditLogEvents.Size = new System.Drawing.Size(106, 20);
      this.tbAuditLogEvents.TabIndex = 91;
      // 
      // tbAuditDirSerAccess
      // 
      this.tbAuditDirSerAccess.Location = new System.Drawing.Point(197, 104);
      this.tbAuditDirSerAccess.Name = "tbAuditDirSerAccess";
      this.tbAuditDirSerAccess.Size = new System.Drawing.Size(106, 20);
      this.tbAuditDirSerAccess.TabIndex = 90;
      // 
      // tbAuditAccManage
      // 
      this.tbAuditAccManage.Location = new System.Drawing.Point(197, 78);
      this.tbAuditAccManage.Name = "tbAuditAccManage";
      this.tbAuditAccManage.Size = new System.Drawing.Size(106, 20);
      this.tbAuditAccManage.TabIndex = 89;
      // 
      // tbAuditAccLogEvents
      // 
      this.tbAuditAccLogEvents.Location = new System.Drawing.Point(197, 53);
      this.tbAuditAccLogEvents.Name = "tbAuditAccLogEvents";
      this.tbAuditAccLogEvents.Size = new System.Drawing.Size(106, 20);
      this.tbAuditAccLogEvents.TabIndex = 88;
      // 
      // btGetAllCurrentAuditPolicies
      // 
      this.btGetAllCurrentAuditPolicies.Location = new System.Drawing.Point(209, 20);
      this.btGetAllCurrentAuditPolicies.Name = "btGetAllCurrentAuditPolicies";
      this.btGetAllCurrentAuditPolicies.Size = new System.Drawing.Size(75, 23);
      this.btGetAllCurrentAuditPolicies.TabIndex = 43;
      this.btGetAllCurrentAuditPolicies.Text = "Current";
      this.btGetAllCurrentAuditPolicies.UseVisualStyleBackColor = true;
      this.btGetAllCurrentAuditPolicies.Click += new System.EventHandler(this.btGetAllCurrentAuditPolicies_Click);
      // 
      // label105
      // 
      this.label105.AutoSize = true;
      this.label105.Location = new System.Drawing.Point(337, 30);
      this.label105.Name = "label105";
      this.label105.Size = new System.Drawing.Size(123, 13);
      this.label105.TabIndex = 87;
      this.label105.Text = "Recommended Settings:";
      // 
      // ttAuditSytemEvents
      // 
      this.ttAuditSytemEvents.Image = ((System.Drawing.Image)(resources.GetObject("ttAuditSytemEvents.Image")));
      this.ttAuditSytemEvents.Location = new System.Drawing.Point(23, 258);
      this.ttAuditSytemEvents.Name = "ttAuditSytemEvents";
      this.ttAuditSytemEvents.Size = new System.Drawing.Size(16, 16);
      this.ttAuditSytemEvents.TabIndex = 75;
      this.ttAuditSytemEvents.TabStop = false;
      this.ttAuditSytemEvents.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // ttAuditProcessTracking
      // 
      this.ttAuditProcessTracking.Image = ((System.Drawing.Image)(resources.GetObject("ttAuditProcessTracking.Image")));
      this.ttAuditProcessTracking.Location = new System.Drawing.Point(23, 233);
      this.ttAuditProcessTracking.Name = "ttAuditProcessTracking";
      this.ttAuditProcessTracking.Size = new System.Drawing.Size(16, 16);
      this.ttAuditProcessTracking.TabIndex = 76;
      this.ttAuditProcessTracking.TabStop = false;
      this.ttAuditProcessTracking.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // ttAuditObjectAcces
      // 
      this.ttAuditObjectAcces.Image = ((System.Drawing.Image)(resources.GetObject("ttAuditObjectAcces.Image")));
      this.ttAuditObjectAcces.Location = new System.Drawing.Point(23, 155);
      this.ttAuditObjectAcces.Name = "ttAuditObjectAcces";
      this.ttAuditObjectAcces.Size = new System.Drawing.Size(16, 16);
      this.ttAuditObjectAcces.TabIndex = 74;
      this.ttAuditObjectAcces.TabStop = false;
      this.ttAuditObjectAcces.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // ttAuditPrivilegeUse
      // 
      this.ttAuditPrivilegeUse.Image = ((System.Drawing.Image)(resources.GetObject("ttAuditPrivilegeUse.Image")));
      this.ttAuditPrivilegeUse.Location = new System.Drawing.Point(23, 207);
      this.ttAuditPrivilegeUse.Name = "ttAuditPrivilegeUse";
      this.ttAuditPrivilegeUse.Size = new System.Drawing.Size(16, 16);
      this.ttAuditPrivilegeUse.TabIndex = 43;
      this.ttAuditPrivilegeUse.TabStop = false;
      this.ttAuditPrivilegeUse.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // ttAuditPolicyChange
      // 
      this.ttAuditPolicyChange.Image = ((System.Drawing.Image)(resources.GetObject("ttAuditPolicyChange.Image")));
      this.ttAuditPolicyChange.Location = new System.Drawing.Point(23, 182);
      this.ttAuditPolicyChange.Name = "ttAuditPolicyChange";
      this.ttAuditPolicyChange.Size = new System.Drawing.Size(16, 16);
      this.ttAuditPolicyChange.TabIndex = 42;
      this.ttAuditPolicyChange.TabStop = false;
      this.ttAuditPolicyChange.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // tbControlPolicy9
      // 
      this.tbControlPolicy9.Location = new System.Drawing.Point(496, 255);
      this.tbControlPolicy9.Name = "tbControlPolicy9";
      this.tbControlPolicy9.Size = new System.Drawing.Size(106, 20);
      this.tbControlPolicy9.TabIndex = 19;
      this.tbControlPolicy9.Visible = false;
      // 
      // ttAuditActiveDirectoryAcces
      // 
      this.ttAuditActiveDirectoryAcces.Image = ((System.Drawing.Image)(resources.GetObject("ttAuditActiveDirectoryAcces.Image")));
      this.ttAuditActiveDirectoryAcces.Location = new System.Drawing.Point(23, 106);
      this.ttAuditActiveDirectoryAcces.Name = "ttAuditActiveDirectoryAcces";
      this.ttAuditActiveDirectoryAcces.Size = new System.Drawing.Size(16, 16);
      this.ttAuditActiveDirectoryAcces.TabIndex = 41;
      this.ttAuditActiveDirectoryAcces.TabStop = false;
      this.ttAuditActiveDirectoryAcces.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // tbControlPolicy8
      // 
      this.tbControlPolicy8.Location = new System.Drawing.Point(496, 229);
      this.tbControlPolicy8.Name = "tbControlPolicy8";
      this.tbControlPolicy8.Size = new System.Drawing.Size(106, 20);
      this.tbControlPolicy8.TabIndex = 18;
      this.tbControlPolicy8.Visible = false;
      // 
      // ttAuditAccountManagement
      // 
      this.ttAuditAccountManagement.Image = ((System.Drawing.Image)(resources.GetObject("ttAuditAccountManagement.Image")));
      this.ttAuditAccountManagement.Location = new System.Drawing.Point(23, 81);
      this.ttAuditAccountManagement.Name = "ttAuditAccountManagement";
      this.ttAuditAccountManagement.Size = new System.Drawing.Size(16, 16);
      this.ttAuditAccountManagement.TabIndex = 40;
      this.ttAuditAccountManagement.TabStop = false;
      this.ttAuditAccountManagement.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // tbControlPolicy6
      // 
      this.tbControlPolicy6.Location = new System.Drawing.Point(496, 202);
      this.tbControlPolicy6.Name = "tbControlPolicy6";
      this.tbControlPolicy6.Size = new System.Drawing.Size(106, 20);
      this.tbControlPolicy6.TabIndex = 16;
      this.tbControlPolicy6.Visible = false;
      // 
      // ttAuditAccountLogon
      // 
      this.ttAuditAccountLogon.Image = ((System.Drawing.Image)(resources.GetObject("ttAuditAccountLogon.Image")));
      this.ttAuditAccountLogon.Location = new System.Drawing.Point(23, 56);
      this.ttAuditAccountLogon.Name = "ttAuditAccountLogon";
      this.ttAuditAccountLogon.Size = new System.Drawing.Size(16, 16);
      this.ttAuditAccountLogon.TabIndex = 39;
      this.ttAuditAccountLogon.TabStop = false;
      this.ttAuditAccountLogon.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // tbControlPolicy5
      // 
      this.tbControlPolicy5.Location = new System.Drawing.Point(496, 177);
      this.tbControlPolicy5.Name = "tbControlPolicy5";
      this.tbControlPolicy5.Size = new System.Drawing.Size(106, 20);
      this.tbControlPolicy5.TabIndex = 15;
      this.tbControlPolicy5.Visible = false;
      // 
      // ttAuditLogonEvents
      // 
      this.ttAuditLogonEvents.Image = ((System.Drawing.Image)(resources.GetObject("ttAuditLogonEvents.Image")));
      this.ttAuditLogonEvents.Location = new System.Drawing.Point(23, 130);
      this.ttAuditLogonEvents.Name = "ttAuditLogonEvents";
      this.ttAuditLogonEvents.Size = new System.Drawing.Size(16, 16);
      this.ttAuditLogonEvents.TabIndex = 38;
      this.ttAuditLogonEvents.TabStop = false;
      this.ttAuditLogonEvents.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // tbControlPolicy3
      // 
      this.tbControlPolicy3.Location = new System.Drawing.Point(496, 76);
      this.tbControlPolicy3.Name = "tbControlPolicy3";
      this.tbControlPolicy3.Size = new System.Drawing.Size(106, 20);
      this.tbControlPolicy3.TabIndex = 13;
      this.tbControlPolicy3.Visible = false;
      // 
      // tbControlPolicy2
      // 
      this.tbControlPolicy2.Location = new System.Drawing.Point(496, 52);
      this.tbControlPolicy2.Name = "tbControlPolicy2";
      this.tbControlPolicy2.Size = new System.Drawing.Size(106, 20);
      this.tbControlPolicy2.TabIndex = 12;
      this.tbControlPolicy2.Visible = false;
      // 
      // tbControlPolicy1
      // 
      this.tbControlPolicy1.Location = new System.Drawing.Point(496, 127);
      this.tbControlPolicy1.Name = "tbControlPolicy1";
      this.tbControlPolicy1.Size = new System.Drawing.Size(106, 20);
      this.tbControlPolicy1.TabIndex = 11;
      this.tbControlPolicy1.Visible = false;
      // 
      // label46
      // 
      this.label46.AutoSize = true;
      this.label46.Location = new System.Drawing.Point(478, 230);
      this.label46.Name = "label46";
      this.label46.Size = new System.Drawing.Size(13, 13);
      this.label46.TabIndex = 66;
      this.label46.Text = "8";
      this.label46.Visible = false;
      // 
      // label47
      // 
      this.label47.AutoSize = true;
      this.label47.Location = new System.Drawing.Point(478, 156);
      this.label47.Name = "label47";
      this.label47.Size = new System.Drawing.Size(13, 13);
      this.label47.TabIndex = 65;
      this.label47.Text = "5";
      this.label47.Visible = false;
      // 
      // label48
      // 
      this.label48.AutoSize = true;
      this.label48.Location = new System.Drawing.Point(478, 205);
      this.label48.Name = "label48";
      this.label48.Size = new System.Drawing.Size(13, 13);
      this.label48.TabIndex = 64;
      this.label48.Text = "7";
      this.label48.Visible = false;
      // 
      // label49
      // 
      this.label49.AutoSize = true;
      this.label49.Location = new System.Drawing.Point(478, 180);
      this.label49.Name = "label49";
      this.label49.Size = new System.Drawing.Size(13, 13);
      this.label49.TabIndex = 63;
      this.label49.Text = "6";
      this.label49.Visible = false;
      // 
      // label45
      // 
      this.label45.AutoSize = true;
      this.label45.Location = new System.Drawing.Point(479, 259);
      this.label45.Name = "label45";
      this.label45.Size = new System.Drawing.Size(13, 13);
      this.label45.TabIndex = 62;
      this.label45.Text = "9";
      this.label45.Visible = false;
      // 
      // label44
      // 
      this.label44.AutoSize = true;
      this.label44.Location = new System.Drawing.Point(478, 104);
      this.label44.Name = "label44";
      this.label44.Size = new System.Drawing.Size(13, 13);
      this.label44.TabIndex = 61;
      this.label44.Text = "3";
      this.label44.Visible = false;
      // 
      // label43
      // 
      this.label43.AutoSize = true;
      this.label43.Location = new System.Drawing.Point(478, 79);
      this.label43.Name = "label43";
      this.label43.Size = new System.Drawing.Size(13, 13);
      this.label43.TabIndex = 60;
      this.label43.Text = "2";
      this.label43.Visible = false;
      // 
      // label42
      // 
      this.label42.AutoSize = true;
      this.label42.Location = new System.Drawing.Point(478, 54);
      this.label42.Name = "label42";
      this.label42.Size = new System.Drawing.Size(13, 13);
      this.label42.TabIndex = 59;
      this.label42.Text = "1";
      this.label42.Visible = false;
      // 
      // label41
      // 
      this.label41.AutoSize = true;
      this.label41.Location = new System.Drawing.Point(478, 129);
      this.label41.Name = "label41";
      this.label41.Size = new System.Drawing.Size(13, 13);
      this.label41.TabIndex = 58;
      this.label41.Text = "4";
      this.label41.Visible = false;
      // 
      // tbControlPolicy7
      // 
      this.tbControlPolicy7.Location = new System.Drawing.Point(496, 152);
      this.tbControlPolicy7.Name = "tbControlPolicy7";
      this.tbControlPolicy7.Size = new System.Drawing.Size(106, 20);
      this.tbControlPolicy7.TabIndex = 17;
      this.tbControlPolicy7.Visible = false;
      // 
      // lbAuditPolicyNotStandard
      // 
      this.lbAuditPolicyNotStandard.AutoSize = true;
      this.lbAuditPolicyNotStandard.Location = new System.Drawing.Point(493, 30);
      this.lbAuditPolicyNotStandard.Name = "lbAuditPolicyNotStandard";
      this.lbAuditPolicyNotStandard.Size = new System.Drawing.Size(76, 13);
      this.lbAuditPolicyNotStandard.TabIndex = 56;
      this.lbAuditPolicyNotStandard.Text = "Give a reason:";
      this.lbAuditPolicyNotStandard.Visible = false;
      // 
      // tbControlPolicy4
      // 
      this.tbControlPolicy4.Location = new System.Drawing.Point(496, 101);
      this.tbControlPolicy4.Name = "tbControlPolicy4";
      this.tbControlPolicy4.Size = new System.Drawing.Size(106, 20);
      this.tbControlPolicy4.TabIndex = 14;
      this.tbControlPolicy4.Visible = false;
      // 
      // combControlPolicy9
      // 
      this.combControlPolicy9.FormattingEnabled = true;
      this.combControlPolicy9.Items.AddRange(new object[] {
            "Not check",
            "Successful",
            "Failed",
            "Successful, Failed"});
      this.combControlPolicy9.Location = new System.Drawing.Point(340, 256);
      this.combControlPolicy9.Name = "combControlPolicy9";
      this.combControlPolicy9.Size = new System.Drawing.Size(127, 21);
      this.combControlPolicy9.TabIndex = 10;
      this.combControlPolicy9.Text = "Successful, Failed";
      this.combControlPolicy9.SelectedValueChanged += new System.EventHandler(this.combControlPolicyX_SelectedValueChanged);
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(42, 30);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(64, 13);
      this.label13.TabIndex = 38;
      this.label13.Text = "Check from:";
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Location = new System.Drawing.Point(42, 258);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(101, 13);
      this.label19.TabIndex = 53;
      this.label19.Text = "Audit system events";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(42, 130);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(95, 13);
      this.label12.TabIndex = 36;
      this.label12.Text = "Audit logon events";
      // 
      // combControlPolicy8
      // 
      this.combControlPolicy8.FormattingEnabled = true;
      this.combControlPolicy8.Items.AddRange(new object[] {
            "Not check",
            "Successful",
            "Failed",
            "Successful, Failed"});
      this.combControlPolicy8.Location = new System.Drawing.Point(340, 230);
      this.combControlPolicy8.Name = "combControlPolicy8";
      this.combControlPolicy8.Size = new System.Drawing.Size(127, 21);
      this.combControlPolicy8.TabIndex = 8;
      this.combControlPolicy8.Text = "Not check";
      this.combControlPolicy8.SelectedValueChanged += new System.EventHandler(this.combControlPolicyX_SelectedValueChanged);
      // 
      // combControlPolicy1
      // 
      this.combControlPolicy1.FormattingEnabled = true;
      this.combControlPolicy1.Items.AddRange(new object[] {
            "Not check",
            "Successful",
            "Failed",
            "Successful, Failed"});
      this.combControlPolicy1.Location = new System.Drawing.Point(340, 127);
      this.combControlPolicy1.Name = "combControlPolicy1";
      this.combControlPolicy1.Size = new System.Drawing.Size(127, 21);
      this.combControlPolicy1.TabIndex = 1;
      this.combControlPolicy1.Text = "Successful, Failed";
      this.combControlPolicy1.SelectedValueChanged += new System.EventHandler(this.combControlPolicyX_SelectedValueChanged);
      // 
      // label20
      // 
      this.label20.AutoSize = true;
      this.label20.Location = new System.Drawing.Point(42, 232);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(112, 13);
      this.label20.TabIndex = 51;
      this.label20.Text = "Audit process tracking";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(42, 56);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(137, 13);
      this.label14.TabIndex = 39;
      this.label14.Text = "Audit account logon events";
      // 
      // combControlPolicy7
      // 
      this.combControlPolicy7.FormattingEnabled = true;
      this.combControlPolicy7.Items.AddRange(new object[] {
            "Not check",
            "Successful",
            "Failed",
            "Successful, Failed"});
      this.combControlPolicy7.Location = new System.Drawing.Point(340, 151);
      this.combControlPolicy7.Name = "combControlPolicy7";
      this.combControlPolicy7.Size = new System.Drawing.Size(127, 21);
      this.combControlPolicy7.TabIndex = 7;
      this.combControlPolicy7.Text = "Failed";
      this.combControlPolicy7.SelectedValueChanged += new System.EventHandler(this.combControlPolicyX_SelectedValueChanged);
      // 
      // combControlPolicy2
      // 
      this.combControlPolicy2.FormattingEnabled = true;
      this.combControlPolicy2.Items.AddRange(new object[] {
            "Not check",
            "Successful",
            "Failed",
            "Successful, Failed"});
      this.combControlPolicy2.Location = new System.Drawing.Point(340, 52);
      this.combControlPolicy2.Name = "combControlPolicy2";
      this.combControlPolicy2.Size = new System.Drawing.Size(127, 21);
      this.combControlPolicy2.TabIndex = 2;
      this.combControlPolicy2.Text = "Successful, Failed";
      this.combControlPolicy2.SelectedValueChanged += new System.EventHandler(this.combControlPolicyX_SelectedValueChanged);
      // 
      // label21
      // 
      this.label21.AutoSize = true;
      this.label21.Location = new System.Drawing.Point(42, 156);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(100, 13);
      this.label21.TabIndex = 49;
      this.label21.Text = "Audit object access";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(42, 81);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(137, 13);
      this.label15.TabIndex = 41;
      this.label15.Text = "Audit account management";
      // 
      // combControlPolicy6
      // 
      this.combControlPolicy6.FormattingEnabled = true;
      this.combControlPolicy6.Items.AddRange(new object[] {
            "Not check",
            "Successful",
            "Failed",
            "Successful, Failed"});
      this.combControlPolicy6.Location = new System.Drawing.Point(340, 204);
      this.combControlPolicy6.Name = "combControlPolicy6";
      this.combControlPolicy6.Size = new System.Drawing.Size(127, 21);
      this.combControlPolicy6.TabIndex = 6;
      this.combControlPolicy6.Text = "Not check";
      this.combControlPolicy6.SelectedValueChanged += new System.EventHandler(this.combControlPolicyX_SelectedValueChanged);
      // 
      // combControlPolicy3
      // 
      this.combControlPolicy3.FormattingEnabled = true;
      this.combControlPolicy3.Items.AddRange(new object[] {
            "Not check",
            "Successful",
            "Failed",
            "Successful, Failed"});
      this.combControlPolicy3.Location = new System.Drawing.Point(340, 77);
      this.combControlPolicy3.Name = "combControlPolicy3";
      this.combControlPolicy3.Size = new System.Drawing.Size(127, 21);
      this.combControlPolicy3.TabIndex = 3;
      this.combControlPolicy3.Text = "Successful, Failed";
      this.combControlPolicy3.SelectedValueChanged += new System.EventHandler(this.combControlPolicyX_SelectedValueChanged);
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(42, 206);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(93, 13);
      this.label16.TabIndex = 47;
      this.label16.Text = "Audit privilege use";
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Location = new System.Drawing.Point(42, 106);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(148, 13);
      this.label18.TabIndex = 43;
      this.label18.Text = "Audit directory service access";
      // 
      // combControlPolicy5
      // 
      this.combControlPolicy5.FormattingEnabled = true;
      this.combControlPolicy5.Items.AddRange(new object[] {
            "Not check",
            "Successful",
            "Failed",
            "Successful, Failed"});
      this.combControlPolicy5.Location = new System.Drawing.Point(340, 177);
      this.combControlPolicy5.Name = "combControlPolicy5";
      this.combControlPolicy5.Size = new System.Drawing.Size(127, 21);
      this.combControlPolicy5.TabIndex = 5;
      this.combControlPolicy5.Text = "Successful, Failed";
      this.combControlPolicy5.SelectedValueChanged += new System.EventHandler(this.combControlPolicyX_SelectedValueChanged);
      // 
      // combControlPolicy4
      // 
      this.combControlPolicy4.FormattingEnabled = true;
      this.combControlPolicy4.Items.AddRange(new object[] {
            "Not check",
            "Successful",
            "Failed",
            "Successful, Failed"});
      this.combControlPolicy4.Location = new System.Drawing.Point(340, 102);
      this.combControlPolicy4.Name = "combControlPolicy4";
      this.combControlPolicy4.Size = new System.Drawing.Size(127, 21);
      this.combControlPolicy4.TabIndex = 4;
      this.combControlPolicy4.Text = "Failed";
      this.combControlPolicy4.SelectedValueChanged += new System.EventHandler(this.combControlPolicyX_SelectedValueChanged);
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(42, 181);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(100, 13);
      this.label17.TabIndex = 45;
      this.label17.Text = "Audit policy change";
      // 
      // wpGroups
      // 
      this.wpGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpGroups.AntiAlias = false;
      this.wpGroups.BackColor = System.Drawing.Color.Transparent;
      this.wpGroups.Controls.Add(this.groupBox6);
      this.wpGroups.Location = new System.Drawing.Point(7, 72);
      this.wpGroups.Name = "wpGroups";
      this.wpGroups.PageDescription = "Make a new group of users:";
      this.wpGroups.PageTitle = "Users and Groups";
      this.wpGroups.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.Security;
      this.wpGroups.Size = new System.Drawing.Size(608, 283);
      this.wpGroups.TabIndex = 11;
      this.wpGroups.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpGroups_NextButtonClick);
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.cbAddgroupAdministrators);
      this.groupBox6.Controls.Add(this.cbAddGroupFTP_users);
      this.groupBox6.Controls.Add(this.lbSelectGroupFirst);
      this.groupBox6.Controls.Add(this.btDeleteGroup);
      this.groupBox6.Controls.Add(this.cbAddgroupActemiumEngineers);
      this.groupBox6.Controls.Add(this.label32);
      this.groupBox6.Controls.Add(this.lvUsergroups);
      this.groupBox6.Controls.Add(this.label24);
      this.groupBox6.Controls.Add(this.tbAddUserGroupDescription);
      this.groupBox6.Controls.Add(this.label23);
      this.groupBox6.Controls.Add(this.tbAddUserGroupName);
      this.groupBox6.Controls.Add(this.btAddUserGroup);
      this.groupBox6.Controls.Add(this.label22);
      this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox6.Location = new System.Drawing.Point(0, 0);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(608, 283);
      this.groupBox6.TabIndex = 7;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Usergroups";
      // 
      // cbAddgroupAdministrators
      // 
      this.cbAddgroupAdministrators.AutoSize = true;
      this.cbAddgroupAdministrators.Location = new System.Drawing.Point(336, 45);
      this.cbAddgroupAdministrators.Name = "cbAddgroupAdministrators";
      this.cbAddgroupAdministrators.Size = new System.Drawing.Size(91, 17);
      this.cbAddgroupAdministrators.TabIndex = 42;
      this.cbAddgroupAdministrators.Text = "Administrators";
      this.cbAddgroupAdministrators.UseVisualStyleBackColor = true;
      this.cbAddgroupAdministrators.CheckedChanged += new System.EventHandler(this.cbAddgroupAdministrators_CheckedChanged);
      // 
      // cbAddGroupFTP_users
      // 
      this.cbAddGroupFTP_users.AutoSize = true;
      this.cbAddGroupFTP_users.Location = new System.Drawing.Point(336, 91);
      this.cbAddGroupFTP_users.Name = "cbAddGroupFTP_users";
      this.cbAddGroupFTP_users.Size = new System.Drawing.Size(79, 17);
      this.cbAddGroupFTP_users.TabIndex = 2;
      this.cbAddGroupFTP_users.Text = "FTP_Users";
      this.cbAddGroupFTP_users.UseVisualStyleBackColor = true;
      this.cbAddGroupFTP_users.CheckedChanged += new System.EventHandler(this.cbAddGroupFTP_users_CheckedChanged);
      // 
      // lbSelectGroupFirst
      // 
      this.lbSelectGroupFirst.AutoSize = true;
      this.lbSelectGroupFirst.ForeColor = System.Drawing.Color.Red;
      this.lbSelectGroupFirst.Location = new System.Drawing.Point(41, 266);
      this.lbSelectGroupFirst.Name = "lbSelectGroupFirst";
      this.lbSelectGroupFirst.Size = new System.Drawing.Size(100, 13);
      this.lbSelectGroupFirst.TabIndex = 41;
      this.lbSelectGroupFirst.Text = "*First select a group";
      this.lbSelectGroupFirst.Visible = false;
      // 
      // btDeleteGroup
      // 
      this.btDeleteGroup.Location = new System.Drawing.Point(308, 237);
      this.btDeleteGroup.Name = "btDeleteGroup";
      this.btDeleteGroup.Size = new System.Drawing.Size(100, 23);
      this.btDeleteGroup.TabIndex = 6;
      this.btDeleteGroup.Text = "Delete Group";
      this.btDeleteGroup.UseVisualStyleBackColor = true;
      this.btDeleteGroup.Click += new System.EventHandler(this.btDeleteGroup_Click);
      // 
      // cbAddgroupActemiumEngineers
      // 
      this.cbAddgroupActemiumEngineers.AutoSize = true;
      this.cbAddgroupActemiumEngineers.Location = new System.Drawing.Point(336, 68);
      this.cbAddgroupActemiumEngineers.Name = "cbAddgroupActemiumEngineers";
      this.cbAddgroupActemiumEngineers.Size = new System.Drawing.Size(122, 17);
      this.cbAddgroupActemiumEngineers.TabIndex = 1;
      this.cbAddgroupActemiumEngineers.Text = "Actemium Engineers";
      this.cbAddgroupActemiumEngineers.UseVisualStyleBackColor = true;
      this.cbAddgroupActemiumEngineers.CheckedChanged += new System.EventHandler(this.cbAddgroupActemiumEngineers_CheckedChanged);
      // 
      // label32
      // 
      this.label32.AutoSize = true;
      this.label32.Location = new System.Drawing.Point(325, 20);
      this.label32.Name = "label32";
      this.label32.Size = new System.Drawing.Size(115, 13);
      this.label32.TabIndex = 9;
      this.label32.Text = "Add standard group to:";
      // 
      // lvUsergroups
      // 
      this.lvUsergroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Group,
            this.Discription1});
      this.lvUsergroups.FullRowSelect = true;
      this.lvUsergroups.GridLines = true;
      this.lvUsergroups.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lvUsergroups.Location = new System.Drawing.Point(41, 45);
      this.lvUsergroups.Name = "lvUsergroups";
      this.lvUsergroups.Size = new System.Drawing.Size(261, 215);
      this.lvUsergroups.TabIndex = 8;
      this.lvUsergroups.UseCompatibleStateImageBehavior = false;
      this.lvUsergroups.View = System.Windows.Forms.View.Details;
      // 
      // Group
      // 
      this.Group.Text = "Group";
      this.Group.Width = 109;
      // 
      // Discription1
      // 
      this.Discription1.Text = "Description";
      this.Discription1.Width = 148;
      // 
      // label24
      // 
      this.label24.AutoSize = true;
      this.label24.Location = new System.Drawing.Point(324, 140);
      this.label24.Name = "label24";
      this.label24.Size = new System.Drawing.Size(63, 13);
      this.label24.TabIndex = 6;
      this.label24.Text = "Description:";
      // 
      // tbAddUserGroupDescription
      // 
      this.tbAddUserGroupDescription.Location = new System.Drawing.Point(397, 137);
      this.tbAddUserGroupDescription.Name = "tbAddUserGroupDescription";
      this.tbAddUserGroupDescription.Size = new System.Drawing.Size(158, 20);
      this.tbAddUserGroupDescription.TabIndex = 4;
      // 
      // label23
      // 
      this.label23.AutoSize = true;
      this.label23.Location = new System.Drawing.Point(324, 117);
      this.label23.Name = "label23";
      this.label23.Size = new System.Drawing.Size(65, 13);
      this.label23.TabIndex = 4;
      this.label23.Text = "Groupname:";
      // 
      // tbAddUserGroupName
      // 
      this.tbAddUserGroupName.Location = new System.Drawing.Point(397, 114);
      this.tbAddUserGroupName.Name = "tbAddUserGroupName";
      this.tbAddUserGroupName.Size = new System.Drawing.Size(158, 20);
      this.tbAddUserGroupName.TabIndex = 3;
      // 
      // btAddUserGroup
      // 
      this.btAddUserGroup.Location = new System.Drawing.Point(397, 163);
      this.btAddUserGroup.Name = "btAddUserGroup";
      this.btAddUserGroup.Size = new System.Drawing.Size(81, 23);
      this.btAddUserGroup.TabIndex = 5;
      this.btAddUserGroup.Text = "Add";
      this.btAddUserGroup.UseVisualStyleBackColor = true;
      this.btAddUserGroup.Click += new System.EventHandler(this.btAddUserGroup_Click);
      // 
      // label22
      // 
      this.label22.AutoSize = true;
      this.label22.Location = new System.Drawing.Point(8, 20);
      this.label22.Name = "label22";
      this.label22.Size = new System.Drawing.Size(140, 13);
      this.label22.TabIndex = 1;
      this.label22.Text = "Overview of existing groups:";
      // 
      // wpDefaultAccounts
      // 
      this.wpDefaultAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpDefaultAccounts.AntiAlias = false;
      this.wpDefaultAccounts.BackColor = System.Drawing.Color.Transparent;
      this.wpDefaultAccounts.Controls.Add(this.gbAddAdminAndActemiumUsers);
      this.wpDefaultAccounts.Controls.Add(this.label4);
      this.wpDefaultAccounts.Controls.Add(this.label1);
      this.wpDefaultAccounts.Controls.Add(this.lbChangeDefaultAccountAdministrator);
      this.wpDefaultAccounts.Controls.Add(this.lbChangeDefaultAccountSUPPORT);
      this.wpDefaultAccounts.Controls.Add(this.lbChangeDefaultAccountGuest);
      this.wpDefaultAccounts.Controls.Add(this.ttChangeDefaultAccountsSavePasswordInLogFile);
      this.wpDefaultAccounts.Controls.Add(this.cbBlockDefAccoAdministrator);
      this.wpDefaultAccounts.Controls.Add(this.cbChangeDefaultAccountsSavePasswordInLogFile);
      this.wpDefaultAccounts.Controls.Add(this.cbRandomPWChangeDefAccoAdministrator);
      this.wpDefaultAccounts.Controls.Add(this.label53);
      this.wpDefaultAccounts.Controls.Add(this.tbChangeConfirmPasswDefAccoAdministrator);
      this.wpDefaultAccounts.Controls.Add(this.tbChangePasswDefAccoAdministrator);
      this.wpDefaultAccounts.Controls.Add(this.cbBlockDefAccoSUPPORT);
      this.wpDefaultAccounts.Controls.Add(this.cbRandomPWChangeDefAccoSUPPORT);
      this.wpDefaultAccounts.Controls.Add(this.label51);
      this.wpDefaultAccounts.Controls.Add(this.tbChangeConfirmPasswDefAccoSUPPORT);
      this.wpDefaultAccounts.Controls.Add(this.tbChangePasswDefAccoSUPPORT);
      this.wpDefaultAccounts.Controls.Add(this.cbBlockDefAccoGuest);
      this.wpDefaultAccounts.Controls.Add(this.cbRandomPWChangeDefAccoGuest);
      this.wpDefaultAccounts.Controls.Add(this.label33);
      this.wpDefaultAccounts.Controls.Add(this.label50);
      this.wpDefaultAccounts.Controls.Add(this.tbChangeConfirmPasswDefAccoGuest);
      this.wpDefaultAccounts.Controls.Add(this.tbChangePasswDefAccoGuest);
      this.wpDefaultAccounts.Location = new System.Drawing.Point(7, 72);
      this.wpDefaultAccounts.Name = "wpDefaultAccounts";
      this.wpDefaultAccounts.PageDescription = "Here display a number of accounts should be disabled";
      this.wpDefaultAccounts.PageTitle = "Users and Groups";
      this.wpDefaultAccounts.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.SecurityAndLockdown;
      this.wpDefaultAccounts.Size = new System.Drawing.Size(608, 283);
      this.wpDefaultAccounts.TabIndex = 30;
      this.wpDefaultAccounts.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpDefaultAccounts_NextButtonClick);
      // 
      // gbAddAdminAndActemiumUsers
      // 
      this.gbAddAdminAndActemiumUsers.Controls.Add(this.cbRandomPWAdmin);
      this.gbAddAdminAndActemiumUsers.Controls.Add(this.lbPWcomfimAdmin);
      this.gbAddAdminAndActemiumUsers.Controls.Add(this.lbPWAdmin);
      this.gbAddAdminAndActemiumUsers.Controls.Add(this.tbPWcomfimAdmin);
      this.gbAddAdminAndActemiumUsers.Controls.Add(this.tbPWAdmin);
      this.gbAddAdminAndActemiumUsers.Controls.Add(this.cbCreateAdminUser);
      this.gbAddAdminAndActemiumUsers.Controls.Add(this.cbRandomPWActemium);
      this.gbAddAdminAndActemiumUsers.Controls.Add(this.lbPWcomfimActemium);
      this.gbAddAdminAndActemiumUsers.Controls.Add(this.lbPWActemium);
      this.gbAddAdminAndActemiumUsers.Controls.Add(this.tbPWcomfimActemium);
      this.gbAddAdminAndActemiumUsers.Controls.Add(this.tbPWActemium);
      this.gbAddAdminAndActemiumUsers.Controls.Add(this.cbCreateActemiumUser);
      this.gbAddAdminAndActemiumUsers.Location = new System.Drawing.Point(17, 127);
      this.gbAddAdminAndActemiumUsers.Name = "gbAddAdminAndActemiumUsers";
      this.gbAddAdminAndActemiumUsers.Size = new System.Drawing.Size(568, 143);
      this.gbAddAdminAndActemiumUsers.TabIndex = 90;
      this.gbAddAdminAndActemiumUsers.TabStop = false;
      this.gbAddAdminAndActemiumUsers.Text = "Add standard user(s) to: ";
      // 
      // cbRandomPWAdmin
      // 
      this.cbRandomPWAdmin.AutoSize = true;
      this.cbRandomPWAdmin.Enabled = false;
      this.cbRandomPWAdmin.Location = new System.Drawing.Point(346, 80);
      this.cbRandomPWAdmin.Name = "cbRandomPWAdmin";
      this.cbRandomPWAdmin.Size = new System.Drawing.Size(148, 17);
      this.cbRandomPWAdmin.TabIndex = 107;
      this.cbRandomPWAdmin.Text = "Choose random password";
      this.cbRandomPWAdmin.UseVisualStyleBackColor = true;
      // 
      // lbPWcomfimAdmin
      // 
      this.lbPWcomfimAdmin.AutoSize = true;
      this.lbPWcomfimAdmin.Enabled = false;
      this.lbPWcomfimAdmin.Location = new System.Drawing.Point(333, 63);
      this.lbPWcomfimAdmin.Name = "lbPWcomfimAdmin";
      this.lbPWcomfimAdmin.Size = new System.Drawing.Size(45, 13);
      this.lbPWcomfimAdmin.TabIndex = 109;
      this.lbPWcomfimAdmin.Text = "Confirm:";
      // 
      // lbPWAdmin
      // 
      this.lbPWAdmin.AutoSize = true;
      this.lbPWAdmin.Enabled = false;
      this.lbPWAdmin.Location = new System.Drawing.Point(335, 39);
      this.lbPWAdmin.Name = "lbPWAdmin";
      this.lbPWAdmin.Size = new System.Drawing.Size(56, 13);
      this.lbPWAdmin.TabIndex = 108;
      this.lbPWAdmin.Text = "Password:";
      // 
      // tbPWcomfimAdmin
      // 
      this.tbPWcomfimAdmin.Enabled = false;
      this.tbPWcomfimAdmin.Location = new System.Drawing.Point(409, 60);
      this.tbPWcomfimAdmin.Name = "tbPWcomfimAdmin";
      this.tbPWcomfimAdmin.PasswordChar = '*';
      this.tbPWcomfimAdmin.Size = new System.Drawing.Size(90, 20);
      this.tbPWcomfimAdmin.TabIndex = 106;
      // 
      // tbPWAdmin
      // 
      this.tbPWAdmin.Enabled = false;
      this.tbPWAdmin.Location = new System.Drawing.Point(409, 32);
      this.tbPWAdmin.Name = "tbPWAdmin";
      this.tbPWAdmin.PasswordChar = '*';
      this.tbPWAdmin.Size = new System.Drawing.Size(90, 20);
      this.tbPWAdmin.TabIndex = 105;
      // 
      // cbCreateAdminUser
      // 
      this.cbCreateAdminUser.AutoSize = true;
      this.cbCreateAdminUser.Location = new System.Drawing.Point(338, 19);
      this.cbCreateAdminUser.Name = "cbCreateAdminUser";
      this.cbCreateAdminUser.Size = new System.Drawing.Size(55, 17);
      this.cbCreateAdminUser.TabIndex = 104;
      this.cbCreateAdminUser.Text = "Admin";
      this.cbCreateAdminUser.UseVisualStyleBackColor = true;
      this.cbCreateAdminUser.CheckedChanged += new System.EventHandler(this.cbCreateAdminUser_CheckedChanged);
      // 
      // cbRandomPWActemium
      // 
      this.cbRandomPWActemium.AutoSize = true;
      this.cbRandomPWActemium.Enabled = false;
      this.cbRandomPWActemium.Location = new System.Drawing.Point(31, 81);
      this.cbRandomPWActemium.Name = "cbRandomPWActemium";
      this.cbRandomPWActemium.Size = new System.Drawing.Size(148, 17);
      this.cbRandomPWActemium.TabIndex = 100;
      this.cbRandomPWActemium.Text = "Choose random password";
      this.cbRandomPWActemium.UseVisualStyleBackColor = true;
      // 
      // lbPWcomfimActemium
      // 
      this.lbPWcomfimActemium.AutoSize = true;
      this.lbPWcomfimActemium.Enabled = false;
      this.lbPWcomfimActemium.Location = new System.Drawing.Point(21, 63);
      this.lbPWcomfimActemium.Name = "lbPWcomfimActemium";
      this.lbPWcomfimActemium.Size = new System.Drawing.Size(45, 13);
      this.lbPWcomfimActemium.TabIndex = 103;
      this.lbPWcomfimActemium.Text = "Confirm:";
      // 
      // lbPWActemium
      // 
      this.lbPWActemium.AutoSize = true;
      this.lbPWActemium.Enabled = false;
      this.lbPWActemium.Location = new System.Drawing.Point(19, 39);
      this.lbPWActemium.Name = "lbPWActemium";
      this.lbPWActemium.Size = new System.Drawing.Size(56, 13);
      this.lbPWActemium.TabIndex = 102;
      this.lbPWActemium.Text = "Password:";
      // 
      // tbPWcomfimActemium
      // 
      this.tbPWcomfimActemium.Enabled = false;
      this.tbPWcomfimActemium.Location = new System.Drawing.Point(93, 60);
      this.tbPWcomfimActemium.Name = "tbPWcomfimActemium";
      this.tbPWcomfimActemium.PasswordChar = '*';
      this.tbPWcomfimActemium.Size = new System.Drawing.Size(90, 20);
      this.tbPWcomfimActemium.TabIndex = 99;
      // 
      // tbPWActemium
      // 
      this.tbPWActemium.Enabled = false;
      this.tbPWActemium.Location = new System.Drawing.Point(93, 32);
      this.tbPWActemium.Name = "tbPWActemium";
      this.tbPWActemium.PasswordChar = '*';
      this.tbPWActemium.Size = new System.Drawing.Size(90, 20);
      this.tbPWActemium.TabIndex = 98;
      // 
      // cbCreateActemiumUser
      // 
      this.cbCreateActemiumUser.AutoSize = true;
      this.cbCreateActemiumUser.Location = new System.Drawing.Point(22, 19);
      this.cbCreateActemiumUser.Name = "cbCreateActemiumUser";
      this.cbCreateActemiumUser.Size = new System.Drawing.Size(72, 17);
      this.cbCreateActemiumUser.TabIndex = 97;
      this.cbCreateActemiumUser.Text = "Actemium";
      this.cbCreateActemiumUser.UseVisualStyleBackColor = true;
      this.cbCreateActemiumUser.CheckedChanged += new System.EventHandler(this.cbCreateActemiumUser_CheckedChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(407, 28);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(65, 26);
      this.label4.TabIndex = 89;
      this.label4.Text = "Change the \r\npassword:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(209, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 26);
      this.label1.TabIndex = 88;
      this.label1.Text = "Change the \r\npassword:";
      // 
      // lbChangeDefaultAccountAdministrator
      // 
      this.lbChangeDefaultAccountAdministrator.AutoSize = true;
      this.lbChangeDefaultAccountAdministrator.Location = new System.Drawing.Point(427, 2);
      this.lbChangeDefaultAccountAdministrator.Name = "lbChangeDefaultAccountAdministrator";
      this.lbChangeDefaultAccountAdministrator.Size = new System.Drawing.Size(109, 13);
      this.lbChangeDefaultAccountAdministrator.TabIndex = 87;
      this.lbChangeDefaultAccountAdministrator.Text = "Administrator account";
      // 
      // lbChangeDefaultAccountSUPPORT
      // 
      this.lbChangeDefaultAccountSUPPORT.AutoSize = true;
      this.lbChangeDefaultAccountSUPPORT.Location = new System.Drawing.Point(228, 2);
      this.lbChangeDefaultAccountSUPPORT.Name = "lbChangeDefaultAccountSUPPORT";
      this.lbChangeDefaultAccountSUPPORT.Size = new System.Drawing.Size(114, 13);
      this.lbChangeDefaultAccountSUPPORT.TabIndex = 86;
      this.lbChangeDefaultAccountSUPPORT.Text = "SUPPORT_*  account";
      // 
      // lbChangeDefaultAccountGuest
      // 
      this.lbChangeDefaultAccountGuest.AutoSize = true;
      this.lbChangeDefaultAccountGuest.Location = new System.Drawing.Point(34, 2);
      this.lbChangeDefaultAccountGuest.Name = "lbChangeDefaultAccountGuest";
      this.lbChangeDefaultAccountGuest.Size = new System.Drawing.Size(77, 13);
      this.lbChangeDefaultAccountGuest.TabIndex = 85;
      this.lbChangeDefaultAccountGuest.Text = "Guest account";
      // 
      // ttChangeDefaultAccountsSavePasswordInLogFile
      // 
      this.ttChangeDefaultAccountsSavePasswordInLogFile.Image = ((System.Drawing.Image)(resources.GetObject("ttChangeDefaultAccountsSavePasswordInLogFile.Image")));
      this.ttChangeDefaultAccountsSavePasswordInLogFile.Location = new System.Drawing.Point(455, 270);
      this.ttChangeDefaultAccountsSavePasswordInLogFile.Name = "ttChangeDefaultAccountsSavePasswordInLogFile";
      this.ttChangeDefaultAccountsSavePasswordInLogFile.Size = new System.Drawing.Size(16, 16);
      this.ttChangeDefaultAccountsSavePasswordInLogFile.TabIndex = 42;
      this.ttChangeDefaultAccountsSavePasswordInLogFile.TabStop = false;
      this.ttChangeDefaultAccountsSavePasswordInLogFile.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // cbBlockDefAccoAdministrator
      // 
      this.cbBlockDefAccoAdministrator.AutoSize = true;
      this.cbBlockDefAccoAdministrator.Checked = true;
      this.cbBlockDefAccoAdministrator.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbBlockDefAccoAdministrator.Location = new System.Drawing.Point(427, 107);
      this.cbBlockDefAccoAdministrator.Name = "cbBlockDefAccoAdministrator";
      this.cbBlockDefAccoAdministrator.Size = new System.Drawing.Size(103, 17);
      this.cbBlockDefAccoAdministrator.TabIndex = 84;
      this.cbBlockDefAccoAdministrator.Text = "Disable account";
      this.cbBlockDefAccoAdministrator.UseVisualStyleBackColor = true;
      // 
      // cbChangeDefaultAccountsSavePasswordInLogFile
      // 
      this.cbChangeDefaultAccountsSavePasswordInLogFile.AutoSize = true;
      this.cbChangeDefaultAccountsSavePasswordInLogFile.Location = new System.Drawing.Point(482, 269);
      this.cbChangeDefaultAccountsSavePasswordInLogFile.Name = "cbChangeDefaultAccountsSavePasswordInLogFile";
      this.cbChangeDefaultAccountsSavePasswordInLogFile.Size = new System.Drawing.Size(120, 17);
      this.cbChangeDefaultAccountsSavePasswordInLogFile.TabIndex = 41;
      this.cbChangeDefaultAccountsSavePasswordInLogFile.Text = "Save all passwords ";
      this.cbChangeDefaultAccountsSavePasswordInLogFile.UseVisualStyleBackColor = true;
      this.cbChangeDefaultAccountsSavePasswordInLogFile.CheckedChanged += new System.EventHandler(this.cbChangeDefaultAccountsSavePasswordInLogFile_CheckedChanged);
      // 
      // cbRandomPWChangeDefAccoAdministrator
      // 
      this.cbRandomPWChangeDefAccoAdministrator.AutoSize = true;
      this.cbRandomPWChangeDefAccoAdministrator.Location = new System.Drawing.Point(427, 88);
      this.cbRandomPWChangeDefAccoAdministrator.Name = "cbRandomPWChangeDefAccoAdministrator";
      this.cbRandomPWChangeDefAccoAdministrator.Size = new System.Drawing.Size(148, 17);
      this.cbRandomPWChangeDefAccoAdministrator.TabIndex = 81;
      this.cbRandomPWChangeDefAccoAdministrator.Text = "Choose random password";
      this.cbRandomPWChangeDefAccoAdministrator.UseVisualStyleBackColor = true;
      this.cbRandomPWChangeDefAccoAdministrator.CheckedChanged += new System.EventHandler(this.cbRandomPWChangeDefAccoAdministrator_CheckedChanged);
      // 
      // label53
      // 
      this.label53.AutoSize = true;
      this.label53.Location = new System.Drawing.Point(407, 58);
      this.label53.Name = "label53";
      this.label53.Size = new System.Drawing.Size(63, 26);
      this.label53.TabIndex = 83;
      this.label53.Text = "Confirm the \r\npassword:";
      // 
      // tbChangeConfirmPasswDefAccoAdministrator
      // 
      this.tbChangeConfirmPasswDefAccoAdministrator.Location = new System.Drawing.Point(482, 62);
      this.tbChangeConfirmPasswDefAccoAdministrator.Name = "tbChangeConfirmPasswDefAccoAdministrator";
      this.tbChangeConfirmPasswDefAccoAdministrator.PasswordChar = '*';
      this.tbChangeConfirmPasswDefAccoAdministrator.Size = new System.Drawing.Size(90, 20);
      this.tbChangeConfirmPasswDefAccoAdministrator.TabIndex = 80;
      // 
      // tbChangePasswDefAccoAdministrator
      // 
      this.tbChangePasswDefAccoAdministrator.Location = new System.Drawing.Point(482, 31);
      this.tbChangePasswDefAccoAdministrator.Name = "tbChangePasswDefAccoAdministrator";
      this.tbChangePasswDefAccoAdministrator.PasswordChar = '*';
      this.tbChangePasswDefAccoAdministrator.Size = new System.Drawing.Size(90, 20);
      this.tbChangePasswDefAccoAdministrator.TabIndex = 79;
      // 
      // cbBlockDefAccoSUPPORT
      // 
      this.cbBlockDefAccoSUPPORT.AutoSize = true;
      this.cbBlockDefAccoSUPPORT.Checked = true;
      this.cbBlockDefAccoSUPPORT.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbBlockDefAccoSUPPORT.Location = new System.Drawing.Point(228, 108);
      this.cbBlockDefAccoSUPPORT.Name = "cbBlockDefAccoSUPPORT";
      this.cbBlockDefAccoSUPPORT.Size = new System.Drawing.Size(103, 17);
      this.cbBlockDefAccoSUPPORT.TabIndex = 77;
      this.cbBlockDefAccoSUPPORT.Text = "Disable account";
      this.cbBlockDefAccoSUPPORT.UseVisualStyleBackColor = true;
      // 
      // cbRandomPWChangeDefAccoSUPPORT
      // 
      this.cbRandomPWChangeDefAccoSUPPORT.AutoSize = true;
      this.cbRandomPWChangeDefAccoSUPPORT.Location = new System.Drawing.Point(228, 88);
      this.cbRandomPWChangeDefAccoSUPPORT.Name = "cbRandomPWChangeDefAccoSUPPORT";
      this.cbRandomPWChangeDefAccoSUPPORT.Size = new System.Drawing.Size(148, 17);
      this.cbRandomPWChangeDefAccoSUPPORT.TabIndex = 74;
      this.cbRandomPWChangeDefAccoSUPPORT.Text = "Choose random password";
      this.cbRandomPWChangeDefAccoSUPPORT.UseVisualStyleBackColor = true;
      this.cbRandomPWChangeDefAccoSUPPORT.CheckedChanged += new System.EventHandler(this.cbRandomPWChangeDefAccoSUPPORT_CheckedChanged);
      // 
      // label51
      // 
      this.label51.AutoSize = true;
      this.label51.Location = new System.Drawing.Point(208, 58);
      this.label51.Name = "label51";
      this.label51.Size = new System.Drawing.Size(63, 26);
      this.label51.TabIndex = 76;
      this.label51.Text = "Confirm the \r\npassword:";
      // 
      // tbChangeConfirmPasswDefAccoSUPPORT
      // 
      this.tbChangeConfirmPasswDefAccoSUPPORT.Location = new System.Drawing.Point(283, 62);
      this.tbChangeConfirmPasswDefAccoSUPPORT.Name = "tbChangeConfirmPasswDefAccoSUPPORT";
      this.tbChangeConfirmPasswDefAccoSUPPORT.PasswordChar = '*';
      this.tbChangeConfirmPasswDefAccoSUPPORT.Size = new System.Drawing.Size(90, 20);
      this.tbChangeConfirmPasswDefAccoSUPPORT.TabIndex = 73;
      // 
      // tbChangePasswDefAccoSUPPORT
      // 
      this.tbChangePasswDefAccoSUPPORT.Location = new System.Drawing.Point(283, 31);
      this.tbChangePasswDefAccoSUPPORT.Name = "tbChangePasswDefAccoSUPPORT";
      this.tbChangePasswDefAccoSUPPORT.PasswordChar = '*';
      this.tbChangePasswDefAccoSUPPORT.Size = new System.Drawing.Size(90, 20);
      this.tbChangePasswDefAccoSUPPORT.TabIndex = 72;
      // 
      // cbBlockDefAccoGuest
      // 
      this.cbBlockDefAccoGuest.AutoSize = true;
      this.cbBlockDefAccoGuest.Checked = true;
      this.cbBlockDefAccoGuest.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbBlockDefAccoGuest.Location = new System.Drawing.Point(34, 108);
      this.cbBlockDefAccoGuest.Name = "cbBlockDefAccoGuest";
      this.cbBlockDefAccoGuest.Size = new System.Drawing.Size(103, 17);
      this.cbBlockDefAccoGuest.TabIndex = 70;
      this.cbBlockDefAccoGuest.Text = "Disable account";
      this.cbBlockDefAccoGuest.UseVisualStyleBackColor = true;
      // 
      // cbRandomPWChangeDefAccoGuest
      // 
      this.cbRandomPWChangeDefAccoGuest.AutoSize = true;
      this.cbRandomPWChangeDefAccoGuest.Location = new System.Drawing.Point(34, 87);
      this.cbRandomPWChangeDefAccoGuest.Name = "cbRandomPWChangeDefAccoGuest";
      this.cbRandomPWChangeDefAccoGuest.Size = new System.Drawing.Size(148, 17);
      this.cbRandomPWChangeDefAccoGuest.TabIndex = 67;
      this.cbRandomPWChangeDefAccoGuest.Text = "Choose random password";
      this.cbRandomPWChangeDefAccoGuest.UseVisualStyleBackColor = true;
      this.cbRandomPWChangeDefAccoGuest.CheckedChanged += new System.EventHandler(this.cbRandomPWChangeDefAccoGuest_CheckedChanged);
      // 
      // label33
      // 
      this.label33.AutoSize = true;
      this.label33.Location = new System.Drawing.Point(14, 58);
      this.label33.Name = "label33";
      this.label33.Size = new System.Drawing.Size(63, 26);
      this.label33.TabIndex = 69;
      this.label33.Text = "Confirm the \r\npassword:";
      // 
      // label50
      // 
      this.label50.AutoSize = true;
      this.label50.Location = new System.Drawing.Point(15, 28);
      this.label50.Name = "label50";
      this.label50.Size = new System.Drawing.Size(65, 26);
      this.label50.TabIndex = 68;
      this.label50.Text = "Change the \r\npassword:";
      // 
      // tbChangeConfirmPasswDefAccoGuest
      // 
      this.tbChangeConfirmPasswDefAccoGuest.Location = new System.Drawing.Point(89, 61);
      this.tbChangeConfirmPasswDefAccoGuest.Name = "tbChangeConfirmPasswDefAccoGuest";
      this.tbChangeConfirmPasswDefAccoGuest.PasswordChar = '*';
      this.tbChangeConfirmPasswDefAccoGuest.Size = new System.Drawing.Size(90, 20);
      this.tbChangeConfirmPasswDefAccoGuest.TabIndex = 66;
      // 
      // tbChangePasswDefAccoGuest
      // 
      this.tbChangePasswDefAccoGuest.Location = new System.Drawing.Point(89, 30);
      this.tbChangePasswDefAccoGuest.Name = "tbChangePasswDefAccoGuest";
      this.tbChangePasswDefAccoGuest.PasswordChar = '*';
      this.tbChangePasswDefAccoGuest.Size = new System.Drawing.Size(90, 20);
      this.tbChangePasswDefAccoGuest.TabIndex = 65;
      // 
      // wpUsers
      // 
      this.wpUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpUsers.AntiAlias = false;
      this.wpUsers.BackColor = System.Drawing.Color.Transparent;
      this.wpUsers.Controls.Add(this.groupBox11);
      this.wpUsers.Controls.Add(this.btModifyUser);
      this.wpUsers.Controls.Add(this.cbRandomPaswordUsers);
      this.wpUsers.Controls.Add(this.lbSelectUserFirst);
      this.wpUsers.Controls.Add(this.btDeleteUser);
      this.wpUsers.Controls.Add(this.ttSavePasswordInLogFile);
      this.wpUsers.Controls.Add(this.cbSavePasswordInLogFile);
      this.wpUsers.Controls.Add(this.cbAccountDisabled);
      this.wpUsers.Controls.Add(this.cbPaswordNeverExpires);
      this.wpUsers.Controls.Add(this.cbPaswordCantBeChanged);
      this.wpUsers.Controls.Add(this.cbChangePwNextLogon);
      this.wpUsers.Controls.Add(this.label26);
      this.wpUsers.Controls.Add(this.lvUsers);
      this.wpUsers.Location = new System.Drawing.Point(7, 72);
      this.wpUsers.Name = "wpUsers";
      this.wpUsers.PageDescription = "Make new users:";
      this.wpUsers.PageTitle = "Users and groups";
      this.wpUsers.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.Security;
      this.wpUsers.Size = new System.Drawing.Size(608, 283);
      this.wpUsers.TabIndex = 12;
      this.wpUsers.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpUsers_NextButtonClick);
      // 
      // groupBox11
      // 
      this.groupBox11.Controls.Add(this.chkListBUserGroups);
      this.groupBox11.Controls.Add(this.btAddUser);
      this.groupBox11.Controls.Add(this.tbAddUserPasword2);
      this.groupBox11.Controls.Add(this.label31);
      this.groupBox11.Controls.Add(this.tbAddUserPasword1);
      this.groupBox11.Controls.Add(this.label30);
      this.groupBox11.Controls.Add(this.tbAddUserDescription);
      this.groupBox11.Controls.Add(this.label29);
      this.groupBox11.Controls.Add(this.tbAddUserFullName);
      this.groupBox11.Controls.Add(this.label28);
      this.groupBox11.Controls.Add(this.tbAddUserUserName);
      this.groupBox11.Controls.Add(this.label27);
      this.groupBox11.Location = new System.Drawing.Point(10, 132);
      this.groupBox11.Name = "groupBox11";
      this.groupBox11.Size = new System.Drawing.Size(418, 150);
      this.groupBox11.TabIndex = 69;
      this.groupBox11.TabStop = false;
      this.groupBox11.Text = "Add user(s) to:";
      // 
      // chkListBUserGroups
      // 
      this.chkListBUserGroups.FormattingEnabled = true;
      this.chkListBUserGroups.Location = new System.Drawing.Point(235, 12);
      this.chkListBUserGroups.Name = "chkListBUserGroups";
      this.chkListBUserGroups.Size = new System.Drawing.Size(177, 109);
      this.chkListBUserGroups.TabIndex = 83;
      // 
      // btAddUser
      // 
      this.btAddUser.Location = new System.Drawing.Point(274, 123);
      this.btAddUser.Name = "btAddUser";
      this.btAddUser.Size = new System.Drawing.Size(95, 23);
      this.btAddUser.TabIndex = 75;
      this.btAddUser.Text = "Add";
      this.btAddUser.UseVisualStyleBackColor = true;
      this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
      // 
      // tbAddUserPasword2
      // 
      this.tbAddUserPasword2.Location = new System.Drawing.Point(101, 103);
      this.tbAddUserPasword2.Name = "tbAddUserPasword2";
      this.tbAddUserPasword2.PasswordChar = '*';
      this.tbAddUserPasword2.Size = new System.Drawing.Size(128, 20);
      this.tbAddUserPasword2.TabIndex = 74;
      // 
      // label31
      // 
      this.label31.AutoSize = true;
      this.label31.Location = new System.Drawing.Point(6, 108);
      this.label31.Name = "label31";
      this.label31.Size = new System.Drawing.Size(93, 13);
      this.label31.TabIndex = 80;
      this.label31.Text = "Confirm password:";
      // 
      // tbAddUserPasword1
      // 
      this.tbAddUserPasword1.Location = new System.Drawing.Point(101, 81);
      this.tbAddUserPasword1.Name = "tbAddUserPasword1";
      this.tbAddUserPasword1.PasswordChar = '*';
      this.tbAddUserPasword1.Size = new System.Drawing.Size(128, 20);
      this.tbAddUserPasword1.TabIndex = 73;
      // 
      // label30
      // 
      this.label30.AutoSize = true;
      this.label30.Location = new System.Drawing.Point(6, 87);
      this.label30.Name = "label30";
      this.label30.Size = new System.Drawing.Size(56, 13);
      this.label30.TabIndex = 79;
      this.label30.Text = "Password:";
      // 
      // tbAddUserDescription
      // 
      this.tbAddUserDescription.Location = new System.Drawing.Point(101, 59);
      this.tbAddUserDescription.Name = "tbAddUserDescription";
      this.tbAddUserDescription.Size = new System.Drawing.Size(128, 20);
      this.tbAddUserDescription.TabIndex = 72;
      // 
      // label29
      // 
      this.label29.AutoSize = true;
      this.label29.Location = new System.Drawing.Point(8, 63);
      this.label29.Name = "label29";
      this.label29.Size = new System.Drawing.Size(63, 13);
      this.label29.TabIndex = 78;
      this.label29.Text = "Description:";
      // 
      // tbAddUserFullName
      // 
      this.tbAddUserFullName.Location = new System.Drawing.Point(101, 37);
      this.tbAddUserFullName.Name = "tbAddUserFullName";
      this.tbAddUserFullName.Size = new System.Drawing.Size(128, 20);
      this.tbAddUserFullName.TabIndex = 71;
      // 
      // label28
      // 
      this.label28.AutoSize = true;
      this.label28.Location = new System.Drawing.Point(8, 41);
      this.label28.Name = "label28";
      this.label28.Size = new System.Drawing.Size(55, 13);
      this.label28.TabIndex = 77;
      this.label28.Text = "Full name:";
      // 
      // tbAddUserUserName
      // 
      this.tbAddUserUserName.Location = new System.Drawing.Point(101, 16);
      this.tbAddUserUserName.Name = "tbAddUserUserName";
      this.tbAddUserUserName.Size = new System.Drawing.Size(128, 20);
      this.tbAddUserUserName.TabIndex = 70;
      // 
      // label27
      // 
      this.label27.AutoSize = true;
      this.label27.Location = new System.Drawing.Point(8, 20);
      this.label27.Name = "label27";
      this.label27.Size = new System.Drawing.Size(58, 13);
      this.label27.TabIndex = 76;
      this.label27.Text = "Username:";
      // 
      // btModifyUser
      // 
      this.btModifyUser.Location = new System.Drawing.Point(434, 136);
      this.btModifyUser.Name = "btModifyUser";
      this.btModifyUser.Size = new System.Drawing.Size(68, 23);
      this.btModifyUser.TabIndex = 68;
      this.btModifyUser.Text = "Modify";
      this.btModifyUser.UseVisualStyleBackColor = true;
      this.btModifyUser.Click += new System.EventHandler(this.btModifyUser_Click);
      // 
      // cbRandomPaswordUsers
      // 
      this.cbRandomPaswordUsers.AutoSize = true;
      this.cbRandomPaswordUsers.Location = new System.Drawing.Point(434, 243);
      this.cbRandomPaswordUsers.Name = "cbRandomPaswordUsers";
      this.cbRandomPaswordUsers.Size = new System.Drawing.Size(148, 17);
      this.cbRandomPaswordUsers.TabIndex = 11;
      this.cbRandomPaswordUsers.Text = "Choose random password";
      this.cbRandomPaswordUsers.UseVisualStyleBackColor = true;
      this.cbRandomPaswordUsers.CheckedChanged += new System.EventHandler(this.cbRandomPaswordUsers_CheckedChanged);
      // 
      // lbSelectUserFirst
      // 
      this.lbSelectUserFirst.AutoSize = true;
      this.lbSelectUserFirst.ForeColor = System.Drawing.Color.Red;
      this.lbSelectUserFirst.Location = new System.Drawing.Point(263, -2);
      this.lbSelectUserFirst.Name = "lbSelectUserFirst";
      this.lbSelectUserFirst.Size = new System.Drawing.Size(99, 13);
      this.lbSelectUserFirst.TabIndex = 42;
      this.lbSelectUserFirst.Text = "*First select an user";
      this.lbSelectUserFirst.Visible = false;
      // 
      // btDeleteUser
      // 
      this.btDeleteUser.Location = new System.Drawing.Point(503, 136);
      this.btDeleteUser.Name = "btDeleteUser";
      this.btDeleteUser.Size = new System.Drawing.Size(68, 23);
      this.btDeleteUser.TabIndex = 64;
      this.btDeleteUser.Text = "Delete";
      this.btDeleteUser.UseVisualStyleBackColor = true;
      this.btDeleteUser.Click += new System.EventHandler(this.btDeleteUser_Click);
      // 
      // ttSavePasswordInLogFile
      // 
      this.ttSavePasswordInLogFile.Image = ((System.Drawing.Image)(resources.GetObject("ttSavePasswordInLogFile.Image")));
      this.ttSavePasswordInLogFile.Location = new System.Drawing.Point(481, 264);
      this.ttSavePasswordInLogFile.Name = "ttSavePasswordInLogFile";
      this.ttSavePasswordInLogFile.Size = new System.Drawing.Size(16, 16);
      this.ttSavePasswordInLogFile.TabIndex = 39;
      this.ttSavePasswordInLogFile.TabStop = false;
      this.ttSavePasswordInLogFile.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // cbSavePasswordInLogFile
      // 
      this.cbSavePasswordInLogFile.AutoSize = true;
      this.cbSavePasswordInLogFile.Location = new System.Drawing.Point(503, 263);
      this.cbSavePasswordInLogFile.Name = "cbSavePasswordInLogFile";
      this.cbSavePasswordInLogFile.Size = new System.Drawing.Size(117, 17);
      this.cbSavePasswordInLogFile.TabIndex = 21;
      this.cbSavePasswordInLogFile.Text = "Save all passwords";
      this.cbSavePasswordInLogFile.UseVisualStyleBackColor = true;
      this.cbSavePasswordInLogFile.CheckedChanged += new System.EventHandler(this.cbSavePasswordInLogFile_CheckedChanged);
      // 
      // cbAccountDisabled
      // 
      this.cbAccountDisabled.AutoSize = true;
      this.cbAccountDisabled.Location = new System.Drawing.Point(434, 226);
      this.cbAccountDisabled.Name = "cbAccountDisabled";
      this.cbAccountDisabled.Size = new System.Drawing.Size(118, 17);
      this.cbAccountDisabled.TabIndex = 10;
      this.cbAccountDisabled.Text = "Account is disabled";
      this.cbAccountDisabled.UseVisualStyleBackColor = true;
      // 
      // cbPaswordNeverExpires
      // 
      this.cbPaswordNeverExpires.AutoSize = true;
      this.cbPaswordNeverExpires.Enabled = false;
      this.cbPaswordNeverExpires.Location = new System.Drawing.Point(434, 210);
      this.cbPaswordNeverExpires.Name = "cbPaswordNeverExpires";
      this.cbPaswordNeverExpires.Size = new System.Drawing.Size(138, 17);
      this.cbPaswordNeverExpires.TabIndex = 9;
      this.cbPaswordNeverExpires.Text = "Password never expires";
      this.cbPaswordNeverExpires.UseVisualStyleBackColor = true;
      this.cbPaswordNeverExpires.CheckedChanged += new System.EventHandler(this.cbPaswordNeverExpires_CheckedChanged);
      // 
      // cbPaswordCantBeChanged
      // 
      this.cbPaswordCantBeChanged.AutoSize = true;
      this.cbPaswordCantBeChanged.Enabled = false;
      this.cbPaswordCantBeChanged.Location = new System.Drawing.Point(434, 193);
      this.cbPaswordCantBeChanged.Name = "cbPaswordCantBeChanged";
      this.cbPaswordCantBeChanged.Size = new System.Drawing.Size(174, 17);
      this.cbPaswordCantBeChanged.TabIndex = 8;
      this.cbPaswordCantBeChanged.Text = "User can not change password";
      this.cbPaswordCantBeChanged.UseVisualStyleBackColor = true;
      this.cbPaswordCantBeChanged.CheckedChanged += new System.EventHandler(this.cbPaswordCantBeChanged_CheckedChanged);
      // 
      // cbChangePwNextLogon
      // 
      this.cbChangePwNextLogon.AutoSize = true;
      this.cbChangePwNextLogon.Checked = true;
      this.cbChangePwNextLogon.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbChangePwNextLogon.Location = new System.Drawing.Point(434, 165);
      this.cbChangePwNextLogon.Name = "cbChangePwNextLogon";
      this.cbChangePwNextLogon.Size = new System.Drawing.Size(163, 30);
      this.cbChangePwNextLogon.TabIndex = 7;
      this.cbChangePwNextLogon.Text = "User must change password \r\nin the next login";
      this.cbChangePwNextLogon.UseVisualStyleBackColor = true;
      this.cbChangePwNextLogon.CheckedChanged += new System.EventHandler(this.cbChangePwNextLogon_CheckedChanged);
      // 
      // label26
      // 
      this.label26.AutoSize = true;
      this.label26.Location = new System.Drawing.Point(5, -2);
      this.label26.Name = "label26";
      this.label26.Size = new System.Drawing.Size(63, 13);
      this.label26.TabIndex = 30;
      this.label26.Text = "List of users";
      // 
      // lvUsers
      // 
      this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
      this.lvUsers.FullRowSelect = true;
      this.lvUsers.GridLines = true;
      this.lvUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lvUsers.Location = new System.Drawing.Point(8, 14);
      this.lvUsers.Name = "lvUsers";
      this.lvUsers.Size = new System.Drawing.Size(589, 112);
      this.lvUsers.TabIndex = 28;
      this.lvUsers.UseCompatibleStateImageBehavior = false;
      this.lvUsers.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Name";
      this.columnHeader1.Width = 92;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Fullname";
      this.columnHeader2.Width = 169;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Description";
      this.columnHeader3.Width = 323;
      // 
      // wpAutoPlayAndWExplorer
      // 
      this.wpAutoPlayAndWExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpAutoPlayAndWExplorer.AntiAlias = false;
      this.wpAutoPlayAndWExplorer.BackColor = System.Drawing.Color.Transparent;
      this.wpAutoPlayAndWExplorer.Controls.Add(this.gbExplorerSettings);
      this.wpAutoPlayAndWExplorer.Controls.Add(this.groupBox2);
      this.wpAutoPlayAndWExplorer.Location = new System.Drawing.Point(7, 72);
      this.wpAutoPlayAndWExplorer.Name = "wpAutoPlayAndWExplorer";
      this.wpAutoPlayAndWExplorer.PageDescription = "Change the settings here for AutoPlay in Windows Explorer:";
      this.wpAutoPlayAndWExplorer.PageTitle = "Windows settings";
      this.wpAutoPlayAndWExplorer.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.SecurityAndLockdown;
      this.wpAutoPlayAndWExplorer.Size = new System.Drawing.Size(608, 283);
      this.wpAutoPlayAndWExplorer.TabIndex = 13;
      this.wpAutoPlayAndWExplorer.BackButtonClick += new System.ComponentModel.CancelEventHandler(this.wpAutoPlayAndWExplorer_BackButtonClick);
      this.wpAutoPlayAndWExplorer.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpAutoPlayAndWExplorer_NextButtonClick);
      // 
      // gbExplorerSettings
      // 
      this.gbExplorerSettings.Controls.Add(this.lbWesASNFP);
      this.gbExplorerSettings.Controls.Add(this.lbWesDCSF);
      this.gbExplorerSettings.Controls.Add(this.tbWesDCSF);
      this.gbExplorerSettings.Controls.Add(this.tbWesASNFP);
      this.gbExplorerSettings.Controls.Add(this.lbWesDFPAB);
      this.gbExplorerSettings.Controls.Add(this.tbWesDFPAB);
      this.gbExplorerSettings.Controls.Add(this.lbWesSHFF);
      this.gbExplorerSettings.Controls.Add(this.tbWesSHFF);
      this.gbExplorerSettings.Controls.Add(this.lbWesHEKF);
      this.gbExplorerSettings.Controls.Add(this.ttAutoSearchFoldersPrinters);
      this.gbExplorerSettings.Controls.Add(this.cbWesASNFP);
      this.gbExplorerSettings.Controls.Add(this.tbWesHEKF);
      this.gbExplorerSettings.Controls.Add(this.lbWesHPOSF);
      this.gbExplorerSettings.Controls.Add(this.tbWesHPOSF);
      this.gbExplorerSettings.Controls.Add(this.lbWesREFS);
      this.gbExplorerSettings.Controls.Add(this.tbWesREFS);
      this.gbExplorerSettings.Controls.Add(this.lbWesSECFC);
      this.gbExplorerSettings.Controls.Add(this.tbWesSECFC);
      this.gbExplorerSettings.Controls.Add(this.ttShowNTFSinBlue);
      this.gbExplorerSettings.Controls.Add(this.ttRembemberViewSettings);
      this.gbExplorerSettings.Controls.Add(this.ttHideProtectedSysFiles);
      this.gbExplorerSettings.Controls.Add(this.ttHideExtensions);
      this.gbExplorerSettings.Controls.Add(this.ttShowHiddenFolders);
      this.gbExplorerSettings.Controls.Add(this.ttDisplayFullPathAddressBar);
      this.gbExplorerSettings.Controls.Add(this.ttDisplayContentsSysFolders);
      this.gbExplorerSettings.Controls.Add(this.cbWesSECFC);
      this.gbExplorerSettings.Controls.Add(this.cbWesREFS);
      this.gbExplorerSettings.Controls.Add(this.cbWesHPOSF);
      this.gbExplorerSettings.Controls.Add(this.cbWesHEKF);
      this.gbExplorerSettings.Controls.Add(this.cbWesSHFF);
      this.gbExplorerSettings.Controls.Add(this.cbWesDFPAB);
      this.gbExplorerSettings.Controls.Add(this.cbWesDCSF);
      this.gbExplorerSettings.Location = new System.Drawing.Point(0, 93);
      this.gbExplorerSettings.Name = "gbExplorerSettings";
      this.gbExplorerSettings.Size = new System.Drawing.Size(603, 190);
      this.gbExplorerSettings.TabIndex = 9;
      this.gbExplorerSettings.TabStop = false;
      this.gbExplorerSettings.Text = "Windows Explorer settings";
      // 
      // lbWesASNFP
      // 
      this.lbWesASNFP.AutoSize = true;
      this.lbWesASNFP.Location = new System.Drawing.Point(22, 155);
      this.lbWesASNFP.Name = "lbWesASNFP";
      this.lbWesASNFP.Size = new System.Drawing.Size(54, 13);
      this.lbWesASNFP.TabIndex = 113;
      this.lbWesASNFP.Text = "Comment:";
      this.lbWesASNFP.Visible = false;
      // 
      // lbWesDCSF
      // 
      this.lbWesDCSF.AutoSize = true;
      this.lbWesDCSF.Location = new System.Drawing.Point(22, 36);
      this.lbWesDCSF.Name = "lbWesDCSF";
      this.lbWesDCSF.Size = new System.Drawing.Size(54, 13);
      this.lbWesDCSF.TabIndex = 111;
      this.lbWesDCSF.Text = "Comment:";
      this.lbWesDCSF.Visible = false;
      // 
      // tbWesDCSF
      // 
      this.tbWesDCSF.Location = new System.Drawing.Point(82, 34);
      this.tbWesDCSF.Name = "tbWesDCSF";
      this.tbWesDCSF.Size = new System.Drawing.Size(171, 20);
      this.tbWesDCSF.TabIndex = 13;
      this.tbWesDCSF.Visible = false;
      // 
      // tbWesASNFP
      // 
      this.tbWesASNFP.Location = new System.Drawing.Point(82, 148);
      this.tbWesASNFP.Name = "tbWesASNFP";
      this.tbWesASNFP.Size = new System.Drawing.Size(171, 20);
      this.tbWesASNFP.TabIndex = 16;
      this.tbWesASNFP.Visible = false;
      // 
      // lbWesDFPAB
      // 
      this.lbWesDFPAB.AutoSize = true;
      this.lbWesDFPAB.Location = new System.Drawing.Point(22, 72);
      this.lbWesDFPAB.Name = "lbWesDFPAB";
      this.lbWesDFPAB.Size = new System.Drawing.Size(54, 13);
      this.lbWesDFPAB.TabIndex = 109;
      this.lbWesDFPAB.Text = "Comment:";
      this.lbWesDFPAB.Visible = false;
      // 
      // tbWesDFPAB
      // 
      this.tbWesDFPAB.Location = new System.Drawing.Point(82, 69);
      this.tbWesDFPAB.Name = "tbWesDFPAB";
      this.tbWesDFPAB.Size = new System.Drawing.Size(171, 20);
      this.tbWesDFPAB.TabIndex = 14;
      this.tbWesDFPAB.Visible = false;
      // 
      // lbWesSHFF
      // 
      this.lbWesSHFF.AutoSize = true;
      this.lbWesSHFF.Location = new System.Drawing.Point(18, 109);
      this.lbWesSHFF.Name = "lbWesSHFF";
      this.lbWesSHFF.Size = new System.Drawing.Size(54, 13);
      this.lbWesSHFF.TabIndex = 107;
      this.lbWesSHFF.Text = "Comment:";
      this.lbWesSHFF.Visible = false;
      // 
      // tbWesSHFF
      // 
      this.tbWesSHFF.Location = new System.Drawing.Point(82, 104);
      this.tbWesSHFF.Name = "tbWesSHFF";
      this.tbWesSHFF.Size = new System.Drawing.Size(171, 20);
      this.tbWesSHFF.TabIndex = 15;
      this.tbWesSHFF.Visible = false;
      // 
      // lbWesHEKF
      // 
      this.lbWesHEKF.AutoSize = true;
      this.lbWesHEKF.Location = new System.Drawing.Point(314, 36);
      this.lbWesHEKF.Name = "lbWesHEKF";
      this.lbWesHEKF.Size = new System.Drawing.Size(54, 13);
      this.lbWesHEKF.TabIndex = 105;
      this.lbWesHEKF.Text = "Comment:";
      this.lbWesHEKF.Visible = false;
      // 
      // ttAutoSearchFoldersPrinters
      // 
      this.ttAutoSearchFoldersPrinters.Image = ((System.Drawing.Image)(resources.GetObject("ttAutoSearchFoldersPrinters.Image")));
      this.ttAutoSearchFoldersPrinters.Location = new System.Drawing.Point(17, 131);
      this.ttAutoSearchFoldersPrinters.Name = "ttAutoSearchFoldersPrinters";
      this.ttAutoSearchFoldersPrinters.Size = new System.Drawing.Size(16, 16);
      this.ttAutoSearchFoldersPrinters.TabIndex = 90;
      this.ttAutoSearchFoldersPrinters.TabStop = false;
      this.ttAutoSearchFoldersPrinters.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // cbWesASNFP
      // 
      this.cbWesASNFP.Location = new System.Drawing.Point(39, 116);
      this.cbWesASNFP.Name = "cbWesASNFP";
      this.cbWesASNFP.Size = new System.Drawing.Size(269, 43);
      this.cbWesASNFP.TabIndex = 8;
      this.cbWesASNFP.Text = "Automatic search for network folders and printers";
      this.cbWesASNFP.UseVisualStyleBackColor = true;
      this.cbWesASNFP.CheckedChanged += new System.EventHandler(this.cbWesASNFP_CheckedChanged);
      // 
      // tbWesHEKF
      // 
      this.tbWesHEKF.Location = new System.Drawing.Point(373, 34);
      this.tbWesHEKF.Name = "tbWesHEKF";
      this.tbWesHEKF.Size = new System.Drawing.Size(171, 20);
      this.tbWesHEKF.TabIndex = 17;
      this.tbWesHEKF.Visible = false;
      // 
      // lbWesHPOSF
      // 
      this.lbWesHPOSF.AutoSize = true;
      this.lbWesHPOSF.Location = new System.Drawing.Point(314, 69);
      this.lbWesHPOSF.Name = "lbWesHPOSF";
      this.lbWesHPOSF.Size = new System.Drawing.Size(54, 13);
      this.lbWesHPOSF.TabIndex = 103;
      this.lbWesHPOSF.Text = "Comment:";
      this.lbWesHPOSF.Visible = false;
      // 
      // tbWesHPOSF
      // 
      this.tbWesHPOSF.Location = new System.Drawing.Point(373, 69);
      this.tbWesHPOSF.Name = "tbWesHPOSF";
      this.tbWesHPOSF.Size = new System.Drawing.Size(171, 20);
      this.tbWesHPOSF.TabIndex = 18;
      this.tbWesHPOSF.Visible = false;
      // 
      // lbWesREFS
      // 
      this.lbWesREFS.AutoSize = true;
      this.lbWesREFS.Location = new System.Drawing.Point(314, 109);
      this.lbWesREFS.Name = "lbWesREFS";
      this.lbWesREFS.Size = new System.Drawing.Size(54, 13);
      this.lbWesREFS.TabIndex = 101;
      this.lbWesREFS.Text = "Comment:";
      this.lbWesREFS.Visible = false;
      // 
      // tbWesREFS
      // 
      this.tbWesREFS.Location = new System.Drawing.Point(373, 106);
      this.tbWesREFS.Name = "tbWesREFS";
      this.tbWesREFS.Size = new System.Drawing.Size(171, 20);
      this.tbWesREFS.TabIndex = 19;
      this.tbWesREFS.Visible = false;
      // 
      // lbWesSECFC
      // 
      this.lbWesSECFC.AutoSize = true;
      this.lbWesSECFC.Location = new System.Drawing.Point(314, 158);
      this.lbWesSECFC.Name = "lbWesSECFC";
      this.lbWesSECFC.Size = new System.Drawing.Size(54, 13);
      this.lbWesSECFC.TabIndex = 99;
      this.lbWesSECFC.Text = "Comment:";
      this.lbWesSECFC.Visible = false;
      // 
      // tbWesSECFC
      // 
      this.tbWesSECFC.Location = new System.Drawing.Point(373, 155);
      this.tbWesSECFC.Name = "tbWesSECFC";
      this.tbWesSECFC.Size = new System.Drawing.Size(171, 20);
      this.tbWesSECFC.TabIndex = 20;
      this.tbWesSECFC.Visible = false;
      // 
      // ttShowNTFSinBlue
      // 
      this.ttShowNTFSinBlue.Image = ((System.Drawing.Image)(resources.GetObject("ttShowNTFSinBlue.Image")));
      this.ttShowNTFSinBlue.Location = new System.Drawing.Point(314, 131);
      this.ttShowNTFSinBlue.Name = "ttShowNTFSinBlue";
      this.ttShowNTFSinBlue.Size = new System.Drawing.Size(16, 16);
      this.ttShowNTFSinBlue.TabIndex = 97;
      this.ttShowNTFSinBlue.TabStop = false;
      this.ttShowNTFSinBlue.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // ttRembemberViewSettings
      // 
      this.ttRembemberViewSettings.Image = ((System.Drawing.Image)(resources.GetObject("ttRembemberViewSettings.Image")));
      this.ttRembemberViewSettings.Location = new System.Drawing.Point(314, 89);
      this.ttRembemberViewSettings.Name = "ttRembemberViewSettings";
      this.ttRembemberViewSettings.Size = new System.Drawing.Size(16, 16);
      this.ttRembemberViewSettings.TabIndex = 96;
      this.ttRembemberViewSettings.TabStop = false;
      this.ttRembemberViewSettings.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // ttHideProtectedSysFiles
      // 
      this.ttHideProtectedSysFiles.Image = ((System.Drawing.Image)(resources.GetObject("ttHideProtectedSysFiles.Image")));
      this.ttHideProtectedSysFiles.Location = new System.Drawing.Point(314, 53);
      this.ttHideProtectedSysFiles.Name = "ttHideProtectedSysFiles";
      this.ttHideProtectedSysFiles.Size = new System.Drawing.Size(16, 16);
      this.ttHideProtectedSysFiles.TabIndex = 95;
      this.ttHideProtectedSysFiles.TabStop = false;
      this.ttHideProtectedSysFiles.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // ttHideExtensions
      // 
      this.ttHideExtensions.Image = ((System.Drawing.Image)(resources.GetObject("ttHideExtensions.Image")));
      this.ttHideExtensions.Location = new System.Drawing.Point(314, 17);
      this.ttHideExtensions.Name = "ttHideExtensions";
      this.ttHideExtensions.Size = new System.Drawing.Size(16, 16);
      this.ttHideExtensions.TabIndex = 94;
      this.ttHideExtensions.TabStop = false;
      this.ttHideExtensions.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // ttShowHiddenFolders
      // 
      this.ttShowHiddenFolders.Image = ((System.Drawing.Image)(resources.GetObject("ttShowHiddenFolders.Image")));
      this.ttShowHiddenFolders.Location = new System.Drawing.Point(17, 89);
      this.ttShowHiddenFolders.Name = "ttShowHiddenFolders";
      this.ttShowHiddenFolders.Size = new System.Drawing.Size(16, 16);
      this.ttShowHiddenFolders.TabIndex = 93;
      this.ttShowHiddenFolders.TabStop = false;
      this.ttShowHiddenFolders.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // ttDisplayFullPathAddressBar
      // 
      this.ttDisplayFullPathAddressBar.Image = ((System.Drawing.Image)(resources.GetObject("ttDisplayFullPathAddressBar.Image")));
      this.ttDisplayFullPathAddressBar.Location = new System.Drawing.Point(17, 53);
      this.ttDisplayFullPathAddressBar.Name = "ttDisplayFullPathAddressBar";
      this.ttDisplayFullPathAddressBar.Size = new System.Drawing.Size(16, 16);
      this.ttDisplayFullPathAddressBar.TabIndex = 92;
      this.ttDisplayFullPathAddressBar.TabStop = false;
      this.ttDisplayFullPathAddressBar.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // ttDisplayContentsSysFolders
      // 
      this.ttDisplayContentsSysFolders.Image = ((System.Drawing.Image)(resources.GetObject("ttDisplayContentsSysFolders.Image")));
      this.ttDisplayContentsSysFolders.Location = new System.Drawing.Point(17, 17);
      this.ttDisplayContentsSysFolders.Name = "ttDisplayContentsSysFolders";
      this.ttDisplayContentsSysFolders.Size = new System.Drawing.Size(16, 16);
      this.ttDisplayContentsSysFolders.TabIndex = 91;
      this.ttDisplayContentsSysFolders.TabStop = false;
      this.ttDisplayContentsSysFolders.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // cbWesSECFC
      // 
      this.cbWesSECFC.Checked = true;
      this.cbWesSECFC.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbWesSECFC.Location = new System.Drawing.Point(336, 125);
      this.cbWesSECFC.Name = "cbWesSECFC";
      this.cbWesSECFC.Size = new System.Drawing.Size(261, 43);
      this.cbWesSECFC.TabIndex = 12;
      this.cbWesSECFC.Text = "Show Encrypted or compressed NTFS files in color";
      this.cbWesSECFC.TextAlign = System.Drawing.ContentAlignment.TopLeft;
      this.cbWesSECFC.UseVisualStyleBackColor = true;
      this.cbWesSECFC.CheckedChanged += new System.EventHandler(this.cbWesSECFC_CheckedChanged);
      // 
      // cbWesREFS
      // 
      this.cbWesREFS.AutoSize = true;
      this.cbWesREFS.Location = new System.Drawing.Point(336, 89);
      this.cbWesREFS.Name = "cbWesREFS";
      this.cbWesREFS.Size = new System.Drawing.Size(180, 17);
      this.cbWesREFS.TabIndex = 11;
      this.cbWesREFS.Text = "The view settings for each folder";
      this.cbWesREFS.UseVisualStyleBackColor = true;
      this.cbWesREFS.CheckedChanged += new System.EventHandler(this.cbWesREFS_CheckedChanged);
      // 
      // cbWesHPOSF
      // 
      this.cbWesHPOSF.AutoSize = true;
      this.cbWesHPOSF.Location = new System.Drawing.Point(336, 53);
      this.cbWesHPOSF.Name = "cbWesHPOSF";
      this.cbWesHPOSF.Size = new System.Drawing.Size(199, 17);
      this.cbWesHPOSF.TabIndex = 10;
      this.cbWesHPOSF.Text = "Hide protected operating system files";
      this.cbWesHPOSF.UseVisualStyleBackColor = true;
      this.cbWesHPOSF.CheckedChanged += new System.EventHandler(this.cbWesHPOSF_CheckedChanged);
      // 
      // cbWesHEKF
      // 
      this.cbWesHEKF.AutoSize = true;
      this.cbWesHEKF.Location = new System.Drawing.Point(336, 18);
      this.cbWesHEKF.Name = "cbWesHEKF";
      this.cbWesHEKF.Size = new System.Drawing.Size(195, 17);
      this.cbWesHEKF.TabIndex = 9;
      this.cbWesHEKF.Text = "Hide extensions for known file types";
      this.cbWesHEKF.UseVisualStyleBackColor = true;
      this.cbWesHEKF.CheckedChanged += new System.EventHandler(this.cbWesHEKF_CheckedChanged);
      // 
      // cbWesSHFF
      // 
      this.cbWesSHFF.AutoSize = true;
      this.cbWesSHFF.Checked = true;
      this.cbWesSHFF.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbWesSHFF.Location = new System.Drawing.Point(39, 89);
      this.cbWesSHFF.Name = "cbWesSHFF";
      this.cbWesSHFF.Size = new System.Drawing.Size(164, 17);
      this.cbWesSHFF.TabIndex = 7;
      this.cbWesSHFF.Text = "Show hidden files and folders";
      this.cbWesSHFF.UseVisualStyleBackColor = true;
      this.cbWesSHFF.CheckedChanged += new System.EventHandler(this.cbWesSHFF_CheckedChanged);
      // 
      // cbWesDFPAB
      // 
      this.cbWesDFPAB.AutoSize = true;
      this.cbWesDFPAB.Checked = true;
      this.cbWesDFPAB.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbWesDFPAB.Location = new System.Drawing.Point(39, 53);
      this.cbWesDFPAB.Name = "cbWesDFPAB";
      this.cbWesDFPAB.Size = new System.Drawing.Size(206, 17);
      this.cbWesDFPAB.TabIndex = 6;
      this.cbWesDFPAB.Text = "Display the full path in the Address bar";
      this.cbWesDFPAB.UseVisualStyleBackColor = true;
      this.cbWesDFPAB.CheckedChanged += new System.EventHandler(this.cbWesDFPAB_CheckedChanged);
      // 
      // cbWesDCSF
      // 
      this.cbWesDCSF.AutoSize = true;
      this.cbWesDCSF.Checked = true;
      this.cbWesDCSF.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbWesDCSF.Location = new System.Drawing.Point(39, 18);
      this.cbWesDCSF.Name = "cbWesDCSF";
      this.cbWesDCSF.Size = new System.Drawing.Size(196, 17);
      this.cbWesDCSF.TabIndex = 5;
      this.cbWesDCSF.Text = "Show the contents of system folders";
      this.cbWesDCSF.UseVisualStyleBackColor = true;
      this.cbWesDCSF.CheckedChanged += new System.EventHandler(this.cbWesDCSF_CheckedChanged);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.lbAutoPlayNotDefault);
      this.groupBox2.Controls.Add(this.ttAutoPlay);
      this.groupBox2.Controls.Add(this.tbAutoPlayNotDefault);
      this.groupBox2.Controls.Add(this.cbAutoplaydrives);
      this.groupBox2.Controls.Add(this.rbEnabledAP);
      this.groupBox2.Controls.Add(this.rbDisabledAP);
      this.groupBox2.Location = new System.Drawing.Point(0, -2);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(602, 92);
      this.groupBox2.TabIndex = 8;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Autoplay";
      // 
      // lbAutoPlayNotDefault
      // 
      this.lbAutoPlayNotDefault.AutoSize = true;
      this.lbAutoPlayNotDefault.Location = new System.Drawing.Point(360, 19);
      this.lbAutoPlayNotDefault.Name = "lbAutoPlayNotDefault";
      this.lbAutoPlayNotDefault.Size = new System.Drawing.Size(213, 13);
      this.lbAutoPlayNotDefault.TabIndex = 116;
      this.lbAutoPlayNotDefault.Text = "This is not a prefered setting, give a reason:";
      this.lbAutoPlayNotDefault.Visible = false;
      // 
      // ttAutoPlay
      // 
      this.ttAutoPlay.Image = ((System.Drawing.Image)(resources.GetObject("ttAutoPlay.Image")));
      this.ttAutoPlay.Location = new System.Drawing.Point(228, 64);
      this.ttAutoPlay.Name = "ttAutoPlay";
      this.ttAutoPlay.Size = new System.Drawing.Size(16, 16);
      this.ttAutoPlay.TabIndex = 39;
      this.ttAutoPlay.TabStop = false;
      this.ttAutoPlay.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // tbAutoPlayNotDefault
      // 
      this.tbAutoPlayNotDefault.Location = new System.Drawing.Point(373, 41);
      this.tbAutoPlayNotDefault.Name = "tbAutoPlayNotDefault";
      this.tbAutoPlayNotDefault.Size = new System.Drawing.Size(171, 20);
      this.tbAutoPlayNotDefault.TabIndex = 4;
      this.tbAutoPlayNotDefault.Visible = false;
      // 
      // cbAutoplaydrives
      // 
      this.cbAutoplaydrives.FormattingEnabled = true;
      this.cbAutoplaydrives.Items.AddRange(new object[] {
            "CD-ROM and removable media drives",
            "All drives "});
      this.cbAutoplaydrives.Location = new System.Drawing.Point(18, 64);
      this.cbAutoplaydrives.Name = "cbAutoplaydrives";
      this.cbAutoplaydrives.Size = new System.Drawing.Size(204, 21);
      this.cbAutoplaydrives.TabIndex = 3;
      this.cbAutoplaydrives.Text = "All drives ";
      this.cbAutoplaydrives.SelectedValueChanged += new System.EventHandler(this.cbAutoplaydrives_SelectedValueChanged);
      // 
      // rbEnabledAP
      // 
      this.rbEnabledAP.AutoSize = true;
      this.rbEnabledAP.Location = new System.Drawing.Point(18, 19);
      this.rbEnabledAP.Name = "rbEnabledAP";
      this.rbEnabledAP.Size = new System.Drawing.Size(101, 17);
      this.rbEnabledAP.TabIndex = 1;
      this.rbEnabledAP.Text = "Enable autoplay";
      this.rbEnabledAP.UseVisualStyleBackColor = true;
      // 
      // rbDisabledAP
      // 
      this.rbDisabledAP.AutoSize = true;
      this.rbDisabledAP.Checked = true;
      this.rbDisabledAP.Location = new System.Drawing.Point(18, 41);
      this.rbDisabledAP.Name = "rbDisabledAP";
      this.rbDisabledAP.Size = new System.Drawing.Size(122, 17);
      this.rbDisabledAP.TabIndex = 2;
      this.rbDisabledAP.TabStop = true;
      this.rbDisabledAP.Text = "Disable Autoplay for:";
      this.rbDisabledAP.UseVisualStyleBackColor = true;
      this.rbDisabledAP.CheckedChanged += new System.EventHandler(this.rbDisabledAP_CheckedChanged);
      // 
      // wpAutoLogonAndEventTracker
      // 
      this.wpAutoLogonAndEventTracker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpAutoLogonAndEventTracker.AntiAlias = false;
      this.wpAutoLogonAndEventTracker.BackColor = System.Drawing.Color.Transparent;
      this.wpAutoLogonAndEventTracker.Controls.Add(this.groupBox15);
      this.wpAutoLogonAndEventTracker.Controls.Add(this.groupBox8);
      this.wpAutoLogonAndEventTracker.Location = new System.Drawing.Point(7, 72);
      this.wpAutoLogonAndEventTracker.Name = "wpAutoLogonAndEventTracker";
      this.wpAutoLogonAndEventTracker.PageDescription = "Change the settings here for Automatic Login, Shutdown event tracker and Remote D" +
    "esktop";
      this.wpAutoLogonAndEventTracker.PageTitle = "Windows settings";
      this.wpAutoLogonAndEventTracker.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.Security;
      this.wpAutoLogonAndEventTracker.Size = new System.Drawing.Size(608, 283);
      this.wpAutoLogonAndEventTracker.TabIndex = 14;
      this.wpAutoLogonAndEventTracker.BackButtonClick += new System.ComponentModel.CancelEventHandler(this.wpAutoLogonAndEventTracker_BackButtonClick);
      this.wpAutoLogonAndEventTracker.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpAutoLogonAndEventTracker_NextButtonClick);
      // 
      // groupBox15
      // 
      this.groupBox15.Controls.Add(this.lbRemoteDesktopNotDefault);
      this.groupBox15.Controls.Add(this.tbRemoteDesktopNotDefault);
      this.groupBox15.Controls.Add(this.ttRemoteDesktopAddUsers);
      this.groupBox15.Controls.Add(this.label34);
      this.groupBox15.Controls.Add(this.btRemoveRemoteDesktopUser);
      this.groupBox15.Controls.Add(this.listbRemoteDesktopUsers);
      this.groupBox15.Controls.Add(this.combRemoteDesktopUsers);
      this.groupBox15.Controls.Add(this.rbRemoteDesktopOnMoreSecure);
      this.groupBox15.Controls.Add(this.rbRemoteDesktopOnLessSecure);
      this.groupBox15.Controls.Add(this.label114);
      this.groupBox15.Controls.Add(this.rbRemoteDesktopOff);
      this.groupBox15.Location = new System.Drawing.Point(290, 1);
      this.groupBox15.Name = "groupBox15";
      this.groupBox15.Size = new System.Drawing.Size(319, 283);
      this.groupBox15.TabIndex = 10;
      this.groupBox15.TabStop = false;
      this.groupBox15.Text = "Remote Desktop";
      // 
      // lbRemoteDesktopNotDefault
      // 
      this.lbRemoteDesktopNotDefault.AutoSize = true;
      this.lbRemoteDesktopNotDefault.Location = new System.Drawing.Point(21, 119);
      this.lbRemoteDesktopNotDefault.Name = "lbRemoteDesktopNotDefault";
      this.lbRemoteDesktopNotDefault.Size = new System.Drawing.Size(54, 13);
      this.lbRemoteDesktopNotDefault.TabIndex = 119;
      this.lbRemoteDesktopNotDefault.Text = "Comment:";
      this.lbRemoteDesktopNotDefault.Visible = false;
      // 
      // tbRemoteDesktopNotDefault
      // 
      this.tbRemoteDesktopNotDefault.Location = new System.Drawing.Point(83, 116);
      this.tbRemoteDesktopNotDefault.Name = "tbRemoteDesktopNotDefault";
      this.tbRemoteDesktopNotDefault.Size = new System.Drawing.Size(171, 20);
      this.tbRemoteDesktopNotDefault.TabIndex = 10;
      this.tbRemoteDesktopNotDefault.Visible = false;
      // 
      // ttRemoteDesktopAddUsers
      // 
      this.ttRemoteDesktopAddUsers.Image = ((System.Drawing.Image)(resources.GetObject("ttRemoteDesktopAddUsers.Image")));
      this.ttRemoteDesktopAddUsers.Location = new System.Drawing.Point(258, 146);
      this.ttRemoteDesktopAddUsers.Name = "ttRemoteDesktopAddUsers";
      this.ttRemoteDesktopAddUsers.Size = new System.Drawing.Size(16, 16);
      this.ttRemoteDesktopAddUsers.TabIndex = 41;
      this.ttRemoteDesktopAddUsers.TabStop = false;
      this.ttRemoteDesktopAddUsers.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // label34
      // 
      this.label34.AutoSize = true;
      this.label34.Location = new System.Drawing.Point(12, 146);
      this.label34.Name = "label34";
      this.label34.Size = new System.Drawing.Size(240, 13);
      this.label34.TabIndex = 12;
      this.label34.Text = "Select local users who can use Remote Desktop:";
      // 
      // btRemoveRemoteDesktopUser
      // 
      this.btRemoveRemoteDesktopUser.Enabled = false;
      this.btRemoveRemoteDesktopUser.Location = new System.Drawing.Point(224, 231);
      this.btRemoveRemoteDesktopUser.Name = "btRemoveRemoteDesktopUser";
      this.btRemoveRemoteDesktopUser.Size = new System.Drawing.Size(75, 23);
      this.btRemoveRemoteDesktopUser.TabIndex = 12;
      this.btRemoveRemoteDesktopUser.Text = "Remove";
      this.btRemoveRemoteDesktopUser.UseVisualStyleBackColor = true;
      this.btRemoveRemoteDesktopUser.Click += new System.EventHandler(this.btRemoveRemoteDesktopUser_Click);
      // 
      // listbRemoteDesktopUsers
      // 
      this.listbRemoteDesktopUsers.Enabled = false;
      this.listbRemoteDesktopUsers.FormattingEnabled = true;
      this.listbRemoteDesktopUsers.Location = new System.Drawing.Point(15, 202);
      this.listbRemoteDesktopUsers.Name = "listbRemoteDesktopUsers";
      this.listbRemoteDesktopUsers.Size = new System.Drawing.Size(203, 56);
      this.listbRemoteDesktopUsers.TabIndex = 10;
      // 
      // combRemoteDesktopUsers
      // 
      this.combRemoteDesktopUsers.Enabled = false;
      this.combRemoteDesktopUsers.FormattingEnabled = true;
      this.combRemoteDesktopUsers.Location = new System.Drawing.Point(14, 175);
      this.combRemoteDesktopUsers.Name = "combRemoteDesktopUsers";
      this.combRemoteDesktopUsers.Size = new System.Drawing.Size(204, 21);
      this.combRemoteDesktopUsers.TabIndex = 11;
      this.combRemoteDesktopUsers.Text = "<none>";
      this.combRemoteDesktopUsers.SelectedIndexChanged += new System.EventHandler(this.combRemoteDesktopUsers_SelectedIndexChanged);
      // 
      // rbRemoteDesktopOnMoreSecure
      // 
      this.rbRemoteDesktopOnMoreSecure.AutoSize = true;
      this.rbRemoteDesktopOnMoreSecure.Location = new System.Drawing.Point(7, 85);
      this.rbRemoteDesktopOnMoreSecure.Name = "rbRemoteDesktopOnMoreSecure";
      this.rbRemoteDesktopOnMoreSecure.Size = new System.Drawing.Size(292, 30);
      this.rbRemoteDesktopOnMoreSecure.TabIndex = 9;
      this.rbRemoteDesktopOnMoreSecure.Text = "Yes, all computers with \"Remote desktop\" with Network \r\nlevel authentication is a" +
    "llowed. (safer)";
      this.rbRemoteDesktopOnMoreSecure.UseVisualStyleBackColor = true;
      // 
      // rbRemoteDesktopOnLessSecure
      // 
      this.rbRemoteDesktopOnLessSecure.AutoSize = true;
      this.rbRemoteDesktopOnLessSecure.Location = new System.Drawing.Point(7, 56);
      this.rbRemoteDesktopOnLessSecure.Name = "rbRemoteDesktopOnLessSecure";
      this.rbRemoteDesktopOnLessSecure.Size = new System.Drawing.Size(299, 30);
      this.rbRemoteDesktopOnLessSecure.TabIndex = 8;
      this.rbRemoteDesktopOnLessSecure.Text = "Yes, computers running any version of \"Remote desktop\" \r\nare allowed (less secure" +
    ") ";
      this.rbRemoteDesktopOnLessSecure.UseVisualStyleBackColor = true;
      // 
      // label114
      // 
      this.label114.AutoSize = true;
      this.label114.Location = new System.Drawing.Point(7, 20);
      this.label114.Name = "label114";
      this.label114.Size = new System.Drawing.Size(145, 13);
      this.label114.TabIndex = 6;
      this.label114.Text = "Allow outside connections to:";
      // 
      // rbRemoteDesktopOff
      // 
      this.rbRemoteDesktopOff.AutoSize = true;
      this.rbRemoteDesktopOff.Checked = true;
      this.rbRemoteDesktopOff.Location = new System.Drawing.Point(7, 40);
      this.rbRemoteDesktopOff.Name = "rbRemoteDesktopOff";
      this.rbRemoteDesktopOff.Size = new System.Drawing.Size(39, 17);
      this.rbRemoteDesktopOff.TabIndex = 7;
      this.rbRemoteDesktopOff.TabStop = true;
      this.rbRemoteDesktopOff.Text = "No";
      this.rbRemoteDesktopOff.UseVisualStyleBackColor = true;
      this.rbRemoteDesktopOff.CheckedChanged += new System.EventHandler(this.rbRemoteDesktopOff_CheckedChanged);
      // 
      // groupBox8
      // 
      this.groupBox8.Controls.Add(this.label118);
      this.groupBox8.Controls.Add(this.combAutoLogonUser);
      this.groupBox8.Controls.Add(this.lbAutoLogonNotDefault);
      this.groupBox8.Controls.Add(this.tbAutoLogonNotDefault);
      this.groupBox8.Controls.Add(this.lbShutDownEventTrackerNotDefault);
      this.groupBox8.Controls.Add(this.lbPasswordKnow);
      this.groupBox8.Controls.Add(this.tbShutDownEventTrackerNotDefault);
      this.groupBox8.Controls.Add(this.pbValidatePassWordAutoLogon);
      this.groupBox8.Controls.Add(this.label116);
      this.groupBox8.Controls.Add(this.tbAutoLogonPasword);
      this.groupBox8.Controls.Add(this.ttShutdownEventTracker);
      this.groupBox8.Controls.Add(this.combShutDEventTracker);
      this.groupBox8.Controls.Add(this.lbShutDownEventTracker);
      this.groupBox8.Controls.Add(this.cbAutoLogon);
      this.groupBox8.Location = new System.Drawing.Point(0, 0);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new System.Drawing.Size(289, 283);
      this.groupBox8.TabIndex = 9;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = "Login and Shutdown";
      // 
      // label118
      // 
      this.label118.AutoSize = true;
      this.label118.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label118.ForeColor = System.Drawing.Color.Red;
      this.label118.Location = new System.Drawing.Point(78, 10);
      this.label118.Name = "label118";
      this.label118.Size = new System.Drawing.Size(208, 15);
      this.label118.TabIndex = 42;
      this.label118.Text = "Remote desktop for testing by default";
      this.label118.Visible = false;
      // 
      // combAutoLogonUser
      // 
      this.combAutoLogonUser.Enabled = false;
      this.combAutoLogonUser.FormattingEnabled = true;
      this.combAutoLogonUser.Location = new System.Drawing.Point(18, 63);
      this.combAutoLogonUser.Name = "combAutoLogonUser";
      this.combAutoLogonUser.Size = new System.Drawing.Size(121, 21);
      this.combAutoLogonUser.TabIndex = 120;
      this.combAutoLogonUser.Text = "<none>";
      this.combAutoLogonUser.SelectedIndexChanged += new System.EventHandler(this.combAutoLogonUser_SelectedIndexChanged);
      // 
      // lbAutoLogonNotDefault
      // 
      this.lbAutoLogonNotDefault.AutoSize = true;
      this.lbAutoLogonNotDefault.Location = new System.Drawing.Point(15, 133);
      this.lbAutoLogonNotDefault.Name = "lbAutoLogonNotDefault";
      this.lbAutoLogonNotDefault.Size = new System.Drawing.Size(54, 13);
      this.lbAutoLogonNotDefault.TabIndex = 119;
      this.lbAutoLogonNotDefault.Text = "Comment:";
      this.lbAutoLogonNotDefault.Visible = false;
      // 
      // tbAutoLogonNotDefault
      // 
      this.tbAutoLogonNotDefault.Location = new System.Drawing.Point(77, 130);
      this.tbAutoLogonNotDefault.Name = "tbAutoLogonNotDefault";
      this.tbAutoLogonNotDefault.Size = new System.Drawing.Size(171, 20);
      this.tbAutoLogonNotDefault.TabIndex = 4;
      this.tbAutoLogonNotDefault.Visible = false;
      // 
      // lbShutDownEventTrackerNotDefault
      // 
      this.lbShutDownEventTrackerNotDefault.AutoSize = true;
      this.lbShutDownEventTrackerNotDefault.Location = new System.Drawing.Point(15, 201);
      this.lbShutDownEventTrackerNotDefault.Name = "lbShutDownEventTrackerNotDefault";
      this.lbShutDownEventTrackerNotDefault.Size = new System.Drawing.Size(52, 13);
      this.lbShutDownEventTrackerNotDefault.TabIndex = 117;
      this.lbShutDownEventTrackerNotDefault.Text = "Reasons:";
      this.lbShutDownEventTrackerNotDefault.Visible = false;
      // 
      // lbPasswordKnow
      // 
      this.lbPasswordKnow.AutoSize = true;
      this.lbPasswordKnow.Location = new System.Drawing.Point(166, 108);
      this.lbPasswordKnow.Name = "lbPasswordKnow";
      this.lbPasswordKnow.Size = new System.Drawing.Size(98, 13);
      this.lbPasswordKnow.TabIndex = 53;
      this.lbPasswordKnow.Text = "Password is known";
      this.lbPasswordKnow.Visible = false;
      // 
      // tbShutDownEventTrackerNotDefault
      // 
      this.tbShutDownEventTrackerNotDefault.Location = new System.Drawing.Point(68, 198);
      this.tbShutDownEventTrackerNotDefault.Name = "tbShutDownEventTrackerNotDefault";
      this.tbShutDownEventTrackerNotDefault.Size = new System.Drawing.Size(171, 20);
      this.tbShutDownEventTrackerNotDefault.TabIndex = 6;
      this.tbShutDownEventTrackerNotDefault.Visible = false;
      // 
      // pbValidatePassWordAutoLogon
      // 
      this.pbValidatePassWordAutoLogon.Location = new System.Drawing.Point(144, 106);
      this.pbValidatePassWordAutoLogon.Name = "pbValidatePassWordAutoLogon";
      this.pbValidatePassWordAutoLogon.Size = new System.Drawing.Size(16, 16);
      this.pbValidatePassWordAutoLogon.TabIndex = 52;
      this.pbValidatePassWordAutoLogon.TabStop = false;
      // 
      // label116
      // 
      this.label116.AutoSize = true;
      this.label116.Location = new System.Drawing.Point(15, 88);
      this.label116.Name = "label116";
      this.label116.Size = new System.Drawing.Size(53, 13);
      this.label116.TabIndex = 42;
      this.label116.Text = "Password";
      // 
      // tbAutoLogonPasword
      // 
      this.tbAutoLogonPasword.Enabled = false;
      this.tbAutoLogonPasword.Location = new System.Drawing.Point(18, 104);
      this.tbAutoLogonPasword.Name = "tbAutoLogonPasword";
      this.tbAutoLogonPasword.PasswordChar = '*';
      this.tbAutoLogonPasword.Size = new System.Drawing.Size(100, 20);
      this.tbAutoLogonPasword.TabIndex = 3;
      this.tbAutoLogonPasword.TextChanged += new System.EventHandler(this.tbAutoLogonPasword_TextChanged);
      // 
      // ttShutdownEventTracker
      // 
      this.ttShutdownEventTracker.Image = ((System.Drawing.Image)(resources.GetObject("ttShutdownEventTracker.Image")));
      this.ttShutdownEventTracker.Location = new System.Drawing.Point(143, 174);
      this.ttShutdownEventTracker.Name = "ttShutdownEventTracker";
      this.ttShutdownEventTracker.Size = new System.Drawing.Size(16, 16);
      this.ttShutdownEventTracker.TabIndex = 40;
      this.ttShutdownEventTracker.TabStop = false;
      this.ttShutdownEventTracker.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // combShutDEventTracker
      // 
      this.combShutDEventTracker.AllowDrop = true;
      this.combShutDEventTracker.FormattingEnabled = true;
      this.combShutDEventTracker.Items.AddRange(new object[] {
            "Off ",
            "On"});
      this.combShutDEventTracker.Location = new System.Drawing.Point(18, 171);
      this.combShutDEventTracker.Name = "combShutDEventTracker";
      this.combShutDEventTracker.Size = new System.Drawing.Size(121, 21);
      this.combShutDEventTracker.TabIndex = 5;
      this.combShutDEventTracker.Text = "Maintain";
      this.combShutDEventTracker.SelectedValueChanged += new System.EventHandler(this.combShutDEventTracker_SelectedValueChanged);
      // 
      // lbShutDownEventTracker
      // 
      this.lbShutDownEventTracker.AutoSize = true;
      this.lbShutDownEventTracker.Location = new System.Drawing.Point(15, 155);
      this.lbShutDownEventTracker.Name = "lbShutDownEventTracker";
      this.lbShutDownEventTracker.Size = new System.Drawing.Size(246, 13);
      this.lbShutDownEventTracker.TabIndex = 2;
      this.lbShutDownEventTracker.Text = "Give reason to shutdown (shutdown event tracker)";
      // 
      // cbAutoLogon
      // 
      this.cbAutoLogon.AutoSize = true;
      this.cbAutoLogon.Location = new System.Drawing.Point(18, 28);
      this.cbAutoLogon.Name = "cbAutoLogon";
      this.cbAutoLogon.Size = new System.Drawing.Size(125, 30);
      this.cbAutoLogon.TabIndex = 1;
      this.cbAutoLogon.Text = "Automatic login \r\nfor the particular user";
      this.cbAutoLogon.UseVisualStyleBackColor = true;
      this.cbAutoLogon.CheckedChanged += new System.EventHandler(this.cbAutoLogon_CheckedChanged);
      // 
      // wpSQLConfig
      // 
      this.wpSQLConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpSQLConfig.AntiAlias = false;
      this.wpSQLConfig.BackColor = System.Drawing.Color.LightGray;
      this.wpSQLConfig.Controls.Add(this.groupBox4);
      this.wpSQLConfig.Controls.Add(this.gbSQL);
      this.wpSQLConfig.Location = new System.Drawing.Point(7, 72);
      this.wpSQLConfig.Name = "wpSQLConfig";
      this.wpSQLConfig.PageDescription = "You can install and config SQL server here";
      this.wpSQLConfig.PageTitle = "SQL Server Config";
      this.wpSQLConfig.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.Security;
      this.wpSQLConfig.Size = new System.Drawing.Size(608, 283);
      this.wpSQLConfig.TabIndex = 35;
      this.wpSQLConfig.Text = "s";
      this.wpSQLConfig.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpSQLConfig_NextButtonClick);
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.btModifySQLUser);
      this.groupBox4.Controls.Add(this.lvSqlAdmins);
      this.groupBox4.Controls.Add(this.btRemoveSQLAdmins);
      this.groupBox4.Controls.Add(this.btAddSQLAdmins);
      this.groupBox4.Controls.Add(this.label81);
      this.groupBox4.Controls.Add(this.label77);
      this.groupBox4.Location = new System.Drawing.Point(298, 3);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(305, 280);
      this.groupBox4.TabIndex = 1;
      this.groupBox4.TabStop = false;
      // 
      // btModifySQLUser
      // 
      this.btModifySQLUser.Location = new System.Drawing.Point(147, 250);
      this.btModifySQLUser.Name = "btModifySQLUser";
      this.btModifySQLUser.Size = new System.Drawing.Size(75, 23);
      this.btModifySQLUser.TabIndex = 11;
      this.btModifySQLUser.Text = "Modify";
      this.btModifySQLUser.UseVisualStyleBackColor = true;
      // 
      // lvSqlAdmins
      // 
      this.lvSqlAdmins.Location = new System.Drawing.Point(6, 41);
      this.lvSqlAdmins.Name = "lvSqlAdmins";
      this.lvSqlAdmins.Size = new System.Drawing.Size(290, 203);
      this.lvSqlAdmins.TabIndex = 12;
      this.lvSqlAdmins.UseCompatibleStateImageBehavior = false;
      // 
      // btRemoveSQLAdmins
      // 
      this.btRemoveSQLAdmins.Location = new System.Drawing.Point(76, 250);
      this.btRemoveSQLAdmins.Name = "btRemoveSQLAdmins";
      this.btRemoveSQLAdmins.Size = new System.Drawing.Size(65, 24);
      this.btRemoveSQLAdmins.TabIndex = 10;
      this.btRemoveSQLAdmins.Text = "&Remove";
      this.btRemoveSQLAdmins.UseVisualStyleBackColor = true;
      // 
      // btAddSQLAdmins
      // 
      this.btAddSQLAdmins.Location = new System.Drawing.Point(12, 251);
      this.btAddSQLAdmins.Name = "btAddSQLAdmins";
      this.btAddSQLAdmins.Size = new System.Drawing.Size(58, 23);
      this.btAddSQLAdmins.TabIndex = 9;
      this.btAddSQLAdmins.Text = "&Add...";
      this.btAddSQLAdmins.UseVisualStyleBackColor = true;
      this.btAddSQLAdmins.Click += new System.EventHandler(this.btAddSQLAdmins_Click);
      // 
      // label81
      // 
      this.label81.AutoSize = true;
      this.label81.Location = new System.Drawing.Point(168, 20);
      this.label81.Name = "label81";
      this.label81.Size = new System.Drawing.Size(133, 13);
      this.label81.TabIndex = 4;
      this.label81.Text = "_____________________";
      // 
      // label77
      // 
      this.label77.AutoSize = true;
      this.label77.Location = new System.Drawing.Point(5, 25);
      this.label77.Name = "label77";
      this.label77.Size = new System.Drawing.Size(168, 13);
      this.label77.TabIndex = 3;
      this.label77.Text = "Specify SQL Server Administrators";
      // 
      // gbSQL
      // 
      this.gbSQL.BackColor = System.Drawing.Color.LightGray;
      this.gbSQL.Controls.Add(this.gbChangeSaPass);
      this.gbSQL.Controls.Add(this.rbSqlMixMode);
      this.gbSQL.Controls.Add(this.label66);
      this.gbSQL.Controls.Add(this.rbSqlWinAuthenMode);
      this.gbSQL.Location = new System.Drawing.Point(5, 3);
      this.gbSQL.Name = "gbSQL";
      this.gbSQL.Size = new System.Drawing.Size(287, 280);
      this.gbSQL.TabIndex = 0;
      this.gbSQL.TabStop = false;
      this.gbSQL.Text = "Configure SQL Server";
      // 
      // gbChangeSaPass
      // 
      this.gbChangeSaPass.Controls.Add(this.cbSqlSavePassToLog);
      this.gbChangeSaPass.Controls.Add(this.cbSqlRandomPass);
      this.gbChangeSaPass.Controls.Add(this.tbSaConfPass);
      this.gbChangeSaPass.Controls.Add(this.tbSaPass);
      this.gbChangeSaPass.Controls.Add(this.label75);
      this.gbChangeSaPass.Controls.Add(this.label68);
      this.gbChangeSaPass.Controls.Add(this.cbSqlChangeSaPass);
      this.gbChangeSaPass.Controls.Add(this.tbSqlCurrentSaPass);
      this.gbChangeSaPass.Controls.Add(this.label67);
      this.gbChangeSaPass.Location = new System.Drawing.Point(6, 91);
      this.gbChangeSaPass.Name = "gbChangeSaPass";
      this.gbChangeSaPass.Size = new System.Drawing.Size(275, 182);
      this.gbChangeSaPass.TabIndex = 87;
      this.gbChangeSaPass.TabStop = false;
      // 
      // cbSqlSavePassToLog
      // 
      this.cbSqlSavePassToLog.AutoSize = true;
      this.cbSqlSavePassToLog.Checked = true;
      this.cbSqlSavePassToLog.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbSqlSavePassToLog.Location = new System.Drawing.Point(18, 153);
      this.cbSqlSavePassToLog.Name = "cbSqlSavePassToLog";
      this.cbSqlSavePassToLog.Size = new System.Drawing.Size(128, 17);
      this.cbSqlSavePassToLog.TabIndex = 8;
      this.cbSqlSavePassToLog.Text = "Save password to log";
      this.cbSqlSavePassToLog.UseVisualStyleBackColor = true;
      this.cbSqlSavePassToLog.CheckedChanged += new System.EventHandler(this.cbSqlSavePassToLog_CheckedChanged);
      // 
      // cbSqlRandomPass
      // 
      this.cbSqlRandomPass.AutoSize = true;
      this.cbSqlRandomPass.Location = new System.Drawing.Point(18, 131);
      this.cbSqlRandomPass.Name = "cbSqlRandomPass";
      this.cbSqlRandomPass.Size = new System.Drawing.Size(114, 17);
      this.cbSqlRandomPass.TabIndex = 7;
      this.cbSqlRandomPass.Text = "Random password";
      this.cbSqlRandomPass.UseVisualStyleBackColor = true;
      this.cbSqlRandomPass.CheckedChanged += new System.EventHandler(this.cbSqlRandomPass_CheckedChanged);
      // 
      // tbSaConfPass
      // 
      this.tbSaConfPass.Location = new System.Drawing.Point(104, 96);
      this.tbSaConfPass.Name = "tbSaConfPass";
      this.tbSaConfPass.PasswordChar = '*';
      this.tbSaConfPass.Size = new System.Drawing.Size(147, 20);
      this.tbSaConfPass.TabIndex = 6;
      // 
      // tbSaPass
      // 
      this.tbSaPass.Location = new System.Drawing.Point(104, 69);
      this.tbSaPass.Name = "tbSaPass";
      this.tbSaPass.PasswordChar = '*';
      this.tbSaPass.Size = new System.Drawing.Size(147, 20);
      this.tbSaPass.TabIndex = 5;
      // 
      // label75
      // 
      this.label75.AutoSize = true;
      this.label75.Location = new System.Drawing.Point(8, 99);
      this.label75.Name = "label75";
      this.label75.Size = new System.Drawing.Size(93, 13);
      this.label75.TabIndex = 4;
      this.label75.Text = "Confirm password:";
      // 
      // label68
      // 
      this.label68.AutoSize = true;
      this.label68.Location = new System.Drawing.Point(45, 72);
      this.label68.Name = "label68";
      this.label68.Size = new System.Drawing.Size(56, 13);
      this.label68.TabIndex = 3;
      this.label68.Text = "Password:";
      // 
      // cbSqlChangeSaPass
      // 
      this.cbSqlChangeSaPass.AutoSize = true;
      this.cbSqlChangeSaPass.Location = new System.Drawing.Point(11, 43);
      this.cbSqlChangeSaPass.Name = "cbSqlChangeSaPass";
      this.cbSqlChangeSaPass.Size = new System.Drawing.Size(128, 17);
      this.cbSqlChangeSaPass.TabIndex = 4;
      this.cbSqlChangeSaPass.Text = "Change SA password";
      this.cbSqlChangeSaPass.UseVisualStyleBackColor = true;
      // 
      // tbSqlCurrentSaPass
      // 
      this.tbSqlCurrentSaPass.Location = new System.Drawing.Point(119, 17);
      this.tbSqlCurrentSaPass.Name = "tbSqlCurrentSaPass";
      this.tbSqlCurrentSaPass.PasswordChar = '*';
      this.tbSqlCurrentSaPass.Size = new System.Drawing.Size(132, 20);
      this.tbSqlCurrentSaPass.TabIndex = 3;
      // 
      // label67
      // 
      this.label67.AutoSize = true;
      this.label67.Location = new System.Drawing.Point(8, 20);
      this.label67.Name = "label67";
      this.label67.Size = new System.Drawing.Size(105, 13);
      this.label67.TabIndex = 0;
      this.label67.Text = "Enter current SA pw:";
      // 
      // rbSqlMixMode
      // 
      this.rbSqlMixMode.AutoSize = true;
      this.rbSqlMixMode.Checked = true;
      this.rbSqlMixMode.Location = new System.Drawing.Point(26, 68);
      this.rbSqlMixMode.Name = "rbSqlMixMode";
      this.rbSqlMixMode.Size = new System.Drawing.Size(71, 17);
      this.rbSqlMixMode.TabIndex = 2;
      this.rbSqlMixMode.TabStop = true;
      this.rbSqlMixMode.Text = "Mix Mode";
      this.rbSqlMixMode.UseVisualStyleBackColor = true;
      this.rbSqlMixMode.CheckedChanged += new System.EventHandler(this.rbSqlMixMode_CheckedChanged);
      // 
      // label66
      // 
      this.label66.AutoSize = true;
      this.label66.Location = new System.Drawing.Point(14, 25);
      this.label66.Name = "label66";
      this.label66.Size = new System.Drawing.Size(69, 13);
      this.label66.TabIndex = 85;
      this.label66.Text = "Login Using :";
      // 
      // rbSqlWinAuthenMode
      // 
      this.rbSqlWinAuthenMode.AutoSize = true;
      this.rbSqlWinAuthenMode.Location = new System.Drawing.Point(26, 45);
      this.rbSqlWinAuthenMode.Name = "rbSqlWinAuthenMode";
      this.rbSqlWinAuthenMode.Size = new System.Drawing.Size(169, 17);
      this.rbSqlWinAuthenMode.TabIndex = 1;
      this.rbSqlWinAuthenMode.Text = "Windows Authentication mode";
      this.rbSqlWinAuthenMode.UseVisualStyleBackColor = true;
      // 
      // wpPCAnywhere
      // 
      this.wpPCAnywhere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpPCAnywhere.AntiAlias = false;
      this.wpPCAnywhere.BackColor = System.Drawing.Color.LightGray;
      this.wpPCAnywhere.Controls.Add(this.tabControl1);
      this.wpPCAnywhere.Location = new System.Drawing.Point(7, 72);
      this.wpPCAnywhere.Name = "wpPCAnywhere";
      this.wpPCAnywhere.PageDescription = "This page allow you to configure PcAnywhere";
      this.wpPCAnywhere.PageTitle = "PC Anywhere ";
      this.wpPCAnywhere.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.Lockdown;
      this.wpPCAnywhere.Size = new System.Drawing.Size(608, 283);
      this.wpPCAnywhere.TabIndex = 37;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Location = new System.Drawing.Point(5, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(598, 283);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.BackColor = System.Drawing.Color.LightGray;
      this.tabPage1.Controls.Add(this.groupBox23);
      this.tabPage1.Controls.Add(this.groupBox22);
      this.tabPage1.Controls.Add(this.groupBox24);
      this.tabPage1.Controls.Add(this.groupBox21);
      this.tabPage1.Controls.Add(this.groupBox20);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(590, 257);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Server";
      // 
      // groupBox23
      // 
      this.groupBox23.Controls.Add(this.checkBox28);
      this.groupBox23.Controls.Add(this.radioButton9);
      this.groupBox23.Controls.Add(this.radioButton10);
      this.groupBox23.Controls.Add(this.radioButton11);
      this.groupBox23.Location = new System.Drawing.Point(204, 148);
      this.groupBox23.Name = "groupBox23";
      this.groupBox23.Size = new System.Drawing.Size(192, 88);
      this.groupBox23.TabIndex = 6;
      this.groupBox23.TabStop = false;
      this.groupBox23.Text = "      and secure by:";
      // 
      // checkBox28
      // 
      this.checkBox28.AutoSize = true;
      this.checkBox28.Checked = true;
      this.checkBox28.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox28.Location = new System.Drawing.Point(12, 0);
      this.checkBox28.Name = "checkBox28";
      this.checkBox28.Size = new System.Drawing.Size(15, 14);
      this.checkBox28.TabIndex = 4;
      this.checkBox28.UseVisualStyleBackColor = true;
      // 
      // radioButton9
      // 
      this.radioButton9.AutoSize = true;
      this.radioButton9.Location = new System.Drawing.Point(29, 62);
      this.radioButton9.Name = "radioButton9";
      this.radioButton9.Size = new System.Drawing.Size(78, 17);
      this.radioButton9.TabIndex = 2;
      this.radioButton9.Text = "Logoff user";
      this.radioButton9.UseVisualStyleBackColor = true;
      // 
      // radioButton10
      // 
      this.radioButton10.AutoSize = true;
      this.radioButton10.Location = new System.Drawing.Point(29, 39);
      this.radioButton10.Name = "radioButton10";
      this.radioButton10.Size = new System.Drawing.Size(129, 17);
      this.radioButton10.TabIndex = 1;
      this.radioButton10.Text = "Restart host computer";
      this.radioButton10.UseVisualStyleBackColor = true;
      // 
      // radioButton11
      // 
      this.radioButton11.AutoSize = true;
      this.radioButton11.Checked = true;
      this.radioButton11.Location = new System.Drawing.Point(29, 19);
      this.radioButton11.Name = "radioButton11";
      this.radioButton11.Size = new System.Drawing.Size(78, 17);
      this.radioButton11.TabIndex = 0;
      this.radioButton11.TabStop = true;
      this.radioButton11.Text = "Logoff user";
      this.radioButton11.UseVisualStyleBackColor = true;
      // 
      // groupBox22
      // 
      this.groupBox22.Controls.Add(this.checkBox27);
      this.groupBox22.Controls.Add(this.radioButton8);
      this.groupBox22.Controls.Add(this.radioButton7);
      this.groupBox22.Controls.Add(this.radioButton6);
      this.groupBox22.Location = new System.Drawing.Point(6, 148);
      this.groupBox22.Name = "groupBox22";
      this.groupBox22.Size = new System.Drawing.Size(192, 88);
      this.groupBox22.TabIndex = 2;
      this.groupBox22.TabStop = false;
      this.groupBox22.Text = "      and secure by:";
      // 
      // checkBox27
      // 
      this.checkBox27.AutoSize = true;
      this.checkBox27.Checked = true;
      this.checkBox27.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox27.Location = new System.Drawing.Point(12, -1);
      this.checkBox27.Name = "checkBox27";
      this.checkBox27.Size = new System.Drawing.Size(15, 14);
      this.checkBox27.TabIndex = 3;
      this.checkBox27.UseVisualStyleBackColor = true;
      // 
      // radioButton8
      // 
      this.radioButton8.AutoSize = true;
      this.radioButton8.Location = new System.Drawing.Point(31, 62);
      this.radioButton8.Name = "radioButton8";
      this.radioButton8.Size = new System.Drawing.Size(78, 17);
      this.radioButton8.TabIndex = 2;
      this.radioButton8.Text = "Logoff user";
      this.radioButton8.UseVisualStyleBackColor = true;
      // 
      // radioButton7
      // 
      this.radioButton7.AutoSize = true;
      this.radioButton7.Location = new System.Drawing.Point(31, 42);
      this.radioButton7.Name = "radioButton7";
      this.radioButton7.Size = new System.Drawing.Size(129, 17);
      this.radioButton7.TabIndex = 1;
      this.radioButton7.Text = "Restart host computer";
      this.radioButton7.UseVisualStyleBackColor = true;
      // 
      // radioButton6
      // 
      this.radioButton6.AutoSize = true;
      this.radioButton6.Checked = true;
      this.radioButton6.Location = new System.Drawing.Point(31, 19);
      this.radioButton6.Name = "radioButton6";
      this.radioButton6.Size = new System.Drawing.Size(78, 17);
      this.radioButton6.TabIndex = 0;
      this.radioButton6.TabStop = true;
      this.radioButton6.Text = "Logoff user";
      this.radioButton6.UseVisualStyleBackColor = true;
      // 
      // groupBox24
      // 
      this.groupBox24.Controls.Add(this.radioButton12);
      this.groupBox24.Controls.Add(this.radioButton13);
      this.groupBox24.Location = new System.Drawing.Point(204, 25);
      this.groupBox24.Name = "groupBox24";
      this.groupBox24.Size = new System.Drawing.Size(192, 117);
      this.groupBox24.TabIndex = 5;
      this.groupBox24.TabStop = false;
      this.groupBox24.Text = "After an normal end of section";
      // 
      // radioButton12
      // 
      this.radioButton12.AutoSize = true;
      this.radioButton12.Location = new System.Drawing.Point(12, 74);
      this.radioButton12.Name = "radioButton12";
      this.radioButton12.Size = new System.Drawing.Size(81, 17);
      this.radioButton12.TabIndex = 1;
      this.radioButton12.Text = "Cancel host";
      this.radioButton12.UseVisualStyleBackColor = true;
      // 
      // radioButton13
      // 
      this.radioButton13.AutoSize = true;
      this.radioButton13.Checked = true;
      this.radioButton13.Location = new System.Drawing.Point(12, 44);
      this.radioButton13.Name = "radioButton13";
      this.radioButton13.Size = new System.Drawing.Size(100, 17);
      this.radioButton13.TabIndex = 0;
      this.radioButton13.TabStop = true;
      this.radioButton13.Text = "Wait for anyone";
      this.radioButton13.UseVisualStyleBackColor = true;
      // 
      // groupBox21
      // 
      this.groupBox21.Controls.Add(this.label71);
      this.groupBox21.Controls.Add(this.numericUpDown2);
      this.groupBox21.Controls.Add(this.label70);
      this.groupBox21.Controls.Add(this.radioButton5);
      this.groupBox21.Controls.Add(this.radioButton4);
      this.groupBox21.Location = new System.Drawing.Point(6, 25);
      this.groupBox21.Name = "groupBox21";
      this.groupBox21.Size = new System.Drawing.Size(192, 117);
      this.groupBox21.TabIndex = 1;
      this.groupBox21.TabStop = false;
      this.groupBox21.Text = "After an abnormal end of section";
      // 
      // label71
      // 
      this.label71.AllowDrop = true;
      this.label71.AutoSize = true;
      this.label71.Location = new System.Drawing.Point(81, 26);
      this.label71.Name = "label71";
      this.label71.Size = new System.Drawing.Size(109, 13);
      this.label71.TabIndex = 4;
      this.label71.Text = "minutes for reconnect";
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.Location = new System.Drawing.Point(41, 24);
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(34, 20);
      this.numericUpDown2.TabIndex = 3;
      this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      // 
      // label70
      // 
      this.label70.AutoSize = true;
      this.label70.Location = new System.Drawing.Point(6, 26);
      this.label70.Name = "label70";
      this.label70.Size = new System.Drawing.Size(29, 13);
      this.label70.TabIndex = 2;
      this.label70.Text = "Wait";
      // 
      // radioButton5
      // 
      this.radioButton5.AutoSize = true;
      this.radioButton5.Location = new System.Drawing.Point(9, 84);
      this.radioButton5.Name = "radioButton5";
      this.radioButton5.Size = new System.Drawing.Size(81, 17);
      this.radioButton5.TabIndex = 1;
      this.radioButton5.Text = "Cancel host";
      this.radioButton5.UseVisualStyleBackColor = true;
      // 
      // radioButton4
      // 
      this.radioButton4.AutoSize = true;
      this.radioButton4.Checked = true;
      this.radioButton4.Location = new System.Drawing.Point(9, 61);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new System.Drawing.Size(100, 17);
      this.radioButton4.TabIndex = 0;
      this.radioButton4.TabStop = true;
      this.radioButton4.Text = "Wait for anyone";
      this.radioButton4.UseVisualStyleBackColor = true;
      // 
      // groupBox20
      // 
      this.groupBox20.Controls.Add(this.checkBox26);
      this.groupBox20.Controls.Add(this.checkBox25);
      this.groupBox20.Controls.Add(this.checkBox24);
      this.groupBox20.Controls.Add(this.checkBox23);
      this.groupBox20.Location = new System.Drawing.Point(402, 6);
      this.groupBox20.Name = "groupBox20";
      this.groupBox20.Size = new System.Drawing.Size(182, 161);
      this.groupBox20.TabIndex = 0;
      this.groupBox20.TabStop = false;
      this.groupBox20.Text = "Host startup";
      // 
      // checkBox26
      // 
      this.checkBox26.AutoSize = true;
      this.checkBox26.Checked = true;
      this.checkBox26.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox26.Enabled = false;
      this.checkBox26.Location = new System.Drawing.Point(6, 128);
      this.checkBox26.Name = "checkBox26";
      this.checkBox26.Size = new System.Drawing.Size(97, 17);
      this.checkBox26.TabIndex = 3;
      this.checkBox26.Text = "R&un as service";
      this.checkBox26.UseVisualStyleBackColor = true;
      // 
      // checkBox25
      // 
      this.checkBox25.AutoSize = true;
      this.checkBox25.Checked = true;
      this.checkBox25.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox25.Location = new System.Drawing.Point(6, 94);
      this.checkBox25.Name = "checkBox25";
      this.checkBox25.Size = new System.Drawing.Size(88, 17);
      this.checkBox25.TabIndex = 2;
      this.checkBox25.Text = "Run minimi&ze";
      this.checkBox25.UseVisualStyleBackColor = true;
      // 
      // checkBox24
      // 
      this.checkBox24.AutoSize = true;
      this.checkBox24.Location = new System.Drawing.Point(6, 64);
      this.checkBox24.Name = "checkBox24";
      this.checkBox24.Size = new System.Drawing.Size(97, 17);
      this.checkBox24.TabIndex = 1;
      this.checkBox24.Text = "Lock compu&ter";
      this.checkBox24.UseVisualStyleBackColor = true;
      // 
      // checkBox23
      // 
      this.checkBox23.AutoSize = true;
      this.checkBox23.Checked = true;
      this.checkBox23.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox23.Location = new System.Drawing.Point(6, 32);
      this.checkBox23.Name = "checkBox23";
      this.checkBox23.Size = new System.Drawing.Size(128, 17);
      this.checkBox23.TabIndex = 0;
      this.checkBox23.Text = "&Launch with windows";
      this.checkBox23.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.BackColor = System.Drawing.Color.LightGray;
      this.tabPage2.Controls.Add(this.groupBox25);
      this.tabPage2.Controls.Add(this.groupBox26);
      this.tabPage2.Controls.Add(this.groupBox27);
      this.tabPage2.Controls.Add(this.groupBox28);
      this.tabPage2.Controls.Add(this.groupBox29);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(590, 257);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Client";
      // 
      // groupBox25
      // 
      this.groupBox25.Controls.Add(this.checkBox29);
      this.groupBox25.Controls.Add(this.radioButton14);
      this.groupBox25.Controls.Add(this.radioButton15);
      this.groupBox25.Controls.Add(this.radioButton16);
      this.groupBox25.Location = new System.Drawing.Point(204, 149);
      this.groupBox25.Name = "groupBox25";
      this.groupBox25.Size = new System.Drawing.Size(192, 88);
      this.groupBox25.TabIndex = 11;
      this.groupBox25.TabStop = false;
      this.groupBox25.Text = "      and secure by:";
      // 
      // checkBox29
      // 
      this.checkBox29.AutoSize = true;
      this.checkBox29.Location = new System.Drawing.Point(12, 0);
      this.checkBox29.Name = "checkBox29";
      this.checkBox29.Size = new System.Drawing.Size(15, 14);
      this.checkBox29.TabIndex = 4;
      this.checkBox29.UseVisualStyleBackColor = true;
      // 
      // radioButton14
      // 
      this.radioButton14.AutoSize = true;
      this.radioButton14.Enabled = false;
      this.radioButton14.Location = new System.Drawing.Point(29, 62);
      this.radioButton14.Name = "radioButton14";
      this.radioButton14.Size = new System.Drawing.Size(78, 17);
      this.radioButton14.TabIndex = 2;
      this.radioButton14.TabStop = true;
      this.radioButton14.Text = "Logoff user";
      this.radioButton14.UseVisualStyleBackColor = true;
      // 
      // radioButton15
      // 
      this.radioButton15.AutoSize = true;
      this.radioButton15.Enabled = false;
      this.radioButton15.Location = new System.Drawing.Point(29, 36);
      this.radioButton15.Name = "radioButton15";
      this.radioButton15.Size = new System.Drawing.Size(129, 17);
      this.radioButton15.TabIndex = 1;
      this.radioButton15.TabStop = true;
      this.radioButton15.Text = "Restart host computer";
      this.radioButton15.UseVisualStyleBackColor = true;
      // 
      // radioButton16
      // 
      this.radioButton16.AutoSize = true;
      this.radioButton16.Enabled = false;
      this.radioButton16.Location = new System.Drawing.Point(29, 19);
      this.radioButton16.Name = "radioButton16";
      this.radioButton16.Size = new System.Drawing.Size(78, 17);
      this.radioButton16.TabIndex = 0;
      this.radioButton16.TabStop = true;
      this.radioButton16.Text = "Logoff user";
      this.radioButton16.UseVisualStyleBackColor = true;
      // 
      // groupBox26
      // 
      this.groupBox26.Controls.Add(this.checkBox30);
      this.groupBox26.Controls.Add(this.radioButton17);
      this.groupBox26.Controls.Add(this.radioButton18);
      this.groupBox26.Controls.Add(this.radioButton19);
      this.groupBox26.Location = new System.Drawing.Point(6, 149);
      this.groupBox26.Name = "groupBox26";
      this.groupBox26.Size = new System.Drawing.Size(192, 88);
      this.groupBox26.TabIndex = 9;
      this.groupBox26.TabStop = false;
      this.groupBox26.Text = "      and secure by:";
      // 
      // checkBox30
      // 
      this.checkBox30.AutoSize = true;
      this.checkBox30.Location = new System.Drawing.Point(12, -1);
      this.checkBox30.Name = "checkBox30";
      this.checkBox30.Size = new System.Drawing.Size(15, 14);
      this.checkBox30.TabIndex = 3;
      this.checkBox30.UseVisualStyleBackColor = true;
      // 
      // radioButton17
      // 
      this.radioButton17.AutoSize = true;
      this.radioButton17.Enabled = false;
      this.radioButton17.Location = new System.Drawing.Point(31, 62);
      this.radioButton17.Name = "radioButton17";
      this.radioButton17.Size = new System.Drawing.Size(78, 17);
      this.radioButton17.TabIndex = 2;
      this.radioButton17.TabStop = true;
      this.radioButton17.Text = "Logoff user";
      this.radioButton17.UseVisualStyleBackColor = true;
      // 
      // radioButton18
      // 
      this.radioButton18.AutoSize = true;
      this.radioButton18.Enabled = false;
      this.radioButton18.Location = new System.Drawing.Point(31, 42);
      this.radioButton18.Name = "radioButton18";
      this.radioButton18.Size = new System.Drawing.Size(129, 17);
      this.radioButton18.TabIndex = 1;
      this.radioButton18.TabStop = true;
      this.radioButton18.Text = "Restart host computer";
      this.radioButton18.UseVisualStyleBackColor = true;
      // 
      // radioButton19
      // 
      this.radioButton19.AutoSize = true;
      this.radioButton19.Enabled = false;
      this.radioButton19.Location = new System.Drawing.Point(31, 19);
      this.radioButton19.Name = "radioButton19";
      this.radioButton19.Size = new System.Drawing.Size(78, 17);
      this.radioButton19.TabIndex = 0;
      this.radioButton19.TabStop = true;
      this.radioButton19.Text = "Logoff user";
      this.radioButton19.UseVisualStyleBackColor = true;
      // 
      // groupBox27
      // 
      this.groupBox27.Controls.Add(this.radioButton20);
      this.groupBox27.Controls.Add(this.radioButton21);
      this.groupBox27.Location = new System.Drawing.Point(204, 26);
      this.groupBox27.Name = "groupBox27";
      this.groupBox27.Size = new System.Drawing.Size(192, 117);
      this.groupBox27.TabIndex = 10;
      this.groupBox27.TabStop = false;
      this.groupBox27.Text = "After an normal end of section";
      // 
      // radioButton20
      // 
      this.radioButton20.AutoSize = true;
      this.radioButton20.Location = new System.Drawing.Point(12, 75);
      this.radioButton20.Name = "radioButton20";
      this.radioButton20.Size = new System.Drawing.Size(81, 17);
      this.radioButton20.TabIndex = 1;
      this.radioButton20.Text = "Cancel host";
      this.radioButton20.UseVisualStyleBackColor = true;
      // 
      // radioButton21
      // 
      this.radioButton21.AutoSize = true;
      this.radioButton21.Checked = true;
      this.radioButton21.Location = new System.Drawing.Point(12, 44);
      this.radioButton21.Name = "radioButton21";
      this.radioButton21.Size = new System.Drawing.Size(100, 17);
      this.radioButton21.TabIndex = 0;
      this.radioButton21.TabStop = true;
      this.radioButton21.Text = "Wait for anyone";
      this.radioButton21.UseVisualStyleBackColor = true;
      // 
      // groupBox28
      // 
      this.groupBox28.Controls.Add(this.label72);
      this.groupBox28.Controls.Add(this.numericUpDown3);
      this.groupBox28.Controls.Add(this.label73);
      this.groupBox28.Controls.Add(this.radioButton22);
      this.groupBox28.Controls.Add(this.radioButton23);
      this.groupBox28.Location = new System.Drawing.Point(6, 26);
      this.groupBox28.Name = "groupBox28";
      this.groupBox28.Size = new System.Drawing.Size(192, 117);
      this.groupBox28.TabIndex = 8;
      this.groupBox28.TabStop = false;
      this.groupBox28.Text = "After an abnormal end of section";
      // 
      // label72
      // 
      this.label72.AllowDrop = true;
      this.label72.AutoSize = true;
      this.label72.Location = new System.Drawing.Point(81, 26);
      this.label72.Name = "label72";
      this.label72.Size = new System.Drawing.Size(109, 13);
      this.label72.TabIndex = 4;
      this.label72.Text = "minutes for reconnect";
      // 
      // numericUpDown3
      // 
      this.numericUpDown3.Location = new System.Drawing.Point(41, 24);
      this.numericUpDown3.Name = "numericUpDown3";
      this.numericUpDown3.Size = new System.Drawing.Size(34, 20);
      this.numericUpDown3.TabIndex = 3;
      this.numericUpDown3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      // 
      // label73
      // 
      this.label73.AutoSize = true;
      this.label73.Location = new System.Drawing.Point(6, 26);
      this.label73.Name = "label73";
      this.label73.Size = new System.Drawing.Size(29, 13);
      this.label73.TabIndex = 2;
      this.label73.Text = "Wait";
      // 
      // radioButton22
      // 
      this.radioButton22.AutoSize = true;
      this.radioButton22.Location = new System.Drawing.Point(9, 84);
      this.radioButton22.Name = "radioButton22";
      this.radioButton22.Size = new System.Drawing.Size(81, 17);
      this.radioButton22.TabIndex = 1;
      this.radioButton22.Text = "Cancel host";
      this.radioButton22.UseVisualStyleBackColor = true;
      // 
      // radioButton23
      // 
      this.radioButton23.AutoSize = true;
      this.radioButton23.Checked = true;
      this.radioButton23.Location = new System.Drawing.Point(9, 61);
      this.radioButton23.Name = "radioButton23";
      this.radioButton23.Size = new System.Drawing.Size(100, 17);
      this.radioButton23.TabIndex = 0;
      this.radioButton23.TabStop = true;
      this.radioButton23.Text = "Wait for anyone";
      this.radioButton23.UseVisualStyleBackColor = true;
      // 
      // groupBox29
      // 
      this.groupBox29.Controls.Add(this.checkBox31);
      this.groupBox29.Controls.Add(this.checkBox32);
      this.groupBox29.Controls.Add(this.checkBox33);
      this.groupBox29.Controls.Add(this.checkBox34);
      this.groupBox29.Location = new System.Drawing.Point(402, 7);
      this.groupBox29.Name = "groupBox29";
      this.groupBox29.Size = new System.Drawing.Size(182, 161);
      this.groupBox29.TabIndex = 7;
      this.groupBox29.TabStop = false;
      this.groupBox29.Text = "Host startup";
      // 
      // checkBox31
      // 
      this.checkBox31.AutoSize = true;
      this.checkBox31.Checked = true;
      this.checkBox31.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox31.Enabled = false;
      this.checkBox31.Location = new System.Drawing.Point(6, 128);
      this.checkBox31.Name = "checkBox31";
      this.checkBox31.Size = new System.Drawing.Size(97, 17);
      this.checkBox31.TabIndex = 3;
      this.checkBox31.Text = "R&un as service";
      this.checkBox31.UseVisualStyleBackColor = true;
      // 
      // checkBox32
      // 
      this.checkBox32.AutoSize = true;
      this.checkBox32.Checked = true;
      this.checkBox32.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox32.Location = new System.Drawing.Point(6, 94);
      this.checkBox32.Name = "checkBox32";
      this.checkBox32.Size = new System.Drawing.Size(88, 17);
      this.checkBox32.TabIndex = 2;
      this.checkBox32.Text = "Run minimi&ze";
      this.checkBox32.UseVisualStyleBackColor = true;
      // 
      // checkBox33
      // 
      this.checkBox33.AutoSize = true;
      this.checkBox33.Location = new System.Drawing.Point(6, 64);
      this.checkBox33.Name = "checkBox33";
      this.checkBox33.Size = new System.Drawing.Size(97, 17);
      this.checkBox33.TabIndex = 1;
      this.checkBox33.Text = "Lock compu&ter";
      this.checkBox33.UseVisualStyleBackColor = true;
      // 
      // checkBox34
      // 
      this.checkBox34.AutoSize = true;
      this.checkBox34.Checked = true;
      this.checkBox34.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox34.Location = new System.Drawing.Point(6, 32);
      this.checkBox34.Name = "checkBox34";
      this.checkBox34.Size = new System.Drawing.Size(128, 17);
      this.checkBox34.TabIndex = 0;
      this.checkBox34.Text = "&Launch with windows";
      this.checkBox34.UseVisualStyleBackColor = true;
      // 
      // tabPage3
      // 
      this.tabPage3.BackColor = System.Drawing.Color.LightGray;
      this.tabPage3.Controls.Add(this.checkBox40);
      this.tabPage3.Controls.Add(this.checkBox39);
      this.tabPage3.Controls.Add(this.checkBox36);
      this.tabPage3.Controls.Add(this.checkBox35);
      this.tabPage3.Controls.Add(this.textBox14);
      this.tabPage3.Controls.Add(this.textBox13);
      this.tabPage3.Controls.Add(this.label87);
      this.tabPage3.Controls.Add(this.label86);
      this.tabPage3.Controls.Add(this.label85);
      this.tabPage3.Controls.Add(this.pictureBox13);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(590, 257);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Protect Item";
      // 
      // checkBox40
      // 
      this.checkBox40.AutoSize = true;
      this.checkBox40.Checked = true;
      this.checkBox40.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox40.Location = new System.Drawing.Point(70, 234);
      this.checkBox40.Name = "checkBox40";
      this.checkBox40.Size = new System.Drawing.Size(128, 17);
      this.checkBox40.TabIndex = 9;
      this.checkBox40.Text = "Save password to log";
      this.checkBox40.UseVisualStyleBackColor = true;
      // 
      // checkBox39
      // 
      this.checkBox39.AutoSize = true;
      this.checkBox39.Checked = true;
      this.checkBox39.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox39.Location = new System.Drawing.Point(70, 211);
      this.checkBox39.Name = "checkBox39";
      this.checkBox39.Size = new System.Drawing.Size(114, 17);
      this.checkBox39.TabIndex = 8;
      this.checkBox39.Text = "Random password";
      this.checkBox39.UseVisualStyleBackColor = true;
      // 
      // checkBox36
      // 
      this.checkBox36.AutoSize = true;
      this.checkBox36.Checked = true;
      this.checkBox36.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox36.Location = new System.Drawing.Point(70, 188);
      this.checkBox36.Name = "checkBox36";
      this.checkBox36.Size = new System.Drawing.Size(163, 17);
      this.checkBox36.TabIndex = 7;
      this.checkBox36.Text = "Required to &modify properties";
      this.checkBox36.UseVisualStyleBackColor = true;
      // 
      // checkBox35
      // 
      this.checkBox35.AutoSize = true;
      this.checkBox35.Location = new System.Drawing.Point(52, 165);
      this.checkBox35.Name = "checkBox35";
      this.checkBox35.Size = new System.Drawing.Size(155, 17);
      this.checkBox35.TabIndex = 6;
      this.checkBox35.Text = "Required to &view properties";
      this.checkBox35.UseVisualStyleBackColor = true;
      // 
      // textBox14
      // 
      this.textBox14.Location = new System.Drawing.Point(143, 121);
      this.textBox14.Name = "textBox14";
      this.textBox14.PasswordChar = '*';
      this.textBox14.Size = new System.Drawing.Size(305, 20);
      this.textBox14.TabIndex = 5;
      // 
      // textBox13
      // 
      this.textBox13.Location = new System.Drawing.Point(143, 96);
      this.textBox13.Name = "textBox13";
      this.textBox13.PasswordChar = '*';
      this.textBox13.Size = new System.Drawing.Size(305, 20);
      this.textBox13.TabIndex = 4;
      // 
      // label87
      // 
      this.label87.AutoSize = true;
      this.label87.Location = new System.Drawing.Point(43, 128);
      this.label87.Name = "label87";
      this.label87.Size = new System.Drawing.Size(94, 13);
      this.label87.TabIndex = 3;
      this.label87.Text = "&Confirm Password:";
      // 
      // label86
      // 
      this.label86.AutoSize = true;
      this.label86.Location = new System.Drawing.Point(43, 103);
      this.label86.Name = "label86";
      this.label86.Size = new System.Drawing.Size(59, 13);
      this.label86.TabIndex = 2;
      this.label86.Text = "&Password: ";
      // 
      // label85
      // 
      this.label85.Location = new System.Drawing.Point(127, 22);
      this.label85.Name = "label85";
      this.label85.Size = new System.Drawing.Size(416, 49);
      this.label85.TabIndex = 1;
      this.label85.Text = "Please enter the password you will use to protect this item. If no password is en" +
    "tered, anyone who has accessed to this pc can view, executes or modifies this it" +
    "em";
      // 
      // pictureBox13
      // 
      this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
      this.pictureBox13.Location = new System.Drawing.Point(46, 15);
      this.pictureBox13.Name = "pictureBox13";
      this.pictureBox13.Size = new System.Drawing.Size(46, 56);
      this.pictureBox13.TabIndex = 0;
      this.pictureBox13.TabStop = false;
      // 
      // wpIIS
      // 
      this.wpIIS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpIIS.AntiAlias = false;
      this.wpIIS.BackColor = System.Drawing.Color.LightGray;
      this.wpIIS.Controls.Add(this.tabControl2);
      this.wpIIS.Location = new System.Drawing.Point(7, 72);
      this.wpIIS.Name = "wpIIS";
      this.wpIIS.PageDescription = "Here you can configure Web server, Mail server, FTP server";
      this.wpIIS.PageTitle = "Internet Information Service";
      this.wpIIS.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.Security;
      this.wpIIS.Size = new System.Drawing.Size(608, 283);
      this.wpIIS.TabIndex = 33;
      this.wpIIS.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpIIS_NextButtonClick);
      // 
      // tabControl2
      // 
      this.tabControl2.Controls.Add(this.tabPage4);
      this.tabControl2.Controls.Add(this.tpWeb);
      this.tabControl2.Controls.Add(this.tabPage5);
      this.tabControl2.Controls.Add(this.tabPageFTP);
      this.tabControl2.Location = new System.Drawing.Point(0, 0);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new System.Drawing.Size(607, 281);
      this.tabControl2.TabIndex = 0;
      // 
      // tabPage4
      // 
      this.tabPage4.BackColor = System.Drawing.Color.LightGray;
      this.tabPage4.Controls.Add(this.groupBox19);
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage4.Size = new System.Drawing.Size(599, 255);
      this.tabPage4.TabIndex = 0;
      this.tabPage4.Text = "Logon";
      // 
      // groupBox19
      // 
      this.groupBox19.Controls.Add(this.btIISBrowse);
      this.groupBox19.Controls.Add(this.btIISServiceLogin);
      this.groupBox19.Controls.Add(this.lbIISPass);
      this.groupBox19.Controls.Add(this.tbIISCustomAccountPass);
      this.groupBox19.Controls.Add(this.tbIISCustomAccount);
      this.groupBox19.Controls.Add(this.rbIIsAccountSelect);
      this.groupBox19.Controls.Add(this.rbIISLocalSystemAccount);
      this.groupBox19.Location = new System.Drawing.Point(6, 6);
      this.groupBox19.Name = "groupBox19";
      this.groupBox19.Size = new System.Drawing.Size(587, 243);
      this.groupBox19.TabIndex = 0;
      this.groupBox19.TabStop = false;
      this.groupBox19.Text = "Log on as";
      // 
      // btIISBrowse
      // 
      this.btIISBrowse.Location = new System.Drawing.Point(399, 97);
      this.btIISBrowse.Name = "btIISBrowse";
      this.btIISBrowse.Size = new System.Drawing.Size(75, 23);
      this.btIISBrowse.TabIndex = 6;
      this.btIISBrowse.Text = "Browse";
      this.btIISBrowse.UseVisualStyleBackColor = true;
      // 
      // btIISServiceLogin
      // 
      this.btIISServiceLogin.Location = new System.Drawing.Point(233, 151);
      this.btIISServiceLogin.Name = "btIISServiceLogin";
      this.btIISServiceLogin.Size = new System.Drawing.Size(75, 23);
      this.btIISServiceLogin.TabIndex = 5;
      this.btIISServiceLogin.Text = "Login";
      this.btIISServiceLogin.UseVisualStyleBackColor = true;
      // 
      // lbIISPass
      // 
      this.lbIISPass.AutoSize = true;
      this.lbIISPass.Location = new System.Drawing.Point(135, 128);
      this.lbIISPass.Name = "lbIISPass";
      this.lbIISPass.Size = new System.Drawing.Size(59, 13);
      this.lbIISPass.TabIndex = 18;
      this.lbIISPass.Text = "Password: ";
      // 
      // tbIISCustomAccountPass
      // 
      this.tbIISCustomAccountPass.Location = new System.Drawing.Point(233, 125);
      this.tbIISCustomAccountPass.Name = "tbIISCustomAccountPass";
      this.tbIISCustomAccountPass.Size = new System.Drawing.Size(148, 20);
      this.tbIISCustomAccountPass.TabIndex = 4;
      // 
      // tbIISCustomAccount
      // 
      this.tbIISCustomAccount.Location = new System.Drawing.Point(233, 99);
      this.tbIISCustomAccount.Name = "tbIISCustomAccount";
      this.tbIISCustomAccount.Size = new System.Drawing.Size(148, 20);
      this.tbIISCustomAccount.TabIndex = 3;
      // 
      // rbIIsAccountSelect
      // 
      this.rbIIsAccountSelect.AutoSize = true;
      this.rbIIsAccountSelect.Location = new System.Drawing.Point(100, 100);
      this.rbIIsAccountSelect.Name = "rbIIsAccountSelect";
      this.rbIIsAccountSelect.Size = new System.Drawing.Size(94, 17);
      this.rbIIsAccountSelect.TabIndex = 2;
      this.rbIIsAccountSelect.Text = "This Account: ";
      this.rbIIsAccountSelect.UseVisualStyleBackColor = true;
      // 
      // rbIISLocalSystemAccount
      // 
      this.rbIISLocalSystemAccount.AutoSize = true;
      this.rbIISLocalSystemAccount.Checked = true;
      this.rbIISLocalSystemAccount.Location = new System.Drawing.Point(100, 77);
      this.rbIISLocalSystemAccount.Name = "rbIISLocalSystemAccount";
      this.rbIISLocalSystemAccount.Size = new System.Drawing.Size(131, 17);
      this.rbIISLocalSystemAccount.TabIndex = 1;
      this.rbIISLocalSystemAccount.TabStop = true;
      this.rbIISLocalSystemAccount.Text = "Local System Account";
      this.rbIISLocalSystemAccount.UseVisualStyleBackColor = true;
      this.rbIISLocalSystemAccount.CheckedChanged += new System.EventHandler(this.rbIISLocalSystemAccount_CheckedChanged);
      // 
      // tpWeb
      // 
      this.tpWeb.BackColor = System.Drawing.Color.LightGray;
      this.tpWeb.Controls.Add(this.lbIISNotDefault);
      this.tpWeb.Controls.Add(this.gbIISLog);
      this.tpWeb.Controls.Add(this.tbIISNotDefault);
      this.tpWeb.Controls.Add(this.gbIIS);
      this.tpWeb.Controls.Add(this.cbIISOnOff);
      this.tpWeb.Location = new System.Drawing.Point(4, 22);
      this.tpWeb.Name = "tpWeb";
      this.tpWeb.Padding = new System.Windows.Forms.Padding(3);
      this.tpWeb.Size = new System.Drawing.Size(599, 255);
      this.tpWeb.TabIndex = 1;
      this.tpWeb.Text = "Web Server";
      // 
      // lbIISNotDefault
      // 
      this.lbIISNotDefault.AutoSize = true;
      this.lbIISNotDefault.Location = new System.Drawing.Point(6, 200);
      this.lbIISNotDefault.Name = "lbIISNotDefault";
      this.lbIISNotDefault.Size = new System.Drawing.Size(150, 13);
      this.lbIISNotDefault.TabIndex = 62;
      this.lbIISNotDefault.Text = "If not default, give a comment:";
      this.lbIISNotDefault.Visible = false;
      // 
      // gbIISLog
      // 
      this.gbIISLog.BackColor = System.Drawing.Color.LightGray;
      this.gbIISLog.Controls.Add(this.groupBox9);
      this.gbIISLog.Controls.Add(this.groupBox7);
      this.gbIISLog.Controls.Add(this.cboWebActiveLogFormat);
      this.gbIISLog.Controls.Add(this.cbLoginAuthorOnOff);
      this.gbIISLog.Controls.Add(this.label6);
      this.gbIISLog.Location = new System.Drawing.Point(369, 8);
      this.gbIISLog.Name = "gbIISLog";
      this.gbIISLog.Size = new System.Drawing.Size(224, 244);
      this.gbIISLog.TabIndex = 59;
      this.gbIISLog.TabStop = false;
      this.gbIISLog.Text = "     Logging";
      // 
      // groupBox9
      // 
      this.groupBox9.Controls.Add(this.cbWebLogDelete);
      this.groupBox9.Controls.Add(this.btWeblogBrowse);
      this.groupBox9.Controls.Add(this.tbWebLogLocation);
      this.groupBox9.Location = new System.Drawing.Point(9, 182);
      this.groupBox9.Name = "groupBox9";
      this.groupBox9.Size = new System.Drawing.Size(205, 59);
      this.groupBox9.TabIndex = 60;
      this.groupBox9.TabStop = false;
      this.groupBox9.Text = "Log file directory";
      // 
      // cbWebLogDelete
      // 
      this.cbWebLogDelete.AutoSize = true;
      this.cbWebLogDelete.Location = new System.Drawing.Point(6, 39);
      this.cbWebLogDelete.Name = "cbWebLogDelete";
      this.cbWebLogDelete.Size = new System.Drawing.Size(112, 17);
      this.cbWebLogDelete.TabIndex = 24;
      this.cbWebLogDelete.Text = "Delete old log files";
      this.cbWebLogDelete.UseVisualStyleBackColor = true;
      // 
      // btWeblogBrowse
      // 
      this.btWeblogBrowse.Location = new System.Drawing.Point(172, 13);
      this.btWeblogBrowse.Name = "btWeblogBrowse";
      this.btWeblogBrowse.Size = new System.Drawing.Size(27, 23);
      this.btWeblogBrowse.TabIndex = 22;
      this.btWeblogBrowse.Text = "...";
      this.btWeblogBrowse.UseVisualStyleBackColor = true;
      this.btWeblogBrowse.Click += new System.EventHandler(this.btWeblogBrowse_Click);
      // 
      // tbWebLogLocation
      // 
      this.tbWebLogLocation.Location = new System.Drawing.Point(6, 15);
      this.tbWebLogLocation.Name = "tbWebLogLocation";
      this.tbWebLogLocation.Size = new System.Drawing.Size(160, 20);
      this.tbWebLogLocation.TabIndex = 23;
      this.tbWebLogLocation.Text = "C:\\WINDOWS\\System32\\LogFiles";
      // 
      // groupBox7
      // 
      this.groupBox7.Controls.Add(this.label7);
      this.groupBox7.Controls.Add(this.nudWebLogSize);
      this.groupBox7.Controls.Add(this.rbWebLogSizeReach);
      this.groupBox7.Controls.Add(this.rbWebLogUnlimitSize);
      this.groupBox7.Controls.Add(this.rbWebLogMonth);
      this.groupBox7.Controls.Add(this.rbWebLogWeek);
      this.groupBox7.Controls.Add(this.rbWebLogDay);
      this.groupBox7.Controls.Add(this.rbWebLogHour);
      this.groupBox7.Location = new System.Drawing.Point(9, 49);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(205, 133);
      this.groupBox7.TabIndex = 59;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "New log schedule";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Enabled = false;
      this.label7.Location = new System.Drawing.Point(178, 108);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(23, 13);
      this.label7.TabIndex = 61;
      this.label7.Text = "MB";
      // 
      // nudWebLogSize
      // 
      this.nudWebLogSize.Location = new System.Drawing.Point(123, 105);
      this.nudWebLogSize.Name = "nudWebLogSize";
      this.nudWebLogSize.Size = new System.Drawing.Size(54, 20);
      this.nudWebLogSize.TabIndex = 21;
      this.nudWebLogSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
      // 
      // rbWebLogSizeReach
      // 
      this.rbWebLogSizeReach.AutoSize = true;
      this.rbWebLogSizeReach.Location = new System.Drawing.Point(6, 108);
      this.rbWebLogSizeReach.Name = "rbWebLogSizeReach";
      this.rbWebLogSizeReach.Size = new System.Drawing.Size(119, 17);
      this.rbWebLogSizeReach.TabIndex = 20;
      this.rbWebLogSizeReach.Text = "When size reaches:";
      this.rbWebLogSizeReach.UseVisualStyleBackColor = true;
      // 
      // rbWebLogUnlimitSize
      // 
      this.rbWebLogUnlimitSize.AutoSize = true;
      this.rbWebLogUnlimitSize.Location = new System.Drawing.Point(6, 89);
      this.rbWebLogUnlimitSize.Name = "rbWebLogUnlimitSize";
      this.rbWebLogUnlimitSize.Size = new System.Drawing.Size(105, 17);
      this.rbWebLogUnlimitSize.TabIndex = 19;
      this.rbWebLogUnlimitSize.Text = "Unlimited file size";
      this.rbWebLogUnlimitSize.UseVisualStyleBackColor = true;
      // 
      // rbWebLogMonth
      // 
      this.rbWebLogMonth.AutoSize = true;
      this.rbWebLogMonth.Location = new System.Drawing.Point(6, 70);
      this.rbWebLogMonth.Name = "rbWebLogMonth";
      this.rbWebLogMonth.Size = new System.Drawing.Size(62, 17);
      this.rbWebLogMonth.TabIndex = 18;
      this.rbWebLogMonth.Text = "Monthly";
      this.rbWebLogMonth.UseVisualStyleBackColor = true;
      // 
      // rbWebLogWeek
      // 
      this.rbWebLogWeek.AutoSize = true;
      this.rbWebLogWeek.Location = new System.Drawing.Point(6, 51);
      this.rbWebLogWeek.Name = "rbWebLogWeek";
      this.rbWebLogWeek.Size = new System.Drawing.Size(61, 17);
      this.rbWebLogWeek.TabIndex = 17;
      this.rbWebLogWeek.Text = "Weekly";
      this.rbWebLogWeek.UseVisualStyleBackColor = true;
      // 
      // rbWebLogDay
      // 
      this.rbWebLogDay.AutoSize = true;
      this.rbWebLogDay.Checked = true;
      this.rbWebLogDay.Location = new System.Drawing.Point(6, 32);
      this.rbWebLogDay.Name = "rbWebLogDay";
      this.rbWebLogDay.Size = new System.Drawing.Size(48, 17);
      this.rbWebLogDay.TabIndex = 16;
      this.rbWebLogDay.TabStop = true;
      this.rbWebLogDay.Text = "Daily";
      this.rbWebLogDay.UseVisualStyleBackColor = true;
      // 
      // rbWebLogHour
      // 
      this.rbWebLogHour.AutoSize = true;
      this.rbWebLogHour.Location = new System.Drawing.Point(6, 14);
      this.rbWebLogHour.Name = "rbWebLogHour";
      this.rbWebLogHour.Size = new System.Drawing.Size(55, 17);
      this.rbWebLogHour.TabIndex = 15;
      this.rbWebLogHour.Text = "Hourly";
      this.rbWebLogHour.UseVisualStyleBackColor = true;
      // 
      // cboWebActiveLogFormat
      // 
      this.cboWebActiveLogFormat.FormattingEnabled = true;
      this.cboWebActiveLogFormat.Items.AddRange(new object[] {
            "W3C Extended Log File Format",
            "Microsoft IIS Log file format",
            "NCSA common log file format"});
      this.cboWebActiveLogFormat.Location = new System.Drawing.Point(9, 30);
      this.cboWebActiveLogFormat.Name = "cboWebActiveLogFormat";
      this.cboWebActiveLogFormat.Size = new System.Drawing.Size(205, 21);
      this.cboWebActiveLogFormat.TabIndex = 14;
      // 
      // cbLoginAuthorOnOff
      // 
      this.cbLoginAuthorOnOff.AutoSize = true;
      this.cbLoginAuthorOnOff.Checked = true;
      this.cbLoginAuthorOnOff.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbLoginAuthorOnOff.Location = new System.Drawing.Point(11, 1);
      this.cbLoginAuthorOnOff.Name = "cbLoginAuthorOnOff";
      this.cbLoginAuthorOnOff.Size = new System.Drawing.Size(15, 14);
      this.cbLoginAuthorOnOff.TabIndex = 57;
      this.cbLoginAuthorOnOff.UseVisualStyleBackColor = true;
      this.cbLoginAuthorOnOff.CheckedChanged += new System.EventHandler(this.cbLoginAuthorOnOff_CheckedChanged);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(8, 14);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(86, 13);
      this.label6.TabIndex = 56;
      this.label6.Text = "Active log format";
      // 
      // tbIISNotDefault
      // 
      this.tbIISNotDefault.Location = new System.Drawing.Point(9, 216);
      this.tbIISNotDefault.Name = "tbIISNotDefault";
      this.tbIISNotDefault.Size = new System.Drawing.Size(253, 20);
      this.tbIISNotDefault.TabIndex = 13;
      this.tbIISNotDefault.Visible = false;
      // 
      // gbIIS
      // 
      this.gbIIS.BackColor = System.Drawing.Color.LightGray;
      this.gbIIS.Controls.Add(this.lvWebservers);
      this.gbIIS.Controls.Add(this.btAddWebSrv);
      this.gbIIS.Controls.Add(this.btRemoveWebSrv);
      this.gbIIS.Controls.Add(this.lbWebServers);
      this.gbIIS.Location = new System.Drawing.Point(6, 23);
      this.gbIIS.Name = "gbIIS";
      this.gbIIS.Size = new System.Drawing.Size(357, 174);
      this.gbIIS.TabIndex = 58;
      this.gbIIS.TabStop = false;
      // 
      // lvWebservers
      // 
      this.lvWebservers.Location = new System.Drawing.Point(6, 27);
      this.lvWebservers.Name = "lvWebservers";
      this.lvWebservers.Size = new System.Drawing.Size(345, 113);
      this.lvWebservers.TabIndex = 5;
      this.lvWebservers.UseCompatibleStateImageBehavior = false;
      // 
      // btAddWebSrv
      // 
      this.btAddWebSrv.Location = new System.Drawing.Point(6, 146);
      this.btAddWebSrv.Name = "btAddWebSrv";
      this.btAddWebSrv.Size = new System.Drawing.Size(39, 22);
      this.btAddWebSrv.TabIndex = 3;
      this.btAddWebSrv.Text = "Add";
      this.btAddWebSrv.UseVisualStyleBackColor = true;
      this.btAddWebSrv.Click += new System.EventHandler(this.btAddWebSrv_Click);
      // 
      // btRemoveWebSrv
      // 
      this.btRemoveWebSrv.Location = new System.Drawing.Point(45, 146);
      this.btRemoveWebSrv.Name = "btRemoveWebSrv";
      this.btRemoveWebSrv.Size = new System.Drawing.Size(50, 22);
      this.btRemoveWebSrv.TabIndex = 4;
      this.btRemoveWebSrv.Text = "Delete ";
      this.btRemoveWebSrv.UseVisualStyleBackColor = true;
      // 
      // lbWebServers
      // 
      this.lbWebServers.AutoSize = true;
      this.lbWebServers.Location = new System.Drawing.Point(5, 13);
      this.lbWebServers.Name = "lbWebServers";
      this.lbWebServers.Size = new System.Drawing.Size(67, 13);
      this.lbWebServers.TabIndex = 0;
      this.lbWebServers.Text = "Web Server:";
      // 
      // cbIISOnOff
      // 
      this.cbIISOnOff.AutoSize = true;
      this.cbIISOnOff.Checked = true;
      this.cbIISOnOff.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbIISOnOff.Location = new System.Drawing.Point(18, 6);
      this.cbIISOnOff.Name = "cbIISOnOff";
      this.cbIISOnOff.Size = new System.Drawing.Size(131, 17);
      this.cbIISOnOff.TabIndex = 1;
      this.cbIISOnOff.Text = "Configure Web Server";
      this.cbIISOnOff.UseVisualStyleBackColor = true;
      this.cbIISOnOff.CheckedChanged += new System.EventHandler(this.cbIISOnOff_CheckedChanged);
      // 
      // tabPage5
      // 
      this.tabPage5.BackColor = System.Drawing.Color.LightGray;
      this.tabPage5.Controls.Add(this.lbMailSrvNotDefault);
      this.tabPage5.Controls.Add(this.tbMailSrvNotDefault);
      this.tabPage5.Controls.Add(this.gbMailSrvConfigure);
      this.tabPage5.Controls.Add(this.gbMailSrvLogging);
      this.tabPage5.Location = new System.Drawing.Point(4, 22);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage5.Size = new System.Drawing.Size(599, 255);
      this.tabPage5.TabIndex = 2;
      this.tabPage5.Text = "Mail Server";
      // 
      // lbMailSrvNotDefault
      // 
      this.lbMailSrvNotDefault.AutoSize = true;
      this.lbMailSrvNotDefault.Location = new System.Drawing.Point(9, 213);
      this.lbMailSrvNotDefault.Name = "lbMailSrvNotDefault";
      this.lbMailSrvNotDefault.Size = new System.Drawing.Size(150, 13);
      this.lbMailSrvNotDefault.TabIndex = 68;
      this.lbMailSrvNotDefault.Text = "If not default, give a comment:";
      this.lbMailSrvNotDefault.Visible = false;
      // 
      // tbMailSrvNotDefault
      // 
      this.tbMailSrvNotDefault.Location = new System.Drawing.Point(12, 229);
      this.tbMailSrvNotDefault.Name = "tbMailSrvNotDefault";
      this.tbMailSrvNotDefault.Size = new System.Drawing.Size(159, 20);
      this.tbMailSrvNotDefault.TabIndex = 67;
      this.tbMailSrvNotDefault.Visible = false;
      // 
      // gbMailSrvConfigure
      // 
      this.gbMailSrvConfigure.Controls.Add(this.gbMailSrvRelay);
      this.gbMailSrvConfigure.Controls.Add(this.cbMailSrvRelay);
      this.gbMailSrvConfigure.Controls.Add(this.cbMailSrvAllowAnonym);
      this.gbMailSrvConfigure.Controls.Add(this.cbMailSrvConfOnOrOff);
      this.gbMailSrvConfigure.Location = new System.Drawing.Point(3, 8);
      this.gbMailSrvConfigure.Name = "gbMailSrvConfigure";
      this.gbMailSrvConfigure.Size = new System.Drawing.Size(380, 202);
      this.gbMailSrvConfigure.TabIndex = 64;
      this.gbMailSrvConfigure.TabStop = false;
      this.gbMailSrvConfigure.Text = "    Configure Mail Server";
      // 
      // gbMailSrvRelay
      // 
      this.gbMailSrvRelay.Controls.Add(this.cbMailSrvRelayAllowSuccessAuthen);
      this.gbMailSrvRelay.Controls.Add(this.button3);
      this.gbMailSrvRelay.Controls.Add(this.button2);
      this.gbMailSrvRelay.Controls.Add(this.listView2);
      this.gbMailSrvRelay.Controls.Add(this.label132);
      this.gbMailSrvRelay.Controls.Add(this.rbMailSrvRelayAllExceptListBelow);
      this.gbMailSrvRelay.Controls.Add(this.rbMailSrvRelayOnlyListBelow);
      this.gbMailSrvRelay.Location = new System.Drawing.Point(6, 53);
      this.gbMailSrvRelay.Name = "gbMailSrvRelay";
      this.gbMailSrvRelay.Size = new System.Drawing.Size(368, 143);
      this.gbMailSrvRelay.TabIndex = 64;
      this.gbMailSrvRelay.TabStop = false;
      this.gbMailSrvRelay.Text = "Select which computer may relay through this ";
      // 
      // cbMailSrvRelayAllowSuccessAuthen
      // 
      this.cbMailSrvRelayAllowSuccessAuthen.AutoSize = true;
      this.cbMailSrvRelayAllowSuccessAuthen.Location = new System.Drawing.Point(3, 123);
      this.cbMailSrvRelayAllowSuccessAuthen.Name = "cbMailSrvRelayAllowSuccessAuthen";
      this.cbMailSrvRelayAllowSuccessAuthen.Size = new System.Drawing.Size(262, 17);
      this.cbMailSrvRelayAllowSuccessAuthen.TabIndex = 6;
      this.cbMailSrvRelayAllowSuccessAuthen.Text = "Allow all computers which successful authenticate";
      this.cbMailSrvRelayAllowSuccessAuthen.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(300, 95);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(62, 27);
      this.button3.TabIndex = 5;
      this.button3.Text = "Remove";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(300, 62);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(62, 27);
      this.button2.TabIndex = 4;
      this.button2.Text = "Add...";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // listView2
      // 
      this.listView2.Location = new System.Drawing.Point(7, 62);
      this.listView2.Name = "listView2";
      this.listView2.Size = new System.Drawing.Size(287, 57);
      this.listView2.TabIndex = 3;
      this.listView2.UseCompatibleStateImageBehavior = false;
      // 
      // label132
      // 
      this.label132.AutoSize = true;
      this.label132.Location = new System.Drawing.Point(4, 46);
      this.label132.Name = "label132";
      this.label132.Size = new System.Drawing.Size(60, 13);
      this.label132.TabIndex = 2;
      this.label132.Text = "Computers:";
      // 
      // rbMailSrvRelayAllExceptListBelow
      // 
      this.rbMailSrvRelayAllExceptListBelow.AutoSize = true;
      this.rbMailSrvRelayAllExceptListBelow.Location = new System.Drawing.Point(18, 31);
      this.rbMailSrvRelayAllExceptListBelow.Name = "rbMailSrvRelayAllExceptListBelow";
      this.rbMailSrvRelayAllExceptListBelow.Size = new System.Drawing.Size(135, 17);
      this.rbMailSrvRelayAllExceptListBelow.TabIndex = 1;
      this.rbMailSrvRelayAllExceptListBelow.TabStop = true;
      this.rbMailSrvRelayAllExceptListBelow.Text = "All except the list below";
      this.rbMailSrvRelayAllExceptListBelow.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
      this.rbMailSrvRelayAllExceptListBelow.UseVisualStyleBackColor = true;
      // 
      // rbMailSrvRelayOnlyListBelow
      // 
      this.rbMailSrvRelayOnlyListBelow.AutoSize = true;
      this.rbMailSrvRelayOnlyListBelow.Location = new System.Drawing.Point(18, 15);
      this.rbMailSrvRelayOnlyListBelow.Name = "rbMailSrvRelayOnlyListBelow";
      this.rbMailSrvRelayOnlyListBelow.Size = new System.Drawing.Size(110, 17);
      this.rbMailSrvRelayOnlyListBelow.TabIndex = 0;
      this.rbMailSrvRelayOnlyListBelow.TabStop = true;
      this.rbMailSrvRelayOnlyListBelow.Text = "Only the list below";
      this.rbMailSrvRelayOnlyListBelow.UseVisualStyleBackColor = true;
      // 
      // cbMailSrvRelay
      // 
      this.cbMailSrvRelay.AutoSize = true;
      this.cbMailSrvRelay.Location = new System.Drawing.Point(6, 34);
      this.cbMailSrvRelay.Name = "cbMailSrvRelay";
      this.cbMailSrvRelay.Size = new System.Drawing.Size(106, 17);
      this.cbMailSrvRelay.TabIndex = 63;
      this.cbMailSrvRelay.Text = "Relay Restriction";
      this.cbMailSrvRelay.UseVisualStyleBackColor = true;
      this.cbMailSrvRelay.CheckedChanged += new System.EventHandler(this.cbMailSrvRelay_CheckedChanged);
      // 
      // cbMailSrvAllowAnonym
      // 
      this.cbMailSrvAllowAnonym.AutoSize = true;
      this.cbMailSrvAllowAnonym.Location = new System.Drawing.Point(6, 16);
      this.cbMailSrvAllowAnonym.Name = "cbMailSrvAllowAnonym";
      this.cbMailSrvAllowAnonym.Size = new System.Drawing.Size(215, 17);
      this.cbMailSrvAllowAnonym.TabIndex = 50;
      this.cbMailSrvAllowAnonym.Text = "Allow anonymous access to this website";
      this.cbMailSrvAllowAnonym.UseVisualStyleBackColor = true;
      this.cbMailSrvAllowAnonym.CheckedChanged += new System.EventHandler(this.cbMailSrvAllowAnonym_CheckedChanged);
      // 
      // cbMailSrvConfOnOrOff
      // 
      this.cbMailSrvConfOnOrOff.AutoSize = true;
      this.cbMailSrvConfOnOrOff.Location = new System.Drawing.Point(6, -1);
      this.cbMailSrvConfOnOrOff.Name = "cbMailSrvConfOnOrOff";
      this.cbMailSrvConfOnOrOff.Size = new System.Drawing.Size(15, 14);
      this.cbMailSrvConfOnOrOff.TabIndex = 62;
      this.cbMailSrvConfOnOrOff.UseVisualStyleBackColor = true;
      this.cbMailSrvConfOnOrOff.CheckedChanged += new System.EventHandler(this.cbMailSrvConfOnOrOff_CheckedChanged);
      // 
      // gbMailSrvLogging
      // 
      this.gbMailSrvLogging.BackColor = System.Drawing.Color.LightGray;
      this.gbMailSrvLogging.Controls.Add(this.gbMailSrvLogDir);
      this.gbMailSrvLogging.Controls.Add(this.gbMailLoggingSchedule);
      this.gbMailSrvLogging.Controls.Add(this.cboMailActiveLogFormat);
      this.gbMailSrvLogging.Controls.Add(this.cbLoggingMailOnOff);
      this.gbMailSrvLogging.Controls.Add(this.label82);
      this.gbMailSrvLogging.Location = new System.Drawing.Point(389, 5);
      this.gbMailSrvLogging.Name = "gbMailSrvLogging";
      this.gbMailSrvLogging.Size = new System.Drawing.Size(204, 244);
      this.gbMailSrvLogging.TabIndex = 63;
      this.gbMailSrvLogging.TabStop = false;
      this.gbMailSrvLogging.Text = "     Logging";
      // 
      // gbMailSrvLogDir
      // 
      this.gbMailSrvLogDir.Controls.Add(this.cbMailLogDelete);
      this.gbMailSrvLogDir.Controls.Add(this.btMailLogBrowse);
      this.gbMailSrvLogDir.Controls.Add(this.tbMailLogLocation);
      this.gbMailSrvLogDir.Location = new System.Drawing.Point(9, 173);
      this.gbMailSrvLogDir.Name = "gbMailSrvLogDir";
      this.gbMailSrvLogDir.Size = new System.Drawing.Size(185, 65);
      this.gbMailSrvLogDir.TabIndex = 60;
      this.gbMailSrvLogDir.TabStop = false;
      this.gbMailSrvLogDir.Text = "Log file directory";
      // 
      // cbMailLogDelete
      // 
      this.cbMailLogDelete.AutoSize = true;
      this.cbMailLogDelete.Checked = true;
      this.cbMailLogDelete.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbMailLogDelete.Location = new System.Drawing.Point(6, 41);
      this.cbMailLogDelete.Name = "cbMailLogDelete";
      this.cbMailLogDelete.Size = new System.Drawing.Size(112, 17);
      this.cbMailLogDelete.TabIndex = 3;
      this.cbMailLogDelete.Text = "Delete old log files";
      this.cbMailLogDelete.UseVisualStyleBackColor = true;
      // 
      // btMailLogBrowse
      // 
      this.btMailLogBrowse.Location = new System.Drawing.Point(152, 16);
      this.btMailLogBrowse.Name = "btMailLogBrowse";
      this.btMailLogBrowse.Size = new System.Drawing.Size(27, 23);
      this.btMailLogBrowse.TabIndex = 1;
      this.btMailLogBrowse.Text = "...";
      this.btMailLogBrowse.UseVisualStyleBackColor = true;
      this.btMailLogBrowse.Click += new System.EventHandler(this.btMailLogBrowse_Click);
      // 
      // tbMailLogLocation
      // 
      this.tbMailLogLocation.Location = new System.Drawing.Point(6, 18);
      this.tbMailLogLocation.Name = "tbMailLogLocation";
      this.tbMailLogLocation.Size = new System.Drawing.Size(140, 20);
      this.tbMailLogLocation.TabIndex = 0;
      this.tbMailLogLocation.Text = "C:\\WINDOWS\\System32\\LogFiles";
      // 
      // gbMailLoggingSchedule
      // 
      this.gbMailLoggingSchedule.Controls.Add(this.label80);
      this.gbMailLoggingSchedule.Controls.Add(this.nudMailLogSize);
      this.gbMailLoggingSchedule.Controls.Add(this.rbMailLogSizeReach);
      this.gbMailLoggingSchedule.Controls.Add(this.rbMailLogUnlimitedSize);
      this.gbMailLoggingSchedule.Controls.Add(this.rbMailLogMonth);
      this.gbMailLoggingSchedule.Controls.Add(this.rbMailLogWeek);
      this.gbMailLoggingSchedule.Controls.Add(this.rbMailLogDay);
      this.gbMailLoggingSchedule.Controls.Add(this.rbMailLogH);
      this.gbMailLoggingSchedule.Location = new System.Drawing.Point(9, 52);
      this.gbMailLoggingSchedule.Name = "gbMailLoggingSchedule";
      this.gbMailLoggingSchedule.Size = new System.Drawing.Size(185, 122);
      this.gbMailLoggingSchedule.TabIndex = 59;
      this.gbMailLoggingSchedule.TabStop = false;
      this.gbMailLoggingSchedule.Text = "New log schedule";
      // 
      // label80
      // 
      this.label80.AutoSize = true;
      this.label80.Enabled = false;
      this.label80.Location = new System.Drawing.Point(160, 102);
      this.label80.Name = "label80";
      this.label80.Size = new System.Drawing.Size(23, 13);
      this.label80.TabIndex = 61;
      this.label80.Text = "MB";
      // 
      // nudMailLogSize
      // 
      this.nudMailLogSize.Location = new System.Drawing.Point(120, 98);
      this.nudMailLogSize.Name = "nudMailLogSize";
      this.nudMailLogSize.Size = new System.Drawing.Size(38, 20);
      this.nudMailLogSize.TabIndex = 60;
      this.nudMailLogSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
      // 
      // rbMailLogSizeReach
      // 
      this.rbMailLogSizeReach.AutoSize = true;
      this.rbMailLogSizeReach.Location = new System.Drawing.Point(6, 102);
      this.rbMailLogSizeReach.Name = "rbMailLogSizeReach";
      this.rbMailLogSizeReach.Size = new System.Drawing.Size(119, 17);
      this.rbMailLogSizeReach.TabIndex = 5;
      this.rbMailLogSizeReach.Text = "When size reaches:";
      this.rbMailLogSizeReach.UseVisualStyleBackColor = true;
      this.rbMailLogSizeReach.CheckedChanged += new System.EventHandler(this.rbMailLogSizeReach_CheckedChanged);
      // 
      // rbMailLogUnlimitedSize
      // 
      this.rbMailLogUnlimitedSize.AutoSize = true;
      this.rbMailLogUnlimitedSize.Location = new System.Drawing.Point(6, 86);
      this.rbMailLogUnlimitedSize.Name = "rbMailLogUnlimitedSize";
      this.rbMailLogUnlimitedSize.Size = new System.Drawing.Size(105, 17);
      this.rbMailLogUnlimitedSize.TabIndex = 4;
      this.rbMailLogUnlimitedSize.Text = "Unlimited file size";
      this.rbMailLogUnlimitedSize.UseVisualStyleBackColor = true;
      // 
      // rbMailLogMonth
      // 
      this.rbMailLogMonth.AutoSize = true;
      this.rbMailLogMonth.Location = new System.Drawing.Point(6, 68);
      this.rbMailLogMonth.Name = "rbMailLogMonth";
      this.rbMailLogMonth.Size = new System.Drawing.Size(62, 17);
      this.rbMailLogMonth.TabIndex = 3;
      this.rbMailLogMonth.Text = "Monthly";
      this.rbMailLogMonth.UseVisualStyleBackColor = true;
      // 
      // rbMailLogWeek
      // 
      this.rbMailLogWeek.AutoSize = true;
      this.rbMailLogWeek.Location = new System.Drawing.Point(6, 50);
      this.rbMailLogWeek.Name = "rbMailLogWeek";
      this.rbMailLogWeek.Size = new System.Drawing.Size(61, 17);
      this.rbMailLogWeek.TabIndex = 2;
      this.rbMailLogWeek.Text = "Weekly";
      this.rbMailLogWeek.UseVisualStyleBackColor = true;
      // 
      // rbMailLogDay
      // 
      this.rbMailLogDay.AutoSize = true;
      this.rbMailLogDay.Checked = true;
      this.rbMailLogDay.Location = new System.Drawing.Point(6, 32);
      this.rbMailLogDay.Name = "rbMailLogDay";
      this.rbMailLogDay.Size = new System.Drawing.Size(48, 17);
      this.rbMailLogDay.TabIndex = 1;
      this.rbMailLogDay.TabStop = true;
      this.rbMailLogDay.Text = "Daily";
      this.rbMailLogDay.UseVisualStyleBackColor = true;
      // 
      // rbMailLogH
      // 
      this.rbMailLogH.AutoSize = true;
      this.rbMailLogH.Location = new System.Drawing.Point(6, 15);
      this.rbMailLogH.Name = "rbMailLogH";
      this.rbMailLogH.Size = new System.Drawing.Size(55, 17);
      this.rbMailLogH.TabIndex = 0;
      this.rbMailLogH.Text = "Hourly";
      this.rbMailLogH.UseVisualStyleBackColor = true;
      // 
      // cboMailActiveLogFormat
      // 
      this.cboMailActiveLogFormat.FormattingEnabled = true;
      this.cboMailActiveLogFormat.Items.AddRange(new object[] {
            "W3C Extended Log File Format",
            "Microsoft IIS Log file format",
            "NCSA common log file format"});
      this.cboMailActiveLogFormat.Location = new System.Drawing.Point(9, 32);
      this.cboMailActiveLogFormat.Name = "cboMailActiveLogFormat";
      this.cboMailActiveLogFormat.Size = new System.Drawing.Size(185, 21);
      this.cboMailActiveLogFormat.TabIndex = 58;
      // 
      // cbLoggingMailOnOff
      // 
      this.cbLoggingMailOnOff.AutoSize = true;
      this.cbLoggingMailOnOff.Location = new System.Drawing.Point(11, 1);
      this.cbLoggingMailOnOff.Name = "cbLoggingMailOnOff";
      this.cbLoggingMailOnOff.Size = new System.Drawing.Size(15, 14);
      this.cbLoggingMailOnOff.TabIndex = 57;
      this.cbLoggingMailOnOff.UseVisualStyleBackColor = true;
      this.cbLoggingMailOnOff.CheckedChanged += new System.EventHandler(this.cbLoggingMailOnOff_CheckedChanged);
      // 
      // label82
      // 
      this.label82.AutoSize = true;
      this.label82.Location = new System.Drawing.Point(6, 16);
      this.label82.Name = "label82";
      this.label82.Size = new System.Drawing.Size(86, 13);
      this.label82.TabIndex = 56;
      this.label82.Text = "Active log format";
      // 
      // tabPageFTP
      // 
      this.tabPageFTP.BackColor = System.Drawing.Color.LightGray;
      this.tabPageFTP.Controls.Add(this.groupBox14);
      this.tabPageFTP.Controls.Add(this.label54);
      this.tabPageFTP.Controls.Add(this.rbFtpShareLocated);
      this.tabPageFTP.Controls.Add(this.rbFTPLocalLocated);
      this.tabPageFTP.Controls.Add(this.groupBox10);
      this.tabPageFTP.Location = new System.Drawing.Point(4, 22);
      this.tabPageFTP.Name = "tabPageFTP";
      this.tabPageFTP.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageFTP.Size = new System.Drawing.Size(599, 255);
      this.tabPageFTP.TabIndex = 3;
      this.tabPageFTP.Text = "FTP Server";
      // 
      // groupBox14
      // 
      this.groupBox14.Controls.Add(this.btRemoveFtpSrv);
      this.groupBox14.Controls.Add(this.btAddFtpSrv);
      this.groupBox14.Controls.Add(this.listView1);
      this.groupBox14.Controls.Add(this.lbFTPNet);
      this.groupBox14.Controls.Add(this.cbFTPDir);
      this.groupBox14.Controls.Add(this.btAddFtpUser);
      this.groupBox14.Controls.Add(this.btFtpShareConnect);
      this.groupBox14.Controls.Add(this.lbFTPLocal);
      this.groupBox14.Controls.Add(this.cbDisableFTPAnonymous);
      this.groupBox14.Controls.Add(this.cbFTPServerLogs);
      this.groupBox14.Controls.Add(this.cbFTPServerWrite);
      this.groupBox14.Controls.Add(this.cbFTPServerRead);
      this.groupBox14.Controls.Add(this.tbFTPPath);
      this.groupBox14.Location = new System.Drawing.Point(6, 64);
      this.groupBox14.Name = "groupBox14";
      this.groupBox14.Size = new System.Drawing.Size(374, 188);
      this.groupBox14.TabIndex = 59;
      this.groupBox14.TabStop = false;
      this.groupBox14.Text = "FTP Site Directory";
      // 
      // btRemoveFtpSrv
      // 
      this.btRemoveFtpSrv.Location = new System.Drawing.Point(295, 17);
      this.btRemoveFtpSrv.Name = "btRemoveFtpSrv";
      this.btRemoveFtpSrv.Size = new System.Drawing.Size(69, 23);
      this.btRemoveFtpSrv.TabIndex = 66;
      this.btRemoveFtpSrv.Text = "Delete FTP";
      this.btRemoveFtpSrv.UseVisualStyleBackColor = true;
      // 
      // btAddFtpSrv
      // 
      this.btAddFtpSrv.Location = new System.Drawing.Point(255, 17);
      this.btAddFtpSrv.Name = "btAddFtpSrv";
      this.btAddFtpSrv.Size = new System.Drawing.Size(39, 23);
      this.btAddFtpSrv.TabIndex = 65;
      this.btAddFtpSrv.Text = "Add";
      this.btAddFtpSrv.UseVisualStyleBackColor = true;
      this.btAddFtpSrv.Click += new System.EventHandler(this.btAddFtpSrv_Click);
      // 
      // listView1
      // 
      this.listView1.Location = new System.Drawing.Point(105, 68);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(263, 86);
      this.listView1.TabIndex = 64;
      this.listView1.UseCompatibleStateImageBehavior = false;
      // 
      // lbFTPNet
      // 
      this.lbFTPNet.AutoSize = true;
      this.lbFTPNet.Location = new System.Drawing.Point(2, 22);
      this.lbFTPNet.Name = "lbFTPNet";
      this.lbFTPNet.Size = new System.Drawing.Size(84, 13);
      this.lbFTPNet.TabIndex = 63;
      this.lbFTPNet.Text = "NetWork Share:";
      this.lbFTPNet.Visible = false;
      // 
      // cbFTPDir
      // 
      this.cbFTPDir.FormattingEnabled = true;
      this.cbFTPDir.Location = new System.Drawing.Point(92, 18);
      this.cbFTPDir.Name = "cbFTPDir";
      this.cbFTPDir.Size = new System.Drawing.Size(157, 21);
      this.cbFTPDir.TabIndex = 62;
      // 
      // btAddFtpUser
      // 
      this.btAddFtpUser.Location = new System.Drawing.Point(287, 159);
      this.btAddFtpUser.Name = "btAddFtpUser";
      this.btAddFtpUser.Size = new System.Drawing.Size(81, 23);
      this.btAddFtpUser.TabIndex = 61;
      this.btAddFtpUser.Text = "Add FTP user";
      this.btAddFtpUser.UseVisualStyleBackColor = true;
      this.btAddFtpUser.Click += new System.EventHandler(this.btAddFtpUser_Click);
      // 
      // btFtpShareConnect
      // 
      this.btFtpShareConnect.Location = new System.Drawing.Point(292, 17);
      this.btFtpShareConnect.Name = "btFtpShareConnect";
      this.btFtpShareConnect.Size = new System.Drawing.Size(70, 23);
      this.btFtpShareConnect.TabIndex = 60;
      this.btFtpShareConnect.Text = "Con&nect As";
      this.btFtpShareConnect.UseVisualStyleBackColor = true;
      this.btFtpShareConnect.Visible = false;
      // 
      // lbFTPLocal
      // 
      this.lbFTPLocal.AutoSize = true;
      this.lbFTPLocal.Location = new System.Drawing.Point(13, 21);
      this.lbFTPLocal.Name = "lbFTPLocal";
      this.lbFTPLocal.Size = new System.Drawing.Size(61, 13);
      this.lbFTPLocal.TabIndex = 59;
      this.lbFTPLocal.Text = "Local Path:";
      // 
      // cbDisableFTPAnonymous
      // 
      this.cbDisableFTPAnonymous.AutoSize = true;
      this.cbDisableFTPAnonymous.Location = new System.Drawing.Point(105, 45);
      this.cbDisableFTPAnonymous.Name = "cbDisableFTPAnonymous";
      this.cbDisableFTPAnonymous.Size = new System.Drawing.Size(118, 17);
      this.cbDisableFTPAnonymous.TabIndex = 58;
      this.cbDisableFTPAnonymous.Text = "Disable anonymous";
      this.cbDisableFTPAnonymous.UseVisualStyleBackColor = true;
      // 
      // cbFTPServerLogs
      // 
      this.cbFTPServerLogs.AutoSize = true;
      this.cbFTPServerLogs.Checked = true;
      this.cbFTPServerLogs.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbFTPServerLogs.Location = new System.Drawing.Point(13, 91);
      this.cbFTPServerLogs.Name = "cbFTPServerLogs";
      this.cbFTPServerLogs.Size = new System.Drawing.Size(70, 17);
      this.cbFTPServerLogs.TabIndex = 57;
      this.cbFTPServerLogs.Text = "Log visits";
      this.cbFTPServerLogs.UseVisualStyleBackColor = true;
      // 
      // cbFTPServerWrite
      // 
      this.cbFTPServerWrite.AutoSize = true;
      this.cbFTPServerWrite.Location = new System.Drawing.Point(13, 68);
      this.cbFTPServerWrite.Name = "cbFTPServerWrite";
      this.cbFTPServerWrite.Size = new System.Drawing.Size(51, 17);
      this.cbFTPServerWrite.TabIndex = 56;
      this.cbFTPServerWrite.Text = "Write";
      this.cbFTPServerWrite.UseVisualStyleBackColor = true;
      // 
      // cbFTPServerRead
      // 
      this.cbFTPServerRead.AutoSize = true;
      this.cbFTPServerRead.Checked = true;
      this.cbFTPServerRead.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbFTPServerRead.Location = new System.Drawing.Point(13, 45);
      this.cbFTPServerRead.Name = "cbFTPServerRead";
      this.cbFTPServerRead.Size = new System.Drawing.Size(52, 17);
      this.cbFTPServerRead.TabIndex = 55;
      this.cbFTPServerRead.Text = "Read";
      this.cbFTPServerRead.UseVisualStyleBackColor = true;
      // 
      // tbFTPPath
      // 
      this.tbFTPPath.Location = new System.Drawing.Point(92, 18);
      this.tbFTPPath.Name = "tbFTPPath";
      this.tbFTPPath.Size = new System.Drawing.Size(190, 20);
      this.tbFTPPath.TabIndex = 10;
      this.tbFTPPath.Visible = false;
      // 
      // label54
      // 
      this.label54.AutoSize = true;
      this.label54.Location = new System.Drawing.Point(4, 8);
      this.label54.Name = "label54";
      this.label54.Size = new System.Drawing.Size(270, 13);
      this.label54.TabIndex = 58;
      this.label54.Text = "When connect to this resource, the content comes from";
      // 
      // rbFtpShareLocated
      // 
      this.rbFtpShareLocated.AutoSize = true;
      this.rbFtpShareLocated.Location = new System.Drawing.Point(11, 46);
      this.rbFtpShareLocated.Name = "rbFtpShareLocated";
      this.rbFtpShareLocated.Size = new System.Drawing.Size(199, 17);
      this.rbFtpShareLocated.TabIndex = 57;
      this.rbFtpShareLocated.Text = "a share located on another computer";
      this.rbFtpShareLocated.UseVisualStyleBackColor = true;
      this.rbFtpShareLocated.Click += new System.EventHandler(this.rbFtpShareLocated_Click);
      // 
      // rbFTPLocalLocated
      // 
      this.rbFTPLocalLocated.AutoSize = true;
      this.rbFTPLocalLocated.Checked = true;
      this.rbFTPLocalLocated.Location = new System.Drawing.Point(11, 24);
      this.rbFTPLocalLocated.Name = "rbFTPLocalLocated";
      this.rbFTPLocalLocated.Size = new System.Drawing.Size(196, 17);
      this.rbFTPLocalLocated.TabIndex = 56;
      this.rbFTPLocalLocated.TabStop = true;
      this.rbFTPLocalLocated.Text = "a directory located  on this computer";
      this.rbFTPLocalLocated.UseVisualStyleBackColor = true;
      this.rbFTPLocalLocated.Click += new System.EventHandler(this.rbFTPLocalLocated_Click);
      // 
      // groupBox10
      // 
      this.groupBox10.BackColor = System.Drawing.Color.LightGray;
      this.groupBox10.Controls.Add(this.gbFTPLogLocation);
      this.groupBox10.Controls.Add(this.gbFTPLogSchedule);
      this.groupBox10.Controls.Add(this.cboFTPLogFormat);
      this.groupBox10.Controls.Add(this.cbFTPLoggingOnOff);
      this.groupBox10.Controls.Add(this.label52);
      this.groupBox10.Location = new System.Drawing.Point(386, 4);
      this.groupBox10.Name = "groupBox10";
      this.groupBox10.Size = new System.Drawing.Size(207, 249);
      this.groupBox10.TabIndex = 55;
      this.groupBox10.TabStop = false;
      this.groupBox10.Text = "     Logging";
      // 
      // gbFTPLogLocation
      // 
      this.gbFTPLogLocation.Controls.Add(this.label74);
      this.gbFTPLogLocation.Controls.Add(this.cbFTPLogDelete);
      this.gbFTPLogLocation.Controls.Add(this.btFTPLogBrowse);
      this.gbFTPLogLocation.Controls.Add(this.tbFTPLogLocation);
      this.gbFTPLogLocation.Location = new System.Drawing.Point(9, 181);
      this.gbFTPLogLocation.Name = "gbFTPLogLocation";
      this.gbFTPLogLocation.Size = new System.Drawing.Size(188, 62);
      this.gbFTPLogLocation.TabIndex = 60;
      this.gbFTPLogLocation.TabStop = false;
      this.gbFTPLogLocation.Text = "Log file location";
      // 
      // label74
      // 
      this.label74.AutoSize = true;
      this.label74.Location = new System.Drawing.Point(23, 42);
      this.label74.Name = "label74";
      this.label74.Size = new System.Drawing.Size(77, 13);
      this.label74.TabIndex = 4;
      this.label74.Text = "Delete old logs";
      // 
      // cbFTPLogDelete
      // 
      this.cbFTPLogDelete.AutoSize = true;
      this.cbFTPLogDelete.Location = new System.Drawing.Point(6, 42);
      this.cbFTPLogDelete.Name = "cbFTPLogDelete";
      this.cbFTPLogDelete.Size = new System.Drawing.Size(15, 14);
      this.cbFTPLogDelete.TabIndex = 3;
      this.cbFTPLogDelete.UseVisualStyleBackColor = true;
      // 
      // btFTPLogBrowse
      // 
      this.btFTPLogBrowse.Location = new System.Drawing.Point(155, 25);
      this.btFTPLogBrowse.Name = "btFTPLogBrowse";
      this.btFTPLogBrowse.Size = new System.Drawing.Size(27, 23);
      this.btFTPLogBrowse.TabIndex = 1;
      this.btFTPLogBrowse.Text = "...";
      this.btFTPLogBrowse.UseVisualStyleBackColor = true;
      this.btFTPLogBrowse.Click += new System.EventHandler(this.btFTPLogBrowse_Click);
      // 
      // tbFTPLogLocation
      // 
      this.tbFTPLogLocation.Location = new System.Drawing.Point(6, 19);
      this.tbFTPLogLocation.Name = "tbFTPLogLocation";
      this.tbFTPLogLocation.Size = new System.Drawing.Size(143, 20);
      this.tbFTPLogLocation.TabIndex = 0;
      this.tbFTPLogLocation.Text = "C:\\WINDOWS\\System32\\LogFiles";
      // 
      // gbFTPLogSchedule
      // 
      this.gbFTPLogSchedule.Controls.Add(this.label10);
      this.gbFTPLogSchedule.Controls.Add(this.nudFTPLogSize);
      this.gbFTPLogSchedule.Controls.Add(this.rbFTPLogSizeReach);
      this.gbFTPLogSchedule.Controls.Add(this.rbFTPLogUnlimit);
      this.gbFTPLogSchedule.Controls.Add(this.rbFTPLogMonth);
      this.gbFTPLogSchedule.Controls.Add(this.rbFTPLogWeek);
      this.gbFTPLogSchedule.Controls.Add(this.rbFTPLogDay);
      this.gbFTPLogSchedule.Controls.Add(this.rbFTPLogHour);
      this.gbFTPLogSchedule.Location = new System.Drawing.Point(9, 49);
      this.gbFTPLogSchedule.Name = "gbFTPLogSchedule";
      this.gbFTPLogSchedule.Size = new System.Drawing.Size(190, 129);
      this.gbFTPLogSchedule.TabIndex = 59;
      this.gbFTPLogSchedule.TabStop = false;
      this.gbFTPLogSchedule.Text = "New log schedule";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Enabled = false;
      this.label10.Location = new System.Drawing.Point(165, 100);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(23, 13);
      this.label10.TabIndex = 61;
      this.label10.Text = "MB";
      // 
      // nudFTPLogSize
      // 
      this.nudFTPLogSize.Location = new System.Drawing.Point(120, 97);
      this.nudFTPLogSize.Name = "nudFTPLogSize";
      this.nudFTPLogSize.Size = new System.Drawing.Size(46, 20);
      this.nudFTPLogSize.TabIndex = 60;
      // 
      // rbFTPLogSizeReach
      // 
      this.rbFTPLogSizeReach.AutoSize = true;
      this.rbFTPLogSizeReach.Location = new System.Drawing.Point(6, 99);
      this.rbFTPLogSizeReach.Name = "rbFTPLogSizeReach";
      this.rbFTPLogSizeReach.Size = new System.Drawing.Size(119, 17);
      this.rbFTPLogSizeReach.TabIndex = 5;
      this.rbFTPLogSizeReach.Text = "When size reaches:";
      this.rbFTPLogSizeReach.UseVisualStyleBackColor = true;
      // 
      // rbFTPLogUnlimit
      // 
      this.rbFTPLogUnlimit.AutoSize = true;
      this.rbFTPLogUnlimit.Location = new System.Drawing.Point(6, 82);
      this.rbFTPLogUnlimit.Name = "rbFTPLogUnlimit";
      this.rbFTPLogUnlimit.Size = new System.Drawing.Size(105, 17);
      this.rbFTPLogUnlimit.TabIndex = 4;
      this.rbFTPLogUnlimit.Text = "Unlimited file size";
      this.rbFTPLogUnlimit.UseVisualStyleBackColor = true;
      // 
      // rbFTPLogMonth
      // 
      this.rbFTPLogMonth.AutoSize = true;
      this.rbFTPLogMonth.Location = new System.Drawing.Point(6, 65);
      this.rbFTPLogMonth.Name = "rbFTPLogMonth";
      this.rbFTPLogMonth.Size = new System.Drawing.Size(62, 17);
      this.rbFTPLogMonth.TabIndex = 3;
      this.rbFTPLogMonth.Text = "Monthly";
      this.rbFTPLogMonth.UseVisualStyleBackColor = true;
      // 
      // rbFTPLogWeek
      // 
      this.rbFTPLogWeek.AutoSize = true;
      this.rbFTPLogWeek.Location = new System.Drawing.Point(6, 48);
      this.rbFTPLogWeek.Name = "rbFTPLogWeek";
      this.rbFTPLogWeek.Size = new System.Drawing.Size(61, 17);
      this.rbFTPLogWeek.TabIndex = 2;
      this.rbFTPLogWeek.Text = "Weekly";
      this.rbFTPLogWeek.UseVisualStyleBackColor = true;
      // 
      // rbFTPLogDay
      // 
      this.rbFTPLogDay.AutoSize = true;
      this.rbFTPLogDay.Checked = true;
      this.rbFTPLogDay.Location = new System.Drawing.Point(6, 31);
      this.rbFTPLogDay.Name = "rbFTPLogDay";
      this.rbFTPLogDay.Size = new System.Drawing.Size(48, 17);
      this.rbFTPLogDay.TabIndex = 1;
      this.rbFTPLogDay.TabStop = true;
      this.rbFTPLogDay.Text = "Daily";
      this.rbFTPLogDay.UseVisualStyleBackColor = true;
      // 
      // rbFTPLogHour
      // 
      this.rbFTPLogHour.AutoSize = true;
      this.rbFTPLogHour.Location = new System.Drawing.Point(6, 15);
      this.rbFTPLogHour.Name = "rbFTPLogHour";
      this.rbFTPLogHour.Size = new System.Drawing.Size(55, 17);
      this.rbFTPLogHour.TabIndex = 0;
      this.rbFTPLogHour.Text = "Hourly";
      this.rbFTPLogHour.UseVisualStyleBackColor = true;
      // 
      // cboFTPLogFormat
      // 
      this.cboFTPLogFormat.FormattingEnabled = true;
      this.cboFTPLogFormat.Items.AddRange(new object[] {
            "W3C Extended Log File Format",
            "Microsoft IIS Log file format"});
      this.cboFTPLogFormat.Location = new System.Drawing.Point(9, 29);
      this.cboFTPLogFormat.Name = "cboFTPLogFormat";
      this.cboFTPLogFormat.Size = new System.Drawing.Size(190, 21);
      this.cboFTPLogFormat.TabIndex = 58;
      // 
      // cbFTPLoggingOnOff
      // 
      this.cbFTPLoggingOnOff.AutoSize = true;
      this.cbFTPLoggingOnOff.Checked = true;
      this.cbFTPLoggingOnOff.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbFTPLoggingOnOff.Location = new System.Drawing.Point(9, 1);
      this.cbFTPLoggingOnOff.Name = "cbFTPLoggingOnOff";
      this.cbFTPLoggingOnOff.Size = new System.Drawing.Size(15, 14);
      this.cbFTPLoggingOnOff.TabIndex = 57;
      this.cbFTPLoggingOnOff.UseVisualStyleBackColor = true;
      this.cbFTPLoggingOnOff.CheckedChanged += new System.EventHandler(this.cbFTPLoggingOnOff_CheckedChanged);
      // 
      // label52
      // 
      this.label52.AutoSize = true;
      this.label52.Location = new System.Drawing.Point(6, 13);
      this.label52.Name = "label52";
      this.label52.Size = new System.Drawing.Size(86, 13);
      this.label52.TabIndex = 56;
      this.label52.Text = "Active log format";
      // 
      // wpFireWall
      // 
      this.wpFireWall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpFireWall.AntiAlias = false;
      this.wpFireWall.BackColor = System.Drawing.Color.Transparent;
      this.wpFireWall.Controls.Add(this.cbFireWallOnOff);
      this.wpFireWall.Controls.Add(this.gbFireWall);
      this.wpFireWall.Location = new System.Drawing.Point(7, 72);
      this.wpFireWall.Name = "wpFireWall";
      this.wpFireWall.PageDescription = "Change the settings for Windows Firewall";
      this.wpFireWall.PageTitle = "Windows settings";
      this.wpFireWall.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.SecurityAndLockdown;
      this.wpFireWall.Size = new System.Drawing.Size(608, 283);
      this.wpFireWall.TabIndex = 16;
      this.wpFireWall.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpFireWall_NextButtonClick);
      // 
      // cbFireWallOnOff
      // 
      this.cbFireWallOnOff.AutoSize = true;
      this.cbFireWallOnOff.Checked = true;
      this.cbFireWallOnOff.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbFireWallOnOff.Location = new System.Drawing.Point(10, 1);
      this.cbFireWallOnOff.Name = "cbFireWallOnOff";
      this.cbFireWallOnOff.Size = new System.Drawing.Size(15, 14);
      this.cbFireWallOnOff.TabIndex = 1;
      this.cbFireWallOnOff.UseVisualStyleBackColor = true;
      this.cbFireWallOnOff.CheckedChanged += new System.EventHandler(this.cbFireWallOnOff_CheckedChanged);
      // 
      // gbFireWall
      // 
      this.gbFireWall.Controls.Add(this.btFwModify);
      this.gbFireWall.Controls.Add(this.groupBox13);
      this.gbFireWall.Controls.Add(this.rbPortOutbound);
      this.gbFireWall.Controls.Add(this.rbPortInbound);
      this.gbFireWall.Controls.Add(this.cbUDP);
      this.gbFireWall.Controls.Add(this.cbTCP);
      this.gbFireWall.Controls.Add(this.TTtcpUdp);
      this.gbFireWall.Controls.Add(this.lbFwPort);
      this.gbFireWall.Controls.Add(this.lbFwName);
      this.gbFireWall.Controls.Add(this.tbFwPortnr);
      this.gbFireWall.Controls.Add(this.tbFwName);
      this.gbFireWall.Controls.Add(this.cbFwAddPort);
      this.gbFireWall.Controls.Add(this.btFwAdd);
      this.gbFireWall.Controls.Add(this.label35);
      this.gbFireWall.Controls.Add(this.cbFwWebServerHTTPs);
      this.gbFireWall.Controls.Add(this.cbFwSqlServer);
      this.gbFireWall.Controls.Add(this.cbFwWebServerHTTP);
      this.gbFireWall.Controls.Add(this.cbFwFtpServer);
      this.gbFireWall.Controls.Add(this.cbFwRemoteDesktop);
      this.gbFireWall.Controls.Add(this.cbFwPcAnywhere);
      this.gbFireWall.Controls.Add(this.lbfwSelectedItem);
      this.gbFireWall.Controls.Add(this.tbFirewallNotDefault);
      this.gbFireWall.Controls.Add(this.lbFirewallNotDefault);
      this.gbFireWall.Controls.Add(this.btFwDelete);
      this.gbFireWall.Controls.Add(this.label36);
      this.gbFireWall.Controls.Add(this.libFireWallExceptions);
      this.gbFireWall.Controls.Add(this.ttFireWall);
      this.gbFireWall.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gbFireWall.Location = new System.Drawing.Point(0, 0);
      this.gbFireWall.Name = "gbFireWall";
      this.gbFireWall.Size = new System.Drawing.Size(608, 283);
      this.gbFireWall.TabIndex = 10;
      this.gbFireWall.TabStop = false;
      this.gbFireWall.Text = "      Windows firewall";
      // 
      // btFwModify
      // 
      this.btFwModify.Location = new System.Drawing.Point(72, 253);
      this.btFwModify.Name = "btFwModify";
      this.btFwModify.Size = new System.Drawing.Size(75, 23);
      this.btFwModify.TabIndex = 194;
      this.btFwModify.Text = "Modify";
      this.btFwModify.UseVisualStyleBackColor = true;
      this.btFwModify.Click += new System.EventHandler(this.btFwModify_Click);
      // 
      // groupBox13
      // 
      this.groupBox13.Controls.Add(this.rbFwProgramOutbound);
      this.groupBox13.Controls.Add(this.rbFwProgramInbound);
      this.groupBox13.Controls.Add(this.btFwAddProgram);
      this.groupBox13.Controls.Add(this.cbFwAddApplication);
      this.groupBox13.Controls.Add(this.tbFwProgramPath);
      this.groupBox13.Controls.Add(this.lbFwAppLoc);
      this.groupBox13.Controls.Add(this.btFwBrowse);
      this.groupBox13.Location = new System.Drawing.Point(377, 81);
      this.groupBox13.Name = "groupBox13";
      this.groupBox13.Size = new System.Drawing.Size(219, 104);
      this.groupBox13.TabIndex = 193;
      this.groupBox13.TabStop = false;
      this.groupBox13.Text = "        Add your own application:";
      // 
      // rbFwProgramOutbound
      // 
      this.rbFwProgramOutbound.AutoSize = true;
      this.rbFwProgramOutbound.Enabled = false;
      this.rbFwProgramOutbound.Location = new System.Drawing.Point(14, 74);
      this.rbFwProgramOutbound.Name = "rbFwProgramOutbound";
      this.rbFwProgramOutbound.Size = new System.Drawing.Size(72, 17);
      this.rbFwProgramOutbound.TabIndex = 191;
      this.rbFwProgramOutbound.Text = "Outbound";
      this.rbFwProgramOutbound.UseVisualStyleBackColor = true;
      // 
      // rbFwProgramInbound
      // 
      this.rbFwProgramInbound.AutoSize = true;
      this.rbFwProgramInbound.Checked = true;
      this.rbFwProgramInbound.Enabled = false;
      this.rbFwProgramInbound.Location = new System.Drawing.Point(14, 51);
      this.rbFwProgramInbound.Name = "rbFwProgramInbound";
      this.rbFwProgramInbound.Size = new System.Drawing.Size(64, 17);
      this.rbFwProgramInbound.TabIndex = 190;
      this.rbFwProgramInbound.TabStop = true;
      this.rbFwProgramInbound.Text = "Inbound";
      this.rbFwProgramInbound.UseVisualStyleBackColor = true;
      // 
      // btFwAddProgram
      // 
      this.btFwAddProgram.Location = new System.Drawing.Point(151, 68);
      this.btFwAddProgram.Name = "btFwAddProgram";
      this.btFwAddProgram.Size = new System.Drawing.Size(58, 23);
      this.btFwAddProgram.TabIndex = 189;
      this.btFwAddProgram.Text = "Add";
      this.btFwAddProgram.UseVisualStyleBackColor = true;
      this.btFwAddProgram.Click += new System.EventHandler(this.btFwAddProgram_Click);
      // 
      // cbFwAddApplication
      // 
      this.cbFwAddApplication.AutoSize = true;
      this.cbFwAddApplication.ForeColor = System.Drawing.Color.Black;
      this.cbFwAddApplication.Location = new System.Drawing.Point(14, 1);
      this.cbFwAddApplication.Name = "cbFwAddApplication";
      this.cbFwAddApplication.Size = new System.Drawing.Size(15, 14);
      this.cbFwAddApplication.TabIndex = 185;
      this.cbFwAddApplication.UseVisualStyleBackColor = true;
      this.cbFwAddApplication.CheckedChanged += new System.EventHandler(this.cbFwAddApplication_CheckedChanged);
      // 
      // tbFwProgramPath
      // 
      this.tbFwProgramPath.Enabled = false;
      this.tbFwProgramPath.Location = new System.Drawing.Point(57, 19);
      this.tbFwProgramPath.Name = "tbFwProgramPath";
      this.tbFwProgramPath.Size = new System.Drawing.Size(152, 20);
      this.tbFwProgramPath.TabIndex = 186;
      // 
      // lbFwAppLoc
      // 
      this.lbFwAppLoc.AutoSize = true;
      this.lbFwAppLoc.Enabled = false;
      this.lbFwAppLoc.Location = new System.Drawing.Point(6, 22);
      this.lbFwAppLoc.Name = "lbFwAppLoc";
      this.lbFwAppLoc.Size = new System.Drawing.Size(51, 13);
      this.lbFwAppLoc.TabIndex = 188;
      this.lbFwAppLoc.Text = "Location:";
      // 
      // btFwBrowse
      // 
      this.btFwBrowse.Enabled = false;
      this.btFwBrowse.Location = new System.Drawing.Point(151, 42);
      this.btFwBrowse.Name = "btFwBrowse";
      this.btFwBrowse.Size = new System.Drawing.Size(58, 23);
      this.btFwBrowse.TabIndex = 187;
      this.btFwBrowse.Text = "Browse";
      this.btFwBrowse.UseVisualStyleBackColor = true;
      this.btFwBrowse.Click += new System.EventHandler(this.btFwBrowse_Click);
      // 
      // rbPortOutbound
      // 
      this.rbPortOutbound.AutoSize = true;
      this.rbPortOutbound.Enabled = false;
      this.rbPortOutbound.Location = new System.Drawing.Point(471, 251);
      this.rbPortOutbound.Name = "rbPortOutbound";
      this.rbPortOutbound.Size = new System.Drawing.Size(72, 17);
      this.rbPortOutbound.TabIndex = 192;
      this.rbPortOutbound.Text = "Outbound";
      this.rbPortOutbound.UseVisualStyleBackColor = true;
      // 
      // rbPortInbound
      // 
      this.rbPortInbound.AutoSize = true;
      this.rbPortInbound.Checked = true;
      this.rbPortInbound.Enabled = false;
      this.rbPortInbound.Location = new System.Drawing.Point(471, 232);
      this.rbPortInbound.Name = "rbPortInbound";
      this.rbPortInbound.Size = new System.Drawing.Size(64, 17);
      this.rbPortInbound.TabIndex = 191;
      this.rbPortInbound.TabStop = true;
      this.rbPortInbound.Text = "Inbound";
      this.rbPortInbound.UseVisualStyleBackColor = true;
      // 
      // cbUDP
      // 
      this.cbUDP.AutoSize = true;
      this.cbUDP.Enabled = false;
      this.cbUDP.Location = new System.Drawing.Point(537, 213);
      this.cbUDP.Name = "cbUDP";
      this.cbUDP.Size = new System.Drawing.Size(49, 17);
      this.cbUDP.TabIndex = 183;
      this.cbUDP.Text = "UDP";
      this.cbUDP.UseVisualStyleBackColor = true;
      // 
      // cbTCP
      // 
      this.cbTCP.AutoSize = true;
      this.cbTCP.Enabled = false;
      this.cbTCP.Location = new System.Drawing.Point(493, 213);
      this.cbTCP.Name = "cbTCP";
      this.cbTCP.Size = new System.Drawing.Size(47, 17);
      this.cbTCP.TabIndex = 182;
      this.cbTCP.Text = "TCP";
      this.cbTCP.UseVisualStyleBackColor = true;
      // 
      // TTtcpUdp
      // 
      this.TTtcpUdp.Image = ((System.Drawing.Image)(resources.GetObject("TTtcpUdp.Image")));
      this.TTtcpUdp.Location = new System.Drawing.Point(471, 213);
      this.TTtcpUdp.Name = "TTtcpUdp";
      this.TTtcpUdp.Size = new System.Drawing.Size(16, 16);
      this.TTtcpUdp.TabIndex = 187;
      this.TTtcpUdp.TabStop = false;
      // 
      // lbFwPort
      // 
      this.lbFwPort.AutoSize = true;
      this.lbFwPort.Enabled = false;
      this.lbFwPort.Location = new System.Drawing.Point(293, 244);
      this.lbFwPort.Name = "lbFwPort";
      this.lbFwPort.Size = new System.Drawing.Size(64, 13);
      this.lbFwPort.TabIndex = 185;
      this.lbFwPort.Text = "Portnumber:";
      // 
      // lbFwName
      // 
      this.lbFwName.AutoSize = true;
      this.lbFwName.Enabled = false;
      this.lbFwName.Location = new System.Drawing.Point(295, 215);
      this.lbFwName.Name = "lbFwName";
      this.lbFwName.Size = new System.Drawing.Size(38, 13);
      this.lbFwName.TabIndex = 183;
      this.lbFwName.Text = "Name:";
      // 
      // tbFwPortnr
      // 
      this.tbFwPortnr.Enabled = false;
      this.tbFwPortnr.Location = new System.Drawing.Point(363, 239);
      this.tbFwPortnr.MaxLength = 5;
      this.tbFwPortnr.Name = "tbFwPortnr";
      this.tbFwPortnr.Size = new System.Drawing.Size(99, 20);
      this.tbFwPortnr.TabIndex = 181;
      // 
      // tbFwName
      // 
      this.tbFwName.Enabled = false;
      this.tbFwName.Location = new System.Drawing.Point(363, 212);
      this.tbFwName.Name = "tbFwName";
      this.tbFwName.Size = new System.Drawing.Size(99, 20);
      this.tbFwName.TabIndex = 180;
      // 
      // cbFwAddPort
      // 
      this.cbFwAddPort.AutoSize = true;
      this.cbFwAddPort.ForeColor = System.Drawing.Color.Black;
      this.cbFwAddPort.Location = new System.Drawing.Point(294, 191);
      this.cbFwAddPort.Name = "cbFwAddPort";
      this.cbFwAddPort.Size = new System.Drawing.Size(112, 17);
      this.cbFwAddPort.TabIndex = 179;
      this.cbFwAddPort.Text = "Add your own port";
      this.cbFwAddPort.UseVisualStyleBackColor = true;
      this.cbFwAddPort.CheckedChanged += new System.EventHandler(this.cbFwAddPort_CheckedChanged);
      // 
      // btFwAdd
      // 
      this.btFwAdd.Enabled = false;
      this.btFwAdd.Location = new System.Drawing.Point(549, 234);
      this.btFwAdd.Name = "btFwAdd";
      this.btFwAdd.Size = new System.Drawing.Size(47, 23);
      this.btFwAdd.TabIndex = 184;
      this.btFwAdd.Text = "Add";
      this.btFwAdd.UseVisualStyleBackColor = true;
      this.btFwAdd.Click += new System.EventHandler(this.btFwAdd_Click);
      // 
      // label35
      // 
      this.label35.AutoSize = true;
      this.label35.Location = new System.Drawing.Point(291, 16);
      this.label35.Name = "label35";
      this.label35.Size = new System.Drawing.Size(99, 13);
      this.label35.TabIndex = 170;
      this.label35.Text = "Allow exception for:";
      // 
      // cbFwWebServerHTTPs
      // 
      this.cbFwWebServerHTTPs.AutoSize = true;
      this.cbFwWebServerHTTPs.Location = new System.Drawing.Point(294, 140);
      this.cbFwWebServerHTTPs.Name = "cbFwWebServerHTTPs";
      this.cbFwWebServerHTTPs.Size = new System.Drawing.Size(83, 17);
      this.cbFwWebServerHTTPs.TabIndex = 175;
      this.cbFwWebServerHTTPs.Text = "Web Server";
      this.cbFwWebServerHTTPs.UseVisualStyleBackColor = true;
      this.cbFwWebServerHTTPs.CheckedChanged += new System.EventHandler(this.cbFwWebServerHTTPs_CheckedChanged);
      // 
      // cbFwSqlServer
      // 
      this.cbFwSqlServer.AutoSize = true;
      this.cbFwSqlServer.Location = new System.Drawing.Point(294, 165);
      this.cbFwSqlServer.Name = "cbFwSqlServer";
      this.cbFwSqlServer.Size = new System.Drawing.Size(76, 17);
      this.cbFwSqlServer.TabIndex = 176;
      this.cbFwSqlServer.Text = "SQLserver";
      this.cbFwSqlServer.UseVisualStyleBackColor = true;
      this.cbFwSqlServer.CheckedChanged += new System.EventHandler(this.cbFwSqlServer_CheckedChanged);
      // 
      // cbFwWebServerHTTP
      // 
      this.cbFwWebServerHTTP.AutoSize = true;
      this.cbFwWebServerHTTP.Location = new System.Drawing.Point(294, 115);
      this.cbFwWebServerHTTP.Name = "cbFwWebServerHTTP";
      this.cbFwWebServerHTTP.Size = new System.Drawing.Size(83, 17);
      this.cbFwWebServerHTTP.TabIndex = 174;
      this.cbFwWebServerHTTP.Text = "Web Server";
      this.cbFwWebServerHTTP.UseVisualStyleBackColor = true;
      this.cbFwWebServerHTTP.CheckedChanged += new System.EventHandler(this.cbFwWebServerHTTP_CheckedChanged);
      // 
      // cbFwFtpServer
      // 
      this.cbFwFtpServer.AutoSize = true;
      this.cbFwFtpServer.Location = new System.Drawing.Point(294, 88);
      this.cbFwFtpServer.Name = "cbFwFtpServer";
      this.cbFwFtpServer.Size = new System.Drawing.Size(77, 17);
      this.cbFwFtpServer.TabIndex = 173;
      this.cbFwFtpServer.Text = "FTPServer";
      this.cbFwFtpServer.UseVisualStyleBackColor = true;
      this.cbFwFtpServer.CheckedChanged += new System.EventHandler(this.cbFwFtpServer_CheckedChanged);
      // 
      // cbFwRemoteDesktop
      // 
      this.cbFwRemoteDesktop.AutoSize = true;
      this.cbFwRemoteDesktop.Location = new System.Drawing.Point(294, 61);
      this.cbFwRemoteDesktop.Name = "cbFwRemoteDesktop";
      this.cbFwRemoteDesktop.Size = new System.Drawing.Size(106, 17);
      this.cbFwRemoteDesktop.TabIndex = 172;
      this.cbFwRemoteDesktop.Text = "Remote Desktop";
      this.cbFwRemoteDesktop.UseVisualStyleBackColor = true;
      this.cbFwRemoteDesktop.CheckedChanged += new System.EventHandler(this.cbFwRemoteDesktop_CheckedChanged);
      // 
      // cbFwPcAnywhere
      // 
      this.cbFwPcAnywhere.AutoSize = true;
      this.cbFwPcAnywhere.Location = new System.Drawing.Point(294, 37);
      this.cbFwPcAnywhere.Name = "cbFwPcAnywhere";
      this.cbFwPcAnywhere.Size = new System.Drawing.Size(86, 17);
      this.cbFwPcAnywhere.TabIndex = 171;
      this.cbFwPcAnywhere.Text = "PcAnywhere";
      this.cbFwPcAnywhere.UseVisualStyleBackColor = true;
      this.cbFwPcAnywhere.CheckedChanged += new System.EventHandler(this.cbFwPcAnywhere_CheckedChanged);
      // 
      // lbfwSelectedItem
      // 
      this.lbfwSelectedItem.AutoSize = true;
      this.lbfwSelectedItem.ForeColor = System.Drawing.Color.Red;
      this.lbfwSelectedItem.Location = new System.Drawing.Point(157, 16);
      this.lbfwSelectedItem.Name = "lbfwSelectedItem";
      this.lbfwSelectedItem.Size = new System.Drawing.Size(0, 13);
      this.lbfwSelectedItem.TabIndex = 169;
      // 
      // tbFirewallNotDefault
      // 
      this.tbFirewallNotDefault.Location = new System.Drawing.Point(200, 253);
      this.tbFirewallNotDefault.Name = "tbFirewallNotDefault";
      this.tbFirewallNotDefault.Size = new System.Drawing.Size(92, 20);
      this.tbFirewallNotDefault.TabIndex = 188;
      this.tbFirewallNotDefault.Visible = false;
      // 
      // lbFirewallNotDefault
      // 
      this.lbFirewallNotDefault.AutoSize = true;
      this.lbFirewallNotDefault.Location = new System.Drawing.Point(151, 258);
      this.lbFirewallNotDefault.Name = "lbFirewallNotDefault";
      this.lbFirewallNotDefault.Size = new System.Drawing.Size(47, 13);
      this.lbFirewallNotDefault.TabIndex = 167;
      this.lbFirewallNotDefault.Text = "Reason:";
      this.lbFirewallNotDefault.Visible = false;
      // 
      // btFwDelete
      // 
      this.btFwDelete.Location = new System.Drawing.Point(10, 253);
      this.btFwDelete.Name = "btFwDelete";
      this.btFwDelete.Size = new System.Drawing.Size(56, 23);
      this.btFwDelete.TabIndex = 165;
      this.btFwDelete.TabStop = false;
      this.btFwDelete.Text = "Delete";
      this.btFwDelete.UseVisualStyleBackColor = true;
      this.btFwDelete.Click += new System.EventHandler(this.btFwDelete_Click);
      // 
      // label36
      // 
      this.label36.AutoSize = true;
      this.label36.Location = new System.Drawing.Point(7, 18);
      this.label36.Name = "label36";
      this.label36.Size = new System.Drawing.Size(80, 13);
      this.label36.TabIndex = 163;
      this.label36.Text = "List exceptions:";
      // 
      // libFireWallExceptions
      // 
      this.libFireWallExceptions.FormattingEnabled = true;
      this.libFireWallExceptions.HorizontalScrollbar = true;
      this.libFireWallExceptions.Location = new System.Drawing.Point(10, 34);
      this.libFireWallExceptions.Name = "libFireWallExceptions";
      this.libFireWallExceptions.Size = new System.Drawing.Size(279, 212);
      this.libFireWallExceptions.TabIndex = 164;
      // 
      // ttFireWall
      // 
      this.ttFireWall.Image = ((System.Drawing.Image)(resources.GetObject("ttFireWall.Image")));
      this.ttFireWall.Location = new System.Drawing.Point(115, 0);
      this.ttFireWall.Name = "ttFireWall";
      this.ttFireWall.Size = new System.Drawing.Size(16, 16);
      this.ttFireWall.TabIndex = 40;
      this.ttFireWall.TabStop = false;
      this.ttFireWall.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // wpBlockKey
      // 
      this.wpBlockKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpBlockKey.AntiAlias = false;
      this.wpBlockKey.BackColor = System.Drawing.Color.LightGray;
      this.wpBlockKey.Controls.Add(this.groupBox5);
      this.wpBlockKey.Location = new System.Drawing.Point(7, 72);
      this.wpBlockKey.Name = "wpBlockKey";
      this.wpBlockKey.PageDescription = "This page allow you to configure BlockKeys";
      this.wpBlockKey.PageTitle = "BlockKeys Settings";
      this.wpBlockKey.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.Lockdown;
      this.wpBlockKey.Size = new System.Drawing.Size(608, 283);
      this.wpBlockKey.TabIndex = 36;
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.checkBox38);
      this.groupBox5.Controls.Add(this.checkBox2);
      this.groupBox5.Controls.Add(this.checkBox20);
      this.groupBox5.Controls.Add(this.checkBox19);
      this.groupBox5.Controls.Add(this.checkBox18);
      this.groupBox5.Controls.Add(this.checkBox17);
      this.groupBox5.Controls.Add(this.textBox9);
      this.groupBox5.Controls.Add(this.label84);
      this.groupBox5.Controls.Add(this.checkBox16);
      this.groupBox5.Controls.Add(this.checkBox15);
      this.groupBox5.Controls.Add(this.textBox8);
      this.groupBox5.Controls.Add(this.label83);
      this.groupBox5.Controls.Add(this.checkBox14);
      this.groupBox5.Controls.Add(this.checkBox13);
      this.groupBox5.Controls.Add(this.checkBox12);
      this.groupBox5.Controls.Add(this.checkBox11);
      this.groupBox5.Controls.Add(this.checkBox10);
      this.groupBox5.Controls.Add(this.checkBox9);
      this.groupBox5.Controls.Add(this.checkBox8);
      this.groupBox5.Controls.Add(this.checkBox7);
      this.groupBox5.Controls.Add(this.checkBox6);
      this.groupBox5.Controls.Add(this.checkBox5);
      this.groupBox5.Controls.Add(this.checkBox4);
      this.groupBox5.Controls.Add(this.checkBox3);
      this.groupBox5.Location = new System.Drawing.Point(5, 11);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(598, 260);
      this.groupBox5.TabIndex = 1;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "      Keys:";
      // 
      // checkBox38
      // 
      this.checkBox38.AutoSize = true;
      this.checkBox38.Location = new System.Drawing.Point(418, 136);
      this.checkBox38.Name = "checkBox38";
      this.checkBox38.Size = new System.Drawing.Size(148, 17);
      this.checkBox38.TabIndex = 23;
      this.checkBox38.Text = "Choose random password";
      this.checkBox38.UseVisualStyleBackColor = true;
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Checked = true;
      this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox2.Location = new System.Drawing.Point(418, 159);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(174, 17);
      this.checkBox2.TabIndex = 22;
      this.checkBox2.Text = "Autorun BlockKeys when logon";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // checkBox20
      // 
      this.checkBox20.AutoSize = true;
      this.checkBox20.Checked = true;
      this.checkBox20.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox20.Location = new System.Drawing.Point(192, 205);
      this.checkBox20.Name = "checkBox20";
      this.checkBox20.Size = new System.Drawing.Size(103, 17);
      this.checkBox20.TabIndex = 21;
      this.checkBox20.Text = "Disable Taskbar";
      this.checkBox20.UseVisualStyleBackColor = true;
      // 
      // checkBox19
      // 
      this.checkBox19.AutoSize = true;
      this.checkBox19.Checked = true;
      this.checkBox19.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox19.Location = new System.Drawing.Point(192, 182);
      this.checkBox19.Name = "checkBox19";
      this.checkBox19.Size = new System.Drawing.Size(132, 17);
      this.checkBox19.TabIndex = 20;
      this.checkBox19.Text = "Disable Registry Editor";
      this.checkBox19.UseVisualStyleBackColor = true;
      // 
      // checkBox18
      // 
      this.checkBox18.AutoSize = true;
      this.checkBox18.Checked = true;
      this.checkBox18.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox18.Location = new System.Drawing.Point(192, 159);
      this.checkBox18.Name = "checkBox18";
      this.checkBox18.Size = new System.Drawing.Size(113, 17);
      this.checkBox18.TabIndex = 19;
      this.checkBox18.Text = "Disable Ctrl-Alt-Del";
      this.checkBox18.UseVisualStyleBackColor = true;
      // 
      // checkBox17
      // 
      this.checkBox17.AutoSize = true;
      this.checkBox17.Checked = true;
      this.checkBox17.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox17.Location = new System.Drawing.Point(192, 136);
      this.checkBox17.Name = "checkBox17";
      this.checkBox17.Size = new System.Drawing.Size(84, 17);
      this.checkBox17.TabIndex = 18;
      this.checkBox17.Text = "Disable Run";
      this.checkBox17.UseVisualStyleBackColor = true;
      // 
      // textBox9
      // 
      this.textBox9.Location = new System.Drawing.Point(396, 67);
      this.textBox9.Name = "textBox9";
      this.textBox9.Size = new System.Drawing.Size(161, 20);
      this.textBox9.TabIndex = 17;
      this.textBox9.Visible = false;
      // 
      // label84
      // 
      this.label84.AutoSize = true;
      this.label84.Location = new System.Drawing.Point(393, 44);
      this.label84.Name = "label84";
      this.label84.Size = new System.Drawing.Size(150, 13);
      this.label84.TabIndex = 16;
      this.label84.Text = "If not default, give a comment:";
      this.label84.Visible = false;
      // 
      // checkBox16
      // 
      this.checkBox16.AutoSize = true;
      this.checkBox16.Checked = true;
      this.checkBox16.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox16.Location = new System.Drawing.Point(418, 182);
      this.checkBox16.Name = "checkBox16";
      this.checkBox16.Size = new System.Drawing.Size(80, 17);
      this.checkBox16.TabIndex = 15;
      this.checkBox16.Text = "Save to log";
      this.checkBox16.UseVisualStyleBackColor = true;
      // 
      // checkBox15
      // 
      this.checkBox15.AutoSize = true;
      this.checkBox15.Checked = true;
      this.checkBox15.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox15.Location = new System.Drawing.Point(11, 0);
      this.checkBox15.Name = "checkBox15";
      this.checkBox15.Size = new System.Drawing.Size(15, 14);
      this.checkBox15.TabIndex = 14;
      this.checkBox15.UseVisualStyleBackColor = true;
      // 
      // textBox8
      // 
      this.textBox8.Location = new System.Drawing.Point(480, 100);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new System.Drawing.Size(100, 20);
      this.textBox8.TabIndex = 13;
      // 
      // label83
      // 
      this.label83.AutoSize = true;
      this.label83.Location = new System.Drawing.Point(393, 103);
      this.label83.Name = "label83";
      this.label83.Size = new System.Drawing.Size(78, 13);
      this.label83.TabIndex = 12;
      this.label83.Text = "Set Password: ";
      // 
      // checkBox14
      // 
      this.checkBox14.AutoSize = true;
      this.checkBox14.Checked = true;
      this.checkBox14.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox14.Location = new System.Drawing.Point(192, 113);
      this.checkBox14.Name = "checkBox14";
      this.checkBox14.Size = new System.Drawing.Size(86, 17);
      this.checkBox14.TabIndex = 11;
      this.checkBox14.Text = "Disable USB";
      this.checkBox14.UseVisualStyleBackColor = true;
      // 
      // checkBox13
      // 
      this.checkBox13.AutoSize = true;
      this.checkBox13.Checked = true;
      this.checkBox13.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox13.Location = new System.Drawing.Point(192, 90);
      this.checkBox13.Name = "checkBox13";
      this.checkBox13.Size = new System.Drawing.Size(130, 17);
      this.checkBox13.TabIndex = 10;
      this.checkBox13.Text = "Disable TaskManager";
      this.checkBox13.UseVisualStyleBackColor = true;
      // 
      // checkBox12
      // 
      this.checkBox12.AutoSize = true;
      this.checkBox12.Location = new System.Drawing.Point(19, 205);
      this.checkBox12.Name = "checkBox12";
      this.checkBox12.Size = new System.Drawing.Size(154, 17);
      this.checkBox12.TabIndex = 9;
      this.checkBox12.Text = "Hide Taskbar and Desktop";
      this.checkBox12.UseVisualStyleBackColor = true;
      // 
      // checkBox11
      // 
      this.checkBox11.AutoSize = true;
      this.checkBox11.Location = new System.Drawing.Point(192, 67);
      this.checkBox11.Name = "checkBox11";
      this.checkBox11.Size = new System.Drawing.Size(146, 17);
      this.checkBox11.TabIndex = 8;
      this.checkBox11.Text = "Disable windows app key";
      this.checkBox11.UseVisualStyleBackColor = true;
      // 
      // checkBox10
      // 
      this.checkBox10.AutoSize = true;
      this.checkBox10.Location = new System.Drawing.Point(192, 44);
      this.checkBox10.Name = "checkBox10";
      this.checkBox10.Size = new System.Drawing.Size(125, 17);
      this.checkBox10.TabIndex = 7;
      this.checkBox10.Text = "Disable windows key";
      this.checkBox10.UseVisualStyleBackColor = true;
      // 
      // checkBox9
      // 
      this.checkBox9.AutoSize = true;
      this.checkBox9.Location = new System.Drawing.Point(19, 182);
      this.checkBox9.Name = "checkBox9";
      this.checkBox9.Size = new System.Drawing.Size(117, 17);
      this.checkBox9.TabIndex = 6;
      this.checkBox9.Text = "Disable Scroll Lock";
      this.checkBox9.UseVisualStyleBackColor = true;
      // 
      // checkBox8
      // 
      this.checkBox8.AutoSize = true;
      this.checkBox8.Location = new System.Drawing.Point(19, 159);
      this.checkBox8.Name = "checkBox8";
      this.checkBox8.Size = new System.Drawing.Size(99, 17);
      this.checkBox8.TabIndex = 5;
      this.checkBox8.Text = "Disable ALT-F4";
      this.checkBox8.UseVisualStyleBackColor = true;
      // 
      // checkBox7
      // 
      this.checkBox7.AutoSize = true;
      this.checkBox7.Location = new System.Drawing.Point(19, 136);
      this.checkBox7.Name = "checkBox7";
      this.checkBox7.Size = new System.Drawing.Size(114, 17);
      this.checkBox7.TabIndex = 4;
      this.checkBox7.Text = "Disable search(F3)";
      this.checkBox7.UseVisualStyleBackColor = true;
      // 
      // checkBox6
      // 
      this.checkBox6.AutoSize = true;
      this.checkBox6.Location = new System.Drawing.Point(19, 113);
      this.checkBox6.Name = "checkBox6";
      this.checkBox6.Size = new System.Drawing.Size(104, 17);
      this.checkBox6.TabIndex = 3;
      this.checkBox6.Text = "Disable Help(F1)";
      this.checkBox6.UseVisualStyleBackColor = true;
      // 
      // checkBox5
      // 
      this.checkBox5.AutoSize = true;
      this.checkBox5.Location = new System.Drawing.Point(19, 90);
      this.checkBox5.Name = "checkBox5";
      this.checkBox5.Size = new System.Drawing.Size(108, 17);
      this.checkBox5.TabIndex = 2;
      this.checkBox5.Text = "Disable ALT-ESC";
      this.checkBox5.UseVisualStyleBackColor = true;
      // 
      // checkBox4
      // 
      this.checkBox4.AutoSize = true;
      this.checkBox4.Location = new System.Drawing.Point(19, 67);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new System.Drawing.Size(108, 17);
      this.checkBox4.TabIndex = 1;
      this.checkBox4.Text = "Disable ALT-TAB";
      this.checkBox4.UseVisualStyleBackColor = true;
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Checked = true;
      this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox3.Location = new System.Drawing.Point(19, 44);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(110, 17);
      this.checkBox3.TabIndex = 0;
      this.checkBox3.Text = "Disable CTR-ESC";
      this.checkBox3.UseVisualStyleBackColor = true;
      // 
      // wpSharedFolderConfig
      // 
      this.wpSharedFolderConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpSharedFolderConfig.AntiAlias = false;
      this.wpSharedFolderConfig.BackColor = System.Drawing.Color.LightGray;
      this.wpSharedFolderConfig.Controls.Add(this.groupBox30);
      this.wpSharedFolderConfig.Location = new System.Drawing.Point(7, 72);
      this.wpSharedFolderConfig.Name = "wpSharedFolderConfig";
      this.wpSharedFolderConfig.PageDescription = "This page allow user to secure file sharing";
      this.wpSharedFolderConfig.PageTitle = "File sharing ";
      this.wpSharedFolderConfig.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.Lockdown;
      this.wpSharedFolderConfig.Size = new System.Drawing.Size(608, 283);
      this.wpSharedFolderConfig.TabIndex = 38;
      // 
      // groupBox30
      // 
      this.groupBox30.Controls.Add(this.listVSharedFolders);
      this.groupBox30.Controls.Add(this.btStopShare);
      this.groupBox30.Controls.Add(this.btAddShare);
      this.groupBox30.Location = new System.Drawing.Point(17, 3);
      this.groupBox30.Name = "groupBox30";
      this.groupBox30.Size = new System.Drawing.Size(560, 277);
      this.groupBox30.TabIndex = 1;
      this.groupBox30.TabStop = false;
      this.groupBox30.Text = "Shared Folders :";
      // 
      // listVSharedFolders
      // 
      this.listVSharedFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
      this.listVSharedFolders.FullRowSelect = true;
      this.listVSharedFolders.GridLines = true;
      this.listVSharedFolders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.listVSharedFolders.Location = new System.Drawing.Point(6, 19);
      this.listVSharedFolders.Name = "listVSharedFolders";
      this.listVSharedFolders.Size = new System.Drawing.Size(548, 223);
      this.listVSharedFolders.TabIndex = 29;
      this.listVSharedFolders.UseCompatibleStateImageBehavior = false;
      this.listVSharedFolders.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader5
      // 
      this.columnHeader5.Text = "Shared Folder";
      this.columnHeader5.Width = 98;
      // 
      // columnHeader6
      // 
      this.columnHeader6.Text = "Shared Path";
      this.columnHeader6.Width = 226;
      // 
      // columnHeader8
      // 
      this.columnHeader8.Text = "Description";
      this.columnHeader8.Width = 168;
      // 
      // btStopShare
      // 
      this.btStopShare.Location = new System.Drawing.Point(373, 248);
      this.btStopShare.Name = "btStopShare";
      this.btStopShare.Size = new System.Drawing.Size(75, 23);
      this.btStopShare.TabIndex = 2;
      this.btStopShare.Text = "Stop Share";
      this.btStopShare.UseVisualStyleBackColor = true;
      // 
      // btAddShare
      // 
      this.btAddShare.Location = new System.Drawing.Point(454, 248);
      this.btAddShare.Name = "btAddShare";
      this.btAddShare.Size = new System.Drawing.Size(75, 23);
      this.btAddShare.TabIndex = 0;
      this.btAddShare.Text = "Add Share...";
      this.btAddShare.UseVisualStyleBackColor = true;
      this.btAddShare.Click += new System.EventHandler(this.btAddShare_Click);
      // 
      // wpNetworkConfigure
      // 
      this.wpNetworkConfigure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpNetworkConfigure.AntiAlias = false;
      this.wpNetworkConfigure.BackColor = System.Drawing.Color.LightGray;
      this.wpNetworkConfigure.Controls.Add(this.tabControl3);
      this.wpNetworkConfigure.Location = new System.Drawing.Point(7, 72);
      this.wpNetworkConfigure.Name = "wpNetworkConfigure";
      this.wpNetworkConfigure.PageDescription = "this page allows user to change the IP address, Default gateway, DNS Server";
      this.wpNetworkConfigure.PageTitle = "Configure Network Adapter";
      this.wpNetworkConfigure.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.Security;
      this.wpNetworkConfigure.Size = new System.Drawing.Size(608, 283);
      this.wpNetworkConfigure.TabIndex = 39;
      // 
      // tabControl3
      // 
      this.tabControl3.Controls.Add(this.tpIpConfig);
      this.tabControl3.Controls.Add(this.tabPage7);
      this.tabControl3.Location = new System.Drawing.Point(0, -4);
      this.tabControl3.Name = "tabControl3";
      this.tabControl3.SelectedIndex = 0;
      this.tabControl3.Size = new System.Drawing.Size(603, 293);
      this.tabControl3.TabIndex = 0;
      // 
      // tpIpConfig
      // 
      this.tpIpConfig.BackColor = System.Drawing.Color.LightGray;
      this.tpIpConfig.Controls.Add(this.btSetIp);
      this.tpIpConfig.Controls.Add(this.listBCurrentIPSettings);
      this.tpIpConfig.Controls.Add(this.gbUseStaticIPAddress);
      this.tpIpConfig.Controls.Add(this.gbDNSServers);
      this.tpIpConfig.Location = new System.Drawing.Point(4, 22);
      this.tpIpConfig.Name = "tpIpConfig";
      this.tpIpConfig.Padding = new System.Windows.Forms.Padding(3);
      this.tpIpConfig.Size = new System.Drawing.Size(595, 267);
      this.tpIpConfig.TabIndex = 0;
      this.tpIpConfig.Text = "IpConfig";
      // 
      // btSetIp
      // 
      this.btSetIp.Location = new System.Drawing.Point(300, 240);
      this.btSetIp.Name = "btSetIp";
      this.btSetIp.Size = new System.Drawing.Size(64, 23);
      this.btSetIp.TabIndex = 14;
      this.btSetIp.Text = "Set";
      this.btSetIp.UseVisualStyleBackColor = true;
      this.btSetIp.Click += new System.EventHandler(this.btSetIp_Click);
      // 
      // listBCurrentIPSettings
      // 
      this.listBCurrentIPSettings.FormattingEnabled = true;
      this.listBCurrentIPSettings.Location = new System.Drawing.Point(299, 10);
      this.listBCurrentIPSettings.Name = "listBCurrentIPSettings";
      this.listBCurrentIPSettings.Size = new System.Drawing.Size(290, 225);
      this.listBCurrentIPSettings.TabIndex = 13;
      // 
      // gbUseStaticIPAddress
      // 
      this.gbUseStaticIPAddress.Controls.Add(this.label130);
      this.gbUseStaticIPAddress.Controls.Add(this.cbNicAdapter);
      this.gbUseStaticIPAddress.Controls.Add(this.rbIPManual);
      this.gbUseStaticIPAddress.Controls.Add(this.rbIPAutoObtain);
      this.gbUseStaticIPAddress.Controls.Add(this.tbDefaultGateway);
      this.gbUseStaticIPAddress.Controls.Add(this.tbSubnetMask);
      this.gbUseStaticIPAddress.Controls.Add(this.tbIPaddress);
      this.gbUseStaticIPAddress.Controls.Add(this.lbDefaultGateway);
      this.gbUseStaticIPAddress.Controls.Add(this.lbSubnetMask);
      this.gbUseStaticIPAddress.Controls.Add(this.lbIPaddress);
      this.gbUseStaticIPAddress.Location = new System.Drawing.Point(4, 6);
      this.gbUseStaticIPAddress.Name = "gbUseStaticIPAddress";
      this.gbUseStaticIPAddress.Size = new System.Drawing.Size(289, 146);
      this.gbUseStaticIPAddress.TabIndex = 12;
      this.gbUseStaticIPAddress.TabStop = false;
      this.gbUseStaticIPAddress.Text = "Configure IP Address";
      // 
      // label130
      // 
      this.label130.AutoSize = true;
      this.label130.Location = new System.Drawing.Point(3, 20);
      this.label130.Name = "label130";
      this.label130.Size = new System.Drawing.Size(116, 13);
      this.label130.TabIndex = 8;
      this.label130.Text = "Choose a NIC Adapter:";
      // 
      // cbNicAdapter
      // 
      this.cbNicAdapter.FormattingEnabled = true;
      this.cbNicAdapter.Location = new System.Drawing.Point(125, 15);
      this.cbNicAdapter.Name = "cbNicAdapter";
      this.cbNicAdapter.Size = new System.Drawing.Size(150, 21);
      this.cbNicAdapter.TabIndex = 7;
      this.cbNicAdapter.SelectedIndexChanged += new System.EventHandler(this.cbNicAdapter_SelectedIndexChanged);
      // 
      // rbIPManual
      // 
      this.rbIPManual.AutoSize = true;
      this.rbIPManual.Location = new System.Drawing.Point(6, 57);
      this.rbIPManual.Name = "rbIPManual";
      this.rbIPManual.Size = new System.Drawing.Size(162, 17);
      this.rbIPManual.TabIndex = 2;
      this.rbIPManual.Text = "Use the following IP address:";
      this.rbIPManual.UseVisualStyleBackColor = true;
      // 
      // rbIPAutoObtain
      // 
      this.rbIPAutoObtain.AutoSize = true;
      this.rbIPAutoObtain.Checked = true;
      this.rbIPAutoObtain.Location = new System.Drawing.Point(6, 37);
      this.rbIPAutoObtain.Name = "rbIPAutoObtain";
      this.rbIPAutoObtain.Size = new System.Drawing.Size(188, 17);
      this.rbIPAutoObtain.TabIndex = 1;
      this.rbIPAutoObtain.TabStop = true;
      this.rbIPAutoObtain.Text = "Obtain an IP address automatically";
      this.rbIPAutoObtain.UseVisualStyleBackColor = true;
      this.rbIPAutoObtain.CheckedChanged += new System.EventHandler(this.rbIPAutoObtain_CheckedChanged);
      // 
      // tbDefaultGateway
      // 
      this.tbDefaultGateway.Enabled = false;
      this.tbDefaultGateway.Location = new System.Drawing.Point(125, 118);
      this.tbDefaultGateway.Name = "tbDefaultGateway";
      this.tbDefaultGateway.Size = new System.Drawing.Size(150, 20);
      this.tbDefaultGateway.TabIndex = 6;
      // 
      // tbSubnetMask
      // 
      this.tbSubnetMask.Enabled = false;
      this.tbSubnetMask.Location = new System.Drawing.Point(125, 96);
      this.tbSubnetMask.Name = "tbSubnetMask";
      this.tbSubnetMask.Size = new System.Drawing.Size(149, 20);
      this.tbSubnetMask.TabIndex = 5;
      // 
      // tbIPaddress
      // 
      this.tbIPaddress.Enabled = false;
      this.tbIPaddress.Location = new System.Drawing.Point(125, 74);
      this.tbIPaddress.Name = "tbIPaddress";
      this.tbIPaddress.Size = new System.Drawing.Size(149, 20);
      this.tbIPaddress.TabIndex = 4;
      // 
      // lbDefaultGateway
      // 
      this.lbDefaultGateway.AutoSize = true;
      this.lbDefaultGateway.Location = new System.Drawing.Point(6, 123);
      this.lbDefaultGateway.Name = "lbDefaultGateway";
      this.lbDefaultGateway.Size = new System.Drawing.Size(87, 13);
      this.lbDefaultGateway.TabIndex = 3;
      this.lbDefaultGateway.Text = "Default gateway:";
      // 
      // lbSubnetMask
      // 
      this.lbSubnetMask.AutoSize = true;
      this.lbSubnetMask.Location = new System.Drawing.Point(6, 102);
      this.lbSubnetMask.Name = "lbSubnetMask";
      this.lbSubnetMask.Size = new System.Drawing.Size(72, 13);
      this.lbSubnetMask.TabIndex = 2;
      this.lbSubnetMask.Text = "Subnet mask:";
      // 
      // lbIPaddress
      // 
      this.lbIPaddress.AutoSize = true;
      this.lbIPaddress.Location = new System.Drawing.Point(6, 81);
      this.lbIPaddress.Name = "lbIPaddress";
      this.lbIPaddress.Size = new System.Drawing.Size(60, 13);
      this.lbIPaddress.TabIndex = 1;
      this.lbIPaddress.Text = "IP address:";
      // 
      // gbDNSServers
      // 
      this.gbDNSServers.Controls.Add(this.tbDNSAlt);
      this.gbDNSServers.Controls.Add(this.tbDNSPre);
      this.gbDNSServers.Controls.Add(this.lbDNSAlt);
      this.gbDNSServers.Controls.Add(this.lbDNSPre);
      this.gbDNSServers.Controls.Add(this.rbDNSManual);
      this.gbDNSServers.Controls.Add(this.rbDNSAuto);
      this.gbDNSServers.Location = new System.Drawing.Point(4, 151);
      this.gbDNSServers.Name = "gbDNSServers";
      this.gbDNSServers.Size = new System.Drawing.Size(290, 111);
      this.gbDNSServers.TabIndex = 10;
      this.gbDNSServers.TabStop = false;
      this.gbDNSServers.Text = "DNS Servers";
      // 
      // tbDNSAlt
      // 
      this.tbDNSAlt.Enabled = false;
      this.tbDNSAlt.Location = new System.Drawing.Point(133, 84);
      this.tbDNSAlt.Name = "tbDNSAlt";
      this.tbDNSAlt.Size = new System.Drawing.Size(141, 20);
      this.tbDNSAlt.TabIndex = 13;
      // 
      // tbDNSPre
      // 
      this.tbDNSPre.Enabled = false;
      this.tbDNSPre.Location = new System.Drawing.Point(133, 61);
      this.tbDNSPre.Name = "tbDNSPre";
      this.tbDNSPre.Size = new System.Drawing.Size(141, 20);
      this.tbDNSPre.TabIndex = 12;
      // 
      // lbDNSAlt
      // 
      this.lbDNSAlt.AutoSize = true;
      this.lbDNSAlt.Location = new System.Drawing.Point(7, 89);
      this.lbDNSAlt.Name = "lbDNSAlt";
      this.lbDNSAlt.Size = new System.Drawing.Size(112, 13);
      this.lbDNSAlt.TabIndex = 11;
      this.lbDNSAlt.Text = "Alternate DNS Server:";
      // 
      // lbDNSPre
      // 
      this.lbDNSPre.AutoSize = true;
      this.lbDNSPre.Location = new System.Drawing.Point(8, 66);
      this.lbDNSPre.Name = "lbDNSPre";
      this.lbDNSPre.Size = new System.Drawing.Size(113, 13);
      this.lbDNSPre.TabIndex = 9;
      this.lbDNSPre.Text = "Preferred DNS Server:";
      // 
      // rbDNSManual
      // 
      this.rbDNSManual.AutoSize = true;
      this.rbDNSManual.Location = new System.Drawing.Point(11, 40);
      this.rbDNSManual.Name = "rbDNSManual";
      this.rbDNSManual.Size = new System.Drawing.Size(217, 17);
      this.rbDNSManual.TabIndex = 4;
      this.rbDNSManual.Text = "Use the following DNS Server addresses";
      this.rbDNSManual.UseVisualStyleBackColor = true;
      // 
      // rbDNSAuto
      // 
      this.rbDNSAuto.AutoSize = true;
      this.rbDNSAuto.Checked = true;
      this.rbDNSAuto.Location = new System.Drawing.Point(11, 18);
      this.rbDNSAuto.Name = "rbDNSAuto";
      this.rbDNSAuto.Size = new System.Drawing.Size(218, 17);
      this.rbDNSAuto.TabIndex = 3;
      this.rbDNSAuto.TabStop = true;
      this.rbDNSAuto.Text = "Obtain DNS server address automatically";
      this.rbDNSAuto.UseVisualStyleBackColor = true;
      this.rbDNSAuto.CheckedChanged += new System.EventHandler(this.rbDNSAuto_CheckedChanged);
      // 
      // tabPage7
      // 
      this.tabPage7.BackColor = System.Drawing.Color.LightGray;
      this.tabPage7.Controls.Add(this.btRemoveWirelessNet);
      this.tabPage7.Controls.Add(this.btAddWirelessNet);
      this.tabPage7.Controls.Add(this.btWirelessConnect);
      this.tabPage7.Controls.Add(this.lvWirelessNetworkAvailable);
      this.tabPage7.Location = new System.Drawing.Point(4, 22);
      this.tabPage7.Name = "tabPage7";
      this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage7.Size = new System.Drawing.Size(595, 267);
      this.tabPage7.TabIndex = 1;
      this.tabPage7.Text = "Wireless";
      // 
      // btRemoveWirelessNet
      // 
      this.btRemoveWirelessNet.Location = new System.Drawing.Point(177, 228);
      this.btRemoveWirelessNet.Name = "btRemoveWirelessNet";
      this.btRemoveWirelessNet.Size = new System.Drawing.Size(75, 23);
      this.btRemoveWirelessNet.TabIndex = 3;
      this.btRemoveWirelessNet.Text = "Remove";
      this.btRemoveWirelessNet.UseVisualStyleBackColor = true;
      // 
      // btAddWirelessNet
      // 
      this.btAddWirelessNet.Location = new System.Drawing.Point(96, 228);
      this.btAddWirelessNet.Name = "btAddWirelessNet";
      this.btAddWirelessNet.Size = new System.Drawing.Size(75, 23);
      this.btAddWirelessNet.TabIndex = 2;
      this.btAddWirelessNet.Text = "Add ...";
      this.btAddWirelessNet.UseVisualStyleBackColor = true;
      this.btAddWirelessNet.Click += new System.EventHandler(this.btAddWirelessNet_Click);
      // 
      // btWirelessConnect
      // 
      this.btWirelessConnect.Location = new System.Drawing.Point(15, 228);
      this.btWirelessConnect.Name = "btWirelessConnect";
      this.btWirelessConnect.Size = new System.Drawing.Size(75, 23);
      this.btWirelessConnect.TabIndex = 1;
      this.btWirelessConnect.Text = "Connect";
      this.btWirelessConnect.UseVisualStyleBackColor = true;
      // 
      // lvWirelessNetworkAvailable
      // 
      this.lvWirelessNetworkAvailable.Location = new System.Drawing.Point(6, 6);
      this.lvWirelessNetworkAvailable.Name = "lvWirelessNetworkAvailable";
      this.lvWirelessNetworkAvailable.Size = new System.Drawing.Size(583, 216);
      this.lvWirelessNetworkAvailable.TabIndex = 0;
      this.lvWirelessNetworkAvailable.UseCompatibleStateImageBehavior = false;
      // 
      // wpMBSA
      // 
      this.wpMBSA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpMBSA.AntiAlias = false;
      this.wpMBSA.BackColor = System.Drawing.Color.Transparent;
      this.wpMBSA.Controls.Add(this.gbMBSA);
      this.wpMBSA.Location = new System.Drawing.Point(7, 72);
      this.wpMBSA.Name = "wpMBSA";
      this.wpMBSA.PageDescription = "Here\'s how the application uses MBSA";
      this.wpMBSA.PageTitle = "Microsoft Baseline Security Analyzer";
      this.wpMBSA.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.SecurityAndLockdown;
      this.wpMBSA.Size = new System.Drawing.Size(608, 283);
      this.wpMBSA.TabIndex = 25;
      this.wpMBSA.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpMBSA_NextButtonClick);
      // 
      // gbMBSA
      // 
      this.gbMBSA.Controls.Add(this.lbMBSAnotDefault);
      this.gbMBSA.Controls.Add(this.lbMBSAinstallationFolder);
      this.gbMBSA.Controls.Add(this.tbMBSAnotDefault);
      this.gbMBSA.Controls.Add(this.label123);
      this.gbMBSA.Controls.Add(this.ttMBSA);
      this.gbMBSA.Controls.Add(this.label91);
      this.gbMBSA.Controls.Add(this.pictureBox3);
      this.gbMBSA.Controls.Add(this.cbMBSA);
      this.gbMBSA.Controls.Add(this.pictureBox2);
      this.gbMBSA.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gbMBSA.Location = new System.Drawing.Point(0, 0);
      this.gbMBSA.Name = "gbMBSA";
      this.gbMBSA.Size = new System.Drawing.Size(608, 283);
      this.gbMBSA.TabIndex = 13;
      this.gbMBSA.TabStop = false;
      this.gbMBSA.Text = "MBSA";
      // 
      // lbMBSAnotDefault
      // 
      this.lbMBSAnotDefault.AutoSize = true;
      this.lbMBSAnotDefault.Location = new System.Drawing.Point(378, 30);
      this.lbMBSAnotDefault.Name = "lbMBSAnotDefault";
      this.lbMBSAnotDefault.Size = new System.Drawing.Size(186, 26);
      this.lbMBSAnotDefault.TabIndex = 121;
      this.lbMBSAnotDefault.Text = "MBSA has been turned off incorrectly \r\nReason:";
      this.lbMBSAnotDefault.Visible = false;
      // 
      // lbMBSAinstallationFolder
      // 
      this.lbMBSAinstallationFolder.AutoSize = true;
      this.lbMBSAinstallationFolder.Location = new System.Drawing.Point(87, 97);
      this.lbMBSAinstallationFolder.Name = "lbMBSAinstallationFolder";
      this.lbMBSAinstallationFolder.Size = new System.Drawing.Size(53, 13);
      this.lbMBSAinstallationFolder.TabIndex = 49;
      this.lbMBSAinstallationFolder.Text = "Unknown";
      // 
      // tbMBSAnotDefault
      // 
      this.tbMBSAnotDefault.Location = new System.Drawing.Point(381, 58);
      this.tbMBSAnotDefault.Name = "tbMBSAnotDefault";
      this.tbMBSAnotDefault.Size = new System.Drawing.Size(171, 20);
      this.tbMBSAnotDefault.TabIndex = 1;
      this.tbMBSAnotDefault.Visible = false;
      // 
      // label123
      // 
      this.label123.AutoSize = true;
      this.label123.Location = new System.Drawing.Point(78, 81);
      this.label123.Name = "label123";
      this.label123.Size = new System.Drawing.Size(165, 13);
      this.label123.TabIndex = 48;
      this.label123.Text = "The installation folder of MBSA is:";
      // 
      // ttMBSA
      // 
      this.ttMBSA.Image = ((System.Drawing.Image)(resources.GetObject("ttMBSA.Image")));
      this.ttMBSA.Location = new System.Drawing.Point(44, 0);
      this.ttMBSA.Name = "ttMBSA";
      this.ttMBSA.Size = new System.Drawing.Size(16, 16);
      this.ttMBSA.TabIndex = 47;
      this.ttMBSA.TabStop = false;
      this.ttMBSA.Click += new System.EventHandler(this.toolTip_Click);
      // 
      // label91
      // 
      this.label91.AutoSize = true;
      this.label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label91.Location = new System.Drawing.Point(148, 249);
      this.label91.Name = "label91";
      this.label91.Size = new System.Drawing.Size(298, 26);
      this.label91.TabIndex = 2;
      this.label91.Text = "Baseline Security Analyzer";
      // 
      // pictureBox3
      // 
      this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
      this.pictureBox3.Location = new System.Drawing.Point(153, 228);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(155, 27);
      this.pictureBox3.TabIndex = 3;
      this.pictureBox3.TabStop = false;
      // 
      // cbMBSA
      // 
      this.cbMBSA.Checked = true;
      this.cbMBSA.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbMBSA.Location = new System.Drawing.Point(18, 30);
      this.cbMBSA.Name = "cbMBSA";
      this.cbMBSA.Size = new System.Drawing.Size(261, 43);
      this.cbMBSA.TabIndex = 0;
      this.cbMBSA.Text = "Use Microsoft Baseline Security Analyzer after completing  this wizard to check t" +
    "he security.";
      this.cbMBSA.UseVisualStyleBackColor = true;
      this.cbMBSA.CheckedChanged += new System.EventHandler(this.cbMBSA_CheckedChanged);
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(3, 127);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(155, 154);
      this.pictureBox2.TabIndex = 1;
      this.pictureBox2.TabStop = false;
      // 
      // wpAcceptSettings
      // 
      this.wpAcceptSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpAcceptSettings.AntiAlias = false;
      this.wpAcceptSettings.BackColor = System.Drawing.Color.Transparent;
      this.wpAcceptSettings.Controls.Add(this.webBrowser1);
      this.wpAcceptSettings.Controls.Add(this.label93);
      this.wpAcceptSettings.Controls.Add(this.label37);
      this.wpAcceptSettings.Location = new System.Drawing.Point(7, 72);
      this.wpAcceptSettings.Name = "wpAcceptSettings";
      this.wpAcceptSettings.PageDescription = "Check before you continue with the chosen settings";
      this.wpAcceptSettings.PageTitle = "Confirm the settings";
      this.wpAcceptSettings.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.All;
      this.wpAcceptSettings.Size = new System.Drawing.Size(608, 283);
      this.wpAcceptSettings.TabIndex = 19;
      this.wpAcceptSettings.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpAcceptSettings_NextButtonClick);
      // 
      // webBrowser1
      // 
      this.webBrowser1.Location = new System.Drawing.Point(8, 14);
      this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.Size = new System.Drawing.Size(595, 250);
      this.webBrowser1.TabIndex = 4;
      // 
      // label93
      // 
      this.label93.AutoSize = true;
      this.label93.Location = new System.Drawing.Point(3, -2);
      this.label93.Name = "label93";
      this.label93.Size = new System.Drawing.Size(155, 13);
      this.label93.TabIndex = 3;
      this.label93.Text = "See below the chosen settings:";
      // 
      // label37
      // 
      this.label37.AutoSize = true;
      this.label37.Location = new System.Drawing.Point(5, 270);
      this.label37.Name = "label37";
      this.label37.Size = new System.Drawing.Size(292, 13);
      this.label37.TabIndex = 2;
      this.label37.Text = "Check the settings made, click Next to complete the settings";
      // 
      // wpConfigurationCheck
      // 
      this.wpConfigurationCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpConfigurationCheck.AntiAlias = false;
      this.wpConfigurationCheck.BackColor = System.Drawing.Color.Transparent;
      this.wpConfigurationCheck.Controls.Add(this.groupBox12);
      this.wpConfigurationCheck.Location = new System.Drawing.Point(7, 72);
      this.wpConfigurationCheck.Name = "wpConfigurationCheck";
      this.wpConfigurationCheck.PageDescription = "All selected settings are now configured";
      this.wpConfigurationCheck.PageTitle = "Configuring settings";
      this.wpConfigurationCheck.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.All;
      this.wpConfigurationCheck.Size = new System.Drawing.Size(608, 283);
      this.wpConfigurationCheck.TabIndex = 26;
      this.wpConfigurationCheck.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpConfigurationCheck_NextButtonClick);
      // 
      // groupBox12
      // 
      this.groupBox12.Controls.Add(this.label111);
      this.groupBox12.Controls.Add(this.label78);
      this.groupBox12.Controls.Add(this.pbConfigCheck18);
      this.groupBox12.Controls.Add(this.pbConfigCheck17);
      this.groupBox12.Controls.Add(this.label103);
      this.groupBox12.Controls.Add(this.label101);
      this.groupBox12.Controls.Add(this.label92);
      this.groupBox12.Controls.Add(this.label90);
      this.groupBox12.Controls.Add(this.label89);
      this.groupBox12.Controls.Add(this.label88);
      this.groupBox12.Controls.Add(this.pbConfigCheck16);
      this.groupBox12.Controls.Add(this.pbConfigCheck15);
      this.groupBox12.Controls.Add(this.pbConfigCheck14);
      this.groupBox12.Controls.Add(this.pbConfigCheck13);
      this.groupBox12.Controls.Add(this.pbConfigCheck12);
      this.groupBox12.Controls.Add(this.pbConfigCheck11);
      this.groupBox12.Controls.Add(this.btCancelMakeSettings);
      this.groupBox12.Controls.Add(this.label117);
      this.groupBox12.Controls.Add(this.pbConfigCheck20);
      this.groupBox12.Controls.Add(this.pbConfigCheck19);
      this.groupBox12.Controls.Add(this.label115);
      this.groupBox12.Controls.Add(this.label119);
      this.groupBox12.Controls.Add(this.lbConfigMBSA);
      this.groupBox12.Controls.Add(this.pbConfigCheck10);
      this.groupBox12.Controls.Add(this.label102);
      this.groupBox12.Controls.Add(this.label100);
      this.groupBox12.Controls.Add(this.label99);
      this.groupBox12.Controls.Add(this.label98);
      this.groupBox12.Controls.Add(this.label97);
      this.groupBox12.Controls.Add(this.label96);
      this.groupBox12.Controls.Add(this.label95);
      this.groupBox12.Controls.Add(this.label120);
      this.groupBox12.Controls.Add(this.label94);
      this.groupBox12.Controls.Add(this.pbConfigCheck9);
      this.groupBox12.Controls.Add(this.pbConfigCheck8);
      this.groupBox12.Controls.Add(this.pbConfigCheck7);
      this.groupBox12.Controls.Add(this.pbConfigCheck6);
      this.groupBox12.Controls.Add(this.pbConfigCheck5);
      this.groupBox12.Controls.Add(this.pbConfigCheck4);
      this.groupBox12.Controls.Add(this.pbConfigCheck3);
      this.groupBox12.Controls.Add(this.pbConfigCheck2);
      this.groupBox12.Controls.Add(this.pbConfigCheck0);
      this.groupBox12.Controls.Add(this.pbConfigCheck1);
      this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox12.Location = new System.Drawing.Point(0, 0);
      this.groupBox12.Name = "groupBox12";
      this.groupBox12.Size = new System.Drawing.Size(608, 283);
      this.groupBox12.TabIndex = 32;
      this.groupBox12.TabStop = false;
      this.groupBox12.Text = "Configuration overview";
      // 
      // label111
      // 
      this.label111.AutoSize = true;
      this.label111.Location = new System.Drawing.Point(321, 98);
      this.label111.Name = "label111";
      this.label111.Size = new System.Drawing.Size(125, 13);
      this.label111.TabIndex = 84;
      this.label111.Text = "Mail Server Configuration";
      // 
      // label78
      // 
      this.label78.AutoSize = true;
      this.label78.Location = new System.Drawing.Point(321, 188);
      this.label78.Name = "label78";
      this.label78.Size = new System.Drawing.Size(123, 13);
      this.label78.TabIndex = 83;
      this.label78.Text = "Ip Network configuration";
      // 
      // pbConfigCheck18
      // 
      this.pbConfigCheck18.Location = new System.Drawing.Point(297, 185);
      this.pbConfigCheck18.Name = "pbConfigCheck18";
      this.pbConfigCheck18.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck18.TabIndex = 82;
      this.pbConfigCheck18.TabStop = false;
      // 
      // pbConfigCheck17
      // 
      this.pbConfigCheck17.Location = new System.Drawing.Point(297, 163);
      this.pbConfigCheck17.Name = "pbConfigCheck17";
      this.pbConfigCheck17.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck17.TabIndex = 81;
      this.pbConfigCheck17.TabStop = false;
      // 
      // label103
      // 
      this.label103.AutoSize = true;
      this.label103.Location = new System.Drawing.Point(321, 166);
      this.label103.Name = "label103";
      this.label103.Size = new System.Drawing.Size(139, 13);
      this.label103.TabIndex = 80;
      this.label103.Text = "Shared folders configuration";
      // 
      // label101
      // 
      this.label101.AutoSize = true;
      this.label101.Location = new System.Drawing.Point(321, 54);
      this.label101.Name = "label101";
      this.label101.Size = new System.Drawing.Size(135, 13);
      this.label101.TabIndex = 79;
      this.label101.Text = "PC Anywhere configuration";
      // 
      // label92
      // 
      this.label92.AutoSize = true;
      this.label92.Location = new System.Drawing.Point(321, 30);
      this.label92.Name = "label92";
      this.label92.Size = new System.Drawing.Size(126, 13);
      this.label92.TabIndex = 78;
      this.label92.Text = "SQL Server configuration";
      // 
      // label90
      // 
      this.label90.AutoSize = true;
      this.label90.Location = new System.Drawing.Point(321, 142);
      this.label90.Name = "label90";
      this.label90.Size = new System.Drawing.Size(121, 13);
      this.label90.TabIndex = 77;
      this.label90.Text = "BlockKeys configuration";
      // 
      // label89
      // 
      this.label89.AutoSize = true;
      this.label89.Location = new System.Drawing.Point(321, 120);
      this.label89.Name = "label89";
      this.label89.Size = new System.Drawing.Size(125, 13);
      this.label89.TabIndex = 76;
      this.label89.Text = "FTP Server configuration";
      // 
      // label88
      // 
      this.label88.AutoSize = true;
      this.label88.Location = new System.Drawing.Point(321, 78);
      this.label88.Name = "label88";
      this.label88.Size = new System.Drawing.Size(128, 13);
      this.label88.TabIndex = 75;
      this.label88.Text = "Web Server configuration";
      // 
      // pbConfigCheck16
      // 
      this.pbConfigCheck16.Location = new System.Drawing.Point(297, 141);
      this.pbConfigCheck16.Name = "pbConfigCheck16";
      this.pbConfigCheck16.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck16.TabIndex = 74;
      this.pbConfigCheck16.TabStop = false;
      // 
      // pbConfigCheck15
      // 
      this.pbConfigCheck15.Location = new System.Drawing.Point(297, 117);
      this.pbConfigCheck15.Name = "pbConfigCheck15";
      this.pbConfigCheck15.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck15.TabIndex = 73;
      this.pbConfigCheck15.TabStop = false;
      // 
      // pbConfigCheck14
      // 
      this.pbConfigCheck14.Location = new System.Drawing.Point(297, 95);
      this.pbConfigCheck14.Name = "pbConfigCheck14";
      this.pbConfigCheck14.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck14.TabIndex = 72;
      this.pbConfigCheck14.TabStop = false;
      // 
      // pbConfigCheck13
      // 
      this.pbConfigCheck13.Location = new System.Drawing.Point(297, 73);
      this.pbConfigCheck13.Name = "pbConfigCheck13";
      this.pbConfigCheck13.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck13.TabIndex = 71;
      this.pbConfigCheck13.TabStop = false;
      // 
      // pbConfigCheck12
      // 
      this.pbConfigCheck12.Location = new System.Drawing.Point(297, 51);
      this.pbConfigCheck12.Name = "pbConfigCheck12";
      this.pbConfigCheck12.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck12.TabIndex = 70;
      this.pbConfigCheck12.TabStop = false;
      // 
      // pbConfigCheck11
      // 
      this.pbConfigCheck11.Location = new System.Drawing.Point(297, 28);
      this.pbConfigCheck11.Name = "pbConfigCheck11";
      this.pbConfigCheck11.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck11.TabIndex = 69;
      this.pbConfigCheck11.TabStop = false;
      // 
      // btCancelMakeSettings
      // 
      this.btCancelMakeSettings.Location = new System.Drawing.Point(527, 254);
      this.btCancelMakeSettings.Name = "btCancelMakeSettings";
      this.btCancelMakeSettings.Size = new System.Drawing.Size(75, 23);
      this.btCancelMakeSettings.TabIndex = 68;
      this.btCancelMakeSettings.Text = "Abort";
      this.btCancelMakeSettings.UseVisualStyleBackColor = true;
      this.btCancelMakeSettings.Click += new System.EventHandler(this.btCancelMakeSettings_Click);
      // 
      // label117
      // 
      this.label117.AutoSize = true;
      this.label117.Location = new System.Drawing.Point(38, 218);
      this.label117.Name = "label117";
      this.label117.Size = new System.Drawing.Size(160, 13);
      this.label117.TabIndex = 67;
      this.label117.Text = "Shutdown event tracker settings";
      // 
      // pbConfigCheck20
      // 
      this.pbConfigCheck20.Location = new System.Drawing.Point(297, 230);
      this.pbConfigCheck20.Name = "pbConfigCheck20";
      this.pbConfigCheck20.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck20.TabIndex = 66;
      this.pbConfigCheck20.TabStop = false;
      // 
      // pbConfigCheck19
      // 
      this.pbConfigCheck19.Location = new System.Drawing.Point(297, 207);
      this.pbConfigCheck19.Name = "pbConfigCheck19";
      this.pbConfigCheck19.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck19.TabIndex = 66;
      this.pbConfigCheck19.TabStop = false;
      // 
      // label115
      // 
      this.label115.AutoSize = true;
      this.label115.Location = new System.Drawing.Point(38, 125);
      this.label115.Name = "label115";
      this.label115.Size = new System.Drawing.Size(98, 13);
      this.label115.TabIndex = 65;
      this.label115.Text = "Users configuration";
      // 
      // label119
      // 
      this.label119.AutoSize = true;
      this.label119.Location = new System.Drawing.Point(319, 233);
      this.label119.Name = "label119";
      this.label119.Size = new System.Drawing.Size(188, 13);
      this.label119.TabIndex = 63;
      this.label119.Text = "Create configuration file for other users";
      // 
      // lbConfigMBSA
      // 
      this.lbConfigMBSA.AutoSize = true;
      this.lbConfigMBSA.Location = new System.Drawing.Point(319, 210);
      this.lbConfigMBSA.Name = "lbConfigMBSA";
      this.lbConfigMBSA.Size = new System.Drawing.Size(98, 13);
      this.lbConfigMBSA.TabIndex = 63;
      this.lbConfigMBSA.Text = "MBSA system scan";
      // 
      // pbConfigCheck10
      // 
      this.pbConfigCheck10.Location = new System.Drawing.Point(16, 264);
      this.pbConfigCheck10.Name = "pbConfigCheck10";
      this.pbConfigCheck10.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck10.TabIndex = 52;
      this.pbConfigCheck10.TabStop = false;
      // 
      // label102
      // 
      this.label102.AutoSize = true;
      this.label102.Location = new System.Drawing.Point(38, 267);
      this.label102.Name = "label102";
      this.label102.Size = new System.Drawing.Size(153, 13);
      this.label102.TabIndex = 49;
      this.label102.Text = "Windows Firewall configuration";
      // 
      // label100
      // 
      this.label100.AutoSize = true;
      this.label100.Location = new System.Drawing.Point(38, 243);
      this.label100.Name = "label100";
      this.label100.Size = new System.Drawing.Size(151, 13);
      this.label100.TabIndex = 47;
      this.label100.Text = "Remote Desktop configuration";
      // 
      // label99
      // 
      this.label99.AutoSize = true;
      this.label99.Location = new System.Drawing.Point(38, 194);
      this.label99.Name = "label99";
      this.label99.Size = new System.Drawing.Size(143, 13);
      this.label99.TabIndex = 46;
      this.label99.Text = "Automatic login configuration";
      // 
      // label98
      // 
      this.label98.AutoSize = true;
      this.label98.Location = new System.Drawing.Point(38, 171);
      this.label98.Name = "label98";
      this.label98.Size = new System.Drawing.Size(140, 13);
      this.label98.TabIndex = 45;
      this.label98.Text = "Configure Windows Explorer";
      // 
      // label97
      // 
      this.label97.AutoSize = true;
      this.label97.Location = new System.Drawing.Point(38, 147);
      this.label97.Name = "label97";
      this.label97.Size = new System.Drawing.Size(112, 13);
      this.label97.TabIndex = 44;
      this.label97.Text = "Autoplay configuration";
      // 
      // label96
      // 
      this.label96.AutoSize = true;
      this.label96.Location = new System.Drawing.Point(38, 101);
      this.label96.Name = "label96";
      this.label96.Size = new System.Drawing.Size(109, 13);
      this.label96.TabIndex = 43;
      this.label96.Text = "Configure Usergroups";
      // 
      // label95
      // 
      this.label95.AutoSize = true;
      this.label95.Location = new System.Drawing.Point(38, 78);
      this.label95.Name = "label95";
      this.label95.Size = new System.Drawing.Size(119, 13);
      this.label95.TabIndex = 42;
      this.label95.Text = "Configure Control Policy";
      // 
      // label120
      // 
      this.label120.AutoSize = true;
      this.label120.Location = new System.Drawing.Point(38, 30);
      this.label120.Name = "label120";
      this.label120.Size = new System.Drawing.Size(152, 13);
      this.label120.TabIndex = 41;
      this.label120.Text = "Create Windows Restore Point";
      // 
      // label94
      // 
      this.label94.AutoSize = true;
      this.label94.Location = new System.Drawing.Point(38, 54);
      this.label94.Name = "label94";
      this.label94.Size = new System.Drawing.Size(132, 13);
      this.label94.TabIndex = 41;
      this.label94.Text = "Configure Password Policy";
      // 
      // pbConfigCheck9
      // 
      this.pbConfigCheck9.Location = new System.Drawing.Point(16, 241);
      this.pbConfigCheck9.Name = "pbConfigCheck9";
      this.pbConfigCheck9.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck9.TabIndex = 40;
      this.pbConfigCheck9.TabStop = false;
      // 
      // pbConfigCheck8
      // 
      this.pbConfigCheck8.Location = new System.Drawing.Point(16, 216);
      this.pbConfigCheck8.Name = "pbConfigCheck8";
      this.pbConfigCheck8.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck8.TabIndex = 39;
      this.pbConfigCheck8.TabStop = false;
      // 
      // pbConfigCheck7
      // 
      this.pbConfigCheck7.Location = new System.Drawing.Point(16, 192);
      this.pbConfigCheck7.Name = "pbConfigCheck7";
      this.pbConfigCheck7.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck7.TabIndex = 38;
      this.pbConfigCheck7.TabStop = false;
      // 
      // pbConfigCheck6
      // 
      this.pbConfigCheck6.Location = new System.Drawing.Point(16, 168);
      this.pbConfigCheck6.Name = "pbConfigCheck6";
      this.pbConfigCheck6.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck6.TabIndex = 37;
      this.pbConfigCheck6.TabStop = false;
      // 
      // pbConfigCheck5
      // 
      this.pbConfigCheck5.Location = new System.Drawing.Point(16, 145);
      this.pbConfigCheck5.Name = "pbConfigCheck5";
      this.pbConfigCheck5.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck5.TabIndex = 36;
      this.pbConfigCheck5.TabStop = false;
      // 
      // pbConfigCheck4
      // 
      this.pbConfigCheck4.Location = new System.Drawing.Point(16, 122);
      this.pbConfigCheck4.Name = "pbConfigCheck4";
      this.pbConfigCheck4.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck4.TabIndex = 35;
      this.pbConfigCheck4.TabStop = false;
      // 
      // pbConfigCheck3
      // 
      this.pbConfigCheck3.Location = new System.Drawing.Point(16, 99);
      this.pbConfigCheck3.Name = "pbConfigCheck3";
      this.pbConfigCheck3.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck3.TabIndex = 34;
      this.pbConfigCheck3.TabStop = false;
      // 
      // pbConfigCheck2
      // 
      this.pbConfigCheck2.Location = new System.Drawing.Point(16, 76);
      this.pbConfigCheck2.Name = "pbConfigCheck2";
      this.pbConfigCheck2.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck2.TabIndex = 33;
      this.pbConfigCheck2.TabStop = false;
      // 
      // pbConfigCheck0
      // 
      this.pbConfigCheck0.Location = new System.Drawing.Point(16, 28);
      this.pbConfigCheck0.Name = "pbConfigCheck0";
      this.pbConfigCheck0.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck0.TabIndex = 32;
      this.pbConfigCheck0.TabStop = false;
      // 
      // pbConfigCheck1
      // 
      this.pbConfigCheck1.Location = new System.Drawing.Point(16, 52);
      this.pbConfigCheck1.Name = "pbConfigCheck1";
      this.pbConfigCheck1.Size = new System.Drawing.Size(16, 16);
      this.pbConfigCheck1.TabIndex = 32;
      this.pbConfigCheck1.TabStop = false;
      // 
      // wpConfigErrorOverview
      // 
      this.wpConfigErrorOverview.AccessibleName = "Error summary";
      this.wpConfigErrorOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpConfigErrorOverview.BackColor = System.Drawing.Color.Transparent;
      this.wpConfigErrorOverview.Controls.Add(this.webBrowser2);
      this.wpConfigErrorOverview.Controls.Add(this.label55);
      this.wpConfigErrorOverview.Controls.Add(this.tbErrorOverviewComment);
      this.wpConfigErrorOverview.Controls.Add(this.cbReadErrorLog);
      this.wpConfigErrorOverview.Location = new System.Drawing.Point(7, 72);
      this.wpConfigErrorOverview.Name = "wpConfigErrorOverview";
      this.wpConfigErrorOverview.PageDescription = "Below is a summary of errors that occurred during the configuration";
      this.wpConfigErrorOverview.PageTitle = "Faults summary";
      this.wpConfigErrorOverview.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.All;
      this.wpConfigErrorOverview.Size = new System.Drawing.Size(608, 283);
      this.wpConfigErrorOverview.TabIndex = 31;
      this.wpConfigErrorOverview.Text = "wizardPage1";
      this.wpConfigErrorOverview.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpConfigErrorOverview_NextButtonClick);
      // 
      // webBrowser2
      // 
      this.webBrowser2.Location = new System.Drawing.Point(9, -1);
      this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser2.Name = "webBrowser2";
      this.webBrowser2.Size = new System.Drawing.Size(594, 214);
      this.webBrowser2.TabIndex = 10;
      // 
      // label55
      // 
      this.label55.AutoSize = true;
      this.label55.Location = new System.Drawing.Point(4, 239);
      this.label55.Name = "label55";
      this.label55.Size = new System.Drawing.Size(99, 13);
      this.label55.TabIndex = 9;
      this.label55.Text = "Comments / action:";
      // 
      // tbErrorOverviewComment
      // 
      this.tbErrorOverviewComment.Location = new System.Drawing.Point(150, 242);
      this.tbErrorOverviewComment.Multiline = true;
      this.tbErrorOverviewComment.Name = "tbErrorOverviewComment";
      this.tbErrorOverviewComment.Size = new System.Drawing.Size(318, 41);
      this.tbErrorOverviewComment.TabIndex = 8;
      // 
      // cbReadErrorLog
      // 
      this.cbReadErrorLog.AutoSize = true;
      this.cbReadErrorLog.Location = new System.Drawing.Point(7, 219);
      this.cbReadErrorLog.Name = "cbReadErrorLog";
      this.cbReadErrorLog.Size = new System.Drawing.Size(411, 17);
      this.cbReadErrorLog.TabIndex = 6;
      this.cbReadErrorLog.Text = "Confirm that you have read the errors and checked for possible risks to the syste" +
    "m";
      this.cbReadErrorLog.UseVisualStyleBackColor = true;
      this.cbReadErrorLog.CheckedChanged += new System.EventHandler(this.cbReadErrorLog_CheckedChanged);
      // 
      // wpMBSAlogOverview
      // 
      this.wpMBSAlogOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpMBSAlogOverview.AntiAlias = false;
      this.wpMBSAlogOverview.BackColor = System.Drawing.Color.Transparent;
      this.wpMBSAlogOverview.CanvasColor = System.Drawing.SystemColors.Control;
      this.wpMBSAlogOverview.Controls.Add(this.label107);
      this.wpMBSAlogOverview.Controls.Add(this.tbMBSAcomments);
      this.wpMBSAlogOverview.Controls.Add(this.cbReadMBSAlog);
      this.wpMBSAlogOverview.Controls.Add(this.richTextBoxMBSAlog);
      this.wpMBSAlogOverview.Location = new System.Drawing.Point(7, 72);
      this.wpMBSAlogOverview.Name = "wpMBSAlogOverview";
      this.wpMBSAlogOverview.PageDescription = "Check here the output of the MBSA scan";
      this.wpMBSAlogOverview.PageTitle = "Output MBSA scan ";
      this.wpMBSAlogOverview.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.All;
      this.wpMBSAlogOverview.Size = new System.Drawing.Size(608, 283);
      this.wpMBSAlogOverview.TabIndex = 29;
      this.wpMBSAlogOverview.NextButtonClick += new System.ComponentModel.CancelEventHandler(this.wpMBSAlogOverview_NextButtonClick);
      // 
      // label107
      // 
      this.label107.AutoSize = true;
      this.label107.Location = new System.Drawing.Point(0, 239);
      this.label107.Name = "label107";
      this.label107.Size = new System.Drawing.Size(38, 13);
      this.label107.TabIndex = 5;
      this.label107.Text = "Notes:";
      // 
      // tbMBSAcomments
      // 
      this.tbMBSAcomments.Location = new System.Drawing.Point(79, 242);
      this.tbMBSAcomments.Multiline = true;
      this.tbMBSAcomments.Name = "tbMBSAcomments";
      this.tbMBSAcomments.Size = new System.Drawing.Size(318, 41);
      this.tbMBSAcomments.TabIndex = 2;
      // 
      // cbReadMBSAlog
      // 
      this.cbReadMBSAlog.AutoSize = true;
      this.cbReadMBSAlog.Location = new System.Drawing.Point(3, 219);
      this.cbReadMBSAlog.Name = "cbReadMBSAlog";
      this.cbReadMBSAlog.Size = new System.Drawing.Size(443, 17);
      this.cbReadMBSAlog.TabIndex = 1;
      this.cbReadMBSAlog.Text = "Confirm that you have read the log of MBSA and checked for possible risks in the " +
    "system";
      this.cbReadMBSAlog.UseVisualStyleBackColor = true;
      this.cbReadMBSAlog.CheckedChanged += new System.EventHandler(this.cbReadMBSAlog_CheckedChanged);
      // 
      // richTextBoxMBSAlog
      // 
      this.richTextBoxMBSAlog.BackColor = System.Drawing.SystemColors.Control;
      this.richTextBoxMBSAlog.Location = new System.Drawing.Point(5, -1);
      this.richTextBoxMBSAlog.Name = "richTextBoxMBSAlog";
      this.richTextBoxMBSAlog.ReadOnly = true;
      this.richTextBoxMBSAlog.Size = new System.Drawing.Size(596, 213);
      this.richTextBoxMBSAlog.TabIndex = 2;
      this.richTextBoxMBSAlog.Text = "";
      // 
      // wpFinish
      // 
      this.wpFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wpFinish.AntiAlias = false;
      this.wpFinish.BackColor = System.Drawing.Color.Transparent;
      this.wpFinish.Controls.Add(this.groupBox17);
      this.wpFinish.Location = new System.Drawing.Point(7, 72);
      this.wpFinish.Name = "wpFinish";
      this.wpFinish.PageDescription = "This is the last step of the configuration";
      this.wpFinish.PageTitle = "Complete the configuration";
      this.wpFinish.PageWiSSWizardMode = Actemium.WiSSWizard.Pages.WiSSWizardMode.All;
      this.wpFinish.Size = new System.Drawing.Size(608, 283);
      this.wpFinish.TabIndex = 27;
      // 
      // groupBox17
      // 
      this.groupBox17.Controls.Add(this.btViewLog);
      this.groupBox17.Controls.Add(this.lbLogfilePathWPFinish);
      this.groupBox17.Controls.Add(this.pictureBox4);
      this.groupBox17.Controls.Add(this.btSaveWpFinish);
      this.groupBox17.Controls.Add(this.label110);
      this.groupBox17.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox17.Location = new System.Drawing.Point(0, 0);
      this.groupBox17.Name = "groupBox17";
      this.groupBox17.Size = new System.Drawing.Size(608, 283);
      this.groupBox17.TabIndex = 14;
      this.groupBox17.TabStop = false;
      this.groupBox17.Text = "Complete";
      // 
      // btViewLog
      // 
      this.btViewLog.Location = new System.Drawing.Point(128, 147);
      this.btViewLog.Name = "btViewLog";
      this.btViewLog.Size = new System.Drawing.Size(75, 23);
      this.btViewLog.TabIndex = 4;
      this.btViewLog.Text = "View";
      this.btViewLog.UseVisualStyleBackColor = true;
      this.btViewLog.Click += new System.EventHandler(this.btViewLog_Click);
      // 
      // lbLogfilePathWPFinish
      // 
      this.lbLogfilePathWPFinish.AutoSize = true;
      this.lbLogfilePathWPFinish.Location = new System.Drawing.Point(18, 186);
      this.lbLogfilePathWPFinish.MaximumSize = new System.Drawing.Size(500, 50);
      this.lbLogfilePathWPFinish.Name = "lbLogfilePathWPFinish";
      this.lbLogfilePathWPFinish.Size = new System.Drawing.Size(105, 13);
      this.lbLogfilePathWPFinish.TabIndex = 3;
      this.lbLogfilePathWPFinish.Text = "{Current file location}";
      // 
      // pictureBox4
      // 
      this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
      this.pictureBox4.Location = new System.Drawing.Point(347, 213);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new System.Drawing.Size(255, 67);
      this.pictureBox4.TabIndex = 2;
      this.pictureBox4.TabStop = false;
      // 
      // btSaveWpFinish
      // 
      this.btSaveWpFinish.Location = new System.Drawing.Point(21, 147);
      this.btSaveWpFinish.Name = "btSaveWpFinish";
      this.btSaveWpFinish.Size = new System.Drawing.Size(101, 23);
      this.btSaveWpFinish.TabIndex = 1;
      this.btSaveWpFinish.Text = "Save Log";
      this.btSaveWpFinish.UseVisualStyleBackColor = true;
      this.btSaveWpFinish.Click += new System.EventHandler(this.btSaveWpFinish_Click);
      // 
      // label110
      // 
      this.label110.AutoSize = true;
      this.label110.Location = new System.Drawing.Point(18, 30);
      this.label110.Name = "label110";
      this.label110.Size = new System.Drawing.Size(288, 117);
      this.label110.TabIndex = 0;
      this.label110.Text = resources.GetString("label110.Text");
      // 
      // CtrlHome
      // 
      this.BackColor = System.Drawing.Color.LightGray;
      this.ClientSize = new System.Drawing.Size(622, 413);
      this.ControlBox = false;
      this.Controls.Add(this.btWindowsRecommend);
      this.Controls.Add(this.btWindowsCurrent);
      this.Controls.Add(this.ttCheckCurrentSettings);
      this.Controls.Add(this.btCheckCurrentSettings);
      this.Controls.Add(this.wizard1);
      this.DoubleBuffered = true;
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.KeyPreview = true;
      this.Name = "CtrlHome";
      this.Text = "c";
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttCheckCurrentSettings)).EndInit();
      this.wizard1.ResumeLayout(false);
      this.wpStartUp.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.wpSelectNameAndSystem.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.gbSelectTemplate.ResumeLayout(false);
      this.gbSelectTemplate.PerformLayout();
      this.wpInstalledApllications.ResumeLayout(false);
      this.groupBox18.ResumeLayout(false);
      this.groupBox18.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbInstalledSoftware6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbNotInstalled)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbInstalled)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbInstalledSoftware5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbInstalledSoftware4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbInstalledSoftware3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbInstalledSoftware2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbInstalledSoftware1)).EndInit();
      this.wpPasswordPolicy.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ttPasswordEncryption)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttPasswordComplexity)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudNrOfRememberedPasw)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMinPaswordlength)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMinPaswordTime)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaxPaswordTime)).EndInit();
      this.wpControlPolicy.ResumeLayout(false);
      this.gbControlPolicy.ResumeLayout(false);
      this.gbControlPolicy.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditSytemEvents)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditProcessTracking)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditObjectAcces)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditPrivilegeUse)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditPolicyChange)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditActiveDirectoryAcces)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditAccountManagement)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditAccountLogon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttAuditLogonEvents)).EndInit();
      this.wpGroups.ResumeLayout(false);
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.wpDefaultAccounts.ResumeLayout(false);
      this.wpDefaultAccounts.PerformLayout();
      this.gbAddAdminAndActemiumUsers.ResumeLayout(false);
      this.gbAddAdminAndActemiumUsers.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ttChangeDefaultAccountsSavePasswordInLogFile)).EndInit();
      this.wpUsers.ResumeLayout(false);
      this.wpUsers.PerformLayout();
      this.groupBox11.ResumeLayout(false);
      this.groupBox11.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ttSavePasswordInLogFile)).EndInit();
      this.wpAutoPlayAndWExplorer.ResumeLayout(false);
      this.gbExplorerSettings.ResumeLayout(false);
      this.gbExplorerSettings.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ttAutoSearchFoldersPrinters)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttShowNTFSinBlue)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttRembemberViewSettings)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttHideProtectedSysFiles)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttHideExtensions)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttShowHiddenFolders)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttDisplayFullPathAddressBar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttDisplayContentsSysFolders)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ttAutoPlay)).EndInit();
      this.wpAutoLogonAndEventTracker.ResumeLayout(false);
      this.groupBox15.ResumeLayout(false);
      this.groupBox15.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ttRemoteDesktopAddUsers)).EndInit();
      this.groupBox8.ResumeLayout(false);
      this.groupBox8.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbValidatePassWordAutoLogon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttShutdownEventTracker)).EndInit();
      this.wpSQLConfig.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.gbSQL.ResumeLayout(false);
      this.gbSQL.PerformLayout();
      this.gbChangeSaPass.ResumeLayout(false);
      this.gbChangeSaPass.PerformLayout();
      this.wpPCAnywhere.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.groupBox23.ResumeLayout(false);
      this.groupBox23.PerformLayout();
      this.groupBox22.ResumeLayout(false);
      this.groupBox22.PerformLayout();
      this.groupBox24.ResumeLayout(false);
      this.groupBox24.PerformLayout();
      this.groupBox21.ResumeLayout(false);
      this.groupBox21.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      this.groupBox20.ResumeLayout(false);
      this.groupBox20.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.groupBox25.ResumeLayout(false);
      this.groupBox25.PerformLayout();
      this.groupBox26.ResumeLayout(false);
      this.groupBox26.PerformLayout();
      this.groupBox27.ResumeLayout(false);
      this.groupBox27.PerformLayout();
      this.groupBox28.ResumeLayout(false);
      this.groupBox28.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
      this.groupBox29.ResumeLayout(false);
      this.groupBox29.PerformLayout();
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
      this.wpIIS.ResumeLayout(false);
      this.tabControl2.ResumeLayout(false);
      this.tabPage4.ResumeLayout(false);
      this.groupBox19.ResumeLayout(false);
      this.groupBox19.PerformLayout();
      this.tpWeb.ResumeLayout(false);
      this.tpWeb.PerformLayout();
      this.gbIISLog.ResumeLayout(false);
      this.gbIISLog.PerformLayout();
      this.groupBox9.ResumeLayout(false);
      this.groupBox9.PerformLayout();
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudWebLogSize)).EndInit();
      this.gbIIS.ResumeLayout(false);
      this.gbIIS.PerformLayout();
      this.tabPage5.ResumeLayout(false);
      this.tabPage5.PerformLayout();
      this.gbMailSrvConfigure.ResumeLayout(false);
      this.gbMailSrvConfigure.PerformLayout();
      this.gbMailSrvRelay.ResumeLayout(false);
      this.gbMailSrvRelay.PerformLayout();
      this.gbMailSrvLogging.ResumeLayout(false);
      this.gbMailSrvLogging.PerformLayout();
      this.gbMailSrvLogDir.ResumeLayout(false);
      this.gbMailSrvLogDir.PerformLayout();
      this.gbMailLoggingSchedule.ResumeLayout(false);
      this.gbMailLoggingSchedule.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudMailLogSize)).EndInit();
      this.tabPageFTP.ResumeLayout(false);
      this.tabPageFTP.PerformLayout();
      this.groupBox14.ResumeLayout(false);
      this.groupBox14.PerformLayout();
      this.groupBox10.ResumeLayout(false);
      this.groupBox10.PerformLayout();
      this.gbFTPLogLocation.ResumeLayout(false);
      this.gbFTPLogLocation.PerformLayout();
      this.gbFTPLogSchedule.ResumeLayout(false);
      this.gbFTPLogSchedule.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudFTPLogSize)).EndInit();
      this.wpFireWall.ResumeLayout(false);
      this.wpFireWall.PerformLayout();
      this.gbFireWall.ResumeLayout(false);
      this.gbFireWall.PerformLayout();
      this.groupBox13.ResumeLayout(false);
      this.groupBox13.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.TTtcpUdp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ttFireWall)).EndInit();
      this.wpBlockKey.ResumeLayout(false);
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.wpSharedFolderConfig.ResumeLayout(false);
      this.groupBox30.ResumeLayout(false);
      this.wpNetworkConfigure.ResumeLayout(false);
      this.tabControl3.ResumeLayout(false);
      this.tpIpConfig.ResumeLayout(false);
      this.gbUseStaticIPAddress.ResumeLayout(false);
      this.gbUseStaticIPAddress.PerformLayout();
      this.gbDNSServers.ResumeLayout(false);
      this.gbDNSServers.PerformLayout();
      this.tabPage7.ResumeLayout(false);
      this.wpMBSA.ResumeLayout(false);
      this.gbMBSA.ResumeLayout(false);
      this.gbMBSA.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ttMBSA)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.wpAcceptSettings.ResumeLayout(false);
      this.wpAcceptSettings.PerformLayout();
      this.wpConfigurationCheck.ResumeLayout(false);
      this.groupBox12.ResumeLayout(false);
      this.groupBox12.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck18)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck17)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck16)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck15)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck14)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck13)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck12)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck11)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck20)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck19)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck10)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck9)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck8)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck0)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbConfigCheck1)).EndInit();
      this.wpConfigErrorOverview.ResumeLayout(false);
      this.wpConfigErrorOverview.PerformLayout();
      this.wpMBSAlogOverview.ResumeLayout(false);
      this.wpMBSAlogOverview.PerformLayout();
      this.wpFinish.ResumeLayout(false);
      this.groupBox17.ResumeLayout(false);
      this.groupBox17.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    //private System.Windows.Forms.ColumnHeader Name;
    private System.Windows.Forms.OpenFileDialog ofd1;
    private System.Windows.Forms.ImageList checkImages;
    private System.Windows.Forms.Button btCheckCurrentSettings;
    private System.Windows.Forms.PictureBox ttCheckCurrentSettings;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.ComponentModel.BackgroundWorker backgroundWorker2;
    private System.ComponentModel.BackgroundWorker bgwCheckMBSApath;
    private System.Windows.Forms.ErrorProvider errorProvider;
    private DevComponents.DotNetBar.Wizard wizard1;
    private BaseWiSSWizardPage wpStartUp;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpSelectNameAndSystem;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label lbOperatingSystem;
    private System.Windows.Forms.Label label40;
    private System.Windows.Forms.Label lbInfoPnStart;
    private System.Windows.Forms.RadioButton rbAllsettingsPnStart;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.ComboBox cbOperatingSystemPnStart;
    private System.Windows.Forms.TextBox tbFamilyNamePnStart;
    private System.Windows.Forms.TextBox tbFirstNamePnStart;
    private System.Windows.Forms.Label lbFamilyNamePnStart;
    private System.Windows.Forms.Label lbFirstNamePnStart;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpInstalledApllications;
    private System.Windows.Forms.GroupBox groupBox18;
    private System.Windows.Forms.PictureBox pbNotInstalled;
    private System.Windows.Forms.PictureBox pbInstalled;
    private System.Windows.Forms.Label label112;
    private System.Windows.Forms.Label label113;
    private System.Windows.Forms.Label label121;
    private System.Windows.Forms.Label label122;
    private System.Windows.Forms.Label label124;
    private System.Windows.Forms.Label label125;
    private System.Windows.Forms.Label label126;
    private System.Windows.Forms.PictureBox pbInstalledSoftware5;
    private System.Windows.Forms.PictureBox pbInstalledSoftware4;
    private System.Windows.Forms.PictureBox pbInstalledSoftware3;
    private System.Windows.Forms.PictureBox pbInstalledSoftware2;
    private System.Windows.Forms.PictureBox pbInstalledSoftware1;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpPasswordPolicy;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.PictureBox ttPasswordEncryption;
    private System.Windows.Forms.PictureBox ttPasswordComplexity;
    private System.Windows.Forms.ComboBox cbEncryptionPW;
    private System.Windows.Forms.Label label56;
    private System.Windows.Forms.ComboBox cbComplexityPW;
    private System.Windows.Forms.Label label57;
    private System.Windows.Forms.Label label58;
    private System.Windows.Forms.Label label59;
    private System.Windows.Forms.NumericUpDown nudNrOfRememberedPasw;
    private System.Windows.Forms.Label label60;
    private System.Windows.Forms.Label label61;
    private System.Windows.Forms.NumericUpDown nudMinPaswordlength;
    private System.Windows.Forms.Label label62;
    private System.Windows.Forms.Label label63;
    private System.Windows.Forms.NumericUpDown nudMinPaswordTime;
    private System.Windows.Forms.Label label64;
    private System.Windows.Forms.Label label65;
    private System.Windows.Forms.NumericUpDown nudMaxPaswordTime;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpControlPolicy;
    private System.Windows.Forms.GroupBox gbControlPolicy;
    private System.Windows.Forms.PictureBox ttAuditSytemEvents;
    private System.Windows.Forms.PictureBox ttAuditProcessTracking;
    private System.Windows.Forms.PictureBox ttAuditObjectAcces;
    private System.Windows.Forms.PictureBox ttAuditPrivilegeUse;
    private System.Windows.Forms.PictureBox ttAuditPolicyChange;
    private System.Windows.Forms.TextBox tbControlPolicy9;
    private System.Windows.Forms.PictureBox ttAuditActiveDirectoryAcces;
    private System.Windows.Forms.TextBox tbControlPolicy8;
    private System.Windows.Forms.PictureBox ttAuditAccountManagement;
    private System.Windows.Forms.TextBox tbControlPolicy6;
    private System.Windows.Forms.PictureBox ttAuditAccountLogon;
    private System.Windows.Forms.TextBox tbControlPolicy5;
    private System.Windows.Forms.PictureBox ttAuditLogonEvents;
    private System.Windows.Forms.TextBox tbControlPolicy3;
    private System.Windows.Forms.TextBox tbControlPolicy2;
    private System.Windows.Forms.TextBox tbControlPolicy1;
    private System.Windows.Forms.Label label46;
    private System.Windows.Forms.Label label47;
    private System.Windows.Forms.Label label48;
    private System.Windows.Forms.Label label49;
    private System.Windows.Forms.Label label45;
    private System.Windows.Forms.Label label44;
    private System.Windows.Forms.Label label43;
    private System.Windows.Forms.Label label42;
    private System.Windows.Forms.Label label41;
    private System.Windows.Forms.TextBox tbControlPolicy7;
    private System.Windows.Forms.Label lbAuditPolicyNotStandard;
    private System.Windows.Forms.TextBox tbControlPolicy4;
    private System.Windows.Forms.ComboBox combControlPolicy9;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.ComboBox combControlPolicy8;
    private System.Windows.Forms.ComboBox combControlPolicy1;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.ComboBox combControlPolicy7;
    private System.Windows.Forms.ComboBox combControlPolicy2;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.ComboBox combControlPolicy6;
    private System.Windows.Forms.ComboBox combControlPolicy3;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.ComboBox combControlPolicy5;
    private System.Windows.Forms.ComboBox combControlPolicy4;
    private System.Windows.Forms.Label label17;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpGroups;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.CheckBox cbAddgroupAdministrators;
    private System.Windows.Forms.CheckBox cbAddGroupFTP_users;
    private System.Windows.Forms.Label lbSelectGroupFirst;
    private System.Windows.Forms.Button btDeleteGroup;
    private System.Windows.Forms.CheckBox cbAddgroupActemiumEngineers;
    private System.Windows.Forms.Label label32;
    private System.Windows.Forms.ListView lvUsergroups;
    private System.Windows.Forms.ColumnHeader Group;
    private System.Windows.Forms.ColumnHeader Discription1;
    private System.Windows.Forms.Label label24;
    private System.Windows.Forms.TextBox tbAddUserGroupDescription;
    private System.Windows.Forms.Label label23;
    private System.Windows.Forms.TextBox tbAddUserGroupName;
    private System.Windows.Forms.Button btAddUserGroup;
    private System.Windows.Forms.Label label22;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpDefaultAccounts;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lbChangeDefaultAccountAdministrator;
    private System.Windows.Forms.Label lbChangeDefaultAccountSUPPORT;
    private System.Windows.Forms.Label lbChangeDefaultAccountGuest;
    private System.Windows.Forms.PictureBox ttChangeDefaultAccountsSavePasswordInLogFile;
    private System.Windows.Forms.CheckBox cbBlockDefAccoAdministrator;
    private System.Windows.Forms.CheckBox cbChangeDefaultAccountsSavePasswordInLogFile;
    private System.Windows.Forms.CheckBox cbRandomPWChangeDefAccoAdministrator;
    private System.Windows.Forms.Label label53;
    private System.Windows.Forms.TextBox tbChangeConfirmPasswDefAccoAdministrator;
    private System.Windows.Forms.TextBox tbChangePasswDefAccoAdministrator;
    private System.Windows.Forms.CheckBox cbBlockDefAccoSUPPORT;
    private System.Windows.Forms.CheckBox cbRandomPWChangeDefAccoSUPPORT;
    private System.Windows.Forms.Label label51;
    private System.Windows.Forms.TextBox tbChangeConfirmPasswDefAccoSUPPORT;
    private System.Windows.Forms.TextBox tbChangePasswDefAccoSUPPORT;
    private System.Windows.Forms.CheckBox cbBlockDefAccoGuest;
    private System.Windows.Forms.CheckBox cbRandomPWChangeDefAccoGuest;
    private System.Windows.Forms.Label label33;
    private System.Windows.Forms.Label label50;
    private System.Windows.Forms.TextBox tbChangeConfirmPasswDefAccoGuest;
    private System.Windows.Forms.TextBox tbChangePasswDefAccoGuest;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpUsers;
    private System.Windows.Forms.Button btModifyUser;
    private System.Windows.Forms.CheckBox cbRandomPaswordUsers;
    private System.Windows.Forms.Label lbSelectUserFirst;
    private System.Windows.Forms.Button btDeleteUser;
    private System.Windows.Forms.PictureBox ttSavePasswordInLogFile;
    private System.Windows.Forms.CheckBox cbSavePasswordInLogFile;
    private System.Windows.Forms.CheckBox cbAccountDisabled;
    private System.Windows.Forms.CheckBox cbPaswordNeverExpires;
    private System.Windows.Forms.CheckBox cbPaswordCantBeChanged;
    private System.Windows.Forms.CheckBox cbChangePwNextLogon;
    private System.Windows.Forms.Label label26;
    private System.Windows.Forms.ListView lvUsers;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpAutoPlayAndWExplorer;
    private System.Windows.Forms.GroupBox gbExplorerSettings;
    private System.Windows.Forms.Label lbWesASNFP;
    private System.Windows.Forms.Label lbWesDCSF;
    private System.Windows.Forms.TextBox tbWesDCSF;
    private System.Windows.Forms.TextBox tbWesASNFP;
    private System.Windows.Forms.Label lbWesDFPAB;
    private System.Windows.Forms.TextBox tbWesDFPAB;
    private System.Windows.Forms.Label lbWesSHFF;
    private System.Windows.Forms.TextBox tbWesSHFF;
    private System.Windows.Forms.Label lbWesHEKF;
    private System.Windows.Forms.PictureBox ttAutoSearchFoldersPrinters;
    private System.Windows.Forms.CheckBox cbWesASNFP;
    private System.Windows.Forms.TextBox tbWesHEKF;
    private System.Windows.Forms.Label lbWesHPOSF;
    private System.Windows.Forms.TextBox tbWesHPOSF;
    private System.Windows.Forms.Label lbWesREFS;
    private System.Windows.Forms.TextBox tbWesREFS;
    private System.Windows.Forms.Label lbWesSECFC;
    private System.Windows.Forms.TextBox tbWesSECFC;
    private System.Windows.Forms.PictureBox ttShowNTFSinBlue;
    private System.Windows.Forms.PictureBox ttRembemberViewSettings;
    private System.Windows.Forms.PictureBox ttHideProtectedSysFiles;
    private System.Windows.Forms.PictureBox ttHideExtensions;
    private System.Windows.Forms.PictureBox ttShowHiddenFolders;
    private System.Windows.Forms.PictureBox ttDisplayFullPathAddressBar;
    private System.Windows.Forms.PictureBox ttDisplayContentsSysFolders;
    private System.Windows.Forms.CheckBox cbWesSECFC;
    private System.Windows.Forms.CheckBox cbWesREFS;
    private System.Windows.Forms.CheckBox cbWesHPOSF;
    private System.Windows.Forms.CheckBox cbWesHEKF;
    private System.Windows.Forms.CheckBox cbWesSHFF;
    private System.Windows.Forms.CheckBox cbWesDFPAB;
    private System.Windows.Forms.CheckBox cbWesDCSF;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label lbAutoPlayNotDefault;
    private System.Windows.Forms.PictureBox ttAutoPlay;
    private System.Windows.Forms.TextBox tbAutoPlayNotDefault;
    private System.Windows.Forms.ComboBox cbAutoplaydrives;
    private System.Windows.Forms.RadioButton rbEnabledAP;
    private System.Windows.Forms.RadioButton rbDisabledAP;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpAutoLogonAndEventTracker;
    private System.Windows.Forms.GroupBox groupBox15;
    private System.Windows.Forms.Label lbRemoteDesktopNotDefault;
    private System.Windows.Forms.TextBox tbRemoteDesktopNotDefault;
    private System.Windows.Forms.PictureBox ttRemoteDesktopAddUsers;
    private System.Windows.Forms.Label label34;
    private System.Windows.Forms.Button btRemoveRemoteDesktopUser;
    private System.Windows.Forms.ListBox listbRemoteDesktopUsers;
    private System.Windows.Forms.ComboBox combRemoteDesktopUsers;
    private System.Windows.Forms.RadioButton rbRemoteDesktopOnMoreSecure;
    private System.Windows.Forms.RadioButton rbRemoteDesktopOnLessSecure;
    private System.Windows.Forms.Label label114;
    private System.Windows.Forms.RadioButton rbRemoteDesktopOff;
    private System.Windows.Forms.GroupBox groupBox8;
    private System.Windows.Forms.Label label118;
    private System.Windows.Forms.ComboBox combAutoLogonUser;
    private System.Windows.Forms.Label lbAutoLogonNotDefault;
    private System.Windows.Forms.TextBox tbAutoLogonNotDefault;
    private System.Windows.Forms.Label lbShutDownEventTrackerNotDefault;
    private System.Windows.Forms.Label lbPasswordKnow;
    private System.Windows.Forms.TextBox tbShutDownEventTrackerNotDefault;
    private System.Windows.Forms.PictureBox pbValidatePassWordAutoLogon;
    private System.Windows.Forms.Label label116;
    private System.Windows.Forms.TextBox tbAutoLogonPasword;
    private System.Windows.Forms.PictureBox ttShutdownEventTracker;
    private System.Windows.Forms.ComboBox combShutDEventTracker;
    private System.Windows.Forms.Label lbShutDownEventTracker;
    private System.Windows.Forms.CheckBox cbAutoLogon;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpFireWall;
    private System.Windows.Forms.CheckBox cbFireWallOnOff;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpIIS;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpMBSA;
    private System.Windows.Forms.GroupBox gbMBSA;
    private System.Windows.Forms.Label lbMBSAnotDefault;
    private System.Windows.Forms.Label lbMBSAinstallationFolder;
    private System.Windows.Forms.TextBox tbMBSAnotDefault;
    private System.Windows.Forms.Label label123;
    private System.Windows.Forms.PictureBox ttMBSA;
    private System.Windows.Forms.Label label91;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.CheckBox cbMBSA;
    private System.Windows.Forms.PictureBox pictureBox2;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpAcceptSettings;
    private System.Windows.Forms.WebBrowser webBrowser1;
    private System.Windows.Forms.Label label93;
    private System.Windows.Forms.Label label37;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpConfigurationCheck;
    private System.Windows.Forms.GroupBox groupBox12;
    private System.Windows.Forms.Button btCancelMakeSettings;
    private System.Windows.Forms.Label label117;
    private System.Windows.Forms.PictureBox pbConfigCheck20;
    private System.Windows.Forms.PictureBox pbConfigCheck19;
    private System.Windows.Forms.Label label115;
    private System.Windows.Forms.Label label119;
    private System.Windows.Forms.Label lbConfigMBSA;
    private System.Windows.Forms.PictureBox pbConfigCheck10;
    private System.Windows.Forms.Label label102;
    private System.Windows.Forms.Label label100;
    private System.Windows.Forms.Label label99;
    private System.Windows.Forms.Label label98;
    private System.Windows.Forms.Label label97;
    private System.Windows.Forms.Label label96;
    private System.Windows.Forms.Label label95;
    private System.Windows.Forms.Label label120;
    private System.Windows.Forms.Label label94;
    private System.Windows.Forms.PictureBox pbConfigCheck9;
    private System.Windows.Forms.PictureBox pbConfigCheck8;
    private System.Windows.Forms.PictureBox pbConfigCheck7;
    private System.Windows.Forms.PictureBox pbConfigCheck6;
    private System.Windows.Forms.PictureBox pbConfigCheck5;
    private System.Windows.Forms.PictureBox pbConfigCheck4;
    private System.Windows.Forms.PictureBox pbConfigCheck3;
    private System.Windows.Forms.PictureBox pbConfigCheck2;
    private System.Windows.Forms.PictureBox pbConfigCheck0;
    private System.Windows.Forms.PictureBox pbConfigCheck1;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpConfigErrorOverview;
    private System.Windows.Forms.WebBrowser webBrowser2;
    private System.Windows.Forms.Label label55;
    private System.Windows.Forms.TextBox tbErrorOverviewComment;
    private System.Windows.Forms.CheckBox cbReadErrorLog;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpMBSAlogOverview;
    private System.Windows.Forms.Label label107;
    private System.Windows.Forms.TextBox tbMBSAcomments;
    private System.Windows.Forms.CheckBox cbReadMBSAlog;
    private System.Windows.Forms.RichTextBox richTextBoxMBSAlog;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpSQLConfig;
    private System.Windows.Forms.GroupBox gbSQL;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpBlockKey;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.TextBox textBox9;
    private System.Windows.Forms.Label label84;
    private System.Windows.Forms.CheckBox checkBox16;
    private System.Windows.Forms.CheckBox checkBox15;
    private System.Windows.Forms.TextBox textBox8;
    private System.Windows.Forms.Label label83;
    private System.Windows.Forms.CheckBox checkBox14;
    private System.Windows.Forms.CheckBox checkBox13;
    private System.Windows.Forms.CheckBox checkBox12;
    private System.Windows.Forms.CheckBox checkBox11;
    private System.Windows.Forms.CheckBox checkBox10;
    private System.Windows.Forms.CheckBox checkBox9;
    private System.Windows.Forms.CheckBox checkBox8;
    private System.Windows.Forms.CheckBox checkBox7;
    private System.Windows.Forms.CheckBox checkBox6;
    private System.Windows.Forms.CheckBox checkBox5;
    private System.Windows.Forms.CheckBox checkBox4;
    private System.Windows.Forms.CheckBox checkBox3;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpPCAnywhere;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpFinish;
    private System.Windows.Forms.GroupBox groupBox17;
    private System.Windows.Forms.Button btViewLog;
    private System.Windows.Forms.Label lbLogfilePathWPFinish;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.Button btSaveWpFinish;
    private System.Windows.Forms.Label label110;
    private System.Windows.Forms.RadioButton rbLockDownPnStart;
    private System.Windows.Forms.Label label69;
    private System.Windows.Forms.PictureBox pbInstalledSoftware6;
    private System.Windows.Forms.CheckBox checkBox20;
    private System.Windows.Forms.CheckBox checkBox19;
    private System.Windows.Forms.CheckBox checkBox18;
    private System.Windows.Forms.CheckBox checkBox17;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpSharedFolderConfig;
    private System.Windows.Forms.GroupBox groupBox23;
    private System.Windows.Forms.CheckBox checkBox28;
    private System.Windows.Forms.RadioButton radioButton9;
    private System.Windows.Forms.RadioButton radioButton10;
    private System.Windows.Forms.RadioButton radioButton11;
    private System.Windows.Forms.GroupBox groupBox22;
    private System.Windows.Forms.CheckBox checkBox27;
    private System.Windows.Forms.RadioButton radioButton8;
    private System.Windows.Forms.RadioButton radioButton7;
    private System.Windows.Forms.RadioButton radioButton6;
    private System.Windows.Forms.GroupBox groupBox24;
    private System.Windows.Forms.RadioButton radioButton12;
    private System.Windows.Forms.RadioButton radioButton13;
    private System.Windows.Forms.GroupBox groupBox21;
    private System.Windows.Forms.Label label71;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.Label label70;
    private System.Windows.Forms.RadioButton radioButton5;
    private System.Windows.Forms.RadioButton radioButton4;
    private System.Windows.Forms.GroupBox groupBox20;
    private System.Windows.Forms.CheckBox checkBox26;
    private System.Windows.Forms.CheckBox checkBox25;
    private System.Windows.Forms.CheckBox checkBox24;
    private System.Windows.Forms.CheckBox checkBox23;
    private System.Windows.Forms.GroupBox groupBox25;
    private System.Windows.Forms.CheckBox checkBox29;
    private System.Windows.Forms.RadioButton radioButton14;
    private System.Windows.Forms.RadioButton radioButton15;
    private System.Windows.Forms.RadioButton radioButton16;
    private System.Windows.Forms.GroupBox groupBox26;
    private System.Windows.Forms.CheckBox checkBox30;
    private System.Windows.Forms.RadioButton radioButton17;
    private System.Windows.Forms.RadioButton radioButton18;
    private System.Windows.Forms.RadioButton radioButton19;
    private System.Windows.Forms.GroupBox groupBox27;
    private System.Windows.Forms.RadioButton radioButton20;
    private System.Windows.Forms.RadioButton radioButton21;
    private System.Windows.Forms.GroupBox groupBox28;
    private System.Windows.Forms.Label label72;
    private System.Windows.Forms.NumericUpDown numericUpDown3;
    private System.Windows.Forms.Label label73;
    private System.Windows.Forms.RadioButton radioButton22;
    private System.Windows.Forms.RadioButton radioButton23;
    private System.Windows.Forms.GroupBox groupBox29;
    private System.Windows.Forms.CheckBox checkBox31;
    private System.Windows.Forms.CheckBox checkBox32;
    private System.Windows.Forms.CheckBox checkBox33;
    private System.Windows.Forms.CheckBox checkBox34;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.CheckBox checkBox36;
    private System.Windows.Forms.CheckBox checkBox35;
    private System.Windows.Forms.TextBox textBox14;
    private System.Windows.Forms.TextBox textBox13;
    private System.Windows.Forms.Label label87;
    private System.Windows.Forms.Label label86;
    private System.Windows.Forms.Label label85;
    private System.Windows.Forms.PictureBox pictureBox13;
    private System.Windows.Forms.GroupBox groupBox30;
    private System.Windows.Forms.Button btAddShare;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button btRemoveSQLAdmins;
    private System.Windows.Forms.Button btAddSQLAdmins;
    private System.Windows.Forms.Label label81;
    private System.Windows.Forms.Label label77;
    private System.Windows.Forms.Label label103;
    private System.Windows.Forms.Label label101;
    private System.Windows.Forms.Label label92;
    private System.Windows.Forms.Label label90;
    private System.Windows.Forms.Label label89;
    private System.Windows.Forms.Label label88;
    private System.Windows.Forms.PictureBox pbConfigCheck16;
    private System.Windows.Forms.PictureBox pbConfigCheck15;
    private System.Windows.Forms.PictureBox pbConfigCheck14;
    private System.Windows.Forms.PictureBox pbConfigCheck13;
    private System.Windows.Forms.PictureBox pbConfigCheck12;
    private System.Windows.Forms.PictureBox pbConfigCheck11;
    private System.Windows.Forms.GroupBox gbSelectTemplate;
    private System.Windows.Forms.Button btSelectTemplate;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.ListView lvSqlAdmins;
    private System.Windows.Forms.Button btStopShare;
    private System.Windows.Forms.TabControl tabControl2;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.GroupBox groupBox19;
    private System.Windows.Forms.TabPage tpWeb;
    private System.Windows.Forms.Label lbIISNotDefault;
    private System.Windows.Forms.GroupBox gbIISLog;
    private System.Windows.Forms.GroupBox groupBox9;
    private System.Windows.Forms.CheckBox cbWebLogDelete;
    private System.Windows.Forms.Button btWeblogBrowse;
    private System.Windows.Forms.TextBox tbWebLogLocation;
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.NumericUpDown nudWebLogSize;
    private System.Windows.Forms.RadioButton rbWebLogSizeReach;
    private System.Windows.Forms.RadioButton rbWebLogUnlimitSize;
    private System.Windows.Forms.RadioButton rbWebLogMonth;
    private System.Windows.Forms.RadioButton rbWebLogWeek;
    private System.Windows.Forms.RadioButton rbWebLogDay;
    private System.Windows.Forms.RadioButton rbWebLogHour;
    private System.Windows.Forms.ComboBox cboWebActiveLogFormat;
    private System.Windows.Forms.CheckBox cbLoginAuthorOnOff;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tbIISNotDefault;
    private System.Windows.Forms.GroupBox gbIIS;
    private System.Windows.Forms.Label lbWebServers;
    private System.Windows.Forms.CheckBox cbIISOnOff;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.RadioButton rbSecurityPnStart;
    private System.Windows.Forms.RadioButton rbLoadTemplate;
    private System.Windows.Forms.Label label105;
    private System.Windows.Forms.ComboBox cbCurrentEncryptionPW;
    private System.Windows.Forms.ComboBox cbCurrentComplexityPW;
    private System.Windows.Forms.Label label129;
    private System.Windows.Forms.Label label128;
    private System.Windows.Forms.Label label106;
    private System.Windows.Forms.Label label108;
    private System.Windows.Forms.Label label109;
    private System.Windows.Forms.Label label127;
    private System.Windows.Forms.GroupBox gbFireWall;
    private System.Windows.Forms.TextBox tbFirewallNotDefault;
    private System.Windows.Forms.Label lbFirewallNotDefault;
    private System.Windows.Forms.Button btFwDelete;
    private System.Windows.Forms.Label label36;
    private System.Windows.Forms.ListBox libFireWallExceptions;
    private System.Windows.Forms.PictureBox ttFireWall;
    private System.Windows.Forms.Label lbfwSelectedItem;
    private System.Windows.Forms.TabPage tabPage5;
    private System.Windows.Forms.TabPage tabPageFTP;
    private System.Windows.Forms.Button btWindowsRecommend;
    private System.Windows.Forms.Button btWindowsCurrent;
    private System.Windows.Forms.GroupBox groupBox14;
    private System.Windows.Forms.Label lbFTPNet;
    private System.Windows.Forms.ComboBox cbFTPDir;
    private System.Windows.Forms.Button btAddFtpUser;
    private System.Windows.Forms.Button btFtpShareConnect;
    private System.Windows.Forms.Label lbFTPLocal;
    private System.Windows.Forms.CheckBox cbDisableFTPAnonymous;
    private System.Windows.Forms.CheckBox cbFTPServerLogs;
    private System.Windows.Forms.CheckBox cbFTPServerWrite;
    private System.Windows.Forms.CheckBox cbFTPServerRead;
    private System.Windows.Forms.TextBox tbFTPPath;
    private System.Windows.Forms.Label label54;
    private System.Windows.Forms.RadioButton rbFtpShareLocated;
    private System.Windows.Forms.RadioButton rbFTPLocalLocated;
    private System.Windows.Forms.GroupBox groupBox10;
    private System.Windows.Forms.GroupBox gbFTPLogLocation;
    private System.Windows.Forms.Label label74;
    private System.Windows.Forms.CheckBox cbFTPLogDelete;
    private System.Windows.Forms.Button btFTPLogBrowse;
    private System.Windows.Forms.TextBox tbFTPLogLocation;
    private System.Windows.Forms.GroupBox gbFTPLogSchedule;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.NumericUpDown nudFTPLogSize;
    private System.Windows.Forms.RadioButton rbFTPLogSizeReach;
    private System.Windows.Forms.RadioButton rbFTPLogUnlimit;
    private System.Windows.Forms.RadioButton rbFTPLogMonth;
    private System.Windows.Forms.RadioButton rbFTPLogWeek;
    private System.Windows.Forms.RadioButton rbFTPLogDay;
    private System.Windows.Forms.RadioButton rbFTPLogHour;
    private System.Windows.Forms.ComboBox cboFTPLogFormat;
    private System.Windows.Forms.CheckBox cbFTPLoggingOnOff;
    private System.Windows.Forms.Label label52;
    private System.Windows.Forms.CheckBox checkBox38;
    private System.Windows.Forms.CheckBox cbUDP;
    private System.Windows.Forms.CheckBox cbTCP;
    private System.Windows.Forms.PictureBox TTtcpUdp;
    private System.Windows.Forms.Label lbFwPort;
    private System.Windows.Forms.Label lbFwName;
    private System.Windows.Forms.TextBox tbFwPortnr;
    private System.Windows.Forms.TextBox tbFwName;
    private System.Windows.Forms.CheckBox cbFwAddPort;
    private System.Windows.Forms.Button btFwAdd;
    private System.Windows.Forms.Label label35;
    private System.Windows.Forms.CheckBox cbFwWebServerHTTPs;
    private System.Windows.Forms.TextBox tbFwProgramPath;
    private System.Windows.Forms.Button btFwBrowse;
    private System.Windows.Forms.CheckBox cbFwSqlServer;
    private System.Windows.Forms.CheckBox cbFwWebServerHTTP;
    private System.Windows.Forms.CheckBox cbFwFtpServer;
    private System.Windows.Forms.CheckBox cbFwRemoteDesktop;
    private System.Windows.Forms.CheckBox cbFwPcAnywhere;
    private System.Windows.Forms.CheckBox checkBox40;
    private System.Windows.Forms.CheckBox checkBox39;
    private System.Windows.Forms.Button btModifySQLUser;
    private System.Windows.Forms.GroupBox gbChangeSaPass;
    private System.Windows.Forms.CheckBox cbSqlSavePassToLog;
    private System.Windows.Forms.CheckBox cbSqlRandomPass;
    private System.Windows.Forms.TextBox tbSaConfPass;
    private System.Windows.Forms.TextBox tbSaPass;
    private System.Windows.Forms.Label label75;
    private System.Windows.Forms.Label label68;
    private System.Windows.Forms.CheckBox cbSqlChangeSaPass;
    private System.Windows.Forms.TextBox tbSqlCurrentSaPass;
    private System.Windows.Forms.Label label67;
    private System.Windows.Forms.RadioButton rbSqlMixMode;
    private System.Windows.Forms.Label label66;
    private System.Windows.Forms.RadioButton rbSqlWinAuthenMode;
    private Actemium.WiSSWizard.Pages.BaseWiSSWizardPage wpNetworkConfigure;
    private System.Windows.Forms.Label label76;
    private System.Windows.Forms.Label lbFwAppLoc;
    private System.Windows.Forms.CheckBox cbMailSrvConfOnOrOff;
    private System.Windows.Forms.GroupBox gbMailSrvConfigure;
    private System.Windows.Forms.CheckBox cbMailSrvAllowAnonym;
    private System.Windows.Forms.TabControl tabControl3;
    private System.Windows.Forms.TabPage tpIpConfig;
    private System.Windows.Forms.GroupBox gbUseStaticIPAddress;
    private System.Windows.Forms.RadioButton rbIPManual;
    private System.Windows.Forms.RadioButton rbIPAutoObtain;
    private System.Windows.Forms.TextBox tbDefaultGateway;
    private System.Windows.Forms.TextBox tbSubnetMask;
    private System.Windows.Forms.TextBox tbIPaddress;
    private System.Windows.Forms.Label lbDefaultGateway;
    private System.Windows.Forms.Label lbSubnetMask;
    private System.Windows.Forms.Label lbIPaddress;
    private System.Windows.Forms.GroupBox gbDNSServers;
    private System.Windows.Forms.TextBox tbDNSAlt;
    private System.Windows.Forms.TextBox tbDNSPre;
    private System.Windows.Forms.Label lbDNSAlt;
    private System.Windows.Forms.Label lbDNSPre;
    private System.Windows.Forms.RadioButton rbDNSManual;
    private System.Windows.Forms.RadioButton rbDNSAuto;
    private System.Windows.Forms.TabPage tabPage7;
    private System.Windows.Forms.Button btRemoveWirelessNet;
    private System.Windows.Forms.Button btAddWirelessNet;
    private System.Windows.Forms.Button btWirelessConnect;
    private System.Windows.Forms.ListView lvWirelessNetworkAvailable;
    private System.Windows.Forms.CheckBox cbFwAddApplication;
    private System.Windows.Forms.Label label111;
    private System.Windows.Forms.Label label78;
    private System.Windows.Forms.PictureBox pbConfigCheck18;
    private System.Windows.Forms.PictureBox pbConfigCheck17;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Button btRemoveWebSrv;
    private System.Windows.Forms.Label label130;
    private System.Windows.Forms.ComboBox cbNicAdapter;
    private System.Windows.Forms.Button btAddWebSrv;
    private System.Windows.Forms.Label lbMailSrvNotDefault;
    private System.Windows.Forms.TextBox tbMailSrvNotDefault;
    private System.Windows.Forms.GroupBox gbMailSrvRelay;
    private System.Windows.Forms.CheckBox cbMailSrvRelayAllowSuccessAuthen;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.ListView listView2;
    private System.Windows.Forms.Label label132;
    private System.Windows.Forms.RadioButton rbMailSrvRelayAllExceptListBelow;
    private System.Windows.Forms.RadioButton rbMailSrvRelayOnlyListBelow;
    private System.Windows.Forms.CheckBox cbMailSrvRelay;
    private System.Windows.Forms.Button btRemoveFtpSrv;
    private System.Windows.Forms.Button btAddFtpSrv;
    private System.Windows.Forms.GroupBox gbMailSrvLogging;
    private System.Windows.Forms.GroupBox gbMailSrvLogDir;
    private System.Windows.Forms.CheckBox cbMailLogDelete;
    private System.Windows.Forms.Button btMailLogBrowse;
    private System.Windows.Forms.TextBox tbMailLogLocation;
    private System.Windows.Forms.GroupBox gbMailLoggingSchedule;
    private System.Windows.Forms.Label label80;
    private System.Windows.Forms.NumericUpDown nudMailLogSize;
    private System.Windows.Forms.RadioButton rbMailLogSizeReach;
    private System.Windows.Forms.RadioButton rbMailLogUnlimitedSize;
    private System.Windows.Forms.RadioButton rbMailLogMonth;
    private System.Windows.Forms.RadioButton rbMailLogWeek;
    private System.Windows.Forms.RadioButton rbMailLogDay;
    private System.Windows.Forms.RadioButton rbMailLogH;
    private System.Windows.Forms.ComboBox cboMailActiveLogFormat;
    private System.Windows.Forms.CheckBox cbLoggingMailOnOff;
    private System.Windows.Forms.Label label82;
    private System.Windows.Forms.Button btIISBrowse;
    private System.Windows.Forms.Button btIISServiceLogin;
    private System.Windows.Forms.Label lbIISPass;
    private System.Windows.Forms.TextBox tbIISCustomAccountPass;
    private System.Windows.Forms.TextBox tbIISCustomAccount;
    private System.Windows.Forms.RadioButton rbIIsAccountSelect;
    private System.Windows.Forms.RadioButton rbIISLocalSystemAccount;
    private System.Windows.Forms.TextBox tbCurrentNoOfSavedPw;
    private System.Windows.Forms.TextBox tbCurrentMinimumPwLength;
    private System.Windows.Forms.TextBox tbCurrentMinimumPwAge;
    private System.Windows.Forms.TextBox tbCurrentMaximumPwAge;
    private System.Windows.Forms.ListBox listBCurrentIPSettings;
    private System.Windows.Forms.ListView listVSharedFolders;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.ColumnHeader columnHeader6;
    private System.Windows.Forms.ColumnHeader columnHeader8;
    private System.Windows.Forms.GroupBox gbAddAdminAndActemiumUsers;
    private System.Windows.Forms.CheckBox cbRandomPWAdmin;
    private System.Windows.Forms.Label lbPWcomfimAdmin;
    private System.Windows.Forms.Label lbPWAdmin;
    private System.Windows.Forms.TextBox tbPWcomfimAdmin;
    private System.Windows.Forms.TextBox tbPWAdmin;
    private System.Windows.Forms.CheckBox cbCreateAdminUser;
    private System.Windows.Forms.CheckBox cbRandomPWActemium;
    private System.Windows.Forms.Label lbPWcomfimActemium;
    private System.Windows.Forms.Label lbPWActemium;
    private System.Windows.Forms.TextBox tbPWcomfimActemium;
    private System.Windows.Forms.TextBox tbPWActemium;
    private System.Windows.Forms.CheckBox cbCreateActemiumUser;
    private System.Windows.Forms.GroupBox groupBox11;
    private System.Windows.Forms.CheckedListBox chkListBUserGroups;
    private System.Windows.Forms.Button btAddUser;
    private System.Windows.Forms.TextBox tbAddUserPasword2;
    private System.Windows.Forms.Label label31;
    private System.Windows.Forms.TextBox tbAddUserPasword1;
    private System.Windows.Forms.Label label30;
    private System.Windows.Forms.TextBox tbAddUserDescription;
    private System.Windows.Forms.Label label29;
    private System.Windows.Forms.TextBox tbAddUserFullName;
    private System.Windows.Forms.Label label28;
    private System.Windows.Forms.TextBox tbAddUserUserName;
    private System.Windows.Forms.Label label27;
    private System.Windows.Forms.Label lbNoteListOfInstalledSoftware;
    private System.Windows.Forms.Label lbNoteExlaintListOfInstalledSoftware;
    private System.Windows.Forms.ListView lvWebservers;
    private System.Windows.Forms.Button btSetIp;
    private System.Windows.Forms.RadioButton rbPortOutbound;
    private System.Windows.Forms.RadioButton rbPortInbound;
    private System.Windows.Forms.GroupBox groupBox13;
    private System.Windows.Forms.Button btFwAddProgram;
    private System.Windows.Forms.RadioButton rbFwProgramOutbound;
    private System.Windows.Forms.RadioButton rbFwProgramInbound;
    private System.Windows.Forms.Button btFwModify;
    private System.Windows.Forms.Button btGetCurrentPasswordPolicies;
    private System.Windows.Forms.Button btGetAllCurrentAuditPolicies;
    private System.Windows.Forms.TextBox tbAuditSystemEvents;
    private System.Windows.Forms.TextBox tbAuditProcessTracking;
    private System.Windows.Forms.TextBox tbAuditPrivilegeUse;
    private System.Windows.Forms.TextBox tbAuditPolicyChange;
    private System.Windows.Forms.TextBox tbAuditObjectAccess;
    private System.Windows.Forms.TextBox tbAuditLogEvents;
    private System.Windows.Forms.TextBox tbAuditDirSerAccess;
    private System.Windows.Forms.TextBox tbAuditAccManage;
    private System.Windows.Forms.TextBox tbAuditAccLogEvents;
    






  }
}