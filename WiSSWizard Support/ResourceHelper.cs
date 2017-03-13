using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actemium.WiSSWizard.Support
{
    public enum OSVersions
    {
        AllOS,
        WindowsXP,
        WindowsXP32,
        WindowsXP64,
        W2003,
        W2003R2,
        WindowsVista,
        WindowsVista32,
        WindowsVista64,
        Windows7,
        W2008,
        W2008R2

/*
Windows 7  6.1   
Windows Server 2008 R2 6.1
Windows Server 2008 6.0
Windows Vista 6.0 
Windows Server 2003 R2 5.2  
Windows Server 2003 5.2  
Windows XP 64-Bit Edition 5.2  
Windows XP 5.1  
*/
    }

    public partial class ResourceHelper
    {
        static public string GetOSOperations(OSVersions osVersion, String operation)
        {
            String version = Environment.OSVersion.Version.ToString();

            switch (osVersion)
            {
                case OSVersions.AllOS:
                    return RES_OS_ALL.ResourceManager.GetString(operation);
                case OSVersions.WindowsXP:
                    return RES_OS_XP.ResourceManager.GetString(operation);
                case OSVersions.WindowsXP32:
                    return RES_OS_XP.ResourceManager.GetString(operation);
                case OSVersions.WindowsXP64:
                    return RES_OS_XP.ResourceManager.GetString(operation);
                case OSVersions.W2003:
                    return RES_OS_W2003.ResourceManager.GetString(operation);
                case OSVersions.WindowsVista:
                    return RES_OS_VISTA.ResourceManager.GetString(operation);
                case OSVersions.WindowsVista32:
                    return RES_OS_VISTA.ResourceManager.GetString(operation);
                case OSVersions.WindowsVista64:
                    return RES_OS_VISTA.ResourceManager.GetString(operation);
                case OSVersions.Windows7:
                    return RES_OS_W7.ResourceManager.GetString(operation);
                case OSVersions.W2008:
                    return RES_OS_2008.ResourceManager.GetString(operation);
                case OSVersions.W2008R2:
                    return RES_OS_2008.ResourceManager.GetString(operation);
                default:
                    throw new NotImplementedException();
            }

        }
        static public string GettoolTipText(String ToolTipname)
        {
            return ToolTipText.ResourceManager.GetString(ToolTipname);    
        }



    }
}
