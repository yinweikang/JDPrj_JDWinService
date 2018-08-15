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
    public class JD_SePriceApply_LogDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        Common common = new Common();
        public JD_SePriceApply_Log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_SePriceApply_Log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_SePriceApply_Log myDetail = new JD_SePriceApply_Log();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["ParentID"])) { myDetail.ParentID = Convert.ToInt32(myReader["ParentID"]); }
                if (!Convert.IsDBNull(myReader["Operater"])) { myDetail.Operater = Convert.ToString(myReader["Operater"]); }
                if (!Convert.IsDBNull(myReader["CreateTime"])) { myDetail.CreateTime = Convert.ToDateTime(myReader["CreateTime"]); }
                if (!Convert.IsDBNull(myReader["IsUpdate"])) { myDetail.IsUpdate = Convert.ToString(myReader["IsUpdate"]); }
                if (!Convert.IsDBNull(myReader["ShortName"])) { myDetail.ShortName = Convert.ToString(myReader["ShortName"]); }
                if (!Convert.IsDBNull(myReader["CustomCode"])) { myDetail.CustomCode = Convert.ToString(myReader["CustomCode"]); }
                if (!Convert.IsDBNull(myReader["CustomName"])) { myDetail.CustomName = Convert.ToString(myReader["CustomName"]); }
                if (!Convert.IsDBNull(myReader["FNumber"])) { myDetail.FNumber = Convert.ToString(myReader["FNumber"]); }
                if (!Convert.IsDBNull(myReader["FModel"])) { myDetail.FModel = Convert.ToString(myReader["FModel"]); }
                if (!Convert.IsDBNull(myReader["CoinType"])) { myDetail.CoinType = Convert.ToString(myReader["CoinType"]); }
                if (!Convert.IsDBNull(myReader["BeginSalesCount"])) { myDetail.BeginSalesCount = Convert.ToDecimal(myReader["BeginSalesCount"]); }
                if (!Convert.IsDBNull(myReader["EndSalesCount"])) { myDetail.EndSalesCount = Convert.ToDecimal(myReader["EndSalesCount"]); }
                if (!Convert.IsDBNull(myReader["Price"])) { myDetail.Price = Convert.ToDecimal(myReader["Price"]); }
                if (!Convert.IsDBNull(myReader["BeginTime"])) { myDetail.BeginTime = Convert.ToDateTime(myReader["BeginTime"]); }
                if (!Convert.IsDBNull(myReader["EndTime"])) { myDetail.EndTime = Convert.ToDateTime(myReader["EndTime"]); }
                if (!Convert.IsDBNull(myReader["IsNew"])) { myDetail.IsNew = Convert.ToString(myReader["IsNew"]); }
                if (!Convert.IsDBNull(myReader["MOQ"])) { myDetail.MOQ = Convert.ToDecimal(myReader["MOQ"]); }
                if (!Convert.IsDBNull(myReader["LimitTimes"])) { myDetail.LimitTimes = Convert.ToString(myReader["LimitTimes"]); }
                if (!Convert.IsDBNull(myReader["CaiWuRemarks"])) { myDetail.CaiWuRemarks = Convert.ToString(myReader["CaiWuRemarks"]); }
                if (!Convert.IsDBNull(myReader["PlanRemarks"])) { myDetail.PlanRemarks = Convert.ToString(myReader["PlanRemarks"]); }
                if (!Convert.IsDBNull(myReader["ApplyType"])) { myDetail.ApplyType = Convert.ToString(myReader["ApplyType"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        /// <summary>
        /// 新增JD_SePriceApply_Log对象
        /// 编写人：ywk
        /// 编写日期：2018/7/26 星期四
        /// </summary>
        public int Add(JD_SePriceApply_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO JD_SePriceApply_Log(ParentID,Operater,CreateTime,IsUpdate,ShortName,CustomCode,CustomName,FNumber,FModel,CoinType,BeginSalesCount,EndSalesCount,Price,BeginTime,EndTime,IsNew,MOQ,LimitTimes,CaiWuRemarks,PlanRemarks,ApplyType,TaskID) VALUES(@m_ParentID,@m_Operater,@m_CreateTime,@m_IsUpdate,@m_ShortName,@m_CustomCode,@m_CustomName,@m_FNumber,@m_FModel,@m_CoinType,@m_BeginSalesCount,@m_EndSalesCount,@m_Price,@m_BeginTime,@m_EndTime,@m_IsNew,@m_MOQ,@m_LimitTimes,@m_CaiWuRemarks,@m_PlanRemarks,@m_ApplyType,@m_TaskID) SELECT @thisId=@@IDENTITY FROM JD_SePriceApply_Log", con);
            con.Open();

            if (model.ParentID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ParentID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ParentID", SqlDbType.Int, 0)).Value = model.ParentID;
            }
            if (model.Operater == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = model.Operater;
            }
            if (model.CreateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = model.CreateTime;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = model.IsUpdate;
            }
            if (model.ShortName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShortName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShortName", SqlDbType.NVarChar, 50)).Value = model.ShortName;
            }
            if (model.CustomCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomCode", SqlDbType.NVarChar, 50)).Value = model.CustomCode;
            }
            if (model.CustomName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomName", SqlDbType.NVarChar, 100)).Value = model.CustomName;
            }
            if (model.FNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 100)).Value = model.FNumber;
            }
            if (model.FModel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = model.FModel;
            }
            if (model.CoinType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinType", SqlDbType.NVarChar, 50)).Value = model.CoinType;
            }
            if (model.BeginSalesCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginSalesCount", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginSalesCount", SqlDbType.Decimal, 18)).Value = model.BeginSalesCount;
            }
            if (model.EndSalesCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndSalesCount", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndSalesCount", SqlDbType.Decimal, 18)).Value = model.EndSalesCount;
            }
            if (model.Price == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Price", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Price", SqlDbType.Decimal, 18)).Value = model.Price;
            }
            if (model.BeginTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginTime", SqlDbType.DateTime, 0)).Value = model.BeginTime;
            }
            if (model.EndTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndTime", SqlDbType.DateTime, 0)).Value = model.EndTime;
            }
            if (model.IsNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsNew", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsNew", SqlDbType.NVarChar, 50)).Value = model.IsNew;
            }
            if (model.MOQ == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.Decimal, 18)).Value = model.MOQ;
            }
            if (model.LimitTimes == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_LimitTimes", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_LimitTimes", SqlDbType.NVarChar, 50)).Value = model.LimitTimes;
            }
            if (model.CaiWuRemarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CaiWuRemarks", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CaiWuRemarks", SqlDbType.NVarChar, 100)).Value = model.CaiWuRemarks;
            }
            if (model.PlanRemarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanRemarks", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanRemarks", SqlDbType.NVarChar, 100)).Value = model.PlanRemarks;
            }
            if (model.ApplyType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyType", SqlDbType.NVarChar, 50)).Value = model.ApplyType;
            }
            if (model.TaskID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = model.TaskID;
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
        /// 更新JD_SePriceApply_Log对象
        /// 编写人：ywk
        /// 编写日期：2018/7/26 星期四
        /// </summary>
        public void Update(JD_SePriceApply_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_SePriceApply_Log SET ParentID = @m_ParentID,Operater = @m_Operater,CreateTime = @m_CreateTime,IsUpdate = @m_IsUpdate,ShortName = @m_ShortName,CustomCode = @m_CustomCode,CustomName = @m_CustomName,FNumber = @m_FNumber,FModel = @m_FModel,CoinType = @m_CoinType,BeginSalesCount = @m_BeginSalesCount,EndSalesCount = @m_EndSalesCount,Price = @m_Price,BeginTime = @m_BeginTime,EndTime = @m_EndTime,IsNew = @m_IsNew,MOQ = @m_MOQ,LimitTimes = @m_LimitTimes,CaiWuRemarks = @m_CaiWuRemarks,PlanRemarks = @m_PlanRemarks,ApplyType = @m_ApplyType,TaskID = @m_TaskID WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.ParentID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ParentID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ParentID", SqlDbType.Int, 0)).Value = model.ParentID;
            }
            if (model.Operater == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = model.Operater;
            }
            if (model.CreateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = model.CreateTime;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = model.IsUpdate;
            }
            if (model.ShortName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShortName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShortName", SqlDbType.NVarChar, 50)).Value = model.ShortName;
            }
            if (model.CustomCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomCode", SqlDbType.NVarChar, 50)).Value = model.CustomCode;
            }
            if (model.CustomName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomName", SqlDbType.NVarChar, 100)).Value = model.CustomName;
            }
            if (model.FNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 100)).Value = model.FNumber;
            }
            if (model.FModel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = model.FModel;
            }
            if (model.CoinType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinType", SqlDbType.NVarChar, 50)).Value = model.CoinType;
            }
            if (model.BeginSalesCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginSalesCount", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginSalesCount", SqlDbType.Decimal, 18)).Value = model.BeginSalesCount;
            }
            if (model.EndSalesCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndSalesCount", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndSalesCount", SqlDbType.Decimal, 18)).Value = model.EndSalesCount;
            }
            if (model.Price == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Price", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Price", SqlDbType.Decimal, 18)).Value = model.Price;
            }
            if (model.BeginTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginTime", SqlDbType.DateTime, 0)).Value = model.BeginTime;
            }
            if (model.EndTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndTime", SqlDbType.DateTime, 0)).Value = model.EndTime;
            }
            if (model.IsNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsNew", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsNew", SqlDbType.NVarChar, 50)).Value = model.IsNew;
            }
            if (model.MOQ == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.Decimal, 18)).Value = model.MOQ;
            }
            if (model.LimitTimes == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_LimitTimes", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_LimitTimes", SqlDbType.NVarChar, 50)).Value = model.LimitTimes;
            }
            if (model.CaiWuRemarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CaiWuRemarks", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CaiWuRemarks", SqlDbType.NVarChar, 100)).Value = model.CaiWuRemarks;
            }
            if (model.PlanRemarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanRemarks", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanRemarks", SqlDbType.NVarChar, 100)).Value = model.PlanRemarks;
            }
            if (model.ApplyType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyType", SqlDbType.NVarChar, 50)).Value = model.ApplyType;
            }
            if (model.TaskID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = model.TaskID;
            }
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID;


            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }


        public DataView GetDistinctList()
        {
            string sql = string.Format(@" select  * from JD_SePriceApply_Log where IsUpdate='0'");
            return DBUtil.Query(sql).Tables[0].DefaultView;
        }
    }
}
