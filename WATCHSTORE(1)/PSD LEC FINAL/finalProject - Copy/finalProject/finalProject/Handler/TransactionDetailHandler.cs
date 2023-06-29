using finalProject.Model;
using finalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Handler
{
	public class TransactionDetailHandler
	{

		public static void createTD(int TransactionID, int WatchDetailID, int Qty)
		{
			TransactionDetailRepository.insert(TransactionID, WatchDetailID, Qty);
		}

		public static List<TransactionDetail> GetDetails(int TransactionID)
		{
			return TransactionDetailRepository.GetDetails(TransactionID);
		}

	}
}