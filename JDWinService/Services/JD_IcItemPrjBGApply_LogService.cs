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
    public class JD_IcItemPrjBGApply_LogService
    {
        JD_IcItemPrjBGApply_LogDal dal = new JD_IcItemPrjBGApply_LogDal();

        public void UpdateItemInfo()
        {
            dal.UpdateItemInfo();
        }
    }
}
