using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Actemium.WiSSWizard
{
    public class ConfigErrors
    {
        //constructors
        public ConfigErrors()
        { 
        }
        public ConfigErrors(string errorclass,string configError, string errorMessage)
        {
            _errorClass = errorclass;
            _configError = configError;
            _errorMessage = errorMessage;
        }

        //properties       
        public string ErrorClass
        {
            get
            {
                return _errorClass;
            }
            set
            {
                _errorClass = value;
            }
        } private string _errorClass = "";
        public string ConfigError
        {
            get
            {
                return _configError;
            }
            set
            {
                _configError = value;
            }
        } private string _configError = "";
        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
            }
        } private string _errorMessage = "";
    }
}
