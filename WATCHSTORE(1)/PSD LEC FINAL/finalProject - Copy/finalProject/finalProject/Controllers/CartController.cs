using finalProject.Handler;
using finalProject.Model;
using finalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Controllers
{
    public class CartController
    {
        Database1Entities2 db = new Database1Entities2();
        CartRepository repo = new CartRepository();
        CartHandler handler = new CartHandler();

        public CartController()
        {

        }

        public void RemoveCart(int customerID, int watchdetailID)
        {
            handler.RemoveCart(customerID, watchdetailID);
            return;
        }

        public List<Cart> getAllCart()
        {
            return handler.getAllCart();
        }

        public dynamic getWatchDetailCart(int id)
        {
            return handler.getWatchDetailCart(id);
        }

        public Cart getCart(int id)
        {
            return handler.getCart(id);
        }

        public void validateCart(string textQuantity, int WatchStock, out string errorMessage, int watchdetailID, int customerID)
        {
            errorMessage = "";
            if (textQuantity.Length == 0)
            {
                errorMessage = "Must be filled and can't be more than the stock ";
                return;
            }
            int quantity = Convert.ToInt32(textQuantity);
            if (quantity > WatchStock)
            {
                errorMessage = "Can't be more than the stock";
                return;
            }
            if (CartHandler.GetCartById(watchdetailID, customerID) == null)
            {
                handler.insert(quantity, watchdetailID, customerID);
            }
            else
            {
                handler.update(quantity, watchdetailID, customerID);
                return;
            }
            return;
        }

        public void CheckOut(int CustomerID)
        {
            List<Cart> carts = CartRepository.GetAllCartsOnly(CustomerID);

            if (carts.Count == 0)
            {
                return;
            }

            handler.looping(carts, CustomerID);

        }

    }


}