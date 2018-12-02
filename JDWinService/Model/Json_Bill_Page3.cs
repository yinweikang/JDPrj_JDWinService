using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    class Json_Bill_Page3
    {
        public page3 Page3 { get; set; }

        public class page3
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

    }
}
