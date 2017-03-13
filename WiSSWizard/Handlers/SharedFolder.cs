using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Actemium.Diagnostics;
using Actemium.WiSSWizard.Support;

namespace Actemium.WiSSWizard
{
  [Serializable]
  public class NewSharedFolder
  {
    /// <summary>
    /// Get or set FolderPath
    /// </summary>
    public string FolderPath
    {
      get { return _folderPath; }
      set { _folderPath = value; }
    } private string _folderPath ="";
    
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
    } private string _name ="";    

    /// <summary>
    /// Get or set CommentShare
    /// </summary>
    public string CommentShare
    {
      get { return _commentShare; }
      set { _commentShare = value; }
    } private string _commentShare ="";

    /// <summary>
    /// Get or set SimultaneousUserLimit
    /// </summary>
    public string SimultaneousUserLimit
    {
      get { return _simultaneousUserLimit; }
      set { _simultaneousUserLimit = value; }
    } private string _simultaneousUserLimit = "";

    public NewSharedFolder()
    { }

    public NewSharedFolder(string folderPath, string name, string simultaneousLimit, string comment)
    {
      _name = name;
      _folderPath = folderPath;
      _simultaneousUserLimit = simultaneousLimit;
      _commentShare = comment;
    }

  }

  [Serializable]
  public class SharedFolder
  {
    private const string CLASSNAME = "SharedFolder";
    //parameters    
    private List<NewSharedFolder> _listOfNewSharedFolder = new List<NewSharedFolder>(); 
    //constructor
    public SharedFolder()
    {}

    public List<NewSharedFolder> ListOfNewSharedFolder
    {
      get { return _listOfNewSharedFolder; }
      
    } 
    public NewSharedFolder AddNewSharedFolder
    {
      set
      {
        NewSharedFolder newSharedFolder = value;
        _listOfNewSharedFolder.Add(newSharedFolder);
      }
    }
    /// <summary>
    /// Get or set ListOfNewSharedFolder
    /// </summary>
    
    
    public void AddSharedFolder(ConfigClass configClass)
    {
      const string FUNCTIONNAME = "AddSharedFolder";
      try
      {
        Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
        string sharedFolderName = "";
        string sharedFolderPath = "";
        string sharedSimultaneousUserLimit = "";
        string sharedFolderComment = "";

        foreach (NewSharedFolder NSF in _listOfNewSharedFolder)
        {
          if (NSF.Name.Length != 0)
            sharedFolderName = NSF.Name;
          if (NSF.FolderPath.Length != 0)
            sharedFolderPath = NSF.FolderPath;
          if (NSF.CommentShare.Length != 0)
            sharedFolderComment = NSF.CommentShare;
          if (NSF.SimultaneousUserLimit.Length != 0)
            sharedSimultaneousUserLimit = NSF.SimultaneousUserLimit;

          configClass.GetScriptHandling.AddSharedFolder(sharedFolderPath, sharedFolderName, sharedSimultaneousUserLimit, sharedFolderComment);
        }
      }
      catch (Exception ex)
      {
        Trace.WriteError("()", FUNCTIONNAME, CLASSNAME, ex);
        throw;
      }

    }
    
  }

}
