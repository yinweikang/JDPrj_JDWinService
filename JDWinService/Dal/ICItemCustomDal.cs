using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using JDWinService.Utils;
using JDWinService.Model;
using System.Data.SqlClient;

namespace JDWinService.Dal
{
    /// <summary>
    /// K3 物料表
    /// </summary>
    public class ICItemCustomDal
    {
        Common common = new Common();
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息


        /// <summary>
		/// 对象t_ICItemCustom明细
		/// 编写人：ywk
		/// 编写日期：2018/7/24 星期二
		/// </summary>
		public ICItemCustom Detail(string FNumber)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("SELECT  *  FROM  t_ICItemCustom where FItemID in(select FItemID from t_ICItem where FNumber =@m_FNumber)", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = FNumber;

             ICItemCustom myDetail = new ICItemCustom();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["FItemID"])) { myDetail.FItemID = Convert.ToInt32(myReader["FItemID"]); }
                if (!Convert.IsDBNull(myReader["F_108"])) { myDetail.F_108 = Convert.ToString(myReader["F_108"]); }
                if (!Convert.IsDBNull(myReader["F_109"])) { myDetail.F_109 = Convert.ToString(myReader["F_109"]); }
                if (!Convert.IsDBNull(myReader["F_111"])) { myDetail.F_111 = Convert.ToInt32(myReader["F_111"]); }
                if (!Convert.IsDBNull(myReader["F_112"])) { myDetail.F_112 = Convert.ToString(myReader["F_112"]); }
                if (!Convert.IsDBNull(myReader["F_113"])) { myDetail.F_113 = Convert.ToInt32(myReader["F_113"]); }
                if (!Convert.IsDBNull(myReader["F_114"])) { myDetail.F_114 = Convert.ToString(myReader["F_114"]); }
                if (!Convert.IsDBNull(myReader["F_115"])) { myDetail.F_115 = Convert.ToString(myReader["F_115"]); }
                if (!Convert.IsDBNull(myReader["F_116"])) { myDetail.F_116 = Convert.ToDouble(myReader["F_116"]); }
                if (!Convert.IsDBNull(myReader["F_117"])) { myDetail.F_117 = Convert.ToString(myReader["F_117"]); }
                if (!Convert.IsDBNull(myReader["F_118"])) { myDetail.F_118 = Convert.ToInt32(myReader["F_118"]); }
                if (!Convert.IsDBNull(myReader["F_119"])) { myDetail.F_119 = Convert.ToDouble(myReader["F_119"]); }
                if (!Convert.IsDBNull(myReader["F_120"])) { myDetail.F_120 = Convert.ToString(myReader["F_120"]); }
                if (!Convert.IsDBNull(myReader["F_121"])) { myDetail.F_121 = Convert.ToInt32(myReader["F_121"]); }
                if (!Convert.IsDBNull(myReader["F_122"])) { myDetail.F_122 = Convert.ToDouble(myReader["F_122"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }
        public void UpdateInLimitApply( string PackageInfo,string FNumber) { 
            string sql = string.Format(@"update   t_ICItemCustom set F_112='{0}'
										where FItemID in(select FItemID from t_ICItem where FNumber='{1}')",
                                         PackageInfo, FNumber);
            DBUtil.ExecuteSql(sql, K3connectionString);
        }
    }
}
