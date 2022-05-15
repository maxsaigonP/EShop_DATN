using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DA_TotNghiep.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        [DisplayName("Người dùng")]
        public int UserId { get; set; }

        public User User { get; set; }
        [DisplayName("Ngày lập hoá đơn")]

        public DateTime IssuedDate { get; set; }
        [DisplayName("Địa chỉ giao hàng")]
        public string ShippingAddress { get; set; }
        [DisplayName("Số điện thoại")]

        public string ShippingPhone { get; set; }

        [DisplayName("Tổng hoá đơn (VNĐ)")]
        [DisplayFormat(DataFormatString = "{0:#,##0} VNĐ")]
        public int Total { get; set; }
        [DisplayName("Trạng thái")]

        public bool Status { get; set; }

        [DisplayName("Huỷ đơn")]
        public bool Cancle { get; set; }

        public List<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
