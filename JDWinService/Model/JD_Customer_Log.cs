using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    public class JD_Customer_Log
    {
        /// <summary>
		/// 
		/// </summary>
		public int ItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TaskID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RequestUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RequestDept { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime RequestDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSaleModeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSaleModeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSaleModeNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSaleTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSaleTypeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSaleTypeNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FCyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FCyID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FCyNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FAPAccountIDName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FAPAccountIDNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FPreAcctIDName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FPreAcctIDNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FOtherAPAcctIDName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FOtherAPAcctIDNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FPayTaxAcctIDName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FPayTaxAcctIDNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FemployeeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FemployeeNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FPayConditionName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FPayConditionNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSetIDName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSetIDNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CustomerNameEN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CompanyAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Headquarter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CompanyContact { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CustomTel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CustomFax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CustomEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BankAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BankAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BankAccountNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string VATNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SwiftCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ABANumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IBANumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PayTerms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PayTermsCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PayMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PayMethodCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CreditLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FinanceContacter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PayTel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PayFax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PayEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DeliveryEXW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DeliveryDDP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DeliveryCIF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DeliveryFCA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DeliveryDDU { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DeliveryFOB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShipVia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BillAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BillContacter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BillTel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BillFax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BillEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShipAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShipContacter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShipPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShipFax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShipEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FShortName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FValueAddRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsUpdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LogType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FemployeeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FSetID { get; set; }
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
        public int FOtherAPAcctID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPayTaxAcctID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPayCondition { get; set; }
    }
}
