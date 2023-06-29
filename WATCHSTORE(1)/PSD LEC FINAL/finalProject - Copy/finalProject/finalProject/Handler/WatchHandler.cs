using finalProject.Model;
using finalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Handler
{
	public class WatchHandler
	{

        public static List<Watch> getAllWatch()
        {
            WatchRepository repo = new WatchRepository();
            return repo.getAllWatch();
        }

        public static Watch getWatch(int id)
        {
            WatchRepository repo = new WatchRepository();
            return repo.getWatch(id);
        }

        public static void delete(int id)
        {
            WatchRepository repo = new WatchRepository();
            repo.delete(id);
        }
        public static void UpdateWatch(int id, string newName, string newImage)
        {
            WatchRepository repo = new WatchRepository();
            repo.update(id, newName, newImage);
        }

        public static void InsertWatch(string name, string image)
        {
            WatchRepository repo = new WatchRepository();
            repo.insert(name, image);
        }

    }
}