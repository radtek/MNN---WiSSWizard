using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Actemium.Diagnostics;

namespace Actemium.WiSSWizard
{
  public class AuditPolicy
  {
    //parameters
    private const string CLASSNAME = "AuditPolicy";
    private List<string> _checkStringsInAuditPolicyINFfile = new List<string>();
    private List<bool> _checkAuditPolicy = new List<bool>();
    private List<bool> _checkPolicySettings = new List<bool>();
    private string _INFfile = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\ConfigFiles\AuditPolicySettings.INF";

    //constructor
    public AuditPolicy()
    { }

    //properties
    public int AuditLogonEvents
    {
      get
      {
        return _auditLogonEvents;
      }
      set
      {
        _auditLogonEvents = value;
      }
    } private int _auditLogonEvents = -1;
    public int AuditAccountLogon
    {
      get
      {
        return _auditAccountLogon;
      }
      set
      {
        _auditAccountLogon = value;
      }
    } private int _auditAccountLogon = -1;
    public int AuditAccountManage
    {
      get
      {
        return _auditAccountManage;
      }
      set
      {
        _auditAccountManage = value;
      }
    } private int _auditAccountManage = -1;
    public int AuditDSAccess
    {
      get
      {
        return _auditDSAccess;
      }
      set
      {
        _auditDSAccess = value;
      }
    } private int _auditDSAccess = -1;
    public int AuditPolicyChange
    {
      get
      {
        return _auditPolicyChange;
      }
      set
      {
        _auditPolicyChange = value;
      }
    } private int _auditPolicyChange = -1;
    public int AuditPrivilegeUse
    {
      get
      {
        return _auditPrivilegeUse;
      }
      set
      {
        _auditPrivilegeUse = value;
      }
    } private int _auditPrivilegeUse = -1;
    public int AuditObjectAccess
    {
      get
      {
        return _auditObjectAccess;
      }
      set
      {
        _auditObjectAccess = value;
      }
    } private int _auditObjectAccess = -1;
    public int AuditProcessTracking
    {
      get
      {
        return _auditProcessTracking;
      }
      set
      {
        _auditProcessTracking = value;
      }
    } private int _auditProcessTracking = -1;
    public int AuditSystemEvents
    {
      get
      {
        return _auditSystemEvents;
      }
      set
      {
        _auditSystemEvents = value;
      }
    } private int _auditSystemEvents = -1;

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


    //methoden
    public void CompleteAuditPolicy(ConfigClass configClass)
    {
      try
      {
        Actemium.Diagnostics.Trace.WriteVerbose("({0})", "CompleteAuditPolicy", CLASSNAME);

        string write = "";
        if (File.Exists(_INFfile))
        {
          File.Delete(_INFfile);
        }
        FileHandling _fh = new FileHandling();
        _fh.CreateFile(_INFfile);
        _fh.AddLineToEndFile(_INFfile, "[Version]");
        _fh.AddLineToEndFile(_INFfile, "signature=\"$CHICAGO$\"");
        _fh.AddLineToEndFile(_INFfile, "Revision=1");
        _fh.AddLineToEndFile(_INFfile, "");
        write = "[Event Audit]";
        _fh.AddLineToEndFile(_INFfile, write);
        _checkStringsInAuditPolicyINFfile.Add(write);

        #region Control Policy
        if (_auditLogonEvents != -1)
        #region
        {
          if (_auditLogonEvents == 0)
          {
            write = "AuditLogonEvents = 0";
          }
          if (_auditLogonEvents == 1)
          {
            write = "AuditLogonEvents = 1";
          }
          if (_auditLogonEvents == 2)
          {
            write = "AuditLogonEvents = 2";
          }
          if (_auditLogonEvents == 3)
          {
            write = "AuditLogonEvents = 3";
          }
          _fh.AddLineToEndFile(_INFfile, write);
          _checkStringsInAuditPolicyINFfile.Add(write);
        }
        #endregion

        if (_auditAccountLogon != -1)
        #region
        {
          if (_auditAccountLogon == 0)
          {
            write = "AuditAccountLogon = 0";
          }
          if (_auditAccountLogon == 1)
          {
            write = "AuditAccountLogon = 1";
          }
          if (_auditAccountLogon == 2)
          {
            write = "AuditAccountLogon = 2";
          }
          if (_auditAccountLogon == 3)
          {
            write = "AuditAccountLogon = 3";
          }
          _fh.AddLineToEndFile(_INFfile, write);
          _checkStringsInAuditPolicyINFfile.Add(write);
        }
        #endregion

        if (_auditAccountManage != -1)
        #region
        {
          if (_auditAccountManage == 0)
          {
            write = "AuditAccountManage = 0";
          }
          if (_auditAccountManage == 1)
          {
            write = "AuditAccountManage = 1";
          }
          if (_auditAccountManage == 2)
          {
            write = "AuditAccountManage = 2";
          }
          if (_auditAccountManage == 3)
          {
            write = "AuditAccountManage = 3";
          }
          _fh.AddLineToEndFile(_INFfile, write);
          _checkStringsInAuditPolicyINFfile.Add(write);
        }
        #endregion

        if (_auditDSAccess != -1)
        #region
        {
          if (_auditDSAccess == 0)
          {
            write = "AuditDSAccess = 0";
          }
          if (_auditDSAccess == 1)
          {
            write = "AuditDSAccess = 1";
          }
          if (_auditDSAccess == 2)
          {
            write = "AuditDSAccess = 2";
          }
          if (_auditDSAccess == 3)
          {
            write = "AuditDSAccess = 3";
          }
          _fh.AddLineToEndFile(_INFfile, write);
          _checkStringsInAuditPolicyINFfile.Add(write);
        }
        #endregion

        if (_auditPolicyChange != -1)
        #region
        {
          if (_auditPolicyChange == 0)
          {
            write = "AuditPolicyChange = 0";
          }
          if (_auditLogonEvents == 1)
          {
            write = "AuditPolicyChange = 1";
          }
          if (_auditLogonEvents == 2)
          {
            write = "AuditPolicyChange = 2";
          }
          if (_auditLogonEvents == 3)
          {
            write = "AuditPolicyChange = 3";
          }
          _fh.AddLineToEndFile(_INFfile, write);
          _checkStringsInAuditPolicyINFfile.Add(write);
        }
        #endregion

        if (_auditPrivilegeUse != -1)
        #region
        {
          if (_auditPrivilegeUse == 0)
          {
            write = "AuditPrivilegeUse  = 0";
          }
          if (_auditPrivilegeUse == 1)
          {
            write = "AuditPrivilegeUse  = 1";
          }
          if (_auditPrivilegeUse == 2)
          {
            write = "AuditPrivilegeUse  = 2";
          }
          if (_auditPrivilegeUse == 3)
          {
            write = "AuditPrivilegeUse  = 3";
          }
          _fh.AddLineToEndFile(_INFfile, write);
          _checkStringsInAuditPolicyINFfile.Add(write);
        }
        #endregion

        if (_auditObjectAccess != -1)
        #region
        {
          if (_auditObjectAccess == 0)
          {
            write = "AuditObjectAccess= 0";
          }
          if (_auditObjectAccess == 1)
          {
            write = "AuditObjectAccess = 1";
          }
          if (_auditObjectAccess == 2)
          {
            write = "AuditObjectAccess = 2";
          }
          if (_auditObjectAccess == 3)
          {
            write = "AuditObjectAccess = 3";
          }
          _fh.AddLineToEndFile(_INFfile, write);
          _checkStringsInAuditPolicyINFfile.Add(write);
        }
        #endregion

        if (_auditProcessTracking != -1)
        #region
        {
          if (_auditProcessTracking == 0)
          {
            write = "AuditProcessTracking = 0";
          }
          if (_auditProcessTracking == 1)
          {
            write = "AuditProcessTracking = 1";
          }
          if (_auditProcessTracking == 2)
          {
            write = "AuditProcessTracking = 2";
          }
          if (_auditProcessTracking == 3)
          {
            write = "AuditProcessTracking = 3";
          }
          _fh.AddLineToEndFile(_INFfile, write);
          _checkStringsInAuditPolicyINFfile.Add(write);
        }
        #endregion

        if (_auditSystemEvents != -1)
        #region
        {
          if (_auditSystemEvents == 0)
          {
            write = "AuditSystemEvents = 0";
          }
          if (_auditSystemEvents == 1)
          {
            write = "AuditSystemEvents = 1";
          }
          if (_auditSystemEvents == 2)
          {
            write = "AuditSystemEvents = 2";
          }
          if (_auditSystemEvents == 3)
          {
            write = "AuditSystemEvents = 3";
          }
          _fh.AddLineToEndFile(_INFfile, write);
          _checkStringsInAuditPolicyINFfile.Add(write);
        }
        #endregion
        #endregion Control Policy
        _checkAuditPolicy.Add(configClass.GetScriptHandling.RunINFfilePasswordAndControlPolicy(_INFfile));
      }
      catch (Exception ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "Make audit policy Settings", CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Make audit policy Settings", ex.Message));
      }
    }
    public bool CheckAuditPolicy(ConfigClass configClass)
    {
      bool totalcheck = true;
      try
      {
        Actemium.Diagnostics.Trace.WriteVerbose("()", "CheckAuditPolicy", CLASSNAME);
        FileHandling _fh = new FileHandling();

        List<string> auditPolicy = new List<string>();
        auditPolicy = _fh.ReadInLogFile(_INFfile, "[Event Audit]", "");

        foreach (string str in auditPolicy)
        {
          if (_checkStringsInAuditPolicyINFfile.Contains(str))
          {
            _checkAuditPolicy.Add(true);
          }
          else
          {
            _checkAuditPolicy.Add(false);
          }
        }
        //File.Delete(_INFfile);

        foreach (bool b in _checkAuditPolicy)
        {
          if (!b)
          {
            totalcheck = false;
            return totalcheck;
          }
        }
        return totalcheck;
      }
      catch (Exception ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "Check Audit policy", CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check Audit policy", ex.Message));
        totalcheck = false;
        return totalcheck;
      }
    }
    






  }
}