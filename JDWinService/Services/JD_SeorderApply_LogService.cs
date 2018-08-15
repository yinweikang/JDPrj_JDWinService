using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDWinService.Dal;
using JDWinService.Model;
using System.Data;

namespace JDWinService.Services
{
    public class JD_SeorderApply_LogService
    {

        JD_SeorderApply_LogDal dal = new JD_SeorderApply_LogDal();
        public void AddSeorder(DataView dv,string APIUrl,string APICode) {
            dal.AddSeorder(dv, APIUrl, APICode);
        }

        public string AddSeorder(int TaskID, string APIUrl, string FuncName, string Token, string FileType)
        {
            return dal.AddSeorder(TaskID, APIUrl, FuncName, Token, FileType);
        }

        public DataView GetDistinctList()
        {
            return dal.GetDistinctList();
        }

        public void Updateordernum(int TaskID, string ordernum)
        {
            dal.Updateordernum(TaskID, ordernum);
        }
        public void Test(string APIUrl, string APICode)
        {
            dal.Test(APIUrl,  APICode);
        }
    }
}
