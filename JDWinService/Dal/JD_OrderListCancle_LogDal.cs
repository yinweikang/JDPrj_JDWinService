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
    public class JD_OrderListCancle_LogDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息
        Common common = new Common();
        public void OrderListCancle()
        {
            try
            {
                //轮询整单取消的
                //轮询订单行取消的
            }
            catch (Exception ex)
            {

            }
            finally { }
        }
        /// <summary>
        /// 采购订单取消-整单取消  ywk 2018-11-28
        /// </summary>
        /// <param name="APIUrl"></param>
        /// <param name="Token"></param>
        public void CancleList(string APIUrl, string Token)
        {
            #region 选择数据源
            string sql = string.Format(@"select distinct TaskID,FBillNo from JD_OrderListCancle_Log where IsUpdate=0 and CancleType='整单取消'");
            DataView dv = DBUtil.Query(sql, connectionString).Tables[0].DefaultView;
            #endregion

            foreach (DataRowView dr in dv)
            {
                string ErrorMsg = string.Empty;
                try
                {
                    #region 集成前 反审核 行关闭标志和关闭标志 都为N
                    UpdateBillClose(dr["FInterID"].ToString());
                    #endregion
                    #region API集成删除
                    string SendJson = "{\"data\":[{\"FBillNo\":\""+dr["FBillNo"] +"\"}]}";
                    string loginUrl = APIUrl + "PO" + "/Delete?Token=" + Token;
                    Result result2 = common.SendToK3(loginUrl, SendJson);
                    if (result2.StatusCode == "200")
                    {
                        common.AddLogQueue(Convert.ToInt32(dr["TaskID"].ToString()), "JD_OrderListCancle_Log", 0, "API", "K3集成成功!", true);
                    }
                    else {
                        common.AddLogQueue(Convert.ToInt32(dr["TaskID"].ToString()), "JD_OrderListCancle_Log", 0, "API", "K3集成失败!失败原因:"+ result2.Message, false);
                    }
                    #endregion 
                    #region 更新日志表
                    sql = string.Format(@" Update JD_OrderListCancle_Log set IsUpdate='1',UpdateTime='{1}' where TaskID='{0}'", dr["TaskID"].ToString(),DateTime.Now.ToString("yyyy-MM-dd"));
                    DBUtil.ExecuteSql(sql, connectionString);
                    #endregion
                }
                catch (Exception ex)
                {
                    ErrorMsg = ex.Message;
                }
                finally
                {
                    if (!string.IsNullOrEmpty(ErrorMsg))
                    {
                        common.AddLogQueue(Convert.ToInt32(dr["TaskID"].ToString()), "JD_OrderListCancle_Log", 0, "SQL", ErrorMsg, false);
                    } 
                }
            }

        }

        /// <summary>
        /// 采购订单取消-行取消
        /// </summary>
        public void CancleDetailLits()
        {
            #region 选择数据源
            string sql = string.Format(@"select * from JD_OrderListCancle_Log where IsUpdate=0 and CancleType='订单行取消'");
            DataView dv = DBUtil.Query(sql, connectionString).Tables[0].DefaultView;
            #endregion

            foreach (DataRowView dr in dv)
            {
                try {

                }
                catch (Exception ex) { }
                finally { }
            }
        }

        //采购订单行关闭标志，表头关闭标志 N
        protected void UpdateBillClose(string FInterID)
        {
            string sql = string.Format(@" update poorderentry set FMrpClosed='N' where FInterID='{0}'", FInterID);
            DBUtil.ExecuteSql(sql, K3connectionString);
            sql = string.Format(@" update poorder set FHeadSelfP0252='N' where FInteID='{0}'", FInterID);
            DBUtil.ExecuteSql(sql, K3connectionString);
        }
        /// <summary>
        /// 对象JD_OrderListCancle_Log明细
        /// 编写人：ywk
        /// 编写日期：2018/11/28 星期三
        /// </summary>
        protected JD_OrderListCancle_Log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_OrderListCancle_Log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_OrderListCancle_Log myDetail = new JD_OrderListCancle_Log();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["SN"])) { myDetail.SN = Convert.ToString(myReader["SN"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["CancleType"])) { myDetail.CancleType = Convert.ToString(myReader["CancleType"]); }
                if (!Convert.IsDBNull(myReader["DetailCancleType"])) { myDetail.DetailCancleType = Convert.ToString(myReader["DetailCancleType"]); }
                if (!Convert.IsDBNull(myReader["IsUpdate"])) { myDetail.IsUpdate = Convert.ToInt32(myReader["IsUpdate"]); }
                if (!Convert.IsDBNull(myReader["FInterID"])) { myDetail.FInterID = Convert.ToString(myReader["FInterID"]); }
                if (!Convert.IsDBNull(myReader["FEntryID"])) { myDetail.FEntryID = Convert.ToString(myReader["FEntryID"]); }
                if (!Convert.IsDBNull(myReader["CreateTime"])) { myDetail.CreateTime = Convert.ToDateTime(myReader["CreateTime"]); }
                if (!Convert.IsDBNull(myReader["UpdateTime"])) { myDetail.UpdateTime = Convert.ToDateTime(myReader["UpdateTime"]); }
                if (!Convert.IsDBNull(myReader["Operater"])) { myDetail.Operater = Convert.ToString(myReader["Operater"]); }
                if (!Convert.IsDBNull(myReader["OperateTime"])) { myDetail.OperateTime = Convert.ToDateTime(myReader["OperateTime"]); }
                if (!Convert.IsDBNull(myReader["SupplierName"])) { myDetail.SupplierName = Convert.ToString(myReader["SupplierName"]); }
                if (!Convert.IsDBNull(myReader["SupplierCode"])) { myDetail.SupplierCode = Convert.ToString(myReader["SupplierCode"]); }
                if (!Convert.IsDBNull(myReader["AllPrice"])) { myDetail.AllPrice = Convert.ToDecimal(myReader["AllPrice"]); }
                if (!Convert.IsDBNull(myReader["BGName"])) { myDetail.BGName = Convert.ToString(myReader["BGName"]); }
                if (!Convert.IsDBNull(myReader["FBillNo"])) { myDetail.FBillNo = Convert.ToString(myReader["FBillNo"]); }
                if (!Convert.IsDBNull(myReader["Attachments"])) { myDetail.Attachments = Convert.ToString(myReader["Attachments"]); }
                if (!Convert.IsDBNull(myReader["WuLiaoNum"])) { myDetail.WuLiaoNum = Convert.ToString(myReader["WuLiaoNum"]); }
                if (!Convert.IsDBNull(myReader["GuiGe"])) { myDetail.GuiGe = Convert.ToString(myReader["GuiGe"]); }
                if (!Convert.IsDBNull(myReader["FAuxQty"])) { myDetail.FAuxQty = Convert.ToDecimal(myReader["FAuxQty"]); }
                if (!Convert.IsDBNull(myReader["Count"])) { myDetail.Count = Convert.ToDecimal(myReader["Count"]); }
                if (!Convert.IsDBNull(myReader["Unit"])) { myDetail.Unit = Convert.ToString(myReader["Unit"]); }
                if (!Convert.IsDBNull(myReader["FAuxPrice"])) { myDetail.FAuxPrice = Convert.ToDecimal(myReader["FAuxPrice"]); }
                if (!Convert.IsDBNull(myReader["Price"])) { myDetail.Price = Convert.ToDecimal(myReader["Price"]); }
                if (!Convert.IsDBNull(myReader["ActualPrice"])) { myDetail.ActualPrice = Convert.ToDecimal(myReader["ActualPrice"]); }
                if (!Convert.IsDBNull(myReader["SendDate"])) { myDetail.SendDate = Convert.ToDateTime(myReader["SendDate"]); }
                if (!Convert.IsDBNull(myReader["FDate"])) { myDetail.FDate = Convert.ToDateTime(myReader["FDate"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0267"])) { myDetail.FEntrySelfP0267 = Convert.ToDateTime(myReader["FEntrySelfP0267"]); }
                if (!Convert.IsDBNull(myReader["FirstConfirmDate"])) { myDetail.FirstConfirmDate = Convert.ToDateTime(myReader["FirstConfirmDate"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0268"])) { myDetail.FEntrySelfP0268 = Convert.ToDateTime(myReader["FEntrySelfP0268"]); }
                if (!Convert.IsDBNull(myReader["LastConfirmDate"])) { myDetail.LastConfirmDate = Convert.ToDateTime(myReader["LastConfirmDate"]); }
                if (!Convert.IsDBNull(myReader["FPOHighPrice"])) { myDetail.FPOHighPrice = Convert.ToDecimal(myReader["FPOHighPrice"]); }
                if (!Convert.IsDBNull(myReader["FPrice"])) { myDetail.FPrice = Convert.ToDecimal(myReader["FPrice"]); }
                if (!Convert.IsDBNull(myReader["FCoefficient"])) { myDetail.FCoefficient = Convert.ToDecimal(myReader["FCoefficient"]); }
                if (!Convert.IsDBNull(myReader["FLinkCount"])) { myDetail.FLinkCount = Convert.ToDecimal(myReader["FLinkCount"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        /// <summary>
        /// 更新JD_OrderListCancle_Log对象
        /// 编写人：ywk
        /// 编写日期：2018/11/28 星期三
        /// </summary>
        protected void Update(JD_OrderListCancle_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_OrderListCancle_Log SET SN = @m_SN,TaskID = @m_TaskID,CancleType = @m_CancleType,DetailCancleType = @m_DetailCancleType,IsUpdate = @m_IsUpdate,FInterID = @m_FInterID,FEntryID = @m_FEntryID,CreateTime = @m_CreateTime,UpdateTime = @m_UpdateTime,Operater = @m_Operater,OperateTime = @m_OperateTime,SupplierName = @m_SupplierName,SupplierCode = @m_SupplierCode,AllPrice = @m_AllPrice,BGName = @m_BGName,FBillNo = @m_FBillNo,Attachments = @m_Attachments,WuLiaoNum = @m_WuLiaoNum,GuiGe = @m_GuiGe,FAuxQty = @m_FAuxQty,Count = @m_Count,Unit = @m_Unit,FAuxPrice = @m_FAuxPrice,Price = @m_Price,ActualPrice = @m_ActualPrice,SendDate = @m_SendDate,FDate = @m_FDate,FEntrySelfP0267 = @m_FEntrySelfP0267,FirstConfirmDate = @m_FirstConfirmDate,FEntrySelfP0268 = @m_FEntrySelfP0268,LastConfirmDate = @m_LastConfirmDate,FPOHighPrice = @m_FPOHighPrice,FPrice = @m_FPrice,FCoefficient = @m_FCoefficient,FLinkCount = @m_FLinkCount WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.SN == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SN", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SN", SqlDbType.NVarChar, 50)).Value = model.SN;
            }
            if (model.TaskID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = model.TaskID;
            }
            if (model.CancleType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CancleType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CancleType", SqlDbType.NVarChar, 50)).Value = model.CancleType;
            }
            if (model.DetailCancleType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_DetailCancleType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_DetailCancleType", SqlDbType.NVarChar, 50)).Value = model.DetailCancleType;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.Int, 0)).Value = model.IsUpdate;
            }
            if (model.FInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInterID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInterID", SqlDbType.NVarChar, 50)).Value = model.FInterID;
            }
            if (model.FEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntryID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntryID", SqlDbType.NVarChar, 50)).Value = model.FEntryID;
            }
            if (model.CreateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = model.CreateTime;
            }
            if (model.UpdateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_UpdateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_UpdateTime", SqlDbType.DateTime, 0)).Value = model.UpdateTime;
            }
            if (model.Operater == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = model.Operater;
            }
            if (model.OperateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_OperateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_OperateTime", SqlDbType.DateTime, 0)).Value = model.OperateTime;
            }
            if (model.SupplierName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierName", SqlDbType.NVarChar, 50)).Value = model.SupplierName;
            }
            if (model.SupplierCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierCode", SqlDbType.NVarChar, 50)).Value = model.SupplierCode;
            }
            if (model.AllPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AllPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AllPrice", SqlDbType.Decimal, 18)).Value = model.AllPrice;
            }
            if (model.BGName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BGName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BGName", SqlDbType.NVarChar, 50)).Value = model.BGName;
            }
            if (model.FBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.NVarChar, 50)).Value = model.FBillNo;
            }
            if (model.Attachments == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Attachments", SqlDbType.NVarChar, 300)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Attachments", SqlDbType.NVarChar, 300)).Value = model.Attachments;
            }
            if (model.WuLiaoNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_WuLiaoNum", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_WuLiaoNum", SqlDbType.NVarChar, 50)).Value = model.WuLiaoNum;
            }
            if (model.GuiGe == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_GuiGe", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_GuiGe", SqlDbType.NVarChar, 500)).Value = model.GuiGe;
            }
            if (model.FAuxQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQty", SqlDbType.Decimal, 18)).Value = model.FAuxQty;
            }
            if (model.Count == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Count", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Count", SqlDbType.Decimal, 18)).Value = model.Count;
            }
            if (model.Unit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Unit", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Unit", SqlDbType.NVarChar, 50)).Value = model.Unit;
            }
            if (model.FAuxPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 18)).Value = model.FAuxPrice;
            }
            if (model.Price == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Price", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Price", SqlDbType.Decimal, 18)).Value = model.Price;
            }
            if (model.ActualPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ActualPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ActualPrice", SqlDbType.Decimal, 18)).Value = model.ActualPrice;
            }
            if (model.SendDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_SendDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SendDate", SqlDbType.DateTime, 0)).Value = model.SendDate;
            }
            if (model.FDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = model.FDate;
            }
            if (model.FEntrySelfP0267 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0267", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0267", SqlDbType.DateTime, 0)).Value = model.FEntrySelfP0267;
            }
            if (model.FirstConfirmDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FirstConfirmDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FirstConfirmDate", SqlDbType.DateTime, 0)).Value = model.FirstConfirmDate;
            }
            if (model.FEntrySelfP0268 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0268", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0268", SqlDbType.DateTime, 0)).Value = model.FEntrySelfP0268;
            }
            if (model.LastConfirmDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_LastConfirmDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_LastConfirmDate", SqlDbType.DateTime, 0)).Value = model.LastConfirmDate;
            }
            if (model.FPOHighPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPOHighPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPOHighPrice", SqlDbType.Decimal, 18)).Value = model.FPOHighPrice;
            }
            if (model.FPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPrice", SqlDbType.Decimal, 18)).Value = model.FPrice;
            }
            if (model.FCoefficient == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCoefficient", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCoefficient", SqlDbType.Decimal, 18)).Value = model.FCoefficient;
            }
            if (model.FLinkCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLinkCount", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLinkCount", SqlDbType.Decimal, 18)).Value = model.FLinkCount;
            }
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID;

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }




    }
}
