using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using Nation1.Logic;

namespace Nation1
{
    public partial class AddToWish : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["ProductID"];
            int productId;
            if(!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out productId))
            {
                using (WishlistCartActions usersWishlistCart = new WishlistCartActions())
                {
                    usersWishlistCart.AddToWish(Convert.ToInt16(rawId));
                }
            }
            else
            {
                Debug.Fail("ERROR : We should never get to AddToWish.aspx without a ProductId.");
                throw new Exception("ERROR : It is illegal to load AddToWish.aspx without setting a ProductId.");
            }
            Response.Redirect("WishlistCart.aspx");
        }
    }
}