using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //采购订单取消 日志表
    public class JD_OrderListCancle_Log
    {
        /// <summary>
		/// 
		/// </summary>
		public int ItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TaskID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CancleType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DetailCancleType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsUpdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FInterID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FEntryID { get; set; }
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
        public DateTime OperateTime { get; set; }
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
        public decimal AllPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BGName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FBillNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Attachments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string WuLiaoNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string GuiGe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal ActualPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime SendDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FEntrySelfP0267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FirstConfirmDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FEntrySelfP0268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime LastConfirmDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FPOHighPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FCoefficient { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FLinkCount { get; set; }
    }
}
