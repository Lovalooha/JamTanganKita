using finalProject.Handler;
using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Controllers
{
	public class TransactionDetailController
	{

		public static void createDetail(int TransactionID, int WatchDetailID, int Qty)
		{
			TransactionDetailHandler.createTD(TransactionID, WatchDetailID, Qty);
		}

		public static List<TransactionDetail> GetDetails(int TransactionID)
		{
			return TransactionDetailHandler.GetDetails(TransactionID);
		}

	}
}