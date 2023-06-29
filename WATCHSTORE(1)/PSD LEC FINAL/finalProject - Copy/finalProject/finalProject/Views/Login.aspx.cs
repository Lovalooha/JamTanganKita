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
	public partial class Login1 : System.Web.UI.Page
	{
        Database1Entities2 db = new Database1Entities2();
        protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
            lblError.Text = "";
            if (db.Customers.Any(x => x.CustomerEmail == txtEmail.Text))
            {
                if (db.Customers.Any(x => x.CustomerEmail == txtEmail.Text && x.CustomerPassword == txtPassword.Text))
                {
                    Customer c;
                    c = (from x in db.Customers where x.CustomerEmail.Equals(txtEmail.Text) && x.CustomerPassword.Equals(txtPassword.Text) select x).FirstOrDefault();
                    
                    if (CheckBox1.Checked)
                    {
                        HttpCookie cookie = new HttpCookie("RememberMe");
                        cookie.Value = c.CustomerID.ToString();
                        cookie.Expires = DateTime.Now.AddHours(24);
                        Response.Cookies.Add(cookie);
                        Session["customer"] = c;
                        Response.Redirect("~/Views/Home/Home.aspx?watchID=" + c.CustomerID);


                        return;
                    }
                    else
                    {
                        Session["customer"] = c;
                        Response.Redirect("~/Views/Home/Home.aspx?watchID=" + c.CustomerID);
                        return;
                    }
                }
                else
                {
                    Customer c;
                    c = (from x in db.Customers where x.CustomerEmail.Equals(txtEmail.Text) && x.CustomerPassword.Equals(txtPassword.Text) select x).FirstOrDefault();

                    lblError.Text = "Password does not match ";
                    return;
                }
            }
            else
            {
                lblError.Text = "Email not found";
                return;
            }
        }
	}
}