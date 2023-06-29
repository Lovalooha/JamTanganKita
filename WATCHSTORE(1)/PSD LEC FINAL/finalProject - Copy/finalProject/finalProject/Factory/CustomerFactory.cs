using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Factory
{
    public class CustomerFactory
    {
        Database1Entities2 db = new Database1Entities2();

        public static Customer create(string newName, string newEmail, string newPassword, string newGender, string newAddress, string newRole)
        {
            Customer newCustomer = new Customer();
            newCustomer.CustomerName = newName;
            newCustomer.CustomerEmail = newEmail;
            newCustomer.CustomerPassword = newPassword;
            newCustomer.CustomerGender = newGender;
            newCustomer.CustomerAddress = newAddress;
            newCustomer.CustomerRole = newRole;

            return newCustomer;

        }

    }
}