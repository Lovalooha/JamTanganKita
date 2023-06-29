using finalProject.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject.Views
{
	public partial class Register : System.Web.UI.Page
	{
		CustomerController cc = new CustomerController();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			string email = txtEmail.Text;
			string address = txtAddress.Text;
			string password = txtPass.Text;
			string gender = rblGender.SelectedValue;
			//Response.Write(gender);

			string errorMessage = string.Empty;

			cc.validateCustomer(name, email, address, password, gender, out errorMessage);

			lblError.Text = errorMessage;
		}
	}
}