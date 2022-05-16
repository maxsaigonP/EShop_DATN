﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DA_TotNghiep.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        [DisplayName("Tên danh mục")]
        public string Name { get; set; }
      
        [DisplayName("Số lượng sản phẩm")]
        public int? TotalProduct { get; set; }
        [DisplayName("Trạng thái")]
        public bool Status { get; set; }
        public List<Product> Products { get; set; }
        
    }
}
