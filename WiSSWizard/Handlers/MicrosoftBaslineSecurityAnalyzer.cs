using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Actemium.WiSSWizard
{
    [Serializable]
    public class MBSAlogItem
    {
        //constructors
        public MBSAlogItem()
        {
        }
        public MBSAlogItem(string item)
        {
            _logItem = item;
        }

        //properties       
        public string LogItem
        {
            get
            {
                return _logItem;
            }
            set
            {
                _logItem = value;
            }
        } private string _logItem = "";
        
    }

    public class MicrosoftBaslineSecurityAnalyzer
    {
        //parameters
        private const string CLASSNAME = "MicrosoftBaslineSecurityAnalyzer";
        private string _MBSAisRunning = null;
        
        //constructor
        public MicrosoftBaslineSecurityAnalyzer()
        {

        }
        
       
        //properties
        public bool MBSAchecked
        {
            get
            {
                return _MBSAchecked;
            }
            set
            {
                _MBSAchecked = value;
            }

        } private bool _MBSAchecked = false;
        public bool RunMBSA
        {
            get
            {
                return _runMBSA;
            }
            set
            {
                _runMBSA = value;
            }
        } private bool _runMBSA = false;
        public string PathMBSA
        {
            get
            {
            return _pathMBSA;
            }
            set
            {
            _pathMBSA = value;
            }
        }private string _pathMBSA = "";
        public bool MBSAstate
        {
            get
            {
                return _MBSAstate;
            }
            set
            {
                _MBSAstate = value;
            }
        } private bool _MBSAstate = false;
        public bool MBSAkilled
        {
            get
            {
                return _MBSAkilled;
            }
            set
            {
                _MBSAkilled = value;
            }
        } private bool _MBSAkilled = false;
        public List<MBSAlogItem> MBSAlogs
        {
            get
            {
                return _mbsaLog;
            }
            set
            {
                _mbsaLog = value;
            }
        } private List<MBSAlogItem> _mbsaLog = new List<MBSAlogItem>();
        public string MBSAoverviewComment
        {
            get
            {
                return _MBSAoverviewComment;
            }
            set
            {
                _MBSAoverviewComment = value;
            }
        } private string _MBSAoverviewComment = "";

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
        public bool SetMBSA(ConfigClass configClass)
        {
            bool check = false;
            try
            {
                string mbsaLog = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\MBSAlog.txt";
                if (File.Exists(mbsaLog))
                {
                    File.Delete(mbsaLog);
                }

                _MBSAisRunning = "start";
                
                if (_runMBSA)
                {
                    _MBSAisRunning = _pathMBSA + "\\mbsacli.exe";
                    configClass.GetScriptHandling.RunMBSA(_pathMBSA, "\"" + mbsaLog + "\"");

                    if (_MBSAkilled)
                    {
                        _MBSAisRunning = null;
                        return false;
                    }
                    else
                    {
                        _MBSAisRunning = null;
                        return true;

                    }
                }
            }
            catch (Exception ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Run MBSA", CLASSNAME, ex);
                configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Run mbsa", ex.Message));
            }
            return check;
        }
        public string FindMBSAexePath(string folderInProgramFiles,ConfigClass configClass)
        {
            try
            {
                string programFiles = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles);
                string folderName = "";
                List<string> programs = new List<string>();
                DirectoryInfo dir = new DirectoryInfo(programFiles);
                foreach (DirectoryInfo f in dir.GetDirectories())
                {
                    if (f.Name.Contains(folderInProgramFiles))
                    {
                        folderName = f.Name;
                        return programFiles + "\\" + folderName;
                    }
                }
            }
            catch (Exception ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Find path from MBSA executable", CLASSNAME, ex);
                configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "", ex.Message));
            }
            return null;
        }
        public void ReadMBSAlog(ConfigClass configClass)
        {
            try
            {
                string mbsaLog = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\MBSAlog.txt";
                if (File.Exists(mbsaLog))
                {
                    FileHandling _fileHandling = new FileHandling();
                    foreach (string str in _fileHandling.ReadWholeFile(mbsaLog))
                    {
                        MBSAlogs.Add(new MBSAlogItem(str));
                    }
                }
            }
            catch (Exception ex)
            {
               configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Read MBSA log", ex.Message));

            }
        
        }

        public void KillMBSAProcessesByClosing(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.StartsWith(name))
                {
                    MBSAkilled = true;
                    clsProcess.Kill();
                    break;
                }
            }
        }
    }
    
}
