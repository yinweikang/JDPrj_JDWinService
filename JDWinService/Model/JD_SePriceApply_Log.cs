using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    public class JD_SePriceApply_Log
    {
        /// <summary>
		/// 
		/// </summary>
		public int ItemID { get; set; }

        public int TaskID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ParentID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Operater { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IsUpdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShortName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CustomCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CustomName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FModel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CoinType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal BeginSalesCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal EndSalesCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IsNew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal MOQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LimitTimes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CaiWuRemarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PlanRemarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ApplyType { get; set; }
    }
}
