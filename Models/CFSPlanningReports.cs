namespace ConnectWithDBContext.Models
{
    public class CFSPlanningReports
    {
        public int Id { get; set; }
        public string Order_Number { get; set; }
        public string Customer_Na { get; set; }
        public string Description { get; set; }
        public string QTY { get; set; }
        public string HOC_Date { get; set; }
        public string CI_Date { get; set; }
        public string CO_Date { get; set; }
        public string CFS_Order_Status { get; set; }
        public string D { get; set; }
        public string S { get; set; }
        public string FDD { get; set; }
        public string UL_Date { get; set; }
        public string MultipackOrder { get; set; }
        public string PID { get; set; }
        public string WarehouseLocation { get; set; }
        public string PutawayZone { get; set; }
        public string PalletID { get; set; }
        public Nullable<int> CartonQTY { get; set; }
        public string HOD_Date { get; set; }
        public string Part_Number { get; set; }
        public string Item_class { get; set; }
    }
}
