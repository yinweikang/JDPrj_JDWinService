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
    class JD_Supplier_LogDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息
        public static string K3BranchConString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3BranchConnectionString"].Value; //连接信息
        Common common = new Common();
        /// <summary>
		/// 对象JD_Supplier_Log明细
		/// 编写人：ywk
		/// 编写日期：2018/8/20 星期一
		/// </summary>
		public JD_Supplier_Log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_Supplier_Log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_Supplier_Log myDetail = new JD_Supplier_Log();
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
                if (!Convert.IsDBNull(myReader["IsUpdate"])) { myDetail.IsUpdate = Convert.ToInt32(myReader["IsUpdate"]); }
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
                if (!Convert.IsDBNull(myReader["CheckResult"])) { myDetail.CheckResult = Convert.ToDouble(myReader["CheckResult"]); }
                if (!Convert.IsDBNull(myReader["FHelpCode"])) { myDetail.FHelpCode = Convert.ToString(myReader["FHelpCode"]); }
                if (!Convert.IsDBNull(myReader["IsAcceptTicket"])) { myDetail.IsAcceptTicket = Convert.ToString(myReader["IsAcceptTicket"]); }
                if (!Convert.IsDBNull(myReader["TicketNum"])) { myDetail.TicketNum = Convert.ToString(myReader["TicketNum"]); }
                if (!Convert.IsDBNull(myReader["AcceptRemarks"])) { myDetail.AcceptRemarks = Convert.ToString(myReader["AcceptRemarks"]); }
                if (!Convert.IsDBNull(myReader["GradeStatus"])) { myDetail.GradeStatus = Convert.ToString(myReader["GradeStatus"]); }
            }
            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }




        /// <summary>
        /// 更新JD_Supplier_Log对象
        /// 编写人：ywk
        /// 编写日期：2018/8/20 星期一
        /// </summary>
        public void Update(JD_Supplier_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_Supplier_Log SET TaskID = @m_TaskID,SNumber = @m_SNumber,FNumber = @m_FNumber,RequestUser = @m_RequestUser,RequestDept = @m_RequestDept,RequestDate = @m_RequestDate,ApplyType = @m_ApplyType,FCyName = @m_FCyName,FCyNumber = @m_FCyNumber,FCode = @m_FCode,FName = @m_FName,FSimpleName = @m_FSimpleName,FIsZZS = @m_FIsZZS,FfullName = @m_FfullName,CompanyType = @m_CompanyType,Address = @m_Address,Source = @m_Source,FGrade = @m_FGrade,SourceRemark = @m_SourceRemark,MainProduct = @m_MainProduct,SwiftCode = @m_SwiftCode,FValueAddRate = @m_FValueAddRate,FcreditdayName = @m_FcreditdayName,FcreditdayNumber = @m_FcreditdayNumber,AccountName = @m_AccountName,AccountCode = @m_AccountCode,XinYongED = @m_XinYongED,TradeInfo = @m_TradeInfo,FsetidName = @m_FsetidName,FsetidNumber = @m_FsetidNumber,FYingFuName = @m_FYingFuName,FYingFuNumber = @m_FYingFuNumber,FYuFuName = @m_FYuFuName,FYuFuNumber = @m_FYuFuNumber,FOtherFuName = @m_FOtherFuName,FOtherFuNumber = @m_FOtherFuNumber,FPayTaxAcctIDName = @m_FPayTaxAcctIDName,FPayTaxAcctIDNumber = @m_FPayTaxAcctIDNumber,CGName = @m_CGName,CGTel = @m_CGTel,CGEmail = @m_CGEmail,CGMobile = @m_CGMobile,CGMobile2 = @m_CGMobile2,CGJob = @m_CGJob,GYLName = @m_GYLName,GYLTel = @m_GYLTel,GYLEmail = @m_GYLEmail,GYLMobile = @m_GYLMobile,GYLMobile2 = @m_GYLMobile2,GYLJob = @m_GYLJob,AttachFiles = @m_AttachFiles,AttachFiles2 = @m_AttachFiles2,AttachFiles3 = @m_AttachFiles3,AttachFiles4 = @m_AttachFiles4,AttachFiles5 = @m_AttachFiles5,AttachFiles6 = @m_AttachFiles6,AttachFiles7 = @m_AttachFiles7,AttachFiles8 = @m_AttachFiles8,AttachFiles9 = @m_AttachFiles9,FTypeCode = @m_FTypeCode,FTypeName = @m_FTypeName,FComGrade = @m_FComGrade,FCyID = @m_FCyID,FCreditDays = @m_FCreditDays,Fsetid = @m_Fsetid,FAPAccountID = @m_FAPAccountID,FPayTaxAcctID = @m_FPayTaxAcctID,FPreAcctID = @m_FPreAcctID,FOtherAPAcctID = @m_FOtherAPAcctID,IsUpdate = @m_IsUpdate,PostCode = @m_PostCode,IsPart = @m_IsPart,Fax = @m_Fax,MfrsType = @m_MfrsType,HasProxy = @m_HasProxy,MainBrand = @m_MainBrand,TaxCode = @m_TaxCode,ApplyReason = @m_ApplyReason,ApplyRemark = @m_ApplyRemark,DeliveryTerms = @m_DeliveryTerms,IsCGSupplier = @m_IsCGSupplier,IsAddressEdit = @m_IsAddressEdit,CheckResult = @m_CheckResult,FHelpCode = @m_FHelpCode,IsAcceptTicket = @m_IsAcceptTicket,TicketNum = @m_TicketNum,AcceptRemarks = @m_AcceptRemarks,GradeStatus=@m_GradeStatus WHERE ItemID = @m_ItemID", con);
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
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.Int, 0)).Value = model.IsUpdate;
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
            if (model.CheckResult == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CheckResult", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CheckResult", SqlDbType.Float, 0)).Value = model.CheckResult;
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

        public void UpdateStatus(int ItemID)
        {
            string sql = string.Format(@" update JD_Supplier_Log set IsUpdate='1' where ItemID='{0}'", ItemID.ToString());
            DBUtil.ExecuteSql(sql);
        }

        public DataView GetDistinct()
        {
            string sql = " select * from JD_Supplier_Log where IsUpdate=0 ";
            DataSet dt = DBUtil.Query(sql);
            return DBUtil.Query(sql).Tables[0].DefaultView;
        }

        //获取最大编号
        protected string GetMaxNo(string FShortNumber, int IsPart)
        {
            string sql = string.Format(@" select maxno from vw_t_item where FShortNumber='{0}'", FShortNumber);
            object obj = DBUtil.GetSingle(sql, (IsPart == 0) ? K3connectionString : K3BranchConString);
            int MaxNo = 0;
            if (obj != null)
            {
                MaxNo = Convert.ToInt32(obj.ToString()) + 1;
            }
            int ItemMaxNo = 0;
            sql = string.Format(@" select top 1 FNumber from  t_item where   FNumber like '%{0}%'  order by FItemID desc", FShortNumber);
            obj = DBUtil.GetSingle(sql, (IsPart == 0) ? K3connectionString : K3BranchConString);
            if (obj != null)
            {
                if (obj.ToString().IndexOf('.') > -1)
                {
                    ItemMaxNo = Convert.ToInt32(obj.ToString().Split('.')[1]) + 1;
                }
            }
            return (MaxNo > ItemMaxNo) ? MaxNo.ToString() : ItemMaxNo.ToString();
        }

        //供应商新增
        public void SupplierAdd(int ItemID, string APIUrl, string FuncName, string Token, string FileType)
        {
            //获取明细
            //调用API新增
            //更新发送状态 IsUpdate 
            //数据记录到集成日志表中
            JD_Supplier_Log logmodel = Detail(ItemID);
            string objectMame = FuncName;
            string actionName = "GetTemplate";
            string saveName = "Save";
            string json = " "; //请求的参数
            string loginUrl = string.Empty;
            Supplier model = new Supplier();
            string htmlCode = "";
            string ErrorMsg = string.Empty;

            try
            {
                if (logmodel != null)
                {
                    //获取对应类别的最大FCode
                    logmodel.FCode = GetMaxNo(logmodel.FTypeCode, logmodel.IsPart);
                    if (logmodel.FCode == "0")
                    {
                        throw new Exception("供应商对应类别的最大FCode为0");
                    }
                    logmodel.FNumber = logmodel.FTypeCode + "." + logmodel.FCode;
                    #region 解析供应商API模板
                    loginUrl = APIUrl + objectMame + "/" + actionName + "?Token=" + Token;
                    HttpWebResponse response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, json, null, null, Encoding.UTF8, null);
                    Stream resStream = response.GetResponseStream();
                    StreamReader sr = new StreamReader(resStream, Encoding.UTF8);
                    htmlCode = sr.ReadToEnd();//获取返回JSON
                    htmlCode = "{\"" + htmlCode.Substring(htmlCode.IndexOf("Data"), htmlCode.Length - htmlCode.IndexOf("Data"));
                    model = JsonConvert.DeserializeObject<Supplier>(htmlCode);
                    #endregion

                    #region API模板赋值
                    model.Data.FNumber = logmodel.FNumber;

                    model.Data.FStatus.FName = "使用";
                    model.Data.FStatus.FID = "ZT01";

                    model.Data.FName = logmodel.FName;//供应商名称
                    model.Data.FShortName = logmodel.FSimpleName;//供应商简称
                    model.Data.FAddress = logmodel.Address;    //地址
                    model.Data.FValueAddRate = Convert.ToInt32(logmodel.FValueAddRate); //税率
                    model.Data.FBank = logmodel.AccountName; //开户行
                    model.Data.FAccount = logmodel.AccountCode; //银行账号
                    model.Data.FContact = logmodel.CGName; //联系人
                    model.Data.FPhone = logmodel.CGTel; //电话
                    model.Data.FMobilePhone = logmodel.CGMobile.Trim(); //移动电话
                    model.Data.FHelpCode = logmodel.FHelpCode;// 助记码

                    model.Data.FCyID.FName = logmodel.FCyName;    //结算币种
                    model.Data.FCyID.FNumber = logmodel.FCyNumber;


                    model.Data.FSetID.FName = logmodel.FsetidName;  //结算方式
                    model.Data.FSetID.FNumber = logmodel.FsetidNumber;


                    model.Data.FAPAccountID.FName = logmodel.FYingFuName;   //应付账款科目代码 
                    model.Data.FAPAccountID.FNumber = logmodel.FYingFuNumber;


                    model.Data.FPreAcctID.FName = logmodel.FYuFuName;   //预付账款科目代码 
                    model.Data.FPreAcctID.FNumber = logmodel.FYuFuNumber;


                    model.Data.FOtherAPAcctID.FName = logmodel.FOtherFuName;   //其他应付账款科目代码
                    model.Data.FOtherAPAcctID.FNumber = logmodel.FOtherFuNumber;


                    model.Data.FPayTaxAcctID.FName = logmodel.FPayTaxAcctIDName;   //应交税金科目代码
                    model.Data.FPayTaxAcctID.FNumber = logmodel.FPayTaxAcctIDNumber;

                    model.Data.FCreditDays[0].FName = logmodel.FcreditdayName;   //付款条件
                    model.Data.FCreditDays[0].FNumber = logmodel.FcreditdayNumber;
                    #endregion

                    #region K3集成新增 
                    string Json = JsonConvert.SerializeObject(model);

                    Json = "{\"data\":[{" + Json.Substring(9, Json.Length - 9 - 2) + "}]}";
                    common.WriteLogs(FileType, logmodel.TaskID.ToString(), "解析的Json数据：");
                    common.WriteLogs(FileType, logmodel.TaskID.ToString(), Json);

                    loginUrl = APIUrl + objectMame + "/" + saveName + "?Token=" + Token;
                    //发送数据
                    Result result = common.SendToK3(loginUrl, Json);

                    if (result.Message != "Successful")
                    {
                        common.WriteLogs(FileType, logmodel.TaskID.ToString(), "API Send Error:");
                        common.WriteLogs(FileType, logmodel.TaskID.ToString(), result.Message);
                        ErrorMsg = result.Message;
                    }
                    else
                    {
                        common.WriteLogs(FileType, logmodel.TaskID.ToString(), "API Success:");
                        common.WriteLogs(FileType, logmodel.TaskID.ToString(), result.Message);
                        //BPM集成 供应商信息
                        bool IsAdd = SupplierMngAdd(logmodel);
                        if (!IsAdd)
                        {
                            throw new Exception("BPM供应商新增集成失败：日志信息不存在或供应商信息重复");
                        }
                        //流程中回写FNumber
                        UpdateFlowNumber(logmodel.TaskID, logmodel.FNumber);
                    }
                    #endregion

                }
                else
                {
                    throw new Exception("ItemID:" + ItemID.ToString() + "不存在！");
                }
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
            }
            finally
            {
                if (logmodel != null)
                {
                    logmodel.IsUpdate = 1;
                    Update(logmodel);
                }

                //记录日志
                if (!string.IsNullOrEmpty(ErrorMsg))
                {
                    common.AddLogQueue(logmodel.TaskID, "JD_Supplier_Log", ItemID, "API", ErrorMsg + ",具体错误信息请查看K3API日志", false);
                }
                else
                {
                    common.AddLogQueue(logmodel.TaskID, "JD_Supplier_Log", ItemID, "API", "操作成功！供应商编号：" + logmodel.FTypeCode + "." + logmodel.FCode, true);
                }

            }

        }



        public void UpdateSupplier(int ItemID, string ApplyType)
        {
            //获取明细
            t_SupplierDal k3dal = new t_SupplierDal();
            JD_Supplier_Log logmodel = new JD_Supplier_Log();
            t_Supplier K3model = new t_Supplier();
            string ErrorMsg = string.Empty;
            try
            {
                logmodel = Detail(ItemID);
                if (!string.IsNullOrEmpty(logmodel.FNumber))
                {
                    K3model = k3dal.Detail(logmodel.FNumber, logmodel.IsPart);
                }
                else
                {
                    K3model = k3dal.Detail(logmodel.FTypeCode + "." + logmodel.FCode, logmodel.IsPart);
                }
               
                #region  变更银行账期
                if (ApplyType == "2")
                {
                    K3model.FCyID = logmodel.FCyID;
                    K3model.FValueAddRate = logmodel.FValueAddRate;
                    K3model.FCreditDays = logmodel.FCreditDays;
                    K3model.FBank = logmodel.AccountName;
                    K3model.FAccount = logmodel.AccountCode;
                    K3model.FSetID = logmodel.Fsetid;
                    K3model.FPayTaxAcctID = logmodel.FPayTaxAcctID;
                    K3model.FAPAccountID = logmodel.FAPAccountID;
                    K3model.FpreAcctID = logmodel.FPreAcctID;
                    K3model.FOtherAPAcctID = logmodel.FOtherAPAcctID;
                }
                #endregion

                #region 其他变更
                else if (ApplyType == "3")
                {
                    K3model.FName = logmodel.FName;//供应商名称
                    K3model.FShortName = logmodel.FSimpleName;//供应商简称
                    K3model.FAddress = logmodel.Address;  //地址
                    K3model.FContact = logmodel.CGName; //联系人
                    K3model.FPhone = logmodel.CGTel; //电话
                    K3model.FHelpCode = logmodel.FHelpCode; //助记码
                    K3model.FMobilePhone = logmodel.CGMobile; //移动电话
                    
                                                              //供应商类型如果不相等
                    //if (K3model.FNumber.Split('.')[0] != logmodel.FTypeCode)
                    //{
                    //    logmodel.FCode = GetMaxNo(logmodel.FTypeCode, logmodel.IsPart);
                    //    K3model.FNumber = logmodel.FTypeCode + "." + logmodel.FCode;
                    //}
                }

                #endregion

                #region 禁用
                else if (ApplyType == "4")
                {
                    K3model.FDeleted = 1;
                    UpdateDeltedStatus(logmodel.FNumber, logmodel.IsCGSupplier);
                }

                #endregion

                if (K3model != null && K3model.FItemID != 0)
                {
                    k3dal.Update(K3model, logmodel.IsPart);
                }
                //BPM 供应商修改
                bool IsUpdate = UpdateSupplierMng(logmodel);
                if (!IsUpdate)
                {
                    throw new Exception("BPM供应商修改集成失败：日志不存在或供应商不存在！");
                }
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
            }
            finally
            {

                logmodel.IsUpdate = 1;
                Update(logmodel);
                //记录日志
                common.AddLogQueue(logmodel.TaskID, "JD_Supplier_Log", ItemID, "SQL", ErrorMsg);
            }

        }

        //采购供应商变更
        public void UpdateCGSupplier(int ItemID, string ApplyType)
        {
            //获取明细
            t_SupplierDal k3dal = new t_SupplierDal();
            JD_Supplier_Log logmodel = new JD_Supplier_Log();
            t_Supplier K3model = new t_Supplier();
            string ErrorMsg = string.Empty;
            try
            {
                logmodel = Detail(ItemID);
                K3model = k3dal.Detail(logmodel.FTypeCode + "." + logmodel.FCode, logmodel.IsPart);
                #region  其他变更
                if (ApplyType != "3")
                {
                    K3model.FCyID = logmodel.FCyID;
                    K3model.FValueAddRate = logmodel.FValueAddRate;
                    K3model.FCreditDays = logmodel.FCreditDays;
                    K3model.FBank = logmodel.AccountName;
                    K3model.FAccount = logmodel.AccountCode;
                    K3model.FSetID = logmodel.Fsetid;
                    K3model.FPayTaxAcctID = logmodel.FPayTaxAcctID;
                    K3model.FAPAccountID = logmodel.FAPAccountID;
                    K3model.FpreAcctID = logmodel.FPreAcctID;
                    K3model.FOtherAPAcctID = logmodel.FOtherAPAcctID;

                    K3model.FName = logmodel.FName;//供应商名称
                    K3model.FShortName = logmodel.FSimpleName;//供应商简称
                    K3model.FAddress = logmodel.Address;  //地址
                    K3model.FContact = logmodel.CGName; //联系人
                    K3model.FPhone = logmodel.CGTel; //电话
                    K3model.FMobilePhone = logmodel.CGMobile; //移动电话
                                                              //供应商类型如果不相等
                    if (K3model.FNumber.Split('.')[0] != logmodel.FTypeCode)
                    {
                        logmodel.FCode = GetMaxNo(logmodel.FTypeCode, logmodel.IsPart);
                        K3model.FNumber = logmodel.FTypeCode + "." + logmodel.FCode;
                    }
                }
                #endregion 

                #region 禁用
                else
                {
                    K3model.FDeleted = 1;
                }

                #endregion

                if (K3model != null && K3model.FItemID != 0)
                {
                    k3dal.Update(K3model, logmodel.IsPart);
                }
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
            }
            finally
            {

                logmodel.IsUpdate = 1;
                Update(logmodel);
                //记录日志
                common.AddLogQueue(logmodel.TaskID, "JD_Supplier_Log", ItemID, "SQL", ErrorMsg);
            }

        }

        //BPM供应商维护新增
        protected bool SupplierMngAdd(JD_Supplier_Log logMol)
        {
            //获取日志中的数据
            JD_Supplier_LogDal logdal = new JD_Supplier_LogDal();
            JD_Supplier_MngDal mngdal = new JD_Supplier_MngDal();

            JD_Supplier_Mng Mngmodel = new JD_Supplier_Mng();
            bool IsAdd = false;
            if (logMol != null)
            {
                if (!mngdal.IsExist(logMol.FNumber, logMol.FName))
                {
                    #region 供应商基础信息
                    Mngmodel.FName = logMol.FName;
                    Mngmodel.FSimpleName = logMol.FSimpleName;
                    Mngmodel.CompanyType = logMol.CompanyType;
                    Mngmodel.FTypeCode = logMol.FTypeCode;
                    Mngmodel.FTypeName = logMol.FTypeName;
                    Mngmodel.FIsZZS = logMol.FIsZZS;
                    Mngmodel.FfullName = logMol.FfullName;
                    Mngmodel.FComGrade = logMol.FComGrade;
                    Mngmodel.FCode = logMol.FCode;
                    Mngmodel.Address = logMol.Address;
                    Mngmodel.Source = logMol.Source;
                    Mngmodel.SourceRemark = logMol.SourceRemark;
                    Mngmodel.MainProduct = logMol.MainProduct;
                    Mngmodel.FNumber = logMol.FNumber;
                    Mngmodel.FGrade = logMol.FGrade;
                    Mngmodel.GradeStatus = logMol.GradeStatus;  //供应商状态
                    #endregion

                    #region 银行付款基本信息
                    Mngmodel.FCyID = logMol.FCyID;
                    Mngmodel.FCyName = logMol.FCyName;
                    Mngmodel.FCyNumber = logMol.FCyNumber;
                    Mngmodel.SwiftCode = logMol.SwiftCode;
                    Mngmodel.FValueAddRate = logMol.FValueAddRate;

                    Mngmodel.FcreditdayName = logMol.FcreditdayName;
                    Mngmodel.FCreditDays = logMol.FCreditDays;
                    Mngmodel.FcreditdayNumber = logMol.FcreditdayNumber;

                    Mngmodel.AccountName = logMol.AccountName;
                    Mngmodel.AccountCode = logMol.AccountCode;

                    Mngmodel.XinYongED = logMol.XinYongED;
                    Mngmodel.TradeInfo = logMol.TradeInfo;

                    Mngmodel.FsetidName = logMol.FsetidName;
                    Mngmodel.Fsetid = logMol.Fsetid;
                    Mngmodel.FsetidNumber = logMol.FsetidNumber;

                    Mngmodel.FPayTaxAcctIDName = logMol.FPayTaxAcctIDName;
                    Mngmodel.FPayTaxAcctID = logMol.FPayTaxAcctID;
                    Mngmodel.FPayTaxAcctIDNumber = logMol.FPayTaxAcctIDNumber;

                    Mngmodel.FAPAccountID = logMol.FAPAccountID;
                    Mngmodel.FYingFuName = logMol.FYingFuName;
                    Mngmodel.FYingFuNumber = logMol.FYingFuNumber;

                    Mngmodel.FPreAcctID = logMol.FPreAcctID;
                    Mngmodel.FYuFuName = logMol.FYuFuName;
                    Mngmodel.FYuFuNumber = logMol.FYuFuNumber;


                    Mngmodel.FOtherAPAcctID = logMol.FOtherAPAcctID;
                    Mngmodel.FOtherFuName = logMol.FOtherFuName;
                    Mngmodel.FOtherFuNumber = logMol.FOtherFuNumber;

                    Mngmodel.IsAcceptTicket = logMol.IsAcceptTicket;
                    Mngmodel.TicketNum = logMol.TicketNum;
                    Mngmodel.AcceptRemarks = logMol.AcceptRemarks;

                    #endregion

                    #region 联系方式信息
                    Mngmodel.CGName = logMol.CGName;
                    Mngmodel.CGMobile = logMol.CGMobile;
                    Mngmodel.CGMobile2 = logMol.CGMobile2;
                    Mngmodel.CGEmail = logMol.CGEmail;
                    Mngmodel.CGTel = logMol.CGTel;
                    Mngmodel.CGJob = logMol.CGJob;

                    Mngmodel.GYLName = logMol.GYLName;
                    Mngmodel.GYLMobile = logMol.GYLMobile;
                    Mngmodel.GYLMobile2 = logMol.GYLMobile2;
                    Mngmodel.GYLEmail = logMol.GYLEmail;
                    Mngmodel.GYLTel = logMol.GYLTel;
                    Mngmodel.GYLJob = logMol.GYLJob;

                    #endregion

                    #region 上传资料
                    Mngmodel.AttachFiles = logMol.AttachFiles;
                    Mngmodel.AttachFiles2 = logMol.AttachFiles2;
                    Mngmodel.AttachFiles3 = logMol.AttachFiles3;
                    Mngmodel.AttachFiles4 = logMol.AttachFiles4;
                    Mngmodel.AttachFiles5 = logMol.AttachFiles5;
                    Mngmodel.AttachFiles6 = logMol.AttachFiles6;
                    Mngmodel.AttachFiles7 = logMol.AttachFiles7;
                    Mngmodel.AttachFiles8 = logMol.AttachFiles8;
                    Mngmodel.AttachFiles9 = logMol.AttachFiles9;
                    #endregion

                    mngdal.Add(Mngmodel);
                    IsAdd = true;
                }
            }
            return IsAdd;
            //手动赋值
        }


        protected bool UpdateSupplierMng(JD_Supplier_Log logMol)
        {
            //获取日志中的数据
            JD_Supplier_LogDal logdal = new JD_Supplier_LogDal();
            JD_Supplier_MngDal mngdal = new JD_Supplier_MngDal();

            JD_Supplier_Mng Mngmodel = new JD_Supplier_Mng();
            bool IsUpdate = false;
            if (logMol != null)
            {
                Mngmodel = mngdal.Detail(logMol.FNumber);
                if (Mngmodel != null)
                {
                    #region 账期变更 即银行基本信息变更
                    if (logMol.ApplyType == "2")
                    {
                        Mngmodel.FCyID = logMol.FCyID;
                        Mngmodel.FCyName = logMol.FCyName;
                        Mngmodel.FCyNumber = logMol.FCyNumber;
                        Mngmodel.SwiftCode = logMol.SwiftCode;
                        Mngmodel.FValueAddRate = logMol.FValueAddRate;

                        Mngmodel.FcreditdayName = logMol.FcreditdayName;
                        Mngmodel.FCreditDays = logMol.FCreditDays;
                        Mngmodel.FcreditdayNumber = logMol.FcreditdayNumber;

                        Mngmodel.AccountName = logMol.AccountName;
                        Mngmodel.AccountCode = logMol.AccountCode;

                        Mngmodel.XinYongED = logMol.XinYongED;
                        Mngmodel.TradeInfo = logMol.TradeInfo;

                        Mngmodel.FsetidName = logMol.FsetidName;
                        Mngmodel.Fsetid = logMol.Fsetid;
                        Mngmodel.FsetidNumber = logMol.FsetidNumber;

                        Mngmodel.FPayTaxAcctIDName = logMol.FPayTaxAcctIDName;
                        Mngmodel.FPayTaxAcctID = logMol.FPayTaxAcctID;
                        Mngmodel.FPayTaxAcctIDNumber = logMol.FPayTaxAcctIDNumber;

                        Mngmodel.FAPAccountID = logMol.FAPAccountID;
                        Mngmodel.FYingFuName = logMol.FYingFuName;
                        Mngmodel.FYingFuNumber = logMol.FYingFuNumber;

                        Mngmodel.FPreAcctID = logMol.FPreAcctID;
                        Mngmodel.FYuFuName = logMol.FYuFuName;
                        Mngmodel.FYuFuNumber = logMol.FYuFuNumber;


                        Mngmodel.FOtherAPAcctID = logMol.FOtherAPAcctID;
                        Mngmodel.FOtherFuName = logMol.FOtherFuName;
                        Mngmodel.FOtherFuNumber = logMol.FOtherFuNumber;

                        Mngmodel.IsAcceptTicket = logMol.IsAcceptTicket;
                        Mngmodel.AcceptRemarks = logMol.AcceptRemarks;
                        Mngmodel.TicketNum = logMol.TicketNum;
                    }
                    #endregion

                    #region 其他变更
                    else if (logMol.ApplyType == "3")
                    {
                        #region 供应商基础信息
                        Mngmodel.FName = logMol.FName;
                        Mngmodel.FSimpleName = logMol.FSimpleName;
                        Mngmodel.CompanyType = logMol.CompanyType;
                        Mngmodel.FTypeCode = logMol.FTypeCode;
                        Mngmodel.FTypeName = logMol.FTypeName;
                        Mngmodel.FIsZZS = logMol.FIsZZS;
                        Mngmodel.FfullName = logMol.FfullName;
                        Mngmodel.FComGrade = logMol.FComGrade;
                        Mngmodel.FCode = logMol.FCode;
                        Mngmodel.Address = logMol.Address;
                        Mngmodel.Source = logMol.Source;
                        Mngmodel.SourceRemark = logMol.SourceRemark;
                        Mngmodel.MainProduct = logMol.MainProduct;
                        Mngmodel.FNumber = logMol.FNumber;
                        Mngmodel.FGrade = logMol.FGrade;

                        #endregion

                        #region 联系方式信息
                        Mngmodel.CGName = logMol.CGName;
                        Mngmodel.CGMobile = logMol.CGMobile;
                        Mngmodel.CGMobile2 = logMol.CGMobile2;
                        Mngmodel.CGEmail = logMol.CGEmail;
                        Mngmodel.CGTel = logMol.CGTel;
                        Mngmodel.CGJob = logMol.CGJob;

                        Mngmodel.GYLName = logMol.GYLName;
                        Mngmodel.GYLMobile = logMol.GYLMobile;
                        Mngmodel.GYLMobile2 = logMol.GYLMobile2;
                        Mngmodel.GYLEmail = logMol.GYLEmail;
                        Mngmodel.GYLTel = logMol.GYLTel;
                        Mngmodel.GYLJob = logMol.GYLJob;

                        #endregion

                        #region 上传资料
                        Mngmodel.AttachFiles = logMol.AttachFiles;
                        Mngmodel.AttachFiles2 = logMol.AttachFiles2;
                        Mngmodel.AttachFiles3 = logMol.AttachFiles3;
                        Mngmodel.AttachFiles4 = logMol.AttachFiles4;
                        Mngmodel.AttachFiles5 = logMol.AttachFiles5;
                        Mngmodel.AttachFiles6 = logMol.AttachFiles6;
                        Mngmodel.AttachFiles7 = logMol.AttachFiles7;
                        Mngmodel.AttachFiles8 = logMol.AttachFiles8;
                        Mngmodel.AttachFiles9 = logMol.AttachFiles9;
                        #endregion
                    }
                    #endregion

                    #region 禁用
                    else if (logMol.ApplyType == "4")
                    {
                        Mngmodel.IsForbidden = 1;
                    }
                    #endregion

                    #region 供应商状态变更
                    else if (logMol.ApplyType == "5")
                    {
                        Mngmodel.GradeStatus = logMol.GradeStatus;//供应商状态   
                    }
                       
                    #endregion

                    mngdal.Update(Mngmodel);
                    IsUpdate = true;
                }

            }
            return IsUpdate;
        }
        //其他采购供应商新增


        protected void UpdateFlowNumber(int TaskID, string FNumber)
        {
            string sql = string.Format(@" update JD_Supplier set FNumber='{0}' where TaskID='{1}'", FNumber, TaskID.ToString());
            DBUtil.ExecuteSql(sql);
        }

        protected void UpdateDeltedStatus(string FNumber, int IsCG)
        {
            string sql = string.Format(@"update t_Item set FDeleted='1' where FNumber='{0}'", FNumber);
            DBUtil.ExecuteSql(sql, (IsCG == 0) ? K3connectionString : K3BranchConString);
            sql = string.Format(@" update t_supplier set FDeleted='1' where FNumber='{0}'", FNumber);
            DBUtil.ExecuteSql(sql, (IsCG == 0) ? K3connectionString : K3BranchConString); 
        }
    }
}
