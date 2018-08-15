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

            try
            {
                if (model != null)
                {
                    POOrderEntry entrymodel = entrydal.Detail(model.FInterID, model.FEntryID);
                    if (entrymodel != null)
                    {
                        //更新首次确认时间 末次确认时间
                        if (model.FEntrySelfP0267 != null)
                        {
                            
                            entrymodel.FEntrySelfP0267 = model.FEntrySelfP0267;
                        }
                      
                        if (model.FEntrySelfP0268 != null)
                        {
                            entrymodel.FEntrySelfP0268 = model.FEntrySelfP0268;
                        }
                     

                        entrydal.Update(entrymodel);
                    }
                }
            }
            catch (Exception ex)
            {
                common.WriteLogs("采购订单交期变更Error:" + ex.Message);
            }
            finally
            {
                model.UpdateTime = DateTime.Now;
                model.IsUpdate = "1";
                dal.Update(model);
            }


        }
    }
}
