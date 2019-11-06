using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jeff.Jones.JLogger;
using Jeff.Jones.JHelpers;
using System.Configuration;

namespace POCO_Generator
{
    public partial class frmSettings : Form
    {
        private LOG_TYPE m_DebugLogOptions = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DEBUG_LOG_OPTIONS];

        public frmSettings()
        {
            InitializeComponent();

            DateTime methodStart = DateTime.Now;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            try
            {
                SetCurrentValues();
            }
            catch (Exception exUnhandled)
            {
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

        private void TxtConnectionTimeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumbersOnly(e);
        }

        private void TxtConnectionRetryCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumbersOnly(e);
        }

        private void TxtConnectionRetryInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumbersOnly(e);
        }

        private void TxtCommandTimeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumbersOnly(e);
        }


        private void ChkUseWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseWindowsAuthentication.Checked)
            {
                grpLogon.Enabled = false;
            }
            else
            {
                grpLogon.Enabled = true;
            }
        }

        private void TxtDBPortNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                 !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private Boolean NumbersOnly(KeyPressEventArgs e)
        {
            Boolean retVal = false;

            if (!char.IsControl(e.KeyChar) &&
                 !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                retVal = true;
            }

            return retVal;
        }


        private Boolean NumbersOnlyWithDecimal(KeyPressEventArgs e, String textValue)
        {
            Boolean retVal = false;

            if (!char.IsControl(e.KeyChar) &&
                 !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                retVal = true;
            }
            else
            {
                // only allow one decimal point
                if ((e.KeyChar == '.') && (textValue.IndexOf('.') > -1))
                {
                    retVal = true;
                }
            }

            return retVal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {




        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {

            DateTime methodStart = DateTime.Now;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            try
            {
                List<String> settingKeys = new List<String>(ContextMgr.Instance.ContextValues.Keys);

                foreach (String key in settingKeys)
                {
                    if (key == Properties.Resources.SETTING_COMMAND_TIMEOUT)
                    {
                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_COMMAND_TIMEOUT] = CommonHelpers.GetInt32(txtCommandTimeout.Text, 10);
                    }
                    else if (key == Properties.Resources.SETTING_CONNECTION_POOLING)
                    {
                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_POOLING] = chkConnectionPooling.Checked;
                    }
                    else if (key == Properties.Resources.SETTING_CONNECTION_RETRY_COUNT)
                    {
                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_COUNT] = CommonHelpers.GetInt32(txtConnectionRetryCount.Text, 3);
                    }
                    else if (key == Properties.Resources.SETTING_CONNECTION_RETRY_INTERVAL)
                    {
                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_INTERVAL] = CommonHelpers.GetInt32(txtConnectionRetryInterval.Text, 10);
                    }
                    else if (key == Properties.Resources.SETTING_CONNECTION_TIMEOUT)
                    {
                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_TIMEOUT] = CommonHelpers.GetInt32(txtConnectionTimeout.Text, 10);
                    }
                    else if (key == Properties.Resources.SETTING_DB_APPLICATION_NAME)
                    {
                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_APPLICATION_NAME] = txtDBApplicationName.Text;
                    }
                    else if (key == Properties.Resources.SETTING_DB_PASSWORD)
                    {
                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PASSWORD] = txtDBPassword.Text.Trim();
                    }
                    else if (key == Properties.Resources.SETTING_DB_PORT_NUMBER)
                    {
                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PORT_NUMBER] = CommonHelpers.GetInt32(txtDBPortNumber.Text, 1433);
                    }
                    else if (key == Properties.Resources.SETTING_DB_USER_NAME)
                    {
                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_USER_NAME] = txtDBUserName.Text.Trim();
                    }
                    else if (key == Properties.Resources.SETTING_DEBUG_LOG_OPTIONS)
                    {
                        String logOptions = "";

                        for (int i = 0; i < chkDebugLogOptions.CheckedItems.Count; i++)
                        {
                            logOptions += chkDebugLogOptions.CheckedItems[i].ToString() + ",";
                        }

                        if (logOptions.EndsWith(","))
                        {
                            logOptions = logOptions.Substring(0, logOptions.Length - 1);
                        }

                        LOG_TYPE logOptionsList = (LOG_TYPE)Enum.Parse(typeof(LOG_TYPE), logOptions);

                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DEBUG_LOG_OPTIONS] = logOptionsList;

                    }
                    else if (key == Properties.Resources.SETTING_DEFAULT_DB)
                    {
                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DEFAULT_DB] = txtDefaultDB.Text.Trim();
                    }
                    else if (key == Properties.Resources.SETTING_LAST_DB_SERVER)
                    {
                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_LAST_DB_SERVER] = txtLastDBServer.Text.Trim();
                    }
                    else if (key == Properties.Resources.SETTING_USE_WINDOWS_AUTHENTICATION)
                    {
                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_USE_WINDOWS_AUTHENTICATION] = chkUseWindowsAuthentication.Checked;
                    }
                    else
                    {
                        // Do nothing
                    }
                }  // foreach (String key in settingKeys)



                String dbPassword = ContextMgr.Instance.ContextValues["DBPassword"];

                String dbPasswordEncrypted = "";


                if (dbPassword.Length > 0)
                {
                    CryptoMgr crypto = new CryptoMgr();

                    dbPasswordEncrypted = crypto.EncryptStringAES(dbPassword);

                    crypto = null;

                }

                Properties.Settings.Default.DBPassword = dbPasswordEncrypted;
                Properties.Settings.Default.CommandTimeout = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_COMMAND_TIMEOUT];
                Properties.Settings.Default.ConnectionRetryCount = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_COUNT];
                Properties.Settings.Default.ConnectionRetryInterval = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_INTERVAL];
                Properties.Settings.Default.ConnectionTimeout = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_COMMAND_TIMEOUT];
                Properties.Settings.Default.DBApplicationName = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_APPLICATION_NAME];
                Properties.Settings.Default.DBUserName = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_USER_NAME];
                Properties.Settings.Default.DebugLogOptions = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DEBUG_LOG_OPTIONS];
                Properties.Settings.Default.DefaultDB = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DEFAULT_DB];
                Properties.Settings.Default.LastDBServer = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_LAST_DB_SERVER];
                Properties.Settings.Default.UseWindowsAuthentication = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_USE_WINDOWS_AUTHENTICATION];
                Properties.Settings.Default.DBPortNumber = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PORT_NUMBER];
                Properties.Settings.Default.ConnectionPooling = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_POOLING];
                Properties.Settings.Default.Save();

            }
            catch (Exception exUnhandled)
            {
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

        /// <summary>
        /// 
        /// </summary>
        private void SetCurrentValues()
        {

            DateTime methodStart = DateTime.Now;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            try
            {

                foreach (KeyValuePair<String, dynamic> contextSetting in ContextMgr.Instance.ContextValues)
                {
                    if (contextSetting.Key == Properties.Resources.SETTING_COMMAND_TIMEOUT)
                    {
                        txtCommandTimeout.Text = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_COMMAND_TIMEOUT].ToString();
                    }
                    else if (contextSetting.Key == Properties.Resources.SETTING_CONNECTION_POOLING)
                    {
                        chkConnectionPooling.Checked = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_POOLING];
                    }
                    else if (contextSetting.Key == Properties.Resources.SETTING_CONNECTION_RETRY_COUNT)
                    {
                        txtConnectionRetryCount.Text = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_COUNT].ToString();
                    }
                    else if (contextSetting.Key == Properties.Resources.SETTING_CONNECTION_RETRY_INTERVAL)
                    {
                        txtConnectionRetryInterval.Text = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_INTERVAL].ToString();
                    }
                    else if (contextSetting.Key == Properties.Resources.SETTING_CONNECTION_TIMEOUT)
                    {
                        txtConnectionTimeout.Text = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_TIMEOUT].ToString();
                    }
                    else if (contextSetting.Key == Properties.Resources.SETTING_DB_APPLICATION_NAME)
                    {
                        txtDBApplicationName.Text = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_APPLICATION_NAME];
                    }
                    else if (contextSetting.Key == Properties.Resources.SETTING_DB_PASSWORD)
                    {
                        txtDBPassword.Text = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PASSWORD];
                    }
                    else if (contextSetting.Key == Properties.Resources.SETTING_DB_PORT_NUMBER)
                    {
                        txtDBPortNumber.Text = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PORT_NUMBER].ToString();
                    }
                    else if (contextSetting.Key == Properties.Resources.SETTING_DB_USER_NAME)
                    {
                        txtDBUserName.Text = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_USER_NAME];
                    }
                    else if (contextSetting.Key == Properties.Resources.SETTING_DEBUG_LOG_OPTIONS)
                    {
                        String[] enumNames = Enum.GetNames(typeof(LOG_TYPE));

                        LOG_TYPE[] enumValues = (LOG_TYPE[])Enum.GetValues(typeof(LOG_TYPE));

                        for (int i = 0; i < enumNames.Length; i++)
                        {
                            String enumName = enumNames[i];

                            LOG_TYPE enumValue = enumValues[i];

                            Boolean enumState = ((m_DebugLogOptions & enumValue) == enumValue);

                            chkDebugLogOptions.Items.Add(enumName, enumState);

                        }
                    }
                    else if (contextSetting.Key == Properties.Resources.SETTING_DEFAULT_DB)
                    {
                        txtDefaultDB.Text = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DEFAULT_DB];
                    }
                    else if (contextSetting.Key == Properties.Resources.SETTING_LAST_DB_SERVER)
                    {
                        txtLastDBServer.Text = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_LAST_DB_SERVER];
                    }
                    else if (contextSetting.Key == Properties.Resources.SETTING_USE_WINDOWS_AUTHENTICATION)
                    {
                        chkUseWindowsAuthentication.Checked = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_USE_WINDOWS_AUTHENTICATION];
                    }
                    else
                    {
                        // Do nothing
                    }
                }  // foreach (KeyValuePair<String, dynamic> contextSetting in ContextMgr.Instance.ContextValues)

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);

                txtConfigFilePath.Text = config.FilePath;

            }
            catch (Exception exUnhandled)
            {

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUndoChanges_Click(object sender, EventArgs e)
        {
            DateTime methodStart = DateTime.Now;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            try
            {
                SetCurrentValues();

            }
            catch (Exception exUnhandled)
            {
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
