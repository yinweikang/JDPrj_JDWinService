using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //K3 客户信息表
    public class t_Organization
    {
        /// <summary>
		/// 
		/// </summary>
		public int FItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FCity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FProvince { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FCountry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FPostalCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FFax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FHomePage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FCreditLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FTaxID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FBank { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FBankNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FBrNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FBoundAttr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FErpClsID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FShortName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPriorityID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPOGroupID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FLanguageID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FRegionID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FTrade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double FMinPOValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double FMaxDebitDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FLegalPerson { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FContact { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FContactAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FPhoneAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FFaxAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FZipAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FEmailAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FAddrAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float FTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCyID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSetID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSetDLineID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FTaxNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPriceClsID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOperID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FCIQNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public short FDeleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSaleMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FParentID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FShortNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FARAccountID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FAPAccountID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FpreAcctID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FlastTradeAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FlastRPAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FfavorPolicy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Fdepartment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Femployee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Fcorperate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FbeginTradeDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FendTradeDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FlastTradeDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FlastReceiveDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FcashDiscount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FcurrencyID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double FmaxDealAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double FminForeReceiveRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double FminReserverate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FdebtLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCarryingAOS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool FIsCreditMgr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCreditPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCreditLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPayTaxAcctID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FValueAddRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FTypeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCreditDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FCreditAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FStockIDAssign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FStockIDInst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FStockIDKeep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FPaperPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FAlarmPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool FLicAndPermit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOtherARAcctID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOtherAPAcctID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPreAPAcctID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSaleID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FHelpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FModifyTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FNameEN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FAddrEn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FCIQCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FRegion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FMobilePhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPayCondition { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FManageType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FClass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FRegUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FLastModifyDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FRecentContactDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FRegDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FFlat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FClassTypeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCoSupplierID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FShareStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCustType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSuperiorID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FClueID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FLastMailTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCityID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FProvinceID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FMobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FDuty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FWorkSite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FWorkUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FIncomeLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FStratum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FAge { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FBirthday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FNation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FBizPostCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FIM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FBizPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FLastActivityTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FLastSVTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FLastCallTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FLastSMSTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FExpired { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string F_102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int F_103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string F_104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string F_105 { get; set; }
    }
}
