using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using FriendlyBudget.LocalClient.Components.Core.Interfaces;

namespace FriendlyBudget.LocalClient.Plugins.PdfExporterPlugin
{
    class PdfExporter<T> : IExporter<T>, IDisposable
    {
        private Dictionary<string, string> _configuration;
        #region Constructors

        public PdfExporter()
        {
            _configuration = new Dictionary<string, string>();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Public Methods

        public void Export(T dataSource)
        {
            throw new NotImplementedException();
        }

        public void Export(List<T> dataSource)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Methods

        private bool CheckSuccess()
        {
            throw new NotImplementedException();
        }

        private void ParseData(T dataSource)
        {
            throw new NotImplementedException();
        }

        private void ParseData(List<T> dataSource)
        {
            throw new NotImplementedException();
        }

        #endregion 
    }
}
