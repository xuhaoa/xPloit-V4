namespace xPloit_V4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabGUI = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFilePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getFilesInDirectoryPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDirectoriesInDirectoryPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peekFilePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getFileLengthPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPathPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchPathPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayPopupTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLogicalDrivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCommandPromptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCurrentUserItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTaskManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killProcessNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getURLSourceURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkSiteURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resolveIPHostnameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exploitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMDBypassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteShutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.args = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.miscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabGUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGUI
            // 
            this.tabGUI.BackColor = System.Drawing.SystemColors.Control;
            this.tabGUI.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tabGUI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.oSToolStripMenuItem,
            this.networkToolStripMenuItem,
            this.exploitToolStripMenuItem,
            this.miscToolStripMenuItem});
            this.tabGUI.Location = new System.Drawing.Point(0, 0);
            this.tabGUI.Name = "tabGUI";
            this.tabGUI.Size = new System.Drawing.Size(1167, 52);
            this.tabGUI.TabIndex = 0;
            this.tabGUI.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFilePathToolStripMenuItem,
            this.getFilesInDirectoryPathToolStripMenuItem,
            this.getDirectoriesInDirectoryPathToolStripMenuItem,
            this.peekFilePathToolStripMenuItem,
            this.getFileLengthPathToolStripMenuItem,
            this.checkPathPathToolStripMenuItem,
            this.launchPathPathToolStripMenuItem});
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(178, 48);
            this.fToolStripMenuItem.Text = "File System";
            // 
            // createFilePathToolStripMenuItem
            // 
            this.createFilePathToolStripMenuItem.Name = "createFilePathToolStripMenuItem";
            this.createFilePathToolStripMenuItem.Size = new System.Drawing.Size(575, 46);
            this.createFilePathToolStripMenuItem.Text = "Create File (Path)";
            this.createFilePathToolStripMenuItem.Click += new System.EventHandler(this.createFilePathToolStripMenuItem_Click);
            // 
            // getFilesInDirectoryPathToolStripMenuItem
            // 
            this.getFilesInDirectoryPathToolStripMenuItem.Name = "getFilesInDirectoryPathToolStripMenuItem";
            this.getFilesInDirectoryPathToolStripMenuItem.Size = new System.Drawing.Size(575, 46);
            this.getFilesInDirectoryPathToolStripMenuItem.Text = "Get Files In Directory (Path)";
            this.getFilesInDirectoryPathToolStripMenuItem.Click += new System.EventHandler(this.getFilesInDirectoryPathToolStripMenuItem_Click);
            // 
            // getDirectoriesInDirectoryPathToolStripMenuItem
            // 
            this.getDirectoriesInDirectoryPathToolStripMenuItem.Name = "getDirectoriesInDirectoryPathToolStripMenuItem";
            this.getDirectoriesInDirectoryPathToolStripMenuItem.Size = new System.Drawing.Size(575, 46);
            this.getDirectoriesInDirectoryPathToolStripMenuItem.Text = "Get Directories In Directory (Path)";
            this.getDirectoriesInDirectoryPathToolStripMenuItem.Click += new System.EventHandler(this.getDirectoriesInDirectoryPathToolStripMenuItem_Click);
            // 
            // peekFilePathToolStripMenuItem
            // 
            this.peekFilePathToolStripMenuItem.Name = "peekFilePathToolStripMenuItem";
            this.peekFilePathToolStripMenuItem.Size = new System.Drawing.Size(575, 46);
            this.peekFilePathToolStripMenuItem.Text = "Peek File (Path)";
            this.peekFilePathToolStripMenuItem.Click += new System.EventHandler(this.peekFilePathToolStripMenuItem_Click);
            // 
            // getFileLengthPathToolStripMenuItem
            // 
            this.getFileLengthPathToolStripMenuItem.Name = "getFileLengthPathToolStripMenuItem";
            this.getFileLengthPathToolStripMenuItem.Size = new System.Drawing.Size(575, 46);
            this.getFileLengthPathToolStripMenuItem.Text = "Get File Length (Path)";
            this.getFileLengthPathToolStripMenuItem.Click += new System.EventHandler(this.getFileLengthPathToolStripMenuItem_Click);
            // 
            // checkPathPathToolStripMenuItem
            // 
            this.checkPathPathToolStripMenuItem.Name = "checkPathPathToolStripMenuItem";
            this.checkPathPathToolStripMenuItem.Size = new System.Drawing.Size(575, 46);
            this.checkPathPathToolStripMenuItem.Text = "Check Path (Path)";
            this.checkPathPathToolStripMenuItem.Click += new System.EventHandler(this.checkPathPathToolStripMenuItem_Click);
            // 
            // launchPathPathToolStripMenuItem
            // 
            this.launchPathPathToolStripMenuItem.Name = "launchPathPathToolStripMenuItem";
            this.launchPathPathToolStripMenuItem.Size = new System.Drawing.Size(575, 46);
            this.launchPathPathToolStripMenuItem.Text = "Launch Path (Path)";
            this.launchPathPathToolStripMenuItem.Click += new System.EventHandler(this.launchPathPathToolStripMenuItem_Click);
            // 
            // oSToolStripMenuItem
            // 
            this.oSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayPopupTextToolStripMenuItem,
            this.showUsersToolStripMenuItem,
            this.showLogicalDrivesToolStripMenuItem,
            this.openCommandPromptToolStripMenuItem,
            this.showCurrentUserItemsToolStripMenuItem,
            this.openTaskManagerToolStripMenuItem,
            this.killProcessNameToolStripMenuItem});
            this.oSToolStripMenuItem.Name = "oSToolStripMenuItem";
            this.oSToolStripMenuItem.Size = new System.Drawing.Size(69, 48);
            this.oSToolStripMenuItem.Text = "OS";
            // 
            // displayPopupTextToolStripMenuItem
            // 
            this.displayPopupTextToolStripMenuItem.Name = "displayPopupTextToolStripMenuItem";
            this.displayPopupTextToolStripMenuItem.Size = new System.Drawing.Size(461, 46);
            this.displayPopupTextToolStripMenuItem.Text = "Display Popup (Text)";
            this.displayPopupTextToolStripMenuItem.Click += new System.EventHandler(this.displayPopupTextToolStripMenuItem_Click);
            // 
            // showUsersToolStripMenuItem
            // 
            this.showUsersToolStripMenuItem.Name = "showUsersToolStripMenuItem";
            this.showUsersToolStripMenuItem.Size = new System.Drawing.Size(461, 46);
            this.showUsersToolStripMenuItem.Text = "Show Users";
            this.showUsersToolStripMenuItem.Click += new System.EventHandler(this.showUsersToolStripMenuItem_Click);
            // 
            // showLogicalDrivesToolStripMenuItem
            // 
            this.showLogicalDrivesToolStripMenuItem.Name = "showLogicalDrivesToolStripMenuItem";
            this.showLogicalDrivesToolStripMenuItem.Size = new System.Drawing.Size(461, 46);
            this.showLogicalDrivesToolStripMenuItem.Text = "Show Logical Drives";
            this.showLogicalDrivesToolStripMenuItem.Click += new System.EventHandler(this.showLogicalDrivesToolStripMenuItem_Click);
            // 
            // openCommandPromptToolStripMenuItem
            // 
            this.openCommandPromptToolStripMenuItem.Name = "openCommandPromptToolStripMenuItem";
            this.openCommandPromptToolStripMenuItem.Size = new System.Drawing.Size(461, 46);
            this.openCommandPromptToolStripMenuItem.Text = "Open Command Prompt";
            this.openCommandPromptToolStripMenuItem.Click += new System.EventHandler(this.openCommandPromptToolStripMenuItem_Click);
            // 
            // showCurrentUserItemsToolStripMenuItem
            // 
            this.showCurrentUserItemsToolStripMenuItem.Name = "showCurrentUserItemsToolStripMenuItem";
            this.showCurrentUserItemsToolStripMenuItem.Size = new System.Drawing.Size(461, 46);
            this.showCurrentUserItemsToolStripMenuItem.Text = "Show Current User Items";
            this.showCurrentUserItemsToolStripMenuItem.Click += new System.EventHandler(this.showCurrentUserItemsToolStripMenuItem_Click);
            // 
            // openTaskManagerToolStripMenuItem
            // 
            this.openTaskManagerToolStripMenuItem.Name = "openTaskManagerToolStripMenuItem";
            this.openTaskManagerToolStripMenuItem.Size = new System.Drawing.Size(461, 46);
            this.openTaskManagerToolStripMenuItem.Text = "Open Task Manager";
            this.openTaskManagerToolStripMenuItem.Click += new System.EventHandler(this.openTaskManagerToolStripMenuItem_Click);
            // 
            // killProcessNameToolStripMenuItem
            // 
            this.killProcessNameToolStripMenuItem.Name = "killProcessNameToolStripMenuItem";
            this.killProcessNameToolStripMenuItem.Size = new System.Drawing.Size(461, 46);
            this.killProcessNameToolStripMenuItem.Text = "Kill Process (Name)";
            this.killProcessNameToolStripMenuItem.Click += new System.EventHandler(this.killProcessNameToolStripMenuItem_Click);
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getURLSourceURLToolStripMenuItem,
            this.checkSiteURLToolStripMenuItem,
            this.resolveIPHostnameToolStripMenuItem});
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(143, 48);
            this.networkToolStripMenuItem.Text = "Network";
            // 
            // getURLSourceURLToolStripMenuItem
            // 
            this.getURLSourceURLToolStripMenuItem.Name = "getURLSourceURLToolStripMenuItem";
            this.getURLSourceURLToolStripMenuItem.Size = new System.Drawing.Size(428, 46);
            this.getURLSourceURLToolStripMenuItem.Text = "Get URL Source (URL)";
            this.getURLSourceURLToolStripMenuItem.Click += new System.EventHandler(this.getURLSourceURLToolStripMenuItem_Click);
            // 
            // checkSiteURLToolStripMenuItem
            // 
            this.checkSiteURLToolStripMenuItem.Name = "checkSiteURLToolStripMenuItem";
            this.checkSiteURLToolStripMenuItem.Size = new System.Drawing.Size(428, 46);
            this.checkSiteURLToolStripMenuItem.Text = "Check Site (URL)";
            this.checkSiteURLToolStripMenuItem.Click += new System.EventHandler(this.checkSiteURLToolStripMenuItem_Click);
            // 
            // resolveIPHostnameToolStripMenuItem
            // 
            this.resolveIPHostnameToolStripMenuItem.Name = "resolveIPHostnameToolStripMenuItem";
            this.resolveIPHostnameToolStripMenuItem.Size = new System.Drawing.Size(428, 46);
            this.resolveIPHostnameToolStripMenuItem.Text = "Resolve IP (Hostname)";
            this.resolveIPHostnameToolStripMenuItem.Click += new System.EventHandler(this.resolveIPHostnameToolStripMenuItem_Click);
            // 
            // exploitToolStripMenuItem
            // 
            this.exploitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMDBypassToolStripMenuItem,
            this.remoteShutdownToolStripMenuItem});
            this.exploitToolStripMenuItem.Name = "exploitToolStripMenuItem";
            this.exploitToolStripMenuItem.Size = new System.Drawing.Size(119, 48);
            this.exploitToolStripMenuItem.Text = "Exploit";
            // 
            // cMDBypassToolStripMenuItem
            // 
            this.cMDBypassToolStripMenuItem.Name = "cMDBypassToolStripMenuItem";
            this.cMDBypassToolStripMenuItem.Size = new System.Drawing.Size(378, 46);
            this.cMDBypassToolStripMenuItem.Text = "CMD Bypass";
            this.cMDBypassToolStripMenuItem.Click += new System.EventHandler(this.cMDBypassToolStripMenuItem_Click);
            // 
            // remoteShutdownToolStripMenuItem
            // 
            this.remoteShutdownToolStripMenuItem.Name = "remoteShutdownToolStripMenuItem";
            this.remoteShutdownToolStripMenuItem.Size = new System.Drawing.Size(378, 46);
            this.remoteShutdownToolStripMenuItem.Text = "Remote Shutdown";
            this.remoteShutdownToolStripMenuItem.Click += new System.EventHandler(this.remoteShutdownToolStripMenuItem_Click);
            // 
            // args
            // 
            this.args.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.args.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.args.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.args.ForeColor = System.Drawing.Color.White;
            this.args.Location = new System.Drawing.Point(12, 71);
            this.args.Name = "args";
            this.args.Size = new System.Drawing.Size(1142, 41);
            this.args.TabIndex = 1;
            this.args.Text = "Arguments:";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.White;
            this.output.Location = new System.Drawing.Point(12, 126);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(1142, 264);
            this.output.TabIndex = 2;
            this.output.Text = "";
            // 
            // miscToolStripMenuItem
            // 
            this.miscToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogToolStripMenuItem,
            this.logTextToolStripMenuItem});
            this.miscToolStripMenuItem.Name = "miscToolStripMenuItem";
            this.miscToolStripMenuItem.Size = new System.Drawing.Size(91, 48);
            this.miscToolStripMenuItem.Text = "Misc";
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.clearLogToolStripMenuItem.Text = "Clear Log";
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // logTextToolStripMenuItem
            // 
            this.logTextToolStripMenuItem.Name = "logTextToolStripMenuItem";
            this.logTextToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.logTextToolStripMenuItem.Text = "Log Text";
            this.logTextToolStripMenuItem.Click += new System.EventHandler(this.logTextToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1167, 403);
            this.Controls.Add(this.output);
            this.Controls.Add(this.args);
            this.Controls.Add(this.tabGUI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.tabGUI;
            this.Name = "Form1";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xPloit V4";
            this.tabGUI.ResumeLayout(false);
            this.tabGUI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip tabGUI;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.TextBox args;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.ToolStripMenuItem createFilePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getFilesInDirectoryPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDirectoriesInDirectoryPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peekFilePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getFileLengthPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPathPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchPathPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayPopupTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLogicalDrivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCommandPromptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCurrentUserItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTaskManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killProcessNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getURLSourceURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkSiteURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resolveIPHostnameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exploitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cMDBypassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteShutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logTextToolStripMenuItem;
    }
}

