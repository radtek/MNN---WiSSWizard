using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Actemium.WiSSWizard.Support;

namespace Actemium.WiSSWizard
{   
    [Serializable]
    public class RemoteDesktopUser
    {
        public RemoteDesktopUser()
            { }
        public RemoteDesktopUser(string name)
            {
                _name = name;
            }
        
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
    
    }
    public class RemoteDesktopGroup
    {
      public RemoteDesktopGroup()
      { }
      public RemoteDesktopGroup(string name)
      {
        _name = name;
      }

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

    }
    public class Remotedesktop
    {
        //parameters
        private const string CLASSNAME = "Remotedesktop";
        private List<bool> _checkRemoteDesktop = new List<bool>();

        //constructor
        public Remotedesktop()
        {
        }
        
        //properties
        public bool RemoteDesktopDisabled
        {
            get
            {
                return _remoteDesktopDisabled;
            }

            set
            {
                _remoteDesktopDisabled = value;
            }
        } private bool _remoteDesktopDisabled = false;
        public bool RemoteDesktopEnabledForAllPCs
        {
            get
            {
                return _remoteDesktopEnabledForAllPCs;
            }

            set
            {
                _remoteDesktopEnabledForAllPCs = value;
            }
        } private bool _remoteDesktopEnabledForAllPCs = false;
        public bool RemoteDesktopEnabledOnlyForPCsWithNLA
        {
            get
            {
                return _remoteDesktopEnabledOnlyForPCsWithNLA;
            }

            set
            {
                _remoteDesktopEnabledOnlyForPCsWithNLA = value;
            }
        } private bool _remoteDesktopEnabledOnlyForPCsWithNLA = false;
        
        public List<RemoteDesktopUser> RemoteDesktopUsers
        {
            get
            {
                return _remoteDesktopUsers;
            }
            set
            {
                _remoteDesktopUsers = value;
            }
        } private List<RemoteDesktopUser> _remoteDesktopUsers = new List<RemoteDesktopUser>();
        public List<RemoteDesktopGroup> RemoteDesktopGroups
        {
          get
          {
            return _remoteDesktopGroups;
          }
          set
          {
            _remoteDesktopGroups = value;
          }
        } private List<RemoteDesktopGroup> _remoteDesktopGroups = new List<RemoteDesktopGroup>();

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
        public void SetRemoteDesktopSettings(OSVersions os,ConfigClass configClass)
        {
            try
            {
            string regPath = "";
            string regKey = "";
            string value = "";
            string propertyType = "DWORD";
            //string description = "";
            string group = "";
            #region language
            string oslanguage = System.Globalization.CultureInfo.CurrentCulture.DisplayName;
            if (oslanguage.Contains("Nederland"))
            {
              group = "Externe bureaubladgebruikers";
            }
            else
            {
              group = "Remote Desktop Users";
            }
            #endregion language

             if (_remoteDesktopDisabled)
                {
                    #region RegPath
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegPath") != null)
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegPath");
                    }
                    else
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableLessSecureRegPath");
                    }
                    #endregion RegPath
                    #region RegKeyRemoteDesktop
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegKey") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegKey");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableLessSecureRegKey");
                    }
                    value = "1";
                    configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                    #endregion RegKeyRemoteDesktop
                    if (os != OSVersions.WindowsXP && os != OSVersions.WindowsXP32 && os != OSVersions.WindowsXP64 && os != OSVersions.W2003 && os != OSVersions.W2003R2)
                    {
                        #region RegPath Netwerk level authentication
                        if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegPath") != null)
                        {
                            regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegPath");
                        }
                        else
                        {
                            regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableMoreSecureRegPath");
                        }
                        #endregion RegPath Netwerk level authentication
                        #region RegKeyRemoteDesktop Netwerk level authentication
                        if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegKey") != null)
                        {
                            regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegKey");
                        }
                        else
                        {
                            regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableMoreSecureRegKey");
                        }
                        value = "0";
                        configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                        #endregion RegKeyRemoteDesktop Netwerk level authentication
                    }
                }
                if (_remoteDesktopEnabledForAllPCs && !_remoteDesktopEnabledOnlyForPCsWithNLA)
                {
                    #region RegPath
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegPath") != null)
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegPath");
                    }
                    else
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableLessSecureRegPath");
                    }
                    #endregion RegPath
                    #region RegKeyRemoteDesktop
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegKey") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegKey");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableLessSecureRegKey");
                    }
                    value = "0";
                    configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                    #endregion RegKeyRemoteDesktop

                    if (os != OSVersions.WindowsXP && os != OSVersions.WindowsXP32 && os != OSVersions.WindowsXP64 && os != OSVersions.W2003 && os != OSVersions.W2003R2)
                    {
                        #region RegPath Netwerk level authentication
                        if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegPath") != null)
                        {
                            regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegPath");
                        }
                        else
                        {
                            regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableMoreSecureRegPath");
                        }
                        #endregion RegPath Netwerk level authentication
                        #region RegKeyRemoteDesktop Netwerk level authentication
                        if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegKey") != null)
                        {
                            regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegKey");
                        }
                        else
                        {
                            regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableMoreSecureRegKey");
                        }
                        value = "0";
                        configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                        #endregion RegKeyRemoteDesktop Netwerk level authentication
                    }
                }
                if (_remoteDesktopEnabledForAllPCs && _remoteDesktopEnabledOnlyForPCsWithNLA)
                {
                    #region RegPath Enable/Disable
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegPath") != null)
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegPath");
                    }
                    else
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableLessSecureRegPath");
                    }
                    #endregion RegPath Enable/Disable
                    #region RegKeyRemoteDesktop
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegKey") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegKey");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableLessSecureRegKey");
                    }
                    value = "0";
                    configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                    #endregion RegKeyRemoteDesktop


                    #region RegPath Netwerk level authentication
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegPath") != null)
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegPath");
                    }
                    else
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableMoreSecureRegPath");
                    }
                    #endregion RegPath Netwerk level authentication
                    #region RegKeyRemoteDesktop Netwerk level authentication
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegKey") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegKey");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableMoreSecureRegKey");
                    }
                    value = "1";
                    configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                    #endregion RegKeyRemoteDesktop Netwerk level authentication
                }
                if (_remoteDesktopGroups.Count != 0)
                {
                  foreach (RemoteDesktopGroup rdpGroup in _remoteDesktopGroups)
                  {
                    string trimmedRDPGroupName = rdpGroup.Name.Replace("\n","").Trim();
                    configClass.GetScriptHandling.addGroupsToRemoteDesktopUsers(trimmedRDPGroupName);
                  }
                }
                if (_remoteDesktopUsers.Count != 0)
                {
                    foreach (RemoteDesktopUser rdpUser in _remoteDesktopUsers)
                    {
                      configClass.GetScriptHandling.AddUserToGroup(rdpUser.Name, group);
                    }
                }
               
            }
            catch (Exception ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Set remotedesktop settings", CLASSNAME, ex);
                configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Set remotedesktop settings", ex.Message));

            }
            
        }
        public bool CheckRemoteDesktopSettings(OSVersions os,ConfigClass configClass)
        {
            bool totalcheck = true;
            try
            {

                string regPath = "";
                string regKey = "";
                string value = "";

                if (_remoteDesktopDisabled)
                {
                    #region RegPath
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegPath") != null)
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegPath");
                    }
                    else
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableLessSecureRegPath");
                    }
                    #endregion RegPath
                    #region RegKeyRemoteDesktop
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegKey") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegKey");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableLessSecureRegKey");
                    }
                    value = "1";
                    if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                    {
                        _checkRemoteDesktop.Add(true);
                    }
                    else
                    {
                        _checkRemoteDesktop.Add(false);
                    }
                    #endregion RegKeyRemoteDesktop

                    if (os != OSVersions.WindowsXP && os != OSVersions.WindowsXP32 && os != OSVersions.WindowsXP64 && os != OSVersions.W2003 && os != OSVersions.W2003R2)
                    {
                        #region RegPath Netwerk level authentication
                        if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegPath") != null)
                        {
                            regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegPath");
                        }
                        else
                        {
                            regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableMoreSecureRegPath");
                        }
                        #endregion RegPath Netwerk level authentication
                        #region RegKeyRemoteDesktop Netwerk level authentication
                        if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegKey") != null)
                        {
                            regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegKey");
                        }
                        else
                        {
                            regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableMoreSecureRegKey");
                        }
                        value = "0";
                        if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                        {
                            _checkRemoteDesktop.Add(true);
                        }
                        else
                        {
                            _checkRemoteDesktop.Add(false);
                        }
                        #endregion RegKeyRemoteDesktop Netwerk level authentication
                    }
                }
                if (_remoteDesktopEnabledForAllPCs && !_remoteDesktopEnabledOnlyForPCsWithNLA)
                {
                    #region RegPath
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegPath") != null)
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegPath");
                    }
                    else
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableLessSecureRegPath");
                    }
                    #endregion RegPath
                    #region RegKeyRemoteDesktop
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegKey") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegKey");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableLessSecureRegKey");
                    }
                    value = "0";
                    if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                    {
                        _checkRemoteDesktop.Add(true);
                    }
                    else
                    {
                        _checkRemoteDesktop.Add(false);
                    }

                    #endregion RegKeyRemoteDesktop

                    if (os != OSVersions.WindowsXP && os != OSVersions.WindowsXP32 && os != OSVersions.WindowsXP64 && os != OSVersions.W2003 && os != OSVersions.W2003R2)
                    {
                        #region RegPath Netwerk level authentication
                        if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegPath") != null)
                        {
                            regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegPath");
                        }
                        else
                        {
                            regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableMoreSecureRegPath");
                        }
                        #endregion RegPath Netwerk level authentication
                        #region RegKeyRemoteDesktop Netwerk level authentication
                        if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegKey") != null)
                        {
                            regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegKey");
                        }
                        else
                        {
                            regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableMoreSecureRegKey");
                        }
                        value = "0";
                        if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                        {
                            _checkRemoteDesktop.Add(true);
                        }
                        else
                        {
                            _checkRemoteDesktop.Add(false);
                        }
                        #endregion RegKeyRemoteDesktop Netwerk level authentication
                    }
                }
                if (_remoteDesktopEnabledForAllPCs && _remoteDesktopEnabledOnlyForPCsWithNLA)
                {
                    #region RegPath Enable/Disable
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegPath") != null)
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegPath");
                    }
                    else
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableLessSecureRegPath");
                    }
                    #endregion RegPath Enable/Disable
                    #region RegKeyRemoteDesktop
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegKey") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableLessSecureRegKey");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableLessSecureRegKey");
                    }
                    value = "0";
                    if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                    {
                        _checkRemoteDesktop.Add(true);
                    }
                    else
                    {
                        _checkRemoteDesktop.Add(false);
                    }
                    #endregion RegKeyRemoteDesktop


                    #region RegPath Netwerk level authentication
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegPath") != null)
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegPath");
                    }
                    else
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableMoreSecureRegPath");
                    }
                    #endregion RegPath Netwerk level authentication
                    #region RegKeyRemoteDesktop Netwerk level authentication
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegKey") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "RemoteDesktopEnableMoreSecureRegKey");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "RemoteDesktopEnableMoreSecureRegKey");
                    }
                    value = "1";
                    if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                    {
                        _checkRemoteDesktop.Add(true);
                    }
                    else
                    {
                        _checkRemoteDesktop.Add(false);
                    }
                    #endregion RegKeyRemoteDesktop Netwerk level authentication

                }

                if (configClass.GetScriptHandling.CheckIfUserinGroupExist(_remoteDesktopUsers))
                {
                  _checkRemoteDesktop.Add(true);
                }
                else
                {
                  _checkRemoteDesktop.Add(false);
                }
                //if (configClass.GetScriptHandling.CheckIfGroupInGroupExist(_remoteDesktopGroups))
                //{
                //  _checkRemoteDesktop.Add(true);
                //}
                //else
                //{
                //  _checkRemoteDesktop.Add(false);
                //}

                
                foreach (bool b in _checkRemoteDesktop)
                {
                    if (!b)
                    {
                        return totalcheck;
                    }
                }
                
            }
            catch (Exception ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Check remotedesktop settings", CLASSNAME, ex);
                configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check remotedesktop settings", ex.Message));

            }
            return totalcheck;
        }
        
            
    }
}
