using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDWinService.Dal;
using JDWinService.Model;
using JDWinService.Utils;


namespace JDWinService.Services
{
    public class JD_OrderList_SupplierCredit_logService
    {
        JD_OrderList_SupplierCredit_logDal dal = new JD_OrderList_SupplierCredit_logDal();

        public void SendBeyondMsg()
        {
            dal.SendBeyondMsg();
        }
    }
}
