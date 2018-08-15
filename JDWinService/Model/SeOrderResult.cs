using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    public class SeOrderResult
    {
        public string Message;

        public string StatusCode;

        public SeOrderResult(string MessgaeStr, string StatusCodeStr)
        {
            this.Message = MessgaeStr;
            this.StatusCode = StatusCodeStr;
        }

        public SeOrderResult(string Json)
        {

            var o = JObject.Parse(Json);
          
            this.Message = o["Message"].ToString();
            this.StatusCode = o["StatusCode"].ToString();
        }
    }
}
