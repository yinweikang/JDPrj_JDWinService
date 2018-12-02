using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using JDWinService.Utils;
using System;
using JDWinService.Model;
using System.Data.SqlClient;

namespace JDWinService.Dal
{
    public class JD_PORequest_DelDal
    {
        Common common = new Common();
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息

        /// <summary>
        /// 更新JD_PORequest_Del对象
        /// 编写人：ywk
        /// 编写日期：2018/9/4 星期二
        /// </summary>
        public void Update(JD_PORequest_Del model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_PORequest_Del SET CreateTime = @m_CreateTime,FBillNo = @m_FBillNo,FInterID = @m_FInterID,FEntryID = @m_FEntryID,IsUpdate = @m_IsUpdate WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.CreateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = model.CreateTime;
            }
            if (model.FBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.NVarChar, 50)).Value = model.FBillNo;
            }
            if (model.FInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInterID", SqlDbType.Int, 0)).Value = model.FInterID;
            }
            if (model.FEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntryID", SqlDbType.Int, 0)).Value = model.FEntryID;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.Int, 0)).Value = model.IsUpdate;
            }
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID;

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        protected void Update(string FInterID)
        {
            string sql = string.Format(@" update JD_PORequest_Del set IsUpdate='1' where FInterID='{0}'", FInterID);
            DBUtil.ExecuteSql(sql);
        }

        //获取已有的FEnterys
        protected string GetFentryIDs( string FInterID)
        {
            string sql = string.Empty;
            string FEnterys = string.Empty;
            if ( !string.IsNullOrEmpty(FInterID))
            {
                sql = string.Format(@" select * from JD_PORequest_Del where FInterID='{0}' and IsUpdate='0'",  FInterID);
                DataView dv = DBUtil.Query(sql).Tables[0].DefaultView;
                if (dv.Count > 0)
                {
                    foreach (DataRowView dr in dv)
                    {
                        FEnterys += "'" + dr["FEntryID"].ToString() + "'" + ",";
                    }
                }
            }
            return FEnterys.TrimEnd(',');
        }

        /// <summary>
        /// 删除在不在请购单中的 请购明细数据
        /// </summary>
        /// <param name="FInterID"></param>
        /// <param name="FEnterys">'1','2'</param>
        protected void DeleteK3PoRequest(string FInterID, string FEnterys)
        {
            
            string sql = string.Format(@"delete from PORequestEntry where FEntryID not in({0}) and FInterID='{1}' ", FEnterys, FInterID);
            DBUtil.ExecuteSql(sql, K3connectionString);
        }

        public DataView GetDistinct()
        {
            string sql = string.Format(@" select distinct FInterID,TaskID from JD_PORequest_Del where IsUpdate='0'");
            return DBUtil.Query(sql).Tables[0].DefaultView;
        }

        /// <summary>
        /// 处理请购单中需要删除的数据
        /// 2018 09 04
        /// </summary>
        /// <param name="FInterID"></param>
        public void HandleDel(string FInterID,string TaskID)
        {
            string ErrorMsg = string.Empty; 
            try
            {
                //获取FEntrys
                string FEntryIDs = GetFentryIDs(FInterID);
                if (!string.IsNullOrEmpty(FEntryIDs))
                {
                    DeleteK3PoRequest(FInterID, FEntryIDs);
                }
                else
                {
                    throw new Exception("FEntryIDs错误：不存在！");
                }
               
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
            }
            finally
            {
                //更新IsUpdate
                Update(FInterID);
                //记录日志
                common.AddLogQueue(Convert.ToInt32(TaskID), "JD_PORequest_Del", 0, "SQL", ErrorMsg);
            }
        }
    }
}
