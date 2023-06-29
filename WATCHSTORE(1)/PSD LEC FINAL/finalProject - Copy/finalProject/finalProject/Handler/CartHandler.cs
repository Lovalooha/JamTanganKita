using finalProject.Model;
using finalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Handler
{
    public class CartHandler
    {
        Database1Entities2 db = new Database1Entities2();
        CartRepository repo = new CartRepository();
        public CartHandler()
        {

        }

        public static dynamic GetCartById(int customerID, int watchdetailID)
        {
            return CartRepository.GetCartById(customerID, watchdetailID);
        }

        public void RemoveCart(int customerID, int watchdetailID)
        {
            repo.RemoveCart(customerID, watchdetailID);
            return;
        }
        public List<Cart> getAllCart()
        {
            return repo.getAllCart();
        }
        public dynamic getWatchDetailCart(int id)
        {
            return repo.getWatchDetailCart(id);
        }
        public Cart getCart(int id)
        {
            return repo.getCart(id);
        }

        //repo.insert(quantity, albumID, customerID);

        public void insert(int quantity, int watchdetailID, int customerID)
        {
            repo.insert(quantity, watchdetailID, customerID);
        }
        public void update(int quantity, int watchdetailID, int customerID)
        {
            repo.update(quantity, watchdetailID, customerID);
        }

        public void looping(List<Cart> carts, int CustomerID)
        {
            int TransactionID = TransactionHeaderRepository.insert(DateTime.Now, CustomerID);
            foreach (Cart x in carts)
            {
                int Qty = x.Qty;
                WatchDetail watchdetail = WatchDetailRepository.getWatchDetail(x.WatchDetailID);
                WatchDetailRepository.updateStock(watchdetail.WatchDetailID, watchdetail.WatchStock - Qty);

                TransactionDetailRepository.insert(TransactionID, x.WatchDetailID, Qty);
            }

            repo.RemoveAllCarts(CustomerID);
        }
    }
}