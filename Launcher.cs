using System;
using System.Diagnostics;

namespace xPloit_V4
{
    class Launcher
    {
        //Launch Path:
        public void launchPath(string path)
        {
            Process.Start(path);
        }
    }
}