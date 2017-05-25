using System;
using System.Diagnostics;
using System.IO;

namespace xPloit_V4
{
    class OS
    {
        Launcher lnc = new Launcher();

        //Get User:
        public string getUser()
        {
            string user = Environment.UserName;
            return user;
        }

        //Get Current Drive:
        public string getCurrentDrive()
        {
            string currentDrive = Path.GetPathRoot(Directory.GetCurrentDirectory());
            return currentDrive;
        }

        //Get Sys32:
        public string getSys32()
        {
            string currentDrive = this.getCurrentDrive();
            string sys32 = currentDrive + "Windows\\System32";
            return sys32;
        }

        //Open Task Manager:
        public void openTaskManager()
        {
            string sys32 = this.getSys32();
            lnc.launchPath(sys32 + "\\taskmgr.exe");
        }

        //Kill Process:
        public void killProcess(string name)
        {
            foreach (var process in Process.GetProcessesByName(name))
            {
                process.Kill();
            }
        }
    }
}