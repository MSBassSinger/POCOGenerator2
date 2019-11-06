namespace POCO_Generator
{
    partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.fIleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splMain = new System.Windows.Forms.SplitContainer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lstDatabases = new System.Windows.Forms.ListBox();
			this.lblDatabases = new System.Windows.Forms.Label();
			this.pnlServer = new System.Windows.Forms.Panel();
			this.btnGetDBs = new System.Windows.Forms.Button();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.lblServer = new System.Windows.Forms.Label();
			this.pnlTables = new System.Windows.Forms.Panel();
			this.lstTables = new System.Windows.Forms.ListBox();
			this.pnlTableButtons = new System.Windows.Forms.Panel();
			this.btnPathCRUD = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCRUDDestination = new System.Windows.Forms.TextBox();
			this.grpDDL = new System.Windows.Forms.GroupBox();
			this.chkIncludeAuditDDL = new System.Windows.Forms.CheckBox();
			this.btnCreateSPs = new System.Windows.Forms.Button();
			this.lblNamespace = new System.Windows.Forms.Label();
			this.txtNamespace = new System.Windows.Forms.TextBox();
			this.btnPathPOCO = new System.Windows.Forms.Button();
			this.lblDestination = new System.Windows.Forms.Label();
			this.txtPOCODestination = new System.Windows.Forms.TextBox();
			this.btnCreatePOCOs = new System.Windows.Forms.Button();
			this.lblTables = new System.Windows.Forms.Label();
			this.ttpMain = new System.Windows.Forms.ToolTip(this.components);
			this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.mnuMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
			this.splMain.Panel1.SuspendLayout();
			this.splMain.Panel2.SuspendLayout();
			this.splMain.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnlServer.SuspendLayout();
			this.pnlTables.SuspendLayout();
			this.pnlTableButtons.SuspendLayout();
			this.grpDDL.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuMain
			// 
			this.mnuMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem1});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size(1166, 24);
			this.mnuMain.TabIndex = 0;
			this.mnuMain.Text = "menuStrip1";
			// 
			// fIleToolStripMenuItem1
			// 
			this.fIleToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem1});
			this.fIleToolStripMenuItem1.Name = "fIleToolStripMenuItem1";
			this.fIleToolStripMenuItem1.Size = new System.Drawing.Size(36, 20);
			this.fIleToolStripMenuItem1.Text = "&File";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.settingsToolStripMenuItem.Text = "&Settings...";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.EditSettingsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem1
			// 
			this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			this.exitToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
			this.exitToolStripMenuItem1.Text = "E&xit";
			this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// editSettingsToolStripMenuItem
			// 
			this.editSettingsToolStripMenuItem.Name = "editSettingsToolStripMenuItem";
			this.editSettingsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.editSettingsToolStripMenuItem.Text = "Edit &Settings";
			this.editSettingsToolStripMenuItem.Click += new System.EventHandler(this.EditSettingsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// splMain
			// 
			this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splMain.Location = new System.Drawing.Point(0, 24);
			this.splMain.Name = "splMain";
			// 
			// splMain.Panel1
			// 
			this.splMain.Panel1.Controls.Add(this.panel1);
			this.splMain.Panel1.Controls.Add(this.pnlServer);
			// 
			// splMain.Panel2
			// 
			this.splMain.Panel2.Controls.Add(this.pnlTables);
			this.splMain.Panel2.Controls.Add(this.pnlTableButtons);
			this.splMain.Panel2.Controls.Add(this.lblTables);
			this.splMain.Size = new System.Drawing.Size(1166, 687);
			this.splMain.SplitterDistance = 562;
			this.splMain.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lstDatabases);
			this.panel1.Controls.Add(this.lblDatabases);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 73);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(562, 614);
			this.panel1.TabIndex = 1;
			// 
			// lstDatabases
			// 
			this.lstDatabases.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstDatabases.FormattingEnabled = true;
			this.lstDatabases.Location = new System.Drawing.Point(0, 18);
			this.lstDatabases.Name = "lstDatabases";
			this.lstDatabases.Size = new System.Drawing.Size(562, 596);
			this.lstDatabases.TabIndex = 1;
			this.ttpMain.SetToolTip(this.lstDatabases, "List of known databases.\r\nDouble-click on a database to see a list of known table" +
        "s.\r\n");
			this.lstDatabases.DoubleClick += new System.EventHandler(this.LstDatabases_DoubleClick);
			// 
			// lblDatabases
			// 
			this.lblDatabases.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDatabases.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDatabases.Location = new System.Drawing.Point(0, 0);
			this.lblDatabases.Name = "lblDatabases";
			this.lblDatabases.Size = new System.Drawing.Size(562, 18);
			this.lblDatabases.TabIndex = 0;
			this.lblDatabases.Text = "Databases";
			// 
			// pnlServer
			// 
			this.pnlServer.Controls.Add(this.btnGetDBs);
			this.pnlServer.Controls.Add(this.txtServer);
			this.pnlServer.Controls.Add(this.lblServer);
			this.pnlServer.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlServer.Location = new System.Drawing.Point(0, 0);
			this.pnlServer.Name = "pnlServer";
			this.pnlServer.Size = new System.Drawing.Size(562, 73);
			this.pnlServer.TabIndex = 0;
			// 
			// btnGetDBs
			// 
			this.btnGetDBs.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnGetDBs.Enabled = false;
			this.btnGetDBs.Location = new System.Drawing.Point(0, 38);
			this.btnGetDBs.Name = "btnGetDBs";
			this.btnGetDBs.Size = new System.Drawing.Size(562, 23);
			this.btnGetDBs.TabIndex = 2;
			this.btnGetDBs.Text = "Get &Databases";
			this.ttpMain.SetToolTip(this.btnGetDBs, "Once a SQL Server name or instance has been defined, click this button to get a l" +
        "ist of known databases.");
			this.btnGetDBs.UseVisualStyleBackColor = true;
			this.btnGetDBs.Click += new System.EventHandler(this.BtnGetDatabases_Click);
			// 
			// txtServer
			// 
			this.txtServer.Dock = System.Windows.Forms.DockStyle.Top;
			this.txtServer.Location = new System.Drawing.Point(0, 17);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(562, 21);
			this.txtServer.TabIndex = 1;
			this.ttpMain.SetToolTip(this.txtServer, resources.GetString("txtServer.ToolTip"));
			this.txtServer.TextChanged += new System.EventHandler(this.TxtServer_TextChanged);
			// 
			// lblServer
			// 
			this.lblServer.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblServer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblServer.Location = new System.Drawing.Point(0, 0);
			this.lblServer.Name = "lblServer";
			this.lblServer.Size = new System.Drawing.Size(562, 17);
			this.lblServer.TabIndex = 0;
			this.lblServer.Text = "SQL Server Instance";
			// 
			// pnlTables
			// 
			this.pnlTables.Controls.Add(this.lstTables);
			this.pnlTables.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlTables.Location = new System.Drawing.Point(0, 21);
			this.pnlTables.Name = "pnlTables";
			this.pnlTables.Size = new System.Drawing.Size(600, 504);
			this.pnlTables.TabIndex = 3;
			// 
			// lstTables
			// 
			this.lstTables.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstTables.FormattingEnabled = true;
			this.lstTables.Location = new System.Drawing.Point(0, 0);
			this.lstTables.Name = "lstTables";
			this.lstTables.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstTables.Size = new System.Drawing.Size(600, 504);
			this.lstTables.Sorted = true;
			this.lstTables.TabIndex = 0;
			this.ttpMain.SetToolTip(this.lstTables, "Table names from the selected database.");
			// 
			// pnlTableButtons
			// 
			this.pnlTableButtons.Controls.Add(this.btnPathCRUD);
			this.pnlTableButtons.Controls.Add(this.label1);
			this.pnlTableButtons.Controls.Add(this.txtCRUDDestination);
			this.pnlTableButtons.Controls.Add(this.grpDDL);
			this.pnlTableButtons.Controls.Add(this.lblNamespace);
			this.pnlTableButtons.Controls.Add(this.txtNamespace);
			this.pnlTableButtons.Controls.Add(this.btnPathPOCO);
			this.pnlTableButtons.Controls.Add(this.lblDestination);
			this.pnlTableButtons.Controls.Add(this.txtPOCODestination);
			this.pnlTableButtons.Controls.Add(this.btnCreatePOCOs);
			this.pnlTableButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlTableButtons.Location = new System.Drawing.Point(0, 525);
			this.pnlTableButtons.Name = "pnlTableButtons";
			this.pnlTableButtons.Size = new System.Drawing.Size(600, 162);
			this.pnlTableButtons.TabIndex = 2;
			// 
			// btnPathCRUD
			// 
			this.btnPathCRUD.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPathCRUD.Location = new System.Drawing.Point(545, 38);
			this.btnPathCRUD.Name = "btnPathCRUD";
			this.btnPathCRUD.Size = new System.Drawing.Size(43, 21);
			this.btnPathCRUD.TabIndex = 11;
			this.btnPathCRUD.Text = " . . . ";
			this.ttpMain.SetToolTip(this.btnPathCRUD, "Select Path Dialog");
			this.btnPathCRUD.UseVisualStyleBackColor = true;
			this.btnPathCRUD.Click += new System.EventHandler(this.btnPathCRUD_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "CRUD Destination";
			// 
			// txtCRUDDestination
			// 
			this.txtCRUDDestination.Location = new System.Drawing.Point(119, 38);
			this.txtCRUDDestination.Name = "txtCRUDDestination";
			this.txtCRUDDestination.Size = new System.Drawing.Size(408, 21);
			this.txtCRUDDestination.TabIndex = 9;
			this.ttpMain.SetToolTip(this.txtCRUDDestination, "Destination path");
			// 
			// grpDDL
			// 
			this.grpDDL.Controls.Add(this.chkIncludeAuditDDL);
			this.grpDDL.Controls.Add(this.btnCreateSPs);
			this.grpDDL.Location = new System.Drawing.Point(152, 92);
			this.grpDDL.Name = "grpDDL";
			this.grpDDL.Size = new System.Drawing.Size(375, 51);
			this.grpDDL.TabIndex = 8;
			this.grpDDL.TabStop = false;
			this.grpDDL.Text = "Create DDL";
			// 
			// chkIncludeAuditDDL
			// 
			this.chkIncludeAuditDDL.AutoSize = true;
			this.chkIncludeAuditDDL.Location = new System.Drawing.Point(130, 24);
			this.chkIncludeAuditDDL.Name = "chkIncludeAuditDDL";
			this.chkIncludeAuditDDL.Size = new System.Drawing.Size(184, 17);
			this.chkIncludeAuditDDL.TabIndex = 3;
			this.chkIncludeAuditDDL.Text = "Include Audit Table && Restore SP";
			this.ttpMain.SetToolTip(this.chkIncludeAuditDDL, "Add audit table DDL and changes to the Stored Procedures to support auditing.");
			this.chkIncludeAuditDDL.UseVisualStyleBackColor = true;
			// 
			// btnCreateSPs
			// 
			this.btnCreateSPs.Location = new System.Drawing.Point(20, 17);
			this.btnCreateSPs.Name = "btnCreateSPs";
			this.btnCreateSPs.Size = new System.Drawing.Size(104, 28);
			this.btnCreateSPs.TabIndex = 2;
			this.btnCreateSPs.Text = "Create CRUD SPs";
			this.ttpMain.SetToolTip(this.btnCreateSPs, "Create stored procedues for SELECT, INSERT, UPDATE, and DELETE.");
			this.btnCreateSPs.UseVisualStyleBackColor = true;
			this.btnCreateSPs.Click += new System.EventHandler(this.BtnCreateSPs_Click);
			// 
			// lblNamespace
			// 
			this.lblNamespace.AutoSize = true;
			this.lblNamespace.Location = new System.Drawing.Point(12, 68);
			this.lblNamespace.Name = "lblNamespace";
			this.lblNamespace.Size = new System.Drawing.Size(62, 13);
			this.lblNamespace.TabIndex = 7;
			this.lblNamespace.Text = "Namespace";
			// 
			// txtNamespace
			// 
			this.txtNamespace.Location = new System.Drawing.Point(119, 65);
			this.txtNamespace.Name = "txtNamespace";
			this.txtNamespace.Size = new System.Drawing.Size(408, 21);
			this.txtNamespace.TabIndex = 6;
			this.ttpMain.SetToolTip(this.txtNamespace, "Namespace to use in the POCO class code.");
			this.txtNamespace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNamespace_KeyPress);
			// 
			// btnPathPOCO
			// 
			this.btnPathPOCO.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPathPOCO.Location = new System.Drawing.Point(545, 11);
			this.btnPathPOCO.Name = "btnPathPOCO";
			this.btnPathPOCO.Size = new System.Drawing.Size(43, 21);
			this.btnPathPOCO.TabIndex = 4;
			this.btnPathPOCO.Text = " . . . ";
			this.ttpMain.SetToolTip(this.btnPathPOCO, "Select Path Dialog");
			this.btnPathPOCO.UseVisualStyleBackColor = true;
			this.btnPathPOCO.Click += new System.EventHandler(this.BtnPOCOPath_Click);
			// 
			// lblDestination
			// 
			this.lblDestination.AutoSize = true;
			this.lblDestination.Location = new System.Drawing.Point(12, 14);
			this.lblDestination.Name = "lblDestination";
			this.lblDestination.Size = new System.Drawing.Size(93, 13);
			this.lblDestination.TabIndex = 3;
			this.lblDestination.Text = "POCO Destination";
			// 
			// txtPOCODestination
			// 
			this.txtPOCODestination.Location = new System.Drawing.Point(119, 11);
			this.txtPOCODestination.Name = "txtPOCODestination";
			this.txtPOCODestination.Size = new System.Drawing.Size(408, 21);
			this.txtPOCODestination.TabIndex = 2;
			this.ttpMain.SetToolTip(this.txtPOCODestination, "Destination path");
			// 
			// btnCreatePOCOs
			// 
			this.btnCreatePOCOs.Location = new System.Drawing.Point(18, 109);
			this.btnCreatePOCOs.Name = "btnCreatePOCOs";
			this.btnCreatePOCOs.Size = new System.Drawing.Size(105, 28);
			this.btnCreatePOCOs.TabIndex = 0;
			this.btnCreatePOCOs.Text = "Create POCO(s)";
			this.ttpMain.SetToolTip(this.btnCreatePOCOs, "Create a POCO class for each table selected.");
			this.btnCreatePOCOs.UseVisualStyleBackColor = true;
			this.btnCreatePOCOs.Click += new System.EventHandler(this.BtnCreatePOCOs_Click);
			// 
			// lblTables
			// 
			this.lblTables.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTables.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTables.Location = new System.Drawing.Point(0, 0);
			this.lblTables.Name = "lblTables";
			this.lblTables.Size = new System.Drawing.Size(600, 21);
			this.lblTables.TabIndex = 1;
			this.lblTables.Text = "Tables";
			// 
			// ttpMain
			// 
			this.ttpMain.IsBalloon = true;
			this.ttpMain.ToolTipTitle = "POCO Generator";
			// 
			// dlgFolder
			// 
			this.dlgFolder.Description = "Choose Destination Folder";
			this.dlgFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this.dlgFolder.SelectedPath = "C:\\";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1166, 711);
			this.Controls.Add(this.splMain);
			this.Controls.Add(this.mnuMain);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mnuMain;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "POCO Generator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.splMain.Panel1.ResumeLayout(false);
			this.splMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
			this.splMain.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.pnlServer.ResumeLayout(false);
			this.pnlServer.PerformLayout();
			this.pnlTables.ResumeLayout(false);
			this.pnlTableButtons.ResumeLayout(false);
			this.pnlTableButtons.PerformLayout();
			this.grpDDL.ResumeLayout(false);
			this.grpDDL.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDatabases;
        private System.Windows.Forms.Panel pnlServer;
        private System.Windows.Forms.Button btnGetDBs;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ListBox lstDatabases;
        private System.Windows.Forms.ToolStripMenuItem editSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolTip ttpMain;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.Panel pnlTables;
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.Panel pnlTableButtons;
		private System.Windows.Forms.Button btnPathCRUD;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCRUDDestination;
		private System.Windows.Forms.GroupBox grpDDL;
		private System.Windows.Forms.CheckBox chkIncludeAuditDDL;
		private System.Windows.Forms.Button btnCreateSPs;
		private System.Windows.Forms.Label lblNamespace;
		private System.Windows.Forms.TextBox txtNamespace;
		private System.Windows.Forms.Button btnPathPOCO;
		private System.Windows.Forms.Label lblDestination;
		private System.Windows.Forms.TextBox txtPOCODestination;
		private System.Windows.Forms.Button btnCreatePOCOs;
	}
}

