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
using System.Threading;


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
                //TestToken();             //K3 API连接测试
                UpdateOrderEntry_Date();   //采购订单 交期变更
                UpdateSeorderEntry_Date(); //销售订单 交期表更

                //供应链流程
                UpdateCuPrice();           //采购限价应用更新 阶梯价
                UpdateItemBySupplier();    //物料信息修改-供应链 
                SupplierCheck();           //供应商新增或变更
                PrivateNote();             //供应商流程备忘录

                //请购流程
                UpdatePORequest();         //请购单集成

                //采购流程
                OrderBGCheck();            //采购订单物料变更 
                //AddPOOrderEntry();         //采购订单新增API 集成 
                //OrderBGNPIAndOtherCheck(); //采购订单其他和NPI变更

                //OrderBGNPICheck();         //采购订单NPI变更  

                //UpdateSeorderEntry();      //销售订单 数量和单价变更
                //UpdateSePrice();           //销售限价更新
                //AddSeOrderEntry();         //销售订单新增



                //UpdateCustomer();          //客户新增或变更
                //UpdatePORequestDel();      //请购单中删除不需要的数据 集成

                //UpdateItemByPlan();        //物料信息修改-计划部
                //UpdateItemByPrj();         //物料信息修改-工程部
                //IcItemAdd();               //料号新建
                //SupplierCredit();          //供应商超限额轮询
                //Test();
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

        public static void TestToken()
        {
            ApiEnvironment apiEnv = new ApiEnvironment();
            apiEnv.init(APIUrl, APICode);
            if (string.IsNullOrEmpty(apiEnv.Token))
            {
                Thread.Sleep(2000);
            }
        }
        //供应商新增轮询
        public static void SupplierCheck()
        {


            JD_Supplier_LogService service = new JD_Supplier_LogService();
            DataView dv = service.GetDistinct();
            int IsPart = 0;
            int IsCG = 0;
            if (dv.Count > 0)
            {

                ApiEnvironment apiEnv = new ApiEnvironment();
                foreach (DataRowView dr in dv)
                {
                    //是分公司的话，用分公司的APICode

                    IsPart = Convert.ToInt32((string.IsNullOrEmpty(dr["IsPart"].ToString()) ? "0" : dr["IsPart"].ToString()));
                    common.WriteLogs("IsPart:" + IsPart.ToString());


                    apiEnv.init(APIUrl, (IsPart == 0) ? APICode : APICodePart);
                    IsCG = Convert.ToInt32((string.IsNullOrEmpty(dr["IsCGSupplier"].ToString()) ? "0" : dr["IsCGSupplier"].ToString()));

                    service.HandleSupplier(
                        Convert.ToInt32(dr["ItemID"].ToString()),
                        APIUrl,
                        "Supplier",
                        apiEnv.Token,
                        Common.FileType.供应商流程.ToString(),
                        dr["ApplyType"].ToString(), IsCG);
                }
            }
        }

        //采购订单变更(物料)轮询
        public static void OrderBGCheck()
        {


            JD_OrderListBG_LogService service = new JD_OrderListBG_LogService();
            DataView dv = service.GetDistinctList();
            dv.RowFilter = " OrderListBGName='WL' ";
            if (dv.Count > 0)
            {
                common.WriteLogs(Common.FileType.采购订单变更_物料.ToString(), "--采购订单变更_物料开始--");
                foreach (DataRowView dr in dv)
                {
                    service.UpdatePOEntry(dr["TaskID"].ToString(), dr["BGName"].ToString());
                }
                common.WriteLogs(Common.FileType.采购订单变更_物料.ToString(), "--采购订单变更_物料结束--");
            }
        }

        //采购订单变更(其他和NPI)轮询
        public static void OrderBGNPIAndOtherCheck()
        {
            JD_OrderListBG_LogService service = new JD_OrderListBG_LogService();
            service.UpdateOrderBG();
        }

        //采购订单变更(NPI)轮询
        public static void OrderBGNPICheck()
        {

            JD_OrderListBG_LogService service = new JD_OrderListBG_LogService();
            DataView dv = service.GetDistinctList();
            dv.RowFilter = " OrderListBGName='NPI' ";
            if (dv.Count > 0)
            {
               
                foreach (DataRowView dr in dv)
                {
                    service.UpdateNPIPOEntry(dr["TaskID"].ToString());
                }
             
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
                    service.UpdateSeOrderEntry(Convert.ToInt32(dr["ItemID"]), Convert.ToInt32(dr["TaskID"]));
                }
                common.WriteLogs("--销售订单批量变更结束--");
            }
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
                    #region 更新K3 关联数量以及关闭状态

                    DataView dv2 = service.GetUpdateInfo(dr["TaskID"].ToString());
                    if (dv2.Count > 0)
                    {
                        foreach (DataRowView dr2 in dv2)
                        {
                            if (!string.IsNullOrEmpty(dr2["FInterID"].ToString()))
                            {
                                decimal FCount = Convert.ToDecimal(dr2["FQty"].ToString());
                                ppservice.UpdateInSeorder(Convert.ToInt32(dr2["FInterID"].ToString()), Convert.ToInt32(dr2["FEntryID"].ToString()), FCount);
                            }
                        }
                    }
                    #endregion

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
                    }
                }
            }

        }

        //铜价阶梯价更新
        public static void UpdateCuPrice()
        {
            JD_CuPriceDetailService service = new JD_CuPriceDetailService();
            //更新表中 变更前数据
            service.UpdateStatusInNew();
            DataView dv = service.GetDistinctList();
            if (dv.Count > 0)
            {
                 
                foreach (DataRowView dr in dv)
                {
                    //本地集成 和 K3物料信息集成
                    service.UpdateCuPrice(Convert.ToInt32(dr["ItemID"].ToString()), Common.FileType.采购限价申请.ToString(), Convert.ToInt32(dr["TaskID"].ToString())); 
                }

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
            dv.RowFilter = " REQType='WL' ";
            if (dv.Count > 0)
            {
                foreach (DataRowView dr in dv)
                {
                    service.UpdatePORequest_Apply(Convert.ToInt32(dr["ItemID"].ToString()), Common.FileType.请购单_物料.ToString(), Convert.ToInt32(dr["TaskID"].ToString()));
                }
            }
            #endregion

            #region 请购单变更 数量更新
            dv.RowFilter = " LogType='Edit'";
            if (dv.Count > 0)
            {
                foreach (DataRowView dr in dv)
                {
                    service.UpdatePORequest_NumBG(Convert.ToInt32(dr["ItemID"].ToString()), Common.FileType.请购单变更.ToString(), Convert.ToInt32(dr["TaskID"].ToString()));
                }
            }
            #endregion

        }

        public static void UpdateCustomer()
        {
            JD_Customer_LogService service = new JD_Customer_LogService();
            DataView dv = service.GetDistinct();

            #region 客户新增集成
            dv.RowFilter = " LogType='Add'";
            if (dv.Count > 0)
            {
                ApiEnvironment apiEnv = new ApiEnvironment();
                apiEnv.init(APIUrl, APICode);
                foreach (DataRowView dr in dv)
                {

                    service.CustomerAdd(
                        Convert.ToInt32(dr["ItemID"].ToString()),
                        APIUrl,
                        "Customer",
                        apiEnv.Token,
                        Common.FileType.客户新增或变更流程.ToString()
                      );
                }
            }
            #endregion

            #region 客户变更 本地集成在流程图中用控件完成  和K3数据库集成
            dv.RowFilter = " LogType='Edit'";
            if (dv.Count > 0)
            {
                foreach (DataRowView dr in dv)
                {
                    service.UpdateCustomer(Convert.ToInt32(dr["ItemID"].ToString()), Common.FileType.客户新增或变更流程.ToString());
                }
            }
            #endregion
        }


        //删除请购单中 需要删除的数据
        public static void UpdatePORequestDel()
        {
            JD_PORequest_DelService service = new JD_PORequest_DelService();
            DataView dv = service.GetDistinct();
            if (dv.Count > 0)
            {
                foreach (DataRowView dr in dv)
                {
                    service.HandleDel(dr["FInterID"].ToString(), dr["TaskID"].ToString());
                }
            }
        }

        //物料信息变更  供应链修改
        public static void UpdateItemBySupplier()
        {
            JD_IcItemBGApply_LogService service = new JD_IcItemBGApply_LogService();
            service.UpdateItemBySupply();
        }

        public static void UpdateItemByPlan()
        {
            JD_IcItemPlanBGApply_logService service = new JD_IcItemPlanBGApply_logService();
            service.UpdateInfo();
        }

        public static void UpdateItemByPrj()
        {
            JD_IcItemPrjBGApply_LogService service = new JD_IcItemPrjBGApply_LogService();
            service.UpdateItemInfo();
        }

        public static void IcItemAdd()
        {
            MaterialService service = new MaterialService();
            service.IcItemAdd(APIUrl, APICode);
            //MaterialDal dal = new MaterialDal();
            //ApiEnvironment apiEnv = new ApiEnvironment();
            //apiEnv.init(APIUrl, APICode);
            //dal.Save(APIUrl,"Save", apiEnv.Token);
        }

        //供应商超限额
        public static void SupplierCredit()
        {
            JD_OrderList_SupplierCredit_logService service = new JD_OrderList_SupplierCredit_logService();
            service.SendBeyondMsg();
        }

        public static void PrivateNote()
        {
            JD_PrivateNoteDal dal = new JD_PrivateNoteDal();
            dal.AddNewNote();
        }

        public static void Test()
        {


            //DataTable dt = AccessHelper.Query("select * from CHECKINOUT"); 
            //foreach (DataRowView dr in dt.DefaultView)
            //{

            //}

            //JD_PrjBomBGDal dal = new JD_PrjBomBGDal();
            //dal.TestCheck(APIUrl, APICode);

            //JD_CuPriceDetailDal dal = new JD_CuPriceDetailDal();
            //dal.UpdateParentID();

            JD_PrivateNoteDal dal = new JD_PrivateNoteDal();
            dal.AddNewNote();
        }
    }
}
