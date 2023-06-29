using finalProject.Factory;
using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Repository
{
    public class CartRepository
    {
        private static Database1Entities2 db = new Database1Entities2();
        public void insert(int Qty, int watchdetailID, int customerID)
        {
            Cart newCart = CartFactory.create(Qty, watchdetailID, customerID);
            db.Carts.Add(newCart);
            db.SaveChanges();
        }
        public void update(int Qty, int watchdetailID, int customerID)
		{
            Cart carts = CartRepository.GetCartById(customerID, watchdetailID);
            carts.Qty += Qty;
            db.SaveChanges();
		}

        public List<Cart> getAllCart()
        {
            return db.Carts.ToList();
        }

        public Cart getCart(int id)
        {
            return db.Carts.Find(id);
        }

        public static Cart GetCartById(int customerID, int watchdetailID)
		{
            return db.Carts.FirstOrDefault(x => x.CustomerID == customerID && x.WatchDetailID == watchdetailID);
		}

        public dynamic getWatchDetailCart(int id)
        {
            return db.Carts.Join(db.WatchDetails, Cart => Cart.WatchDetailID, WatchDetail => WatchDetail.WatchDetailID, (Cart, WatchDetail) => new
            {
                CustomerID = Cart.CustomerID,
                WatchDetailID = WatchDetail.WatchDetailID,
                WatchName = WatchDetail.WatchName,
                WatchImage = WatchDetail.WatchImage,
                WatchPrice = WatchDetail.WatchPrice,
                Qty = Cart.Qty,
            }).Where(x => x.CustomerID == id).ToList();
        }

        public void RemoveCart(int customerID, int watchdetailID)
        {
            Cart cart = db.Carts.FirstOrDefault(x => x.CustomerID == customerID && x.WatchDetailID == watchdetailID);
            db.Carts.Remove(cart);
            db.SaveChanges();
        }

        public void RemoveAllCarts(int CustomerID)
        {
            List<Cart> removeCarts = CartRepository.GetAllCartsOnly(CustomerID);
            db.Carts.RemoveRange(removeCarts);
            db.SaveChanges();
            return;
        }

        public static dynamic GetAllCarts(int customerID)
        {
            return db.Carts.Join(db.WatchDetails, cart => cart.WatchDetailID, watchdetail => watchdetail.WatchDetailID, (cart, watchdetail) => new
            {
                CustomerID = cart.CustomerID,
                WatchID = cart.WatchDetailID,
                WatchName = watchdetail.WatchName,
                WatchImage = watchdetail.WatchImage,
                WatchPrice = watchdetail.WatchPrice,
                Qty = cart.Qty,
            }).Where(x => x.CustomerID == customerID).ToList();
        }

        public static List<Cart> GetAllCartsOnly(int customerID)
		{
            return db.Carts.Where(x => x.CustomerID == customerID).ToList();
		}
    }
}