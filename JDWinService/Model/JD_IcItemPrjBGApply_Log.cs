using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //物料基础信息修改-工程部
    public class JD_IcItemPrjBGApply_Log
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
        public DateTime RequestDate { get; set; }
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
        public int FItemID { get; set; }
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
        public string FFullName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FNameNew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FModel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FModelNew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FNetWeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FNetWeightNew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FGrossWeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FGrossWeightNew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double FPPQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double FPPQNew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsUpdate { get; set; }
    }
}
