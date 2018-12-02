using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using JDWinService.Utils;
using Kingdee.K3.API.SDK;
using System.Net;
using System.IO;
using JDWinService.Model;
using Newtonsoft.Json;


namespace JDWinService.Dal
{
    public class MaterialDal
    {
        Common common = new Common();
        JD_MaterialApply_LogDal logdal = new JD_MaterialApply_LogDal();
        //料号新增
        public void Save(string APIUrl,string FuncName, string Token)
        {
           
            string tableName = "JD_Supplier";
            string objectMame = "Material";
            string actionName = "GetTemplate";
          
            string loginUrl = "";//K3 API请求的路径
            string json = " "; //请求的参数
            Material model = new Material();

            string htmlCode = "";
            try
            {

                #region 请求K3API 获得Model对象

                loginUrl = APIUrl + objectMame + "/" + actionName + "?Token=" + Token;
                HttpWebResponse response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, json, null, null, Encoding.UTF8, null);
                Stream resStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(resStream, Encoding.UTF8);
                htmlCode = sr.ReadToEnd();//获取返回JSON
                htmlCode = "{\"" + htmlCode.Substring(htmlCode.IndexOf("Data"), htmlCode.Length - htmlCode.IndexOf("Data"));
                model = JsonConvert.DeserializeObject<Material>(htmlCode);

              
                #endregion

                #region 物料必填项赋值 和 K3集成新增 

                #region 基本资料
                model.Data.FName = "SISISISIS";
                model.Data.FNumber = "5.H5-10068";
                model.Data.FFullName = "Test-SISISISIS";
                //物料属性
                //model.Data.FErpClsID.FName = "";
                //model.Data.FErpClsID.FID = "";
                //计量单位组
                model.Data.FUnitGroupID.FName = "数量组";
                model.Data.FUnitGroupID.FNumber = "24381";

                //基本计量单位
                model.Data.FUnitID.FName = "PCS";
                model.Data.FUnitID.FNumber = "S01";
                //采购单位
                model.Data.FOrderUnitID.FName = "PCS";
                model.Data.FOrderUnitID.FNumber = "S01";
                //销售单位
                model.Data.FSaleUnitID.FName = "PCS";
                model.Data.FSaleUnitID.FNumber = "S01";
                //生产单位
                model.Data.FProductUnitID.FName = "PCS";
                model.Data.FProductUnitID.FNumber = "S01";
                //库存单位
                model.Data.FStoreUnitID.FName = "PCS";
                model.Data.FStoreUnitID.FNumber = "S01";

                model.Data.FHighLimit = 1000;

                #endregion

                #region 供应商信息
                model.Data.F_109 = "制造商";  //制造商
                model.Data.F_108 = "ZZSCode";
                model.Data.F_117 = "ZZSVersion";
                #endregion

                #region 物流资料
                model.Data.FCheckCycle = 1;
                model.Data.FKanBanCapability = 1;
                model.Data.FStdBatchQty = 1;

                model.Data.FISKFPeriod = true;
                model.Data.FKFPeriod = 365;
                model.Data.FStockTime = true;
                model.Data.FBatchManager = true;
                //成品:加权  零件：批内加权
                model.Data.FTrack.FName = "加权平均法"; //计价方法
                model.Data.FTrack.FID = "F001";

                model.Data.FPriceDecimal = "6";
                //存货科目
                model.Data.FAcctID.FName = "库存现金";
                model.Data.FAcctID.FNumber = "1001";
                //销售科目
                model.Data.FSaleAcctID.FName = "库存现金";
                model.Data.FSaleAcctID.FNumber = "1001";
                //销售成本科目
                model.Data.FCostAcctID.FName = "库存现金";
                model.Data.FCostAcctID.FNumber = "1001";
                //税目代码
                model.Data.FGoodSpec.FName = "卷烟";
                model.Data.FGoodSpec.FID = "1010101100";

                model.Data.FTaxRate = 16;

                #endregion

                #region 计划资料
                model.Data.FBatChangeEconomy = 1;
                //投料自动取整
                model.Data.FPutInteger = false;
                //计划策略
                model.Data.FPlanTrategy.FName = "物料需求计划(MRP)";
                model.Data.FPlanTrategy.FID = "MRP";
                //计划模式
                model.Data.FPlanMode.FName = "MTS计划模式";
                model.Data.FPlanMode.FID = "MTS";
                //订购策略
                model.Data.FOrderTrategy.FName = "批对批(LFL)";
                model.Data.FOrderTrategy.FID = "LFL";

                model.Data.FQtyMin = 1;
                model.Data.FQtyMax =10000;
                model.Data.FIsFixedReOrder = true;
              
                #endregion

                #region 设计资料&&标准数据
                //BU
                model.Data.F_114 = "集成";
                model.Data.F_115 = "未承认";
                model.Data.FStandardManHour = 0; //单位标准工时
                model.Data.F_122 = 0; //本层标准工时
                #endregion
                #region K3集成新增 
                string aaa = JsonConvert.SerializeObject(model);

                aaa = "{\"data\":[{" + aaa.Substring(9, aaa.Length - 9 - 2) + "}]}";
                loginUrl = APIUrl + objectMame + "/" + FuncName + "?Token=" + Token;
                //发送数据
                Result result = common.SendToK3(loginUrl, aaa);
                //更新发送表
                //  common.UpdateTable(tableName, dr["TaskID"].ToString());

                if (result.Message != "Successful")
                {
                    common.WriteLogs("K3集成-供应商新增Error,TaskID:" +  result.Message);
                }

                #endregion
                #endregion
            }
            catch (Exception ex)
            {
                common.WriteLogs(ex.Message);
            }




        }


        public void IcItemAdd(string APIUrl,string APICode)
        {
            DataView dv = logdal.GetDistinct();
            if (dv.Count > 0)
            {
                ApiEnvironment apiEnv = new ApiEnvironment();
                apiEnv.init(APIUrl, APICode);
                Material model = new Material();
                JD_MaterialApply_Log logmodel = new JD_MaterialApply_Log();
                foreach (DataRowView dr in dv)
                {
                    string Error = string.Empty;
                    int ItemID = Convert.ToInt32(dr["ItemID"].ToString());
                    int TaskID = Convert.ToInt32(dr["TaskID"].ToString());
                    model = GetK3Model(APIUrl, "Material", "GetTemplate", apiEnv.Token);
                    try {
                        
                        logmodel = logdal.Detail(ItemID);
                        string SendResult = IcItemSave(APIUrl, "Save", apiEnv.Token, logmodel, model);
                        if (SendResult != "Successful")
                        {
                            Error = SendResult;
                        }
                    }
                    catch (Exception ex)
                    {
                        Error = ex.Message;
                    }
                    finally {
                        logmodel.IsUpdate = 1;
                        logmodel.UpdateTime = DateTime.Now;
                        logdal.Update(logmodel);
                        //集成日志
                        common.AddLogQueue(TaskID, "JD_MaterialApply_Log", ItemID, "API", Error);
                    }
                }
            }
        }

        protected string IcItemSave(string APIUrl, string FuncName, string Token, JD_MaterialApply_Log logmodel, Material model)
        {
            #region 物料必填项赋值 

            #region 基本资料
            model.Data.FName = logmodel.FName;
            model.Data.FNumber = logmodel.FNumber;
            model.Data.FFullName = logmodel.FFullName;
            model.Data.FModel = logmodel.FModel;
            //物料属性
            model.Data.FErpClsID.FName = logmodel.FErpClsID;
            model.Data.FErpClsID.FID = logmodel.FErpClsIDNum;
            //计量单位组
            model.Data.FUnitGroupID.FName = logmodel.FUnitGroupID;
            model.Data.FUnitGroupID.FNumber = logmodel.FUnitGroupIDNum;

            //基本计量单位
            model.Data.FUnitID.FName = logmodel.FUnitID;
            model.Data.FUnitID.FNumber = logmodel.FUnitIDNum;
            //采购单位
            model.Data.FOrderUnitID.FName = logmodel.FOrderUnitID;
            model.Data.FOrderUnitID.FNumber = logmodel.FOrderUnitIDNum;
            //销售单位
            model.Data.FSaleUnitID.FName = logmodel.FSaleUnitID;
            model.Data.FSaleUnitID.FNumber = logmodel.FSaleUnitIDNum;
            //生产单位
            model.Data.FProductUnitID.FName = logmodel.FProductUnitID;
            model.Data.FProductUnitID.FNumber = logmodel.FProductUnitIDNum;
            //库存单位
            model.Data.FStoreUnitID.FName = logmodel.FStoreUnitID;
            model.Data.FStoreUnitID.FNumber = logmodel.FStoreUnitIDNum;

            model.Data.FHighLimit = 1000;

            #endregion

            #region 供应商信息
            model.Data.F_109 = logmodel.MakerName;  //制造商
            model.Data.F_108 = logmodel.MakerCode;
            model.Data.F_117 = logmodel.MakerVersion;
            #endregion

            #region 物流资料
            model.Data.FCheckCycle = 1;
            model.Data.FKanBanCapability = 1;
            model.Data.FStdBatchQty = 1;

            model.Data.FISKFPeriod =(logmodel.FISKFPeriod=="是")?true:false;
            model.Data.FKFPeriod = logmodel.FKFPeriod;
            model.Data.FStockTime = (logmodel.FStockTime == "是") ? true : false;  
            model.Data.FBatchManager = (logmodel.FBatchManager == "是") ? true : false; 
            //成品:加权  零件：批内加权
            model.Data.FTrack.FName = logmodel.FTrack; //计价方法
            model.Data.FTrack.FID = logmodel.FTrackNum;

            model.Data.FPriceDecimal = "6";
            //存货科目
            model.Data.FAcctID.FName = logmodel.FAcctID;
            model.Data.FAcctID.FNumber = logmodel.FAcctIDNum;
            //销售科目
            model.Data.FSaleAcctID.FName = logmodel.FSaleAcctID;
            model.Data.FSaleAcctID.FNumber = logmodel.FSaleAcctIDNum;
            //销售成本科目
            model.Data.FCostAcctID.FName = logmodel.FCostAcctID;
            model.Data.FCostAcctID.FNumber = logmodel.FCostAcctIDNum;
            //税目代码
            model.Data.FGoodSpec.FName = logmodel.FGoodSpec;
            model.Data.FGoodSpec.FID = logmodel.FGoodSpecNum;

            model.Data.FTaxRate = 16;

            #endregion

            #region 计划资料
            model.Data.FBatChangeEconomy = 1;
            //投料自动取整
            model.Data.FPutInteger = (logmodel.FPutInteger == "是") ? true : false; ;
            //计划策略
            model.Data.FPlanTrategy.FName = logmodel.FPlanTrategy;
            model.Data.FPlanTrategy.FID = logmodel.FPlanTrategyNum;
            //计划模式
            model.Data.FPlanMode.FName = logmodel.FPlanMode;
            model.Data.FPlanMode.FID = logmodel.FPlanModeNum;
            //订购策略
            model.Data.FOrderTrategy.FName = logmodel.FOrderTrategy;
            model.Data.FOrderTrategy.FID = logmodel.FOrderTrategyNum;

            model.Data.FQtyMin = 1;
            model.Data.FQtyMax = 10000;
            model.Data.FIsFixedReOrder = true;

            #endregion

            #region 设计资料&&标准数据
            //BU
            model.Data.F_114 = logmodel.F_114;
            model.Data.F_115 = logmodel.F_114;
            model.Data.FStandardManHour = logmodel.FStandardManHour; //单位标准工时
            model.Data.F_122 = logmodel.F_122; //本层标准工时
            #endregion

            #endregion

            #region K3集成新增 
            string aaa = JsonConvert.SerializeObject(model);
            string loginUrl = string.Empty;
            aaa = "{\"data\":[{" + aaa.Substring(9, aaa.Length - 9 - 2) + "}]}";
            loginUrl = APIUrl + "Material" + "/" + FuncName + "?Token=" + Token;
            //发送数据
            Result result = common.SendToK3(loginUrl, aaa);
            if (result.Message != "Successful")
            {
                common.WriteLogs("K3集成-料号新建集成Error,TaskID:" + result.Message);
            }
            return result.Message;
            #endregion
        }
        //获取API模板
        protected Material GetK3Model(string APIUrl,string objectMame, string actionName,string Token)
        {
            string loginUrl = "";//K3 API请求的路径
            string json = " "; //请求的参数
            string htmlCode = string.Empty;
            loginUrl = APIUrl + objectMame + "/" + actionName + "?Token=" + Token;
            HttpWebResponse response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, json, null, null, Encoding.UTF8, null);
            Stream resStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(resStream, Encoding.UTF8);
            htmlCode = sr.ReadToEnd();//获取返回JSON
            htmlCode = "{\"" + htmlCode.Substring(htmlCode.IndexOf("Data"), htmlCode.Length - htmlCode.IndexOf("Data"));
            return JsonConvert.DeserializeObject<Material>(htmlCode);
        }
    }
}
