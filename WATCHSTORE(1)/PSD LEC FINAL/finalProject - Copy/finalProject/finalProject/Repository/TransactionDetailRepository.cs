using finalProject.Factory;
using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Repository
{
	public class TransactionDetailRepository
	{
        private static Database1Entities2 db = DatabaseSingleton.getInstance();

        public static void insert(int TransactionID, int WatchDetailID, int Qty)
        {
            TransactionDetail newTransactionDetail = TransactionDetailFactory.create(TransactionID, WatchDetailID, Qty);
            db.TransactionDetails.Add(newTransactionDetail);
            db.SaveChanges();
        }

        public static List<TransactionDetail> GetDetails(int TransactionID)
		{
            return (from x in db.TransactionDetails where x.TransactionID == TransactionID select x).ToList();
		}

    }
}