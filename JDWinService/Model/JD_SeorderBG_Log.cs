using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    public class JD_SeorderBG_Log
    {
        public int ItemID { get; set; }
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
        public string FBillNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FCustID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FDate { get; set; }
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
        public DateTime OperateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IsUpdate { get; set; }

        public DateTime? FEntrySelfS0155 { get; set; }

        public DateTime? FEntrySelfS0154 { get; set; }

       
        public DateTime? FQTDate { get; set; }

        public string FQueLiao { get; set; }


        //备注
        public string FNote { get; set; }


        //齐套日期
        public string FEntrySelfS0183 { get; set; }


        //缺料
        public string FEntrySelfS0184 { get; set; }
    }
}
