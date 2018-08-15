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
    public class JD_SeorderListBG_LogService
    {
        JD_SeorderListBG_LogDal dal = new JD_SeorderListBG_LogDal();
        SeOrderEntryDal k3dal = new SeOrderEntryDal();
        Common com = new Common();
        public DataView GetUpdateList()
        {
            return dal.GetUpdateList();
        }
        public JD_SeorderListBG_Log Detail(int ItemID)
        {
            return dal.Detail(ItemID);
        }

        public int Add(JD_SeorderListBG_Log model)
        {
            return dal.Add(model);
        }

        public void UpdateSeOrderEntry(int ItemID,int TaskID)
        {
            JD_SeorderListBG_Log logmodel = dal.Detail(ItemID);
            string ErrorMsg = string.Empty;
            if (logmodel != null)
            {
                try
                {

                  
                    #region   判断是否有销售订单的原始记录  不存在 新增
                    if (dal.GetCount(logmodel.FInterID, logmodel.FEntryID) == 1)
                    {

                        SEOrderEntry semodel = k3dal.Detail(logmodel.FInterID, logmodel.FEntryID); //销售订单明细
                        if (semodel != null)
                        {
                            dal.Add(new JD_SeorderListBG_Log
                            {
                                IsNew = 1,
                                FEntrySelfS0153 = semodel.FEntrySelfS0153,
                                FEntrySelfS0177 = semodel.FEntrySelfS0177.ToString(),
                                FNote = semodel.FNote,
                                FDate = semodel.FDate,
                                FEntrySelfS0183 = semodel.FEntrySelfS0183,
                                FAuxQty = semodel.FAuxQty,
                                FAuxPrice = semodel.FAuxPrice,
                                FEntrySelfS0154 = semodel.FEntrySelfS0154,
                                FInterID = semodel.FInterID,
                                FEntryID = semodel.FEntryID,
                                IsUpdate = "1",
                                UpdateTime = DateTime.Now,
                                Requester="-"
                            });
                        }

                    }

                    #endregion

                    #region 订单明细与K3集成
                    decimal Fcess = Convert.ToDecimal(100.00);
                    SEOrderEntry Entrymodel = k3dal.Detail(logmodel.FInterID, logmodel.FEntryID);
                    Entrymodel.FEntrySelfS0153 = logmodel.FEntrySelfS0153;   //客户订单
                    Entrymodel.FEntrySelfS0177 = Convert.ToInt32(logmodel.FEntrySelfS0177); //订单行号
                    Entrymodel.FNote = logmodel.FNote;
                    Entrymodel.FDate = logmodel.FDate; //确认日期
                    Entrymodel.FEntrySelfS0183 = logmodel.FEntrySelfS0183;//齐套日期
                    Entrymodel.FAuxQty = logmodel.FAuxQty;
                    Entrymodel.FAdviceConsignDate = logmodel.FDate;  //建议交货日期
                    Entrymodel.FAuxPrice = logmodel.FAuxPrice;  //未税单价
                    Entrymodel.FEntrySelfS0154 = logmodel.FEntrySelfS0154; //首次确认日期
                    //影响数量的更新
                    Entrymodel.FAmount = Math.Round(Entrymodel.FAuxQty * Entrymodel.FPrice, 2);
                    Entrymodel.FTaxAmount = Math.Round(Entrymodel.FAmount * Math.Round(Entrymodel.FCESS / Fcess, 6), 2);
                    Entrymodel.FAllAmount = Entrymodel.FAmount + Entrymodel.FTaxAmount;
                    k3dal.Update(Entrymodel);
                    #endregion
                }
                catch (Exception ex)
                {
                    ErrorMsg = ex.Message; 
                    com.WriteLogs(ex.Message);
                }
                finally
                {
                    logmodel.IsUpdate = "1";
                    dal.Update(logmodel);
                    if (!string.IsNullOrEmpty(ErrorMsg))
                    {
                        com.AddLogQueue(TaskID, "JD_SeorderListBG_Log", ItemID, "SQL", ErrorMsg, false);
                    }
                    else {
                        com.AddLogQueue(TaskID, "JD_SeorderListBG_Log", ItemID, "SQL", "操作成功", true);
                    }
                  
                }

            }
        }
    }
}
