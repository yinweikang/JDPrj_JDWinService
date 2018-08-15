using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //销售订单 表身 明细
    public class Json_SOOrder_Body
    {
        public page2 Page2 { get; set; }

        public class page2
        {
            public string FEntryID2 { get; set; }
            public Fatpdeduct FATPDeduct { get; set; }
            public string FEntrySelfS0153 { get; set; }
            public string FEntrySelfS0154 { get; set; }
            public string FEntrySelfS0155 { get; set; }
            public string FEntrySelfS0161 { get; set; }
            public string FEntrySelfS0162 { get; set; }
            public string FEntrySelfS0168 { get; set; }
            public string FEntrySelfS0169 { get; set; }
            public string FEntrySelfS0170 { get; set; }
            public string FEntrySelfS0171 { get; set; }
            public string FEntrySelfS0172 { get; set; }
            public string FEntrySelfS0173 { get; set; }
            public string FEntrySelfS0174 { get; set; }
            public string FEntrySelfS0175 { get; set; }
            public string FEntrySelfS0176 { get; set; }
            public string FEntrySelfS0177 { get; set; }
            public string FEntrySelfS0183 { get; set; }
            public string FEntrySelfS0184 { get; set; }
            public string FEntrySelfS0185 { get; set; }
            public string FOutSourceEntryID { get; set; }
            public string FOutSourceInterID { get; set; }
            public string FOutSourceTranType { get; set; }
            public Fmapnumber FMapNumber { get; set; }
            public string FMapName { get; set; }
            public Fitemid FItemID { get; set; }
            public string FItemName { get; set; }
            public string FItemModel { get; set; }
            public Fauxpropid FAuxPropID { get; set; }
            public string FBaseUnit { get; set; }
            public string FQty { get; set; }
            public Funitid FUnitID { get; set; }
            public string Fauxqty { get; set; }
            public string FSecUnitID { get; set; }
            public string FSecCoefficient { get; set; }
            public string FSecQty { get; set; }
            public string Fauxprice { get; set; }
            public string FAuxTaxPrice { get; set; }
            public string Famount { get; set; }
            public string FCess { get; set; }
            public string FTaxRate { get; set; }
            public string FUniDiscount { get; set; }
            public string FTaxAmount { get; set; }
            public string FAuxPriceDiscount { get; set; }
            public string FTaxAmt { get; set; }
            public string FAllAmount { get; set; }
            public string FTranLeadTime { get; set; }
            public Finforecast FInForecast { get; set; }
            public string FDate1 { get; set; }
            public string Fnote { get; set; }
            public string FCommitQty { get; set; }
            public string FAuxCommitQty { get; set; }
            public string FSecCommitQty { get; set; }
            public string FSecStockQty { get; set; }
            public string FStockQty { get; set; }
            public string FAuxStockQty { get; set; }
            public Fplanmode FPlanMode { get; set; }
            public string FMTONo { get; set; }
            public Fbominterid FBomInterID { get; set; }
            public Fcostobjectid FCostObjectID { get; set; }
            public string FLockFlag { get; set; }
            public string FSourceBillNo { get; set; }
            public Fbomcategory FBOMCategory { get; set; }
            public string FSourceTranType { get; set; }
            public string FOrderBOMInterID { get; set; }
            public string FSourceInterId { get; set; }
            public string FSourceEntryID { get; set; }
            public Forderbomstatus FOrderBOMStatus { get; set; }
            public string FContractBillNo { get; set; }
            public string FContractInterID { get; set; }
            public string FContractEntryID { get; set; }
            public string FAuxQtyInvoice { get; set; }
            public string FSecInvoiceQty { get; set; }
            public string FQtyInvoice { get; set; }
            public string FSecCommitInstall { get; set; }
            public string FCommitInstall { get; set; }
            public string FAuxCommitInstall { get; set; }
            public string FAuxPropCls { get; set; }
            public string FAllStdAmount { get; set; }
            public string FMrpLockFlag { get; set; }
            public string FHaveMrp { get; set; }
            public string FReceiveAmountFor_Commit { get; set; }
            public string FOrderBillNo { get; set; }
            public string FOrderEntryID { get; set; }
        }

        public class Fatpdeduct
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fmapnumber
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fitemid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fauxpropid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Funitid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Finforecast
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fplanmode
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbominterid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fcostobjectid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbomcategory
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Forderbomstatus
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

    }
}
