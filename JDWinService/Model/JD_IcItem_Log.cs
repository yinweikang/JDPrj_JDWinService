using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //BPM 物价申请时 更新的物料数据 MOQ PPQ FNumber
    public class JD_IcItem_Log
    {
        /// <summary>
		/// 
		/// </summary>
		public int ItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal MOQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal PPQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PackageInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
