using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using AnVat_WebTM.Models;
using System.Web.ModelBinding;

namespace AnVat_WebTM
{
    public partial class SPList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<LoaiSP> GetBooks([QueryString("id")] int? Maloai)
        {
            var _db = new AnVat_WebTM.Models.SPcontext();
            IQueryable<LoaiSP> query = _db.LoaiSP;
            if (Maloai.HasValue && Maloai > 0)
            {
                query = query.Where(p => p.MaLoai == Maloai);
            }
            return query;
        }
    }
}