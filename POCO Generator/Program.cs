using Jeff.Jones.JHelpers;
using Jeff.Jones.JLogger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace POCO_Generator
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartLog();
            Application.Run(new frmMain());
            StopLog();
        }

        private static void StartLog()
        {

            // Setting a class-wide variable. What you set may
            // be different for development, QA, production, and troubleshooting production.
            // This global value for the program is usually stored in some
            // configuration data location.

            LOG_TYPE debugLogOptions = Properties.Settings.Default.DebugLogOptions;

            String logRoot = CommonHelpers.CurDir + @"\Logs";

            if (!Directory.Exists(logRoot))
            {
                Directory.CreateDirectory(logRoot);
            }

            // Context singleton
            ContextMgr.Instance.ContextValues.Add(Properties.Resources.SETTING_DEBUG_LOG_OPTIONS, debugLogOptions);
            ContextMgr.Instance.ContextValues.Add(Properties.Resources.SETTING_COMMAND_TIMEOUT, Properties.Settings.Default.CommandTimeout);
            ContextMgr.Instance.ContextValues.Add(Properties.Resources.SETTING_CONNECTION_RETRY_COUNT, Properties.Settings.Default.ConnectionRetryCount);
            ContextMgr.Instance.ContextValues.Add(Properties.Resources.SETTING_CONNECTION_RETRY_INTERVAL, Properties.Settings.Default.ConnectionRetryInterval);
            ContextMgr.Instance.ContextValues.Add(Properties.Resources.SETTING_CONNECTION_TIMEOUT, Properties.Settings.Default.ConnectionTimeout);
            ContextMgr.Instance.ContextValues.Add(Properties.Resources.SETTING_DB_APPLICATION_NAME, Properties.Settings.Default.DBApplicationName);
            ContextMgr.Instance.ContextValues.Add(Properties.Resources.SETTING_LAST_DB_SERVER, Properties.Settings.Default.LastDBServer);
            ContextMgr.Instance.ContextValues.Add(Properties.Resources.SETTING_DEFAULT_DB, Properties.Settings.Default.DefaultDB);
            ContextMgr.Instance.ContextValues.Add(Properties.Resources.SETTING_DB_USER_NAME, Properties.Settings.Default.DBUserName);

            // NOTE:  The value, if used, is encrypted when stored, and decrypted when read.
            //        Do NOT change the value in the config file.
            String dbPasswordEncrypted = Properties.Settings.Default.DBPassword.Trim();
            String dbPassword = "";

            if (dbPasswordEncrypted.Length > 0)
            {
                CryptoMgr crypto = new CryptoMgr();

                dbPassword = crypto.DecryptStringAES(dbPasswordEncrypted);

                crypto = null;

            }

            ContextMgr.Instance.ContextValues.Add(Properties.Resources.SETTING_DB_PASSWORD, dbPassword);
            ContextMgr.Instance.ContextValues.Add(Properties.Resources.SETTING_DB_PORT_NUMBER, Properties.Settings.Default.DBPortNumber);
            ContextMgr.Instance.ContextValues.Add(Properties.Resources.SETTING_CONNECTION_POOLING, Properties.Settings.Default.ConnectionPooling);
            ContextMgr.Instance.ContextValues.Add(Properties.Resources.SETTING_USE_WINDOWS_AUTHENTICATION, Properties.Settings.Default.UseWindowsAuthentication);


            // Setting variables used to configure the Logger
            // Typically in the programs startup code, as early as possible.
            Boolean response = false;

            String fileNamePrefix = "POCOGen";

            Int32 daysToRetainLogs = 30;

            // Setting the Logger data so it knows how to build a log file, and
            // how long to keep them. The initial debug log options is set here,
            // and can be changed programmatically at anytime in the
            // Logger.Instance.DebugLogOptions property.
            response = Logger.Instance.SetLogData(logRoot, 
                                                    fileNamePrefix,
                                                    daysToRetainLogs, 
                                                    debugLogOptions, 
                                                    "");

            // These next lines may be omitted if not sending email from your log.
            // Email setup.

            //Int32 smtpPort = 587;

            //Boolean useSSL = true;

            //List<String> sendToAddresses = new List<String> ();

            //sendToAddresses.Add("MyBuddy@somewhere.net");

            //sendToAddresses.Add("John.Smith@anywhere.net");

            //response = Logger.Instance.SetEmailData("smtp.mymailserver.net",
            //                                        "logonEmailAddress@work.net",
            //                                        "logonEmailPassword",
            //                                        smtpPort,
            //                                        sendToAddresses,
            //                                        "emailFromAddress@work.net",
            //                                        "emailReplyToAddress@work.net>",
            //                                        useSSL);

            // End of email setup.

            // This starts the log operation AFTER you have set the initial parameters.

            response = Logger.Instance.StartLog();

            // This ends the configuration example
        }

        private static void StopLog()
        {
            Logger.Instance.StopLog();
        }

    }
}
