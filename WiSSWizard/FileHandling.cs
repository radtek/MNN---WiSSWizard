using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Actemium.Diagnostics;

namespace Actemium.WiSSWizard
{
    class FileHandling
    {
        //parameters
        const string CLASSNAME = "FileHandling";
        private string _filePath;
        private FileStream _fileStream = null;
        private FileStream _newFileStream = null;
        private StreamWriter _streamWriter = null;
        private StreamReader _streamReader = null;
        private ConfigClass _configClass;
        
        //constructors
        public FileHandling()
        {
        }
        public FileHandling(ConfigClass configClass)
        {
            _configClass = configClass;
        }

        //properties 
        public string FilePath
        {
            get
            {
                return _filePath;
            }
            set
            {
                _filePath = value;
            }
        }
        
        //methods
        public string CreateFile(string path)
        {
            try
            {
                string folder = "";
                string[] splitPath = path.Split('\\');
                for (int i = 0; i < splitPath.Length-1; i++)
                { 
                folder = folder+splitPath[i]+"\\";
                }
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);

                    }
                _fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);


            }
            catch (IOException ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Create file", CLASSNAME, ex);
                _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "", ex.Message));
            }
            finally
            {

                if (_fileStream != null) { _fileStream.Close(); }

            }
            return path;
        }
        public string CreateRegFile(string path)
        {
            try
            {
                using (_fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {

                }
            }
            catch (IOException ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Create reg file", CLASSNAME, ex);
                _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Create reg file", ex.Message));
                
            }



            return path;
        }
        public string CreateFileName(string ext)
        {
            string fileName;
            try
            {
                
                DateTime dt = DateTime.Now;
                string machineName = System.Environment.MachineName;
                string month = "";
                string day = "";
                string year = dt.Year.ToString();
                string hour = "";
                string minute = "";
                string second = "";

                if (dt.Month == 1) { month = "Jan"; }
                else if (dt.Month == 2) { month = "feb"; }
                else if (dt.Month == 3) { month = "march"; }
                else if (dt.Month == 4) { month = "April"; }
                else if (dt.Month == 5) { month = "May"; }
                else if (dt.Month == 6) { month = "Jun"; }
                else if (dt.Month == 7) { month = "Jul"; }
                else if (dt.Month == 8) { month = "Aug"; }
                else if (dt.Month == 9) { month = "Sep"; }
                else if (dt.Month == 10) { month = "Oct"; }
                else if (dt.Month == 11) { month = "Nov"; }
                else if (dt.Month == 12) { month = "Dec"; }


                if (dt.Day < 10) { day = "0" + dt.Day.ToString(); }
                else { day = dt.Day.ToString(); }

                if (dt.Hour < 10) { hour = "0" + dt.Hour.ToString(); }
                else { hour = dt.Hour.ToString(); }

                if (dt.Minute < 10) { minute = "0" + dt.Minute.ToString(); }
                else { minute = dt.Minute.ToString(); }

                if (dt.Second < 10) { second = "0" + dt.Second.ToString(); }
                else { second = dt.Second.ToString(); }
                fileName = (machineName + "_" + year + "_" + month + "_" + day + "_" + hour + "." + minute + "." + second + " hr") + ext;
                return fileName;
            }
            catch (Exception ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Create file name", CLASSNAME, ex);
                _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Create file name", ex.Message));
                return null;
            }
        }

        public void AddLineToEndFile(string applicationPAth, string text)
        {
            try
            {
                if (_fileStream == null)
                {
                    CreateFile(applicationPAth);
                }
                else
                {
                    _fileStream = new FileStream(applicationPAth, FileMode.Append, FileAccess.Write);
                }
                _streamWriter = new StreamWriter(_fileStream);
                _streamWriter.WriteLine(text);
            }
            catch (IOException ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Add Line to end of file", CLASSNAME, ex);
                _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Add Line to end of file", ex.Message));
            }
            finally
            {
                if (_streamWriter != null) { _streamWriter.Close(); }
                if (_fileStream != null) { _fileStream.Close(); }
            }

        }
        public void AddLineToBeginFile(string applicationPAth, string text)
        {
            try
            {
                if (_fileStream == null)
                {
                    CreateFile(applicationPAth);
                }
                else
                {
                    _fileStream = new FileStream(applicationPAth, FileMode.Open, FileAccess.ReadWrite);
                }
                _streamReader = new StreamReader(_fileStream);
                string totalText = text + _streamReader.ReadToEnd();

                _streamWriter = new StreamWriter(_fileStream);
                _streamWriter.WriteLine(totalText);
            }
            catch (IOException ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "add line to begin of file", CLASSNAME, ex);
                _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "add line to begin of file", ex.Message));
            
            }
            finally
            {
                if (_streamWriter != null) { _streamWriter.Close(); }
                if (_fileStream != null) { _fileStream.Close(); }
            }

        }
        public List<string> ReadInLogFile(string path, string begin, string end)
        {
            List<string> listOfRoles = new List<string>();

            try
            {
                _fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

                using (StreamReader sr = new StreamReader(_fileStream))
                {
                    String line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == begin)
                        {
                            while ((line = sr.ReadLine()) != end && line != null)
                            {
                                listOfRoles.Add(line);
                            }
                            break;
                        }
                    }
                }
                for (int i = 0; i < listOfRoles.Count; i++)
                {
                    char[] charArray = { ' ' };
                    string s = listOfRoles[i].Trim(charArray);
                    listOfRoles[i] = s;
                }
            }
            catch (IOException ioex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Read in logfile", CLASSNAME, ioex);
                _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Read in logfile", ioex.Message));
            
                throw;
                // trace
                // handle
            }
            catch (Exception ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Read in logfile", CLASSNAME, ex);
                _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Read in logfile", ex.Message));
                throw;
            }
            finally
            {
                if (_fileStream != null) { _fileStream.Close(); }
            }

            return listOfRoles;
        }
        public List<string> ReadWholeFile(string path)
        {
            List<string> listOfRoles = new List<string>();

            try
            {
                _fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

                using (StreamReader sr = new StreamReader(_fileStream))
                {
                    String line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        listOfRoles.Add(line);
                    }
                }
                for (int i = 0; i < listOfRoles.Count; i++)
                {
                    char[] charArray = { ' ' };
                    string s = listOfRoles[i].Trim(charArray);
                    listOfRoles[i] = s;
                }
            }
            catch (IOException ioex)
            {
                Trace.WriteError("({0})", "ReadInLogFile", CLASSNAME, ioex, path);
                _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Read whole file", ioex.Message));
                // trace
                // handle
            }
            catch (Exception ex)
            {
                Trace.WriteError("({0})", "ReadInLogFile", CLASSNAME, ex, path);
                _configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Read whole file", ex.Message));
                
            }
            finally
            {
                if (_fileStream != null) { _fileStream.Close(); }
            }

            return listOfRoles;
        }

    }
}