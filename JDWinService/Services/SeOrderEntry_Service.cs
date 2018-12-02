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
            string ErrorMsg = string.Empty;
            string Title = string.Empty;
            try
            {
                Title = "基础信息—销售单号:" + model.FBillNo + ",内部编号:" + model.FInterID.ToString() + ",行号:" + model.FEntryID.ToString() + ",操作人:" + model.Operater;
                if (model != null)
                {
                    sedal.UpdateFdate(model); 
                }
                else
                {
                    com.WriteLogs("ItemID:" + ItemID.ToString() + " ,销售订单变更日志表不存在");
                    throw new Exception("Error—销售订单变更日志表不存在");
                }

            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
            }
            finally {
                logdal.UpdateStatus(ItemID);
                if (!string.IsNullOrEmpty(ErrorMsg))
                {
                    com.AddLogQueue("销售订单交期变更", "JD_SeorderBG_Log", ItemID, "SQL", ErrorMsg + Title, false);
                }
                else
                {
                    com.AddLogQueue("销售订单交期变更", "JD_SeorderBG_Log", ItemID, "SQL","操作成功！" + Title, true);
                }
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
