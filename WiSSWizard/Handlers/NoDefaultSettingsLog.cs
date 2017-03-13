using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actemium.WiSSWizard
{
    [Serializable]    
    public class NoDefaultSettingsLog
    {
        //constructor
        public NoDefaultSettingsLog()
        {
    
        }
        public NoDefaultSettingsLog(string setting, string comment)
        {
            _setting = setting;
            _comment = comment;
        }

        //properties
        public string Setting
        {
            get
            {
                return _setting;
            }
            set
            {
                _setting = value;
            }
        } private string _setting = "";
        public string Comment
        {
            get
            {
                return _comment;
            }
            set
            {
                _comment = value;
            }
        } private string _comment = "";
    }
}
