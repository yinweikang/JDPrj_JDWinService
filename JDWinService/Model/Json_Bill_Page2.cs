using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    class Json_Bill_Page2
    {
        public page2 Page2 { get; set; }

        public class page2
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

    }
}
