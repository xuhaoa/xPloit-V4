/*
 * xPloit V4 Source Code:
 */

using System;
using System.Windows.Forms;
using System.IO;

namespace xPloit_V4
{
    /*
     * UI Controls:
     * tabGUI: Contains all controls and options.
     * args: Arguments for xPloit V4.
     * output: Log for events.
     */

    public partial class Form1 : Form
    {
        //Class Imports:
        FileManager fileLib = new FileManager();
        Launcher lnc = new Launcher();
        OS os = new OS();
        Client c = new Client();
        Exploit xploit = new Exploit();

        //When the form loads:
        public Form1()
        {
            InitializeComponent();

            output.ReadOnly = true;

            string user = os.getUser();
            string time = DateTime.Now.ToString();

            this.logger(time + " - " + user);
        }

        //Get args:
        private string getArgs()
        {
            string enteredArgs = args.Text;
            return enteredArgs;
        }

        //Log:
        private void logger(string text)
        {
            output.AppendText(text + "\n");
        }

        //Create File:
        private void createFilePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = this.getArgs();
            fileLib.createFile(path);

            if (fileLib.fileExists(path))
            {
                this.logger("File created: " + path);
                return;
            }

            this.logger("Could not create file: " + path);
        }

        //Get Files In Directory:
        private void getFilesInDirectoryPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = this.getArgs();
            string[] files = fileLib.getFiles(path);

            if (files == null)
            {
                this.logger("Could not get files in: " + path);
                return;
            }

            int i;
            for (i = 0; i < files.Length; i++)
            {
                this.logger(files[i]);
            }
        }

        //Get Directories In Directory:
        private void getDirectoriesInDirectoryPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = this.getArgs();
            string[] dirs = fileLib.getDirs(path);

            if (dirs == null)
            {
                this.logger("Could not get directories in: " + path);
                return;
            }
        
            int i;
            for (i = 0; i < dirs.Length; i++)
            {
                this.logger(dirs[i]);
            }
        }

        //Peek File:
        private void peekFilePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = this.getArgs();
            string contents = fileLib.getFileContents(path);

            if (contents == null)
            {
                this.logger("Could not get contents of: " + path);
                return;
            }

            this.logger(contents);
        }

        //Get File Length:

        private void getFileLengthPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = this.getArgs();
            string contents = fileLib.getFileContents(path);

            try
            {
                int length = contents.Length;
                this.logger(length.ToString());
                return;
            }
            catch
            {
                this.logger("Could not get length of: " + path);
                return;
            }
        }

        //Check Path:
        private void checkPathPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = this.getArgs();

            if (fileLib.fileExists(path))
            {
                this.logger("File exists: " + path);
                return;
            }
            if (fileLib.dirExists(path))
            {
                this.logger("Directory exists: " + path);
                return;
            }

            this.logger("Path is invalid: " + path);
        }

        //Launch Path:
        private void launchPathPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = this.getArgs();

            if (fileLib.fileExists(path) || fileLib.dirExists(path))
            {
                lnc.launchPath(path);
                return;
            }

            this.logger("Invalid path: " + path);
        }

        //Display Popup:
        private void displayPopupTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = this.getArgs();
            this.WindowState = FormWindowState.Minimized;
            MessageBox.Show(text);
            this.WindowState = FormWindowState.Normal;
        }

        //Show Users:
        private void showUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string driveLetter = Path.GetPathRoot(Directory.GetCurrentDirectory());
            string[] users = fileLib.getDirs(driveLetter + "Users");
            int i;

            for (i = 0; i < users.Length; i++)
            {
                this.logger(users[i]);
            }
        }

        //Show Logical Drives:
        private void showLogicalDrivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] drives = Directory.GetLogicalDrives();
            int i;

            for (i = 0; i < drives.Length; i++)
            {
                this.logger(drives[i]);
            }
        }

        //Open Command Prompt:
        private void openCommandPromptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string driveLetter = Path.GetPathRoot(Directory.GetCurrentDirectory());
            string cmdPath = driveLetter + "Windows\\System32\\cmd.exe";
            lnc.launchPath(cmdPath);
        }

        //Show Current User Items:
        private void showCurrentUserItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string user = os.getUser();
            string currentDrive = os.getCurrentDrive();
            string path = currentDrive + "Users\\" + user;
            string[] files = fileLib.getFiles(path);
            string[] dirs = fileLib.getDirs(path);
            int f;
            int d;

            //Display Files:
            for (f = 0; f < files.Length; f++)
            {
                this.logger(files[f]);
            }

            //Display Directories:
            for (d = 0; d < dirs.Length; d++)
            {
                this.logger(dirs[d]);
            }
        }

        //Open Task Manager:
        private void openTaskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            os.openTaskManager();
        }

        //Kill Process:
        private void killProcessNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = this.getArgs();
            os.killProcess(name);
            this.logger("Attempted to kill process: " + name);
        }

        //Get URL Source:
        private void getURLSourceURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string URL = this.getArgs();

            if (c.URLExists(URL))
            {
                string src = c.getURLSource(URL);
                this.logger(src);
                return;
            }

            this.logger("Invalid URL: " + URL);
        }

        //Check Site:
        private void checkSiteURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string URL = this.getArgs();
            
            if (c.URLExists(URL))
            {
                this.logger("Valid URL: " + URL);
                return;
            }

            this.logger("Invalid URL: " + URL);
        }

        //Resolve IP:
        private void resolveIPHostnameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string hostname = this.getArgs();
            string IP = c.resolveIP(hostname);

            if (IP.Length > 0)
            {
                this.logger(IP);
                return;
            }

            this.logger("Could not get IP of hostname: " + hostname);
        }

        //CMD Bypass:
        private void cMDBypassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string drive = os.getCurrentDrive();
            string user = os.getUser();
            string desktop = drive + "Users\\" + user + "\\Desktop";
            string fullPath = desktop + "\\cmdbypass.cmd";

            xploit.createCMDBypass();
            lnc.launchPath(fullPath);
        }

        //Remote Shutdown:
        private void remoteShutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string drive = os.getCurrentDrive();
            string user = os.getUser();
            string desktop = drive + "Users\\" + user + "\\Desktop";
            string fullPath = desktop + "\\shutdown.cmd";

            xploit.remoteShutdown();
            lnc.launchPath(fullPath);
        }

        //Clear Log:
        private void clearLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            output.Text = "";
        }

        //Log Text:
        private void logTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = this.getArgs();
            this.logger(text);
        }
    }
}