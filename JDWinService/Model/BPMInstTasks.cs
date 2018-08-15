using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    public  class BPMInstTasks
    {
        public int TaskID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProcessName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OwnerAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AgentAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FinishAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SerialNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OptUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime OptAt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OptMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FormDataSetID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ExtYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ExtInitiator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool ExtDeleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int OwnerPositionID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ParentTaskID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ParentStepID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentStepName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProcessVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ParentServerIdentity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool ReturnToParent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UrlParams { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Context { get; set; }
    }
}
