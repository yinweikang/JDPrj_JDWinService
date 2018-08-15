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
    public class PPOrderEntryDal
    {

        /// <summary>
        /// 对象PPOrderEntry明细
        /// 编写人：ywk
        /// 编写日期：2018/7/5 星期四
        /// </summary>
        Common common = new Common();
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息
       
        public PPOrderEntry Detail(int FInterID, int FEntryID)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM PPOrderEntry WHERE FInterID = @m_FInterID and FEntryID=@m_FEntryID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_FInterID", SqlDbType.Int, 0)).Value = FInterID;
            cmd.Parameters.Add(new SqlParameter("@m_FEntryID", SqlDbType.Int, 0)).Value = FEntryID;
            PPOrderEntry myDetail = new PPOrderEntry();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["FBrNo"])) { myDetail.FBrNo = Convert.ToString(myReader["FBrNo"]); }
                if (!Convert.IsDBNull(myReader["FInterID"])) { myDetail.FInterID = Convert.ToInt32(myReader["FInterID"]); }
                if (!Convert.IsDBNull(myReader["FEntryID"])) { myDetail.FEntryID = Convert.ToInt32(myReader["FEntryID"]); }
                if (!Convert.IsDBNull(myReader["FItemID"])) { myDetail.FItemID = Convert.ToInt32(myReader["FItemID"]); }
                if (!Convert.IsDBNull(myReader["FUnitID"])) { myDetail.FUnitID = Convert.ToInt32(myReader["FUnitID"]); }
                if (!Convert.IsDBNull(myReader["FQty"])) { myDetail.FQty = Convert.ToDecimal(myReader["FQty"]); }
                if (!Convert.IsDBNull(myReader["FNeedDate"])) { myDetail.FNeedDate = Convert.ToDateTime(myReader["FNeedDate"]); }
                if (!Convert.IsDBNull(myReader["FNote"])) { myDetail.FNote = Convert.ToString(myReader["FNote"]); }
                if (!Convert.IsDBNull(myReader["FAuxQty"])) { myDetail.FAuxQty = Convert.ToDecimal(myReader["FAuxQty"]); }
                if (!Convert.IsDBNull(myReader["FCommitQty"])) { myDetail.FCommitQty = Convert.ToDecimal(myReader["FCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxCommitQty"])) { myDetail.FAuxCommitQty = Convert.ToDecimal(myReader["FAuxCommitQty"]); }
                if (!Convert.IsDBNull(myReader["FSourceEntryID"])) { myDetail.FSourceEntryID = Convert.ToInt16(myReader["FSourceEntryID"]); }
                if (!Convert.IsDBNull(myReader["FHaveMrp"])) { myDetail.FHaveMrp = Convert.ToInt32(myReader["FHaveMrp"]); }
                if (!Convert.IsDBNull(myReader["FMrpClosed"])) { myDetail.FMrpClosed = Convert.ToInt32(myReader["FMrpClosed"]); }
                if (!Convert.IsDBNull(myReader["FNeedDateEnd"])) { myDetail.FNeedDateEnd = Convert.ToDateTime(myReader["FNeedDateEnd"]); }
                if (!Convert.IsDBNull(myReader["FSplitCycleID"])) { myDetail.FSplitCycleID = Convert.ToInt32(myReader["FSplitCycleID"]); }
                if (!Convert.IsDBNull(myReader["FOrgNeedDate"])) { myDetail.FOrgNeedDate = Convert.ToDateTime(myReader["FOrgNeedDate"]); }
                if (!Convert.IsDBNull(myReader["FOrgNeedDateEnd"])) { myDetail.FOrgNeedDateEnd = Convert.ToDateTime(myReader["FOrgNeedDateEnd"]); }
                if (!Convert.IsDBNull(myReader["FOrgEntryID"])) { myDetail.FOrgEntryID = Convert.ToInt32(myReader["FOrgEntryID"]); }
                if (!Convert.IsDBNull(myReader["FIsKilled"])) { myDetail.FIsKilled = Convert.ToInt32(myReader["FIsKilled"]); }
                if (!Convert.IsDBNull(myReader["FKillQty"])) { myDetail.FKillQty = Convert.ToDecimal(myReader["FKillQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxKillQty"])) { myDetail.FAuxKillQty = Convert.ToDecimal(myReader["FAuxKillQty"]); }
                if (!Convert.IsDBNull(myReader["FBomInterID"])) { myDetail.FBomInterID = Convert.ToInt32(myReader["FBomInterID"]); }
                if (!Convert.IsDBNull(myReader["FCustID"])) { myDetail.FCustID = Convert.ToInt32(myReader["FCustID"]); }
                if (!Convert.IsDBNull(myReader["FSaleQty"])) { myDetail.FSaleQty = Convert.ToDecimal(myReader["FSaleQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxSaleQty"])) { myDetail.FAuxSaleQty = Convert.ToDecimal(myReader["FAuxSaleQty"]); }
                if (!Convert.IsDBNull(myReader["FSelQty"])) { myDetail.FSelQty = Convert.ToDecimal(myReader["FSelQty"]); }
                if (!Convert.IsDBNull(myReader["FAuxSelQty"])) { myDetail.FAuxSelQty = Convert.ToDecimal(myReader["FAuxSelQty"]); }
                if (!Convert.IsDBNull(myReader["FOrderClosed"])) { myDetail.FOrderClosed = Convert.ToInt32(myReader["FOrderClosed"]); }
                if (!Convert.IsDBNull(myReader["FMRPLockFlag"])) { myDetail.FMRPLockFlag = Convert.ToInt32(myReader["FMRPLockFlag"]); }
                if (!Convert.IsDBNull(myReader["FSourceTranType"])) { myDetail.FSourceTranType = Convert.ToInt32(myReader["FSourceTranType"]); }
                if (!Convert.IsDBNull(myReader["FSourceInterID"])) { myDetail.FSourceInterID = Convert.ToInt32(myReader["FSourceInterID"]); }
                if (!Convert.IsDBNull(myReader["FSourceBillNo"])) { myDetail.FSourceBillNo = Convert.ToString(myReader["FSourceBillNo"]); }
                if (!Convert.IsDBNull(myReader["FPlanMode"])) { myDetail.FPlanMode = Convert.ToInt32(myReader["FPlanMode"]); }
                if (!Convert.IsDBNull(myReader["FMTONo"])) { myDetail.FMTONo = Convert.ToString(myReader["FMTONo"]); }
                if (!Convert.IsDBNull(myReader["FDetailID"])) { myDetail.FDetailID = Convert.ToInt32(myReader["FDetailID"]); }
                if (!Convert.IsDBNull(myReader["FBOMCategory"])) { myDetail.FBOMCategory = Convert.ToInt32(myReader["FBOMCategory"]); }
                if (!Convert.IsDBNull(myReader["FIsAPS"])) { myDetail.FIsAPS = Convert.ToInt32(myReader["FIsAPS"]); }
                if (!Convert.IsDBNull(myReader["FMeetDelivery"])) { myDetail.FMeetDelivery = Convert.ToInt32(myReader["FMeetDelivery"]); }
                if (!Convert.IsDBNull(myReader["FAuxPropID"])) { myDetail.FAuxPropID = Convert.ToInt32(myReader["FAuxPropID"]); }
                if (!Convert.IsDBNull(myReader["FOrderBOMStatus"])) { myDetail.FOrderBOMStatus = Convert.ToInt32(myReader["FOrderBOMStatus"]); }
                if (!Convert.IsDBNull(myReader["FOrderBOMInterID"])) { myDetail.FOrderBOMInterID = Convert.ToInt32(myReader["FOrderBOMInterID"]); }
                if (!Convert.IsDBNull(myReader["FEntrySelfY0128"])) { myDetail.FEntrySelfY0128 = Convert.ToString(myReader["FEntrySelfY0128"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        /// <summary>
        /// 新增PPOrderEntry对象
        /// 编写人：ywk
        /// 编写日期：2018/7/5 星期四
        /// </summary>
        public int Add(PPOrderEntry model)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO PPOrderEntry(FBrNo,FInterID,FEntryID,FItemID,FUnitID,FQty,FNeedDate,FNote,FAuxQty,FCommitQty,FAuxCommitQty,FSourceEntryID,FHaveMrp,FMrpClosed,FNeedDateEnd,FSplitCycleID,FOrgNeedDate,FOrgNeedDateEnd,FOrgEntryID,FIsKilled,FKillQty,FAuxKillQty,FBomInterID,FCustID,FSaleQty,FAuxSaleQty,FSelQty,FAuxSelQty,FOrderClosed,FMRPLockFlag,FSourceTranType,FSourceInterID,FSourceBillNo,FPlanMode,FMTONo,FBOMCategory,FIsAPS,FMeetDelivery,FAuxPropID,FOrderBOMStatus,FOrderBOMInterID,FEntrySelfY0128) VALUES(@m_FBrNo,@m_FInterID,@m_FEntryID,@m_FItemID,@m_FUnitID,@m_FQty,@m_FNeedDate,@m_FNote,@m_FAuxQty,@m_FCommitQty,@m_FAuxCommitQty,@m_FSourceEntryID,@m_FHaveMrp,@m_FMrpClosed,@m_FNeedDateEnd,@m_FSplitCycleID,@m_FOrgNeedDate,@m_FOrgNeedDateEnd,@m_FOrgEntryID,@m_FIsKilled,@m_FKillQty,@m_FAuxKillQty,@m_FBomInterID,@m_FCustID,@m_FSaleQty,@m_FAuxSaleQty,@m_FSelQty,@m_FAuxSelQty,@m_FOrderClosed,@m_FMRPLockFlag,@m_FSourceTranType,@m_FSourceInterID,@m_FSourceBillNo,@m_FPlanMode,@m_FMTONo,@m_FBOMCategory,@m_FIsAPS,@m_FMeetDelivery,@m_FAuxPropID,@m_FOrderBOMStatus,@m_FOrderBOMInterID,@m_FEntrySelfY0128) SELECT @thisId=@@IDENTITY FROM PPOrderEntry", con);
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
            if (model.FUnitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.Int, 0)).Value = model.FUnitID;
            }
            if (model.FQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 28)).Value = model.FQty;
            }
            if (model.FNeedDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNeedDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNeedDate", SqlDbType.DateTime, 0)).Value = model.FNeedDate;
            }
            if (model.FNote == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.VarChar, 255)).Value = model.FNote;
            }
            if (model.FAuxQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQty", SqlDbType.Decimal, 28)).Value = model.FAuxQty;
            }
            if (model.FCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitQty", SqlDbType.Decimal, 28)).Value = model.FCommitQty;
            }
            if (model.FAuxCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxCommitQty;
            }
            if (model.FSourceEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.SmallInt, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.SmallInt, 0)).Value = model.FSourceEntryID;
            }
            if (model.FHaveMrp == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHaveMrp", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHaveMrp", SqlDbType.Int, 0)).Value = model.FHaveMrp;
            }
            if (model.FMrpClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpClosed", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpClosed", SqlDbType.Int, 0)).Value = model.FMrpClosed;
            }
            if (model.FNeedDateEnd == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNeedDateEnd", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNeedDateEnd", SqlDbType.DateTime, 0)).Value = model.FNeedDateEnd;
            }
            if (model.FSplitCycleID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSplitCycleID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSplitCycleID", SqlDbType.Int, 0)).Value = model.FSplitCycleID;
            }
            if (model.FOrgNeedDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrgNeedDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrgNeedDate", SqlDbType.DateTime, 0)).Value = model.FOrgNeedDate;
            }
            if (model.FOrgNeedDateEnd == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrgNeedDateEnd", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrgNeedDateEnd", SqlDbType.DateTime, 0)).Value = model.FOrgNeedDateEnd;
            }
            if (model.FOrgEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrgEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrgEntryID", SqlDbType.Int, 0)).Value = model.FOrgEntryID;
            }
            if (model.FIsKilled == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsKilled", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsKilled", SqlDbType.Int, 0)).Value = model.FIsKilled;
            }
            if (model.FKillQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FKillQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FKillQty", SqlDbType.Decimal, 28)).Value = model.FKillQty;
            }
            if (model.FAuxKillQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxKillQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxKillQty", SqlDbType.Decimal, 28)).Value = model.FAuxKillQty;
            }
            if (model.FBomInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBomInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBomInterID", SqlDbType.Int, 0)).Value = model.FBomInterID;
            }
            if (model.FCustID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCustID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCustID", SqlDbType.Int, 0)).Value = model.FCustID;
            }
            if (model.FSaleQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleQty", SqlDbType.Decimal, 28)).Value = model.FSaleQty;
            }
            if (model.FAuxSaleQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxSaleQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxSaleQty", SqlDbType.Decimal, 28)).Value = model.FAuxSaleQty;
            }
            if (model.FSelQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSelQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSelQty", SqlDbType.Decimal, 28)).Value = model.FSelQty;
            }
            if (model.FAuxSelQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxSelQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxSelQty", SqlDbType.Decimal, 28)).Value = model.FAuxSelQty;
            }
            if (model.FOrderClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderClosed", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderClosed", SqlDbType.Int, 0)).Value = model.FOrderClosed;
            }
            if (model.FMRPLockFlag == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMRPLockFlag", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMRPLockFlag", SqlDbType.Int, 0)).Value = model.FMRPLockFlag;
            }
            if (model.FSourceTranType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceTranType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceTranType", SqlDbType.Int, 0)).Value = model.FSourceTranType;
            }
            if (model.FSourceInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceInterID", SqlDbType.Int, 0)).Value = model.FSourceInterID;
            }
            if (model.FSourceBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceBillNo", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceBillNo", SqlDbType.NVarChar, 255)).Value = model.FSourceBillNo;
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
            if (model.FBOMCategory == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBOMCategory", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBOMCategory", SqlDbType.Int, 0)).Value = model.FBOMCategory;
            }
            if (model.FIsAPS == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsAPS", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsAPS", SqlDbType.Int, 0)).Value = model.FIsAPS;
            }
            if (model.FMeetDelivery == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMeetDelivery", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMeetDelivery", SqlDbType.Int, 0)).Value = model.FMeetDelivery;
            }
            if (model.FAuxPropID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPropID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPropID", SqlDbType.Int, 0)).Value = model.FAuxPropID;
            }
            if (model.FOrderBOMStatus == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMStatus", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMStatus", SqlDbType.Int, 0)).Value = model.FOrderBOMStatus;
            }
            if (model.FOrderBOMInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMInterID", SqlDbType.Int, 0)).Value = model.FOrderBOMInterID;
            }
            if (model.FEntrySelfY0128 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfY0128", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfY0128", SqlDbType.VarChar, 255)).Value = model.FEntrySelfY0128;
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
        /// 更新PPOrderEntry对象
        /// 编写人：ywk
        /// 编写日期：2018/7/5 星期四
        /// </summary>
        public void Update(PPOrderEntry model)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE PPOrderEntry SET FBrNo = @m_FBrNo,FInterID = @m_FInterID,FEntryID = @m_FEntryID,FItemID = @m_FItemID,FUnitID = @m_FUnitID,FQty = @m_FQty,FNeedDate = @m_FNeedDate,FNote = @m_FNote,FAuxQty = @m_FAuxQty,FCommitQty = @m_FCommitQty,FAuxCommitQty = @m_FAuxCommitQty,FSourceEntryID = @m_FSourceEntryID,FHaveMrp = @m_FHaveMrp,FMrpClosed = @m_FMrpClosed,FNeedDateEnd = @m_FNeedDateEnd,FSplitCycleID = @m_FSplitCycleID,FOrgNeedDate = @m_FOrgNeedDate,FOrgNeedDateEnd = @m_FOrgNeedDateEnd,FOrgEntryID = @m_FOrgEntryID,FIsKilled = @m_FIsKilled,FKillQty = @m_FKillQty,FAuxKillQty = @m_FAuxKillQty,FBomInterID = @m_FBomInterID,FCustID = @m_FCustID,FSaleQty = @m_FSaleQty,FAuxSaleQty = @m_FAuxSaleQty,FSelQty = @m_FSelQty,FAuxSelQty = @m_FAuxSelQty,FOrderClosed = @m_FOrderClosed,FMRPLockFlag = @m_FMRPLockFlag,FSourceTranType = @m_FSourceTranType,FSourceInterID = @m_FSourceInterID,FSourceBillNo = @m_FSourceBillNo,FPlanMode = @m_FPlanMode,FMTONo = @m_FMTONo,FBOMCategory = @m_FBOMCategory,FIsAPS = @m_FIsAPS,FMeetDelivery = @m_FMeetDelivery,FAuxPropID = @m_FAuxPropID,FOrderBOMStatus = @m_FOrderBOMStatus,FOrderBOMInterID = @m_FOrderBOMInterID,FEntrySelfY0128 = @m_FEntrySelfY0128 WHERE FAuxPropID = @m_FAuxPropID", con);
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
            if (model.FUnitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.Int, 0)).Value = model.FUnitID;
            }
            if (model.FQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 28)).Value = model.FQty;
            }
            if (model.FNeedDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNeedDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNeedDate", SqlDbType.DateTime, 0)).Value = model.FNeedDate;
            }
            if (model.FNote == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.VarChar, 255)).Value = model.FNote;
            }
            if (model.FAuxQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxQty", SqlDbType.Decimal, 28)).Value = model.FAuxQty;
            }
            if (model.FCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCommitQty", SqlDbType.Decimal, 28)).Value = model.FCommitQty;
            }
            if (model.FAuxCommitQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxCommitQty", SqlDbType.Decimal, 28)).Value = model.FAuxCommitQty;
            }
            if (model.FSourceEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.SmallInt, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.SmallInt, 0)).Value = model.FSourceEntryID;
            }
            if (model.FHaveMrp == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHaveMrp", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHaveMrp", SqlDbType.Int, 0)).Value = model.FHaveMrp;
            }
            if (model.FMrpClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpClosed", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMrpClosed", SqlDbType.Int, 0)).Value = model.FMrpClosed;
            }
            if (model.FNeedDateEnd == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNeedDateEnd", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNeedDateEnd", SqlDbType.DateTime, 0)).Value = model.FNeedDateEnd;
            }
            if (model.FSplitCycleID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSplitCycleID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSplitCycleID", SqlDbType.Int, 0)).Value = model.FSplitCycleID;
            }
            if (model.FOrgNeedDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrgNeedDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrgNeedDate", SqlDbType.DateTime, 0)).Value = model.FOrgNeedDate;
            }
            if (model.FOrgNeedDateEnd == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrgNeedDateEnd", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrgNeedDateEnd", SqlDbType.DateTime, 0)).Value = model.FOrgNeedDateEnd;
            }
            if (model.FOrgEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrgEntryID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrgEntryID", SqlDbType.Int, 0)).Value = model.FOrgEntryID;
            }
            if (model.FIsKilled == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsKilled", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsKilled", SqlDbType.Int, 0)).Value = model.FIsKilled;
            }
            if (model.FKillQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FKillQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FKillQty", SqlDbType.Decimal, 28)).Value = model.FKillQty;
            }
            if (model.FAuxKillQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxKillQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxKillQty", SqlDbType.Decimal, 28)).Value = model.FAuxKillQty;
            }
            if (model.FBomInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBomInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBomInterID", SqlDbType.Int, 0)).Value = model.FBomInterID;
            }
            if (model.FCustID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCustID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCustID", SqlDbType.Int, 0)).Value = model.FCustID;
            }
            if (model.FSaleQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleQty", SqlDbType.Decimal, 28)).Value = model.FSaleQty;
            }
            if (model.FAuxSaleQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxSaleQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxSaleQty", SqlDbType.Decimal, 28)).Value = model.FAuxSaleQty;
            }
            if (model.FSelQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSelQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSelQty", SqlDbType.Decimal, 28)).Value = model.FSelQty;
            }
            if (model.FAuxSelQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxSelQty", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxSelQty", SqlDbType.Decimal, 28)).Value = model.FAuxSelQty;
            }
            if (model.FOrderClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderClosed", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderClosed", SqlDbType.Int, 0)).Value = model.FOrderClosed;
            }
            if (model.FMRPLockFlag == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMRPLockFlag", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMRPLockFlag", SqlDbType.Int, 0)).Value = model.FMRPLockFlag;
            }
            if (model.FSourceTranType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceTranType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceTranType", SqlDbType.Int, 0)).Value = model.FSourceTranType;
            }
            if (model.FSourceInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceInterID", SqlDbType.Int, 0)).Value = model.FSourceInterID;
            }
            if (model.FSourceBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceBillNo", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceBillNo", SqlDbType.NVarChar, 255)).Value = model.FSourceBillNo;
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
            if (model.FBOMCategory == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBOMCategory", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBOMCategory", SqlDbType.Int, 0)).Value = model.FBOMCategory;
            }
            if (model.FIsAPS == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsAPS", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsAPS", SqlDbType.Int, 0)).Value = model.FIsAPS;
            }
            if (model.FMeetDelivery == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMeetDelivery", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMeetDelivery", SqlDbType.Int, 0)).Value = model.FMeetDelivery;
            }
            if (model.FAuxPropID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPropID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAuxPropID", SqlDbType.Int, 0)).Value = model.FAuxPropID;
            }
            if (model.FOrderBOMStatus == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMStatus", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMStatus", SqlDbType.Int, 0)).Value = model.FOrderBOMStatus;
            }
            if (model.FOrderBOMInterID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMInterID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderBOMInterID", SqlDbType.Int, 0)).Value = model.FOrderBOMInterID;
            }
            if (model.FEntrySelfY0128 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfY0128", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEntrySelfY0128", SqlDbType.VarChar, 255)).Value = model.FEntrySelfY0128;
            }

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }
    }
}
