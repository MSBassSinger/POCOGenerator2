using Jeff.Jones.JHelpers;
using Jeff.Jones.JLogger;
using Jeff.Jones.JDAC; 
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace POCO_Generator
{

    /// <summary>
    /// 
    /// </summary>
    public partial class frmMain : Form
    {
        private String m_Server = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_LAST_DB_SERVER];   

        private String m_Database = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DEFAULT_DB];

        private LOG_TYPE m_DebugLogOptions = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DEBUG_LOG_OPTIONS];


        /// <summary>
        /// 
        /// </summary>
        public frmMain()
        {
            InitializeComponent();

            txtServer.Text = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_LAST_DB_SERVER];

            //GetTableSchema();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ContextMgr.Instance.ContextValues["LastDBServer"] = txtServer.Text.Trim();
            Properties.Settings.Default.LastDBServer = txtServer.Text.Trim();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtServer_TextChanged(object sender, EventArgs e)
        {
            if (txtServer.Text.Trim().Length > 0)
            {
                btnGetDBs.Enabled = true;
            }
            else
            {
                btnGetDBs.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGetDatabases_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DateTime methodStart = DateTime.Now;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            POCOBusiness poco = null;

            try
            {
                String server = txtServer.Text.Trim();

                if (server.Length > 0)
                {

                    poco = new POCOBusiness();

                    if (poco.IsConnectionAvailable(server, "master"))
                    {
                        lstDatabases.Items.Clear();

                        List<String> dbs = poco.GetDatabaseNameList(server);

                        Boolean failure = true;

                        if (dbs != null)
                        {
                            if (dbs.Count > 0)
                            {
                                failure = false;

                                foreach (String dbName in dbs)
                                {
                                    lstDatabases.Items.Add(dbName);
                                }

                            }

                        }

                        if (failure)
                        {
                            this.Cursor = Cursors.Default;

                            MessageBox.Show($"No databases found for {server}.",
                                            "Database Search Failed",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Asterisk);

                        }

                        ContextMgr.Instance.ContextValues["LastDBServer"] = server;
                        Properties.Settings.Default.LastDBServer = server;

                    }
                    else
                    {
                        this.Cursor = Cursors.Default;

                        MessageBox.Show($"No connection for {server}.  The server may not exist or may be unreachable.",
                                        "Database Connection Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Asterisk);


                    }
                }

            }
            catch (Exception exUnhandled)
            {
                // Capture some runtime data that may be useful in debugging.

                exUnhandled.Data.Add("m_Server", m_Server);

                if ((m_DebugLogOptions & LOG_TYPE.Error) == LOG_TYPE.Error)
                {
                    Logger.Instance.WriteDebugLog(LOG_TYPE.Error, exUnhandled, null);
                }

            }
            finally
            {
                this.Cursor = Cursors.Default;

                if ((m_DebugLogOptions & LOG_TYPE.Performance) == LOG_TYPE.Performance)
                {
                    TimeSpan elapsedTime = DateTime.Now - methodStart;

                    Logger.Instance.WriteDebugLog(LOG_TYPE.Performance,
                                                    $"END; elapsed time = [{elapsedTime,0:mm} mins, {elapsedTime,0:ss} secs, {elapsedTime:fff} msecs].");
                }
            }

        }

        private void EditSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime methodStart = DateTime.Now;

            frmSettings settings = null;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            try
            {
                settings = new frmSettings();

                settings.ShowDialog(this);
            }
            catch (Exception exUnhandled)
            {
                // Capture some runtime data that may be useful in debugging.

                exUnhandled.Data.Add("m_Server", m_Server);

                if ((m_DebugLogOptions & LOG_TYPE.Error) == LOG_TYPE.Error)
                {
                    Logger.Instance.WriteDebugLog(LOG_TYPE.Error, exUnhandled, null);
                }

            }
            finally
            {
                if (settings != null)
                {
                    settings.Dispose();

                    settings = null;
                }

                if ((m_DebugLogOptions & LOG_TYPE.Performance) == LOG_TYPE.Performance)
                {
                    TimeSpan elapsedTime = DateTime.Now - methodStart;

                    Logger.Instance.WriteDebugLog(LOG_TYPE.Performance,
                                                    $"END; elapsed time = [{elapsedTime,0:mm} mins, {elapsedTime,0:ss} secs, {elapsedTime:fff} msecs].");
                }
            }



        }

        private void BtnPOCOPath_Click(object sender, EventArgs e)
        {

            DateTime methodStart = DateTime.Now;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            try
            {

                DialogResult result = dlgFolder.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    txtPOCODestination.Text = dlgFolder.SelectedPath;
                }

            }
            catch (Exception exUnhandled)
            {
                // Capture some runtime data that may be useful in debugging.

                exUnhandled.Data.Add("m_Server", m_Server);

                if ((m_DebugLogOptions & LOG_TYPE.Error) == LOG_TYPE.Error)
                {
                    Logger.Instance.WriteDebugLog(LOG_TYPE.Error, exUnhandled, null);
                }

            }
            finally
            {

                if ((m_DebugLogOptions & LOG_TYPE.Performance) == LOG_TYPE.Performance)
                {
                    TimeSpan elapsedTime = DateTime.Now - methodStart;

                    Logger.Instance.WriteDebugLog(LOG_TYPE.Performance,
                                                    $"END; elapsed time = [{elapsedTime,0:mm} mins, {elapsedTime,0:ss} secs, {elapsedTime:fff} msecs].");
                }
            }

        }

        private void LstDatabases_DoubleClick(object sender, EventArgs e)
        {

            DateTime methodStart = DateTime.Now;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            POCOBusiness poco = null;

            this.Cursor = Cursors.WaitCursor;

            try
            {

                poco = new POCOBusiness();

                String dbName = "";
                String serverName = txtServer.Text.Trim();

                if (lstDatabases.SelectedIndex >= 0)
                {
                    dbName = lstDatabases.SelectedItem.ToString();

                    List<String> tableList = poco.GetTableNameList(serverName, dbName);

                    Boolean failure = true;

                    if (tableList != null)
                    {
                        if (tableList.Count > 0)
                        {
                            tableList.Sort();

                            lblTables.Text = "Tables";

                            lstTables.Items.Clear();

                            failure = false;

                            lblTables.Text = $"{serverName} Tables";

                            foreach (String tableName in tableList)
                            {
                                lstTables.Items.Add(tableName);
                            }
                        }
                    }

                    if (failure)
                    {
                        MessageBox.Show(this,
                                        $"Either the database {dbName} has no tables, or your login does npot have access to see them.",
                                        "No Tables Found",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

                    }

                }

            }  // END try
            catch (Exception exUnhandled)
            {
                // Capture some runtime data that may be useful in debugging.

                exUnhandled.Data.Add("m_Server", m_Server);

                if ((m_DebugLogOptions & LOG_TYPE.Error) == LOG_TYPE.Error)
                {
                    Logger.Instance.WriteDebugLog(LOG_TYPE.Error, exUnhandled, null);
                }

            }  // END catch (Exception exUnhandled)
            finally
            {
                poco = null;

                if ((m_DebugLogOptions & LOG_TYPE.Performance) == LOG_TYPE.Performance)
                {
                    TimeSpan elapsedTime = DateTime.Now - methodStart;

                    Logger.Instance.WriteDebugLog(LOG_TYPE.Performance,
                                                    $"END; elapsed time = [{elapsedTime,0:mm} mins, {elapsedTime,0:ss} secs, {elapsedTime:fff} msecs].");
                }

                this.Cursor = Cursors.Default;

            }  // END finally
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreatePOCOs_Click(object sender, EventArgs e)
        {
            DateTime methodStart = DateTime.Now;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            POCOBusiness poco = null;

            this.Cursor = Cursors.WaitCursor;

            try
            {

                String serverName = txtServer.Text.Trim();

                String databaseName = lstDatabases.SelectedItem.ToString();

                String nameSpace = txtNamespace.Text.Trim();

                String destPath = txtPOCODestination.Text.Trim();

                if (!destPath.EndsWith(@"\"))
                {
                    destPath += @"\";
                }

                poco = new POCOBusiness();

                if (poco.IsConnectionAvailable(serverName, "master"))
                {

                    List<String> tableNames = lstTables.SelectedItems.OfType<String>().ToList();

                    foreach (String tableName in tableNames)
                    {

                        String classCode = poco.GetPOCO_CS(serverName, databaseName, tableName, nameSpace);

						String methodCode = poco.GetMethodCode_CS(serverName, databaseName, tableName);

                        if (!Directory.Exists(destPath))
                        {
                            Directory.CreateDirectory(destPath);
                        }

                        String pocoFileName = tableName;

						if (tableName.StartsWith("dbo.", StringComparison.CurrentCultureIgnoreCase))
                        {
                            pocoFileName = tableName.Replace("dbo.", "");
                        }

                        File.WriteAllText(destPath + pocoFileName + "DO.cs", classCode);
						File.WriteAllText(destPath + pocoFileName + "_Method.cs", methodCode);

					}  // END foreach (String tableName in tableNames)

				}
                else
                {
                    this.Cursor = Cursors.Default;

                    MessageBox.Show(this,
                                    $"SQL Server {serverName} was not available.",
                                    "SQL Server Not Reachable",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                }
            }  // END try
            catch (Exception exUnhandled)
            {
                if ((m_DebugLogOptions & LOG_TYPE.Error) == LOG_TYPE.Error)
                {
                    Logger.Instance.WriteDebugLog(LOG_TYPE.Error, exUnhandled, null);
                }

            }  // END catch (Exception exUnhandled)
            finally
            {

                if ((m_DebugLogOptions & LOG_TYPE.Performance) == LOG_TYPE.Performance)
                {
                    TimeSpan elapsedTime = DateTime.Now - methodStart;

                    Logger.Instance.WriteDebugLog(LOG_TYPE.Performance,
                                                    $"END; elapsed time = [{elapsedTime,0:mm} mins, {elapsedTime,0:ss} secs, {elapsedTime:fff} msecs].");
                }

                this.Cursor = Cursors.Default;

            }  // END finally

        }  // END private void BtnCreatePOCOs_Click(object sender, EventArgs e)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreateSPs_Click(object sender, EventArgs e)
        {

            DateTime methodStart = DateTime.Now;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            POCOBusiness poco = null;

            JDAC_DDL sps = null;

            Boolean doAudit = false;

 
            try
            {
                this.Cursor = Cursors.WaitCursor;

                doAudit = chkIncludeAuditDDL.Checked;

                String serverName = txtServer.Text.Trim();

                String databaseName = lstDatabases.SelectedItem.ToString();

				String destPathCRUD = txtCRUDDestination.Text.Trim();

				if (!destPathCRUD.EndsWith(@"\"))
				{
					destPathCRUD += @"\";
				}

				poco = new POCOBusiness();

                if (poco.IsConnectionAvailable(serverName, "master"))
                {
                    List<String> tableNames = lstTables.SelectedItems.OfType<String>().ToList();

                    foreach (String tableName in tableNames)
                    {
                        sps = poco.GetSPs(serverName, databaseName, tableName, doAudit);

                        if (!Directory.Exists(destPathCRUD))
                        {
                            Directory.CreateDirectory(destPathCRUD);
                        }

                        String fileName = char.ToUpper(tableName[0]) + tableName.Substring(1); 

                        if (fileName.Contains('.'))
                        {
                            fileName = fileName.Replace(".", "_");
                        }

                        String spName = $"sp_{fileName}_Get.sql";

                        File.WriteAllText(destPathCRUD + spName, sps.SelectSP);

						if (chkIncludeAuditDDL.Checked)
						{
							spName = $"sp_{fileName}_Insert_Audit.sql"; ;
						}
						else
						{
							spName = $"sp_{fileName}_Insert.sql"; ;
						}

						File.WriteAllText(destPathCRUD + spName, sps.InsertSP);

						if (chkIncludeAuditDDL.Checked)
						{
							spName = $"sp_{fileName}_Update_Audit.sql"; ;
						}
						else
						{
							spName = $"sp_{fileName}_Update.sql"; ;
						}

						File.WriteAllText(destPathCRUD + spName, sps.UpdateSP);

						if (chkIncludeAuditDDL.Checked)
						{
							spName = $"sp_{fileName}_Delete_Audit.sql"; ;
						}
						else
						{
							spName = $"sp_{fileName}_Delete.sql"; ;
						}

						File.WriteAllText(destPathCRUD + spName, sps.DeleteSP);

						if (chkIncludeAuditDDL.Checked)
						{
							spName = $"sp_{fileName}_Restore.sql";

							File.WriteAllText(destPathCRUD + spName, sps.RestoreSP);

							String tblName = $"{fileName}_Audit_Table.sql";

							File.WriteAllText(destPathCRUD + tblName, sps.AuditTable);

						}

					}  // END foreach (String tableName in tableNames)

				}
            }  // END try
            catch (Exception exUnhandled)
            {
                if ((m_DebugLogOptions & LOG_TYPE.Error) == LOG_TYPE.Error)
                {
                    Logger.Instance.WriteDebugLog(LOG_TYPE.Error, exUnhandled, null);
                }

            }  // END catch (Exception exUnhandled)
            finally
            {
                poco = null;

                this.Cursor = Cursors.Default;

                if ((m_DebugLogOptions & LOG_TYPE.Performance) == LOG_TYPE.Performance)
                {
                    TimeSpan elapsedTime = DateTime.Now - methodStart;

                    Logger.Instance.WriteDebugLog(LOG_TYPE.Performance,
                                                    $"END; elapsed time = [{elapsedTime,0:mm} mins, {elapsedTime,0:ss} secs, {elapsedTime:fff} msecs].");
                }
            }  // END finally

        }  // END private void BtnCreateSPs_Click(object sender, EventArgs e)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAuditDDL_Click(object sender, EventArgs e)
        {

            DateTime methodStart = DateTime.Now;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            try
            {



            }  // END try
            catch (Exception exUnhandled)
            {
                if ((m_DebugLogOptions & LOG_TYPE.Error) == LOG_TYPE.Error)
                {
                    Logger.Instance.WriteDebugLog(LOG_TYPE.Error, exUnhandled, null);
                }

            }  // END catch (Exception exUnhandled)
            finally
            {

                if ((m_DebugLogOptions & LOG_TYPE.Performance) == LOG_TYPE.Performance)
                {
                    TimeSpan elapsedTime = DateTime.Now - methodStart;

                    Logger.Instance.WriteDebugLog(LOG_TYPE.Performance,
                                                    $"END; elapsed time = [{elapsedTime,0:mm} mins, {elapsedTime,0:ss} secs, {elapsedTime:fff} msecs].");
                }
            }  // END finally


        }  // END private void BtnAuditDDL_Click(object sender, EventArgs e)

        private void TxtNamespace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == " ")
            {
                e.Handled = true;
            }
        }

		private void btnPathCRUD_Click(object sender, EventArgs e)
		{
			DateTime methodStart = DateTime.Now;

			if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
			{
				Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
			}

			try
			{

				DialogResult result = dlgFolder.ShowDialog(this);

				if (result == DialogResult.OK)
				{
					txtCRUDDestination.Text = dlgFolder.SelectedPath;
				}

			}
			catch (Exception exUnhandled)
			{
				// Capture some runtime data that may be useful in debugging.

				exUnhandled.Data.Add("m_Server", m_Server);

				if ((m_DebugLogOptions & LOG_TYPE.Error) == LOG_TYPE.Error)
				{
					Logger.Instance.WriteDebugLog(LOG_TYPE.Error, exUnhandled, null);
				}

			}
			finally
			{

				if ((m_DebugLogOptions & LOG_TYPE.Performance) == LOG_TYPE.Performance)
				{
					TimeSpan elapsedTime = DateTime.Now - methodStart;

					Logger.Instance.WriteDebugLog(LOG_TYPE.Performance,
													$"END; elapsed time = [{elapsedTime,0:mm} mins, {elapsedTime,0:ss} secs, {elapsedTime:fff} msecs].");
				}
			}
		}
	}  // END public partial class frmMain : Form

}  // END namespace POCO_Generator
