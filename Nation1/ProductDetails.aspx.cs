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
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Product> GetProduct([QueryString("productID")] int? productId, [RouteData] string productLinkName)
        {
            var _db = new Nation1.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            if (productId.HasValue && productId > 0)
            {
                query = query.Where(p => p.ProductID == productId);
            }
            else if (!String.IsNullOrEmpty(productLinkName))
            {
                query = query.Where(p =>
                    String.Compare(p.ProductLinkName, productLinkName) == 0);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}