using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Factory
{
	public class TransactionDetailFactory
	{
		public static TransactionDetail create(int newTransactionID, int newWatchDetailID, int newQty)
		{
			TransactionDetail newTransactionDetail = new TransactionDetail();
			newTransactionDetail.TransactionID = newTransactionID;
			newTransactionDetail.WatchDetailID = newWatchDetailID;
			newTransactionDetail.Qty = newQty;
			return newTransactionDetail;
		}
	}
}