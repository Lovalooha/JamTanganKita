using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Factory
{
	public class TransactionHeaderFactory
	{
		public static TransactionHeader create(DateTime newTransactionDate, int customerID)
		{
			TransactionHeader newTransactionHeader = new TransactionHeader();
			newTransactionHeader.TransactionDate = newTransactionDate;
			newTransactionHeader.CustomerID = customerID;

			return newTransactionHeader;
		}
	}
}