using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //请购单管理
    public class JD_PORequestManage
    {
        public int ItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TaskID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string REQType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FLinkQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FBeginDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FOperater { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCess { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TypeNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FModel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FNeedQty { get; set; }
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
        public DateTime FAPurchTime { get; set; }
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
        public decimal CostPrice { get; set; }
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
        public string FSourceBillNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSourceEntryID { get; set; }
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
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FsupNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsClosed { get; set; }
    }
}
