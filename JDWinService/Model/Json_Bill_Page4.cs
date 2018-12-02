using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    public class Json_Bill_Page4
    {
        public page4 Page4 { get; set; }

        public class page4
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
