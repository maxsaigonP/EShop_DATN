using E_Shop_DATN.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop_DATN.Models
{
    public class Admins
    {
        public int Id { get; set; }

        [DisplayName("Tên")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string FullName { get; set; }
        [DisplayName("Tên tài khoản")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Username { get; set; }
        [DisplayName("Mật khảu")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Password { get; set; }
        [DisplayName("Địa chỉ email")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống")]
        [DisplayName("Số điện thoại")]

        public string Phone { get; set; }
        [DisplayName("Ảnh đại diện")]

        public string? Avatar { get; set; }
    

        public bool IsAdmin { get; set; }
        [DisplayName("Trạng thái")]
        public bool Status { get; set; }
    
        public List<ImportedInvoice> ImporedtInvoices { get; set; }

    }
}
