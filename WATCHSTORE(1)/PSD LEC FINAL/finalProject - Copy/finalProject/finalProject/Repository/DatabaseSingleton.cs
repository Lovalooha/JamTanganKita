using finalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.Repository
{
	public class DatabaseSingleton
	{

		private static Database1Entities2 db;
		public static Database1Entities2 getInstance()
		{
			if(db == null)
			{
				db = new Database1Entities2();
			}
			return db;
		}

	}
}