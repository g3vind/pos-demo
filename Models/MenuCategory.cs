using SQLite;

namespace pos_demo.Models
{
    public class MenuCategory
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Icon { get; set; } = "";
    }
}
