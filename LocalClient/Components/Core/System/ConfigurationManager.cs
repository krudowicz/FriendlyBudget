using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Core.System
{
    class ConfigurationManager
    {
        private Dictionary<string, string> _databaseConfiguration;
        private Dictionary<string, string> _localConfiguration;
        private Dictionary<string, string> _globalConfiguration;

        public Dictionary<string, string> DatabaseConfiguration
        {
            get { return _databaseConfiguration; }
            set { _databaseConfiguration = value; }
        }

        public Dictionary<string, string> LocalConfiguration
        {
            get { return _localConfiguration; }
            set { _localConfiguration = value; }
        }

        public Dictionary<string, string> GlobalConfiguration
        {
            get { return _globalConfiguration; }
            set { _localConfiguration = value; }
        }

        public ConfigurationManager()
        {
            throw new NotImplementedException();
        }

        public ConfigurationManager(string configuration)
        {
            throw new NotImplementedException();
        }

        private void LoadConfiguration(Dictionary<string, string> configurationSet)
        {
            foreach(KeyValuePair<string, string> configuration in configurationSet)
            {

            }
        }

    }
}
