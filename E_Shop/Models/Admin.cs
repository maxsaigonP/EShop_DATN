using E_Shop_DATN.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop_DATN.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [DisplayName("Tên")]
        public string FullName { get; set; }
        [DisplayName("Tên tài khoản")]
        public string Username { get; set; }
        [DisplayName("Mật khảu")]
        public string Password { get; set; }
        [DisplayName("Địa chỉ email")]

        public string Email { get; set; }
        [DisplayName("Số điện thoại")]

        public string Phone { get; set; }
        [DisplayName("Ảnh đại diện")]

        public string Avatar { get; set; }
    

        public bool IsAdmin { get; set; }
        [DisplayName("Trạng thái")]
        public bool Status { get; set; }
    
        public List<ImportedInvoice> ImporedtInvoices { get; set; }

    }
}
