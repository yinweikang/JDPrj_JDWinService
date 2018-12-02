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
    public class JD_CuPriceDetailService
    {
        JD_CuPriceDetailDal dal = new JD_CuPriceDetailDal();
        public void UpdateCuPrice(int ItemID, string FileName,int TaskID)
        {
            dal.HandleCuPrice(ItemID, FileName,TaskID);
        }
        /// <summary>
        /// 获取待更新的数据
        /// </summary>
        /// <returns></returns>
        public DataView GetDistinctList()
        {
            return new JD_LimitPriceApply_LogDal().GetDistinctList();
        }

        public void UpdateStatusInNew()
        {
            new JD_LimitPriceApply_LogDal().UpdateStatusInNew();
        }

        public void UpdateItemInfo(string MOQ, string PPQ, string PackageInfo, string FNumber,string ItemID)
        {
              dal.UpdateItemInfo(MOQ, PPQ, PackageInfo, FNumber, ItemID);
        }
    }
}
