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
    public class JD_IcItemBGApply_LogService
    {
        JD_IcItemBGApply_LogDal dal = new JD_IcItemBGApply_LogDal();

        public void UpdateItemBySupply()
        {
            dal.UpdateItemBySupply();
        }
    }
}
