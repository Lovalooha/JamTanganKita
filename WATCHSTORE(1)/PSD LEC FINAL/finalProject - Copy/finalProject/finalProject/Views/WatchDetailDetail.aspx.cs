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
	public partial class WatchDetailDetail1 : System.Web.UI.Page
	{
		CartController cartC = new CartController();
		protected void Page_Load(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(Request.QueryString["Id"]);

			WatchDetail watchdetail = WatchDetailController.getWatchDetail(id);

			Image1.ImageUrl = "~/Assets/WatchesDetail/" + watchdetail.WatchImage;
			lblName.Text = watchdetail.WatchName;
			lblDescription.Text = watchdetail.WatchDescription;
			lblPrice.Text = "Rp. " + watchdetail.WatchPrice.ToString();
			//lblPrice.Text = watchdetail.WatchPrice.ToString();
			lblStock.Text = watchdetail.WatchStock.ToString();
	

			if ((Session["customer"] == null) || (Session["customer"] != null && ((Customer)Session["customer"]).CustomerRole.Equals("ADMIN")))
			{
				txtQuantity.Visible = false;
				//lblQuantity.Visible = false;
				btnCart.Visible = false;
			}

		}

		//protected void btnMinus_Click(object sender, EventArgs e)
		//{
		//	TextBox txtQuantity = (TextBox)FindControl("txtQuantity");
		//	int quantity = int.Parse(txtQuantity.Text);
		//	if (quantity > 1)
		//	{
		//		quantity--;
		//		txtQuantity.Text = quantity.ToString();
		//	}
		//}

		//protected void btnPlus_Click(object sender, EventArgs e)
		//{
		//	TextBox txtQuantity = (TextBox)FindControl("txtQuantity");
		//	int quantity = int.Parse(txtQuantity.Text);
		//	quantity++;
		//	txtQuantity.Text = quantity.ToString();
		//}


		protected void btnCart_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(Request.QueryString["Id"]);
			int customerID = Convert.ToInt32(Request.QueryString["customerID"]);
			WatchDetail watchdetail = WatchDetailController.getWatchDetail(id);
			string errorMessage = string.Empty;

			string textQuantity = txtQuantity.Text;
			int WatchStock = watchdetail.WatchStock;
			cartC.validateCart(textQuantity, WatchStock, out errorMessage, id, customerID);

			lblError.Text = errorMessage;

			if(lblError.Text.Length == 0)
			{
				Response.Redirect("~/Views/WatchDetailDetail.aspx?Id="+ id);
			}

		}

	}
}