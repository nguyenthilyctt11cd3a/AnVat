using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AnVat_WebTM.Models
{
    public class SPcontext : DbContext
    {
        public SPcontext() : base("AnVat")
        { }
        public DbSet<LoaiSP> LoaiSP { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
    }
}
