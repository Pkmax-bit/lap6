using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace lap6.Models
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public int MaHH { get; set; }
        [MaxLength(50)]
        public string TenHH { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        [MaxLength(150)]
        public string Hinh { get; set; }
        public int? MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public Loai? Loai { get; set; }
    }
}
