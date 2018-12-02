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
    public class JD_Supplier_LogService
    {
        JD_Supplier_LogDal dal = new JD_Supplier_LogDal();
        public DataView GetDistinct()
        {
            return dal.GetDistinct();
        }

        public void HandleSupplier(int ItemID, string APIUrl, string FuncName, string Token, string FileType, string ApplyType,int IsCGSupplier)
        {
            #region 采购杂项供应商
            if (IsCGSupplier == 1)
            {
                switch (ApplyType)
                {
                    case "1":  //新增
                        dal.SupplierAdd(ItemID, APIUrl, FuncName, Token, FileType);
                        break;
                    case "2":  //变更 
                    case "3": //撤销
                        dal.UpdateCGSupplier(ItemID, ApplyType);
                        break;

                }
            }
            #endregion
            #region 普通供应商
            else
            {
                switch (ApplyType)
                {
                    //新增
                    case "1":
                        dal.SupplierAdd(ItemID, APIUrl, FuncName, Token, FileType);
                        break;
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                        dal.UpdateSupplier(ItemID, ApplyType);
                        break;
                    default: break;
                }
            }
            #endregion

        }
        public void SupplierAdd(int ItemID, string APIUrl, string FuncName, string Token, string FileType)
        {
              dal.SupplierAdd(ItemID,  APIUrl,  FuncName,  Token,  FileType);
        }
    }
}
