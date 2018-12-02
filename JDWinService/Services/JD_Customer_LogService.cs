using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDWinService.Dal;
using JDWinService.Model;
using JDWinService.Utils;
using System.Data;

namespace JDWinService.Services
{
    public class JD_Customer_LogService
    {
        JD_Customer_LogDal dal = new JD_Customer_LogDal();
        public DataView GetDistinct()
        {
            return dal.GetDistinct();
        }

        public void CustomerAdd(int ItemID, string APIUrl, string FuncName, string Token, string FileType)
        {
            dal.CustomerAdd(ItemID, APIUrl, FuncName, Token, FileType);
        }
        public void UpdateCustomer(int ItemID, string FileType)
        {
            dal.UpdateCustomer(ItemID,FileType);
        }
    }
}
