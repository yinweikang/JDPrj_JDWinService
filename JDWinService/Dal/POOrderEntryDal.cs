using JDWinService.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Dal
{
    public class POOrderEntryDal
    {
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息

        /// <summary>
		/// 对象POOrderEntry明细
		/// 编写人：ywk
		/// 编写日期：2018/6/8 星期五
		/// </summary>
		public POOrderEntry Detail(int FInterID, int FEntryID)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM POOrderEntry WHERE FInterID = @m_FInterID and FEntryID=@m_FEntryID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_FInterID", SqlDbType.Int, 0)).Value = FInterID;
            cmd.Parameters.Add(new SqlParameter("@m_FEntryID", SqlDbType.Int, 0)).Value = FEntryID;

            POOrderEntry myDetail = new POOrderEntry();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["FBrNo"])) { myDetail.FBrNo = Convert.ToString(myReader["FBrNo"]); }
                if (!Convert.IsDBNull(myReader["FInterID"])) { myDetail.FInterID = Convert.ToInt32(myReader["FInterID"]); }
                if (!Convert.IsDBNull(myReader["FEntryID"])) { myDetail.FEntryID = Convert.ToInt32(myReader["FEntryID"]); }
                if (!Convert.IsDBNull(myReader["FItemID"])) { myDetail.FItemID = Convert.ToInt32(myReader["FItemID"]); }
                if (!Convert.IsDBNull(myReader["FQty"])) { myDetail.FQty = Convert.ToDecimal(myReader["FQty"]); }
                if (!Convert.IsDBNull(myReader["FCommitQty"])) { myDetail.FCommitQty = Convert.ToDecimal(myReader["FCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FDate"])) { myDetail.FDate = Convert.ToDateTime(myReader["FDate"]); }
                if (!Convert.IsDBNull(myReader["FPrice"])) { myDetail.FPrice = Convert.ToDecimal(myReader["FPrice"]); }
                if (!Convert.IsDBNull(myReader["FAmount"])) { myDetail.FAmount = Convert.ToDecimal(myReader["FAmount"]); }
                if (!Convert.IsDBNull(myReader["FTaxRate"])) { myDetail.FTaxRate = Convert.ToDecimal(myReader["FTaxRate"]); }
                if (!Convert.IsDBNull(myReader["FTax"])) { myDetail.FTax = Convert.ToDecimal(myReader["FTax"]); }
                if (!Convert.IsDBNull(myReader["FTaxAmount"])) { myDetail.FTaxAmount = Convert.ToDecimal(myReader["FTaxAmount"]); }
                if (!Convert.IsDBNull(myReader["FNote"])) { myDetail.FNote = Convert.ToString(myReader["FNote"]); }
                if (!Convert.IsDBNull(myReader["FUnitID"])) { myDetail.FUnitID = Convert.ToInt32(myReader["FUnitID"]); }
                if (!Convert.IsDBNull(myReader["FAuxCommitQty"])) { myDetail.FAuxCommitQty = Convert.ToDecimal(myReader["FAuxCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxPrice"])) { myDetail.FAuxPrice = Convert.ToDecimal(myReader["FAuxPrice"]); }
                if (!Convert.IsDBNull(myReader["FAuxQty"])) { myDetail.FAuxQty = Convert.ToDecimal(myReader["FAuxQty"]); }
                if (!Convert.IsDBNull(myReader["FSourceEntryID"])) { myDetail.FSourceEntryID = Convert.ToInt32(myReader["FSourceEntryID"]); }
                if (!Convert.IsDBNull(myReader["FCess"])) { myDetail.FCess = Convert.ToDecimal(myReader["FCess"]); }
                if (!Convert.IsDBNull(myReader["FStockQty"])) { myDetail.FStockQty = Convert.ToDecimal(myReader["FStockQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxStockQty"])) { myDetail.FAuxStockQty = Convert.ToDecimal(myReader["FAuxStockQty"]); }
                if (!Convert.IsDBNull(myReader["FMapNumber"])) { myDetail.FMapNumber = Convert.ToString(myReader["FMapNumber"]); }
                if (!Convert.IsDBNull(myReader["FMapName"])) { myDetail.FMapName = Convert.ToString(myReader["FMapName"]); }
                if (!Convert.IsDBNull(myReader["FAllAmount"])) { myDetail.FAllAmount = Convert.ToDecimal(myReader["FAllAmount"]); }
                if (!Convert.IsDBNull(myReader["FAuxPropID"])) { myDetail.FAuxPropID = Convert.ToInt32(myReader["FAuxPropID"]); }
                if (!Convert.IsDBNull(myReader["FAuxPriceDiscount"])) { myDetail.FAuxPriceDiscount = Convert.ToDecimal(myReader["FAuxPriceDiscount"]); }
                if (!Convert.IsDBNull(myReader["FPriceDiscount"])) { myDetail.FPriceDiscount = Convert.ToDecimal(myReader["FPriceDiscount"]); }
                if (!Convert.IsDBNull(myReader["FQtyInvoice"])) { myDetail.FQtyInvoice = Convert.ToDecimal(myReader["FQtyInvoice"]); }
                if (!Convert.IsDBNull(myReader["FQtyInvoiceBase"])) { myDetail.FQtyInvoiceBase = Convert.ToDecimal(myReader["FQtyInvoiceBase"]); }
                if (!Convert.IsDBNull(myReader["FAuxTaxPrice"])) { myDetail.FAuxTaxPrice = Convert.ToDecimal(myReader["FAuxTaxPrice"]); }
                if (!Convert.IsDBNull(myReader["FTaxPrice"])) { myDetail.FTaxPrice = Convert.ToDecimal(myReader["FTaxPrice"]); }
                if (!Convert.IsDBNull(myReader["FReceiveAmountFor_Commit"])) { myDetail.FReceiveAmountFor_Commit = Convert.ToDecimal(myReader["FReceiveAmountFor_Commit"]); }
                if (!Convert.IsDBNull(myReader["FReceiveAmount_Commit"])) { myDetail.FReceiveAmount_Commit = Convert.ToDecimal(myReader["FReceiveAmount_Commit"]); }
                if (!Convert.IsDBNull(myReader["FSecCoefficient"])) { myDetail.FSecCoefficient = Convert.ToDecimal(myReader["FSecCoefficient"]); }
                if (!Convert.IsDBNull(myReader["FSecQty"])) { myDetail.FSecQty = Convert.ToDecimal(myReader["FSecQty"]); }
                if (!Convert.IsDBNull(myReader["FSecCommitQty"])) { myDetail.FSecCommitQty = Convert.ToDecimal(myReader["FSecCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FSourceTranType"])) { myDetail.FSourceTranType = Convert.ToInt32(myReader["FSourceTranType"]); }
                if (!Convert.IsDBNull(myReader["FSourceInterId"])) { myDetail.FSourceInterId = Convert.ToInt32(myReader["FSourceInterId"]); }
                if (!Convert.IsDBNull(myReader["FSourceBillNo"])) { myDetail.FSourceBillNo = Convert.ToString(myReader["FSourceBillNo"]); }
                if (!Convert.IsDBNull(myReader["FContractInterID"])) { myDetail.FContractInterID = Convert.ToInt32(myReader["FContractInterID"]); }
                if (!Convert.IsDBNull(myReader["FContractEntryID"])) { myDetail.FContractEntryID = Convert.ToInt32(myReader["FContractEntryID"]); }
                if (!Convert.IsDBNull(myReader["FContractBillNo"])) { myDetail.FContractBillNo = Convert.ToString(myReader["FContractBillNo"]); }
                if (!Convert.IsDBNull(myReader["FMRPLockFlag"])) { myDetail.FMRPLockFlag = Convert.ToInt32(myReader["FMRPLockFlag"]); }
                if (!Convert.IsDBNull(myReader["FAuxQtyInvoice"])) { myDetail.FAuxQtyInvoice = Convert.ToDecimal(myReader["FAuxQtyInvoice"]); }
                if (!Convert.IsDBNull(myReader["FMrpClosed"])) { myDetail.FMrpClosed = Convert.ToInt32(myReader["FMrpClosed"]); }
                if (!Convert.IsDBNull(myReader["FDetailID"])) { myDetail.FDetailID = Convert.ToInt32(myReader["FDetailID"]); }
                if (!Convert.IsDBNull(myReader["FMapID"])) { myDetail.FMapID = Convert.ToInt32(myReader["FMapID"]); }
                if (!Convert.IsDBNull(myReader["FSProducingAreaID"])) { myDetail.FSProducingAreaID = Convert.ToInt32(myReader["FSProducingAreaID"]); }
                if (!Convert.IsDBNull(myReader["FAmtDiscount"])) { myDetail.FAmtDiscount = Convert.ToDecimal(myReader["FAmtDiscount"]); }
                if (!Convert.IsDBNull(myReader["FCheckAmount"])) { myDetail.FCheckAmount = Convert.ToDecimal(myReader["FCheckAmount"]); }
                if (!Convert.IsDBNull(myReader["FMrpAutoClosed"])) { myDetail.FMrpAutoClosed = Convert.ToInt32(myReader["FMrpAutoClosed"]); }
                if (!Convert.IsDBNull(myReader["FPayApplyAmountFor_Commit"])) { myDetail.FPayApplyAmountFor_Commit = Convert.ToDecimal(myReader["FPayApplyAmountFor_Commit"]); }
                if (!Convert.IsDBNull(myReader["FPayApplyAmount_Commit"])) { myDetail.FPayApplyAmount_Commit = Convert.ToDecimal(myReader["FPayApplyAmount_Commit"]); }
                if (!Convert.IsDBNull(myReader["FSecStockQty"])) { myDetail.FSecStockQty = Convert.ToDecimal(myReader["FSecStockQty"]); }
                if (!Convert.IsDBNull(myReader["FSecInvoiceQty"])) { myDetail.FSecInvoiceQty = Convert.ToDecimal(myReader["FSecInvoiceQty"]); }
                if (!Convert.IsDBNull(myReader["FPlanMode"])) { myDetail.FPlanMode = Convert.ToInt32(myReader["FPlanMode"]); }
                if (!Convert.IsDBNull(myReader["FMTONo"])) { myDetail.FMTONo = Convert.ToString(myReader["FMTONo"]); }
                if (!Convert.IsDBNull(myReader["FDescount"])) { myDetail.FDescount = Convert.ToDecimal(myReader["FDescount"]); }
                if (!Convert.IsDBNull(myReader["FSupConfirm"])) { myDetail.FSupConfirm = Convert.ToString(myReader["FSupConfirm"]); }
                if (!Convert.IsDBNull(myReader["FSupConDate"])) { myDetail.FSupConDate = Convert.ToDateTime(myReader["FSupConDate"]); }
                if (!Convert.IsDBNull(myReader["FSupConQty"])) { myDetail.FSupConQty = Convert.ToDecimal(myReader["FSupConQty"]); }
                if (!Convert.IsDBNull(myReader["FSupConMem"])) { myDetail.FSupConMem = Convert.ToString(myReader["FSupConMem"]); }
                if (!Convert.IsDBNull(myReader["FSupConFetchDate"])) { myDetail.FSupConFetchDate = Convert.ToDateTime(myReader["FSupConFetchDate"]); }
                if (!Convert.IsDBNull(myReader["FSupConfirmor"])) { myDetail.FSupConfirmor = Convert.ToInt32(myReader["FSupConfirmor"]); }
                if (!Convert.IsDBNull(myReader["FQualityRptBillID"])) { myDetail.FQualityRptBillID = Convert.ToInt32(myReader["FQualityRptBillID"]); }
                if (!Convert.IsDBNull(myReader["FLockByAlter"])) { myDetail.FLockByAlter = Convert.ToInt32(myReader["FLockByAlter"]); }
                if (!Convert.IsDBNull(myReader["FDeliveryQty"])) { myDetail.FDeliveryQty = Convert.ToDecimal(myReader["FDeliveryQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxDeliveryQty"])) { myDetail.FAuxDeliveryQty = Convert.ToDecimal(myReader["FAuxDeliveryQty"]); }
                if (!Convert.IsDBNull(myReader["FSecDeliveryQty"])) { myDetail.FSecDeliveryQty = Convert.ToDecimal(myReader["FSecDeliveryQty"]); }
                if (!Convert.IsDBNull(myReader["FRejectRefuseNote"])) { myDetail.FRejectRefuseNote = Convert.ToString(myReader["FRejectRefuseNote"]); }
                if (!Convert.IsDBNull(myReader["FRefuseNote"])) { myDetail.FRefuseNote = Convert.ToString(myReader["FRefuseNote"]); }
                if (!Convert.IsDBNull(myReader["FEntryAccessoryCount"])) { myDetail.FEntryAccessoryCount = Convert.ToInt32(myReader["FEntryAccessoryCount"]); }
                if (!Convert.IsDBNull(myReader["FPRInterID"])) { myDetail.FPRInterID = Convert.ToInt32(myReader["FPRInterID"]); }
                if (!Convert.IsDBNull(myReader["FPREntryID"])) { myDetail.FPREntryID = Convert.ToInt32(myReader["FPREntryID"]); }
                if (!Convert.IsDBNull(myReader["FAuxReceiptQty"])) { myDetail.FAuxReceiptQty = Convert.ToDecimal(myReader["FAuxReceiptQty"]); }
                if (!Convert.IsDBNull(myReader["FReceiptQty"])) { myDetail.FReceiptQty = Convert.ToDecimal(myReader["FReceiptQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxReturnQty"])) { myDetail.FAuxReturnQty = Convert.ToDecimal(myReader["FAuxReturnQty"]); }
                if (!Convert.IsDBNull(myReader["FReturnQty"])) { myDetail.FReturnQty = Convert.ToDecimal(myReader["FReturnQty"]); }
                if (!Convert.IsDBNull(myReader["FCheckMethod"])) { myDetail.FCheckMethod = Convert.ToInt32(myReader["FCheckMethod"]); }
                if (!Convert.IsDBNull(myReader["FIsCheck"])) { myDetail.FIsCheck = Convert.ToInt32(myReader["FIsCheck"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0266"])) { myDetail.FEntrySelfP0266 = Convert.ToDecimal(myReader["FEntrySelfP0266"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0267"])) { myDetail.FEntrySelfP0267 = Convert.ToDateTime(myReader["FEntrySelfP0267"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0268"])) { myDetail.FEntrySelfP0268 = Convert.ToDateTime(myReader["FEntrySelfP0268"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0272"])) { myDetail.FEntrySelfP0272 = Convert.ToDecimal(myReader["FEntrySelfP0272"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0273"])) { myDetail.FEntrySelfP0273 = Convert.ToString(myReader["FEntrySelfP0273"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0275"])) { myDetail.FEntrySelfP0275 = Convert.ToString(myReader["FEntrySelfP0275"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0277"])) { myDetail.FEntrySelfP0277 = Convert.ToDecimal(myReader["FEntrySelfP0277"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0278"])) { myDetail.FEntrySelfP0278 = Convert.ToDecimal(myReader["FEntrySelfP0278"]); }
                if (!Convert.IsDBNull(myReader["FAmountExceptDisCount"])) { myDetail.FAmountExceptDisCount = Convert.ToDecimal(myReader["FAmountExceptDisCount"]); }
                if (!Convert.IsDBNull(myReader["FAllAmountExceptDisCount"])) { myDetail.FAllAmountExceptDisCount = Convert.ToDecimal(myReader["FAllAmountExceptDisCount"]); }
                if (!Convert.IsDBNull(myReader["FEntryDisCount"])) { myDetail.FEntryDisCount = Convert.ToDecimal(myReader["FEntryDisCount"]); }
                if (!Convert.IsDBNull(myReader["FCommitAmt"])) { myDetail.FCommitAmt = Convert.ToDecimal(myReader["FCommitAmt"]); }
                if (!Convert.IsDBNull(myReader["FCommitAmtTax"])) { myDetail.FCommitAmtTax = Convert.ToDecimal(myReader["FCommitAmtTax"]); }
                if (!Convert.IsDBNull(myReader["FCommitTax"])) { myDetail.FCommitTax = Convert.ToDecimal(myReader["FCommitTax"]); }
                if (!Convert.IsDBNull(myReader["FPayReqPayAmountFor"])) { myDetail.FPayReqPayAmountFor = Convert.ToDecimal(myReader["FPayReqPayAmountFor"]); }
                if (!Convert.IsDBNull(myReader["FCloseEntryUser"])) { myDetail.FCloseEntryUser = Convert.ToInt32(myReader["FCloseEntryUser"]); }
                if (!Convert.IsDBNull(myReader["FCloseEntryDate"])) { myDetail.FCloseEntryDate = Convert.ToDateTime(myReader["FCloseEntryDate"]); }
                if (!Convert.IsDBNull(myReader["FCloseEntryCauses"])) { myDetail.FCloseEntryCauses = Convert.ToString(myReader["FCloseEntryCauses"]); }
                if (!Convert.IsDBNull(myReader["FOutSourceInterID"])) { myDetail.FOutSourceInterID = Convert.ToInt32(myReader["FOutSourceInterID"]); }
                if (!Convert.IsDBNull(myReader["FOutSourceEntryID"])) { myDetail.FOutSourceEntryID = Convert.ToInt32(myReader["FOutSourceEntryID"]); }
                if (!Convert.IsDBNull(myReader["FOutSourceTranType"])) { myDetail.FOutSourceTranType = Convert.ToInt32(myReader["FOutSourceTranType"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }

        /// <summary>
		/// 新增POOrderEntry对象
		/// 编写人：ywk
		/// 编写日期：2018/6/8 星期五
		/// </summary>
		public int Add(POOrderEntry model)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO POOrderEntry(FBrNo,FInterID,FEntryID,FItemID,FQty,FCommitQty,FDate,FPrice,FAmount,FTaxRate,FTax,FTaxAmount,FNote,FUnitID,FAuxCommitQty,FAuxPrice,FAuxQty,FSourceEntryID,FCess,FStockQty,FAuxStockQty,FMapNumber,FMapName,FAllAmount,FAuxPropID,FAuxPriceDiscount,FPriceDiscount,FQtyInvoice,FQtyInvoiceBase,FAuxTaxPrice,FTaxPrice,FReceiveAmountFor_Commit,FReceiveAmount_Commit,FSecCoefficient,FSecQty,FSecCommitQty,FSourceTranType,FSourceInterId,FSourceBillNo,FContractInterID,FContractEntryID,FContractBillNo,FMRPLockFlag,FAuxQtyInvoice,FMrpClosed,FMapID,FSProducingAreaID,FAmtDiscount,FCheckAmount,FMrpAutoClosed,FPayApplyAmountFor_Commit,FPayApplyAmount_Commit,FSecStockQty,FSecInvoiceQty,FPlanMode,FMTONo,FDescount,FSupConfirm,FSupConDate,FSupConQty,FSupConMem,FSupConFetchDate,FSupConfirmor,FQualityRptBillID,FLockByAlter,FDeliveryQty,FAuxDeliveryQty,FSecDeliveryQty,FRejectRefuseNote,FRefuseNote,FLockBySupplier,FEntryAccessoryCount,FPRInterID,FPREntryID,FAuxReceiptQty,FReceiptQty,FAuxReturnQty,FReturnQty,FCheckMethod,FIsCheck,FEntrySelfP0266,FEntrySelfP0267,FEntrySelfP0268,FEntrySelfP0272,FEntrySelfP0273,FEntrySelfP0275,FEntrySelfP0277,FEntrySelfP0278,FAmountExceptDisCount,FAllAmountExceptDisCount,FEntryDisCount,FCommitAmt,FCommitAmtTax,FCommitTax,FPayReqPayAmountFor,FCloseEntryUser,FCloseEntryDate,FCloseEntryCauses,FOutSourceInterID,FOutSourceEntryID,FOutSourceTranType) VALUES(@m_FBrNo,@m_FInterID,@m_FEntryID,@m_FItemID,@m_FQty,@m_FCommitQty,@m_FDate,@m_FPrice,@m_FAmount,@m_FTaxRate,@m_FTax,@m_FTaxAmount,@m_FNote,@m_FUnitID,@m_FAuxCommitQty,@m_FAuxPrice,@m_FAuxQty,@m_FSourceEntryID,@m_FCess,@m_FStockQty,@m_FAuxStockQty,@m_FMapNumber,@m_FMapName,@m_FAllAmount,@m_FAuxPropID,@m_FAuxPriceDiscount,@m_FPriceDiscount,@m_FQtyInvoice,@m_FQtyInvoiceBase,@m_FAuxTaxPrice,@m_FTaxPrice,@m_FReceiveAmountFor_Commit,@m_FReceiveAmount_Commit,@m_FSecCoefficient,@m_FSecQty,@m_FSecCommitQty,@m_FSourceTranType,@m_FSourceInterId,@m_FSourceBillNo,@m_FContractInterID,@m_FContractEntryID,@m_FContractBillNo,@m_FMRPLockFlag,@m_FAuxQtyInvoice,@m_FMrpClosed,@m_FMapID,@m_FSProducingAreaID,@m_FAmtDiscount,@m_FCheckAmount,@m_FMrpAutoClosed,@m_FPayApplyAmountFor_Commit,@m_FPayApplyAmount_Commit,@m_FSecStockQty,@m_FSecInvoiceQty,@m_FPlanMode,@m_FMTONo,@m_FDescount,@m_FSupConfirm,@m_FSupConDate,@m_FSupConQty,@m_FSupConMem,@m_FSupConFetchDate,@m_FSupConfirmor,@m_FQualityRptBillID,@m_FLockByAlter,@m_FDeliveryQty,@m_FAuxDeliveryQty,@m_FSecDeliveryQty,@m_FRejectRefuseNote,@m_FRefuseNote,@m_FLockBySupplier,@m_FEntryAccessoryCount,@m_FPRInterID,@m_FPREntryID,@m_FAuxReceiptQty,@m_FReceiptQty,@m_FAuxReturnQty,@m_FReturnQty,@m_FCheckMethod,@m_FIsCheck,@m_FEntrySelfP0266,@m_FEntrySelfP0267,@m_FEntrySelfP0268,@m_FEntrySelfP0272,@m_FEntrySelfP0273,@m_FEntrySelfP0275,@m_FEntrySelfP0277,@m_FEntrySelfP0278,@m_FAmountExceptDisCount,@m_FAllAmountExceptDisCount,@m_FEntryDisCount,@m_FCommitAmt,@m_FCommitAmtTax,@m_FCommitTax,@m_FPayReqPayAmountFor,@m_FCloseEntryUser,@m_FCloseEntryDate,@m_FCloseEntryCauses,@m_FOutSourceInterID,@m_FOutSourceEntryID,@m_FOutSourceTranType) SELECT @thisId=@@IDENTITY FROM POOrderEntry", con);
            con.Open();

            if (model.FBrNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBrNo", SqlDbType.VarChar, 10)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBrNo", SqlDbType.VarChar, 10)).Value = model.FBrNo;
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
            if (model.FItemID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FItemID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FItemID", SqlDbType.Int, 0)).Value = model.FItemID;
            }
            if (model.FQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 28)).Value = model.FQty;
            }
            if (model.FCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitQty", SqlDbType.Decimal, 28)).Value = model.FCommitQty;
            }
            if (model.FDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = model.FDate;
            }
            if (model.FPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPrice", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPrice", SqlDbType.Decimal, 28)).Value = model.FPrice;
            }
            if (model.FAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmount", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmount", SqlDbType.Decimal, 20)).Value = model.FAmount;
            }
            if (model.FTaxRate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxRate", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxRate", SqlDbType.Decimal, 28)).Value = model.FTaxRate;
            }
            if (model.FTax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTax", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTax", SqlDbType.Decimal, 20)).Value = model.FTax;
            }
            if (model.FTaxAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxAmount", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxAmount", SqlDbType.Decimal, 20)).Value = model.FTaxAmount;
            }
            if (model.FNote == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.VarChar, 255)).Value = model.FNote;
            }
            if (model.FUnitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.Int, 0)).Value = model.FUnitID;
            }
            if (model.FAuxCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxCommitQty;
            }
            if (model.FAuxPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 28)).Value = model.FAuxPrice;
            }
            if (model.FAuxQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQty", SqlDbType.Decimal, 28)).Value = model.FAuxQty;
            }
            if (model.FSourceEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.Int, 0)).Value = model.FSourceEntryID;
            }
            if (model.FCess == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCess", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCess", SqlDbType.Decimal, 20)).Value = model.FCess;
            }
            if (model.FStockQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStockQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStockQty", SqlDbType.Decimal, 28)).Value = model.FStockQty;
            }
            if (model.FAuxStockQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxStockQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxStockQty", SqlDbType.Decimal, 28)).Value = model.FAuxStockQty;
            }
            if (model.FMapNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMapNumber", SqlDbType.VarChar, 80)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMapNumber", SqlDbType.VarChar, 80)).Value = model.FMapNumber;
            }
            if (model.FMapName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMapName", SqlDbType.NVarChar, 256)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMapName", SqlDbType.NVarChar, 256)).Value = model.FMapName;
            }
            if (model.FAllAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllAmount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllAmount", SqlDbType.Decimal, 28)).Value = model.FAllAmount;
            }
            if (model.FAuxPropID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPropID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPropID", SqlDbType.Int, 0)).Value = model.FAuxPropID;
            }
            if (model.FAuxPriceDiscount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPriceDiscount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPriceDiscount", SqlDbType.Decimal, 28)).Value = model.FAuxPriceDiscount;
            }
            if (model.FPriceDiscount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPriceDiscount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPriceDiscount", SqlDbType.Decimal, 28)).Value = model.FPriceDiscount;
            }
            if (model.FQtyInvoice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyInvoice", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyInvoice", SqlDbType.Decimal, 28)).Value = model.FQtyInvoice;
            }
            if (model.FQtyInvoiceBase == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyInvoiceBase", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyInvoiceBase", SqlDbType.Decimal, 28)).Value = model.FQtyInvoiceBase;
            }
            if (model.FAuxTaxPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxTaxPrice", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxTaxPrice", SqlDbType.Decimal, 28)).Value = model.FAuxTaxPrice;
            }
            if (model.FTaxPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxPrice", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxPrice", SqlDbType.Decimal, 28)).Value = model.FTaxPrice;
            }
            if (model.FReceiveAmountFor_Commit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FReceiveAmountFor_Commit", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FReceiveAmountFor_Commit", SqlDbType.Decimal, 28)).Value = model.FReceiveAmountFor_Commit;
            }
            if (model.FReceiveAmount_Commit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FReceiveAmount_Commit", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FReceiveAmount_Commit", SqlDbType.Decimal, 28)).Value = model.FReceiveAmount_Commit;
            }
            if (model.FSecCoefficient == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecCoefficient", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecCoefficient", SqlDbType.Decimal, 28)).Value = model.FSecCoefficient;
            }
            if (model.FSecQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecQty", SqlDbType.Decimal, 28)).Value = model.FSecQty;
            }
            if (model.FSecCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecCommitQty", SqlDbType.Decimal, 28)).Value = model.FSecCommitQty;
            }
            if (model.FSourceTranType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceTranType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceTranType", SqlDbType.Int, 0)).Value = model.FSourceTranType;
            }
            if (model.FSourceInterId == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceInterId", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceInterId", SqlDbType.Int, 0)).Value = model.FSourceInterId;
            }
            if (model.FSourceBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceBillNo", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceBillNo", SqlDbType.NVarChar, 255)).Value = model.FSourceBillNo;
            }
            if (model.FContractInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FContractInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FContractInterID", SqlDbType.Int, 0)).Value = model.FContractInterID;
            }
            if (model.FContractEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FContractEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FContractEntryID", SqlDbType.Int, 0)).Value = model.FContractEntryID;
            }
            if (model.FContractBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FContractBillNo", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FContractBillNo", SqlDbType.NVarChar, 255)).Value = model.FContractBillNo;
            }
            if (model.FMRPLockFlag == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMRPLockFlag", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMRPLockFlag", SqlDbType.Int, 0)).Value = model.FMRPLockFlag;
            }
            if (model.FAuxQtyInvoice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQtyInvoice", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQtyInvoice", SqlDbType.Decimal, 28)).Value = model.FAuxQtyInvoice;
            }
            if (model.FMrpClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpClosed", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpClosed", SqlDbType.Int, 0)).Value = model.FMrpClosed;
            }
            if (model.FMapID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMapID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMapID", SqlDbType.Int, 0)).Value = model.FMapID;
            }
            if (model.FSProducingAreaID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSProducingAreaID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSProducingAreaID", SqlDbType.Int, 0)).Value = model.FSProducingAreaID;
            }
            if (model.FAmtDiscount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmtDiscount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmtDiscount", SqlDbType.Decimal, 28)).Value = model.FAmtDiscount;
            }
            if (model.FCheckAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCheckAmount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCheckAmount", SqlDbType.Decimal, 28)).Value = model.FCheckAmount;
            }
            if (model.FMrpAutoClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpAutoClosed", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpAutoClosed", SqlDbType.Int, 0)).Value = model.FMrpAutoClosed;
            }
            if (model.FPayApplyAmountFor_Commit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayApplyAmountFor_Commit", SqlDbType.Decimal, 19)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayApplyAmountFor_Commit", SqlDbType.Decimal, 19)).Value = model.FPayApplyAmountFor_Commit;
            }
            if (model.FPayApplyAmount_Commit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayApplyAmount_Commit", SqlDbType.Decimal, 19)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayApplyAmount_Commit", SqlDbType.Decimal, 19)).Value = model.FPayApplyAmount_Commit;
            }
            if (model.FSecStockQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecStockQty", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecStockQty", SqlDbType.Decimal, 23)).Value = model.FSecStockQty;
            }
            if (model.FSecInvoiceQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecInvoiceQty", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecInvoiceQty", SqlDbType.Decimal, 23)).Value = model.FSecInvoiceQty;
            }
            if (model.FPlanMode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanMode", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanMode", SqlDbType.Int, 0)).Value = model.FPlanMode;
            }
            if (model.FMTONo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMTONo", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMTONo", SqlDbType.NVarChar, 50)).Value = model.FMTONo;
            }
            if (model.FDescount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDescount", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDescount", SqlDbType.Decimal, 23)).Value = model.FDescount;
            }
            if (model.FSupConfirm == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConfirm", SqlDbType.NVarChar, 10)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConfirm", SqlDbType.NVarChar, 10)).Value = model.FSupConfirm;
            }
            if (model.FSupConDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConDate", SqlDbType.DateTime, 0)).Value = model.FSupConDate;
            }
            if (model.FSupConQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConQty", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConQty", SqlDbType.Decimal, 23)).Value = model.FSupConQty;
            }
            if (model.FSupConMem == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConMem", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConMem", SqlDbType.NVarChar, 255)).Value = model.FSupConMem;
            }
            if (model.FSupConFetchDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConFetchDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConFetchDate", SqlDbType.DateTime, 0)).Value = model.FSupConFetchDate;
            }
            if (model.FSupConfirmor == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConfirmor", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConfirmor", SqlDbType.Int, 0)).Value = model.FSupConfirmor;
            }
            if (model.FQualityRptBillID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQualityRptBillID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQualityRptBillID", SqlDbType.Int, 0)).Value = model.FQualityRptBillID;
            }
            if (model.FLockByAlter == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLockByAlter", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLockByAlter", SqlDbType.Int, 0)).Value = model.FLockByAlter;
            }
            if (model.FDeliveryQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDeliveryQty", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDeliveryQty", SqlDbType.Decimal, 23)).Value = model.FDeliveryQty;
            }
            if (model.FAuxDeliveryQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxDeliveryQty", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxDeliveryQty", SqlDbType.Decimal, 23)).Value = model.FAuxDeliveryQty;
            }
            if (model.FSecDeliveryQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecDeliveryQty", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecDeliveryQty", SqlDbType.Decimal, 23)).Value = model.FSecDeliveryQty;
            }
            if (model.FRejectRefuseNote == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRejectRefuseNote", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRejectRefuseNote", SqlDbType.NVarChar, 255)).Value = model.FRejectRefuseNote;
            }
            if (model.FRefuseNote == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRefuseNote", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRefuseNote", SqlDbType.NVarChar, 255)).Value = model.FRefuseNote;
            }
            if (model.FLockBySupplier == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLockBySupplier", SqlDbType.TinyInt, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLockBySupplier", SqlDbType.TinyInt, 0)).Value = model.FLockBySupplier;
            }
            if (model.FEntryAccessoryCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntryAccessoryCount", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntryAccessoryCount", SqlDbType.Int, 0)).Value = model.FEntryAccessoryCount;
            }
            if (model.FPRInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPRInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPRInterID", SqlDbType.Int, 0)).Value = model.FPRInterID;
            }
            if (model.FPREntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPREntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPREntryID", SqlDbType.Int, 0)).Value = model.FPREntryID;
            }
            if (model.FAuxReceiptQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxReceiptQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxReceiptQty", SqlDbType.Decimal, 28)).Value = model.FAuxReceiptQty;
            }
            if (model.FReceiptQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FReceiptQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FReceiptQty", SqlDbType.Decimal, 28)).Value = model.FReceiptQty;
            }
            if (model.FAuxReturnQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxReturnQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxReturnQty", SqlDbType.Decimal, 28)).Value = model.FAuxReturnQty;
            }
            if (model.FReturnQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FReturnQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FReturnQty", SqlDbType.Decimal, 28)).Value = model.FReturnQty;
            }
            if (model.FCheckMethod == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCheckMethod", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCheckMethod", SqlDbType.Int, 0)).Value = model.FCheckMethod;
            }
            if (model.FIsCheck == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsCheck", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsCheck", SqlDbType.Int, 0)).Value = model.FIsCheck;
            }
            if (model.FEntrySelfP0266 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0266", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0266", SqlDbType.Decimal, 28)).Value = model.FEntrySelfP0266;
            }
            if (model.FEntrySelfP0267 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0267", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0267", SqlDbType.DateTime, 0)).Value = model.FEntrySelfP0267;
            }
            if (model.FEntrySelfP0268 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0268", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0268", SqlDbType.DateTime, 0)).Value = model.FEntrySelfP0268;
            }
            if (model.FEntrySelfP0272 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0272", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0272", SqlDbType.Decimal, 28)).Value = model.FEntrySelfP0272;
            }
            if (model.FEntrySelfP0273 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0273", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0273", SqlDbType.VarChar, 255)).Value = model.FEntrySelfP0273;
            }
            if (model.FEntrySelfP0275 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0275", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0275", SqlDbType.VarChar, 255)).Value = model.FEntrySelfP0275;
            }
            if (model.FEntrySelfP0277 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0277", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0277", SqlDbType.Decimal, 28)).Value = model.FEntrySelfP0277;
            }
            if (model.FEntrySelfP0278 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0278", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0278", SqlDbType.Decimal, 20)).Value = model.FEntrySelfP0278;
            }
            if (model.FAmountExceptDisCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmountExceptDisCount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmountExceptDisCount", SqlDbType.Decimal, 28)).Value = model.FAmountExceptDisCount;
            }
            if (model.FAllAmountExceptDisCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllAmountExceptDisCount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllAmountExceptDisCount", SqlDbType.Decimal, 28)).Value = model.FAllAmountExceptDisCount;
            }
            if (model.FEntryDisCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntryDisCount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntryDisCount", SqlDbType.Decimal, 28)).Value = model.FEntryDisCount;
            }
            if (model.FCommitAmt == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitAmt", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitAmt", SqlDbType.Decimal, 23)).Value = model.FCommitAmt;
            }
            if (model.FCommitAmtTax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitAmtTax", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitAmtTax", SqlDbType.Decimal, 23)).Value = model.FCommitAmtTax;
            }
            if (model.FCommitTax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitTax", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitTax", SqlDbType.Decimal, 23)).Value = model.FCommitTax;
            }
            if (model.FPayReqPayAmountFor == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayReqPayAmountFor", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayReqPayAmountFor", SqlDbType.Decimal, 28)).Value = model.FPayReqPayAmountFor;
            }
            if (model.FCloseEntryUser == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCloseEntryUser", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCloseEntryUser", SqlDbType.Int, 0)).Value = model.FCloseEntryUser;
            }
            if (model.FCloseEntryDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCloseEntryDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCloseEntryDate", SqlDbType.DateTime, 0)).Value = model.FCloseEntryDate;
            }
            if (model.FCloseEntryCauses == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCloseEntryCauses", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCloseEntryCauses", SqlDbType.NVarChar, 255)).Value = model.FCloseEntryCauses;
            }
            if (model.FOutSourceInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOutSourceInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOutSourceInterID", SqlDbType.Int, 0)).Value = model.FOutSourceInterID;
            }
            if (model.FOutSourceEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOutSourceEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOutSourceEntryID", SqlDbType.Int, 0)).Value = model.FOutSourceEntryID;
            }
            if (model.FOutSourceTranType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOutSourceTranType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOutSourceTranType", SqlDbType.Int, 0)).Value = model.FOutSourceTranType;
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
		/// 更新POOrderEntry对象
		/// 编写人：ywk
		/// 编写日期：2018/6/9 星期六
		/// </summary>
		public void Update(POOrderEntry model)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE POOrderEntry SET FBrNo = @m_FBrNo,FInterID = @m_FInterID,FEntryID = @m_FEntryID,FItemID = @m_FItemID,FQty = @m_FQty,FCommitQty = @m_FCommitQty,FDate = @m_FDate,FPrice = @m_FPrice,FAmount = @m_FAmount,FTaxRate = @m_FTaxRate,FTax = @m_FTax,FTaxAmount = @m_FTaxAmount,FNote = @m_FNote,FUnitID = @m_FUnitID,FAuxCommitQty = @m_FAuxCommitQty,FAuxPrice = @m_FAuxPrice,FAuxQty = @m_FAuxQty,FSourceEntryID = @m_FSourceEntryID,FCess = @m_FCess,FStockQty = @m_FStockQty,FAuxStockQty = @m_FAuxStockQty,FMapNumber = @m_FMapNumber,FMapName = @m_FMapName,FAllAmount = @m_FAllAmount,FAuxPropID = @m_FAuxPropID,FAuxPriceDiscount = @m_FAuxPriceDiscount,FPriceDiscount = @m_FPriceDiscount,FQtyInvoice = @m_FQtyInvoice,FQtyInvoiceBase = @m_FQtyInvoiceBase,FAuxTaxPrice = @m_FAuxTaxPrice,FTaxPrice = @m_FTaxPrice,FReceiveAmountFor_Commit = @m_FReceiveAmountFor_Commit,FReceiveAmount_Commit = @m_FReceiveAmount_Commit,FSecCoefficient = @m_FSecCoefficient,FSecQty = @m_FSecQty,FSecCommitQty = @m_FSecCommitQty,FSourceTranType = @m_FSourceTranType,FSourceInterId = @m_FSourceInterId,FSourceBillNo = @m_FSourceBillNo,FContractInterID = @m_FContractInterID,FContractEntryID = @m_FContractEntryID,FContractBillNo = @m_FContractBillNo,FMRPLockFlag = @m_FMRPLockFlag,FAuxQtyInvoice = @m_FAuxQtyInvoice,FMrpClosed = @m_FMrpClosed,FMapID = @m_FMapID,FSProducingAreaID = @m_FSProducingAreaID,FAmtDiscount = @m_FAmtDiscount,FCheckAmount = @m_FCheckAmount,FMrpAutoClosed = @m_FMrpAutoClosed,FPayApplyAmountFor_Commit = @m_FPayApplyAmountFor_Commit,FPayApplyAmount_Commit = @m_FPayApplyAmount_Commit,FSecStockQty = @m_FSecStockQty,FSecInvoiceQty = @m_FSecInvoiceQty,FPlanMode = @m_FPlanMode,FMTONo = @m_FMTONo,FDescount = @m_FDescount,FSupConfirm = @m_FSupConfirm,FSupConDate = @m_FSupConDate,FSupConQty = @m_FSupConQty,FSupConMem = @m_FSupConMem,FSupConFetchDate = @m_FSupConFetchDate,FSupConfirmor = @m_FSupConfirmor,FQualityRptBillID = @m_FQualityRptBillID,FLockByAlter = @m_FLockByAlter,FDeliveryQty = @m_FDeliveryQty,FAuxDeliveryQty = @m_FAuxDeliveryQty,FSecDeliveryQty = @m_FSecDeliveryQty,FRejectRefuseNote = @m_FRejectRefuseNote,FRefuseNote = @m_FRefuseNote,FLockBySupplier = @m_FLockBySupplier,FEntryAccessoryCount = @m_FEntryAccessoryCount,FPRInterID = @m_FPRInterID,FPREntryID = @m_FPREntryID,FAuxReceiptQty = @m_FAuxReceiptQty,FReceiptQty = @m_FReceiptQty,FAuxReturnQty = @m_FAuxReturnQty,FReturnQty = @m_FReturnQty,FCheckMethod = @m_FCheckMethod,FIsCheck = @m_FIsCheck,FEntrySelfP0266 = @m_FEntrySelfP0266,FEntrySelfP0267 = @m_FEntrySelfP0267,FEntrySelfP0268 = @m_FEntrySelfP0268,FEntrySelfP0272 = @m_FEntrySelfP0272,FEntrySelfP0273 = @m_FEntrySelfP0273,FEntrySelfP0275 = @m_FEntrySelfP0275,FEntrySelfP0277 = @m_FEntrySelfP0277,FEntrySelfP0278 = @m_FEntrySelfP0278,FAmountExceptDisCount = @m_FAmountExceptDisCount,FAllAmountExceptDisCount = @m_FAllAmountExceptDisCount,FEntryDisCount = @m_FEntryDisCount,FCommitAmt = @m_FCommitAmt,FCommitAmtTax = @m_FCommitAmtTax,FCommitTax = @m_FCommitTax,FPayReqPayAmountFor = @m_FPayReqPayAmountFor,FCloseEntryUser = @m_FCloseEntryUser,FCloseEntryDate = @m_FCloseEntryDate,FCloseEntryCauses = @m_FCloseEntryCauses,FOutSourceInterID = @m_FOutSourceInterID,FOutSourceEntryID = @m_FOutSourceEntryID,FOutSourceTranType = @m_FOutSourceTranType WHERE FDetailID = @m_FDetailID", con);
            con.Open();

            if (model.FBrNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBrNo", SqlDbType.VarChar, 10)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBrNo", SqlDbType.VarChar, 10)).Value = model.FBrNo;
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
            if (model.FItemID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FItemID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FItemID", SqlDbType.Int, 0)).Value = model.FItemID;
            }
            if (model.FQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 28)).Value = model.FQty;
            }
            if (model.FCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitQty", SqlDbType.Decimal, 28)).Value = model.FCommitQty;
            }
            if (model.FDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = model.FDate;
            }
            if (model.FPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPrice", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPrice", SqlDbType.Decimal, 28)).Value = model.FPrice;
            }
            if (model.FAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmount", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmount", SqlDbType.Decimal, 20)).Value = model.FAmount;
            }
            if (model.FTaxRate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxRate", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxRate", SqlDbType.Decimal, 28)).Value = model.FTaxRate;
            }
            if (model.FTax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTax", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTax", SqlDbType.Decimal, 20)).Value = model.FTax;
            }
            if (model.FTaxAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxAmount", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxAmount", SqlDbType.Decimal, 20)).Value = model.FTaxAmount;
            }
            if (model.FNote == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.VarChar, 255)).Value = model.FNote;
            }
            if (model.FUnitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.Int, 0)).Value = model.FUnitID;
            }
            if (model.FAuxCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxCommitQty;
            }
            if (model.FAuxPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 28)).Value = model.FAuxPrice;
            }
            if (model.FAuxQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQty", SqlDbType.Decimal, 28)).Value = model.FAuxQty;
            }
            if (model.FSourceEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.Int, 0)).Value = model.FSourceEntryID;
            }
            if (model.FCess == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCess", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCess", SqlDbType.Decimal, 20)).Value = model.FCess;
            }
            if (model.FStockQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStockQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStockQty", SqlDbType.Decimal, 28)).Value = model.FStockQty;
            }
            if (model.FAuxStockQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxStockQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxStockQty", SqlDbType.Decimal, 28)).Value = model.FAuxStockQty;
            }
            if (model.FMapNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMapNumber", SqlDbType.VarChar, 80)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMapNumber", SqlDbType.VarChar, 80)).Value = model.FMapNumber;
            }
            if (model.FMapName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMapName", SqlDbType.NVarChar, 256)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMapName", SqlDbType.NVarChar, 256)).Value = model.FMapName;
            }
            if (model.FAllAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllAmount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllAmount", SqlDbType.Decimal, 28)).Value = model.FAllAmount;
            }
            if (model.FAuxPropID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPropID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPropID", SqlDbType.Int, 0)).Value = model.FAuxPropID;
            }
            if (model.FAuxPriceDiscount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPriceDiscount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPriceDiscount", SqlDbType.Decimal, 28)).Value = model.FAuxPriceDiscount;
            }
            if (model.FPriceDiscount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPriceDiscount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPriceDiscount", SqlDbType.Decimal, 28)).Value = model.FPriceDiscount;
            }
            if (model.FQtyInvoice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyInvoice", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyInvoice", SqlDbType.Decimal, 28)).Value = model.FQtyInvoice;
            }
            if (model.FQtyInvoiceBase == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyInvoiceBase", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyInvoiceBase", SqlDbType.Decimal, 28)).Value = model.FQtyInvoiceBase;
            }
            if (model.FAuxTaxPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxTaxPrice", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxTaxPrice", SqlDbType.Decimal, 28)).Value = model.FAuxTaxPrice;
            }
            if (model.FTaxPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxPrice", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxPrice", SqlDbType.Decimal, 28)).Value = model.FTaxPrice;
            }
            if (model.FReceiveAmountFor_Commit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FReceiveAmountFor_Commit", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FReceiveAmountFor_Commit", SqlDbType.Decimal, 28)).Value = model.FReceiveAmountFor_Commit;
            }
            if (model.FReceiveAmount_Commit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FReceiveAmount_Commit", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FReceiveAmount_Commit", SqlDbType.Decimal, 28)).Value = model.FReceiveAmount_Commit;
            }
            if (model.FSecCoefficient == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecCoefficient", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecCoefficient", SqlDbType.Decimal, 28)).Value = model.FSecCoefficient;
            }
            if (model.FSecQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecQty", SqlDbType.Decimal, 28)).Value = model.FSecQty;
            }
            if (model.FSecCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecCommitQty", SqlDbType.Decimal, 28)).Value = model.FSecCommitQty;
            }
            if (model.FSourceTranType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceTranType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceTranType", SqlDbType.Int, 0)).Value = model.FSourceTranType;
            }
            if (model.FSourceInterId == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceInterId", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceInterId", SqlDbType.Int, 0)).Value = model.FSourceInterId;
            }
            if (model.FSourceBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceBillNo", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceBillNo", SqlDbType.NVarChar, 255)).Value = model.FSourceBillNo;
            }
            if (model.FContractInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FContractInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FContractInterID", SqlDbType.Int, 0)).Value = model.FContractInterID;
            }
            if (model.FContractEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FContractEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FContractEntryID", SqlDbType.Int, 0)).Value = model.FContractEntryID;
            }
            if (model.FContractBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FContractBillNo", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FContractBillNo", SqlDbType.NVarChar, 255)).Value = model.FContractBillNo;
            }
            if (model.FMRPLockFlag == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMRPLockFlag", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMRPLockFlag", SqlDbType.Int, 0)).Value = model.FMRPLockFlag;
            }
            if (model.FAuxQtyInvoice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQtyInvoice", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQtyInvoice", SqlDbType.Decimal, 28)).Value = model.FAuxQtyInvoice;
            }
            if (model.FMrpClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpClosed", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpClosed", SqlDbType.Int, 0)).Value = model.FMrpClosed;
            }
            if (model.FMapID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMapID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMapID", SqlDbType.Int, 0)).Value = model.FMapID;
            }
            if (model.FSProducingAreaID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSProducingAreaID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSProducingAreaID", SqlDbType.Int, 0)).Value = model.FSProducingAreaID;
            }
            if (model.FAmtDiscount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmtDiscount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmtDiscount", SqlDbType.Decimal, 28)).Value = model.FAmtDiscount;
            }
            if (model.FCheckAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCheckAmount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCheckAmount", SqlDbType.Decimal, 28)).Value = model.FCheckAmount;
            }
            if (model.FMrpAutoClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpAutoClosed", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpAutoClosed", SqlDbType.Int, 0)).Value = model.FMrpAutoClosed;
            }
            if (model.FPayApplyAmountFor_Commit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayApplyAmountFor_Commit", SqlDbType.Decimal, 19)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayApplyAmountFor_Commit", SqlDbType.Decimal, 19)).Value = model.FPayApplyAmountFor_Commit;
            }
            if (model.FPayApplyAmount_Commit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayApplyAmount_Commit", SqlDbType.Decimal, 19)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayApplyAmount_Commit", SqlDbType.Decimal, 19)).Value = model.FPayApplyAmount_Commit;
            }
            if (model.FSecStockQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecStockQty", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecStockQty", SqlDbType.Decimal, 23)).Value = model.FSecStockQty;
            }
            if (model.FSecInvoiceQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecInvoiceQty", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecInvoiceQty", SqlDbType.Decimal, 23)).Value = model.FSecInvoiceQty;
            }
            if (model.FPlanMode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanMode", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanMode", SqlDbType.Int, 0)).Value = model.FPlanMode;
            }
            if (model.FMTONo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMTONo", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMTONo", SqlDbType.NVarChar, 50)).Value = model.FMTONo;
            }
            if (model.FDescount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDescount", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDescount", SqlDbType.Decimal, 23)).Value = model.FDescount;
            }
            if (model.FSupConfirm == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConfirm", SqlDbType.NVarChar, 10)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConfirm", SqlDbType.NVarChar, 10)).Value = model.FSupConfirm;
            }
            if (model.FSupConDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConDate", SqlDbType.DateTime, 0)).Value = model.FSupConDate;
            }
            if (model.FSupConQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConQty", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConQty", SqlDbType.Decimal, 23)).Value = model.FSupConQty;
            }
            if (model.FSupConMem == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConMem", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConMem", SqlDbType.NVarChar, 255)).Value = model.FSupConMem;
            }
            if (model.FSupConFetchDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConFetchDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConFetchDate", SqlDbType.DateTime, 0)).Value = model.FSupConFetchDate;
            }
            if (model.FSupConfirmor == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConfirmor", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupConfirmor", SqlDbType.Int, 0)).Value = model.FSupConfirmor;
            }
            if (model.FQualityRptBillID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQualityRptBillID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQualityRptBillID", SqlDbType.Int, 0)).Value = model.FQualityRptBillID;
            }
            if (model.FLockByAlter == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLockByAlter", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLockByAlter", SqlDbType.Int, 0)).Value = model.FLockByAlter;
            }
            if (model.FDeliveryQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDeliveryQty", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDeliveryQty", SqlDbType.Decimal, 23)).Value = model.FDeliveryQty;
            }
            if (model.FAuxDeliveryQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxDeliveryQty", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxDeliveryQty", SqlDbType.Decimal, 23)).Value = model.FAuxDeliveryQty;
            }
            if (model.FSecDeliveryQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecDeliveryQty", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecDeliveryQty", SqlDbType.Decimal, 23)).Value = model.FSecDeliveryQty;
            }
            if (model.FRejectRefuseNote == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRejectRefuseNote", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRejectRefuseNote", SqlDbType.NVarChar, 255)).Value = model.FRejectRefuseNote;
            }
            if (model.FRefuseNote == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRefuseNote", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRefuseNote", SqlDbType.NVarChar, 255)).Value = model.FRefuseNote;
            }
            if (model.FLockBySupplier == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLockBySupplier", SqlDbType.TinyInt, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLockBySupplier", SqlDbType.TinyInt, 0)).Value = model.FLockBySupplier;
            }
            if (model.FEntryAccessoryCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntryAccessoryCount", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntryAccessoryCount", SqlDbType.Int, 0)).Value = model.FEntryAccessoryCount;
            }
            if (model.FPRInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPRInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPRInterID", SqlDbType.Int, 0)).Value = model.FPRInterID;
            }
            if (model.FPREntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPREntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPREntryID", SqlDbType.Int, 0)).Value = model.FPREntryID;
            }
            if (model.FAuxReceiptQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxReceiptQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxReceiptQty", SqlDbType.Decimal, 28)).Value = model.FAuxReceiptQty;
            }
            if (model.FReceiptQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FReceiptQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FReceiptQty", SqlDbType.Decimal, 28)).Value = model.FReceiptQty;
            }
            if (model.FAuxReturnQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxReturnQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxReturnQty", SqlDbType.Decimal, 28)).Value = model.FAuxReturnQty;
            }
            if (model.FReturnQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FReturnQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FReturnQty", SqlDbType.Decimal, 28)).Value = model.FReturnQty;
            }
            if (model.FCheckMethod == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCheckMethod", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCheckMethod", SqlDbType.Int, 0)).Value = model.FCheckMethod;
            }
            if (model.FIsCheck == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsCheck", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsCheck", SqlDbType.Int, 0)).Value = model.FIsCheck;
            }
            if (model.FEntrySelfP0266 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0266", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0266", SqlDbType.Decimal, 28)).Value = model.FEntrySelfP0266;
            }
            if (model.FEntrySelfP0267 == null)
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
            if (model.FEntrySelfP0272 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0272", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0272", SqlDbType.Decimal, 28)).Value = model.FEntrySelfP0272;
            }
            if (model.FEntrySelfP0273 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0273", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0273", SqlDbType.VarChar, 255)).Value = model.FEntrySelfP0273;
            }
            if (model.FEntrySelfP0275 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0275", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0275", SqlDbType.VarChar, 255)).Value = model.FEntrySelfP0275;
            }
            if (model.FEntrySelfP0277 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0277", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0277", SqlDbType.Decimal, 28)).Value = model.FEntrySelfP0277;
            }
            if (model.FEntrySelfP0278 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0278", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0278", SqlDbType.Decimal, 20)).Value = model.FEntrySelfP0278;
            }
            if (model.FAmountExceptDisCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmountExceptDisCount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmountExceptDisCount", SqlDbType.Decimal, 28)).Value = model.FAmountExceptDisCount;
            }
            if (model.FAllAmountExceptDisCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllAmountExceptDisCount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllAmountExceptDisCount", SqlDbType.Decimal, 28)).Value = model.FAllAmountExceptDisCount;
            }
            if (model.FEntryDisCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntryDisCount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntryDisCount", SqlDbType.Decimal, 28)).Value = model.FEntryDisCount;
            }
            if (model.FCommitAmt == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitAmt", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitAmt", SqlDbType.Decimal, 23)).Value = model.FCommitAmt;
            }
            if (model.FCommitAmtTax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitAmtTax", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitAmtTax", SqlDbType.Decimal, 23)).Value = model.FCommitAmtTax;
            }
            if (model.FCommitTax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitTax", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitTax", SqlDbType.Decimal, 23)).Value = model.FCommitTax;
            }
            if (model.FPayReqPayAmountFor == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayReqPayAmountFor", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayReqPayAmountFor", SqlDbType.Decimal, 28)).Value = model.FPayReqPayAmountFor;
            }
            if (model.FCloseEntryUser == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCloseEntryUser", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCloseEntryUser", SqlDbType.Int, 0)).Value = model.FCloseEntryUser;
            }
            if (model.FCloseEntryDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCloseEntryDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCloseEntryDate", SqlDbType.DateTime, 0)).Value = model.FCloseEntryDate;
            }
            if (model.FCloseEntryCauses == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCloseEntryCauses", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCloseEntryCauses", SqlDbType.NVarChar, 255)).Value = model.FCloseEntryCauses;
            }
            if (model.FOutSourceInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOutSourceInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOutSourceInterID", SqlDbType.Int, 0)).Value = model.FOutSourceInterID;
            }
            if (model.FOutSourceEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOutSourceEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOutSourceEntryID", SqlDbType.Int, 0)).Value = model.FOutSourceEntryID;
            }
            if (model.FOutSourceTranType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOutSourceTranType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOutSourceTranType", SqlDbType.Int, 0)).Value = model.FOutSourceTranType;
            }
            cmd.Parameters.Add(new SqlParameter("@m_FDetailID", SqlDbType.Int, 0)).Value = model.FDetailID;

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        


    }
}
