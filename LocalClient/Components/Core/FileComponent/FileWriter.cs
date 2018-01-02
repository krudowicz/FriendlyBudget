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
            throw new NotImplementedException();
        }

        private void OverwriteFileContent(string content)
        {
            throw new NotImplementedException();
        }

        private bool FileExists()
        {
            throw new NotImplementedException();
        }

        private void CreateFile(string path)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
