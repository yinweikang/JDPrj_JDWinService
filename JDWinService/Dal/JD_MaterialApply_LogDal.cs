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
    public class JD_MaterialApply_LogDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息

        /// <summary>
		/// 对象JD_MaterialApply_Log明细
		/// 编写人：ywk
		/// 编写日期：2018/9/30 星期日
		/// </summary>
		public JD_MaterialApply_Log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_MaterialApply_Log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_MaterialApply_Log myDetail = new JD_MaterialApply_Log();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["RequestUser"])) { myDetail.RequestUser = Convert.ToString(myReader["RequestUser"]); }
                if (!Convert.IsDBNull(myReader["RequestDate"])) { myDetail.RequestDate = Convert.ToDateTime(myReader["RequestDate"]); }
                if (!Convert.IsDBNull(myReader["SNumber"])) { myDetail.SNumber = Convert.ToString(myReader["SNumber"]); }
                if (!Convert.IsDBNull(myReader["FType"])) { myDetail.FType = Convert.ToString(myReader["FType"]); }
                if (!Convert.IsDBNull(myReader["FName"])) { myDetail.FName = Convert.ToString(myReader["FName"]); }
                if (!Convert.IsDBNull(myReader["FNumber"])) { myDetail.FNumber = Convert.ToString(myReader["FNumber"]); }
                if (!Convert.IsDBNull(myReader["FFullName"])) { myDetail.FFullName = Convert.ToString(myReader["FFullName"]); }
                if (!Convert.IsDBNull(myReader["FModel"])) { myDetail.FModel = Convert.ToString(myReader["FModel"]); }
                if (!Convert.IsDBNull(myReader["FErpClsID"])) { myDetail.FErpClsID = Convert.ToString(myReader["FErpClsID"]); }
                if (!Convert.IsDBNull(myReader["FErpClsIDNum"])) { myDetail.FErpClsIDNum = Convert.ToString(myReader["FErpClsIDNum"]); }
                if (!Convert.IsDBNull(myReader["FUnitGroupID"])) { myDetail.FUnitGroupID = Convert.ToString(myReader["FUnitGroupID"]); }
                if (!Convert.IsDBNull(myReader["FUnitGroupIDNum"])) { myDetail.FUnitGroupIDNum = Convert.ToString(myReader["FUnitGroupIDNum"]); }
                if (!Convert.IsDBNull(myReader["FUnitID"])) { myDetail.FUnitID = Convert.ToString(myReader["FUnitID"]); }
                if (!Convert.IsDBNull(myReader["FUnitIDNum"])) { myDetail.FUnitIDNum = Convert.ToString(myReader["FUnitIDNum"]); }
                if (!Convert.IsDBNull(myReader["FOrderUnitID"])) { myDetail.FOrderUnitID = Convert.ToString(myReader["FOrderUnitID"]); }
                if (!Convert.IsDBNull(myReader["FOrderUnitIDNum"])) { myDetail.FOrderUnitIDNum = Convert.ToString(myReader["FOrderUnitIDNum"]); }
                if (!Convert.IsDBNull(myReader["FSaleUnitID"])) { myDetail.FSaleUnitID = Convert.ToString(myReader["FSaleUnitID"]); }
                if (!Convert.IsDBNull(myReader["FSaleUnitIDNum"])) { myDetail.FSaleUnitIDNum = Convert.ToString(myReader["FSaleUnitIDNum"]); }
                if (!Convert.IsDBNull(myReader["FProductUnitID"])) { myDetail.FProductUnitID = Convert.ToString(myReader["FProductUnitID"]); }
                if (!Convert.IsDBNull(myReader["FProductUnitIDNum"])) { myDetail.FProductUnitIDNum = Convert.ToString(myReader["FProductUnitIDNum"]); }
                if (!Convert.IsDBNull(myReader["FStoreUnitID"])) { myDetail.FStoreUnitID = Convert.ToString(myReader["FStoreUnitID"]); }
                if (!Convert.IsDBNull(myReader["FStoreUnitIDNum"])) { myDetail.FStoreUnitIDNum = Convert.ToString(myReader["FStoreUnitIDNum"]); }
                if (!Convert.IsDBNull(myReader["MakerName"])) { myDetail.MakerName = Convert.ToString(myReader["MakerName"]); }
                if (!Convert.IsDBNull(myReader["MakerCode"])) { myDetail.MakerCode = Convert.ToString(myReader["MakerCode"]); }
                if (!Convert.IsDBNull(myReader["MakerVersion"])) { myDetail.MakerVersion = Convert.ToString(myReader["MakerVersion"]); }
                if (!Convert.IsDBNull(myReader["FISKFPeriod"])) { myDetail.FISKFPeriod = Convert.ToString(myReader["FISKFPeriod"]); }
                if (!Convert.IsDBNull(myReader["FKFPeriod"])) { myDetail.FKFPeriod = Convert.ToInt32(myReader["FKFPeriod"]); }
                if (!Convert.IsDBNull(myReader["FStockTime"])) { myDetail.FStockTime = Convert.ToString(myReader["FStockTime"]); }
                if (!Convert.IsDBNull(myReader["FBatchManager"])) { myDetail.FBatchManager = Convert.ToString(myReader["FBatchManager"]); }
                if (!Convert.IsDBNull(myReader["FTrack"])) { myDetail.FTrack = Convert.ToString(myReader["FTrack"]); }
                if (!Convert.IsDBNull(myReader["FTrackNum"])) { myDetail.FTrackNum = Convert.ToString(myReader["FTrackNum"]); }
                if (!Convert.IsDBNull(myReader["FAcctID"])) { myDetail.FAcctID = Convert.ToString(myReader["FAcctID"]); }
                if (!Convert.IsDBNull(myReader["FAcctIDNum"])) { myDetail.FAcctIDNum = Convert.ToString(myReader["FAcctIDNum"]); }
                if (!Convert.IsDBNull(myReader["FSaleAcctID"])) { myDetail.FSaleAcctID = Convert.ToString(myReader["FSaleAcctID"]); }
                if (!Convert.IsDBNull(myReader["FSaleAcctIDNum"])) { myDetail.FSaleAcctIDNum = Convert.ToString(myReader["FSaleAcctIDNum"]); }
                if (!Convert.IsDBNull(myReader["FCostAcctID"])) { myDetail.FCostAcctID = Convert.ToString(myReader["FCostAcctID"]); }
                if (!Convert.IsDBNull(myReader["FCostAcctIDNum"])) { myDetail.FCostAcctIDNum = Convert.ToString(myReader["FCostAcctIDNum"]); }
                if (!Convert.IsDBNull(myReader["FGoodSpec"])) { myDetail.FGoodSpec = Convert.ToString(myReader["FGoodSpec"]); }
                if (!Convert.IsDBNull(myReader["FGoodSpecNum"])) { myDetail.FGoodSpecNum = Convert.ToString(myReader["FGoodSpecNum"]); }
                if (!Convert.IsDBNull(myReader["FCBRestore"])) { myDetail.FCBRestore = Convert.ToString(myReader["FCBRestore"]); }
                if (!Convert.IsDBNull(myReader["FNote"])) { myDetail.FNote = Convert.ToString(myReader["FNote"]); }
                if (!Convert.IsDBNull(myReader["FPutInteger"])) { myDetail.FPutInteger = Convert.ToString(myReader["FPutInteger"]); }
                if (!Convert.IsDBNull(myReader["FPlanTrategy"])) { myDetail.FPlanTrategy = Convert.ToString(myReader["FPlanTrategy"]); }
                if (!Convert.IsDBNull(myReader["FPlanTrategyNum"])) { myDetail.FPlanTrategyNum = Convert.ToString(myReader["FPlanTrategyNum"]); }
                if (!Convert.IsDBNull(myReader["FPlanMode"])) { myDetail.FPlanMode = Convert.ToString(myReader["FPlanMode"]); }
                if (!Convert.IsDBNull(myReader["FPlanModeNum"])) { myDetail.FPlanModeNum = Convert.ToString(myReader["FPlanModeNum"]); }
                if (!Convert.IsDBNull(myReader["FOrderTrategy"])) { myDetail.FOrderTrategy = Convert.ToString(myReader["FOrderTrategy"]); }
                if (!Convert.IsDBNull(myReader["FOrderTrategyNum"])) { myDetail.FOrderTrategyNum = Convert.ToString(myReader["FOrderTrategyNum"]); }
                if (!Convert.IsDBNull(myReader["FQtyMin"])) { myDetail.FQtyMin = Convert.ToInt32(myReader["FQtyMin"]); }
                if (!Convert.IsDBNull(myReader["FQtyMax"])) { myDetail.FQtyMax = Convert.ToInt32(myReader["FQtyMax"]); }
                if (!Convert.IsDBNull(myReader["FIsFixedReOrder"])) { myDetail.FIsFixedReOrder = Convert.ToString(myReader["FIsFixedReOrder"]); }
                if (!Convert.IsDBNull(myReader["FCtrlType"])) { myDetail.FCtrlType = Convert.ToString(myReader["FCtrlType"]); }
                if (!Convert.IsDBNull(myReader["FCtrlTypeNum"])) { myDetail.FCtrlTypeNum = Convert.ToString(myReader["FCtrlTypeNum"]); }
                if (!Convert.IsDBNull(myReader["F_114"])) { myDetail.F_114 = Convert.ToString(myReader["F_114"]); }
                if (!Convert.IsDBNull(myReader["F_115"])) { myDetail.F_115 = Convert.ToString(myReader["F_115"]); }
                if (!Convert.IsDBNull(myReader["FStandardManHour"])) { myDetail.FStandardManHour = Convert.ToInt32(myReader["FStandardManHour"]); }
                if (!Convert.IsDBNull(myReader["F_122"])) { myDetail.F_122 = Convert.ToInt32(myReader["F_122"]); }
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
        /// 更新JD_MaterialApply_Log对象
        /// 编写人：ywk
        /// 编写日期：2018/9/30 星期日
        /// </summary>
        public void Update(JD_MaterialApply_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_MaterialApply_Log SET TaskID = @m_TaskID,RequestUser = @m_RequestUser,RequestDate = @m_RequestDate,SNumber = @m_SNumber,FType = @m_FType,FName = @m_FName,FNumber = @m_FNumber,FFullName = @m_FFullName,FModel = @m_FModel,FErpClsID = @m_FErpClsID,FErpClsIDNum = @m_FErpClsIDNum,FUnitGroupID = @m_FUnitGroupID,FUnitGroupIDNum = @m_FUnitGroupIDNum,FUnitID = @m_FUnitID,FUnitIDNum = @m_FUnitIDNum,FOrderUnitID = @m_FOrderUnitID,FOrderUnitIDNum = @m_FOrderUnitIDNum,FSaleUnitID = @m_FSaleUnitID,FSaleUnitIDNum = @m_FSaleUnitIDNum,FProductUnitID = @m_FProductUnitID,FProductUnitIDNum = @m_FProductUnitIDNum,FStoreUnitID = @m_FStoreUnitID,FStoreUnitIDNum = @m_FStoreUnitIDNum,MakerName = @m_MakerName,MakerCode = @m_MakerCode,MakerVersion = @m_MakerVersion,FISKFPeriod = @m_FISKFPeriod,FKFPeriod = @m_FKFPeriod,FStockTime = @m_FStockTime,FBatchManager = @m_FBatchManager,FTrack = @m_FTrack,FTrackNum = @m_FTrackNum,FAcctID = @m_FAcctID,FAcctIDNum = @m_FAcctIDNum,FSaleAcctID = @m_FSaleAcctID,FSaleAcctIDNum = @m_FSaleAcctIDNum,FCostAcctID = @m_FCostAcctID,FCostAcctIDNum = @m_FCostAcctIDNum,FGoodSpec = @m_FGoodSpec,FGoodSpecNum = @m_FGoodSpecNum,FCBRestore = @m_FCBRestore,FNote = @m_FNote,FPutInteger = @m_FPutInteger,FPlanTrategy = @m_FPlanTrategy,FPlanTrategyNum = @m_FPlanTrategyNum,FPlanMode = @m_FPlanMode,FPlanModeNum = @m_FPlanModeNum,FOrderTrategy = @m_FOrderTrategy,FOrderTrategyNum = @m_FOrderTrategyNum,FQtyMin = @m_FQtyMin,FQtyMax = @m_FQtyMax,FIsFixedReOrder = @m_FIsFixedReOrder,FCtrlType = @m_FCtrlType,FCtrlTypeNum = @m_FCtrlTypeNum,F_114 = @m_F_114,F_115 = @m_F_115,FStandardManHour = @m_FStandardManHour,F_122 = @m_F_122,UpdateTime = @m_UpdateTime,IsUpdate = @m_IsUpdate WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.TaskID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = model.TaskID;
            }
            if (model.RequestUser == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestUser", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestUser", SqlDbType.NVarChar, 50)).Value = model.RequestUser;
            }
            if (model.RequestDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestDate", SqlDbType.DateTime, 0)).Value = model.RequestDate;
            }
            if (model.SNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = model.SNumber;
            }
            if (model.FType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FType", SqlDbType.NVarChar, 50)).Value = model.FType;
            }
            if (model.FName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.NVarChar, 100)).Value = model.FName;
            }
            if (model.FNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 100)).Value = model.FNumber;
            }
            if (model.FFullName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFullName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFullName", SqlDbType.NVarChar, 100)).Value = model.FFullName;
            }
            if (model.FModel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NText, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NText, 0)).Value = model.FModel;
            }
            if (model.FErpClsID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FErpClsID", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FErpClsID", SqlDbType.NVarChar, 100)).Value = model.FErpClsID;
            }
            if (model.FErpClsIDNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FErpClsIDNum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FErpClsIDNum", SqlDbType.NVarChar, 100)).Value = model.FErpClsIDNum;
            }
            if (model.FUnitGroupID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitGroupID", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitGroupID", SqlDbType.NVarChar, 100)).Value = model.FUnitGroupID;
            }
            if (model.FUnitGroupIDNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitGroupIDNum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitGroupIDNum", SqlDbType.NVarChar, 100)).Value = model.FUnitGroupIDNum;
            }
            if (model.FUnitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitID", SqlDbType.NVarChar, 100)).Value = model.FUnitID;
            }
            if (model.FUnitIDNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitIDNum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnitIDNum", SqlDbType.NVarChar, 100)).Value = model.FUnitIDNum;
            }
            if (model.FOrderUnitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderUnitID", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderUnitID", SqlDbType.NVarChar, 100)).Value = model.FOrderUnitID;
            }
            if (model.FOrderUnitIDNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderUnitIDNum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderUnitIDNum", SqlDbType.NVarChar, 100)).Value = model.FOrderUnitIDNum;
            }
            if (model.FSaleUnitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleUnitID", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleUnitID", SqlDbType.NVarChar, 100)).Value = model.FSaleUnitID;
            }
            if (model.FSaleUnitIDNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleUnitIDNum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleUnitIDNum", SqlDbType.NVarChar, 100)).Value = model.FSaleUnitIDNum;
            }
            if (model.FProductUnitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FProductUnitID", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FProductUnitID", SqlDbType.NVarChar, 100)).Value = model.FProductUnitID;
            }
            if (model.FProductUnitIDNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FProductUnitIDNum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FProductUnitIDNum", SqlDbType.NVarChar, 100)).Value = model.FProductUnitIDNum;
            }
            if (model.FStoreUnitID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStoreUnitID", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStoreUnitID", SqlDbType.NVarChar, 100)).Value = model.FStoreUnitID;
            }
            if (model.FStoreUnitIDNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStoreUnitIDNum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStoreUnitIDNum", SqlDbType.NVarChar, 100)).Value = model.FStoreUnitIDNum;
            }
            if (model.MakerName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MakerName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MakerName", SqlDbType.NVarChar, 100)).Value = model.MakerName;
            }
            if (model.MakerCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MakerCode", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MakerCode", SqlDbType.NVarChar, 100)).Value = model.MakerCode;
            }
            if (model.MakerVersion == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MakerVersion", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MakerVersion", SqlDbType.NVarChar, 100)).Value = model.MakerVersion;
            }
            if (model.FISKFPeriod == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FISKFPeriod", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FISKFPeriod", SqlDbType.NVarChar, 50)).Value = model.FISKFPeriod;
            }
            if (model.FKFPeriod == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FKFPeriod", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FKFPeriod", SqlDbType.Int, 0)).Value = model.FKFPeriod;
            }
            if (model.FStockTime == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStockTime", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStockTime", SqlDbType.NVarChar, 100)).Value = model.FStockTime;
            }
            if (model.FBatchManager == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchManager", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchManager", SqlDbType.NVarChar, 100)).Value = model.FBatchManager;
            }
            if (model.FTrack == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTrack", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTrack", SqlDbType.NVarChar, 100)).Value = model.FTrack;
            }
            if (model.FTrackNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTrackNum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTrackNum", SqlDbType.NVarChar, 100)).Value = model.FTrackNum;
            }
            if (model.FAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAcctID", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAcctID", SqlDbType.NVarChar, 100)).Value = model.FAcctID;
            }
            if (model.FAcctIDNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAcctIDNum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAcctIDNum", SqlDbType.NVarChar, 100)).Value = model.FAcctIDNum;
            }
            if (model.FSaleAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleAcctID", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleAcctID", SqlDbType.NVarChar, 100)).Value = model.FSaleAcctID;
            }
            if (model.FSaleAcctIDNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleAcctIDNum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleAcctIDNum", SqlDbType.NVarChar, 100)).Value = model.FSaleAcctIDNum;
            }
            if (model.FCostAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCostAcctID", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCostAcctID", SqlDbType.NVarChar, 100)).Value = model.FCostAcctID;
            }
            if (model.FCostAcctIDNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCostAcctIDNum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCostAcctIDNum", SqlDbType.NVarChar, 100)).Value = model.FCostAcctIDNum;
            }
            if (model.FGoodSpec == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FGoodSpec", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FGoodSpec", SqlDbType.NVarChar, 100)).Value = model.FGoodSpec;
            }
            if (model.FGoodSpecNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FGoodSpecNum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FGoodSpecNum", SqlDbType.NVarChar, 100)).Value = model.FGoodSpecNum;
            }
            if (model.FCBRestore == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCBRestore", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCBRestore", SqlDbType.NVarChar, 100)).Value = model.FCBRestore;
            }
            if (model.FNote == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNote", SqlDbType.NVarChar, 100)).Value = model.FNote;
            }
            if (model.FPutInteger == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPutInteger", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPutInteger", SqlDbType.NVarChar, 100)).Value = model.FPutInteger;
            }
            if (model.FPlanTrategy == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanTrategy", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanTrategy", SqlDbType.NVarChar, 100)).Value = model.FPlanTrategy;
            }
            if (model.FPlanTrategyNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanTrategyNum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanTrategyNum", SqlDbType.NVarChar, 100)).Value = model.FPlanTrategyNum;
            }
            if (model.FPlanMode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanMode", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanMode", SqlDbType.NVarChar, 100)).Value = model.FPlanMode;
            }
            if (model.FPlanModeNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanModeNum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPlanModeNum", SqlDbType.NVarChar, 100)).Value = model.FPlanModeNum;
            }
            if (model.FOrderTrategy == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderTrategy", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderTrategy", SqlDbType.NVarChar, 100)).Value = model.FOrderTrategy;
            }
            if (model.FOrderTrategyNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderTrategyNum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOrderTrategyNum", SqlDbType.NVarChar, 100)).Value = model.FOrderTrategyNum;
            }
            if (model.FQtyMin == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyMin", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyMin", SqlDbType.Int, 0)).Value = model.FQtyMin;
            }
            if (model.FQtyMax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyMax", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyMax", SqlDbType.Int, 0)).Value = model.FQtyMax;
            }
            if (model.FIsFixedReOrder == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsFixedReOrder", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsFixedReOrder", SqlDbType.NVarChar, 100)).Value = model.FIsFixedReOrder;
            }
            if (model.FCtrlType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCtrlType", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCtrlType", SqlDbType.NVarChar, 100)).Value = model.FCtrlType;
            }
            if (model.FCtrlTypeNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCtrlTypeNum", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCtrlTypeNum", SqlDbType.NVarChar, 100)).Value = model.FCtrlTypeNum;
            }
            if (model.F_114 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_F_114", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_F_114", SqlDbType.NVarChar, 100)).Value = model.F_114;
            }
            if (model.F_115 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_F_115", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_F_115", SqlDbType.NVarChar, 100)).Value = model.F_115;
            }
            if (model.FStandardManHour == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStandardManHour", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStandardManHour", SqlDbType.Int, 0)).Value = model.FStandardManHour;
            }
            if (model.F_122 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_F_122", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_F_122", SqlDbType.Int, 0)).Value = model.F_122;
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

        public DataView GetDistinct()
        {
            string sql = string.Format(@" select * from JD_MaterialApply_Log where IsUpdate=0");
            return DBUtil.Query(sql, connectionString).Tables[0].DefaultView;
        }

    }
}
