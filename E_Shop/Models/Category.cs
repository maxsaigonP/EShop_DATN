using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DA_TotNghiep.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int TotalProduct { get; set; }

        public bool Status { get; set; }
        public List<Product> Products { get; set; }
        
    }
}
