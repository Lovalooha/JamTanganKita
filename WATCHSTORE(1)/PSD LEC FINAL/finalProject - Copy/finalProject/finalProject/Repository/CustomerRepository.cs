using finalProject.Factory;
using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Repository
{
    public class CustomerRepository
    {
        private static Database1Entities2 db = new Database1Entities2();

        public void insert(string name, string email, string password, string gender, string address, string role)
        {
            Customer newCustomer = CustomerFactory.create(name, email, password, gender, address, role);
            db.Customers.Add(newCustomer);
            db.SaveChanges();
        }

        public void update(int id, string newName, string newEmail, string newPasssword, string newGender, string newAddress)
        {
            Customer updateCustomer = db.Customers.Find(id);

            updateCustomer.CustomerName = newName;
            updateCustomer.CustomerEmail = newEmail;
            updateCustomer.CustomerPassword = newPasssword;
            updateCustomer.CustomerGender = newGender;
            updateCustomer.CustomerAddress = newAddress;

            db.SaveChanges();
        }

        public void delete(int id)
        {
            Customer deleteCustomer = db.Customers.Find(id);
            db.Customers.Remove(deleteCustomer);
            db.SaveChanges();
        }

        public static Customer GetProfile(int id)
		{
			try
			{
                return (from x in db.Customers where x.CustomerID == id select x).FirstOrDefault();
			}
            catch(Exception e)
			{
                return null;
			}
		}

    }
}