using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jeff.Jones.JHelpers;
using Jeff.Jones.JLogger;
using Jeff.Jones.JDAC;


namespace POCO_Generator
{
    public class POCOBusiness
    {
        private LOG_TYPE m_DebugLogOptions = ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DEBUG_LOG_OPTIONS];


        public POCOBusiness()
        {

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverName"></param>
        /// <returns></returns>
        public List<String> GetDatabaseNameList(String serverName)
        {

            DateTime methodStart = DateTime.Now;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            JDataAccessSQL dac = null;

            List<String> retVal = null;

            try
            {

                dac = new JDataAccessSQL(serverName,
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DEFAULT_DB],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_USE_WINDOWS_AUTHENTICATION],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_USER_NAME],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PASSWORD],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_TIMEOUT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_COMMAND_TIMEOUT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_COUNT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_INTERVAL],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_APPLICATION_NAME],
                                        Environment.MachineName,
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PORT_NUMBER],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_POOLING]);


                retVal = dac.GetDatabaseNames();

            }
            catch (Exception exUnhandled)
            {
                // Capture some runtime data that may be useful in debugging.

                exUnhandled.Data.Add("serverName", serverName);

                if ((m_DebugLogOptions & LOG_TYPE.Error) == LOG_TYPE.Error)
                {
                    Logger.Instance.WriteDebugLog(LOG_TYPE.Error, exUnhandled, null);
                }

            }
            finally
            {
                dac = null;

                if ((m_DebugLogOptions & LOG_TYPE.Performance) == LOG_TYPE.Performance)
                {
                    TimeSpan elapsedTime = DateTime.Now - methodStart;

                    Logger.Instance.WriteDebugLog(LOG_TYPE.Performance,
                                                    $"END; elapsed time = [{elapsedTime,0:mm} mins, {elapsedTime,0:ss} secs, {elapsedTime:fff} msecs].");
                }
            }

            return retVal;

        }  // END public List<String> GetDatabaseNameList(String serverName)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        public List<String> GetTableNameList(String serverName, String databaseName)
        {

            DateTime methodStart = DateTime.Now;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            JDataAccessSQL dac = null;

            List<String> retVal = null;

            try
            {

                dac = new JDataAccessSQL(serverName,
                                        databaseName,
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_USE_WINDOWS_AUTHENTICATION],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_USER_NAME],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PASSWORD],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_TIMEOUT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_COMMAND_TIMEOUT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_COUNT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_INTERVAL],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_APPLICATION_NAME],
                                        Environment.MachineName,
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PORT_NUMBER],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_POOLING]);


                retVal = dac.GetTableNames(databaseName);

            }
            catch (Exception exUnhandled)
            {
                // Capture some runtime data that may be useful in debugging.

                exUnhandled.Data.Add("serverName", serverName);
                exUnhandled.Data.Add("databaseName", databaseName);

                if ((m_DebugLogOptions & LOG_TYPE.Error) == LOG_TYPE.Error)
                {
                    Logger.Instance.WriteDebugLog(LOG_TYPE.Error, exUnhandled, null);
                }

            }
            finally
            {
                dac = null;

                if ((m_DebugLogOptions & LOG_TYPE.Performance) == LOG_TYPE.Performance)
                {
                    TimeSpan elapsedTime = DateTime.Now - methodStart;

                    Logger.Instance.WriteDebugLog(LOG_TYPE.Performance,
                                                    $"END; elapsed time = [{elapsedTime,0:mm} mins, {elapsedTime,0:ss} secs, {elapsedTime:fff} msecs].");
                }
            }

            return retVal;

        }  // END public List<String> GetTableNameList(String serverName, String databaseName)

        public List<ColumnsDO> GetTableColumnsMetaData(String serverName, String databaseName)
        {

            DateTime methodStart = DateTime.Now;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            JDataAccessSQL dac = null;

            SchemaFactory sf = null;

            List <ColumnsDO> retVal = null;

            try
            {

                dac = new JDataAccessSQL(serverName,
                                        databaseName,
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_USE_WINDOWS_AUTHENTICATION],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_USER_NAME],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PASSWORD],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_TIMEOUT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_COMMAND_TIMEOUT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_COUNT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_INTERVAL],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_APPLICATION_NAME],
                                        Environment.MachineName,
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PORT_NUMBER],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_POOLING]);


                sf = new SchemaFactory();

                dac.DefaultDB = databaseName;

                retVal = sf.GetColumnsDO(dac);

            }
            catch (Exception exUnhandled)
            {
                // Capture some runtime data that may be useful in debugging.

                exUnhandled.Data.Add("serverName", serverName);
                exUnhandled.Data.Add("databaseName", databaseName);

                if ((m_DebugLogOptions & LOG_TYPE.Error) == LOG_TYPE.Error)
                {
                    Logger.Instance.WriteDebugLog(LOG_TYPE.Error, exUnhandled, null);
                }

            }
            finally
            {
                dac = null;

                sf = null;

                if ((m_DebugLogOptions & LOG_TYPE.Performance) == LOG_TYPE.Performance)
                {
                    TimeSpan elapsedTime = DateTime.Now - methodStart;

                    Logger.Instance.WriteDebugLog(LOG_TYPE.Performance,
                                                    $"END; elapsed time = [{elapsedTime,0:mm} mins, {elapsedTime,0:ss} secs, {elapsedTime:fff} msecs].");
                }
            }

            return retVal;

        }  // END public List<ColumnsDO> GetTableColumnsMetaData(String serverName, String databaseName)

        public Boolean IsConnectionAvailable(String serverName, String databaseName)
        {


            DateTime methodStart = DateTime.Now;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            Boolean retVal = false;

            JDataAccessSQL dac = null;

            try
            {

                dac = new JDataAccessSQL(serverName,
                                        databaseName,
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_USE_WINDOWS_AUTHENTICATION],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_USER_NAME],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PASSWORD],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_TIMEOUT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_COMMAND_TIMEOUT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_COUNT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_INTERVAL],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_APPLICATION_NAME],
                                        Environment.MachineName,
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PORT_NUMBER],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_POOLING]);

                retVal = dac.CheckConnection();

            }
            catch (Exception exUnhandled)
            {
                // Capture some runtime data that may be useful in debugging.

                exUnhandled.Data.Add("server", serverName);
                exUnhandled.Data.Add("databaseName", databaseName);

                if ((m_DebugLogOptions & LOG_TYPE.Error) == LOG_TYPE.Error)
                {
                    Logger.Instance.WriteDebugLog(LOG_TYPE.Error, exUnhandled, null);
                }

            }
            finally
            {
                dac = null;

                if ((m_DebugLogOptions & LOG_TYPE.Performance) == LOG_TYPE.Performance)
                {
                    TimeSpan elapsedTime = DateTime.Now - methodStart;

                    Logger.Instance.WriteDebugLog(LOG_TYPE.Performance,
                                                    $"END; elapsed time = [{elapsedTime,0:mm} mins, {elapsedTime,0:ss} secs, {elapsedTime:fff} msecs].");
                }
            }

            return retVal;

        }  // END public Boolean IsConnectionAvailable(String serverName, String databaseName)


        public String GetPOCO_CS(String serverName, String databaseName, String tableName, String nameSpace)
        {

            DateTime methodStart = DateTime.Now;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            String retVal = "";

            JDataAccessSQL dac = null;

            SchemaFactory sf = null;

            List<ColumnsDO> columns = null;

            try
            {

                dac = new JDataAccessSQL(serverName,
                                        databaseName,
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_USE_WINDOWS_AUTHENTICATION],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_USER_NAME],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PASSWORD],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_TIMEOUT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_COMMAND_TIMEOUT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_COUNT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_INTERVAL],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_APPLICATION_NAME],
                                        Environment.MachineName,
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PORT_NUMBER],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_POOLING]);

                Boolean isAvailable = dac.CheckConnection();

                if (isAvailable)
                {
                    sf = new SchemaFactory();
                    
                    columns = sf.GetColumnsDO(dac, databaseName, tableName);

                    String className = tableName;

                    if (tableName.Contains("."))
                    {
                        if (tableName.StartsWith("dbo.", StringComparison.CurrentCultureIgnoreCase))
                        {
                            className = tableName.Replace("dbo.", "");
                        }
                        else
                        {
                            className = tableName.Replace(".", "_");
                        }
                    }
                    retVal = sf.ConvertSchemaColumnsToCSClass(columns, nameSpace, className + "DO");
                }



            }  // END try
            catch (Exception exUnhandled)
            {
                // Capture some runtime data that may be useful in debugging.

                exUnhandled.Data.Add("serverName", serverName);
                exUnhandled.Data.Add("databaseName", databaseName);
                exUnhandled.Data.Add("tableName", tableName);

                if ((m_DebugLogOptions & LOG_TYPE.Error) == LOG_TYPE.Error)
                {
                    Logger.Instance.WriteDebugLog(LOG_TYPE.Error, exUnhandled, null);
                }

            }  // END catch (Exception exUnhandled)
            finally
            {
                dac = null;

                sf = null;

                if (columns != null)
                {
                    columns.Clear();

                    columns = null;
                }

                if ((m_DebugLogOptions & LOG_TYPE.Performance) == LOG_TYPE.Performance)
                {
                    TimeSpan elapsedTime = DateTime.Now - methodStart;

                    Logger.Instance.WriteDebugLog(LOG_TYPE.Performance,
                                                    $"END; elapsed time = [{elapsedTime,0:mm} mins, {elapsedTime,0:ss} secs, {elapsedTime:fff} msecs].");
                }
            }  // END finally

            return retVal;

        }  // END public String GetPOCO_CS(String serverName, String tableName)


		public String GetMethodCode_CS(String serverName, String databaseName, String tableName)
		{

			DateTime methodStart = DateTime.Now;

			if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
			{
				Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
			}

			String retVal = "";

			JDataAccessSQL dac = null;

			SchemaFactory sf = null;

			List<ColumnsDO> columns = null;

			try
			{

				dac = new JDataAccessSQL(serverName,
										databaseName,
										ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_USE_WINDOWS_AUTHENTICATION],
										ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_USER_NAME],
										ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PASSWORD],
										ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_TIMEOUT],
										ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_COMMAND_TIMEOUT],
										ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_COUNT],
										ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_INTERVAL],
										ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_APPLICATION_NAME],
										Environment.MachineName,
										ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PORT_NUMBER],
										ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_POOLING]);

				Boolean isAvailable = dac.CheckConnection();

				if (isAvailable)
				{
					sf = new SchemaFactory();

					columns = sf.GetColumnsDO(dac, databaseName, tableName);

					String className = tableName;

					if (tableName.Contains("."))
					{
						if (tableName.StartsWith("dbo.", StringComparison.CurrentCultureIgnoreCase))
						{
							className = tableName.Replace("dbo.", "");
						}
						else
						{
							className = tableName.Replace(".", "_");
						}
					}
					retVal = sf.GetFactoryMethodCode(columns, className + "DO");
				}

			}  // END try
			catch (Exception exUnhandled)
			{
				// Capture some runtime data that may be useful in debugging.

				exUnhandled.Data.Add("serverName", serverName);
				exUnhandled.Data.Add("databaseName", databaseName);
				exUnhandled.Data.Add("tableName", tableName);

				if ((m_DebugLogOptions & LOG_TYPE.Error) == LOG_TYPE.Error)
				{
					Logger.Instance.WriteDebugLog(LOG_TYPE.Error, exUnhandled, null);
				}

			}  // END catch (Exception exUnhandled)
			finally
			{
				dac = null;

				sf = null;

				if (columns != null)
				{
					columns.Clear();

					columns = null;
				}

				if ((m_DebugLogOptions & LOG_TYPE.Performance) == LOG_TYPE.Performance)
				{
					TimeSpan elapsedTime = DateTime.Now - methodStart;

					Logger.Instance.WriteDebugLog(LOG_TYPE.Performance,
													$"END; elapsed time = [{elapsedTime,0:mm} mins, {elapsedTime,0:ss} secs, {elapsedTime:fff} msecs].");
				}
			}  // END finally

			return retVal;

		}  // END public String GetPOCO_CS(String serverName, String tableName)


		/// <summary>
		/// 
		/// </summary>
		/// <param name="serverName"></param>
		/// <returns></returns>
		public JDAC_DDL GetSPs(String serverName, String dbName, String tableName, Boolean doAudit)
        {

            DateTime methodStart = DateTime.Now;

            if ((m_DebugLogOptions & LOG_TYPE.Flow) == LOG_TYPE.Flow)
            {
                Logger.Instance.WriteDebugLog(LOG_TYPE.Flow, "1st line in method");
            }

            JDataAccessSQL dac = null;

            SchemaFactory sf = null;

			JDAC_DDL retVal = null;

            try
            {
                retVal = new JDAC_DDL();

                dac = new JDataAccessSQL(serverName,
                                        dbName,
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_USE_WINDOWS_AUTHENTICATION],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_USER_NAME],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PASSWORD],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_TIMEOUT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_COMMAND_TIMEOUT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_COUNT],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_RETRY_INTERVAL],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_APPLICATION_NAME],
                                        Environment.MachineName,
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_DB_PORT_NUMBER],
                                        ContextMgr.Instance.ContextValues[Properties.Resources.SETTING_CONNECTION_POOLING]);


                sf = new SchemaFactory();

                retVal = sf.GetTableSPs(dac, dbName, tableName, doAudit);

            }
            catch (Exception exUnhandled)
            {
                // Capture some runtime data that may be useful in debugging.

                exUnhandled.Data.Add("serverName", serverName);

                if ((m_DebugLogOptions & LOG_TYPE.Error) == LOG_TYPE.Error)
                {
                    Logger.Instance.WriteDebugLog(LOG_TYPE.Error, exUnhandled, null);
                }

            }
            finally
            {
                dac = null;

                if ((m_DebugLogOptions & LOG_TYPE.Performance) == LOG_TYPE.Performance)
                {
                    TimeSpan elapsedTime = DateTime.Now - methodStart;

                    Logger.Instance.WriteDebugLog(LOG_TYPE.Performance,
                                                    $"END; elapsed time = [{elapsedTime,0:mm} mins, {elapsedTime,0:ss} secs, {elapsedTime:fff} msecs].");
                }
            }

            return retVal;

        }  // END public JDAC_DDL GetSPs(String serverName, String dbName, String tableName)












    }  // END internal class POCOBusiness

}  // END namespace POCO_Generator
