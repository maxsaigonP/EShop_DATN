using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;


namespace E_Shop_DATN.Models
{
    public class User
    {
        public int Id { get; set; }
        [DisplayName("Tên")]
        public string Name { get; set; }
        [DisplayName("Tên tài khoản")]
        public string Username { get; set; }
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }
        [DisplayName("Ảnh đại diện")]
        public string Avatar { get; set; }

        [DisplayName("Địa chỉ giao hàng")]
        public string ShipperAddress { get; set; }

        [DisplayName("Ngày cập nhật cuối")]
        public DateTime LastUpdate { get; set; }
        [DisplayName("Trạng thái")]
        public bool Status { get; set; }

        public List<Cart> Carts { get; set; }

        public List<Invoice> Invoices { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
