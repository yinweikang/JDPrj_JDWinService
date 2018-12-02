using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //供应商BPM管理
    //2018-08-29
    public class JD_Supplier_Mng
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
        public string SNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FNumber { get; set; }
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
        public string ApplyType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FCyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FCyNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FSimpleName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FIsZZS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FfullName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CompanyType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FGrade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SourceRemark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string MainProduct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SwiftCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FValueAddRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FcreditdayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FcreditdayNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AccountName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AccountCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string XinYongED { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TradeInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FsetidName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FsetidNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FYingFuName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FYingFuNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FYuFuName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FYuFuNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FOtherFuName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FOtherFuNumber { get; set; }
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
        public string CGName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CGTel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CGEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CGMobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CGMobile2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CGJob { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string GYLName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string GYLTel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string GYLEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string GYLMobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string GYLMobile2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string GYLJob { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AttachFiles { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AttachFiles2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AttachFiles3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AttachFiles4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AttachFiles5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AttachFiles6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AttachFiles7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AttachFiles8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AttachFiles9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FComGrade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCyID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FCreditDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Fsetid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FAPAccountID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPayTaxAcctID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FPreAcctID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FOtherAPAcctID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PostCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsPart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string MfrsType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HasProxy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string MainBrand { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ApplyReason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ApplyRemark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DeliveryTerms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsCGSupplier { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IsAddressEdit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsForbidden { get; set; }

        public double CheckResult { get; set; }
        public double Coefficient { get; set; }

        public string FHelpCode { get; set; }

        public string IsAcceptTicket { get; set; }
        
        public string TicketNum { get; set; }
        
        public string AcceptRemarks { get; set; }

        public string GradeStatus { get; set; }

        public int OrderListCount { get; set; }
    }
}
