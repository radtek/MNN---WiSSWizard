using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Actemium.WiSSWizard
{
  [Serializable]
  public class AddUserSQL
  {
    //parameters
    public string NameSQL
    {
      get
      {
        return _nameSql;
      }
      set
      {
        _nameSql = value;
      }
    } private string _nameSql;
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
    public string RoleService
    {
      get
      {
        return _roleService;
      }
      set
      {
        _roleService = value;
      }
    }private string _roleService = "";
    //constructor
    public AddUserSQL()
    {
    }
    //methods
    public AddUserSQL(string name, string password, string rolesv)
    {
      _nameSql = name;
      _password = password;
      _roleService = rolesv;
    }


  }


  [Serializable]
  public class ModifySA
  {
    public string ChangeSaPassword
    {
      get
      {
        return _changeSaPassword;
      }
      set
      {
        _changeSaPassword = value;
      }
    } private string _changeSaPassword = "";

    public ModifySA()
    { }
    public ModifySA(string password)
    {
      _changeSaPassword = password;

    }
  }

  [Serializable]
  public class SQLServer
  {
    //Parameters
    private const string CLASSNAME = "SQLServer";

    //constructor
    public SQLServer()
    {
    }

    //Properties
    [XmlIgnoreAttribute()]
    public string SqlServerType
    {
      get
      {
        return _sqlServerType;
      }
      set
      {
        _sqlServerType = value;
      }
    }private string _sqlServerType;


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
  }

}
