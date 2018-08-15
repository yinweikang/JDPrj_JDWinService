using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //K3 预测订单
    public class PPOrder
    {
        /// <summary>
		/// 
		/// </summary>
		public string FBrNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FInterID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FBillNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FTranType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FBillerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCheckerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FCheckDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public short FStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPlanType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FParentInterID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOrderInterID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool FCancellation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public short FMrpClosed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCurCheckLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMultiCheckLevel1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMultiCheckLevel2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMultiCheckLevel3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMultiCheckLevel4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMultiCheckLevel5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMultiCheckLevel6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FMultiCheckDate1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FMultiCheckDate2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FMultiCheckDate3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FMultiCheckDate4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FMultiCheckDate5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FMultiCheckDate6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSelTranType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPlanCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public short FConnectFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPrintCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FHeadSelfY0124 { get; set; }
    }
}
