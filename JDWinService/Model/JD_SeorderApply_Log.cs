using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //BPM 销售申请单
    public class JD_SeorderApply_Log
    {
        /// <summary>
        /// 
        /// </summary>
        public int ItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Requester { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IsUpdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OrderNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SeorderType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PlanType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SalesType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SalesRange { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RateType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CoinType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SendAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CheckAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PurchaseUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PurchaseUnitCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SeorderTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PlanTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SalesTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SalesRangeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RateTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CoinTypeCode { get; set; }
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
        public string SourceNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SourceLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CustomNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CustomLineNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CustomCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProductCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PlanRemark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Fmodel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal MOQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal MiniOrderQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal IncreaseQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FTaxAuxPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxAllPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal XXRatePrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAllPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FIcItemLT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime LTDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CustomDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal PPQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FCess { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UnitID { get; set; }
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
        public string CheckID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CheckDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SettleID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SettleIDCode { get; set; }
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
        public int TaskID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FBillNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CusNeedDate { get; set; }
    }
}
