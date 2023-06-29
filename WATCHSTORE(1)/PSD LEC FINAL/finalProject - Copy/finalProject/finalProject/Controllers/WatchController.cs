using finalProject.Handler;
using finalProject.Model;
using finalProject.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace finalProject.Controllers
{
	public class WatchController
	{
		Database1Entities2 db = new Database1Entities2();
        WatchRepository repo = new WatchRepository();
        public WatchController()
        {

        }

        //get, delete, update
        public List<Watch> getAllWatch()
        {
            return WatchHandler.getAllWatch();
        }

        public Watch getWatch(int id)
        {
            Watch watch = WatchHandler.getWatch(id);
            if(watch == null)
			{
                return null;
			}
            return WatchHandler.getWatch(id);
        }

        public void delete(int id)
        {
            WatchHandler.delete(id);
        }

        public bool validateUpdateWatch(int id, string name, FileUpload image, out string errorMessage)
        {
            errorMessage = "";
            string fileName = string.Empty;
            if (name.Length == 0)
            {
                errorMessage = "Must be filled and unique among the watch name.";
                return false;
            }
            else if (repo.validateWatchName(name))
            {
                errorMessage = "Must be filled and unique among the watch name.";
                return false;
            }
            else if (image.HasFile)
            {
                HttpPostedFile uploadedFile = image.PostedFile;

                //ngambil extension
                string extension = Path.GetExtension(uploadedFile.FileName).ToLower();
                int sizeFile = uploadedFile.ContentLength;

                //vallidasi
                fileName = uploadedFile.FileName;
                if (sizeFile >= 2 * 1024 * 1024)
                {
                    errorMessage = "Image size must be lower than 2 MB ";
                    return false;
                }

                else if (extension != ".png" && extension != ".jpg" && extension != ".jpeg" && extension != ".jfif")
                {
                    errorMessage = "file extension must be .png, .jpg, .jpeg, or .jfif";
                    return false;
                }

            }
            else
            {
                errorMessage = "Image Must be chosen";
                return false;
            }
            WatchHandler.UpdateWatch(id, name, fileName);
            return true;
        }

        public bool validateInsertWatch(string name, FileUpload image, out string errorMessage)
        {
            errorMessage = "";
            string fileName = string.Empty;
            if (name.Length == 0)
            {
                errorMessage = "Must be filled and unique among the watch name.";
                return false;
            }
            else if (repo.validateWatchName(name))
            {
                errorMessage = "Must be filled and unique among the watch name.";
                return false;
            }
            else if (image.HasFile)
            {
                HttpPostedFile uploadedFile = image.PostedFile;

                //ngambil extension
                string extension = Path.GetExtension(uploadedFile.FileName).ToLower();
                int sizeFile = uploadedFile.ContentLength;

                //vallidasi
                fileName = uploadedFile.FileName;
                if (sizeFile >= 2 * 1024 * 1024)
                {
                    errorMessage = "Image size must be lower than 2 MB ";
                    return false;
                }

                else if (extension != ".png" && extension != ".jpg" && extension != ".jpeg" && extension != ".jfif")
                {
                    errorMessage = "file extension must be .png, .jpg, .jpeg, or .jfif";
                    return false;
                }

            }
            else
            {
                errorMessage = "Image Must be chosen";
                return false;
            }
            WatchHandler.InsertWatch(name, fileName);
            return true;
        }


    }
}