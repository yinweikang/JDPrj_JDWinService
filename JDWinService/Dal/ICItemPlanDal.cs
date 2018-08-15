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
    
    public class ICItemPlanDal
    {
        Common common = new Common();
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息

        /// <summary>
		/// 对象t_ICItemPlan明细
		/// 编写人：ywk
		/// 编写日期：2018/7/24 星期二
		/// </summary>
		public ICItemPlan Detail(string FNumber)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand(" SELECT  *  FROM t_ICItemPlan where FItemID in(select FItemID from t_ICItem where FNumber =@m_FNumber)", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = FNumber;

            ICItemPlan myDetail = new  ICItemPlan();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["FItemID"])) { myDetail.FItemID = Convert.ToInt32(myReader["FItemID"]); }
                if (!Convert.IsDBNull(myReader["FPlanTrategy"])) { myDetail.FPlanTrategy = Convert.ToInt32(myReader["FPlanTrategy"]); }
                if (!Convert.IsDBNull(myReader["FOrderTrategy"])) { myDetail.FOrderTrategy = Convert.ToInt32(myReader["FOrderTrategy"]); }
            
                if (!Convert.IsDBNull(myReader["FTotalTQQ"])) { myDetail.FTotalTQQ = Convert.ToInt32(myReader["FTotalTQQ"]); }
                if (!Convert.IsDBNull(myReader["FQtyMin"])) { myDetail.FQtyMin = Convert.ToDecimal(myReader["FQtyMin"]); }
                if (!Convert.IsDBNull(myReader["FQtyMax"])) { myDetail.FQtyMax = Convert.ToDecimal(myReader["FQtyMax"]); }
                if (!Convert.IsDBNull(myReader["FCUUnitID"])) { myDetail.FCUUnitID = Convert.ToInt32(myReader["FCUUnitID"]); }
                if (!Convert.IsDBNull(myReader["FOrderInterVal"])) { myDetail.FOrderInterVal = Convert.ToInt32(myReader["FOrderInterVal"]); }
                if (!Convert.IsDBNull(myReader["FBatchAppendQty"])) { myDetail.FBatchAppendQty = Convert.ToDecimal(myReader["FBatchAppendQty"]); }
                if (!Convert.IsDBNull(myReader["FOrderPoint"])) { myDetail.FOrderPoint = Convert.ToDecimal(myReader["FOrderPoint"]); }
                if (!Convert.IsDBNull(myReader["FBatFixEconomy"])) { myDetail.FBatFixEconomy = Convert.ToDecimal(myReader["FBatFixEconomy"]); }
                if (!Convert.IsDBNull(myReader["FBatChangeEconomy"])) { myDetail.FBatChangeEconomy = Convert.ToDecimal(myReader["FBatChangeEconomy"]); }
                if (!Convert.IsDBNull(myReader["FRequirePoint"])) { myDetail.FRequirePoint = Convert.ToInt32(myReader["FRequirePoint"]); }
                if (!Convert.IsDBNull(myReader["FPlanPoint"])) { myDetail.FPlanPoint = Convert.ToInt32(myReader["FPlanPoint"]); }
                if (!Convert.IsDBNull(myReader["FDefaultRoutingID"])) { myDetail.FDefaultRoutingID = Convert.ToInt32(myReader["FDefaultRoutingID"]); }
                if (!Convert.IsDBNull(myReader["FDefaultWorkTypeID"])) { myDetail.FDefaultWorkTypeID = Convert.ToInt32(myReader["FDefaultWorkTypeID"]); }
                if (!Convert.IsDBNull(myReader["FProductPrincipal"])) { myDetail.FProductPrincipal = Convert.ToInt32(myReader["FProductPrincipal"]); }
                if (!Convert.IsDBNull(myReader["FDailyConsume"])) { myDetail.FDailyConsume = Convert.ToDecimal(myReader["FDailyConsume"]); }
                if (!Convert.IsDBNull(myReader["FMRPCon"])) { myDetail.FMRPCon = Convert.ToBoolean(myReader["FMRPCon"]); }
                if (!Convert.IsDBNull(myReader["FPlanner"])) { myDetail.FPlanner = Convert.ToInt32(myReader["FPlanner"]); }
                if (!Convert.IsDBNull(myReader["FPutInteger"])) { myDetail.FPutInteger = Convert.ToBoolean(myReader["FPutInteger"]); }
                if (!Convert.IsDBNull(myReader["FInHighLimit"])) { myDetail.FInHighLimit = Convert.ToDecimal(myReader["FInHighLimit"]); }
                if (!Convert.IsDBNull(myReader["FInLowLimit"])) { myDetail.FInLowLimit = Convert.ToDecimal(myReader["FInLowLimit"]); }
                if (!Convert.IsDBNull(myReader["FLowestBomCode"])) { myDetail.FLowestBomCode = Convert.ToInt32(myReader["FLowestBomCode"]); }
                if (!Convert.IsDBNull(myReader["FMRPOrder"])) { myDetail.FMRPOrder = Convert.ToBoolean(myReader["FMRPOrder"]); }
                if (!Convert.IsDBNull(myReader["FIsCharSourceItem"])) { myDetail.FIsCharSourceItem = Convert.ToInt32(myReader["FIsCharSourceItem"]); }
                if (!Convert.IsDBNull(myReader["FCharSourceItemID"])) { myDetail.FCharSourceItemID = Convert.ToInt32(myReader["FCharSourceItemID"]); }
                if (!Convert.IsDBNull(myReader["FPlanMode"])) { myDetail.FPlanMode = Convert.ToInt32(myReader["FPlanMode"]); }
                if (!Convert.IsDBNull(myReader["FCtrlType"])) { myDetail.FCtrlType = Convert.ToInt32(myReader["FCtrlType"]); }
                if (!Convert.IsDBNull(myReader["FCtrlStraregy"])) { myDetail.FCtrlStraregy = Convert.ToInt32(myReader["FCtrlStraregy"]); }
                if (!Convert.IsDBNull(myReader["FContainerName"])) { myDetail.FContainerName = Convert.ToString(myReader["FContainerName"]); }
                if (!Convert.IsDBNull(myReader["FKanBanCapability"])) { myDetail.FKanBanCapability = Convert.ToInt32(myReader["FKanBanCapability"]); }
                if (!Convert.IsDBNull(myReader["FIsBackFlush"])) { myDetail.FIsBackFlush = Convert.ToInt32(myReader["FIsBackFlush"]); }
                if (!Convert.IsDBNull(myReader["FBackFlushStockID"])) { myDetail.FBackFlushStockID = Convert.ToInt32(myReader["FBackFlushStockID"]); }
                if (!Convert.IsDBNull(myReader["FBackFlushSPID"])) { myDetail.FBackFlushSPID = Convert.ToInt32(myReader["FBackFlushSPID"]); }
                if (!Convert.IsDBNull(myReader["FBatchSplitDays"])) { myDetail.FBatchSplitDays = Convert.ToInt32(myReader["FBatchSplitDays"]); }
                if (!Convert.IsDBNull(myReader["FBatchSplit"])) { myDetail.FBatchSplit = Convert.ToDecimal(myReader["FBatchSplit"]); }
                if (!Convert.IsDBNull(myReader["FIsFixedReOrder"])) { myDetail.FIsFixedReOrder = Convert.ToBoolean(myReader["FIsFixedReOrder"]); }
                if (!Convert.IsDBNull(myReader["FAuxInMrpCal"])) { myDetail.FAuxInMrpCal = Convert.ToBoolean(myReader["FAuxInMrpCal"]); }
                if (!Convert.IsDBNull(myReader["FProductDesigner"])) { myDetail.FProductDesigner = Convert.ToInt32(myReader["FProductDesigner"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        public void UpdateInLimitApply(string MOQ, string PPQ, string FNumber) {
            string sql = string.Format(@" update t_ICItemPlan set Fqtymin='{0}', FBatchAppendQty='{1}'
									where FItemID in(select FItemID from t_ICItem where FNumber='{2}')", MOQ, PPQ, FNumber);
            DBUtil.ExecuteSql(sql, K3connectionString);
        }
    }
}
