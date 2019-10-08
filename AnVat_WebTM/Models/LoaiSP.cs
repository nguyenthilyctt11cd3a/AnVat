using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace AnVat_WebTM.Models
{
    public class LoaiSP
    {
        [ScaffoldColumn(false)]
        public int MaLoai { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string TenLoai { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}