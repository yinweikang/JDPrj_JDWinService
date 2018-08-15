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
    public class JD_SeorderBG_LogDal
    {

        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        /// <summary>
		/// 对象JD_SeorderBG_Log明细
		/// 编写人：ywk
		/// 编写日期：2018/6/21 星期四
		/// </summary>
		public JD_SeorderBG_Log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_SeorderBG_Log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_SeorderBG_Log myDetail = new JD_SeorderBG_Log();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["FInterID"])) { myDetail.FInterID = Convert.ToInt32(myReader["FInterID"]); }
                if (!Convert.IsDBNull(myReader["FEntryID"])) { myDetail.FEntryID = Convert.ToInt32(myReader["FEntryID"]); }
                if (!Convert.IsDBNull(myReader["FBillNo"])) { myDetail.FBillNo = Convert.ToString(myReader["FBillNo"]); }
                if (!Convert.IsDBNull(myReader["FCustID"])) { myDetail.FCustID = Convert.ToString(myReader["FCustID"]); }
                if (!Convert.IsDBNull(myReader["FDate"])) { myDetail.FDate = Convert.ToDateTime(myReader["FDate"]); }
                if (!Convert.IsDBNull(myReader["Operater"])) { myDetail.Operater = Convert.ToString(myReader["Operater"]); }
                if (!Convert.IsDBNull(myReader["OperaterID"])) { myDetail.OperaterID = Convert.ToString(myReader["OperaterID"]); }
                if (!Convert.IsDBNull(myReader["OperateDate"])) { myDetail.OperateDate = Convert.ToDateTime(myReader["OperateDate"]); }
                if (!Convert.IsDBNull(myReader["IsUpdate"])) { myDetail.IsUpdate = Convert.ToString(myReader["IsUpdate"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0155"])) { myDetail.FEntrySelfS0155 = Convert.ToDateTime(myReader["FEntrySelfS0155"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0154"])) { myDetail.FEntrySelfS0154 = Convert.ToDateTime(myReader["FEntrySelfS0154"]); }
                if (!Convert.IsDBNull(myReader["FQTDate"])) { myDetail.FQTDate = Convert.ToDateTime(myReader["FQTDate"]); }
                if (!Convert.IsDBNull(myReader["FQueLiao"])) { myDetail.FQueLiao = Convert.ToString(myReader["FQueLiao"]); }
                if (!Convert.IsDBNull(myReader["FNote"])) { myDetail.FNote = Convert.ToString(myReader["FNote"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0183"])) { myDetail.FEntrySelfS0183 = Convert.ToString(myReader["FEntrySelfS0183"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0184"])) { myDetail.FEntrySelfS0184 = Convert.ToString(myReader["FEntrySelfS0184"]); }
            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }
        public void Update(JD_SeorderBG_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_SeorderBG_Log SET FInterID = @m_FInterID,FEntryID = @m_FEntryID,FBillNo = @m_FBillNo,FCustID = @m_FCustID,FDate = @m_FDate,Operater = @m_Operater,OperaterID = @m_OperaterID,OperateDate = @m_OperateDate,IsUpdate = @m_IsUpdate WHERE ItemID = @m_ItemID", con);
            con.Open();

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
            if (model.FBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.NVarChar, 50)).Value = model.FBillNo;
            }
            if (model.FCustID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCustID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCustID", SqlDbType.NVarChar, 50)).Value = model.FCustID;
            }
            if (model.FDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = model.FDate;
            }
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
            if (model.OperateDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_OperateDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_OperateDate", SqlDbType.DateTime, 0)).Value = model.OperateDate;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = model.IsUpdate;
            }
            if (model.FEntrySelfS0155 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0155", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0155", SqlDbType.DateTime, 0)).Value = model.FEntrySelfS0155;
            }
            if (model.FEntrySelfS0154 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0154", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0154", SqlDbType.DateTime, 0)).Value = model.FEntrySelfS0154;
            }

            if (model.FQTDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQTDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQTDate", SqlDbType.DateTime, 0)).Value = model.FQTDate;
            }

            if (model.FQueLiao == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQueLiao", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQueLiao", SqlDbType.NVarChar, 50)).Value = model.FQueLiao;
            }

            if (model.FNote == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.NVarChar, 50)).Value = model.FNote;
            }

            if (model.FEntrySelfS0183 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0183", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0183", SqlDbType.NVarChar, 100)).Value = model.FEntrySelfS0183;
            }

            if (model.FEntrySelfS0184== null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0184", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0184", SqlDbType.NVarChar, 100)).Value = model.FEntrySelfS0184;
            }
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID;

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        public void UpdateStatus(int ItemID) {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_SeorderBG_Log SET IsUpdate='1' WHERE ItemID = @m_ItemID", con);
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
