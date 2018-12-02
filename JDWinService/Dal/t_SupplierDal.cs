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
    public class t_SupplierDal
    {
        Common common = new Common();
        public static string K3connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3ConnectionString"].Value; //连接信息
        public static string K3BranchConString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["K3BranchConnectionString"].Value; //连接信息

        /// <summary>
        /// 对象t_Supplier明细
        /// 编写人：ywk
        /// 编写日期：2018/8/20 星期一
        /// </summary>
        public t_Supplier Detail(string FNumber,int IsPart)
        {
            SqlConnection con = new SqlConnection((IsPart==0)?K3connectionString: K3BranchConString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM t_Supplier WHERE FNumber = @m_FNumber", con);
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@m_FNumber", SqlDbType.VarChar, 255)).Value = FNumber;

            t_Supplier myDetail = new t_Supplier();
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
                if (!Convert.IsDBNull(myReader["FSaleMode"])) { myDetail.FSaleMode = Convert.ToInt16(myReader["FSaleMode"]); }
                if (!Convert.IsDBNull(myReader["FName"])) { myDetail.FName = Convert.ToString(myReader["FName"]); }
                if (!Convert.IsDBNull(myReader["FNumber"])) { myDetail.FNumber = Convert.ToString(myReader["FNumber"]); }
                if (!Convert.IsDBNull(myReader["FParentID"])) { myDetail.FParentID = Convert.ToInt32(myReader["FParentID"]); }
                if (!Convert.IsDBNull(myReader["FShortNumber"])) { myDetail.FShortNumber = Convert.ToString(myReader["FShortNumber"]); }
                if (!Convert.IsDBNull(myReader["FARAccountID"])) { myDetail.FARAccountID = Convert.ToInt32(myReader["FARAccountID"]); }
                if (!Convert.IsDBNull(myReader["FAPAccountID"])) { myDetail.FAPAccountID = Convert.ToInt32(myReader["FAPAccountID"]); }
                if (!Convert.IsDBNull(myReader["FpreAcctID"])) { myDetail.FpreAcctID = Convert.ToInt32(myReader["FpreAcctID"]); }
                if (!Convert.IsDBNull(myReader["FlastTradeAmount"])) { myDetail.FlastTradeAmount = Convert.ToDecimal(myReader["FlastTradeAmount"]); }
                if (!Convert.IsDBNull(myReader["FLastRPAmount"])) { myDetail.FLastRPAmount = Convert.ToDecimal(myReader["FLastRPAmount"]); }
                if (!Convert.IsDBNull(myReader["FFavorPolicy"])) { myDetail.FFavorPolicy = Convert.ToString(myReader["FFavorPolicy"]); }
                if (!Convert.IsDBNull(myReader["Fdepartment"])) { myDetail.Fdepartment = Convert.ToInt32(myReader["Fdepartment"]); }
                if (!Convert.IsDBNull(myReader["Femployee"])) { myDetail.Femployee = Convert.ToInt32(myReader["Femployee"]); }
                if (!Convert.IsDBNull(myReader["Fcorperate"])) { myDetail.Fcorperate = Convert.ToString(myReader["Fcorperate"]); }
                if (!Convert.IsDBNull(myReader["FBeginTradeDate"])) { myDetail.FBeginTradeDate = Convert.ToDateTime(myReader["FBeginTradeDate"]); }
                if (!Convert.IsDBNull(myReader["FEndTradeDate"])) { myDetail.FEndTradeDate = Convert.ToDateTime(myReader["FEndTradeDate"]); }
                if (!Convert.IsDBNull(myReader["FLastTradeDate"])) { myDetail.FLastTradeDate = Convert.ToDateTime(myReader["FLastTradeDate"]); }
                if (!Convert.IsDBNull(myReader["FLastReceiveDate"])) { myDetail.FLastReceiveDate = Convert.ToDateTime(myReader["FLastReceiveDate"]); }
                if (!Convert.IsDBNull(myReader["FcashDiscount"])) { myDetail.FcashDiscount = Convert.ToString(myReader["FcashDiscount"]); }
                if (!Convert.IsDBNull(myReader["FcurrencyID"])) { myDetail.FcurrencyID = Convert.ToInt32(myReader["FcurrencyID"]); }
                if (!Convert.IsDBNull(myReader["FMaxDealAmount"])) { myDetail.FMaxDealAmount = Convert.ToDouble(myReader["FMaxDealAmount"]); }
                if (!Convert.IsDBNull(myReader["FMinForeReceiveRate"])) { myDetail.FMinForeReceiveRate = Convert.ToDouble(myReader["FMinForeReceiveRate"]); }
                if (!Convert.IsDBNull(myReader["FMinReserveRate"])) { myDetail.FMinReserveRate = Convert.ToDouble(myReader["FMinReserveRate"]); }
                if (!Convert.IsDBNull(myReader["FMaxForePayAmount"])) { myDetail.FMaxForePayAmount = Convert.ToDouble(myReader["FMaxForePayAmount"]); }
                if (!Convert.IsDBNull(myReader["FMaxForePayRate"])) { myDetail.FMaxForePayRate = Convert.ToDouble(myReader["FMaxForePayRate"]); }
                if (!Convert.IsDBNull(myReader["FdebtLevel"])) { myDetail.FdebtLevel = Convert.ToInt32(myReader["FdebtLevel"]); }
                if (!Convert.IsDBNull(myReader["FCreditDays"])) { myDetail.FCreditDays = Convert.ToInt32(myReader["FCreditDays"]); }
                if (!Convert.IsDBNull(myReader["FValueAddRate"])) { myDetail.FValueAddRate = Convert.ToDecimal(myReader["FValueAddRate"]); }
                if (!Convert.IsDBNull(myReader["FPayTaxAcctID"])) { myDetail.FPayTaxAcctID = Convert.ToInt32(myReader["FPayTaxAcctID"]); }
                if (!Convert.IsDBNull(myReader["FDiscount"])) { myDetail.FDiscount = Convert.ToDecimal(myReader["FDiscount"]); }
                if (!Convert.IsDBNull(myReader["FTypeID"])) { myDetail.FTypeID = Convert.ToInt32(myReader["FTypeID"]); }
                if (!Convert.IsDBNull(myReader["FCreditAmount"])) { myDetail.FCreditAmount = Convert.ToDecimal(myReader["FCreditAmount"]); }
                if (!Convert.IsDBNull(myReader["FCreditLevel"])) { myDetail.FCreditLevel = Convert.ToString(myReader["FCreditLevel"]); }
                if (!Convert.IsDBNull(myReader["FStockIDAssignee"])) { myDetail.FStockIDAssignee = Convert.ToInt32(myReader["FStockIDAssignee"]); }
                if (!Convert.IsDBNull(myReader["FBr"])) { myDetail.FBr = Convert.ToInt32(myReader["FBr"]); }
                if (!Convert.IsDBNull(myReader["FRegmark"])) { myDetail.FRegmark = Convert.ToString(myReader["FRegmark"]); }
                if (!Convert.IsDBNull(myReader["FLicAndPermit"])) { myDetail.FLicAndPermit = Convert.ToBoolean(myReader["FLicAndPermit"]); }
                if (!Convert.IsDBNull(myReader["FLicence"])) { myDetail.FLicence = Convert.ToString(myReader["FLicence"]); }
                if (!Convert.IsDBNull(myReader["FPaperPeriod"])) { myDetail.FPaperPeriod = Convert.ToDateTime(myReader["FPaperPeriod"]); }
                if (!Convert.IsDBNull(myReader["FAlarmPeriod"])) { myDetail.FAlarmPeriod = Convert.ToInt32(myReader["FAlarmPeriod"]); }
                if (!Convert.IsDBNull(myReader["FOtherARAcctID"])) { myDetail.FOtherARAcctID = Convert.ToInt32(myReader["FOtherARAcctID"]); }
                if (!Convert.IsDBNull(myReader["FOtherAPAcctID"])) { myDetail.FOtherAPAcctID = Convert.ToInt32(myReader["FOtherAPAcctID"]); }
                if (!Convert.IsDBNull(myReader["FPreARAcctID"])) { myDetail.FPreARAcctID = Convert.ToInt32(myReader["FPreARAcctID"]); }
                if (!Convert.IsDBNull(myReader["FHelpCode"])) { myDetail.FHelpCode = Convert.ToString(myReader["FHelpCode"]); }
                //if (!Convert.IsDBNull(myReader["FModifyTime"])) { myDetail.FModifyTime = Convert.ToDateTime(myReader["FModifyTime"]); }
                if (!Convert.IsDBNull(myReader["FNameEN"])) { myDetail.FNameEN = Convert.ToString(myReader["FNameEN"]); }
                if (!Convert.IsDBNull(myReader["FAddrEn"])) { myDetail.FAddrEn = Convert.ToString(myReader["FAddrEn"]); }
                if (!Convert.IsDBNull(myReader["FCIQCode"])) { myDetail.FCIQCode = Convert.ToString(myReader["FCIQCode"]); }
                if (!Convert.IsDBNull(myReader["FRegion"])) { myDetail.FRegion = Convert.ToInt32(myReader["FRegion"]); }
                if (!Convert.IsDBNull(myReader["FMobilePhone"])) { myDetail.FMobilePhone = Convert.ToString(myReader["FMobilePhone"]); }
                if (!Convert.IsDBNull(myReader["FManageType"])) { myDetail.FManageType = Convert.ToInt32(myReader["FManageType"]); }
                if (!Convert.IsDBNull(myReader["FRegsterDate"])) { myDetail.FRegsterDate = Convert.ToDateTime(myReader["FRegsterDate"]); }
                if (!Convert.IsDBNull(myReader["FPassDate"])) { myDetail.FPassDate = Convert.ToDateTime(myReader["FPassDate"]); }
                if (!Convert.IsDBNull(myReader["FInureDate"])) { myDetail.FInureDate = Convert.ToDateTime(myReader["FInureDate"]); }
                if (!Convert.IsDBNull(myReader["FAbateDate"])) { myDetail.FAbateDate = Convert.ToDateTime(myReader["FAbateDate"]); }
                if (!Convert.IsDBNull(myReader["FSupplyGrade"])) { myDetail.FSupplyGrade = Convert.ToInt32(myReader["FSupplyGrade"]); }
                if (!Convert.IsDBNull(myReader["FSupplyType"])) { myDetail.FSupplyType = Convert.ToInt32(myReader["FSupplyType"]); }
                if (!Convert.IsDBNull(myReader["FCompanyType"])) { myDetail.FCompanyType = Convert.ToInt32(myReader["FCompanyType"]); }
                if (!Convert.IsDBNull(myReader["FEvalutionType"])) { myDetail.FEvalutionType = Convert.ToInt32(myReader["FEvalutionType"]); }
                if (!Convert.IsDBNull(myReader["FSupplierCoroutineFlag"])) { myDetail.FSupplierCoroutineFlag = Convert.ToBoolean(myReader["FSupplierCoroutineFlag"]); }
                if (!Convert.IsDBNull(myReader["FAutoCreateMR"])) { myDetail.FAutoCreateMR = Convert.ToBoolean(myReader["FAutoCreateMR"]); }
                if (!Convert.IsDBNull(myReader["FAutoValidateOrderFlag"])) { myDetail.FAutoValidateOrderFlag = Convert.ToBoolean(myReader["FAutoValidateOrderFlag"]); }
                if (!Convert.IsDBNull(myReader["FAPFrozenFlag"])) { myDetail.FAPFrozenFlag = Convert.ToBoolean(myReader["FAPFrozenFlag"]); }
                if (!Convert.IsDBNull(myReader["FID"])) { myDetail.FID = Convert.ToInt32(myReader["FID"]); }
                if (!Convert.IsDBNull(myReader["FClassTypeID"])) { myDetail.FClassTypeID = Convert.ToInt32(myReader["FClassTypeID"]); }
                if (!Convert.IsDBNull(myReader["FBillNo"])) { myDetail.FBillNo = Convert.ToString(myReader["FBillNo"]); }
                if (!Convert.IsDBNull(myReader["FBiller"])) { myDetail.FBiller = Convert.ToInt32(myReader["FBiller"]); }
                if (!Convert.IsDBNull(myReader["FModifier"])) { myDetail.FModifier = Convert.ToInt32(myReader["FModifier"]); }
                if (!Convert.IsDBNull(myReader["FBillDate"])) { myDetail.FBillDate = Convert.ToDateTime(myReader["FBillDate"]); }
                if (!Convert.IsDBNull(myReader["FModifyDate"])) { myDetail.FModifyDate = Convert.ToDateTime(myReader["FModifyDate"]); }
                if (!Convert.IsDBNull(myReader["FScale"])) { myDetail.FScale = Convert.ToString(myReader["FScale"]); }
                if (!Convert.IsDBNull(myReader["FCharacter"])) { myDetail.FCharacter = Convert.ToString(myReader["FCharacter"]); }
                if (!Convert.IsDBNull(myReader["FCreateDate"])) { myDetail.FCreateDate = Convert.ToDateTime(myReader["FCreateDate"]); }
                if (!Convert.IsDBNull(myReader["FRegsterAmount"])) { myDetail.FRegsterAmount = Convert.ToDecimal(myReader["FRegsterAmount"]); }
                if (!Convert.IsDBNull(myReader["FProducePermit"])) { myDetail.FProducePermit = Convert.ToString(myReader["FProducePermit"]); }
                if (!Convert.IsDBNull(myReader["FSumPepole"])) { myDetail.FSumPepole = Convert.ToInt32(myReader["FSumPepole"]); }
                if (!Convert.IsDBNull(myReader["FPrepayAmount"])) { myDetail.FPrepayAmount = Convert.ToDecimal(myReader["FPrepayAmount"]); }
                if (!Convert.IsDBNull(myReader["FIsAutoNumber"])) { myDetail.FIsAutoNumber = Convert.ToInt32(myReader["FIsAutoNumber"]); }
                if (!Convert.IsDBNull(myReader["FVMIStockID"])) { myDetail.FVMIStockID = Convert.ToInt32(myReader["FVMIStockID"]); }
                if (!Convert.IsDBNull(myReader["FPOMode"])) { myDetail.FPOMode = Convert.ToInt32(myReader["FPOMode"]); }
                if (!Convert.IsDBNull(myReader["FSRMStartDate"])) { myDetail.FSRMStartDate = Convert.ToDateTime(myReader["FSRMStartDate"]); }
                if (!Convert.IsDBNull(myReader["F_102"])) { myDetail.F_102 = Convert.ToInt32(myReader["F_102"]); }
                if (!Convert.IsDBNull(myReader["FProvinceID"])) { myDetail.FProvinceID = Convert.ToInt32(myReader["FProvinceID"]); }
                if (!Convert.IsDBNull(myReader["F1688MemberId"])) { myDetail.F1688MemberId = Convert.ToString(myReader["F1688MemberId"]); }
                if (!Convert.IsDBNull(myReader["FCityID"])) { myDetail.FCityID = Convert.ToInt32(myReader["FCityID"]); }

            }

            myReader.Close();

            cmd.Dispose();
            con.Close();
            con.Dispose();
            return myDetail;
        }



        /// <summary>
        /// 更新t_Supplier对象
        /// 编写人：ywk
        /// 编写日期：2018/8/20 星期一
        /// </summary>
        public void Update(t_Supplier model,int IsPart)
        {
            SqlConnection con = new SqlConnection((IsPart == 0) ? K3connectionString : K3BranchConString);
            SqlCommand cmd = new SqlCommand("UPDATE t_Supplier SET FItemID = @m_FItemID,FAddress = @m_FAddress,FCity = @m_FCity,FProvince = @m_FProvince,FCountry = @m_FCountry,FPostalCode = @m_FPostalCode,FPhone = @m_FPhone,FFax = @m_FFax,FEmail = @m_FEmail,FHomePage = @m_FHomePage,FCreditLimit = @m_FCreditLimit,FTaxID = @m_FTaxID,FBank = @m_FBank,FAccount = @m_FAccount,FBrNo = @m_FBrNo,FBoundAttr = @m_FBoundAttr,FErpClsID = @m_FErpClsID,FShortName = @m_FShortName,FPriorityID = @m_FPriorityID,FPOGroupID = @m_FPOGroupID,FStatus = @m_FStatus,FLanguageID = @m_FLanguageID,FRegionID = @m_FRegionID,FTrade = @m_FTrade,FMinPOValue = @m_FMinPOValue,FMaxDebitDate = @m_FMaxDebitDate,FLegalPerson = @m_FLegalPerson,FContact = @m_FContact,FContactAcct = @m_FContactAcct,FPhoneAcct = @m_FPhoneAcct,FFaxAcct = @m_FFaxAcct,FZipAcct = @m_FZipAcct,FEmailAcct = @m_FEmailAcct,FAddrAcct = @m_FAddrAcct,FTax = @m_FTax,FCyID = @m_FCyID,FSetID = @m_FSetID,FSetDLineID = @m_FSetDLineID,FTaxNum = @m_FTaxNum,FPriceClsID = @m_FPriceClsID,FOperID = @m_FOperID,FCIQNumber = @m_FCIQNumber,FDeleted = @m_FDeleted,FSaleMode = @m_FSaleMode,FName = @m_FName,FNumber = @m_FNumber,FParentID = @m_FParentID,FShortNumber = @m_FShortNumber,FARAccountID = @m_FARAccountID,FAPAccountID = @m_FAPAccountID,FpreAcctID = @m_FpreAcctID,FlastTradeAmount = @m_FlastTradeAmount,FLastRPAmount = @m_FLastRPAmount,FFavorPolicy = @m_FFavorPolicy,Fdepartment = @m_Fdepartment,Femployee = @m_Femployee,Fcorperate = @m_Fcorperate,FBeginTradeDate = @m_FBeginTradeDate,FEndTradeDate = @m_FEndTradeDate,FLastTradeDate = @m_FLastTradeDate,FLastReceiveDate = @m_FLastReceiveDate,FcashDiscount = @m_FcashDiscount,FcurrencyID = @m_FcurrencyID,FMaxDealAmount = @m_FMaxDealAmount,FMinForeReceiveRate = @m_FMinForeReceiveRate,FMinReserveRate = @m_FMinReserveRate,FMaxForePayAmount = @m_FMaxForePayAmount,FMaxForePayRate = @m_FMaxForePayRate,FdebtLevel = @m_FdebtLevel,FCreditDays = @m_FCreditDays,FValueAddRate = @m_FValueAddRate,FPayTaxAcctID = @m_FPayTaxAcctID,FDiscount = @m_FDiscount,FTypeID = @m_FTypeID,FCreditAmount = @m_FCreditAmount,FCreditLevel = @m_FCreditLevel,FStockIDAssignee = @m_FStockIDAssignee,FBr = @m_FBr,FRegmark = @m_FRegmark,FLicAndPermit = @m_FLicAndPermit,FLicence = @m_FLicence,FPaperPeriod = @m_FPaperPeriod,FAlarmPeriod = @m_FAlarmPeriod,FOtherARAcctID = @m_FOtherARAcctID,FOtherAPAcctID = @m_FOtherAPAcctID,FPreARAcctID = @m_FPreARAcctID,FHelpCode = @m_FHelpCode,FNameEN = @m_FNameEN,FAddrEn = @m_FAddrEn,FCIQCode = @m_FCIQCode,FRegion = @m_FRegion,FMobilePhone = @m_FMobilePhone,FManageType = @m_FManageType,FRegsterDate = @m_FRegsterDate,FPassDate = @m_FPassDate,FInureDate = @m_FInureDate,FAbateDate = @m_FAbateDate,FSupplyGrade = @m_FSupplyGrade,FSupplyType = @m_FSupplyType,FCompanyType = @m_FCompanyType,FEvalutionType = @m_FEvalutionType,FSupplierCoroutineFlag = @m_FSupplierCoroutineFlag,FAutoCreateMR = @m_FAutoCreateMR,FAutoValidateOrderFlag = @m_FAutoValidateOrderFlag,FAPFrozenFlag = @m_FAPFrozenFlag,FID = @m_FID,FClassTypeID = @m_FClassTypeID,FBillNo = @m_FBillNo,FBiller = @m_FBiller,FModifier = @m_FModifier,FBillDate = @m_FBillDate,FModifyDate = @m_FModifyDate,FScale = @m_FScale,FCharacter = @m_FCharacter,FCreateDate = @m_FCreateDate,FRegsterAmount = @m_FRegsterAmount,FProducePermit = @m_FProducePermit,FSumPepole = @m_FSumPepole,FPrepayAmount = @m_FPrepayAmount,FIsAutoNumber = @m_FIsAutoNumber,FVMIStockID = @m_FVMIStockID,FPOMode = @m_FPOMode,FSRMStartDate = @m_FSRMStartDate,F_102 = @m_F_102,FProvinceID = @m_FProvinceID,F1688MemberId = @m_F1688MemberId,FCityID = @m_FCityID WHERE FNumber = @m_FNumber", con);
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
                cmd.Parameters.Add(new SqlParameter("@m_FSaleMode", SqlDbType.SmallInt, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSaleMode", SqlDbType.SmallInt, 0)).Value = model.FSaleMode;
            }
            if (model.FName == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FName", SqlDbType.VarChar, 255)).Value = model.FName;
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
            if (model.FLastRPAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLastRPAmount", SqlDbType.Money, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLastRPAmount", SqlDbType.Money, 0)).Value = model.FLastRPAmount;
            }
            if (model.FFavorPolicy == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFavorPolicy", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FFavorPolicy", SqlDbType.VarChar, 255)).Value = model.FFavorPolicy;
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
            if (model.FBeginTradeDate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBeginTradeDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBeginTradeDate", SqlDbType.DateTime, 0)).Value = model.FBeginTradeDate;
            }
            if (model.FEndTradeDate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEndTradeDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEndTradeDate", SqlDbType.DateTime, 0)).Value = model.FEndTradeDate;
            }
            if (model.FLastTradeDate ==null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLastTradeDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLastTradeDate", SqlDbType.DateTime, 0)).Value = model.FLastTradeDate;
            }
            if (model.FLastReceiveDate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLastReceiveDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLastReceiveDate", SqlDbType.DateTime, 0)).Value = model.FLastReceiveDate;
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
            if (model.FMaxDealAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMaxDealAmount", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMaxDealAmount", SqlDbType.Float, 0)).Value = model.FMaxDealAmount;
            }
            if (model.FMinForeReceiveRate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMinForeReceiveRate", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMinForeReceiveRate", SqlDbType.Float, 0)).Value = model.FMinForeReceiveRate;
            }
            if (model.FMinReserveRate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMinReserveRate", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMinReserveRate", SqlDbType.Float, 0)).Value = model.FMinReserveRate;
            }
            if (model.FMaxForePayAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMaxForePayAmount", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMaxForePayAmount", SqlDbType.Float, 0)).Value = model.FMaxForePayAmount;
            }
            if (model.FMaxForePayRate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMaxForePayRate", SqlDbType.Float, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FMaxForePayRate", SqlDbType.Float, 0)).Value = model.FMaxForePayRate;
            }
            if (model.FdebtLevel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FdebtLevel", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FdebtLevel", SqlDbType.Int, 0)).Value = model.FdebtLevel;
            }
            if (model.FCreditDays == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditDays", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditDays", SqlDbType.Int, 0)).Value = model.FCreditDays;
            }
            if (model.FValueAddRate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FValueAddRate", SqlDbType.Decimal, 28)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FValueAddRate", SqlDbType.Decimal, 28)).Value = model.FValueAddRate;
            }
            if (model.FPayTaxAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPayTaxAcctID", SqlDbType.Int, 0)).Value = model.FPayTaxAcctID;
            }
            if (model.FDiscount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDiscount", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FDiscount", SqlDbType.Decimal, 18)).Value = model.FDiscount;
            }
            if (model.FTypeID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTypeID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FTypeID", SqlDbType.Int, 0)).Value = model.FTypeID;
            }
            if (model.FCreditAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditAmount", SqlDbType.Decimal, 18)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditAmount", SqlDbType.Decimal, 18)).Value = model.FCreditAmount;
            }
            if (model.FCreditLevel == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditLevel", SqlDbType.VarChar, 20)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreditLevel", SqlDbType.VarChar, 20)).Value = model.FCreditLevel;
            }
            if (model.FStockIDAssignee == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStockIDAssignee", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FStockIDAssignee", SqlDbType.Int, 0)).Value = model.FStockIDAssignee;
            }
            if (model.FBr == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBr", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBr", SqlDbType.Int, 0)).Value = model.FBr;
            }
            if (model.FRegmark == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRegmark", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRegmark", SqlDbType.VarChar, 255)).Value = model.FRegmark;
            }
            if (model.FLicAndPermit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLicAndPermit", SqlDbType.Bit, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLicAndPermit", SqlDbType.Bit, 0)).Value = model.FLicAndPermit;
            }
            if (model.FLicence == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLicence", SqlDbType.VarChar, 255)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FLicence", SqlDbType.VarChar, 255)).Value = model.FLicence;
            }
            if (model.FPaperPeriod == null)
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
            if (model.FPreARAcctID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPreARAcctID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPreARAcctID", SqlDbType.Int, 0)).Value = model.FPreARAcctID;
            }
            if (model.FHelpCode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHelpCode", SqlDbType.VarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FHelpCode", SqlDbType.VarChar, 50)).Value = model.FHelpCode;
            }
            //if (model.FModifyTime == null)
            //{
            //    cmd.Parameters.Add(new SqlParameter("@m_FModifyTime", SqlDbType.Timestamp, 0)).Value = DBNull.Value;
            //}
            //else
            //{
            //    cmd.Parameters.Add(new SqlParameter("@m_FModifyTime", SqlDbType.Timestamp, 0)).Value = model.FModifyTime;
            //}
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
            if (model.FManageType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FManageType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FManageType", SqlDbType.Int, 0)).Value = model.FManageType;
            }
            if (model.FRegsterDate ==null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRegsterDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRegsterDate", SqlDbType.DateTime, 0)).Value = model.FRegsterDate;
            }
            if (model.FPassDate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPassDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPassDate", SqlDbType.DateTime, 0)).Value = model.FPassDate;
            }
            if (model.FInureDate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInureDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FInureDate", SqlDbType.DateTime, 0)).Value = model.FInureDate;
            }
            if (model.FAbateDate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAbateDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAbateDate", SqlDbType.DateTime, 0)).Value = model.FAbateDate;
            }
            if (model.FSupplyGrade == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupplyGrade", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupplyGrade", SqlDbType.Int, 0)).Value = model.FSupplyGrade;
            }
            if (model.FSupplyType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupplyType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupplyType", SqlDbType.Int, 0)).Value = model.FSupplyType;
            }
            if (model.FCompanyType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCompanyType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCompanyType", SqlDbType.Int, 0)).Value = model.FCompanyType;
            }
            if (model.FEvalutionType == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEvalutionType", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FEvalutionType", SqlDbType.Int, 0)).Value = model.FEvalutionType;
            }
            if (model.FSupplierCoroutineFlag == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupplierCoroutineFlag", SqlDbType.Bit, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSupplierCoroutineFlag", SqlDbType.Bit, 0)).Value = model.FSupplierCoroutineFlag;
            }
            if (model.FAutoCreateMR == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAutoCreateMR", SqlDbType.Bit, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAutoCreateMR", SqlDbType.Bit, 0)).Value = model.FAutoCreateMR;
            }
            if (model.FAutoValidateOrderFlag == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAutoValidateOrderFlag", SqlDbType.Bit, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAutoValidateOrderFlag", SqlDbType.Bit, 0)).Value = model.FAutoValidateOrderFlag;
            }
            if (model.FAPFrozenFlag == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAPFrozenFlag", SqlDbType.Bit, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FAPFrozenFlag", SqlDbType.Bit, 0)).Value = model.FAPFrozenFlag;
            }
            if (model.FID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FID", SqlDbType.Int, 0)).Value = model.FID;
            }
            if (model.FClassTypeID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FClassTypeID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FClassTypeID", SqlDbType.Int, 0)).Value = model.FClassTypeID;
            }
            if (model.FBillNo == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.NVarChar, 30)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillNo", SqlDbType.NVarChar, 30)).Value = model.FBillNo;
            }
            if (model.FBiller == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBiller", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBiller", SqlDbType.Int, 0)).Value = model.FBiller;
            }
            if (model.FModifier == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModifier", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModifier", SqlDbType.Int, 0)).Value = model.FModifier;
            }
            if (model.FBillDate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FBillDate", SqlDbType.DateTime, 0)).Value = model.FBillDate;
            }
            if (model.FModifyDate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModifyDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FModifyDate", SqlDbType.DateTime, 0)).Value = model.FModifyDate;
            }
            if (model.FScale == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FScale", SqlDbType.NVarChar, 50)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FScale", SqlDbType.NVarChar, 50)).Value = model.FScale;
            }
            if (model.FCharacter == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCharacter", SqlDbType.NVarChar, 80)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCharacter", SqlDbType.NVarChar, 80)).Value = model.FCharacter;
            }
            if (model.FCreateDate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreateDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCreateDate", SqlDbType.DateTime, 0)).Value = model.FCreateDate;
            }
            if (model.FRegsterAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRegsterAmount", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FRegsterAmount", SqlDbType.Decimal, 23)).Value = model.FRegsterAmount;
            }
            if (model.FProducePermit == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FProducePermit", SqlDbType.NVarChar, 80)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FProducePermit", SqlDbType.NVarChar, 80)).Value = model.FProducePermit;
            }
            if (model.FSumPepole == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSumPepole", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSumPepole", SqlDbType.Int, 0)).Value = model.FSumPepole;
            }
            if (model.FPrepayAmount == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPrepayAmount", SqlDbType.Decimal, 23)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPrepayAmount", SqlDbType.Decimal, 23)).Value = model.FPrepayAmount;
            }
            if (model.FIsAutoNumber == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsAutoNumber", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FIsAutoNumber", SqlDbType.Int, 0)).Value = model.FIsAutoNumber;
            }
            if (model.FVMIStockID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FVMIStockID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FVMIStockID", SqlDbType.Int, 0)).Value = model.FVMIStockID;
            }
            if (model.FPOMode == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPOMode", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FPOMode", SqlDbType.Int, 0)).Value = model.FPOMode;
            }
            if (model.FSRMStartDate == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSRMStartDate", SqlDbType.DateTime, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FSRMStartDate", SqlDbType.DateTime, 0)).Value = model.FSRMStartDate;
            }
            if (model.F_102 == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_F_102", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_F_102", SqlDbType.Int, 0)).Value = model.F_102;
            }
            if (model.FProvinceID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FProvinceID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FProvinceID", SqlDbType.Int, 0)).Value = model.FProvinceID;
            }
            if (model.F1688MemberId == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_F1688MemberId", SqlDbType.VarChar, 1)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_F1688MemberId", SqlDbType.VarChar, 1)).Value = model.F1688MemberId;
            }
            if (model.FCityID == null)
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCityID", SqlDbType.Int, 0)).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@m_FCityID", SqlDbType.Int, 0)).Value = model.FCityID;
            }

            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw new Exception(e.ToString()); }
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }


    }
}
