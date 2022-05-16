using System.ComponentModel;

namespace E_Shop_DATN.Models
{
    public class TradeMark
    {
        public int Id { get; set; }

        [DisplayName("Thương hiệu")]
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
