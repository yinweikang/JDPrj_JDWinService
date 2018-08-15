using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using JDWinService.Utils;
using System;
using JDWinService.Model;

namespace JDWinService.Dal
{

    public class POOrderDal
    {
        Common common = new Common();
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息
        POOrderEntryDal dal = new POOrderEntryDal(); 
        
        //采购订单物料变更
        public void UpdatePOEntry(string TaskID, string BGName)
        {
            string sql = string.Format(@"select * from dbo.JD_OrderListDeailBG_WL  
                                        where TaskID='{0}'
                                        order by WuLiaoNum asc,FAuxQty desc", TaskID);
            string updateSql = string.Empty;
            try
            {
                DataTable dt = DBUtil.Query(sql).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    switch (BGName)
                    {
                        case "数量变更":
                            common.WriteLogs("数量变更开始");
                            Update_SL(dt);
                            break;
                        case "价格变更":
                            common.WriteLogs("价格变更开始");
                            Update_JG(dt);
                            break;
                        case "交期变更":
                            common.WriteLogs("交期变更开始");
                            Update_JQ(dt, TaskID);
                            break;
                        default:
                            break;
                    } 
                } 

            }
            catch (Exception ex)
            {
                common.WriteLogs("采购订单变更Error:" + ex.Message);
            }
            finally
            {

                updateSql = "update JD_OrderListBG_WL set IsUpdate='1' where TaskID='" + TaskID + "'";
                DBUtil.ExecuteSql(updateSql);
            }

        }

        public void UpdateNPIPOEntry(string TaskID) {

            string sql = string.Format(@"select * from dbo.JD_OrderListDeailBG_NPI 
                                        where TaskID='{0}'
                                        order by WuLiaoNum asc,FAuxQty desc", TaskID);
            string updateSql = string.Empty;
            try
            {
                DataTable dt = DBUtil.Query(sql).Tables[0];
                Update_NPI(dt);
            }
            catch (Exception ex)
            {
                common.WriteLogs("采购订单NPI变更Error:" + ex.Message);
            }
            finally
            {

                updateSql = "update JD_OrderListBG_NPI set IsUpdate='1' where TaskID='" + TaskID + "'";
                DBUtil.ExecuteSql(updateSql);
            }

        }
     
        //数量变更
        protected void Update_SL(DataTable dt)
        {
            POOrderEntry model = new POOrderEntry();
            string tempsql = string.Empty;
            string sql = string.Empty;
            int FInterID = 0;
            int FEntryID = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (!string.IsNullOrEmpty(dr["WuLiaoNum"].ToString()))
                {
                    FInterID = Convert.ToInt32(dr["FInterID"].ToString());
                    FEntryID = Convert.ToInt32(dr["FEntryID"].ToString());
                    model = dal.Detail(FInterID, FEntryID);

                    
                    model.FAuxQty = Math.Round(Convert.ToDecimal(dr["FAuxQty"].ToString()), 10); //数量更新
                    model = LastUpdateModel(model);  
                    dal.Update(model);
                    //sql = string.Format(@"update POOrderEntry set FAuxQty='{0}' {3} where FInterID='{1}' and FEntryID='{2}'",
                    //    dr["FAuxQty"].ToString(), dr["FInterID"].ToString(), dr["FEntryID"].ToString(), tempsql);
                }
                //common.WriteLogs("料号：" + dr["WuLiaoNum"].ToString() + "，数量变更：" + sql);
                //DBUtil.ExecuteSql(sql, K3connectionString);

            }
        }


        protected void Update_FQty(DataTable dt)
        {
            POOrderEntry model = new POOrderEntry();
            string tempsql = string.Empty;
            string sql = string.Empty;
            int FInterID = 0;
            int FEntryID = 0;
            //判断是否有拆分的订单
            //有订单拆分

            //无订单拆分

            foreach (DataRow dr in dt.Rows)
            {
                if (!string.IsNullOrEmpty(dr["WuLiaoNum"].ToString()))
                {
                    FInterID = Convert.ToInt32(dr["FInterID"].ToString());
                    FEntryID = Convert.ToInt32(dr["FEntryID"].ToString());
                    model = dal.Detail(FInterID, FEntryID);


                    model.FAuxQty = Math.Round(Convert.ToDecimal(dr["FAuxQty"].ToString()), 10); //数量更新
                    model = LastUpdateModel(model);
                    dal.Update(model);
                    //sql = string.Format(@"update POOrderEntry set FAuxQty='{0}' {3} where FInterID='{1}' and FEntryID='{2}'",
                    //    dr["FAuxQty"].ToString(), dr["FInterID"].ToString(), dr["FEntryID"].ToString(), tempsql);
                }
                //common.WriteLogs("料号：" + dr["WuLiaoNum"].ToString() + "，数量变更：" + sql);
                //DBUtil.ExecuteSql(sql, K3connectionString);

            }
        }
        //价格变更
        protected void Update_JG(DataTable dt)
        {
            POOrderEntry model = new POOrderEntry();
            string tempsql = string.Empty;
            string sql = string.Empty;
            int FInterID = 0;
            int FEntryID = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (!string.IsNullOrEmpty(dr["WuLiaoNum"].ToString()))
                {
                    //sql = string.Format(@"update POOrderEntry set FAuxPrice='{0}' where FInterID='{1}' and FEntryID='{2}'",
                    //            dr["FAuxPrice"].ToString(), dr["FInterID"].ToString(), dr["FEntryID"].ToString());
                    FInterID = Convert.ToInt32(dr["FInterID"].ToString());
                    FEntryID = Convert.ToInt32(dr["FEntryID"].ToString());
                    model = dal.Detail(FInterID, FEntryID);
                    model.FAuxPrice = Math.Round(Convert.ToDecimal(dr["FAuxPrice"].ToString()), 10); //价格变更
                    model = LastUpdateModel(model);
                    dal.Update(model);
                }
                //common.WriteLogs("料号：" + dr["WuLiaoNum"].ToString() + "，价格变更：" + sql);
                //DBUtil.ExecuteSql(sql, K3connectionString);
            }
        }

        /// <summary>
        /// 交期变更
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="TaskID">主表ID</param>
        protected void Update_JQ(DataTable dt,string TaskID)
        {
            POOrderEntryDal dal = new POOrderEntryDal();
            POOrderEntry old_model = new POOrderEntry();  //原始的采购订单明细
            //找出不重复的FEntryID  遍历
            string sql = "select distinct FEntryID  from dbo.JD_OrderListDeailBG_WL where TaskID='"+ TaskID + "' order by FEntryID asc";
            //string updatesql = "";
            //string sqltemp = "";
            var FEntryIDs = DBUtil.Query(sql).Tables[0].AsEnumerable().Select(r => r["FEntryID"]).Distinct();
            foreach (var item in FEntryIDs)
            {
                DataRow[] dr = dt.Select("FEntryID='"+ item.ToString() + "'","FAuxQty desc");
                int Count = 0;
                foreach (DataRow datarow in dr) {
                    //更新
                    if (Count == 0)
                    {
                        common.WriteLogs("首行");
                        common.WriteLogs("Count:" + Count);
                        common.WriteLogs("FEntryID:"+ datarow["FInterID"].ToString()+ ",FEntryID:"+ item.ToString());
                        old_model = dal.Detail(Convert.ToInt32(datarow["FInterID"].ToString()), Convert.ToInt32(item.ToString()));
                        if (!String.IsNullOrEmpty(datarow["FEntrySelfP0267"].ToString())) {
                            old_model.FEntrySelfP0267 = Convert.ToDateTime(datarow["FEntrySelfP0267"].ToString());
                        }
                        if (!String.IsNullOrEmpty(datarow["FEntrySelfP0268"].ToString()))
                        {
                            old_model.FEntrySelfP0268 = Convert.ToDateTime(datarow["FEntrySelfP0268"].ToString());
                        }
                        if (!string.IsNullOrEmpty(datarow["FDate"].ToString())) {
                            old_model.FDate= Convert.ToDateTime(datarow["FDate"].ToString());
                        }
                        old_model.FAuxQty = Math.Round(Convert.ToDecimal(datarow["FAuxQty"].ToString()), 10); //数量更新
                        old_model = LastUpdateModel(old_model);
                        dal.Update(old_model);
                        //sqltemp = (!String.IsNullOrEmpty(datarow["FEntrySelfP0267"].ToString())) ? ",FEntrySelfP0267='" + Convert.ToDateTime(datarow["FEntrySelfP0267"].ToString()).ToString("yyyy-MM-dd") + "'" : "";
                        //sqltemp += (!String.IsNullOrEmpty(datarow["FEntrySelfP0268"].ToString())) ? ",FEntrySelfP0268='" + Convert.ToDateTime(datarow["FEntrySelfP0268"].ToString()).ToString("yyyy-MM-dd") + "'" : "";
                        //updatesql = string.Format(@"update POOrderEntry set FDate='{0}' {1} {4}
                        //  where FInterID='{2}' and FEntryID='{3}'", Convert.ToDateTime(datarow["FDate"].ToString()).ToString("yyyy-MM-dd"), sqltemp, datarow["FInterID"].ToString(), item.ToString(),
                        // ",FAuxQty='"+ Math.Round(Convert.ToDecimal(datarow["FAuxQty"].ToString()), 10).ToString() + "'" );
                        //common.WriteLogs("首行");
                        //common.WriteLogs(updatesql);
                        //DBUtil.ExecuteSql(updatesql, K3connectionString); 
                    }
                    //插入
                    else
                    {
                        common.WriteLogs("非首行");
                        common.WriteLogs("Count:"+Count);
                      
                        //获取拆分订单中首个明细
                        POOrderEntry model = dal.Detail(Convert.ToInt32(datarow["FInterID"]), Convert.ToInt32(item.ToString()));
                        //带出Max(FEntryID)
                        int MaxFEntryID = common.GetMaxID("FEntryID", "POOrderEntry", " where FInterID='" + datarow["FInterID"] + "' ");
                       
                        model.FAuxQty = Math.Round(Convert.ToDecimal(datarow["FAuxQty"].ToString()), 10);
                        if (!String.IsNullOrEmpty(datarow["FEntrySelfP0267"].ToString())) {
                            model.FEntrySelfP0267 = Convert.ToDateTime(datarow["FEntrySelfP0267"].ToString());
                        }
                        if (!String.IsNullOrEmpty(datarow["FEntrySelfP0268"].ToString())) {
                            model.FEntrySelfP0268 = Convert.ToDateTime(datarow["FEntrySelfP0268"].ToString());
                        }
                        if (!string.IsNullOrEmpty(datarow["FDate"].ToString()))
                        {
                            model.FDate = Convert.ToDateTime(datarow["FDate"].ToString());
                        }
                        decimal zero = Convert.ToDecimal(0.00);
                     
                        model.FEntryID = MaxFEntryID;  //行号更新
                        model.FCommitQty =model.FCheckAmount= model.FAuxCommitQty = model.FStockQty = model.FAuxStockQty =model.FQtyInvoice = model.FReceiveAmountFor_Commit=model.FReceiveAmount_Commit=model.FAuxQtyInvoice=model.FAuxReceiptQty=model.FReceiptQty=model.FAuxReturnQty=model.FReturnQty=model.FAmountExceptDisCount=model.FAllAmountExceptDisCount=zero;
                        model = LastUpdateModel(model);
                        dal.Add(model);
                        
                    }
                   
                    Count++;
                }
              
            }
        }

        //NPI变更
        protected void Update_NPI(DataTable dt) {
            POOrderEntry model = new POOrderEntry();
            string tempsql = string.Empty;
            string sql = string.Empty;
            int FInterID = 0;
            int FEntryID = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (!string.IsNullOrEmpty(dr["WuLiaoNum"].ToString()))
                {
                    FInterID = Convert.ToInt32(dr["FInterID"].ToString());
                    FEntryID = Convert.ToInt32(dr["FEntryID"].ToString());
                    model = dal.Detail(FInterID, FEntryID); 
                    model.FAuxQty = Math.Round(Convert.ToDecimal(dr["FAuxQty"].ToString()), 10); //数量更新
                    model.FAuxPrice = Math.Round(Convert.ToDecimal(dr["FAuxPrice"].ToString()), 10); //价格变更
                    if (!String.IsNullOrEmpty(dr["FEntrySelfP0267"].ToString()))
                    {
                        model.FEntrySelfP0267 = Convert.ToDateTime(dr["FEntrySelfP0267"].ToString());
                    }
                    if (!String.IsNullOrEmpty(dr["FEntrySelfP0268"].ToString()))
                    {
                        model.FEntrySelfP0268 = Convert.ToDateTime(dr["FEntrySelfP0268"].ToString());
                    }
                    if (!string.IsNullOrEmpty(dr["FDate"].ToString()))
                    {
                        model.FDate = Convert.ToDateTime(dr["FDate"].ToString());
                    }
                    model = LastUpdateModel(model);
                    dal.Update(model); 
                } 

            }
        }
        protected DataTable MeasureUnit(string UnitName)
        {
            string Sql = string.Format(@" select FName,FCoefficient from t_measureUnit where FStandard='0' and FName='{0}' ", UnitName);
            return DBUtil.Query(Sql, K3connectionString).Tables[0]; 
        }

        //采购订单明细最后更新 更新相关基础信息
        protected POOrderEntry LastUpdateModel(POOrderEntry model) {
        
            #region   FQty数量初始化
            DataTable dtable = MeasureUnit(model.FUnitID.ToString());
            if (dtable.Rows.Count > 0)
            {
                decimal FAuxQty = Convert.ToDecimal(model.FAuxQty); //数量变更时候 要初始值
                decimal Convertion = Convert.ToDecimal(dtable.Rows[0]["FCoefficient"].ToString());
                model.FQty = Math.Round(FAuxQty * Convertion, 10);
            }
            else {
                model.FQty = model.FAuxQty;
            }
            #endregion
            decimal Fcess = Convert.ToDecimal(100.00);
            decimal Fcess2 = Convert.ToDecimal(100 + model.FCess)/ Fcess;
            model.FAmount = Math.Round(model.FQty * model.FPrice,2) ;
            model.FTaxAmount = Math.Round(model.FAmount * Math.Round(model.FCess / Fcess, 6),2) ;
            model.FAllAmount = model.FAmount + model.FTaxAmount;

          
          
            model.FAuxTaxPrice = model.FPrice + model.FPrice * Math.Round(model.FCess / Fcess, 10);
            model.FTaxPrice = model.FAuxTaxPrice;

            model.FAllAmountExceptDisCount = model.FPriceDiscount * model.FQty;
            model.FAmountExceptDisCount = Math.Round(model.FAllAmountExceptDisCount / Fcess2, 4);
            common.WriteLogs("LastUpdateModel结束");
            return model;
        }
    }
}
