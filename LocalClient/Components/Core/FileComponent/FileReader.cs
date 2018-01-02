using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Core.FileComponent
{
    class FileReader : IDisposable
    {
        private string _path;
        private string _defaultPath;
        private string _fileName;

        public string Read(string filename)
        {
            string path = string.Empty;
            SetPath(path);
            string result = string.Empty;
            result = ReadInternal(filename);
            return result;
        }

        public string Read(string filename, string path)
        {
            SetPath(path);
            string result = string.Empty;
            result = ReadInternal(filename);
            return result;
        }

        private string ReadInternal(string filename)
        {
            string result = string.Empty;
            string file = _path + filename;

            if(!FileExists())
            {
                throw new Exception("File not found.");
            }

            File.ReadAllLines(file);

            return result;
        }

        //TODO: Not complete!
        private void SetPath(string directory)
        {
            //Implement: If given directory is not absolute, set it to some default value + subdir
            if(string.IsNullOrWhiteSpace(directory))
            {
                _path = _defaultPath;
            }

            _path = directory;

        }

        private bool FileExists()
        {
            bool result = false;

            string path = _path + _fileName;

            if (!string.IsNullOrWhiteSpace(path))
            {
                result = File.Exists(path);
            }

            return result;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
