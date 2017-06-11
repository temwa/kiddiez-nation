using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nation1.Models;
using Nation1.Logic;
using System.Collections.Specialized;

namespace Nation1
{
    public partial class WishlistCart : System.Web.UI.Page
    {
        private ProductContext _db = new ProductContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            using (WishlistCartActions usersWishlistCart = new WishlistCartActions())
            {
                decimal wishTotal = 0;
                wishTotal = usersWishlistCart.GetTotal();
                if (wishTotal > 0)
                {
                    // Display Total.
                    lblTotal.Text = String.Format("{0:c}", wishTotal);
                }
                else
                {
                    LabelTotalText.Text = "";
                    lblTotal.Text = "";
                    WishlistCartTitle.InnerText = "Wish List is Empty";
                    UpdateBtn.Visible = false;
                }
            }
        }

        public List<WishItem> GetWishlistItems()
        {
            WishlistCartActions actions = new WishlistCartActions();
            return actions.GetWishItems();
        }

        public List<WishItem> UpdateWishItems()
        {
            using (WishlistCartActions usersWishlistCart = new WishlistCartActions())
            {
                String wishId = usersWishlistCart.GetWishId();
                WishlistCartActions.WishlistUpdates[] wishUpdates = new WishlistCartActions.WishlistUpdates[WishList.Rows.Count];
                for (int i = 0; i < WishList.Rows.Count; i++)
                {
                    IOrderedDictionary rowValues = new OrderedDictionary();
                    rowValues = GetValues(WishList.Rows[i]);
                    wishUpdates[i].ProductId = Convert.ToInt32(rowValues["ProductID"]);

                    CheckBox cbRemove = new CheckBox();
                    cbRemove = (CheckBox)WishList.Rows[i].FindControl("Remove");
                    wishUpdates[i].RemoveItem = cbRemove.Checked;

                    TextBox quantityTextBox = new TextBox();
                    quantityTextBox = (TextBox)WishList.Rows[i].FindControl("WishQuantity");
                    wishUpdates[i].WishQuantity = Convert.ToInt16(quantityTextBox.Text.ToString());
                }
                usersWishlistCart.UpdateWishlistCartDatabase(wishId, wishUpdates);
                WishList.DataBind();
                lblTotal.Text = String.Format("{0:c}", usersWishlistCart.GetTotal());
                return usersWishlistCart.GetWishItems();
            }
        }

        public static IOrderedDictionary GetValues(GridViewRow row)
        {
            IOrderedDictionary values = new OrderedDictionary();
            foreach (DataControlFieldCell cell in row.Cells)
            {
                if (cell.Visible)
                {
                    // Extract values from the cell.
                    cell.ContainingField.ExtractValuesFromCell(values, cell, row.RowState, true);
                }
            }
            return values;
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateWishItems();
        }
    }
}