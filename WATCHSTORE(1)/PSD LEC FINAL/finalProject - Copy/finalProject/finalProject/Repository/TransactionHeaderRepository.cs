using finalProject.Factory;
using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Repository
{
	public class TransactionHeaderRepository
	{
		private static Database1Entities2 db = new Database1Entities2();

        public static int insert(int CustomerID, DateTime TransactionDate)
        {
            TransactionHeader newTransactionHeader = TransactionHeaderFactory.create(TransactionDate, CustomerID);
            db.TransactionHeaders.Add(newTransactionHeader);
            db.SaveChanges();

            return newTransactionHeader.TransactionID;
        }

        //public void update(int id, DateTime newTransactionDate)
        //{
        //    TransactionHeader updateTransactionHeader = db.TransactionHeaders.Find(id);
        //    updateTransactionHeader.TransactionDate = newTransactionDate;
        //    db.SaveChanges();
        //}

        //public void delete(int id)
        //{
        //    TransactionHeader deleteTransactionHeader = db.TransactionHeaders.Find(id);
        //    db.TransactionHeaders.Remove(deleteTransactionHeader);
        //    db.SaveChanges();
        //}
        public static int insert(DateTime TransactionDate, int CustomerID)
        {
            TransactionHeader newTransactionHeader = TransactionHeaderFactory.create(TransactionDate, CustomerID);

            db.TransactionHeaders.Add(newTransactionHeader);
            db.SaveChanges();

            return newTransactionHeader.TransactionID;
        }

        public void update(int id, DateTime newTransactionDate)
        {
            TransactionHeader updateTransactionHeader = db.TransactionHeaders.Find(id);
            updateTransactionHeader.TransactionDate = newTransactionDate;
            db.SaveChanges();
        }

        public void delete(int id)
        {
            TransactionHeader deleteTransactionHeader = db.TransactionHeaders.Find(id);
            db.TransactionHeaders.Remove(deleteTransactionHeader);
            db.SaveChanges();
        }

        public static List<TransactionHeader> GetAllTransactionHeader()
		{
            return db.TransactionHeaders.ToList();
		}

        public static List<TransactionHeader> GetCustomerTransactionHeader(int CustID)
		{
            return (from x in db.TransactionHeaders where x.CustomerID== CustID select x).ToList();
		}

        public static dynamic GetTransactionDetail(int CustID)
		{
            Customer c = db.Customers.Where(x => x.CustomerID == CustID).FirstOrDefault();

            return db.TransactionHeaders.Join(db.TransactionDetails, th => th.TransactionID, td => td.TransactionID, (th, td) => new { th, td }).Join(db.WatchDetails, t => t.td.WatchDetailID, a => a.WatchDetailID, (t, a) => new
            {
                TransactionID = t.th.TransactionID,
                TransactionDate = t.th.TransactionDate,
                CustomerID = t.th.CustomerID,
                CustomerName = c.CustomerName,
                WatchImage = a.WatchImage,
                WatchName = a.WatchName,
                WatchQty = t.td.Qty,
                WatchPrice = a.WatchPrice,
            }).Where(x => x.CustomerID == CustID).ToList();

		}


    }
}