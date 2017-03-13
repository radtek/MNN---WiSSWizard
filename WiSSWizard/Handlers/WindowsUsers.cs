using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using Actemium.Diagnostics;
using System.Security.Principal;
using System.DirectoryServices.AccountManagement;
using System.Threading;

namespace Actemium.WiSSWizard
{
  public class ExistedUser
  {
    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        _name = value;
      }
    } private string _name;
    public string Fullname
    {
      get
      {
        return _fullname;
      }
      set
      {
        _fullname = value;
      }
    }private string _fullname = "";
    public string Description
    {
      get
      {
        return _description;
      }
      set
      {
        _description = value;
      }
    } private string _description;
    /// <summary>
    /// Get or set Groups
    /// </summary>
    public string Groups
    {
      get { return _groups; }
      set { _groups = value; }
    } private string _groups; 

    public ExistedUser()
    { }
    public ExistedUser(string name, string fullname, string description)
    {
      _name = name;
      _fullname = fullname;
      _description = description;
    }
  }

  [Serializable]
  public class NewUser
  {
    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        _name = value;
      }
    } private string _name;
    public string Fullname
    {
      get
      {
        return _fullname;
      }
      set
      {
        _fullname = value;
      }
    }private string _fullname = "";
    public string Description
    {
      get
      {
        return _description;
      }
      set
      {
        _description = value;
      }
    } private string _description;
    public List<string> UserGroupList
    {
      get
      {
        return _usergroupList;
      }
      set
      {
        _usergroupList = value;
      }
    } private List<string> _usergroupList;
    public string ChangePwNextLogon
    {
      get
      {
        return _changePwNextLogon;
      }
      set
      {
        _changePwNextLogon = value;
      }
    } private string _changePwNextLogon = "";
    public string PasswordCantBeChanged
    {
      get
      {
        return _passwordCantBeChanged;
      }
      set
      {
        _passwordCantBeChanged = value;
      }
    } private string _passwordCantBeChanged = "";
    public string PasswordNeverExpires
    {
      get
      {
        return _passwordNeverExpires;
      }
      set
      {
        _passwordNeverExpires = value;
      }
    } private string _passwordNeverExpires = "";
    public string AccountDisabled
    {
      get
      {
        return _accountDisabled;
      }
      set
      {
        _accountDisabled = value;
      }
    } private string _accountDisabled = "";
    public string Password
    {
      get
      {
        return _password;
      }
      set
      {
        _password = value;
      }
    } private string _password = "";
    public NewUser()
    { }
    public NewUser(string name, string fullname, string description, List<string> usergroupList, string changePwNextLogon, string passwordCantBeChanged, string passwordNeverExpires, string accountDisabled, string password)
    {
      _name = name;
      _fullname = fullname;
      _description = description;
      _usergroupList = usergroupList;
      _changePwNextLogon = changePwNextLogon;
      _passwordCantBeChanged = passwordCantBeChanged;
      _passwordNeverExpires = passwordNeverExpires;
      _accountDisabled = accountDisabled;
      _password = password;

    }
  }
  [Serializable]
    
  public class ModfiedUser
  {
    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        _name = value;
      }
    } private string _name;
    public string Fullname
    {
      get
      {
        return _fullname;
      }
      set
      {
        _fullname = value;
      }
    }private string _fullname = "";
    public string Description
    {
      get
      {
        return _description;
      }
      set
      {
        _description = value;
      }
    } private string _description;
    public string ChangePwNextLogon
    {
      get
      {
        return _changePwNextLogon;
      }
      set
      {
        _changePwNextLogon = value;
      }
    } private string _changePwNextLogon = "";
    public string PasswordCantBeChanged
    {
      get
      {
        return _passwordCantBeChanged;
      }
      set
      {
        _passwordCantBeChanged = value;
      }
    } private string _passwordCantBeChanged = "";
    public string PasswordNeverExpires
    {
      get
      {
        return _passwordNeverExpires;
      }
      set
      {
        _passwordNeverExpires = value;
      }
    } private string _passwordNeverExpires = "";
    public string AccountDisabled
    {
      get
      {
        return _accountDisabled;
      }
      set
      {
        _accountDisabled = value;
      }
    } private string _accountDisabled = "";
    public string ModifyOtherSettings
    {
      get
      {
        return _modifyOtherSettings;
      }
      set
      {
        _modifyOtherSettings = value;
      }
    } private string _modifyOtherSettings = "";
    public string Password
    {
      get
      {
        return _password;
      }
      set
      {
        _password = value;
      }
    } private string _password = "";
    public List<string> UserGroupList
    {
      get
      {
        return _usergroupList;
      }
      set
      {
        _usergroupList = value;
      }
    } private List<string> _usergroupList;
    

    public ModfiedUser()
    { }
    public ModfiedUser(string name, string fullname, string description,List<string> usergroupList, string changePwNextLogon, string passwordCantBeChanged, string passwordNeverExpires, string accountDisabled, string password, string modifyOtherSettings)
    {
      _name = name;
      _fullname = fullname;
      _description = description;
      _changePwNextLogon = changePwNextLogon;
      _usergroupList = usergroupList;
      _passwordCantBeChanged = passwordCantBeChanged;
      _passwordNeverExpires = passwordNeverExpires;
      _accountDisabled = accountDisabled;
      _modifyOtherSettings = modifyOtherSettings;
      _password = password;

    }
  }
  [Serializable]
  public class DeletedUser
  {
    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        _name = value;
      }
    } private string _name;

    public DeletedUser()
    { }
    public DeletedUser(string name)
    {
      _name = name;
    }
  }
  [Serializable]
  public class WindowsUsers
  {
    //parameters
    private const string CLASSNAME = "WindowsUsers";
    private List<ExistedUser> _existedUsers = new List<ExistedUser>();
    private List<DeletedUser> _deletedUsers = new List<DeletedUser>();
    private List<NewUser> _newUsers = new List<NewUser>();
    
    private List<ModfiedUser> _modifiedUsers = new List<ModfiedUser>();
    private bool _checkUsers = true;

    private EncryptionPassword _encryptionPassword;

    //constructor
    public WindowsUsers()
    { }
    public WindowsUsers(ConfigClass configClass)
    {
      _encryptionPassword = new EncryptionPassword(configClass);
      if (!File.Exists(_encryptionPassword.FilePath))
      {
        _encryptionPassword.CreateEncryptedKeyFile();
      }
    }

    //properties
    public bool SavePasswordsInLogfile
    {
      get
      {
        return _savePasswordsInLogfile;
      }
      set
      {
        _savePasswordsInLogfile = value;
      }
    }private bool _savePasswordsInLogfile = false;

    [XmlIgnoreAttribute()]
    public bool DefaultGuestAccountInUse
    {
      get
      {
        return _defaultGuestAccountInUse;
      }
      set
      {
        _defaultGuestAccountInUse = value;
      }

    } private bool _defaultGuestAccountInUse = false;
    [XmlIgnoreAttribute()]
    public bool DefaultSupportAccountInUse
    {
      get
      {
        return _defaultSupportAccountInUse;
      }
      set
      {
        _defaultSupportAccountInUse = value;
      }

    } private bool _defaultSupportAccountInUse = false;
    [XmlIgnoreAttribute()]
    public bool DefaultAdministratorAccountInUse
    {
      get
      {
        return _defaultAdministratorAccountInUse;
      }
      set
      {
        _defaultAdministratorAccountInUse = value;
      }
    } private bool _defaultAdministratorAccountInUse = false;

    [XmlIgnoreAttribute()]
    public string EncryptionPath
    {
      get
      {
        return _encryptionPassword.FilePath;
      }
    }
    public List<ExistedUser> ExistedUsers(ConfigClass configClass)
    {

      configClass.GetScriptHandling.putAllLocalUsersToList();
      _existedUsers = configClass.GetScriptHandling.GetAllLocalUsers;
      return _existedUsers;

    }

    public List<DeletedUser> DeletedUsers
    {
      get
      {
        return _deletedUsers;
      }
    }
    [XmlIgnoreAttribute()]
    public DeletedUser AddDeletedUser
    {
      set
      {
        _deletedUsers.Add(value);
      }
    }

    public List<NewUser> NewUsers
    {
      get
      {
        return _newUsers;
      }
    }
    
    [XmlIgnoreAttribute()]


    public NewUser AddNewUser
    {
      set
      {
        NewUser user = value;
        string Password = "";
        if (SavePasswordsInLogfile || user.Password == "PassWordIsEncrypted")
        {
          _newUsers.Add(value);
        }
        else
        {
          _encryptionPassword.AddKey(user.Name, user.Password);
          Password = "PassWordIsEncrypted";
          user.Password = Password;
          _newUsers.Add(user);
        }

      }
    }
    

    public List<ModfiedUser> ModifiedUsers
    {
      get
      {
        return _modifiedUsers;
      }
    }
    [XmlIgnoreAttribute()]
    public ModfiedUser AddModifiedUser
    {
      set
      {
        ModfiedUser user = value;
        string Password = "";

        foreach (ModfiedUser modUser in _modifiedUsers)
        {
          if (modUser.Name == user.Name)
          {
            _modifiedUsers.Remove(modUser);
            break;
          }
        }
        if (user.Password != "-1")
        {
          if (SavePasswordsInLogfile || user.Password == "PassWordIsEncrypted")
          {
            _modifiedUsers.Add(value);
          }
          else
          {
            _encryptionPassword.AddKey(user.Name, user.Password);
            Password = "PassWordIsEncrypted";
            user.Password = Password;
            _modifiedUsers.Add(user);
          }
        }
        else
        {
          _modifiedUsers.Add(value);
        }
      }
    }

    //methods
    public bool CheckIfUserExist(string name, ConfigClass configClass)
    {
      bool check = false;
      foreach (ExistedUser user in ExistedUsers(configClass))
      {
        if (string.Equals(user.Name, name, StringComparison.OrdinalIgnoreCase))
        {
          check = true;
          break;
        }
      }
      return check;
    }
    public string CheckIfSUPPORTaccountExist(ConfigClass configClass)
    {
      string SUPPORTaccount = "";
      foreach (ExistedUser user in ExistedUsers(configClass))
      {
        if (user.Name.Contains("SUPPORT"))
        {
          SUPPORTaccount = user.Name;
          break;
        }
      }
      return SUPPORTaccount;
    }
    public bool CheckIfUserInNewList(string name)
    {
      bool check = false;
      foreach (NewUser user in _newUsers)
      {
        if (string.Equals(user.Name, name, StringComparison.OrdinalIgnoreCase))
        {
          check = true;
        }
      }
      return check;
    }
    

    public void CheckIfPassWordsAreEncrypted(bool Encrypted)
    {
      if (Encrypted)
      {
        #region newusers
        List<NewUser> changePWnewUser = new List<NewUser>();
        foreach (NewUser user in _newUsers)
        {
          if (user.Password == "PassWordIsEncrypted")
          {
            changePWnewUser.Add(user);
          }
        }
        foreach (NewUser change in changePWnewUser)
        {
          _newUsers.Remove(change);
          NewUser temp = change;
          temp.Password = _encryptionPassword.GetKey(temp.Name);
          _newUsers.Add(temp);
        }
        #endregion newusers

        #region modifiedusers
        List<ModfiedUser> changePWmodifiedUser = new List<ModfiedUser>();
        foreach (ModfiedUser user in _modifiedUsers)
        {
          if (user.Password == "PassWordIsEncrypted")
          {
            changePWmodifiedUser.Add(user);
          }
        }

        foreach (ModfiedUser change in changePWmodifiedUser)
        {
          if (change.Password != "-1")
          {
            _modifiedUsers.Remove(change);
            ModfiedUser temp = change;
            temp.Password = _encryptionPassword.GetKey(temp.Name);
            _modifiedUsers.Add(temp);
          }
        }
        #endregion modifiedusers


      }
      else
      {
        #region newUsers
        List<NewUser> changePWnewUser = new List<NewUser>();
        foreach (NewUser user in _newUsers)
        {
          if (user.Password != "PassWordIsEncrypted")
          {
            changePWnewUser.Add(user);
          }
        }
        foreach (NewUser change in changePWnewUser)
        {
          _newUsers.Remove(change);
          NewUser temp = change;
          _encryptionPassword.AddKey(change.Name, change.Password);
          temp.Password = "PassWordIsEncrypted";
          _newUsers.Add(temp);
        }
        #endregion newUsers

        #region modifiedUsers
        List<ModfiedUser> changePWmodifiedUser = new List<ModfiedUser>();
        foreach (ModfiedUser user in _modifiedUsers)
        {
          if (user.Password != "-1")
          {
            if (user.Password != "PassWordIsEncrypted")
            {
              changePWmodifiedUser.Add(user);
            }
          }
        }
        foreach (ModfiedUser change in changePWmodifiedUser)
        {
          _modifiedUsers.Remove(change);
          ModfiedUser temp = change;
          _encryptionPassword.AddKey(change.Name, change.Password);
          temp.Password = "PassWordIsEncrypted";
          _modifiedUsers.Add(temp);
        }
        #endregion modifiedUsers
      }
    }
    public void DeleteUsers(ConfigClass configClass)
    {
      try
      {
        foreach (DeletedUser deletedUser in _deletedUsers)
        {
          configClass.GetScriptHandling.DeleteUser(deletedUser.Name);
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError(ex.Message, "DeleteUser", CLASSNAME);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Delete User", ex.Message));

      }

    }
    public bool CheckUserDeleted(ConfigClass configClass)
    {
      try
      {
        configClass.GetScriptHandling.putAllLocalUsersToList();
        if (!configClass.GetScriptHandling.CheckUserDeleted(_deletedUsers))
        {
          _checkUsers = false;
        }
      }
      catch (Exception ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "Check if useris deleted", CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check if useris deleted", ex.Message));

      }
      return _checkUsers;
    }


    public void AddUsers(ConfigClass configClass, EncryptionPassword enc)
    {
      string name = "";
      try
      {

        string fullname = "";
        string description = "";
        List<string> group = new List<string>();
        int changePwNextLogon = -1;
        int passwordCantBeChanged = -1;
        int passwordNeverExpires = -1;
        int accountDisabled = -1;
        string password = "";

        foreach (NewUser newUser in _newUsers)
        {
          name = newUser.Name;
          if (newUser.Fullname.Length != 0)
          {
            fullname = newUser.Fullname;
          }
          if (newUser.Description.Length != 0)
          {
            description = newUser.Description;
          }
          if (newUser.UserGroupList.Count != 0)
          {
            group = newUser.UserGroupList;
          }

          if (newUser.ChangePwNextLogon == "Yes")
          {
            changePwNextLogon = 1;
          }
          else if (newUser.ChangePwNextLogon == "No")
          {
            changePwNextLogon = 0;
          }

          if (newUser.PasswordCantBeChanged == "Yes")
          {
            passwordCantBeChanged = 1;
          }
          else if (newUser.PasswordCantBeChanged == "No")
          {
            passwordCantBeChanged = 0;
          }

          if (newUser.PasswordNeverExpires == "Yes")
          {
            passwordNeverExpires = 1;
          }
          else if (newUser.PasswordNeverExpires == "No")
          {
            passwordNeverExpires = 0;
          }

          if (newUser.AccountDisabled == "Yes")
          {
            accountDisabled = 1;
          }
          else if (newUser.AccountDisabled == "No")
          {
            accountDisabled = 0;
          }
          if (newUser.Password.Length != 0)
          {
            if (newUser.Password == "PassWordIsEncrypted")
            {
              password = enc.GetKey(name);
            }
            else
            {
              password = newUser.Password;
            }
          }

          configClass.GetScriptHandling.CreateUser(name, fullname, description, group, changePwNextLogon, passwordCantBeChanged, passwordNeverExpires, accountDisabled, password);
          foreach (string groupString in group)
          {
            configClass.GetScriptHandling.AddUserToGroup(newUser.Name,groupString);
          }
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError(ex.Message, "NewUser", CLASSNAME);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Create user " + name, ex.Message));

      }
    }
   
    public bool CheckUserCreated(ConfigClass configClass)
    {
      try
      {
        configClass.GetScriptHandling.putAllLocalUsersToList();
        if (!configClass.GetScriptHandling.CheckUserCreated(_newUsers))
        {
          _checkUsers = false;
        }
      }
      catch (Exception ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "Check if user is created", CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check if user is created", ex.Message));

      }
      return _checkUsers;
    }
    public void RemoveNewUserFromList(NewUser itemToRemove, ConfigClass configClass)
    {
      try
      {
        foreach (NewUser item in _newUsers)
        {
          if (item.Name == itemToRemove.Name)
          {
            _newUsers.Remove(item);
            break;
          }
        }
      }
      catch (Exception ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "Remove user from newUser list", CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Remove user from newUser list", ex.Message));

      }
    }
    

    public void ModifyUsers(ConfigClass configClass, EncryptionPassword enc)
    {

      string name = "";
      string fullname = "";
      string description = "";
      List<string> group = new List<string>();
      bool changePwNextLogon = false;
      bool passwordCantBeChanged = false;
      bool passwordNeverExpires = false;
      bool accountDisabled = false;
      string password = "";
      bool modifyOtherSettings = false;
      try
      {
        foreach (ModfiedUser modifiedUser in _modifiedUsers)
        {
          name = modifiedUser.Name;
          if (modifiedUser.Fullname.Length != 0)
          {
            fullname = modifiedUser.Fullname;
          }
          if (modifiedUser.Description.Length != 0)
          {
            description = modifiedUser.Description;
          }
          if (modifiedUser.UserGroupList.Count != 0)
          { 
          group = modifiedUser.UserGroupList;
          }
          if (modifiedUser.ChangePwNextLogon == "Yes")
          {
            changePwNextLogon = true;
          }
          else if (modifiedUser.ChangePwNextLogon == "No")
          {
            changePwNextLogon = false;
          }

          if (modifiedUser.PasswordCantBeChanged == "Yes")
          {
            passwordCantBeChanged = true;
          }
          else if (modifiedUser.PasswordCantBeChanged == "No")
          {
            passwordCantBeChanged = false;
          }

          if (modifiedUser.PasswordNeverExpires == "Yes")
          {
            passwordNeverExpires = true;
          }
          else if (modifiedUser.PasswordNeverExpires == "No")
          {
            passwordNeverExpires = false;
          }

          if (modifiedUser.AccountDisabled == "Yes")
          {
            accountDisabled = true;
          }
          else if (modifiedUser.AccountDisabled == "No")
          {
            accountDisabled = false;
          }
          if (modifiedUser.Password.Length != 0)
          {
            if (modifiedUser.Password == "PassWordIsEncrypted")
            {
              password = enc.GetKey(name);
            }
            else
            {
              password = modifiedUser.Password;
            }
          }
          if (modifiedUser.ModifyOtherSettings == "Yes")
          {
            modifyOtherSettings = true;
          }
          else if (modifiedUser.ModifyOtherSettings == "No")
          {
            modifyOtherSettings = false;
          }

          configClass.GetScriptHandling.ModifyUser(name, fullname, description, changePwNextLogon, passwordCantBeChanged, passwordNeverExpires, accountDisabled, password, modifyOtherSettings);
          foreach (string groupString in group)
          {
            configClass.GetScriptHandling.AddUserToGroup(modifiedUser.Name, groupString);
          }
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError(ex.Message, "ModifyUser " + name, CLASSNAME);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Modifyuser " + name, ex.Message));
      }
    }
    public bool CheckUserModified(ConfigClass configClass)
    {

      try
      {
        //TODO
      }
      catch (Exception ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "Check if user is modified", CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check if user is modified", ex.Message));

      }
      return _checkUsers;
    }
    public void RemoveModifiedUserFromList(ModfiedUser itemToRemove, ConfigClass configClass)
    {
      try
      {
        foreach (ModfiedUser item in _modifiedUsers)
        {
          if (item.Name == itemToRemove.Name)
          {
            _modifiedUsers.Remove(item);
            break;
          }
        }
      }
      catch (Exception ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "Remove user from modified user list", CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Remove user from modified user list", ex.Message));

      }

    }

    public bool CheckAccountIsBuiltIn(string name)
    {
      bool isBuiltin = false;


      PrincipalContext PrincipalContext = new PrincipalContext(ContextType.Machine);
      UserPrincipal userPrincipal = new UserPrincipal(PrincipalContext);
      userPrincipal.Name = name;

      PrincipalSearcher principalSearcher = new PrincipalSearcher();
      principalSearcher.QueryFilter = userPrincipal;
      PrincipalSearchResult<Principal> results = principalSearcher.FindAll();
      if (userPrincipal != null)
      {
        foreach (Principal p in results)
        {
          if (p.Name == name)
          {
            if (p.Description.Contains("Ingebouwde account") || p.Description.Contains("Built-in account"))
            {
              isBuiltin = true;
              break;
            }
          }
        }

      }


      return isBuiltin; ;
    }

  }
}
