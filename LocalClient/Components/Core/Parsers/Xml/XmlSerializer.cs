using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FriendlyBudget.LocalClient.Components.Core.Serialization
{
    class XmlSerializer : IDisposable
    {
        #region Fields

        private bool _disposed = false;

        private XmlDocument _document;

        #endregion

        #region Constructors

        public XmlSerializer()
        {
            _document = new XmlDocument();
        }

        #endregion

        #region Public Methods

        public void Serialize(string data)
        {
            SerializeInternal(data);
        }

        #endregion

        #region Methods

        private void SerializeInternal(string data)
        {
            throw new NotImplementedException();
        }

        private void PrepareData()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IDisposable implementation

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!_disposed)
            {
                if(disposing)
                {
                    _document = null;
                }
            }

            _disposed = true;
        }

        #endregion
    }
}
