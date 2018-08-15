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

    public class JD_OrderListBG_LogDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息

        Common common = new Common();
        POOrderEntryDal dal = new POOrderEntryDal();
        /// <summary>
		/// 对象JD_OrderListBG_Log明细
		/// 编写人：ywk
		/// 编写日期：2018/8/8 星期三
		/// </summary>
		public JD_OrderListBG_Log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_OrderListBG_Log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_OrderListBG_Log myDetail = new JD_OrderListBG_Log();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["IsUpdate"])) { myDetail.IsUpdate = Convert.ToInt32(myReader["IsUpdate"]); }
                if (!Convert.IsDBNull(myReader["CreateTime"])) { myDetail.CreateTime = Convert.ToDateTime(myReader["CreateTime"]); }
                if (!Convert.IsDBNull(myReader["UpdateTime"])) { myDetail.UpdateTime = Convert.ToDateTime(myReader["UpdateTime"]); }
                if (!Convert.IsDBNull(myReader["Operater"])) { myDetail.Operater = Convert.ToString(myReader["Operater"]); }
                if (!Convert.IsDBNull(myReader["OperateTime"])) { myDetail.OperateTime = Convert.ToDateTime(myReader["OperateTime"]); }
                if (!Convert.IsDBNull(myReader["SupplierName"])) { myDetail.SupplierName = Convert.ToString(myReader["SupplierName"]); }
                if (!Convert.IsDBNull(myReader["SupplierCode"])) { myDetail.SupplierCode = Convert.ToString(myReader["SupplierCode"]); }
                if (!Convert.IsDBNull(myReader["BGType"])) { myDetail.BGType = Convert.ToString(myReader["BGType"]); }
                if (!Convert.IsDBNull(myReader["AllPrice"])) { myDetail.AllPrice = Convert.ToDecimal(myReader["AllPrice"]); }
                if (!Convert.IsDBNull(myReader["BGName"])) { myDetail.BGName = Convert.ToString(myReader["BGName"]); }
                if (!Convert.IsDBNull(myReader["FBillNo"])) { myDetail.FBillNo = Convert.ToString(myReader["FBillNo"]); }
                if (!Convert.IsDBNull(myReader["SN"])) { myDetail.SN = Convert.ToString(myReader["SN"]); }
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
                if (!Convert.IsDBNull(myReader["BGMarks"])) { myDetail.BGMarks = Convert.ToString(myReader["BGMarks"]); }
                if (!Convert.IsDBNull(myReader["FInterID"])) { myDetail.FInterID = Convert.ToString(myReader["FInterID"]); }
                if (!Convert.IsDBNull(myReader["FEntryID"])) { myDetail.FEntryID = Convert.ToString(myReader["FEntryID"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0267"])) { myDetail.FEntrySelfP0267 = Convert.ToDateTime(myReader["FEntrySelfP0267"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0268"])) { myDetail.FEntrySelfP0268 = Convert.ToDateTime(myReader["FEntrySelfP0268"]); }
                if (!Convert.IsDBNull(myReader["FPOHighPrice"])) { myDetail.FPOHighPrice = Convert.ToDecimal(myReader["FPOHighPrice"]); }
                if (!Convert.IsDBNull(myReader["FPrice"])) { myDetail.FPrice = Convert.ToDecimal(myReader["FPrice"]); }
                if (!Convert.IsDBNull(myReader["FCoefficient"])) { myDetail.FCoefficient = Convert.ToDecimal(myReader["FCoefficient"]); }
                if (!Convert.IsDBNull(myReader["FLinkCount"])) { myDetail.FLinkCount = Convert.ToDecimal(myReader["FLinkCount"]); }
                if (!Convert.IsDBNull(myReader["OrderListBGName"])) { myDetail.OrderListBGName = Convert.ToString(myReader["OrderListBGName"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }



        /// <summary>
        /// 更新JD_OrderListBG_Log对象
        /// 编写人：ywk
        /// 编写日期：2018/8/8 星期三
        /// </summary>
        public void Update(JD_OrderListBG_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_OrderListBG_Log SET TaskID = @m_TaskID,IsUpdate = @m_IsUpdate,CreateTime = @m_CreateTime,UpdateTime = @m_UpdateTime,Operater = @m_Operater,OperateTime = @m_OperateTime,SupplierName = @m_SupplierName,SupplierCode = @m_SupplierCode,BGType = @m_BGType,AllPrice = @m_AllPrice,BGName = @m_BGName,FBillNo = @m_FBillNo,SN = @m_SN,Attachments = @m_Attachments,WuLiaoNum = @m_WuLiaoNum,GuiGe = @m_GuiGe,FAuxQty = @m_FAuxQty,Count = @m_Count,Unit = @m_Unit,FAuxPrice = @m_FAuxPrice,Price = @m_Price,ActualPrice = @m_ActualPrice,SendDate = @m_SendDate,FDate = @m_FDate,BGMarks = @m_BGMarks,FInterID = @m_FInterID,FEntryID = @m_FEntryID,FEntrySelfP0267 = @m_FEntrySelfP0267,FEntrySelfP0268 = @m_FEntrySelfP0268,FPOHighPrice = @m_FPOHighPrice,FPrice = @m_FPrice,FCoefficient = @m_FCoefficient,FLinkCount = @m_FLinkCount,OrderListBGName = @m_OrderListBGName WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.TaskID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = model.TaskID;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.Int, 0)).Value = model.IsUpdate;
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
            if (model.BGType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BGType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BGType", SqlDbType.NVarChar, 50)).Value = model.BGType;
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
            if (model.SN == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SN", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SN", SqlDbType.NVarChar, 50)).Value = model.SN;
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
            if (model.BGMarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BGMarks", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BGMarks", SqlDbType.NVarChar, 500)).Value = model.BGMarks;
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
            if (model.FEntrySelfP0267 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0267", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0267", SqlDbType.DateTime, 0)).Value = model.FEntrySelfP0267;
            }
            if (model.FEntrySelfP0268 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0268", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0268", SqlDbType.DateTime, 0)).Value = model.FEntrySelfP0268;
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
            if (model.OrderListBGName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderListBGName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderListBGName", SqlDbType.NVarChar, 50)).Value = model.OrderListBGName;
            }
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID;

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        public void UpdateStatus(int TaskID)
        {
            string sql = string.Format(@"update JD_OrderListBG_Log set IsUpdate='1' where TaskID='{0}'", TaskID.ToString());
            DBUtil.ExecuteSql(sql);
        }

        public DataView GetDistinctList()
        {
            string sql = string.Format(@" select distinct TaskID,BGName,OrderListBGName from JD_OrderListBG_Log where IsUpdate='0' ");
            return DBUtil.Query(sql).Tables[0].DefaultView;
        }

        protected DataTable GetLogList(string TaskID, string OrderListBGName)
        {
            string sql = string.Format(@" select * from JD_OrderListBG_Log where IsUpdate='0' and TaskID='" + TaskID + "' and OrderListBGName='" + OrderListBGName + "' ");
            return DBUtil.Query(sql).Tables[0];
        }



        /// <summary>
        /// 采购订单物料变更
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="BGName"></param>
        public void UpdatePOEntry(string TaskID, string BGName)
        {
            //选出需要变更的数据
            DataTable dt = GetLogList(TaskID, "WL");
            string ErrorMsg = string.Empty;
            try
            {
                if (dt.Rows.Count > 0)
                {
                    switch (BGName)
                    {
                        case "数量变更":
                            Update_SL(dt);
                            break;
                        case "价格变更":
                            Update_JG(dt);
                            break;
                        case "交期变更":
                            Update_JQ(dt, TaskID);
                            break;
                        default:
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
                common.WriteLogs(Common.FileType.采购订单_物料.ToString(), "-----Error-----");
                common.WriteLogs(Common.FileType.采购订单_物料.ToString(), ex.Message);
                common.WriteLogs(Common.FileType.采购订单_物料.ToString(), "-----Error-----");
            }
            finally
            {
                if (!string.IsNullOrEmpty(ErrorMsg))
                {
                    common.AddLogQueue(Convert.ToInt32(TaskID), "JD_OrderListBG_Log", 0, "SQL", ErrorMsg, false);
                }
                else
                {
                    common.AddLogQueue(Convert.ToInt32(TaskID), "JD_OrderListBG_Log", 0, "SQL", "操作成功", true);
                }
                UpdateStatus(TaskID);
            }


        }

        public void UpdateNPIPOEntry(string TaskID)
        {
             
            try
            {
                DataTable dt = GetLogList(TaskID, "NPI");
                Update_NPI(dt, TaskID);
            }
            catch (Exception ex)
            {
                common.WriteLogs("采购订单NPI变更Error:" + ex.Message);
            }
            finally
            {
                UpdateStatus(TaskID);
            }

        }


        protected void Update_SL(DataTable dt)
        {
            POOrderEntry model = new POOrderEntry();
            string tempsql = string.Empty;
            string sql = string.Empty;
            int FInterID = 0;
            int FEntryID = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (!string.IsNullOrEmpty(dr["WuLiaoNum"].ToString()))
                {
                    FInterID = Convert.ToInt32(dr["FInterID"].ToString());
                    FEntryID = Convert.ToInt32(dr["FEntryID"].ToString());
                    model = dal.Detail(FInterID, FEntryID);
                    model.FAuxQty = Math.Round(Convert.ToDecimal(dr["FAuxQty"].ToString()), 10); //数量更新
                    model = LastUpdateModel(model);
                    dal.Update(model);
                }
            }
        }
        /// <summary>
        /// 采购订单数量变更
        /// </summary>
        /// <param name="dt"></param> 
        protected void Update_FQty(DataTable dt, string TaskID)
        {
            POOrderEntry model = new POOrderEntry();
            string tempsql = string.Empty;
            string sql = string.Empty;
            int FInterID = 0;
            int FEntryID = 0;
            int Count = 0;
            decimal dateEmpty = Convert.ToDecimal("0");

            //判断是否有拆分的订单 
            DataView dvAll = dt.DefaultView;                                    //所有的数据集
            DataView dv = dt.DefaultView.ToTable(true, "FEntryID", "FInterID").DefaultView; //无重复的数据集

            foreach (DataRowView dr in dv)
            {

                //选出 FEntryID相同的数据集 大于1 被拆分 不然 未被拆分直接更新
                dvAll.RowFilter = " FEntryID='" + dr["FEntryID"] + "'";

                #region 订单已被拆分 需要更新并插入新的数据
                //行号  
                if (dvAll.Count > 1)
                {
                    Count = 0;
                    decimal FirstData = Convert.ToDecimal("0");
                    //遍历 FEntryID相同的数据集
                    foreach (DataRowView dr2 in dvAll)
                    {
                        FInterID = Convert.ToInt32(dr["FInterID"].ToString());
                        FEntryID = Convert.ToInt32(dr["FEntryID"].ToString());
                        //第一个数量
                        if (Count == 0)
                        {
                            //如果关联数量为0  更新数量为修改的数量 否则 更新数量为关联数量
                            if (Convert.ToDecimal(dvAll[0]["FLinkCount"].ToString()) == dateEmpty)
                            {
                                FirstData = Convert.ToDecimal(dr2["FAuxQty"]);
                            }
                            else
                            {
                                FirstData = Convert.ToDecimal(dvAll[0]["FLinkCount"].ToString());
                            }
                            Update_FQtyInner(FInterID, FEntryID, FirstData);

                            Count++;
                        }
                        //其余数量插入新的值
                        else
                        {
                            model = dal.Detail(FInterID, FEntryID);
                            POOrderEntry childMol = new POOrderEntry();
                            childMol = model;
                            childMol.FInterID = FInterID;
                            childMol.FEntryID = GetMaxFEntryID(FInterID.ToString());
                            childMol.FAuxQty = Convert.ToDecimal(dr2["FAuxQty"]);
                            childMol = LastUpdateModel(childMol);
                            dal.Add(childMol);
                        }

                        Count++;
                        //若关联数量
                    }
                }
                #endregion
                #region 订单未被拆分 只是更新数量
                else
                {
                    if (!string.IsNullOrEmpty(dr["WuLiaoNum"].ToString()))
                    {
                        Update_FQtyInner(Convert.ToInt32(dr["FInterID"].ToString()),
                            Convert.ToInt32(dr["FEntryID"].ToString()),
                            Math.Round(Convert.ToDecimal(dr["FAuxQty"].ToString()), 10));
                    }
                    //更新状态
                }
                #endregion

            }
            UpdateStatus(TaskID);
        }

        //数量更新
        protected void Update_FQtyInner(int FInterID, int FEntryID, decimal FAuxQty)
        {
            POOrderEntry model = new POOrderEntry();
            model = dal.Detail(FInterID, FEntryID);
            model.FAuxQty = Math.Round(FAuxQty, 10); //数量更新
            model = LastUpdateModel(model);
            dal.Update(model);
        }

        //状态更新
        protected void UpdateStatus(string TaskID)
        {
            string sql = string.Format(@"update JD_OrderListBG_Log set IsUpdate='{0}',UpdateTime='{1}' where TaskID='{2}' ",
                "1", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), TaskID);
            DBUtil.ExecuteSql(sql);
        }
        protected int GetMaxFEntryID(string FInterID)
        {
            string sql = string.Format(@"select MAX(FEntryID)+1 from POOrderEntry where FInterID='{0}'", FInterID);
            object obj = DBUtil.GetSingle(sql, K3connectionString);
            return (obj == null) ? 0 : int.Parse(obj.ToString());
        }


        //价格变更
        protected void Update_JG(DataTable dt)
        {
            POOrderEntry model = new POOrderEntry();
            string tempsql = string.Empty;
            string sql = string.Empty;
            int FInterID = 0;
            int FEntryID = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (!string.IsNullOrEmpty(dr["WuLiaoNum"].ToString()))
                {
                    //sql = string.Format(@"update POOrderEntry set FAuxPrice='{0}' where FInterID='{1}' and FEntryID='{2}'",
                    //            dr["FAuxPrice"].ToString(), dr["FInterID"].ToString(), dr["FEntryID"].ToString());
                    FInterID = Convert.ToInt32(dr["FInterID"].ToString());
                    FEntryID = Convert.ToInt32(dr["FEntryID"].ToString());
                    model = dal.Detail(FInterID, FEntryID);
                    model.FAuxPrice = Math.Round(Convert.ToDecimal(dr["FAuxPrice"].ToString()), 10); //价格变更
                    model = LastUpdateModel(model);
                    dal.Update(model);
                }

            }
        }

        /// <summary>
        /// 交期变更
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="TaskID">主表ID</param>
        protected void Update_JQ(DataTable dt, string TaskID)
        {
            POOrderEntryDal dal = new POOrderEntryDal();
            POOrderEntry old_model = new POOrderEntry();  //原始的采购订单明细
            //找出不重复的FEntryID  遍历
            string sql = "select distinct FEntryID  from dbo.JD_OrderListBG_Log where TaskID='" + TaskID + "' order by FEntryID asc";

            var FEntryIDs = DBUtil.Query(sql).Tables[0].AsEnumerable().Select(r => r["FEntryID"]).Distinct();
            foreach (var item in FEntryIDs)
            {
                DataRow[] dr = dt.Select("FEntryID='" + item.ToString() + "'", "FAuxQty desc");
                int Count = 0;
                foreach (DataRow datarow in dr)
                {
                    //更新
                    if (Count == 0)
                    {

                        old_model = dal.Detail(Convert.ToInt32(datarow["FInterID"].ToString()), Convert.ToInt32(item.ToString()));
                        if (!String.IsNullOrEmpty(datarow["FEntrySelfP0267"].ToString()))
                        {
                            old_model.FEntrySelfP0267 = Convert.ToDateTime(datarow["FEntrySelfP0267"].ToString());
                        }
                        if (!String.IsNullOrEmpty(datarow["FEntrySelfP0268"].ToString()))
                        {
                            old_model.FEntrySelfP0268 = Convert.ToDateTime(datarow["FEntrySelfP0268"].ToString());
                        }
                        if (!string.IsNullOrEmpty(datarow["FDate"].ToString()))
                        {
                            old_model.FDate = Convert.ToDateTime(datarow["FDate"].ToString());
                        }
                        old_model.FAuxQty = Math.Round(Convert.ToDecimal(datarow["FAuxQty"].ToString()), 10); //数量更新
                        old_model = LastUpdateModel(old_model);
                        dal.Update(old_model);
                    }
                    //插入
                    else
                    {

                        //获取拆分订单中首个明细
                        POOrderEntry model = dal.Detail(Convert.ToInt32(datarow["FInterID"]), Convert.ToInt32(item.ToString()));
                        //带出Max(FEntryID)
                        int MaxFEntryID = common.GetMaxID("FEntryID", "POOrderEntry", " where FInterID='" + datarow["FInterID"] + "' ");

                        model.FAuxQty = Math.Round(Convert.ToDecimal(datarow["FAuxQty"].ToString()), 10);
                        if (!String.IsNullOrEmpty(datarow["FEntrySelfP0267"].ToString()))
                        {
                            model.FEntrySelfP0267 = Convert.ToDateTime(datarow["FEntrySelfP0267"].ToString());
                        }
                        if (!String.IsNullOrEmpty(datarow["FEntrySelfP0268"].ToString()))
                        {
                            model.FEntrySelfP0268 = Convert.ToDateTime(datarow["FEntrySelfP0268"].ToString());
                        }
                        if (!string.IsNullOrEmpty(datarow["FDate"].ToString()))
                        {
                            model.FDate = Convert.ToDateTime(datarow["FDate"].ToString());
                        }
                        decimal zero = Convert.ToDecimal(0.00);

                        model.FEntryID = MaxFEntryID;  //行号更新
                        model.FCommitQty = model.FCheckAmount = model.FAuxCommitQty = model.FStockQty = model.FAuxStockQty = model.FQtyInvoice = model.FReceiveAmountFor_Commit = model.FReceiveAmount_Commit = model.FAuxQtyInvoice = model.FAuxReceiptQty = model.FReceiptQty = model.FAuxReturnQty = model.FReturnQty = model.FAmountExceptDisCount = model.FAllAmountExceptDisCount = zero;
                        model = LastUpdateModel(model);
                        dal.Add(model);

                    }

                    Count++;
                }

            }
        }

        //NPI变更
        protected void Update_NPI(DataTable dt, string TaskID)
        {

            POOrderEntryDal dal = new POOrderEntryDal();
            POOrderEntry old_model = new POOrderEntry();  //原始的采购订单明细

            string sql = "select distinct FEntryID  from dbo.JD_OrderListBG_Log where TaskID='" + TaskID + "' order by FEntryID asc"; 
            var FEntryIDs = DBUtil.Query(sql).Tables[0].AsEnumerable().Select(r => r["FEntryID"]).Distinct();
            foreach (var item in FEntryIDs)
            {
                DataRow[] dr = dt.Select("FEntryID='" + item.ToString() + "'", "FAuxQty desc");
                int Count = 0;
                foreach (DataRow datarow in dr)
                {
                    //更新
                    if (Count == 0)
                    {

                        old_model = dal.Detail(Convert.ToInt32(datarow["FInterID"].ToString()), Convert.ToInt32(item.ToString()));
                        if (!String.IsNullOrEmpty(datarow["FEntrySelfP0267"].ToString()))
                        {
                            old_model.FEntrySelfP0267 = Convert.ToDateTime(datarow["FEntrySelfP0267"].ToString());
                        }
                        if (!String.IsNullOrEmpty(datarow["FEntrySelfP0268"].ToString()))
                        {
                            old_model.FEntrySelfP0268 = Convert.ToDateTime(datarow["FEntrySelfP0268"].ToString());
                        }
                        if (!string.IsNullOrEmpty(datarow["FDate"].ToString()))
                        {
                            old_model.FDate = Convert.ToDateTime(datarow["FDate"].ToString());
                        }
                        old_model.FAuxQty = Math.Round(Convert.ToDecimal(datarow["FAuxQty"].ToString()), 10); //数量更新
                        old_model = LastUpdateModel(old_model);
                        dal.Update(old_model);
                    }
                    //插入
                    else
                    {

                        //获取拆分订单中首个明细
                        POOrderEntry model = dal.Detail(Convert.ToInt32(datarow["FInterID"]), Convert.ToInt32(item.ToString()));
                        //带出Max(FEntryID)
                        int MaxFEntryID = common.GetMaxID("FEntryID", "POOrderEntry", " where FInterID='" + datarow["FInterID"] + "' ");

                        model.FAuxQty = Math.Round(Convert.ToDecimal(datarow["FAuxQty"].ToString()), 10);
                        if (!String.IsNullOrEmpty(datarow["FEntrySelfP0267"].ToString()))
                        {
                            model.FEntrySelfP0267 = Convert.ToDateTime(datarow["FEntrySelfP0267"].ToString());
                        }
                        if (!String.IsNullOrEmpty(datarow["FEntrySelfP0268"].ToString()))
                        {
                            model.FEntrySelfP0268 = Convert.ToDateTime(datarow["FEntrySelfP0268"].ToString());
                        }
                        if (!string.IsNullOrEmpty(datarow["FDate"].ToString()))
                        {
                            model.FDate = Convert.ToDateTime(datarow["FDate"].ToString());
                        }
                        decimal zero = Convert.ToDecimal(0.00);

                        model.FEntryID = MaxFEntryID;  //行号更新
                        model.FCommitQty = model.FCheckAmount = model.FAuxCommitQty = model.FStockQty = model.FAuxStockQty = model.FQtyInvoice = model.FReceiveAmountFor_Commit = model.FReceiveAmount_Commit = model.FAuxQtyInvoice = model.FAuxReceiptQty = model.FReceiptQty = model.FAuxReturnQty = model.FReturnQty = model.FAmountExceptDisCount = model.FAllAmountExceptDisCount = zero;
                        model = LastUpdateModel(model);
                        dal.Add(model);

                    }

                    Count++;
                }


            }

        }
        protected DataTable MeasureUnit(string UnitName)
        {
            string Sql = string.Format(@" select FName,FCoefficient from t_measureUnit where FStandard='0' and FName='{0}' ", UnitName);
            return DBUtil.Query(Sql, K3connectionString).Tables[0];
        }

        //采购订单明细最后更新 更新相关基础信息
        protected POOrderEntry LastUpdateModel(POOrderEntry model)
        {

            #region   FQty数量初始化
            DataTable dtable = MeasureUnit(model.FUnitID.ToString());
            model.FPrice = model.FAuxPrice;
            if (dtable.Rows.Count > 0)
            {
                decimal FAuxQty = Convert.ToDecimal(model.FAuxQty); //数量变更时候 要初始值
                decimal Convertion = Convert.ToDecimal(dtable.Rows[0]["FCoefficient"].ToString());
                model.FQty = Math.Round(FAuxQty * Convertion, 10);
                model.FPrice= Math.Round(model.FAuxPrice * Convertion, 10);
            }
            else
            {
                model.FQty = model.FAuxQty;
            }
            #endregion
            decimal Fcess = Convert.ToDecimal(100.00);
            decimal Fcess2 = Convert.ToDecimal(100 + model.FCess) / Fcess;
            
            model.FAmount = Math.Round(model.FQty * model.FPrice, 2);
            model.FTaxAmount = Math.Round(model.FAmount * Math.Round(model.FCess / Fcess, 6), 2);
            model.FAllAmount = model.FAmount + model.FTaxAmount;



            model.FAuxTaxPrice = model.FPrice + model.FPrice * Math.Round(model.FCess / Fcess, 10);
            model.FTaxPrice = model.FAuxTaxPrice;

            model.FAuxPriceDiscount = model.FAuxTaxPrice;
            model.FPriceDiscount = model.FTaxPrice;

            model.FAllAmountExceptDisCount = model.FPriceDiscount * model.FQty;
            model.FAmountExceptDisCount = Math.Round(model.FAllAmountExceptDisCount / Fcess2, 4); 
            return model;
        }
    }
}
