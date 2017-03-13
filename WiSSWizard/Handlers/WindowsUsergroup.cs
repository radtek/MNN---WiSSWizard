using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Actemium.WiSSWizard
{
  [Serializable]
  public class UserGroup
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

    //constructor
    public UserGroup()
    { }
    public UserGroup(string name, string description)
    {
      _name = name;
      _description = description;
    }
  }

  [Serializable]
  public class WindowsUsergroup
  {
    //parameters
    private const string CLASSNAME = "windowsUserGroups";
    private List<UserGroup> _newUserGroups = new List<UserGroup>();
    private List<ListViewItem> _deletedUserGroups = new List<ListViewItem>();
    private bool _checkUsersgroups = true;

    //constructor
    public WindowsUsergroup()
    { }

    //properties
    public List<UserGroup> NewUserGroups
    {
      get
      {
        return _newuserGroups;
      }
      set
      {
        _newuserGroups = value;
      }
    } private List<UserGroup> _newuserGroups = new List<UserGroup>();
    public List<UserGroup> DeletedUserGroups
    {
      get
      {
        return _deleteduserGroups;
      }
      set
      {
        _deleteduserGroups = value;
      }
    } private List<UserGroup> _deleteduserGroups = new List<UserGroup>();

    public List<ConfigErrors> ErrorList
    {
      get
      {
        return _errorList;
      }
      set
      {
        _errorList = value;
      }
    } private List<ConfigErrors> _errorList = new List<ConfigErrors>();
    
    //methods
    public List<UserGroup> ExistedUserGroups(ConfigClass configClass)
    {
      configClass.GetScriptHandling.putAllLocalGroupsToList();
      _existeduserGroups = configClass.GetScriptHandling.GetAllLocalUsersGroups;
      return _existeduserGroups;


    } private List<UserGroup> _existeduserGroups = new List<UserGroup>();


    public bool CheckIfUserGroupExist(string name, ConfigClass configClass)
    {
      bool check = false;
      try
      {

        foreach (UserGroup user in ExistedUserGroups(configClass))
        {
          if (string.Equals(user.Name, name, StringComparison.OrdinalIgnoreCase))
          {
            check = true;
            break;
          }
        }
        return check;
      }
      catch (Exception ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "Check if usergroup " + name + " Exist", CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check if usergroup " + name + " Exist", ex.Message));

        return check;
      }
    }

    public void DeleteUserGroups(ConfigClass configClass)
    {
      string name = "";
      try
      {
        foreach (UserGroup deleteGroup in DeletedUserGroups)
        {
          name = deleteGroup.Name;
          configClass.GetScriptHandling.DeleteUserGroup(deleteGroup.Name);
        }
      }
      catch (Exception ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "Delete usergroup " + name, CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Delete usergroup " + name, ex.Message));

      }
    }
    public bool CheckUsergroupDeleted(ConfigClass configClass)
    {
      string name = "";
      try
      {
        foreach (UserGroup group in DeletedUserGroups)
        {
          name = group.Name;
          if (CheckIfUserGroupExist(group.Name, configClass))
          {
            _checkUsersgroups = false;
            break;
          }
        }
        return _checkUsersgroups;
      }
      catch (Exception ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "Check if usergroup " + name + " is deleted", CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check if usergroup " + name + " is deleted", ex.Message));
        return _checkUsersgroups;
      }
    }

    public void AddUserGroups(ConfigClass configClass)
    {
      string name = "";
      try
      {
        foreach (UserGroup newGroup in NewUserGroups)
        {
          name = newGroup.Name;
          configClass.GetScriptHandling.CreateUserGroups(newGroup.Name, newGroup.Description);
        }
      }
      catch (Exception ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "Create Usergroup", CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "", "Group " + name + " " + ex.Message));
      }
    }
    public bool CheckUsergroupCreated(ConfigClass configClass)
    {
      string name = "";
      try
      {
        foreach (UserGroup group in NewUserGroups)
        {
          name = group.Name;
          if (!CheckIfUserGroupExist(group.Name, configClass))
          {
            _checkUsersgroups = false;
            break;
          }

        }
      }
      catch (Exception ex)
      {
        Actemium.Diagnostics.Trace.WriteError("({0})", "Check if usergroup " + name + " is created", CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check if usergroup " + name + " is created", ex.Message));

      }
      return _checkUsersgroups;

    }

  }
}
