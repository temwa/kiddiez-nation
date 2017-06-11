using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nation1.Models;
using System.Web.ModelBinding;

namespace Nation1
{
    public partial class NannyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Nanny> GetNanny([QueryString("nannyID")] int? nannyId)
        {
            var _db = new Nation1.Models.NannyContext();
            IQueryable<Nanny> query = _db.Nannies;
            if(nannyId.HasValue && nannyId > 0)
            {
                query = query.Where(p => p.NannyID == nannyId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}