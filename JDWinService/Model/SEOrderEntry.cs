using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //K3 销售订单明细表
    public class SEOrderEntry
    {
        public string FBrNO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FInterID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FEntryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FTaxRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FTaxAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float FDiscount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FNote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FDiscountAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FInvoiceQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FBCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FTranLeadTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FATPDeduct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCostObjectID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FUnitID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxBCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxInvoiceQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FUniDiscount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FFinalAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSourceEntryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FHaveMrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FStockQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxStockQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FBatchNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FCESS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FAdviceConsignDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FBomInterID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FMapNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FMapName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FLockFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FInForeCast { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAllAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAllStdAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FAuxPropID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxPriceDiscount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FPriceDiscount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FQtyInvoice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FQtyInvoiceBase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FTaxAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxTaxPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FTaxPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FReceiveAmountFor_Commit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FReceiveAmount_Commit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FSecCoefficient { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FSecQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FSecCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSourceTranType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSourceInterId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSourceBillNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FContractInterID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FContractEntryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FContractBillNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMRPLockFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMRPTrackFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FOrderCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FOrderSecCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxQtyInvoice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FCommitInstall { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxCommitInstall { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMrpClosed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxInCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FInCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FSecInCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FApplyCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxApplyCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FSecApplyCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FEvaluated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPackUnitID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPackCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FPackType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FDetailID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMapID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FGoodsDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAmountAfterDiscount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FInformCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxInformCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FSecInformCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FPurCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxPurCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FSecPurCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMrpAutoClosed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FEntrySelfS0153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FEntrySelfS0154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FEntrySelfS0155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FSecStockQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FSecInvoiceQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FSecCommitInstall { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FEntrySelfS0161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FEntrySelfS0162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPlanMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FMTONo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FOrderBillNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOrderEntryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FDiffQtyClosed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FBOMCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOrderBOMStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOrderBOMInterID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte FIsAltered { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FEntrySelfS0171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FEntrySelfS0174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FEntrySelfS0177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAmountExceptDisCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAllAmountExceptDisCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FEntryDisCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FCommitAmt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FCommitAmtTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FCommitTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FIsAPS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMeetDelivery { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOrderBOMEntryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOutSourceInterID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOutSourceEntryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOutSourceTranType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FEntrySelfS0183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FEntrySelfS0184 { get; set; }
    }
}
