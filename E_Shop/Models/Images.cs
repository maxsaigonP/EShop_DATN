using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace DA_TotNghiep.Models
{
    public class Images
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Image {get;set;}

        [DisplayName("Sản phẩm")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public int ProductId { get; set;}
        public Product Product { get; set;}
    }
}
