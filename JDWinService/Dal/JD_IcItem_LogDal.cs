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
    public class JD_IcItem_LogDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        Common common = new Common();
        /// <summary>
		/// 新增JD_IcItem_Log对象
		/// 编写人：ywk
		/// 编写日期：2018/7/24 星期二
		/// </summary>
		public int Add(JD_IcItem_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO JD_IcItem_Log(FNumber,MOQ,PPQ,PackageInfo,CreateTime) VALUES(@m_FNumber,@m_MOQ,@m_PPQ,@m_PackageInfo,@m_CreateTime) SELECT @thisId=@@IDENTITY FROM JD_IcItem_Log", con);
            con.Open();

            if (model.FNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 100)).Value = model.FNumber;
            }
            if (model.MOQ == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.Decimal, 18)).Value = model.MOQ;
            }
            if (model.PPQ == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PPQ", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PPQ", SqlDbType.Decimal, 18)).Value = model.PPQ;
            }
            if (model.PackageInfo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PackageInfo", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PackageInfo", SqlDbType.NVarChar, 500)).Value = model.PackageInfo;
            }
            if (model.CreateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = model.CreateTime;
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


        public bool IsExist(string FNumber)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM JD_IcItem_Log WHERE FNumber = @m_FNumber", con);
            con.Open();
            cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = FNumber;

            bool b = false;
            try
            {
                int count = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (count > 0) b = true;
            }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return b;
        }
    }
}
