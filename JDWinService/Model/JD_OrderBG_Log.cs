using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //采购单交期变更 日志表
    public class JD_OrderBG_Log
    {
        public int ItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Operater { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OperaterID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime OperaterDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IsUpdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdateTime { get; set; }
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
        public DateTime? FEntrySelfP0267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FEntrySelfP0268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SupplierName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PONum { get; set; }
    }
}
