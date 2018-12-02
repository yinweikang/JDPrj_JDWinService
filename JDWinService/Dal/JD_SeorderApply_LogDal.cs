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
    public class JD_SeorderApply_LogDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息


        Common common = new Common();
        /// <summary>
        /// 对象JD_SeorderApply_Log明细
        /// 编写人：ywk
        /// 编写日期：2018/7/4 星期三
        /// </summary>
        public JD_SeorderApply_Log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_SeorderApply_Log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_SeorderApply_Log myDetail = new JD_SeorderApply_Log();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["Requester"])) { myDetail.Requester = Convert.ToString(myReader["Requester"]); }
                if (!Convert.IsDBNull(myReader["IsUpdate"])) { myDetail.IsUpdate = Convert.ToString(myReader["IsUpdate"]); }
                if (!Convert.IsDBNull(myReader["OrderNum"])) { myDetail.OrderNum = Convert.ToString(myReader["OrderNum"]); }
                if (!Convert.IsDBNull(myReader["SeorderType"])) { myDetail.SeorderType = Convert.ToString(myReader["SeorderType"]); }
                if (!Convert.IsDBNull(myReader["PlanType"])) { myDetail.PlanType = Convert.ToString(myReader["PlanType"]); }
                if (!Convert.IsDBNull(myReader["SalesType"])) { myDetail.SalesType = Convert.ToString(myReader["SalesType"]); }
                if (!Convert.IsDBNull(myReader["SalesRange"])) { myDetail.SalesRange = Convert.ToString(myReader["SalesRange"]); }
                if (!Convert.IsDBNull(myReader["RateType"])) { myDetail.RateType = Convert.ToString(myReader["RateType"]); }
                if (!Convert.IsDBNull(myReader["Rate"])) { myDetail.Rate = Convert.ToString(myReader["Rate"]); }
                if (!Convert.IsDBNull(myReader["CoinType"])) { myDetail.CoinType = Convert.ToString(myReader["CoinType"]); }
                if (!Convert.IsDBNull(myReader["SendAddress"])) { myDetail.SendAddress = Convert.ToString(myReader["SendAddress"]); }
                if (!Convert.IsDBNull(myReader["CheckAddress"])) { myDetail.CheckAddress = Convert.ToString(myReader["CheckAddress"]); }
                if (!Convert.IsDBNull(myReader["PurchaseUnit"])) { myDetail.PurchaseUnit = Convert.ToString(myReader["PurchaseUnit"]); }
                if (!Convert.IsDBNull(myReader["PurchaseUnitCode"])) { myDetail.PurchaseUnitCode = Convert.ToString(myReader["PurchaseUnitCode"]); }
                if (!Convert.IsDBNull(myReader["SeorderTypeCode"])) { myDetail.SeorderTypeCode = Convert.ToString(myReader["SeorderTypeCode"]); }
                if (!Convert.IsDBNull(myReader["PlanTypeCode"])) { myDetail.PlanTypeCode = Convert.ToString(myReader["PlanTypeCode"]); }
                if (!Convert.IsDBNull(myReader["SalesTypeCode"])) { myDetail.SalesTypeCode = Convert.ToString(myReader["SalesTypeCode"]); }
                if (!Convert.IsDBNull(myReader["SalesRangeCode"])) { myDetail.SalesRangeCode = Convert.ToString(myReader["SalesRangeCode"]); }
                if (!Convert.IsDBNull(myReader["RateTypeCode"])) { myDetail.RateTypeCode = Convert.ToString(myReader["RateTypeCode"]); }
                if (!Convert.IsDBNull(myReader["CoinTypeCode"])) { myDetail.CoinTypeCode = Convert.ToString(myReader["CoinTypeCode"]); }
                if (!Convert.IsDBNull(myReader["CreateTime"])) { myDetail.CreateTime = Convert.ToDateTime(myReader["CreateTime"]); }
                if (!Convert.IsDBNull(myReader["UpdateTime"])) { myDetail.UpdateTime = Convert.ToDateTime(myReader["UpdateTime"]); }
                if (!Convert.IsDBNull(myReader["SourceNum"])) { myDetail.SourceNum = Convert.ToString(myReader["SourceNum"]); }
                if (!Convert.IsDBNull(myReader["SourceLineNum"])) { myDetail.SourceLineNum = Convert.ToString(myReader["SourceLineNum"]); }
                if (!Convert.IsDBNull(myReader["CustomNum"])) { myDetail.CustomNum = Convert.ToString(myReader["CustomNum"]); }
                if (!Convert.IsDBNull(myReader["CustomLineNum"])) { myDetail.CustomLineNum = Convert.ToString(myReader["CustomLineNum"]); }
                if (!Convert.IsDBNull(myReader["CustomCode"])) { myDetail.CustomCode = Convert.ToString(myReader["CustomCode"]); }
                if (!Convert.IsDBNull(myReader["Name"])) { myDetail.Name = Convert.ToString(myReader["Name"]); }
                if (!Convert.IsDBNull(myReader["ProductCode"])) { myDetail.ProductCode = Convert.ToString(myReader["ProductCode"]); }
                if (!Convert.IsDBNull(myReader["PlanRemark"])) { myDetail.PlanRemark = Convert.ToString(myReader["PlanRemark"]); }
                if (!Convert.IsDBNull(myReader["ProductName"])) { myDetail.ProductName = Convert.ToString(myReader["ProductName"]); }
                if (!Convert.IsDBNull(myReader["Fmodel"])) { myDetail.Fmodel = Convert.ToString(myReader["Fmodel"]); }
                if (!Convert.IsDBNull(myReader["Unit"])) { myDetail.Unit = Convert.ToString(myReader["Unit"]); }
                if (!Convert.IsDBNull(myReader["FQty"])) { myDetail.FQty = Convert.ToDecimal(myReader["FQty"]); }
                if (!Convert.IsDBNull(myReader["MOQ"])) { myDetail.MOQ = Convert.ToDecimal(myReader["MOQ"]); }
                if (!Convert.IsDBNull(myReader["MiniOrderQty"])) { myDetail.MiniOrderQty = Convert.ToDecimal(myReader["MiniOrderQty"]); }
                if (!Convert.IsDBNull(myReader["IncreaseQty"])) { myDetail.IncreaseQty = Convert.ToDecimal(myReader["IncreaseQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxPrice"])) { myDetail.FAuxPrice = Convert.ToDecimal(myReader["FAuxPrice"]); }
                if (!Convert.IsDBNull(myReader["FTaxAuxPrice"])) { myDetail.FTaxAuxPrice = Convert.ToDecimal(myReader["FTaxAuxPrice"]); }
                if (!Convert.IsDBNull(myReader["FAuxAllPrice"])) { myDetail.FAuxAllPrice = Convert.ToDecimal(myReader["FAuxAllPrice"]); }
                if (!Convert.IsDBNull(myReader["XXRatePrice"])) { myDetail.XXRatePrice = Convert.ToDecimal(myReader["XXRatePrice"]); }
                if (!Convert.IsDBNull(myReader["FAllPrice"])) { myDetail.FAllPrice = Convert.ToDecimal(myReader["FAllPrice"]); }
                if (!Convert.IsDBNull(myReader["FIcItemLT"])) { myDetail.FIcItemLT = Convert.ToInt32(myReader["FIcItemLT"]); }
                if (!Convert.IsDBNull(myReader["LTDate"])) { myDetail.LTDate = Convert.ToDateTime(myReader["LTDate"]); }
                if (!Convert.IsDBNull(myReader["CustomDate"])) { myDetail.CustomDate = Convert.ToDateTime(myReader["CustomDate"]); }
                if (!Convert.IsDBNull(myReader["Remarks"])) { myDetail.Remarks = Convert.ToString(myReader["Remarks"]); }
                if (!Convert.IsDBNull(myReader["PPQ"])) { myDetail.PPQ = Convert.ToDecimal(myReader["PPQ"]); }
                if (!Convert.IsDBNull(myReader["FCess"])) { myDetail.FCess = Convert.ToDecimal(myReader["FCess"]); }
                if (!Convert.IsDBNull(myReader["UnitID"])) { myDetail.UnitID = Convert.ToString(myReader["UnitID"]); }
                if (!Convert.IsDBNull(myReader["FInterID"])) { myDetail.FInterID = Convert.ToInt32(myReader["FInterID"]); }
                if (!Convert.IsDBNull(myReader["FEntryID"])) { myDetail.FEntryID = Convert.ToInt32(myReader["FEntryID"]); }
                if (!Convert.IsDBNull(myReader["CheckID"])) { myDetail.CheckID = Convert.ToString(myReader["CheckID"]); }
                if (!Convert.IsDBNull(myReader["CheckDate"])) { myDetail.CheckDate = Convert.ToDateTime(myReader["CheckDate"]); }
                if (!Convert.IsDBNull(myReader["SettleID"])) { myDetail.SettleID = Convert.ToString(myReader["SettleID"]); }
                if (!Convert.IsDBNull(myReader["SettleIDCode"])) { myDetail.SettleIDCode = Convert.ToString(myReader["SettleIDCode"]); }
                if (!Convert.IsDBNull(myReader["DeptID"])) { myDetail.DeptID = Convert.ToString(myReader["DeptID"]); }
                if (!Convert.IsDBNull(myReader["DeptIDCode"])) { myDetail.DeptIDCode = Convert.ToString(myReader["DeptIDCode"]); }
                if (!Convert.IsDBNull(myReader["FEmpID"])) { myDetail.FEmpID = Convert.ToString(myReader["FEmpID"]); }
                if (!Convert.IsDBNull(myReader["FEmpIDCode"])) { myDetail.FEmpIDCode = Convert.ToString(myReader["FEmpIDCode"]); }
                if (!Convert.IsDBNull(myReader["FManageID"])) { myDetail.FManageID = Convert.ToString(myReader["FManageID"]); }
                if (!Convert.IsDBNull(myReader["FManageIDCode"])) { myDetail.FManageIDCode = Convert.ToString(myReader["FManageIDCode"]); }
                if (!Convert.IsDBNull(myReader["FBillerID"])) { myDetail.FBillerID = Convert.ToString(myReader["FBillerID"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["FBillNo"])) { myDetail.FBillNo = Convert.ToString(myReader["FBillNo"]); }
                if (!Convert.IsDBNull(myReader["CusNeedDate"])) { myDetail.CusNeedDate = Convert.ToDateTime(myReader["CusNeedDate"]); }
            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }

        /// <summary>
		/// 更新JD_SeorderApply_Log对象
		/// 编写人：ywk
		/// 编写日期：2018/7/4 星期三
		/// </summary>
		public void Update(JD_SeorderApply_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_SeorderApply_Log SET Requester = @m_Requester,IsUpdate = @m_IsUpdate,OrderNum = @m_OrderNum,SeorderType = @m_SeorderType,PlanType = @m_PlanType,SalesType = @m_SalesType,SalesRange = @m_SalesRange,RateType = @m_RateType,Rate = @m_Rate,CoinType = @m_CoinType,SendAddress = @m_SendAddress,CheckAddress = @m_CheckAddress,PurchaseUnit = @m_PurchaseUnit,PurchaseUnitCode = @m_PurchaseUnitCode,SeorderTypeCode = @m_SeorderTypeCode,PlanTypeCode = @m_PlanTypeCode,SalesTypeCode = @m_SalesTypeCode,SalesRangeCode = @m_SalesRangeCode,RateTypeCode = @m_RateTypeCode,CoinTypeCode = @m_CoinTypeCode,CreateTime = @m_CreateTime,UpdateTime = @m_UpdateTime,SourceNum = @m_SourceNum,SourceLineNum = @m_SourceLineNum,CustomNum = @m_CustomNum,CustomLineNum = @m_CustomLineNum,CustomCode = @m_CustomCode,Name = @m_Name,ProductCode = @m_ProductCode,PlanRemark = @m_PlanRemark,ProductName = @m_ProductName,Fmodel = @m_Fmodel,Unit = @m_Unit,FQty = @m_FQty,MOQ = @m_MOQ,MiniOrderQty = @m_MiniOrderQty,IncreaseQty = @m_IncreaseQty,FAuxPrice = @m_FAuxPrice,FTaxAuxPrice = @m_FTaxAuxPrice,FAuxAllPrice = @m_FAuxAllPrice,XXRatePrice = @m_XXRatePrice,FAllPrice = @m_FAllPrice,FIcItemLT = @m_FIcItemLT,LTDate = @m_LTDate,CustomDate = @m_CustomDate,Remarks = @m_Remarks,PPQ = @m_PPQ,FCess = @m_FCess,UnitID = @m_UnitID,FInterID = @m_FInterID,FEntryID = @m_FEntryID,CheckID = @m_CheckID,CheckDate = @m_CheckDate,SettleID = @m_SettleID,SettleIDCode = @m_SettleIDCode,DeptID = @m_DeptID,DeptIDCode = @m_DeptIDCode,FEmpID = @m_FEmpID,FEmpIDCode = @m_FEmpIDCode,FManageID = @m_FManageID,FManageIDCode = @m_FManageIDCode,FBillerID = @m_FBillerID,TaskID = @m_TaskID,FBillNo = @m_FBillNo,CusNeedDate = @m_CusNeedDate WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.Requester == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Requester", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Requester", SqlDbType.NVarChar, 50)).Value = model.Requester;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = model.IsUpdate;
            }
            if (model.OrderNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderNum", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderNum", SqlDbType.NVarChar, 50)).Value = model.OrderNum;
            }
            if (model.SeorderType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SeorderType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SeorderType", SqlDbType.NVarChar, 50)).Value = model.SeorderType;
            }
            if (model.PlanType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanType", SqlDbType.NVarChar, 50)).Value = model.PlanType;
            }
            if (model.SalesType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SalesType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SalesType", SqlDbType.NVarChar, 50)).Value = model.SalesType;
            }
            if (model.SalesRange == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SalesRange", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SalesRange", SqlDbType.NVarChar, 50)).Value = model.SalesRange;
            }
            if (model.RateType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_RateType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_RateType", SqlDbType.NVarChar, 50)).Value = model.RateType;
            }
            if (model.Rate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Rate", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Rate", SqlDbType.NVarChar, 50)).Value = model.Rate;
            }
            if (model.CoinType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinType", SqlDbType.NVarChar, 50)).Value = model.CoinType;
            }
            if (model.SendAddress == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SendAddress", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SendAddress", SqlDbType.NVarChar, 500)).Value = model.SendAddress;
            }
            if (model.CheckAddress == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CheckAddress", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CheckAddress", SqlDbType.NVarChar, 500)).Value = model.CheckAddress;
            }
            if (model.PurchaseUnit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PurchaseUnit", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PurchaseUnit", SqlDbType.NVarChar, 500)).Value = model.PurchaseUnit;
            }
            if (model.PurchaseUnitCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PurchaseUnitCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PurchaseUnitCode", SqlDbType.NVarChar, 50)).Value = model.PurchaseUnitCode;
            }
            if (model.SeorderTypeCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SeorderTypeCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SeorderTypeCode", SqlDbType.NVarChar, 50)).Value = model.SeorderTypeCode;
            }
            if (model.PlanTypeCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanTypeCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanTypeCode", SqlDbType.NVarChar, 50)).Value = model.PlanTypeCode;
            }
            if (model.SalesTypeCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SalesTypeCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SalesTypeCode", SqlDbType.NVarChar, 50)).Value = model.SalesTypeCode;
            }
            if (model.SalesRangeCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SalesRangeCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SalesRangeCode", SqlDbType.NVarChar, 50)).Value = model.SalesRangeCode;
            }
            if (model.RateTypeCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_RateTypeCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_RateTypeCode", SqlDbType.NVarChar, 50)).Value = model.RateTypeCode;
            }
            if (model.CoinTypeCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinTypeCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinTypeCode", SqlDbType.NVarChar, 50)).Value = model.CoinTypeCode;
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
            if (model.SourceNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SourceNum", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SourceNum", SqlDbType.NVarChar, 50)).Value = model.SourceNum;
            }
            if (model.SourceLineNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SourceLineNum", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SourceLineNum", SqlDbType.NVarChar, 50)).Value = model.SourceLineNum;
            }
            if (model.CustomNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomNum", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomNum", SqlDbType.NVarChar, 50)).Value = model.CustomNum;
            }
            if (model.CustomLineNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomLineNum", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomLineNum", SqlDbType.NVarChar, 50)).Value = model.CustomLineNum;
            }
            if (model.CustomCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomCode", SqlDbType.NVarChar, 50)).Value = model.CustomCode;
            }
            if (model.Name == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Name", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Name", SqlDbType.NVarChar, 50)).Value = model.Name;
            }
            if (model.ProductCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ProductCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ProductCode", SqlDbType.NVarChar, 50)).Value = model.ProductCode;
            }
            if (model.PlanRemark == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanRemark", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanRemark", SqlDbType.NVarChar, 500)).Value = model.PlanRemark;
            }
            if (model.ProductName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ProductName", SqlDbType.NText, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ProductName", SqlDbType.NText, 0)).Value = model.ProductName;
            }
            if (model.Fmodel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fmodel", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fmodel", SqlDbType.NVarChar, 50)).Value = model.Fmodel;
            }
            if (model.Unit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Unit", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Unit", SqlDbType.NVarChar, 50)).Value = model.Unit;
            }
            if (model.FQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 18)).Value = model.FQty;
            }
            if (model.MOQ == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.Decimal, 18)).Value = model.MOQ;
            }
            if (model.MiniOrderQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MiniOrderQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MiniOrderQty", SqlDbType.Decimal, 18)).Value = model.MiniOrderQty;
            }
            if (model.IncreaseQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IncreaseQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IncreaseQty", SqlDbType.Decimal, 18)).Value = model.IncreaseQty;
            }
            if (model.FAuxPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 18)).Value = model.FAuxPrice;
            }
            if (model.FTaxAuxPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxAuxPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxAuxPrice", SqlDbType.Decimal, 18)).Value = model.FTaxAuxPrice;
            }
            if (model.FAuxAllPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxAllPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxAllPrice", SqlDbType.Decimal, 18)).Value = model.FAuxAllPrice;
            }
            if (model.XXRatePrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_XXRatePrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_XXRatePrice", SqlDbType.Decimal, 18)).Value = model.XXRatePrice;
            }
            if (model.FAllPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllPrice", SqlDbType.Decimal, 18)).Value = model.FAllPrice;
            }
            if (model.FIcItemLT == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIcItemLT", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIcItemLT", SqlDbType.Int, 0)).Value = model.FIcItemLT;
            }
            if (model.LTDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_LTDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_LTDate", SqlDbType.DateTime, 0)).Value = model.LTDate;
            }
            if (model.CustomDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomDate", SqlDbType.DateTime, 0)).Value = model.CustomDate;
            }
            if (model.Remarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Remarks", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Remarks", SqlDbType.NVarChar, 500)).Value = model.Remarks;
            }
            if (model.PPQ == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PPQ", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PPQ", SqlDbType.Decimal, 18)).Value = model.PPQ;
            }
            if (model.FCess == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCess", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCess", SqlDbType.Decimal, 18)).Value = model.FCess;
            }
            if (model.UnitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_UnitID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_UnitID", SqlDbType.NVarChar, 50)).Value = model.UnitID;
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
            if (model.CheckID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CheckID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CheckID", SqlDbType.NVarChar, 50)).Value = model.CheckID;
            }
            if (model.CheckDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_CheckDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CheckDate", SqlDbType.DateTime, 0)).Value = model.CheckDate;
            }
            if (model.SettleID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SettleID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SettleID", SqlDbType.NVarChar, 50)).Value = model.SettleID;
            }
            if (model.SettleIDCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SettleIDCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SettleIDCode", SqlDbType.NVarChar, 50)).Value = model.SettleIDCode;
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
            if (model.TaskID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = model.TaskID;
            }
            if (model.FBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.NVarChar, 50)).Value = model.FBillNo;
            }
            if (model.CusNeedDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_CusNeedDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CusNeedDate", SqlDbType.DateTime, 0)).Value = model.CusNeedDate;
            }
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID;

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }


        /// <summary>
		/// 更新JD_SeorderApply_Log对象
		/// 编写人：ywk
		/// 编写日期：2018/7/4 星期三
        public void Update(string ItemID)
        {
            string sql = string.Format(@" update JD_SeorderApply_Log set IsUpdate='1' , UpdateTime='{0}' where ItemID='{1}'",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), ItemID);
            DBUtil.ExecuteSql(sql);
        }

        /// <summary>
        /// 获取需要更新的列表
        /// </summary>
        /// <returns></returns>
        public DataView GetUpdateList()
        {
            string sql = string.Format(@" select ItemID from JD_SeorderApply_Log where IsUpdate='0' ");
            return DBUtil.Query(sql).Tables[0].DefaultView;
        }
        /// <summary>
        /// 销售订单新增 集成 Demo版
        /// </summary>
        /// <param name="dv"></param>
        /// <param name="APIUrl"></param>
        /// <param name="APICode"></param>
        public void AddSeorder(DataView dv, string APIUrl, string APICode)
        {
            //获取需要的数据

            if (dv.Count > 0)
            {
                common.WriteLogs("销售订单申请集成开始");
                Json_SeOrder ordermodel = new Json_SeOrder();
                JD_SeorderApply_Log model = new JD_SeorderApply_Log();
                string SendJson = string.Empty;

                #region 获取模板
                ApiEnvironment apiEnv = new ApiEnvironment();
                apiEnv.init(APIUrl, APICode);
                string loginUrl = APIUrl + "SO/GetTemplate?Token=" + apiEnv.Token;

                HttpWebResponse response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, " ", null, null, Encoding.UTF8, null);
            
                Stream resStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(resStream, Encoding.UTF8);
                string htmlCode = sr.ReadToEnd();//获取返回JSON 
                //模板数据解析
                htmlCode = htmlCode.Substring(htmlCode.IndexOf("Data") + 6, htmlCode.Length - htmlCode.IndexOf("Data") - 6 - 1);
                htmlCode = htmlCode.Substring(htmlCode.IndexOf("Data") + 6, htmlCode.Length - htmlCode.IndexOf("Data") - 6 - 4);
                htmlCode = htmlCode.Replace('[', ' ').Replace(']', ' ');

                ordermodel = JsonConvert.DeserializeObject<Json_SeOrder>(htmlCode);
                #endregion
                foreach (DataRowView dr in dv)
                {
                    try
                    {
                        model = Detail(Convert.ToInt32(dr["ItemID"]));

                        #region Page1 表头数据
                        ordermodel.Page1.FCancellation = "false";
                        ordermodel.Page1.FClassTypeID = "0";
                        ordermodel.Page1.FHeadSelfS0140.FName = model.SeorderType;
                        ordermodel.Page1.FHeadSelfS0140.FNumber = model.SeorderTypeCode;

                       
                        ordermodel.Page1.FCustID.FName = model.PurchaseUnit; //购货单位
                         ordermodel.Page1.FCustID.FNumber = model.PurchaseUnitCode;
 

                        ordermodel.Page1.FSettleID.FName = model.SettleID;   //购货单位
                        ordermodel.Page1.FSettleID.FNumber = model.SettleIDCode;

                        ordermodel.Page1.FAreaPS.FName = model.SalesRange;  //销售范围
                        ordermodel.Page1.FAreaPS.FNumber = model.SalesRangeCode;

                        ordermodel.Page1.FSaleStyle.FName = model.SalesType;  //销售方式
                        ordermodel.Page1.FSaleStyle.FNumber = model.SalesTypeCode;

                        ordermodel.Page1.FBillNo = model.OrderNum;
                        ordermodel.Page1.FTranType = "81";
                        ordermodel.Page1.FCurrencyID.FName = model.CoinType; //币别
                        ordermodel.Page1.FCurrencyID.FNumber = model.CoinTypeCode;
                        ordermodel.Page1.FExchangeRate = model.Rate;

                        ordermodel.Page1.FExchangeRateType.FName = model.RateType;//汇率类型
                        ordermodel.Page1.FExchangeRateType.FNumber = model.RateTypeCode;

                        ordermodel.Page1.FCheckerID.FName = model.CheckID;
                        ordermodel.Page1.FCheckerID.FNumber = model.CheckID;
                        ordermodel.Page1.FDeptID.FName = model.DeptID;
                        ordermodel.Page1.FDeptID.FNumber = model.DeptIDCode;
                        ordermodel.Page1.FEmpID.FName = model.FEmpID;
                        ordermodel.Page1.FEmpID.FNumber =model.FEmpIDCode;
                        ordermodel.Page1.FMangerID.FName = model.FManageID;
                        ordermodel.Page1.FMangerID.FNumber = model.FManageIDCode; 

                        ordermodel.Page1.FPlanCategory.FName = model.PlanType;  //计划类别
                        ordermodel.Page1.FPlanCategory.FNumber = model.PlanTypeCode;
                        
                        ordermodel.Page1.FBillerID.FName = "Sr.Sun";
                        ordermodel.Page1.FBillerID.FNumber = "Sr.Sun";
                        
                        #endregion


                        #region Page2  采购订单明细数据
                        ordermodel.Page2.FEntrySelfS0153 = model.CustomNum;
                        ordermodel.Page2.FOrderEntryID = model.CustomLineNum;
                        ordermodel.Page2.FMapName = model.Name;
                        ordermodel.Page2.FDate1 = DateTime.Now.ToString("yyyy-MM-dd"); 
                        ordermodel.Page2.FItemID.FName = model.ProductName;
                        ordermodel.Page2.FItemID.FNumber = model.ProductCode;
                        ordermodel.Page2.Fnote = model.PlanRemark;
                        ordermodel.Page2.FItemModel = model.Fmodel; 
                        ordermodel.Page2.FUnitID.FName = model.Unit;
                        ordermodel.Page2.FUnitID.FNumber = model.UnitID; 
                        ordermodel.Page2.Fauxqty = Math.Round(model.FQty, 6).ToString();
                        ordermodel.Page2.FQty = Math.Round(model.FQty, 6).ToString();
                        ordermodel.Page2.FCess = Math.Round(model.FCess, 2).ToString(); 
                        ordermodel.Page2.Fauxprice = Math.Round(model.FAllPrice, 6).ToString();
                        ordermodel.Page2.FAuxTaxPrice = Math.Round(model.FTaxAuxPrice, 6).ToString();

                        //K3系统找不到 需要填写的字段
                        ordermodel.Page2.FPlanMode.FName = "MTS计划模式";
                        ordermodel.Page2.FPlanMode.FNumber = "MTS";

                        #endregion



                        #region K3 API集成

                        if (apiEnv.isOk)
                        {
                            #region Json数据处理
                            SendJson = JsonConvert.SerializeObject(ordermodel);
                            int index = SendJson.IndexOf(":");
                            SendJson = SendJson.Insert(index + 1, "[");
                            index = SendJson.IndexOf(",\"Page2\":");
                            SendJson = SendJson.Insert(index, "]");


                            index = SendJson.IndexOf("{\"FEntryID2\":");
                            SendJson = SendJson.Insert(index, "[");
                            index = SendJson.IndexOf("}}");
                            SendJson = SendJson.Insert(index + 1, "]");
                            common.WriteLogs("-----Json数据开始------");
                            common.WriteLogs("{\"Data\":" + SendJson + "}");
                            common.WriteLogs("-----Json数据结束------");
                            loginUrl = APIUrl + "SO/Save?Token=" + apiEnv.Token;

                            #endregion

                            //发送数据
                            SeOrderResult result =common.SendToK3InSe(loginUrl, "{\"Data\":" + SendJson + "}");
                            if (result.StatusCode == "200") {
                                model.FBillNo = result.Message;
                            }

                        }
                        else
                        {
                            common.WriteLogs("销售订单申请集成APIErroe:");
                        }
                        #endregion


                    }
                    catch (Exception ex)
                    {
                        common.WriteLogs("销售订单申请集成Error:" + ex.Message);
                    }
                    finally
                    {
                        //更新发送列表
                        Update(model.ItemID.ToString());
                    }

                }
                common.WriteLogs("销售订单申请集成结束");
            }


        }

        /// <summary>
        /// 销售订单新增 集成 正式版 
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="APIUrl"></param>
        /// <param name="FuncName"></param>
        /// <param name="Token"></param>
        /// <param name="FileType"></param>
        /// <returns></returns>
        public string AddSeorder(int TaskID, string APIUrl, string FuncName, string Token, string FileType)
        {
            K3JsonHelper helper = new K3JsonHelper();
            string ErrorMsg = string.Empty;
            string headJson = string.Empty;
            string BodyJsonStr = string.Empty;
            string SendJson = string.Empty;
            string FDate = string.Empty;
            DataView dv = GetDetail(TaskID);
            if (dv.Count > 0)
            {
                JD_SeorderApply_Log model = Detail(Convert.ToInt32(dv[0]["ItemID"].ToString()));
                FDate = model.CreateTime.ToString("yyyy-MM-dd");
                #region Page1 解析并序列化
                Json_SOOrder_Head headMol = helper.GetPageMol<Json_SOOrder_Head>(TaskID, APIUrl, FuncName, Token, FileType, Common.PageNum.Page1.ToString());
                 if (headMol != null)
                {
                    headMol.Page1.FCancellation = "false";
                    headMol.Page1.FClassTypeID = "0";
                    headMol.Page1.FHeadSelfS0140.FName = model.SeorderType;
                    headMol.Page1.FHeadSelfS0140.FNumber = model.SeorderTypeCode;
                    headMol.Page1.FStatus = "1";
                    

                    headMol.Page1.FCustID.FName = model.PurchaseUnit; //购货单位
                    headMol.Page1.FCustID.FNumber = model.PurchaseUnitCode;


                    headMol.Page1.FSettleID.FName = model.SettleID;   //购货单位
                    headMol.Page1.FSettleID.FNumber = model.SettleIDCode;

                    headMol.Page1.FAreaPS.FName = model.SalesRange;  //销售范围
                    headMol.Page1.FAreaPS.FNumber = model.SalesRangeCode;

                    headMol.Page1.FSaleStyle.FName = model.SalesType;  //销售方式
                    headMol.Page1.FSaleStyle.FNumber = model.SalesTypeCode;

                    headMol.Page1.FBillNo = model.OrderNum;
                    headMol.Page1.FTranType = "81";
                    headMol.Page1.FCurrencyID.FName = model.CoinType; //币别
                    headMol.Page1.FCurrencyID.FNumber = model.CoinTypeCode;
                    headMol.Page1.FExchangeRate = model.Rate;

                    headMol.Page1.FExchangeRateType.FName = model.RateType;//汇率类型
                    headMol.Page1.FExchangeRateType.FNumber = model.RateTypeCode;

                    headMol.Page1.FCheckerID.FName = model.CheckID;
                    headMol.Page1.FCheckerID.FNumber = model.CheckID;
                    headMol.Page1.FDeptID.FName = model.DeptID;
                    headMol.Page1.FDeptID.FNumber = model.DeptIDCode;
                    headMol.Page1.FEmpID.FName = model.FEmpID;
                    headMol.Page1.FEmpID.FNumber = model.FEmpIDCode;
                    headMol.Page1.FMangerID.FName = model.FManageID;
                    headMol.Page1.FMangerID.FNumber = model.FManageIDCode;

                    headMol.Page1.FPlanCategory.FName = model.PlanType;  //计划类别
                    headMol.Page1.FPlanCategory.FNumber = model.PlanTypeCode;

                    headMol.Page1.FBillerID.FName = model.FBillerID;
                    headMol.Page1.FBillerID.FNumber = model.FBillerID;
                }

                headJson = JsonConvert.SerializeObject(headMol);
                var o = JObject.Parse(headJson);
                headJson = o["Page1"].ToString();
                headJson = "\"Page1\":[" + headJson + "]"; 

                #endregion

                #region Page2 解析并序列化
                // bodyMol 初始化 
                Json_SOOrder_Body bodyMol= helper.GetPageMol<Json_SOOrder_Body>(TaskID, APIUrl, FuncName, Token, FileType, Common.PageNum.Page2.ToString());
                 
                string bodyJson = string.Empty;
                BodyJsonStr = string.Empty;

                foreach (DataRowView dr in dv)
                {
                    try
                    {
                        model = Detail(Convert.ToInt32(dr["ItemID"]));
                        if (model != null)
                        {
                            
                            bodyMol.Page2.FEntrySelfS0153 = model.CustomNum;
                            bodyMol.Page2.FOrderEntryID = model.CustomLineNum;
                            bodyMol.Page2.FMapName = model.Name;
                            bodyMol.Page2.FDate1 = DateTime.Now.ToString("yyyy-MM-dd");
                            bodyMol.Page2.FItemID.FName = model.ProductName;
                            bodyMol.Page2.FItemID.FNumber = model.ProductCode;
                            bodyMol.Page2.Fnote = model.PlanRemark;
                            bodyMol.Page2.FItemModel = model.Fmodel;
                            bodyMol.Page2.FUnitID.FName = model.Unit;
                            bodyMol.Page2.FUnitID.FNumber = model.UnitID;
                            bodyMol.Page2.Fauxqty = Math.Round(model.FQty, 6).ToString();
                            bodyMol.Page2.FQty = Math.Round(model.FQty, 6).ToString();
                            bodyMol.Page2.FCess = Math.Round(model.FCess, 2).ToString();
                            bodyMol.Page2.Fauxprice = Math.Round(model.FAllPrice, 6).ToString();
                            bodyMol.Page2.FAuxTaxPrice = Math.Round(model.FTaxAuxPrice, 6).ToString();
                            bodyMol.Page2.FEntrySelfS0155 = model.CusNeedDate.ToString("yyyy-MM-dd");
                            //K3系统找不到 需要填写的字段
                            bodyMol.Page2.FPlanMode.FName = "MTS计划模式";
                            bodyMol.Page2.FPlanMode.FNumber = "MTS";

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
                        ErrorMsg+= ex.Message;
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
            string loginUrl = APIUrl + FuncName + "/Save?Token=" + Token;
            Result result2 = common.SendToK3(loginUrl, SendJson);
            if (result2.StatusCode == "200")
            {
                UpdateFDate(FDate, result2.Message);
                common.WriteLogs(FileType, TaskID.ToString(), "K3集成成功!!");
                common.AddLogQueue(TaskID, "JD_SeOrderApply_Log", 0, "API", "销售订单号：" + result2.Message, true);
                return result2.Message;
            }
            else
            { 
                common.WriteLogs(FileType, TaskID.ToString(), "K3集成失败--->" + result2.Message);
                if (!string.IsNullOrEmpty(ErrorMsg)) {
                    ErrorMsg = "系统错误：" + ErrorMsg;
                }
                ErrorMsg += "API返回错误信息：" + result2.Message;
                common.AddLogQueue(TaskID, "JD_SeOrderApply_Log", 0, "API", ErrorMsg, false);
                return "";
            }
            #endregion


        }

        protected void UpdatePO(int FInterID, int FEntryID, decimal FselQty)
        {
            // PPOrderEntry 关联数量更新
            // 当数量变更时 FSaleQty FSelQty 也要更新
            PPOrderEntryDal entrydal = new PPOrderEntryDal();
            PPOrderDal orderdal = new PPOrderDal();
            PPOrderEntry model = entrydal.Detail(FInterID, FEntryID);
            model.FSaleQty += FselQty;
            model.FSelQty += FselQty;
            entrydal.Update(model);


            //PPOrder 行关闭标志更新
            if (model.FQty == model.FSaleQty)
            {
                PPOrder ppmodel = orderdal.Detail(FInterID);
                if (ppmodel != null)
                {
                    ppmodel.FMrpClosed = 1;
                    orderdal.Update(ppmodel);
                }
            }


        }

        protected void UpdateFDate(string FDate, string FbillNo)
        {
            if (!string.IsNullOrEmpty(FbillNo))
            {
                string sql = string.Format(@" update SEOrder set FDate='{0}' where FBillNo='{1}'", FDate, FbillNo);
                DBUtil.ExecuteSql(sql, K3connectionString);
            }
        }

        public DataView GetDetail(int TaskID)
        {
            string sql = string.Format(@" select * from JD_SeOrderApply_Log where TaskID='{0}'", TaskID);
            return DBUtil.Query(sql).Tables[0].DefaultView;
        }
        public void Test(string APIUrl, string APICode)
        {
            ApiEnvironment apiEnv = new ApiEnvironment();
            apiEnv.init(APIUrl, APICode);
            string loginUrl = APIUrl + "SO/Save?Token=" + apiEnv.Token;


            FileStream fs = new FileStream(@"D:\MyPrj\2018_苏州矩度\代码\JDWinService\JDWinService\Test.txt", FileMode.Open, FileAccess.Read);
            //仅 对文本 执行  读写操作     
            System.Text.Encoding code = System.Text.Encoding.GetEncoding("gb2312");
            StreamReader sr = new StreamReader(fs, code);
           
            string Json = sr.ReadToEnd();
            HttpWebResponse response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, Json, null, null, Encoding.UTF8, null);
            Stream resStream = response.GetResponseStream();
            StreamReader sr2 = new StreamReader(resStream, Encoding.UTF8);
            string htmlCode = sr2.ReadToEnd();//获取返回JSON
            common.WriteLogs("htmlCode:" + htmlCode);
            sr.Close();
            fs.Close();


        }

        //更新订单编号
        public void Updateordernum(int TaskID, string ordernum)
        {
            string sql = string.Format(@" update JD_SeorderApply set ordernum='{0}' where TaskID='{1}'", ordernum, TaskID.ToString());
            DBUtil.GetSingle(sql);
            sql = string.Format(@" update JD_SeorderApply_Log set ordernum='{0}' where TaskID='{1}'", ordernum, TaskID.ToString());
            DBUtil.GetSingle(sql);
        }

        /// <summary>
        /// 获取待轮询的TaskID
        /// </summary>
        /// <returns></returns>
        public DataView GetDistinctList()
        {
            string sql = string.Format(@" select  distinct TaskID from JD_SeorderApply_Log where IsUpdate='0'");
            return DBUtil.Query(sql).Tables[0].DefaultView;
        }

        public DataView GetUpdateInfo(string TaskID)
        {
            string sql = string.Format(@" select  * from JD_SeorderApply_Log where TaskID='{0}'",TaskID);
            return DBUtil.Query(sql).Tables[0].DefaultView;
        }
    }
}
