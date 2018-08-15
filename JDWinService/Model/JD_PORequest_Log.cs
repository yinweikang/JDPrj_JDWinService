using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    public class JD_PORequest_Log
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
        public string IsUpdate { get; set; }
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
        public string Operater { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CheckID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BusinessType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BusinessTypeCode { get; set; }
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
        public string ordernum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Remarks { get; set; }
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
        public string Funit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FUnitID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FNeedQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DetailRemarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FFixLeadTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FAdmit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FFetchTime { get; set; }
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
        public string Flimitprice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FOpenPo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Fpoqty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Fpoqty1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Fpoqty2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Fstockqty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PackageInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FSecInv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSourceInterId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSourceBillNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSourceEntryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Fsupname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FsupNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FsupplyID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal CostPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TypeNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Fcess { get; set; }
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
        public string SNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LogType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FQtyNew { get; set; }

        public string REQType { get; set; }
    }
}
