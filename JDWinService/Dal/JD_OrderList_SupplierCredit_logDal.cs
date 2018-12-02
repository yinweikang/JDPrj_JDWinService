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
   public class JD_OrderList_SupplierCredit_logDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        public static string K3ConnectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息
        public static string CreditRoleName= ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["CreditRoleName"].Value;
        Common common = new Common();
        /// <summary>
        /// 对象JD_OrderList_SupplierCredit_log明细
        /// 编写人：ywk
        /// 编写日期：2018/10/19 星期五
        /// </summary>
        public JD_OrderList_SupplierCredit_log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_OrderList_SupplierCredit_log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_OrderList_SupplierCredit_log myDetail = new JD_OrderList_SupplierCredit_log();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {


                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["SNumber"])) { myDetail.SNumber = Convert.ToString(myReader["SNumber"]); }
                if (!Convert.IsDBNull(myReader["SupplierCode"])) { myDetail.SupplierCode = Convert.ToString(myReader["SupplierCode"]); }
                if (!Convert.IsDBNull(myReader["SupplierName"])) { myDetail.SupplierName = Convert.ToString(myReader["SupplierName"]); }
                if (!Convert.IsDBNull(myReader["IsUpdate"])) { myDetail.IsUpdate = Convert.ToInt32(myReader["IsUpdate"]); }
                if (!Convert.IsDBNull(myReader["IsBeyond"])) { myDetail.IsBeyond = Convert.ToInt32(myReader["IsBeyond"]); }
                if (!Convert.IsDBNull(myReader["UpdateTime"])) { myDetail.UpdateTime = Convert.ToDateTime(myReader["UpdateTime"]); }
                if (!Convert.IsDBNull(myReader["ProcessName"])) { myDetail.ProcessName = Convert.ToString(myReader["ProcessName"]); }
                if (!Convert.IsDBNull(myReader["Requester"])) { myDetail.Requester = Convert.ToString(myReader["Requester"]); }
                if (!Convert.IsDBNull(myReader["RequestDate"])) { myDetail.RequestDate = Convert.ToDateTime(myReader["RequestDate"]); }


            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        /// <summary>
        /// 更新JD_OrderList_SupplierCredit_log对象
        /// 编写人：ywk
        /// 编写日期：2018/10/19 星期五
        /// </summary>
        public void Update(JD_OrderList_SupplierCredit_log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_OrderList_SupplierCredit_log SET TaskID = @m_TaskID,SNumber = @m_SNumber,SupplierCode = @m_SupplierCode,SupplierName = @m_SupplierName,IsUpdate = @m_IsUpdate,IsBeyond = @m_IsBeyond,UpdateTime = @m_UpdateTime,ProcessName = @m_ProcessName,Requester = @m_Requester,RequestDate = @m_RequestDate WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.TaskID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = model.TaskID;
            }
            if (model.SNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = model.SNumber;
            }
            if (model.SupplierCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierCode", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierCode", SqlDbType.NVarChar, 100)).Value = model.SupplierCode;
            }
            if (model.SupplierName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SupplierName", SqlDbType.NVarChar, 100)).Value = model.SupplierName;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.Int, 0)).Value = model.IsUpdate;
            }
            if (model.IsBeyond == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsBeyond", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsBeyond", SqlDbType.Int, 0)).Value = model.IsBeyond;
            }
            if (model.UpdateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_UpdateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_UpdateTime", SqlDbType.DateTime, 0)).Value = model.UpdateTime;
            }
            if (model.ProcessName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ProcessName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ProcessName", SqlDbType.NVarChar, 100)).Value = model.ProcessName;
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
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID; 

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }


        public void SendBeyondMsg()
        {
            DataView dv = GetDistinct();
            if (dv.Count > 0)
            {

                foreach (DataRowView dr in dv)
                {
                    string ErrorMsg = string.Empty;
                    int TaskID = Convert.ToInt32(dr["TaskID"].ToString());
                    int ItemID= Convert.ToInt32(dr["ItemID"].ToString());
                    string FNumber = dr["SupplierCode"].ToString();
                    JD_OrderList_SupplierCredit_log logmodel = Detail(ItemID);
                    string Title = string.Empty;
                    StringBuilder Content = new StringBuilder() ;
                  
                    try
                    {
                        //比较同一供应商的订单未付金额和信用额度  
                        if (logmodel != null&&!string.IsNullOrEmpty(FNumber))
                        {
                            double UnPayPrice = GetUnPayPrice(FNumber);
                            double CreditPrice = GetCreditPrice(FNumber);
                          
                            //如果大于信用额度的90% 发送邮件给采购部和供应链部负责人
                            if (UnPayPrice >= (CreditPrice * 0.9))
                            {
                                #region 插入邮件通知队列
                                double Percent = (UnPayPrice * 100) / CreditPrice;
                                string EMails = GetEMails(); //AAA;BBB
                                #region 邮件标题和内容
                                if (String.IsNullOrEmpty(EMails))
                                {
                                    throw new Exception("负责人的邮箱地址为空！");
                                }
                                else
                                {
                                    Title = "[BPM系统提示]供应商："+ logmodel.SupplierName+ "现有额度比为"+ Math.Round(Percent,2) + "%,即将到达限额，请及时查看";
                                    Content.Append("业务名:" + logmodel.ProcessName + "<br/>");
                                    Content.Append("提交人:" + logmodel.Requester + "<br/>");
                                    Content.Append("提交日期:" + logmodel.RequestDate.ToString("yyyy-MM-dd") + "<br/>");
                                    Content.Append("流水号:" + logmodel.SNumber + "<br/>");
                                    Content.Append("内容摘要:<br/>");
                                    Content.Append("供应商名称:" + logmodel.SupplierName + "<br/>");
                                    Content.Append("预定未付金额:" + UnPayPrice + "<br/>");
                                    Content.Append("信用额度:" + CreditPrice + "<br/>");
                                   
                                }
                                #endregion

                                #region 插入队列
                                BPMSysMessagesQueueDal MsgDal = new BPMSysMessagesQueueDal();
                                foreach (string Email in EMails.Split(';'))
                                {
                                    MsgDal.Add(new BPMSysMessagesQueue
                                    {
                                        ProviderName = "Mail",
                                        Address = Email,
                                        Title = Title,
                                        Message = Content.ToString(),
                                        CreateAt = DateTime.Now,
                                        FailCount = 0
                                    });
                                }
                                #endregion

                                logmodel.IsBeyond = 1;
                                #endregion
                            }
                        }
                        else
                        {
                            throw new Exception("对象不存在！");
                        }
                    }
                    catch (Exception ex)
                    {
                        ErrorMsg = ex.Message;
                    }
                    finally
                    {
                        logmodel.IsUpdate = 1;
                        logmodel.UpdateTime = DateTime.Now;
                        Update(logmodel);
                        //集成日志
                        common.AddLogQueue(TaskID, "JD_OrderList_SupplierCredit_log", ItemID, "SQL", ErrorMsg);
                    }
                }
               
            }
        }

        //获取订单未付金额
        protected double GetUnPayPrice(string FNumber)
        {
            double UnPayPrice = Convert.ToDouble("0");
            string sql = string.Format(@"select OrderUnPayPrice  from vw_bpm_SupplierCredit where FNumber='{0}' ", FNumber);
            object obj = DBUtil.GetSingle(sql, K3ConnectionString);
            if (obj != null)
            {
                UnPayPrice = Convert.ToDouble(obj.ToString());
            }
            return UnPayPrice;
        }

        //获取供应商信用额度
        protected double GetCreditPrice(string FNumber)
        {
            double CreditPrice = Convert.ToDouble("0");
            string sql = string.Format(@"select IsNull(XinYongED,0) as Credit  from JD_Supplier_mng where FNumber='{0}' ", FNumber);
            object obj = DBUtil.GetSingle(sql, connectionString);
            if (obj != null)
            {
                CreditPrice = Convert.ToDouble(obj.ToString());
            }
            return CreditPrice;
        }

        //获取需要轮询的数据
        protected DataView GetDistinct()
        {
            string sql = string.Format(@" select * from JD_OrderList_SupplierCredit_log where IsUpdate='0'");
            return DBUtil.Query(sql).Tables[0].DefaultView;
        }

        //获取负责人邮箱信息  AAAA;BBB
        protected string GetEMails()
        {
            string[] RoleNames = CreditRoleName.Split('@');
            string AccountStr = string.Empty;
            string Filter = string.Empty;
            if (RoleNames.Length > 0)
            {
                int Count = 0;
                foreach (string Role in RoleNames)
                {

                    if (Count == 0)
                    {
                        Filter += " and RoleName='"+Role+"' ";
                    }
                    else
                    {
                        Filter += " or RoleName='" + Role + "' ";
                    }
                    Count++;
                }
               
            }
            string sql = string.Format(@" select * from dbo.BPMSysUsers where Account in(
                                        select UserAccount from dbo.BPMSysOURoleMembers where 1=1 {0}
                                        ) ", Filter);
            DataView dv = DBUtil.Query(sql, connectionString).Tables[0].DefaultView;
            foreach (DataRowView dr in dv)
            {
                AccountStr += dr["EMail"].ToString() + ";";
            }
            return AccountStr.TrimEnd(';');
        }

    }
 
}
