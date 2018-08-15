using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDWinService.Dal;
namespace JDWinService.Services
{
    public class JD_OrderListBG_Service
    {
        POOrderDal orderdal = new POOrderDal();

        //采购订单变更（物料） 和K3集成
        public void UpdatePOEntry(string TaskID, string BGName) {
            orderdal.UpdatePOEntry(TaskID, BGName);
        }
        public void UpdateNPIPOEntry(string TaskID)
        {
            orderdal.UpdateNPIPOEntry(TaskID);
        }
        
    }
}
