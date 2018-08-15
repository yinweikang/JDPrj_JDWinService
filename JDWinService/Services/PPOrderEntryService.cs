using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDWinService.Dal;
using JDWinService.Model;
using JDWinService.Utils;

namespace JDWinService.Services
{
    public class PPOrderEntryService
    {
        PPOrderEntryDal dal = new PPOrderEntryDal();

        /// <summary>
        /// 更新预测单 数量和关闭状态
        /// </summary>
        /// <param name="FinterID"></param>
        /// <param name="FEntryID"></param>
        /// <param name="FCount"></param>
        public void UpdateInSeorder(int FinterID, int FEntryID, decimal FCount)
        {
            //FSaleQty FAuxSaleQty FSelQty FAuxSelQty 数量增加
            //FSaleQty==FQty  Fmrpclosed=1
            PPOrderEntry model = dal.Detail(FinterID, FEntryID);
            if (model != null)
            {
                model.FSaleQty += FCount;
                model.FAuxSaleQty += FCount;
                model.FSelQty += FCount;
                model.FAuxSelQty += FCount;
                if (model.FSaleQty == model.FQty)
                {
                    model.FMrpClosed = 1;
                }
                dal.Update(model);
            }
        }
    }
}
