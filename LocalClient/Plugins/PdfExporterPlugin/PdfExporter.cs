using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using FriendlyBudget.LocalClient.Components.Core.Interfaces;

namespace FriendlyBudget.LocalClient.Plugins.PdfExporterPlugin
{
    class PdfExporter<T> : IExporter<T>
    {


        #region Constructors

        public PdfExporter()
        {

        }

        #endregion

        #region Public Methods

        public void Export(T dataSource)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Methods

        public void PrepareData()
        {
            throw new NotImplementedException();
        }

        public bool CheckSuccess()
        {
            throw new NotImplementedException();
        }

        #endregion 
    }
}
