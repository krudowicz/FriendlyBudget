using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Core.FileComponent
{
    class FileWriter : IDisposable
    {
        #region Fields

        private bool _disposed = false;

        private FileReader _reader;
        private string _path;
        private string _defaultPath;
        private string _currentContent;

        #endregion

        #region Constructors

        public FileWriter()
        {
            _reader = new FileReader();
            _path = string.Empty;
            _defaultPath = @"C:\Users\Default\Documents\FriendlyBudget";
            _currentContent = string.Empty;
        }

        #endregion

        #region Public Methods

        public void Write(string content, string path, bool overwriteContent)
        {
            _path = path;
            WriteInternal(content, overwriteContent);
        }

        #endregion

        #region Methods

        private void WriteInternal(string content, bool overwriteContent)
        {
            try
            {
                _currentContent = _reader.Read(_path);
            } catch(Exception e)
            {
                CreateFile(_path);
            } finally
            {
                if (overwriteContent)
                {
                    OverwriteFileContent(content);
                }
                else
                {
                    AppendToFile(content);
                }
            }
            
        }

        private void AppendToFile(string content)
        {
            File.AppendAllText(_path, content);
        }

        private void OverwriteFileContent(string content)
        {
            File.WriteAllText(_path, content);
        }

        private void CreateFile(string path)
        {
            File.Create(path);
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
                    _reader = null;
                    _path = string.Empty;
                    _defaultPath = string.Empty;
                    _currentContent = string.Empty;
                }
            }

            _disposed = true;
        }

        #endregion
    }
}
