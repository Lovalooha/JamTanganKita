using finalProject.Model;
using finalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Handler
{
	public class TransactionHeaderHandler
	{

		public static void create(int CustomerID, DateTime TransactionDate)
		{
			TransactionHeaderRepository.insert(CustomerID, TransactionDate);
		}

		public static dynamic GetAllCustomerTransactionDetail(int CustomerID)
		{
			return TransactionHeaderRepository.GetTransactionDetail(CustomerID);
		}

		public static List<TransactionHeader> GetAllTransactionHeader()
		{
			return TransactionHeaderRepository.GetAllTransactionHeader();
		}

	}
}