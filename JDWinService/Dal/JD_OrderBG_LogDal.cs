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
    public class JD_OrderBG_LogDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        /// <summary>
		/// 对象JD_OrderBG_Log明细
		/// 编写人：ywk
		/// 编写日期：2018/7/9 星期一
		/// </summary>
		public JD_OrderBG_Log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_OrderBG_Log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_OrderBG_Log myDetail = new JD_OrderBG_Log();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["Operater"])) { myDetail.Operater = Convert.ToString(myReader["Operater"]); }
                if (!Convert.IsDBNull(myReader["OperaterID"])) { myDetail.OperaterID = Convert.ToString(myReader["OperaterID"]); }
                if (!Convert.IsDBNull(myReader["OperaterDate"])) { myDetail.OperaterDate = Convert.ToDateTime(myReader["OperaterDate"]); }
                if (!Convert.IsDBNull(myReader["IsUpdate"])) { myDetail.IsUpdate = Convert.ToString(myReader["IsUpdate"]); }
                if (!Convert.IsDBNull(myReader["UpdateTime"])) { myDetail.UpdateTime = Convert.ToDateTime(myReader["UpdateTime"]); }
                if (!Convert.IsDBNull(myReader["FInterID"])) { myDetail.FInterID = Convert.ToInt32(myReader["FInterID"]); }
                if (!Convert.IsDBNull(myReader["FEntryID"])) { myDetail.FEntryID = Convert.ToInt32(myReader["FEntryID"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0267"])) { myDetail.FEntrySelfP0267 = Convert.ToDateTime(myReader["FEntrySelfP0267"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0268"])) { myDetail.FEntrySelfP0268 = Convert.ToDateTime(myReader["FEntrySelfP0268"]); }
                if (!Convert.IsDBNull(myReader["SupplierName"])) { myDetail.SupplierName = Convert.ToString(myReader["SupplierName"]); }
                if (!Convert.IsDBNull(myReader["PONum"])) { myDetail.PONum = Convert.ToString(myReader["PONum"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        /// <summary>
		/// 更新JD_OrderBG_Log对象
		/// 编写人：ywk
		/// 编写日期：2018/7/9 星期一
		/// </summary>
		public void Update(JD_OrderBG_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_OrderBG_Log SET Operater = @m_Operater,OperaterID = @m_OperaterID,OperaterDate = @m_OperaterDate,IsUpdate = @m_IsUpdate,UpdateTime = @m_UpdateTime,FInterID = @m_FInterID,FEntryID = @m_FEntryID,FEntrySelfP0267 = @m_FEntrySelfP0267,FEntrySelfP0268 = @m_FEntrySelfP0268,SupplierName = @m_SupplierName,PONum = @m_PONum WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.Operater == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = model.Operater;
            }
            if (model.OperaterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_OperaterID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_OperaterID", SqlDbType.NVarChar, 50)).Value = model.OperaterID;
            }
            if (model.OperaterDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_OperaterDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_OperaterDate", SqlDbType.DateTime, 0)).Value = model.OperaterDate;
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
            if (model.FEntrySelfP0267==null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0267", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0267", SqlDbType.DateTime, 0)).Value = model.FEntrySelfP0267;
            }
            if (model.FEntrySelfP0268 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0268", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0268", SqlDbType.DateTime, 0)).Value = model.FEntrySelfP0268;
            }
            if (model.SupplierName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierName", SqlDbType.NVarChar, 100)).Value = model.SupplierName;
            }
            if (model.PONum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PONum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PONum", SqlDbType.NVarChar, 100)).Value = model.PONum;
            }
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID;

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }



    }
}
