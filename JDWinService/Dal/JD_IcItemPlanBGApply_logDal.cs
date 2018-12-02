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
    public class JD_IcItemPlanBGApply_logDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息 
        Common common = new Common();

        /// <summary>
		/// 对象JD_IcItemPlanBGApply_log明细
		/// 编写人：ywk
		/// 编写日期：2018/9/26 星期三
		/// </summary>
		public JD_IcItemPlanBGApply_log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_IcItemPlanBGApply_log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_IcItemPlanBGApply_log myDetail = new JD_IcItemPlanBGApply_log();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["FItemID"])) { myDetail.FItemID = Convert.ToInt32(myReader["FItemID"]); }
                if (!Convert.IsDBNull(myReader["FNumber"])) { myDetail.FNumber = Convert.ToString(myReader["FNumber"]); }
                if (!Convert.IsDBNull(myReader["FModel"])) { myDetail.FModel = Convert.ToString(myReader["FModel"]); }
                if (!Convert.IsDBNull(myReader["SNumber"])) { myDetail.SNumber = Convert.ToString(myReader["SNumber"]); }
                if (!Convert.IsDBNull(myReader["Requester"])) { myDetail.Requester = Convert.ToString(myReader["Requester"]); }
                if (!Convert.IsDBNull(myReader["RequestDate"])) { myDetail.RequestDate = Convert.ToDateTime(myReader["RequestDate"]); }
                if (!Convert.IsDBNull(myReader["fqtymin"])) { myDetail.fqtymin = Convert.ToDecimal(myReader["fqtymin"]); }
                if (!Convert.IsDBNull(myReader["fqtyminnew"])) { myDetail.fqtyminnew = Convert.ToDecimal(myReader["fqtyminnew"]); }
                if (!Convert.IsDBNull(myReader["FBatchAppendQty"])) { myDetail.FBatchAppendQty = Convert.ToDecimal(myReader["FBatchAppendQty"]); }
                if (!Convert.IsDBNull(myReader["FBatchAppendQtynew"])) { myDetail.FBatchAppendQtynew = Convert.ToDecimal(myReader["FBatchAppendQtynew"]); }
                if (!Convert.IsDBNull(myReader["FFixLeadTime"])) { myDetail.FFixLeadTime = Convert.ToInt32(myReader["FFixLeadTime"]); }
                if (!Convert.IsDBNull(myReader["FFixLeadTimenew"])) { myDetail.FFixLeadTimenew = Convert.ToInt32(myReader["FFixLeadTimenew"]); }
                if (!Convert.IsDBNull(myReader["Fsecinv"])) { myDetail.Fsecinv = Convert.ToDecimal(myReader["Fsecinv"]); }
                if (!Convert.IsDBNull(myReader["FsecinvNew"])) { myDetail.FsecinvNew = Convert.ToDecimal(myReader["FsecinvNew"]); }
                if (!Convert.IsDBNull(myReader["ProductLT"])) { myDetail.ProductLT = Convert.ToInt32(myReader["ProductLT"]); }
                if (!Convert.IsDBNull(myReader["ProductLTnew"])) { myDetail.ProductLTnew = Convert.ToInt32(myReader["ProductLTnew"]); }
                if (!Convert.IsDBNull(myReader["PPQ"])) { myDetail.PPQ = Convert.ToDouble(myReader["PPQ"]); }
                if (!Convert.IsDBNull(myReader["PPQnew"])) { myDetail.PPQnew = Convert.ToDouble(myReader["PPQnew"]); }
                if (!Convert.IsDBNull(myReader["PlanRemarks"])) { myDetail.PlanRemarks = Convert.ToString(myReader["PlanRemarks"]); }
                if (!Convert.IsDBNull(myReader["PlanRemarksnew"])) { myDetail.PlanRemarksnew = Convert.ToString(myReader["PlanRemarksnew"]); }
                if (!Convert.IsDBNull(myReader["MOQ"])) { myDetail.MOQ = Convert.ToInt32(myReader["MOQ"]); }
                if (!Convert.IsDBNull(myReader["MOQnew"])) { myDetail.MOQnew = Convert.ToInt32(myReader["MOQnew"]); }
                if (!Convert.IsDBNull(myReader["IsSMI"])) { myDetail.IsSMI = Convert.ToInt32(myReader["IsSMI"]); }
                if (!Convert.IsDBNull(myReader["Ferpclsid"])) { myDetail.Ferpclsid = Convert.ToInt32(myReader["Ferpclsid"]); }
                if (!Convert.IsDBNull(myReader["UpdateTime"])) { myDetail.UpdateTime = Convert.ToDateTime(myReader["UpdateTime"]); }
                if (!Convert.IsDBNull(myReader["IsUpdate"])) { myDetail.IsUpdate = Convert.ToInt32(myReader["IsUpdate"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        /// <summary>
        /// 更新JD_IcItemPlanBGApply_log对象
        /// 编写人：ywk
        /// 编写日期：2018/9/26 星期三
        /// </summary>
        public void Update(JD_IcItemPlanBGApply_log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_IcItemPlanBGApply_log SET TaskID = @m_TaskID,FItemID = @m_FItemID,FNumber = @m_FNumber,FModel = @m_FModel,SNumber = @m_SNumber,Requester = @m_Requester,RequestDate = @m_RequestDate,fqtymin = @m_fqtymin,fqtyminnew = @m_fqtyminnew,FBatchAppendQty = @m_FBatchAppendQty,FBatchAppendQtynew = @m_FBatchAppendQtynew,FFixLeadTime = @m_FFixLeadTime,FFixLeadTimenew = @m_FFixLeadTimenew,Fsecinv = @m_Fsecinv,FsecinvNew = @m_FsecinvNew,ProductLT = @m_ProductLT,ProductLTnew = @m_ProductLTnew,PPQ = @m_PPQ,PPQnew = @m_PPQnew,PlanRemarks = @m_PlanRemarks,PlanRemarksnew = @m_PlanRemarksnew,MOQ = @m_MOQ,MOQnew = @m_MOQnew,IsSMI = @m_IsSMI,Ferpclsid = @m_Ferpclsid,UpdateTime = @m_UpdateTime,IsUpdate = @m_IsUpdate WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.TaskID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = model.TaskID;
            }
            if (model.FItemID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FItemID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FItemID", SqlDbType.Int, 0)).Value = model.FItemID;
            }
            if (model.FNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = model.FNumber;
            }
            if (model.FModel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NText, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NText, 0)).Value = model.FModel;
            }
            if (model.SNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = model.SNumber;
            }
            if (model.Requester == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Requester", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Requester", SqlDbType.NVarChar, 50)).Value = model.Requester;
            }
            if (model.RequestDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestDate", SqlDbType.DateTime, 0)).Value = model.RequestDate;
            }
            if (model.fqtymin == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_fqtymin", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_fqtymin", SqlDbType.Decimal, 18)).Value = model.fqtymin;
            }
            if (model.fqtyminnew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_fqtyminnew", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_fqtyminnew", SqlDbType.Decimal, 18)).Value = model.fqtyminnew;
            }
            if (model.FBatchAppendQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchAppendQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchAppendQty", SqlDbType.Decimal, 18)).Value = model.FBatchAppendQty;
            }
            if (model.FBatchAppendQtynew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchAppendQtynew", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchAppendQtynew", SqlDbType.Decimal, 18)).Value = model.FBatchAppendQtynew;
            }
            if (model.FFixLeadTime == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFixLeadTime", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFixLeadTime", SqlDbType.Int, 0)).Value = model.FFixLeadTime;
            }
            if (model.FFixLeadTimenew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFixLeadTimenew", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFixLeadTimenew", SqlDbType.Int, 0)).Value = model.FFixLeadTimenew;
            }
            if (model.Fsecinv == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fsecinv", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fsecinv", SqlDbType.Decimal, 18)).Value = model.Fsecinv;
            }
            if (model.FsecinvNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FsecinvNew", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FsecinvNew", SqlDbType.Decimal, 18)).Value = model.FsecinvNew;
            }
            if (model.ProductLT == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ProductLT", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ProductLT", SqlDbType.Int, 0)).Value = model.ProductLT;
            }
            if (model.ProductLTnew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ProductLTnew", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ProductLTnew", SqlDbType.Int, 0)).Value = model.ProductLTnew;
            }
            if (model.PPQ == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PPQ", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PPQ", SqlDbType.Float, 0)).Value = model.PPQ;
            }
            if (model.PPQnew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PPQnew", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PPQnew", SqlDbType.Float, 0)).Value = model.PPQnew;
            }
            if (model.PlanRemarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanRemarks", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanRemarks", SqlDbType.NVarChar, 100)).Value = model.PlanRemarks;
            }
            if (model.PlanRemarksnew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanRemarksnew", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanRemarksnew", SqlDbType.NVarChar, 100)).Value = model.PlanRemarksnew;
            }
            if (model.MOQ == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.Int, 0)).Value = model.MOQ;
            }
            if (model.MOQnew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQnew", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQnew", SqlDbType.Int, 0)).Value = model.MOQnew;
            }
            if (model.IsSMI == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsSMI", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsSMI", SqlDbType.Int, 0)).Value = model.IsSMI;
            }
            if (model.Ferpclsid == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Ferpclsid", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Ferpclsid", SqlDbType.Int, 0)).Value = model.Ferpclsid;
            }
            if (model.UpdateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_UpdateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_UpdateTime", SqlDbType.DateTime, 0)).Value = model.UpdateTime;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.Int, 0)).Value = model.IsUpdate;
            }
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID;

            try { cmd.ExecuteNonQuery(); } 
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        protected DataView GetDistinct()
        {
            string sql = string.Format(@" select * from JD_IcItemPlanBGApply_log where IsUpdate='0'");
            return DBUtil.Query(sql, connectionString).Tables[0].DefaultView;
        }

        public void UpdateInfo()
        {
            
            DataView dv = GetDistinct();
            if (dv.Count > 0)
            {
                JD_IcItemPlanBGApply_log model = new JD_IcItemPlanBGApply_log();
                foreach (DataRowView dr in dv)
                {
                    string FItemID = dr["FItemID"].ToString();
                    int ItemID = Convert.ToInt32(dr["ItemID"].ToString());
                    model = Detail(ItemID);
                    string sql = string.Empty;
                    string ErrorMsg = string.Empty;
                    try {
                       
                        #region 普通的安全库存更新 
                        string FSECINV = Math.Round(model.FsecinvNew, 6).ToString();
                        sql = string.Format(@" update t_ICItemBase set FSECINV='{0}' where fitemid='{1}' ", FSECINV, FItemID.ToString());
                        DBUtil.ExecuteSql(sql, K3connectionString);
                        #endregion

                        #region 符合SMI条件更新
                        string IsSMI = !string.IsNullOrEmpty(model.IsSMI.ToString()) ? model.IsSMI.ToString() : "0";
                        if (IsSMI.Equals("1"))
                        {
                            string fqtyminNew = !string.IsNullOrEmpty(dr["fqtyminnew"].ToString()) ? dr["fqtyminnew"].ToString() : "0"; 
                            string FBatchAppendQtyNew = !string.IsNullOrEmpty(dr["FBatchAppendQtynew"].ToString()) ? dr["FBatchAppendQtynew"].ToString() : "0";
                          
                            fqtyminNew = Math.Round(Convert.ToDecimal(fqtyminNew), 6).ToString();
                            FBatchAppendQtyNew  = Math.Round(Convert.ToDecimal(FBatchAppendQtyNew), 6).ToString();
                          
                            sql = string.Format(@" update t_ICItemplan  set fqtymin='{0}' ,FBatchAppendQty='{1}' where FItemID='{2}'",
                                fqtyminNew, FBatchAppendQtyNew,  FItemID);
                            DBUtil.ExecuteSql(sql, K3connectionString);
                        }
                        #endregion

                        #region Ferpclsid==2 的更新
                        if (model.Ferpclsid == 2)
                        {
                            //固定提前期
                            sql = string.Format(@"update t_ICItemplan  set FFixLeadTime='{0}'   where FItemID='{1}' ", model.FFixLeadTimenew.ToString(), model.FItemID);
                            DBUtil.ExecuteSql(sql, K3connectionString);

                            //PPQ由工程部修改 2018-10-10  
                            //sql = string.Format(@" update t_icitemcustom set F_118='{0}',f_119='{1}',f_120='{2}',f_121='{3}' where FItemID='{4}' ",
                            //    model.ProductLTnew.ToString(), model.PPQnew.ToString(), model.PlanRemarksnew, model.MOQnew.ToString(), model.FItemID.ToString());

                            sql = string.Format(@" update t_icitemcustom set F_118='{0}' ,f_120='{1}',f_121='{2}' where FItemID='{3}' ",
                              model.ProductLTnew.ToString(), model.PlanRemarksnew, model.MOQnew.ToString(), model.FItemID.ToString());
                            DBUtil.ExecuteSql(sql, K3connectionString);
                        }
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        ErrorMsg = ex.Message;
                    }
                    finally {
                        model.IsUpdate = 1;
                        model.UpdateTime = DateTime.Now;
                        Update(model);
                        //显示到集成日志的应用中
                        common.AddLogQueue(model.TaskID, "JD_IcItemPlanBGApply_log", model.ItemID, "SQL", ErrorMsg);
                    }
                }
            } 
        }
    }
}
