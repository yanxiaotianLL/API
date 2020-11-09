using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Fund.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Common
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Common
     *项目描述  ：
     *类名称    ：SqlBulkCopyHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : SqlBulkCopyHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-03-02 20:37:36
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class SqlBulkCopyHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString">目标连接字符</param>
        /// <param name="TableName">目标表</param>
        /// <param name="dt">源数据</param>
        public static void SqlBulkCopyByDatatable(string conncetion,DataTable dt,string tableName,Dictionary<string,string> tableMapper)
        {
            //using (SqlConnection conn = new SqlConnection(conncetion))
            //{
                using (SqlBulkCopy sqlbulkcopy = new SqlBulkCopy(conncetion, SqlBulkCopyOptions.UseInternalTransaction))
                {
                    try
                    {
                        sqlbulkcopy.DestinationTableName = tableName;
                       
                        foreach (var k in tableMapper)
                        {
                            sqlbulkcopy.ColumnMappings.Add(k.Key,k.Value);
                        }
                        sqlbulkcopy.WriteToServer(dt);
                    }
                    catch (System.Exception ex)
                    {
                        var log = EngineContext.Current.Resolve<ILoggerProviderFactory>().CreateLogger(myselfFast.Component.Logging.LoggerType.LogEntity);
                        log.Error(null, "", ex);
                        throw ex;
                    }
                }
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString">目标连接字符</param>
        /// <param name="TableName">目标表</param>
        /// <param name="dt">源数据</param>
        public static void SqlBulkCopyByDataReader(string conncetion, IDataReader dr, string tableName, Dictionary<string, string> tableMapper)
        {
            //using (SqlConnection conn = new SqlConnection(conncetion))
            //{
            using (SqlBulkCopy sqlbulkcopy = new SqlBulkCopy(conncetion, SqlBulkCopyOptions.UseInternalTransaction))
            {
                try
                {
                    sqlbulkcopy.DestinationTableName = tableName;
                    sqlbulkcopy.BulkCopyTimeout = 21600;
                    foreach (var k in tableMapper)
                    {
                        sqlbulkcopy.ColumnMappings.Add(k.Key, k.Value);
                    }
                    sqlbulkcopy.WriteToServer(dr);
                }
                catch (InvalidOperationException ex)
                {
                    //var log = EngineContext.Current.Resolve<ILoggerProviderFactory>().CreateLogger(myselfFast.Component.Logging.LoggerType.LogEntity);
                    //if (log !=null)
                    //{
                    //    log.Error(null, "", ex);
                    //}
                    throw ex;
                }
                catch (System.Exception ex)
                {
                    //var log = EngineContext.Current.Resolve<ILoggerProviderFactory>().CreateLogger(myselfFast.Component.Logging.LoggerType.LogEntity);
                    //if (log != null)
                    //{
                    //    log.Error(null, "", ex);
                    //}
                    throw ex;
                }
            }
            //}
        }
    }


    public class CSVDataReader : IDataReader
    {
        private StreamReader stream;
        private Dictionary<string, int> columnsByName = new Dictionary<string, int>();
        private Dictionary<int, string> columnsByOrdinal = new Dictionary<int, string>();
        private string[] currentRow;
        private bool _isClosed = true;
        private int taskId = 0;
        private int taskIndex = 0;
        public CSVDataReader(string fileName,int taskId)
        {
            if (!File.Exists(fileName))
                throw new Exception("File [" + fileName + "] does not exist.");
            this.taskId = taskId;
            this.stream = new StreamReader(fileName, Encoding.Default);


            //int count = 0;
            //while (this.stream.Peek() > 0)
            //{
            //    this.stream.ReadLine();
            //    count++;
            //}
           
            string[] headers = stream.ReadLine().Split(',');
            for (int i = 0; i < headers.Length; i++)
            {
                columnsByName.Add(headers[i].Replace("\"","").Replace("'",""), i);
                columnsByOrdinal.Add(i, headers[i]);
            }
            columnsByName.Add("TASKID", headers.Length);
            columnsByOrdinal.Add(headers.Length, "TASKID");
            taskIndex = headers.Length;
            _isClosed = false;
        }

        public void Close()
        {
            if (stream != null) stream.Close();
            _isClosed = true;
        }

        public int FieldCount
        {
            get { return columnsByName.Count; }
        }
        bool flag = false;
        /// <summary>
        /// This is the main function that does the work - it reads in the next line of data and parses the values into ordinals.
        /// </summary>
        /// <returns>A value indicating whether the EOF was reached or not.</returns>
        public bool Read()
        {
            if (stream == null) return false;
            if (stream.Peek()<=0) return false;


            currentRow = stream.ReadLine().Replace("\"", "").Replace("'", "").Split(',');
            //currentRow = currentRowNew;
            //if(flag == true){
            //    currentRow = currentRow.Union(currentRowNew).ToArray();
            //    flag = false;
            //}
            //if (currentRow.Length < columnsByName.Count)
            //{
            //    flag = true;
            //}
            //for (int i = 0; i >= currentRow.Length; i++)
            //{

            //    currentRow[i] = currentRow[i].Replace("\"", "").Replace("'", "").Trim();              

            //}
            return true;
        }

        public object GetValue(int i)
        {
            try
            {
                if (i == taskIndex)
                {
                    return this.taskId;
                }
                return currentRow[i].Replace("\"", "").Replace("'", "").Trim(); ;
            }
            catch(Exception ex){
                var log = EngineContext.Current.Resolve<ILoggerProviderFactory>().CreateLogger(myselfFast.Component.Logging.LoggerType.LogEntity);
                log.Error(null, "", ex);
                return "";
            }
            
        }

        public string GetName(int i)
        {
            if (i == taskIndex)
            {
                return "TASKID";
            }
            return columnsByOrdinal[i];
        }

        public int GetOrdinal(string name)
        {
            try
            {
                if ("TASKID" == name)
                {
                    return taskIndex;
                }
                return columnsByName[name];
            }catch(Exception ex){
                //var log = EngineContext.Current.Resolve<ILoggerProviderFactory>().CreateLogger(myselfFast.Component.Logging.LoggerType.LogEntity);
                //log.Error(null, string.Format("excel导入功能,任务ID:{0},name:{1} 不存在", taskId, name), ex);
                return taskIndex;
            }
        }




        public int Depth
        {
            get { throw new NotImplementedException(); }
        }

        public DataTable GetSchemaTable()
        {
            throw new NotImplementedException();
        }

        public bool IsClosed
        {
            get { throw new NotImplementedException(); }
        }

        public bool NextResult()
        {
            throw new NotImplementedException();
        }

        public int RecordsAffected
        {
            get { throw new NotImplementedException(); }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public bool GetBoolean(int i)
        {
            throw new NotImplementedException();
        }

        public byte GetByte(int i)
        {
            throw new NotImplementedException();
        }

        public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        public char GetChar(int i)
        {
            throw new NotImplementedException();
        }

        public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        public IDataReader GetData(int i)
        {
            throw new NotImplementedException();
        }

        public string GetDataTypeName(int i)
        {
            throw new NotImplementedException();
        }

        public DateTime GetDateTime(int i)
        {
            throw new NotImplementedException();
        }

        public decimal GetDecimal(int i)
        {
            throw new NotImplementedException();
        }

        public double GetDouble(int i)
        {
            throw new NotImplementedException();
        }

        public Type GetFieldType(int i)
        {
            throw new NotImplementedException();
        }

        public float GetFloat(int i)
        {
            throw new NotImplementedException();
        }

        public Guid GetGuid(int i)
        {
            throw new NotImplementedException();
        }

        public short GetInt16(int i)
        {
            throw new NotImplementedException();
        }

        public int GetInt32(int i)
        {
            throw new NotImplementedException();
        }

        public long GetInt64(int i)
        {
            throw new NotImplementedException();
        }

        public string GetString(int i)
        {
            throw new NotImplementedException();
        }

        public int GetValues(object[] values)
        {
            throw new NotImplementedException();
        }

        public bool IsDBNull(int i)
        {
            throw new NotImplementedException();
        }

        public object this[string name]
        {
            get { throw new NotImplementedException(); }
        }

        public object this[int i]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
