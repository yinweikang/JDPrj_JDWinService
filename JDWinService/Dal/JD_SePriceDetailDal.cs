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
    public class JD_SePriceDetailDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        Common common = new Common();
        public bool IsExist(int itemid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM JD_SePriceDetail WHERE ItemID = @m_ItemID", con);
            con.Open();
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = itemid;

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
        /// 对象JD_SePriceDetail明细
        /// 编写人：ywk
        /// 编写日期：2018/7/26 星期四
        /// </summary>
        public JD_SePriceDetail Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_SePriceDetail WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_SePriceDetail myDetail = new JD_SePriceDetail();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["Operater"])) { myDetail.Operater = Convert.ToString(myReader["Operater"]); }
                if (!Convert.IsDBNull(myReader["CreateTime"])) { myDetail.CreateTime = Convert.ToDateTime(myReader["CreateTime"]); }
                if (!Convert.IsDBNull(myReader["ShortName"])) { myDetail.ShortName = Convert.ToString(myReader["ShortName"]); }
                if (!Convert.IsDBNull(myReader["CustomCode"])) { myDetail.CustomCode = Convert.ToString(myReader["CustomCode"]); }
                if (!Convert.IsDBNull(myReader["CustomName"])) { myDetail.CustomName = Convert.ToString(myReader["CustomName"]); }
                if (!Convert.IsDBNull(myReader["FNumber"])) { myDetail.FNumber = Convert.ToString(myReader["FNumber"]); }
                if (!Convert.IsDBNull(myReader["FModel"])) { myDetail.FModel = Convert.ToString(myReader["FModel"]); }
                if (!Convert.IsDBNull(myReader["CoinType"])) { myDetail.CoinType = Convert.ToString(myReader["CoinType"]); }
                if (!Convert.IsDBNull(myReader["BeginSalesCount"])) { myDetail.BeginSalesCount = Convert.ToDecimal(myReader["BeginSalesCount"]); }
                if (!Convert.IsDBNull(myReader["EndSalesCount"])) { myDetail.EndSalesCount = Convert.ToDecimal(myReader["EndSalesCount"]); }
                if (!Convert.IsDBNull(myReader["Price"])) { myDetail.Price = Convert.ToDecimal(myReader["Price"]); }
                if (!Convert.IsDBNull(myReader["BeginTime"])) { myDetail.BeginTime = Convert.ToDateTime(myReader["BeginTime"]); }
                if (!Convert.IsDBNull(myReader["EndTime"])) { myDetail.EndTime = Convert.ToDateTime(myReader["EndTime"]); }
                if (!Convert.IsDBNull(myReader["IsNew"])) { myDetail.IsNew = Convert.ToString(myReader["IsNew"]); }
                if (!Convert.IsDBNull(myReader["MOQ"])) { myDetail.MOQ = Convert.ToDecimal(myReader["MOQ"]); }
                if (!Convert.IsDBNull(myReader["LimitTimes"])) { myDetail.LimitTimes = Convert.ToString(myReader["LimitTimes"]); }
                if (!Convert.IsDBNull(myReader["CaiWuRemarks"])) { myDetail.CaiWuRemarks = Convert.ToString(myReader["CaiWuRemarks"]); }
                if (!Convert.IsDBNull(myReader["PlanRemarks"])) { myDetail.PlanRemarks = Convert.ToString(myReader["PlanRemarks"]); }
                if (!Convert.IsDBNull(myReader["ApplyType"])) { myDetail.ApplyType = Convert.ToString(myReader["ApplyType"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        public JD_SePriceDetail Detail(string CustomeCode, string FNumber, decimal FromCount, decimal EndCount)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_SePriceDetail WHERE  CustomCode = @m_CustomCode and FNumber = @m_FNumber and BeginSalesCount = @m_BeginSalesCount and EndSalesCount = @m_EndSalesCount", con);
            con.Open();
           
 
            cmd.Parameters.Add(new SqlParameter("@m_CustomCode", SqlDbType.NVarChar, 50)).Value = CustomeCode;
            cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = FNumber;
            cmd.Parameters.Add(new SqlParameter("@m_BeginSalesCount", SqlDbType.Decimal, 18)).Value = FromCount;
            cmd.Parameters.Add(new SqlParameter("@m_EndSalesCount", SqlDbType.Decimal, 18)).Value = EndCount;
           
            JD_SePriceDetail myDetail = new JD_SePriceDetail();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["Operater"])) { myDetail.Operater = Convert.ToString(myReader["Operater"]); }
                if (!Convert.IsDBNull(myReader["CreateTime"])) { myDetail.CreateTime = Convert.ToDateTime(myReader["CreateTime"]); }
                if (!Convert.IsDBNull(myReader["ShortName"])) { myDetail.ShortName = Convert.ToString(myReader["ShortName"]); }
                if (!Convert.IsDBNull(myReader["CustomCode"])) { myDetail.CustomCode = Convert.ToString(myReader["CustomCode"]); }
                if (!Convert.IsDBNull(myReader["CustomName"])) { myDetail.CustomName = Convert.ToString(myReader["CustomName"]); }
                if (!Convert.IsDBNull(myReader["FNumber"])) { myDetail.FNumber = Convert.ToString(myReader["FNumber"]); }
                if (!Convert.IsDBNull(myReader["FModel"])) { myDetail.FModel = Convert.ToString(myReader["FModel"]); }
                if (!Convert.IsDBNull(myReader["CoinType"])) { myDetail.CoinType = Convert.ToString(myReader["CoinType"]); }
                if (!Convert.IsDBNull(myReader["BeginSalesCount"])) { myDetail.BeginSalesCount = Convert.ToDecimal(myReader["BeginSalesCount"]); }
                if (!Convert.IsDBNull(myReader["EndSalesCount"])) { myDetail.EndSalesCount = Convert.ToDecimal(myReader["EndSalesCount"]); }
                if (!Convert.IsDBNull(myReader["Price"])) { myDetail.Price = Convert.ToDecimal(myReader["Price"]); }
                if (!Convert.IsDBNull(myReader["BeginTime"])) { myDetail.BeginTime = Convert.ToDateTime(myReader["BeginTime"]); }
                if (!Convert.IsDBNull(myReader["EndTime"])) { myDetail.EndTime = Convert.ToDateTime(myReader["EndTime"]); }
                if (!Convert.IsDBNull(myReader["IsNew"])) { myDetail.IsNew = Convert.ToString(myReader["IsNew"]); }
                if (!Convert.IsDBNull(myReader["MOQ"])) { myDetail.MOQ = Convert.ToDecimal(myReader["MOQ"]); }
                if (!Convert.IsDBNull(myReader["LimitTimes"])) { myDetail.LimitTimes = Convert.ToString(myReader["LimitTimes"]); }
                if (!Convert.IsDBNull(myReader["CaiWuRemarks"])) { myDetail.CaiWuRemarks = Convert.ToString(myReader["CaiWuRemarks"]); }
                if (!Convert.IsDBNull(myReader["PlanRemarks"])) { myDetail.PlanRemarks = Convert.ToString(myReader["PlanRemarks"]); }
                if (!Convert.IsDBNull(myReader["ApplyType"])) { myDetail.ApplyType = Convert.ToString(myReader["ApplyType"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }

        /// <summary>
        /// 新增JD_SePriceDetail对象
        /// 编写人：ywk
        /// 编写日期：2018/7/26 星期四
        /// </summary>
        public int Add(JD_SePriceDetail model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO JD_SePriceDetail(Operater,CreateTime,ShortName,CustomCode,CustomName,FNumber,FModel,CoinType,BeginSalesCount,EndSalesCount,Price,BeginTime,EndTime,IsNew,MOQ,LimitTimes,CaiWuRemarks,PlanRemarks,ApplyType) VALUES(@m_Operater,@m_CreateTime,@m_ShortName,@m_CustomCode,@m_CustomName,@m_FNumber,@m_FModel,@m_CoinType,@m_BeginSalesCount,@m_EndSalesCount,@m_Price,@m_BeginTime,@m_EndTime,@m_IsNew,@m_MOQ,@m_LimitTimes,@m_CaiWuRemarks,@m_PlanRemarks,@m_ApplyType) SELECT @thisId=@@IDENTITY FROM JD_SePriceDetail", con);
            con.Open();

            if (model.Operater == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = model.Operater;
            }
            if (model.CreateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = model.CreateTime;
            }
            if (model.ShortName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShortName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShortName", SqlDbType.NVarChar, 50)).Value = model.ShortName;
            }
            if (model.CustomCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomCode", SqlDbType.NVarChar, 50)).Value = model.CustomCode;
            }
            if (model.CustomName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomName", SqlDbType.NVarChar, 100)).Value = model.CustomName;
            }
            if (model.FNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 100)).Value = model.FNumber;
            }
            if (model.FModel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = model.FModel;
            }
            if (model.CoinType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinType", SqlDbType.NVarChar, 50)).Value = model.CoinType;
            }
            if (model.BeginSalesCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginSalesCount", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginSalesCount", SqlDbType.Decimal, 18)).Value = model.BeginSalesCount;
            }
            if (model.EndSalesCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndSalesCount", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndSalesCount", SqlDbType.Decimal, 18)).Value = model.EndSalesCount;
            }
            if (model.Price == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Price", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Price", SqlDbType.Decimal, 18)).Value = model.Price;
            }
            if (model.BeginTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginTime", SqlDbType.DateTime, 0)).Value = model.BeginTime;
            }
            if (model.EndTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndTime", SqlDbType.DateTime, 0)).Value = model.EndTime;
            }
            if (model.IsNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsNew", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsNew", SqlDbType.NVarChar, 50)).Value = model.IsNew;
            }
            if (model.MOQ == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.Decimal, 18)).Value = model.MOQ;
            }
            if (model.LimitTimes == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_LimitTimes", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_LimitTimes", SqlDbType.NVarChar, 50)).Value = model.LimitTimes;
            }
            if (model.CaiWuRemarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CaiWuRemarks", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CaiWuRemarks", SqlDbType.NVarChar, 100)).Value = model.CaiWuRemarks;
            }
            if (model.PlanRemarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanRemarks", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanRemarks", SqlDbType.NVarChar, 100)).Value = model.PlanRemarks;
            }
            if (model.ApplyType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyType", SqlDbType.NVarChar, 50)).Value = model.ApplyType;
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
        /// 更新JD_SePriceDetail对象
        /// 编写人：ywk
        /// 编写日期：2018/7/26 星期四
        /// </summary>
        public void Update(JD_SePriceDetail model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_SePriceDetail SET Operater = @m_Operater,CreateTime = @m_CreateTime,ShortName = @m_ShortName,CustomCode = @m_CustomCode,CustomName = @m_CustomName,FNumber = @m_FNumber,FModel = @m_FModel,CoinType = @m_CoinType,BeginSalesCount = @m_BeginSalesCount,EndSalesCount = @m_EndSalesCount,Price = @m_Price,BeginTime = @m_BeginTime,EndTime = @m_EndTime,IsNew = @m_IsNew,MOQ = @m_MOQ,LimitTimes = @m_LimitTimes,CaiWuRemarks = @m_CaiWuRemarks,PlanRemarks = @m_PlanRemarks,ApplyType = @m_ApplyType WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.Operater == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Operater", SqlDbType.NVarChar, 50)).Value = model.Operater;
            }
            if (model.CreateTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreateTime", SqlDbType.DateTime, 0)).Value = model.CreateTime;
            }
            if (model.ShortName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShortName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShortName", SqlDbType.NVarChar, 50)).Value = model.ShortName;
            }
            if (model.CustomCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomCode", SqlDbType.NVarChar, 50)).Value = model.CustomCode;
            }
            if (model.CustomName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomName", SqlDbType.NVarChar, 100)).Value = model.CustomName;
            }
            if (model.FNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 100)).Value = model.FNumber;
            }
            if (model.FModel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 500)).Value = model.FModel;
            }
            if (model.CoinType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CoinType", SqlDbType.NVarChar, 50)).Value = model.CoinType;
            }
            if (model.BeginSalesCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginSalesCount", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginSalesCount", SqlDbType.Decimal, 18)).Value = model.BeginSalesCount;
            }
            if (model.EndSalesCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndSalesCount", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndSalesCount", SqlDbType.Decimal, 18)).Value = model.EndSalesCount;
            }
            if (model.Price == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Price", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Price", SqlDbType.Decimal, 18)).Value = model.Price;
            }
            if (model.BeginTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BeginTime", SqlDbType.DateTime, 0)).Value = model.BeginTime;
            }
            if (model.EndTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_EndTime", SqlDbType.DateTime, 0)).Value = model.EndTime;
            }
            if (model.IsNew == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsNew", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsNew", SqlDbType.NVarChar, 50)).Value = model.IsNew;
            }
            if (model.MOQ == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MOQ", SqlDbType.Decimal, 18)).Value = model.MOQ;
            }
            if (model.LimitTimes == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_LimitTimes", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_LimitTimes", SqlDbType.NVarChar, 50)).Value = model.LimitTimes;
            }
            if (model.CaiWuRemarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CaiWuRemarks", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CaiWuRemarks", SqlDbType.NVarChar, 100)).Value = model.CaiWuRemarks;
            }
            if (model.PlanRemarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanRemarks", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PlanRemarks", SqlDbType.NVarChar, 100)).Value = model.PlanRemarks;
            }
            if (model.ApplyType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyType", SqlDbType.NVarChar, 50)).Value = model.ApplyType;
            }
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID;

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        public void HandlePriceData(int ItemID, string FileName,int TaskID)
        {
            JD_SePriceApply_LogDal Logdal = new JD_SePriceApply_LogDal();
            JD_SePriceDetailDal dal = new JD_SePriceDetailDal();
            //找到需要更新的数据 
            JD_SePriceApply_Log logmodel = Logdal.Detail(ItemID);
            JD_SePriceDetail seprimodel = new JD_SePriceDetail();
            string ErrorMsg = string.Empty;
            if (logmodel != null)
            {
                try
                {
                    //如果ApplyType 为Add 即新增  Edit为变更
                    #region 新增
                    if (logmodel.ApplyType == "Add")
                    {
                        seprimodel = Detail(logmodel.CustomCode, logmodel.FNumber, logmodel.BeginSalesCount, logmodel.EndSalesCount);
                        //如果是新增的是相同的更新价格
                        if (!string.IsNullOrEmpty(seprimodel.CustomCode))
                        {
                            seprimodel.Price = logmodel.Price;
                            dal.Update(seprimodel);
                            logmodel.ParentID = seprimodel.ItemID;
                        }
                        else
                        {
                            #region 新增销售限价
                            int ParentID = dal.Add(new JD_SePriceDetail
                            {
                                Operater = logmodel.Operater,
                                ShortName = logmodel.ShortName,
                                CustomCode = logmodel.CustomCode,
                                CustomName = logmodel.CustomName,
                                FNumber = logmodel.FNumber,
                                FModel = logmodel.FModel,
                                CoinType = logmodel.CoinType,
                                BeginSalesCount = logmodel.BeginSalesCount,
                                EndSalesCount = logmodel.EndSalesCount,
                                Price = logmodel.Price,
                                BeginTime = logmodel.BeginTime,
                                EndTime = logmodel.EndTime,
                                IsNew = logmodel.IsNew,
                                MOQ = logmodel.MOQ,
                                LimitTimes = logmodel.LimitTimes,
                                CaiWuRemarks = logmodel.CaiWuRemarks,
                                PlanRemarks = logmodel.PlanRemarks,
                                ApplyType = logmodel.ApplyType,
                                CreateTime = DateTime.Now
                            });
                            logmodel.ParentID = ParentID;
                            #endregion
                        }

                    }
                    #endregion

                    #region 变更
                    else if (logmodel.ApplyType == "Edit")
                    {
                        JD_SePriceDetail derailModel = dal.Detail(logmodel.ParentID);
                        if (derailModel != null)
                        {

                            derailModel.ShortName = logmodel.ShortName;
                            derailModel.CustomCode = logmodel.CustomCode;
                            derailModel.CustomName = logmodel.CustomName;
                            derailModel.FNumber = logmodel.FNumber;
                            derailModel.FModel = logmodel.FModel;
                            derailModel.CoinType = logmodel.CoinType;
                            derailModel.BeginSalesCount = logmodel.BeginSalesCount;
                            derailModel.EndSalesCount = logmodel.EndSalesCount;
                            derailModel.Price = logmodel.Price;
                            derailModel.BeginTime = logmodel.BeginTime;
                            derailModel.EndTime = logmodel.EndTime;
                            derailModel.IsNew = logmodel.IsNew;
                            derailModel.MOQ = logmodel.MOQ;
                            derailModel.LimitTimes = logmodel.LimitTimes;
                            derailModel.CaiWuRemarks = logmodel.CaiWuRemarks;
                            derailModel.PlanRemarks = logmodel.PlanRemarks;
                            dal.Update(derailModel);
                        }
                    }
                    #endregion

                   
                }
                catch (Exception ex)
                {
                    common.WriteLogs(FileName, ItemID.ToString(), ex.Message);
                    ErrorMsg = ex.Message;
                }
                finally {
                    if (!string.IsNullOrEmpty(ErrorMsg))
                    {
                        //本地集成
                        common.AddLogQueue(TaskID, "JD_SePriceApply_Log", ItemID, "SQL", ErrorMsg, false);
                    }
                    else
                    {
                        common.AddLogQueue(TaskID, "JD_SePriceApply_Log", ItemID, "SQL", "操作成功", true);
                    }
                    logmodel.IsUpdate = "1";
                    Logdal.Update(logmodel);
                }
            }





        }
    }
}
