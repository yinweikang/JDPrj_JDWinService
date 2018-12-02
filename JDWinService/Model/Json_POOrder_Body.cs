using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    public class Json_POOrder_Body
    {
        public page2 Page2 { get; set; }

        public class page2 {
            public string FEntryID2 { get; set; }
            public string FEntrySelfP0245 { get; set; }
            public string FEntrySelfP0246 { get; set; }
            public string FEntrySelfP0266 { get; set; }
            public string FEntrySelfP0267 { get; set; }
            public string FEntrySelfP0268 { get; set; }
            public string FEntrySelfP0272 { get; set; }
            public string FEntrySelfP0273 { get; set; }
            public string FEntrySelfP0274 { get; set; }
            public string FEntrySelfP0275 { get; set; }
            public string FEntrySelfP0276 { get; set; }
            public string FEntrySelfP0277 { get; set; }
            public string FEntrySelfP0278 { get; set; }
            public string FEntrySelfP0279 { get; set; }
            public string FEntrySelfP0280 { get; set; }
            public string FEntrySelfP0285 { get; set; }

            public string FEntrySelfP0286 { get; set; }
            public string FIsCheck { get; set; }
            public Fcheckmethod FCheckMethod { get; set; }
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
            public string FAuxQty { get; set; }
            public string FSecUnitID { get; set; }
            public string FSecCoefficient { get; set; }
            public string FSecQty { get; set; }
            public string Fauxprice { get; set; }
            public string FAuxTaxPrice { get; set; }
            public string FAmount { get; set; }
            public string FTaxRate { get; set; }
            public string FAuxPriceDiscount { get; set; }
            public string FDescount { get; set; }
            public string FCess { get; set; }
            public string FTaxAmount { get; set; }
            public string FAllAmount { get; set; }
            public string Fdate1 { get; set; }
            public string Fnote { get; set; }
            public string FCommitQty { get; set; }
            public string FAuxCommitQty { get; set; }
            public string FSecCommitQty { get; set; }
            public string FStockQty { get; set; }
            public string FSecStockQty { get; set; }
            public string FAuxStockQty { get; set; }
            public string FSourceBillNo { get; set; }
            public string FSourceTranType { get; set; }
            public string FEntryAccessoryCount { get; set; }
            public string FSourceInterId { get; set; }
            public string FSourceEntryID { get; set; }
            public string FRefuseNote { get; set; }
            public string FContractBillNo { get; set; }
            public string FRejectRefuseNote { get; set; }
            public string FContractInterID { get; set; }
            public string FSupConDate { get; set; }
            public string FContractEntryID { get; set; }
            public string FSupConFetchDate { get; set; }
            public string FAuxQtyInvoice { get; set; }
            public string FSupConfirm { get; set; }
            public string FSecInvoiceQty { get; set; }
            public Fsupconfirmor FSupConfirmor { get; set; }
            public string FQtyInvoice { get; set; }
            public string FSupConMem { get; set; }
            public string FAuxPropCls { get; set; }
            public string FSupConQty { get; set; }
            public string FMrpLockFlag { get; set; }
            public string FReceiveAmountFor_Commit { get; set; }
            public Fplanmode FPlanMode { get; set; }
            public string FMTONo { get; set; }

        }

        public class Fcheckmethod
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

        public class Fsupconfirmor
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fplanmode
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

    }
}
