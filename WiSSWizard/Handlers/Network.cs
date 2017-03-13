using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Actemium.WiSSWizard.Support;
using Actemium.Diagnostics;

namespace Actemium.WiSSWizard
{
  [Serializable]
  public class NewNetwork
  {
    const string CLASSNAME = "SetNetwork";
    /// <summary>
    /// Get or set NetCaption
    /// </summary>
    public string NetCaption
    {
      get { return _caption; }
      set { _caption = value; }
    } private string _caption;
    //Properties
    /// <summary>
    /// Get or set IpAddress
    /// </summary>
    public string IpAddress
    {
      get { return _ipAddress; }
      set { _ipAddress = value; }
    } private string _ipAddress;
    /// <summary>
    /// Get or set SubnetMask
    /// </summary>
    public string SubnetMask
    {
      get { return _subnetMask; }
      set { _subnetMask = value; }
    } private string _subnetMask;
    /// <summary>
    /// Get or set Gateway
    /// </summary>
    public string Gateway
    {
      get { return _gateway; }
      set { _gateway = value; }
    } private string _gateway;
    /// <summary>
    /// Get or set SetDnsServers
    /// </summary>
    public List<string> SetDnsServers
    {
      get { return _dnsServers; }
      set { _dnsServers = value; }
    } private List<string> _dnsServers;
    
    //Constructor
    public NewNetwork()
    { }
    //Methods
    public NewNetwork(string ipAddress, string subnetMask, string gateway, List<string> dnsServers, string caption)
    {
      _ipAddress = ipAddress;
      _subnetMask = subnetMask;
      _gateway = gateway;
      _dnsServers = dnsServers;
      _caption = caption;

    }
  }
  public class SetNetwork
  {
    private const string CLASSNAME = "SetNetwork";
    //parameters

    /// <summary>
    /// Get or set CaptionList
    /// </summary>
    public List<string> CaptionList
    {
      get { return _captionList; }
      set { _captionList = value; }
    } private List<string> _captionList = new List<string>();
    /// <summary>
    /// Get or set IpAutoAssign
    /// </summary>
    public bool IpAutoAssign
    {
      get { return _ipAutoAssign; }
      set { _ipAutoAssign = value; }
    } private bool _ipAutoAssign = true;
    /// <summary>
    /// Get or set DnsAutoAssign
    /// </summary>
    public bool DnsAutoAssign
    {
      get { return _dnsAutoAssign; }
      set { _dnsAutoAssign = value; }
    } private bool _dnsAutoAssign = true;
    private List<NewNetwork> _newNetwork = new List<NewNetwork>();

    //constructor
    public SetNetwork()
    {}
    public List<NewNetwork> NewNetworkList
    {
      get
      { return _newNetwork; }
    }
    public NewNetwork AddNewNetwork
    {
      set
      {
        NewNetwork newNetwork = value;
        _newNetwork.Add(newNetwork);      
      }
    }


    public void SetNetworkStaticConfigure(OSVersions os, ConfigClass configClass)
    
    {      
      const string FUNCTIONNAME = "SetNetworkConfigure";
      Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
      try
      {       
          string staticIpAddress = "";
          string staticSubnetMask = "";
          string staticDefaultGateway ="";
          string staticCaption = "";
          List<string> ListOfDnsServers = new List<string>();
          foreach (NewNetwork nn in _newNetwork)
          {
            if (nn.IpAddress.Length != 0)
              staticIpAddress = nn.IpAddress;
            if (nn.SubnetMask.Length != 0)
              staticSubnetMask = nn.SubnetMask;
            if (nn.Gateway.Length != 0)
              staticDefaultGateway = nn.Gateway;
            if (nn.SetDnsServers.Count != 0)
              ListOfDnsServers = nn.SetDnsServers;
            if (nn.NetCaption.Length != 0)
              staticCaption = nn.NetCaption;

            if (_ipAutoAssign == false)
              _dnsAutoAssign = false;
            if (_ipAutoAssign == false)
              configClass.GetScriptHandling.SetStaticIPAddresses(staticIpAddress, staticSubnetMask, staticDefaultGateway, ListOfDnsServers, staticCaption);
            else if (_ipAutoAssign == true && _dnsAutoAssign == true)
              configClass.GetScriptHandling.SetAutoIpAddresses(staticCaption);
            else if (_ipAutoAssign == true && _dnsAutoAssign == false)
            {
              foreach (string dnsString in ListOfDnsServers)
                configClass.GetScriptHandling.SetStaticDnsAddresses(dnsString, staticCaption);
            }           
          }
      }
      catch (Exception ex)
      {
        Trace.WriteError("({0})", FUNCTIONNAME, CLASSNAME, ex);
        configClass.ErrorList.Add(new ConfigErrors(CLASSNAME, "Set IP settings", ex.Message));
      }
    }
    const string NICNAME = "Current configure for ";
    public void GetAllNic()
    {
      const string FUNCTIONNAME = "GetAllNic";
      Trace.WriteVerbose("()", FUNCTIONNAME, CLASSNAME);
      ScriptHandling _sh = new ScriptHandling();
      _sh.ShowCurrentIPSetting();      
      foreach (string currentIpString in _sh.ShowAllCurrentIPSettings)
      {
        if (currentIpString.Contains(NICNAME))
        {
          int seperationIndex = currentIpString.IndexOf("[");
          string captionInit = currentIpString.Substring(0, seperationIndex);
          string captionName = currentIpString.Substring(seperationIndex, currentIpString.Length - captionInit.Length);
          if (captionName.Contains("\r"))
            captionName = captionName.Substring(0, captionName.Length - 1);
          _captionList.Add(captionName);
          
        }
      }
    }
  }
}