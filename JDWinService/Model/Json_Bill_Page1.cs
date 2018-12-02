using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    public class Json_Bill_Page1
    {
        public page1 Page1 { get; set; }
        public class page1
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
    }
     

  
    
}
