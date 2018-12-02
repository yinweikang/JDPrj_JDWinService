using JDWinService.Model;
using JDWinService.Utils;
using Kingdee.K3.API.SDK;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Dal
{
    public class JD_PrjBomBGDal
    {
        public void Test(string APIUrl, string APICode)
        {
            ApiEnvironment apiEnv = new ApiEnvironment();
            apiEnv.init(APIUrl, APICode);
            //string loginUrl = APIUrl + "Bill1002535/GetDetail?Token=" + apiEnv.Token;
            //string json = "{ \"data\": {   \"FBillNo\": \"BOM013463\"   }   }";
            string loginUrl = APIUrl + "Bill1002535/GetDetail?Token=" + apiEnv.Token;
            string json = " { \"data\": {   \"FBillNo\": \"ECN002330\"   }   }";
            string htmlCode = "";
            HttpWebResponse response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, json, null, null, Encoding.UTF8, null);
            Stream resStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(resStream, Encoding.UTF8);
            htmlCode = sr.ReadToEnd();//获取返回JSON
            string TestJsonData = htmlCode;
            htmlCode = "{\"" + htmlCode.Substring(htmlCode.IndexOf("Data"), htmlCode.Length - htmlCode.IndexOf("Data"));
          


            K3JsonHelper helper = new K3JsonHelper();

            string page1Json = string.Empty;
            string page2Json = string.Empty;
            string page4Json = string.Empty;

            Json_Bill_Page1 page1 = helper.GetPageMol<Json_Bill_Page1>(0, APIUrl, "Bill1002535", apiEnv.Token, "工程变更", Common.PageNum.Page1.ToString());
            page1.Page1.FDescription = "ceshi";
            #region Page2
            Json_Bill_Page2 page2 = helper.GetPageMol<Json_Bill_Page2>(0, APIUrl, "Bill1002535", apiEnv.Token, "工程变更", Common.PageNum.Page2.ToString());
            page2.Page2.FBomEntryParentClsID = "2";
            page2.Page2.FBomEntryParentItemNumber = "5.A6-1758";
            page2.Page2.FBomEntryParentItemName = "CABLE ASSY";
            page2.Page2.FBomEntryParentItemModel = "497-0518415 (REV:A)";
            page2.Page2.FBomEntryItemName = "H.S TUBE";
            page2.Page2.FBomEntryModel = "H.S TUBE H-5(3X) 3/8 COLOR:BLACK ID:9.5MM 带胶 MFG:HONGSHANG";
            page2.Page2.FBomEntryItemOldIndex = "5";
            page2.Page2.FBomEntryAuxQty = "0.05";
            page2.Page2.FBomEntryQty = "0.05";
            page2.Page2.FBomEntryPercent = "100";
            page2.Page2.FBomEntryBeginDay = "1900-01-01 00:00:00";
            page2.Page2.FBomEntryEndDay = "2100-01-01 00:00:00";
            page2.Page2.FBomEntryScrap = "0";
            page2.Page2.FBomEntryPositionNo = "";
            page2.Page2.FBomEntryItemSize = "";
            page2.Page2.FBomEntryItemSuite = "";
            page2.Page2.FBomEntryOperSN = "0";
            page2.Page2.FBomEntryMachinePos = "";
            page2.Page2.FBomEntryOffSetDay = "0";
            page2.Page2.FBomEntryIsKeyItem = "true";
            page2.Page2.FBomEntryUseState = "使用";
            page2.Page2.FBomEntryForbitUse = "0";
            page2.Page2.FBomEntryNOTE = "";
            page2.Page2.FBomEntryNOTE1 = "";
            page2.Page2.FBomEntryNOTE2 = "";
            page2.Page2.FBomEntryNOTE3 = "";
            page2.Page2.FBomEntryDetailID = "fed458de-0b78-45c2-8749-a5df94835579";
            page2.Page2.FBomEntryParentItemID = "64618";
            page2.Page2.FBomEntryIsStockMgr = "true";
            page2.Page2.FBomEntryParentAuxPropID = "0";
            page2.Page2.FBomEntryParentIsCharSourceItem = "0";
            page2.Page2.FBomEntryFixLeadTime = "28";
            page2.Page2.FBomEntrySubItemErpClsID = "1";
            page2.Page2.FBomEntrySubItemErpClsName = "外购"; 
            page2.Page2.FIndex2 = "1";
            page2.Page2.FBomEntryISOld = "0";

            page2.Page2.FBomEntryModifyType.FName = "新增";
            page2.Page2.FBomEntryModifyType.FNumber = "Add";
            page2.Page2.FBomEntryHasChar = "0";

            page2.Page2.FBomEntryAuxPropID.FName = "";
            page2.Page2.FBomEntryAuxPropID.FNumber = "";

            page2.Page2.FBomEntrySPID.FName = "";
            page2.Page2.FBomEntrySPID.FNumber = "";

            page2.Page2.FBomEntryStockID.FName = "原料仓";
            page2.Page2.FBomEntryStockID.FNumber = "C2";


            page2.Page2.FBomEntryBackFlush.FName = "否";
            page2.Page2.FBomEntryBackFlush.FNumber = "N";

            page2.Page2.FBomEntryOperID.FName = "";
            page2.Page2.FBomEntryOperID.FNumber = "";

            page2.Page2.FBomEntryMaterielType.FName = "普通件";
            page2.Page2.FBomEntryMaterielType.FNumber = "COM";

            page2.Page2.FBomEntryUnitID.FName = "M";
            page2.Page2.FBomEntryUnitID.FNumber = "L01";

            page2.Page2.FBomEntryItemID.FName = "H.S TUBE";
            page2.Page2.FBomEntryItemID.FNumber = "C.J0000187M";

            page2.Page2.FBomEntryBOMInterID.FName = "BOM012674";
            page2.Page2.FBomEntryBOMInterID.FNumber = "BOM012674";

            page2.Page2.FBomEntryHasChar = "0";
            #endregion


            Json_Bill_Page3 page3 = helper.GetPageMol<Json_Bill_Page3>(0, APIUrl, "Bill1002535", apiEnv.Token, "工程变更", Common.PageNum.Page3.ToString()); ;

            #region Page4
            Json_Bill_Page4 page4 = helper.GetPageMol<Json_Bill_Page4>(0, APIUrl, "Bill1002535", apiEnv.Token, "工程变更", Common.PageNum.Page4.ToString()); ;
            page4.Page4.FItemName = "H.S TUBE";
            page4.Page4.FModel = "H.S TUBE H-5(3X) 3/8 COLOR:BLACK ID:9.5MM 带胶 MFG:HONGSHANG";
            page4.Page4.FItemClsID = "外购";
            page4.Page4.FEntryItemOldIndex = "5";
            page4.Page4.FAuxQty = "0.05";
            page4.Page4.FQty = "0.05";
            page4.Page4.FEntryBeginDay = "1900-01-01 00:00:00";
            page4.Page4.FEntryEndDay = "2100-01-01 00:00:00";
            page4.Page4.FHeadRoutingName = "";
            page4.Page4.FHeadVersion = "";
            page4.Page4.FEntryScrap ="0";
            page4.Page4.FHeadYield = "";
            page4.Page4.FEntryPositionNo = "";
            page4.Page4.FHeadNote = "";
            page4.Page4.FEntryItemSize = "";
            page4.Page4.FEntryItemSuite = "";
            page4.Page4.FEntryPercent = "100";
            page4.Page4.FEntryOperSN = "0";
            page4.Page4.FEntryMachinePos = "";
            page4.Page4.FEntryOffSetDay = "0";
            page4.Page4.FEntryIsKeyItem = "62680";
            page4.Page4.FEntryUseState = "使用";
            page4.Page4.FEntryForbitUse = "62680";
            page4.Page4.FEntryNOTE = "";
            page4.Page4.FEntryNOTE1 = "";
            page4.Page4.FEntryNOTE2 = "";
            page4.Page4.FEntryNOTE3 = "";
          
            page4.Page4.FIndex4 = "1";
            page4.Page4.FIsOld = "1";
            page4.Page4.FModifyType = "11023";
            page4.Page4.FModifyContent = "1";
            #endregion

            page1Json = JsonConvert.SerializeObject(page1);
            //获取Page2中的内容
            JObject o = JObject.Parse(page1Json);
            page1Json = o["Page1"].ToString();

           
            string SendJson = string.Empty;
            string BodyJson = "\"Page1\":" + "[" + page1Json + "],\"Page2\":"+"["+ JObject.Parse(JsonConvert.SerializeObject(page2))["Page2"].ToString() + "],\"Page3\":["+ JObject.Parse(JsonConvert.SerializeObject(page3))["Page3"].ToString() + "],\"Page4\":["+ JObject.Parse(JsonConvert.SerializeObject(page4))["Page4"].ToString() + "]";
            SendJson = "{\"Data\":{"+BodyJson+"}}";
           
            loginUrl = APIUrl + "Bill1002535" + "/Save?Token=" + apiEnv.Token;
            Result result2 = new Common().SendToK3(loginUrl, SendJson);
            new Common().WriteLogs(SendJson);
            new Common().WriteLogs(result2.Message);
        }

        public void TestCheck(string APIUrl, string APICode)
        {
            ApiEnvironment apiEnv = new ApiEnvironment();
            apiEnv.init(APIUrl, APICode);
            string loginUrl = APIUrl + "Bill1002535/CheckBill?Token=" + apiEnv.Token;
            string json = " { \"data\": {   \"FBillNo\": \"ECN002350\"   }   }";
            string htmlCode = "";
            HttpWebResponse response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, json, null, null, Encoding.UTF8, null);
            Stream resStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(resStream, Encoding.UTF8);
            htmlCode = sr.ReadToEnd();//获取返回JSON
           
        }
    }
}
