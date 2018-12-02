using JDWinService.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace JDWinService.Utils
{
    public class K3JsonHelper
    {
        Common common = new Common();
        /// <summary>
        /// 初始化对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="TaskID">流程ID</param>
        /// <param name="APIUrl"></param>
        /// <param name="FuncName">API名称</param>
        /// <param name="Token"></param>
        /// <param name="FileType">日志文件类别</param>
        /// <param name="PageNum">Page1，Page2</param>
        /// <returns></returns>
        public T GetPageMol<T>(int TaskID,string APIUrl, string FuncName, string Token, string FileType,string PageNum) {

            string loginUrl = APIUrl + FuncName + "/GetTemplate?Token=" + Token; 
            HttpWebResponse response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, " ", null, null, Encoding.UTF8, null);
            Stream resStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(resStream, Encoding.UTF8);
            string htmlCode = sr.ReadToEnd();//获取返回JSON  
            JObject jobj = JObject.Parse(htmlCode);
          
            if (jobj["StatusCode"].ToString() == "200")
            {
                JObject OutData = JObject.Parse(jobj["Data"].ToString());
                JObject InnerData = JObject.Parse(OutData["Data"].ToString());

                string JsonPage1 = "{\""+ PageNum + "\":" + InnerData[PageNum].ToString().TrimStart('[').TrimEnd(']') + "}";
                return JsonConvert.DeserializeObject<T>(JsonPage1);
            }
            else
            {
                common.WriteLogs(FileType, TaskID.ToString(), "----获取模板失败--");
                common.WriteLogs(FileType, TaskID.ToString(), jobj["Message"].ToString());
                return default(T);
            }
               
        }
        //适用于工程变更的Json 格式
        public T GetPageMol<T>(int TaskID, string APIUrl, string FuncName, string Token, string FileType, string PageNum,string ActionName,string Paramers)
        {

            string loginUrl = APIUrl + FuncName + "/"+ ActionName + "?Token=" + Token;
            HttpWebResponse response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, Paramers, null, null, Encoding.UTF8, null);
            Stream resStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(resStream, Encoding.UTF8);
            string htmlCode = sr.ReadToEnd();//获取返回JSON  
            JObject jobj = JObject.Parse(htmlCode);

            if (jobj["StatusCode"].ToString() == "200")
            {
                JObject OutData = JObject.Parse(jobj["Data"].ToString()); 
                string JsonPage1 = "{\"" + PageNum + "\":" + OutData[PageNum].ToString().TrimStart('[').TrimEnd(']') + "}";
                return JsonConvert.DeserializeObject<T>(JsonPage1);
            }
            else
            {
                common.WriteLogs(FileType, TaskID.ToString(), "----获取模板失败--");
                common.WriteLogs(FileType, TaskID.ToString(), jobj["Message"].ToString());
                return default(T);
            }

        }
    }
}
