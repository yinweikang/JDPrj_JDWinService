using JDWinService.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDWinService.Utils;
namespace JDWinService.Dal
{
    public class PORequestEntryDal
    {

        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息

        /// <summary>
		/// 对象PORequestEntry明细
		/// 编写人：ywk
		/// 编写日期：2018/8/27 星期一
		/// </summary>
		public PORequestEntry Detail(int FInterID,int FEntryID)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM PORequestEntry WHERE FInterID = @m_FInterID and FEntryID=@m_FEntryID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_FInterID", SqlDbType.Int, 0)).Value = FInterID;
            cmd.Parameters.Add(new SqlParameter("@m_FEntryID", SqlDbType.Int, 0)).Value = FEntryID;

            PORequestEntry myDetail = new PORequestEntry();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["FBrNo"])) { myDetail.FBrNo = Convert.ToString(myReader["FBrNo"]); }
                if (!Convert.IsDBNull(myReader["FInterID"])) { myDetail.FInterID = Convert.ToInt32(myReader["FInterID"]); }
                if (!Convert.IsDBNull(myReader["FEntryID"])) { myDetail.FEntryID = Convert.ToInt32(myReader["FEntryID"]); }
                if (!Convert.IsDBNull(myReader["FItemID"])) { myDetail.FItemID = Convert.ToInt32(myReader["FItemID"]); }
                if (!Convert.IsDBNull(myReader["FQty"])) { myDetail.FQty = Convert.ToDecimal(myReader["FQty"]); }
                if (!Convert.IsDBNull(myReader["FCommitQty"])) { myDetail.FCommitQty = Convert.ToDecimal(myReader["FCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FPrice"])) { myDetail.FPrice = Convert.ToDecimal(myReader["FPrice"]); }
                if (!Convert.IsDBNull(myReader["FUse"])) { myDetail.FUse = Convert.ToString(myReader["FUse"]); }
                if (!Convert.IsDBNull(myReader["FFetchTime"])) { myDetail.FFetchTime = Convert.ToDateTime(myReader["FFetchTime"]); }
                if (!Convert.IsDBNull(myReader["FUnitID"])) { myDetail.FUnitID = Convert.ToInt32(myReader["FUnitID"]); }
                if (!Convert.IsDBNull(myReader["FAuxCommitQty"])) { myDetail.FAuxCommitQty = Convert.ToDecimal(myReader["FAuxCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxPrice"])) { myDetail.FAuxPrice = Convert.ToDecimal(myReader["FAuxPrice"]); }
                if (!Convert.IsDBNull(myReader["FAuxQty"])) { myDetail.FAuxQty = Convert.ToDecimal(myReader["FAuxQty"]); }
                if (!Convert.IsDBNull(myReader["FSourceEntryID"])) { myDetail.FSourceEntryID = Convert.ToInt32(myReader["FSourceEntryID"]); }
                if (!Convert.IsDBNull(myReader["FSupplyID"])) { myDetail.FSupplyID = Convert.ToInt32(myReader["FSupplyID"]); }
                if (!Convert.IsDBNull(myReader["FAPurchTime"])) { myDetail.FAPurchTime = Convert.ToDateTime(myReader["FAPurchTime"]); }
                if (!Convert.IsDBNull(myReader["FPlanOrderInterID"])) { myDetail.FPlanOrderInterID = Convert.ToInt32(myReader["FPlanOrderInterID"]); }
                if (!Convert.IsDBNull(myReader["FAuxPropID"])) { myDetail.FAuxPropID = Convert.ToInt32(myReader["FAuxPropID"]); }
                if (!Convert.IsDBNull(myReader["FSecCoefficient"])) { myDetail.FSecCoefficient = Convert.ToDecimal(myReader["FSecCoefficient"]); }
                if (!Convert.IsDBNull(myReader["FSecQty"])) { myDetail.FSecQty = Convert.ToDecimal(myReader["FSecQty"]); }
                if (!Convert.IsDBNull(myReader["FSecCommitQty"])) { myDetail.FSecCommitQty = Convert.ToDecimal(myReader["FSecCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FSourceTranType"])) { myDetail.FSourceTranType = Convert.ToInt32(myReader["FSourceTranType"]); }
                if (!Convert.IsDBNull(myReader["FSourceInterId"])) { myDetail.FSourceInterId = Convert.ToInt32(myReader["FSourceInterId"]); }
                if (!Convert.IsDBNull(myReader["FSourceBillNo"])) { myDetail.FSourceBillNo = Convert.ToString(myReader["FSourceBillNo"]); }
                if (!Convert.IsDBNull(myReader["FMRPLockFlag"])) { myDetail.FMRPLockFlag = Convert.ToInt32(myReader["FMRPLockFlag"]); }
                if (!Convert.IsDBNull(myReader["FOrderQty"])) { myDetail.FOrderQty = Convert.ToDecimal(myReader["FOrderQty"]); }
                if (!Convert.IsDBNull(myReader["FMRPClosed"])) { myDetail.FMRPClosed = Convert.ToInt32(myReader["FMRPClosed"]); }
                if (!Convert.IsDBNull(myReader["FMrpAutoClosed"])) { myDetail.FMrpAutoClosed = Convert.ToInt32(myReader["FMrpAutoClosed"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0127"])) { myDetail.FEntrySelfP0127 = Convert.ToDecimal(myReader["FEntrySelfP0127"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0128"])) { myDetail.FEntrySelfP0128 = Convert.ToDecimal(myReader["FEntrySelfP0128"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0129"])) { myDetail.FEntrySelfP0129 = Convert.ToDecimal(myReader["FEntrySelfP0129"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0130"])) { myDetail.FEntrySelfP0130 = Convert.ToDecimal(myReader["FEntrySelfP0130"]); }
                if (!Convert.IsDBNull(myReader["FPlanMode"])) { myDetail.FPlanMode = Convert.ToInt32(myReader["FPlanMode"]); }
                if (!Convert.IsDBNull(myReader["FMTONo"])) { myDetail.FMTONo = Convert.ToString(myReader["FMTONo"]); }
                if (!Convert.IsDBNull(myReader["FBomInterID"])) { myDetail.FBomInterID = Convert.ToInt32(myReader["FBomInterID"]); }
                if (!Convert.IsDBNull(myReader["FIsInquiry"])) { myDetail.FIsInquiry = Convert.ToInt32(myReader["FIsInquiry"]); }
                if (!Convert.IsDBNull(myReader["FDetailID"])) { myDetail.FDetailID = Convert.ToInt32(myReader["FDetailID"]); }
                if (!Convert.IsDBNull(myReader["FBOMCategory"])) { myDetail.FBOMCategory = Convert.ToInt32(myReader["FBOMCategory"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0135"])) { myDetail.FEntrySelfP0135 = Convert.ToDecimal(myReader["FEntrySelfP0135"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0136"])) { myDetail.FEntrySelfP0136 = Convert.ToInt32(myReader["FEntrySelfP0136"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0137"])) { myDetail.FEntrySelfP0137 = Convert.ToString(myReader["FEntrySelfP0137"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0145"])) { myDetail.FEntrySelfP0145 = Convert.ToString(myReader["FEntrySelfP0145"]); }
                if (!Convert.IsDBNull(myReader["FOrderBOMEntryID"])) { myDetail.FOrderBOMEntryID = Convert.ToInt32(myReader["FOrderBOMEntryID"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfP0148"])) { myDetail.FEntrySelfP0148 = Convert.ToInt32(myReader["FEntrySelfP0148"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        /// <summary>
        /// 更新PORequestEntry对象
        /// 编写人：ywk
        /// 编写日期：2018/8/27 星期一
        /// </summary>
        public void Update(PORequestEntry model)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE PORequestEntry SET FBrNo = @m_FBrNo,FInterID = @m_FInterID,FEntryID = @m_FEntryID,FItemID = @m_FItemID,FQty = @m_FQty,FCommitQty = @m_FCommitQty,FPrice = @m_FPrice,FUse = @m_FUse,FFetchTime = @m_FFetchTime,FUnitID = @m_FUnitID,FAuxCommitQty = @m_FAuxCommitQty,FAuxPrice = @m_FAuxPrice,FAuxQty = @m_FAuxQty,FSourceEntryID = @m_FSourceEntryID,FSupplyID = @m_FSupplyID,FAPurchTime = @m_FAPurchTime,FPlanOrderInterID = @m_FPlanOrderInterID,FAuxPropID = @m_FAuxPropID,FSecCoefficient = @m_FSecCoefficient,FSecQty = @m_FSecQty,FSecCommitQty = @m_FSecCommitQty,FSourceTranType = @m_FSourceTranType,FSourceInterId = @m_FSourceInterId,FSourceBillNo = @m_FSourceBillNo,FMRPLockFlag = @m_FMRPLockFlag,FOrderQty = @m_FOrderQty,FMRPClosed = @m_FMRPClosed,FMrpAutoClosed = @m_FMrpAutoClosed,FEntrySelfP0127 = @m_FEntrySelfP0127,FEntrySelfP0128 = @m_FEntrySelfP0128,FEntrySelfP0129 = @m_FEntrySelfP0129,FEntrySelfP0130 = @m_FEntrySelfP0130,FPlanMode = @m_FPlanMode,FMTONo = @m_FMTONo,FBomInterID = @m_FBomInterID,FIsInquiry = @m_FIsInquiry,FBOMCategory = @m_FBOMCategory,FEntrySelfP0135 = @m_FEntrySelfP0135,FEntrySelfP0136 = @m_FEntrySelfP0136,FEntrySelfP0137 = @m_FEntrySelfP0137,FEntrySelfP0145 = @m_FEntrySelfP0145,FOrderBOMEntryID = @m_FOrderBOMEntryID,FEntrySelfP0148 = @m_FEntrySelfP0148 WHERE FSourceInterId = @m_FSourceInterId", con);
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
            if (model.FEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntryID", SqlDbType.Int, 0)).Value = model.FEntryID;
            }
            if (model.FItemID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FItemID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FItemID", SqlDbType.Int, 0)).Value = model.FItemID;
            }
            if (model.FQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 28)).Value = model.FQty;
            }
            if (model.FCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitQty", SqlDbType.Decimal, 28)).Value = model.FCommitQty;
            }
            if (model.FPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPrice", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPrice", SqlDbType.Decimal, 28)).Value = model.FPrice;
            }
            if (model.FUse == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUse", SqlDbType.VarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUse", SqlDbType.VarChar, 50)).Value = model.FUse;
            }
            if (model.FFetchTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFetchTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFetchTime", SqlDbType.DateTime, 0)).Value = model.FFetchTime;
            }
            if (model.FUnitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.Int, 0)).Value = model.FUnitID;
            }
            if (model.FAuxCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxCommitQty;
            }
            if (model.FAuxPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPrice", SqlDbType.Decimal, 28)).Value = model.FAuxPrice;
            }
            if (model.FAuxQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQty", SqlDbType.Decimal, 28)).Value = model.FAuxQty;
            }
            if (model.FSourceEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.Int, 0)).Value = model.FSourceEntryID;
            }
            if (model.FSupplyID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupplyID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupplyID", SqlDbType.Int, 0)).Value = model.FSupplyID;
            }
            if (model.FAPurchTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAPurchTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAPurchTime", SqlDbType.DateTime, 0)).Value = model.FAPurchTime;
            }
            if (model.FPlanOrderInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanOrderInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanOrderInterID", SqlDbType.Int, 0)).Value = model.FPlanOrderInterID;
            }
            if (model.FAuxPropID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPropID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPropID", SqlDbType.Int, 0)).Value = model.FAuxPropID;
            }
            if (model.FSecCoefficient == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecCoefficient", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecCoefficient", SqlDbType.Decimal, 28)).Value = model.FSecCoefficient;
            }
            if (model.FSecQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecQty", SqlDbType.Decimal, 28)).Value = model.FSecQty;
            }
            if (model.FSecCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecCommitQty", SqlDbType.Decimal, 28)).Value = model.FSecCommitQty;
            }
            if (model.FSourceTranType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceTranType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceTranType", SqlDbType.Int, 0)).Value = model.FSourceTranType;
            }
            if (model.FSourceInterId == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceInterId", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceInterId", SqlDbType.Int, 0)).Value = model.FSourceInterId;
            }
            if (model.FSourceBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceBillNo", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceBillNo", SqlDbType.NVarChar, 255)).Value = model.FSourceBillNo;
            }
            if (model.FMRPLockFlag == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMRPLockFlag", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMRPLockFlag", SqlDbType.Int, 0)).Value = model.FMRPLockFlag;
            }
            if (model.FOrderQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderQty", SqlDbType.Decimal, 28)).Value = model.FOrderQty;
            }
            if (model.FMRPClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMRPClosed", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMRPClosed", SqlDbType.Int, 0)).Value = model.FMRPClosed;
            }
            if (model.FMrpAutoClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpAutoClosed", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpAutoClosed", SqlDbType.Int, 0)).Value = model.FMrpAutoClosed;
            }
            if (model.FEntrySelfP0127 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0127", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0127", SqlDbType.Decimal, 28)).Value = model.FEntrySelfP0127;
            }
            if (model.FEntrySelfP0128 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0128", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0128", SqlDbType.Decimal, 28)).Value = model.FEntrySelfP0128;
            }
            if (model.FEntrySelfP0129 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0129", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0129", SqlDbType.Decimal, 28)).Value = model.FEntrySelfP0129;
            }
            if (model.FEntrySelfP0130 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0130", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0130", SqlDbType.Decimal, 28)).Value = model.FEntrySelfP0130;
            }
            if (model.FPlanMode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanMode", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanMode", SqlDbType.Int, 0)).Value = model.FPlanMode;
            }
            if (model.FMTONo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMTONo", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMTONo", SqlDbType.NVarChar, 50)).Value = model.FMTONo;
            }
            if (model.FBomInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBomInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBomInterID", SqlDbType.Int, 0)).Value = model.FBomInterID;
            }
            if (model.FIsInquiry == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsInquiry", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsInquiry", SqlDbType.Int, 0)).Value = model.FIsInquiry;
            }
            if (model.FBOMCategory == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBOMCategory", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBOMCategory", SqlDbType.Int, 0)).Value = model.FBOMCategory;
            }
            if (model.FEntrySelfP0135 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0135", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0135", SqlDbType.Decimal, 28)).Value = model.FEntrySelfP0135;
            }
            if (model.FEntrySelfP0136 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0136", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0136", SqlDbType.Int, 0)).Value = model.FEntrySelfP0136;
            }
            if (model.FEntrySelfP0137 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0137", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0137", SqlDbType.VarChar, 255)).Value = model.FEntrySelfP0137;
            }
            if (model.FEntrySelfP0145 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0145", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0145", SqlDbType.VarChar, 255)).Value = model.FEntrySelfP0145;
            }
            if (model.FOrderBOMEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMEntryID", SqlDbType.Int, 0)).Value = model.FOrderBOMEntryID;
            }
            if (model.FEntrySelfP0148 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0148", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfP0148", SqlDbType.Int, 0)).Value = model.FEntrySelfP0148;
            }

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }


        //是否子表全是关闭状态
        public bool NeedClosed(int FInterID)
        {
            string sql = string.Format(@" select count(1) from PORequestEntry where FInterID={0} and FMRPClosed=0", FInterID);
            object obj = DBUtil.GetSingle(sql);
            bool IsNeedClosed = true;
            if (obj != null && Convert.ToInt32(obj.ToString()) > 0)
            {
                IsNeedClosed = false;
            }
            return IsNeedClosed;

        }
    }
 
}
