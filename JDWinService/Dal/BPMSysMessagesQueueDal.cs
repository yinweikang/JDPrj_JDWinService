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
    public class BPMSysMessagesQueueDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        Common common = new Common();

        /// <summary>
		/// 新增BPMSysMessagesQueue对象
		/// 编写人：ywk
		/// 编写日期：2018/10/19 星期五
		/// </summary>
		public int Add(BPMSysMessagesQueue model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO BPMSysMessagesQueue(ProviderName,Address,Title,Message,CreateAt,LastSendAt,FailCount,Attachments,Extra) VALUES(@m_ProviderName,@m_Address,@m_Title,@m_Message,@m_CreateAt,@m_LastSendAt,@m_FailCount,@m_Attachments,@m_Extra) SELECT @thisId=@@IDENTITY FROM BPMSysMessagesQueue", con);
            con.Open();

            if (model.ProviderName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ProviderName", SqlDbType.NVarChar, 30)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ProviderName", SqlDbType.NVarChar, 30)).Value = model.ProviderName;
            }
            if (model.Address == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Address", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Address", SqlDbType.NVarChar, 100)).Value = model.Address;
            }
            if (model.Title == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Title", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Title", SqlDbType.NVarChar, 500)).Value = model.Title;
            }
            if (model.Message == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Message", SqlDbType.NText, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Message", SqlDbType.NText, 0)).Value = model.Message;
            }
            if (model.CreateAt == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateAt", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateAt", SqlDbType.DateTime, 0)).Value = model.CreateAt;
            }
            if (model.LastSendAt == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_LastSendAt", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_LastSendAt", SqlDbType.DateTime, 0)).Value = model.LastSendAt;
            }
            if (model.FailCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FailCount", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FailCount", SqlDbType.Int, 0)).Value = model.FailCount;
            }
            if (model.Attachments == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Attachments", SqlDbType.NText, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Attachments", SqlDbType.NText, 0)).Value = model.Attachments;
            }
            if (model.Extra == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Extra", SqlDbType.NVarChar, 200)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Extra", SqlDbType.NVarChar, 200)).Value = model.Extra;
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
