using System.ComponentModel.DataAnnotations;
namespace NguyenKimmanh_241230790.Models
{
    public class SachCreateViewModel
    {
        [Required(ErrorMessage = "Vui lòng chọn thể loại")]
        public int? MaTl { get; set; }

        [Required(ErrorMessage = "Tên sách không được để trống")]
        public string TenSach { get; set; } = string.Empty;

        [Required(ErrorMessage = "Giá không được để trống")]
        [Range(typeof(decimal), "50", "1000",
            ErrorMessage = "Giá phải từ 50 đến 1000")]
        public decimal? Gia { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên ảnh")]
        [RegularExpression(
            @"(?i)^.+\.(jpg|jpeg|png|webp)$",
            ErrorMessage = "Ảnh phải có đuôi jpg, jpeg, png hoặc webp")]
        public string Anh { get; set; } = string.Empty;
    }
}

