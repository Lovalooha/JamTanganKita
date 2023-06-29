using finalProject.Controllers;
using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject.Views
{
	public partial class CartPage1 : System.Web.UI.Page
	{
		CartController cartC = new CartController();
		CustomerController customerC = new CustomerController();
		WatchDetailController watchdetailC = new WatchDetailController();
		protected void Page_Load(object sender, EventArgs e)
		{
			int CustomerID = Convert.ToInt32(Request.QueryString["CustomerID"]);
			//CustomerID = 4;

			if (!IsPostBack)
			{
				GridViewCart.DataSource = cartC.getWatchDetailCart(CustomerID);
				GridViewCart.DataBind();
			}
		}

		protected void checkoutBtn_Click(object sender, EventArgs e)
		{
			int CustomerID = Convert.ToInt32(Request.QueryString["CustomerID"]);
			//CustomerID = 4;

			cartC.CheckOut(CustomerID);
			Response.Redirect("~/Views/Home/Home.aspx?Id=" + CustomerID);
		}

		protected void GridViewCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
		{
			int CustomerID = Convert.ToInt32(Request.QueryString["CustomerID"]);
			//customerID = 4;

			GridViewRow row = GridViewCart.Rows[e.RowIndex];
			String ID = row.Cells[0].Text;
			int watchdetailID = Convert.ToInt32(ID);

			cartC.RemoveCart(CustomerID, watchdetailID);
			GridViewCart.DataBind();
			Response.Redirect("~/Views/CartPage.aspx?CustomerID=" + CustomerID);
		}
	}
}