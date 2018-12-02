using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    public class PrjBOMBG
    {
        public MyData Data;
       
        public class MyData
        {
            public Page1  Page1 { get; set; }
            public Page2[]  Page2 { get; set; }
            public Page3  Page3 { get; set; }
            public Page4[]  Page4 { get; set; }
        }

        public class Page1
        {
            public string FBillNo { get; set; }
            public string FStatus { get; set; }
            public Fdeptid FDeptID { get; set; }
            public Fproposerid FProposerID { get; set; }
            public Fproducterid FProducterID { get; set; }
            public Fdesignerid FDesignerID { get; set; }
            public string FDescription { get; set; }
            public Fbiller FBiller { get; set; }
            public string FDate { get; set; }
            public Fcheckerid FCheckerID { get; set; }
            public string FClassTypeID { get; set; }
            public string FCheckDate { get; set; }
        }

        public class Fdeptid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fproposerid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fproducterid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fdesignerid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbiller
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fcheckerid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Page2
        {
            public string FIndex2 { get; set; }
            public string FBomEntryParentClsID { get; set; }
            public string FBomEntryISOld { get; set; }
            public Fbomentrybominterid FBomEntryBOMInterID { get; set; }
            public string FBomEntryParentItemNumber { get; set; }
            public string FBomEntryParentItemName { get; set; }
            public string FBomEntryParentItemModel { get; set; }
            public Fbomentrymodifytype FBomEntryModifyType { get; set; }
            public Fbomentryitemid FBomEntryItemID { get; set; }
            public string FBomEntryItemName { get; set; }
            public string FBomEntryModel { get; set; }
            public Fbomentryauxpropid FBomEntryAuxPropID { get; set; }
            public string FBomEntryHasChar { get; set; }
            public string FBomEntryItemOldIndex { get; set; }
            public Fbomentryunitid FBomEntryUnitID { get; set; }
            public string FBomEntryAuxQty { get; set; }
            public string FBomEntryQty { get; set; }
            public Fbomentrymarshaltype FBomEntryMarshalType { get; set; }
            public string FBomEntryPercent { get; set; }
            public Fbomentrymaterieltype FBomEntryMaterielType { get; set; }
            public string FBomEntryBeginDay { get; set; }
            public string FBomEntryEndDay { get; set; }
            public string FBomEntryScrap { get; set; }
            public string FBomEntryPositionNo { get; set; }
            public string FBomEntryItemSize { get; set; }
            public string FBomEntryItemSuite { get; set; }
            public string FBomEntryOperSN { get; set; }
            public Fbomentryoperid FBomEntryOperID { get; set; }
            public string FBomEntryMachinePos { get; set; }
            public string FBomEntryOffSetDay { get; set; }
            public Fbomentrybackflush FBomEntryBackFlush { get; set; }
            public string FBomEntryIsKeyItem { get; set; }
            public string FBomEntryUseState { get; set; }
            public string FBomEntryForbitUse { get; set; }
            public Fbomentrystockid FBomEntryStockID { get; set; }
            public Fbomentryspid FBomEntrySPID { get; set; }
            public string FBomEntryNOTE { get; set; }
            public string FBomEntryNOTE1 { get; set; }
            public string FBomEntryNOTE2 { get; set; }
            public string FBomEntryNOTE3 { get; set; }
            public string FBomEntryDetailID { get; set; }
            public string FBomEntryParentItemID { get; set; }
            public string FBomEntryIsStockMgr { get; set; }
            public string FBomEntryParentAuxPropID { get; set; }
            public string FBomEntryParentIsCharSourceItem { get; set; }
            public string FBomEntryFixLeadTime { get; set; }
            public string FBomEntrySubItemErpClsID { get; set; }
            public string FBomEntrySubItemErpClsName { get; set; }
        }

        public class Fbomentrybominterid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbomentrymodifytype
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbomentryitemid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbomentryauxpropid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbomentryunitid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbomentrymarshaltype
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbomentrymaterieltype
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbomentryoperid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbomentrybackflush
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbomentrystockid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbomentryspid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Page3
        {
            public string FIndex3 { get; set; }
            public string FBomHeadIsOld { get; set; }
            public string FBomHeadOrderID { get; set; }
            public Fbomheadbominterid FBomHeadBomInterID { get; set; }
            public string FBomHeadModifyType { get; set; }
            public Fbomheaditemid FBomHeadItemID { get; set; }
            public string FBomHeadItemName { get; set; }
            public string FBomHeadModel { get; set; }
            public Fbomheadauxpropid FBomHeadAuxPropID { get; set; }
            public string FBomHeadClsID { get; set; }
            public Fbomheadunitid FBomHeadUnitID { get; set; }
            public string FBomHeadAuxQty { get; set; }
            public string FBomHeadQty { get; set; }
            public Fbomheadroutingid FBomHeadRoutingID { get; set; }
            public string FBomHeadRoutingName { get; set; }
            public string FBomHeadYield { get; set; }
            public string FBomHeadVersion { get; set; }
            public string FBomHeadBOMSkip { get; set; }
            public string FBomHeadNote { get; set; }
        }

        public class Fbomheadbominterid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbomheaditemid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbomheadauxpropid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbomheadunitid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fbomheadroutingid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Page4
        {
            public string FIndex4 { get; set; }
            public string FIsOld { get; set; }
            public Fbominterid FBomInterID { get; set; }
            public string FModifyType { get; set; }
            public string FModifyContent { get; set; }
            public Fitemid FItemID { get; set; }
            public string FItemName { get; set; }
            public string FModel { get; set; }
            public string FItemClsID { get; set; }
            public string FEntryItemOldIndex { get; set; }
            public Funitid FUnitID { get; set; }
            public string FAuxQty { get; set; }
            public string FQty { get; set; }
            public string FEntryBeginDay { get; set; }
            public string FEntryEndDay { get; set; }
            public Fheadroutingid FHeadRoutingID { get; set; }
            public string FHeadRoutingName { get; set; }
            public string FHeadVersion { get; set; }
            public string FEntryScrap { get; set; }
            public string FHeadYield { get; set; }
            public string FEntryPositionNo { get; set; }
            public Fheadbomskip FHeadBOMSkip { get; set; }
            public string FHeadNote { get; set; }
            public string FEntryItemSize { get; set; }
            public string FEntryItemSuite { get; set; }
            public Fentrymarshaltype FEntryMarshalType { get; set; }
            public string FEntryPercent { get; set; }
            public string FEntryOperSN { get; set; }
            public Fentryoperid FEntryOperID { get; set; }
            public string FEntryMachinePos { get; set; }
            public Fentrymaterieltype FEntryMaterielType { get; set; }
            public string FEntryOffSetDay { get; set; }
            public Fentrybackflush FEntryBackFlush { get; set; }
            public string FEntryIsKeyItem { get; set; }
            public string FEntryUseState { get; set; }
            public string FEntryForbitUse { get; set; }
            public Fentrystockid FEntryStockID { get; set; }
            public Fentryspid FEntrySPID { get; set; }
            public string FEntryNOTE { get; set; }
            public string FEntryNOTE1 { get; set; }
            public string FEntryNOTE2 { get; set; }
            public string FEntryNOTE3 { get; set; }
        }

        public class Fbominterid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fitemid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Funitid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fheadroutingid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fheadbomskip
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fentrymarshaltype
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fentryoperid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fentrymaterieltype
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fentrybackflush
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fentrystockid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

        public class Fentryspid
        {
            public string FNumber { get; set; }
            public string FName { get; set; }
        }

    }
}
