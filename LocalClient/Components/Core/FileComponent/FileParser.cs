using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget.LocalClient.Components.Core.FileComponent
{
    class FileParser
    {
        private string _path;
        private string _defaultPath;
        private string _fileName;

        public string Parse(string filename)
        {
            string path = string.Empty;
            SetPath(path);
            string result = string.Empty;
            result = ParseInternal(filename);
            return result;
        }

        public string Parse(string filename, string path)
        {
            SetPath(path);
            string result = string.Empty;
            result = ParseInternal(filename);
            return result;
        }

        private string ParseInternal(string filename)
        {
            if(!FileExists())
            {
                throw new Exception("File not found.");
            }

            throw new NotImplementedException();
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
            throw new NotImplementedException();

            string path = _path + _fileName;

            if (!string.IsNullOrWhiteSpace(path))
            {
                return true;
            }

            return false;
        }
    }
}
