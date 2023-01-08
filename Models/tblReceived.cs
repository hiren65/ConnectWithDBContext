namespace ConnectWithDBContext.Models
{
    public class Received
    {
        public int Id { get; set; }

        public DateTime? ReceivedDate { get; set; }

        public short? ReceivedQty { get; set; }

        public short? Monitors { get; set; }

        public short? Eports { get; set; }

        public short? Miscellaneous { get; set; }

        public int OrderNumber { get; set; }

        public string SI { get; set; }

        public string? CustomerName { get; set; }

        public string? OparatorCode { get; set; }

        public string? TypeDeviceForSevice { get; set; }

        public string? Product_Line_Desc { get; set; }

        public int? Order_Count { get; set; }

        public string? HOC_Date { get; set; }
    }
}
