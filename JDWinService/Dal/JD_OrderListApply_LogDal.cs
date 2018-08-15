using JDWinService.Model;
using JDWinService.Utils;
using Kingdee.K3.API.SDK;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace JDWinService.Dal
{
    public class JD_OrderListApply_LogDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        Common common = new Common();

        /// <summary>
        /// 对象JD_OrderListApply_Log明细
        /// 编写人：ywk
        /// 编写日期：2018/7/10 星期二
        /// </summary>
        public JD_OrderListApply_Log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_OrderListApply_Log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_OrderListApply_Log myDetail = new JD_OrderListApply_Log();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["CreateTime"])) { myDetail.CreateTime = Convert.ToDateTime(myReader["CreateTime"]); }
                if (!Convert.IsDBNull(myReader["UpdateTime"])) { myDetail.UpdateTime = Convert.ToDateTime(myReader["UpdateTime"]); }
                if (!Convert.IsDBNull(myReader["SupplierName"])) { myDetail.SupplierName = Convert.ToString(myReader["SupplierName"]); }
                if (!Convert.IsDBNull(myReader["SupplierCode"])) { myDetail.SupplierCode = Convert.ToString(myReader["SupplierCode"]); }
                if (!Convert.IsDBNull(myReader["PlanType"])) { myDetail.PlanType = Convert.ToString(myReader["PlanType"]); }
                if (!Convert.IsDBNull(myReader["PlanTypeCode"])) { myDetail.PlanTypeCode = Convert.ToString(myReader["PlanTypeCode"]); }
                if (!Convert.IsDBNull(myReader["CoinType"])) { myDetail.CoinType = Convert.ToString(myReader["CoinType"]); }
                if (!Convert.IsDBNull(myReader["CoinTypeCode"])) { myDetail.CoinTypeCode = Convert.ToString(myReader["CoinTypeCode"]); }
                if (!Convert.IsDBNull(myReader["Rate"])) { myDetail.Rate = Convert.ToString(myReader["Rate"]); }
                if (!Convert.IsDBNull(myReader["RateType"])) { myDetail.RateType = Convert.ToString(myReader["RateType"]); }
                if (!Convert.IsDBNull(myReader["RateTypeCode"])) { myDetail.RateTypeCode = Convert.ToString(myReader["RateTypeCode"]); }
                if (!Convert.IsDBNull(myReader["OrderMode"])) { myDetail.OrderMode = Convert.ToString(myReader["OrderMode"]); }
                if (!Convert.IsDBNull(myReader["OrderModeCode"])) { myDetail.OrderModeCode = Convert.ToString(myReader["OrderModeCode"]); }
                if (!Convert.IsDBNull(myReader["OrderType"])) { myDetail.OrderType = Convert.ToString(myReader["OrderType"]); }
                if (!Convert.IsDBNull(myReader["OrderTypeCode"])) { myDetail.OrderTypeCode = Convert.ToString(myReader["OrderTypeCode"]); }
                if (!Convert.IsDBNull(myReader["OrderRange"])) { myDetail.OrderRange = Convert.ToString(myReader["OrderRange"]); }
                if (!Convert.IsDBNull(myReader["OrderRangeCode"])) { myDetail.OrderRangeCode = Convert.ToString(myReader["OrderRangeCode"]); }
                if (!Convert.IsDBNull(myReader["BalanceType"])) { myDetail.BalanceType = Convert.ToString(myReader["BalanceType"]); }
                if (!Convert.IsDBNull(myReader["BalanceTypeCode"])) { myDetail.BalanceTypeCode = Convert.ToString(myReader["BalanceTypeCode"]); }
                if (!Convert.IsDBNull(myReader["BU"])) { myDetail.BU = Convert.ToString(myReader["BU"]); }
                if (!Convert.IsDBNull(myReader["BUCode"])) { myDetail.BUCode = Convert.ToString(myReader["BUCode"]); }
                if (!Convert.IsDBNull(myReader["FAllPrice"])) { myDetail.FAllPrice = Convert.ToDecimal(myReader["FAllPrice"]); }
                if (!Convert.IsDBNull(myReader["FAllTaxPrice"])) { myDetail.FAllTaxPrice = Convert.ToDecimal(myReader["FAllTaxPrice"]); }
                if (!Convert.IsDBNull(myReader["FBillNo"])) { myDetail.FBillNo = Convert.ToString(myReader["FBillNo"]); }
                if (!Convert.IsDBNull(myReader["FInterID"])) { myDetail.FInterID = Convert.ToInt32(myReader["FInterID"]); }
                if (!Convert.IsDBNull(myReader["FEntryID"])) { myDetail.FEntryID = Convert.ToInt32(myReader["FEntryID"]); }
                if (!Convert.IsDBNull(myReader["FNumber"])) { myDetail.FNumber = Convert.ToString(myReader["FNumber"]); }
                if (!Convert.IsDBNull(myReader["FName"])) { myDetail.FName = Convert.ToString(myReader["FName"]); }
                if (!Convert.IsDBNull(myReader["FModel"])) { myDetail.FModel = Convert.ToString(myReader["FModel"]); }
                if (!Convert.IsDBNull(myReader["FQtyMin"])) { myDetail.FQtyMin = Convert.ToDecimal(myReader["FQtyMin"]); }
                if (!Convert.IsDBNull(myReader["FBatchAppendQty"])) { myDetail.FBatchAppendQty = Convert.ToDecimal(myReader["FBatchAppendQty"]); }
                if (!Convert.IsDBNull(myReader["WuLiaoCode"])) { myDetail.WuLiaoCode = Convert.ToString(myReader["WuLiaoCode"]); }
                if (!Convert.IsDBNull(myReader["WuLiaoSupplier"])) { myDetail.WuLiaoSupplier = Convert.ToString(myReader["WuLiaoSupplier"]); }
                if (!Convert.IsDBNull(myReader["EnginCRName"])) { myDetail.EnginCRName = Convert.ToString(myReader["EnginCRName"]); }
                if (!Convert.IsDBNull(myReader["EnginCRCode"])) { myDetail.EnginCRCode = Convert.ToString(myReader["EnginCRCode"]); }
                if (!Convert.IsDBNull(myReader["PriceXiShu"])) { myDetail.PriceXiShu = Convert.ToDouble(myReader["PriceXiShu"]); }
                if (!Convert.IsDBNull(myReader["SupplierVersion"])) { myDetail.SupplierVersion = Convert.ToString(myReader["SupplierVersion"]); }
                if (!Convert.IsDBNull(myReader["funit"])) { myDetail.funit = Convert.ToString(myReader["funit"]); }
                if (!Convert.IsDBNull(myReader["funitID"])) { myDetail.funitID = Convert.ToString(myReader["funitID"]); }
                if (!Convert.IsDBNull(myReader["FQty"])) { myDetail.FQty = Convert.ToDecimal(myReader["FQty"]); }
                if (!Convert.IsDBNull(myReader["FCommitQty"])) { myDetail.FCommitQty = Convert.ToDecimal(myReader["FCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FpoNum"])) { myDetail.FpoNum = Convert.ToDecimal(myReader["FpoNum"]); }
                if (!Convert.IsDBNull(myReader["FFetchTime"])) { myDetail.FFetchTime = Convert.ToDateTime(myReader["FFetchTime"]); }
                if (!Convert.IsDBNull(myReader["FSupplyID"])) { myDetail.FSupplyID = Convert.ToString(myReader["FSupplyID"]); }
                if (!Convert.IsDBNull(myReader["fsupNo"])) { myDetail.fsupNo = Convert.ToString(myReader["fsupNo"]); }
                if (!Convert.IsDBNull(myReader["fsupname"])) { myDetail.fsupname = Convert.ToString(myReader["fsupname"]); }
                if (!Convert.IsDBNull(myReader["FAuxPrice"])) { myDetail.FAuxPrice = Convert.ToDecimal(myReader["FAuxPrice"]); }
                if (!Convert.IsDBNull(myReader["FAuxTaxPrice"])) { myDetail.FAuxTaxPrice = Convert.ToDecimal(myReader["FAuxTaxPrice"]); }
                if (!Convert.IsDBNull(myReader["FAmount"])) { myDetail.FAmount = Convert.ToDecimal(myReader["FAmount"]); }
                if (!Convert.IsDBNull(myReader["FTaxAmount"])) { myDetail.FTaxAmount = Convert.ToDecimal(myReader["FTaxAmount"]); }
                if (!Convert.IsDBNull(myReader["Remarks"])) { myDetail.Remarks = Convert.ToString(myReader["Remarks"]); }
                if (!Convert.IsDBNull(myReader["FCess"])) { myDetail.FCess = Convert.ToDecimal(myReader["FCess"]); }
                if (!Convert.IsDBNull(myReader["POHightPrice"])) { myDetail.POHightPrice = Convert.ToDecimal(myReader["POHightPrice"]); }
                if (!Convert.IsDBNull(myReader["IsUpdate"])) { myDetail.IsUpdate = Convert.ToString(myReader["IsUpdate"]); }
                if (!Convert.IsDBNull(myReader["FDate"])) { myDetail.FDate = Convert.ToDateTime(myReader["FDate"]); }
                if (!Convert.IsDBNull(myReader["DeptID"])) { myDetail.DeptID = Convert.ToString(myReader["DeptID"]); }
                if (!Convert.IsDBNull(myReader["DeptIDCode"])) { myDetail.DeptIDCode = Convert.ToString(myReader["DeptIDCode"]); }
                if (!Convert.IsDBNull(myReader["FEmpID"])) { myDetail.FEmpID = Convert.ToString(myReader["FEmpID"]); }
                if (!Convert.IsDBNull(myReader["FEmpIDCode"])) { myDetail.FEmpIDCode = Convert.ToString(myReader["FEmpIDCode"]); }
                if (!Convert.IsDBNull(myReader["FManageID"])) { myDetail.FManageID = Convert.ToString(myReader["FManageID"]); }
                if (!Convert.IsDBNull(myReader["FManageIDCode"])) { myDetail.FManageIDCode = Convert.ToString(myReader["FManageIDCode"]); }
                if (!Convert.IsDBNull(myReader["FBillerID"])) { myDetail.FBillerID = Convert.ToString(myReader["FBillerID"]); }
                if (!Convert.IsDBNull(myReader["FDate1"])) { myDetail.FDate1 = Convert.ToDateTime(myReader["FDate1"]); }
                if (!Convert.IsDBNull(myReader["ordernum"])) { myDetail.ordernum = Convert.ToString(myReader["ordernum"]); }
                if (!Convert.IsDBNull(myReader["REQType"])) { myDetail.REQType = Convert.ToString(myReader["REQType"]); }
                if (!Convert.IsDBNull(myReader["IsPart"])) { myDetail.IsPart = Convert.ToInt32(myReader["IsPart"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }

        /// <summary>
        /// 更新JD_OrderListApply_Log对象
        /// 编写人：ywk
        /// 编写日期：2018/7/11 星期三
        /// </summary>
        public void Update(JD_OrderListApply_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_OrderListApply_Log SET TaskID = @m_TaskID,CreateTime = @m_CreateTime,UpdateTime = @m_UpdateTime,SupplierName = @m_SupplierName,SupplierCode = @m_SupplierCode,PlanType = @m_PlanType,PlanTypeCode = @m_PlanTypeCode,CoinType = @m_CoinType,CoinTypeCode = @m_CoinTypeCode,Rate = @m_Rate,RateType = @m_RateType,RateTypeCode = @m_RateTypeCode,OrderMode = @m_OrderMode,OrderModeCode = @m_OrderModeCode,OrderType = @m_OrderType,OrderTypeCode = @m_OrderTypeCode,OrderRange = @m_OrderRange,OrderRangeCode = @m_OrderRangeCode,BalanceType = @m_BalanceType,BalanceTypeCode = @m_BalanceTypeCode,BU = @m_BU,BUCode = @m_BUCode,FAllPrice = @m_FAllPrice,FAllTaxPrice = @m_FAllTaxPrice,FBillNo = @m_FBillNo,FInterID = @m_FInterID,FEntryID = @m_FEntryID,FNumber = @m_FNumber,FName = @m_FName,FModel = @m_FModel,FQtyMin = @m_FQtyMin,FBatchAppendQty = @m_FBatchAppendQty,WuLiaoCode = @m_WuLiaoCode,WuLiaoSupplier = @m_WuLiaoSupplier,EnginCRName = @m_EnginCRName,EnginCRCode = @m_EnginCRCode,PriceXiShu = @m_PriceXiShu,SupplierVersion = @m_SupplierVersion,funit = @m_funit,funitID = @m_funitID,FQty = @m_FQty,FCommitQty = @m_FCommitQty,FpoNum = @m_FpoNum,FFetchTime = @m_FFetchTime,FSupplyID = @m_FSupplyID,fsupNo = @m_fsupNo,fsupname = @m_fsupname,FAuxPrice = @m_FAuxPrice,FAuxTaxPrice = @m_FAuxTaxPrice,FAmount = @m_FAmount,FTaxAmount = @m_FTaxAmount,Remarks = @m_Remarks,FCess = @m_FCess,POHightPrice = @m_POHightPrice,IsUpdate = @m_IsUpdate,FDate = @m_FDate,DeptID = @m_DeptID,DeptIDCode = @m_DeptIDCode,FEmpID = @m_FEmpID,FEmpIDCode = @m_FEmpIDCode,FManageID = @m_FManageID,FManageIDCode = @m_FManageIDCode,FBillerID = @m_FBillerID,FDate1 = @m_FDate1,ordernum = @m_ordernum,REQType = @m_REQType,IsPart = @m_IsPart WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.TaskID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = model.TaskID;
            }
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
            if (model.PlanType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanType", SqlDbType.NVarChar, 50)).Value = model.PlanType;
            }
            if (model.PlanTypeCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanTypeCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanTypeCode", SqlDbType.NVarChar, 50)).Value = model.PlanTypeCode;
            }
            if (model.CoinType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinType", SqlDbType.NVarChar, 50)).Value = model.CoinType;
            }
            if (model.CoinTypeCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinTypeCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinTypeCode", SqlDbType.NVarChar, 50)).Value = model.CoinTypeCode;
            }
            if (model.Rate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Rate", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Rate", SqlDbType.NVarChar, 50)).Value = model.Rate;
            }
            if (model.RateType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_RateType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_RateType", SqlDbType.NVarChar, 50)).Value = model.RateType;
            }
            if (model.RateTypeCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_RateTypeCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_RateTypeCode", SqlDbType.NVarChar, 50)).Value = model.RateTypeCode;
            }
            if (model.OrderMode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderMode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderMode", SqlDbType.NVarChar, 50)).Value = model.OrderMode;
            }
            if (model.OrderModeCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderModeCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderModeCode", SqlDbType.NVarChar, 50)).Value = model.OrderModeCode;
            }
            if (model.OrderType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderType", SqlDbType.NVarChar, 50)).Value = model.OrderType;
            }
            if (model.OrderTypeCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderTypeCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderTypeCode", SqlDbType.NVarChar, 50)).Value = model.OrderTypeCode;
            }
            if (model.OrderRange == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderRange", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderRange", SqlDbType.NVarChar, 50)).Value = model.OrderRange;
            }
            if (model.OrderRangeCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderRangeCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderRangeCode", SqlDbType.NVarChar, 50)).Value = model.OrderRangeCode;
            }
            if (model.BalanceType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BalanceType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BalanceType", SqlDbType.NVarChar, 50)).Value = model.BalanceType;
            }
            if (model.BalanceTypeCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BalanceTypeCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BalanceTypeCode", SqlDbType.NVarChar, 50)).Value = model.BalanceTypeCode;
            }
            if (model.BU == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BU", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BU", SqlDbType.NVarChar, 50)).Value = model.BU;
            }
            if (model.BUCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BUCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BUCode", SqlDbType.NVarChar, 50)).Value = model.BUCode;
            }
            if (model.FAllPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllPrice", SqlDbType.Decimal, 18)).Value = model.FAllPrice;
            }
            if (model.FAllTaxPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllTaxPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllTaxPrice", SqlDbType.Decimal, 18)).Value = model.FAllTaxPrice;
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
            if (model.FNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = model.FNumber;
            }
            if (model.FName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.NVarChar, 50)).Value = model.FName;
            }
            if (model.FModel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 100)).Value = model.FModel;
            }
            if (model.FQtyMin == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyMin", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyMin", SqlDbType.Decimal, 18)).Value = model.FQtyMin;
            }
            if (model.FBatchAppendQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchAppendQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchAppendQty", SqlDbType.Decimal, 18)).Value = model.FBatchAppendQty;
            }
            if (model.WuLiaoCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_WuLiaoCode", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_WuLiaoCode", SqlDbType.NVarChar, 100)).Value = model.WuLiaoCode;
            }
            if (model.WuLiaoSupplier == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_WuLiaoSupplier", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_WuLiaoSupplier", SqlDbType.NVarChar, 100)).Value = model.WuLiaoSupplier;
            }
            if (model.EnginCRName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_EnginCRName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_EnginCRName", SqlDbType.NVarChar, 100)).Value = model.EnginCRName;
            }
            if (model.EnginCRCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_EnginCRCode", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_EnginCRCode", SqlDbType.NVarChar, 100)).Value = model.EnginCRCode;
            }
            if (model.PriceXiShu == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PriceXiShu", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PriceXiShu", SqlDbType.Float, 0)).Value = model.PriceXiShu;
            }
            if (model.SupplierVersion == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierVersion", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierVersion", SqlDbType.NVarChar, 50)).Value = model.SupplierVersion;
            }
            if (model.funit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_funit", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_funit", SqlDbType.NVarChar, 50)).Value = model.funit;
            }
            if (model.funitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_funitID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_funitID", SqlDbType.NVarChar, 50)).Value = model.funitID;
            }
            if (model.FQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 18)).Value = model.FQty;
            }
            if (model.FCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitQty", SqlDbType.Decimal, 18)).Value = model.FCommitQty;
            }
            if (model.FpoNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FpoNum", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FpoNum", SqlDbType.Decimal, 18)).Value = model.FpoNum;
            }
            if (model.FFetchTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFetchTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFetchTime", SqlDbType.DateTime, 0)).Value = model.FFetchTime;
            }
            if (model.FSupplyID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupplyID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupplyID", SqlDbType.NVarChar, 50)).Value = model.FSupplyID;
            }
            if (model.fsupNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_fsupNo", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_fsupNo", SqlDbType.NVarChar, 50)).Value = model.fsupNo;
            }
            if (model.fsupname == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_fsupname", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_fsupname", SqlDbType.NVarChar, 100)).Value = model.fsupname;
            }
            if (model.FAuxPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 18)).Value = model.FAuxPrice;
            }
            if (model.FAuxTaxPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxTaxPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxTaxPrice", SqlDbType.Decimal, 18)).Value = model.FAuxTaxPrice;
            }
            if (model.FAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmount", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmount", SqlDbType.Decimal, 18)).Value = model.FAmount;
            }
            if (model.FTaxAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxAmount", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxAmount", SqlDbType.Decimal, 18)).Value = model.FTaxAmount;
            }
            if (model.Remarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Remarks", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Remarks", SqlDbType.NVarChar, 500)).Value = model.Remarks;
            }
            if (model.FCess == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCess", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCess", SqlDbType.Decimal, 18)).Value = model.FCess;
            }
            if (model.POHightPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_POHightPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_POHightPrice", SqlDbType.Decimal, 18)).Value = model.POHightPrice;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = model.IsUpdate;
            }
            if (model.FDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = model.FDate;
            }
            if (model.DeptID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeptID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeptID", SqlDbType.NVarChar, 50)).Value = model.DeptID;
            }
            if (model.DeptIDCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeptIDCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeptIDCode", SqlDbType.NVarChar, 50)).Value = model.DeptIDCode;
            }
            if (model.FEmpID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEmpID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEmpID", SqlDbType.NVarChar, 50)).Value = model.FEmpID;
            }
            if (model.FEmpIDCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEmpIDCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEmpIDCode", SqlDbType.NVarChar, 50)).Value = model.FEmpIDCode;
            }
            if (model.FManageID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FManageID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FManageID", SqlDbType.NVarChar, 50)).Value = model.FManageID;
            }
            if (model.FManageIDCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FManageIDCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FManageIDCode", SqlDbType.NVarChar, 50)).Value = model.FManageIDCode;
            }
            if (model.FBillerID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillerID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillerID", SqlDbType.NVarChar, 50)).Value = model.FBillerID;
            }
            if (model.FDate1 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate1", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate1", SqlDbType.DateTime, 0)).Value = model.FDate1;
            }
            if (model.ordernum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ordernum", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ordernum", SqlDbType.NVarChar, 50)).Value = model.ordernum;
            }
            if (model.REQType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_REQType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_REQType", SqlDbType.NVarChar, 50)).Value = model.REQType;
            }
            if (model.IsPart == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsPart", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsPart", SqlDbType.Int, 0)).Value = model.IsPart;
            }
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID;

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }



        /// <summary>
        /// 采购订单 K3集成 Demo
        /// </summary>
        /// <param name="dv"></param>
        /// <param name="APIUrl"></param>
        /// <param name="APICode"></param>

        public void AddOrderEntry(int TaskID, string APIUrl, string APICode, string FileType)
        {
            #region 获取模板数据
            ApiEnvironment apiEnv = new ApiEnvironment();
            apiEnv.init(APIUrl, APICode);
            string loginUrl = APIUrl + "PO/GetTemplate?Token=" + apiEnv.Token;

            HttpWebResponse response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, " ", null, null, Encoding.UTF8, null);
            Stream resStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(resStream, Encoding.UTF8);
            string htmlCode = sr.ReadToEnd();//获取返回JSON 
            #endregion

            Result result = new Result(htmlCode, "AddOrderEntry");
            string headJson = string.Empty;
            string BodyJsonStr = string.Empty;
            string SendJson = string.Empty;
            if (result.StatusCode == "200")
            {
                DataView dv = GetDetail(TaskID);
                if (dv.Count > 0)
                {
                    JD_OrderListApply_Log model = Detail(TaskID);
                    #region Page1 解析并序列化
                    headJson = "{" + result.Data.Substring(result.Data.IndexOf("\"Page1\""), result.Data.IndexOf("]") - result.Data.IndexOf("\"Page1\"")) + "}";
                    headJson = headJson.Replace('[', ' ').Replace(']', ' ');

                    Json_POOrder_Head headMol = new Json_POOrder_Head();
                    headMol = JsonConvert.DeserializeObject<Json_POOrder_Head>(headJson);
                    headMol.Page1.FHeadSelfP0255.FName = model.BU;
                    headMol.Page1.FHeadSelfP0255.FNumber = model.BUCode;
                    headMol.Page1.FAreaPS.FName = model.OrderRange; //采购范围
                    headMol.Page1.FAreaPS.FNumber = model.OrderRangeCode;
                    headMol.Page1.FSettleID.FName = model.BalanceType;//结算方式
                    headMol.Page1.FSettleID.FNumber = model.BalanceTypeCode;
                    headMol.Page1.FPOStyle.FName = model.OrderType; //采购方式
                    headMol.Page1.FPOStyle.FNumber = model.OrderTypeCode;
                    headMol.Page1.FCurrencyID.FName = model.CoinType;//币别
                    headMol.Page1.FCurrencyID.FNumber = model.CoinTypeCode;
                    headMol.Page1.FPlanCategory.FName = model.PlanType;//计划类别
                    headMol.Page1.FPlanCategory.FNumber = model.PlanTypeCode;
                    headMol.Page1.FExchangeRateType.FName = model.RateType;//汇率类型
                    headMol.Page1.FExchangeRateType.FNumber = model.RateTypeCode;
                    headMol.Page1.FPOMode.FName = model.OrderMode;//采购模式
                    headMol.Page1.FPOMode.FNumber = model.OrderModeCode;
                    headMol.Page1.FCheckerID.FName = "";
                    headMol.Page1.FCheckerID.FNumber = "";

                    headMol.Page1.FMangerID.FName = model.FManageID;
                    headMol.Page1.FMangerID.FNumber = model.FManageIDCode;

                    headMol.Page1.FDeptID.FName = model.DeptID;
                    headMol.Page1.FDeptID.FNumber = model.DeptIDCode;


                    headMol.Page1.FEmpID.FName = model.FEmpID;
                    headMol.Page1.FEmpID.FNumber = model.FEmpIDCode;

                    headMol.Page1.FBillerID.FName = "Sr.Sun";
                    headMol.Page1.FBillerID.FNumber = "Sr.Sun";

                    //headMol.Page1.FBillerID.FName = model.FBillerID;
                    // headMol.Page1.FBillerID.FNumber = model.FBillerID;

                    headMol.Page1.FHeadSelfP0252 = "N";

                    headMol.Page1.FSysStatus = "2";
                    headMol.Page1.FSupplyID.FName = model.SupplierName;
                    headMol.Page1.FSupplyID.FNumber = model.SupplierCode;
                    headMol.Page1.FVersionNo = model.SupplierVersion;
                    headMol.Page1.FMultiCheckStatus = "16";
                    headMol.Page1.FExchangeRate = model.Rate;
                    headMol.Page1.Fdate = model.FDate.ToString("yyyy-MM-dd");
                    headJson = JsonConvert.SerializeObject(headMol);
                    int index = headJson.IndexOf(":");
                    headJson = headJson.Insert(index + 1, "[");
                    headJson = headJson.TrimEnd('}') + "}]";


                    #endregion

                    #region Page2 解析并序列化
                    #region bodyMol 初始化
                    string bodyJson = "{" + result.Data.Substring(result.Data.IndexOf("\"Page2\""), result.Data.LastIndexOf("]") - result.Data.IndexOf("\"Page2\"")) + "}";
                    bodyJson = bodyJson.Replace('[', ' ').Replace(']', ' ');
                    common.WriteLogs(FileType, "bodyJson :" + bodyJson);
                    Json_POOrder_Body bodyMol = new Json_POOrder_Body();
                    bodyMol = JsonConvert.DeserializeObject<Json_POOrder_Body>(bodyJson);
                    #endregion

                    BodyJsonStr = string.Empty;

                    foreach (DataRowView dr in dv)
                    {
                        try
                        {
                            model = Detail(Convert.ToInt32(dr["ItemID"]));
                            if (model != null)
                            {
                                bodyMol.Page2.FUnitID.FName = model.funit;
                                bodyMol.Page2.FUnitID.FNumber = model.funitID;
                                bodyMol.Page2.FItemName = model.FName;
                                bodyMol.Page2.FItemModel = model.FModel;
                                bodyMol.Page2.FItemID.FName = model.FName;
                                bodyMol.Page2.FItemID.FNumber = model.FNumber;
                                bodyMol.Page2.FBaseUnit = model.funit;
                                bodyMol.Page2.FQty = Math.Round(model.FQty, 6).ToString();
                                bodyMol.Page2.FAuxQty = Math.Round(model.FpoNum, 6).ToString();
                                bodyMol.Page2.Fauxprice = Math.Round(model.FAuxPrice, 6).ToString();
                                bodyMol.Page2.FAmount = Math.Round(model.FAmount, 6).ToString();
                                bodyMol.Page2.FCess = Math.Round(model.FCess, 2).ToString();
                                bodyMol.Page2.FPlanMode.FName = "MTS计划模式";
                                bodyMol.Page2.FPlanMode.FNumber = "MTS计划模式";
                                bodyMol.Page2.FCheckMethod.FName = "免检";
                                bodyMol.Page2.FCheckMethod.FNumber = "MJ";
                                bodyMol.Page2.Fdate1 = model.FDate1.ToString("yyyy-MM-dd");
                                bodyJson = JsonConvert.SerializeObject(bodyMol);
                                //获取Page2中的内容
                                var o = JObject.Parse(bodyJson);
                                bodyJson = o["Page2"].ToString();
                                BodyJsonStr += bodyJson + ",";
                            }
                        }
                        catch (Exception ex) {
                            common.WriteLogs(FileType, TaskID.ToString(), "Error----->" + ex.Message);
                        }
                        finally {
                            model.IsUpdate = "1";
                            Update(model);
                        }


                    }
                    BodyJsonStr = BodyJsonStr.TrimEnd(',');
                    BodyJsonStr = "\"Page2\":[" + BodyJsonStr + "]";

                    #endregion

                }
                SendJson = "{\"Data\":" + headJson + "," + BodyJsonStr + "}}";

                common.WriteLogs(FileType, TaskID.ToString(), " 序列化数据：" + SendJson);



                #region 发送数据
                loginUrl = APIUrl + "PO/Save?Token=" + apiEnv.Token;
                SeOrderResult result2 = common.SendToK3InSe(loginUrl, SendJson);
                if (result2.StatusCode == "200")
                {
                    common.WriteLogs(FileType, TaskID.ToString(), "K3集成成功!!");
                }
                else
                {
                    common.WriteLogs(FileType, TaskID.ToString(), "K3集成失败--->" + result2.Message);
                }
                #endregion

            }
            else
            {
                common.WriteLogs(FileType, "TaskID：Error");
            }




        }

        /// <summary>
        /// 采购订单 K3集成 完整版
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="APIUrl"></param>
        /// <param name="FuncName"></param>
        /// <param name="Token"></param>
        /// <param name="FileType"></param>
        public string AddPOOrderEntry(int TaskID, string APIUrl,string FuncName,string Token, string FileType)
        {
            K3JsonHelper helper = new K3JsonHelper();
            string headJson = string.Empty;
            string BodyJsonStr = string.Empty;
            string SendJson = string.Empty; 
            DataView dv = GetDetail(TaskID);
            if (dv.Count > 0)
            {
                JD_OrderListApply_Log model = Detail(Convert.ToInt32(dv[0]["ItemID"].ToString()));
                #region Page1 解析并序列化

                Json_POOrder_Head headMol = helper.GetPageMol<Json_POOrder_Head>(TaskID, APIUrl, FuncName, Token, FileType,Common.PageNum.Page1.ToString());
                if (headMol != null) {
                    headMol.Page1.FHeadSelfP0255.FName = model.BU;
                    headMol.Page1.FHeadSelfP0255.FNumber = model.BUCode;
                    headMol.Page1.FAreaPS.FName = model.OrderRange; //采购范围
                    headMol.Page1.FAreaPS.FNumber = model.OrderRangeCode;
                    headMol.Page1.FSettleID.FName = model.BalanceType;//结算方式
                    headMol.Page1.FSettleID.FNumber = model.BalanceTypeCode;
                    headMol.Page1.FPOStyle.FName = model.OrderType; //采购方式
                    headMol.Page1.FPOStyle.FNumber = model.OrderTypeCode;
                    headMol.Page1.FCurrencyID.FName = model.CoinType;//币别
                    headMol.Page1.FCurrencyID.FNumber = model.CoinTypeCode;
                    headMol.Page1.FPlanCategory.FName = model.PlanType;//计划类别
                    headMol.Page1.FPlanCategory.FNumber = model.PlanTypeCode;
                    headMol.Page1.FExchangeRateType.FName = model.RateType;//汇率类型
                    headMol.Page1.FExchangeRateType.FNumber = model.RateTypeCode;
                    headMol.Page1.FPOMode.FName = model.OrderMode;//采购模式
                    headMol.Page1.FPOMode.FNumber = model.OrderModeCode;
                    headMol.Page1.FCheckerID.FName = "";
                    headMol.Page1.FCheckerID.FNumber = "";

                    headMol.Page1.FMangerID.FName = model.FManageID;
                    headMol.Page1.FMangerID.FNumber = model.FManageIDCode;

                    headMol.Page1.FDeptID.FName = model.DeptID;
                    headMol.Page1.FDeptID.FNumber = model.DeptIDCode;


                    headMol.Page1.FEmpID.FName = model.FEmpID;
                    headMol.Page1.FEmpID.FNumber = model.FEmpIDCode;

                    //headMol.Page1.FBillerID.FName = "Sr.Sun";
                    //headMol.Page1.FBillerID.FNumber = "Sr.Sun";

                    headMol.Page1.FBillerID.FName = model.FBillerID;
                    headMol.Page1.FBillerID.FNumber = model.FBillerID;

                    headMol.Page1.FHeadSelfP0252 = "N";

                    headMol.Page1.FSysStatus = "2";
                    headMol.Page1.FSupplyID.FName = model.SupplierName;
                    headMol.Page1.FSupplyID.FNumber = model.SupplierCode;
                    headMol.Page1.FVersionNo = model.SupplierVersion;
                    headMol.Page1.FMultiCheckStatus = "16";
                    headMol.Page1.FExchangeRate = model.Rate;
                    headMol.Page1.Fdate = model.FDate.ToString("yyyy-MM-dd");
                }
              
                headJson = JsonConvert.SerializeObject(headMol);
                var o = JObject.Parse(headJson);
                headJson = o["Page1"].ToString();
                headJson = "\"Page1\":[" + headJson + "]";


                #endregion

                #region Page2 解析并序列化
               // bodyMol 初始化 
                Json_POOrder_Body bodyMol = helper.GetPageMol<Json_POOrder_Body>(TaskID, APIUrl, FuncName, Token, FileType, Common.PageNum.Page2.ToString());


                string bodyJson = string.Empty;
                BodyJsonStr = string.Empty;

                foreach (DataRowView dr in dv)
                {
                    try
                    {
                        model = Detail(Convert.ToInt32(dr["ItemID"]));
                        if (model != null)
                        {
                            bodyMol.Page2.FUnitID.FName = model.funit;
                            bodyMol.Page2.FUnitID.FNumber = model.funitID;
                            bodyMol.Page2.FItemName = model.FName;
                            bodyMol.Page2.FItemModel = model.FModel;
                            bodyMol.Page2.FItemID.FName = model.FName;
                            bodyMol.Page2.FItemID.FNumber = model.FNumber;
                            bodyMol.Page2.FBaseUnit = model.funit;
                            bodyMol.Page2.FQty = Math.Round(model.FQty, 6).ToString();
                            bodyMol.Page2.FAuxQty = Math.Round(model.FpoNum, 6).ToString();
                            bodyMol.Page2.Fauxprice = Math.Round(model.FAuxPrice, 6).ToString();
                            bodyMol.Page2.FAmount = Math.Round(model.FAmount, 6).ToString();
                            bodyMol.Page2.FCess = Math.Round(model.FCess, 2).ToString();
                            bodyMol.Page2.FPlanMode.FName = "MTS计划模式";
                            bodyMol.Page2.FPlanMode.FNumber = "MTS计划模式";
                            bodyMol.Page2.FCheckMethod.FName = "免检";
                            bodyMol.Page2.FCheckMethod.FNumber = "MJ";
                            bodyMol.Page2.Fdate1 = model.FDate1.ToString("yyyy-MM-dd");
                            bodyJson = JsonConvert.SerializeObject(bodyMol);
                            //获取Page2中的内容
                            o = JObject.Parse(bodyJson);
                            bodyJson = o["Page2"].ToString();
                            BodyJsonStr += bodyJson + ",";
                        }
                    }
                    catch (Exception ex)
                    {
                        common.WriteLogs(FileType, TaskID.ToString(), "Error----->" + ex.Message);
                    }
                    finally
                    {
                        model.IsUpdate = "1";
                        model.UpdateTime = DateTime.Now;
                        Update(model);
                    }


                }
                BodyJsonStr = BodyJsonStr.TrimEnd(',');
                BodyJsonStr = "\"Page2\":[" + BodyJsonStr + "]";

                #endregion

            }
            #region 数据合并序列化
            SendJson = "{\"Data\":{" + headJson + "," + BodyJsonStr + "}}"; 
            common.WriteLogs(FileType, TaskID.ToString(), " ------序列化数据--------" + SendJson);
            #endregion


            #region 发送数据
            string  loginUrl = APIUrl + FuncName+"/Save?Token=" + Token;
            Result result2 = common.SendToK3(loginUrl, SendJson);
            if (result2.StatusCode == "200")
            {
                common.WriteLogs(FileType, TaskID.ToString(), "K3集成成功!!");
                return result2.Message;
            }
            else
            {
                common.WriteLogs(FileType, "K3集成失败--->" + result2.Message);
                common.WriteLogs(FileType, TaskID.ToString(), "K3集成失败--->" + result2.Message);
                return "";
            }
            #endregion 
        }
        public DataView GetDetail(int TaskID)
        {
            string sql = string.Format(@" select * from JD_OrderListApply_Log where TaskID='{0}'", TaskID);
            return DBUtil.Query(sql).Tables[0].DefaultView;
        }

        /// <summary>
        /// 获取待轮询的TaskID
        /// </summary>
        /// <returns></returns>
        public DataView GetDistinctList()
        {
            string sql = string.Format(@" select  distinct TaskID from JD_OrderListApply_Log where IsUpdate='0'");
            return DBUtil.Query(sql).Tables[0].DefaultView;
        }

        //更新订单编号
        public void Updateordernum(int TaskID,string ordernum) {
            string sql = string.Format(@" update JD_OrderListApply set ordernum='{0}' where TaskID='{1}'", ordernum, TaskID.ToString());
            DBUtil.GetSingle(sql);
            sql = string.Format(@" update JD_OrderListApply_Log set ordernum='{0}' where TaskID='{1}'", ordernum, TaskID.ToString());
            DBUtil.GetSingle(sql);
        }

        //若是其他或者NPI的采购订单 则要更新关联数量
        //若关联数量等于请购数量 IsClosed状态从0到1 更新 表示状态关闭
        public void UpdateFLinkQty(string SNumber,string FNumber, decimal FQty) {
            JD_PORequestManageDal dal = new JD_PORequestManageDal();
            JD_PORequestManage model = dal.Detail(SNumber, FNumber);
            if (model != null) {
                model.FLinkQty += FQty;
                if (model.FLinkQty == model.FQty)
                {
                    model.IsClosed = 1;
                }
                dal.Update(model);
            }
        }

    }
}
