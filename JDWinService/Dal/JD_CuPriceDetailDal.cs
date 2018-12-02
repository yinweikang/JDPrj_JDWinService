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
    public class JD_CuPriceDetailDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        Common common = new Common();
        public bool IsExist(string SupplierCode, string ItemCode, decimal BeginCuPrice, decimal EndCuPrice, int FromCount, int EndCount)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM JD_CuPriceDetail WHERE SupplierCode = @m_SupplierCode and ItemCode=@m_ItemCode and BeginCuPrice=@m_BeginCuPrice  and EndCuPrice=@m_EndCuPrice and FromCount=@m_FromCount and EndCount=@m_EndCount", con);
            con.Open();
            cmd.Parameters.Add(new SqlParameter("@m_SupplierCode", SqlDbType.VarChar, 50)).Value = SupplierCode;
            cmd.Parameters.Add(new SqlParameter("@m_ItemCode", SqlDbType.VarChar, 50)).Value = ItemCode;
            cmd.Parameters.Add(new SqlParameter("@m_BeginCuPrice", SqlDbType.Decimal, 18)).Value = BeginCuPrice;
            cmd.Parameters.Add(new SqlParameter("@m_EndCuPrice", SqlDbType.Decimal, 18)).Value = EndCuPrice;
            cmd.Parameters.Add(new SqlParameter("@m_FromCount", SqlDbType.Int, 0)).Value = FromCount;
            cmd.Parameters.Add(new SqlParameter("@m_EndCount", SqlDbType.Int, 0)).Value = EndCount;
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

        public JD_CuPriceDetail Detail(string SupplierCode, string ItemCode, decimal BeginCuPrice, decimal EndCuPrice, int FromCount, int EndCount)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_CuPriceDetail  WHERE SupplierCode = @m_SupplierCode and ItemCode=@m_ItemCode and BeginCuPrice=@m_BeginCuPrice  and EndCuPrice=@m_EndCuPrice and FromCount=@m_FromCount and EndCount=@m_EndCount", con);
            con.Open();

            cmd.Parameters.Add(new SqlParameter("@m_SupplierCode", SqlDbType.VarChar, 50)).Value = SupplierCode;
            cmd.Parameters.Add(new SqlParameter("@m_ItemCode", SqlDbType.VarChar, 50)).Value = ItemCode;
            cmd.Parameters.Add(new SqlParameter("@m_BeginCuPrice", SqlDbType.Decimal, 18)).Value = BeginCuPrice;
            cmd.Parameters.Add(new SqlParameter("@m_EndCuPrice", SqlDbType.Decimal, 18)).Value = EndCuPrice;
            cmd.Parameters.Add(new SqlParameter("@m_FromCount", SqlDbType.Int, 0)).Value = FromCount;
            cmd.Parameters.Add(new SqlParameter("@m_EndCount", SqlDbType.Int, 0)).Value = EndCount;
            JD_CuPriceDetail myDetail = new JD_CuPriceDetail();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["CreateTime"])) { myDetail.CreateTime = Convert.ToDateTime(myReader["CreateTime"]); }
                if (!Convert.IsDBNull(myReader["Operater"])) { myDetail.Operater = Convert.ToString(myReader["Operater"]); }
                if (!Convert.IsDBNull(myReader["SupplierName"])) { myDetail.SupplierName = Convert.ToString(myReader["SupplierName"]); }
                if (!Convert.IsDBNull(myReader["SupplierCode"])) { myDetail.SupplierCode = Convert.ToString(myReader["SupplierCode"]); }
                if (!Convert.IsDBNull(myReader["BeginCuPrice"])) { myDetail.BeginCuPrice = Convert.ToDecimal(myReader["BeginCuPrice"]); }
                if (!Convert.IsDBNull(myReader["EndCuPrice"])) { myDetail.EndCuPrice = Convert.ToDecimal(myReader["EndCuPrice"]); }
                if (!Convert.IsDBNull(myReader["ItemName"])) { myDetail.ItemName = Convert.ToString(myReader["ItemName"]); }
                if (!Convert.IsDBNull(myReader["ItemCode"])) { myDetail.ItemCode = Convert.ToString(myReader["ItemCode"]); }
                if (!Convert.IsDBNull(myReader["FModel"])) { myDetail.FModel = Convert.ToString(myReader["FModel"]); }
                if (!Convert.IsDBNull(myReader["FromCount"])) { myDetail.FromCount = Convert.ToInt32(myReader["FromCount"]); }
                if (!Convert.IsDBNull(myReader["EndCount"])) { myDetail.EndCount = Convert.ToInt32(myReader["EndCount"]); }
                if (!Convert.IsDBNull(myReader["Price"])) { myDetail.Price = Convert.ToDecimal(myReader["Price"]); }
                if (!Convert.IsDBNull(myReader["FUnit"])) { myDetail.FUnit = Convert.ToString(myReader["FUnit"]); }
                if (!Convert.IsDBNull(myReader["CoinType"])) { myDetail.CoinType = Convert.ToString(myReader["CoinType"]); }
                if (!Convert.IsDBNull(myReader["MOQ"])) { myDetail.MOQ = Convert.ToString(myReader["MOQ"]); }
                if (!Convert.IsDBNull(myReader["PPQ"])) { myDetail.PPQ = Convert.ToString(myReader["PPQ"]); }
                if (!Convert.IsDBNull(myReader["LimitTimes"])) { myDetail.LimitTimes = Convert.ToString(myReader["LimitTimes"]); }
                if (!Convert.IsDBNull(myReader["IsDeleted"])) { myDetail.IsDeleted = Convert.ToInt32(myReader["IsDeleted"]); }
                if (!Convert.IsDBNull(myReader["PackageInfo"])) { myDetail.PackageInfo = Convert.ToString(myReader["PackageInfo"]); }
                if (!Convert.IsDBNull(myReader["CostPrice"])) { myDetail.CostPrice = Convert.ToDecimal(myReader["CostPrice"]); }
                if (!Convert.IsDBNull(myReader["CostCoinType"])) { myDetail.CostCoinType = Convert.ToString(myReader["CostCoinType"]); }
                if (!Convert.IsDBNull(myReader["EffectiveDate"])) { myDetail.EffectiveDate = Convert.ToDateTime(myReader["EffectiveDate"]); }
                if (!Convert.IsDBNull(myReader["PriceRemarks"])) { myDetail.PriceRemarks = Convert.ToString(myReader["PriceRemarks"]); }
            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        public JD_CuPriceDetail Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_CuPriceDetail  WHERE ItemID = @m_ItemID", con);
            con.Open();
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;
            JD_CuPriceDetail myDetail = new JD_CuPriceDetail();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["CreateTime"])) { myDetail.CreateTime = Convert.ToDateTime(myReader["CreateTime"]); }
                if (!Convert.IsDBNull(myReader["Operater"])) { myDetail.Operater = Convert.ToString(myReader["Operater"]); }
                if (!Convert.IsDBNull(myReader["SupplierName"])) { myDetail.SupplierName = Convert.ToString(myReader["SupplierName"]); }
                if (!Convert.IsDBNull(myReader["SupplierCode"])) { myDetail.SupplierCode = Convert.ToString(myReader["SupplierCode"]); }
                if (!Convert.IsDBNull(myReader["BeginCuPrice"])) { myDetail.BeginCuPrice = Convert.ToDecimal(myReader["BeginCuPrice"]); }
                if (!Convert.IsDBNull(myReader["EndCuPrice"])) { myDetail.EndCuPrice = Convert.ToDecimal(myReader["EndCuPrice"]); }
                if (!Convert.IsDBNull(myReader["ItemName"])) { myDetail.ItemName = Convert.ToString(myReader["ItemName"]); }
                if (!Convert.IsDBNull(myReader["ItemCode"])) { myDetail.ItemCode = Convert.ToString(myReader["ItemCode"]); }
                if (!Convert.IsDBNull(myReader["FModel"])) { myDetail.FModel = Convert.ToString(myReader["FModel"]); }
                if (!Convert.IsDBNull(myReader["FromCount"])) { myDetail.FromCount = Convert.ToInt32(myReader["FromCount"]); }
                if (!Convert.IsDBNull(myReader["EndCount"])) { myDetail.EndCount = Convert.ToInt32(myReader["EndCount"]); }
                if (!Convert.IsDBNull(myReader["Price"])) { myDetail.Price = Convert.ToDecimal(myReader["Price"]); }
                if (!Convert.IsDBNull(myReader["FUnit"])) { myDetail.FUnit = Convert.ToString(myReader["FUnit"]); }
                if (!Convert.IsDBNull(myReader["CoinType"])) { myDetail.CoinType = Convert.ToString(myReader["CoinType"]); }
                if (!Convert.IsDBNull(myReader["MOQ"])) { myDetail.MOQ = Convert.ToString(myReader["MOQ"]); }
                if (!Convert.IsDBNull(myReader["PPQ"])) { myDetail.PPQ = Convert.ToString(myReader["PPQ"]); }
                if (!Convert.IsDBNull(myReader["LimitTimes"])) { myDetail.LimitTimes = Convert.ToString(myReader["LimitTimes"]); }
                if (!Convert.IsDBNull(myReader["IsDeleted"])) { myDetail.IsDeleted = Convert.ToInt32(myReader["IsDeleted"]); }
                if (!Convert.IsDBNull(myReader["PackageInfo"])) { myDetail.PackageInfo = Convert.ToString(myReader["PackageInfo"]); }
                if (!Convert.IsDBNull(myReader["CostPrice"])) { myDetail.CostPrice = Convert.ToDecimal(myReader["CostPrice"]); }
                if (!Convert.IsDBNull(myReader["CostCoinType"])) { myDetail.CostCoinType = Convert.ToString(myReader["CostCoinType"]); }
                if (!Convert.IsDBNull(myReader["EffectiveDate"])) { myDetail.EffectiveDate = Convert.ToDateTime(myReader["EffectiveDate"]); }
                if (!Convert.IsDBNull(myReader["PriceRemarks"])) { myDetail.PriceRemarks = Convert.ToString(myReader["PriceRemarks"]); }
            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }

        /// <summary>
        /// 新增JD_CuPriceDetail对象
        /// 编写人：ywk
        /// 编写日期：2018/7/20 星期五
        /// </summary>
        public int Add(JD_CuPriceDetail model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO JD_CuPriceDetail(CreateTime,Operater,SupplierName,SupplierCode,BeginCuPrice,EndCuPrice,ItemName,ItemCode,FModel,FromCount,EndCount,Price,FUnit,CoinType,MOQ,PPQ,LimitTimes,IsDeleted,PackageInfo,CostPrice,CostCoinType,EffectiveDate,PriceRemarks) VALUES(@m_CreateTime,@m_Operater,@m_SupplierName,@m_SupplierCode,@m_BeginCuPrice,@m_EndCuPrice,@m_ItemName,@m_ItemCode,@m_FModel,@m_FromCount,@m_EndCount,@m_Price,@m_FUnit,@m_CoinType,@m_MOQ,@m_PPQ,@m_LimitTimes,@m_IsDeleted,@m_PackageInfo,@m_CostPrice,@m_CostCoinType,@m_EffectiveDate,@m_PriceRemarks) SELECT @thisId=@@IDENTITY FROM JD_CuPriceDetail", con);
            con.Open();

            if (model.CreateTime == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = model.CreateTime;
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
                cmd.Parameters.Add(new SqlParameter("@m_SupplierName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierName", SqlDbType.NVarChar, 50)).Value = model.SupplierName;
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
                cmd.Parameters.Add(new SqlParameter("@m_ItemName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ItemName", SqlDbType.NVarChar, 100)).Value = model.ItemName;
            }
            if (model.ItemCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ItemCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ItemCode", SqlDbType.NVarChar, 50)).Value = model.ItemCode;
            }
            if (model.FModel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = model.FModel;
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
            if (model.IsDeleted == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsDeleted", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsDeleted", SqlDbType.Int, 0)).Value = model.IsDeleted;
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
            if (model.EffectiveDate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_EffectiveDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_EffectiveDate", SqlDbType.DateTime, 0)).Value = model.EffectiveDate;
            }
            if (model.PriceRemarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PriceRemarks", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PriceRemarks", SqlDbType.NVarChar, 100)).Value = model.PriceRemarks;
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
        /// 更新JD_CuPriceDetail对象
        /// 编写人：ywk
        /// 编写日期：2018/7/20 星期五
        /// </summary>
        public void Update(JD_CuPriceDetail model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_CuPriceDetail SET CreateTime = @m_CreateTime,Operater = @m_Operater,SupplierName = @m_SupplierName,SupplierCode = @m_SupplierCode,BeginCuPrice = @m_BeginCuPrice,EndCuPrice = @m_EndCuPrice,ItemName = @m_ItemName,ItemCode = @m_ItemCode,FModel = @m_FModel,FromCount = @m_FromCount,EndCount = @m_EndCount,Price = @m_Price,FUnit = @m_FUnit,CoinType = @m_CoinType,MOQ = @m_MOQ,PPQ = @m_PPQ,LimitTimes = @m_LimitTimes,IsDeleted = @m_IsDeleted,PackageInfo = @m_PackageInfo,CostPrice = @m_CostPrice,CostCoinType = @m_CostCoinType,EffectiveDate = @m_EffectiveDate,PriceRemarks=@m_PriceRemarks WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.CreateTime == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = model.CreateTime;
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
                cmd.Parameters.Add(new SqlParameter("@m_SupplierName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierName", SqlDbType.NVarChar, 50)).Value = model.SupplierName;
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
                cmd.Parameters.Add(new SqlParameter("@m_ItemName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ItemName", SqlDbType.NVarChar, 100)).Value = model.ItemName;
            }
            if (model.ItemCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ItemCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ItemCode", SqlDbType.NVarChar, 50)).Value = model.ItemCode;
            }
            if (model.FModel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = model.FModel;
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
            if (model.IsDeleted == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsDeleted", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsDeleted", SqlDbType.Int, 0)).Value = model.IsDeleted;
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
            if (model.EffectiveDate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_EffectiveDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_EffectiveDate", SqlDbType.DateTime, 0)).Value = model.EffectiveDate;
            }
            if (model.PriceRemarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PriceRemarks", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PriceRemarks", SqlDbType.NVarChar, 100)).Value = model.PriceRemarks;
            }
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID;

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }


        /// <summary>
        /// 根据限价日志的ID 批量处理
        /// </summary>
        /// <param name="ItemID"></param>
        /// JD_LimitPriceApply 数据 更新至JD_CuPriceDetail中
        public void HandleCuPrice(int ItemID, string FileName, int TaskID)
        {

            JD_LimitPriceApply_LogDal logdal = new JD_LimitPriceApply_LogDal();
            JD_LimitPriceApply_Log Logmodel = logdal.Detail(ItemID);

            JD_CuPriceDetailDal detaildal = new JD_CuPriceDetailDal();
            JD_CuPriceDetail detailmodel = new JD_CuPriceDetail();
            string ErrorMsg = string.Empty;
            int CuPriceID = 0;
            try
            {
                if (Logmodel != null)
                {
                    #region 本地集成
                    switch (Logmodel.ApplyType)
                    {
                        case "1": //新增
                            #region 新增
                            //判断是否存在 若存在 更新单价 

                            detailmodel = Detail(Logmodel.SupplierCode, Logmodel.ItemCode, Logmodel.BeginCuPrice, Logmodel.EndCuPrice, Logmodel.FromCount, Logmodel.EndCount);

                            if (detailmodel != null && !string.IsNullOrEmpty(detailmodel.SupplierCode))
                            {
                                detailmodel.Price = Logmodel.Price;
                                detailmodel.PriceRemarks = Logmodel.PriceRemarks;
                                detailmodel.EffectiveDate = DateTime.Now;
                                Update(detailmodel);

                            }
                            else
                            {
                                //不存在 更新

                                CuPriceID = detaildal.Add(new JD_CuPriceDetail
                                {
                                    ItemName = Logmodel.ItemName,
                                    ItemCode = Logmodel.ItemCode,
                                    FUnit = Logmodel.FUnit,
                                    BeginCuPrice = Logmodel.BeginCuPrice,
                                    EndCuPrice = Logmodel.EndCuPrice,
                                    FromCount = Logmodel.FromCount,
                                    EndCount = Logmodel.EndCount,
                                    SupplierName = Logmodel.SupplierName,
                                    SupplierCode = Logmodel.SupplierCode,
                                    CoinType = Logmodel.CoinType,
                                    Price = Logmodel.Price,
                                    MOQ = Logmodel.MOQ,
                                    PPQ = Logmodel.PPQ,
                                    LimitTimes = Logmodel.LimitTimes,
                                    FModel = Logmodel.FModel,
                                    CreateTime = DateTime.Now,
                                    Operater = Logmodel.Operater,
                                    PackageInfo = Logmodel.PackageInfo,
                                    //CostPrice = Logmodel.CostPrice,
                                    //CostCoinType = Logmodel.CostCoinType,
                                    CostPrice = Logmodel.Price,
                                    CostCoinType = Logmodel.CoinType,
                                    PriceRemarks = Logmodel.PriceRemarks,
                                    EffectiveDate=DateTime.Now
                                    
                                });
                                Logmodel.ParentID = CuPriceID;
                            }


                            #endregion
                            break;
                        case "2": //删除
                            #region 删除
                            detailmodel = Detail(Logmodel.SupplierCode, Logmodel.ItemCode, Logmodel.BeginCuPrice, Logmodel.EndCuPrice, Logmodel.FromCount, Logmodel.EndCount);

                            if (detailmodel != null && !string.IsNullOrEmpty(detailmodel.SupplierCode))
                            {
                                detailmodel.IsDeleted = 1;
                                detailmodel.EffectiveDate = DateTime.Now;
                                Update(detailmodel);
                            }
                            #endregion
                            break;
                        case "3": //涨价
                        case "4": //降价
                            //2018-11-19 阶梯价更新时 数量也被修改 所以用ItemID确定唯一性
                            //detailmodel = Detail(Logmodel.SupplierCode, Logmodel.ItemCode, Logmodel.BeginCuPrice, Logmodel.EndCuPrice, Logmodel.FromCount, Logmodel.EndCount);
                            detailmodel = Detail(Logmodel.ParentID);
                            if (detailmodel != null && !string.IsNullOrEmpty(detailmodel.SupplierCode))
                            {
                                detailmodel.Price = Logmodel.Price;
                                //2018-10-29 单价和限价不做区分
                                //detailmodel.CostPrice = Logmodel.CostPrice;
                                detailmodel.CostPrice = Logmodel.Price;
                                //2018-10-18  价格变更中还要包括铜价和数量的变更
                                detailmodel.BeginCuPrice = Logmodel.BeginCuPrice;
                                detailmodel.EndCuPrice = Logmodel.EndCuPrice;
                                detailmodel.FromCount = Logmodel.FromCount;
                                detailmodel.EndCount = Logmodel.EndCount;
                                detailmodel.EffectiveDate = DateTime.Now;
                                detailmodel.CoinType = Logmodel.CoinType;
                                //detailmodel.MOQ = Logmodel.MOQ;
                                //detailmodel.PPQ = Logmodel.PPQ;
                                //detailmodel.LimitTimes = Logmodel.LimitTimes;
                                Update(detailmodel);
                            }
                            //2018-10-17 如果供应商变更了，需要IsDeleted原来的数据，并新增数据
                            UpdateSupplierInfo(Logmodel.ItemID);

                            break;
                        case "5": //其他变更 除了价格的变更
                            //2018-10-17 已不存在其他变更
                            #region 除了价格的变更  料号和供应商不能变
                            detailmodel = Detail(Logmodel.SupplierCode, Logmodel.ItemCode, Logmodel.BeginCuPrice, Logmodel.EndCuPrice, Logmodel.FromCount, Logmodel.EndCount);
                            if (detailmodel != null && !string.IsNullOrEmpty(detailmodel.SupplierCode))
                            {

                                detailmodel.FUnit = Logmodel.FUnit;
                                detailmodel.BeginCuPrice = Logmodel.BeginCuPrice;
                                detailmodel.EndCuPrice = Logmodel.EndCuPrice;
                                detailmodel.FromCount = Logmodel.FromCount;
                                detailmodel.EndCount = Logmodel.EndCount;
                                detailmodel.CoinType = Logmodel.CoinType;
                                detailmodel.MOQ = Logmodel.MOQ;
                                detailmodel.PPQ = Logmodel.PPQ;
                                detailmodel.LimitTimes = Logmodel.LimitTimes;
                                detailmodel.FModel = Logmodel.FModel;
                                detailmodel.Operater = Logmodel.Operater;
                                detailmodel.PackageInfo = Logmodel.PackageInfo;
                                detailmodel.CostCoinType = Logmodel.CostCoinType;
                                Update(detailmodel);
                            }
                            #endregion
                            break;

                    }
                    #endregion

                    #region K3物料集成
                    UpdateItemInfo(Logmodel.MOQ, Logmodel.PPQ, Logmodel.PackageInfo,
                    Logmodel.ItemCode, ItemID.ToString());
                    #endregion

                }
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
                common.WriteLogs(FileName, ItemID.ToString(), "Error:" + ex.Message);
            }
            finally
            {
                //更新状态
                Logmodel.IsUpdate = "1";
                Logmodel.UpdateTime = DateTime.Now;
                logdal.Update(Logmodel);

                if (!string.IsNullOrEmpty(ErrorMsg))
                {
                    common.AddLogQueue(TaskID, "JD_LimitPriceApply_Log", ItemID, "SQL", ErrorMsg, false);
                }
                else
                {
                    common.AddLogQueue(TaskID, "JD_LimitPriceApply_Log", ItemID, "SQL", "操作成功", true);
                }
            }

        }

        protected void UpdateSupplierInfo(int LogItemID)
        {
            JD_LimitPriceApply_LogDal logdal = new JD_LimitPriceApply_LogDal();
            JD_LimitPriceApply_Log logmodel = logdal.Detail(LogItemID);
            if (logmodel != null)
            {
                JD_CuPriceDetail model = Detail(logmodel.ParentID);

                //供应商编号不相等 禁用原来的铜价信息
                if (logmodel.SupplierCode != model.SupplierCode)
                {
                    #region 新增铜价阶梯价记录
                    JD_CuPriceDetail newmodel = model;
                    newmodel.SupplierCode = logmodel.SupplierCode;
                    newmodel.SupplierName = logmodel.SupplierName;
                    newmodel.EffectiveDate = DateTime.Now;
                    newmodel.IsDeleted = 0;
                    Add(newmodel);
                    #endregion

                    //禁用原来的铜价信息
                    model.IsDeleted = 1;
                    Update(model);
                }


            }
        }

        public void UpdateItemInfo(string MOQ, string PPQ, string PackageInfo, string FNumber, string ItemID)
        {
            if (!string.IsNullOrEmpty(FNumber))
            {
                if (!string.IsNullOrEmpty(MOQ))
                {
                    MOQ = Math.Round(Convert.ToDecimal(MOQ), 10).ToString();
                }
                if (!string.IsNullOrEmpty(PPQ))
                {
                    PPQ = Math.Round(Convert.ToDecimal(PPQ), 10).ToString();
                }
                #region 更新日志数据
                //若有料号 直接更新
                //若更新前无数据 则先插入
                JD_IcItem_LogDal dal = new JD_IcItem_LogDal();
                ICItemPlanDal plandal = new ICItemPlanDal();
                ICItemCustomDal customdal = new ICItemCustomDal();
                #region 若更新前无数据 则先插入
                if (!dal.IsExist(FNumber))
                {

                    ICItemPlan modelPlan = plandal.Detail(FNumber);
                    ICItemCustom modelCus = customdal.Detail(FNumber);
                    if (modelPlan != null && modelCus != null)
                    {
                        dal.Add(new JD_IcItem_Log
                        {
                            FNumber = FNumber,
                            MOQ = modelPlan.FQtyMin,
                            PPQ = modelPlan.FBatchAppendQty,
                            PackageInfo = modelCus.F_112,
                            CreateTime = DateTime.Now
                        });
                    }
                }
                #endregion

                #region 日志中保存数据
                dal.Add(new JD_IcItem_Log
                {
                    CreateTime = DateTime.Now,
                    MOQ = Convert.ToDecimal(MOQ),
                    PPQ = Convert.ToDecimal(PPQ),
                    FNumber = FNumber,
                    PackageInfo = PackageInfo
                });
                #endregion

                #endregion

                #region 更新K3 PPQ MOQ
                plandal.UpdateInLimitApply(MOQ, PPQ, FNumber);
                customdal.UpdateInLimitApply(PackageInfo, FNumber);
                #endregion
            }
            else
            {
                common.WriteLogs(Common.FileType.采购限价申请.ToString(), ItemID, "---FNumber不存在---");
            }

        }

        public void UpdateParentID()
        {
            try
            {
                string sql = " select distinct TaskID    from [dbo].[JD_LimitPriceApply_Log] where ApplyType='3' and ParentID=0  order by TaskID asc ";
                JD_LimitPriceApply_LogDal limtdal = new JD_LimitPriceApply_LogDal();
                DataView dv = DBUtil.Query(sql, connectionString).Tables[0].DefaultView;
                foreach (DataRowView dr in dv)
                {
                    string DataSql = string.Format(@"select  *   from[dbo].[JD_LimitPriceApply_Log] where ApplyType = '3' and ParentID = 0  and TaskID = '{0}'", dr["TaskID"].ToString());

                    DataView Newdv = DBUtil.Query(DataSql, connectionString).Tables[0].DefaultView;
                    int Count = 0;
                    foreach (DataRowView drchild in Newdv)
                    {
                        //偶数行 更新Parent
                        if (Count % 2 == 1)
                        {
                            int ItemID = Convert.ToInt32(drchild["ItemID"].ToString());
                            JD_LimitPriceApply_Log limlogNew = limtdal.Detail(ItemID);
                            JD_LimitPriceApply_Log limlog = limtdal.Detail(ItemID - 1);
                            if (limlog != null)
                            {
                                JD_CuPriceDetail detailMol = Detail(limlog.SupplierCode, limlog.ItemCode, limlog.BeginCuPrice, limlog.EndCuPrice,
                                    limlog.FromCount, limlog.EndCount);
                                limlogNew.ParentID = detailMol.ItemID;
                                limtdal.Update(limlogNew);
                            }
                        }
                        Count++;
                    }

                }

            }
            catch (Exception ex)
            {
                common.WriteLogs("铜价阶梯价服务错误："+ex.Message);
            }
            finally
            {

            }
        }


    }
}
