using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDWinService.Dal;
using JDWinService.Model;
using JDWinService.Utils;
using System.Data;

namespace JDWinService.Services
{
    public class JD_OrderListBG_LogService
    {
        JD_OrderListBG_LogDal dal = new JD_OrderListBG_LogDal();
        public DataView GetDistinctList()
        {
            return dal.GetDistinctList();
        }

        public void UpdatePOEntry(string TaskID,string BGName) {
            dal.UpdatePOEntry(TaskID, BGName);
        }

        public void UpdateNPIPOEntry(string TaskID)
        {
            dal.UpdateNPIPOEntry(TaskID);
        }

        /// <summary>
        /// 采购订单变更 NPI和其他
        /// </summary>
        public void UpdateOrderBG()
        {
            dal.UpdateOrderBG();
        }
    }
}
