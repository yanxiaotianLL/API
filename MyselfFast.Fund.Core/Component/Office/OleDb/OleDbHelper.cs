using FescoFast.Fund.Core.Domain.JiCai;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FescoFast.Fund.Core.Component.Office.OleDb
{
    /**********************************************************************************
     *项目名称	：FescoFast.Fund.Core.Component.Office.OleDb
     *项目描述  ：
     *类名称    ：OleDbHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : OleDbHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-02-06 23:18:57
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public   class OleDbHelper
    {
        /// <summary>
        /// 用于将DataReader中的数据转移到业务类中处理
        /// </summary>
        public delegate void FileData(OleDbDataReader dataReader, T_JC_Task task);
        public delegate void SqlBulkCopyByDataReader(string conncetion, IDataReader dr, string tableName, Dictionary<string, string> tableMapper);
        //根据excle的路径把第一个sheel中的内容放入DataTable
        public static DataTable ReadExcelToDataTable(string path, int tableIndex)//excel存放的路径
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(CreateConnectionString(path)))
                {
                    conn.Open();
                    //获取表名称,如果传空默认读取第一个表单内容
                    string firstSheetName = GetTableName(conn, tableIndex);
                    string sql = string.Format("SELECT * FROM [{0}]", firstSheetName); //查询字符串

                    OleDbDataAdapter ada = new OleDbDataAdapter(sql, conn);
                    DataSet set = new DataSet();
                    ada.Fill(set);
                    return set.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //根据excle的路径把第一个sheel中的内容放入DataTable
        public static DataTable ReadExcelToDataTable(string path, int tableIndex,string sql)//excel存放的路径
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(CreateConnectionString(path,"YES","1")))
                {
                    conn.Open();
                    //获取表名称,如果传空默认读取第一个表单内容
                    string firstSheetName = GetTableName(conn, tableIndex);
                    

                    OleDbDataAdapter ada = new OleDbDataAdapter(sql, conn);
                    DataSet set = new DataSet();
                    ada.Fill(set);
                    return set.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //根据excle的路径把第一个sheel中的内容放入DataReader
        public static void ReadExcelToDataReader(string path, int tableIndex, FileData dr, T_JC_Task task)//excel存放的路径
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(CreateConnectionString(path)))
                {
                    conn.Open();
                    //获取表名称,如果传空默认读取第一个表单内容
                    string firstSheetName = GetTableName(conn,tableIndex);
                    string sql = string.Format("SELECT * FROM [{0}]", firstSheetName); //查询字符串

                    using (var commond = conn.CreateCommand())
                    {
                        commond.CommandText = sql;
                        OleDbDataReader reader = commond.ExecuteReader();


                        while (reader.HasRows)
                        {
                            dr(reader,task);
                            break;
                        }
                      
                        reader.Dispose();
                    } 
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void ReadExcelToDataReader(string path, int tableIndex, string conncetion,string tableName, Dictionary<string, string> tableMapper,SqlBulkCopyByDataReader sqlBulkCopyByDataReader)//excel存放的路径
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(CreateConnectionString(path)))
                {
                    conn.Open();
                    
                   
                    //获取表名称,如果传空默认读取第一个表单内容
                    string firstSheetName = GetTableName(conn, tableIndex);
                    string sql = string.Format("SELECT * FROM [{0}]", firstSheetName); //查询字符串

                    using (var commond = conn.CreateCommand())
                    {
                        commond.CommandText = sql;
                        commond.CommandTimeout = 21600;
                        OleDbDataReader reader = commond.ExecuteReader();

                        sqlBulkCopyByDataReader(conncetion, reader, tableName, tableMapper);
                       
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
       
        /// <summary>
        /// 根据excle的路径把第一个sheel中的内容放入DataReader
        /// </summary>
        /// <param name="path">excel路径</param>
        /// <param name="tableIndex">表索引，从0开始</param>
        /// <param name="orderby">排序字段</param>
        /// <param name="dr">游标外放委托</param>
        public static void ReadExcelToDataReader(string path, int tableIndex, string orderby, FileData dr, T_JC_Task task)//excel存放的路径
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(CreateConnectionString(path,"YES","1")))
                {
                    conn.Open();
                    //获取表名称,如果传空默认读取第一个表单内容
                    string firstSheetName = GetTableName(conn, tableIndex);
                    //string sql = string.Format("SELECT * FROM [{0}] WHERE 1=1 ORDER BY [{1}]", firstSheetName, orderby); //查询字符串
                    string sql = string.Format("SELECT * FROM [{0}] ", firstSheetName); //查询字符串
                    using (var commond = conn.CreateCommand())
                    {
                        commond.CommandText = sql;
                        OleDbDataReader reader = commond.ExecuteReader();


                        while (reader.HasRows)
                        {
                            dr(reader,task);
                            break;
                        }

                        reader.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #region 获取表单名称
        /// <summary>
        /// 获取第一个sheet表单的名称
        /// </summary>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static string GetTableName(OleDbConnection conn)
        {

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            DataTable sheetsName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" }); //得到所有sheet的名字
            return sheetsName.Rows[0]["TABLE_NAME"].ToString(); //得到第一个sheet的名字

        }
        /// <summary>
        /// 获取第n个表单的名称
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="tableIndex">索引值，从0开始</param>
        /// <returns></returns>
        public static string GetTableName(OleDbConnection conn, int tableIndex)
        {

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            DataTable sheetsName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" }); //得到所有sheet的名字
            if (sheetsName.Rows.Count < tableIndex + 1)
            {
                throw new ArgumentOutOfRangeException("tableIndex索引值超出有效范围");
            }
            return sheetsName.Rows[tableIndex]["TABLE_NAME"].ToString(); //得到第一个sheet的名字

        }
        /// <summary>
        /// 获取第n个表单的名称
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="tableIndex">索引值，从0开始</param>
        /// <returns></returns>
        public static string GetTableName(string filepath, int tableIndex)
        {
            using (OleDbConnection conn = new OleDbConnection(CreateConnectionString(filepath)))
            {
                conn.Open();
                DataTable sheetsName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" }); //得到所有sheet的名字
                if (sheetsName.Rows.Count < tableIndex + 1)
                {
                    throw new ArgumentOutOfRangeException("tableIndex索引值超出有效范围");
                }
                return sheetsName.Rows[tableIndex]["TABLE_NAME"].ToString(); //得到第一个sheet的名字
            }

        } 
        #endregion

        #region 创建excel连接字符串
        /// <summary>
        /// 创建excel连接字符串
        /// </summary>
        /// <param name="filePath">excel文件路径</param>
        /// <param name="hdr">这代表第一行是标题  ：YEW  OR  NO</param>
        /// <param name="imex">
        /// IMEX 有三种模式：
        //0 is Export mode
        //1 is Import mode
        //2 is Linked mode (full update capabilities)
        //我这里特别要说明的就是 IMEX 参数了，因为不同的模式代表著不同的读写行为：
        //当 IMEX=0 时为“汇出模式”，这个模式开启的 Excel 档案只能用来做“写入”用途。
        //当 IMEX=1 时为“汇入模式”，这个模式开启的 Excel 档案只能用来做“读取”用途。
        //当 IMEX=2 时为“连结模式”，这个模式开启的 Excel 档案可同时支援“读取”与“写入”用途。
        /// </param>
        /// <returns></returns>
        public static string CreateConnectionString(string filePath, string hdr, string imex)
        {
            //连接字符串
            string connstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=NO;IMEX=1';"; // Office 07及以上版本 不能出现多余的空格 而且分号注意
            return string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1};IMEX={2}';", filePath, hdr, imex);
        }
        public static string CreateConnectionString(string filePath, string hdr)
        {
            //连接字符串            
            return string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1};IMEX={2}';", filePath, hdr, 1);
        }
        public static string CreateConnectionString(string filePath)
        {
            //连接字符串           
            return string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1};IMEX={2}';", filePath, "YES", 1);
        } 
        #endregion

        public static T MapperToEntity<T>(IDataReader dr)
            where T:class
        {
            try
            {
                Type type = typeof(T);
                T instance = (T)Activator.CreateInstance(type);
                //获取对象所有属性
                PropertyInfo[] propertys = type.GetProperties();
                foreach (var p in propertys)
                {
                    FieldAttribute attribute = (FieldAttribute)p.GetCustomAttribute(typeof(FieldAttribute));
                    if (attribute != null)
                    {
                        string fieldName = attribute.Name;
                        try
                        {
                            string fieldValue = dr[fieldName].ToString();
                            p.SetValue(instance, fieldValue);
                        }
                        catch{}
                      
                    }
                }

                return instance;
            }
            catch(Exception ex){
                throw ex;
            }
        }
    }
}
