using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AnVat_WebTM.Models
{
    public class SanPham
    {
        [ScaffoldColumn(false)]
        public int MaSP { get; set; }
        [Required, StringLength(100), Display(Name = "TenSP")]
        public string TenSP { get; set; }
        [Required, StringLength(1000), Display(Name = "Gioi Thieu"),
        DataType(DataType.MultilineText)]
        public string GioiThieu { get; set; }
        public string Anh { get; set; }
        [Display(Name = "GiaTien")]
        public float? GiaTien { get; set; }
        public int? MaLoai { get; set; }
        public virtual LoaiSP LoaiSP { get; set; }
    }
}