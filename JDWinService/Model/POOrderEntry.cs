using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //K3 采购订单明细表
    public  class POOrderEntry
    {
        #region 类的属性定义

        /// <summary>
        /// 
        /// </summary>
        public string FBrNo { get; set; }
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
        public DateTime FDate { get; set; }
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
        public decimal FTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FTaxAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FNote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FUnitID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxCommitQty { get; set; }
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
        public int FSourceEntryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FCess { get; set; }
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
        public string FMapNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FMapName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAllAmount { get; set; }
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
        public decimal FAuxQtyInvoice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMrpClosed { get; set; }
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
        public int FSProducingAreaID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAmtDiscount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FCheckAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMrpAutoClosed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FPayApplyAmountFor_Commit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FPayApplyAmount_Commit { get; set; }
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
        public int FPlanMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FMTONo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FDescount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSupConfirm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FSupConDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FSupConQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSupConMem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FSupConFetchDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSupConfirmor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FQualityRptBillID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FLockByAlter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FDeliveryQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxDeliveryQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FSecDeliveryQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FRejectRefuseNote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FRefuseNote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte FLockBySupplier { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FEntryAccessoryCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPRInterID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPREntryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxReceiptQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FReceiptQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxReturnQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FReturnQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCheckMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FIsCheck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FEntrySelfP0266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime?  FEntrySelfP0267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime?  FEntrySelfP0268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FEntrySelfP0272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FEntrySelfP0273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FEntrySelfP0275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FEntrySelfP0277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FEntrySelfP0278 { get; set; }
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
        public decimal FPayReqPayAmountFor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCloseEntryUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FCloseEntryDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FCloseEntryCauses { get; set; }
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

        #endregion
    }
}
