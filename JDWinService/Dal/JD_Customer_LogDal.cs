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
    class JD_Customer_LogDal
    {
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息
        public static string CustomCodeType = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["CustomCodeType"].Value; //连接信息
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息

        Common common = new Common();
        /// <summary>
		/// 对象JD_Customer_Log明细
		/// 编写人：ywk
		/// 编写日期：2018/8/24 星期五
		/// </summary>
		public JD_Customer_Log Detail(int ItemID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM JD_Customer_Log WHERE ItemID = @m_ItemID", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_ItemID", SqlDbType.Int, 0)).Value = ItemID;

            JD_Customer_Log myDetail = new JD_Customer_Log();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                if (!Convert.IsDBNull(myReader["ItemID"])) { myDetail.ItemID = Convert.ToInt32(myReader["ItemID"]); }
                if (!Convert.IsDBNull(myReader["TaskID"])) { myDetail.TaskID = Convert.ToInt32(myReader["TaskID"]); }
                if (!Convert.IsDBNull(myReader["RequestUser"])) { myDetail.RequestUser = Convert.ToString(myReader["RequestUser"]); }
                if (!Convert.IsDBNull(myReader["RequestDept"])) { myDetail.RequestDept = Convert.ToString(myReader["RequestDept"]); }
                if (!Convert.IsDBNull(myReader["RequestDate"])) { myDetail.RequestDate = Convert.ToDateTime(myReader["RequestDate"]); }
                if (!Convert.IsDBNull(myReader["SNumber"])) { myDetail.SNumber = Convert.ToString(myReader["SNumber"]); }
                if (!Convert.IsDBNull(myReader["FSaleModeName"])) { myDetail.FSaleModeName = Convert.ToString(myReader["FSaleModeName"]); }
                if (!Convert.IsDBNull(myReader["FSaleModeID"])) { myDetail.FSaleModeID = Convert.ToString(myReader["FSaleModeID"]); }
                if (!Convert.IsDBNull(myReader["FSaleModeNumber"])) { myDetail.FSaleModeNumber = Convert.ToString(myReader["FSaleModeNumber"]); }
                if (!Convert.IsDBNull(myReader["FSaleTypeName"])) { myDetail.FSaleTypeName = Convert.ToString(myReader["FSaleTypeName"]); }
                if (!Convert.IsDBNull(myReader["FSaleTypeID"])) { myDetail.FSaleTypeID = Convert.ToString(myReader["FSaleTypeID"]); }
                if (!Convert.IsDBNull(myReader["FSaleTypeNumber"])) { myDetail.FSaleTypeNumber = Convert.ToString(myReader["FSaleTypeNumber"]); }
                if (!Convert.IsDBNull(myReader["FCyName"])) { myDetail.FCyName = Convert.ToString(myReader["FCyName"]); }
                if (!Convert.IsDBNull(myReader["FCyID"])) { myDetail.FCyID = Convert.ToString(myReader["FCyID"]); }
                if (!Convert.IsDBNull(myReader["FCyNumber"])) { myDetail.FCyNumber = Convert.ToString(myReader["FCyNumber"]); }
                if (!Convert.IsDBNull(myReader["FAPAccountIDName"])) { myDetail.FAPAccountIDName = Convert.ToString(myReader["FAPAccountIDName"]); }
                if (!Convert.IsDBNull(myReader["FAPAccountIDNumber"])) { myDetail.FAPAccountIDNumber = Convert.ToString(myReader["FAPAccountIDNumber"]); }
                if (!Convert.IsDBNull(myReader["FPreAcctIDName"])) { myDetail.FPreAcctIDName = Convert.ToString(myReader["FPreAcctIDName"]); }
                if (!Convert.IsDBNull(myReader["FPreAcctIDNumber"])) { myDetail.FPreAcctIDNumber = Convert.ToString(myReader["FPreAcctIDNumber"]); }
                if (!Convert.IsDBNull(myReader["FOtherAPAcctIDName"])) { myDetail.FOtherAPAcctIDName = Convert.ToString(myReader["FOtherAPAcctIDName"]); }
                if (!Convert.IsDBNull(myReader["FOtherAPAcctIDNumber"])) { myDetail.FOtherAPAcctIDNumber = Convert.ToString(myReader["FOtherAPAcctIDNumber"]); }
                if (!Convert.IsDBNull(myReader["FPayTaxAcctIDName"])) { myDetail.FPayTaxAcctIDName = Convert.ToString(myReader["FPayTaxAcctIDName"]); }
                if (!Convert.IsDBNull(myReader["FPayTaxAcctIDNumber"])) { myDetail.FPayTaxAcctIDNumber = Convert.ToString(myReader["FPayTaxAcctIDNumber"]); }
                if (!Convert.IsDBNull(myReader["FemployeeName"])) { myDetail.FemployeeName = Convert.ToString(myReader["FemployeeName"]); }
                if (!Convert.IsDBNull(myReader["FemployeeNumber"])) { myDetail.FemployeeNumber = Convert.ToString(myReader["FemployeeNumber"]); }
                if (!Convert.IsDBNull(myReader["FPayConditionName"])) { myDetail.FPayConditionName = Convert.ToString(myReader["FPayConditionName"]); }
                if (!Convert.IsDBNull(myReader["FPayConditionNumber"])) { myDetail.FPayConditionNumber = Convert.ToString(myReader["FPayConditionNumber"]); }
                if (!Convert.IsDBNull(myReader["FSetIDName"])) { myDetail.FSetIDName = Convert.ToString(myReader["FSetIDName"]); }
                if (!Convert.IsDBNull(myReader["FSetIDNumber"])) { myDetail.FSetIDNumber = Convert.ToString(myReader["FSetIDNumber"]); }
                if (!Convert.IsDBNull(myReader["CustomerName"])) { myDetail.CustomerName = Convert.ToString(myReader["CustomerName"]); }
                if (!Convert.IsDBNull(myReader["CustomerNameEN"])) { myDetail.CustomerNameEN = Convert.ToString(myReader["CustomerNameEN"]); }
                if (!Convert.IsDBNull(myReader["CompanyAddress"])) { myDetail.CompanyAddress = Convert.ToString(myReader["CompanyAddress"]); }
                if (!Convert.IsDBNull(myReader["Headquarter"])) { myDetail.Headquarter = Convert.ToString(myReader["Headquarter"]); }
                if (!Convert.IsDBNull(myReader["CompanyContact"])) { myDetail.CompanyContact = Convert.ToString(myReader["CompanyContact"]); }
                if (!Convert.IsDBNull(myReader["CustomTel"])) { myDetail.CustomTel = Convert.ToString(myReader["CustomTel"]); }
                if (!Convert.IsDBNull(myReader["CustomFax"])) { myDetail.CustomFax = Convert.ToString(myReader["CustomFax"]); }
                if (!Convert.IsDBNull(myReader["CustomEmail"])) { myDetail.CustomEmail = Convert.ToString(myReader["CustomEmail"]); }
                if (!Convert.IsDBNull(myReader["BankAccount"])) { myDetail.BankAccount = Convert.ToString(myReader["BankAccount"]); }
                if (!Convert.IsDBNull(myReader["BankName"])) { myDetail.BankName = Convert.ToString(myReader["BankName"]); }
                if (!Convert.IsDBNull(myReader["BankAddress"])) { myDetail.BankAddress = Convert.ToString(myReader["BankAddress"]); }
                if (!Convert.IsDBNull(myReader["BankAccountNo"])) { myDetail.BankAccountNo = Convert.ToString(myReader["BankAccountNo"]); }
                if (!Convert.IsDBNull(myReader["VATNo"])) { myDetail.VATNo = Convert.ToString(myReader["VATNo"]); }
                if (!Convert.IsDBNull(myReader["SwiftCode"])) { myDetail.SwiftCode = Convert.ToString(myReader["SwiftCode"]); }
                if (!Convert.IsDBNull(myReader["ABANumber"])) { myDetail.ABANumber = Convert.ToString(myReader["ABANumber"]); }
                if (!Convert.IsDBNull(myReader["IBANumber"])) { myDetail.IBANumber = Convert.ToString(myReader["IBANumber"]); }
                if (!Convert.IsDBNull(myReader["PayTerms"])) { myDetail.PayTerms = Convert.ToString(myReader["PayTerms"]); }
                if (!Convert.IsDBNull(myReader["PayTermsCode"])) { myDetail.PayTermsCode = Convert.ToString(myReader["PayTermsCode"]); }
                if (!Convert.IsDBNull(myReader["PayMethod"])) { myDetail.PayMethod = Convert.ToString(myReader["PayMethod"]); }
                if (!Convert.IsDBNull(myReader["PayMethodCode"])) { myDetail.PayMethodCode = Convert.ToString(myReader["PayMethodCode"]); }
                if (!Convert.IsDBNull(myReader["CreditLimit"])) { myDetail.CreditLimit = Convert.ToString(myReader["CreditLimit"]); }
                if (!Convert.IsDBNull(myReader["Currency"])) { myDetail.Currency = Convert.ToString(myReader["Currency"]); }
                if (!Convert.IsDBNull(myReader["CurrencyCode"])) { myDetail.CurrencyCode = Convert.ToString(myReader["CurrencyCode"]); }
                if (!Convert.IsDBNull(myReader["FinanceContacter"])) { myDetail.FinanceContacter = Convert.ToString(myReader["FinanceContacter"]); }
                if (!Convert.IsDBNull(myReader["PayTel"])) { myDetail.PayTel = Convert.ToString(myReader["PayTel"]); }
                if (!Convert.IsDBNull(myReader["PayFax"])) { myDetail.PayFax = Convert.ToString(myReader["PayFax"]); }
                if (!Convert.IsDBNull(myReader["PayEmail"])) { myDetail.PayEmail = Convert.ToString(myReader["PayEmail"]); }
                if (!Convert.IsDBNull(myReader["DeliveryEXW"])) { myDetail.DeliveryEXW = Convert.ToString(myReader["DeliveryEXW"]); }
                if (!Convert.IsDBNull(myReader["DeliveryDDP"])) { myDetail.DeliveryDDP = Convert.ToString(myReader["DeliveryDDP"]); }
                if (!Convert.IsDBNull(myReader["DeliveryCIF"])) { myDetail.DeliveryCIF = Convert.ToString(myReader["DeliveryCIF"]); }
                if (!Convert.IsDBNull(myReader["DeliveryFCA"])) { myDetail.DeliveryFCA = Convert.ToString(myReader["DeliveryFCA"]); }
                if (!Convert.IsDBNull(myReader["DeliveryDDU"])) { myDetail.DeliveryDDU = Convert.ToString(myReader["DeliveryDDU"]); }
                if (!Convert.IsDBNull(myReader["DeliveryFOB"])) { myDetail.DeliveryFOB = Convert.ToString(myReader["DeliveryFOB"]); }
                if (!Convert.IsDBNull(myReader["ShipVia"])) { myDetail.ShipVia = Convert.ToString(myReader["ShipVia"]); }
                if (!Convert.IsDBNull(myReader["BillAddress"])) { myDetail.BillAddress = Convert.ToString(myReader["BillAddress"]); }
                if (!Convert.IsDBNull(myReader["BillContacter"])) { myDetail.BillContacter = Convert.ToString(myReader["BillContacter"]); }
                if (!Convert.IsDBNull(myReader["BillTel"])) { myDetail.BillTel = Convert.ToString(myReader["BillTel"]); }
                if (!Convert.IsDBNull(myReader["BillFax"])) { myDetail.BillFax = Convert.ToString(myReader["BillFax"]); }
                if (!Convert.IsDBNull(myReader["BillEmail"])) { myDetail.BillEmail = Convert.ToString(myReader["BillEmail"]); }
                if (!Convert.IsDBNull(myReader["ShipAddress"])) { myDetail.ShipAddress = Convert.ToString(myReader["ShipAddress"]); }
                if (!Convert.IsDBNull(myReader["ShipContacter"])) { myDetail.ShipContacter = Convert.ToString(myReader["ShipContacter"]); }
                if (!Convert.IsDBNull(myReader["ShipPhone"])) { myDetail.ShipPhone = Convert.ToString(myReader["ShipPhone"]); }
                if (!Convert.IsDBNull(myReader["ShipFax"])) { myDetail.ShipFax = Convert.ToString(myReader["ShipFax"]); }
                if (!Convert.IsDBNull(myReader["ShipEmail"])) { myDetail.ShipEmail = Convert.ToString(myReader["ShipEmail"]); }
                if (!Convert.IsDBNull(myReader["FShortName"])) { myDetail.FShortName = Convert.ToString(myReader["FShortName"]); }
                if (!Convert.IsDBNull(myReader["FValueAddRate"])) { myDetail.FValueAddRate = Convert.ToInt32(myReader["FValueAddRate"]); }
                if (!Convert.IsDBNull(myReader["IsUpdate"])) { myDetail.IsUpdate = Convert.ToInt32(myReader["IsUpdate"]); }
                if (!Convert.IsDBNull(myReader["LogType"])) { myDetail.LogType = Convert.ToString(myReader["LogType"]); }
                if (!Convert.IsDBNull(myReader["FNumber"])) { myDetail.FNumber = Convert.ToString(myReader["FNumber"]); }
                if (!Convert.IsDBNull(myReader["FemployeeID"])) { myDetail.FemployeeID = Convert.ToInt32(myReader["FemployeeID"]); }
                if (!Convert.IsDBNull(myReader["FSetID"])) { myDetail.FSetID = Convert.ToInt32(myReader["FSetID"]); }
                if (!Convert.IsDBNull(myReader["FAPAccountID"])) { myDetail.FAPAccountID = Convert.ToInt32(myReader["FAPAccountID"]); }
                if (!Convert.IsDBNull(myReader["FpreAcctID"])) { myDetail.FpreAcctID = Convert.ToInt32(myReader["FpreAcctID"]); }
                if (!Convert.IsDBNull(myReader["FOtherAPAcctID"])) { myDetail.FOtherAPAcctID = Convert.ToInt32(myReader["FOtherAPAcctID"]); }
                if (!Convert.IsDBNull(myReader["FPayTaxAcctID"])) { myDetail.FPayTaxAcctID = Convert.ToInt32(myReader["FPayTaxAcctID"]); }
                if (!Convert.IsDBNull(myReader["FPayCondition"])) { myDetail.FPayCondition = Convert.ToInt32(myReader["FPayCondition"]); }
            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }

        /// <summary>
		/// 更新JD_Customer_Log对象
		/// 编写人：ywk
		/// 编写日期：2018/8/24 星期五
		/// </summary>
		public void Update(JD_Customer_Log model)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE JD_Customer_Log SET TaskID = @m_TaskID,RequestUser = @m_RequestUser,RequestDept = @m_RequestDept,RequestDate = @m_RequestDate,SNumber = @m_SNumber,FSaleModeName = @m_FSaleModeName,FSaleModeID = @m_FSaleModeID,FSaleModeNumber = @m_FSaleModeNumber,FSaleTypeName = @m_FSaleTypeName,FSaleTypeID = @m_FSaleTypeID,FSaleTypeNumber = @m_FSaleTypeNumber,FCyName = @m_FCyName,FCyID = @m_FCyID,FCyNumber = @m_FCyNumber,FAPAccountIDName = @m_FAPAccountIDName,FAPAccountIDNumber = @m_FAPAccountIDNumber,FPreAcctIDName = @m_FPreAcctIDName,FPreAcctIDNumber = @m_FPreAcctIDNumber,FOtherAPAcctIDName = @m_FOtherAPAcctIDName,FOtherAPAcctIDNumber = @m_FOtherAPAcctIDNumber,FPayTaxAcctIDName = @m_FPayTaxAcctIDName,FPayTaxAcctIDNumber = @m_FPayTaxAcctIDNumber,FemployeeName = @m_FemployeeName,FemployeeNumber = @m_FemployeeNumber,FPayConditionName = @m_FPayConditionName,FPayConditionNumber = @m_FPayConditionNumber,FSetIDName = @m_FSetIDName,FSetIDNumber = @m_FSetIDNumber,CustomerName = @m_CustomerName,CustomerNameEN = @m_CustomerNameEN,CompanyAddress = @m_CompanyAddress,Headquarter = @m_Headquarter,CompanyContact = @m_CompanyContact,CustomTel = @m_CustomTel,CustomFax = @m_CustomFax,CustomEmail = @m_CustomEmail,BankAccount = @m_BankAccount,BankName = @m_BankName,BankAddress = @m_BankAddress,BankAccountNo = @m_BankAccountNo,VATNo = @m_VATNo,SwiftCode = @m_SwiftCode,ABANumber = @m_ABANumber,IBANumber = @m_IBANumber,PayTerms = @m_PayTerms,PayTermsCode = @m_PayTermsCode,PayMethod = @m_PayMethod,PayMethodCode = @m_PayMethodCode,CreditLimit = @m_CreditLimit,Currency = @m_Currency,CurrencyCode = @m_CurrencyCode,FinanceContacter = @m_FinanceContacter,PayTel = @m_PayTel,PayFax = @m_PayFax,PayEmail = @m_PayEmail,DeliveryEXW = @m_DeliveryEXW,DeliveryDDP = @m_DeliveryDDP,DeliveryCIF = @m_DeliveryCIF,DeliveryFCA = @m_DeliveryFCA,DeliveryDDU = @m_DeliveryDDU,DeliveryFOB = @m_DeliveryFOB,ShipVia = @m_ShipVia,BillAddress = @m_BillAddress,BillContacter = @m_BillContacter,BillTel = @m_BillTel,BillFax = @m_BillFax,BillEmail = @m_BillEmail,ShipAddress = @m_ShipAddress,ShipContacter = @m_ShipContacter,ShipPhone = @m_ShipPhone,ShipFax = @m_ShipFax,ShipEmail = @m_ShipEmail,FShortName = @m_FShortName,FValueAddRate = @m_FValueAddRate,IsUpdate = @m_IsUpdate,LogType = @m_LogType,FNumber = @m_FNumber,FemployeeID = @m_FemployeeID,FSetID = @m_FSetID,FAPAccountID = @m_FAPAccountID,FpreAcctID = @m_FpreAcctID,FOtherAPAcctID = @m_FOtherAPAcctID,FPayTaxAcctID = @m_FPayTaxAcctID,FPayCondition = @m_FPayCondition WHERE ItemID = @m_ItemID", con);
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
            if (model.SNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SNumber", SqlDbType.NVarChar, 50)).Value = model.SNumber;
            }
            if (model.FSaleModeName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleModeName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleModeName", SqlDbType.NVarChar, 50)).Value = model.FSaleModeName;
            }
            if (model.FSaleModeID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleModeID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleModeID", SqlDbType.NVarChar, 50)).Value = model.FSaleModeID;
            }
            if (model.FSaleModeNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleModeNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleModeNumber", SqlDbType.NVarChar, 50)).Value = model.FSaleModeNumber;
            }
            if (model.FSaleTypeName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleTypeName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleTypeName", SqlDbType.NVarChar, 50)).Value = model.FSaleTypeName;
            }
            if (model.FSaleTypeID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleTypeID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleTypeID", SqlDbType.NVarChar, 50)).Value = model.FSaleTypeID;
            }
            if (model.FSaleTypeNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleTypeNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleTypeNumber", SqlDbType.NVarChar, 50)).Value = model.FSaleTypeNumber;
            }
            if (model.FCyName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyName", SqlDbType.NVarChar, 50)).Value = model.FCyName;
            }
            if (model.FCyID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyID", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyID", SqlDbType.NVarChar, 50)).Value = model.FCyID;
            }
            if (model.FCyNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyNumber", SqlDbType.NVarChar, 50)).Value = model.FCyNumber;
            }
            if (model.FAPAccountIDName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAPAccountIDName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAPAccountIDName", SqlDbType.NVarChar, 50)).Value = model.FAPAccountIDName;
            }
            if (model.FAPAccountIDNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAPAccountIDNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAPAccountIDNumber", SqlDbType.NVarChar, 50)).Value = model.FAPAccountIDNumber;
            }
            if (model.FPreAcctIDName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPreAcctIDName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPreAcctIDName", SqlDbType.NVarChar, 50)).Value = model.FPreAcctIDName;
            }
            if (model.FPreAcctIDNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPreAcctIDNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPreAcctIDNumber", SqlDbType.NVarChar, 50)).Value = model.FPreAcctIDNumber;
            }
            if (model.FOtherAPAcctIDName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherAPAcctIDName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherAPAcctIDName", SqlDbType.NVarChar, 50)).Value = model.FOtherAPAcctIDName;
            }
            if (model.FOtherAPAcctIDNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherAPAcctIDNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherAPAcctIDNumber", SqlDbType.NVarChar, 50)).Value = model.FOtherAPAcctIDNumber;
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
            if (model.FemployeeName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FemployeeName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FemployeeName", SqlDbType.NVarChar, 50)).Value = model.FemployeeName;
            }
            if (model.FemployeeNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FemployeeNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FemployeeNumber", SqlDbType.NVarChar, 50)).Value = model.FemployeeNumber;
            }
            if (model.FPayConditionName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayConditionName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayConditionName", SqlDbType.NVarChar, 50)).Value = model.FPayConditionName;
            }
            if (model.FPayConditionNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayConditionNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayConditionNumber", SqlDbType.NVarChar, 50)).Value = model.FPayConditionNumber;
            }
            if (model.FSetIDName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSetIDName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSetIDName", SqlDbType.NVarChar, 50)).Value = model.FSetIDName;
            }
            if (model.FSetIDNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSetIDNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSetIDNumber", SqlDbType.NVarChar, 50)).Value = model.FSetIDNumber;
            }
            if (model.CustomerName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomerName", SqlDbType.NVarChar, 200)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomerName", SqlDbType.NVarChar, 200)).Value = model.CustomerName;
            }
            if (model.CustomerNameEN == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomerNameEN", SqlDbType.NVarChar, 300)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomerNameEN", SqlDbType.NVarChar, 300)).Value = model.CustomerNameEN;
            }
            if (model.CompanyAddress == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CompanyAddress", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CompanyAddress", SqlDbType.NVarChar, 500)).Value = model.CompanyAddress;
            }
            if (model.Headquarter == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Headquarter", SqlDbType.NVarChar, 200)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Headquarter", SqlDbType.NVarChar, 200)).Value = model.Headquarter;
            }
            if (model.CompanyContact == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CompanyContact", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CompanyContact", SqlDbType.NVarChar, 50)).Value = model.CompanyContact;
            }
            if (model.CustomTel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomTel", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomTel", SqlDbType.NVarChar, 50)).Value = model.CustomTel;
            }
            if (model.CustomFax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomFax", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomFax", SqlDbType.NVarChar, 50)).Value = model.CustomFax;
            }
            if (model.CustomEmail == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomEmail", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CustomEmail", SqlDbType.NVarChar, 50)).Value = model.CustomEmail;
            }
            if (model.BankAccount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BankAccount", SqlDbType.NVarChar, 200)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BankAccount", SqlDbType.NVarChar, 200)).Value = model.BankAccount;
            }
            if (model.BankName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BankName", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BankName", SqlDbType.NVarChar, 100)).Value = model.BankName;
            }
            if (model.BankAddress == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BankAddress", SqlDbType.NVarChar, 300)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BankAddress", SqlDbType.NVarChar, 300)).Value = model.BankAddress;
            }
            if (model.BankAccountNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BankAccountNo", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BankAccountNo", SqlDbType.NVarChar, 100)).Value = model.BankAccountNo;
            }
            if (model.VATNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_VATNo", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_VATNo", SqlDbType.NVarChar, 100)).Value = model.VATNo;
            }
            if (model.SwiftCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_SwiftCode", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_SwiftCode", SqlDbType.NVarChar, 100)).Value = model.SwiftCode;
            }
            if (model.ABANumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ABANumber", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ABANumber", SqlDbType.NVarChar, 100)).Value = model.ABANumber;
            }
            if (model.IBANumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IBANumber", SqlDbType.NVarChar, 100)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IBANumber", SqlDbType.NVarChar, 100)).Value = model.IBANumber;
            }
            if (model.PayTerms == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PayTerms", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PayTerms", SqlDbType.NVarChar, 50)).Value = model.PayTerms;
            }
            if (model.PayTermsCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PayTermsCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PayTermsCode", SqlDbType.NVarChar, 50)).Value = model.PayTermsCode;
            }
            if (model.PayMethod == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PayMethod", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PayMethod", SqlDbType.NVarChar, 50)).Value = model.PayMethod;
            }
            if (model.PayMethodCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PayMethodCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PayMethodCode", SqlDbType.NVarChar, 50)).Value = model.PayMethodCode;
            }
            if (model.CreditLimit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreditLimit", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CreditLimit", SqlDbType.NVarChar, 50)).Value = model.CreditLimit;
            }
            if (model.Currency == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Currency", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Currency", SqlDbType.NVarChar, 50)).Value = model.Currency;
            }
            if (model.CurrencyCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_CurrencyCode", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_CurrencyCode", SqlDbType.NVarChar, 50)).Value = model.CurrencyCode;
            }
            if (model.FinanceContacter == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FinanceContacter", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FinanceContacter", SqlDbType.NVarChar, 50)).Value = model.FinanceContacter;
            }
            if (model.PayTel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PayTel", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PayTel", SqlDbType.NVarChar, 50)).Value = model.PayTel;
            }
            if (model.PayFax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PayFax", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PayFax", SqlDbType.NVarChar, 50)).Value = model.PayFax;
            }
            if (model.PayEmail == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_PayEmail", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_PayEmail", SqlDbType.NVarChar, 50)).Value = model.PayEmail;
            }
            if (model.DeliveryEXW == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeliveryEXW", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeliveryEXW", SqlDbType.NVarChar, 50)).Value = model.DeliveryEXW;
            }
            if (model.DeliveryDDP == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeliveryDDP", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeliveryDDP", SqlDbType.NVarChar, 50)).Value = model.DeliveryDDP;
            }
            if (model.DeliveryCIF == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeliveryCIF", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeliveryCIF", SqlDbType.NVarChar, 50)).Value = model.DeliveryCIF;
            }
            if (model.DeliveryFCA == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeliveryFCA", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeliveryFCA", SqlDbType.NVarChar, 50)).Value = model.DeliveryFCA;
            }
            if (model.DeliveryDDU == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeliveryDDU", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeliveryDDU", SqlDbType.NVarChar, 50)).Value = model.DeliveryDDU;
            }
            if (model.DeliveryFOB == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeliveryFOB", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_DeliveryFOB", SqlDbType.NVarChar, 50)).Value = model.DeliveryFOB;
            }
            if (model.ShipVia == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShipVia", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShipVia", SqlDbType.NVarChar, 50)).Value = model.ShipVia;
            }
            if (model.BillAddress == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BillAddress", SqlDbType.NVarChar, 300)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BillAddress", SqlDbType.NVarChar, 300)).Value = model.BillAddress;
            }
            if (model.BillContacter == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BillContacter", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BillContacter", SqlDbType.NVarChar, 50)).Value = model.BillContacter;
            }
            if (model.BillTel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BillTel", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BillTel", SqlDbType.NVarChar, 50)).Value = model.BillTel;
            }
            if (model.BillFax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BillFax", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BillFax", SqlDbType.NVarChar, 50)).Value = model.BillFax;
            }
            if (model.BillEmail == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_BillEmail", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_BillEmail", SqlDbType.NVarChar, 50)).Value = model.BillEmail;
            }
            if (model.ShipAddress == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShipAddress", SqlDbType.NVarChar, 500)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShipAddress", SqlDbType.NVarChar, 500)).Value = model.ShipAddress;
            }
            if (model.ShipContacter == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShipContacter", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShipContacter", SqlDbType.NVarChar, 50)).Value = model.ShipContacter;
            }
            if (model.ShipPhone == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShipPhone", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShipPhone", SqlDbType.NVarChar, 50)).Value = model.ShipPhone;
            }
            if (model.ShipFax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShipFax", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShipFax", SqlDbType.NVarChar, 50)).Value = model.ShipFax;
            }
            if (model.ShipEmail == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShipEmail", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_ShipEmail", SqlDbType.NVarChar, 50)).Value = model.ShipEmail;
            }
            if (model.FShortName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FShortName", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FShortName", SqlDbType.NVarChar, 50)).Value = model.FShortName;
            }
            if (model.FValueAddRate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FValueAddRate", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FValueAddRate", SqlDbType.Int, 0)).Value = model.FValueAddRate;
            }
            if (model.IsUpdate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_IsUpdate", SqlDbType.Int, 0)).Value = model.IsUpdate;
            }
            if (model.LogType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_LogType", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_LogType", SqlDbType.NVarChar, 50)).Value = model.LogType;
            }
            if (model.FNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.NVarChar, 50)).Value = model.FNumber;
            }
            if (model.FemployeeID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FemployeeID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FemployeeID", SqlDbType.Int, 0)).Value = model.FemployeeID;
            }
            if (model.FSetID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSetID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSetID", SqlDbType.Int, 0)).Value = model.FSetID;
            }
            if (model.FAPAccountID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAPAccountID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAPAccountID", SqlDbType.Int, 0)).Value = model.FAPAccountID;
            }
            if (model.FpreAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FpreAcctID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FpreAcctID", SqlDbType.Int, 0)).Value = model.FpreAcctID;
            }
            if (model.FOtherAPAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherAPAcctID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherAPAcctID", SqlDbType.Int, 0)).Value = model.FOtherAPAcctID;
            }
            if (model.FPayTaxAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctID", SqlDbType.Int, 0)).Value = model.FPayTaxAcctID;
            }
            if (model.FPayCondition == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayCondition", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayCondition", SqlDbType.Int, 0)).Value = model.FPayCondition;
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
            string sql = string.Format("select * from JD_Customer_Log where IsUpdate=0");
            return DBUtil.Query(sql).Tables[0].DefaultView;
        }
        //获取最大编号
        protected string GetMaxNo()
        {
            string sql = string.Format(@" select FNUmber from t_Organization where  FItemID in (select MAX(FItemID) from t_Organization)" );
            object obj = DBUtil.GetSingle(sql,K3connectionString);
            string FNUmber= (obj != null) ? obj.ToString() : "";
            string MaxNo = string.Empty;
            if (FNUmber.IndexOf('-') > -1)
            {
                MaxNo = (Convert.ToInt32(FNUmber.Split('-')[1]) + 1).ToString("000");
            }
            return MaxNo;
        }



        /// <summary>
        /// 客户新增完成 更新编号 JD_Customer和JD_Customer_Mng
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="FNumber"></param>
        protected void UpdateFNumber(string TaskID, string FNumber)
        {
            string sql = string.Format(@" update JD_Customer_Mng set FNumber='{0}' where TaskID='{1}'", FNumber, TaskID);
            DBUtil.ExecuteSql(sql);
            sql = string.Format(@" update JD_Customer set FNumber='{0}' where TaskID='{1}'", FNumber, TaskID);
            DBUtil.ExecuteSql(sql);
        }
        //客户新增 集成K3API
        public void CustomerAdd(int ItemID, string APIUrl, string FuncName, string Token, string FileType)
        {
            JD_Customer_Log logmodel = Detail(ItemID);
            JD_Customer_MngDal Mngdal = new JD_Customer_MngDal();
            string objectMame = FuncName;
            string actionName = "GetTemplate";
            string saveName = "Save";
            string json = " "; //请求的参数
            string loginUrl = string.Empty;
            Customer model = new Customer();
            string htmlCode = "";
            string ErrorMsg = string.Empty;
            string MaxNo = string.Empty;
            try
            {
                if (logmodel != null)
                {
                    #region 解析客户API模板
                    loginUrl = APIUrl + objectMame + "/" + actionName + "?Token=" + Token;
                    HttpWebResponse response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, json, null, null, Encoding.UTF8, null);
                    Stream resStream = response.GetResponseStream();
                    StreamReader sr = new StreamReader(resStream, Encoding.UTF8);
                    htmlCode = sr.ReadToEnd();//获取返回JSON
                    htmlCode = "{\"" + htmlCode.Substring(htmlCode.IndexOf("Data"), htmlCode.Length - htmlCode.IndexOf("Data"));
                    model = JsonConvert.DeserializeObject<Customer>(htmlCode);
                    #endregion

                    #region API模板赋值
                    MaxNo = GetMaxNo();
                    model.Data.FNumber = CustomCodeType + "-" + MaxNo;

                    model.Data.FStatus.FName = "使用";
                    model.Data.FStatus.FID = "ZT01";

                    //基础信息
                    model.Data.FSaleMode.FName = logmodel.FSaleModeName;  //销售模式
                    model.Data.FSaleMode.FID = logmodel.FSaleModeID;

                    model.Data.FSaleID.FID = logmodel.FSaleTypeID;  //销售方式
                    model.Data.FSaleID.FName = logmodel.FSaleTypeName;


                    //应收应付资料
                    model.Data.FCyID.FName = logmodel.FCyName;    //结算币种
                    model.Data.FCyID.FNumber = logmodel.FCyNumber;

                    model.Data.Femployee.FName = logmodel.FemployeeName;
                    model.Data.Femployee.FNumber = logmodel.FemployeeNumber;  //营业员

                    model.Data.FSetID.FName = logmodel.FSetIDName;  //结算方式
                    model.Data.FSetID.FNumber = logmodel.FSetIDNumber;


                    model.Data.FAPAccountID.FName = logmodel.FAPAccountIDName;   //应付账款科目代码 
                    model.Data.FAPAccountID.FNumber = logmodel.FAPAccountIDNumber;


                    model.Data.FPreAcctID.FName = logmodel.FPreAcctIDName;   //预付账款科目代码 
                    model.Data.FPreAcctID.FNumber = logmodel.FPreAcctIDNumber;


                    model.Data.FOtherAPAcctID.FName = logmodel.FOtherAPAcctIDName;   //其他应付账款科目代码
                    model.Data.FOtherAPAcctID.FNumber = logmodel.FOtherAPAcctIDNumber;


                    model.Data.FPayTaxAcctID.FName = logmodel.FPayTaxAcctIDName;   //应交税金科目代码
                    model.Data.FPayTaxAcctID.FNumber = logmodel.FPayTaxAcctIDNumber;

                    model.Data.FPayCondition[0].FName = logmodel.FPayConditionName;   //收款条件
                    model.Data.FPayCondition[0].FNumber = logmodel.FPayConditionName;

                    model.Data.FValueAddRate = logmodel.FValueAddRate;

                    //客户信息

                    model.Data.FName = logmodel.CustomerName;//客户名称

                    model.Data.FAddress = logmodel.CompanyAddress;    //地址
                                                                      //model.Data.FValueAddRate = Convert.ToInt32(logmodel.FValueAddRate); //税率
                    model.Data.FBank = logmodel.BankName; //开户行
                    model.Data.FAccount = logmodel.BankAccount; //银行账号

                    model.Data.FContact = logmodel.CompanyContact; //联系人
                    model.Data.FPhone = logmodel.CustomTel; //电话
                    model.Data.FMobilePhone = logmodel.CustomTel; //移动电话
                    model.Data.FFax = logmodel.CustomFax;
                    //model.Data.FEmail = logmodel.CustomEmail;
                    model.Data.FTaxNum = logmodel.SwiftCode;
                     
                    model.Data.FShortName = logmodel.FShortName;  //简称

                    model.Data.FCountry = logmodel.Headquarter;  //首都 
                    
                    #endregion

                    #region K3集成新增 
                    string Json = JsonConvert.SerializeObject(model);

                    Json = "{\"data\":[{" + Json.Substring(9, Json.Length - 9 - 2) + "}]}";

                    //记录日志 解析数据
                    common.WriteLogs(FileType, logmodel.TaskID.ToString(), "解析的Json数据：");
                    common.WriteLogs(FileType, logmodel.TaskID.ToString(), Json);

                    loginUrl = APIUrl + objectMame + "/" + saveName + "?Token=" + Token;
                    //发送数据
                    Result result = common.SendToK3(loginUrl, Json);


                    //记录日志
                    if (result.Message != "Successful")
                    {
                        common.WriteLogs(FileType, logmodel.TaskID.ToString(), "API Send Error:");
                        common.WriteLogs(FileType, logmodel.TaskID.ToString(), result.Data);
                        ErrorMsg = result.Message+":"+ result.Data;
                    }
                    else
                    {
                        common.WriteLogs(FileType, logmodel.TaskID.ToString(), "API Success:");
                        common.WriteLogs(FileType, logmodel.TaskID.ToString(), result.Message);
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
                    logmodel.FNumber = CustomCodeType + "-" + MaxNo; 
                    Update(logmodel);

                    //更新供应商维护的编号
                    UpdateFNumber(logmodel.TaskID.ToString(), logmodel.FNumber);
                }

                //记录日志
                if (!string.IsNullOrEmpty(ErrorMsg))
                {
                    common.AddLogQueue(logmodel.TaskID, "JD_Customer_Log", ItemID, "API", ErrorMsg, false);
                }
                else
                {
                    common.AddLogQueue(logmodel.TaskID, "JD_Customer_Log", ItemID, "API", "操作成功！客户编号：" + CustomCodeType + "-" + MaxNo, true);
                }

            }
        }

        //客户变更 集成K3数据库
        public void UpdateCustomer(int ItemID, string FileType)
        {
            string Error = string.Empty;
            JD_Customer_Log logmodel = Detail(ItemID);
            t_OrganizationDal k3dal = new t_OrganizationDal();
            t_Organization k3model = new t_Organization();
            try
            {
                 
                if (logmodel != null)
                {
                     k3model = k3dal.Detail(logmodel.FNumber);
                    #region 基础信息
                   
                    k3model.FSaleMode= Convert.ToInt32(logmodel.FSaleModeNumber); //销售模式
                    k3model.FSaleID = Convert.ToInt32(logmodel.FSaleTypeNumber);      //销售方式 
                    #endregion

                    #region 应收应付资料
                    k3model.FCyID = Convert.ToInt32(logmodel.FCyID);    //结算币种
                    k3model.Femployee= Convert.ToInt32(logmodel.FemployeeID);  //营业员
                    k3model.FSetID = Convert.ToInt32(logmodel.FSetID); //结算方式

                    k3model.FAPAccountID = logmodel.FAPAccountID; //应付账款科目代码 

                    k3model.FpreAcctID = logmodel.FpreAcctID;  //预付账款科目代码 

                    k3model.FOtherAPAcctID = logmodel.FOtherAPAcctID;  //其他应付账款科目代码

                    k3model.FPayTaxAcctID = logmodel.FPayTaxAcctID; //应交税金科目代码

                    k3model.FPayCondition = logmodel.FPayCondition;//收款条件

                    k3model.FValueAddRate = logmodel.FValueAddRate;
                    #endregion

                    #region 客户资料
                    k3model.FName = logmodel.CustomerName;//客户名称

                    k3model.FAddress = logmodel.CompanyAddress;    //地址
                    
                    k3model.FBank = logmodel.BankName; //开户行
                    k3model.FAccount = logmodel.BankAccount; //银行账号

                    k3model.FContact = logmodel.CompanyContact; //联系人
                    k3model.FPhone = logmodel.CustomTel; //电话
                    k3model.FMobilePhone = logmodel.CustomTel; //移动电话
                    k3model.FFax = logmodel.CustomFax;
                    //model.Data.FEmail = logmodel.CustomEmail;
                    k3model.FTaxNum = logmodel.SwiftCode;

                    k3model.FShortName = logmodel.FShortName;  //简称

                    k3model.FCountry = logmodel.Headquarter;  //首都 
                    #endregion
                }
                else
                {
                    throw new Exception("JD_Customer_Log对象不存在！");
                }
                k3dal.Update(k3model); 
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                common.WriteLogs(FileType, logmodel.TaskID.ToString(), Error);
            }
            finally {
             
                logmodel.IsUpdate = 1;
                Update(logmodel);
                //记录集成日志 
                common.AddLogQueue(logmodel.TaskID, "JD_Customer_Log", ItemID, "SQL", Error);

            }
         
        }

    }
}
