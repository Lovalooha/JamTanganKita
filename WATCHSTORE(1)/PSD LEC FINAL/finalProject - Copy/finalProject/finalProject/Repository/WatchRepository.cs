using finalProject.Factory;
using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace finalProject.Repository
{
    public class WatchRepository
    {
        Database1Entities2 db = new Database1Entities2();

        public void insert(string name, string image)
        {
            Watch newWatch = WatchFactory.create(name, image);
            db.Watches.Add(newWatch);
            db.SaveChanges();
        }

        public void update(int id, string newName, string newImage)
        {
            Watch updateWatch = db.Watches.Find(id);
            updateWatch.WatchName = newName;
            updateWatch.WatchImage = newImage;
            db.SaveChanges();
        }

        public bool validateWatchName(String name)
		{
            return db.Watches.Any(x => x.WatchName == name);

        }

        public void delete(int id)
        {
            Watch deleteWatch = db.Watches.Find(id);
            db.Watches.Remove(deleteWatch);
            db.SaveChanges();
        }

        public List<Watch> getAllWatch()
        {
            return db.Watches.ToList();
        }

        public Watch getWatch(int id)
        {
            return db.Watches.Find(id);
        }

    }
}