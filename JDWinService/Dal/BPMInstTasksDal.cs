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
    public class BPMInstTasksDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        Common common = new Common();


        /// <summary>
        /// 对象BPMInstTasks明细
        /// 编写人：ywk
        /// 编写日期：2018/8/10 星期五
        /// </summary>
        public BPMInstTasks Detail(int TaskID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM BPMInstTasks WHERE TaskID = @m_TaskID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = TaskID;

            BPMInstTasks myDetail = new BPMInstTasks();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["ProcessName"])) { myDetail.ProcessName = Convert.ToString(myReader["ProcessName"]); }
                if (!Convert.IsDBNull(myReader["OwnerAccount"])) { myDetail.OwnerAccount = Convert.ToString(myReader["OwnerAccount"]); }
                if (!Convert.IsDBNull(myReader["AgentAccount"])) { myDetail.AgentAccount = Convert.ToString(myReader["AgentAccount"]); }
                if (!Convert.IsDBNull(myReader["CreateAt"])) { myDetail.CreateAt = Convert.ToDateTime(myReader["CreateAt"]); }
                if (!Convert.IsDBNull(myReader["Description"])) { myDetail.Description = Convert.ToString(myReader["Description"]); }
                if (!Convert.IsDBNull(myReader["FinishAt"])) { myDetail.FinishAt = Convert.ToDateTime(myReader["FinishAt"]); }
                if (!Convert.IsDBNull(myReader["State"])) { myDetail.State = Convert.ToString(myReader["State"]); }
                if (!Convert.IsDBNull(myReader["SerialNum"])) { myDetail.SerialNum = Convert.ToString(myReader["SerialNum"]); }
                if (!Convert.IsDBNull(myReader["OptUser"])) { myDetail.OptUser = Convert.ToString(myReader["OptUser"]); }
                if (!Convert.IsDBNull(myReader["OptAt"])) { myDetail.OptAt = Convert.ToDateTime(myReader["OptAt"]); }
                if (!Convert.IsDBNull(myReader["OptMemo"])) { myDetail.OptMemo = Convert.ToString(myReader["OptMemo"]); }
                if (!Convert.IsDBNull(myReader["FormDataSetID"])) { myDetail.FormDataSetID = Convert.ToInt32(myReader["FormDataSetID"]); }
                if (!Convert.IsDBNull(myReader["ExtYear"])) { myDetail.ExtYear = Convert.ToInt32(myReader["ExtYear"]); }
                if (!Convert.IsDBNull(myReader["ExtInitiator"])) { myDetail.ExtInitiator = Convert.ToString(myReader["ExtInitiator"]); }
                if (!Convert.IsDBNull(myReader["ExtDeleted"])) { myDetail.ExtDeleted = Convert.ToBoolean(myReader["ExtDeleted"]); }
                if (!Convert.IsDBNull(myReader["OwnerPositionID"])) { myDetail.OwnerPositionID = Convert.ToInt32(myReader["OwnerPositionID"]); }
                if (!Convert.IsDBNull(myReader["ParentTaskID"])) { myDetail.ParentTaskID = Convert.ToInt32(myReader["ParentTaskID"]); }
                if (!Convert.IsDBNull(myReader["ParentStepID"])) { myDetail.ParentStepID = Convert.ToInt32(myReader["ParentStepID"]); }
                if (!Convert.IsDBNull(myReader["ParentStepName"])) { myDetail.ParentStepName = Convert.ToString(myReader["ParentStepName"]); }
                if (!Convert.IsDBNull(myReader["ProcessVersion"])) { myDetail.ProcessVersion = Convert.ToString(myReader["ProcessVersion"]); }
                if (!Convert.IsDBNull(myReader["ParentServerIdentity"])) { myDetail.ParentServerIdentity = Convert.ToString(myReader["ParentServerIdentity"]); }
                if (!Convert.IsDBNull(myReader["ReturnToParent"])) { myDetail.ReturnToParent = Convert.ToBoolean(myReader["ReturnToParent"]); }
                if (!Convert.IsDBNull(myReader["UrlParams"])) { myDetail.UrlParams = Convert.ToString(myReader["UrlParams"]); }
                if (!Convert.IsDBNull(myReader["Context"])) { myDetail.Context = Convert.ToString(myReader["Context"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }

    }
}
