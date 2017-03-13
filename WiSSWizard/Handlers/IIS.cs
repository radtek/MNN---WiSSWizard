using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Actemium.Diagnostics;

namespace Actemium.WiSSWizard
{

  [Serializable]
  public class NewWebServer
  {
    const string CLASSNAME = "SetNetwork";
    //Parameters
    /// <summary>
    /// Get or set SiteName
    /// </summary>
    public string SiteName
    {
      get { return _siteName; }
      set { _siteName = value; }
    } private string _siteName;
    
    /// <summary>
    /// Get or set SiteProtocol
    /// </summary>
    public string SiteProtocol
    {
      get { return _siteProtocol; }
      set { _siteProtocol = value; }
    } private string _siteProtocol; 
    /// <summary>
    /// Get or set SitePath
    /// </summary>
    public string SitePath
    {
      get { return _sitePath; }
      set { _sitePath = value; }
    } private string _sitePath;
    /// <summary>
    /// Get or set SiteIPAddress
    /// </summary>
    public string SiteIPAddress
    {
      get { return _siteIpAddress; }
      set { _siteIpAddress = value; }
    } private string _siteIpAddress;
    /// <summary>
    /// Get or set SiteTcpPort
    /// </summary>
    public string SiteTcpPort
    {
      get { return _siteTcpPort; }
      set { _siteTcpPort = value; }
    } private string _siteTcpPort;

    /// <summary>
    /// Get or set SiteHostname
    /// </summary>
    public string SiteHostname
    {
      get { return _siteHostName; }
      set { _siteHostName = value; }
    } private string _siteHostName;
    /// <summary>
    /// Get or set SiteApplicationPool
    /// </summary>
    public string SiteApplicationPool
    {
      get { return _siteAppPool; }
      set { _siteAppPool = value; }
    } private string _siteAppPool; 
    //////////////////////////////////
    //Constructor
    public NewWebServer()
    { }

    //Methods
    public NewWebServer(string siteName,string siteProtocol,string siteIp,string sitePort,string siteHostHeader,string siteAppPool,string siteLocation)
    {
      _siteName = siteName;      
      _siteProtocol = siteProtocol;
      _siteTcpPort = sitePort;
      _siteIpAddress = siteIp;
      _siteHostName = siteHostHeader;
      _siteAppPool = siteAppPool;
      _sitePath = siteLocation;
    }

  }
  [Serializable]
  public class NewFTPServer
  {
    public NewFTPServer()
    {}
    //parameters
    /// <summary>
    /// Get or set Name
    /// </summary>
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    } private string _name;

    /// <summary>
    /// Get or set SitePath
    /// </summary>
    public string SitePath
    {
      get { return _sitePath; }
      set { _sitePath = value; }
    } private string _sitePath;
    public string SiteIPAddress
    {
      get { return _siteIpAddress; }
      set { _siteIpAddress = value; }
    } private string _siteIpAddress;
    /// <summary>
    /// Get or set SiteTcpPort
    /// </summary>
    public string SiteTcpPort
    {
      get { return _siteTcpPort; }
      set { _siteTcpPort = value; }
    } private string _siteTcpPort;

    /// <summary>
    /// Get or set DisableVirtualHostName
    /// </summary>
    public bool DisableVirtualHostName
    {
      get { return _disableVirtualHostName; }
      set { _disableVirtualHostName = value; }
    } private bool _disableVirtualHostName = true;
    /// <summary>
    /// Get or set AuthenticationType
    /// </summary>
    public List<bool> AuthenticationType
    {
      get { return _authenticationType; }
      set { _authenticationType = value; }
    } private List<bool> _authenticationType; 

    //methods
    public NewFTPServer(string ftpSiteName,string ftpSiteLocation,string ftpSitePort,string ftpSiteIpAddress)
    {
      _name = ftpSiteName;
      _sitePath = ftpSiteLocation;
      _siteTcpPort = ftpSitePort;
      _siteIpAddress = ftpSiteIpAddress;
    }
  }
  [Serializable]
  public class WebServer
  {
    private const string CLASSNAME = "WebServer";
    //parameters
    private List<NewWebServer> _newWebServer = new List<NewWebServer>();

    //constructor
    public WebServer()
    {}
    public List<NewWebServer> NewWebServerList
    {
      get
      { return _newWebServer; }
    }
    public NewWebServer AddNewWebserver
    {
      set
      {
        NewWebServer webServer = value;
        _newWebServer.Add(webServer);
      }
    }
    

    public void AddWebServer(ConfigClass configClass)
    {
      const string FUNCTIONNAME = "AddWebServer";
      try
      {
        Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
        string siteName = "";
        string siteLocation = "";
        string siteProtocol = "";
        string sitePort = "";
        string siteIpAddress = "";
        string siteHostname = "";
        string siteAppPool = "";        
        foreach (NewWebServer ws in _newWebServer)
        {
          if (ws.SiteName.Length != 0)
            siteName = ws.SiteName;
          if (ws.SitePath.Length != 0)
            siteLocation = ws.SitePath;
          if (ws.SiteProtocol.Length != 0)
            siteProtocol = ws.SiteProtocol;
          if (ws.SiteTcpPort.Length != 0)
            sitePort = ws.SiteTcpPort;
          if (ws.SiteIPAddress.Length != 0)
            siteIpAddress = ws.SiteIPAddress;
          if (ws.SiteHostname.Length != 0)
            siteHostname = ws.SiteHostname;
          if (ws.SiteApplicationPool.Length != 0)
            siteAppPool = ws.SiteApplicationPool;          
          configClass.GetScriptHandling.AddIIS7WebSite(siteName, siteProtocol, siteIpAddress, sitePort,siteHostname,siteAppPool, siteLocation);
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
