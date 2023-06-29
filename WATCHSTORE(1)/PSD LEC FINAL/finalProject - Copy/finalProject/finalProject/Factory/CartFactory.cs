using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Factory
{
	public class CartFactory
	{
		Database1Entities2 db = new Database1Entities2();

		public static Cart create(int newQty, int watchdetailID, int watchID)
		{
			Cart newCart = new Cart();
			newCart.Qty = newQty;
			newCart.WatchDetailID = watchdetailID;
			newCart.CustomerID = watchID;
			return newCart;
		}
	}
}