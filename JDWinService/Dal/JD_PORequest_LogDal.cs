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
    //请购单日志
    public class JD_PORequest_LogDal
    {
        Common common = new Common();
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息

        /// <summary>
		/// 对象JD_PORequest_Log明细
		/// 编写人：ywk
		/// 编写日期：2018/7/31 星期二
		/// </summary>
		public JD_PORequest_Log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_PORequest_Log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_PORequest_Log myDetail = new JD_PORequest_Log();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["IsUpdate"])) { myDetail.IsUpdate = Convert.ToString(myReader["IsUpdate"]); }
                if (!Convert.IsDBNull(myReader["CreateTime"])) { myDetail.CreateTime = Convert.ToDateTime(myReader["CreateTime"]); }
                if (!Convert.IsDBNull(myReader["UpdateTime"])) { myDetail.UpdateTime = Convert.ToDateTime(myReader["UpdateTime"]); }
                if (!Convert.IsDBNull(myReader["Operater"])) { myDetail.Operater = Convert.ToString(myReader["Operater"]); }
                if (!Convert.IsDBNull(myReader["CheckID"])) { myDetail.CheckID = Convert.ToString(myReader["CheckID"]); }
                if (!Convert.IsDBNull(myReader["BusinessType"])) { myDetail.BusinessType = Convert.ToString(myReader["BusinessType"]); }
                if (!Convert.IsDBNull(myReader["BusinessTypeCode"])) { myDetail.BusinessTypeCode = Convert.ToString(myReader["BusinessTypeCode"]); }
                if (!Convert.IsDBNull(myReader["PlanType"])) { myDetail.PlanType = Convert.ToString(myReader["PlanType"]); }
                if (!Convert.IsDBNull(myReader["PlanTypeCode"])) { myDetail.PlanTypeCode = Convert.ToString(myReader["PlanTypeCode"]); }
                if (!Convert.IsDBNull(myReader["ordernum"])) { myDetail.ordernum = Convert.ToString(myReader["ordernum"]); }
                if (!Convert.IsDBNull(myReader["Remarks"])) { myDetail.Remarks = Convert.ToString(myReader["Remarks"]); }
                if (!Convert.IsDBNull(myReader["FBillNo"])) { myDetail.FBillNo = Convert.ToString(myReader["FBillNo"]); }
                if (!Convert.IsDBNull(myReader["FInterID"])) { myDetail.FInterID = Convert.ToInt32(myReader["FInterID"]); }
                if (!Convert.IsDBNull(myReader["FEntryID"])) { myDetail.FEntryID = Convert.ToInt32(myReader["FEntryID"]); }
                if (!Convert.IsDBNull(myReader["FNumber"])) { myDetail.FNumber = Convert.ToString(myReader["FNumber"]); }
                if (!Convert.IsDBNull(myReader["FName"])) { myDetail.FName = Convert.ToString(myReader["FName"]); }
                if (!Convert.IsDBNull(myReader["FModel"])) { myDetail.FModel = Convert.ToString(myReader["FModel"]); }
                if (!Convert.IsDBNull(myReader["Funit"])) { myDetail.Funit = Convert.ToString(myReader["Funit"]); }
                if (!Convert.IsDBNull(myReader["FUnitID"])) { myDetail.FUnitID = Convert.ToString(myReader["FUnitID"]); }
                if (!Convert.IsDBNull(myReader["FNeedQty"])) { myDetail.FNeedQty = Convert.ToDecimal(myReader["FNeedQty"]); }
                if (!Convert.IsDBNull(myReader["FQty"])) { myDetail.FQty = Convert.ToDecimal(myReader["FQty"]); }
                if (!Convert.IsDBNull(myReader["DetailRemarks"])) { myDetail.DetailRemarks = Convert.ToString(myReader["DetailRemarks"]); }
                if (!Convert.IsDBNull(myReader["FFixLeadTime"])) { myDetail.FFixLeadTime = Convert.ToString(myReader["FFixLeadTime"]); }
                if (!Convert.IsDBNull(myReader["FAdmit"])) { myDetail.FAdmit = Convert.ToString(myReader["FAdmit"]); }
                if (!Convert.IsDBNull(myReader["FFetchTime"])) { myDetail.FFetchTime = Convert.ToDateTime(myReader["FFetchTime"]); }
                if (!Convert.IsDBNull(myReader["FQtyMin"])) { myDetail.FQtyMin = Convert.ToDecimal(myReader["FQtyMin"]); }
                if (!Convert.IsDBNull(myReader["FBatchAppendQty"])) { myDetail.FBatchAppendQty = Convert.ToDecimal(myReader["FBatchAppendQty"]); }
                if (!Convert.IsDBNull(myReader["Flimitprice"])) { myDetail.Flimitprice = Convert.ToString(myReader["Flimitprice"]); }
                if (!Convert.IsDBNull(myReader["FOpenPo"])) { myDetail.FOpenPo = Convert.ToDecimal(myReader["FOpenPo"]); }
                if (!Convert.IsDBNull(myReader["Fpoqty"])) { myDetail.Fpoqty = Convert.ToDecimal(myReader["Fpoqty"]); }
                if (!Convert.IsDBNull(myReader["Fpoqty1"])) { myDetail.Fpoqty1 = Convert.ToDecimal(myReader["Fpoqty1"]); }
                if (!Convert.IsDBNull(myReader["Fpoqty2"])) { myDetail.Fpoqty2 = Convert.ToDecimal(myReader["Fpoqty2"]); }
                if (!Convert.IsDBNull(myReader["Fstockqty"])) { myDetail.Fstockqty = Convert.ToDecimal(myReader["Fstockqty"]); }
                if (!Convert.IsDBNull(myReader["PackageInfo"])) { myDetail.PackageInfo = Convert.ToString(myReader["PackageInfo"]); }
                if (!Convert.IsDBNull(myReader["FSecInv"])) { myDetail.FSecInv = Convert.ToDecimal(myReader["FSecInv"]); }
                if (!Convert.IsDBNull(myReader["FSourceInterId"])) { myDetail.FSourceInterId = Convert.ToString(myReader["FSourceInterId"]); }
                if (!Convert.IsDBNull(myReader["FSourceBillNo"])) { myDetail.FSourceBillNo = Convert.ToString(myReader["FSourceBillNo"]); }
                if (!Convert.IsDBNull(myReader["FSourceEntryID"])) { myDetail.FSourceEntryID = Convert.ToString(myReader["FSourceEntryID"]); }
                if (!Convert.IsDBNull(myReader["Fsupname"])) { myDetail.Fsupname = Convert.ToString(myReader["Fsupname"]); }
                if (!Convert.IsDBNull(myReader["FsupNum"])) { myDetail.FsupNum = Convert.ToString(myReader["FsupNum"]); }
                if (!Convert.IsDBNull(myReader["FsupplyID"])) { myDetail.FsupplyID = Convert.ToString(myReader["FsupplyID"]); }
                if (!Convert.IsDBNull(myReader["CostPrice"])) { myDetail.CostPrice = Convert.ToDecimal(myReader["CostPrice"]); }
                if (!Convert.IsDBNull(myReader["TypeNumber"])) { myDetail.TypeNumber = Convert.ToString(myReader["TypeNumber"]); }
                if (!Convert.IsDBNull(myReader["ProductName"])) { myDetail.ProductName = Convert.ToString(myReader["ProductName"]); }
                if (!Convert.IsDBNull(myReader["FAuxPrice"])) { myDetail.FAuxPrice = Convert.ToDecimal(myReader["FAuxPrice"]); }
                if (!Convert.IsDBNull(myReader["Fcess"])) { myDetail.Fcess = Convert.ToInt32(myReader["Fcess"]); }
                if (!Convert.IsDBNull(myReader["FAmount"])) { myDetail.FAmount = Convert.ToDecimal(myReader["FAmount"]); }
                if (!Convert.IsDBNull(myReader["FTaxAmount"])) { myDetail.FTaxAmount = Convert.ToDecimal(myReader["FTaxAmount"]); }
                if (!Convert.IsDBNull(myReader["SNumber"])) { myDetail.SNumber = Convert.ToString(myReader["SNumber"]); }
                if (!Convert.IsDBNull(myReader["LogType"])) { myDetail.LogType = Convert.ToString(myReader["LogType"]); }
                if (!Convert.IsDBNull(myReader["FQtyNew"])) { myDetail.FQtyNew = Convert.ToDecimal(myReader["FQtyNew"]); }
                if (!Convert.IsDBNull(myReader["REQType"])) { myDetail.REQType = Convert.ToString(myReader["REQType"]); }

            }
            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        /// <summary>
        /// 更新JD_PORequest_Log对象
        /// 编写人：ywk
        /// 编写日期：2018/7/31 星期二
        /// </summary>
        public void Update(JD_PORequest_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_PORequest_Log SET TaskID = @m_TaskID,IsUpdate = @m_IsUpdate,CreateTime = @m_CreateTime,UpdateTime = @m_UpdateTime,Operater = @m_Operater,CheckID = @m_CheckID,BusinessType = @m_BusinessType,BusinessTypeCode = @m_BusinessTypeCode,PlanType = @m_PlanType,PlanTypeCode = @m_PlanTypeCode,ordernum = @m_ordernum,Remarks = @m_Remarks,FBillNo = @m_FBillNo,FInterID = @m_FInterID,FEntryID = @m_FEntryID,FNumber = @m_FNumber,FName = @m_FName,FModel = @m_FModel,Funit = @m_Funit,FUnitID = @m_FUnitID,FNeedQty = @m_FNeedQty,FQty = @m_FQty,DetailRemarks = @m_DetailRemarks,FFixLeadTime = @m_FFixLeadTime,FAdmit = @m_FAdmit,FFetchTime = @m_FFetchTime,FQtyMin = @m_FQtyMin,FBatchAppendQty = @m_FBatchAppendQty,Flimitprice = @m_Flimitprice,FOpenPo = @m_FOpenPo,Fpoqty = @m_Fpoqty,Fpoqty1 = @m_Fpoqty1,Fpoqty2 = @m_Fpoqty2,Fstockqty = @m_Fstockqty,PackageInfo = @m_PackageInfo,FSecInv = @m_FSecInv,FSourceInterId = @m_FSourceInterId,FSourceBillNo = @m_FSourceBillNo,FSourceEntryID = @m_FSourceEntryID,Fsupname = @m_Fsupname,FsupNum = @m_FsupNum,FsupplyID = @m_FsupplyID,CostPrice = @m_CostPrice,TypeNumber = @m_TypeNumber,ProductName = @m_ProductName,FAuxPrice = @m_FAuxPrice,Fcess = @m_Fcess,FAmount = @m_FAmount,FTaxAmount = @m_FTaxAmount,SNumber = @m_SNumber,LogType = @m_LogType,FQtyNew = @m_FQtyNew,REQType = @m_REQType WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.TaskID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = model.TaskID;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.NVarChar, 50)).Value = model.IsUpdate;
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
            if (model.Operater == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = model.Operater;
            }
            if (model.CheckID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CheckID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CheckID", SqlDbType.NVarChar, 50)).Value = model.CheckID;
            }
            if (model.BusinessType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BusinessType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BusinessType", SqlDbType.NVarChar, 50)).Value = model.BusinessType;
            }
            if (model.BusinessTypeCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BusinessTypeCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BusinessTypeCode", SqlDbType.NVarChar, 50)).Value = model.BusinessTypeCode;
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
            if (model.ordernum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ordernum", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ordernum", SqlDbType.NVarChar, 50)).Value = model.ordernum;
            }
            if (model.Remarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Remarks", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Remarks", SqlDbType.NVarChar, 500)).Value = model.Remarks;
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
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 100)).Value = model.FNumber;
            }
            if (model.FName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.NVarChar, 100)).Value = model.FName;
            }
            if (model.FModel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = model.FModel;
            }
            if (model.Funit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Funit", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Funit", SqlDbType.NVarChar, 50)).Value = model.Funit;
            }
            if (model.FUnitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.NVarChar, 50)).Value = model.FUnitID;
            }
            if (model.FNeedQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNeedQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNeedQty", SqlDbType.Decimal, 18)).Value = model.FNeedQty;
            }
            if (model.FQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 18)).Value = model.FQty;
            }
            if (model.DetailRemarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_DetailRemarks", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_DetailRemarks", SqlDbType.NVarChar, 500)).Value = model.DetailRemarks;
            }
            if (model.FFixLeadTime == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFixLeadTime", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFixLeadTime", SqlDbType.NVarChar, 50)).Value = model.FFixLeadTime;
            }
            if (model.FAdmit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAdmit", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAdmit", SqlDbType.NVarChar, 50)).Value = model.FAdmit;
            }
            if (model.FFetchTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFetchTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFetchTime", SqlDbType.DateTime, 0)).Value = model.FFetchTime;
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
            if (model.Flimitprice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Flimitprice", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Flimitprice", SqlDbType.NVarChar, 50)).Value = model.Flimitprice;
            }
            if (model.FOpenPo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOpenPo", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOpenPo", SqlDbType.Decimal, 18)).Value = model.FOpenPo;
            }
            if (model.Fpoqty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fpoqty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fpoqty", SqlDbType.Decimal, 18)).Value = model.Fpoqty;
            }
            if (model.Fpoqty1 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fpoqty1", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fpoqty1", SqlDbType.Decimal, 18)).Value = model.Fpoqty1;
            }
            if (model.Fpoqty2 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fpoqty2", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fpoqty2", SqlDbType.Decimal, 18)).Value = model.Fpoqty2;
            }
            if (model.Fstockqty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fstockqty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fstockqty", SqlDbType.Decimal, 18)).Value = model.Fstockqty;
            }
            if (model.PackageInfo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PackageInfo", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PackageInfo", SqlDbType.NVarChar, 500)).Value = model.PackageInfo;
            }
            if (model.FSecInv == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecInv", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecInv", SqlDbType.Decimal, 18)).Value = model.FSecInv;
            }
            if (model.FSourceInterId == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceInterId", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceInterId", SqlDbType.NVarChar, 50)).Value = model.FSourceInterId;
            }
            if (model.FSourceBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceBillNo", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceBillNo", SqlDbType.NVarChar, 50)).Value = model.FSourceBillNo;
            }
            if (model.FSourceEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.NVarChar, 50)).Value = model.FSourceEntryID;
            }
            if (model.Fsupname == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fsupname", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fsupname", SqlDbType.NVarChar, 50)).Value = model.Fsupname;
            }
            if (model.FsupNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FsupNum", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FsupNum", SqlDbType.NVarChar, 50)).Value = model.FsupNum;
            }
            if (model.FsupplyID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FsupplyID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FsupplyID", SqlDbType.NVarChar, 50)).Value = model.FsupplyID;
            }
            if (model.CostPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CostPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CostPrice", SqlDbType.Decimal, 18)).Value = model.CostPrice;
            }
            if (model.TypeNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TypeNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TypeNumber", SqlDbType.NVarChar, 50)).Value = model.TypeNumber;
            }
            if (model.ProductName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ProductName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ProductName", SqlDbType.NVarChar, 50)).Value = model.ProductName;
            }
            if (model.FAuxPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 18)).Value = model.FAuxPrice;
            }
            if (model.Fcess == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fcess", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fcess", SqlDbType.Int, 0)).Value = model.Fcess;
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
            if (model.SNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = model.SNumber;
            }
            if (model.LogType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_LogType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_LogType", SqlDbType.NVarChar, 50)).Value = model.LogType;
            }
            if (model.FQtyNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyNew", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyNew", SqlDbType.Decimal, 18)).Value = model.FQtyNew;
            }
            if (model.REQType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_REQType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_REQType", SqlDbType.NVarChar, 50)).Value = model.REQType;
            }
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID;

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        /// <summary>
        /// 获取需要转换的单位
        /// </summary>
        /// <param name="FUnitID"></param>
        /// <returns></returns>
        protected string MeasureUnit(string FUnitID)
        {
            string Sql = string.Format(@" select FCoefficient from t_measureUnit where FStandard='0' and FNumber='{0}' and FCoefficient!='1' ", FUnitID);
            object obj = DBUtil.GetSingle(Sql, K3connectionString);
            return (obj == null) ? "" : obj.ToString();
        }

        /// <summary>
        /// K3集成 请购单更新
        /// </summary>
        /// <param name="ItemID"></param>
        /// <param name="FileName"></param>
        public void UpdatePORequest_Apply(int ItemID, string FileName)
        {
            JD_PORequest_Log model = Detail(ItemID);
            string Sql = string.Empty;
            string LogMsg = string.Empty;
            string FUserID = string.Empty;
            if (model != null)
            {
                try
                {
                    decimal FAuxQty = model.FQty;

                    #region 更新PORequestEntry 的FAuxQty
                    string FCoefient = MeasureUnit(model.FUnitID);
                    if (!string.IsNullOrEmpty(FCoefient))
                    {
                        decimal Fient = Convert.ToDecimal(FCoefient);
                        FAuxQty = Math.Round(model.FQty / Fient, 10);
                    }
                    Sql = string.Format(@"update PORequestEntry set FQty='{0}',FAuxQty='{1}' where FInterID='{2}' and FEntryID='{3}'",
                        model.FQty.ToString("f10"), FAuxQty.ToString("f10"), model.FInterID, model.FEntryID);
                    DBUtil.ExecuteSql(Sql, K3connectionString);
                    #endregion


                    #region 更新表头
                    Sql = string.Format(@"select top 1 FUserID from t_Base_User where FName='{0}' ", model.CheckID);
                    object obj = DBUtil.GetSingle(Sql, K3connectionString);

                    if (obj == null)
                    {
                        throw new Exception("未能在系统中找到和K3匹配的FUserID");
                    }
                    else {
                        Sql = string.Format(@" update PORequest set FCheckerID=(select top 1 FUserID from t_Base_User where FName='{0}'),
                                     FCheckTime='{1}',fstatus=1,FNote='{3}',FCheckDate='{1}' where FInterID='{2}' ",
                                     model.CheckID, model.CreateTime.ToString("yyyy-MM-dd"), model.FInterID, model.Remarks);
                        DBUtil.ExecuteSql(Sql, K3connectionString);
                    }  
                    #endregion

                }
                catch (Exception ex)
                {
                    common.WriteLogs(FileName, ItemID.ToString(), ex.Message);
                    common.AddLogQueue(0, "物料请购单"+ model.LogType, ItemID, "SQL", ex.Message, false);
                }
                finally
                {
                    //更新发送标志
                    model.IsUpdate = "1";
                    model.UpdateTime = DateTime.Now;
                    Update(model);
                }

            }
            else
            {
                common.WriteLogs(FileName, ItemID.ToString(), "对象为空！");
            }
        }

        /// <summary>
        /// 获取待轮询的TaskID
        /// </summary>
        /// <returns></returns>
        public DataView GetDistinctList()
        {
            string sql = string.Format(@" select  * from JD_PORequest_Log where IsUpdate='0' ");
            return DBUtil.Query(sql).Tables[0].DefaultView;
        }
        /// <summary>
        /// 请购单变更数量 更新Manage表数据
        /// </summary>
        /// <param name="ItemID"></param>
        /// <param name="FileName"></param>
        public void UpdatePORequest_NumBG(int ItemID, string FileName)
        {
            //获取待更新的Log 数据明细
            JD_PORequest_Log logmodel = Detail(ItemID);
            JD_PORequestManageDal dal = new JD_PORequestManageDal();
            JD_PORequestManage model = dal.Detail(logmodel.SNumber, logmodel.FNumber);
            try
            {
                if (model != null)
                {
                    //更新Manage表数量 
                    model.FQty = logmodel.FQtyNew;
                    dal.Update(model);

                    //更新日志表状态
                    logmodel.IsUpdate = "1";
                    logmodel.UpdateTime = DateTime.Now;
                    Update(logmodel);
                }
            }
            catch (Exception ex)
            {
                common.WriteLogs(FileName, ItemID.ToString(), ex.Message);
            }


        }
    }
}
