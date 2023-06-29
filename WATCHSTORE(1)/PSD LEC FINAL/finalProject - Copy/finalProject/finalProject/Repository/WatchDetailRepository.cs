using finalProject.Factory;
using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Repository
{
    public class WatchDetailRepository
    {
        private static Database1Entities2 db = new Database1Entities2();
        public void insert(string name, string description, int price, int stock, string image, string watchID)
        {
            int watch_ID = Convert.ToInt32(watchID);
            WatchDetail newWatchDetail = WatchDetailFactory.create(name,description,price,stock,image,watch_ID);
            db.WatchDetails.Add(newWatchDetail);
            db.SaveChanges();
        }

        public void update(int id, string newName, string newDescription, int newPrice, int newStock, string newImage)
        {
            WatchDetail updateWatchDetail = db.WatchDetails.Find(id);
            updateWatchDetail.WatchPrice = newPrice;
            updateWatchDetail.WatchName = newName;
            updateWatchDetail.WatchDescription = newDescription;
            updateWatchDetail.WatchStock = newStock;
            updateWatchDetail.WatchImage = newImage;

            db.SaveChanges();
        }

        public void delete(int id)
        {
            WatchDetail deleteWatchDetail = db.WatchDetails.Find(id);
            db.WatchDetails.Remove(deleteWatchDetail);
            db.SaveChanges();
        }

        public static List<WatchDetail> getAllWatchDetail()
        {
            return db.WatchDetails.ToList();
        }

        public static List<WatchDetail> getWatchDetailList(int id)
        {
            return (from watchdetail in db.WatchDetails where watchdetail.WatchID == id select watchdetail).ToList();
        }

        public static WatchDetail getWatchDetail(int id)
        {
            return db.WatchDetails.Find(id);
        }

        public static void updateStock(int WatchDetailID, int WatchDetailStock)
        {
            WatchDetail updateWatchDetail = db.WatchDetails.Find(WatchDetailID);
            updateWatchDetail.WatchStock = WatchDetailStock;

            db.SaveChanges();

        }

    }
}