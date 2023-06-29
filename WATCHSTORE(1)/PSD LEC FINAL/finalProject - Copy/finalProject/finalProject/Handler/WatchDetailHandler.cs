using finalProject.Model;
using finalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Handler
{
	public class WatchDetailHandler
	{	
		public static void insertWatchDetail(string name, string description, int price, int stock, string image, string watchID)
		{
			WatchDetailRepository repo = new WatchDetailRepository();
			repo.insert(name, description, price, stock, image, watchID);
		}

		public static void updateWatchDetail(int id, string newName, string newDescription, int newPrice, int newStock, string newImage)
		{
			WatchDetailRepository repo = new WatchDetailRepository();
			repo.update(id, newName, newDescription, newPrice, newStock, newImage);
		}
		public static void deleteWatchDetail(int id)
		{
			WatchDetailRepository repo = new WatchDetailRepository();
			repo.delete(id);
		}

		public static List<WatchDetail> GetAllWatchDetail()
		{
			return WatchDetailRepository.getAllWatchDetail();
		}

		public static List<WatchDetail> GetWatchDetailList(int id)
		{
			return WatchDetailRepository.getWatchDetailList(id);
		}

		public static WatchDetail GetWatchDetailID(int id)
		{
			return WatchDetailRepository.getWatchDetail(id);
		}

		

	}
}