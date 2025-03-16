using SQLite;

namespace pos_demo.Models
{
    public class Order
    {
        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public int TotalItemsCount { get; set; }
        public string PaymentMode { get; set; } = "";
    }
}
