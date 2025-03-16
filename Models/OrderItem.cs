using SQLite;

namespace pos_demo.Models
{
    public class OrderItem
    {
        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }
        public long OrderId { get; set; }
        public int MenuItemId { get; set; }
        public string MenuItemName { get; set; } = "";
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Icon { get; set; } = "";

        [Ignore]
        public double TotalPrice => Quantity * Price;
    }
}
