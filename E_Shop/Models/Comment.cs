﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DA_TotNghiep.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [DisplayName("Nội dung")]
        public string Content { get; set; }
        [DisplayName("Người dùng")]
        public int UserId { get; set; }
        public User User { get; set; }
        [DisplayName("Thời gian")]
        public DateTime Time { get; set; }
        [DisplayName("Sản phẩm")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [DisplayName("Đánh giá")]
        public int Star { get; set; }
        
        public bool Status { get; set; }
    }
}
