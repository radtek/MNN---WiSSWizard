using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Windows.Forms;

namespace Actemium.WiSSWizard
{
    public class XMLhandler
    {
        private const string CLASSNAME = "XMLhandler";

        private const int CONFIGURATIONVERSION = 1;
        public static void WriteConfigToFile(string StyleSheetType, string FileNamePath, string FileFolder, ConfigClass configClass)
        {
            try
            {

              FileHandling fileHandling = new FileHandling(configClass);

                if (!File.Exists(FileNamePath))
                {
                    fileHandling.CreateFile(FileNamePath);
                }
                //string stylesheetPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\stylesheets\Actemium.xsl";
                if (StyleSheetType == "ConfigOverview")
                {
                    string stylesheetPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\stylesheets\Actemium.xsl";
                    if (!File.Exists(FileFolder + "ActemiumStyleSheet.xsl"))
                    {
                        File.Copy(stylesheetPath, FileFolder + "ActemiumStyleSheet.xsl");
                    }
                    else
                    {
                        File.Delete(FileFolder + "ActemiumStyleSheet.xsl");
                        File.Copy(stylesheetPath, FileFolder + "ActemiumStyleSheet.xsl");
                    }
                }
                else if (StyleSheetType == "ErrorOverview")
                {
                    string stylesheetPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\stylesheets\Error.xsl";
                    
                    string file = FileFolder + "ActemiumStyleSheet.xsl";
                    if (!File.Exists(file))
                    {
                        File.Copy(stylesheetPath, FileFolder + "ActemiumStyleSheet.xsl");
                    }
                    else
                    {
                        File.Delete(FileFolder + "ActemiumStyleSheet.xsl");
                        File.Copy(stylesheetPath, FileFolder + "ActemiumStyleSheet.xsl");
                    }
                }
                else if (StyleSheetType == "TotalOverview")
                {
                    string stylesheetPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\stylesheets\TotalOverviewActemium.xsl";

                    if (!File.Exists(FileFolder + "ActemiumStyleSheet.xsl"))
                    {
                        File.Copy(stylesheetPath, FileFolder + "ActemiumStyleSheet.xsl");
                    }
                    else
                    {
                        File.Delete(FileFolder + "ActemiumStyleSheet.xsl");
                        File.Copy(stylesheetPath, FileFolder + "ActemiumStyleSheet.xsl");
                    }
                }
                using (StreamWriter streamWriter = new StreamWriter(FileNamePath))
                {
                    string blockKeysSettingsRaw = CtrlHome.GetConfigClass.Serialize(StyleSheetType);
                    streamWriter.Write(blockKeysSettingsRaw);
                    streamWriter.Flush();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Writing configuration to configuration file failed.", ex);
            }



        }
        public static ConfigClass ReadConfigFromFile(string FileNamePath)
        {
            try
            {
                if (File.Exists(FileNamePath))
                {
                    string blockSettingsXMLString = null;

                    using (StreamReader streamReader = new StreamReader(FileNamePath))
                    {
                        string blockKeysSettingsENC = streamReader.ReadToEnd();

                        if (blockKeysSettingsENC.Length > 0)
                            blockSettingsXMLString = blockKeysSettingsENC;
                    }

                    return ConfigClass.Deserialize(blockSettingsXMLString);
                }
                else
                    throw new ApplicationException(String.Format("Configuration file ({0}) not found.", FileNamePath));
            }
            catch (Exception ex)
            {
                Actemium.Diagnostics.Trace.WriteError("({0})", "Read config from xml file", CLASSNAME, ex);
                //_configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Read config from xml file", ex.Message));
                throw;
            }
        }

    }
}
