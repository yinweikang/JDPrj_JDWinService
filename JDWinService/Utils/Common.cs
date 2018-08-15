using JDWinService.Dal;
using JDWinService.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace JDWinService.Utils
{
    public class Common
    {
        public string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息

        public enum FileType
        {
            采购订单_物料 = 0,
            销售订单 = 1,
            采购限价申请 = 2,
            销售限价申请 = 3,
            请购单_物料 = 4,
            请购单变更 = 5,
            采购订单变更_物料 = 6,
            采购订单变更_NPI = 7
        }
        public enum PageNum
        {
            Page1 = 0,
            Page2 = 1
        }
        public void WriteLogs(string content)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string LogName = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Namespace.Split('.')[0];
            string[] sArray = path.Split(new string[] { LogName }, StringSplitOptions.RemoveEmptyEntries);


            string aa = sArray[0] + "\\" + LogName + "Log\\";

            path = aa;
            if (!string.IsNullOrEmpty(path))
            {

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = path + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";//
                if (!File.Exists(path))
                {
                    FileStream fs = File.Create(path);
                    fs.Close();
                }
                if (File.Exists(path))
                {
                    StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default);

                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "----" + content + "\r\n");

                    sw.Close();
                }
            }
        }

        public void WriteLogs(string FileType, string content)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string LogName = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Namespace.Split('.')[0];
            string[] sArray = path.Split(new string[] { LogName }, StringSplitOptions.RemoveEmptyEntries);


            string aa = sArray[0] + "\\" + LogName + "Log\\" + FileType + "\\";

            path = aa;
            if (!string.IsNullOrEmpty(path))
            {

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = path + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";//
                if (!File.Exists(path))
                {
                    FileStream fs = File.Create(path);
                    fs.Close();
                }
                if (File.Exists(path))
                {
                    StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default);

                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "----" + content + "\r\n");

                    sw.Close();
                }
            }
        }


        public void WriteLogs(string FileType, string TaskID, string content)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string LogName = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Namespace.Split('.')[0];
            string[] sArray = path.Split(new string[] { LogName }, StringSplitOptions.RemoveEmptyEntries);


            string aa = sArray[0] + "\\" + LogName + "Log\\" + FileType + "\\" + TaskID + "\\";

            path = aa;
            if (!string.IsNullOrEmpty(path))
            {

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = path + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";//
                if (!File.Exists(path))
                {
                    FileStream fs = File.Create(path);
                    fs.Close();
                }
                if (File.Exists(path))
                {
                    StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default);

                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "----" + content + "\r\n");

                    sw.Close();
                }
            }
        }
        public void UpdateTable(string TableName, string TaskID)
        {
            string Sql = string.Format(@"update '{0}' set IsUpdate='1' where TaskId='{1}'", TableName, TaskID);
            DBUtil.ExecuteSql(Sql);
            this.WriteLogs("更新表：" + TableName + ",TaskID:" + TaskID);
        }

        public Result SendToK3(string loginUrl, string SendJson)
        {
            HttpWebResponse response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, SendJson, null, null, Encoding.UTF8, null);
            Stream resStream = response.GetResponseStream();

            StreamReader sr2 = new StreamReader(resStream, Encoding.UTF8);
            string ReturnMsg = sr2.ReadToEnd();
            new Common().WriteLogs("K3 返回Code:" + ReturnMsg);
            Result result = new Result(ReturnMsg, "");
            return result;
        }
        public SeOrderResult SendToK3InSe(string loginUrl, string SendJson)
        {
            HttpWebResponse response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, SendJson, null, null, Encoding.UTF8, null);

            Stream resStream = response.GetResponseStream();

            StreamReader sr2 = new StreamReader(resStream, Encoding.UTF8);
            string ReturnMsg = sr2.ReadToEnd();
            new Common().WriteLogs("K3 返回Code:" + ReturnMsg);
            return new SeOrderResult(ReturnMsg);

        }



        //服务字段更新
        public DataTable GetUpdateTab(string TableName, string SqlFilter)
        {
            string sql = string.Format(@"select A.* from {0} A left join BPMInstTasks B
                on A.TaskID=B.TaskID where B.State='Approved' and A.IsUpdate='0'  {1}", TableName, SqlFilter);
            return DBUtil.Query(sql).Tables[0];

        }
        //应用表单字段
        public DataTable GetUpdateAppTab(string TableName, string sqlFilter)
        {
            string sql = string.Format(@"select * from {0} where Isupdate='0' {1} ", TableName, sqlFilter);
            return DBUtil.Query(sql).Tables[0];
        }

        //获得最大ID
        public int GetMaxID(string FieldName, string TableName, string SqlFilter)
        {
            string strsql = "select max(" + FieldName + ")+1 from " + TableName;
            if (!String.IsNullOrEmpty(strsql))
            {
                strsql = strsql + SqlFilter;
            }
            object obj = DBUtil.GetSingle(strsql, K3connectionString);
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return int.Parse(obj.ToString());
            }
        }

        public int GetMaxItemID(string FieldName, string TableName)
        {
            string strsql = "select max(" + FieldName + ")+1 from " + TableName;

            object obj = DBUtil.GetSingle(strsql, K3connectionString);
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return int.Parse(obj.ToString());
            }
        }

        /// <summary>
        /// 插入日志查询列表
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="TableName">轮询日志表名</param>
        /// <param name="TableItemID">轮询日志表ID</param>
        /// <param name="LogType">"API"|"SQL"</param>
        /// <param name="Message">返回信息</param>
        /// <param name="Success">是否成功</param>
        /// <returns></returns>
        public void AddLogQueue(int TaskID, string TableName, int TableItemID, string LogType, string Message, bool Success)
        {
            JD_LogMngQueueDal dal = new JD_LogMngQueueDal();
            JD_LogMngFailedDal faildal = new JD_LogMngFailedDal();
            BPMInstTasksDal taskdal = new BPMInstTasksDal();
            DateTime NowDate = DateTime.Now;
            BPMInstTasks taskMol = taskdal.Detail(TaskID);

            int LogQueID = dal.Add(new JD_LogMngQueue
            {
                TaskID = TaskID,
                TableItemID = TableItemID,
                LogTableName = TableName,
                Message = Message,
                CreateTime = NowDate,
                LogType = LogType,
                Year = NowDate.Year,
                Month = NowDate.Month,
                IsSuccess = (Success == true) ? 1 : 0,
                FileName = taskMol.ProcessName,
                SNumber = taskMol.SerialNum
            });

            //如果不成功 插入错误日志
            if (!Success)
            {
                faildal.Add(new JD_LogMngFailed
                {
                    TaskID = TaskID,
                    TableItemID = TableItemID,
                    LogTableName = TableName,
                    CreateTime = NowDate,
                    FileName = taskMol.ProcessName,
                    SNumber = taskMol.SerialNum,
                    LogQueID = LogQueID,
                    LogType = LogType,
                    Message = Message
                });
            }

        }
    }
}