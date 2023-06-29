using finalProject.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject.Views
{
	public partial class InsertWatch1 : System.Web.UI.Page
	{
		WatchController watchC = new WatchController();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			string errorMessage = string.Empty;
			string image = "";


			image = FileUpload1.PostedFile.FileName;

			bool vals = watchC.validateInsertWatch(name, FileUpload1, out errorMessage);

			if (vals)
			{
				FileUpload1.SaveAs(Server.MapPath("~/Assets/Watches/") + image);
			}

			lblError.Text = errorMessage;
		}
	}
}