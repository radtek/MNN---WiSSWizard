using System;
using System.Configuration;
using System.Linq;

namespace Actemium.WiSSWizard
{
  public sealed class Settings
  {
    static Settings()
    {
      _configHandlerNavigation = (ConfigHandlerNavigation)ConfigurationManager.GetSection("Navigation");
    }

    public static ConfigHandlerNavigation Navigation
    {
      get { return _configHandlerNavigation; }
    } private static ConfigHandlerNavigation _configHandlerNavigation = null;   
  }
}
