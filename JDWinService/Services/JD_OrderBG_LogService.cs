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
    //采购订单 交期变更应用
    public class JD_OrderBG_LogService
    {
        JD_OrderBG_LogDal dal = new JD_OrderBG_LogDal();

        POOrderEntryDal entrydal = new POOrderEntryDal();

        Common common = new Common();
        public void UpdatePOOrderEntry(int ItemID)
        {
            JD_OrderBG_Log model = dal.Detail(ItemID);
            string ErrorMsg = string.Empty; 
            string TitleMsg = string.Empty;
            try
            {
                if (model != null)
                {
                    POOrderEntry entrymodel = entrydal.Detail(model.FInterID, model.FEntryID);
                    TitleMsg = "基础信息—采购单号：" + model.PONum + ",内部编号:" + model.FInterID.ToString() + ",行号:" + model.FEntryID.ToString()+",操作人:"+model.Operater;
                    if (entrymodel != null)
                    {
                        //更新首次确认时间 末次确认时间
                        if (model.FEntrySelfP0267 != null)
                        {

                            if (entrymodel.FEntrySelfP0267 != model.FEntrySelfP0267)
                            { 
                                entrymodel.FEntrySelfP0267 = model.FEntrySelfP0267; 
                            }
                           
                        }
                      
                        if (model.FEntrySelfP0268 != null)
                        {
                            if (entrymodel.FEntrySelfP0268 != model.FEntrySelfP0268)
                            { 
                                entrymodel.FEntrySelfP0268 = model.FEntrySelfP0268;
                            } 
                        }
                        entrydal.Update(entrymodel);

                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
                common.WriteLogs("采购订单交期变更Error:" + ex.Message);
            }
            finally
            {
                model.UpdateTime = DateTime.Now;
                model.IsUpdate = "1";
                dal.Update(model);
                if (!string.IsNullOrEmpty(ErrorMsg))
                {
                    common.AddLogQueue("采购订单交期变更", "JD_OrderBG_Log", ItemID, "SQL", ErrorMsg+ TitleMsg, false);
                }
                else
                {
                    common.AddLogQueue("采购订单交期变更", "JD_OrderBG_Log", ItemID, "SQL", "操作成功！" + TitleMsg, true);
                }
            }


        }
    }
}
