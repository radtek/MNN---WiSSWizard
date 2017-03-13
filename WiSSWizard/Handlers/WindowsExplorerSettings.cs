using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Actemium.Diagnostics;
using Actemium.WiSSWizard.Support;

namespace Actemium.WiSSWizard
{
    public class WindowsExplorerSettings
    {
        //parameters
        private const string CLASSNAME = "WindowsExplorerSettings";
        private List<bool> _checkWindowsExplorerFolderOptions = new List<bool>();

        //constructor
        public WindowsExplorerSettings()
        {

        }

        //properties
        public bool AutoplayCD
        {
          get
          {
            return _autoplayCD;
          
          }
          set
          {
            _autoplayCD = value;
          
          }
          
        }private bool _autoplayCD = false;
        public bool AutomaticallySearchNetworkFoldersAndPrinters
        {
            get
            {
                return _automaticallySearchNetworkFoldersAndPrinters;
            }
            set
            {
                _automaticallySearchNetworkFoldersAndPrinters = value;
            }
        } private bool _automaticallySearchNetworkFoldersAndPrinters = false;
        public bool DisplayContentOfSystemFolder
        {
            get
            {
                return _displayContentOfSystemFolder;
            }
            set
            {
                _displayContentOfSystemFolder = value;
            }
        } private bool _displayContentOfSystemFolder = false;
        public bool DisplayFullPathInAddressBar
        {
            get
            {
                return _displayFullPathInAddressBar;
            }
            set
            {
                _displayFullPathInAddressBar = value;
            }
        } private bool _displayFullPathInAddressBar = false;
        public bool ShowHiddenFolders
        {
            get
            {
                return _showHiddenFolders;
            }
            set
            {
                _showHiddenFolders = value;
            }
        } private bool _showHiddenFolders = false;
        public bool HideExtensions
        {
            get
            {
                return _hideExtensions;
            }
            set
            {
                _hideExtensions = value;
            }
        } private bool _hideExtensions = false;
        public bool HideProtectedOSFiles
        {
            get
            {
                return _hideProtectedOSFiles;
            }
            set
            {
                _hideProtectedOSFiles = value;
            }
        } private bool _hideProtectedOSFiles = false;
        public bool RememberEachFoldersViewSetting
        {
            get
            {
                return _rememberEachFoldersViewSetting;
            }
            set
            {
                _rememberEachFoldersViewSetting = value;
            }
        } private bool _rememberEachFoldersViewSetting = false;
        public bool ShowNTFSFilesInColor
        {
            get
            {
                return _showNTFSFilesInColor;
            }
            set
            {
                _showNTFSFilesInColor = value;
            }
        } private bool _showNTFSFilesInColor = false;

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
        public void SetExplorerMapOptions(OSVersions os,ConfigClass configClass)
        {
            try
            {
                string regPath = "";
                string regKey = "";
                string value = "";
                string propertyType = "DWORD";

                #region Automatically search for network folders and printers

                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }
                if (ResourceHelper.GetOSOperations(os, "EMONoNetCrawling") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMONoNetCrawling");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMONoNetCrawling");
                }

                if (_automaticallySearchNetworkFoldersAndPrinters)
                { value = "0"; }
                else
                { value = "1"; }
                configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                #endregion
                #region Display the contents of system folders

                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOWebViewBarricade") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOWebViewBarricade");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOWebViewBarricade");
                }
                if (_displayContentOfSystemFolder)
                { value = "1"; }
                else
                { value = "0"; }
                configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);


                #endregion
                #region Display the full path in the Address bar
                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsCabinetState") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsCabinetState");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsCabinetState");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOFullPathAddress") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOFullPathAddress");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOFullPathAddress");
                }
                if (_displayFullPathInAddressBar)
                { value = "1"; }
                else
                { value = "0"; }
                configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                #endregion
                #region Show hidden files and folders
                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOHidden") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOHidden");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOHidden");
                }
                if (_showHiddenFolders)
                { value = "1"; }
                else
                { value = "2"; }
                configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);


                #endregion
                #region Hide extensions for known file types
                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOHideFileExt") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOHideFileExt");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOHideFileExt");
                }
                if (_hideExtensions)
                { value = "1"; }
                else
                { value = "0"; }
                configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);

                #endregion
                #region Hide protected operating system files
                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOShowSuperHidden") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOShowSuperHidden");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOShowSuperHidden");
                }
                if (_hideProtectedOSFiles)
                { value = "0"; }
                else
                { value = "1"; }
                configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                #endregion
                #region The view settings for each folder
                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOClassicViewState") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOClassicViewState");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOClassicViewState");
                }
                if (_rememberEachFoldersViewSetting)
                { value = "0"; }
                else
                { value = "1"; }
                configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                #endregion
                #region Show encrypted or compressed NTFS files in color
                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOShowCompColor") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOShowCompColor");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOShowCompColor");
                }
                if (_showNTFSFilesInColor)
                { value = "1"; }
                else
                { value = "0"; }
                configClass.GetScriptHandling.SetRegisterKey(regPath, regKey, value, propertyType);
                #endregion
            }
            catch (Exception ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Set Windows explorer folder options", CLASSNAME, ex);
                configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Set Windows explorer folder options", ex.Message));

            }
        }
        public bool CheckexplorerMapOptions(OSVersions os,ConfigClass configClass)
        {
            bool totalcheck = true;
            try
            {
                string regPath = "";
                string regKey = "";
                string value = "";

                _checkWindowsExplorerFolderOptions.Clear();

                #region Automatically search for network folders and printers 
                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }
                if (ResourceHelper.GetOSOperations(os, "EMONoNetCrawling") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMONoNetCrawling");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMONoNetCrawling");
                }
                if (_automaticallySearchNetworkFoldersAndPrinters)
                { value = "0"; }
                else
                { value = "1"; }

                if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                {
                    _checkWindowsExplorerFolderOptions.Add(true);
                }
                else
                {
                    _checkWindowsExplorerFolderOptions.Add(false);
                }


                #endregion
                #region Display the contents of system folders

                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOWebViewBarricade") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOWebViewBarricade");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOWebViewBarricade");
                }
                if (_displayContentOfSystemFolder)
                { value = "1"; }
                else
                { value = "0"; }

                if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                {
                    _checkWindowsExplorerFolderOptions.Add(true);
                }
                else
                {
                    _checkWindowsExplorerFolderOptions.Add(false);
                }


                #endregion
                #region Display the full path in the Address bar
                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsCabinetState") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsCabinetState");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsCabinetState");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOFullPathAddress") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOFullPathAddress");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOFullPathAddress");
                }
                if (_displayFullPathInAddressBar)
                { value = "1"; }
                else
                { value = "0"; }

                if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                {
                    _checkWindowsExplorerFolderOptions.Add(true);
                }
                else
                {
                    _checkWindowsExplorerFolderOptions.Add(false);
                }

                #endregion
                #region Show hidden files and folders
                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOHidden") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOHidden");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOHidden");
                }
                if (_showHiddenFolders)
                { value = "1"; }
                else
                { value = "2"; }

                if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                {
                    _checkWindowsExplorerFolderOptions.Add(true);
                }
                else
                {
                    _checkWindowsExplorerFolderOptions.Add(false);
                }

                #endregion
                #region Hide extensions for known file types
                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOHideFileExt") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOHideFileExt");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOHideFileExt");
                }
                if (_hideExtensions)
                { value = "1"; }
                else
                { value = "0"; }

                if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                {
                    _checkWindowsExplorerFolderOptions.Add(true);
                }
                else
                {
                    _checkWindowsExplorerFolderOptions.Add(false);
                }
                #endregion
                #region Hide protected operating system files
                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOShowSuperHidden") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOShowSuperHidden");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOShowSuperHidden");
                }
                if (_hideProtectedOSFiles)
                { value = "0"; }
                else
                { value = "1"; }

                if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                {
                    _checkWindowsExplorerFolderOptions.Add(true);
                }
                else
                {
                    _checkWindowsExplorerFolderOptions.Add(false);
                }
                #endregion
                #region The view settings for each folder
                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOClassicViewState") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOClassicViewState");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOClassicViewState");
                }
                if (_rememberEachFoldersViewSetting)
                { value = "0"; }
                else
                { value = "1"; }

                if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                {
                    _checkWindowsExplorerFolderOptions.Add(true);
                }
                else
                {
                    _checkWindowsExplorerFolderOptions.Add(false);
                }

                #endregion
                #region Show encrypted or compressed NTFS files in color
                if (ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced") != null)
                {
                    regPath = ResourceHelper.GetOSOperations(os, "EMOregPathfolderOptionsAdvanced");
                }
                else
                {
                    regPath = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOregPathfolderOptionsAdvanced");
                }

                if (ResourceHelper.GetOSOperations(os, "EMOShowCompColor") != null)
                {
                    regKey = ResourceHelper.GetOSOperations(os, "EMOShowCompColor");
                }
                else
                {
                    regKey = ResourceHelper.GetOSOperations(OSVersions.AllOS, "EMOShowCompColor");
                }
                if (_showNTFSFilesInColor)
                { value = "1"; }
                else
                { value = "0"; }

                if (configClass.GetScriptHandling.CheckRegKeyExist(regPath, regKey, value))
                {
                    _checkWindowsExplorerFolderOptions.Add(true);
                }
                else
                {
                    _checkWindowsExplorerFolderOptions.Add(false);
                }
                #endregion


                foreach (bool b in _checkWindowsExplorerFolderOptions)
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
                Actemium.Diagnostics.Trace.WriteError("({0})", "Set Windows explorer folder options", CLASSNAME, ex);
                configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Set Windows explorer folder options", ex.Message));

            }
           
            return totalcheck;
        }
        private const string AUTOPLAY = "Autoplay is set to :";
        private const string SHOW_THE_CONTENT_OF_SYSTEM_FOLDER = "Show the content of system folder is set to :";
        private const string DISPLAY_THE_FULL_PATH_IN_THE_ADDRESS_BAR = "Display the full path in the address bar is set to :";
        private const string SHOW_HIDDEN_FILES_AND_FOLDERS = "Show hidden files and folders is set to :";
        private const string AUTOMATIC_SEARCH_FOR_NETWORK_FOLDERS_AND_PRINTERS = "Automatic search for network folders and printers is set to :";
        private const string HIDE_FILE_EXTENSIONS = "Hide File extensions is set to :";
        private const string SHOW_SYSTEM_FILES_AND_FOLDERS = "Show system files and folders is set to :";
        private const string THE_VIEW_SETTINGS_FOR_EACH_FOLDER = "The View settings for each folder is set to :";
        private const string SHOW_ENCRYPTED_OR_COMPRESSED_NTFS_FILES_IN_COLOR = "Show Encrypted or compressed NTFS files in color is set to :";
        
        public void GetAllCurrentWindowsSettings(ConfigClass configClass)
        {
          const string FUNCTIONNAME = "GetAllCurrentWindowsSettings";
          try
          {
            Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
            ScriptHandling _sh = new ScriptHandling();
            _sh.ShowCurrentWindowsSettings();
            
            foreach (string str in _sh.ShowAllCurrentWindowsSettings)
            {
              int seperationIndex = str.IndexOf(":");
              string windowsSettingsName = str.Substring(0, seperationIndex + 1);
              string windowsSettingsValue = str.Substring(seperationIndex + 1, str.Length - seperationIndex - 1);
              bool windowsValue = false;
              int temp = 0;
                  
              switch (windowsSettingsName)
              {
                case AUTOPLAY:
                  temp = int.Parse(windowsSettingsValue);
                  switch (temp)
                  {
                    case 0:
                      windowsValue = false;
                      break;
                    case 1:
                      windowsValue = true;
                      break;
                  }
                  AutoplayCD = windowsValue;
                  break;
                case SHOW_THE_CONTENT_OF_SYSTEM_FOLDER:
                  temp = int.Parse(windowsSettingsValue);
                  switch (temp)
                  {
                    case 0:
                      windowsValue = false;
                      break;
                    case 1:
                      windowsValue = true;
                      break;
                  }
                  DisplayContentOfSystemFolder = windowsValue;
                  break;
                case DISPLAY_THE_FULL_PATH_IN_THE_ADDRESS_BAR:
                  temp = int.Parse(windowsSettingsValue);
                  switch (temp)
                  {
                    case 0:
                      windowsValue = false;
                      break;
                    case 1:
                      windowsValue = true;
                      break;
                  }
                  DisplayFullPathInAddressBar = windowsValue;
                  break;
                case SHOW_HIDDEN_FILES_AND_FOLDERS:
                  temp = int.Parse(windowsSettingsValue);
                  switch (temp)
                  {
                    case 0:
                      windowsValue = false;
                      break;
                    case 1:
                      windowsValue = true;
                      break;
                  }
                  ShowHiddenFolders = windowsValue;
                  break;
                case AUTOMATIC_SEARCH_FOR_NETWORK_FOLDERS_AND_PRINTERS:
                  temp = int.Parse(windowsSettingsValue);
                  switch (temp)
                  {
                    case 0:
                      windowsValue = false;
                      break;
                    case 1:
                      windowsValue = true;
                      break;
                  }
                  AutomaticallySearchNetworkFoldersAndPrinters = windowsValue;
                  break;
                case HIDE_FILE_EXTENSIONS:
                  temp = int.Parse(windowsSettingsValue);
                  switch (temp)
                  {
                    case 0:
                      windowsValue = false;
                      break;
                    case 1:
                      windowsValue = true;
                      break;
                  }
                  HideExtensions = windowsValue;
                  break;
                case SHOW_SYSTEM_FILES_AND_FOLDERS:
                  temp = int.Parse(windowsSettingsValue);
                  switch (temp)
                  {
                    case 0:
                      windowsValue = false;
                      break;
                    case 1:
                      windowsValue = true;
                      break;
                  }
                  HideProtectedOSFiles = windowsValue;
                  break;
                case THE_VIEW_SETTINGS_FOR_EACH_FOLDER:
                  temp = int.Parse(windowsSettingsValue);
                  switch (temp)
                  {
                    case 0:
                      windowsValue = false;
                      break;
                    case 1:
                      windowsValue = true;
                      break;
                  }
                  RememberEachFoldersViewSetting = windowsValue;
                  break;
                case SHOW_ENCRYPTED_OR_COMPRESSED_NTFS_FILES_IN_COLOR:
                  temp = int.Parse(windowsSettingsValue);
                  switch (temp)
                  {
                    case 0:
                      windowsValue = false;
                      break;
                    case 1:
                      windowsValue = true;
                      break;
                  }
                  ShowNTFSFilesInColor = windowsValue;
                  break;
                
                default:
                  Trace.WriteInformation("'{0}' is not a supported value for Windows Settings", FUNCTIONNAME, CLASSNAME, windowsSettingsName);
                  break;
              }
            }
          }
          catch (Exception ex)
          {
            Trace.WriteError("()", FUNCTIONNAME, CLASSNAME, ex);
            configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "GetAllAuditPolicy", ex.Message));
          }

        }

    }
}
