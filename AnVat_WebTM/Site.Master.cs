using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AnVat_WebTM.Models;
//usingAnVat_WebTM.Logic;

namespace AnVat_WebTM
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<LoaiSP> GetLoaiSPs()
        {
            var _db = new AnVat_WebTM.Models.SPcontext();
            IQueryable<LoaiSP> query = _db.LoaiSP;
            return query;
        }

    }
}