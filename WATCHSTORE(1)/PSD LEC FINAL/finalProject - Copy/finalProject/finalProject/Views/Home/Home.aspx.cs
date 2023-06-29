using finalProject.Controllers;
using finalProject.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject.Views.Home
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		WatchController watchC = new WatchController();
		protected void Page_Load(object sender, EventArgs e)
		{

			if (Request.Cookies["RememberMe"] != null && Session["customer"] == null)
			{
				int CustomerID = Convert.ToInt32(Request.Cookies["RememberMe"].Value);
				Customer c = CustomerController.GetProfile(CustomerID);
				Session["customer"] = c;
			}

			if(Session["customer"] != null && ((Customer)Session["customer"]).CustomerRole.Equals("ADMIN"))
			{
				insertBtn.Visible = true;
			}
			
			if (!IsPostBack)
			{
					CardRepeater.DataSource = watchC.getAllWatch();
					CardRepeater.DataBind();

				CardRepeater1.DataSource = watchC.getAllWatch();
				CardRepeater1.DataBind();
			}
		}
		protected void BindData()
		{
			CardRepeater.DataSource = watchC.getAllWatch();
			CardRepeater.DataBind();

			CardRepeater1.DataSource = watchC.getAllWatch();
			CardRepeater1.DataBind();
		}

		protected void updateBtn_Click(object sender, EventArgs e)
		{
			Button deleteBtn = (Button)sender;
			int id = Convert.ToInt32(deleteBtn.CommandArgument);
			Response.Redirect("~/Views/UpdateWatch.aspx?id=" + id);
		}

		protected void deleteBtn_Click(object sender, EventArgs e)
		{
			Button deleteBtn = (Button)sender;
			int id = Convert.ToInt32(deleteBtn.CommandArgument);


			string path = Server.MapPath("~/Assets/Watch/" + watchC.getWatch(id).WatchImage);
			FileInfo file = new FileInfo(path);
			if (file.Exists)
			{
				file.Delete();
			}
			List<WatchDetail> watchdetailList = WatchDetailController.getWatchDetailList(id); 

			foreach(WatchDetail watchdetail in watchdetailList)
			{
				string pathWatchDetail = Server.MapPath("~/Assets/WatchDetail/" + watchdetail.WatchImage);
				FileInfo fileWatchDetail = new FileInfo(pathWatchDetail);
				if (fileWatchDetail.Exists)
				{
					fileWatchDetail.Delete();
				}
			}

			
			watchC.delete(id);
			BindData();
			Response.Redirect("~/Views/Home/Home.aspx");
		}

		protected void CardRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
		{
			//if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
			//{
			//	Button deleteBtn = e.Item.FindControl("deleteBtn") as Button;

			//	if (deleteBtn != null)
			//	{
			//		deleteBtn.Click += deleteBtn_Click;
			//	}
			//}

			if((Session["customer"] != null && ((Customer)Session["customer"]).CustomerRole.Equals("CUST")) || Session["customer"] == null)
			{
				(e.Item.FindControl("updateBtn") as Control).Visible = false;
				(e.Item.FindControl("deleteBtn") as Control).Visible = false;
			}

		}

		protected void insertBtn_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/Views/InsertWatch.aspx");
		}

        protected void watchCard_Click(object sender, EventArgs e)
        {
			LinkButton watchCard = (LinkButton)sender;
			string id = watchCard.CommandArgument;

			int customerID = Convert.ToInt32(((Customer)Session["customer"]).CustomerID);
			Response.Redirect("~/Views/WatchDetailDetail.aspx?Id=" + id + "&customerID=" + customerID);
		}

		protected void CardRepeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
		{
			if ((Session["customer"] != null && ((Customer)Session["customer"]).CustomerRole.Equals("CUST")) || Session["customer"] == null)
			{
				(e.Item.FindControl("updateBtn1") as Control).Visible = false;
				(e.Item.FindControl("deleteBtn1") as Control).Visible = false;
			}
		}
	}
}