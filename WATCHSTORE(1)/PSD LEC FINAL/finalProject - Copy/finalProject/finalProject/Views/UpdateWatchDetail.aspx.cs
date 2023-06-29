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
	public partial class UpdateWatchDetail : System.Web.UI.Page
	{
		WatchDetailController watchdetailC = new WatchDetailController();
		protected void Page_Load(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(Request.QueryString["id"]);

			WatchDetail watchdetail = WatchDetailController.getWatchDetail(id);

			Image1.ImageUrl = "~/Assets/WatchesDetail/" + watchdetail.WatchImage;
			LabelName.Text = watchdetail.WatchName;
			LabelDescription.Text = watchdetail.WatchDescription;
			LabelPrice.Text = watchdetail.WatchPrice.ToString();
			LabelStock.Text = watchdetail.WatchStock.ToString();
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			string errorMessage = string.Empty;
			string image = "";
			string description = txtDescription.Text;
			string price = txtPrice.Text;
			string stock = txtStock.Text;			

			int id = Convert.ToInt32(Request.QueryString["ID"]);
			WatchDetail watchdetail = WatchDetailController.getWatchDetail(id);

			image = FileUpload1.PostedFile.FileName;

			bool vals = watchdetailC.validateUpdateWatchDetail(id, name, description, price, stock, FileUpload1, out errorMessage);

			if (vals)
			{
				FileUpload1.SaveAs(Server.MapPath("~/Assets/WatchesDetail/") + image);
				Response.Redirect("~/Views/WatchDetail.aspx?Id=" + watchdetail.WatchID);
			}

			lblError.Text = errorMessage;
		}
	}
}