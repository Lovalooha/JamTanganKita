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
	public partial class UpdateProfile1 : System.Web.UI.Page
	{
		Database1Entities2 db = new Database1Entities2();
		CustomerController cc = new CustomerController();
		protected void Page_Load(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(Request.QueryString["CustomerID"]);

			
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(Request.QueryString["CustomerID"]);

			string name = txtName.Text;
			string email = txtEmail.Text;
			string address = txtAddress.Text;
			string password = txtPass.Text;
			string gender = rblGender.SelectedValue;
			//Response.Write(gender);

			string errorMessage = string.Empty;

			cc.validateUpdateCustomer(id, name, email, address, password, gender, out errorMessage);

			lblError.Text = errorMessage;
		}
	}
}