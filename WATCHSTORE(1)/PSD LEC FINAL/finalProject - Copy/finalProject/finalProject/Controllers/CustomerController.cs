using finalProject.Handler;
using finalProject.Model;
using finalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace finalProject.Controllers
{
	public class CustomerController
	{
		Database1Entities2 db = new Database1Entities2();

		public void validateCustomer(string name,string email,string address,string password,string gender, out string errorMessage)
		{
            //validate password pattern
            string pattern = "^(?=.*[a-zA-Z])(?=.*\\d).+$";
            Regex regex = new Regex(pattern);
            errorMessage = "";

            if (name.Length == 0)
            {
                errorMessage = "Name must be filled";
                return;
            }
            else if (name.Length < 5 || name.Length > 50)
            {
                errorMessage = "Name Must be filled and between 5 and 50 characters";
                return;
            }
            else if (email.Length == 0)
            {
                errorMessage = "Email Must be filled";
                return;
            }
            else if (db.Customers.Any(x => x.CustomerEmail == email))
            {
                errorMessage = "Email must be unique among the customer’s email";
                return;
            }
            else if (gender.Length == 0)
            {
                errorMessage = "Gender must be selected";
                return;
            }
            else if (address.Length == 0)
            {
                errorMessage = "Address must be filled";
                return;
            }
            else if (!address.EndsWith("Street"))
            {
                errorMessage = "Address must be ends with 'Street' ";
                return;
            }
            else if (password.Length == 0)
            {
                errorMessage = "Password must be filled";
                return;
            }
            else if (!regex.IsMatch(password))
            {
                errorMessage = "Password must be alphanumeric";
                return;
            }
            else
            {
                CustomerHandler.insert(name, email, password, gender, address, "CUST");
                return;
            }
        }

        public void validateUpdateCustomer(int id, string name, string email, string address, string password, string gender, out string errorMessage)
        {
            //validate password pattern
            string pattern = "^(?=.*[a-zA-Z])(?=.*\\d).+$";
            Regex regex = new Regex(pattern);
            errorMessage = "";

            if (name.Length == 0)
            {
                errorMessage = "Name must be filled";
                return;
            }
            else if (name.Length < 5 || name.Length > 50)
            {
                errorMessage = "Name Must be filled and between 5 and 50 characters";
                return;
            }
            else if (email.Length == 0)
            {
                errorMessage = "Email Must be filled";
                return;
            }
            else if (db.Customers.Any(x => x.CustomerEmail == email))
            {
                errorMessage = "Email must be unique among the customer’s email";
                return;
            }
            else if (gender.Length == 0)
            {
                errorMessage = "Gender must be selected";
                return;
            }
            else if (address.Length == 0)
            {
                errorMessage = "Address must be filled";
                return;
            }
            else if (!address.EndsWith("Street"))
            {
                errorMessage = "Address must be ends with 'Street' ";
                return;
            }
            else if (password.Length == 0)
            {
                errorMessage = "Password must be filled";
                return;
            }
            else if (!regex.IsMatch(password))
            {
                errorMessage = "Password must be alphanumeric";
                return;
            }
            else
            {
                CustomerHandler.update(id, name, email, password, gender, address);
                return;
            }
        }

        public static Customer GetProfile(int id)
        {
          id = Convert.ToInt32(id);
            return CustomerHandler.GetProfile(id);
        }

    }
}