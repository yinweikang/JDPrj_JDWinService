using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using JDWinService.Utils;
using System;
using JDWinService.Model;
using System.Data.SqlClient;

namespace JDWinService.Dal
{
    public class PPOrderDal
    {
        Common common = new Common();
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息
        /// <summary>
		/// 对象PPOrder明细
		/// 编写人：ywk
		/// 编写日期：2018/7/5 星期四
		/// </summary>
		public PPOrder Detail(int FInterID)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM PPOrder WHERE FInterID = @m_FInterID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_FInterID", SqlDbType.Int, 0)).Value = FInterID;

            PPOrder myDetail = new PPOrder();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["FBrNo"])) { myDetail.FBrNo = Convert.ToString(myReader["FBrNo"]); }
                if (!Convert.IsDBNull(myReader["FInterID"])) { myDetail.FInterID = Convert.ToInt32(myReader["FInterID"]); }
                if (!Convert.IsDBNull(myReader["FBillNo"])) { myDetail.FBillNo = Convert.ToString(myReader["FBillNo"]); }
                if (!Convert.IsDBNull(myReader["FTranType"])) { myDetail.FTranType = Convert.ToInt32(myReader["FTranType"]); }
                if (!Convert.IsDBNull(myReader["FDate"])) { myDetail.FDate = Convert.ToDateTime(myReader["FDate"]); }
                if (!Convert.IsDBNull(myReader["FBillerID"])) { myDetail.FBillerID = Convert.ToInt32(myReader["FBillerID"]); }
                if (!Convert.IsDBNull(myReader["FCheckerID"])) { myDetail.FCheckerID = Convert.ToInt32(myReader["FCheckerID"]); }
                if (!Convert.IsDBNull(myReader["FCheckDate"])) { myDetail.FCheckDate = Convert.ToDateTime(myReader["FCheckDate"]); }
                if (!Convert.IsDBNull(myReader["FStatus"])) { myDetail.FStatus = Convert.ToInt16(myReader["FStatus"]); }
                if (!Convert.IsDBNull(myReader["FPlanType"])) { myDetail.FPlanType = Convert.ToInt32(myReader["FPlanType"]); }
                if (!Convert.IsDBNull(myReader["FParentInterID"])) { myDetail.FParentInterID = Convert.ToInt32(myReader["FParentInterID"]); }
                if (!Convert.IsDBNull(myReader["FOrderInterID"])) { myDetail.FOrderInterID = Convert.ToInt32(myReader["FOrderInterID"]); }
                if (!Convert.IsDBNull(myReader["FCancellation"])) { myDetail.FCancellation = Convert.ToBoolean(myReader["FCancellation"]); }
                if (!Convert.IsDBNull(myReader["FMrpClosed"])) { myDetail.FMrpClosed = Convert.ToInt16(myReader["FMrpClosed"]); }
                if (!Convert.IsDBNull(myReader["FCurCheckLevel"])) { myDetail.FCurCheckLevel = Convert.ToInt32(myReader["FCurCheckLevel"]); }
                if (!Convert.IsDBNull(myReader["FMultiCheckLevel1"])) { myDetail.FMultiCheckLevel1 = Convert.ToInt32(myReader["FMultiCheckLevel1"]); }
                if (!Convert.IsDBNull(myReader["FMultiCheckLevel2"])) { myDetail.FMultiCheckLevel2 = Convert.ToInt32(myReader["FMultiCheckLevel2"]); }
                if (!Convert.IsDBNull(myReader["FMultiCheckLevel3"])) { myDetail.FMultiCheckLevel3 = Convert.ToInt32(myReader["FMultiCheckLevel3"]); }
                if (!Convert.IsDBNull(myReader["FMultiCheckLevel4"])) { myDetail.FMultiCheckLevel4 = Convert.ToInt32(myReader["FMultiCheckLevel4"]); }
                if (!Convert.IsDBNull(myReader["FMultiCheckLevel5"])) { myDetail.FMultiCheckLevel5 = Convert.ToInt32(myReader["FMultiCheckLevel5"]); }
                if (!Convert.IsDBNull(myReader["FMultiCheckLevel6"])) { myDetail.FMultiCheckLevel6 = Convert.ToInt32(myReader["FMultiCheckLevel6"]); }
                if (!Convert.IsDBNull(myReader["FMultiCheckDate1"])) { myDetail.FMultiCheckDate1 = Convert.ToDateTime(myReader["FMultiCheckDate1"]); }
                if (!Convert.IsDBNull(myReader["FMultiCheckDate2"])) { myDetail.FMultiCheckDate2 = Convert.ToDateTime(myReader["FMultiCheckDate2"]); }
                if (!Convert.IsDBNull(myReader["FMultiCheckDate3"])) { myDetail.FMultiCheckDate3 = Convert.ToDateTime(myReader["FMultiCheckDate3"]); }
                if (!Convert.IsDBNull(myReader["FMultiCheckDate4"])) { myDetail.FMultiCheckDate4 = Convert.ToDateTime(myReader["FMultiCheckDate4"]); }
                if (!Convert.IsDBNull(myReader["FMultiCheckDate5"])) { myDetail.FMultiCheckDate5 = Convert.ToDateTime(myReader["FMultiCheckDate5"]); }
                if (!Convert.IsDBNull(myReader["FMultiCheckDate6"])) { myDetail.FMultiCheckDate6 = Convert.ToDateTime(myReader["FMultiCheckDate6"]); }
                if (!Convert.IsDBNull(myReader["FSelTranType"])) { myDetail.FSelTranType = Convert.ToInt32(myReader["FSelTranType"]); }
                if (!Convert.IsDBNull(myReader["FPlanCategory"])) { myDetail.FPlanCategory = Convert.ToInt32(myReader["FPlanCategory"]); }
                if (!Convert.IsDBNull(myReader["FConnectFlag"])) { myDetail.FConnectFlag = Convert.ToInt16(myReader["FConnectFlag"]); }
                if (!Convert.IsDBNull(myReader["FPrintCount"])) { myDetail.FPrintCount = Convert.ToInt32(myReader["FPrintCount"]); }
                if (!Convert.IsDBNull(myReader["FHeadSelfY0124"])) { myDetail.FHeadSelfY0124 = Convert.ToInt32(myReader["FHeadSelfY0124"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        /// <summary>
        /// 新增PPOrder对象
        /// 编写人：ywk
        /// 编写日期：2018/7/5 星期四
        /// </summary>
        public int Add(PPOrder model)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO PPOrder(FBrNo,FInterID,FBillNo,FTranType,FDate,FBillerID,FCheckerID,FCheckDate,FStatus,FPlanType,FParentInterID,FOrderInterID,FCancellation,FMrpClosed,FCurCheckLevel,FMultiCheckLevel1,FMultiCheckLevel2,FMultiCheckLevel3,FMultiCheckLevel4,FMultiCheckLevel5,FMultiCheckLevel6,FMultiCheckDate1,FMultiCheckDate2,FMultiCheckDate3,FMultiCheckDate4,FMultiCheckDate5,FMultiCheckDate6,FSelTranType,FPlanCategory,FConnectFlag,FPrintCount,FHeadSelfY0124) VALUES(@m_FBrNo,@m_FInterID,@m_FBillNo,@m_FTranType,@m_FDate,@m_FBillerID,@m_FCheckerID,@m_FCheckDate,@m_FStatus,@m_FPlanType,@m_FParentInterID,@m_FOrderInterID,@m_FCancellation,@m_FMrpClosed,@m_FCurCheckLevel,@m_FMultiCheckLevel1,@m_FMultiCheckLevel2,@m_FMultiCheckLevel3,@m_FMultiCheckLevel4,@m_FMultiCheckLevel5,@m_FMultiCheckLevel6,@m_FMultiCheckDate1,@m_FMultiCheckDate2,@m_FMultiCheckDate3,@m_FMultiCheckDate4,@m_FMultiCheckDate5,@m_FMultiCheckDate6,@m_FSelTranType,@m_FPlanCategory,@m_FConnectFlag,@m_FPrintCount,@m_FHeadSelfY0124) SELECT @thisId=@@IDENTITY FROM PPOrder", con);
            con.Open();

            if (model.FBrNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBrNo", SqlDbType.VarChar, 10)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBrNo", SqlDbType.VarChar, 10)).Value = model.FBrNo;
            }
            if (model.FInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInterID", SqlDbType.Int, 0)).Value = model.FInterID;
            }
            if (model.FBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.VarChar, 30)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.VarChar, 30)).Value = model.FBillNo;
            }
            if (model.FTranType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTranType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTranType", SqlDbType.Int, 0)).Value = model.FTranType;
            }
            if (model.FDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = model.FDate;
            }
            if (model.FBillerID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillerID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillerID", SqlDbType.Int, 0)).Value = model.FBillerID;
            }
            if (model.FCheckerID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCheckerID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCheckerID", SqlDbType.Int, 0)).Value = model.FCheckerID;
            }
            if (model.FCheckDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCheckDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCheckDate", SqlDbType.DateTime, 0)).Value = model.FCheckDate;
            }
            if (model.FStatus == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStatus", SqlDbType.SmallInt, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStatus", SqlDbType.SmallInt, 0)).Value = model.FStatus;
            }
            if (model.FPlanType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanType", SqlDbType.Int, 0)).Value = model.FPlanType;
            }
            if (model.FParentInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FParentInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FParentInterID", SqlDbType.Int, 0)).Value = model.FParentInterID;
            }
            if (model.FOrderInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderInterID", SqlDbType.Int, 0)).Value = model.FOrderInterID;
            }
            if (model.FCancellation == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCancellation", SqlDbType.Bit, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCancellation", SqlDbType.Bit, 0)).Value = model.FCancellation;
            }
            if (model.FMrpClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpClosed", SqlDbType.SmallInt, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpClosed", SqlDbType.SmallInt, 0)).Value = model.FMrpClosed;
            }
            if (model.FCurCheckLevel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCurCheckLevel", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCurCheckLevel", SqlDbType.Int, 0)).Value = model.FCurCheckLevel;
            }
            if (model.FMultiCheckLevel1 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel1", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel1", SqlDbType.Int, 0)).Value = model.FMultiCheckLevel1;
            }
            if (model.FMultiCheckLevel2 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel2", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel2", SqlDbType.Int, 0)).Value = model.FMultiCheckLevel2;
            }
            if (model.FMultiCheckLevel3 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel3", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel3", SqlDbType.Int, 0)).Value = model.FMultiCheckLevel3;
            }
            if (model.FMultiCheckLevel4 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel4", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel4", SqlDbType.Int, 0)).Value = model.FMultiCheckLevel4;
            }
            if (model.FMultiCheckLevel5 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel5", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel5", SqlDbType.Int, 0)).Value = model.FMultiCheckLevel5;
            }
            if (model.FMultiCheckLevel6 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel6", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel6", SqlDbType.Int, 0)).Value = model.FMultiCheckLevel6;
            }
            if (model.FMultiCheckDate1 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate1", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate1", SqlDbType.DateTime, 0)).Value = model.FMultiCheckDate1;
            }
            if (model.FMultiCheckDate2 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate2", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate2", SqlDbType.DateTime, 0)).Value = model.FMultiCheckDate2;
            }
            if (model.FMultiCheckDate3 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate3", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate3", SqlDbType.DateTime, 0)).Value = model.FMultiCheckDate3;
            }
            if (model.FMultiCheckDate4 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate4", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate4", SqlDbType.DateTime, 0)).Value = model.FMultiCheckDate4;
            }
            if (model.FMultiCheckDate5 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate5", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate5", SqlDbType.DateTime, 0)).Value = model.FMultiCheckDate5;
            }
            if (model.FMultiCheckDate6 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate6", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate6", SqlDbType.DateTime, 0)).Value = model.FMultiCheckDate6;
            }
            if (model.FSelTranType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSelTranType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSelTranType", SqlDbType.Int, 0)).Value = model.FSelTranType;
            }
            if (model.FPlanCategory == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanCategory", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanCategory", SqlDbType.Int, 0)).Value = model.FPlanCategory;
            }
            if (model.FConnectFlag == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FConnectFlag", SqlDbType.SmallInt, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FConnectFlag", SqlDbType.SmallInt, 0)).Value = model.FConnectFlag;
            }
            if (model.FPrintCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPrintCount", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPrintCount", SqlDbType.Int, 0)).Value = model.FPrintCount;
            }
            if (model.FHeadSelfY0124 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHeadSelfY0124", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHeadSelfY0124", SqlDbType.Int, 0)).Value = model.FHeadSelfY0124;
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
        /// 更新PPOrder对象
        /// 编写人：ywk
        /// 编写日期：2018/7/5 星期四
        /// </summary>
        public void Update(PPOrder model)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE PPOrder SET FBrNo = @m_FBrNo,FInterID = @m_FInterID,FBillNo = @m_FBillNo,FTranType = @m_FTranType,FDate = @m_FDate,FBillerID = @m_FBillerID,FCheckerID = @m_FCheckerID,FCheckDate = @m_FCheckDate,FStatus = @m_FStatus,FPlanType = @m_FPlanType,FParentInterID = @m_FParentInterID,FOrderInterID = @m_FOrderInterID,FCancellation = @m_FCancellation,FMrpClosed = @m_FMrpClosed,FCurCheckLevel = @m_FCurCheckLevel,FMultiCheckLevel1 = @m_FMultiCheckLevel1,FMultiCheckLevel2 = @m_FMultiCheckLevel2,FMultiCheckLevel3 = @m_FMultiCheckLevel3,FMultiCheckLevel4 = @m_FMultiCheckLevel4,FMultiCheckLevel5 = @m_FMultiCheckLevel5,FMultiCheckLevel6 = @m_FMultiCheckLevel6,FMultiCheckDate1 = @m_FMultiCheckDate1,FMultiCheckDate2 = @m_FMultiCheckDate2,FMultiCheckDate3 = @m_FMultiCheckDate3,FMultiCheckDate4 = @m_FMultiCheckDate4,FMultiCheckDate5 = @m_FMultiCheckDate5,FMultiCheckDate6 = @m_FMultiCheckDate6,FSelTranType = @m_FSelTranType,FPlanCategory = @m_FPlanCategory,FConnectFlag = @m_FConnectFlag,FPrintCount = @m_FPrintCount,FHeadSelfY0124 = @m_FHeadSelfY0124 WHERE FInterID = @m_FInterID", con);
            con.Open();

            if (model.FBrNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBrNo", SqlDbType.VarChar, 10)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBrNo", SqlDbType.VarChar, 10)).Value = model.FBrNo;
            }
            if (model.FInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInterID", SqlDbType.Int, 0)).Value = model.FInterID;
            }
            if (model.FBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.VarChar, 30)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.VarChar, 30)).Value = model.FBillNo;
            }
            if (model.FTranType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTranType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTranType", SqlDbType.Int, 0)).Value = model.FTranType;
            }
            if (model.FDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = model.FDate;
            }
            if (model.FBillerID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillerID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillerID", SqlDbType.Int, 0)).Value = model.FBillerID;
            }
            if (model.FCheckerID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCheckerID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCheckerID", SqlDbType.Int, 0)).Value = model.FCheckerID;
            }
            if (model.FCheckDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCheckDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCheckDate", SqlDbType.DateTime, 0)).Value = model.FCheckDate;
            }
            if (model.FStatus == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStatus", SqlDbType.SmallInt, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStatus", SqlDbType.SmallInt, 0)).Value = model.FStatus;
            }
            if (model.FPlanType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanType", SqlDbType.Int, 0)).Value = model.FPlanType;
            }
            if (model.FParentInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FParentInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FParentInterID", SqlDbType.Int, 0)).Value = model.FParentInterID;
            }
            if (model.FOrderInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderInterID", SqlDbType.Int, 0)).Value = model.FOrderInterID;
            }
            if (model.FCancellation == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCancellation", SqlDbType.Bit, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCancellation", SqlDbType.Bit, 0)).Value = model.FCancellation;
            }
            if (model.FMrpClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpClosed", SqlDbType.SmallInt, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpClosed", SqlDbType.SmallInt, 0)).Value = model.FMrpClosed;
            }
            if (model.FCurCheckLevel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCurCheckLevel", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCurCheckLevel", SqlDbType.Int, 0)).Value = model.FCurCheckLevel;
            }
            if (model.FMultiCheckLevel1 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel1", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel1", SqlDbType.Int, 0)).Value = model.FMultiCheckLevel1;
            }
            if (model.FMultiCheckLevel2 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel2", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel2", SqlDbType.Int, 0)).Value = model.FMultiCheckLevel2;
            }
            if (model.FMultiCheckLevel3 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel3", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel3", SqlDbType.Int, 0)).Value = model.FMultiCheckLevel3;
            }
            if (model.FMultiCheckLevel4 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel4", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel4", SqlDbType.Int, 0)).Value = model.FMultiCheckLevel4;
            }
            if (model.FMultiCheckLevel5 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel5", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel5", SqlDbType.Int, 0)).Value = model.FMultiCheckLevel5;
            }
            if (model.FMultiCheckLevel6 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel6", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckLevel6", SqlDbType.Int, 0)).Value = model.FMultiCheckLevel6;
            }
            if (model.FMultiCheckDate1 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate1", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate1", SqlDbType.DateTime, 0)).Value = model.FMultiCheckDate1;
            }
            if (model.FMultiCheckDate2 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate2", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate2", SqlDbType.DateTime, 0)).Value = model.FMultiCheckDate2;
            }
            if (model.FMultiCheckDate3 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate3", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate3", SqlDbType.DateTime, 0)).Value = model.FMultiCheckDate3;
            }
            if (model.FMultiCheckDate4 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate4", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate4", SqlDbType.DateTime, 0)).Value = model.FMultiCheckDate4;
            }
            if (model.FMultiCheckDate5 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate5", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate5", SqlDbType.DateTime, 0)).Value = model.FMultiCheckDate5;
            }
            if (model.FMultiCheckDate6 == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate6", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMultiCheckDate6", SqlDbType.DateTime, 0)).Value = model.FMultiCheckDate6;
            }
            if (model.FSelTranType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSelTranType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSelTranType", SqlDbType.Int, 0)).Value = model.FSelTranType;
            }
            if (model.FPlanCategory == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanCategory", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanCategory", SqlDbType.Int, 0)).Value = model.FPlanCategory;
            }
            if (model.FConnectFlag == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FConnectFlag", SqlDbType.SmallInt, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FConnectFlag", SqlDbType.SmallInt, 0)).Value = model.FConnectFlag;
            }
            if (model.FPrintCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPrintCount", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPrintCount", SqlDbType.Int, 0)).Value = model.FPrintCount;
            }
            if (model.FHeadSelfY0124 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHeadSelfY0124", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHeadSelfY0124", SqlDbType.Int, 0)).Value = model.FHeadSelfY0124;
            }

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }


    }
}
