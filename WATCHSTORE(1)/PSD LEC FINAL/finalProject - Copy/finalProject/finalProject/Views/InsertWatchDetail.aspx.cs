using finalProject.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject.Views
{
	public partial class InsertWatchDetail1 : System.Web.UI.Page
	{
		WatchDetailController watchdetailC = new WatchDetailController();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
            string name = txtName.Text;
            string description = txtDescription.Text;
            string image = "";
            string price = txtPrice.Text;
            string stock = txtStock.Text;
            // Error price & stockc;
            //tinggal price sm sstock yg perlu di masukkin param

            string errorMessage = string.Empty;

            //validateInsertAlbum(string name, string description, int price, int stock, FileUpload image, out string errorMessage, string artistID)

            image = FileUpload1.PostedFile.FileName;
            string ID = Request.QueryString["id"];

            bool vals = watchdetailC.validateInsertWatchDetail(name, description, price, stock, FileUpload1, out errorMessage, ID);

            if (vals)
            {
                FileUpload1.SaveAs(Server.MapPath("~/Assets/WatchesDetail/") + image);
                Response.Redirect("~/Views/Home/Home.aspx");
            }

            lblError.Text = errorMessage;



        }
	}
}