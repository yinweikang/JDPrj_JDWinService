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
    public  class JD_LimitPriceApply_LogDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        /// <summary>
		/// 对象JD_LimitPriceApply_Log明细
		/// 编写人：ywk
		/// 编写日期：2018/7/20 星期五
		/// </summary>
		public JD_LimitPriceApply_Log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_LimitPriceApply_Log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_LimitPriceApply_Log myDetail = new JD_LimitPriceApply_Log();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {


                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["CreateTime"])) { myDetail.CreateTime = Convert.ToDateTime(myReader["CreateTime"]); }
                if (!Convert.IsDBNull(myReader["UpdateTime"])) { myDetail.UpdateTime = Convert.ToDateTime(myReader["UpdateTime"]); }
                if (!Convert.IsDBNull(myReader["IsUpdate"])) { myDetail.IsUpdate = Convert.ToString(myReader["IsUpdate"]); }
                if (!Convert.IsDBNull(myReader["Operater"])) { myDetail.Operater = Convert.ToString(myReader["Operater"]); }
                if (!Convert.IsDBNull(myReader["SupplierName"])) { myDetail.SupplierName = Convert.ToString(myReader["SupplierName"]); }
                if (!Convert.IsDBNull(myReader["SupplierCode"])) { myDetail.SupplierCode = Convert.ToString(myReader["SupplierCode"]); }
                if (!Convert.IsDBNull(myReader["BeginCuPrice"])) { myDetail.BeginCuPrice = Convert.ToDecimal(myReader["BeginCuPrice"]); }
                if (!Convert.IsDBNull(myReader["EndCuPrice"])) { myDetail.EndCuPrice = Convert.ToDecimal(myReader["EndCuPrice"]); }
                if (!Convert.IsDBNull(myReader["ItemName"])) { myDetail.ItemName = Convert.ToString(myReader["ItemName"]); }
                if (!Convert.IsDBNull(myReader["ItemCode"])) { myDetail.ItemCode = Convert.ToString(myReader["ItemCode"]); }
                if (!Convert.IsDBNull(myReader["FromCount"])) { myDetail.FromCount = Convert.ToInt32(myReader["FromCount"]); }
                if (!Convert.IsDBNull(myReader["EndCount"])) { myDetail.EndCount = Convert.ToInt32(myReader["EndCount"]); }
                if (!Convert.IsDBNull(myReader["Price"])) { myDetail.Price = Convert.ToDecimal(myReader["Price"]); }
                if (!Convert.IsDBNull(myReader["FModel"])) { myDetail.FModel = Convert.ToString(myReader["FModel"]); }
                if (!Convert.IsDBNull(myReader["FUnit"])) { myDetail.FUnit = Convert.ToString(myReader["FUnit"]); }
                if (!Convert.IsDBNull(myReader["CoinType"])) { myDetail.CoinType = Convert.ToString(myReader["CoinType"]); }
                if (!Convert.IsDBNull(myReader["MOQ"])) { myDetail.MOQ = Convert.ToString(myReader["MOQ"]); }
                if (!Convert.IsDBNull(myReader["PPQ"])) { myDetail.PPQ = Convert.ToString(myReader["PPQ"]); }
                if (!Convert.IsDBNull(myReader["LimitTimes"])) { myDetail.LimitTimes = Convert.ToString(myReader["LimitTimes"]); }
                if (!Convert.IsDBNull(myReader["ApplyType"])) { myDetail.ApplyType = Convert.ToString(myReader["ApplyType"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["PackageInfo"])) { myDetail.PackageInfo = Convert.ToString(myReader["PackageInfo"]); }
                if (!Convert.IsDBNull(myReader["CostPrice"])) { myDetail.CostPrice = Convert.ToDecimal(myReader["CostPrice"]); }
                if (!Convert.IsDBNull(myReader["CostCoinType"])) { myDetail.CostCoinType = Convert.ToString(myReader["CostCoinType"]); }
                if (!Convert.IsDBNull(myReader["ParentID"])) { myDetail.ParentID = Convert.ToInt32(myReader["ParentID"]); }
            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        /// <summary>
        /// 新增JD_LimitPriceApply_Log对象
        /// 编写人：ywk
        /// 编写日期：2018/7/20 星期五
        /// </summary>
        public int Add(JD_LimitPriceApply_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO JD_LimitPriceApply_Log(CreateTime,UpdateTime,IsUpdate,Operater,SupplierName,SupplierCode,BeginCuPrice,EndCuPrice,ItemName,ItemCode,FromCount,EndCount,Price,FModel,FUnit,CoinType,MOQ,PPQ,LimitTimes,ApplyType,TaskID,PackageInfo,CostPrice,CostCoinType,ParentID) VALUES(@m_CreateTime,@m_UpdateTime,@m_IsUpdate,@m_Operater,@m_SupplierName,@m_SupplierCode,@m_BeginCuPrice,@m_EndCuPrice,@m_ItemName,@m_ItemCode,@m_FromCount,@m_EndCount,@m_Price,@m_FModel,@m_FUnit,@m_CoinType,@m_MOQ,@m_PPQ,@m_LimitTimes,@m_ApplyType,@m_TaskID,@m_PackageInfo,@m_CostPrice,@m_CostCoinType,@m_ParentID) SELECT @thisId=@@IDENTITY FROM JD_LimitPriceApply_Log", con);
            con.Open();

            if (model.CreateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = model.CreateTime;
            }
            if (model.UpdateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_UpdateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_UpdateTime", SqlDbType.DateTime, 0)).Value = model.UpdateTime;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = model.IsUpdate;
            }
            if (model.Operater == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = model.Operater;
            }
            if (model.SupplierName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierName", SqlDbType.NVarChar, 100)).Value = model.SupplierName;
            }
            if (model.SupplierCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierCode", SqlDbType.NVarChar, 50)).Value = model.SupplierCode;
            }
            if (model.BeginCuPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginCuPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginCuPrice", SqlDbType.Decimal, 18)).Value = model.BeginCuPrice;
            }
            if (model.EndCuPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndCuPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndCuPrice", SqlDbType.Decimal, 18)).Value = model.EndCuPrice;
            }
            if (model.ItemName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ItemName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ItemName", SqlDbType.NVarChar, 50)).Value = model.ItemName;
            }
            if (model.ItemCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ItemCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ItemCode", SqlDbType.NVarChar, 50)).Value = model.ItemCode;
            }
            if (model.FromCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FromCount", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FromCount", SqlDbType.Int, 0)).Value = model.FromCount;
            }
            if (model.EndCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndCount", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndCount", SqlDbType.Int, 0)).Value = model.EndCount;
            }
            if (model.Price == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Price", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Price", SqlDbType.Decimal, 18)).Value = model.Price;
            }
            if (model.FModel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = model.FModel;
            }
            if (model.FUnit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnit", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnit", SqlDbType.NVarChar, 50)).Value = model.FUnit;
            }
            if (model.CoinType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinType", SqlDbType.NVarChar, 50)).Value = model.CoinType;
            }
            if (model.MOQ == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.NVarChar, 50)).Value = model.MOQ;
            }
            if (model.PPQ == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PPQ", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PPQ", SqlDbType.NVarChar, 50)).Value = model.PPQ;
            }
            if (model.LimitTimes == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_LimitTimes", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_LimitTimes", SqlDbType.NVarChar, 50)).Value = model.LimitTimes;
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
            if (model.PackageInfo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PackageInfo", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PackageInfo", SqlDbType.NVarChar, 500)).Value = model.PackageInfo;
            }
            if (model.CostPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CostPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CostPrice", SqlDbType.Decimal, 18)).Value = model.CostPrice;
            }
            if (model.CostCoinType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CostCoinType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CostCoinType", SqlDbType.NVarChar, 50)).Value = model.CostCoinType;
            }
            if (model.ParentID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ParentID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ParentID", SqlDbType.Int, 0)).Value = model.ParentID;
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
        /// 更新JD_LimitPriceApply_Log对象
        /// 编写人：ywk
        /// 编写日期：2018/7/20 星期五
        /// </summary>
        public void Update(JD_LimitPriceApply_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_LimitPriceApply_Log SET CreateTime = @m_CreateTime,UpdateTime = @m_UpdateTime,IsUpdate = @m_IsUpdate,Operater = @m_Operater,SupplierName = @m_SupplierName,SupplierCode = @m_SupplierCode,BeginCuPrice = @m_BeginCuPrice,EndCuPrice = @m_EndCuPrice,ItemName = @m_ItemName,ItemCode = @m_ItemCode,FromCount = @m_FromCount,EndCount = @m_EndCount,Price = @m_Price,FModel = @m_FModel,FUnit = @m_FUnit,CoinType = @m_CoinType,MOQ = @m_MOQ,PPQ = @m_PPQ,LimitTimes = @m_LimitTimes,ApplyType = @m_ApplyType,TaskID = @m_TaskID,PackageInfo = @m_PackageInfo,CostPrice = @m_CostPrice,CostCoinType = @m_CostCoinType,ParentID = @m_ParentID WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.CreateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = model.CreateTime;
            }
            if (model.UpdateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_UpdateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_UpdateTime", SqlDbType.DateTime, 0)).Value = model.UpdateTime;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = model.IsUpdate;
            }
            if (model.Operater == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = model.Operater;
            }
            if (model.SupplierName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierName", SqlDbType.NVarChar, 100)).Value = model.SupplierName;
            }
            if (model.SupplierCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierCode", SqlDbType.NVarChar, 50)).Value = model.SupplierCode;
            }
            if (model.BeginCuPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginCuPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginCuPrice", SqlDbType.Decimal, 18)).Value = model.BeginCuPrice;
            }
            if (model.EndCuPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndCuPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndCuPrice", SqlDbType.Decimal, 18)).Value = model.EndCuPrice;
            }
            if (model.ItemName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ItemName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ItemName", SqlDbType.NVarChar, 50)).Value = model.ItemName;
            }
            if (model.ItemCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ItemCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ItemCode", SqlDbType.NVarChar, 50)).Value = model.ItemCode;
            }
            if (model.FromCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FromCount", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FromCount", SqlDbType.Int, 0)).Value = model.FromCount;
            }
            if (model.EndCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndCount", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndCount", SqlDbType.Int, 0)).Value = model.EndCount;
            }
            if (model.Price == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Price", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Price", SqlDbType.Decimal, 18)).Value = model.Price;
            }
            if (model.FModel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = model.FModel;
            }
            if (model.FUnit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnit", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnit", SqlDbType.NVarChar, 50)).Value = model.FUnit;
            }
            if (model.CoinType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinType", SqlDbType.NVarChar, 50)).Value = model.CoinType;
            }
            if (model.MOQ == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.NVarChar, 50)).Value = model.MOQ;
            }
            if (model.PPQ == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PPQ", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PPQ", SqlDbType.NVarChar, 50)).Value = model.PPQ;
            }
            if (model.LimitTimes == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_LimitTimes", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_LimitTimes", SqlDbType.NVarChar, 50)).Value = model.LimitTimes;
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
            if (model.PackageInfo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PackageInfo", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PackageInfo", SqlDbType.NVarChar, 500)).Value = model.PackageInfo;
            }
            if (model.CostPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CostPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CostPrice", SqlDbType.Decimal, 18)).Value = model.CostPrice;
            }
            if (model.CostCoinType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CostCoinType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CostCoinType", SqlDbType.NVarChar, 50)).Value = model.CostCoinType;
            }
            if (model.ParentID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ParentID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ParentID", SqlDbType.Int, 0)).Value = model.ParentID;
            }
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID;

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }


        /// <summary>
        /// 获取待更新的数据
        /// </summary>
        /// <returns></returns>
        public DataView GetDistinctList()
        {
            string sql = string.Format(@" select  * from JD_LimitPriceApply_Log where IsUpdate='0'");
            return DBUtil.Query(sql).Tables[0].DefaultView;
        }
    }
}
