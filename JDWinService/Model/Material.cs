using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDWinService.Model
{
    //K3 物料表API接口类
    public class Material
    {

        public MyData Data;
        public class MyData
        {
            public object F_108 { get; set; }
            public object F_109 { get; set; }
            public F_111 F_111 { get; set; }
            public object F_112 { get; set; }
            public int F_113 { get; set; }
            public object F_114 { get; set; }
            public string F_115 { get; set; }
            public int F_116 { get; set; }
            public object F_117 { get; set; }
            public int F_118 { get; set; }
            public int F_119 { get; set; }
            public object F_120 { get; set; }
            public int F_121 { get; set; }
            public int F_122 { get; set; }
            public Facctid FAcctID { get; set; }
            public Fadminacctid FAdminAcctID { get; set; }
            public object FAlias { get; set; }
            public Fapacctid FAPAcctID { get; set; }
            public object FApproveNo { get; set; }
            public Fauxclassid FAuxClassID { get; set; }
            public bool FAuxInMrpCal { get; set; }
            public Fbackflushspid FBackFlushSPID { get; set; }
            public Fbackflushstockid FBackFlushStockID { get; set; }
            public int FBatChangeEconomy { get; set; }
            public int FBatchAppendQty { get; set; }
            public bool FBatchManager { get; set; }
            public int FBatchSplit { get; set; }
            public int FBatchSplitDays { get; set; }
            public int FBatFixEconomy { get; set; }
            public int FBeforeExpire { get; set; }
            public bool FBookPlan { get; set; }
            public Fcavacctid FCAVAcctID { get; set; }
            public Fcbappendproject FCBAppendProject { get; set; }
            public int FCBAppendRate { get; set; }
            public bool FCBRestore { get; set; }
            public Fcbrouting FCBRouting { get; set; }
            public Fcharsourceitemid FCharSourceItemID { get; set; }
            public object FChartNumber { get; set; }
            public int FCheckCycle { get; set; }
            public Fcheckcycunit FCheckCycUnit { get; set; }
            public int FChgFeeRate { get; set; }
            public int FConsumeTaxRate { get; set; }
            public object FContainerName { get; set; }
            public Fcostacctid FCostAcctID { get; set; }
            public Fcostbomid FCostBomID { get; set; }
            public Fcostproject FCostProject { get; set; }
            public Fctrlstraregy FCtrlStraregy { get; set; }
            public Fctrltype FCtrlType { get; set; }
            public int FCubageDecimal { get; set; }
            public Fcubicmeasure FCubicMeasure { get; set; }
            public int FDailyConsume { get; set; }
            public int FDaysPer { get; set; }
            public Fdefaultloc FDefaultLoc { get; set; }
            public Fdefaultreadyloc FDefaultReadyLoc { get; set; }
            public Fdefaultroutingid FDefaultRoutingID { get; set; }
            public Fdefaultworktypeid FDefaultWorkTypeID { get; set; }
            public Fdsmanagerid FDSManagerID { get; set; }
            public object FEquipmentNum { get; set; }
            public Ferpclsid FErpClsID { get; set; }
            public int FExportRate { get; set; }
            public object FFirstUnit { get; set; }
            public int FFirstUnitRate { get; set; }
            public string FFixLeadTime { get; set; }
            public bool FForbbitBarcodeEdit { get; set; }
            public object FFullName { get; set; }
            public Fgoodspec FGoodSpec { get; set; }
            public int FGrossWeight { get; set; }
            public int FHeight { get; set; }
            public object FHelpCode { get; set; }
            public int FHighLimit { get; set; }
            public Fhsnumber FHSNumber { get; set; }
            public Fidentifier FIdentifier { get; set; }
            public int FImpostTaxRate { get; set; }
            public int FInHighLimit { get; set; }
            public int FInLowLimit { get; set; }
            public Finspectionlevel FInspectionLevel { get; set; }
            public Finspectionproject FInspectionProject { get; set; }
            public bool FIsBackFlush { get; set; }
            public int FIsCharSourceItem { get; set; }
            public bool FIsEquipment { get; set; }
            public bool FIsFix { get; set; }
            public bool FIsFixedReOrder { get; set; }
            public bool FIsKeyItem { get; set; }
            public bool FISKFPeriod { get; set; }
            public bool FIsManage { get; set; }
            public bool FIsSale { get; set; }
            public bool FIsSNManage { get; set; }
            public bool FIsSparePart { get; set; }
            public bool FIsSpecialTax { get; set; }
            public int FKanBanCapability { get; set; }
            public int FKFPeriod { get; set; }
            public object FLastCheckDate { get; set; }
            public string FLeadTime { get; set; }
            public int FLenDecimal { get; set; }
            public int FLength { get; set; }
            public int FLowLimit { get; set; }
            public bool FMakeFile { get; set; }
            public Fmanagetype FManageType { get; set; }
            public Fmaund FMaund { get; set; }
            public Fmcvacctid FMCVAcctID { get; set; }
            public object FModel { get; set; }
            public object FModelEn { get; set; }
            public bool FMRPCon { get; set; }
            public bool FMRPOrder { get; set; }
            public string FName { get; set; }
            public object FNameEn { get; set; }
            public int FNetWeight { get; set; }
            public object FNote { get; set; }
            public string FNumber { get; set; }
            public int FOIHighLimit { get; set; }
            public int FOILowLimit { get; set; }
            public object FOnlineShopPName { get; set; }
            public object FOnlineShopPNo { get; set; }
            public Forderdept FOrderDept { get; set; }
            public int FOrderInterVal { get; set; }
            public int FOrderPoint { get; set; }
            public int FOrderPrice { get; set; }
            public Forderrector FOrderRector { get; set; }
            public Fordertrategy FOrderTrategy { get; set; }
            public Forderunitid FOrderUnitID { get; set; }
            public Fotherchkmde FOtherChkMde { get; set; }
            public int FOutMachFee { get; set; }
            public Foutmachfeeproject FOutMachFeeProject { get; set; }
            public Fpcvacctid FPCVAcctID { get; set; }
            public int FPickHighLimit { get; set; }
            public int FPickLowLimit { get; set; }
            public int FPieceRate { get; set; }
            public Fpivacctid FPIVAcctID { get; set; }
            public Fplanmode FPlanMode { get; set; }
            public Fplanner FPlanner { get; set; }
            public int FPlanPoint { get; set; }
            public int FPlanPrice { get; set; }
            public Fplantrategy FPlanTrategy { get; set; }
            public Fpohghprcmnytype FPOHghPrcMnyType { get; set; }
            public int FPOHighPrice { get; set; }
            public Fpovacctid FPOVAcctID { get; set; }
            public string FPriceDecimal { get; set; }
            public Fprochkmde FProChkMde { get; set; }
            public Fproductdesigner FProductDesigner { get; set; }
            public Fproductprincipal FProductPrincipal { get; set; }
            public Fproductunitid FProductUnitID { get; set; }
            public int FProfitRate { get; set; }
            public bool FPutInteger { get; set; }
            public string FQtyDecimal { get; set; }
            public int FQtyMax { get; set; }
            public int FQtyMin { get; set; }
            public int FRequirePoint { get; set; }
            public Fsaleacctid FSaleAcctID { get; set; }
            public int FSalePrice { get; set; }
            public Fsaleunitid FSaleUnitID { get; set; }
            public Fsampstdcritical FSampStdCritical { get; set; }
            public Fsampstdslight FSampStdSlight { get; set; }
            public Fsampstdstrict FSampStdStrict { get; set; }
            public int FSecCoefficient { get; set; }
            public int FSecInv { get; set; }
            public object FSecondUnit { get; set; }
            public int FSecondUnitRate { get; set; }
            public Fsecunitid FSecUnitID { get; set; }
            public int FSize { get; set; }
            public Fslacctid FSLAcctID { get; set; }
            public Fsochkmde FSOChkMde { get; set; }
            public int FSOHighLimit { get; set; }
            public int FSOLowLimit { get; set; }
            public int FSOLowPrc { get; set; }
            public Fsolowprcmnytype FSOLowPrcMnyType { get; set; }
            public Fsource FSource { get; set; }
            public FSPID FSPID { get; set; }
            public Fspidready FSPIDReady { get; set; }
            public int FStandardCost { get; set; }
            public int FStandardManHour { get; set; }
            public bool FStartService { get; set; }
            public int FStdBatchQty { get; set; }
            public int FStdFixFeeRate { get; set; }
            public int FStdPayRate { get; set; }
            public int FStkChkAlrm { get; set; }
            public Fstkchkmde FStkChkMde { get; set; }
            public int FStkChkPrd { get; set; }
            public bool FStockTime { get; set; }
            public Fstoreunitid FStoreUnitID { get; set; }
            public int FTaxRate { get; set; }
            public int FTotalTQQ { get; set; }
            public Ftrack FTrack { get; set; }
            public int FTtermOfService { get; set; }
            public int FTtermOfUsefulTime { get; set; }
            public Ftypeid FTypeID { get; set; }
            public Funitgroupid FUnitGroupID { get; set; }
            public Funitid FUnitID { get; set; }
            public int FUnitPackageNumber { get; set; }
            public Fusestate FUseState { get; set; }
            public object FVersion { get; set; }
            public int FWeightDecimal { get; set; }
            public int FWidth { get; set; }
            public Fwthdrwchkmde FWthDrwChkMde { get; set; }
            public Fwwchkmde FWWChkMde { get; set; }
            public int FWWHghPrc { get; set; }
            public Fwwhghprcmnytype FWWHghPrcMnyType { get; set; }
        }

        public class F_111
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Facctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fadminacctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fapacctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fauxclassid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fbackflushspid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fbackflushstockid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fcavacctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fcbappendproject
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fcbrouting
        {
            public string FBillNo { get; set; }
            public string FRoutingName { get; set; }
        }

        public class Fcharsourceitemid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fcheckcycunit
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fcostacctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fcostbomid
        {
            public string FBOMNumber { get; set; }
        }

        public class Fcostproject
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fctrlstraregy
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fctrltype
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fcubicmeasure
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fdefaultloc
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fdefaultreadyloc
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fdefaultroutingid
        {
            public string FBillNo { get; set; }
            public string FRoutingName { get; set; }
        }

        public class Fdefaultworktypeid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fdsmanagerid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Ferpclsid
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fgoodspec
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fhsnumber
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fidentifier
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Finspectionlevel
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Finspectionproject
        {
            public string FBillNo { get; set; }
            public string FSchemeName { get; set; }
        }

        public class Fmanagetype
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fmaund
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fmcvacctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Forderdept
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Forderrector
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fordertrategy
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Forderunitid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fotherchkmde
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Foutmachfeeproject
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fpcvacctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fpivacctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fplanmode
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fplanner
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fplantrategy
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fpohghprcmnytype
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fpovacctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fprochkmde
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fproductdesigner
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fproductprincipal
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fproductunitid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fsaleacctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fsaleunitid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fsampstdcritical
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fsampstdslight
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fsampstdstrict
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fsecunitid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fslacctid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fsochkmde
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fsolowprcmnytype
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fsource
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class FSPID
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fspidready
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fstkchkmde
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fstoreunitid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Ftrack
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Ftypeid
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Funitgroupid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Funitid
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

        public class Fusestate
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fwthdrwchkmde
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fwwchkmde
        {
            public string FID { get; set; }
            public string FName { get; set; }
        }

        public class Fwwhghprcmnytype
        {
            public string FName { get; set; }
            public string FNumber { get; set; }
        }

    }
}
