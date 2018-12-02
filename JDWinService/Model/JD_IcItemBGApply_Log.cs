using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    /// <summary>
    /// 物料信息变更 供应链
    /// </summary>
    public class JD_IcItemBGApply_Log
    {
        /// <summary>
		/// 
		/// </summary>
		public int ItemID { get; set; }

        public int FItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Requester { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RequestDept { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TaskID { get; set; }
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
        public decimal FQtyMin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FQtyMinNew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FBatchAppendQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FBatchAppendQtyNew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FFixLeadTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FFixLeadTimeNew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PackageInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PackageInfoNew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double PriceCoeffient { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double PriceCoeffientNew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsUpdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}
