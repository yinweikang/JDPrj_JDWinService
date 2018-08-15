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
    public class SupplierDal
    {

        Common common = new Common();
        //供应商新增
        public void Save(DataTable dt, string APIUrl, string APICode)
        {
            string tableName = "JD_Supplier";
            string objectMame = "Supplier";
            string actionName = "GetTemplate";
            string saveName = "Save";
            string loginUrl = "";//K3 API请求的路径
            string json = " "; //请求的参数
            Supplier model = new Supplier();
            string htmlCode = "";
            try
            {

                #region 请求K3API 获得Model对象
                ApiEnvironment apiEnv = new ApiEnvironment();
                apiEnv.init(APIUrl, APICode);

                if (apiEnv.isOk)
                {
                    loginUrl = APIUrl + objectMame + "/" + actionName + "?Token=" + apiEnv.Token;
                    HttpWebResponse response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, json, null, null, Encoding.UTF8, null);
                    Stream resStream = response.GetResponseStream();
                    StreamReader sr = new StreamReader(resStream, Encoding.UTF8);
                    htmlCode = sr.ReadToEnd();//获取返回JSON
                    htmlCode = "{\"" + htmlCode.Substring(htmlCode.IndexOf("Data"), htmlCode.Length - htmlCode.IndexOf("Data"));
                    model = JsonConvert.DeserializeObject<Supplier>(htmlCode);
                }
                else
                {
                    common.WriteLogs("供应商接口Error：" + apiEnv.Message);
                }
                #endregion

                #region 供应商必填项赋值 和 K3集成新增 

                foreach (DataRow dr in dt.Rows)
                {
                    model.Data.FNumber = dr["FTypeCode"].ToString() + "." + dr["FCode"].ToString();
                    model.Data.FStatus.FName = "使用";
                    model.Data.FStatus.FID = "ZT01";

                    model.Data.FName = dr["FName"].ToString();//供应商名称
                    model.Data.FShortName = dr["FSimpleName"].ToString();//供应商简称
                    model.Data.FValueAddRate = Convert.ToInt32(dr["FValueAddRate"].ToString()); //税率
                    model.Data.FBank = dr["AccountName"].ToString(); //开户行
                    model.Data.FAccount = dr["AccountCode"].ToString(); //银行账号
                    model.Data.FContact = dr["CGName"].ToString(); //联系人
                    model.Data.FPhone = dr["CGTel"].ToString(); //电话
                    model.Data.FMobilePhone = dr["CGMobile"].ToString(); //移动电话

                    model.Data.FCyID.FName = dr["FCyName"].ToString();    //结算币种
                    model.Data.FCyID.FNumber = dr["FCyNumber"].ToString();


                    model.Data.FSetID.FName = dr["FsetidName"].ToString();  //结算方式
                    model.Data.FSetID.FNumber = dr["FsetidNumber"].ToString();


                    model.Data.FAPAccountID.FName = dr["FYingFuName"].ToString();   //应付账款科目代码 
                    model.Data.FAPAccountID.FNumber = dr["FYingFuNumber"].ToString();


                    model.Data.FPreAcctID.FName = dr["FYuFuName"].ToString();   //预付账款科目代码 
                    model.Data.FPreAcctID.FNumber = dr["FYuFuNumber"].ToString();


                    model.Data.FOtherAPAcctID.FName = dr["FOtherFuName"].ToString();   //其他应付账款科目代码
                    model.Data.FOtherAPAcctID.FNumber = dr["FOtherFuNumber"].ToString();


                    model.Data.FPayTaxAcctID.FName = dr["FPayTaxAcctIDName"].ToString();   //应交税金科目代码
                    model.Data.FPayTaxAcctID.FNumber = dr["FPayTaxAcctIDNumber"].ToString();

                    model.Data.FCreditDays[0].FName = dr["FcreditdayName"].ToString();   //付款条件
                    model.Data.FCreditDays[0].FNumber = dr["FcreditdayNumber"].ToString();

                    #region K3集成新增 
                    string aaa = JsonConvert.SerializeObject(model);

                    aaa = "{\"data\":[{" + aaa.Substring(9, aaa.Length - 9 - 2) + "}]}";
                    loginUrl = APIUrl + objectMame +"/"+ saveName+ "?Token=" + apiEnv.Token;
                    //发送数据
                    Result result = common.SendToK3(loginUrl, aaa);
                    //更新发送表
                    common.UpdateTable(tableName, dr["TaskID"].ToString());

                    if (result.Message != "Successful")
                    {
                        common.WriteLogs("K3集成-供应商新增Error,TaskID:" + dr["TaskID"].ToString() + ",Message:" + result.Message);
                    }

                    #endregion
                }


                #endregion


            }
            catch (Exception ex)
            {
                common.WriteLogs(ex.Message);
            }

        }
    }
}
