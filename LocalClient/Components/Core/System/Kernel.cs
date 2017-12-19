using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Core.System
{
    class Kernel
    {

        public static Kernel Instance { get; private set; }
        public ConfigurationManager ConfigurationManager { get; private set; }

        private Kernel()
        {
            ConfigurationManager = new ConfigurationManager();
        }

        public static Kernel getKernelInstance()
        {
            if(Instance == null)
            {
                Instance = new Kernel();
            }

            return Instance;
        }

        private void LoadConfiguration()
        {
            throw new NotImplementedException();
        }

        //TODO: void type will change
        public void GetConfiguration()
        {
            throw new NotImplementedException();
        }
    }
}
