using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actemium.WiSSWizard
{
  [Serializable]
  public class ModifyFirewall
  {
    /// <summary>
    /// Get or set RuleName
    /// </summary>
    public string oldRuleName
    {
      get { return _oldRuleName; }
      set { _oldRuleName = value; }
    } private string _oldRuleName = "";

    /// <summary>
    /// Get or set NewRuleName
    /// </summary>
    public string NewRuleName
    {
      get { return _newRuleName; }
      set { _newRuleName = value; }
    } private string _newRuleName; 

    /// <summary>
    /// Get or set RuleEnable
    /// </summary>
    public string IsRuleEnable
    {
      get { return _isRuleEnable; }
      set { _isRuleEnable = value; }
    } private string _isRuleEnable = "";

    /// <summary>
    /// Get or set RuleDirection
    /// </summary>
    public string RuleDirection
    {
      get { return _ruleDirection; }
      set { _ruleDirection = value; }
    } private string _ruleDirection ="";

    /// <summary>
    /// Get or set RuleProtocol
    /// </summary>
    public string RuleProtocol
    {
      get { return _ruleProtocol; }
      set { _ruleProtocol = value; }
    } private string _ruleProtocol="";

    /// <summary>
    /// Get or set RulePort
    /// </summary>
    public string RulePort
    {
      get { return _rulePort; }
      set { _rulePort = value; }
    } private string _rulePort="";

    /// <summary>
    /// Get or set RuleAction
    /// </summary>
    public string RuleAction
    {
      get { return _ruleAction; }
      set { _ruleAction = value; }
    } private string _ruleAction=""; 

    public ModifyFirewall()
    {}

    public ModifyFirewall(string oldRuleName,string newRuleName,string isEnable,string ruleDirection,string ruleProtocol,string rulePort,string ruleAction)
    {
      _oldRuleName = oldRuleName;
      _newRuleName = newRuleName;
      _isRuleEnable = isEnable;
      _ruleDirection = ruleDirection;
      _ruleProtocol = ruleProtocol;
      _rulePort = rulePort;
      _ruleAction = ruleAction;

    }
  }

  [Serializable]
  public class FireWallException
  {
    public string ExceptionName
    {
      get
      {
        return _exceptionName;
      }
      set
      {
        _exceptionName = value;
      }
    } private string _exceptionName;

    public FireWallException()
    { }
    public FireWallException(string exceptionName)
    {
      _exceptionName = exceptionName;
    }
  }

  public class WindowsFirewall
  {
    //parameters
    private const string CLASSNAME = "WindowsFirewall";

    //constructor
    public WindowsFirewall()
    {

    }

    //properties
    public bool FireWallOn
    {
      get
      {
        return _fireWallOn;
      }
      set
      {
        _fireWallOn = value;
      }
    } private bool _fireWallOn = true;
    /// <summary>
    /// Get or set ModifyFirewallRule
    /// </summary>
    public List<ModifyFirewall> ModifyFirewallRule
    {
      get { return _modifyFirewallRule; }
      set { _modifyFirewallRule = value; }
    } private List<ModifyFirewall> _modifyFirewallRule = new List<ModifyFirewall>(); 

    /// <summary>
    /// All the exceptions
    /// </summary>
    public List<FireWallException> FireWallExceptions
    {
      get
      {
        return _fireWallExceptions;
      }
      set
      {
        _fireWallExceptions.Clear();
        _fireWallExceptions = value;
      }

    } private List<FireWallException> _fireWallExceptions = new List<FireWallException>();

    /// <summary>
    /// All the exceptions to add
    /// </summary>
    public List<FireWallException> AddFireWallExceptions
    {
      get
      {
        return _addFireWallExceptions;
      }
      set
      {
        _addFireWallExceptions.Clear();
        _addFireWallExceptions = value;
      }

    } private List<FireWallException> _addFireWallExceptions = new List<FireWallException>();

    /// <summary>
    /// All the exceptions to delete
    /// </summary>
    public List<FireWallException> DeleteFireWallExceptions
    {
      get
      {
        return _deleteFireWallExceptions;
      }
      set
      {
        _deleteFireWallExceptions.Clear();
        _deleteFireWallExceptions = value;
      }

    } private List<FireWallException> _deleteFireWallExceptions = new List<FireWallException>();

    /// <summary>
    /// Get or set DeleteFirewallException
    /// </summary>


    public string AddFireWallPort
    {
      set
      {
        _fireWallOwnAddedPorts.Add(value);
      }
    }

    public List<string> GetOwnAddedFireWallPorts
    {
      get
      {
        return _fireWallOwnAddedPorts;
      }
    } private List<string> _fireWallOwnAddedPorts = new List<string>();

    public List<NoDefaultSettingsLog> NoDefaultSettingsLog
    {
      get
      {
        return _noDefaultSettingsLog;
      }
      set
      {
        _noDefaultSettingsLog = value;
      }
    } private List<NoDefaultSettingsLog> _noDefaultSettingsLog = new List<NoDefaultSettingsLog>();
    public NoDefaultSettingsLog AddNoDefaultSettingsToList
    {
      set
      {
        NoDefaultSettingsLog newLog = value;
        foreach (NoDefaultSettingsLog nds in _noDefaultSettingsLog)
        {
          if (nds.Setting == newLog.Setting)
          {
            _noDefaultSettingsLog.Remove(nds);
            break;
          }
        }
        _noDefaultSettingsLog.Add(newLog);
      }
    }

    //methods
    public bool CheckFireWallPortisFree(int port, string protocol, ConfigClass configClass)
    {

      bool isFree = true;
      try
      {
        foreach (string str in configClass.GetScriptHandling.GetAllLocalFirewallusingPorts())
        {
          if (protocol == "ALL")
          {
            if (str.Contains("UDP") || str.Contains("TCP"))
            {
              string[] splitStr = str.Split(' ');
              if (port == Convert.ToInt32(splitStr[0]))
              {
                isFree = false;
                return isFree;
              }
            }
          }
          else
          {
            if (str.Contains(protocol))
            {
              string[] splitStr = str.Split(' ');
              if (port == Convert.ToInt32(splitStr[0]))
              {
                isFree = false;
                return isFree;
              }
            }
          }
        }
        foreach (string str in _fireWallOwnAddedPorts)
        {
          if (protocol == "ALL")
          {
            if (str.Contains("UDP") || str.Contains("TCP"))
            {
              string[] splitStr = str.Split(' ');
              if (port == Convert.ToInt32(splitStr[0]))
              {
                isFree = false;
                return isFree;
              }
            }
          }
          else
          {
            if (str.Contains(protocol))
            {
              string[] splitStr = str.Split(' ');
              if (port == Convert.ToInt32(splitStr[0]))
              {
                isFree = false;
                return isFree;
              }
            }
          }
        }




        return isFree;
      }
      catch
      {
        return isFree;
      }
    }
    public void ClearListOwnAddedFireWallPorts()
    {
      _fireWallOwnAddedPorts.Clear();
    }

    public void SetFireWall(ConfigClass configClass)
    {
      try
      {
        string os = configClass.ConfSetDefaultInformation.Operatingsystem;
        if (_fireWallOn)
        {
          configClass.GetScriptHandling.TurnOnOffFireWall("enable");
        }
        else// if (_addFireWallExceptions[i].Contains("Firewall uitgeschakeld"))
        { configClass.GetScriptHandling.TurnOnOffFireWall("disable"); }
        #region Windows XP Firewall
        if (os == "Windows XP" || os == "Windows XP 32 Bit" || os == "Windows XP 64 Bit")
        {
          for (int i = 0; i < _addFireWallExceptions.Count; i++)
          {
            if (_addFireWallExceptions[i].ExceptionName.Contains("PcAnywhere"))
            {
            }
            if (_addFireWallExceptions[i].ExceptionName.Contains("Remote Desktop"))
            {
              configClass.GetScriptHandling.AddExeceptionFirewall("RemoteDesktop", "null", "null");
            }
            if (_addFireWallExceptions[i].ExceptionName.Contains("FTPServer"))
            {
              configClass.GetScriptHandling.AddPortExeceptionFirewall("TCP", "21", "FTPServer");
            }
            if (_addFireWallExceptions[i].ExceptionName == "Web Server http")
            {
              configClass.GetScriptHandling.AddPortExeceptionFirewall("TCP", "80", "WebServerhttp");
            }
            if (_addFireWallExceptions[i].ExceptionName.Contains("Web Server https"))
            {
              configClass.GetScriptHandling.AddPortExeceptionFirewall("TCP", "443", "Web Server https");
            }
            if (_addFireWallExceptions[i].ExceptionName.Contains("SQLserver"))
            {
              configClass.GetScriptHandling.AddPortExeceptionFirewall("TCP", "1433", "SQL Server");
            }
            if (_addFireWallExceptions[i].ExceptionName.Contains("Exception") && _addFireWallExceptions[i].ExceptionName.Contains("PortNo:") && _addFireWallExceptions[i].ExceptionName.Contains("Protocol"))
            {
              string[] split = _addFireWallExceptions[i].ExceptionName.Split(' ');
              string name = "";
              string port = "";
              string protocol = "";

              for (int j = 0; j < split.Length-1; j++)
              {
                if (split[j].Contains("Exception"))
                {
                  j++;
                  for (int k = 0; k < split.Length-1; k++)
                  {
                    if (split[j + k] != "PortNo:")
                    {
                      name = name + split[j + k] + " ";
                    }
                    else
                    {
                      break;
                    }

                  }
                }
                if (split[j].Contains("PortNo:"))
                {
                  port = split[j + 1];
                }
                if (split[j].Contains("Protocol"))
                {
                  protocol = split[j + 2];
                }

              }
              configClass.GetScriptHandling.AddPortExeceptionFirewall(protocol, port, name);
            }
            if (_addFireWallExceptions[i].ExceptionName.Contains("Executable Path:"))
            {
              string name = "";
              string programPath = _addFireWallExceptions[i].ExceptionName.Remove(0, 17);
              string[] split = _addFireWallExceptions[i].ExceptionName.Split('\\');
              name = split[split.Length - 1];
              name = name.Replace(" ", "");
              programPath = "\"" + programPath + "\"";
              configClass.GetScriptHandling.AddExeceptionFirewall(name, programPath, "null");
            }
            
          }
        }
        #endregion Windows XP Firewall
        #region Windows version higher than XP

        else
        {
          for (int i = 0; i <= _addFireWallExceptions.Count -1; i++)
          {
            if (_addFireWallExceptions[i].ExceptionName.Contains("PcAnywhere"))
            {
            }
            if (_addFireWallExceptions[i].ExceptionName.Contains("Remote Desktop"))
            {
              configClass.GetScriptHandling.AddExeceptionFirewall("RemoteDesktop", "null", "null");
            }
            if (_addFireWallExceptions[i].ExceptionName.Contains("FTPServer"))
            {
              configClass.GetScriptHandling.AddPortExeceptionFirewall("TCP", "21", "FTPServer");
            }
            if (_addFireWallExceptions[i].ExceptionName == "Web Server http")
            {
              configClass.GetScriptHandling.AddPortExeceptionFirewall("TCP", "80", "WebServerhttp");
            }
            if (_addFireWallExceptions[i].ExceptionName.Contains("Web Server https"))
            {
              configClass.GetScriptHandling.AddPortExeceptionFirewall("TCP", "443", "Web Server https");
            }
            if (_addFireWallExceptions[i].ExceptionName.Contains("SQLserver"))
            {
              configClass.GetScriptHandling.AddPortExeceptionFirewall("TCP", "1433", "SQL Server");
            }
            if (_addFireWallExceptions[i].ExceptionName.Contains("Exception") && _addFireWallExceptions[i].ExceptionName.Contains("PortNo:") && _addFireWallExceptions[i].ExceptionName.Contains("Protocol"))
            {
              string[] split = _addFireWallExceptions[i].ExceptionName.Split(' ');
              string name = "";
              string port = "";
              string protocol = "";
              string direction = "";
              for (int j = 0; j < split.Length-1; j++)
              {
                if (split[j].Contains("Exception"))
                {
                  j++;
                  for (int k = 0; k < split.Length-1; k++)
                  {
                    if (split[j + k] != "Direction=")
                    {
                      name = name + split[j + k] + " ";
                    }
                    else
                    {
                      break;
                    }

                  }
                }
                if (split[j].Contains("Direction="))
                {
                  direction = split[j + 1];
                }
                if (split[j].Contains("PortNo:"))
                {
                  port = split[j + 1];
                }
                if (split[j].Contains("Protocol"))
                {
                  protocol = split[j + 2];
                }

              }
              configClass.GetScriptHandling.AddRuleAdvFirewallPort(name,direction,protocol,port);
            }
            if (_addFireWallExceptions[i].ExceptionName.Contains("Executable Path:"))
            {
              string name = "";
              string direction = "";
              string programPath = _addFireWallExceptions[i].ExceptionName.Remove(0, 17);
              string[] split = _addFireWallExceptions[i].ExceptionName.Split('\\');
              string[] split2 = _addFireWallExceptions[i].ExceptionName.Split(' ');
              name = split[split.Length - 1];
              name = name.Replace(" ", "");
              programPath = "\"" + programPath + "\"";
              for (int l = 0; l <= split2.Length; l++)
              {
                if (split2[l].Contains("Direction="))
                  direction = split2[l + 1];
              }
              configClass.GetScriptHandling.AddRuleAdvFirewallProgram(name, direction, programPath);
            }
            
          }
        }
        #endregion Windows version higher than XP

      }
      catch (Exception ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "Set firewall", CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Set firewall", ex.Message));

      }
    }
    public void DeleteFirewall(ConfigClass configClass)
    {
      string os = configClass.ConfSetDefaultInformation.Operatingsystem;
      try
      {
        for (int i = 0; i <= _deleteFireWallExceptions.Count -1; i++)
        {
          #region Windows XP Firewall
          if (os == "Windows XP" || os == "Windows XP 32 Bit" || os == "Windows XP 64 Bit")
          {
            if (_deleteFireWallExceptions[i].ExceptionName.Contains("PcAnywhere"))
            {
            }
            if (_deleteFireWallExceptions[i].ExceptionName.Contains("Remote Desktop"))
            {
              configClass.GetScriptHandling.DeleteExceptionFirewall("RemoteDesktop", "null", "null", "null");
            }
            if (_deleteFireWallExceptions[i].ExceptionName.Contains("FTPServer"))
            {
              configClass.GetScriptHandling.DeleteExceptionFirewall("null", "TCP", "21", "null");
            }
            if (_deleteFireWallExceptions[i].ExceptionName.Contains("Web Server http"))
            {
              configClass.GetScriptHandling.DeleteExceptionFirewall("null", "TCP", "80", "null");
            }
            if (_deleteFireWallExceptions[i].ExceptionName.Contains("Web Server https"))
            {
              configClass.GetScriptHandling.DeleteExceptionFirewall("null", "TCP", "443", "null");
            }
            if (_deleteFireWallExceptions[i].ExceptionName.Contains("SQL Server"))

            {
              configClass.GetScriptHandling.DeleteExceptionFirewall("null", "TCP", "1433", "null");
            }
            #region unnecessary

            //if (_deleteFireWallExceptions[i].ExceptionName.Contains("Exception") && _deleteFireWallExceptions[i].ExceptionName.Contains("PortNo:") && _deleteFireWallExceptions[i].ExceptionName.Contains("Protocol"))
            //{
            //  string[] split = _deleteFireWallExceptions[i].ExceptionName.Split(' ');
            //  string name = "";
            //  string port = "";
            //  string protocol = "";

            //  for (int j = 0; j < split.Length; j++)
            //  {
            //    if (split[j].Contains("Exception"))
            //    {
            //      j++;
            //      for (int k = 0; k < split.Length; k++)
            //      {
            //        if (split[j + k] != "PortNo:")
            //        {
            //          name = name + split[j + k] + " ";
            //        }
            //        else
            //        {
            //          break;
            //        }

            //      }
            //    }
            //    if (split[j].Contains("PortNo:"))
            //    {
            //      port = split[j + 1];
            //    }
            //    if (split[j].Contains("Protocol"))
            //    {
            //      protocol = split[j + 2];
            //    }

            //  }
            //  configClass.GetScriptHandling.DeleteExceptionFirewall("null", protocol, port, "null");
            //}
            //if (_deleteFireWallExceptions[i].ExceptionName.Contains("Executable Path:"))
            //{
            //  string name = "";
            //  string programPath = _deleteFireWallExceptions[i].ExceptionName.Remove(0, 17);
            //  string[] split = _deleteFireWallExceptions[i].ExceptionName.Split('\\');
            //  name = split[split.Length - 1];
            //  name = name.Replace(" ", "");
            //  programPath = "\"" + programPath + "\"";
            //  configClass.GetScriptHandling.DeleteExceptionFirewall("null", "null", "null", programPath);
            //}
            #endregion unnecessary
            else
            {
              if (!_deleteFireWallExceptions[i].ExceptionName.Contains("Remote Desktop")
                  && !_deleteFireWallExceptions[i].ExceptionName.Contains("FTPServer")
                  && !_deleteFireWallExceptions[i].ExceptionName.Contains("Web Server http")
                  && !_deleteFireWallExceptions[i].ExceptionName.Contains("Web Server https")
                  && !_deleteFireWallExceptions[i].ExceptionName.Contains("SQLserver")
                  && !_deleteFireWallExceptions[i].ExceptionName.Contains("PcAnywhere"))
              {
                string[] split = _deleteFireWallExceptions[i].ExceptionName.Split(' ');
                string port = "";
                string protocol = "";
                string programPath = "";
                for (int j = 0; j < split.Length; j++)
                {
                  if (split[j].Contains("TCP") || split[j].Contains("UDP"))
                  {
                    protocol = split[j];
                    port = split[j + 2];
                    configClass.GetScriptHandling.DeleteExceptionFirewall("null", protocol, port, "null");
                  }
                  if (split[j].Contains("-"))
                  {
                    int indexForSplitString = _deleteFireWallExceptions[i].ExceptionName.IndexOf("-");
                    programPath = _deleteFireWallExceptions[i].ExceptionName.Substring(indexForSplitString + 2, _deleteFireWallExceptions[i].ExceptionName.Length - indexForSplitString - 2);
                    configClass.GetScriptHandling.DeleteExceptionFirewall("null", "null", "null", programPath);
                  }
                }
              }
            }
          }
          #endregion Windows XP Firewall
          #region Windows with version higher than XP

          else
          {
            if (_deleteFireWallExceptions[i].ExceptionName.Contains("PcAnywhere"))
            {
            }
            if (_deleteFireWallExceptions[i].ExceptionName.Contains("Remote Desktop"))
            {
              configClass.GetScriptHandling.DeleteRuleAdvFirewall("RemoteDesktop (TCP-In)");
            }
            if (_deleteFireWallExceptions[i].ExceptionName.Contains("FTPServer"))
            {
              configClass.GetScriptHandling.DeleteRuleAdvFirewall("FTPServer");
            }
            if (_deleteFireWallExceptions[i].ExceptionName.Contains("Web Server http"))
            {
              configClass.GetScriptHandling.DeleteRuleAdvFirewall("Web Server http");
            }
            if (_deleteFireWallExceptions[i].ExceptionName.Contains("Web Server https"))
            {
              configClass.GetScriptHandling.DeleteRuleAdvFirewall("Web Server https");
            }
            if (_deleteFireWallExceptions[i].ExceptionName.Contains("SQLserver"))
            {
              configClass.GetScriptHandling.DeleteRuleAdvFirewall("SQLserver");
            }
            else
            {
              if (!_deleteFireWallExceptions[i].ExceptionName.Contains("Remote Desktop")
                  && !_deleteFireWallExceptions[i].ExceptionName.Contains("FTPServer")
                  && !_deleteFireWallExceptions[i].ExceptionName.Contains("Web Server http")
                  && !_deleteFireWallExceptions[i].ExceptionName.Contains("Web Server https")
                  && !_deleteFireWallExceptions[i].ExceptionName.Contains("SQLserver")
                  && !_deleteFireWallExceptions[i].ExceptionName.Contains("PcAnywhere"))
              {
                string[] split = _deleteFireWallExceptions[i].ExceptionName.Split(' ');                
                string ruleName = "";
                for (int j = 0; j <= split.Length - 1; j++)
                {
                  for (int k = 0; k <= split.Length - 1; k++)
                  {
                    if (split[j + k] != "Enabled")
                    {
                      ruleName = ruleName + split[j + k] + " ";                      
                    }                      
                    else
                    {
                      break;
                    }
                  }                  
                }
                ruleName = ruleName.Trim();
                configClass.GetScriptHandling.DeleteRuleAdvFirewall(ruleName);
              }
            }
          }
          #endregion Windows with version higher than XP
        }
      }
      catch (Exception ex)
      {

        Actemium.Diagnostics.Trace.WriteError(ex.Message, "DeleteUser", CLASSNAME);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Delete User", ex.Message));

      }

    }
    public void ModifyFirewallRules(ConfigClass configClass)
    {
      const string FUNCTIONNAME = "ModifyFirewallRule";
      try
      {
        Actemium.Diagnostics.Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
        for (int i = 0; i <= _modifyFirewallRule.Count - 1; i++)
        {
          configClass.GetScriptHandling.ModifyFirewallRule(_modifyFirewallRule[i].oldRuleName, _modifyFirewallRule[i].NewRuleName, _modifyFirewallRule[i].IsRuleEnable, _modifyFirewallRule[i].RuleDirection, _modifyFirewallRule[i].RuleProtocol, _modifyFirewallRule[i].RulePort, _modifyFirewallRule[i].RuleAction);
        
        }
        //foreach (ModifyFirewall firewallRuleToModify in _modifyFirewallRule)
        //{
        //  configClass.GetScriptHandling.ModifyFirewallRule(firewallRuleToModify.oldRuleName, firewallRuleToModify.NewRuleName, firewallRuleToModify.IsRuleEnable, firewallRuleToModify.RuleDirection, firewallRuleToModify.RuleProtocol, firewallRuleToModify.RulePort, firewallRuleToModify.RuleAction);
        //}


      }
      catch (Exception ex)
      {

        Actemium.Diagnostics.Trace.WriteError("()", FUNCTIONNAME, CLASSNAME, ex);
        throw;
      }
    }
    public bool CheckFirewallExeceptions(ConfigClass configClass)
    {
      bool totalcheck = true;
      try
      {
        configClass.GetScriptHandling.putAllLocalFireWallExceptionsToList();
        List<bool> check = new List<bool>();

        foreach (FireWallException exeptions in _fireWallExceptions)
        {
          #region firewallEnabledOrDisabled
          if (exeptions.ExceptionName.Contains("Firewall ingeschakeld"))
          {
            bool chk = false;
            foreach (string str in configClass.GetScriptHandling.GetAllLocalFirewallExceptions)
            {

              if (str.Contains("Operationele modus") && str.Contains("Inschakelen"))
              {
                chk = true;
                break;
              }
              else if (str.Contains("Operational mode") && str.Contains("Enable"))
              {
                chk = true;
                break;
              }
              else
              {
                chk = false;
              }
            }
            check.Add(chk);
          }
          #endregion firewallEnabledOrDisabled
          #region RemoteEnabledOrDisabled
          if (exeptions.ExceptionName.Contains("Remote Desktop"))
          {
            bool chk = false;
            foreach (string str in configClass.GetScriptHandling.GetAllLocalFirewallExceptions)
            {

              if (str.Contains("Remote-Control Mode") && str.Contains("Enable"))
              {
                chk = true;
                break;
              }
              else if (str.Contains("Remote admin mode") && str.Contains("Enable"))
              {
                chk = true;
                break;
              }
              else
              {
                chk = false;
              }
            }
            check.Add(chk);
          }

          #endregion RemoteEnabledOrDisabled
          #region FTP Server
          if (exeptions.ExceptionName.Contains("FTP Server"))
          {
            bool chk = false;
            foreach (string str in configClass.GetScriptHandling.GetAllLocalFirewallExceptions)
            {

              if (str.Contains("21") && str.Contains("TCP"))
              {
                chk = true;
                break;
              }
              else
              {
                chk = false;
              }
            }
            check.Add(chk);
          }
          #endregion FTP Server
          #region Web Server http -protocol
          if (exeptions.ExceptionName.Contains("Web Server http -protocol"))
          {
            bool chk = false;
            foreach (string str in configClass.GetScriptHandling.GetAllLocalFirewallExceptions)
            {

              if (str.Contains("80") && str.Contains("TCP"))
              {
                chk = true;
                break;
              }
              else
              {
                chk = false;
              }
            }
            check.Add(chk);
          }
          #endregion Web Server http -protocol
          #region Web Server https -protocol
          if (exeptions.ExceptionName.Contains("Web Server http -protocol"))
          {
            bool chk = false;
            foreach (string str in configClass.GetScriptHandling.GetAllLocalFirewallExceptions)
            {

              if (str.Contains("443") && str.Contains("TCP"))
              {
                chk = true;
                break;
              }
              else
              {
                chk = false;
              }
            }
            check.Add(chk);
          }
          #endregion Web Server https -protocol
          #region SQL Server
          if (exeptions.ExceptionName.Contains("SQL Server"))
          {
            bool chk = false;
            foreach (string str in configClass.GetScriptHandling.GetAllLocalFirewallExceptions)
            {

              if (str.Contains("1433") && str.Contains("TCP"))
              {
                chk = true;
                break;
              }
              else
              {
                chk = false;
              }
            }
            check.Add(chk);
          }
          #endregion SQL Server
          #region own added port

          if (exeptions.ExceptionName.Contains("exception") && exeptions.ExceptionName.Contains("Protocol"))
          {
            string[] split = exeptions.ExceptionName.Split(' ');
            string name = "";
            string port = "";
            string protocol = "";

            for (int j = 0; j < split.Length; j++)
            {
              if (split[j].Contains("exception"))
              {
                j++;
                for (int k = 0; k < split.Length; k++)
                {
                  if (split[j + k] != "Portnr.:")
                  {
                    name = name + split[j + k] + " ";
                  }
                  else
                  {
                    break;
                  }

                }
              }
              if (split[j].Contains("Portnr.:"))
              {
                port = split[j + 1];
              }
              if (split[j].Contains("Protocol"))
              {
                protocol = split[j + 2];
              }
            }
            bool chk = false;

            foreach (string str in configClass.GetScriptHandling.GetAllLocalFirewallExceptions)
            {

              if (str.Contains(port) && str.Contains(protocol))
              {
                chk = true;
                break;
              }
              else
              {
                chk = false;
              }
            }
            check.Add(chk);

          }
          #endregion own added port
          #region added Executable
          if (exeptions.ExceptionName.Contains("Executable Path:"))
          {
            string[] split = exeptions.ExceptionName.Split('\\');
            string exec = split[split.Length - 1];
            bool chk = false;
            foreach (string str in configClass.GetScriptHandling.GetAllLocalFirewallExceptions)
            {

              if (str.Contains(exec))
              {
                chk = true;
                break;
              }
              else
              {
                chk = false;
              }
            }
            check.Add(chk);
          }
          #endregion added Executable

        }

        foreach (bool b in check)
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
        Actemium.Diagnostics.Trace.WriteError("({0})", "Set firewall", CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Set firewall", ex.Message));

      }
      return totalcheck;
    }

  }
}
