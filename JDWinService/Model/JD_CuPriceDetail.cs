using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    public class JD_CuPriceDetail
    {
        /// <summary>
        /// 
        /// </summary>
        public int ItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Operater { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SupplierName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SupplierCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal BeginCuPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal EndCuPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FModel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FromCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int EndCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CoinType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string MOQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PPQ { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LimitTimes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsDeleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PackageInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal CostPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CostCoinType { get; set; }
    }
}
