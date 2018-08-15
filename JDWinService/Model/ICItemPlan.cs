using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    /// <summary>
    /// K3 t_ICItemPlan
    /// </summary>
    public class ICItemPlan
    {
        /// <summary>
		/// 
		/// </summary>
		public int FItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPlanTrategy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOrderTrategy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float FLeadTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float FFixLeadTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FTotalTQQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FQtyMin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FQtyMax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCUUnitID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOrderInterVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FBatchAppendQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FOrderPoint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FBatFixEconomy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FBatChangeEconomy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FRequirePoint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPlanPoint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FDefaultRoutingID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FDefaultWorkTypeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FProductPrincipal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FDailyConsume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool FMRPCon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPlanner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool FPutInteger { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FInHighLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FInLowLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FLowestBomCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool FMRPOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FIsCharSourceItem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCharSourceItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPlanMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCtrlType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCtrlStraregy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FContainerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FKanBanCapability { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FIsBackFlush { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FBackFlushStockID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FBackFlushSPID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FBatchSplitDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FBatchSplit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool FIsFixedReOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool FAuxInMrpCal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FProductDesigner { get; set; }

    }
}
