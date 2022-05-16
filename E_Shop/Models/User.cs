using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DA_TotNghiep.Models
{
    public class User
    {
        public int Id { get; set; }
        [DisplayName("Tên")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Name { get; set; }
        [DisplayName("Tên tài khoản")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Username { get; set; }
        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Password { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống")]
        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }
        [DisplayName("Ảnh đại diện")]
        
        public string? Avatar { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống")]
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
