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
        private bool _disposed = false;

        private FileReader _reader;
        private string _path;
        private string _currentContent;
        
        public FileWriter()
        {
            _reader = new FileReader();
            _path = string.Empty;
            _currentContent = string.Empty;
        }

        public void Write(string content, string path, bool overwriteContent)
        {
            _path = path;
            WriteInternal(content, overwriteContent);
        }

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
                    _currentContent = string.Empty;
                }
            }

            _disposed = true;
        }
    }
}
