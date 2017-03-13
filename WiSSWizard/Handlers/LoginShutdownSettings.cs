using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Actemium.WiSSWizard.Support;

namespace Actemium.WiSSWizard
{
    public class LoginShutdownSettings
    {
        //parameters
        private const string CLASSNAME = "LoginShutdownSettings";
        private List<bool> _checkAutoLogonSettings = new List<bool>();
        private List<bool> _checkShutdownEventTracker = new List<bool>();

        //constructor
        public LoginShutdownSettings()
        {
        }

        //properties
        public bool AutologonInUse
        {
            get
            {
                return _autologonInUse;
            }
            set
            {
                _autologonInUse = value;
            }
        } private bool _autologonInUse = false;
        public string UsernameAutoLogon
        {
            get
            {
                return _usernameAutoLogon;
            }
            set
            {
                _usernameAutoLogon = value;
            }
        }private string _usernameAutoLogon = "";
        public string PasswordAutoLogon
        {
            get
            {
                return _passwordAutoLogon;
            }
            set
            {
                _passwordAutoLogon = value;
            }
        }private string _passwordAutoLogon = "";
        public bool AutoLogonCheck
        {
            get
            {
                return _autoLogonCheck;
            }
            set
            {
                _autoLogonCheck = value;
            }
        } private bool _autoLogonCheck = true;

        public bool ShutDownEventTrackerInUse
        {
            get
            {
                return _shutDownEventTrackerInUse;
            }
            set
            {
                _shutDownEventTrackerInUse = value;
            }
        } private bool _shutDownEventTrackerInUse = false;
        public bool ShutDownEventTrackerCheck
        {
            get { return _shutDownEventTrackerCheck; }
            set { _shutDownEventTrackerCheck = value; }
        } private bool _shutDownEventTrackerCheck = true;

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
        public void AutlogonSettings(OSVersions os, ConfigClass configClass)
        {
            try
            {

                string regPath = "";
                string regKey = "";
                string value = "";
                string propertyType = "String";

                #region Auto-login set for user
                if (_autologonInUse)
                {
                    if (configClass.ConfSetWindowsUsers.CheckIfUserExist(UsernameAutoLogon, configClass))
                    {
                        #region RegPath
                        if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonRegPath") != null)
                        {
                            regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonRegPath");
                        }
                        else
                        {
                            regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoLogonRegPath");
                        }
                        #endregion RegPath
                        #region Username
                        if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonUsername") != null)
                        {
                            regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonUsername");
                        }
                        else
                        {
                            regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoLogonUsername");
                        }
                        value = _usernameAutoLogon; // name
                        configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                        #endregion  Username
                        #region Pasword
                        string password = "";
                        if (_passwordAutoLogon == "PassWordIsEncrypted")
                        {
                            EncryptionPassword enc = new EncryptionPassword(configClass);
                            password = enc.GetKey("AutoLogon");
                        }
                        else
                        {
                            password = _passwordAutoLogon;
                        }

                        if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonPassword") != null)
                        {
                            regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonPassword");
                        }
                        else
                        {
                            regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoLogonPassword");
                        }
                        value = password; //password
                        configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                        #endregion Pasword
                        #region DomainName
                        if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonDomainName") != null)
                        {
                            regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonDomainName");
                        }
                        else
                        {
                            regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoLogonDomainName");
                        }
                        value = System.Environment.MachineName;//Domain
                        configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                        #endregion DomainName
                        #region SetAutoLogon
                        if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoAdminLogon") != null)
                        {
                            regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoAdminLogon");
                        }
                        else
                        {
                            regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoAdminLogon");
                        }
                        value = "1";
                        configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                        #endregion SetAutoLogon
                    }

                    else
                    {
                        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Autologon settings", "Gebruikers account niet beschikbaar"));
                        AutoLogonCheck = false;
                    }
                }
                #endregion Auto-login set for user
                #region Disable Auto login
                else
                {
                    #region RegPath
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonRegPath") != null)
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonRegPath");
                    }
                    else
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoLogonRegPath");
                    }
                    #endregion RegPath
                    #region Pasword
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonPassword") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonPassword");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoLogonPassword");
                    }
                    configClass.GetScriptHandling.RemoveRegisterKey(regPath, regKey);
                    #endregion Pasword
                    #region SetAutoLogon
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoAdminLogon") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoAdminLogon");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoAdminLogon");
                    }
                    value = "0";
                    configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                    #endregion SetAutoLogon
                }
                #endregion Disable Auto login

            }
            catch (Exception ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Autologon settings", CLASSNAME, ex);
                configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Autologon settings", ex.Message));
                AutoLogonCheck = false;
            }
        }
        public bool CheckAutoLogonSettings(OSVersions os, ConfigClass configClass)
        {

            try
            {
                string regPath = "";
                string regKey = "";
                string value = "";

                #region Automatic login setting
                if (_autologonInUse)
                {
                    #region RegPath
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonRegPath") != null)
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonRegPath");
                    }
                    else
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoLogonRegPath");
                    }
                    #endregion RegPath

                    #region Username
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonUsername") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonUsername");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoLogonUsername");
                    }
                    value = _usernameAutoLogon; // name
                    if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                    {
                        _checkAutoLogonSettings.Add(true);
                    }
                    else
                    {
                        _checkAutoLogonSettings.Add(false);
                    }
                    #endregion  Username
                    //TODO:  Powershell kan geen string vergelijken met speciale tekens
                    /*
                    #region Pasword
                    string password = "";
                    if (_passwordAutoLogon == "PassWordIsEncrypted")
                    {
                        EncryptionPassword enc = new EncryptionPassword(configClass);
                        password = enc.GetKey("AutoLogon");
                    }
                    else
                    {
                        password = _passwordAutoLogon;
                    }
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonPassword") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonPassword");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoLogonPassword");
                    }
                    value = password; //password
                    if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value)) TODO: Powershell kan gen string vergelijken met speciale tekens
                    {
                        _checkAutoLogonSettings.Add(true);
                    }
                    else
                    {
                        _checkAutoLogonSettings.Add(false);
                    }
                      
                    #endregion Pasword*/

                    #region DomainName
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonDomainName") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonDomainName");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoLogonDomainName");
                    }
                    value = System.Environment.MachineName;//Domain
                    if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                    {
                        _checkAutoLogonSettings.Add(true);
                    }
                    else
                    {
                        _checkAutoLogonSettings.Add(false);
                    }
                    #endregion DomainName

                    #region SetAutoLogon
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoAdminLogon") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoAdminLogon");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoAdminLogon");
                    }
                    value = "1";
                    if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                    {
                        _checkAutoLogonSettings.Add(true);
                    }
                    else
                    {
                        _checkAutoLogonSettings.Add(false);
                    }
                    #endregion SetAutoLogon

                }
                #endregion Automatic login setting
                #region Disable auto login
                else
                {
                    #region RegPath
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonRegPath") != null)
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonRegPath");
                    }
                    else
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoLogonRegPath");
                    }
                    #endregion RegPath
                    #region Pasword
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonPassword") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoLogonPassword");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoLogonPassword");
                    }
                    value = "null";
                    if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                    {
                        _checkAutoLogonSettings.Add(false);
                    }
                    else
                    {
                        _checkAutoLogonSettings.Add(true);
                    }
                    #endregion Pasword
                    #region SetAutoLogon
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoAdminLogon") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "AutoAdminLogon");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoAdminLogon");
                    }
                    value = "0";
                    if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                    {
                        _checkAutoLogonSettings.Add(true);
                    }
                    else
                    {
                        _checkAutoLogonSettings.Add(false);
                    }
                    #endregion SetAutoLogon
                }
                #endregion Disable auto login


                foreach (bool b in _checkAutoLogonSettings)
                {
                    if (!b)
                    {
                        AutoLogonCheck = false;
                        return AutoLogonCheck;
                    }
                }

            }
            catch (Exception ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Check autologin settings", CLASSNAME, ex);
                configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Check autologin settings", ex.Message));
                AutoLogonCheck = false;
            }
            return AutoLogonCheck;
        }

        public void SetShutDownEventTracker(OSVersions os, ConfigClass configClass)
        {
            try
            {
                string regPath = "";
                string regKey = "";
                string value = "";
                string propertyType = "DWORD";

                if (_shutDownEventTrackerInUse)
                {
                    #region RegPath
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegPath") != null)
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegPath");
                    }
                    else
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "SDEVTRegPath");
                    }
                    #endregion RegPath
                    #region RegKeyShutdownReason
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegKeyShutdownReason") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegKeyShutdownReason");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "SDEVTRegKeyShutdownReason");
                    }
                    value = "1";
                    configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                    #endregion RegKeyShutdownReason
                    #region OnShutdownReasonUI
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegKeyOnShutdownReasonUI") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegKeyOnShutdownReasonUI");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "SDEVTRegKeyOnShutdownReasonUI");
                    }
                    value = "1";
                    configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                    #endregion OnShutdownReasonUI
                }
                else
                {
                    #region RegPath
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegPath") != null)
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegPath");
                    }
                    else
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "SDEVTRegPath");
                    }
                    #endregion RegPath
                    #region RegKeyShutdownReason
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegKeyShutdownReason") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegKeyShutdownReason");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "SDEVTRegKeyShutdownReason");
                    }
                    value = "0";
                    configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                    #endregion RegKeyShutdownReason
                    #region OnShutdownReasonUI
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegKeyOnShutdownReasonUI") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegKeyOnShutdownReasonUI");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "SDEVTRegKeyOnShutdownReasonUI");
                    }
                    value = "0";
                    configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                    #endregion OnShutdownReasonUI
                }
            }
            catch (Exception ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Set Shutdown event tracker", CLASSNAME, ex);
                configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Set Shutdown event tracker", ex.Message));
                ShutDownEventTrackerCheck = false;
            }

        }
        public bool CheckSetShutDownEventTracker(OSVersions os, ConfigClass configClass)
        {

            try
            {
                string regPath = "";
                string regKey = "";
                string value = "";


                if (_shutDownEventTrackerInUse)
                {
                    #region RegPath
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegPath") != null)
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegPath");
                    }
                    else
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "SDEVTRegPath");
                    }
                    #endregion RegPath
                    #region RegKeyShutdownReason
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegKeyShutdownReason") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegKeyShutdownReason");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "SDEVTRegKeyShutdownReason");
                    }
                    value = "1";
                    if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                    {
                        _checkShutdownEventTracker.Add(true);
                    }
                    else
                    {
                        _checkShutdownEventTracker.Add(false);
                    }
                    #endregion RegKeyShutdownReason
                    #region OnShutdownReasonUI
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegKeyOnShutdownReasonUI") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegKeyOnShutdownReasonUI");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "SDEVTRegKeyOnShutdownReasonUI");
                    }
                    value = "1";
                    if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                    {
                        _checkShutdownEventTracker.Add(true);
                    }
                    else
                    {
                        _checkShutdownEventTracker.Add(false);
                    }
                    #endregion OnShutdownReasonUI


                }
                else
                {
                    #region RegPath
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegPath") != null)
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegPath");
                    }
                    else
                    {
                        regPath = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "SDEVTRegPath");
                    }
                    #endregion RegPath
                    #region RegKeyShutdownReason
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegKeyShutdownReason") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegKeyShutdownReason");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "SDEVTRegKeyShutdownReason");
                    }
                    value = "0";
                    if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                    {
                        _checkShutdownEventTracker.Add(true);
                    }
                    else
                    {
                        _checkShutdownEventTracker.Add(false);
                    }
                    #endregion RegKeyShutdownReason
                    #region OnShutdownReasonUI
                    if (Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegKeyOnShutdownReasonUI") != null)
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(os, "SDEVTRegKeyOnShutdownReasonUI");
                    }
                    else
                    {
                        regKey = Actemium.WiSSWizard.Support.ResourceHelper.GetOSOperations(OSVersions.AllOS, "SDEVTRegKeyOnShutdownReasonUI");
                    }
                    value = "0";
                    if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                    {
                        _checkShutdownEventTracker.Add(true);
                    }
                    else
                    {
                        _checkShutdownEventTracker.Add(false);
                    }
                    #endregion OnShutdownReasonUI

                }

                foreach (bool b in _checkShutdownEventTracker)
                {
                    if (!b)
                    {
                        _shutDownEventTrackerCheck = false;
                        return _shutDownEventTrackerCheck;
                    }
                }

            }
            catch (Exception ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Shutdown eventtracker", CLASSNAME, ex);
                configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Shutdown eventtracker", ex.Message));
                ShutDownEventTrackerCheck = false;
            }
            return _shutDownEventTrackerCheck;
        }

    }
}
