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
    public class MaterialService
    {
        MaterialDal dal = new MaterialDal();
        public void IcItemAdd(string APIUrl, string APICode)
        {
            dal.IcItemAdd(  APIUrl, APICode); 
        }
    }
}
