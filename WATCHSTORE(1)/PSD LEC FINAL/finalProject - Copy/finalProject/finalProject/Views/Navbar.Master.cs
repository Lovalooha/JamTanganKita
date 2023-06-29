using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject.Views
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			if(Session["customer"] == null) //guest
			{
				loginBtn.Visible = true;
				registerBtn.Visible = true;
				cartBtn.Visible = false;
				logoutBtn.Visible = false;
				transactionHistoryBtn.Visible = false;
				updateProfileBtn.Visible = false;
			}
			else if(Session["customer"] != null && ((Customer)Session["customer"]).CustomerRole.Equals("ADMIN")) // admin
			{
				updateProfileBtn.Visible = false;
				cartBtn.Visible = false;
				transactionHistoryBtn.Visible = true;
				transactionHistoryBtn.Visible = false;
			}
			else //customer
			{
				updateProfileBtn.Visible = true;
			}
        }

		protected void cartBtn_Click(object sender, EventArgs e)
		{
			int CustomerID = Convert.ToInt32(((Customer)Session["customer"]).CustomerID);
			Response.Redirect("~/Views/CartPage.aspx?CustomerID=" + CustomerID);
		}

		protected void logoutBtn_Click(object sender, EventArgs e)
		{
			if (Session["customer"] != null)
			{
				HttpContext.Current.Session.Remove("customer");
			}
			string[] cookies = HttpContext.Current.Request.Cookies.AllKeys;
			foreach (string cookie in cookies)
			{
				HttpContext.Current.Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
			}
			Response.Redirect("~/Views/Login.aspx");
		}

		protected void updateProfileBtn_Click(object sender, EventArgs e)
		{
			int CustomerID = Convert.ToInt32(((Customer)Session["customer"]).CustomerID);
			Response.Redirect("~/Views/UpdateProfile.aspx?CustomerID=" + CustomerID);
		}
	}
}