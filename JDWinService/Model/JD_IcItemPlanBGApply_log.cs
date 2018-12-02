using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //物料信息变更-计划
    public class JD_IcItemPlanBGApply_log
    {
        /// <summary>
		/// 
		/// </summary>
		public int ItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TaskID { get; set; }

        public int FItemID { get; set; }
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
        public string SNumber { get; set; }
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
        public decimal fqtymin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal fqtyminnew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FBatchAppendQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FBatchAppendQtynew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FFixLeadTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FFixLeadTimenew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Fsecinv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FsecinvNew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ProductLT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ProductLTnew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double PPQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double PPQnew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PlanRemarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PlanRemarksnew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MOQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MOQnew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsSMI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Ferpclsid { get; set; }
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
