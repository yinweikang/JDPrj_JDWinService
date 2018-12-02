using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //备忘录Check
    public class JD_PrivateNote
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
        public string SNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProcessName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Submiter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime SubmitDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsCheck { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BelongDept { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RejectReason { get; set; }

    }
}
