using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FriendlyBudget.LocalClient.Components.Core.Serialization
{
    class XmlDeserializer<T> : IDisposable where T : class
    {
        #region Fields

        private bool _disposed = false;

        #endregion

        #region Properties

        #endregion

        #region Constructors

        public XmlDeserializer()
        {

        }

        #endregion

        #region Public Methods

        #endregion

        #region Methods

        #endregion

        #region IDisposable implementation

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if(!_disposed)
            {
                if(disposing)
                {
                    
                }
            }

            _disposed = true;
        }

        #endregion
    }
}
