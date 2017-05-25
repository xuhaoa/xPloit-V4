using System;
using System.IO;

namespace xPloit_V4
{
    class FileManager
    {
        //Create File:
        public void createFile(string path)
        {
            try
            {
                var f = File.Create(path);
                f.Dispose();
            }
            catch
            {
                return;
            }
        }

        //File Exists:
        public bool fileExists(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }

            return false;
        }

        //Dir Exists:
        public bool dirExists(string path)
        {
            if (Directory.Exists(path))
            {
                return true;
            }

            return false;
        }

        //Get Files In Directory:
        public string[] getFiles(string path)
        {
            try
            {
                string[] files = Directory.GetFiles(path);
                return files;
            }
            catch
            {
                return null;
            }
        }

        //Get Directories In Directory:
        public string[] getDirs(string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                return dirs;
            }
            catch
            {
                return null;
            }
        }

        //Get File Contents:
        public string getFileContents(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                string contents = "";

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    contents = contents + line + "\n";
                }

                return contents;
            }
            catch
            {
                return null;
            }
        }
    }
}