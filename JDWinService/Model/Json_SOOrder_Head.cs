using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //销售订单 表头
    public class Json_SOOrder_Head
    {
        public page1 Page1 { get; set; }

        public class page1
        {
            public string FCancellation { get; set; }
            public string FClassTypeID { get; set; }
            public string FEnterpriseID { get; set; }
            public Fheadselfs0140 FHeadSelfS0140 { get; set; }
            public string FHeadSelfS0153 { get; set; }
            public Fheadselfs0154 FHeadSelfS0154 { get; set; }
            public string FHeadSelfS0156 { get; set; }
            public Fheadselfs0157 FHeadSelfS0157 { get; set; }
            public string FHeadSelfS0160 { get; set; }
            public string FHeadSelfS0161 { get; set; }
            public string FSendStatus { get; set; }
            public string FStatus { get; set; }
            public Fcustid FCustID { get; set; }
            public string FSettleDate { get; set; }
            public string FImport { get; set; }
            public Fareaps FAreaPS { get; set; }
            public Fsettleid FSettleID { get; set; }
            public Frelatebrid FRelateBrID { get; set; }
            public string FPOOrdBillNo { get; set; }
            public Fsalestyle FSaleStyle { get; set; }
            public string FTransitAheadTime { get; set; }
            public Fbrid FBrID { get; set; }
            public string FTranType { get; set; }
            public Ffetchstyle FFetchStyle { get; set; }
            public string FFetchAdd { get; set; }
            public string FExplanation { get; set; }
            public Fcurrencyid FCurrencyID { get; set; }
            public string FSelTranType { get; set; }
            public string FSelBillNo { get; set; }
            public string FExchangeRate { get; set; }
            public string FBillNo { get; set; }
            public Fcustaddress FCustAddress { get; set; }
            public Fexchangeratetype FExchangeRateType { get; set; }
            public Fplancategory FPlanCategory { get; set; }
            public Fcheckerid FCheckerID { get; set; }
            public string FCheckDate { get; set; }
            public Fdeptid FDeptID { get; set; }
            public Fempid FEmpID { get; set; }
            public Fmangerid FMangerID { get; set; }
            public Fbillerid FBillerID { get; set; }
            public string FManageType { get; set; }
            public string FValidaterName { get; set; }
            public string FSysStatus { get; set; }
            public Fconsignee FConsignee { get; set; }
            public string FVersionNo { get; set; }
            public string FChangeDate { get; set; }
            public Fchangeuser FChangeUser { get; set; }
            public string FChangeCauses { get; set; }
            public string FChangeMark { get; set; }
        }

        public class Fheadselfs0140
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fheadselfs0154
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fheadselfs0157
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fcustid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fareaps
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fsettleid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Frelatebrid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fsalestyle
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbrid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Ffetchstyle
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fcurrencyid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fcustaddress
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fexchangeratetype
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fplancategory
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fcheckerid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fdeptid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fempid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fmangerid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbillerid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fconsignee
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fchangeuser
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

    }
}
