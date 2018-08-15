using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    // K3 预测订单明细表
    public class PPOrderEntry
    {
        public string FBrNo { get; set; }
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
        public int FItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FUnitID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FNeedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FNote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxCommitQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public short FSourceEntryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FHaveMrp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMrpClosed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FNeedDateEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSplitCycleID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FOrgNeedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FOrgNeedDateEnd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOrgEntryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FIsKilled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FKillQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxKillQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FBomInterID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCustID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FSaleQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxSaleQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FSelQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxSelQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOrderClosed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMRPLockFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSourceTranType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSourceInterID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSourceBillNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPlanMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FMTONo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FDetailID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FBOMCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FIsAPS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FMeetDelivery { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FAuxPropID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOrderBOMStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOrderBOMInterID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FEntrySelfY0128 { get; set; }

    }
}
