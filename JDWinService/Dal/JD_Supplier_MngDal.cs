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
using Newtonsoft.Json;

namespace JDWinService.Dal
{
    public class JD_Supplier_MngDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息
        Common common = new Common();

        /// <summary>
		/// 对象JD_Supplier_Mng明细
		/// 编写人：ywk
		/// 编写日期：2018/8/28 星期二
		/// </summary>
		public JD_Supplier_Mng Detail(string FNumber)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_Supplier_Mng WHERE FNumber = @m_FNumber", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = FNumber;

            JD_Supplier_Mng myDetail = new JD_Supplier_Mng();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["SNumber"])) { myDetail.SNumber = Convert.ToString(myReader["SNumber"]); }
                if (!Convert.IsDBNull(myReader["FNumber"])) { myDetail.FNumber = Convert.ToString(myReader["FNumber"]); }
                if (!Convert.IsDBNull(myReader["RequestUser"])) { myDetail.RequestUser = Convert.ToString(myReader["RequestUser"]); }
                if (!Convert.IsDBNull(myReader["RequestDept"])) { myDetail.RequestDept = Convert.ToString(myReader["RequestDept"]); }
                if (!Convert.IsDBNull(myReader["RequestDate"])) { myDetail.RequestDate = Convert.ToDateTime(myReader["RequestDate"]); }
                if (!Convert.IsDBNull(myReader["ApplyType"])) { myDetail.ApplyType = Convert.ToString(myReader["ApplyType"]); }
                if (!Convert.IsDBNull(myReader["FCyName"])) { myDetail.FCyName = Convert.ToString(myReader["FCyName"]); }
                if (!Convert.IsDBNull(myReader["FCyNumber"])) { myDetail.FCyNumber = Convert.ToString(myReader["FCyNumber"]); }
                if (!Convert.IsDBNull(myReader["FCode"])) { myDetail.FCode = Convert.ToString(myReader["FCode"]); }
                if (!Convert.IsDBNull(myReader["FName"])) { myDetail.FName = Convert.ToString(myReader["FName"]); }
                if (!Convert.IsDBNull(myReader["FSimpleName"])) { myDetail.FSimpleName = Convert.ToString(myReader["FSimpleName"]); }
                if (!Convert.IsDBNull(myReader["FIsZZS"])) { myDetail.FIsZZS = Convert.ToString(myReader["FIsZZS"]); }
                if (!Convert.IsDBNull(myReader["FfullName"])) { myDetail.FfullName = Convert.ToString(myReader["FfullName"]); }
                if (!Convert.IsDBNull(myReader["CompanyType"])) { myDetail.CompanyType = Convert.ToString(myReader["CompanyType"]); }
                if (!Convert.IsDBNull(myReader["Address"])) { myDetail.Address = Convert.ToString(myReader["Address"]); }
                if (!Convert.IsDBNull(myReader["Source"])) { myDetail.Source = Convert.ToString(myReader["Source"]); }
                if (!Convert.IsDBNull(myReader["FGrade"])) { myDetail.FGrade = Convert.ToString(myReader["FGrade"]); }
                if (!Convert.IsDBNull(myReader["SourceRemark"])) { myDetail.SourceRemark = Convert.ToString(myReader["SourceRemark"]); }
                if (!Convert.IsDBNull(myReader["MainProduct"])) { myDetail.MainProduct = Convert.ToString(myReader["MainProduct"]); }
                if (!Convert.IsDBNull(myReader["SwiftCode"])) { myDetail.SwiftCode = Convert.ToString(myReader["SwiftCode"]); }
                if (!Convert.IsDBNull(myReader["FValueAddRate"])) { myDetail.FValueAddRate = Convert.ToInt32(myReader["FValueAddRate"]); }
                if (!Convert.IsDBNull(myReader["FcreditdayName"])) { myDetail.FcreditdayName = Convert.ToString(myReader["FcreditdayName"]); }
                if (!Convert.IsDBNull(myReader["FcreditdayNumber"])) { myDetail.FcreditdayNumber = Convert.ToString(myReader["FcreditdayNumber"]); }
                if (!Convert.IsDBNull(myReader["AccountName"])) { myDetail.AccountName = Convert.ToString(myReader["AccountName"]); }
                if (!Convert.IsDBNull(myReader["AccountCode"])) { myDetail.AccountCode = Convert.ToString(myReader["AccountCode"]); }
                if (!Convert.IsDBNull(myReader["XinYongED"])) { myDetail.XinYongED = Convert.ToString(myReader["XinYongED"]); }
                if (!Convert.IsDBNull(myReader["TradeInfo"])) { myDetail.TradeInfo = Convert.ToString(myReader["TradeInfo"]); }
                if (!Convert.IsDBNull(myReader["FsetidName"])) { myDetail.FsetidName = Convert.ToString(myReader["FsetidName"]); }
                if (!Convert.IsDBNull(myReader["FsetidNumber"])) { myDetail.FsetidNumber = Convert.ToString(myReader["FsetidNumber"]); }
                if (!Convert.IsDBNull(myReader["FYingFuName"])) { myDetail.FYingFuName = Convert.ToString(myReader["FYingFuName"]); }
                if (!Convert.IsDBNull(myReader["FYingFuNumber"])) { myDetail.FYingFuNumber = Convert.ToString(myReader["FYingFuNumber"]); }
                if (!Convert.IsDBNull(myReader["FYuFuName"])) { myDetail.FYuFuName = Convert.ToString(myReader["FYuFuName"]); }
                if (!Convert.IsDBNull(myReader["FYuFuNumber"])) { myDetail.FYuFuNumber = Convert.ToString(myReader["FYuFuNumber"]); }
                if (!Convert.IsDBNull(myReader["FOtherFuName"])) { myDetail.FOtherFuName = Convert.ToString(myReader["FOtherFuName"]); }
                if (!Convert.IsDBNull(myReader["FOtherFuNumber"])) { myDetail.FOtherFuNumber = Convert.ToString(myReader["FOtherFuNumber"]); }
                if (!Convert.IsDBNull(myReader["FPayTaxAcctIDName"])) { myDetail.FPayTaxAcctIDName = Convert.ToString(myReader["FPayTaxAcctIDName"]); }
                if (!Convert.IsDBNull(myReader["FPayTaxAcctIDNumber"])) { myDetail.FPayTaxAcctIDNumber = Convert.ToString(myReader["FPayTaxAcctIDNumber"]); }
                if (!Convert.IsDBNull(myReader["CGName"])) { myDetail.CGName = Convert.ToString(myReader["CGName"]); }
                if (!Convert.IsDBNull(myReader["CGTel"])) { myDetail.CGTel = Convert.ToString(myReader["CGTel"]); }
                if (!Convert.IsDBNull(myReader["CGEmail"])) { myDetail.CGEmail = Convert.ToString(myReader["CGEmail"]); }
                if (!Convert.IsDBNull(myReader["CGMobile"])) { myDetail.CGMobile = Convert.ToString(myReader["CGMobile"]); }
                if (!Convert.IsDBNull(myReader["CGMobile2"])) { myDetail.CGMobile2 = Convert.ToString(myReader["CGMobile2"]); }
                if (!Convert.IsDBNull(myReader["CGJob"])) { myDetail.CGJob = Convert.ToString(myReader["CGJob"]); }
                if (!Convert.IsDBNull(myReader["GYLName"])) { myDetail.GYLName = Convert.ToString(myReader["GYLName"]); }
                if (!Convert.IsDBNull(myReader["GYLTel"])) { myDetail.GYLTel = Convert.ToString(myReader["GYLTel"]); }
                if (!Convert.IsDBNull(myReader["GYLEmail"])) { myDetail.GYLEmail = Convert.ToString(myReader["GYLEmail"]); }
                if (!Convert.IsDBNull(myReader["GYLMobile"])) { myDetail.GYLMobile = Convert.ToString(myReader["GYLMobile"]); }
                if (!Convert.IsDBNull(myReader["GYLMobile2"])) { myDetail.GYLMobile2 = Convert.ToString(myReader["GYLMobile2"]); }
                if (!Convert.IsDBNull(myReader["GYLJob"])) { myDetail.GYLJob = Convert.ToString(myReader["GYLJob"]); }
                if (!Convert.IsDBNull(myReader["AttachFiles"])) { myDetail.AttachFiles = Convert.ToString(myReader["AttachFiles"]); }
                if (!Convert.IsDBNull(myReader["AttachFiles2"])) { myDetail.AttachFiles2 = Convert.ToString(myReader["AttachFiles2"]); }
                if (!Convert.IsDBNull(myReader["AttachFiles3"])) { myDetail.AttachFiles3 = Convert.ToString(myReader["AttachFiles3"]); }
                if (!Convert.IsDBNull(myReader["AttachFiles4"])) { myDetail.AttachFiles4 = Convert.ToString(myReader["AttachFiles4"]); }
                if (!Convert.IsDBNull(myReader["AttachFiles5"])) { myDetail.AttachFiles5 = Convert.ToString(myReader["AttachFiles5"]); }
                if (!Convert.IsDBNull(myReader["AttachFiles6"])) { myDetail.AttachFiles6 = Convert.ToString(myReader["AttachFiles6"]); }
                if (!Convert.IsDBNull(myReader["AttachFiles7"])) { myDetail.AttachFiles7 = Convert.ToString(myReader["AttachFiles7"]); }
                if (!Convert.IsDBNull(myReader["AttachFiles8"])) { myDetail.AttachFiles8 = Convert.ToString(myReader["AttachFiles8"]); }
                if (!Convert.IsDBNull(myReader["AttachFiles9"])) { myDetail.AttachFiles9 = Convert.ToString(myReader["AttachFiles9"]); }
                if (!Convert.IsDBNull(myReader["FTypeCode"])) { myDetail.FTypeCode = Convert.ToString(myReader["FTypeCode"]); }
                if (!Convert.IsDBNull(myReader["FTypeName"])) { myDetail.FTypeName = Convert.ToString(myReader["FTypeName"]); }
                if (!Convert.IsDBNull(myReader["FComGrade"])) { myDetail.FComGrade = Convert.ToString(myReader["FComGrade"]); }
                if (!Convert.IsDBNull(myReader["FCyID"])) { myDetail.FCyID = Convert.ToInt32(myReader["FCyID"]); }
                if (!Convert.IsDBNull(myReader["FCreditDays"])) { myDetail.FCreditDays = Convert.ToInt32(myReader["FCreditDays"]); }
                if (!Convert.IsDBNull(myReader["Fsetid"])) { myDetail.Fsetid = Convert.ToInt32(myReader["Fsetid"]); }
                if (!Convert.IsDBNull(myReader["FAPAccountID"])) { myDetail.FAPAccountID = Convert.ToInt32(myReader["FAPAccountID"]); }
                if (!Convert.IsDBNull(myReader["FPayTaxAcctID"])) { myDetail.FPayTaxAcctID = Convert.ToInt32(myReader["FPayTaxAcctID"]); }
                if (!Convert.IsDBNull(myReader["FPreAcctID"])) { myDetail.FPreAcctID = Convert.ToInt32(myReader["FPreAcctID"]); }
                if (!Convert.IsDBNull(myReader["FOtherAPAcctID"])) { myDetail.FOtherAPAcctID = Convert.ToInt32(myReader["FOtherAPAcctID"]); }
                if (!Convert.IsDBNull(myReader["PostCode"])) { myDetail.PostCode = Convert.ToString(myReader["PostCode"]); }
                if (!Convert.IsDBNull(myReader["IsPart"])) { myDetail.IsPart = Convert.ToInt32(myReader["IsPart"]); }
                if (!Convert.IsDBNull(myReader["Fax"])) { myDetail.Fax = Convert.ToString(myReader["Fax"]); }
                if (!Convert.IsDBNull(myReader["MfrsType"])) { myDetail.MfrsType = Convert.ToString(myReader["MfrsType"]); }
                if (!Convert.IsDBNull(myReader["HasProxy"])) { myDetail.HasProxy = Convert.ToString(myReader["HasProxy"]); }
                if (!Convert.IsDBNull(myReader["MainBrand"])) { myDetail.MainBrand = Convert.ToString(myReader["MainBrand"]); }
                if (!Convert.IsDBNull(myReader["TaxCode"])) { myDetail.TaxCode = Convert.ToString(myReader["TaxCode"]); }
                if (!Convert.IsDBNull(myReader["ApplyReason"])) { myDetail.ApplyReason = Convert.ToString(myReader["ApplyReason"]); }
                if (!Convert.IsDBNull(myReader["ApplyRemark"])) { myDetail.ApplyRemark = Convert.ToString(myReader["ApplyRemark"]); }
                if (!Convert.IsDBNull(myReader["DeliveryTerms"])) { myDetail.DeliveryTerms = Convert.ToString(myReader["DeliveryTerms"]); }
                if (!Convert.IsDBNull(myReader["IsCGSupplier"])) { myDetail.IsCGSupplier = Convert.ToInt32(myReader["IsCGSupplier"]); }
                if (!Convert.IsDBNull(myReader["IsAddressEdit"])) { myDetail.IsAddressEdit = Convert.ToString(myReader["IsAddressEdit"]); }
                if (!Convert.IsDBNull(myReader["IsForbidden"])) { myDetail.IsForbidden = Convert.ToInt32(myReader["IsForbidden"]); }
                if (!Convert.IsDBNull(myReader["CheckResult"])) { myDetail.CheckResult = Convert.ToDouble(myReader["CheckResult"]); }
                if (!Convert.IsDBNull(myReader["Coefficient"])) { myDetail.Coefficient = Convert.ToDouble(myReader["Coefficient"]); }
                if (!Convert.IsDBNull(myReader["FHelpCode"])) { myDetail.FHelpCode = Convert.ToString(myReader["FHelpCode"]); }
                if (!Convert.IsDBNull(myReader["IsAcceptTicket"])) { myDetail.IsAcceptTicket = Convert.ToString(myReader["IsAcceptTicket"]); }
                if (!Convert.IsDBNull(myReader["TicketNum"])) { myDetail.TicketNum = Convert.ToString(myReader["TicketNum"]); }
                if (!Convert.IsDBNull(myReader["AcceptRemarks"])) { myDetail.AcceptRemarks = Convert.ToString(myReader["AcceptRemarks"]); } 
                if (!Convert.IsDBNull(myReader["GradeStatus"])) { myDetail.GradeStatus = Convert.ToString(myReader["GradeStatus"]); }
                if (!Convert.IsDBNull(myReader["OrderListCount"])) { myDetail.OrderListCount = Convert.ToInt32(myReader["OrderListCount"]); }
            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        /// <summary>
        /// 新增JD_Supplier_Mng对象
        /// 编写人：ywk
        /// 编写日期：2018/8/28 星期二
        /// </summary>
        public int Add(JD_Supplier_Mng model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO JD_Supplier_Mng(TaskID,SNumber,FNumber,RequestUser,RequestDept,RequestDate,ApplyType,FCyName,FCyNumber,FCode,FName,FSimpleName,FIsZZS,FfullName,CompanyType,Address,Source,FGrade,SourceRemark,MainProduct,SwiftCode,FValueAddRate,FcreditdayName,FcreditdayNumber,AccountName,AccountCode,XinYongED,TradeInfo,FsetidName,FsetidNumber,FYingFuName,FYingFuNumber,FYuFuName,FYuFuNumber,FOtherFuName,FOtherFuNumber,FPayTaxAcctIDName,FPayTaxAcctIDNumber,CGName,CGTel,CGEmail,CGMobile,CGMobile2,CGJob,GYLName,GYLTel,GYLEmail,GYLMobile,GYLMobile2,GYLJob,AttachFiles,AttachFiles2,AttachFiles3,AttachFiles4,AttachFiles5,AttachFiles6,AttachFiles7,AttachFiles8,AttachFiles9,FTypeCode,FTypeName,FComGrade,FCyID,FCreditDays,Fsetid,FAPAccountID,FPayTaxAcctID,FPreAcctID,FOtherAPAcctID,PostCode,IsPart,Fax,MfrsType,HasProxy,MainBrand,TaxCode,ApplyReason,ApplyRemark,DeliveryTerms,IsCGSupplier,IsAddressEdit,IsForbidden,CheckResult,Coefficient,FHelpCode,IsAcceptTicket,TicketNum,AcceptRemarks,GradeStatus,OrderListCount) VALUES(@m_TaskID,@m_SNumber,@m_FNumber,@m_RequestUser,@m_RequestDept,@m_RequestDate,@m_ApplyType,@m_FCyName,@m_FCyNumber,@m_FCode,@m_FName,@m_FSimpleName,@m_FIsZZS,@m_FfullName,@m_CompanyType,@m_Address,@m_Source,@m_FGrade,@m_SourceRemark,@m_MainProduct,@m_SwiftCode,@m_FValueAddRate,@m_FcreditdayName,@m_FcreditdayNumber,@m_AccountName,@m_AccountCode,@m_XinYongED,@m_TradeInfo,@m_FsetidName,@m_FsetidNumber,@m_FYingFuName,@m_FYingFuNumber,@m_FYuFuName,@m_FYuFuNumber,@m_FOtherFuName,@m_FOtherFuNumber,@m_FPayTaxAcctIDName,@m_FPayTaxAcctIDNumber,@m_CGName,@m_CGTel,@m_CGEmail,@m_CGMobile,@m_CGMobile2,@m_CGJob,@m_GYLName,@m_GYLTel,@m_GYLEmail,@m_GYLMobile,@m_GYLMobile2,@m_GYLJob,@m_AttachFiles,@m_AttachFiles2,@m_AttachFiles3,@m_AttachFiles4,@m_AttachFiles5,@m_AttachFiles6,@m_AttachFiles7,@m_AttachFiles8,@m_AttachFiles9,@m_FTypeCode,@m_FTypeName,@m_FComGrade,@m_FCyID,@m_FCreditDays,@m_Fsetid,@m_FAPAccountID,@m_FPayTaxAcctID,@m_FPreAcctID,@m_FOtherAPAcctID,@m_PostCode,@m_IsPart,@m_Fax,@m_MfrsType,@m_HasProxy,@m_MainBrand,@m_TaxCode,@m_ApplyReason,@m_ApplyRemark,@m_DeliveryTerms,@m_IsCGSupplier,@m_IsAddressEdit,@m_IsForbidden,@m_CheckResult,@m_Coefficient,@m_FHelpCode,@m_IsAcceptTicket,@m_TicketNum,@m_AcceptRemarks,@m_GradeStatus,@m_OrderListCount) SELECT @thisId=@@IDENTITY FROM JD_Supplier_Mng", con);
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
            if (model.FNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = model.FNumber;
            }
            if (model.RequestUser == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestUser", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestUser", SqlDbType.NVarChar, 50)).Value = model.RequestUser;
            }
            if (model.RequestDept == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestDept", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestDept", SqlDbType.NVarChar, 50)).Value = model.RequestDept;
            }
            if (model.RequestDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestDate", SqlDbType.DateTime, 0)).Value = model.RequestDate;
            }
            if (model.ApplyType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyType", SqlDbType.NVarChar, 50)).Value = model.ApplyType;
            }
            if (model.FCyName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyName", SqlDbType.NVarChar, 50)).Value = model.FCyName;
            }
            if (model.FCyNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyNumber", SqlDbType.NVarChar, 50)).Value = model.FCyNumber;
            }
            if (model.FCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCode", SqlDbType.NVarChar, 50)).Value = model.FCode;
            }
            if (model.FName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.NVarChar, 50)).Value = model.FName;
            }
            if (model.FSimpleName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSimpleName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSimpleName", SqlDbType.NVarChar, 50)).Value = model.FSimpleName;
            }
            if (model.FIsZZS == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsZZS", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsZZS", SqlDbType.NVarChar, 50)).Value = model.FIsZZS;
            }
            if (model.FfullName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FfullName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FfullName", SqlDbType.NVarChar, 50)).Value = model.FfullName;
            }
            if (model.CompanyType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CompanyType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CompanyType", SqlDbType.NVarChar, 50)).Value = model.CompanyType;
            }
            if (model.Address == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Address", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Address", SqlDbType.NVarChar, 50)).Value = model.Address;
            }
            if (model.Source == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Source", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Source", SqlDbType.NVarChar, 50)).Value = model.Source;
            }
            if (model.FGrade == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FGrade", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FGrade", SqlDbType.NVarChar, 50)).Value = model.FGrade;
            }
            if (model.SourceRemark == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SourceRemark", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SourceRemark", SqlDbType.NVarChar, 500)).Value = model.SourceRemark;
            }
            if (model.MainProduct == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MainProduct", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MainProduct", SqlDbType.NVarChar, 50)).Value = model.MainProduct;
            }
            if (model.SwiftCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SwiftCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SwiftCode", SqlDbType.NVarChar, 50)).Value = model.SwiftCode;
            }
            if (model.FValueAddRate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FValueAddRate", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FValueAddRate", SqlDbType.Int, 0)).Value = model.FValueAddRate;
            }
            if (model.FcreditdayName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FcreditdayName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FcreditdayName", SqlDbType.NVarChar, 50)).Value = model.FcreditdayName;
            }
            if (model.FcreditdayNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FcreditdayNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FcreditdayNumber", SqlDbType.NVarChar, 50)).Value = model.FcreditdayNumber;
            }
            if (model.AccountName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AccountName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AccountName", SqlDbType.NVarChar, 50)).Value = model.AccountName;
            }
            if (model.AccountCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AccountCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AccountCode", SqlDbType.NVarChar, 50)).Value = model.AccountCode;
            }
            if (model.XinYongED == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_XinYongED", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_XinYongED", SqlDbType.NVarChar, 50)).Value = model.XinYongED;
            }
            if (model.TradeInfo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TradeInfo", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TradeInfo", SqlDbType.NVarChar, 50)).Value = model.TradeInfo;
            }
            if (model.FsetidName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FsetidName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FsetidName", SqlDbType.NVarChar, 50)).Value = model.FsetidName;
            }
            if (model.FsetidNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FsetidNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FsetidNumber", SqlDbType.NVarChar, 50)).Value = model.FsetidNumber;
            }
            if (model.FYingFuName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FYingFuName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FYingFuName", SqlDbType.NVarChar, 50)).Value = model.FYingFuName;
            }
            if (model.FYingFuNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FYingFuNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FYingFuNumber", SqlDbType.NVarChar, 50)).Value = model.FYingFuNumber;
            }
            if (model.FYuFuName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FYuFuName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FYuFuName", SqlDbType.NVarChar, 50)).Value = model.FYuFuName;
            }
            if (model.FYuFuNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FYuFuNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FYuFuNumber", SqlDbType.NVarChar, 50)).Value = model.FYuFuNumber;
            }
            if (model.FOtherFuName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherFuName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherFuName", SqlDbType.NVarChar, 50)).Value = model.FOtherFuName;
            }
            if (model.FOtherFuNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherFuNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherFuNumber", SqlDbType.NVarChar, 50)).Value = model.FOtherFuNumber;
            }
            if (model.FPayTaxAcctIDName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctIDName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctIDName", SqlDbType.NVarChar, 50)).Value = model.FPayTaxAcctIDName;
            }
            if (model.FPayTaxAcctIDNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctIDNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctIDNumber", SqlDbType.NVarChar, 50)).Value = model.FPayTaxAcctIDNumber;
            }
            if (model.CGName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGName", SqlDbType.NVarChar, 50)).Value = model.CGName;
            }
            if (model.CGTel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGTel", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGTel", SqlDbType.NVarChar, 50)).Value = model.CGTel;
            }
            if (model.CGEmail == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGEmail", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGEmail", SqlDbType.NVarChar, 50)).Value = model.CGEmail;
            }
            if (model.CGMobile == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGMobile", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGMobile", SqlDbType.NVarChar, 50)).Value = model.CGMobile;
            }
            if (model.CGMobile2 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGMobile2", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGMobile2", SqlDbType.NVarChar, 50)).Value = model.CGMobile2;
            }
            if (model.CGJob == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGJob", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGJob", SqlDbType.NVarChar, 50)).Value = model.CGJob;
            }
            if (model.GYLName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLName", SqlDbType.NVarChar, 50)).Value = model.GYLName;
            }
            if (model.GYLTel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLTel", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLTel", SqlDbType.NVarChar, 50)).Value = model.GYLTel;
            }
            if (model.GYLEmail == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLEmail", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLEmail", SqlDbType.NVarChar, 50)).Value = model.GYLEmail;
            }
            if (model.GYLMobile == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLMobile", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLMobile", SqlDbType.NVarChar, 50)).Value = model.GYLMobile;
            }
            if (model.GYLMobile2 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLMobile2", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLMobile2", SqlDbType.NVarChar, 50)).Value = model.GYLMobile2;
            }
            if (model.GYLJob == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLJob", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLJob", SqlDbType.NVarChar, 50)).Value = model.GYLJob;
            }
            if (model.AttachFiles == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles", SqlDbType.NVarChar, 500)).Value = model.AttachFiles;
            }
            if (model.AttachFiles2 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles2", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles2", SqlDbType.NVarChar, 500)).Value = model.AttachFiles2;
            }
            if (model.AttachFiles3 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles3", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles3", SqlDbType.NVarChar, 500)).Value = model.AttachFiles3;
            }
            if (model.AttachFiles4 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles4", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles4", SqlDbType.NVarChar, 500)).Value = model.AttachFiles4;
            }
            if (model.AttachFiles5 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles5", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles5", SqlDbType.NVarChar, 500)).Value = model.AttachFiles5;
            }
            if (model.AttachFiles6 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles6", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles6", SqlDbType.NVarChar, 500)).Value = model.AttachFiles6;
            }
            if (model.AttachFiles7 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles7", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles7", SqlDbType.NVarChar, 500)).Value = model.AttachFiles7;
            }
            if (model.AttachFiles8 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles8", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles8", SqlDbType.NVarChar, 500)).Value = model.AttachFiles8;
            }
            if (model.AttachFiles9 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles9", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles9", SqlDbType.NVarChar, 500)).Value = model.AttachFiles9;
            }
            if (model.FTypeCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTypeCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTypeCode", SqlDbType.NVarChar, 50)).Value = model.FTypeCode;
            }
            if (model.FTypeName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTypeName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTypeName", SqlDbType.NVarChar, 50)).Value = model.FTypeName;
            }
            if (model.FComGrade == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FComGrade", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FComGrade", SqlDbType.NVarChar, 50)).Value = model.FComGrade;
            }
            if (model.FCyID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyID", SqlDbType.Int, 0)).Value = model.FCyID;
            }
            if (model.FCreditDays == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditDays", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditDays", SqlDbType.Int, 0)).Value = model.FCreditDays;
            }
            if (model.Fsetid == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fsetid", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fsetid", SqlDbType.Int, 0)).Value = model.Fsetid;
            }
            if (model.FAPAccountID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAPAccountID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAPAccountID", SqlDbType.Int, 0)).Value = model.FAPAccountID;
            }
            if (model.FPayTaxAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctID", SqlDbType.Int, 0)).Value = model.FPayTaxAcctID;
            }
            if (model.FPreAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPreAcctID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPreAcctID", SqlDbType.Int, 0)).Value = model.FPreAcctID;
            }
            if (model.FOtherAPAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherAPAcctID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherAPAcctID", SqlDbType.Int, 0)).Value = model.FOtherAPAcctID;
            }
            if (model.PostCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PostCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PostCode", SqlDbType.NVarChar, 50)).Value = model.PostCode;
            }
            if (model.IsPart == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsPart", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsPart", SqlDbType.Int, 0)).Value = model.IsPart;
            }
            if (model.Fax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fax", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fax", SqlDbType.NVarChar, 50)).Value = model.Fax;
            }
            if (model.MfrsType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MfrsType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MfrsType", SqlDbType.NVarChar, 50)).Value = model.MfrsType;
            }
            if (model.HasProxy == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_HasProxy", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_HasProxy", SqlDbType.NVarChar, 50)).Value = model.HasProxy;
            }
            if (model.MainBrand == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MainBrand", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MainBrand", SqlDbType.NVarChar, 100)).Value = model.MainBrand;
            }
            if (model.TaxCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaxCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaxCode", SqlDbType.NVarChar, 50)).Value = model.TaxCode;
            }
            if (model.ApplyReason == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyReason", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyReason", SqlDbType.NVarChar, 500)).Value = model.ApplyReason;
            }
            if (model.ApplyRemark == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyRemark", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyRemark", SqlDbType.NVarChar, 500)).Value = model.ApplyRemark;
            }
            if (model.DeliveryTerms == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeliveryTerms", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeliveryTerms", SqlDbType.NVarChar, 50)).Value = model.DeliveryTerms;
            }
            if (model.IsCGSupplier == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsCGSupplier", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsCGSupplier", SqlDbType.Int, 0)).Value = model.IsCGSupplier;
            }
            if (model.IsAddressEdit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsAddressEdit", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsAddressEdit", SqlDbType.NVarChar, 50)).Value = model.IsAddressEdit;
            }
            if (model.IsForbidden == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsForbidden", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsForbidden", SqlDbType.Int, 0)).Value = model.IsForbidden;
            }
            if (model.CheckResult == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CheckResult", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CheckResult", SqlDbType.Float, 0)).Value = model.CheckResult;
            }
            if (model.Coefficient == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Coefficient", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Coefficient", SqlDbType.Float, 0)).Value = model.Coefficient;
            }
            if (model.FHelpCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHelpCode", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHelpCode", SqlDbType.NVarChar, 100)).Value = model.FHelpCode;
            }
            if (model.IsAcceptTicket == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsAcceptTicket", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsAcceptTicket", SqlDbType.NVarChar, 50)).Value = model.IsAcceptTicket;
            }
            if (model.TicketNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TicketNum", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TicketNum", SqlDbType.NVarChar, 50)).Value = model.TicketNum;
            }
            if (model.AcceptRemarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AcceptRemarks", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AcceptRemarks", SqlDbType.NVarChar, 100)).Value = model.AcceptRemarks;
            }

            if (model.OrderListCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderListCount", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderListCount", SqlDbType.Int, 0)).Value = model.OrderListCount;
            }
            if (model.GradeStatus == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_GradeStatus", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_GradeStatus", SqlDbType.NVarChar, 50)).Value = model.GradeStatus;
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
        /// 更新JD_Supplier_Mng对象
        /// 编写人：ywk
        /// 编写日期：2018/8/28 星期二
        /// </summary>
        public void Update(JD_Supplier_Mng model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_Supplier_Mng SET TaskID = @m_TaskID,SNumber = @m_SNumber,FNumber = @m_FNumber,RequestUser = @m_RequestUser,RequestDept = @m_RequestDept,RequestDate = @m_RequestDate,ApplyType = @m_ApplyType,FCyName = @m_FCyName,FCyNumber = @m_FCyNumber,FCode = @m_FCode,FName = @m_FName,FSimpleName = @m_FSimpleName,FIsZZS = @m_FIsZZS,FfullName = @m_FfullName,CompanyType = @m_CompanyType,Address = @m_Address,Source = @m_Source,FGrade = @m_FGrade,SourceRemark = @m_SourceRemark,MainProduct = @m_MainProduct,SwiftCode = @m_SwiftCode,FValueAddRate = @m_FValueAddRate,FcreditdayName = @m_FcreditdayName,FcreditdayNumber = @m_FcreditdayNumber,AccountName = @m_AccountName,AccountCode = @m_AccountCode,XinYongED = @m_XinYongED,TradeInfo = @m_TradeInfo,FsetidName = @m_FsetidName,FsetidNumber = @m_FsetidNumber,FYingFuName = @m_FYingFuName,FYingFuNumber = @m_FYingFuNumber,FYuFuName = @m_FYuFuName,FYuFuNumber = @m_FYuFuNumber,FOtherFuName = @m_FOtherFuName,FOtherFuNumber = @m_FOtherFuNumber,FPayTaxAcctIDName = @m_FPayTaxAcctIDName,FPayTaxAcctIDNumber = @m_FPayTaxAcctIDNumber,CGName = @m_CGName,CGTel = @m_CGTel,CGEmail = @m_CGEmail,CGMobile = @m_CGMobile,CGMobile2 = @m_CGMobile2,CGJob = @m_CGJob,GYLName = @m_GYLName,GYLTel = @m_GYLTel,GYLEmail = @m_GYLEmail,GYLMobile = @m_GYLMobile,GYLMobile2 = @m_GYLMobile2,GYLJob = @m_GYLJob,AttachFiles = @m_AttachFiles,AttachFiles2 = @m_AttachFiles2,AttachFiles3 = @m_AttachFiles3,AttachFiles4 = @m_AttachFiles4,AttachFiles5 = @m_AttachFiles5,AttachFiles6 = @m_AttachFiles6,AttachFiles7 = @m_AttachFiles7,AttachFiles8 = @m_AttachFiles8,AttachFiles9 = @m_AttachFiles9,FTypeCode = @m_FTypeCode,FTypeName = @m_FTypeName,FComGrade = @m_FComGrade,FCyID = @m_FCyID,FCreditDays = @m_FCreditDays,Fsetid = @m_Fsetid,FAPAccountID = @m_FAPAccountID,FPayTaxAcctID = @m_FPayTaxAcctID,FPreAcctID = @m_FPreAcctID,FOtherAPAcctID = @m_FOtherAPAcctID,PostCode = @m_PostCode,IsPart = @m_IsPart,Fax = @m_Fax,MfrsType = @m_MfrsType,HasProxy = @m_HasProxy,MainBrand = @m_MainBrand,TaxCode = @m_TaxCode,ApplyReason = @m_ApplyReason,ApplyRemark = @m_ApplyRemark,DeliveryTerms = @m_DeliveryTerms,IsCGSupplier = @m_IsCGSupplier,IsAddressEdit = @m_IsAddressEdit,IsForbidden = @m_IsForbidden,CheckResult = @m_CheckResult,Coefficient = @m_Coefficient,FHelpCode = @m_FHelpCode,IsAcceptTicket = @m_IsAcceptTicket,TicketNum = @m_TicketNum,AcceptRemarks = @m_AcceptRemarks,GradeStatus=@m_GradeStatus,OrderListCount=@m_OrderListCount WHERE ItemID = @m_ItemID", con);
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
            if (model.FNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = model.FNumber;
            }
            if (model.RequestUser == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestUser", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestUser", SqlDbType.NVarChar, 50)).Value = model.RequestUser;
            }
            if (model.RequestDept == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestDept", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestDept", SqlDbType.NVarChar, 50)).Value = model.RequestDept;
            }
            if (model.RequestDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_RequestDate", SqlDbType.DateTime, 0)).Value = model.RequestDate;
            }
            if (model.ApplyType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyType", SqlDbType.NVarChar, 50)).Value = model.ApplyType;
            }
            if (model.FCyName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyName", SqlDbType.NVarChar, 50)).Value = model.FCyName;
            }
            if (model.FCyNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyNumber", SqlDbType.NVarChar, 50)).Value = model.FCyNumber;
            }
            if (model.FCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCode", SqlDbType.NVarChar, 50)).Value = model.FCode;
            }
            if (model.FName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.NVarChar, 50)).Value = model.FName;
            }
            if (model.FSimpleName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSimpleName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSimpleName", SqlDbType.NVarChar, 50)).Value = model.FSimpleName;
            }
            if (model.FIsZZS == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsZZS", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsZZS", SqlDbType.NVarChar, 50)).Value = model.FIsZZS;
            }
            if (model.FfullName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FfullName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FfullName", SqlDbType.NVarChar, 50)).Value = model.FfullName;
            }
            if (model.CompanyType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CompanyType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CompanyType", SqlDbType.NVarChar, 50)).Value = model.CompanyType;
            }
            if (model.Address == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Address", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Address", SqlDbType.NVarChar, 50)).Value = model.Address;
            }
            if (model.Source == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Source", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Source", SqlDbType.NVarChar, 50)).Value = model.Source;
            }
            if (model.FGrade == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FGrade", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FGrade", SqlDbType.NVarChar, 50)).Value = model.FGrade;
            }
            if (model.SourceRemark == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SourceRemark", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SourceRemark", SqlDbType.NVarChar, 500)).Value = model.SourceRemark;
            }
            if (model.MainProduct == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MainProduct", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MainProduct", SqlDbType.NVarChar, 50)).Value = model.MainProduct;
            }
            if (model.SwiftCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SwiftCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SwiftCode", SqlDbType.NVarChar, 50)).Value = model.SwiftCode;
            }
            if (model.FValueAddRate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FValueAddRate", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FValueAddRate", SqlDbType.Int, 0)).Value = model.FValueAddRate;
            }
            if (model.FcreditdayName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FcreditdayName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FcreditdayName", SqlDbType.NVarChar, 50)).Value = model.FcreditdayName;
            }
            if (model.FcreditdayNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FcreditdayNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FcreditdayNumber", SqlDbType.NVarChar, 50)).Value = model.FcreditdayNumber;
            }
            if (model.AccountName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AccountName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AccountName", SqlDbType.NVarChar, 50)).Value = model.AccountName;
            }
            if (model.AccountCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AccountCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AccountCode", SqlDbType.NVarChar, 50)).Value = model.AccountCode;
            }
            if (model.XinYongED == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_XinYongED", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_XinYongED", SqlDbType.NVarChar, 50)).Value = model.XinYongED;
            }
            if (model.TradeInfo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TradeInfo", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TradeInfo", SqlDbType.NVarChar, 50)).Value = model.TradeInfo;
            }
            if (model.FsetidName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FsetidName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FsetidName", SqlDbType.NVarChar, 50)).Value = model.FsetidName;
            }
            if (model.FsetidNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FsetidNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FsetidNumber", SqlDbType.NVarChar, 50)).Value = model.FsetidNumber;
            }
            if (model.FYingFuName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FYingFuName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FYingFuName", SqlDbType.NVarChar, 50)).Value = model.FYingFuName;
            }
            if (model.FYingFuNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FYingFuNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FYingFuNumber", SqlDbType.NVarChar, 50)).Value = model.FYingFuNumber;
            }
            if (model.FYuFuName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FYuFuName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FYuFuName", SqlDbType.NVarChar, 50)).Value = model.FYuFuName;
            }
            if (model.FYuFuNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FYuFuNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FYuFuNumber", SqlDbType.NVarChar, 50)).Value = model.FYuFuNumber;
            }
            if (model.FOtherFuName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherFuName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherFuName", SqlDbType.NVarChar, 50)).Value = model.FOtherFuName;
            }
            if (model.FOtherFuNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherFuNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherFuNumber", SqlDbType.NVarChar, 50)).Value = model.FOtherFuNumber;
            }
            if (model.FPayTaxAcctIDName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctIDName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctIDName", SqlDbType.NVarChar, 50)).Value = model.FPayTaxAcctIDName;
            }
            if (model.FPayTaxAcctIDNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctIDNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctIDNumber", SqlDbType.NVarChar, 50)).Value = model.FPayTaxAcctIDNumber;
            }
            if (model.CGName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGName", SqlDbType.NVarChar, 50)).Value = model.CGName;
            }
            if (model.CGTel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGTel", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGTel", SqlDbType.NVarChar, 50)).Value = model.CGTel;
            }
            if (model.CGEmail == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGEmail", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGEmail", SqlDbType.NVarChar, 50)).Value = model.CGEmail;
            }
            if (model.CGMobile == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGMobile", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGMobile", SqlDbType.NVarChar, 50)).Value = model.CGMobile;
            }
            if (model.CGMobile2 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGMobile2", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGMobile2", SqlDbType.NVarChar, 50)).Value = model.CGMobile2;
            }
            if (model.CGJob == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGJob", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CGJob", SqlDbType.NVarChar, 50)).Value = model.CGJob;
            }
            if (model.GYLName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLName", SqlDbType.NVarChar, 50)).Value = model.GYLName;
            }
            if (model.GYLTel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLTel", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLTel", SqlDbType.NVarChar, 50)).Value = model.GYLTel;
            }
            if (model.GYLEmail == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLEmail", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLEmail", SqlDbType.NVarChar, 50)).Value = model.GYLEmail;
            }
            if (model.GYLMobile == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLMobile", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLMobile", SqlDbType.NVarChar, 50)).Value = model.GYLMobile;
            }
            if (model.GYLMobile2 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLMobile2", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLMobile2", SqlDbType.NVarChar, 50)).Value = model.GYLMobile2;
            }
            if (model.GYLJob == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLJob", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_GYLJob", SqlDbType.NVarChar, 50)).Value = model.GYLJob;
            }
            if (model.AttachFiles == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles", SqlDbType.NVarChar, 500)).Value = model.AttachFiles;
            }
            if (model.AttachFiles2 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles2", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles2", SqlDbType.NVarChar, 500)).Value = model.AttachFiles2;
            }
            if (model.AttachFiles3 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles3", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles3", SqlDbType.NVarChar, 500)).Value = model.AttachFiles3;
            }
            if (model.AttachFiles4 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles4", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles4", SqlDbType.NVarChar, 500)).Value = model.AttachFiles4;
            }
            if (model.AttachFiles5 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles5", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles5", SqlDbType.NVarChar, 500)).Value = model.AttachFiles5;
            }
            if (model.AttachFiles6 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles6", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles6", SqlDbType.NVarChar, 500)).Value = model.AttachFiles6;
            }
            if (model.AttachFiles7 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles7", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles7", SqlDbType.NVarChar, 500)).Value = model.AttachFiles7;
            }
            if (model.AttachFiles8 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles8", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles8", SqlDbType.NVarChar, 500)).Value = model.AttachFiles8;
            }
            if (model.AttachFiles9 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles9", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AttachFiles9", SqlDbType.NVarChar, 500)).Value = model.AttachFiles9;
            }
            if (model.FTypeCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTypeCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTypeCode", SqlDbType.NVarChar, 50)).Value = model.FTypeCode;
            }
            if (model.FTypeName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTypeName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTypeName", SqlDbType.NVarChar, 50)).Value = model.FTypeName;
            }
            if (model.FComGrade == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FComGrade", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FComGrade", SqlDbType.NVarChar, 50)).Value = model.FComGrade;
            }
            if (model.FCyID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyID", SqlDbType.Int, 0)).Value = model.FCyID;
            }
            if (model.FCreditDays == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditDays", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditDays", SqlDbType.Int, 0)).Value = model.FCreditDays;
            }
            if (model.Fsetid == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fsetid", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fsetid", SqlDbType.Int, 0)).Value = model.Fsetid;
            }
            if (model.FAPAccountID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAPAccountID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAPAccountID", SqlDbType.Int, 0)).Value = model.FAPAccountID;
            }
            if (model.FPayTaxAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctID", SqlDbType.Int, 0)).Value = model.FPayTaxAcctID;
            }
            if (model.FPreAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPreAcctID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPreAcctID", SqlDbType.Int, 0)).Value = model.FPreAcctID;
            }
            if (model.FOtherAPAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherAPAcctID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherAPAcctID", SqlDbType.Int, 0)).Value = model.FOtherAPAcctID;
            }
            if (model.PostCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PostCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PostCode", SqlDbType.NVarChar, 50)).Value = model.PostCode;
            }
            if (model.IsPart == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsPart", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsPart", SqlDbType.Int, 0)).Value = model.IsPart;
            }
            if (model.Fax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fax", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fax", SqlDbType.NVarChar, 50)).Value = model.Fax;
            }
            if (model.MfrsType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MfrsType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MfrsType", SqlDbType.NVarChar, 50)).Value = model.MfrsType;
            }
            if (model.HasProxy == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_HasProxy", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_HasProxy", SqlDbType.NVarChar, 50)).Value = model.HasProxy;
            }
            if (model.MainBrand == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_MainBrand", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_MainBrand", SqlDbType.NVarChar, 100)).Value = model.MainBrand;
            }
            if (model.TaxCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaxCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TaxCode", SqlDbType.NVarChar, 50)).Value = model.TaxCode;
            }
            if (model.ApplyReason == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyReason", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyReason", SqlDbType.NVarChar, 500)).Value = model.ApplyReason;
            }
            if (model.ApplyRemark == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyRemark", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ApplyRemark", SqlDbType.NVarChar, 500)).Value = model.ApplyRemark;
            }
            if (model.DeliveryTerms == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeliveryTerms", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeliveryTerms", SqlDbType.NVarChar, 50)).Value = model.DeliveryTerms;
            }
            if (model.IsCGSupplier == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsCGSupplier", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsCGSupplier", SqlDbType.Int, 0)).Value = model.IsCGSupplier;
            }
            if (model.IsAddressEdit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsAddressEdit", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsAddressEdit", SqlDbType.NVarChar, 50)).Value = model.IsAddressEdit;
            }
            if (model.IsForbidden == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsForbidden", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsForbidden", SqlDbType.Int, 0)).Value = model.IsForbidden;
            }
            if (model.CheckResult == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CheckResult", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CheckResult", SqlDbType.Float, 0)).Value = model.CheckResult;
            }
            if (model.Coefficient == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Coefficient", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Coefficient", SqlDbType.Float, 0)).Value = model.Coefficient;
            }
            if (model.FHelpCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHelpCode", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHelpCode", SqlDbType.NVarChar, 100)).Value = model.FHelpCode;
            }
            if (model.IsAcceptTicket == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsAcceptTicket", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsAcceptTicket", SqlDbType.NVarChar, 50)).Value = model.IsAcceptTicket;
            }
            if (model.TicketNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_TicketNum", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_TicketNum", SqlDbType.NVarChar, 50)).Value = model.TicketNum;
            }
            if (model.AcceptRemarks == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_AcceptRemarks", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_AcceptRemarks", SqlDbType.NVarChar, 100)).Value = model.AcceptRemarks;
            }


            if (model.OrderListCount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderListCount", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_OrderListCount", SqlDbType.Int, 0)).Value = model.OrderListCount;
            }
            if (model.GradeStatus == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_GradeStatus", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_GradeStatus", SqlDbType.NVarChar, 50)).Value = model.GradeStatus;
            }
            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = model.ItemID; 
            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }


        public bool IsExist(string FNumber,string FName)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM JD_Supplier_Mng WHERE FNumber = @m_FNumber or FName=@m_FName", con);
            con.Open();
            cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = FNumber;
            cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.NVarChar, 50)).Value = FName;
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
    }
}
