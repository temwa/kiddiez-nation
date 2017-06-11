using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nation1.Models;

namespace Nation1.Logic
{
    public class WishlistCartActions : IDisposable
    {
        public string WishlistId { get; set; }

        private ProductContext _db = new ProductContext();

        public const string WishSessionKey = "WishId";

        public void AddToWish(int id)
        {
            //Retrieve the product from the database.
            WishlistId = GetWishId();

            var wishItem = _db.WishlistItems.SingleOrDefault(
                c => c.WishId == WishlistId 
                && c.ProductId == id);
            if(wishItem == null)
            {
                //Create a new wishlis item if no wishlist items exists.
                wishItem = new WishItem
                {
                    ItemId = Guid.NewGuid().ToString(), ProductId = id, WishId = WishlistId, Product = _db.Products.SingleOrDefault(p => p.ProductID == id), Quantity = 1, DateCreated = DateTime.Now
                };

                _db.WishlistItems.Add(wishItem);
            }
            else
            {
                // If the item does exist in the wishlist,
                //then add one to the quantity.
                wishItem.Quantity++;
            }
            _db.SaveChanges();
        }

        public void Dispose()
        {
            if(_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }

        public string GetWishId()
        {
            if(HttpContext.Current.Session[WishSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[WishSessionKey] = HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class.
                    Guid tempWishId = Guid.NewGuid();
                    HttpContext.Current.Session[WishSessionKey] = tempWishId.ToString();
                }
            }
            return HttpContext.Current.Session[WishSessionKey].ToString();
        }

        public List<WishItem> GetWishItems()
        {
            WishlistId = GetWishId();
            return _db.WishlistItems.Where(
                c => c.WishId == WishlistId).ToList();
        }

        public decimal GetTotal()
        {
            WishlistId = GetWishId();
            // Multiply product price by quantity of that product to get
            // the current price for each of those products in the cart.
            // Sum all product price totals to get the cart total.
            decimal? total = decimal.Zero;
            total = (decimal?)(from wishItems in _db.WishlistItems
                               where wishItems.WishId == WishlistId
                               select (int?)wishItems.Quantity *
                                wishItems.Product.UnitPrice).Sum();
            return total ?? decimal.Zero;
        }

        public WishlistCartActions GetWish(HttpContext context)
        {
            using (var wish = new WishlistCartActions())
            {
                wish.WishlistId = wish.GetWishId();
                return wish;
            }
        }

        public void UpdateWishlistCartDatabase(String wishId, WishlistUpdates[] WishItemUpdates)
        {
            using(var db = new Nation1.Models.ProductContext())
            {
                try
                {
                    int WishItemCount = WishItemUpdates.Count();
                    List<WishItem> myWish = GetWishItems();
                    foreach (var wishItem in myWish)
                    {
                        //Iterate through all rows within shopping cart list
                        for(int i = 0; i < WishItemCount; i++)
                        {
                            if(wishItem.Product.ProductID == WishItemUpdates[i].ProductId)
                            {
                                if(WishItemUpdates[i].WishQuantity < 1 || WishItemUpdates[i].RemoveItem == true)
                                {
                                    RemoveItem(wishId, wishItem.ProductId);
                                }
                                else
                                {
                                    UpdateItem(wishId, wishItem.ProductId, WishItemUpdates[i].WishQuantity);
                                }
                            }
                        }
                    }
                }
                catch(Exception exp)
                {
                    throw new Exception("ERROR: Unable to Update Wishlist Database - " + exp.Message.ToString(), exp);
                }
            }
        }

        public void RemoveItem(string removeWishID, int removeProductID)
        {
            using (var _db = new Nation1.Models.ProductContext())
            {
                try
                {
                    var myItem = (from c in _db.WishlistItems
                                  where c.WishId == removeWishID && c.Product.ProductID == removeProductID
                                  select c).FirstOrDefault();
                    if (myItem != null)
                    {
                        // Remove Item.
                        _db.WishlistItems.Remove(myItem);
                        _db.SaveChanges();
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Remove Cart Item - " + exp.Message.ToString(), exp);
                }
            }
        }
        public void UpdateItem(string updateWishID, int updateProductID, int quantity)
        {
            using (var _db = new Nation1.Models.ProductContext())
            {
                try
                {
                    var myItem = (from c in _db.WishlistItems
                                  where c.WishId == updateWishID && c.Product.ProductID == updateProductID
                                  select c).FirstOrDefault();
                    if (myItem != null)
                    {
                        myItem.Quantity = quantity;
                        _db.SaveChanges();
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Update Cart Item - " + exp.Message.ToString(), exp);
                }
            }
        }

        public void EmptyCart()
        {
            WishlistId = GetWishId();
            var wishItems = _db.WishlistItems.Where(
            c => c.WishId == WishlistId);
            foreach (var wishItem in wishItems)
            {
                _db.WishlistItems.Remove(wishItem);
            }
            // Save changes.
            _db.SaveChanges();
        }

        public int GetCount()
        {
            WishlistId = GetWishId();
            // Get the count of each item in the wishlist and sum them up
            int? count = (from wishItems in _db.WishlistItems
                          where wishItems.WishId == WishlistId
                          select (int?)wishItems.Quantity).Sum();
            // Return 0 if all entries are null
            return count ?? 0;
        }

        public struct WishlistUpdates
        {
            public int ProductId;
            public int WishQuantity;
            public bool RemoveItem;
        }
    }
}