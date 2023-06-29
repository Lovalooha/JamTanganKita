using finalProject.Model;
using finalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Handler
{
	public class CustomerHandler
	{
        public static void insert(string name, string email, string password, string gender, string address, string role)
        {
            CustomerRepository repo = new CustomerRepository();
            repo.insert(name, email, password, gender, address, role);

        }

        public static void update(int id, string newName, string newEmail, string newPasssword, string newGender, string newAddress)
        {
            CustomerRepository repo = new CustomerRepository();
            repo.update(id, newName, newEmail, newPasssword, newGender, newAddress);
        }

        public static Customer GetProfile(int id)
		{
            return CustomerRepository.GetProfile(id);
		}

    }
}