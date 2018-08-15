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
    //销售限价数据更新
    public class JD_SePriceDetailService
    {
        JD_SePriceDetailDal dal = new JD_SePriceDetailDal();
        JD_SePriceApply_LogDal logdal = new JD_SePriceApply_LogDal();
        public void HandlePriceData(int ItemID, string FileName,int TaskID)
        {
            dal.HandlePriceData(ItemID, FileName, TaskID);
        }
        public DataView GetDistinctList()
        {
            return logdal.GetDistinctList();
        }
    }
}
