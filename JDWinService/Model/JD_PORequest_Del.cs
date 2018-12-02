using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //请购删除表
    public class JD_PORequest_Del
    {
        /// <summary>
		/// 
		/// </summary>
		public int ItemID { get; set; }

        public int TaskID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FBillNo { get; set; }


        public string SNumber { get; set; }
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
        public int IsUpdate { get; set; }
    }
}
