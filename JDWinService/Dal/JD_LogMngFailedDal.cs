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
    public class JD_LogMngFailedDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        /// <summary>
		/// 对象JD_LogMngFailed明细
		/// 编写人：ywk
		/// 编写日期：2018/8/14 星期二
		/// </summary>
		public JD_LogMngFailed Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_LogMngFailed WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_LogMngFailed myDetail = new JD_LogMngFailed();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["LogQueID"])) { myDetail.LogQueID = Convert.ToInt32(myReader["LogQueID"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["TableItemID"])) { myDetail.TableItemID = Convert.ToInt32(myReader["TableItemID"]); }
                if (!Convert.IsDBNull(myReader["LogTableName"])) { myDetail.LogTableName = Convert.ToString(myReader["LogTableName"]); }
                if (!Convert.IsDBNull(myReader["FileName"])) { myDetail.FileName = Convert.ToString(myReader["FileName"]); }
                if (!Convert.IsDBNull(myReader["Message"])) { myDetail.Message = Convert.ToString(myReader["Message"]); }
                if (!Convert.IsDBNull(myReader["CreateTime"])) { myDetail.CreateTime = Convert.ToDateTime(myReader["CreateTime"]); }
                if (!Convert.IsDBNull(myReader["LogType"])) { myDetail.LogType = Convert.ToString(myReader["LogType"]); }
                if (!Convert.IsDBNull(myReader["SNumber"])) { myDetail.SNumber = Convert.ToString(myReader["SNumber"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }

        /// <summary>
		/// 新增JD_LogMngFailed对象
		/// 编写人：ywk
		/// 编写日期：2018/8/14 星期二
		/// </summary>
		public int Add(JD_LogMngFailed model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO JD_LogMngFailed(LogQueID,TaskID,TableItemID,LogTableName,FileName,Message,CreateTime,LogType,SNumber) VALUES(@m_LogQueID,@m_TaskID,@m_TableItemID,@m_LogTableName,@m_FileName,@m_Message,@m_CreateTime,@m_LogType,@m_SNumber) SELECT @thisId=@@IDENTITY FROM JD_LogMngFailed", con);
            con.Open();

            if (model.LogQueID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_LogQueID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_LogQueID", SqlDbType.Int, 0)).Value = model.LogQueID;
            }
            if (model.TaskID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = model.TaskID;
            }
            if (model.TableItemID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TableItemID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TableItemID", SqlDbType.Int, 0)).Value = model.TableItemID;
            }
            if (model.LogTableName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_LogTableName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_LogTableName", SqlDbType.NVarChar, 50)).Value = model.LogTableName;
            }
            if (model.FileName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FileName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FileName", SqlDbType.NVarChar, 50)).Value = model.FileName;
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
            if (model.LogType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_LogType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_LogType", SqlDbType.NVarChar, 50)).Value = model.LogType;
            }
            if (model.SNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = model.SNumber;
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

    }
}
