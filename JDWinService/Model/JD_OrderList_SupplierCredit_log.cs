using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //供应商采购未付金额 超过 信用额度的90% 的日志
    public class JD_OrderList_SupplierCredit_log
    {
        public int ItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TaskID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SupplierCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SupplierName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsUpdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsBeyond { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProcessName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Requester { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime RequestDate { get; set; }
    }
}
