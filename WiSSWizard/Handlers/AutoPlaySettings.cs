using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Actemium.WiSSWizard.Support;

namespace Actemium.WiSSWizard
{
    public class AutoPlaySettings
    {
        //parameters
        private const string CLASSNAME = "AutoPlaySettings";
        private List<bool> _checkAutoPlaySettings = new List<bool>();
       
        //constructor
        public AutoPlaySettings()
        {
        }

        //properties
        public bool AutoPlayOff
        {
            get
            {
                return _autoPlayOff;
            }
            set
            {
                _autoPlayOff = value;
            }
        }private bool _autoPlayOff = true;
        public int AutoPlaySetting
        {
            get
            {
                return _autoPlaySetting;
            }
            set
            {
                _autoPlaySetting = value;
            }
        } private int _autoPlaySetting = -1;
        // 0 = CD-ROM and removable media drives
        // 1 = All drives 
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
        public void MakeAutoplaySettings(OSVersions os,ConfigClass configClass)
        {
            try
            {
                string regPath = "";
                string regKey = "";
                string value = "";
                string propertyType = "DWORD";

                if (_autoPlayOff)
                {
                    if (_autoPlaySetting != -1)
                    {
                        #region All drives
                        if (_autoPlaySetting == 1)
                        {

                            if (ResourceHelper.GetOSOperations(os, "APRegKeyNoDriveTypeAutoRun") != null)
                            {
                                regKey = ResourceHelper.GetOSOperations(os, "APRegKeyNoDriveTypeAutoRun");
                            }
                            else
                            {
                                regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "APRegKeyNoDriveTypeAutoRun");
                            }
                            if (ResourceHelper.GetOSOperations(os, "AutoPlaySettingRegPath") != null)
                            {
                                regPath = ResourceHelper.GetOSOperations(os, "AutoPlaySettingRegPath");
                            }
                            else
                            {
                                regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoPlaySettingRegPath");
                            }
                            value = "255";
                            configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                        }
                        #endregion All drives
                        #region CD-ROM drives
                        if (_autoPlaySetting == 0)
                        {
                            if (ResourceHelper.GetOSOperations(os, "APRegKeyNoDriveTypeAutoRun") != null)
                            {
                                regKey = ResourceHelper.GetOSOperations(os, "APRegKeyNoDriveTypeAutoRun");
                            }
                            else
                            {
                                regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "APRegKeyNoDriveTypeAutoRun");
                            }
                            if (ResourceHelper.GetOSOperations(os, "AutoPlaySettingRegPath") != null)
                            {
                                regPath = ResourceHelper.GetOSOperations(os, "AutoPlaySettingRegPath");
                            }
                            else
                            {
                                regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoPlaySettingRegPath");
                            }
                            value = "181";

                            configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                        }
                        #endregion CD-ROM drives
                    }
                }
                #region Enable all Drives
                else
                {
                    if (ResourceHelper.GetOSOperations(os, "APRegKeyNoDriveTypeAutoRun") != null)
                    {
                        regKey = ResourceHelper.GetOSOperations(os, "APRegKeyNoDriveTypeAutoRun");
                    }
                    else
                    {
                        regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "APRegKeyNoDriveTypeAutoRun");
                    }
                    if (ResourceHelper.GetOSOperations(os, "AutoPlaySettingRegPath") != null)
                    {
                        regPath = ResourceHelper.GetOSOperations(os, "AutoPlaySettingRegPath");
                    }
                    else
                    {
                        regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoPlaySettingRegPath");
                    }
                    configClass.GetScriptHandling.RemoveRegisterKey(regPath, regKey);
                }
                #endregion Enable all drives
            }
            catch (Exception ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Make autoplay settings", CLASSNAME, ex);
                configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Make autoplay settings", ex.Message));
            }
        }
        public bool CheckAutoPlaySettings(OSVersions os, ConfigClass configClass)
        {
            bool totalcheck = true;
            try
            {
                string regPath = "";
                string regKey = "";
                string value = "";

                if (_autoPlayOff)
                {
                    #region All Drives
                    if (_autoPlaySetting == 1)
                    {
                        if (ResourceHelper.GetOSOperations(os, "APRegKeyNoDriveTypeAutoRun") != null)
                        {
                            regKey = ResourceHelper.GetOSOperations(os, "APRegKeyNoDriveTypeAutoRun");
                        }
                        else
                        {
                            regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "APRegKeyNoDriveTypeAutoRun");
                        }
                        if (ResourceHelper.GetOSOperations(os, "AutoPlaySettingRegPath") != null)
                        {
                            regPath = ResourceHelper.GetOSOperations(os, "AutoPlaySettingRegPath");
                        }
                        else
                        {
                            regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoPlaySettingRegPath");
                        }
                        value = "255";
                        if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                        {
                            _checkAutoPlaySettings.Add(true);
                        }
                        else
                        {
                            _checkAutoPlaySettings.Add(false);
                        }
                    }
                    #endregion All Drives
                    #region CD-ROM drives
                    if (_autoPlaySetting == 0)
                    {
                        if (ResourceHelper.GetOSOperations(os, "APRegKeyNoDriveTypeAutoRun") != null)
                        {
                            regKey = ResourceHelper.GetOSOperations(os, "APRegKeyNoDriveTypeAutoRun");
                        }
                        else
                        {
                            regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "APRegKeyNoDriveTypeAutoRun");
                        }
                        if (ResourceHelper.GetOSOperations(os, "AutoPlaySettingRegPath") != null)
                        {
                            regPath = ResourceHelper.GetOSOperations(os, "AutoPlaySettingRegPath");
                        }
                        else
                        {
                            regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoPlaySettingRegPath");
                        }
                        value = "181";

                        if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                        {
                            _checkAutoPlaySettings.Add(true);
                        }
                        else
                        {
                            _checkAutoPlaySettings.Add(false);
                        }
                    }
                    #endregion CD-ROM drives
                }
                else
                {
                    #region Disable
                    if (ResourceHelper.GetOSOperations(os, "APRegKeyNoDriveTypeAutoRun") != null)
                    {
                        regKey = ResourceHelper.GetOSOperations(os, "APRegKeyNoDriveTypeAutoRun");
                    }
                    else
                    {
                        regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "APRegKeyNoDriveTypeAutoRun");
                    }
                    if (ResourceHelper.GetOSOperations(os, "AutoPlaySettingRegPath") != null)
                    {
                        regPath = ResourceHelper.GetOSOperations(os, "AutoPlaySettingRegPath");
                    }
                    else
                    {
                        regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "AutoPlaySettingRegPath");
                    }

                    if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                    {
                        _checkAutoPlaySettings.Add(false);
                    }
                    else
                    {
                        _checkAutoPlaySettings.Add(true);
                    }

                }

                foreach (bool b in _checkAutoPlaySettings)
                {
                    if (!b)
                    {
                        totalcheck = false;
                        return totalcheck;
                    }
                }
                return totalcheck;


            }
                    #endregion Disable
            catch (Exception ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Make autoplay settings", CLASSNAME, ex);
                configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Make autoplay settings", ex.Message));
                totalcheck = false;
                return totalcheck;
            }
        }

    }
}