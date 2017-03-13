using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actemium.WiSSWizard
{
    public class DefaultInformation
    {
        //constructor
        public DefaultInformation()
        {
        }
        
        //properties
        public string ConfigName
        {
            get
            {
                return _configName;
            }
            set
            {
                _configName = value;
            }

        } private string _configName = "";
        public string ConfigDateTime
        {
            get
            {
                return _configDateTime;
            }
            set
            {
                _configDateTime = value;
            }

        } private string _configDateTime = "";
        public string ApplicationUserName
        {
            get
            {
                return _applicationUserName;
            }
            set
            {
                _applicationUserName = value;
            }
        } private string _applicationUserName="";
        public string ApplicationFamilyName
        {
            get
            {
                return _applicationFamilyName;
            }
            set
            {
                _applicationFamilyName = value;
            }
        } private string _applicationFamilyName;
        public string Operatingsystem
        {
            get
            {
                return _operatingSystem;
            }
            set
            {
                _operatingSystem = value;
            }
        } private string _operatingSystem="";
        public string ComputerName
        {
            get
            {
                return _computerName;
            }
            set
            {
                _computerName = value;
            }

        }private string _computerName = "";

        public bool SecurityConfiguration
        {
            get
            {
                return _securityConfiguration;
            }
            set
            {
                _securityConfiguration = value;
            }
        } private bool _securityConfiguration;
        public bool AdvancedConfiguration
        {
            get
            {
                return _advancedConfiguration;
            }
            set
            {
                _advancedConfiguration = value;
            }
        } private bool _advancedConfiguration;
        public bool LockDownConfiguration
        {
            get
            {
                return _lockDownConfiguration;
            }
            set
            {
                _lockDownConfiguration = value;
            }
        }private bool _lockDownConfiguration;
        public bool LoadtemplateConfiguration
        {
            get
            {
                return _loadTemplateConfiguration;
            }
            set
            {
                _loadTemplateConfiguration = value;
            }

        }private bool _loadTemplateConfiguration;

    }
}
