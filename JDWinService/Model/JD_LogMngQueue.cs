using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    public class JD_LogMngQueue
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
        public string FileName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LogTableName { get; set; }
        /// <summary>
        /// 日志的ID
        /// </summary>
        public int TableItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Month { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LogType { get; set; }
        /// <summary>
        /// 是否发送成功
        /// </summary>
        public int IsSuccess { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsHandle { get; set; }
    }
}
