using SQLite;

namespace pos_demo.Data
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
