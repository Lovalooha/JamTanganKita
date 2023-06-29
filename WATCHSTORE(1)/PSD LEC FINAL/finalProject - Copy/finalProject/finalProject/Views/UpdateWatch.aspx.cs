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
	public partial class UpdateWatch1 : System.Web.UI.Page
	{
		WatchController watchC = new WatchController();
		protected void Page_Load(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(Request.QueryString["id"]);

			Watch watch = watchC.getWatch(id);

			Image1.ImageUrl = "~/Assets/Watches/" + watch.WatchImage;
			Label1.Text = watch.WatchName;
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			string errorMessage = string.Empty;
			string image = "";
			int id = Convert.ToInt32(Request.QueryString["ID"]);

			image = FileUpload1.PostedFile.FileName;

			bool vals = watchC.validateUpdateWatch(id, name, FileUpload1, out errorMessage);

			if (vals)
			{
				FileUpload1.SaveAs(Server.MapPath("~/Assets/Watches/") + image);
				Response.Redirect("~/Views/Home/Home.aspx");
			}

			lblError.Text = errorMessage;
		}
	}
}