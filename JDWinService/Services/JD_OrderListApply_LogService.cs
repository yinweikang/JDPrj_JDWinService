using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDWinService.Dal;
using JDWinService.Model;
using JDWinService.Utils;
using Kingdee.K3.API.SDK;
using System.IO;
using System.Net;
using System.Data;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace JDWinService.Services
{
    public class JD_OrderListApply_LogService
    {
        JD_OrderListApply_LogDal dal = new JD_OrderListApply_LogDal();
        public void AddOrderEntry(int TaskID, string APIUrl, string APICode, string FileType)
        {
            dal.AddOrderEntry(TaskID, APIUrl, APICode, FileType);
        }
        public string AddPOOrderEntry(int TaskID, string APIUrl, string FuncName, string Token, string FileType)
        {
            return dal.AddPOOrderEntry(TaskID, APIUrl, FuncName, Token, FileType);
        }

        public DataView GetDistinctList()
        {
            return dal.GetDistinctList();
        }

        public void Updateordernum(int TaskID, string ordernum)
        {
            dal.Updateordernum(TaskID, ordernum);
        }

        public void UpdateFLinkQty(string SNumber, int ItemID, decimal FQty)
        {
            dal.UpdateFLinkQty(SNumber, ItemID,   FQty);
        }

       
        public void Test(string APIUrl, string APICode)
        {
            ApiEnvironment apiEnv = new ApiEnvironment();
            apiEnv.init(APIUrl, APICode);
            string loginUrl = APIUrl + "PO/Save?Token=" + apiEnv.Token;


            FileStream fs = new FileStream(@"D:\MyPrj\2018_苏州矩度\代码\JDWinService\JDWinService\Json2.txt", FileMode.Open, FileAccess.Read);
            //仅 对文本 执行  读写操作     
            System.Text.Encoding code = System.Text.Encoding.GetEncoding("gb2312");
            StreamReader sr = new StreamReader(fs, code);

            string Json = sr.ReadToEnd();
            new Common().WriteLogs(Common.FileType.采购订单_物料.ToString(), "Test数据：" + Json);

            HttpWebResponse response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, Json, null, null, Encoding.UTF8, null);
            Stream resStream = response.GetResponseStream();
            StreamReader sr2 = new StreamReader(resStream, Encoding.UTF8);
            string htmlCode = sr2.ReadToEnd();//获取返回JSON
            new Common().WriteLogs(Common.FileType.采购订单_物料.ToString(), "htmlCode:" + htmlCode);
            sr.Close();
            fs.Close();
        }

        public void TestJson()
        {
            //FileStream fs = new FileStream(@"D:\MyPrj\2018_苏州矩度\代码\JDWinService\JDWinService\Json.txt", FileMode.Open, FileAccess.Read);
            ////仅 对文本 执行  读写操作     
            //System.Text.Encoding code = System.Text.Encoding.GetEncoding("gb2312");
            //StreamReader sr = new StreamReader(fs, code); 
            //string Json = sr.ReadToEnd();
            //JObject jobj = JObject.Parse(Json);
            //string aaa ="{\"Page1\":"+ jobj["Data"]["Page1"].ToString().TrimStart('[').TrimEnd(']') + "}" ;
            //Json_POOrder_Head model = JsonConvert.DeserializeObject<Json_POOrder_Head>(aaa);
            //new Common().WriteLogs(Common.FileType.采购订单_物料.ToString(), "FStatus:" + model.Page1.FStatus);
            K3JsonHelper helper = new K3JsonHelper();
            //Json_POOrder_Head model = helper.GetPageMol<Json_POOrder_Head>(11111,APIUrl,"PO",T)
        }
    }
}
