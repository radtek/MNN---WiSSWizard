using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Actemium.Diagnostics;
using Actemium.WiSSWizard.Support;

namespace Actemium.WiSSWizard
{
  public class ScriptHandling
  {
    const string CLASSNAME = "ScriptHandling";
    private List<UserGroup> _allLocalGroups = new List<UserGroup>();

    private List<string> _allCurrentWindowsSettings = new List<string>();    
    private List<string> _allCurrentIPSetting = new List<string>();
    private List<ExistedUser> _allLocalUsers = new List<ExistedUser>();
    private List<string> _allLocalUserInfo = new List<string>();
    private List<string> _listOfUsersInRDU = new List<string>();
    private List<string> _listOfGlobalGroups = new List<string>();
    private List<string> _allLocalFireWallExceptions = new List<string>();
    private List<string> _allFireWallUsingPorts = new List<string>();
    private List<string> _membersOfRemoteDesktop = new List<string>();
    private List<string> _membersOfAdministrators = new List<string>();
    private FileStream _fileStream = null;
    private StreamWriter _streamWriter = null;
    private List<string> _registrySettings = new List<string>();
    private ConfigClass _configClass;
    private bool triedOnceturnOnSystemRestore = false;

    public ScriptHandling()
    {
      CreateTempPSfile(OSVersions.AllOS, "");
    }
    public ScriptHandling(ConfigClass configClass)
    {
      _configClass = configClass;
      CreateTempPSfile(OSVersions.AllOS, "");
    }

    public void CreateTempPSfile(OSVersions os, string script)
    {
      Directory.SetCurrentDirectory(Path.GetDirectoryName(Application.ExecutablePath));
      string directoryString = Path.GetDirectoryName(Application.ExecutablePath) + @"\Temp";
      string path = "";

      try
      {
        DirectoryInfo di = Directory.CreateDirectory(directoryString);
        di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;

        if (script != "")
        {

          path = directoryString + @"\temp.ps1";
          File.Delete(path);
          try
          {
            using (_fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
              using (_streamWriter = new StreamWriter(_fileStream))
              {
                String command = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, script);
                _streamWriter.WriteLine(command);
              }
            }
          }

          catch (IOException ex)
          {
            Trace.WriteError("({0})", "CreateTempPSfile", CLASSNAME, ex, script);

          }
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "Create temporary  PowerShell scriptfile", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Create temporary  PowerShell scriptfile", ex.Message));
      }
    }

    public List<string> GetWindowsRestorePoints()
    {
      List<string> restorePoints = new List<string>();
      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())//;
        {

          runspace.Open();
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("get-computerrestorepoint | format-table SequenceNumber, Description -auto");
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          StringBuilder stringBuilder = new StringBuilder();

          foreach (PSObject str in results)
          {
            stringBuilder.AppendLine(str.ToString());
            string all = stringBuilder.ToString();
            string[] split = all.Split('\n');
            foreach (string item in split)
            {
              string st = item.Trim(new char[] { '\t', ' ', '\r', '\n' });
              restorePoints.Add(st);
            }
          }
        }
      }
      catch (MethodInvocationException ex)
      {
        Trace.WriteError("({0})", "GetWindowsRestorePoints", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Get Windows Restore Points", ex.Message));

      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "GetWindowsRestorePoints", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Get Windows Restore Points", ex.Message));

      }
      return restorePoints;

    }
    public void CreateWindowsRestorePoint(string description)
    {

      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          try
          {
            Pipeline pipeline = runspace.CreatePipeline();


            pipeline.Commands.AddScript("checkpoint-computer -description \"" + description + "\"");
            pipeline.Commands.Add("Out-String");

            // execute the script
            Collection<PSObject> results = pipeline.Invoke();
          }
          catch (MethodInvocationException ex)
          {
            Trace.WriteError("({0})", "CreateWindowsRestorePoint", CLASSNAME, ex);
            _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Create Windows Restore Point", ex.Message));
          }
          catch (Exception ex)
          {
            Trace.WriteError("({0})", "CreateWindowsRestorePoint", CLASSNAME, ex);
            _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Create Windows Restore Point", ex.Message));
          }
        }
      }
      catch (Exception ex)
      {
        if (!triedOnceturnOnSystemRestore)
        {
          DialogResult result = MessageBox.Show("Windows system recovery may be disabled \n If you want System Restore, you will first have to turn it on and try again", "Windows System Restore off", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
          if (result == System.Windows.Forms.DialogResult.Retry)
          {
            triedOnceturnOnSystemRestore = true;
            CreateWindowsRestorePoint(description);
          }
        }
        else
        {
          MessageBox.Show("Restore Point is not possible");
        }

        Trace.WriteError("({0})", "Create Windows Restore Point", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Create Windows Restore Point", ex.Message));
      }
    }
    public void RestoreSettings(string restorePointNr)
    {
      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())//;
        {
          runspace.Open();
          try
          {
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript("restore-computer -RestorePoint " + restorePointNr);
            pipeline.Commands.Add("Out-String");

            // execute the script
            Collection<PSObject> results = pipeline.Invoke();
          }
          catch (MethodInvocationException ex)
          {
            Trace.WriteError("({0})", "RestoreSettings", CLASSNAME, ex);
            _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Restore settings to latest Restore Point", ex.Message));

          }
          catch (Exception ex)
          {
            Trace.WriteError("({0})", "RestoreSettings", CLASSNAME, ex);
            _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Restore settings to latest Restore Point", ex.Message));

          }
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "Restore settings to latest Restore Point", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Restore settings to latest Restore Point", ex.Message));
      }
    }
    public bool RunINFfilePasswordAndControlPolicy(string infFile)
    {
      try
      {
        string command = "SECEDIT /configure /db secedit.sdb /cfg " + "\"" + infFile + "\"";
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
        }
        return true;
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "RunINFfilePasswordAndControlPolicy", CLASSNAME, ex, infFile);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Run INFfile Password And ControlPolicy", ex.Message));

        return false;
      }
    }
    #region Password policies and Audit Policies Properties
    public string MinimumPasswordAge
    {
      get
      { return _minimumPasswordAge; }
      set
      { _minimumPasswordAge = value; }
    }private string _minimumPasswordAge = "";

    public string MaximumPasswordAge
    {
      get
      { return _maximumPasswordAge; }
      set
      { _maximumPasswordAge = value; }
    }private string _maximumPasswordAge = "";

    public string MinimumPasswordLength
    {
      get
      { return _minimumPasswordLength; }
      set
      { _minimumPasswordLength = value; }
    }private string _minimumPasswordLength = "";

    public bool PasswordComplexity
    {
      get
      { return _passwordComplexity; }
      set
      { _passwordComplexity = value; }
    }private bool _passwordComplexity = false;

    public string PasswordHistorySize
    {
      get
      { return _passwordHistorySize; }
      set
      { _passwordHistorySize = value; }
    }private string _passwordHistorySize = "";

    public bool ClearTextPassword
    {
      get
      { return _clearTextPassword; }
      set
      { _clearTextPassword = value; }
    }private bool _clearTextPassword = false;

    public string AuditSystemEvents
    {
      get
      { return _auditSystemEvents; }
      set
      { _auditSystemEvents = value; }
    }private string _auditSystemEvents = "";

    public string AuditLogonEvents
    {
      get
      { return _auditLogonEvents; }
      set
      { _auditLogonEvents = value; }
    }private string _auditLogonEvents = "";

    public string AuditObjectAccess
    {
      get
      { return _auditObjectAccess; }
      set
      { _auditObjectAccess = value; }
    }private string _auditObjectAccess = "";

    public string AuditPrivilegeUse
    {
      get
      { return _auditPrivilegeUse; }
      set
      { _auditPrivilegeUse = value; }
    }private string _auditPrivilegeUse = "";

    public string AuditPolicyChange
    {
      get
      { return _auditPolicyChange; }
      set
      { _auditPolicyChange = value; }
    }private string _auditPolicyChange = "";

    public string AuditAccountManage
    {
      get
      { return _auditAccountManage; }
      set
      { _auditAccountManage = value; }
    }private string _auditAccountManage = "";

    public string AuditProcessTracking
    {
      get
      { return _auditProcessTracking; }
      set
      { _auditProcessTracking = value; }
    }private string _auditProcessTracking = string.Empty;

    public string AuditDSAccess
    {
      get
      { return _auditDSAccess; }
      set
      { _auditDSAccess = value; }
    }private string _auditDSAccess = "";

    public string AuditAccountLogon
    {
      get
      { return _auditAccountLogon; }
      set
      { _auditAccountLogon = value; }
    }private string _auditAccountLogon = "";

    #endregion Password policies and Audit Policies Properties

    public void GetPWPoliciesAndAuditPolicies()
    {
      const string FUNCTIONNAME="GetPWPoliciesAndAuditPolicies";
      try
      {
        string infFile = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\PasswordAndAuditPolicies.INF";
        string command = "SECEDIT /export /areas SECURITYPOLICY /cfg " + "\"" + infFile + "\"";
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
        }
        FileHandling _fileHandling = new FileHandling();
        List<string> passwordPolicy = new List<string>();
        passwordPolicy = _fileHandling.ReadInLogFile(infFile, "[System Access]", "[Event Audit]");
        foreach (string str in passwordPolicy)        
        {
          string[] split = str.Split(' ');          
          for (int i = 0; i < split.Length - 1; i++)
          {
            if (split[i].Contains("MinimumPasswordAge"))
              _minimumPasswordAge = split[i + 2];
            else if (split[i].Contains("MaximumPasswordAge"))
              _maximumPasswordAge = split[i + 2];
            else if (split[i].Contains("MinimumPasswordLength"))
              _minimumPasswordLength = split[i + 2];
            else if (split[i].Contains("PasswordComplexity"))
            {
              string passwordValue = split[i + 2];
              if (passwordValue == "1")
                _passwordComplexity = true;
              else if (passwordValue == "0")
                _passwordComplexity = false;
            }
            else if (split[i].Contains("PasswordHistorySize"))
              _passwordHistorySize = split[i + 2];
            else if (split[i].Contains("ClearTextPassword"))
            {
              string clearTextValue = split[i + 2];
              if (clearTextValue == "1")
                _clearTextPassword = true;
              else if (clearTextValue == "0")
                _clearTextPassword = false;
            }
              
          }        
        }
        List<string> auditPolicy = new List<string>();
        auditPolicy = _fileHandling.ReadInLogFile(infFile, "[Event Audit]", "[Registry Values]");
        foreach (string strAudit in auditPolicy)
        {
          string[] splitAudit = strAudit.Split(' ');
          for (int i = 0; i < splitAudit.Length - 1; i++)
          {
            if (splitAudit[i].Contains("AuditSystemEvents"))
            {
              string auditValue = splitAudit[i + 2];
              if (auditValue == "0")
                _auditSystemEvents = "No auditing";
              else if (auditValue == "1")
                _auditSystemEvents = "Success";
              else if (auditValue == "2")
                _auditSystemEvents = "Failure";
              else if (auditValue == "3")
                _auditSystemEvents = "Success, Failure";
            }
            else if (splitAudit[i].Contains("AuditLogonEvents"))
            {
              string auditValue = splitAudit[i + 2];
              if (auditValue == "0")
                _auditLogonEvents = "No auditing";
              else if (auditValue == "1")
                _auditLogonEvents = "Success";
              else if (auditValue == "2")
                _auditLogonEvents = "Failure";
              else if (auditValue == "3")
                _auditLogonEvents = "Success, Failure";
            }
            else if (splitAudit[i].Contains("AuditObjectAccess"))
            {
              string auditValue = splitAudit[i + 2];
              if (auditValue == "0")
                _auditObjectAccess = "No auditing";
              else if (auditValue == "1")
                _auditObjectAccess = "Success";
              else if (auditValue == "2")
                _auditObjectAccess = "Failure";
              else if (auditValue == "3")
                _auditObjectAccess = "Success, Failure";
            }
            else if (splitAudit[i].Contains("AuditPrivilegeUse"))
            {
              string auditValue = splitAudit[i + 2];
              if (auditValue == "0")
                _auditPrivilegeUse = "No auditing";
              else if (auditValue == "1")
                _auditPrivilegeUse = "Success";
              else if (auditValue == "2")
                _auditPrivilegeUse = "Failure";
              else if (auditValue == "3")
                _auditPrivilegeUse = "Success, Failure";
            }
            else if (splitAudit[i].Contains("AuditPolicyChange"))
            {
              string auditValue = splitAudit[i + 2];
              if (auditValue == "0")
                _auditPolicyChange = "No auditing";
              else if (auditValue == "1")
                _auditPolicyChange = "Success";
              else if (auditValue == "2")
                _auditPolicyChange = "Failure";
              else if (auditValue == "3")
                _auditPolicyChange = "Success, Failure";
            }
            else if (splitAudit[i].Contains("AuditAccountManage"))
            {
              string auditValue = splitAudit[i + 2];
              if (auditValue == "0")
                _auditAccountManage = "No auditing";
              else if (auditValue == "1")
                _auditAccountManage = "Success";
              else if (auditValue == "2")
                _auditAccountManage = "Failure";
              else if (auditValue == "3")
                _auditAccountManage = "Success, Failure";
            }
            else if (splitAudit[i].Contains("AuditProcessTracking"))
            {
              string auditValue = splitAudit[i + 2];
              if (auditValue == "0")
                _auditProcessTracking = "No auditing";
              else if (auditValue == "1")
                _auditProcessTracking = "Success";
              else if (auditValue == "2")
                _auditProcessTracking = "Failure";
              else if (auditValue == "3")
                _auditProcessTracking = "Success, Failure";
            }
            else if (splitAudit[i].Contains("AuditDSAccess"))
            {
              string auditValue = splitAudit[i + 2];
              if (auditValue == "0")
                _auditDSAccess = "No auditing";
              else if (auditValue == "1")
                _auditDSAccess = "Success";
              else if (auditValue == "2")
                _auditDSAccess = "Failure";
              else if (auditValue == "3")
                _auditDSAccess = "Success, Failure";
            }
            else if (splitAudit[i].Contains("AuditAccountLogon"))
            {
              string auditValue = splitAudit[i + 2];
              if (auditValue == "0")
                _auditAccountLogon = "No auditing";
              else if (auditValue == "1")
                _auditAccountLogon = "Success";
              else if (auditValue == "2")
                _auditAccountLogon = "Failure";
              else if (auditValue == "3")
                _auditAccountLogon = "Success, Failure";
            }
          }
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", FUNCTIONNAME, CLASSNAME);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Get all Password And ControlPolicy", ex.Message));
      }

    }

    [XmlIgnoreAttribute()]
    public List<UserGroup> GetAllLocalUsersGroups
    {
      get
      {
        return _allLocalGroups;
      }
    }
    public List<string> ListOfUsersInRDU
    {
      get { return _listOfUsersInRDU; }
      set { _listOfUsersInRDU = value; }
    }
    public List<string> ShowAllCurrentIPSettings
    {
      get
      {
        return _allCurrentIPSetting;
      }
    }

    public void SetAutoIpAddresses(string caption)
    {
      const string FUNCTIONNAME = "SetAutoIpAddresses";
      try
      {
        Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          CreateTempPSfile(OSVersions.AllOS, "SetAutoIpAddresses");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1 -caption " + "\"" + caption + "\"";
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
        }
      }
      catch (Exception ex)
      {

        Trace.WriteError("()", FUNCTIONNAME, CLASSNAME, ex);
        throw;
      }
    }
    public void SetStaticIPAddresses(string ipAdress, string subnetMask, string defaultGateway, List<string> DnsServers, string caption)
    {
      const string FUNCTIONNAME = "SetStaticIPAddresses";
      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())//;
        {
          runspace.Open();
          CreateTempPSfile(OSVersions.AllOS, "SetStaticIPAddressAndDNS");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1 -staticIP " + "\"" + ipAdress + "\"" + " -subnetMask " + "\"" + subnetMask + "\"" + " -gateway " + "\"" + defaultGateway + "\"" + " -caption " + "\"" + caption + "\"";
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();

        }
        //did it wrong here, need improve next version (this method will only add string to primary DNS)
        foreach (string dnsString in DnsServers)
          SetStaticDnsAddresses(dnsString, caption);


      }
      catch (MethodInvocationException ex)
      {
        Trace.WriteError("({0},{1},{2},{3})", FUNCTIONNAME, CLASSNAME, ex, ipAdress, subnetMask, defaultGateway, DnsServers);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Put set of IP addresses to system", ex.Message));

      }
      catch (Exception ex)
      {
        Trace.WriteError("({0},{1},{2},{3})", FUNCTIONNAME, CLASSNAME, ex, ipAdress, subnetMask, defaultGateway, DnsServers);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Put set of IP Addresses to system", ex.Message));
      }

    }
    public void SetStaticDnsAddresses(string dnsServers, string dnsCaption)
    {
      const string FUNCTIONNAME = "SetStaticDnsAddresses";
      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())//;
        {
          runspace.Open();
          CreateTempPSfile(OSVersions.AllOS, "SetStaticDNSAddresses");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1 -DnsServers " + "\"" + dnsServers + "\"" + " -caption " + "\"" + dnsCaption + "\"";
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
        }
      }
      catch (MethodInvocationException ex)
      {
        Trace.WriteError("({0})", FUNCTIONNAME, CLASSNAME, ex, dnsServers);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Put set of IP addresses to system", ex.Message));
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", FUNCTIONNAME, CLASSNAME, ex, dnsServers);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Put set of IP Addresses to system", ex.Message));
      }
    }
    public List<string> ShowAllCurrentWindowsSettings
    {
      get
      { return _allCurrentWindowsSettings; }
    }
    public List<string> ListOfGlobalGroup
    {
      get { return _listOfGlobalGroups; }
      set { _listOfGlobalGroups = value; }
    }
    public void putAllLocalGroupsToList()
    {
      try
      {
        _allLocalGroups.Clear();
        PrincipalContext insPrincipalContext = new PrincipalContext(ContextType.Machine);
        GroupPrincipal insGroupPrincipal = new GroupPrincipal(insPrincipalContext);
        insGroupPrincipal.Name = "*";
        PrincipalSearcher insPrincipalSearcher = new PrincipalSearcher();
        insPrincipalSearcher.QueryFilter = insGroupPrincipal;
        PrincipalSearchResult<Principal> results = insPrincipalSearcher.FindAll();
        if (insGroupPrincipal != null)
        {
          foreach (Principal p in results)
          {
            UserGroup group = new UserGroup(p.Name, p.Description);
            _allLocalGroups.Add(group);
          }
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "Put Local groups to list of local groups", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Put Local groups to list of local groups", ex.Message));

      }
    }
    /// <summary>
    /// Add global group to remote desktop users
    /// Check before add a global group
    /// </summary>
    /// <param name="groupsToRemoteDesktopUsers">name of global group</param>
    public void addGroupsToRemoteDesktopUsers(string groupsToRemoteDesktopUsers)
    {
      try
      {
        bool isInGroup = false;
        foreach (string str in ListOfUsersInRDU)
        {
          if (str == groupsToRemoteDesktopUsers)
          {
            isInGroup = true;
            break;
          }
        }
        if (!isInGroup)
        {
          using (Runspace runspace = RunspaceFactory.CreateRunspace())//;
          {
            runspace.Open();
            CreateTempPSfile(OSVersions.AllOS, "addGroupsToRemoteDesktop");
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
            string command = @".\Temp\temp.ps1 -GlobalGroup " + "\"" + groupsToRemoteDesktopUsers + "\"";
            pipeline.Commands.AddScript(command);
            pipeline.Commands.Add("Out-String");
            // execute the script
            Collection<PSObject> results = pipeline.Invoke();

          }
        }
      }
      catch (MethodInvocationException ex)
      {
        Trace.WriteError("({0})", "putGroupsToRemoteDesktopUsers", CLASSNAME, ex, groupsToRemoteDesktopUsers);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Put groups to remote desktop users", ex.Message));

      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "putGroupsToRemoteDesktopUsers", CLASSNAME, ex, groupsToRemoteDesktopUsers);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Put groups to remote desktop users", ex.Message));
      }

    }
    public void CreateUserGroups(string name, string description)
    {

      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())//;
        {
          runspace.Open();
          CreateTempPSfile(OSVersions.AllOS, "addLocalGroup");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          pipeline.Commands.AddScript(".\\Temp\\temp.ps1 -localGroupName \"" + name + "\" -description \"" + description + "\"");
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();

        }
      }
      catch (MethodInvocationException ex)
      {
        Trace.WriteError("({0},{1})", "CreateUserGroups", CLASSNAME, ex, name, description);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Create user group", ex.Message));

      }
      catch (Exception ex)
      {
        Trace.WriteError("({0},{1})", "CreateUserGroups", CLASSNAME, ex, name, description);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Create user group", ex.Message));
      }

    }

    /// <summary>
    /// Do the powershell script and get all current windows settings including settings for autoplay
    /// </summary>
    public void ShowCurrentWindowsSettings()
    {
      const string FUNCTIONNAME = "ShowCurrentWindowsSettings";

      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
          CreateTempPSfile(OSVersions.AllOS, "ShowCurrentWindowsExplorerSettings");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1";
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
          if (results.Count > 1)
            throw new ApplicationException("Got more then 1 result when getting Control Policy settings from powershell");

          string resultString = results[0].ToString();
          string[] resultStringSplitted = resultString.Split('\n');
          foreach (string resultLine in resultStringSplitted)
          {
            // Ignore line that we don't need
            if (resultLine != "\r" && !string.IsNullOrEmpty(resultLine))
              _allCurrentWindowsSettings.Add(resultLine);
          }
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("()", FUNCTIONNAME, CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Show Current Control Policy", ex.Message));
      }

    }

    public void DeleteUser(string UserName)
    {
      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          CreateTempPSfile(OSVersions.AllOS, "DeleteUser");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1 -UserName " + "\"" + UserName + "\"";

          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
        };
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "Delete User", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Delete User", ex.Message));

      }
    }

    /// <summary>
    /// Get all information about NICs that available 
    /// </summary>
    public void ShowCurrentIPSetting()
    {
      const string FUNCTIONNAME = "ShowCurrentIPSetting";
      _allCurrentIPSetting.Clear();
      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
          CreateTempPSfile(OSVersions.AllOS, "ShowCurrentIPSetting");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1";
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");
          // execute the script

          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();

          if (results.Count > 1)
            throw new ApplicationException("Got more then 1 result when getting IP settings from powershell");

          string resultString = results[0].ToString();
          string[] resultStringSplitted = resultString.Split('\n');
          foreach (string resultLine in resultStringSplitted)
          {
            // Ignore line that we don't need
            if (resultLine != "\r" && !string.IsNullOrEmpty(resultLine))
            {
              string lineChosen = resultLine;
              if (lineChosen.Contains("\r"))
                lineChosen = lineChosen.Substring(0, lineChosen.Length - 1);
              _allCurrentIPSetting.Add(lineChosen);
            }
          }
        }
      }

      catch (Exception ex)
      {
        Trace.WriteError("()", FUNCTIONNAME, CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Show Current Ip Config", ex.Message));
      }
    }

    public void ShowListOfUsersInRDU()
    {
      const string FUNCTIONNAME = "ShowListOfUsersInRDU";
      _listOfUsersInRDU.Clear();
      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
          CreateTempPSfile(OSVersions.AllOS, "getListOfUsersInRDU");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1";
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");
          // execute the script

          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();

          if (results.Count > 1)
            throw new ApplicationException("Got more then 1 result when getting list of users in RDU from powershell");

          string resultString = results[0].ToString();
          string[] resultStringSplitted = resultString.Split('\n');
          foreach (string resultLine in resultStringSplitted)
          {
            // Ignore line that we don't need
            if (resultLine != "\r" && !string.IsNullOrEmpty(resultLine))
              _listOfUsersInRDU.Add(resultLine);
          }
        }
      }

      catch (Exception ex)
      {
        Trace.WriteError("()", FUNCTIONNAME, CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "ShowListOfUsersInRDU", ex.Message));
      }
    }
    public void DeleteUserGroup(string UserGroupName)
    {
      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          CreateTempPSfile(OSVersions.AllOS, "DeleteUserGroup");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1 -localGroupName " + "\"" + UserGroupName + "\"";

          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
        };
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "Delete usergroup", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Delete usergroup", ex.Message));

      }
    }

    [XmlIgnoreAttribute]
    public List<ExistedUser> GetAllLocalUsers
    {
      get
      {
        return _allLocalUsers;
      }
    }
    public void putAllLocalUsersToList()
    {
      try
      {
        _allLocalUsers.Clear();
        PrincipalContext PrincipalContext = new PrincipalContext(ContextType.Machine);
        UserPrincipal userPrincipal = new UserPrincipal(PrincipalContext);
        userPrincipal.Name = "*";
        PrincipalSearcher principalSearcher = new PrincipalSearcher();
        principalSearcher.QueryFilter = userPrincipal;
        PrincipalSearchResult<Principal> results = principalSearcher.FindAll();
        if (userPrincipal != null)
        {
          foreach (Principal p in results)
          {
            ExistedUser user = new ExistedUser(p.Name, p.DisplayName, p.Description);
            _allLocalUsers.Add(user);

          }

        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "Put local users to list", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Put local users to list", ex.Message));

      }


    }

    public void CreateUser(string name, string fullname, string description, List<string> group, int ChangePwNextLogon, int PasswordCantBeChanged, int PasswordNeverExpires, int AccountDisabled, string Password)
    {
      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          string computer = "localhost";

          CreateTempPSfile(OSVersions.AllOS, "addUser");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1 -computer " + computer + " -user \"" + name + "\" -fullname \"" + fullname + "\" -description \"" + description + "\" -group \"" + group + "\" -password " + "\"" + Password + "\"" + " -CNL " + ChangePwNextLogon.ToString() + " -PCC " + PasswordCantBeChanged.ToString() + " -PNE " + PasswordNeverExpires.ToString() + " -AD " + AccountDisabled.ToString();

          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
        };
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "Create local user", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Create local user", ex.Message));

      }

    }
    /// <summary>
    /// Create user and assign it to multiple groups
    /// </summary>
    /// <param name="name">username</param>
    /// <param name="fullname">Fullname</param>
    /// <param name="description"></param>
    /// <param name="group">groups typeof array of string</param>
    /// <param name="ChangePwNextLogon"></param>
    /// <param name="PasswordCantBeChanged"></param>
    /// <param name="PasswordNeverExpires"></param>
    /// <param name="AccountDisabled"></param>
    /// <param name="Password"></param>

    public bool CheckUserCreated(List<NewUser> newusers)
    {
      try
      {
        List<string> allLocalUserNames = new List<string>();
        foreach (ExistedUser existedUser in _allLocalUsers)
        {
          string name = existedUser.Name.TrimEnd(new[] { ' ' });
          allLocalUserNames.Add(name);
        }
        foreach (NewUser newUser in newusers)
        {

          if (!allLocalUserNames.Contains(newUser.Name))
          {
            return false;
          }
        }
        return true;
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "Check if user is created", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check if user is created", ex.Message));
        return false;
      }


    }
    public bool CheckUserDeleted(List<DeletedUser> deletedusers)
    {
      try
      {
        List<string> allLocalUserNames = new List<string>();
        foreach (ExistedUser existedUser in _allLocalUsers)
        {
          string name = existedUser.Name.TrimEnd(new[] { ' ' });
          allLocalUserNames.Add(name);
        }
        foreach (DeletedUser deletedUser in deletedusers)
        {

          if (allLocalUserNames.Contains(deletedUser.Name))
          {
            return false;
          }
        }
        return true;
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "Check if user is deleted", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check if user is deleted", ex.Message));
        return false;
      }
    }
    public void ModifyUser(string username, string fullname, string description, bool ChangePwNextLogon, bool PasswordCantBeChanged, bool PasswordNeverExpires, bool AccountDisabled, string Password, bool ModifyOtherSettings)
    {
      try
      {
        bool go = true;
        if (username == "Administrator")
        {
          if (!CheckIfUserinGroupAdministratorsExist("Admin"))
          {
            go = false;
            putAllLocalUsersToList();
            foreach (ExistedUser user in _allLocalUsers)
            {
              if (user.Name == "Admin")
              {
                AddUserToGroup("Admin", "Administrators");

                putAllLocalGroupsToList();
                break;

              }
            }

            go = true;
          }
        }
        if (go)
        {
          string Username = username;
          string Description = description;

          string FullName = fullname;
          string newPassword = Password;

          string PasswordChangeAtNextLogon = " -PasswordChangeAtNextLogon";
          string CannotChangePassword = " -CannotChangePassword";
          string passwordNeverExpires = " -PasswordNeverExpires";
          string Disable = " -Disable";
          string ResetAllFlags = " -ResetAllFlags";
          //reset
          // first use $CannotChangePassword (hiermee word PasswordChangeAtNextLogon mee uitgevinkt, wat niet gedaan kan worden door ResetAllFlags)	
          // vervolgens $ResetAllFlags
          string resetRole1 = @".\Temp\temp.ps1 -Username " + "\"" + Username + "\" " + CannotChangePassword;
          string resetRole2 = @".\Temp\temp.ps1 -Username " + "\"" + Username + "\" " + ResetAllFlags;
          string command = @".\Temp\temp.ps1 -Username " + "\"" + Username + "\"";

          if (fullname.Length != 0)
          {
            command += " -Fullname " + "\"" + FullName + "\"";
          }
          if (description.Length != 0)
          {
            command += " -Description " + "\"" + Description + "\"";
          }

          if (ModifyOtherSettings)
          {
            if (ChangePwNextLogon)
            {
              command += PasswordChangeAtNextLogon;
            }
            if (PasswordCantBeChanged)
            {
              command += CannotChangePassword;
            }
            if (PasswordNeverExpires)
            {
              command += passwordNeverExpires;
            }
            if (AccountDisabled)
            {
              command += Disable;
            }
          }
          if (Password != "-1")
          {
            command += " -newPassword " + "\"" + Password + "\"";
          }

          using (Runspace runspace = RunspaceFactory.CreateRunspace())
          {
            runspace.Open();
            CreateTempPSfile(OSVersions.AllOS, "modifyUser");
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
            pipeline.Commands.AddScript(resetRole1);
            pipeline.Commands.AddScript(resetRole2);
            pipeline.Commands.AddScript(command);
            pipeline.Commands.Add("Out-String");
            pipeline.Invoke();

            // execute the script
            //Collection<PSObject> results = 
            runspace.Close();
          };

        }
        else
        {
          string errorsetting = "ModfiedUser " + username;
          string errorMessage = "Can not change Administrator while Admin is not a member of Administrators";
          Trace.WriteError("({0})", errorsetting, CLASSNAME, errorMessage);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, errorsetting, errorMessage));
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "Modify user", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Modify user", ex.Message));

      }
    }
    public void AddUserToGroup(string user, string Group)
    {
      bool isingroup = false;
      foreach (string str in putMembersOfGroupToList(Group))
      {
        if (str == user)
        {
          isingroup = true;
          break;
        }
      }
      if (!isingroup)
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          try
          {
            CreateTempPSfile(OSVersions.AllOS, "addUserToGroup");
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
            string command = "";
            command = @".\Temp\temp.ps1 -name " + user + " -toGroup " + "\"" + Group + "\"";
            pipeline.Commands.AddScript(command);
            pipeline.Commands.Add("Out-String");

            // execute the script
            pipeline.Invoke();

          }
          catch (MethodInvocationException ex)
          {
            Trace.WriteError("({0})", "AddUserToGroup", CLASSNAME, ex);
            _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Add user to usergroup", ex.Message));

          }
        };
      }

    }
    public bool CheckIfUserinGroupExist(List<RemoteDesktopUser> membersOfGroup)
    {
      try
      {
        string language = System.Globalization.CultureInfo.CurrentCulture.DisplayName;
        if (language.Contains("Nederland"))
        {
          putMembersOfRemoteDesktopGroupToList("Externe bureaubladgebruikers");
        }
        else
        {
          putMembersOfRemoteDesktopGroupToList("Remote Desktop Users");
        }

        bool check = true;
        bool[] checkArray = new bool[membersOfGroup.Count];
        int count = 0;

        for (int i = 0; i < membersOfGroup.Count; i++)
        {
          checkArray[i] = false;
        }
        foreach (RemoteDesktopUser strUser in membersOfGroup)
        {

          for (int i = 0; i < _membersOfRemoteDesktop.Count; i++)
          {
            if (_membersOfRemoteDesktop[i] == strUser.Name)
            {
              checkArray[count] = true;
              count++;
              break;
            }
          }

        }

        foreach (bool b in checkArray)
        {
          if (b == true)
          {
            check = true;
          }
          else
          {
            check = false;
            break;
          }
        }
        return check;
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "Check if user in usergroup exist", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check if user in usergroup exist", ex.Message));
        return false;
      }

    }
    /// <summary>
    /// Check if groups exist in RDU
    /// </summary>
    /// <param name="groupRemote">group of Remote users</param>
    /// <returns></returns>
    public bool CheckIfGroupInGroupExist(List<RemoteDesktopGroup> groupRemote)
    {
      try
      {
        string language = System.Globalization.CultureInfo.CurrentCulture.DisplayName;
        if (language.Contains("Nederland"))
        {
          putMembersOfRemoteDesktopGroupToList("Externe bureaubladgroeps");
        }
        else
        {
          putMembersOfRemoteDesktopGroupToList("Remote Desktop Groups");
        }

        bool check = true;
        bool[] checkArray = new bool[groupRemote.Count];
        int count = 0;

        for (int i = 0; i < groupRemote.Count; i++)
        {
          checkArray[i] = false;
        }
        foreach (RemoteDesktopGroup str in groupRemote)
        {

          for (int i = 0; i < _membersOfRemoteDesktop.Count; i++)
          {
            if (_membersOfRemoteDesktop[i] == str.Name)
            {
              checkArray[count] = true;
              count++;
              break;
            }
          }

        }
        foreach (bool b in checkArray)
        {
          if (b == true)
          {
            check = true;
          }
          else
          {
            check = false;
            break;
          }
        }
        return check;
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "Check if group exist", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check if group exist", ex.Message));
        return false;
      }

    }
    public bool CheckIfUserinGroupAdministratorsExist(string User)
    {
      try
      {
        putMembersOfRemoteDesktopGroupToList("Administrators");

        bool check = false;

        foreach (string str in _membersOfAdministrators)
        {

          if (str == User)
          {
            check = true;
            break;
          }
        }

        return check;
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "Check if user contains in Administrator group", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check if user contains in Administrator group", ex.Message));
        return false;
      }
    }
    public List<string> GetAllLocalFirewallExceptions
    {
      get
      {
        return _allLocalFireWallExceptions;
      }
    }
    public void putAllLocalFireWallExceptionsToList()
    {
      _allLocalFireWallExceptions.Clear();
      using (Runspace runspace = RunspaceFactory.CreateRunspace())
      {
        runspace.Open();

        try
        {
          CreateTempPSfile(OSVersions.AllOS, "firewallCheckException");

          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");

          pipeline.Commands.AddScript(@".\Temp\temp.ps1");
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          StringBuilder stringBuilder = new StringBuilder();
          foreach (PSObject str in results)
          {
            stringBuilder.AppendLine(str.ToString());
            string all = stringBuilder.ToString();
            string[] split = all.Split('\n');
            string st = "";
            foreach (string item in split)
            {
              st = item.Trim(new char[] { '\t', ' ', '\r', '\n' });
              _allLocalFireWallExceptions.Add(st);
            }

          }
        }
        catch (MethodInvocationException ex)
        {
          Trace.WriteError("({0})", "putAllLocalFireWallExceptionsToList", CLASSNAME, ex);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "putAllLocalFireWallExceptionsToList", ex.Message));

        }
      };
    }
    /// <summary>
    /// Get or set GetAllCurrentFirewallExceptions
    /// </summary>


    public List<string> GetAllCurrentFirewallExceptions
    {
      get { return _getAllCurrentFirewallExceptions; }
      set { _getAllCurrentFirewallExceptions = value; }
    } private List<string> _getAllCurrentFirewallExceptions = new List<string>();


    /// <summary>
    /// Get all the current Firewall Exceptions and put to the list
    /// filtered and trimmed unnecessary lines
    /// </summary>
    public void putCurrentFireWallExceptionsToList()
    {
      _getAllCurrentFirewallExceptions.Clear();
      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();


          CreateTempPSfile(OSVersions.AllOS, "firewallCheckCurrentException");

          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          pipeline.Commands.AddScript(@".\Temp\temp.ps1");
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
          if (results.Count > 1)
            throw new ApplicationException("Got more then 1 result when getting firewall settings from powershell");

          string resultString = results[0].ToString();
          string[] resultStringSplitted = resultString.Split('\n');
          foreach (string resultLine in resultStringSplitted)
          {
            // Ignore line that we don't need
            if (resultLine != "\r" && !string.IsNullOrEmpty(resultLine)
              && resultLine != "-------------------------------------------------------------------\r"
              && resultLine != "Port configuration for Domain profile:\r"
              && resultLine != "Port   Protocol  Mode     Name\r"
              && resultLine != "Port configuration for Standard profile:\r")
            {
              string currentPort = resultLine.Substring(0, 4);
              currentPort = currentPort.Trim();
              string currentProtocol = resultLine.Substring(7, 3);
              string currentMode = resultLine.Substring(17, 6);
              string currentName = resultLine.Substring(26, resultLine.Length - 26);
              if (currentName.Contains("\r"))
                currentName = currentName.Substring(0, currentName.Length - 1);
              if (!_getAllCurrentFirewallExceptions.Contains(currentName + " " + currentProtocol + " " + currentPort))
              _getAllCurrentFirewallExceptions.Add(currentName + " " + currentProtocol + " " + currentPort);

            }
          }
        }
      }
      catch (MethodInvocationException ex)
      {
        Trace.WriteError("({0})", "putAllLocalFireWallExceptionsToList", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "putAllLocalFireWallExceptionsToList", ex.Message));

      }
    }
    /// <summary>
    /// Get or set ListOfAllowedPrograms
    /// </summary>
    public List<string> ListOfAllowedPrograms
    {
      get { return _listOfAllowedPrograms; }
      set { _listOfAllowedPrograms = value; }
    } private List<string> _listOfAllowedPrograms = new List<string>();
    public void putCurrentFireWallProgramsExceptionsToList()
    {
      _listOfAllowedPrograms.Clear();
      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();


          CreateTempPSfile(OSVersions.AllOS, "firewallCheckCurrentExceptionPrograms");

          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          pipeline.Commands.AddScript(@".\Temp\temp.ps1");
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
          if (results.Count > 1)
            throw new ApplicationException("Got more then 1 result when getting firewall settings from powershell");

          string resultString = results[0].ToString();
          string[] resultStringSplitted = resultString.Split('\n');
          foreach (string resultLine in resultStringSplitted)
          {
            // Ignore line that we don't need
            if (resultLine != "\r" && !string.IsNullOrEmpty(resultLine)
              && !resultLine.Contains("Allowed programs configuration for Domain profile:")
              && !resultLine.Contains("Mode     Name / Program")
              && !resultLine.Contains("-------------------------------------------------------------------")
              && !resultLine.Contains("Allowed programs configuration for Standard profile:"))
            {
              string currentProgramName = "";
              string currentProgramPath = "";
              int indexForTrim = resultLine.IndexOf("/");
              currentProgramName = resultLine.Substring(9, indexForTrim - 9);
              currentProgramPath = resultLine.Substring(indexForTrim + 1, resultLine.Length - indexForTrim - 1);
              currentProgramPath = currentProgramPath.Replace("\r", "").Trim();
              if (!_listOfAllowedPrograms.Contains(currentProgramName + " - " + currentProgramPath))
              _listOfAllowedPrograms.Add(currentProgramName + " - " + currentProgramPath);
            }
          }
        }
      }
      catch (MethodInvocationException ex)
      {
        Trace.WriteError("({0})", "putAllLocalFireWallExceptionsToList", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "putAllLocalFireWallExceptionsToList", ex.Message));

      }
    }
    public List<string> GetAllLocalFirewallusingPorts()
    {
      _allFireWallUsingPorts.Clear();
      using (Runspace runspace = RunspaceFactory.CreateRunspace())
      {
        runspace.Open();

        try
        {
          CreateTempPSfile(OSVersions.AllOS, "firewallCheckclosedPorts");

          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");

          pipeline.Commands.AddScript(@".\Temp\temp.ps1");
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          StringBuilder stringBuilder = new StringBuilder();
          foreach (PSObject str in results)
          {
            stringBuilder.AppendLine(str.ToString());
            string all = stringBuilder.ToString();
            string[] split = all.Split('\n');
            string st = "";
            foreach (string item in split)
            {
              st = item.Trim(new char[] { '\t', ' ', '\r', '\n' });
              _allFireWallUsingPorts.Add(st);
            }

          }
          return _allFireWallUsingPorts;
        }
        catch (MethodInvocationException ex)
        {
          Trace.WriteError("({0})", "putAllUsingPortsToList", CLASSNAME, ex);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "get firewallports they are not free", ex.Message));

          return null;
        }
      };
    }
    public void TurnOnOffFireWall(string OnOff)
    {
      using (Runspace runspace = RunspaceFactory.CreateRunspace())
      {
        runspace.Open();
        try
        {
          CreateTempPSfile(OSVersions.AllOS, "firewallTurnOnOff");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");

          pipeline.Commands.AddScript(@".\Temp\temp.ps1 -OnOrOff " + OnOff);
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();

        }
        catch (MethodInvocationException ex)
        {
          Trace.WriteError("({0})", "TurnOnOffFireWal", CLASSNAME, ex, OnOff);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Turn on/off firewall", ex.Message));

        }
      };

    }
    public void AddExeceptionFirewall(string program, string programPath, string pcAnywhere)
    {
      using (Runspace runspace = RunspaceFactory.CreateRunspace())
      {
        runspace.Open();
        try
        {
          CreateTempPSfile(OSVersions.AllOS, "firewallAddException");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1 -program " + "\"" + program + "\"" + " -programPath " + programPath + " -pcAnywhere " + pcAnywhere;
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();

        }
        catch (MethodInvocationException ex)
        {
          Trace.WriteError("({0},{1},{2},{3},{4})", "AddExeceptionFirewall", CLASSNAME, ex, program, programPath, pcAnywhere);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Add Firewall Exception", ex.Message));

        }
      };
    }
    public void AddPortExeceptionFirewall(string protocol, string port, string programPath)
    {
      using (Runspace runspace = RunspaceFactory.CreateRunspace())
      {
        runspace.Open();
        try
        {
          CreateTempPSfile(OSVersions.AllOS, "firewallAddPortException");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1 -protocol " + "\"" + protocol + "\"" + " -port " + port + " -programpath " + "\"" + programPath + "\"";
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();

        }
        catch (MethodInvocationException ex)
        {
          Trace.WriteError("({0},{1},{2})", "AddExeceptionFirewall", CLASSNAME, ex, protocol, port, programPath);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Add Firewall Exception", ex.Message));

        }
      };
    }
    public void DeleteExceptionFirewall(string program, string protocol, string port, string programPath)
    {
      using (Runspace runspace = RunspaceFactory.CreateRunspace())
      {
        runspace.Open();
        try
        {
          CreateTempPSfile(OSVersions.AllOS, "firewallDeleteException");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1 -program " + "\"" + program + "\"" + " -protocol " + protocol + " -port " + port + " -programPath " + "\"" + programPath + "\"";
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();

        }
        catch (MethodInvocationException ex)
        {
          Trace.WriteError("({0},{1},{2},{3})", "DeleteExeceptionFirewall", CLASSNAME, ex, program, protocol, port, programPath);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Delete Firewall Exception", ex.Message));

        }
      };
    }

    public List<string> putMembersOfGroupToList(string group)
    {
      List<string> membersOfgroup = new List<string>();
      membersOfgroup.Clear();
      using (Runspace runspace = RunspaceFactory.CreateRunspace())
      {
        runspace.Open();

        try
        {
          CreateTempPSfile(OSVersions.AllOS, "getListofUsersInGroup");

          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1 -Group " + "\"" + group + "\"";
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          StringBuilder stringBuilder = new StringBuilder();
          foreach (PSObject str in results)
          {
            stringBuilder.AppendLine(str.ToString());
            string all = stringBuilder.ToString();
            string[] split = all.Split('\n');
            string st = "";
            foreach (string item in split)
            {
              st = item.Trim(new char[] { '\t', ' ', '\r', '\n' });
              membersOfgroup.Add(st);
            }

          }

        }
        catch (MethodInvocationException ex)
        {
          Trace.WriteError("({0})", "putMembersOfRemoteDesktopGroupToList", CLASSNAME, ex, group);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "putMembersOfRemoteDesktopGroupToList", ex.Message));

        }
      };
      return membersOfgroup;
    }
    public void putAllGlobalGroupsToList()
    {
      const string FUNCTIONNAME = "putAllGlobalGroupsToList";

      try
      {
        Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          CreateTempPSfile(OSVersions.AllOS, "checkAllGlobalGroups");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1";
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();

          if (results.Count > 1)
            throw new ApplicationException("Got more then 1 result when getting global groups from powershell");

          string resultString = results[0].ToString();
          string[] resultStringSplitted = resultString.Split('\n');

          foreach (string resultLine in resultStringSplitted)
          {
            // Ignore line that we don't need
            if (resultLine != "\r" && !string.IsNullOrEmpty(resultLine) && resultLine != "name                                                                            \r" && resultLine != "----                                                                            \r")
              _listOfGlobalGroups.Add(resultLine);
          }

        }


      }
      catch (Exception ex)
      {

        Trace.WriteError("()", FUNCTIONNAME, CLASSNAME, ex);
        throw;
      }
    }
    /// <summary>
    /// Get or set ListOfGroupsInUser
    /// </summary>
    public List<string> ListOfGroupsInUser
    {
      get { return _listOfGroupsInUser; }
      set { _listOfGroupsInUser = value; }
    } private List<string> _listOfGroupsInUser;
    public void getListofGroupsInUser(string name)
    {
      DirectorySearcher search = new DirectorySearcher();
      int groupCount;
      int counter;
      string GroupName;
      string DataToWriteGroups;

      search.Filter = "(&(objectClass=user)(SAMAccountName=" + name + "))";
      search.PropertiesToLoad.Add("memberOf");
      SearchResult result = search.FindOne();
      groupCount = result.Properties["memberOf"].Count;
      if (groupCount > 0)
      {
        DataToWriteGroups = "Group(s) Belongs To User - " + name + "";
        for (counter = 0; counter <= groupCount - 1; counter++)
        {
          GroupName = "";
          GroupName = (result.Properties["memberOf"][counter].ToString());
          _listOfGroupsInUser.Add(GroupName);
        }
      }
    }
    //public void getListofGroupInUser(string userString)
    //{
    //  using (Runspace runspace = RunspaceFactory.CreateRunspace())
    //  {
    //    runspace.Open();

    //    try
    //    {
    //      CreateTempPSfile(OSVersions.AllOS, "getListofGroupInUser");

    //      Pipeline pipeline = runspace.CreatePipeline();
    //      pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
    //      string command = @".\Temp\temp.ps1 -strUserName " + "\"" + userString + "\"";
    //      pipeline.Commands.AddScript(command);
    //      pipeline.Commands.Add("Out-String");

    //      // execute the script
    //      Collection<PSObject> results = pipeline.Invoke();
    //      runspace.Close();
    //      if (results.Count > 1)
    //        throw new ApplicationException("Got more then 1 result when getting list of groups in one user from powershell");

    //      string resultString = results[0].ToString();
    //      string[] resultStringSplitted = resultString.Split('\n');
    //      foreach (string resultLine in resultStringSplitted)
    //      {
    //        // Ignore line that we don't need
    //        if (resultLine != "\r" && !string.IsNullOrEmpty(resultLine))
    //          _listOfGroupsInUser.Add(resultLine);
    //      }
    //    }
    //    catch (MethodInvocationException ex)
    //    {
    //      Trace.WriteError("({0})", "getListofGroupInUser", CLASSNAME, ex, userString);
    //      _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "getListofGroupInUser", ex.Message));

    //    }
    //  }
    //}
    public void removeUserFromGroup(string userToDeleteString, string fromGroupString)
    {
      using (Runspace runspace = RunspaceFactory.CreateRunspace())
      {
        runspace.Open();
        try
        {
          CreateTempPSfile(OSVersions.AllOS, "removeUserFromGroup");

          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1 -name " + "\"" + userToDeleteString + "\"" + " -fromGroup " + "\"" + fromGroupString + "\"";
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
        }
        catch (MethodInvocationException ex)
        {
          Trace.WriteError("({0},{1})", "removeUserFromGroup", CLASSNAME, ex, userToDeleteString, fromGroupString);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "removeUserFromGroup", ex.Message));
        }
      }
    }
    public void putMembersOfRemoteDesktopGroupToList(string group)
    {
      _membersOfRemoteDesktop.Clear();
      using (Runspace runspace = RunspaceFactory.CreateRunspace())
      {
        runspace.Open();
        try
        {
          CreateTempPSfile(OSVersions.AllOS, "getListofUsersInGroup");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1 -Group " + "\"" + group + "\"";
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          StringBuilder stringBuilder = new StringBuilder();
          foreach (PSObject str in results)
          {
            stringBuilder.AppendLine(str.ToString());
            string all = stringBuilder.ToString();
            string[] split = all.Split('\n');
            string st = "";
            foreach (string item in split)
            {
              st = item.Trim(new char[] { '\t', ' ', '\r', '\n' });
              _membersOfRemoteDesktop.Add(st);
            }
          }
        }
        catch (MethodInvocationException ex)
        {
          Trace.WriteError("({0})", "putMembersOfRemoteDesktopGroupToList", CLASSNAME, ex, group);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "putMembersOfRemoteDesktopGroupToList", ex.Message));

        }
      };
    }
    public void putMembersOfAdministratorsToList(string group)
    {
      _membersOfAdministrators.Clear();
      using (Runspace runspace = RunspaceFactory.CreateRunspace())
      {
        runspace.Open();

        try
        {
          CreateTempPSfile(OSVersions.AllOS, "getListofUsersInGroup");

          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1 -Group " + "\"" + group + "\"";
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          StringBuilder stringBuilder = new StringBuilder();
          foreach (PSObject str in results)
          {
            stringBuilder.AppendLine(str.ToString());
            string all = stringBuilder.ToString();
            string[] split = all.Split('\n');
            string st = "";
            foreach (string item in split)
            {
              st = item.Trim(new char[] { '\t', ' ', '\r', '\n' });
              _membersOfAdministrators.Add(st);
            }

          }
        }
        catch (MethodInvocationException ex)
        {
          Trace.WriteError("({0})", "putMembersOfRemoteDesktopGroupToList", CLASSNAME, ex, group);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "putMembersOfAdministratorsToList", ex.Message));

        }
      };
    }

    public List<string> RegistrySettings
    {
      get
      {
        return _registrySettings;
      }
      set
      {
        _registrySettings = value;
      }
    }
    public string GetRegkeyValue(string registerPath, string registerKey)
    {
      using (Runspace runspace = RunspaceFactory.CreateRunspace())
      {
        runspace.Open();
        try
        {
          if (registerKey.Length != 0)
          {
            CreateTempPSfile(OSVersions.AllOS, "GetRegisterKeyValue");
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
            string command = @".\Temp\temp.ps1 -RegisterPath " + "\"" + registerPath + "\"" + " -Keyname " + registerKey;
            pipeline.Commands.AddScript(command);
            pipeline.Commands.Add("Out-String");

            // execute the script
            Collection<PSObject> results = pipeline.Invoke();
            StringBuilder stringBuilder = new StringBuilder();

            foreach (PSObject str in results)
            {
              stringBuilder.AppendLine(str.ToString());
              string all = stringBuilder.ToString();
              string[] split = all.Split('\n');
              string st = "";
              string stringReturn = "";
              foreach (string item in split)
              {

                st = item.Trim(new char[] { '\t', ' ', '\r', '\n' });
                if (st.Contains("False"))
                {
                  return "NULL";
                }
                if (item.Contains(registerKey))
                {
                  string[] value = st.Split(':');
                  for (int i = 0; i < value.Length; i++)
                  {
                    if (i != 0)
                    {
                      if (i != value.Length - 1)
                      {
                        stringReturn = stringReturn + value[i] + ":";
                      }
                      else
                      {
                        stringReturn = stringReturn + value[i];
                      }
                    }
                  }
                  return stringReturn;
                }

              }

            }

          }
        }
        catch (MethodInvocationException ex)
        {
          Trace.WriteError("({0},{1})", "GetRegkeyValue", CLASSNAME, ex, registerPath, registerKey);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Get Reg Key value", ex.Message));

        }
      };
      return "";

    }
    public void SetRegisterKey(string registerPath, string registerKey, string value, string propertyType)
    {
      using (Runspace runspace = RunspaceFactory.CreateRunspace())
      {
        runspace.Open();
        try
        {
          if (registerPath.Contains(@"HKCU:\"))
          {
            string path = registerPath.Remove(0, 6);

            _registrySettings.Add(@"[HKEY_CURRENT_USER\" + path + "]");
            if (propertyType == "DWORD")
            {
              _registrySettings.Add("\"" + registerKey + "\"=dword:" + value);
            }
            else
            {
              _registrySettings.Add("\"" + registerKey + "\"=\"" + value + "\"");
            }
            _registrySettings.Add("");

          }

          CreateTempPSfile(OSVersions.AllOS, "SetRegisterKey");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = "";
          command = @".\Temp\temp.ps1 -RegisterPath " + "\"" + registerPath + "\"" + " -Keyname " + registerKey + " -Value \"" + value + "\" -PropertyType " + propertyType;
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");

          // execute the script
          pipeline.Invoke();

        }
        catch (MethodInvocationException ex)
        {
          Trace.WriteError("({0},{1},{2})", "SetRegisterKey", CLASSNAME, ex, registerPath, registerKey, propertyType);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Set register key value", ex.Message));

        }
      };
    }
    public bool CheckRegKeyExist(string registerPath, string registerKey, string value)
    {
      using (Runspace runspace = RunspaceFactory.CreateRunspace())
      {
        runspace.Open();

        try
        {
          CreateTempPSfile(OSVersions.AllOS, "checkRegKeyExist");

          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1 -RegisterPath " + "\"" + registerPath + "\"" + " -Keyname " + registerKey + " -Value " + "\"" + value + "\"";
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          StringBuilder stringBuilder = new StringBuilder();
          foreach (PSObject str in results)
          {
            stringBuilder.AppendLine(str.ToString());
            string all = stringBuilder.ToString();
            string[] split = all.Split('\n');
            string st = "";
            foreach (string item in split)
            {
              st = item.Trim(new char[] { '\t', ' ', '\r', '\n' });
              if (item.Contains("True"))
              {
                return true;
              }
              else if (item.Contains("false"))
              {
                return false;
              }
            }

          }
        }
        catch (MethodInvocationException ex)
        {
          Trace.WriteError("({0},{1},{2})", "CheckRegKeyExist", CLASSNAME, ex, registerPath, registerKey, value);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check if registry key exist", ex.Message));
          return false;
        }
        catch (Exception ex)
        {
          Trace.WriteError("({0},{1},{2})", "CheckRegKeyExist", CLASSNAME, ex, registerPath, registerKey, value);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check if registry key exist", ex.Message));
          return false;
        }
      };

      return false;

    }
    public void RemoveRegisterKey(string registerPath, string registerKey)
    {
      using (Runspace runspace = RunspaceFactory.CreateRunspace())
      {
        runspace.Open();
        try
        {
          if (registerKey.Length != 0)
          {
            CreateTempPSfile(OSVersions.AllOS, "RemoveRegisterKey");
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
            string command = @".\Temp\temp.ps1 -RegisterPath " + registerPath + " -Keyname " + registerKey;
            pipeline.Commands.AddScript(command);
            pipeline.Commands.Add("Out-String");

            // execute the script
            Collection<PSObject> results = pipeline.Invoke();
          }
        }
        catch (MethodInvocationException ex)
        {
          Trace.WriteError("({0},{1})", "RemoveRegisterKey", CLASSNAME, ex, registerPath, registerKey);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Remove registry key", ex.Message));
        }
      };

    }
    public void AddRegistrySettingsToFile(string path)
    {
      try
      {
        File.Delete(path);
        FileHandling fh = new FileHandling(_configClass);
        fh.CreateRegFile(path);
        fh.AddLineToEndFile(path, "Windows Registry Editor Version 5.00 ");
        fh.AddLineToEndFile(path, "");
        foreach (string str in _registrySettings)
        {
          fh.AddLineToEndFile(path, str);
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "Add registrykey to .reg file", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Add registrykey to .reg file", ex.Message));

      }
    }
    public void RunMBSA(string path, string mbsaLog)
    {
      using (Runspace runspace = RunspaceFactory.CreateRunspace())
      {
        runspace.Open();
        try
        {
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command1 = "cd \"" + path + "\"";
          string command2 = @".\mbsacli.exe /target localhost > " + mbsaLog;
          pipeline.Commands.AddScript(command1);
          pipeline.Commands.AddScript(command2);
          pipeline.Commands.Add("Out-String");

          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
        }
        catch (MethodInvocationException ex)
        {
          Trace.WriteError("({0},{1})", "RunMBSA", CLASSNAME, ex, path, mbsaLog);
          _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Run MBSA", ex.Message));

        }

      };
    }
    //da script will not work on windows XP
    public void AddIIS7WebSite(string wsName, string wsProtocol, string wsIpAddress, string wsPort, string wsHostname, string wsAppPool, string wsLocation)
    {
      const string FUNCTIONNAME = "AddIIS7WebSite";
      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          CreateTempPSfile(OSVersions.AllOS, "Add-IIS7WebSite");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = "";
          if (wsHostname.Length != 0 && wsAppPool.Length != 0)
            command = @".\Temp\temp.ps1 -Name " + "\"" + wsName + "\"" + " -protocol " + "\"" + wsProtocol + "\"" + " -ipAddress " + "\"" + wsIpAddress + "\"" + " -port " + "\"" + wsPort + "\"" + " -HostHeader " + "\"" + wsHostname + "\"" + " -ApplicationPool " + "\"" + wsAppPool + "\"" + " -PhysicalPath " + "\"" + wsLocation + "\"";
          else if (wsHostname.Length == 0 && wsAppPool.Length == 0)
            command = @".\Temp\temp.ps1 -Name " + "\"" + wsName + "\"" + " -protocol " + "\"" + wsProtocol + "\"" + " -ipAddress " + "\"" + wsIpAddress + "\"" + " -port " + "\"" + wsPort + "\"" + " -PhysicalPath " + "\"" + wsLocation + "\"";
          else if (wsHostname.Length == 0 && wsAppPool.Length != 0)
            command = @".\Temp\temp.ps1 -Name " + "\"" + wsName + "\"" + " -protocol " + "\"" + wsProtocol + "\"" + " -ipAddress " + "\"" + wsIpAddress + "\"" + " -port " + "\"" + wsPort + "\"" + " -ApplicationPool " + "\"" + wsAppPool + "\"" + " -PhysicalPath " + "\"" + wsLocation + "\"";
          else if (wsHostname.Length != 0 && wsAppPool.Length == 0)
            command = @".\Temp\temp.ps1 -Name " + "\"" + wsName + "\"" + " -protocol " + "\"" + wsProtocol + "\"" + " -ipAddress " + "\"" + wsIpAddress + "\"" + " -port " + "\"" + wsPort + "\"" + " -HostHeader " + "\"" + wsHostname + "\"" + " -PhysicalPath " + "\"" + wsLocation + "\"";
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
        }
      }
      catch (MethodInvocationException ex)
      {
        Trace.WriteError("({0},{1},{2},{3},{4},{5},{6})", FUNCTIONNAME, CLASSNAME, ex, wsName, wsProtocol, wsIpAddress, wsPort, wsHostname, wsAppPool, wsLocation);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "AddIIS7WebSite", ex.Message));
      }
    }
    /// <summary>
    /// Get or set ListOfCurrentWebsites
    /// </summary>
    public List<string> ListOfCurrentWebsites
    {
      get { return _listOfCurrentWebSites; }
      set { _listOfCurrentWebSites = value; }
    } private List<string> _listOfCurrentWebSites;
    public void ShowAllWebStatus()
    {
      const string FUNCTIONNAME = "ShowAllWebStatus";

      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
          CreateTempPSfile(OSVersions.AllOS, "Get-IIS7AllSiteStatus");
          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          string command = @".\Temp\temp.ps1";
          pipeline.Commands.AddScript(command);
          pipeline.Commands.Add("Out-String");
          // execute the script

          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();

          if (results.Count > 1)
            throw new ApplicationException("Got more then 1 result when getting current websites from powershell");

          string resultString = results[0].ToString();
          string[] resultStringSplitted = resultString.Split('\n');
          string st = "";
          foreach (string resultLine in resultStringSplitted)
          {
            st = resultLine.Trim(new char[] { '\t', ' ', '\r', '\n' });
            // Ignore line that we don't need
            if (st != "\r" && !string.IsNullOrEmpty(st))
              _listOfCurrentWebSites.Add(st);
          }
        }
      }

      catch (Exception ex)
      {
        Trace.WriteError("()", FUNCTIONNAME, CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "ShowAllWebStatus", ex.Message));
      }
    }
    const string FERULENAME = "Rule Name:";
    const string FEENABLED = "Enabled:";
    const string FEDIRECTION = "Direction:";
    const string FEPROFILE = "Profiles:";
    const string FEGROUPING = "Grouping:";
    const string FELOCALIP = "LocalIP:";
    const string FEREMOTEIP = "RemoteIP:";
    const string FEPROTOCOL = "Protocol:";
    const string FELOCALPORT = "LocalPort:";
    const string FEREMOTEPORT = "RemotePort:";
    const string FEEDGETRAVERSAL = "Edge traversal:";
    const string FEACTION = "Action:";
    /// <summary>
    /// Get or set AllCurrentFwExceptionsWin7
    /// </summary>
    public List<string> AllCurrentFwExceptionsRuleInOut
    {
      get { return _allCurrentFwExceptionRulesInOut; }
      set { _allCurrentFwExceptionRulesInOut = value; }
    } private List<string> _allCurrentFwExceptionRulesInOut = new List<string>();

    public void GetAllCurrentFireWallExceptionsWinServer()
    {
      _allCurrentFwExceptionRulesInOut.Clear();
      try
      {
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();


          CreateTempPSfile(OSVersions.AllOS, "firewallGetAllCurrentFirewallExceptions");

          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          pipeline.Commands.AddScript(@".\Temp\temp.ps1");
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
          if (results.Count > 1)
            throw new ApplicationException("Got more then 1 result when getting firewall exceptions from powershell");

          string resultString = results[0].ToString();
          string[] resultStringSplitted = resultString.Split('\n');

          string currentName = "";
          string currentStatus = "";
          string currentDir = "";
          string currentProtocol = "";
          string currentPort = "";
          string currentAllow = "";
          for (int i = 0; i < resultStringSplitted.Length - 1; i++)
          {
            string resultLine = resultStringSplitted[i];

            if (resultLine.Contains(FERULENAME))
            {
              currentName = resultLine.Substring(38, resultLine.Length - 38).Replace("\r", "").Trim();

            }
            if (resultLine.Contains(FEENABLED))
            {
              currentStatus = resultLine.Substring(38, resultLine.Length - 38).Replace("\r", "").Trim();
            }
            if (resultLine.Contains(FEDIRECTION))
            {
              currentDir = resultLine.Substring(38, resultLine.Length - 38).Replace("\r", "").Trim();

            }
            if (resultLine.Contains(FEPROTOCOL))
            {
              currentProtocol = resultLine.Substring(38, resultLine.Length - 38).Replace("\r", "").Trim(); 

            }
            if (resultLine.Contains(FELOCALPORT))
            {
              currentPort = resultLine.Substring(38, resultLine.Length - 38).Replace("\r", "").Trim(); 
            }
            if (resultLine.Contains(FEACTION))
            {
              currentAllow = resultLine.Substring(38, resultLine.Length - 38).Replace("\r", "").Trim();
              _allCurrentFwExceptionRulesInOut.Add(currentName + " Enabled - " + currentStatus + " Direction - " + currentDir + " Protocol - " + currentProtocol + " Port - " + currentPort + " " + currentAllow);
            }

          }

        }
      }
      catch (MethodInvocationException ex)
      {
        Trace.WriteError("({0})", "putAllLocalFireWallExceptionsToList", CLASSNAME, ex);
        _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "putAllLocalFireWallExceptionsToList", ex.Message));

      }
    }

    public void startIISServiceIfStopped()
    {
      const string FUNCTIONNAME = "startIISServiceIfStopped";
      try
      {
        Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          CreateTempPSfile(OSVersions.AllOS, "startIISServiceIfStopped");

          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          pipeline.Commands.AddScript(@".\Temp\temp.ps1");
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
          if (results.Count > 1)
            throw new ApplicationException("Got more then 1 result when starting IISADMIN Service from powershell");
        }


      }
      catch (Exception ex)
      {

        Trace.WriteError("()", FUNCTIONNAME, CLASSNAME, ex);
        throw;
      }
    }

    /// <summary>
    /// Get or set ListOfAllSharedFolders
    /// </summary>
    public List<string> ListOfAllSharedFolders
    {
      get { return _listOfAllSharedFolders; }
      set { _listOfAllSharedFolders = value; }
    } private List<string> _listOfAllSharedFolders = new List<string>();


    public void GetAllSharedFolders()
    {
      const string FUNCTIONNAME = "GetAllSharedFolders";
      try
      {
        Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          CreateTempPSfile(OSVersions.AllOS, "GetAllSharedFolders");

          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          pipeline.Commands.AddScript(@".\Temp\temp.ps1");
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
          if (results.Count > 1)
            throw new ApplicationException("Got more then 1 result when getting shared folders from powershell");
          string resultString = results[0].ToString();
          string[] resultStringSplitted = resultString.Split('\n');
          foreach (string resultLine in resultStringSplitted)
          {
            if (resultLine != "\r" && !string.IsNullOrEmpty(resultLine)
             && !resultLine.Contains("Name                       Path                       Description               \r")
             && !resultLine.Contains("----                       ----                       -----------               \r"))
            {
              string name = "";
              string path = "";
              string description = "";
              int indexOfSplit = resultLine.IndexOf("\\");
              if (resultLine.Contains("IPC$                                                  Remote IPC                \r"))
              {
                int indexForSplit = resultLine.IndexOf("Remote");
                name = resultLine.Substring(0, indexForSplit - 1).Trim();

                description = resultLine.Substring(indexForSplit, resultLine.Length - indexForSplit);
                description = description.Replace("\r", "").Trim();

                _listOfAllSharedFolders.Add(name + " Description: " + description);
              }
              else
              {
                name = resultLine.Substring(0, indexOfSplit - 3).Trim();

                path = resultLine.Substring(indexOfSplit - 2, 27).Trim();

                description = resultLine.Substring(indexOfSplit + 25, resultLine.Length - (indexOfSplit + 25));
                description = description.Replace("\r", "").Trim();

                _listOfAllSharedFolders.Add(name + " Path: " + path + " Description: " + description);
              }
            }
          }
        }
      }
      catch (Exception ex)
      {

        Trace.WriteError("()", FUNCTIONNAME, CLASSNAME, ex);
        throw;
      }
    }

    public void AddSharedFolder(string sharePath, string shareName, string shareSimultaneous, string shareComment)
    {
      const string FUNCTIONNAME = "AddSharedFolder";
      try
      {
        Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          CreateTempPSfile(OSVersions.AllOS, "AddSharedFolder");

          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          pipeline.Commands.AddScript(@".\Temp\temp.ps1 -FolderPath " + "\"" + sharePath + "\"" + " -ShareName " + "\"" + shareName + "\"" + " -SimultaneousUserLimit " + "\"" + shareSimultaneous + "\"" + " -Description " + "\"" + shareComment + "\"");
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0},{1},{2},{3})", FUNCTIONNAME, CLASSNAME, ex, sharePath, shareName, shareSimultaneous, shareComment);
        throw;
      }

    }

    public void AddRuleAdvFirewallPort(string ruleName,string ruleDir,string ruleProtocol, string rulePort)
    {
      const string FUNCTIONNAME = "AddRuleAdvFirewallPort";
      try
      {
        Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          CreateTempPSfile(OSVersions.AllOS, "AddRuleAdvFirewallPort");

          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          pipeline.Commands.AddScript(@".\Temp\temp.ps1 -ruleName " + "\"" + ruleName + "\"" + " -direction " + "\"" + ruleDir + "\"" + " -protocol " + "\"" + ruleProtocol + "\"" + " -port " + "\"" + rulePort + "\"");
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0},{1},{2},{3})", FUNCTIONNAME, CLASSNAME, ex, ruleName, ruleDir, ruleProtocol, rulePort);
        throw;
      }
    }
    public void AddRuleAdvFirewallProgram(string ruleName,string ruleDir,string ruleProgramPath)
    {
      const string FUNCTIONNAME = "AddRuleAdvFirewallProgram";
      try
      {
        Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          CreateTempPSfile(OSVersions.AllOS, "AddRuleAdvFirewallPort");

          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          pipeline.Commands.AddScript(@".\Temp\temp.ps1 -name " + "\"" + ruleName + "\"" + " -direction " + "\"" + ruleDir + "\"" + " -programPath " + "\"" + ruleProgramPath + "\"");
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0},{1},{2})", FUNCTIONNAME, CLASSNAME, ex, ruleName, ruleDir, ruleProgramPath);
        throw;
      }
    }
    public void DeleteRuleAdvFirewall(string ruleName)
    {
      const string FUNCTIONNAME = "DeleteRuleAdvFirewall";
      try
      {
        Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          CreateTempPSfile(OSVersions.AllOS, "DeleteRuleAdvFirewall");

          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          pipeline.Commands.AddScript(@".\Temp\temp.ps1 -ruleName " + "\"" + ruleName + "\"");
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", FUNCTIONNAME, CLASSNAME, ex, ruleName);
        throw;
      }
    }
    public void ModifyFirewallRule(string oldRuleName, string newRuleName,string ruleEnable,string ruleDirection,string ruleProtocol,string rulePort,string ruleAction)
    {
      const string FUNCTIONNAME = "ModifyFirewallRule";
      try
      {
        Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
        using (Runspace runspace = RunspaceFactory.CreateRunspace())
        {
          runspace.Open();
          CreateTempPSfile(OSVersions.AllOS, "ModifyFirewallRule");

          Pipeline pipeline = runspace.CreatePipeline();
          pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
          pipeline.Commands.AddScript(@".\Temp\temp.ps1 -oldRuleName " + "\"" + oldRuleName + "\""+" -newRuleName "+"\""+newRuleName+ "\""+" -enable "+ "\""+ruleEnable+"\""+" -direction "+"\""+ruleDirection+"\""+ " -protocol "+"\"" +ruleProtocol+"\"" +" -port " +"\""+rulePort+"\""+" -action "+"\"" + ruleAction+"\"");
          pipeline.Commands.Add("Out-String");
          // execute the script
          Collection<PSObject> results = pipeline.Invoke();
          runspace.Close();
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0},{1},{2},{3},{4},{5},{6})", FUNCTIONNAME, CLASSNAME, ex, oldRuleName,newRuleName,ruleEnable,ruleDirection,ruleProtocol,rulePort,ruleAction);
        throw;
      }
    }
  }
}