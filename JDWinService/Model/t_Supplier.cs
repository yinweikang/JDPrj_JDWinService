using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    public class t_Supplier
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
        public short FSaleMode { get; set; }
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
        public decimal FLastRPAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FFavorPolicy { get; set; }
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
        public DateTime? FBeginTradeDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FEndTradeDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FLastTradeDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FLastReceiveDate { get; set; }
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
        public double FMaxDealAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double FMinForeReceiveRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double FMinReserveRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double FMaxForePayAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double FMaxForePayRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FdebtLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCreditDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FValueAddRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPayTaxAcctID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FDiscount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FTypeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FCreditAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FCreditLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FStockIDAssignee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FBr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FRegmark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool FLicAndPermit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FLicence { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FPaperPeriod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FAlarmPeriod { get; set; }
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
        public int FPreARAcctID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FHelpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FModifyTime { get; set; }
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
        public int FManageType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FRegsterDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FPassDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FInureDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FAbateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSupplyGrade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSupplyType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCompanyType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FEvalutionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool FSupplierCoroutineFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool FAutoCreateMR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool FAutoValidateOrderFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool FAPFrozenFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FClassTypeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FBillNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FBiller { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FModifier { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FBillDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FModifyDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FScale { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FCharacter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FCreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FRegsterAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FProducePermit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSumPepole { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FPrepayAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FIsAutoNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FVMIStockID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPOMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FSRMStartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int F_102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FProvinceID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string F1688MemberId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCityID { get; set; }
    }
}
