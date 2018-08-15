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
    public class JD_SeorderListBG_LogDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息

        /// <summary>
		/// 对象JD_SeorderListBG_Log明细
		/// 编写人：ywk
		/// 编写日期：2018/6/29 星期五
		/// </summary>
        public JD_SeorderListBG_Log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_SeorderListBG_Log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_SeorderListBG_Log myDetail = new JD_SeorderListBG_Log();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                 
                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0153"])) { myDetail.FEntrySelfS0153 = Convert.ToString(myReader["FEntrySelfS0153"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0177"])) { myDetail.FEntrySelfS0177 = Convert.ToString(myReader["FEntrySelfS0177"]); }
                if (!Convert.IsDBNull(myReader["FNote"])) { myDetail.FNote = Convert.ToString(myReader["FNote"]); }
                if (!Convert.IsDBNull(myReader["FDate"])) { myDetail.FDate = Convert.ToDateTime(myReader["FDate"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0183"])) { myDetail.FEntrySelfS0183 = Convert.ToString(myReader["FEntrySelfS0183"]); }
                if (!Convert.IsDBNull(myReader["FAuxQty"])) { myDetail.FAuxQty = Convert.ToDecimal(myReader["FAuxQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxPrice"])) { myDetail.FAuxPrice = Convert.ToDecimal(myReader["FAuxPrice"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0154"])) { myDetail.FEntrySelfS0154 = Convert.ToDateTime(myReader["FEntrySelfS0154"]); }
                if (!Convert.IsDBNull(myReader["WIP"])) { myDetail.WIP = Convert.ToString(myReader["WIP"]); }
                if (!Convert.IsDBNull(myReader["StockQty"])) { myDetail.StockQty = Convert.ToDecimal(myReader["StockQty"]); }
                if (!Convert.IsDBNull(myReader["IsUpdate"])) { myDetail.IsUpdate = Convert.ToString(myReader["IsUpdate"]); }
                if (!Convert.IsDBNull(myReader["UpdateTime"])) { myDetail.UpdateTime = Convert.ToDateTime(myReader["UpdateTime"]); }
                if (!Convert.IsDBNull(myReader["FInterID"])) { myDetail.FInterID = Convert.ToInt32(myReader["FInterID"]); }
                if (!Convert.IsDBNull(myReader["FEntryID"])) { myDetail.FEntryID = Convert.ToInt32(myReader["FEntryID"]); }
                if (!Convert.IsDBNull(myReader["Requester"])) { myDetail.Requester = Convert.ToString(myReader["Requester"]); }
                if (!Convert.IsDBNull(myReader["IsNew"])) { myDetail.IsNew = Convert.ToInt32(myReader["IsNew"]); }
                if (!Convert.IsDBNull(myReader["FBillNo"])) { myDetail.FBillNo = Convert.ToString(myReader["FBillNo"]); }
                if (!Convert.IsDBNull(myReader["FQL"])) { myDetail.FQL = Convert.ToString(myReader["FQL"]); }
            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        /// <summary>
        /// 新增JD_SeorderListBG_Log对象
        /// 编写人：ywk
        /// 编写日期：2018/6/29 星期五
        /// </summary>
        public int Add(JD_SeorderListBG_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO JD_SeorderListBG_Log(TaskID,FEntrySelfS0153,FEntrySelfS0177,FNote,FDate,FEntrySelfS0183,FAuxQty,FAuxPrice,FEntrySelfS0154,WIP,StockQty,IsUpdate,UpdateTime,FInterID,FEntryID,Requester,IsNew,FBillNo,FQL) VALUES(@m_TaskID,@m_FEntrySelfS0153,@m_FEntrySelfS0177,@m_FNote,@m_FDate,@m_FEntrySelfS0183,@m_FAuxQty,@m_FAuxPrice,@m_FEntrySelfS0154,@m_WIP,@m_StockQty,@m_IsUpdate,@m_UpdateTime,@m_FInterID,@m_FEntryID,@m_Requester,@m_IsNew,@m_FBillNo,@m_FQL) SELECT @thisId=@@IDENTITY FROM JD_SeorderListBG_Log", con);
            con.Open();

            if (model.TaskID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = model.TaskID;
            }
            if (model.FEntrySelfS0153 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0153", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0153", SqlDbType.NVarChar, 50)).Value = model.FEntrySelfS0153;
            }
            if (model.FEntrySelfS0177 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0177", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0177", SqlDbType.NVarChar, 50)).Value = model.FEntrySelfS0177;
            }
            if (model.FNote == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.NVarChar, 500)).Value = model.FNote;
            }
            if (model.FDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = model.FDate;
            }
            if (model.FEntrySelfS0183 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0183", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0183", SqlDbType.NVarChar, 50)).Value = model.FEntrySelfS0183;
            }
            if (model.FAuxQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQty", SqlDbType.Decimal, 18)).Value = model.FAuxQty;
            }
            if (model.FAuxPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 18)).Value = model.FAuxPrice;
            }
            if (model.FEntrySelfS0154 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0154", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0154", SqlDbType.DateTime, 0)).Value = model.FEntrySelfS0154;
            }
            if (model.WIP == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_WIP", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_WIP", SqlDbType.NVarChar, 500)).Value = model.WIP;
            }
            if (model.StockQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_StockQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_StockQty", SqlDbType.Decimal, 18)).Value = model.StockQty;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = model.IsUpdate;
            }
            if (model.UpdateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_UpdateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_UpdateTime", SqlDbType.DateTime, 0)).Value = model.UpdateTime;
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
            if (model.Requester == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Requester", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Requester", SqlDbType.NVarChar, 50)).Value = model.Requester;
            }
            if (model.IsNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsNew", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsNew", SqlDbType.Int, 0)).Value = model.IsNew;
            }
            if (model.FBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.NVarChar, 50)).Value = model.FBillNo;
            }
            if (model.FQL == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQL", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQL", SqlDbType.NVarChar, 50)).Value = model.FQL;
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


        /// <summary>
        /// 更新JD_SeorderListBG_Log对象
        /// 编写人：ywk
        /// 编写日期：2018/6/29 星期五
        /// </summary>
        public void Update(JD_SeorderListBG_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_SeorderListBG_Log SET TaskID = @m_TaskID,FEntrySelfS0153 = @m_FEntrySelfS0153,FEntrySelfS0177 = @m_FEntrySelfS0177,FNote = @m_FNote,FDate = @m_FDate,FEntrySelfS0183 = @m_FEntrySelfS0183,FAuxQty = @m_FAuxQty,FAuxPrice = @m_FAuxPrice,FEntrySelfS0154 = @m_FEntrySelfS0154,WIP = @m_WIP,StockQty = @m_StockQty,IsUpdate = @m_IsUpdate,UpdateTime = @m_UpdateTime,FInterID = @m_FInterID,FEntryID = @m_FEntryID,Requester = @m_Requester,IsNew = @m_IsNew,FBillNo = @m_FBillNo,FQL = @m_FQL WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.TaskID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = model.TaskID;
            }
            if (model.FEntrySelfS0153 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0153", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0153", SqlDbType.NVarChar, 50)).Value = model.FEntrySelfS0153;
            }
            if (model.FEntrySelfS0177 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0177", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0177", SqlDbType.NVarChar, 50)).Value = model.FEntrySelfS0177;
            }
            if (model.FNote == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.NVarChar, 500)).Value = model.FNote;
            }
            if (model.FDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = model.FDate;
            }
            if (model.FEntrySelfS0183 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0183", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0183", SqlDbType.NVarChar, 50)).Value = model.FEntrySelfS0183;
            }
            if (model.FAuxQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQty", SqlDbType.Decimal, 18)).Value = model.FAuxQty;
            }
            if (model.FAuxPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 18)).Value = model.FAuxPrice;
            }
            if (model.FEntrySelfS0154 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0154", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0154", SqlDbType.DateTime, 0)).Value = model.FEntrySelfS0154;
            }
            if (model.WIP == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_WIP", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_WIP", SqlDbType.NVarChar, 500)).Value = model.WIP;
            }
            if (model.StockQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_StockQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_StockQty", SqlDbType.Decimal, 18)).Value = model.StockQty;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = model.IsUpdate;
            }
            if (model.UpdateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_UpdateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_UpdateTime", SqlDbType.DateTime, 0)).Value = model.UpdateTime;
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
            if (model.Requester == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Requester", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Requester", SqlDbType.NVarChar, 50)).Value = model.Requester;
            }
            if (model.IsNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsNew", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsNew", SqlDbType.Int, 0)).Value = model.IsNew;
            }
            if (model.FBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.NVarChar, 50)).Value = model.FBillNo;
            }
            if (model.FQL == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQL", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQL", SqlDbType.NVarChar, 50)).Value = model.FQL;
            }
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID;

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

       
        public DataView GetUpdateList() {
            string sql = string.Format(@" select * from JD_SeorderListBG_Log where IsUpdate='0'");
            return DBUtil.Query(sql).Tables[0].DefaultView; 
        }


        /// <summary>
        /// 是否已经存在SEOrderEntry对象
        /// 编写人：ywk
        /// 编写日期：2018/7/2 星期一
        /// </summary>
        /// <summary>
        /// 是否已经存在SEOrderEntry对象
        /// 编写人：ywk
        /// 编写日期：2018/7/2 星期一
        /// </summary>
        public bool IsExist(int FInterID, int FEntryID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM JD_SeorderListBG_Log WHERE FInterID = @m_FInterID and FEntryID=@m_FEntryID", con);
            con.Open();
            cmd.Parameters.Add(new SqlParameter("@m_FInterID", SqlDbType.Int, 0)).Value = FInterID;
            cmd.Parameters.Add(new SqlParameter("@m_FEntryID", SqlDbType.Int, 0)).Value = FEntryID;
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

        public int GetCount(int FInterID, int FEntryID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM JD_SeorderListBG_Log WHERE FInterID = @m_FInterID and FEntryID=@m_FEntryID", con);
            con.Open();
            cmd.Parameters.Add(new SqlParameter("@m_FInterID", SqlDbType.Int, 0)).Value = FInterID;
            cmd.Parameters.Add(new SqlParameter("@m_FEntryID", SqlDbType.Int, 0)).Value = FEntryID;
            int count = 0;
            try
            {
                  count = Int32.Parse(cmd.ExecuteScalar().ToString());
               
            }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return count;
        }
    }
}
