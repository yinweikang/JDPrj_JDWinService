using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using JDWinService.Utils;
using JDWinService.Model;
using System.Data.SqlClient;

namespace JDWinService.Dal
{
    public class JD_LogMngQueueDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息

        /// <summary>
        /// 新增JD_LogMng对象
        /// 编写人：ywk
        /// 编写日期：2018/8/10 星期五
        /// </summary>
        public int Add(JD_LogMngQueue model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO JD_LogMngQueue(TaskID,FileName,SNumber,LogTableName,TableItemID,Message,CreateTime,Year,Month,LogType,IsSuccess,IsHandle) VALUES(@m_TaskID,@m_FileName,@m_SNumber,@m_LogTableName,@m_TableItemID,@m_Message,@m_CreateTime,@m_Year,@m_Month,@m_LogType,@m_IsSuccess,@m_IsHandle) SELECT @thisId=@@IDENTITY FROM JD_LogMngQueue", con);
            con.Open();

            if (model.TaskID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = model.TaskID;
            }
            if (model.FileName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FileName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FileName", SqlDbType.NVarChar, 50)).Value = model.FileName;
            }
            if (model.SNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = model.SNumber;
            }
            if (model.LogTableName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_LogTableName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_LogTableName", SqlDbType.NVarChar, 50)).Value = model.LogTableName;
            }
            if (model.TableItemID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TableItemID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TableItemID", SqlDbType.Int, 0)).Value = model.TableItemID;
            }
            if (model.Message == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Message", SqlDbType.NText, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Message", SqlDbType.NText, 0)).Value = model.Message;
            }
            if (model.CreateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = model.CreateTime;
            }
            if (model.Year == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Year", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Year", SqlDbType.Int, 0)).Value = model.Year;
            }
            if (model.Month == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Month", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Month", SqlDbType.Int, 0)).Value = model.Month;
            }
            if (model.LogType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_LogType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_LogType", SqlDbType.NVarChar, 50)).Value = model.LogType;
            }
            if (model.IsSuccess == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsSuccess", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsSuccess", SqlDbType.Int, 0)).Value = model.IsSuccess;
            }
            if (model.IsHandle == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsHandle", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsHandle", SqlDbType.Int, 0)).Value = model.IsHandle;
            }


            //输出参数
            SqlParameter returnParam = cmd.Parameters.Add(new SqlParameter("@thisId", SqlDbType.Int));
            returnParam.Direction = ParameterDirection.Output;
            int returnId = -1;

            try
            {
                cmd.ExecuteScalar();
                returnId = Convert.ToInt32(cmd.Parameters["@thisId"].Value);
            }
            catch (Exception e) { throw new Exception(e.ToString()); }

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return returnId;
        } 
        public void Delete(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("DELETE FROM JD_LogMng WHERE ItemID = @m_ItemID", con);
            con.Open();
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

    }
}
