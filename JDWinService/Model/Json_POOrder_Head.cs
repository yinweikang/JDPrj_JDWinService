using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //采购订单 表头
    public class Json_POOrder_Head
    {
        public page1 Page1 { get; set; }
        public class page1
        {
            public string FCancellation { get; set; }
            public string FClassTypeID { get; set; }
            public string FEnterpriseID { get; set; }
            public string FHeadSelfP0252 { get; set; }
            public string FHeadSelfP0254 { get; set; }
            public Fheadselfp0255 FHeadSelfP0255 { get; set; }
            public string FSendStatus { get; set; }
            public string FStatus { get; set; }
            public string Fdate { get; set; }
            public Fareaps FAreaPS { get; set; }
            public Fsettleid FSettleID { get; set; }
            public Fbrid FBrID { get; set; }
            public Fpostyle FPOStyle { get; set; }
            public Frelatebrid FRelateBrID { get; set; }
            public string FSettleDate { get; set; }
            public Fsupplyid FSupplyID { get; set; }
            public string FPOOrdBillNo { get; set; }
            public string FExplanation { get; set; }
            public string FTranType { get; set; }
            public Fcurrencyid FCurrencyID { get; set; }
            public string FSelTranType { get; set; }
            public string FSelBillNo { get; set; }
            public string FExchangeRate { get; set; }
            public string FBillNo { get; set; }
            public string FMultiCheckStatus { get; set; }
            public string FDeliveryPlace { get; set; }
            public string Attachments { get; set; }
            public Fplancategory FPlanCategory { get; set; }
            public Fexchangeratetype FExchangeRateType { get; set; }
            public Fpomode FPOMode { get; set; }
            public Fcheckerid FCheckerID { get; set; }
            public string FCheckDate { get; set; }
            public Fmangerid FMangerID { get; set; }
            public Fdeptid FDeptID { get; set; }
            public Fempid FEmpID { get; set; }
            public Fbillerid FBillerID { get; set; }
            public string FManageType { get; set; }
            public Fconsignee FConsignee { get; set; }
            public string FSysStatus { get; set; }
            public string FValidaterName { get; set; }
            public string FVersionNo { get; set; }
            public string FChangeDate { get; set; }
            public Fchangeuser FChangeUser { get; set; }
            public string FChangeCauses { get; set; }
            public string FChangeMark { get; set; }
        }

        public class Fheadselfp0255
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

        public class Fbrid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fpostyle
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Frelatebrid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fsupplyid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fcurrencyid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fplancategory
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fexchangeratetype
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fpomode
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fcheckerid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fmangerid
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
