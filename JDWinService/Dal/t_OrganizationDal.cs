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
    public class t_OrganizationDal
    {
        Common common = new Common();
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息

        /// <summary>
		/// 对象t_Organization明细
		/// 编写人：ywk
		/// 编写日期：2018/9/6 星期四
		/// </summary>
		public t_Organization Detail(string FNumber)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM t_Organization WHERE FNumber = @m_FNumber", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.VarChar, 255)).Value = FNumber;

            t_Organization myDetail = new t_Organization();
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                if (!Convert.IsDBNull(myReader["FItemID"])) { myDetail.FItemID = Convert.ToInt32(myReader["FItemID"]); }
                if (!Convert.IsDBNull(myReader["FAddress"])) { myDetail.FAddress = Convert.ToString(myReader["FAddress"]); }
                if (!Convert.IsDBNull(myReader["FCity"])) { myDetail.FCity = Convert.ToString(myReader["FCity"]); }
                if (!Convert.IsDBNull(myReader["FProvince"])) { myDetail.FProvince = Convert.ToString(myReader["FProvince"]); }
                if (!Convert.IsDBNull(myReader["FCountry"])) { myDetail.FCountry = Convert.ToString(myReader["FCountry"]); }
                if (!Convert.IsDBNull(myReader["FPostalCode"])) { myDetail.FPostalCode = Convert.ToString(myReader["FPostalCode"]); }
                if (!Convert.IsDBNull(myReader["FPhone"])) { myDetail.FPhone = Convert.ToString(myReader["FPhone"]); }
                if (!Convert.IsDBNull(myReader["FFax"])) { myDetail.FFax = Convert.ToString(myReader["FFax"]); }
                if (!Convert.IsDBNull(myReader["FEmail"])) { myDetail.FEmail = Convert.ToString(myReader["FEmail"]); }
                if (!Convert.IsDBNull(myReader["FHomePage"])) { myDetail.FHomePage = Convert.ToString(myReader["FHomePage"]); }
                if (!Convert.IsDBNull(myReader["FCreditLimit"])) { myDetail.FCreditLimit = Convert.ToString(myReader["FCreditLimit"]); }
                if (!Convert.IsDBNull(myReader["FTaxID"])) { myDetail.FTaxID = Convert.ToString(myReader["FTaxID"]); }
                if (!Convert.IsDBNull(myReader["FBank"])) { myDetail.FBank = Convert.ToString(myReader["FBank"]); }
                if (!Convert.IsDBNull(myReader["FAccount"])) { myDetail.FAccount = Convert.ToString(myReader["FAccount"]); }
                if (!Convert.IsDBNull(myReader["FBankNumber"])) { myDetail.FBankNumber = Convert.ToString(myReader["FBankNumber"]); }
                if (!Convert.IsDBNull(myReader["FBrNo"])) { myDetail.FBrNo = Convert.ToString(myReader["FBrNo"]); }
                if (!Convert.IsDBNull(myReader["FBoundAttr"])) { myDetail.FBoundAttr = Convert.ToInt32(myReader["FBoundAttr"]); }
                if (!Convert.IsDBNull(myReader["FErpClsID"])) { myDetail.FErpClsID = Convert.ToInt32(myReader["FErpClsID"]); }
                if (!Convert.IsDBNull(myReader["FShortName"])) { myDetail.FShortName = Convert.ToString(myReader["FShortName"]); }
                if (!Convert.IsDBNull(myReader["FPriorityID"])) { myDetail.FPriorityID = Convert.ToInt32(myReader["FPriorityID"]); }
                if (!Convert.IsDBNull(myReader["FPOGroupID"])) { myDetail.FPOGroupID = Convert.ToInt32(myReader["FPOGroupID"]); }
                if (!Convert.IsDBNull(myReader["FStatus"])) { myDetail.FStatus = Convert.ToInt32(myReader["FStatus"]); }
                if (!Convert.IsDBNull(myReader["FLanguageID"])) { myDetail.FLanguageID = Convert.ToInt32(myReader["FLanguageID"]); }
                if (!Convert.IsDBNull(myReader["FRegionID"])) { myDetail.FRegionID = Convert.ToInt32(myReader["FRegionID"]); }
                if (!Convert.IsDBNull(myReader["FTrade"])) { myDetail.FTrade = Convert.ToInt32(myReader["FTrade"]); }
                if (!Convert.IsDBNull(myReader["FMinPOValue"])) { myDetail.FMinPOValue = Convert.ToDouble(myReader["FMinPOValue"]); }
                if (!Convert.IsDBNull(myReader["FMaxDebitDate"])) { myDetail.FMaxDebitDate = Convert.ToDouble(myReader["FMaxDebitDate"]); }
                if (!Convert.IsDBNull(myReader["FLegalPerson"])) { myDetail.FLegalPerson = Convert.ToString(myReader["FLegalPerson"]); }
                if (!Convert.IsDBNull(myReader["FContact"])) { myDetail.FContact = Convert.ToString(myReader["FContact"]); }
                if (!Convert.IsDBNull(myReader["FContactAcct"])) { myDetail.FContactAcct = Convert.ToString(myReader["FContactAcct"]); }
                if (!Convert.IsDBNull(myReader["FPhoneAcct"])) { myDetail.FPhoneAcct = Convert.ToString(myReader["FPhoneAcct"]); }
                if (!Convert.IsDBNull(myReader["FFaxAcct"])) { myDetail.FFaxAcct = Convert.ToString(myReader["FFaxAcct"]); }
                if (!Convert.IsDBNull(myReader["FZipAcct"])) { myDetail.FZipAcct = Convert.ToString(myReader["FZipAcct"]); }
                if (!Convert.IsDBNull(myReader["FEmailAcct"])) { myDetail.FEmailAcct = Convert.ToString(myReader["FEmailAcct"]); }
                if (!Convert.IsDBNull(myReader["FAddrAcct"])) { myDetail.FAddrAcct = Convert.ToString(myReader["FAddrAcct"]); }
                if (!Convert.IsDBNull(myReader["FTax"])) { myDetail.FTax = float.Parse(myReader["FTax"].ToString()); }
                if (!Convert.IsDBNull(myReader["FCyID"])) { myDetail.FCyID = Convert.ToInt32(myReader["FCyID"]); }
                if (!Convert.IsDBNull(myReader["FSetID"])) { myDetail.FSetID = Convert.ToInt32(myReader["FSetID"]); }
                if (!Convert.IsDBNull(myReader["FSetDLineID"])) { myDetail.FSetDLineID = Convert.ToInt32(myReader["FSetDLineID"]); }
                if (!Convert.IsDBNull(myReader["FTaxNum"])) { myDetail.FTaxNum = Convert.ToString(myReader["FTaxNum"]); }
                if (!Convert.IsDBNull(myReader["FPriceClsID"])) { myDetail.FPriceClsID = Convert.ToInt32(myReader["FPriceClsID"]); }
                if (!Convert.IsDBNull(myReader["FOperID"])) { myDetail.FOperID = Convert.ToInt32(myReader["FOperID"]); }
                if (!Convert.IsDBNull(myReader["FCIQNumber"])) { myDetail.FCIQNumber = Convert.ToString(myReader["FCIQNumber"]); }
                if (!Convert.IsDBNull(myReader["FDeleted"])) { myDetail.FDeleted = Convert.ToInt16(myReader["FDeleted"]); }
                if (!Convert.IsDBNull(myReader["FSaleMode"])) { myDetail.FSaleMode = Convert.ToInt32(myReader["FSaleMode"]); }
                if (!Convert.IsDBNull(myReader["FName"])) { myDetail.FName = Convert.ToString(myReader["FName"]); }
                if (!Convert.IsDBNull(myReader["FNumber"])) { myDetail.FNumber = Convert.ToString(myReader["FNumber"]); }
                if (!Convert.IsDBNull(myReader["FParentID"])) { myDetail.FParentID = Convert.ToInt32(myReader["FParentID"]); }
                if (!Convert.IsDBNull(myReader["FShortNumber"])) { myDetail.FShortNumber = Convert.ToString(myReader["FShortNumber"]); }
                if (!Convert.IsDBNull(myReader["FARAccountID"])) { myDetail.FARAccountID = Convert.ToInt32(myReader["FARAccountID"]); }
                if (!Convert.IsDBNull(myReader["FAPAccountID"])) { myDetail.FAPAccountID = Convert.ToInt32(myReader["FAPAccountID"]); }
                if (!Convert.IsDBNull(myReader["FpreAcctID"])) { myDetail.FpreAcctID = Convert.ToInt32(myReader["FpreAcctID"]); }
                if (!Convert.IsDBNull(myReader["FlastTradeAmount"])) { myDetail.FlastTradeAmount = Convert.ToDecimal(myReader["FlastTradeAmount"]); }
                if (!Convert.IsDBNull(myReader["FlastRPAmount"])) { myDetail.FlastRPAmount = Convert.ToDecimal(myReader["FlastRPAmount"]); }
                if (!Convert.IsDBNull(myReader["FfavorPolicy"])) { myDetail.FfavorPolicy = Convert.ToString(myReader["FfavorPolicy"]); }
                if (!Convert.IsDBNull(myReader["Fdepartment"])) { myDetail.Fdepartment = Convert.ToInt32(myReader["Fdepartment"]); }
                if (!Convert.IsDBNull(myReader["Femployee"])) { myDetail.Femployee = Convert.ToInt32(myReader["Femployee"]); }
                if (!Convert.IsDBNull(myReader["Fcorperate"])) { myDetail.Fcorperate = Convert.ToString(myReader["Fcorperate"]); }
                if (!Convert.IsDBNull(myReader["FbeginTradeDate"])) { myDetail.FbeginTradeDate = Convert.ToDateTime(myReader["FbeginTradeDate"]); }
                if (!Convert.IsDBNull(myReader["FendTradeDate"])) { myDetail.FendTradeDate = Convert.ToDateTime(myReader["FendTradeDate"]); }
                if (!Convert.IsDBNull(myReader["FlastTradeDate"])) { myDetail.FlastTradeDate = Convert.ToDateTime(myReader["FlastTradeDate"]); }
                if (!Convert.IsDBNull(myReader["FlastReceiveDate"])) { myDetail.FlastReceiveDate = Convert.ToDateTime(myReader["FlastReceiveDate"]); }
                if (!Convert.IsDBNull(myReader["FcashDiscount"])) { myDetail.FcashDiscount = Convert.ToString(myReader["FcashDiscount"]); }
                if (!Convert.IsDBNull(myReader["FcurrencyID"])) { myDetail.FcurrencyID = Convert.ToInt32(myReader["FcurrencyID"]); }
                if (!Convert.IsDBNull(myReader["FmaxDealAmount"])) { myDetail.FmaxDealAmount = Convert.ToDouble(myReader["FmaxDealAmount"]); }
                if (!Convert.IsDBNull(myReader["FminForeReceiveRate"])) { myDetail.FminForeReceiveRate = Convert.ToDouble(myReader["FminForeReceiveRate"]); }
                if (!Convert.IsDBNull(myReader["FminReserverate"])) { myDetail.FminReserverate = Convert.ToDouble(myReader["FminReserverate"]); }
                if (!Convert.IsDBNull(myReader["FdebtLevel"])) { myDetail.FdebtLevel = Convert.ToInt32(myReader["FdebtLevel"]); }
                if (!Convert.IsDBNull(myReader["FCarryingAOS"])) { myDetail.FCarryingAOS = Convert.ToInt32(myReader["FCarryingAOS"]); }
                if (!Convert.IsDBNull(myReader["FIsCreditMgr"])) { myDetail.FIsCreditMgr = Convert.ToBoolean(myReader["FIsCreditMgr"]); }
                if (!Convert.IsDBNull(myReader["FCreditPeriod"])) { myDetail.FCreditPeriod = Convert.ToInt32(myReader["FCreditPeriod"]); }
                if (!Convert.IsDBNull(myReader["FCreditLevel"])) { myDetail.FCreditLevel = Convert.ToInt32(myReader["FCreditLevel"]); }
                if (!Convert.IsDBNull(myReader["FPayTaxAcctID"])) { myDetail.FPayTaxAcctID = Convert.ToInt32(myReader["FPayTaxAcctID"]); }
                if (!Convert.IsDBNull(myReader["FValueAddRate"])) { myDetail.FValueAddRate = Convert.ToDecimal(myReader["FValueAddRate"]); }
                if (!Convert.IsDBNull(myReader["FTypeID"])) { myDetail.FTypeID = Convert.ToInt32(myReader["FTypeID"]); }
                if (!Convert.IsDBNull(myReader["FCreditDays"])) { myDetail.FCreditDays = Convert.ToInt32(myReader["FCreditDays"]); }
                if (!Convert.IsDBNull(myReader["FCreditAmount"])) { myDetail.FCreditAmount = Convert.ToDecimal(myReader["FCreditAmount"]); }
                if (!Convert.IsDBNull(myReader["FStockIDAssign"])) { myDetail.FStockIDAssign = Convert.ToInt32(myReader["FStockIDAssign"]); }
                if (!Convert.IsDBNull(myReader["FStockIDInst"])) { myDetail.FStockIDInst = Convert.ToInt32(myReader["FStockIDInst"]); }
                if (!Convert.IsDBNull(myReader["FStockIDKeep"])) { myDetail.FStockIDKeep = Convert.ToInt32(myReader["FStockIDKeep"]); }
                if (!Convert.IsDBNull(myReader["FPaperPeriod"])) { myDetail.FPaperPeriod = Convert.ToDateTime(myReader["FPaperPeriod"]); }
                if (!Convert.IsDBNull(myReader["FAlarmPeriod"])) { myDetail.FAlarmPeriod = Convert.ToInt32(myReader["FAlarmPeriod"]); }
                if (!Convert.IsDBNull(myReader["FLicAndPermit"])) { myDetail.FLicAndPermit = Convert.ToBoolean(myReader["FLicAndPermit"]); }
                if (!Convert.IsDBNull(myReader["FOtherARAcctID"])) { myDetail.FOtherARAcctID = Convert.ToInt32(myReader["FOtherARAcctID"]); }
                if (!Convert.IsDBNull(myReader["FOtherAPAcctID"])) { myDetail.FOtherAPAcctID = Convert.ToInt32(myReader["FOtherAPAcctID"]); }
                if (!Convert.IsDBNull(myReader["FPreAPAcctID"])) { myDetail.FPreAPAcctID = Convert.ToInt32(myReader["FPreAPAcctID"]); }
                if (!Convert.IsDBNull(myReader["FSaleID"])) { myDetail.FSaleID = Convert.ToInt32(myReader["FSaleID"]); }
                if (!Convert.IsDBNull(myReader["FHelpCode"])) { myDetail.FHelpCode = Convert.ToString(myReader["FHelpCode"]); }
                //if (!Convert.IsDBNull(myReader["FModifyTime"])) { myDetail.FModifyTime = Convert.ToDateTime(myReader["FModifyTime"]); }
                if (!Convert.IsDBNull(myReader["FNameEN"])) { myDetail.FNameEN = Convert.ToString(myReader["FNameEN"]); }
                if (!Convert.IsDBNull(myReader["FAddrEn"])) { myDetail.FAddrEn = Convert.ToString(myReader["FAddrEn"]); }
                if (!Convert.IsDBNull(myReader["FCIQCode"])) { myDetail.FCIQCode = Convert.ToString(myReader["FCIQCode"]); }
                if (!Convert.IsDBNull(myReader["FRegion"])) { myDetail.FRegion = Convert.ToInt32(myReader["FRegion"]); }
                if (!Convert.IsDBNull(myReader["FMobilePhone"])) { myDetail.FMobilePhone = Convert.ToString(myReader["FMobilePhone"]); }
                if (!Convert.IsDBNull(myReader["FPayCondition"])) { myDetail.FPayCondition = Convert.ToInt32(myReader["FPayCondition"]); }
                if (!Convert.IsDBNull(myReader["FManageType"])) { myDetail.FManageType = Convert.ToInt32(myReader["FManageType"]); }
                if (!Convert.IsDBNull(myReader["FClass"])) { myDetail.FClass = Convert.ToInt32(myReader["FClass"]); }
                if (!Convert.IsDBNull(myReader["FValue"])) { myDetail.FValue = Convert.ToString(myReader["FValue"]); }
                if (!Convert.IsDBNull(myReader["FRegUserID"])) { myDetail.FRegUserID = Convert.ToInt32(myReader["FRegUserID"]); }
                //if (!Convert.IsDBNull(myReader["FLastModifyDate"])) { myDetail.FLastModifyDate = Convert.ToDateTime(myReader["FLastModifyDate"]); }
                //if (!Convert.IsDBNull(myReader["FRecentContactDate"])) { myDetail.FRecentContactDate = Convert.ToDateTime(myReader["FRecentContactDate"]); }
                //if (!Convert.IsDBNull(myReader["FRegDate"])) { myDetail.FRegDate = Convert.ToDateTime(myReader["FRegDate"]); }
                if (!Convert.IsDBNull(myReader["FFlat"])) { myDetail.FFlat = Convert.ToInt32(myReader["FFlat"]); }
                if (!Convert.IsDBNull(myReader["FClassTypeID"])) { myDetail.FClassTypeID = Convert.ToInt32(myReader["FClassTypeID"]); }
                if (!Convert.IsDBNull(myReader["FCoSupplierID"])) { myDetail.FCoSupplierID = Convert.ToInt32(myReader["FCoSupplierID"]); }
                if (!Convert.IsDBNull(myReader["FShareStatus"])) { myDetail.FShareStatus = Convert.ToInt32(myReader["FShareStatus"]); }
                if (!Convert.IsDBNull(myReader["FCustType"])) { myDetail.FCustType = Convert.ToInt32(myReader["FCustType"]); }
                if (!Convert.IsDBNull(myReader["FSuperiorID"])) { myDetail.FSuperiorID = Convert.ToInt32(myReader["FSuperiorID"]); }
                if (!Convert.IsDBNull(myReader["FClueID"])) { myDetail.FClueID = Convert.ToInt32(myReader["FClueID"]); }
               // if (!Convert.IsDBNull(myReader["FLastMailTime"])) { myDetail.FLastMailTime = Convert.ToDateTime(myReader["FLastMailTime"]); }
                if (!Convert.IsDBNull(myReader["FCityID"])) { myDetail.FCityID = Convert.ToInt32(myReader["FCityID"]); }
                if (!Convert.IsDBNull(myReader["FProvinceID"])) { myDetail.FProvinceID = Convert.ToInt32(myReader["FProvinceID"]); }
                if (!Convert.IsDBNull(myReader["FSex"])) { myDetail.FSex = Convert.ToString(myReader["FSex"]); }
                if (!Convert.IsDBNull(myReader["FMobile"])) { myDetail.FMobile = Convert.ToString(myReader["FMobile"]); }
                if (!Convert.IsDBNull(myReader["FDuty"])) { myDetail.FDuty = Convert.ToString(myReader["FDuty"]); }
                if (!Convert.IsDBNull(myReader["FWorkSite"])) { myDetail.FWorkSite = Convert.ToString(myReader["FWorkSite"]); }
                if (!Convert.IsDBNull(myReader["FWorkUnit"])) { myDetail.FWorkUnit = Convert.ToString(myReader["FWorkUnit"]); }
                if (!Convert.IsDBNull(myReader["FIncomeLevel"])) { myDetail.FIncomeLevel = Convert.ToInt32(myReader["FIncomeLevel"]); }
                if (!Convert.IsDBNull(myReader["FStratum"])) { myDetail.FStratum = Convert.ToInt32(myReader["FStratum"]); }
                if (!Convert.IsDBNull(myReader["FAge"])) { myDetail.FAge = Convert.ToInt32(myReader["FAge"]); }
                //if (!Convert.IsDBNull(myReader["FBirthday"])) { myDetail.FBirthday = Convert.ToDateTime(myReader["FBirthday"]); }
                if (!Convert.IsDBNull(myReader["FNation"])) { myDetail.FNation = Convert.ToString(myReader["FNation"]); }
                if (!Convert.IsDBNull(myReader["FBizPostCode"])) { myDetail.FBizPostCode = Convert.ToString(myReader["FBizPostCode"]); }
                if (!Convert.IsDBNull(myReader["FIM"])) { myDetail.FIM = Convert.ToString(myReader["FIM"]); }
                if (!Convert.IsDBNull(myReader["FBizPhone"])) { myDetail.FBizPhone = Convert.ToString(myReader["FBizPhone"]); }
                //if (!Convert.IsDBNull(myReader["FLastActivityTime"])) { myDetail.FLastActivityTime = Convert.ToDateTime(myReader["FLastActivityTime"]); }
                //if (!Convert.IsDBNull(myReader["FLastSVTime"])) { myDetail.FLastSVTime = Convert.ToDateTime(myReader["FLastSVTime"]); }
                //if (!Convert.IsDBNull(myReader["FLastCallTime"])) { myDetail.FLastCallTime = Convert.ToDateTime(myReader["FLastCallTime"]); }
                //if (!Convert.IsDBNull(myReader["FLastSMSTime"])) { myDetail.FLastSMSTime = Convert.ToDateTime(myReader["FLastSMSTime"]); }
                if (!Convert.IsDBNull(myReader["FExpired"])) { myDetail.FExpired = Convert.ToInt32(myReader["FExpired"]); }
                if (!Convert.IsDBNull(myReader["F_102"])) { myDetail.F_102 = Convert.ToString(myReader["F_102"]); }
                if (!Convert.IsDBNull(myReader["F_103"])) { myDetail.F_103 = Convert.ToInt32(myReader["F_103"]); }
                if (!Convert.IsDBNull(myReader["F_104"])) { myDetail.F_104 = Convert.ToString(myReader["F_104"]); }
                if (!Convert.IsDBNull(myReader["F_105"])) { myDetail.F_105 = Convert.ToString(myReader["F_105"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }


        /// <summary>
        /// 更新t_Organization对象
        /// 编写人：ywk
        /// 编写日期：2018/9/6 星期四
        /// </summary>
        public void Update(t_Organization model)
        {
            SqlConnection con = new SqlConnection(K3connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE t_Organization SET FItemID = @m_FItemID,FAddress = @m_FAddress,FCity = @m_FCity,FProvince = @m_FProvince,FCountry = @m_FCountry,FPostalCode = @m_FPostalCode,FPhone = @m_FPhone,FFax = @m_FFax,FEmail = @m_FEmail,FHomePage = @m_FHomePage,FCreditLimit = @m_FCreditLimit,FTaxID = @m_FTaxID,FBank = @m_FBank,FAccount = @m_FAccount,FBankNumber = @m_FBankNumber,FBrNo = @m_FBrNo,FBoundAttr = @m_FBoundAttr,FErpClsID = @m_FErpClsID,FShortName = @m_FShortName,FPriorityID = @m_FPriorityID,FPOGroupID = @m_FPOGroupID,FStatus = @m_FStatus,FLanguageID = @m_FLanguageID,FRegionID = @m_FRegionID,FTrade = @m_FTrade,FMinPOValue = @m_FMinPOValue,FMaxDebitDate = @m_FMaxDebitDate,FLegalPerson = @m_FLegalPerson,FContact = @m_FContact,FContactAcct = @m_FContactAcct,FPhoneAcct = @m_FPhoneAcct,FFaxAcct = @m_FFaxAcct,FZipAcct = @m_FZipAcct,FEmailAcct = @m_FEmailAcct,FAddrAcct = @m_FAddrAcct,FTax = @m_FTax,FCyID = @m_FCyID,FSetID = @m_FSetID,FSetDLineID = @m_FSetDLineID,FTaxNum = @m_FTaxNum,FPriceClsID = @m_FPriceClsID,FOperID = @m_FOperID,FCIQNumber = @m_FCIQNumber,FDeleted = @m_FDeleted,FSaleMode = @m_FSaleMode,FName = @m_FName,FNumber = @m_FNumber,FParentID = @m_FParentID,FShortNumber = @m_FShortNumber,FARAccountID = @m_FARAccountID,FAPAccountID = @m_FAPAccountID,FpreAcctID = @m_FpreAcctID,FlastTradeAmount = @m_FlastTradeAmount,FlastRPAmount = @m_FlastRPAmount,FfavorPolicy = @m_FfavorPolicy,Fdepartment = @m_Fdepartment,Femployee = @m_Femployee,Fcorperate = @m_Fcorperate,FbeginTradeDate = @m_FbeginTradeDate,FendTradeDate = @m_FendTradeDate,FlastTradeDate = @m_FlastTradeDate,FlastReceiveDate = @m_FlastReceiveDate,FcashDiscount = @m_FcashDiscount,FcurrencyID = @m_FcurrencyID,FmaxDealAmount = @m_FmaxDealAmount,FminForeReceiveRate = @m_FminForeReceiveRate,FminReserverate = @m_FminReserverate,FdebtLevel = @m_FdebtLevel,FCarryingAOS = @m_FCarryingAOS,FIsCreditMgr = @m_FIsCreditMgr,FCreditPeriod = @m_FCreditPeriod,FCreditLevel = @m_FCreditLevel,FPayTaxAcctID = @m_FPayTaxAcctID,FValueAddRate = @m_FValueAddRate,FTypeID = @m_FTypeID,FCreditDays = @m_FCreditDays,FCreditAmount = @m_FCreditAmount,FStockIDAssign = @m_FStockIDAssign,FStockIDInst = @m_FStockIDInst,FStockIDKeep = @m_FStockIDKeep,FPaperPeriod = @m_FPaperPeriod,FAlarmPeriod = @m_FAlarmPeriod,FLicAndPermit = @m_FLicAndPermit,FOtherARAcctID = @m_FOtherARAcctID,FOtherAPAcctID = @m_FOtherAPAcctID,FPreAPAcctID = @m_FPreAPAcctID,FSaleID = @m_FSaleID,FHelpCode = @m_FHelpCode ,FNameEN = @m_FNameEN,FAddrEn = @m_FAddrEn,FCIQCode = @m_FCIQCode,FRegion = @m_FRegion,FMobilePhone = @m_FMobilePhone,FPayCondition = @m_FPayCondition,FManageType = @m_FManageType,FClass = @m_FClass,FValue = @m_FValue,FRegUserID = @m_FRegUserID, FFlat = @m_FFlat,FClassTypeID = @m_FClassTypeID,FCoSupplierID = @m_FCoSupplierID,FShareStatus = @m_FShareStatus,FCustType = @m_FCustType,FSuperiorID = @m_FSuperiorID,FClueID = @m_FClueID ,FCityID = @m_FCityID,FProvinceID = @m_FProvinceID,FSex = @m_FSex,FMobile = @m_FMobile,FDuty = @m_FDuty,FWorkSite = @m_FWorkSite,FWorkUnit = @m_FWorkUnit,FIncomeLevel = @m_FIncomeLevel,FStratum = @m_FStratum,FAge = @m_FAge ,FNation = @m_FNation,FBizPostCode = @m_FBizPostCode,FIM = @m_FIM,FBizPhone = @m_FBizPhone,FExpired = @m_FExpired,F_102 = @m_F_102,F_103 = @m_F_103,F_104 = @m_F_104,F_105 = @m_F_105 WHERE FNumber = @m_FNumber", con);
            con.Open();

            if (model.FItemID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FItemID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FItemID", SqlDbType.Int, 0)).Value = model.FItemID;
            }
            if (model.FAddress == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAddress", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAddress", SqlDbType.VarChar, 255)).Value = model.FAddress;
            }
            if (model.FCity == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCity", SqlDbType.VarChar, 80)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCity", SqlDbType.VarChar, 80)).Value = model.FCity;
            }
            if (model.FProvince == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FProvince", SqlDbType.VarChar, 80)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FProvince", SqlDbType.VarChar, 80)).Value = model.FProvince;
            }
            if (model.FCountry == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCountry", SqlDbType.VarChar, 80)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCountry", SqlDbType.VarChar, 80)).Value = model.FCountry;
            }
            if (model.FPostalCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPostalCode", SqlDbType.VarChar, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPostalCode", SqlDbType.VarChar, 20)).Value = model.FPostalCode;
            }
            if (model.FPhone == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPhone", SqlDbType.VarChar, 40)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPhone", SqlDbType.VarChar, 40)).Value = model.FPhone;
            }
            if (model.FFax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFax", SqlDbType.VarChar, 40)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFax", SqlDbType.VarChar, 40)).Value = model.FFax;
            }
            if (model.FEmail == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEmail", SqlDbType.VarChar, 40)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEmail", SqlDbType.VarChar, 40)).Value = model.FEmail;
            }
            if (model.FHomePage == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHomePage", SqlDbType.VarChar, 80)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHomePage", SqlDbType.VarChar, 80)).Value = model.FHomePage;
            }
            if (model.FCreditLimit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditLimit", SqlDbType.VarChar, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditLimit", SqlDbType.VarChar, 20)).Value = model.FCreditLimit;
            }
            if (model.FTaxID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxID", SqlDbType.VarChar, 40)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxID", SqlDbType.VarChar, 40)).Value = model.FTaxID;
            }
            if (model.FBank == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBank", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBank", SqlDbType.VarChar, 255)).Value = model.FBank;
            }
            if (model.FAccount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAccount", SqlDbType.VarChar, 80)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAccount", SqlDbType.VarChar, 80)).Value = model.FAccount;
            }
            if (model.FBankNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBankNumber", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBankNumber", SqlDbType.VarChar, 255)).Value = model.FBankNumber;
            }
            if (model.FBrNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBrNo", SqlDbType.VarChar, 10)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBrNo", SqlDbType.VarChar, 10)).Value = model.FBrNo;
            }
            if (model.FBoundAttr == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBoundAttr", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBoundAttr", SqlDbType.Int, 0)).Value = model.FBoundAttr;
            }
            if (model.FErpClsID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FErpClsID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FErpClsID", SqlDbType.Int, 0)).Value = model.FErpClsID;
            }
            if (model.FShortName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FShortName", SqlDbType.VarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FShortName", SqlDbType.VarChar, 50)).Value = model.FShortName;
            }
            if (model.FPriorityID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPriorityID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPriorityID", SqlDbType.Int, 0)).Value = model.FPriorityID;
            }
            if (model.FPOGroupID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPOGroupID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPOGroupID", SqlDbType.Int, 0)).Value = model.FPOGroupID;
            }
            if (model.FStatus == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStatus", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStatus", SqlDbType.Int, 0)).Value = model.FStatus;
            }
            if (model.FLanguageID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLanguageID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLanguageID", SqlDbType.Int, 0)).Value = model.FLanguageID;
            }
            if (model.FRegionID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRegionID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRegionID", SqlDbType.Int, 0)).Value = model.FRegionID;
            }
            if (model.FTrade == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTrade", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTrade", SqlDbType.Int, 0)).Value = model.FTrade;
            }
            if (model.FMinPOValue == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMinPOValue", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMinPOValue", SqlDbType.Float, 0)).Value = model.FMinPOValue;
            }
            if (model.FMaxDebitDate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMaxDebitDate", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMaxDebitDate", SqlDbType.Float, 0)).Value = model.FMaxDebitDate;
            }
            if (model.FLegalPerson == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLegalPerson", SqlDbType.VarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLegalPerson", SqlDbType.VarChar, 50)).Value = model.FLegalPerson;
            }
            if (model.FContact == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FContact", SqlDbType.VarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FContact", SqlDbType.VarChar, 50)).Value = model.FContact;
            }
            if (model.FContactAcct == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FContactAcct", SqlDbType.VarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FContactAcct", SqlDbType.VarChar, 50)).Value = model.FContactAcct;
            }
            if (model.FPhoneAcct == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPhoneAcct", SqlDbType.VarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPhoneAcct", SqlDbType.VarChar, 50)).Value = model.FPhoneAcct;
            }
            if (model.FFaxAcct == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFaxAcct", SqlDbType.VarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFaxAcct", SqlDbType.VarChar, 50)).Value = model.FFaxAcct;
            }
            if (model.FZipAcct == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FZipAcct", SqlDbType.VarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FZipAcct", SqlDbType.VarChar, 50)).Value = model.FZipAcct;
            }
            if (model.FEmailAcct == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEmailAcct", SqlDbType.VarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEmailAcct", SqlDbType.VarChar, 50)).Value = model.FEmailAcct;
            }
            if (model.FAddrAcct == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAddrAcct", SqlDbType.VarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAddrAcct", SqlDbType.VarChar, 50)).Value = model.FAddrAcct;
            }
            if (model.FTax == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTax", SqlDbType.Real, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTax", SqlDbType.Real, 0)).Value = model.FTax;
            }
            if (model.FCyID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCyID", SqlDbType.Int, 0)).Value = model.FCyID;
            }
            if (model.FSetID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSetID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSetID", SqlDbType.Int, 0)).Value = model.FSetID;
            }
            if (model.FSetDLineID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSetDLineID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSetDLineID", SqlDbType.Int, 0)).Value = model.FSetDLineID;
            }
            if (model.FTaxNum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxNum", SqlDbType.VarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTaxNum", SqlDbType.VarChar, 50)).Value = model.FTaxNum;
            }
            if (model.FPriceClsID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPriceClsID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPriceClsID", SqlDbType.Int, 0)).Value = model.FPriceClsID;
            }
            if (model.FOperID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOperID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOperID", SqlDbType.Int, 0)).Value = model.FOperID;
            }
            if (model.FCIQNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCIQNumber", SqlDbType.VarChar, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCIQNumber", SqlDbType.VarChar, 20)).Value = model.FCIQNumber;
            }
            if (model.FDeleted == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDeleted", SqlDbType.SmallInt, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDeleted", SqlDbType.SmallInt, 0)).Value = model.FDeleted;
            }
            if (model.FSaleMode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleMode", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleMode", SqlDbType.Int, 0)).Value = model.FSaleMode;
            }
            if (model.FName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.VarChar, 80)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.VarChar, 80)).Value = model.FName;
            }
            if (model.FNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.VarChar, 255)).Value = model.FNumber;
            }
            if (model.FParentID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FParentID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FParentID", SqlDbType.Int, 0)).Value = model.FParentID;
            }
            if (model.FShortNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FShortNumber", SqlDbType.VarChar, 80)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FShortNumber", SqlDbType.VarChar, 80)).Value = model.FShortNumber;
            }
            if (model.FARAccountID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FARAccountID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FARAccountID", SqlDbType.Int, 0)).Value = model.FARAccountID;
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
            if (model.FlastTradeAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FlastTradeAmount", SqlDbType.Money, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FlastTradeAmount", SqlDbType.Money, 0)).Value = model.FlastTradeAmount;
            }
            if (model.FlastRPAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FlastRPAmount", SqlDbType.Money, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FlastRPAmount", SqlDbType.Money, 0)).Value = model.FlastRPAmount;
            }
            if (model.FfavorPolicy == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FfavorPolicy", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FfavorPolicy", SqlDbType.VarChar, 255)).Value = model.FfavorPolicy;
            }
            if (model.Fdepartment == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fdepartment", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fdepartment", SqlDbType.Int, 0)).Value = model.Fdepartment;
            }
            if (model.Femployee == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Femployee", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Femployee", SqlDbType.Int, 0)).Value = model.Femployee;
            }
            if (model.Fcorperate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fcorperate", SqlDbType.VarChar, 80)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_Fcorperate", SqlDbType.VarChar, 80)).Value = model.Fcorperate;
            }
            if (model.FbeginTradeDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FbeginTradeDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FbeginTradeDate", SqlDbType.DateTime, 0)).Value = model.FbeginTradeDate;
            }
            if (model.FendTradeDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FendTradeDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FendTradeDate", SqlDbType.DateTime, 0)).Value = model.FendTradeDate;
            }
            if (model.FlastTradeDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FlastTradeDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FlastTradeDate", SqlDbType.DateTime, 0)).Value = model.FlastTradeDate;
            }
            if (model.FlastReceiveDate == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FlastReceiveDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FlastReceiveDate", SqlDbType.DateTime, 0)).Value = model.FlastReceiveDate;
            }
            if (model.FcashDiscount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FcashDiscount", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FcashDiscount", SqlDbType.VarChar, 255)).Value = model.FcashDiscount;
            }
            if (model.FcurrencyID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FcurrencyID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FcurrencyID", SqlDbType.Int, 0)).Value = model.FcurrencyID;
            }
            if (model.FmaxDealAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FmaxDealAmount", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FmaxDealAmount", SqlDbType.Float, 0)).Value = model.FmaxDealAmount;
            }
            if (model.FminForeReceiveRate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FminForeReceiveRate", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FminForeReceiveRate", SqlDbType.Float, 0)).Value = model.FminForeReceiveRate;
            }
            if (model.FminReserverate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FminReserverate", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FminReserverate", SqlDbType.Float, 0)).Value = model.FminReserverate;
            }
            if (model.FdebtLevel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FdebtLevel", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FdebtLevel", SqlDbType.Int, 0)).Value = model.FdebtLevel;
            }
            if (model.FCarryingAOS == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCarryingAOS", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCarryingAOS", SqlDbType.Int, 0)).Value = model.FCarryingAOS;
            }
            if (model.FIsCreditMgr == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsCreditMgr", SqlDbType.Bit, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsCreditMgr", SqlDbType.Bit, 0)).Value = model.FIsCreditMgr;
            }
            if (model.FCreditPeriod == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditPeriod", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditPeriod", SqlDbType.Int, 0)).Value = model.FCreditPeriod;
            }
            if (model.FCreditLevel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditLevel", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditLevel", SqlDbType.Int, 0)).Value = model.FCreditLevel;
            }
            if (model.FPayTaxAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctID", SqlDbType.Int, 0)).Value = model.FPayTaxAcctID;
            }
            if (model.FValueAddRate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FValueAddRate", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FValueAddRate", SqlDbType.Decimal, 28)).Value = model.FValueAddRate;
            }
            if (model.FTypeID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTypeID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTypeID", SqlDbType.Int, 0)).Value = model.FTypeID;
            }
            if (model.FCreditDays == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditDays", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditDays", SqlDbType.Int, 0)).Value = model.FCreditDays;
            }
            if (model.FCreditAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditAmount", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditAmount", SqlDbType.Decimal, 18)).Value = model.FCreditAmount;
            }
            if (model.FStockIDAssign == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStockIDAssign", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStockIDAssign", SqlDbType.Int, 0)).Value = model.FStockIDAssign;
            }
            if (model.FStockIDInst == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStockIDInst", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStockIDInst", SqlDbType.Int, 0)).Value = model.FStockIDInst;
            }
            if (model.FStockIDKeep == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStockIDKeep", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStockIDKeep", SqlDbType.Int, 0)).Value = model.FStockIDKeep;
            }
            if (model.FPaperPeriod == new DateTime())
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPaperPeriod", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPaperPeriod", SqlDbType.DateTime, 0)).Value = model.FPaperPeriod;
            }
            if (model.FAlarmPeriod == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAlarmPeriod", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAlarmPeriod", SqlDbType.Int, 0)).Value = model.FAlarmPeriod;
            }
            if (model.FLicAndPermit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLicAndPermit", SqlDbType.Bit, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLicAndPermit", SqlDbType.Bit, 0)).Value = model.FLicAndPermit;
            }
            if (model.FOtherARAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherARAcctID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherARAcctID", SqlDbType.Int, 0)).Value = model.FOtherARAcctID;
            }
            if (model.FOtherAPAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherAPAcctID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FOtherAPAcctID", SqlDbType.Int, 0)).Value = model.FOtherAPAcctID;
            }
            if (model.FPreAPAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPreAPAcctID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPreAPAcctID", SqlDbType.Int, 0)).Value = model.FPreAPAcctID;
            }
            if (model.FSaleID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleID", SqlDbType.Int, 0)).Value = model.FSaleID;
            }
            if (model.FHelpCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHelpCode", SqlDbType.VarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHelpCode", SqlDbType.VarChar, 50)).Value = model.FHelpCode;
            }
           
            if (model.FNameEN == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNameEN", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNameEN", SqlDbType.NVarChar, 255)).Value = model.FNameEN;
            }
            if (model.FAddrEn == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAddrEn", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAddrEn", SqlDbType.NVarChar, 255)).Value = model.FAddrEn;
            }
            if (model.FCIQCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCIQCode", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCIQCode", SqlDbType.NVarChar, 255)).Value = model.FCIQCode;
            }
            if (model.FRegion == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRegion", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRegion", SqlDbType.Int, 0)).Value = model.FRegion;
            }
            if (model.FMobilePhone == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMobilePhone", SqlDbType.VarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMobilePhone", SqlDbType.VarChar, 50)).Value = model.FMobilePhone;
            }
            if (model.FPayCondition == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayCondition", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayCondition", SqlDbType.Int, 0)).Value = model.FPayCondition;
            }
            if (model.FManageType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FManageType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FManageType", SqlDbType.Int, 0)).Value = model.FManageType;
            }
            if (model.FClass == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FClass", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FClass", SqlDbType.Int, 0)).Value = model.FClass;
            }
            if (model.FValue == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FValue", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FValue", SqlDbType.NVarChar, 255)).Value = model.FValue;
            }
            if (model.FRegUserID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRegUserID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRegUserID", SqlDbType.Int, 0)).Value = model.FRegUserID;
            }
            
            
             
            if (model.FFlat == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFlat", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFlat", SqlDbType.Int, 0)).Value = model.FFlat;
            }
            if (model.FClassTypeID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FClassTypeID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FClassTypeID", SqlDbType.Int, 0)).Value = model.FClassTypeID;
            }
            if (model.FCoSupplierID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCoSupplierID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCoSupplierID", SqlDbType.Int, 0)).Value = model.FCoSupplierID;
            }
            if (model.FShareStatus == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FShareStatus", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FShareStatus", SqlDbType.Int, 0)).Value = model.FShareStatus;
            }
            if (model.FCustType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCustType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCustType", SqlDbType.Int, 0)).Value = model.FCustType;
            }
            if (model.FSuperiorID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSuperiorID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSuperiorID", SqlDbType.Int, 0)).Value = model.FSuperiorID;
            }
            if (model.FClueID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FClueID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FClueID", SqlDbType.Int, 0)).Value = model.FClueID;
            }
          
            if (model.FCityID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCityID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCityID", SqlDbType.Int, 0)).Value = model.FCityID;
            }
            if (model.FProvinceID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FProvinceID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FProvinceID", SqlDbType.Int, 0)).Value = model.FProvinceID;
            }
            if (model.FSex == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSex", SqlDbType.VarChar, 5)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSex", SqlDbType.VarChar, 5)).Value = model.FSex;
            }
            if (model.FMobile == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMobile", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMobile", SqlDbType.NVarChar, 50)).Value = model.FMobile;
            }
            if (model.FDuty == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDuty", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDuty", SqlDbType.NVarChar, 50)).Value = model.FDuty;
            }
            if (model.FWorkSite == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FWorkSite", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FWorkSite", SqlDbType.NVarChar, 255)).Value = model.FWorkSite;
            }
            if (model.FWorkUnit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FWorkUnit", SqlDbType.NVarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FWorkUnit", SqlDbType.NVarChar, 255)).Value = model.FWorkUnit;
            }
            if (model.FIncomeLevel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIncomeLevel", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIncomeLevel", SqlDbType.Int, 0)).Value = model.FIncomeLevel;
            }
            if (model.FStratum == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStratum", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStratum", SqlDbType.Int, 0)).Value = model.FStratum;
            }
            if (model.FAge == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAge", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAge", SqlDbType.Int, 0)).Value = model.FAge;
            }
           
            if (model.FNation == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNation", SqlDbType.NVarChar, 10)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FNation", SqlDbType.NVarChar, 10)).Value = model.FNation;
            }
            if (model.FBizPostCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBizPostCode", SqlDbType.VarChar, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBizPostCode", SqlDbType.VarChar, 20)).Value = model.FBizPostCode;
            }
            if (model.FIM == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIM", SqlDbType.VarChar, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIM", SqlDbType.VarChar, 20)).Value = model.FIM;
            }
            if (model.FBizPhone == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBizPhone", SqlDbType.VarChar, 40)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBizPhone", SqlDbType.VarChar, 40)).Value = model.FBizPhone;
            }
              
           
            if (model.FExpired == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FExpired", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FExpired", SqlDbType.Int, 0)).Value = model.FExpired;
            }
            if (model.F_102 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_F_102", SqlDbType.VarChar, 300)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_F_102", SqlDbType.VarChar, 300)).Value = model.F_102;
            }
            if (model.F_103 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_F_103", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_F_103", SqlDbType.Int, 0)).Value = model.F_103;
            }
            if (model.F_104 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_F_104", SqlDbType.VarChar, 250)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_F_104", SqlDbType.VarChar, 250)).Value = model.F_104;
            }
            if (model.F_105 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_F_105", SqlDbType.VarChar, 250)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_F_105", SqlDbType.VarChar, 250)).Value = model.F_105;
            }

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }


    }
}
