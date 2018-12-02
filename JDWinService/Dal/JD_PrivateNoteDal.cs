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
    public class JD_PrivateNoteDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息

        public bool IsExist(int TaskID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM JD_PrivateNote WHERE TaskID = @m_TaskID", con);
            con.Open();
            cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = TaskID;

            bool b = false;
            try
            {
                int count = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (count > 0) b = true;
            }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
            return b;
        }


          

        /// <summary>
        /// 新增JD_PrivateNote对象
        /// 编写人：ywk
        /// 编写日期：2018/11/29 星期四
        /// </summary>
        public int Add(JD_PrivateNote model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO JD_PrivateNote(TaskID,SNumber,ProcessName,Submiter,SubmitDate,CreateDate,IsCheck,BelongDept,Remarks,RejectReason) VALUES(@m_TaskID,@m_SNumber,@m_ProcessName,@m_Submiter,@m_SubmitDate,@m_CreateDate,@m_IsCheck,@m_BelongDept,@m_Remarks,@m_RejectReason) SELECT @thisId=@@IDENTITY FROM JD_PrivateNote", con);
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
            if (model.ProcessName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ProcessName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ProcessName", SqlDbType.NVarChar, 50)).Value = model.ProcessName;
            }
            if (model.Submiter == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Submiter", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Submiter", SqlDbType.NVarChar, 50)).Value = model.Submiter;
            }
            if (model.SubmitDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_SubmitDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SubmitDate", SqlDbType.DateTime, 0)).Value = model.SubmitDate;
            }
            if (model.CreateDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateDate", SqlDbType.DateTime, 0)).Value = model.CreateDate;
            }
            if (model.IsCheck == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsCheck", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsCheck", SqlDbType.Int, 0)).Value = model.IsCheck;
            }
            if (model.BelongDept == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BelongDept", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BelongDept", SqlDbType.NVarChar, 50)).Value = model.BelongDept;
            }
            if (model.Remarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Remarks", SqlDbType.NText, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Remarks", SqlDbType.NText, 0)).Value = model.Remarks;
            }
            if (model.RejectReason == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_RejectReason", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_RejectReason", SqlDbType.NVarChar, 500)).Value = model.RejectReason;
            }

            //输出参数
            SqlParameter returnParam = cmd.Parameters.Add(new SqlParameter("@thisId", SqlDbType.Int));
            returnParam.Direction = ParameterDirection.Output;
            int returnId = -1;

            try
            {
                cmd.ExecuteScalar();
                returnId = Convert.ToInt32(cmd.Parameters["@thisId"].Value);
            }
            catch (Exception e) { throw new Exception(e.ToString()); }

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return returnId;
        }


        /// <summary>
        /// 轮询是否有新被拒绝的供应链流程
        /// 如果有 新增到备忘录表中
        /// </summary>
        public void AddNewNote()
        {
            DataView dv = GetData();
            int Task = 0;
            BPMInstTasksDal taskdal = new BPMInstTasksDal();
            BPMInstTasks taskmodel = new BPMInstTasks();
         
            foreach (DataRowView dr in dv)
            {
                Task = Convert.ToInt32(dr["TaskID"].ToString());
                taskmodel = taskdal.Detail(Task);
                if (!IsExist(Task))
                {
                    Add(new JD_PrivateNote
                    {
                        TaskID = Task,
                        SNumber = taskmodel.SerialNum,
                        ProcessName = taskmodel.ProcessName,
                        Submiter = taskmodel.OwnerAccount,
                        SubmitDate = taskmodel.CreateAt,
                        IsCheck = 0,
                        BelongDept = "供应链部",
                        RejectReason = GetRejectComment(dr["TaskID"].ToString())
                    });
                }
              
            }
        }

        /// <summary>
        /// 获取供应链被拒绝的流程信息
        /// </summary>
        /// <returns></returns>
        protected DataView GetData()
        {
            string sql = string.Format(@"select * from(
                                            select * from dbo.BPMInstTasks where 
                                            ProcessName='供应商新增与变更' 
                                            or ProcessName='采购单价限价申请单'  
                                            or ProcessName='物料基本信息维护流程')AA where AA.State='Rejected' 
                                            and AA.TaskID not in(select TaskID from JD_PrivateNote) ");
            return DBUtil.Query(sql, connectionString).Tables[0].DefaultView;
        }

        protected string GetRejectComment(string TaskID)
        {
            string sql = string.Format(@" select top 1 comments from dbo.BPMInstProcSteps 
                            where TaskID=''
                            order by StepID desc");
            Object obj = DBUtil.GetSingle(sql, connectionString);
            string ReturnMsg = "";
            if (obj != null)
            {
                ReturnMsg = obj.ToString();
            }
            return ReturnMsg;
        }
    }
}
