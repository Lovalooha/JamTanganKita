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
	public partial class TransactionHistory1 : System.Web.UI.Page
	{
		int customerID;
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				customerID = ((Customer)Session["customer"]).CustomerID;
				GridViewHistory.DataSource = TransactionHeaderController.GetAllCustomerTransactionDetail(customerID);
				GridViewHistory.DataBind();
			}
		}

	}
}