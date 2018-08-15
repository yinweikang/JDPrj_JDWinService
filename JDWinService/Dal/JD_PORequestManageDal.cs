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
    public class JD_PORequestManageDal
    {
        Common common = new Common();
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息

        /// <summary>
        /// 对象JD_PORequestManage明细
        /// 编写人：ywk
        /// 编写日期：2018/8/6 星期一
        /// </summary>
        public JD_PORequestManage Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_PORequestManage WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_PORequestManage myDetail = new JD_PORequestManage();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["REQType"])) { myDetail.REQType = Convert.ToString(myReader["REQType"]); }
                if (!Convert.IsDBNull(myReader["SNumber"])) { myDetail.SNumber = Convert.ToString(myReader["SNumber"]); }
                if (!Convert.IsDBNull(myReader["FNumber"])) { myDetail.FNumber = Convert.ToString(myReader["FNumber"]); }
                if (!Convert.IsDBNull(myReader["FQty"])) { myDetail.FQty = Convert.ToDecimal(myReader["FQty"]); }
                if (!Convert.IsDBNull(myReader["FLinkQty"])) { myDetail.FLinkQty = Convert.ToDecimal(myReader["FLinkQty"]); }
                if (!Convert.IsDBNull(myReader["FDate"])) { myDetail.FDate = Convert.ToDateTime(myReader["FDate"]); }
                if (!Convert.IsDBNull(myReader["FBeginDate"])) { myDetail.FBeginDate = Convert.ToDateTime(myReader["FBeginDate"]); }
                if (!Convert.IsDBNull(myReader["FOperater"])) { myDetail.FOperater = Convert.ToString(myReader["FOperater"]); }
                if (!Convert.IsDBNull(myReader["FUnit"])) { myDetail.FUnit = Convert.ToString(myReader["FUnit"]); }
                if (!Convert.IsDBNull(myReader["FPrice"])) { myDetail.FPrice = Convert.ToDecimal(myReader["FPrice"]); }
                if (!Convert.IsDBNull(myReader["FCess"])) { myDetail.FCess = Convert.ToInt32(myReader["FCess"]); }
                if (!Convert.IsDBNull(myReader["TypeNumber"])) { myDetail.TypeNumber = Convert.ToString(myReader["TypeNumber"]); }
                if (!Convert.IsDBNull(myReader["FModel"])) { myDetail.FModel = Convert.ToString(myReader["FModel"]); }
                if (!Convert.IsDBNull(myReader["FNeedQty"])) { myDetail.FNeedQty = Convert.ToDecimal(myReader["FNeedQty"]); }
                if (!Convert.IsDBNull(myReader["FFixLeadTime"])) { myDetail.FFixLeadTime = Convert.ToString(myReader["FFixLeadTime"]); }
                if (!Convert.IsDBNull(myReader["FAdmit"])) { myDetail.FAdmit = Convert.ToString(myReader["FAdmit"]); }
                if (!Convert.IsDBNull(myReader["FAPurchTime"])) { myDetail.FAPurchTime = Convert.ToDateTime(myReader["FAPurchTime"]); }
                if (!Convert.IsDBNull(myReader["FQtyMin"])) { myDetail.FQtyMin = Convert.ToDecimal(myReader["FQtyMin"]); }
                if (!Convert.IsDBNull(myReader["FBatchAppendQty"])) { myDetail.FBatchAppendQty = Convert.ToDecimal(myReader["FBatchAppendQty"]); }
                if (!Convert.IsDBNull(myReader["CostPrice"])) { myDetail.CostPrice = Convert.ToDecimal(myReader["CostPrice"]); }
                if (!Convert.IsDBNull(myReader["Flimitprice"])) { myDetail.Flimitprice = Convert.ToString(myReader["Flimitprice"]); }
                if (!Convert.IsDBNull(myReader["FOpenPo"])) { myDetail.FOpenPo = Convert.ToDecimal(myReader["FOpenPo"]); }
                if (!Convert.IsDBNull(myReader["Fpoqty"])) { myDetail.Fpoqty = Convert.ToDecimal(myReader["Fpoqty"]); }
                if (!Convert.IsDBNull(myReader["Fpoqty1"])) { myDetail.Fpoqty1 = Convert.ToDecimal(myReader["Fpoqty1"]); }
                if (!Convert.IsDBNull(myReader["Fpoqty2"])) { myDetail.Fpoqty2 = Convert.ToDecimal(myReader["Fpoqty2"]); }
                if (!Convert.IsDBNull(myReader["Fstockqty"])) { myDetail.Fstockqty = Convert.ToDecimal(myReader["Fstockqty"]); }
                if (!Convert.IsDBNull(myReader["PackageInfo"])) { myDetail.PackageInfo = Convert.ToString(myReader["PackageInfo"]); }
                if (!Convert.IsDBNull(myReader["FSecInv"])) { myDetail.FSecInv = Convert.ToDecimal(myReader["FSecInv"]); }
                if (!Convert.IsDBNull(myReader["FSourceBillNo"])) { myDetail.FSourceBillNo = Convert.ToString(myReader["FSourceBillNo"]); }
                if (!Convert.IsDBNull(myReader["FSourceEntryID"])) { myDetail.FSourceEntryID = Convert.ToString(myReader["FSourceEntryID"]); }
                if (!Convert.IsDBNull(myReader["FInterID"])) { myDetail.FInterID = Convert.ToInt32(myReader["FInterID"]); }
                if (!Convert.IsDBNull(myReader["FEntryID"])) { myDetail.FEntryID = Convert.ToInt32(myReader["FEntryID"]); }
                if (!Convert.IsDBNull(myReader["Remarks"])) { myDetail.Remarks = Convert.ToString(myReader["Remarks"]); }
                if (!Convert.IsDBNull(myReader["FsupNum"])) { myDetail.FsupNum = Convert.ToString(myReader["FsupNum"]); }
                if (!Convert.IsDBNull(myReader["IsClosed"])) { myDetail.IsClosed = Convert.ToInt32(myReader["IsClosed"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        public JD_PORequestManage Detail(string SNumber,string FNumber)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_PORequestManage WHERE SNumber = @m_SNumber and FNumber=@m_FNumber", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = SNumber;
            cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = FNumber;
            JD_PORequestManage myDetail = new JD_PORequestManage();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["REQType"])) { myDetail.REQType = Convert.ToString(myReader["REQType"]); }
                if (!Convert.IsDBNull(myReader["SNumber"])) { myDetail.SNumber = Convert.ToString(myReader["SNumber"]); }
                if (!Convert.IsDBNull(myReader["FNumber"])) { myDetail.FNumber = Convert.ToString(myReader["FNumber"]); }
                if (!Convert.IsDBNull(myReader["FQty"])) { myDetail.FQty = Convert.ToDecimal(myReader["FQty"]); }
                if (!Convert.IsDBNull(myReader["FLinkQty"])) { myDetail.FLinkQty = Convert.ToDecimal(myReader["FLinkQty"]); }
                if (!Convert.IsDBNull(myReader["FDate"])) { myDetail.FDate = Convert.ToDateTime(myReader["FDate"]); }
                if (!Convert.IsDBNull(myReader["FBeginDate"])) { myDetail.FBeginDate = Convert.ToDateTime(myReader["FBeginDate"]); }
                if (!Convert.IsDBNull(myReader["FOperater"])) { myDetail.FOperater = Convert.ToString(myReader["FOperater"]); }
                if (!Convert.IsDBNull(myReader["FUnit"])) { myDetail.FUnit = Convert.ToString(myReader["FUnit"]); }
                if (!Convert.IsDBNull(myReader["FPrice"])) { myDetail.FPrice = Convert.ToDecimal(myReader["FPrice"]); }
                if (!Convert.IsDBNull(myReader["FCess"])) { myDetail.FCess = Convert.ToInt32(myReader["FCess"]); }
                if (!Convert.IsDBNull(myReader["TypeNumber"])) { myDetail.TypeNumber = Convert.ToString(myReader["TypeNumber"]); }
                if (!Convert.IsDBNull(myReader["FModel"])) { myDetail.FModel = Convert.ToString(myReader["FModel"]); }
                if (!Convert.IsDBNull(myReader["FNeedQty"])) { myDetail.FNeedQty = Convert.ToDecimal(myReader["FNeedQty"]); }
                if (!Convert.IsDBNull(myReader["FFixLeadTime"])) { myDetail.FFixLeadTime = Convert.ToString(myReader["FFixLeadTime"]); }
                if (!Convert.IsDBNull(myReader["FAdmit"])) { myDetail.FAdmit = Convert.ToString(myReader["FAdmit"]); }
                if (!Convert.IsDBNull(myReader["FAPurchTime"])) { myDetail.FAPurchTime = Convert.ToDateTime(myReader["FAPurchTime"]); }
                if (!Convert.IsDBNull(myReader["FQtyMin"])) { myDetail.FQtyMin = Convert.ToDecimal(myReader["FQtyMin"]); }
                if (!Convert.IsDBNull(myReader["FBatchAppendQty"])) { myDetail.FBatchAppendQty = Convert.ToDecimal(myReader["FBatchAppendQty"]); }
                if (!Convert.IsDBNull(myReader["CostPrice"])) { myDetail.CostPrice = Convert.ToDecimal(myReader["CostPrice"]); }
                if (!Convert.IsDBNull(myReader["Flimitprice"])) { myDetail.Flimitprice = Convert.ToString(myReader["Flimitprice"]); }
                if (!Convert.IsDBNull(myReader["FOpenPo"])) { myDetail.FOpenPo = Convert.ToDecimal(myReader["FOpenPo"]); }
                if (!Convert.IsDBNull(myReader["Fpoqty"])) { myDetail.Fpoqty = Convert.ToDecimal(myReader["Fpoqty"]); }
                if (!Convert.IsDBNull(myReader["Fpoqty1"])) { myDetail.Fpoqty1 = Convert.ToDecimal(myReader["Fpoqty1"]); }
                if (!Convert.IsDBNull(myReader["Fpoqty2"])) { myDetail.Fpoqty2 = Convert.ToDecimal(myReader["Fpoqty2"]); }
                if (!Convert.IsDBNull(myReader["Fstockqty"])) { myDetail.Fstockqty = Convert.ToDecimal(myReader["Fstockqty"]); }
                if (!Convert.IsDBNull(myReader["PackageInfo"])) { myDetail.PackageInfo = Convert.ToString(myReader["PackageInfo"]); }
                if (!Convert.IsDBNull(myReader["FSecInv"])) { myDetail.FSecInv = Convert.ToDecimal(myReader["FSecInv"]); }
                if (!Convert.IsDBNull(myReader["FSourceBillNo"])) { myDetail.FSourceBillNo = Convert.ToString(myReader["FSourceBillNo"]); }
                if (!Convert.IsDBNull(myReader["FSourceEntryID"])) { myDetail.FSourceEntryID = Convert.ToString(myReader["FSourceEntryID"]); }
                if (!Convert.IsDBNull(myReader["FInterID"])) { myDetail.FInterID = Convert.ToInt32(myReader["FInterID"]); }
                if (!Convert.IsDBNull(myReader["FEntryID"])) { myDetail.FEntryID = Convert.ToInt32(myReader["FEntryID"]); }
                if (!Convert.IsDBNull(myReader["Remarks"])) { myDetail.Remarks = Convert.ToString(myReader["Remarks"]); }
                if (!Convert.IsDBNull(myReader["FsupNum"])) { myDetail.FsupNum = Convert.ToString(myReader["FsupNum"]); }
                if (!Convert.IsDBNull(myReader["IsClosed"])) { myDetail.IsClosed = Convert.ToInt32(myReader["IsClosed"]); }
            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }
        /// <summary>
		/// 更新JD_PORequestManage对象
		/// 编写人：ywk
		/// 编写日期：2018/8/6 星期一
		/// </summary>
		public void Update(JD_PORequestManage model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_PORequestManage SET TaskID = @m_TaskID,REQType = @m_REQType,SNumber = @m_SNumber,FNumber = @m_FNumber,FQty = @m_FQty,FLinkQty = @m_FLinkQty,FDate = @m_FDate,FBeginDate = @m_FBeginDate,FOperater = @m_FOperater,FUnit = @m_FUnit,FPrice = @m_FPrice,FCess = @m_FCess,TypeNumber = @m_TypeNumber,FModel = @m_FModel,FNeedQty = @m_FNeedQty,FFixLeadTime = @m_FFixLeadTime,FAdmit = @m_FAdmit,FAPurchTime = @m_FAPurchTime,FQtyMin = @m_FQtyMin,FBatchAppendQty = @m_FBatchAppendQty,CostPrice = @m_CostPrice,Flimitprice = @m_Flimitprice,FOpenPo = @m_FOpenPo,Fpoqty = @m_Fpoqty,Fpoqty1 = @m_Fpoqty1,Fpoqty2 = @m_Fpoqty2,Fstockqty = @m_Fstockqty,PackageInfo = @m_PackageInfo,FSecInv = @m_FSecInv,FSourceBillNo = @m_FSourceBillNo,FSourceEntryID = @m_FSourceEntryID,FInterID = @m_FInterID,FEntryID = @m_FEntryID,Remarks = @m_Remarks,FsupNum = @m_FsupNum,IsClosed = @m_IsClosed WHERE ItemID = @m_ItemID", con);
            con.Open();

            if (model.TaskID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaskID", SqlDbType.Int, 0)).Value = model.TaskID;
            }
            if (model.REQType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_REQType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_REQType", SqlDbType.NVarChar, 50)).Value = model.REQType;
            }
            if (model.SNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = model.SNumber;
            }
            if (model.FNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = model.FNumber;
            }
            if (model.FQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQty", SqlDbType.Decimal, 18)).Value = model.FQty;
            }
            if (model.FLinkQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLinkQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLinkQty", SqlDbType.Decimal, 18)).Value = model.FLinkQty;
            }
            if (model.FDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDate", SqlDbType.DateTime, 0)).Value = model.FDate;
            }
            if (model.FBeginDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBeginDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBeginDate", SqlDbType.DateTime, 0)).Value = model.FBeginDate;
            }
            if (model.FOperater == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOperater", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOperater", SqlDbType.NVarChar, 50)).Value = model.FOperater;
            }
            if (model.FUnit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnit", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FUnit", SqlDbType.NVarChar, 50)).Value = model.FUnit;
            }
            if (model.FPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPrice", SqlDbType.Decimal, 18)).Value = model.FPrice;
            }
            if (model.FCess == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCess", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCess", SqlDbType.Int, 0)).Value = model.FCess;
            }
            if (model.TypeNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TypeNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TypeNumber", SqlDbType.NVarChar, 50)).Value = model.TypeNumber;
            }
            if (model.FModel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 200)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModel", SqlDbType.NVarChar, 200)).Value = model.FModel;
            }
            if (model.FNeedQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNeedQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNeedQty", SqlDbType.Decimal, 18)).Value = model.FNeedQty;
            }
            if (model.FFixLeadTime == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFixLeadTime", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFixLeadTime", SqlDbType.NVarChar, 50)).Value = model.FFixLeadTime;
            }
            if (model.FAdmit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAdmit", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAdmit", SqlDbType.NVarChar, 50)).Value = model.FAdmit;
            }
            if (model.FAPurchTime == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAPurchTime", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAPurchTime", SqlDbType.DateTime, 0)).Value = model.FAPurchTime;
            }
            if (model.FQtyMin == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyMin", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FQtyMin", SqlDbType.Decimal, 18)).Value = model.FQtyMin;
            }
            if (model.FBatchAppendQty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchAppendQty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBatchAppendQty", SqlDbType.Decimal, 18)).Value = model.FBatchAppendQty;
            }
            if (model.CostPrice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CostPrice", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CostPrice", SqlDbType.Decimal, 18)).Value = model.CostPrice;
            }
            if (model.Flimitprice == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Flimitprice", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Flimitprice", SqlDbType.NVarChar, 50)).Value = model.Flimitprice;
            }
            if (model.FOpenPo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOpenPo", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOpenPo", SqlDbType.Decimal, 18)).Value = model.FOpenPo;
            }
            if (model.Fpoqty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fpoqty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fpoqty", SqlDbType.Decimal, 18)).Value = model.Fpoqty;
            }
            if (model.Fpoqty1 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fpoqty1", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fpoqty1", SqlDbType.Decimal, 18)).Value = model.Fpoqty1;
            }
            if (model.Fpoqty2 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fpoqty2", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fpoqty2", SqlDbType.Decimal, 18)).Value = model.Fpoqty2;
            }
            if (model.Fstockqty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fstockqty", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fstockqty", SqlDbType.Decimal, 18)).Value = model.Fstockqty;
            }
            if (model.PackageInfo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PackageInfo", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PackageInfo", SqlDbType.NVarChar, 500)).Value = model.PackageInfo;
            }
            if (model.FSecInv == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecInv", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSecInv", SqlDbType.Decimal, 18)).Value = model.FSecInv;
            }
            if (model.FSourceBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceBillNo", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceBillNo", SqlDbType.NVarChar, 50)).Value = model.FSourceBillNo;
            }
            if (model.FSourceEntryID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSourceEntryID", SqlDbType.NVarChar, 50)).Value = model.FSourceEntryID;
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
            if (model.Remarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Remarks", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Remarks", SqlDbType.NVarChar, 500)).Value = model.Remarks;
            }
            if (model.FsupNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FsupNum", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FsupNum", SqlDbType.NVarChar, 50)).Value = model.FsupNum;
            }
            if (model.IsClosed == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsClosed", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsClosed", SqlDbType.Int, 0)).Value = model.IsClosed;
            }
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID;

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

    }
}
