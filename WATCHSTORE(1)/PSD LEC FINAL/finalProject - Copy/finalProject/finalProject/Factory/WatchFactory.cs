using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Factory
{
    public class WatchFactory
    {
        Database1Entities2 db = new Database1Entities2();

        public static Watch create(string newName, string newImage)
        {
            Watch newWatch = new Watch();

            newWatch.WatchName = newName;
            newWatch.WatchImage = newImage;

            return newWatch;
        }



    }
}