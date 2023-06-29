using finalProject.Handler;
using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Controllers
{
	public class TransactionHeaderController
	{

		public static void create(int CustomerID, DateTime TransactionDate)
		{
			TransactionHeaderHandler.create(CustomerID, TransactionDate);
		}

		public static List<TransactionHeader> GetAllTransactionHeader(int CustomerID)
		{
			return TransactionHeaderHandler.GetAllTransactionHeader();
		}

		public static dynamic GetAllCustomerTransactionDetail(int CustomerID)
		{
			return TransactionHeaderHandler.GetAllCustomerTransactionDetail(CustomerID);
		}

	}
}