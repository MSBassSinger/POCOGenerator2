namespace POCO_Generator
{
    partial class frmSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.pnlData = new System.Windows.Forms.Panel();
            this.txtConfigFilePath = new System.Windows.Forms.TextBox();
            this.lblConfigFilePath = new System.Windows.Forms.Label();
            this.grpDebugLogOptions = new System.Windows.Forms.GroupBox();
            this.chkDebugLogOptions = new System.Windows.Forms.CheckedListBox();
            this.txtLastDBServer = new System.Windows.Forms.TextBox();
            this.lblLastDBServer = new System.Windows.Forms.Label();
            this.txtDefaultDB = new System.Windows.Forms.TextBox();
            this.lblDefaultDB = new System.Windows.Forms.Label();
            this.txtDBPortNumber = new System.Windows.Forms.TextBox();
            this.lblDBPortNumber = new System.Windows.Forms.Label();
            this.chkConnectionPooling = new System.Windows.Forms.CheckBox();
            this.grpLogon = new System.Windows.Forms.GroupBox();
            this.txtDBPassword = new System.Windows.Forms.TextBox();
            this.lblDBUserPassword = new System.Windows.Forms.Label();
            this.txtDBUserName = new System.Windows.Forms.TextBox();
            this.lblDBUserNme = new System.Windows.Forms.Label();
            this.chkUseWindowsAuthentication = new System.Windows.Forms.CheckBox();
            this.txtDBApplicationName = new System.Windows.Forms.TextBox();
            this.lblDBApplicationName = new System.Windows.Forms.Label();
            this.txtCommandTimeout = new System.Windows.Forms.TextBox();
            this.lblCommandTimeout = new System.Windows.Forms.Label();
            this.txtConnectionRetryInterval = new System.Windows.Forms.TextBox();
            this.lblConnectionRetryInterval = new System.Windows.Forms.Label();
            this.txtConnectionRetryCount = new System.Windows.Forms.TextBox();
            this.lblConnectionRetryCount = new System.Windows.Forms.Label();
            this.txtConnectionTimeout = new System.Windows.Forms.TextBox();
            this.lblConnectionTimeout = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUndoChanges = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpSettings = new System.Windows.Forms.ToolTip(this.components);
            this.pnlData.SuspendLayout();
            this.grpDebugLogOptions.SuspendLayout();
            this.grpLogon.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.txtConfigFilePath);
            this.pnlData.Controls.Add(this.lblConfigFilePath);
            this.pnlData.Controls.Add(this.grpDebugLogOptions);
            this.pnlData.Controls.Add(this.txtLastDBServer);
            this.pnlData.Controls.Add(this.lblLastDBServer);
            this.pnlData.Controls.Add(this.txtDefaultDB);
            this.pnlData.Controls.Add(this.lblDefaultDB);
            this.pnlData.Controls.Add(this.txtDBPortNumber);
            this.pnlData.Controls.Add(this.lblDBPortNumber);
            this.pnlData.Controls.Add(this.chkConnectionPooling);
            this.pnlData.Controls.Add(this.grpLogon);
            this.pnlData.Controls.Add(this.chkUseWindowsAuthentication);
            this.pnlData.Controls.Add(this.txtDBApplicationName);
            this.pnlData.Controls.Add(this.lblDBApplicationName);
            this.pnlData.Controls.Add(this.txtCommandTimeout);
            this.pnlData.Controls.Add(this.lblCommandTimeout);
            this.pnlData.Controls.Add(this.txtConnectionRetryInterval);
            this.pnlData.Controls.Add(this.lblConnectionRetryInterval);
            this.pnlData.Controls.Add(this.txtConnectionRetryCount);
            this.pnlData.Controls.Add(this.lblConnectionRetryCount);
            this.pnlData.Controls.Add(this.txtConnectionTimeout);
            this.pnlData.Controls.Add(this.lblConnectionTimeout);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(779, 512);
            this.pnlData.TabIndex = 0;
            // 
            // txtConfigFilePath
            // 
            this.txtConfigFilePath.BackColor = System.Drawing.Color.SeaShell;
            this.txtConfigFilePath.Location = new System.Drawing.Point(12, 426);
            this.txtConfigFilePath.Name = "txtConfigFilePath";
            this.txtConfigFilePath.ReadOnly = true;
            this.txtConfigFilePath.Size = new System.Drawing.Size(754, 21);
            this.txtConfigFilePath.TabIndex = 23;
            this.tlpSettings.SetToolTip(this.txtConfigFilePath, "The path and file name where the settings are kept.");
            // 
            // lblConfigFilePath
            // 
            this.lblConfigFilePath.AutoSize = true;
            this.lblConfigFilePath.Location = new System.Drawing.Point(7, 408);
            this.lblConfigFilePath.Name = "lblConfigFilePath";
            this.lblConfigFilePath.Size = new System.Drawing.Size(110, 13);
            this.lblConfigFilePath.TabIndex = 22;
            this.lblConfigFilePath.Text = "Config file located at:";
            // 
            // grpDebugLogOptions
            // 
            this.grpDebugLogOptions.Controls.Add(this.chkDebugLogOptions);
            this.grpDebugLogOptions.Location = new System.Drawing.Point(371, 12);
            this.grpDebugLogOptions.Name = "grpDebugLogOptions";
            this.grpDebugLogOptions.Size = new System.Drawing.Size(363, 377);
            this.grpDebugLogOptions.TabIndex = 21;
            this.grpDebugLogOptions.TabStop = false;
            this.grpDebugLogOptions.Text = "Debug Log Options";
            // 
            // chkDebugLogOptions
            // 
            this.chkDebugLogOptions.FormattingEnabled = true;
            this.chkDebugLogOptions.Location = new System.Drawing.Point(18, 31);
            this.chkDebugLogOptions.Name = "chkDebugLogOptions";
            this.chkDebugLogOptions.Size = new System.Drawing.Size(328, 324);
            this.chkDebugLogOptions.TabIndex = 0;
            this.tlpSettings.SetToolTip(this.chkDebugLogOptions, "Debug log option flags.  Check those to use, and uncheck those not wanted.");
            // 
            // txtLastDBServer
            // 
            this.txtLastDBServer.Location = new System.Drawing.Point(185, 369);
            this.txtLastDBServer.Name = "txtLastDBServer";
            this.txtLastDBServer.Size = new System.Drawing.Size(178, 21);
            this.txtLastDBServer.TabIndex = 20;
            this.tlpSettings.SetToolTip(this.txtLastDBServer, "This is the SQL Server instance name to be shown at startup.");
            // 
            // lblLastDBServer
            // 
            this.lblLastDBServer.AutoSize = true;
            this.lblLastDBServer.Location = new System.Drawing.Point(12, 372);
            this.lblLastDBServer.Name = "lblLastDBServer";
            this.lblLastDBServer.Size = new System.Drawing.Size(105, 13);
            this.lblLastDBServer.TabIndex = 19;
            this.lblLastDBServer.Text = "Last DB Server Used";
            // 
            // txtDefaultDB
            // 
            this.txtDefaultDB.Location = new System.Drawing.Point(185, 342);
            this.txtDefaultDB.Name = "txtDefaultDB";
            this.txtDefaultDB.Size = new System.Drawing.Size(178, 21);
            this.txtDefaultDB.TabIndex = 18;
            this.tlpSettings.SetToolTip(this.txtDefaultDB, "The default database to use when querying a server.  Typically, this is \'master\'." +
        "");
            // 
            // lblDefaultDB
            // 
            this.lblDefaultDB.AutoSize = true;
            this.lblDefaultDB.Location = new System.Drawing.Point(12, 345);
            this.lblDefaultDB.Name = "lblDefaultDB";
            this.lblDefaultDB.Size = new System.Drawing.Size(58, 13);
            this.lblDefaultDB.TabIndex = 17;
            this.lblDefaultDB.Text = "Default DB";
            // 
            // txtDBPortNumber
            // 
            this.txtDBPortNumber.Location = new System.Drawing.Point(185, 127);
            this.txtDBPortNumber.Name = "txtDBPortNumber";
            this.txtDBPortNumber.Size = new System.Drawing.Size(84, 21);
            this.txtDBPortNumber.TabIndex = 16;
            this.tlpSettings.SetToolTip(this.txtDBPortNumber, "The port number the SQL Server listens on.  Typically 1433.");
            this.txtDBPortNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDBPortNumber_KeyPress);
            // 
            // lblDBPortNumber
            // 
            this.lblDBPortNumber.AutoSize = true;
            this.lblDBPortNumber.Location = new System.Drawing.Point(10, 130);
            this.lblDBPortNumber.Name = "lblDBPortNumber";
            this.lblDBPortNumber.Size = new System.Drawing.Size(124, 13);
            this.lblDBPortNumber.TabIndex = 15;
            this.lblDBPortNumber.Text = "SQL Server Port Number";
            // 
            // chkConnectionPooling
            // 
            this.chkConnectionPooling.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkConnectionPooling.Checked = true;
            this.chkConnectionPooling.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConnectionPooling.Location = new System.Drawing.Point(10, 96);
            this.chkConnectionPooling.Name = "chkConnectionPooling";
            this.chkConnectionPooling.Size = new System.Drawing.Size(355, 22);
            this.chkConnectionPooling.TabIndex = 14;
            this.chkConnectionPooling.Text = "Use Connection Pooling?";
            this.tlpSettings.SetToolTip(this.chkConnectionPooling, "Click to use connection pooling to improve performance.");
            this.chkConnectionPooling.UseVisualStyleBackColor = true;
            // 
            // grpLogon
            // 
            this.grpLogon.Controls.Add(this.txtDBPassword);
            this.grpLogon.Controls.Add(this.lblDBUserPassword);
            this.grpLogon.Controls.Add(this.txtDBUserName);
            this.grpLogon.Controls.Add(this.lblDBUserNme);
            this.grpLogon.Enabled = false;
            this.grpLogon.Location = new System.Drawing.Point(10, 238);
            this.grpLogon.Name = "grpLogon";
            this.grpLogon.Size = new System.Drawing.Size(355, 98);
            this.grpLogon.TabIndex = 13;
            this.grpLogon.TabStop = false;
            this.grpLogon.Text = "SQL Server Authentication";
            // 
            // txtDBPassword
            // 
            this.txtDBPassword.Location = new System.Drawing.Point(84, 54);
            this.txtDBPassword.Name = "txtDBPassword";
            this.txtDBPassword.Size = new System.Drawing.Size(178, 21);
            this.txtDBPassword.TabIndex = 15;
            this.tlpSettings.SetToolTip(this.txtDBPassword, resources.GetString("txtDBPassword.ToolTip"));
            // 
            // lblDBUserPassword
            // 
            this.lblDBUserPassword.AutoSize = true;
            this.lblDBUserPassword.Location = new System.Drawing.Point(3, 58);
            this.lblDBUserPassword.Name = "lblDBUserPassword";
            this.lblDBUserPassword.Size = new System.Drawing.Size(69, 13);
            this.lblDBUserPassword.TabIndex = 14;
            this.lblDBUserPassword.Text = "DB Password";
            // 
            // txtDBUserName
            // 
            this.txtDBUserName.Location = new System.Drawing.Point(84, 27);
            this.txtDBUserName.Name = "txtDBUserName";
            this.txtDBUserName.Size = new System.Drawing.Size(178, 21);
            this.txtDBUserName.TabIndex = 13;
            this.tlpSettings.SetToolTip(this.txtDBUserName, "SQL Server logon name used for SQL Server Authentication.  Not used for Windows A" +
        "uthentication.");
            // 
            // lblDBUserNme
            // 
            this.lblDBUserNme.AutoSize = true;
            this.lblDBUserNme.Location = new System.Drawing.Point(3, 31);
            this.lblDBUserNme.Name = "lblDBUserNme";
            this.lblDBUserNme.Size = new System.Drawing.Size(75, 13);
            this.lblDBUserNme.TabIndex = 12;
            this.lblDBUserNme.Text = "DB User Name";
            // 
            // chkUseWindowsAuthentication
            // 
            this.chkUseWindowsAuthentication.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkUseWindowsAuthentication.Checked = true;
            this.chkUseWindowsAuthentication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseWindowsAuthentication.Location = new System.Drawing.Point(10, 210);
            this.chkUseWindowsAuthentication.Name = "chkUseWindowsAuthentication";
            this.chkUseWindowsAuthentication.Size = new System.Drawing.Size(355, 22);
            this.chkUseWindowsAuthentication.TabIndex = 12;
            this.chkUseWindowsAuthentication.Text = "Use Windows Authentication?";
            this.tlpSettings.SetToolTip(this.chkUseWindowsAuthentication, "Check to use the user\'s Windows domain account to logon to SQL Server.\r\nUncheck t" +
        "o use SQL Server Authorization, entered below.");
            this.chkUseWindowsAuthentication.UseVisualStyleBackColor = true;
            this.chkUseWindowsAuthentication.CheckedChanged += new System.EventHandler(this.ChkUseWindowsAuthentication_CheckedChanged);
            // 
            // txtDBApplicationName
            // 
            this.txtDBApplicationName.Location = new System.Drawing.Point(185, 183);
            this.txtDBApplicationName.Name = "txtDBApplicationName";
            this.txtDBApplicationName.Size = new System.Drawing.Size(178, 21);
            this.txtDBApplicationName.TabIndex = 9;
            this.tlpSettings.SetToolTip(this.txtDBApplicationName, "Name given to the SQL Server when connecting, for this application.");
            // 
            // lblDBApplicationName
            // 
            this.lblDBApplicationName.AutoSize = true;
            this.lblDBApplicationName.Location = new System.Drawing.Point(10, 186);
            this.lblDBApplicationName.Name = "lblDBApplicationName";
            this.lblDBApplicationName.Size = new System.Drawing.Size(89, 13);
            this.lblDBApplicationName.TabIndex = 8;
            this.lblDBApplicationName.Text = "Application Name";
            // 
            // txtCommandTimeout
            // 
            this.txtCommandTimeout.Location = new System.Drawing.Point(185, 156);
            this.txtCommandTimeout.Name = "txtCommandTimeout";
            this.txtCommandTimeout.Size = new System.Drawing.Size(84, 21);
            this.txtCommandTimeout.TabIndex = 7;
            this.tlpSettings.SetToolTip(this.txtCommandTimeout, "The time, in milliseconds, to wait on a command reply before throwing an exceptio" +
        "n.");
            this.txtCommandTimeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCommandTimeout_KeyPress);
            // 
            // lblCommandTimeout
            // 
            this.lblCommandTimeout.AutoSize = true;
            this.lblCommandTimeout.Location = new System.Drawing.Point(10, 159);
            this.lblCommandTimeout.Name = "lblCommandTimeout";
            this.lblCommandTimeout.Size = new System.Drawing.Size(119, 13);
            this.lblCommandTimeout.TabIndex = 6;
            this.lblCommandTimeout.Text = "Command Timeout (ms)";
            // 
            // txtConnectionRetryInterval
            // 
            this.txtConnectionRetryInterval.Location = new System.Drawing.Point(185, 69);
            this.txtConnectionRetryInterval.Name = "txtConnectionRetryInterval";
            this.txtConnectionRetryInterval.Size = new System.Drawing.Size(84, 21);
            this.txtConnectionRetryInterval.TabIndex = 5;
            this.tlpSettings.SetToolTip(this.txtConnectionRetryInterval, "How long, in milliseconds, to wait after a connection failure, to retry connectin" +
        "g.");
            this.txtConnectionRetryInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConnectionRetryInterval_KeyPress);
            // 
            // lblConnectionRetryInterval
            // 
            this.lblConnectionRetryInterval.AutoSize = true;
            this.lblConnectionRetryInterval.Location = new System.Drawing.Point(10, 72);
            this.lblConnectionRetryInterval.Name = "lblConnectionRetryInterval";
            this.lblConnectionRetryInterval.Size = new System.Drawing.Size(156, 13);
            this.lblConnectionRetryInterval.TabIndex = 4;
            this.lblConnectionRetryInterval.Text = "Connection Retry Interval (ms)";
            // 
            // txtConnectionRetryCount
            // 
            this.txtConnectionRetryCount.Location = new System.Drawing.Point(185, 40);
            this.txtConnectionRetryCount.Name = "txtConnectionRetryCount";
            this.txtConnectionRetryCount.Size = new System.Drawing.Size(84, 21);
            this.txtConnectionRetryCount.TabIndex = 3;
            this.tlpSettings.SetToolTip(this.txtConnectionRetryCount, "How many times to retry when a  SQL connection fails.");
            this.txtConnectionRetryCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConnectionRetryCount_KeyPress);
            // 
            // lblConnectionRetryCount
            // 
            this.lblConnectionRetryCount.AutoSize = true;
            this.lblConnectionRetryCount.Location = new System.Drawing.Point(10, 43);
            this.lblConnectionRetryCount.Name = "lblConnectionRetryCount";
            this.lblConnectionRetryCount.Size = new System.Drawing.Size(123, 13);
            this.lblConnectionRetryCount.TabIndex = 2;
            this.lblConnectionRetryCount.Text = "Connection Retry Count";
            // 
            // txtConnectionTimeout
            // 
            this.txtConnectionTimeout.Location = new System.Drawing.Point(185, 13);
            this.txtConnectionTimeout.Name = "txtConnectionTimeout";
            this.txtConnectionTimeout.Size = new System.Drawing.Size(84, 21);
            this.txtConnectionTimeout.TabIndex = 1;
            this.tlpSettings.SetToolTip(this.txtConnectionTimeout, "Timeout for the SQL Server connection, in milliseconds.");
            this.txtConnectionTimeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConnectionTimeout_KeyPress);
            // 
            // lblConnectionTimeout
            // 
            this.lblConnectionTimeout.AutoSize = true;
            this.lblConnectionTimeout.Location = new System.Drawing.Point(10, 16);
            this.lblConnectionTimeout.Name = "lblConnectionTimeout";
            this.lblConnectionTimeout.Size = new System.Drawing.Size(126, 13);
            this.lblConnectionTimeout.TabIndex = 0;
            this.lblConnectionTimeout.Text = "Connection Timeout (ms)";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnExit);
            this.pnlButtons.Controls.Add(this.btnUndoChanges);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 456);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(779, 56);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(264, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.tlpSettings.SetToolTip(this.btnExit, "Exits this form without saving.");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnUndoChanges
            // 
            this.btnUndoChanges.Location = new System.Drawing.Point(153, 13);
            this.btnUndoChanges.Name = "btnUndoChanges";
            this.btnUndoChanges.Size = new System.Drawing.Size(100, 31);
            this.btnUndoChanges.TabIndex = 1;
            this.btnUndoChanges.Text = "&Undo Changes";
            this.tlpSettings.SetToolTip(this.btnUndoChanges, "Restores the changes to the current values.");
            this.btnUndoChanges.UseVisualStyleBackColor = true;
            this.btnUndoChanges.Click += new System.EventHandler(this.BtnUndoChanges_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(42, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.tlpSettings.SetToolTip(this.btnSave, "Saves the changes to the config file, but does not exit.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 512);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlData);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSettings_FormClosing);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.grpDebugLogOptions.ResumeLayout(false);
            this.grpLogon.ResumeLayout(false);
            this.grpLogon.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUndoChanges;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtConnectionTimeout;
        private System.Windows.Forms.Label lblConnectionTimeout;
        private System.Windows.Forms.TextBox txtConnectionRetryCount;
        private System.Windows.Forms.Label lblConnectionRetryCount;
        private System.Windows.Forms.TextBox txtConnectionRetryInterval;
        private System.Windows.Forms.Label lblConnectionRetryInterval;
        private System.Windows.Forms.TextBox txtCommandTimeout;
        private System.Windows.Forms.Label lblCommandTimeout;
        private System.Windows.Forms.TextBox txtDBApplicationName;
        private System.Windows.Forms.Label lblDBApplicationName;
        private System.Windows.Forms.CheckBox chkUseWindowsAuthentication;
        private System.Windows.Forms.GroupBox grpLogon;
        private System.Windows.Forms.TextBox txtDBUserName;
        private System.Windows.Forms.Label lblDBUserNme;
        private System.Windows.Forms.TextBox txtDBPassword;
        private System.Windows.Forms.Label lblDBUserPassword;
        private System.Windows.Forms.CheckBox chkConnectionPooling;
        private System.Windows.Forms.TextBox txtDBPortNumber;
        private System.Windows.Forms.Label lblDBPortNumber;
        private System.Windows.Forms.TextBox txtDefaultDB;
        private System.Windows.Forms.Label lblDefaultDB;
        private System.Windows.Forms.TextBox txtLastDBServer;
        private System.Windows.Forms.Label lblLastDBServer;
        private System.Windows.Forms.GroupBox grpDebugLogOptions;
        private System.Windows.Forms.CheckedListBox chkDebugLogOptions;
        private System.Windows.Forms.Label lblConfigFilePath;
        private System.Windows.Forms.TextBox txtConfigFilePath;
        private System.Windows.Forms.ToolTip tlpSettings;
    }
}