using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    public class BPMSysMessagesQueue
    {
        /// <summary>
		/// 
		/// </summary>
		public int MessageID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProviderName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime LastSendAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FailCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Attachments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Extra { get; set; }

    }
}
