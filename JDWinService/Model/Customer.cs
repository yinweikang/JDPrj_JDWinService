using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //K3 客户API模板

    public class Customer
    {
        public MyData Data;
        public class MyData
        {
            public object F_102 { get; set; }
            public F_103 F_103 { get; set; }
            public object F_104 { get; set; }
            public object F_105 { get; set; }
            public object FAccount { get; set; }
            public object FAddrEn { get; set; }
            public object FAddress { get; set; }
            public Fapaccountid FAPAccountID { get; set; }
            public Faraccountid FARAccountID { get; set; }
            public object FBank { get; set; }
            public int FCarryingAOS { get; set; }
            public object FCIQCode { get; set; }
            public object FCIQNumber { get; set; }
            public Fcityid FCityID { get; set; }
            public object FContact { get; set; }
            public object Fcorperate { get; set; }
            public Fcosupplierid FCoSupplierID { get; set; }
            public object FCountry { get; set; }
            public Fcyid FCyID { get; set; }
            public Fdebtlevel FdebtLevel { get; set; }
            public Fdepartment Fdepartment { get; set; }
            public object FEmail { get; set; }
            public Femployee Femployee { get; set; }
            public object FfavorPolicy { get; set; }
            public object FFax { get; set; }
            public object FHelpCode { get; set; }
            public object FHomePage { get; set; }
            public bool FIsCreditMgr { get; set; }
            public object FlastReceiveDate { get; set; }
            public int FlastRPAmount { get; set; }
            public int FlastTradeAmount { get; set; }
            public object FlastTradeDate { get; set; }
            public Fmanagetype FManageType { get; set; }
            public int FmaxDealAmount { get; set; }
            public int FminForeReceiveRate { get; set; }
            public int FminReserverate { get; set; }
            public string FMobilePhone { get; set; }
            public string FName { get; set; }
            public object FNameEN { get; set; }
            public string FNumber { get; set; }
            public Fotherapacctid FOtherAPAcctID { get; set; }
            public Fotheraracctid FOtherARAcctID { get; set; }
            public Fpaycondition[] FPayCondition { get; set; }
            public Fpaytaxacctid FPayTaxAcctID { get; set; }
            public object FPhone { get; set; }
            public object FPostalCode { get; set; }
            public Fpreacctid FPreAcctID { get; set; }
            public Fpreapacctid FPreAPAcctID { get; set; }
            public Fprovinceid FProvinceID { get; set; }
            public Fregion FRegion { get; set; }
            public Fregionid FRegionID { get; set; }
            public Fsaleid FSaleID { get; set; }
            public Fsalemode FSaleMode { get; set; }
            public Fsetid FSetID { get; set; }
            public object FShortName { get; set; }
            public Fstatus FStatus { get; set; }
            public Fstockidkeep FStockIDKeep { get; set; }
            public object FTaxNum { get; set; }
            public Ftrade FTrade { get; set; }
            public Ftypeid FTypeID { get; set; }
            public int FValueAddRate { get; set; }
        }

        public class F_103
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

        public class Fcityid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fcosupplierid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fcyid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fdebtlevel
        {
            public string FID { get; set; }
            public string FName { get; set; }
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

        public class Fpreacctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fpreapacctid
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

        public class Fsaleid
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fsalemode
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

        public class Fstockidkeep
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
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

        public class Fpaycondition
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

    }
}
