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
    public partial class NannyList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Nanny> GetNannies()
        {
            var _db = new Nation1.Models.NannyContext();
            IQueryable<Nanny> query = _db.Nannies;
            return query;
        }
    }
}