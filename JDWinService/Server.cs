using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDWinService.Utils;
using System.Configuration;
using JDWinService.Dal;
using JDWinService.Services;
using System.IO;
using Newtonsoft.Json;
using JDWinService.Model;
using Newtonsoft.Json.Linq;
using Kingdee.K3.API.SDK;

namespace JDWinService
{
    public class Server
    {
        public static string APIUrl = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["APIUrl"].Value;
        public static string APICode = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["APICode"].Value;
        public static string APICodePart = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["APICodePart"].Value;
        public static Common common = new Common();
        public static void ActionRun(ref bool isRun)
        {

            try
            {
                isRun = true;
                UpdateOrderEntry_Date();  //采购订单 交期变更
                UpdateSeorderEntry_Date(); //销售订单 交期表更
                UpdateSeorderEntry();      //销售订单 数量和单价变更
                UpdateSePrice();   //销售限价更新
                AddSeOrderEntry();           //销售订单新增
                // UpdatePORequest();  //请购单集成
                OrderBGCheck(); //采购订单物料变更
                //OrderBGNPICheck();         //采购订单NPI变更 



                //SupplierCheck();           //供应商新增
                //Test(); 
                //AddPOOrderEntry();         //采购订单_物料 

                //UpdateCuPrice();   //采购限价应用更新


            }
            catch (Exception ex)
            {
                common.WriteLogs(ex.Message);
            }
            finally
            {
                isRun = false;
            }

        }
        //供应商新增轮询
        public static void SupplierCheck()
        {

            SupplierDal supplierDal = new SupplierDal();
            //获取需要操作的供应商数据
            DataTable dt = common.GetUpdateTab("JD_Supplier", " and ApplyType='1'");

            if (dt.Rows.Count > 0)
            {
                common.WriteLogs("--供应商开始--");
                supplierDal.Save(dt, APIUrl, APICode);
                common.WriteLogs("--供应商结束--");
            }
        }

        //采购订单变更(物料)轮询
        public static void OrderBGCheck()
        {
 

            JD_OrderListBG_LogService service = new JD_OrderListBG_LogService();
            DataView dv = service.GetDistinctList();
            dv.RowFilter = " OrderListBGName='WL' ";
            if (dv.Count > 0) {
                common.WriteLogs(Common.FileType.采购订单变更_物料.ToString(), "--采购订单变更_物料开始--");
                foreach (DataRowView dr in dv) {
                    service.UpdatePOEntry(dr["TaskID"].ToString(), dr["BGName"].ToString());
                }
                common.WriteLogs(Common.FileType.采购订单变更_物料.ToString(), "--采购订单变更_物料结束--");
            }
        }

        //采购订单变更(NPI)轮询
        public static void OrderBGNPICheck()
        {
              
            JD_OrderListBG_LogService service = new JD_OrderListBG_LogService();
            DataView dv = service.GetDistinctList();
            dv.RowFilter = " OrderListBGName='NPI' ";
            if (dv.Count > 0)
            {
                common.WriteLogs(Common.FileType.采购订单变更_NPI.ToString(), "--采购订单变更_NPI开始--");
                foreach (DataRowView dr in dv)
                {
                    service.UpdateNPIPOEntry(dr["TaskID"].ToString());
                }
                common.WriteLogs(Common.FileType.采购订单变更_NPI.ToString(), "--采购订单变更_NPI结束--");
            }
        }

        //销售订单交期批量变更 轮询 
        public static void UpdateSeorderEntry_Date()
        {
            DataView dv = common.GetUpdateAppTab("JD_SeorderBG_Log", "").DefaultView;
            SeOrderEntry_Service service = new SeOrderEntry_Service();

            if (dv.Count > 0)
            {
                common.WriteLogs("--销售订单交期批量变更开始--");
                try
                {
                    foreach (DataRowView dr in dv)
                    {
                        service.UpdateSeEntry(Convert.ToInt32(dr["ItemID"]));
                    }
                }
                catch (Exception ex)
                {
                    common.WriteLogs("销售订单交期批量变更Error:" + ex.Message);
                }
                common.WriteLogs("--销售订单交期批量变更结束--");
            }
        }

        public static void UpdateSeorderEntry()
        {
            //选择流程结束的数据 
            JD_SeorderListBG_LogService service = new JD_SeorderListBG_LogService();
            DataView dv = service.GetUpdateList();
            if (dv.Count > 0)
            {
                common.WriteLogs("--销售订单批量变更开始--");
                foreach (DataRowView dr in dv)
                {
                    service.UpdateSeOrderEntry(Convert.ToInt32(dr["ItemID"]),Convert.ToInt32(dr["TaskID"]));
                }
                common.WriteLogs("--销售订单批量变更结束--");
            }
        }

        public static void Test()
        {
            //Json_SeOrder order = new Json_SeOrder();
            //order.page1 = new Json_SeOrder.Page1()
            //{
            //    FBillerID = new Json_SeOrder.Fbillerid() {
            //        FName = "1",
            //        FNumber="4444"

            //    }
            //};
            //common.WriteLogs( "QQQQQ:"+ JsonConvert.SerializeObject(order));

            JD_OrderListApply_LogService service = new JD_OrderListApply_LogService();
            DataView dv = service.GetDistinctList();
            if (dv.Count > 0)
            {
                foreach (DataRowView dr in dv)
                {
                    service.AddOrderEntry(Convert.ToInt32(dr["TaskID"]), APIUrl, APICode, Common.FileType.采购订单_物料.ToString());
                }
            }
            //service.Test(APIUrl, APICode);
        }

        //采购订单交期批量变更 轮询 
        public static void UpdateOrderEntry_Date()
        {
            DataView dv = common.GetUpdateAppTab("JD_OrderBG_Log", "").DefaultView;
            JD_OrderBG_LogService service = new JD_OrderBG_LogService();

            if (dv.Count > 0)
            {
                common.WriteLogs("--采购订单交期批量变更开始--");
                try
                {
                    foreach (DataRowView dr in dv)
                    {
                        service.UpdatePOOrderEntry(Convert.ToInt32(dr["ItemID"]));
                    }
                }
                catch (Exception ex)
                {
                    common.WriteLogs("采购订单交期批量变更Error:" + ex.Message);
                }
                common.WriteLogs("--采购订单交期批量变更结束--");
            }
        }

        //销售订单 新增 集成
        public static void AddSeOrderEntry()
        {

          
            string ordernum = string.Empty;
            JD_SeorderApply_LogService service = new JD_SeorderApply_LogService();
            PPOrderEntryService ppservice = new PPOrderEntryService();
            DataView dv = service.GetDistinctList();
            if (dv.Count > 0)
            {
                ApiEnvironment apiEnv = new ApiEnvironment();
                apiEnv.init(APIUrl, APICode);
                foreach (DataRowView dr in dv)
                {
                    int TaskID = Convert.ToInt32(dr["TaskID"]);
                    //集成 并返回成功的销售订单号
                    ordernum = service.AddSeorder(TaskID, APIUrl, "SO", apiEnv.Token, Common.FileType.销售订单.ToString());
                    //更新ordernum 写回日志
                    if (!string.IsNullOrEmpty(ordernum))
                    {
                        service.Updateordernum(TaskID, ordernum);
                    }
                    //更新K3 关联数量以及关闭状态
                    if (!string.IsNullOrEmpty(dr["FInterID"].ToString()))
                    {
                        decimal FCount = Convert.ToDecimal(dr["FQty"].ToString());
                        ppservice.UpdateInSeorder(Convert.ToInt32(dr["FInterID"].ToString()), Convert.ToInt32(dr["FEntryID"].ToString()), FCount);
                    }
                }
            }
        }

        //采购订单-物料 集成
        public static void AddPOOrderEntry()
        {
            JD_OrderListApply_LogService service = new JD_OrderListApply_LogService();
            DataView dv = service.GetDistinctList();
            if (dv.Count > 0)
            {
                ApiEnvironment apiEnv = new ApiEnvironment();
                apiEnv.init(APIUrl, APICode);
                string ordernum = string.Empty;

                foreach (DataRowView dr in dv)
                {
                    int TaskID = Convert.ToInt32(dr["TaskID"]);
                    //正式服务器上使用
                    //if (dr["IsPart"].ToString() == "1") {
                    //    apiEnv.init(APIUrl, APICodePart); 
                    //}
                    //K3集成
                    ordernum = service.AddPOOrderEntry(TaskID, APIUrl, "PO", apiEnv.Token, Common.FileType.采购订单_物料.ToString());

                    if (!string.IsNullOrEmpty(ordernum))
                    {
                        //更新ordernum
                        service.Updateordernum(TaskID, ordernum);

                        #region 更新请购单 关联数量以及是否关闭标志
                        if (!string.IsNullOrEmpty((dr["REQType"].ToString())))
                        {
                            
                            if (dr["REQType"].ToString() == "NPI" || dr["REQType"].ToString() == "QT")
                            {
                                service.UpdateFLinkQty(dr["FBillNo"].ToString(), dr["FNumber"].ToString(), Convert.ToDecimal(dr["FQty"].ToString()));
                            }
                        }
                        #endregion 
                    }
                }
            }

        }

        //铜价阶梯价更新
        public static void UpdateCuPrice()
        {
            JD_CuPriceDetailService service = new JD_CuPriceDetailService();
            DataView dv = service.GetDistinctList();
            if (dv.Count > 0)
            {
                common.WriteLogs(Common.FileType.采购限价申请.ToString(), "---采购限价申请更新开始---");
                foreach (DataRowView dr in dv)
                {
                    //本地集成
                    service.UpdateCuPrice(Convert.ToInt32(dr["ItemID"].ToString()), Common.FileType.采购限价申请.ToString());
                    //K3 物料信息集成
                    service.UpdateItemInfo(dr["MOQ"].ToString(), dr["PPQ"].ToString(), dr["PackageInfo"].ToString(),
                        dr["FNumber"].ToString(), dr["ItemID"].ToString());


                }
                common.WriteLogs(Common.FileType.采购限价申请.ToString(), "---采购限价申请更新结束---");
            }
        }

        public static void UpdateSePrice()
        {
            JD_SePriceDetailService service = new JD_SePriceDetailService();
            DataView dv = service.GetDistinctList();
            if (dv.Count > 0)
            {
                common.WriteLogs(Common.FileType.销售限价申请.ToString(), "---销售限价申请更新开始---");
                foreach (DataRowView dr in dv)
                {
                    //本地集成
                    service.HandlePriceData(Convert.ToInt32(dr["ItemID"].ToString()), Common.FileType.销售限价申请.ToString(), Convert.ToInt32(dr["TaskID"].ToString()));

                }
                common.WriteLogs(Common.FileType.销售限价申请.ToString(), "---销售限价申请更新结束---");
            }
        }

        //请购单集成  物料集成以及 本地请购单数据更新 
        public static void UpdatePORequest()
        {
            JD_PORequest_LogService service = new JD_PORequest_LogService();
            DataView dv = service.GetDistinctList();
            #region 物料请购单更新
            //dv.RowFilter = " REQType='WL' and LogType='Add' ";
            dv.RowFilter = " REQType='WL' ";
            if (dv.Count > 0)
            {
                foreach (DataRowView dr in dv)
                {
                    service.UpdatePORequest_Apply(Convert.ToInt32(dr["ItemID"].ToString()), Common.FileType.请购单_物料.ToString());
                }
            }
            #endregion

            #region 请购单变更 数量更新
            dv.RowFilter = " LogType='Edit'";
            if (dv.Count > 0)
            {
                foreach (DataRowView dr in dv)
                {
                    service.UpdatePORequest_NumBG(Convert.ToInt32(dr["ItemID"].ToString()), Common.FileType.请购单变更.ToString());
                }
            }
            #endregion

        }


    }
}
