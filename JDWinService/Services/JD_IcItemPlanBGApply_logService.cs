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
    public class JD_IcItemPlanBGApply_logService
    {
        JD_IcItemPlanBGApply_logDal dal = new JD_IcItemPlanBGApply_logDal();

        public void UpdateInfo()
        {
            dal.UpdateInfo();
        }
    }
}
