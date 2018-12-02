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
using System.Net;
using System.IO;


namespace JDWinService.Dal
{
    public class JD_IcItemPrjBGApply_LogDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息 
        Common common = new Common();
        /// <summary>
        /// 对象JD_IcItemPrjBGApply_Log明细
        /// 编写人：ywk
        /// 编写日期：2018/10/11 星期四
        /// </summary>
        public JD_IcItemPrjBGApply_Log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_IcItemPrjBGApply_Log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_IcItemPrjBGApply_Log myDetail = new JD_IcItemPrjBGApply_Log();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["Requester"])) { myDetail.Requester = Convert.ToString(myReader["Requester"]); }
                if (!Convert.IsDBNull(myReader["RequestDate"])) { myDetail.RequestDate = Convert.ToDateTime(myReader["RequestDate"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["SNumber"])) { myDetail.SNumber = Convert.ToString(myReader["SNumber"]); }
                if (!Convert.IsDBNull(myReader["FItemID"])) { myDetail.FItemID = Convert.ToInt32(myReader["FItemID"]); }
                if (!Convert.IsDBNull(myReader["FNumber"])) { myDetail.FNumber = Convert.ToString(myReader["FNumber"]); }
                if (!Convert.IsDBNull(myReader["FName"])) { myDetail.FName = Convert.ToString(myReader["FName"]); }
                if (!Convert.IsDBNull(myReader["FFullName"])) { myDetail.FFullName = Convert.ToString(myReader["FFullName"]); }
                if (!Convert.IsDBNull(myReader["FNameNew"])) { myDetail.FNameNew = Convert.ToString(myReader["FNameNew"]); }
                if (!Convert.IsDBNull(myReader["FModel"])) { myDetail.FModel = Convert.ToString(myReader["FModel"]); }
                if (!Convert.IsDBNull(myReader["FModelNew"])) { myDetail.FModelNew = Convert.ToString(myReader["FModelNew"]); }
                if (!Convert.IsDBNull(myReader["FNetWeight"])) { myDetail.FNetWeight = Convert.ToDecimal(myReader["FNetWeight"]); }
                if (!Convert.IsDBNull(myReader["FNetWeightNew"])) { myDetail.FNetWeightNew = Convert.ToDecimal(myReader["FNetWeightNew"]); }
                if (!Convert.IsDBNull(myReader["FGrossWeight"])) { myDetail.FGrossWeight = Convert.ToDecimal(myReader["FGrossWeight"]); }
                if (!Convert.IsDBNull(myReader["FGrossWeightNew"])) { myDetail.FGrossWeightNew = Convert.ToDecimal(myReader["FGrossWeightNew"]); }
                if (!Convert.IsDBNull(myReader["FPPQ"])) { myDetail.FPPQ = Convert.ToDouble(myReader["FPPQ"]); }
                if (!Convert.IsDBNull(myReader["FPPQNew"])) { myDetail.FPPQNew = Convert.ToDouble(myReader["FPPQNew"]); }
                if (!Convert.IsDBNull(myReader["Remarks"])) { myDetail.Remarks = Convert.ToString(myReader["Remarks"]); }
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
        /// 更新JD_IcItemPrjBGApply_Log对象
        /// 编写人：ywk
        /// 编写日期：2018/10/11 星期四
        /// </summary>
        public void Update(JD_IcItemPrjBGApply_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_IcItemPrjBGApply_Log SET Requester = @m_Requester,RequestDate = @m_RequestDate,TaskID = @m_TaskID,SNumber = @m_SNumber,FItemID = @m_FItemID,FNumber = @m_FNumber,FName = @m_FName,FFullName = @m_FFullName,FNameNew = @m_FNameNew,FModel = @m_FModel,FModelNew = @m_FModelNew,FNetWeight = @m_FNetWeight,FNetWeightNew = @m_FNetWeightNew,FGrossWeight = @m_FGrossWeight,FGrossWeightNew = @m_FGrossWeightNew,FPPQ = @m_FPPQ,FPPQNew = @m_FPPQNew,Remarks = @m_Remarks,UpdateTime = @m_UpdateTime,IsUpdate = @m_IsUpdate WHERE ItemID = @m_ItemID", con);
            con.Open();

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
            if (model.FItemID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FItemID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FItemID", SqlDbType.Int, 0)).Value = model.FItemID;
            }
            if (model.FNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = model.FNumber;
            }
            if (model.FName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.NVarChar, 100)).Value = model.FName;
            }
            if (model.FFullName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFullName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFullName", SqlDbType.NVarChar, 100)).Value = model.FFullName;
            }
            if (model.FNameNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNameNew", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNameNew", SqlDbType.NVarChar, 100)).Value = model.FNameNew;
            }
            if (model.FModel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NText, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NText, 0)).Value = model.FModel;
            }
            if (model.FModelNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModelNew", SqlDbType.NText, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModelNew", SqlDbType.NText, 0)).Value = model.FModelNew;
            }
            if (model.FNetWeight == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNetWeight", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNetWeight", SqlDbType.Decimal, 18)).Value = model.FNetWeight;
            }
            if (model.FNetWeightNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNetWeightNew", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNetWeightNew", SqlDbType.Decimal, 18)).Value = model.FNetWeightNew;
            }
            if (model.FGrossWeight == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FGrossWeight", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FGrossWeight", SqlDbType.Decimal, 18)).Value = model.FGrossWeight;
            }
            if (model.FGrossWeightNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FGrossWeightNew", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FGrossWeightNew", SqlDbType.Decimal, 18)).Value = model.FGrossWeightNew;
            }
            if (model.FPPQ == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPPQ", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPPQ", SqlDbType.Float, 0)).Value = model.FPPQ;
            }
            if (model.FPPQNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPPQNew", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPPQNew", SqlDbType.Float, 0)).Value = model.FPPQNew;
            }
            if (model.Remarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Remarks", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Remarks", SqlDbType.NVarChar, 100)).Value = model.Remarks;
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



        protected DataView GetDistinct()
        {
            string sql = string.Format(@" select * from JD_IcItemPrjBGApply_Log where IsUpdate=0 ");
            return DBUtil.Query(sql).Tables[0].DefaultView;
        }

        public void UpdateItemInfo()
        {
            DataView dv = GetDistinct();
            if (dv.Count > 0)
            {
                JD_IcItemPrjBGApply_Log model = new JD_IcItemPrjBGApply_Log();
                foreach (DataRowView dr in dv)
                {
                    string ErrorMsg = string.Empty;
                    string sql = string.Empty;
                    try {
                        int ItemID = Convert.ToInt32(dr["ItemID"].ToString());
                        int FItemID= Convert.ToInt32(dr["FItemID"].ToString());
                        model = Detail(ItemID);
                        #region 更新PPQ
                        if (model.FPPQ != model.FPPQNew)
                        {
                            sql = string.Format(@" update t_ICItemCustom set f_119='{0}' where FItemID='{1}'",model.FPPQNew.ToString(), FItemID.ToString());
                            DBUtil.ExecuteSql(sql, K3connectionString);
                        }
                        #endregion

                        #region 更新fname,fmodel
                        if (model.FName != model.FNameNew)
                        {
                            sql = string.Format(@" update t_ICItemCore set fname='{0}' where FItemID='{1}'", model.FNameNew.ToString(), FItemID.ToString());
                            DBUtil.ExecuteSql(sql, K3connectionString);
                        } 

                        if (model.FModel != model.FModelNew)
                        {
                            sql = string.Format(@" update t_ICItemCore set FModel='{0}' where FItemID='{1}'", model.FModelNew.ToString(), FItemID.ToString());
                            DBUtil.ExecuteSql(sql, K3connectionString);
                        }
                        #endregion

                        #region 更新全名
                        if (model.FFullName.IndexOf('_') > -1 &&(model.FName!=model.FNameNew))
                        {
                            model.FFullName = model.FFullName.Split('_')[0] + "_" + model.FNameNew;
                            sql = string.Format(@" update t_ICItemBase set FFullName='{0}'  where FItemID='{1}'", model.FFullName, FItemID.ToString());
                            DBUtil.ExecuteSql(sql, K3connectionString);
                        }
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        ErrorMsg = ex.Message;
                    }
                    finally {
                        model.IsUpdate = 1;
                        model.UpdateTime = DateTime.Now;
                        Update(model);
                        //显示到集成日志的应用中
                        common.AddLogQueue(model.TaskID, "JD_IcItemPrjBGApply_Log", model.ItemID, "SQL", ErrorMsg);
                    }
                }
            }
        }
       
    }
}
