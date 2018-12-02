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
    public class JD_IcItemBGApply_LogDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息 
        Common common = new Common();
        /// <summary>
		/// 对象JD_IcItemBGApply_Log明细
		/// 编写人：ywk
		/// 编写日期：2018/9/19 星期三
		/// </summary>
		protected JD_IcItemBGApply_Log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_IcItemBGApply_Log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_IcItemBGApply_Log myDetail = new JD_IcItemBGApply_Log();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["FItemID"])) { myDetail.FItemID = Convert.ToInt32(myReader["FItemID"]); }
                if (!Convert.IsDBNull(myReader["Requester"])) { myDetail.Requester = Convert.ToString(myReader["Requester"]); }
                if (!Convert.IsDBNull(myReader["CreateTime"])) { myDetail.CreateTime = Convert.ToDateTime(myReader["CreateTime"]); }
                if (!Convert.IsDBNull(myReader["RequestDept"])) { myDetail.RequestDept = Convert.ToString(myReader["RequestDept"]); }
                if (!Convert.IsDBNull(myReader["SNumber"])) { myDetail.SNumber = Convert.ToString(myReader["SNumber"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["FNumber"])) { myDetail.FNumber = Convert.ToString(myReader["FNumber"]); }
                if (!Convert.IsDBNull(myReader["FModel"])) { myDetail.FModel = Convert.ToString(myReader["FModel"]); }
                if (!Convert.IsDBNull(myReader["FQtyMin"])) { myDetail.FQtyMin = Convert.ToDecimal(myReader["FQtyMin"]); }
                if (!Convert.IsDBNull(myReader["FQtyMinNew"])) { myDetail.FQtyMinNew = Convert.ToDecimal(myReader["FQtyMinNew"]); }
                if (!Convert.IsDBNull(myReader["FBatchAppendQty"])) { myDetail.FBatchAppendQty = Convert.ToDecimal(myReader["FBatchAppendQty"]); }
                if (!Convert.IsDBNull(myReader["FBatchAppendQtyNew"])) { myDetail.FBatchAppendQtyNew = Convert.ToDecimal(myReader["FBatchAppendQtyNew"]); }
                if (!Convert.IsDBNull(myReader["FFixLeadTime"])) { myDetail.FFixLeadTime = Convert.ToInt32(myReader["FFixLeadTime"]); }
                if (!Convert.IsDBNull(myReader["FFixLeadTimeNew"])) { myDetail.FFixLeadTimeNew = Convert.ToInt32(myReader["FFixLeadTimeNew"]); }
                if (!Convert.IsDBNull(myReader["PackageInfo"])) { myDetail.PackageInfo = Convert.ToString(myReader["PackageInfo"]); }
                if (!Convert.IsDBNull(myReader["PackageInfoNew"])) { myDetail.PackageInfoNew = Convert.ToString(myReader["PackageInfoNew"]); }
                if (!Convert.IsDBNull(myReader["PriceCoeffient"])) { myDetail.PriceCoeffient = Convert.ToDouble(myReader["PriceCoeffient"]); }
                if (!Convert.IsDBNull(myReader["PriceCoeffientNew"])) { myDetail.PriceCoeffientNew = Convert.ToDouble(myReader["PriceCoeffientNew"]); }
                if (!Convert.IsDBNull(myReader["Remarks"])) { myDetail.Remarks = Convert.ToString(myReader["Remarks"]); }
                if (!Convert.IsDBNull(myReader["IsUpdate"])) { myDetail.IsUpdate = Convert.ToInt32(myReader["IsUpdate"]); }
                if (!Convert.IsDBNull(myReader["UpdateTime"])) { myDetail.UpdateTime = Convert.ToDateTime(myReader["UpdateTime"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        /// <summary>
        /// 更新JD_IcItemBGApply_Log对象
        /// 编写人：ywk
        /// 编写日期：2018/9/19 星期三
        /// </summary>
        protected void Update(JD_IcItemBGApply_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_IcItemBGApply_Log SET FItemID = @m_FItemID,Requester = @m_Requester,CreateTime = @m_CreateTime,RequestDept = @m_RequestDept,SNumber = @m_SNumber,TaskID = @m_TaskID,FNumber = @m_FNumber,FModel = @m_FModel,FQtyMin = @m_FQtyMin,FQtyMinNew = @m_FQtyMinNew,FBatchAppendQty = @m_FBatchAppendQty,FBatchAppendQtyNew = @m_FBatchAppendQtyNew,FFixLeadTime = @m_FFixLeadTime,FFixLeadTimeNew = @m_FFixLeadTimeNew,PackageInfo = @m_PackageInfo,PackageInfoNew = @m_PackageInfoNew,PriceCoeffient = @m_PriceCoeffient,PriceCoeffientNew = @m_PriceCoeffientNew,Remarks = @m_Remarks,IsUpdate = @m_IsUpdate,UpdateTime = @m_UpdateTime WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.FItemID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FItemID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FItemID", SqlDbType.Int, 0)).Value = model.FItemID;
            }
            if (model.Requester == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Requester", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Requester", SqlDbType.NVarChar, 50)).Value = model.Requester;
            }
            if (model.CreateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = model.CreateTime;
            }
            if (model.RequestDept == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestDept", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestDept", SqlDbType.NVarChar, 50)).Value = model.RequestDept;
            }
            if (model.SNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = model.SNumber;
            }
            if (model.TaskID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = model.TaskID;
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
            if (model.FQtyMin == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyMin", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyMin", SqlDbType.Decimal, 18)).Value = model.FQtyMin;
            }
            if (model.FQtyMinNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyMinNew", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyMinNew", SqlDbType.Decimal, 18)).Value = model.FQtyMinNew;
            }
            if (model.FBatchAppendQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchAppendQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchAppendQty", SqlDbType.Decimal, 18)).Value = model.FBatchAppendQty;
            }
            if (model.FBatchAppendQtyNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchAppendQtyNew", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchAppendQtyNew", SqlDbType.Decimal, 18)).Value = model.FBatchAppendQtyNew;
            }
            if (model.FFixLeadTime == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFixLeadTime", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFixLeadTime", SqlDbType.Int, 0)).Value = model.FFixLeadTime;
            }
            if (model.FFixLeadTimeNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFixLeadTimeNew", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFixLeadTimeNew", SqlDbType.Int, 0)).Value = model.FFixLeadTimeNew;
            }
            if (model.PackageInfo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PackageInfo", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PackageInfo", SqlDbType.NVarChar, 100)).Value = model.PackageInfo;
            }
            if (model.PackageInfoNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PackageInfoNew", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PackageInfoNew", SqlDbType.NVarChar, 100)).Value = model.PackageInfoNew;
            }
            if (model.PriceCoeffient == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PriceCoeffient", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PriceCoeffient", SqlDbType.Float, 0)).Value = model.PriceCoeffient;
            }
            if (model.PriceCoeffientNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PriceCoeffientNew", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PriceCoeffientNew", SqlDbType.Float, 0)).Value = model.PriceCoeffientNew;
            }
            if (model.Remarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Remarks", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Remarks", SqlDbType.NVarChar, 100)).Value = model.Remarks;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.Int, 0)).Value = model.IsUpdate;
            }
            if (model.UpdateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_UpdateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_UpdateTime", SqlDbType.DateTime, 0)).Value = model.UpdateTime;
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
            string sql = string.Format(@" select * from JD_IcItemBGApply_Log where IsUpdate='0'");
            return DBUtil.Query(sql, connectionString).Tables[0].DefaultView;
        }

        protected void UpdateK3Item(string FItemID,string FQtyMin, string FBatchAppendQty, string FFixLeadTime, string PackageInfo, string PriceCoffient)
        {
            //更新t_ICItemplan 中的fqtymin ,FBatchAppendQty,FFixLeadTime
            string sql = string.Format(@"update t_ICItemplan set fqtymin='{0}',FBatchAppendQty='{1}',FFixLeadTime='{2}' where fitemid='{3}'",
                FQtyMin, FBatchAppendQty, FFixLeadTime, FItemID);
            DBUtil.ExecuteSql(sql, K3connectionString);
            common.WriteLogs("UpdateK3Item 1:"+sql);

            //2018-11-09 
            //更新物料的最大订单量 触发条件 最小订单量大于等于最大订单量  最大订单量设为999999
            sql = string.Format(@"update t_ICItemplan set FQtyMax='999999' where fqtymin>FQtyMax and fitemid='{0}'", FItemID);
            DBUtil.ExecuteSql(sql, K3connectionString);
            common.WriteLogs("UpdateK3Item 3:" + sql);

            //更新t_ICItemCustom中的F_116,F_112
            sql = string.Format(@" update t_ICItemCustom set F_116='{0}',F_112='{1}' where fitemid='{2}'", PriceCoffient, PackageInfo, FItemID);
            DBUtil.ExecuteSql(sql,K3connectionString);
            common.WriteLogs("UpdateK3Item 2:" + sql);

            
        }


        protected void UpdateInfo(string ItemID)
        {
            JD_IcItemBGApply_Log model = Detail(Convert.ToInt32(ItemID));
            string ErrorMsg = string.Empty;
            if (model != null)
            {
                try {
                    //更新最小订购量 批量增量   固定提前期   包装量说明 物料单价系数
                    string FQtyMin = Math.Round(Convert.ToDecimal(model.FQtyMinNew), 10).ToString();
                    string FBatchAppendQty = Math.Round(Convert.ToDecimal(model.FBatchAppendQtyNew), 10).ToString();
                    UpdateK3Item(model.FItemID.ToString(), FQtyMin, FBatchAppendQty, model.FFixLeadTimeNew.ToString(), model.PackageInfoNew, model.PriceCoeffientNew.ToString());
                    //更新本地阶梯价的MOQ PPQ LT
                    UpdateCuPriceDetail(model.FNumber, model.FQtyMinNew, model.FBatchAppendQtyNew, model.FFixLeadTimeNew);
                }
                catch (Exception ex)
                {
                    ErrorMsg = ex.Message;
                }
                finally {
                    model.IsUpdate = 1;
                    model.UpdateTime = DateTime.Now;
                    Update(model);
                    common.AddLogQueue(model.TaskID, "JD_IcItemBGApply_Log", model.ItemID, "SQL", ErrorMsg);
                }
            }
        }

        public void UpdateItemBySupply()
        {
            DataView dv = GetDistinct();
            if (dv.Count > 0)
            {
                foreach (DataRowView dr in dv)
                {
                    UpdateInfo(dr["ItemID"].ToString());
                }
            }
        }

        protected void UpdateCuPriceDetail(string ItemCode, decimal MOQ, decimal PPQ, decimal Limits)
        {
            string sql = string.Format(@" update JD_CuPriceDetail set MOQ='{0}',PPQ='{1}',LimitTimes='{2}' where ItemCode='{3}'",
                                     MOQ.ToString(), PPQ.ToString(), Limits.ToString(), ItemCode);
            DBUtil.Execute(sql);
        }
    }
}
