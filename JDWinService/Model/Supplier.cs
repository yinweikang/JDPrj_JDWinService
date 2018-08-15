using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    public class Supplier
    {
        public MyData Data;
        public class MyData
        {
            public F_102 F_102 { get; set; }
            public object FAbateDate { get; set; }
            public string FAccount { get; set; }
            public object FAddrEn { get; set; }
            public object FAddress { get; set; }
            public Fapaccountid FAPAccountID { get; set; }
            public bool FAPFrozenFlag { get; set; }
            public Faraccountid FARAccountID { get; set; }
            public bool FAutoCreateMR { get; set; }
            public bool FAutoValidateOrderFlag { get; set; }
            public object FBank { get; set; }
            public Fbr FBr { get; set; }
            public object FCIQCode { get; set; }
            public Fcityid FCityID { get; set; }
            public Fcompanytype FCompanyType { get; set; }
            public object FContact { get; set; }
            public object Fcorperate { get; set; }
            public object FCountry { get; set; }
            public Fcreditday[] FCreditDays { get; set; }
            public Fcyid FCyID { get; set; }
            public Fdepartment Fdepartment { get; set; }
            public int FDiscount { get; set; }
            public object FEmail { get; set; }
            public Femployee Femployee { get; set; }
            public object FfavorPolicy { get; set; }
            public object FFax { get; set; }
            public object FHelpCode { get; set; }
            public object FInureDate { get; set; }
            public object FlastReceiveDate { get; set; }
            public int FlastRPAmount { get; set; }
            public int FlastTradeAmount { get; set; }
            public object FlastTradeDate { get; set; }
            public object FLicence { get; set; }
            public Fmanagetype FManageType { get; set; }
            public int FmaxDealAmount { get; set; }
            public int FminForeReceiveRate { get; set; }
            public string FMobilePhone { get; set; }
            public string FName { get; set; }
            public object FNameEN { get; set; }
            public string FNumber { get; set; }
            public Fotherapacctid FOtherAPAcctID { get; set; }
            public Fotheraracctid FOtherARAcctID { get; set; }
            public object FPassDate { get; set; }
            public Fpaytaxacctid FPayTaxAcctID { get; set; }
            public object FPhone { get; set; }
            public Fpomode FPOMode { get; set; }
            public object FPostalCode { get; set; }
            public Fpreacctid FPreAcctID { get; set; }
            public Fprearacctid FPreARAcctID { get; set; }
            public Fprovinceid FProvinceID { get; set; }
            public Fregion FRegion { get; set; }
            public Fregionid FRegionID { get; set; }
            public object FRegmark { get; set; }
            public object FRegsterDate { get; set; }
            public Fsetid FSetID { get; set; }
            public object FShortName { get; set; }
            public Fstatus FStatus { get; set; }
            public Fstockidassignee FStockIDAssignee { get; set; }
            public bool FSupplierCoroutineFlag { get; set; }
            public Fsupplygrade FSupplyGrade { get; set; }
            public Fsupplytype FSupplyType { get; set; }
            public object FTaxNum { get; set; }
            public Ftrade FTrade { get; set; }
            public Ftypeid FTypeID { get; set; }
            public int FValueAddRate { get; set; }
            public Fvmistockid FVMIStockID { get; set; }
        }

        public class F_102
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fapaccountid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Faraccountid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fbr
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fcityid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fcompanytype
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fcyid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fdepartment
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Femployee
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fmanagetype
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fotherapacctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fotheraracctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fpaytaxacctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fpomode
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fpreacctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fprearacctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fprovinceid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fregion
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fregionid
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fsetid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fstatus
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fstockidassignee
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fsupplygrade
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fsupplytype
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Ftrade
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Ftypeid
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fvmistockid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fcreditday
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

    }
}
