using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDWinService.Dal;
using System.Data;

namespace JDWinService.Services
{
    public class JD_PORequest_LogService
    {
        JD_PORequest_LogDal dal = new JD_PORequest_LogDal();
        public void UpdatePORequest(int ItemID, string FileName) {
            //dal.UpdatePORequest( ItemID,  FileName);
        }
        public void UpdatePORequest_Apply(int ItemID, string FileName,int TaskID)
        {
            dal.UpdatePORequest_Apply( ItemID,  FileName,TaskID);
        }

        public void UpdatePORequest_NumBG(int ItemID, string FileName,int TaskID) {
            dal.UpdatePORequest_NumBG(ItemID, FileName,TaskID);
        }
        public DataView GetDistinctList() {
            return dal.GetDistinctList();
        }
    }
}
