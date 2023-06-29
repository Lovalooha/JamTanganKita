using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Factory
{
    public class WatchDetailFactory
    {
        Database1Entities2 db = new Database1Entities2();

        public static WatchDetail create(string newName, string newDescription, int newPrice, int newStock, string newImage, int watchID)
        {
            WatchDetail newWatchDetail = new WatchDetail();
            newWatchDetail.WatchID = watchID;
            newWatchDetail.WatchName = newName;
            newWatchDetail.WatchDescription = newDescription;
            newWatchDetail.WatchPrice = newPrice;
            newWatchDetail.WatchStock = newStock;
            newWatchDetail.WatchImage = newImage;

            return newWatchDetail;
        }

    }
}