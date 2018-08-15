using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //销售订单变更（数量单价）队列表
    public class JD_SeorderListBG_Log
    {
        /// <summary>
        /// 
        /// </summary>
        public int ItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TaskID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FEntrySelfS0153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FEntrySelfS0177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FNote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FEntrySelfS0183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FAuxPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FEntrySelfS0154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string WIP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal StockQty { get; set; }
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
        public string Requester { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsNew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FBillNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FQL { get; set; }


    }
}
