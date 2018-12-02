using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //采购订单 物料日志表
    public class JD_OrderListApply_Log
    {

        /// <summary>
        /// 
        /// </summary>
        public int ItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TaskID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SupplierName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SupplierCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PlanType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PlanTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CoinType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CoinTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RateType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RateTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OrderMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OrderModeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OrderType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OrderTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OrderRange { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OrderRangeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BalanceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BalanceTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BU { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BUCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAllPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAllTaxPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FBillNo { get; set; }
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
        public string FNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FModel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FQtyMin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FBatchAppendQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string WuLiaoCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string WuLiaoSupplier { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EnginCRName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EnginCRCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double PriceXiShu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SupplierVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string funit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string funitID { get; set; }
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
        public decimal FpoNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FFetchTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSupplyID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fsupNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fsupname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxTaxPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FTaxAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FCess { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal POHightPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IsUpdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DeptID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DeptIDCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FEmpID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FEmpIDCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FManageID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FManageIDCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FBillerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FDate1 { get; set; }

        public string ordernum { get; set; }

        public string REQType { get; set; }
        public int IsPart { get; set; }

        public string ExtraInfo { get; set; }

        public string HeadRemarks { get; set; }

        public int FFixLeadTime { get; set; }
    }
}
