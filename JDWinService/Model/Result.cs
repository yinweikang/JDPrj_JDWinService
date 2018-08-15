using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    public class Result
    {
        public string Message;

        public string StatusCode;

        public string Data;

        public Result(string Json, string Type)
        {
            var o = JObject.Parse(Json);

            this.Message = o["Message"].ToString();
            this.StatusCode = o["StatusCode"].ToString();
            this.Data = o["Data"].ToString();
        }

        public Result(string Json) {

            var o = JObject.Parse(Json);
            var v = o["Data"][0]["Data"];
            this.Message = o["Data"][0]["Data"].ToString();
            this.StatusCode = o["StatusCode"].ToString(); 
        }

        
    }
}
