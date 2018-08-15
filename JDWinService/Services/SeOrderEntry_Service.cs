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
   
    public class SeOrderEntry_Service
    {
        JD_SeorderBG_LogDal logdal = new JD_SeorderBG_LogDal();
        SeOrderEntryDal sedal = new SeOrderEntryDal();
        Common com = new Common();
        public void UpdateSeEntry(int ItemID)
        {
         
          //找到销售订单变更日志表信息
          JD_SeorderBG_Log model = logdal.Detail(ItemID);
       
            if (model != null)
            {
                sedal.UpdateFdate(model);
                //model.IsUpdate = "1";
                //logdal.Update(model);
                logdal.UpdateStatus(ItemID);
            }
            else {
                com.WriteLogs("ItemID:" + ItemID.ToString() + " ,销售订单变更日志表不存在");
            }

        }

        public SEOrderEntry Detail(int FInterID, int FEntryID) {
           return  sedal.Detail(FInterID,   FEntryID);
        }


        public void Update(SEOrderEntry model)
        {
              sedal.Update(model);
        }

        public int Add(SEOrderEntry model)
        {
            return sedal.Add(model);
        }
    }
}
