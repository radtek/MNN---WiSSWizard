using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Actemium.Diagnostics;

namespace Actemium.WiSSWizard
{
  public class PasswordPolicy
  {
    //parameters
    private const string CLASSNAME = "PasswordPolicy";
    private List<string> _checkStringsInPassWordPolicy_INFfile = new List<string>();
    private List<bool> _checkPasswordPolicy = new List<bool>();
    private List<string> _getAllCurrentPasswordPolicy = new List<string>();
    private List<string> _allPasswordPolicies = new List<string>();
    private string _INFfile = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\PasswordPolicySettings.INF";

    //constructor
    public PasswordPolicy()
    {

    }

    //properties
    public int MaximumPasswordAge
    {
      get
      {
        return _maximumPasswordAge;
      }
      set
      {
        _maximumPasswordAge = value;
      }
    } private int _maximumPasswordAge = -1;
    public int MinimumPasswordAge
    {
      get
      {
        return _minimumPasswordAge;
      }
      set
      {
        _minimumPasswordAge = value;
      }
    } private int _minimumPasswordAge = -1;
    public int MinimumPasswordLength
    {
      get
      {
        return _minimumPasswordLength;
      }
      set
      {
        _minimumPasswordLength = value;
      }
    } private int _minimumPasswordLength = -1;
    public int PasswordHistorySize
    {
      get
      {
        return _passwordHistorySize;
      }
      set
      {
        _passwordHistorySize = value;
      }
    } private int _passwordHistorySize = -1;
    public int PasswordComplexity
    {
      get
      {
        return _passwordComplexity;
      }
      set
      {
        _passwordComplexity = value;
      }
    } private int _passwordComplexity = -1;
    public int ClearTextPassword
    {
      get
      {
        return _clearTextPassword;
      }
      set
      {
        _clearTextPassword = value;
      }
    } private int _clearTextPassword = -1;

    //methods
    public List<string> ShowAllPasswordPolicies
    {
      get
      {
        return _allPasswordPolicies;
      }
    }
    public void SetPasswordPolicy(ConfigClass configClass)
    {
      try
      {
        Trace.WriteVerbose("({0})", "MainPasswordPolicy", CLASSNAME);

        string write = "";
        File.Delete(_INFfile);

        FileHandling _fileHandling = new FileHandling();
        _fileHandling.CreateFile(_INFfile);
        _fileHandling.AddLineToEndFile(_INFfile, "[Version]");
        _fileHandling.AddLineToEndFile(_INFfile, "signature=\"$CHICAGO$\"");
        _fileHandling.AddLineToEndFile(_INFfile, "Revision=1");
        _fileHandling.AddLineToEndFile(_INFfile, "");
        write = "[System Access]";
        _fileHandling.AddLineToEndFile(_INFfile, write);
        _checkStringsInPassWordPolicy_INFfile.Add(write);


        if (MaximumPasswordAge != -1)
        #region
        {
          write = "MaximumPasswordAge = " + _maximumPasswordAge.ToString();
          _fileHandling.AddLineToEndFile(_INFfile, write);
          _checkStringsInPassWordPolicy_INFfile.Add(write);
        }
        #endregion

        if (_minimumPasswordAge != -1)
        #region
        {
          write = "MinimumPasswordAge = " + _minimumPasswordAge.ToString();
          _fileHandling.AddLineToEndFile(_INFfile, write);
          _checkStringsInPassWordPolicy_INFfile.Add(write);
        }
        #endregion

        if (_minimumPasswordLength != -1)
        #region
        {
          write = "MinimumPasswordLength = " + _minimumPasswordLength.ToString();
          _fileHandling.AddLineToEndFile(_INFfile, write);
          _checkStringsInPassWordPolicy_INFfile.Add(write);
        }
        #endregion

        if (_passwordHistorySize != -1)
        #region
        {
          write = "PasswordHistorySize = " + _passwordHistorySize.ToString();
          _fileHandling.AddLineToEndFile(_INFfile, write);
          _checkStringsInPassWordPolicy_INFfile.Add(write);
        }
        #endregion

        if (_passwordComplexity != -1)
        #region
        {
          write = "PasswordComplexity = " + _passwordComplexity.ToString();
          _fileHandling.AddLineToEndFile(_INFfile, write);
          _checkStringsInPassWordPolicy_INFfile.Add(write);
        }
        #endregion

        if (_clearTextPassword != -1)
        #region
        {
          write = "ClearTextPassword = " + _clearTextPassword.ToString();
          _fileHandling.AddLineToEndFile(_INFfile, write);
          _checkStringsInPassWordPolicy_INFfile.Add(write);
        }
        #endregion
        _checkPasswordPolicy.Add(configClass.GetScriptHandling.RunINFfilePasswordAndControlPolicy(_INFfile));
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", "Make password policy settings", CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Make password policy settings", ex.Message));
      }
    }
    
    public bool CheckPasswordPolicy(ConfigClass configClass)
    {
      bool totalcheck = true;
      try
      {

        Trace.WriteVerbose("()", "MainCheckPasswordPolicy", CLASSNAME);
        FileHandling _fileHandling = new FileHandling();
        string _INFfile = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\PasswordPolicySettings.INF";
        List<string> passwordPolicy = new List<string>();
        passwordPolicy = _fileHandling.ReadInLogFile(_INFfile, "[System Access]", "");

        foreach (string str in passwordPolicy)
        {         
          if (_checkStringsInPassWordPolicy_INFfile.Contains(str))
          {
            _checkPasswordPolicy.Add(true);
          }
          else
          {
            _checkPasswordPolicy.Add(false);
          }
        }
        //File.Delete(_INFfile);

        foreach (bool b in _checkPasswordPolicy)
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
        Trace.WriteError("({0})", "Check password policy", CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check password policy", ex.Message));
        totalcheck = false;
        return totalcheck;
      }
    }
   
    
    
  }
}
