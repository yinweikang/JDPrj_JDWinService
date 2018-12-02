using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDWinService.Dal;
using System.Data;
namespace JDWinService.Services
{
    public class JD_PORequest_DelService
    {
        JD_PORequest_DelDal dal = new JD_PORequest_DelDal();
        public DataView GetDistinct()
        {
            return dal.GetDistinct();
        }

        /// <summary>
        /// 处理请购单中需要删除的数据
        /// 2018 09 04
        /// </summary>
        /// <param name="FInterID"></param>
        public void HandleDel(string FInterID, string TaskID)
        {
            dal.HandleDel(FInterID, TaskID);
        }
    }
}
