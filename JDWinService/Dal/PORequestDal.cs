using JDWinService.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDWinService.Utils;
namespace JDWinService.Dal
{
    public class PORequestDal
    {
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息

        public void UpdateClose(int FInterID)
        {
            string sql = string.Format(@" update PORequest set FClosed=1 where FInterID={0}", FInterID);
            DBUtil.ExecuteSql(sql, K3connectionString);
        }
    }
}
