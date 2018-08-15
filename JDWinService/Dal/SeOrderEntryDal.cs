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
    public class SeOrderEntryDal
    {
        Common com = new Common();
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息

        /// <summary>
        /// 更新交货日期
        /// </summary>
        /// <param name="model"></param>
        public void UpdateFdate(JD_SeorderBG_Log model)
        {
            string sql = string.Empty;
            if (model.FEntrySelfS0154 != null)
            {
                sql = string.Format(@"update Seorderentry set FDate={0},FAdviceConsignDate={0},FEntrySelfS0154={3},FNote='{4}',FEntrySelfS0183='{5}',FEntrySelfS0184='{6}' where FInterID={1} and FEntryID={2}",
                (model.FDate != null) ? "'" + model.FDate + "'" : null,
                model.FInterID,
                model.FEntryID,
                (model.FEntrySelfS0154 != null) ? "'" + model.FEntrySelfS0154 + "'" : null,
                  model.FNote,
                model.FEntrySelfS0183,
                model.FEntrySelfS0184
              );
            }
            else
            {
                sql = string.Format(@"update Seorderentry set FDate={0},FAdviceConsignDate={0},FNote='{3}',FEntrySelfS0183='{4}',FEntrySelfS0184='{5}' where FInterID={1} and FEntryID={2}",
               (model.FDate != null) ? "'" + model.FDate + "'" : null,
               model.FInterID,
               model.FEntryID,
                 model.FNote,
               model.FEntrySelfS0183,
               model.FEntrySelfS0184
             );
            }

            com.WriteLogs("update sql:" + sql);
            DBUtil.ExecuteSql(sql, K3connectionString);
        }


        /// <summary>
		/// 对象SEOrderEntry明细
		/// 编写人：ywk
		/// 编写日期：2018/6/29 星期五
		/// </summary>
		public SEOrderEntry Detail(int FInterID, int FEntryID)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM SEOrderEntry WHERE FInterID = @m_FInterID and FEntryID=@m_FEntryID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_FInterID", SqlDbType.Int, 0)).Value = FInterID;
            cmd.Parameters.Add(new SqlParameter("@m_FEntryID", SqlDbType.Int, 0)).Value = FEntryID;

            SEOrderEntry myDetail = new SEOrderEntry();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["FBrNO"])) { myDetail.FBrNO = Convert.ToString(myReader["FBrNO"]); }
                if (!Convert.IsDBNull(myReader["FInterID"])) { myDetail.FInterID = Convert.ToInt32(myReader["FInterID"]); }
                if (!Convert.IsDBNull(myReader["FEntryID"])) { myDetail.FEntryID = Convert.ToInt32(myReader["FEntryID"]); }
                if (!Convert.IsDBNull(myReader["FItemID"])) { myDetail.FItemID = Convert.ToInt32(myReader["FItemID"]); }
                if (!Convert.IsDBNull(myReader["FQty"])) { myDetail.FQty = Convert.ToDecimal(myReader["FQty"]); }
                if (!Convert.IsDBNull(myReader["FCommitQty"])) { myDetail.FCommitQty = Convert.ToDecimal(myReader["FCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FPrice"])) { myDetail.FPrice = Convert.ToDecimal(myReader["FPrice"]); }
                if (!Convert.IsDBNull(myReader["FAmount"])) { myDetail.FAmount = Convert.ToDecimal(myReader["FAmount"]); }
                if (!Convert.IsDBNull(myReader["FTaxRate"])) { myDetail.FTaxRate = Convert.ToDecimal(myReader["FTaxRate"]); }
                if (!Convert.IsDBNull(myReader["FTaxAmount"])) { myDetail.FTaxAmount = Convert.ToDecimal(myReader["FTaxAmount"]); }
                if (!Convert.IsDBNull(myReader["FTax"])) { myDetail.FTax = Convert.ToDecimal(myReader["FTax"]); }
                if (!Convert.IsDBNull(myReader["FDiscount"])) { myDetail.FDiscount = float.Parse(myReader["FDiscount"].ToString()); }
                if (!Convert.IsDBNull(myReader["FNote"])) { myDetail.FNote = Convert.ToString(myReader["FNote"]); }
                if (!Convert.IsDBNull(myReader["FDate"])) { myDetail.FDate = Convert.ToDateTime(myReader["FDate"]); }
                if (!Convert.IsDBNull(myReader["FDiscountAmount"])) { myDetail.FDiscountAmount = Convert.ToDecimal(myReader["FDiscountAmount"]); }
                if (!Convert.IsDBNull(myReader["FInvoiceQty"])) { myDetail.FInvoiceQty = Convert.ToDecimal(myReader["FInvoiceQty"]); }
                if (!Convert.IsDBNull(myReader["FBCommitQty"])) { myDetail.FBCommitQty = Convert.ToDecimal(myReader["FBCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FTranLeadTime"])) { myDetail.FTranLeadTime = Convert.ToInt32(myReader["FTranLeadTime"]); }
                if (!Convert.IsDBNull(myReader["FATPDeduct"])) { myDetail.FATPDeduct = Convert.ToInt32(myReader["FATPDeduct"]); }
                if (!Convert.IsDBNull(myReader["FCostObjectID"])) { myDetail.FCostObjectID = Convert.ToInt32(myReader["FCostObjectID"]); }
                if (!Convert.IsDBNull(myReader["FUnitID"])) { myDetail.FUnitID = Convert.ToInt32(myReader["FUnitID"]); }
                if (!Convert.IsDBNull(myReader["FAuxBCommitQty"])) { myDetail.FAuxBCommitQty = Convert.ToDecimal(myReader["FAuxBCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxCommitQty"])) { myDetail.FAuxCommitQty = Convert.ToDecimal(myReader["FAuxCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxInvoiceQty"])) { myDetail.FAuxInvoiceQty = Convert.ToDecimal(myReader["FAuxInvoiceQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxPrice"])) { myDetail.FAuxPrice = Convert.ToDecimal(myReader["FAuxPrice"]); }
                if (!Convert.IsDBNull(myReader["FAuxQty"])) { myDetail.FAuxQty = Convert.ToDecimal(myReader["FAuxQty"]); }
                if (!Convert.IsDBNull(myReader["FUniDiscount"])) { myDetail.FUniDiscount = Convert.ToDecimal(myReader["FUniDiscount"]); }
                if (!Convert.IsDBNull(myReader["FFinalAmount"])) { myDetail.FFinalAmount = Convert.ToDecimal(myReader["FFinalAmount"]); }
                if (!Convert.IsDBNull(myReader["FSourceEntryID"])) { myDetail.FSourceEntryID = Convert.ToInt32(myReader["FSourceEntryID"]); }
                if (!Convert.IsDBNull(myReader["FHaveMrp"])) { myDetail.FHaveMrp = Convert.ToInt32(myReader["FHaveMrp"]); }
                if (!Convert.IsDBNull(myReader["FStockQty"])) { myDetail.FStockQty = Convert.ToDecimal(myReader["FStockQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxStockQty"])) { myDetail.FAuxStockQty = Convert.ToDecimal(myReader["FAuxStockQty"]); }
                if (!Convert.IsDBNull(myReader["FBatchNo"])) { myDetail.FBatchNo = Convert.ToString(myReader["FBatchNo"]); }
                if (!Convert.IsDBNull(myReader["FCESS"])) { myDetail.FCESS = Convert.ToDecimal(myReader["FCESS"]); }
                if (!Convert.IsDBNull(myReader["FAdviceConsignDate"])) { myDetail.FAdviceConsignDate = Convert.ToDateTime(myReader["FAdviceConsignDate"]); }
                if (!Convert.IsDBNull(myReader["FBomInterID"])) { myDetail.FBomInterID = Convert.ToInt32(myReader["FBomInterID"]); }
                if (!Convert.IsDBNull(myReader["FMapNumber"])) { myDetail.FMapNumber = Convert.ToString(myReader["FMapNumber"]); }
                if (!Convert.IsDBNull(myReader["FMapName"])) { myDetail.FMapName = Convert.ToString(myReader["FMapName"]); }
                if (!Convert.IsDBNull(myReader["FLockFlag"])) { myDetail.FLockFlag = Convert.ToInt32(myReader["FLockFlag"]); }
                if (!Convert.IsDBNull(myReader["FInForeCast"])) { myDetail.FInForeCast = Convert.ToInt32(myReader["FInForeCast"]); }
                if (!Convert.IsDBNull(myReader["FAllAmount"])) { myDetail.FAllAmount = Convert.ToDecimal(myReader["FAllAmount"]); }
                if (!Convert.IsDBNull(myReader["FAllStdAmount"])) { myDetail.FAllStdAmount = Convert.ToDecimal(myReader["FAllStdAmount"]); }
                if (!Convert.IsDBNull(myReader["FAuxPropID"])) { myDetail.FAuxPropID = Convert.ToInt32(myReader["FAuxPropID"]); }
                if (!Convert.IsDBNull(myReader["FAuxPriceDiscount"])) { myDetail.FAuxPriceDiscount = Convert.ToDecimal(myReader["FAuxPriceDiscount"]); }
                if (!Convert.IsDBNull(myReader["FPriceDiscount"])) { myDetail.FPriceDiscount = Convert.ToDecimal(myReader["FPriceDiscount"]); }
                if (!Convert.IsDBNull(myReader["FQtyInvoice"])) { myDetail.FQtyInvoice = Convert.ToDecimal(myReader["FQtyInvoice"]); }
                if (!Convert.IsDBNull(myReader["FQtyInvoiceBase"])) { myDetail.FQtyInvoiceBase = Convert.ToDecimal(myReader["FQtyInvoiceBase"]); }
                if (!Convert.IsDBNull(myReader["FTaxAmt"])) { myDetail.FTaxAmt = Convert.ToDecimal(myReader["FTaxAmt"]); }
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
                if (!Convert.IsDBNull(myReader["FMRPTrackFlag"])) { myDetail.FMRPTrackFlag = Convert.ToInt32(myReader["FMRPTrackFlag"]); }
                if (!Convert.IsDBNull(myReader["FOrderCommitQty"])) { myDetail.FOrderCommitQty = Convert.ToDecimal(myReader["FOrderCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FOrderSecCommitQty"])) { myDetail.FOrderSecCommitQty = Convert.ToDecimal(myReader["FOrderSecCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxQtyInvoice"])) { myDetail.FAuxQtyInvoice = Convert.ToDecimal(myReader["FAuxQtyInvoice"]); }
                if (!Convert.IsDBNull(myReader["FCommitInstall"])) { myDetail.FCommitInstall = Convert.ToDecimal(myReader["FCommitInstall"]); }
                if (!Convert.IsDBNull(myReader["FAuxCommitInstall"])) { myDetail.FAuxCommitInstall = Convert.ToDecimal(myReader["FAuxCommitInstall"]); }
                if (!Convert.IsDBNull(myReader["FMrpClosed"])) { myDetail.FMrpClosed = Convert.ToInt32(myReader["FMrpClosed"]); }
                if (!Convert.IsDBNull(myReader["FAuxInCommitQty"])) { myDetail.FAuxInCommitQty = Convert.ToDecimal(myReader["FAuxInCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FInCommitQty"])) { myDetail.FInCommitQty = Convert.ToDecimal(myReader["FInCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FSecInCommitQty"])) { myDetail.FSecInCommitQty = Convert.ToDecimal(myReader["FSecInCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FApplyCommitQty"])) { myDetail.FApplyCommitQty = Convert.ToDecimal(myReader["FApplyCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxApplyCommitQty"])) { myDetail.FAuxApplyCommitQty = Convert.ToDecimal(myReader["FAuxApplyCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FSecApplyCommitQty"])) { myDetail.FSecApplyCommitQty = Convert.ToDecimal(myReader["FSecApplyCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FEvaluated"])) { myDetail.FEvaluated = Convert.ToInt32(myReader["FEvaluated"]); }
                if (!Convert.IsDBNull(myReader["FPackUnitID"])) { myDetail.FPackUnitID = Convert.ToInt32(myReader["FPackUnitID"]); }
                if (!Convert.IsDBNull(myReader["FPackCount"])) { myDetail.FPackCount = Convert.ToInt32(myReader["FPackCount"]); }
                if (!Convert.IsDBNull(myReader["FPackType"])) { myDetail.FPackType = Convert.ToDecimal(myReader["FPackType"]); }
                if (!Convert.IsDBNull(myReader["FDetailID"])) { myDetail.FDetailID = Convert.ToInt32(myReader["FDetailID"]); }
                if (!Convert.IsDBNull(myReader["FMapID"])) { myDetail.FMapID = Convert.ToInt32(myReader["FMapID"]); }
                if (!Convert.IsDBNull(myReader["FGoodsDesc"])) { myDetail.FGoodsDesc = Convert.ToString(myReader["FGoodsDesc"]); }
                if (!Convert.IsDBNull(myReader["FAmountAfterDiscount"])) { myDetail.FAmountAfterDiscount = Convert.ToDecimal(myReader["FAmountAfterDiscount"]); }
                if (!Convert.IsDBNull(myReader["FInformCommitQty"])) { myDetail.FInformCommitQty = Convert.ToDecimal(myReader["FInformCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxInformCommitQty"])) { myDetail.FAuxInformCommitQty = Convert.ToDecimal(myReader["FAuxInformCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FSecInformCommitQty"])) { myDetail.FSecInformCommitQty = Convert.ToDecimal(myReader["FSecInformCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FPurCommitQty"])) { myDetail.FPurCommitQty = Convert.ToDecimal(myReader["FPurCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxPurCommitQty"])) { myDetail.FAuxPurCommitQty = Convert.ToDecimal(myReader["FAuxPurCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FSecPurCommitQty"])) { myDetail.FSecPurCommitQty = Convert.ToDecimal(myReader["FSecPurCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FMrpAutoClosed"])) { myDetail.FMrpAutoClosed = Convert.ToInt32(myReader["FMrpAutoClosed"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0153"])) { myDetail.FEntrySelfS0153 = Convert.ToString(myReader["FEntrySelfS0153"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0154"])) { myDetail.FEntrySelfS0154 = Convert.ToDateTime(myReader["FEntrySelfS0154"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0155"])) { myDetail.FEntrySelfS0155 = Convert.ToDateTime(myReader["FEntrySelfS0155"]); }
                if (!Convert.IsDBNull(myReader["FSecStockQty"])) { myDetail.FSecStockQty = Convert.ToDecimal(myReader["FSecStockQty"]); }
                if (!Convert.IsDBNull(myReader["FSecInvoiceQty"])) { myDetail.FSecInvoiceQty = Convert.ToDecimal(myReader["FSecInvoiceQty"]); }
                if (!Convert.IsDBNull(myReader["FSecCommitInstall"])) { myDetail.FSecCommitInstall = Convert.ToDecimal(myReader["FSecCommitInstall"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0161"])) { myDetail.FEntrySelfS0161 = Convert.ToDecimal(myReader["FEntrySelfS0161"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0162"])) { myDetail.FEntrySelfS0162 = Convert.ToInt32(myReader["FEntrySelfS0162"]); }
                if (!Convert.IsDBNull(myReader["FPlanMode"])) { myDetail.FPlanMode = Convert.ToInt32(myReader["FPlanMode"]); }
                if (!Convert.IsDBNull(myReader["FMTONo"])) { myDetail.FMTONo = Convert.ToString(myReader["FMTONo"]); }
                if (!Convert.IsDBNull(myReader["FOrderBillNo"])) { myDetail.FOrderBillNo = Convert.ToString(myReader["FOrderBillNo"]); }
                if (!Convert.IsDBNull(myReader["FOrderEntryID"])) { myDetail.FOrderEntryID = Convert.ToInt32(myReader["FOrderEntryID"]); }
                if (!Convert.IsDBNull(myReader["FDiffQtyClosed"])) { myDetail.FDiffQtyClosed = Convert.ToDecimal(myReader["FDiffQtyClosed"]); }
                if (!Convert.IsDBNull(myReader["FBOMCategory"])) { myDetail.FBOMCategory = Convert.ToInt32(myReader["FBOMCategory"]); }
                if (!Convert.IsDBNull(myReader["FOrderBOMStatus"])) { myDetail.FOrderBOMStatus = Convert.ToInt32(myReader["FOrderBOMStatus"]); }
                if (!Convert.IsDBNull(myReader["FOrderBOMInterID"])) { myDetail.FOrderBOMInterID = Convert.ToInt32(myReader["FOrderBOMInterID"]); }
                if (!Convert.IsDBNull(myReader["FIsAltered"])) { myDetail.FIsAltered = byte.Parse("0"); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0171"])) { myDetail.FEntrySelfS0171 = Convert.ToString(myReader["FEntrySelfS0171"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0174"])) { myDetail.FEntrySelfS0174 = Convert.ToDateTime(myReader["FEntrySelfS0174"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0177"])) { myDetail.FEntrySelfS0177 = Convert.ToInt32(myReader["FEntrySelfS0177"]); }
                if (!Convert.IsDBNull(myReader["FAmountExceptDisCount"])) { myDetail.FAmountExceptDisCount = Convert.ToDecimal(myReader["FAmountExceptDisCount"]); }
                if (!Convert.IsDBNull(myReader["FAllAmountExceptDisCount"])) { myDetail.FAllAmountExceptDisCount = Convert.ToDecimal(myReader["FAllAmountExceptDisCount"]); }
                if (!Convert.IsDBNull(myReader["FEntryDisCount"])) { myDetail.FEntryDisCount = Convert.ToDecimal(myReader["FEntryDisCount"]); }
                if (!Convert.IsDBNull(myReader["FCommitAmt"])) { myDetail.FCommitAmt = Convert.ToDecimal(myReader["FCommitAmt"]); }
                if (!Convert.IsDBNull(myReader["FCommitAmtTax"])) { myDetail.FCommitAmtTax = Convert.ToDecimal(myReader["FCommitAmtTax"]); }
                if (!Convert.IsDBNull(myReader["FCommitTax"])) { myDetail.FCommitTax = Convert.ToDecimal(myReader["FCommitTax"]); }
                if (!Convert.IsDBNull(myReader["FIsAPS"])) { myDetail.FIsAPS = Convert.ToInt32(myReader["FIsAPS"]); }
                if (!Convert.IsDBNull(myReader["FMeetDelivery"])) { myDetail.FMeetDelivery = Convert.ToInt32(myReader["FMeetDelivery"]); }
                if (!Convert.IsDBNull(myReader["FOrderBOMEntryID"])) { myDetail.FOrderBOMEntryID = Convert.ToInt32(myReader["FOrderBOMEntryID"]); }
                if (!Convert.IsDBNull(myReader["FOutSourceInterID"])) { myDetail.FOutSourceInterID = Convert.ToInt32(myReader["FOutSourceInterID"]); }
                if (!Convert.IsDBNull(myReader["FOutSourceEntryID"])) { myDetail.FOutSourceEntryID = Convert.ToInt32(myReader["FOutSourceEntryID"]); }
                if (!Convert.IsDBNull(myReader["FOutSourceTranType"])) { myDetail.FOutSourceTranType = Convert.ToInt32(myReader["FOutSourceTranType"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0183"])) { myDetail.FEntrySelfS0183 = Convert.ToString(myReader["FEntrySelfS0183"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfS0184"])) { myDetail.FEntrySelfS0184 = Convert.ToString(myReader["FEntrySelfS0184"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        /// <summary>
		/// 新增SEOrderEntry对象
		/// 编写人：ywk
		/// 编写日期：2018/6/29 星期五
		/// </summary>
		public int Add(SEOrderEntry model)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO SEOrderEntry(FBrNO,FInterID,FEntryID,FItemID,FQty,FCommitQty,FPrice,FAmount,FTaxRate,FTaxAmount,FTax,FDiscount,FNote,FDate,FDiscountAmount,FInvoiceQty,FBCommitQty,FTranLeadTime,FATPDeduct,FCostObjectID,FUnitID,FAuxBCommitQty,FAuxCommitQty,FAuxInvoiceQty,FAuxPrice,FAuxQty,FUniDiscount,FFinalAmount,FSourceEntryID,FHaveMrp,FStockQty,FAuxStockQty,FBatchNo,FCESS,FAdviceConsignDate,FBomInterID,FMapNumber,FMapName,FLockFlag,FInForeCast,FAllAmount,FAllStdAmount,FAuxPropID,FAuxPriceDiscount,FPriceDiscount,FQtyInvoice,FQtyInvoiceBase,FTaxAmt,FAuxTaxPrice,FTaxPrice,FReceiveAmountFor_Commit,FReceiveAmount_Commit,FSecCoefficient,FSecQty,FSecCommitQty,FSourceTranType,FSourceInterId,FSourceBillNo,FContractInterID,FContractEntryID,FContractBillNo,FMRPLockFlag,FMRPTrackFlag,FOrderCommitQty,FOrderSecCommitQty,FAuxQtyInvoice,FCommitInstall,FAuxCommitInstall,FMrpClosed,FAuxInCommitQty,FInCommitQty,FSecInCommitQty,FApplyCommitQty,FAuxApplyCommitQty,FSecApplyCommitQty,FEvaluated,FPackUnitID,FPackCount,FPackType,FMapID,FGoodsDesc,FAmountAfterDiscount,FInformCommitQty,FAuxInformCommitQty,FSecInformCommitQty,FPurCommitQty,FAuxPurCommitQty,FSecPurCommitQty,FMrpAutoClosed,FEntrySelfS0153,FEntrySelfS0154,FEntrySelfS0155,FSecStockQty,FSecInvoiceQty,FSecCommitInstall,FEntrySelfS0161,FEntrySelfS0162,FPlanMode,FMTONo,FOrderBillNo,FOrderEntryID,FDiffQtyClosed,FBOMCategory,FOrderBOMStatus,FOrderBOMInterID,FIsAltered,FEntrySelfS0171,FEntrySelfS0174,FEntrySelfS0177,FAmountExceptDisCount,FAllAmountExceptDisCount,FEntryDisCount,FCommitAmt,FCommitAmtTax,FCommitTax,FIsAPS,FMeetDelivery,FOrderBOMEntryID,FOutSourceInterID,FOutSourceEntryID,FOutSourceTranType,FEntrySelfS0183,FEntrySelfS0184) VALUES(@m_FBrNO,@m_FInterID,@m_FEntryID,@m_FItemID,@m_FQty,@m_FCommitQty,@m_FPrice,@m_FAmount,@m_FTaxRate,@m_FTaxAmount,@m_FTax,@m_FDiscount,@m_FNote,@m_FDate,@m_FDiscountAmount,@m_FInvoiceQty,@m_FBCommitQty,@m_FTranLeadTime,@m_FATPDeduct,@m_FCostObjectID,@m_FUnitID,@m_FAuxBCommitQty,@m_FAuxCommitQty,@m_FAuxInvoiceQty,@m_FAuxPrice,@m_FAuxQty,@m_FUniDiscount,@m_FFinalAmount,@m_FSourceEntryID,@m_FHaveMrp,@m_FStockQty,@m_FAuxStockQty,@m_FBatchNo,@m_FCESS,@m_FAdviceConsignDate,@m_FBomInterID,@m_FMapNumber,@m_FMapName,@m_FLockFlag,@m_FInForeCast,@m_FAllAmount,@m_FAllStdAmount,@m_FAuxPropID,@m_FAuxPriceDiscount,@m_FPriceDiscount,@m_FQtyInvoice,@m_FQtyInvoiceBase,@m_FTaxAmt,@m_FAuxTaxPrice,@m_FTaxPrice,@m_FReceiveAmountFor_Commit,@m_FReceiveAmount_Commit,@m_FSecCoefficient,@m_FSecQty,@m_FSecCommitQty,@m_FSourceTranType,@m_FSourceInterId,@m_FSourceBillNo,@m_FContractInterID,@m_FContractEntryID,@m_FContractBillNo,@m_FMRPLockFlag,@m_FMRPTrackFlag,@m_FOrderCommitQty,@m_FOrderSecCommitQty,@m_FAuxQtyInvoice,@m_FCommitInstall,@m_FAuxCommitInstall,@m_FMrpClosed,@m_FAuxInCommitQty,@m_FInCommitQty,@m_FSecInCommitQty,@m_FApplyCommitQty,@m_FAuxApplyCommitQty,@m_FSecApplyCommitQty,@m_FEvaluated,@m_FPackUnitID,@m_FPackCount,@m_FPackType,@m_FMapID,@m_FGoodsDesc,@m_FAmountAfterDiscount,@m_FInformCommitQty,@m_FAuxInformCommitQty,@m_FSecInformCommitQty,@m_FPurCommitQty,@m_FAuxPurCommitQty,@m_FSecPurCommitQty,@m_FMrpAutoClosed,@m_FEntrySelfS0153,@m_FEntrySelfS0154,@m_FEntrySelfS0155,@m_FSecStockQty,@m_FSecInvoiceQty,@m_FSecCommitInstall,@m_FEntrySelfS0161,@m_FEntrySelfS0162,@m_FPlanMode,@m_FMTONo,@m_FOrderBillNo,@m_FOrderEntryID,@m_FDiffQtyClosed,@m_FBOMCategory,@m_FOrderBOMStatus,@m_FOrderBOMInterID,@m_FIsAltered,@m_FEntrySelfS0171,@m_FEntrySelfS0174,@m_FEntrySelfS0177,@m_FAmountExceptDisCount,@m_FAllAmountExceptDisCount,@m_FEntryDisCount,@m_FCommitAmt,@m_FCommitAmtTax,@m_FCommitTax,@m_FIsAPS,@m_FMeetDelivery,@m_FOrderBOMEntryID,@m_FOutSourceInterID,@m_FOutSourceEntryID,@m_FOutSourceTranType,@m_FEntrySelfS0183,@m_FEntrySelfS0184) SELECT @thisId=@@IDENTITY FROM SEOrderEntry", con);
            con.Open();

            if (model.FBrNO == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBrNO", SqlDbType.VarChar, 10)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBrNO", SqlDbType.VarChar, 10)).Value = model.FBrNO;
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
            if (model.FTaxAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxAmount", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxAmount", SqlDbType.Decimal, 20)).Value = model.FTaxAmount;
            }
            if (model.FTax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTax", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTax", SqlDbType.Decimal, 20)).Value = model.FTax;
            }
            if (model.FDiscount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDiscount", SqlDbType.Real, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDiscount", SqlDbType.Real, 0)).Value = model.FDiscount;
            }
            if (model.FNote == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.VarChar, 255)).Value = model.FNote;
            }
            if (model.FDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = model.FDate;
            }
            if (model.FDiscountAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDiscountAmount", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDiscountAmount", SqlDbType.Decimal, 20)).Value = model.FDiscountAmount;
            }
            if (model.FInvoiceQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInvoiceQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInvoiceQty", SqlDbType.Decimal, 28)).Value = model.FInvoiceQty;
            }
            if (model.FBCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBCommitQty", SqlDbType.Decimal, 28)).Value = model.FBCommitQty;
            }
            if (model.FTranLeadTime == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTranLeadTime", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTranLeadTime", SqlDbType.Int, 0)).Value = model.FTranLeadTime;
            }
            if (model.FATPDeduct == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FATPDeduct", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FATPDeduct", SqlDbType.Int, 0)).Value = model.FATPDeduct;
            }
            if (model.FCostObjectID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCostObjectID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCostObjectID", SqlDbType.Int, 0)).Value = model.FCostObjectID;
            }
            if (model.FUnitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.Int, 0)).Value = model.FUnitID;
            }
            if (model.FAuxBCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxBCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxBCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxBCommitQty;
            }
            if (model.FAuxCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxCommitQty;
            }
            if (model.FAuxInvoiceQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxInvoiceQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxInvoiceQty", SqlDbType.Decimal, 28)).Value = model.FAuxInvoiceQty;
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
            if (model.FUniDiscount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUniDiscount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUniDiscount", SqlDbType.Decimal, 28)).Value = model.FUniDiscount;
            }
            if (model.FFinalAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFinalAmount", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFinalAmount", SqlDbType.Decimal, 20)).Value = model.FFinalAmount;
            }
            if (model.FSourceEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.Int, 0)).Value = model.FSourceEntryID;
            }
            if (model.FHaveMrp == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHaveMrp", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHaveMrp", SqlDbType.Int, 0)).Value = model.FHaveMrp;
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
            if (model.FBatchNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchNo", SqlDbType.VarChar, 200)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchNo", SqlDbType.VarChar, 200)).Value = model.FBatchNo;
            }
            if (model.FCESS == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCESS", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCESS", SqlDbType.Decimal, 20)).Value = model.FCESS;
            }
            if (model.FAdviceConsignDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAdviceConsignDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAdviceConsignDate", SqlDbType.DateTime, 0)).Value = model.FAdviceConsignDate;
            }
            if (model.FBomInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBomInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBomInterID", SqlDbType.Int, 0)).Value = model.FBomInterID;
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
            if (model.FLockFlag == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLockFlag", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLockFlag", SqlDbType.Int, 0)).Value = model.FLockFlag;
            }
            if (model.FInForeCast == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInForeCast", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInForeCast", SqlDbType.Int, 0)).Value = model.FInForeCast;
            }
            if (model.FAllAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllAmount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllAmount", SqlDbType.Decimal, 28)).Value = model.FAllAmount;
            }
            if (model.FAllStdAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllStdAmount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllStdAmount", SqlDbType.Decimal, 28)).Value = model.FAllStdAmount;
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
            if (model.FTaxAmt == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxAmt", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxAmt", SqlDbType.Decimal, 28)).Value = model.FTaxAmt;
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
            if (model.FMRPTrackFlag == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMRPTrackFlag", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMRPTrackFlag", SqlDbType.Int, 0)).Value = model.FMRPTrackFlag;
            }
            if (model.FOrderCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderCommitQty", SqlDbType.Decimal, 28)).Value = model.FOrderCommitQty;
            }
            if (model.FOrderSecCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderSecCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderSecCommitQty", SqlDbType.Decimal, 28)).Value = model.FOrderSecCommitQty;
            }
            if (model.FAuxQtyInvoice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQtyInvoice", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQtyInvoice", SqlDbType.Decimal, 28)).Value = model.FAuxQtyInvoice;
            }
            if (model.FCommitInstall == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitInstall", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitInstall", SqlDbType.Decimal, 28)).Value = model.FCommitInstall;
            }
            if (model.FAuxCommitInstall == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitInstall", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitInstall", SqlDbType.Decimal, 28)).Value = model.FAuxCommitInstall;
            }
            if (model.FMrpClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpClosed", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpClosed", SqlDbType.Int, 0)).Value = model.FMrpClosed;
            }
            if (model.FAuxInCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxInCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxInCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxInCommitQty;
            }
            if (model.FInCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInCommitQty", SqlDbType.Decimal, 28)).Value = model.FInCommitQty;
            }
            if (model.FSecInCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecInCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecInCommitQty", SqlDbType.Decimal, 28)).Value = model.FSecInCommitQty;
            }
            if (model.FApplyCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FApplyCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FApplyCommitQty", SqlDbType.Decimal, 28)).Value = model.FApplyCommitQty;
            }
            if (model.FAuxApplyCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxApplyCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxApplyCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxApplyCommitQty;
            }
            if (model.FSecApplyCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecApplyCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecApplyCommitQty", SqlDbType.Decimal, 28)).Value = model.FSecApplyCommitQty;
            }
            if (model.FEvaluated == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEvaluated", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEvaluated", SqlDbType.Int, 0)).Value = model.FEvaluated;
            }
            if (model.FPackUnitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPackUnitID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPackUnitID", SqlDbType.Int, 0)).Value = model.FPackUnitID;
            }
            if (model.FPackCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPackCount", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPackCount", SqlDbType.Int, 0)).Value = model.FPackCount;
            }
            if (model.FPackType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPackType", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPackType", SqlDbType.Decimal, 28)).Value = model.FPackType;
            }
            if (model.FMapID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMapID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMapID", SqlDbType.Int, 0)).Value = model.FMapID;
            }
            if (model.FGoodsDesc == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FGoodsDesc", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FGoodsDesc", SqlDbType.NVarChar, 255)).Value = model.FGoodsDesc;
            }
            if (model.FAmountAfterDiscount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmountAfterDiscount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmountAfterDiscount", SqlDbType.Decimal, 28)).Value = model.FAmountAfterDiscount;
            }
            if (model.FInformCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInformCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInformCommitQty", SqlDbType.Decimal, 28)).Value = model.FInformCommitQty;
            }
            if (model.FAuxInformCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxInformCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxInformCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxInformCommitQty;
            }
            if (model.FSecInformCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecInformCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecInformCommitQty", SqlDbType.Decimal, 28)).Value = model.FSecInformCommitQty;
            }
            if (model.FPurCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPurCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPurCommitQty", SqlDbType.Decimal, 28)).Value = model.FPurCommitQty;
            }
            if (model.FAuxPurCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPurCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPurCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxPurCommitQty;
            }
            if (model.FSecPurCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecPurCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecPurCommitQty", SqlDbType.Decimal, 28)).Value = model.FSecPurCommitQty;
            }
            if (model.FMrpAutoClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpAutoClosed", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpAutoClosed", SqlDbType.Int, 0)).Value = model.FMrpAutoClosed;
            }
            if (model.FEntrySelfS0153 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0153", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0153", SqlDbType.VarChar, 255)).Value = model.FEntrySelfS0153;
            }
            if (model.FEntrySelfS0154 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0154", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0154", SqlDbType.DateTime, 0)).Value = model.FEntrySelfS0154;
            }
            if (model.FEntrySelfS0155 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0155", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0155", SqlDbType.DateTime, 0)).Value = model.FEntrySelfS0155;
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
            if (model.FSecCommitInstall == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecCommitInstall", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecCommitInstall", SqlDbType.Decimal, 23)).Value = model.FSecCommitInstall;
            }
            if (model.FEntrySelfS0161 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0161", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0161", SqlDbType.Decimal, 28)).Value = model.FEntrySelfS0161;
            }
            if (model.FEntrySelfS0162 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0162", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0162", SqlDbType.Int, 0)).Value = model.FEntrySelfS0162;
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
            if (model.FOrderBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBillNo", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBillNo", SqlDbType.NVarChar, 255)).Value = model.FOrderBillNo;
            }
            if (model.FOrderEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderEntryID", SqlDbType.Int, 0)).Value = model.FOrderEntryID;
            }
            if (model.FDiffQtyClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDiffQtyClosed", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDiffQtyClosed", SqlDbType.Decimal, 28)).Value = model.FDiffQtyClosed;
            }
            if (model.FBOMCategory == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBOMCategory", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBOMCategory", SqlDbType.Int, 0)).Value = model.FBOMCategory;
            }
            if (model.FOrderBOMStatus == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMStatus", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMStatus", SqlDbType.Int, 0)).Value = model.FOrderBOMStatus;
            }
            if (model.FOrderBOMInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMInterID", SqlDbType.Int, 0)).Value = model.FOrderBOMInterID;
            }
            if (model.FIsAltered == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsAltered", SqlDbType.TinyInt, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsAltered", SqlDbType.TinyInt, 0)).Value = model.FIsAltered;
            }
            if (model.FEntrySelfS0171 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0171", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0171", SqlDbType.VarChar, 255)).Value = model.FEntrySelfS0171;
            }
            if (model.FEntrySelfS0174 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0174", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0174", SqlDbType.DateTime, 0)).Value = model.FEntrySelfS0174;
            }
            if (model.FEntrySelfS0177 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0177", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0177", SqlDbType.Int, 0)).Value = model.FEntrySelfS0177;
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
            if (model.FIsAPS == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsAPS", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsAPS", SqlDbType.Int, 0)).Value = model.FIsAPS;
            }
            if (model.FMeetDelivery == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMeetDelivery", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMeetDelivery", SqlDbType.Int, 0)).Value = model.FMeetDelivery;
            }
            if (model.FOrderBOMEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMEntryID", SqlDbType.Int, 0)).Value = model.FOrderBOMEntryID;
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
            if (model.FEntrySelfS0183 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0183", SqlDbType.Text, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0183", SqlDbType.Text, 0)).Value = model.FEntrySelfS0183;
            }
            if (model.FEntrySelfS0184 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0184", SqlDbType.Text, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0184", SqlDbType.Text, 0)).Value = model.FEntrySelfS0184;
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
        /// 更新SEOrderEntry对象
        /// 编写人：ywk
        /// 编写日期：2018/6/29 星期五
        /// </summary>
        public void Update(SEOrderEntry model)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE SEOrderEntry SET FBrNO = @m_FBrNO,FInterID = @m_FInterID,FEntryID = @m_FEntryID,FItemID = @m_FItemID,FQty = @m_FQty,FCommitQty = @m_FCommitQty,FPrice = @m_FPrice,FAmount = @m_FAmount,FTaxRate = @m_FTaxRate,FTaxAmount = @m_FTaxAmount,FTax = @m_FTax,FDiscount = @m_FDiscount,FNote = @m_FNote,FDate = @m_FDate,FDiscountAmount = @m_FDiscountAmount,FInvoiceQty = @m_FInvoiceQty,FBCommitQty = @m_FBCommitQty,FTranLeadTime = @m_FTranLeadTime,FATPDeduct = @m_FATPDeduct,FCostObjectID = @m_FCostObjectID,FUnitID = @m_FUnitID,FAuxBCommitQty = @m_FAuxBCommitQty,FAuxCommitQty = @m_FAuxCommitQty,FAuxInvoiceQty = @m_FAuxInvoiceQty,FAuxPrice = @m_FAuxPrice,FAuxQty = @m_FAuxQty,FUniDiscount = @m_FUniDiscount,FFinalAmount = @m_FFinalAmount,FSourceEntryID = @m_FSourceEntryID,FHaveMrp = @m_FHaveMrp,FStockQty = @m_FStockQty,FAuxStockQty = @m_FAuxStockQty,FBatchNo = @m_FBatchNo,FCESS = @m_FCESS,FAdviceConsignDate = @m_FAdviceConsignDate,FBomInterID = @m_FBomInterID,FMapNumber = @m_FMapNumber,FMapName = @m_FMapName,FLockFlag = @m_FLockFlag,FInForeCast = @m_FInForeCast,FAllAmount = @m_FAllAmount,FAllStdAmount = @m_FAllStdAmount,FAuxPropID = @m_FAuxPropID,FAuxPriceDiscount = @m_FAuxPriceDiscount,FPriceDiscount = @m_FPriceDiscount,FQtyInvoice = @m_FQtyInvoice,FQtyInvoiceBase = @m_FQtyInvoiceBase,FTaxAmt = @m_FTaxAmt,FAuxTaxPrice = @m_FAuxTaxPrice,FTaxPrice = @m_FTaxPrice,FReceiveAmountFor_Commit = @m_FReceiveAmountFor_Commit,FReceiveAmount_Commit = @m_FReceiveAmount_Commit,FSecCoefficient = @m_FSecCoefficient,FSecQty = @m_FSecQty,FSecCommitQty = @m_FSecCommitQty,FSourceTranType = @m_FSourceTranType,FSourceInterId = @m_FSourceInterId,FSourceBillNo = @m_FSourceBillNo,FContractInterID = @m_FContractInterID,FContractEntryID = @m_FContractEntryID,FContractBillNo = @m_FContractBillNo,FMRPLockFlag = @m_FMRPLockFlag,FMRPTrackFlag = @m_FMRPTrackFlag,FOrderCommitQty = @m_FOrderCommitQty,FOrderSecCommitQty = @m_FOrderSecCommitQty,FAuxQtyInvoice = @m_FAuxQtyInvoice,FCommitInstall = @m_FCommitInstall,FAuxCommitInstall = @m_FAuxCommitInstall,FMrpClosed = @m_FMrpClosed,FAuxInCommitQty = @m_FAuxInCommitQty,FInCommitQty = @m_FInCommitQty,FSecInCommitQty = @m_FSecInCommitQty,FApplyCommitQty = @m_FApplyCommitQty,FAuxApplyCommitQty = @m_FAuxApplyCommitQty,FSecApplyCommitQty = @m_FSecApplyCommitQty,FEvaluated = @m_FEvaluated,FPackUnitID = @m_FPackUnitID,FPackCount = @m_FPackCount,FPackType = @m_FPackType,FMapID = @m_FMapID,FGoodsDesc = @m_FGoodsDesc,FAmountAfterDiscount = @m_FAmountAfterDiscount,FInformCommitQty = @m_FInformCommitQty,FAuxInformCommitQty = @m_FAuxInformCommitQty,FSecInformCommitQty = @m_FSecInformCommitQty,FPurCommitQty = @m_FPurCommitQty,FAuxPurCommitQty = @m_FAuxPurCommitQty,FSecPurCommitQty = @m_FSecPurCommitQty,FMrpAutoClosed = @m_FMrpAutoClosed,FEntrySelfS0153 = @m_FEntrySelfS0153,FEntrySelfS0154 = @m_FEntrySelfS0154,FEntrySelfS0155 = @m_FEntrySelfS0155,FSecStockQty = @m_FSecStockQty,FSecInvoiceQty = @m_FSecInvoiceQty,FSecCommitInstall = @m_FSecCommitInstall,FEntrySelfS0161 = @m_FEntrySelfS0161,FEntrySelfS0162 = @m_FEntrySelfS0162,FPlanMode = @m_FPlanMode,FMTONo = @m_FMTONo,FOrderBillNo = @m_FOrderBillNo,FOrderEntryID = @m_FOrderEntryID,FDiffQtyClosed = @m_FDiffQtyClosed,FBOMCategory = @m_FBOMCategory,FOrderBOMStatus = @m_FOrderBOMStatus,FOrderBOMInterID = @m_FOrderBOMInterID,FIsAltered = @m_FIsAltered,FEntrySelfS0171 = @m_FEntrySelfS0171,FEntrySelfS0174 = @m_FEntrySelfS0174,FEntrySelfS0177 = @m_FEntrySelfS0177,FAmountExceptDisCount = @m_FAmountExceptDisCount,FAllAmountExceptDisCount = @m_FAllAmountExceptDisCount,FEntryDisCount = @m_FEntryDisCount,FCommitAmt = @m_FCommitAmt,FCommitAmtTax = @m_FCommitAmtTax,FCommitTax = @m_FCommitTax,FIsAPS = @m_FIsAPS,FMeetDelivery = @m_FMeetDelivery,FOrderBOMEntryID = @m_FOrderBOMEntryID,FOutSourceInterID = @m_FOutSourceInterID,FOutSourceEntryID = @m_FOutSourceEntryID,FOutSourceTranType = @m_FOutSourceTranType,FEntrySelfS0183 = @m_FEntrySelfS0183,FEntrySelfS0184 = @m_FEntrySelfS0184 WHERE FDetailID = @m_FDetailID", con);
            con.Open();

            if (model.FBrNO == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBrNO", SqlDbType.VarChar, 10)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBrNO", SqlDbType.VarChar, 10)).Value = model.FBrNO;
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
            if (model.FTaxAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxAmount", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxAmount", SqlDbType.Decimal, 20)).Value = model.FTaxAmount;
            }
            if (model.FTax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTax", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTax", SqlDbType.Decimal, 20)).Value = model.FTax;
            }
            if (model.FDiscount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDiscount", SqlDbType.Real, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDiscount", SqlDbType.Real, 0)).Value = model.FDiscount;
            }
            if (model.FNote == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.VarChar, 255)).Value = model.FNote;
            }
            if (model.FDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = model.FDate;
            }
            if (model.FDiscountAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDiscountAmount", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDiscountAmount", SqlDbType.Decimal, 20)).Value = model.FDiscountAmount;
            }
            if (model.FInvoiceQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInvoiceQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInvoiceQty", SqlDbType.Decimal, 28)).Value = model.FInvoiceQty;
            }
            if (model.FBCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBCommitQty", SqlDbType.Decimal, 28)).Value = model.FBCommitQty;
            }
            if (model.FTranLeadTime == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTranLeadTime", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTranLeadTime", SqlDbType.Int, 0)).Value = model.FTranLeadTime;
            }
            if (model.FATPDeduct == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FATPDeduct", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FATPDeduct", SqlDbType.Int, 0)).Value = model.FATPDeduct;
            }
            if (model.FCostObjectID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCostObjectID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCostObjectID", SqlDbType.Int, 0)).Value = model.FCostObjectID;
            }
            if (model.FUnitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.Int, 0)).Value = model.FUnitID;
            }
            if (model.FAuxBCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxBCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxBCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxBCommitQty;
            }
            if (model.FAuxCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxCommitQty;
            }
            if (model.FAuxInvoiceQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxInvoiceQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxInvoiceQty", SqlDbType.Decimal, 28)).Value = model.FAuxInvoiceQty;
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
            if (model.FUniDiscount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUniDiscount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUniDiscount", SqlDbType.Decimal, 28)).Value = model.FUniDiscount;
            }
            if (model.FFinalAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFinalAmount", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFinalAmount", SqlDbType.Decimal, 20)).Value = model.FFinalAmount;
            }
            if (model.FSourceEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.Int, 0)).Value = model.FSourceEntryID;
            }
            if (model.FHaveMrp == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHaveMrp", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHaveMrp", SqlDbType.Int, 0)).Value = model.FHaveMrp;
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
            if (model.FBatchNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchNo", SqlDbType.VarChar, 200)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchNo", SqlDbType.VarChar, 200)).Value = model.FBatchNo;
            }
            if (model.FCESS == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCESS", SqlDbType.Decimal, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCESS", SqlDbType.Decimal, 20)).Value = model.FCESS;
            }
            if (model.FAdviceConsignDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAdviceConsignDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAdviceConsignDate", SqlDbType.DateTime, 0)).Value = model.FAdviceConsignDate;
            }
            if (model.FBomInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBomInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBomInterID", SqlDbType.Int, 0)).Value = model.FBomInterID;
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
            if (model.FLockFlag == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLockFlag", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLockFlag", SqlDbType.Int, 0)).Value = model.FLockFlag;
            }
            if (model.FInForeCast == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInForeCast", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInForeCast", SqlDbType.Int, 0)).Value = model.FInForeCast;
            }
            if (model.FAllAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllAmount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllAmount", SqlDbType.Decimal, 28)).Value = model.FAllAmount;
            }
            if (model.FAllStdAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllStdAmount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAllStdAmount", SqlDbType.Decimal, 28)).Value = model.FAllStdAmount;
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
            if (model.FTaxAmt == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxAmt", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxAmt", SqlDbType.Decimal, 28)).Value = model.FTaxAmt;
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
            if (model.FMRPTrackFlag == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMRPTrackFlag", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMRPTrackFlag", SqlDbType.Int, 0)).Value = model.FMRPTrackFlag;
            }
            if (model.FOrderCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderCommitQty", SqlDbType.Decimal, 28)).Value = model.FOrderCommitQty;
            }
            if (model.FOrderSecCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderSecCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderSecCommitQty", SqlDbType.Decimal, 28)).Value = model.FOrderSecCommitQty;
            }
            if (model.FAuxQtyInvoice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQtyInvoice", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQtyInvoice", SqlDbType.Decimal, 28)).Value = model.FAuxQtyInvoice;
            }
            if (model.FCommitInstall == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitInstall", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitInstall", SqlDbType.Decimal, 28)).Value = model.FCommitInstall;
            }
            if (model.FAuxCommitInstall == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitInstall", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitInstall", SqlDbType.Decimal, 28)).Value = model.FAuxCommitInstall;
            }
            if (model.FMrpClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpClosed", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpClosed", SqlDbType.Int, 0)).Value = model.FMrpClosed;
            }
            if (model.FAuxInCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxInCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxInCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxInCommitQty;
            }
            if (model.FInCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInCommitQty", SqlDbType.Decimal, 28)).Value = model.FInCommitQty;
            }
            if (model.FSecInCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecInCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecInCommitQty", SqlDbType.Decimal, 28)).Value = model.FSecInCommitQty;
            }
            if (model.FApplyCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FApplyCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FApplyCommitQty", SqlDbType.Decimal, 28)).Value = model.FApplyCommitQty;
            }
            if (model.FAuxApplyCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxApplyCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxApplyCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxApplyCommitQty;
            }
            if (model.FSecApplyCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecApplyCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecApplyCommitQty", SqlDbType.Decimal, 28)).Value = model.FSecApplyCommitQty;
            }
            if (model.FEvaluated == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEvaluated", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEvaluated", SqlDbType.Int, 0)).Value = model.FEvaluated;
            }
            if (model.FPackUnitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPackUnitID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPackUnitID", SqlDbType.Int, 0)).Value = model.FPackUnitID;
            }
            if (model.FPackCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPackCount", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPackCount", SqlDbType.Int, 0)).Value = model.FPackCount;
            }
            if (model.FPackType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPackType", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPackType", SqlDbType.Decimal, 28)).Value = model.FPackType;
            }
            if (model.FMapID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMapID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMapID", SqlDbType.Int, 0)).Value = model.FMapID;
            }
            if (model.FGoodsDesc == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FGoodsDesc", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FGoodsDesc", SqlDbType.NVarChar, 255)).Value = model.FGoodsDesc;
            }
            if (model.FAmountAfterDiscount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmountAfterDiscount", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAmountAfterDiscount", SqlDbType.Decimal, 28)).Value = model.FAmountAfterDiscount;
            }
            if (model.FInformCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInformCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInformCommitQty", SqlDbType.Decimal, 28)).Value = model.FInformCommitQty;
            }
            if (model.FAuxInformCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxInformCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxInformCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxInformCommitQty;
            }
            if (model.FSecInformCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecInformCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecInformCommitQty", SqlDbType.Decimal, 28)).Value = model.FSecInformCommitQty;
            }
            if (model.FPurCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPurCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPurCommitQty", SqlDbType.Decimal, 28)).Value = model.FPurCommitQty;
            }
            if (model.FAuxPurCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPurCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPurCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxPurCommitQty;
            }
            if (model.FSecPurCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecPurCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecPurCommitQty", SqlDbType.Decimal, 28)).Value = model.FSecPurCommitQty;
            }
            if (model.FMrpAutoClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpAutoClosed", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpAutoClosed", SqlDbType.Int, 0)).Value = model.FMrpAutoClosed;
            }
            if (model.FEntrySelfS0153 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0153", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0153", SqlDbType.VarChar, 255)).Value = model.FEntrySelfS0153;
            }
            if (model.FEntrySelfS0154 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0154", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0154", SqlDbType.DateTime, 0)).Value = model.FEntrySelfS0154;
            }
            if (model.FEntrySelfS0155 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0155", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0155", SqlDbType.DateTime, 0)).Value = model.FEntrySelfS0155;
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
            if (model.FSecCommitInstall == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecCommitInstall", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecCommitInstall", SqlDbType.Decimal, 23)).Value = model.FSecCommitInstall;
            }
            if (model.FEntrySelfS0161 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0161", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0161", SqlDbType.Decimal, 28)).Value = model.FEntrySelfS0161;
            }
            if (model.FEntrySelfS0162 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0162", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0162", SqlDbType.Int, 0)).Value = model.FEntrySelfS0162;
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
            if (model.FOrderBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBillNo", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBillNo", SqlDbType.NVarChar, 255)).Value = model.FOrderBillNo;
            }
            if (model.FOrderEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderEntryID", SqlDbType.Int, 0)).Value = model.FOrderEntryID;
            }
            if (model.FDiffQtyClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDiffQtyClosed", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDiffQtyClosed", SqlDbType.Decimal, 28)).Value = model.FDiffQtyClosed;
            }
            if (model.FBOMCategory == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBOMCategory", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBOMCategory", SqlDbType.Int, 0)).Value = model.FBOMCategory;
            }
            if (model.FOrderBOMStatus == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMStatus", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMStatus", SqlDbType.Int, 0)).Value = model.FOrderBOMStatus;
            }
            if (model.FOrderBOMInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMInterID", SqlDbType.Int, 0)).Value = model.FOrderBOMInterID;
            }
            if (model.FIsAltered == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsAltered", SqlDbType.TinyInt, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsAltered", SqlDbType.TinyInt, 0)).Value = model.FIsAltered;
            }
            if (model.FEntrySelfS0171 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0171", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0171", SqlDbType.VarChar, 255)).Value = model.FEntrySelfS0171;
            }
            if (model.FEntrySelfS0174 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0174", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0174", SqlDbType.DateTime, 0)).Value = model.FEntrySelfS0174;
            }
            if (model.FEntrySelfS0177 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0177", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0177", SqlDbType.Int, 0)).Value = model.FEntrySelfS0177;
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
            if (model.FIsAPS == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsAPS", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsAPS", SqlDbType.Int, 0)).Value = model.FIsAPS;
            }
            if (model.FMeetDelivery == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMeetDelivery", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMeetDelivery", SqlDbType.Int, 0)).Value = model.FMeetDelivery;
            }
            if (model.FOrderBOMEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMEntryID", SqlDbType.Int, 0)).Value = model.FOrderBOMEntryID;
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
            if (model.FEntrySelfS0183 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0183", SqlDbType.Text, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0183", SqlDbType.Text, 0)).Value = model.FEntrySelfS0183;
            }
            if (model.FEntrySelfS0184 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0184", SqlDbType.Text, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfS0184", SqlDbType.Text, 0)).Value = model.FEntrySelfS0184;
            }
            cmd.Parameters.Add(new SqlParameter("@m_FDetailID", SqlDbType.Int, 0)).Value = model.FDetailID;

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }


        /// <summary>
		/// 是否已经存在SEOrderEntry对象
		/// 编写人：ywk
		/// 编写日期：2018/7/2 星期一
		/// </summary>
		public bool IsExist(int FInterID, int FEntryID)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM SEOrderEntry WHERE FInterID = @m_FInterID and FEntryID=@m_FEntryID", con);
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


    }
}
