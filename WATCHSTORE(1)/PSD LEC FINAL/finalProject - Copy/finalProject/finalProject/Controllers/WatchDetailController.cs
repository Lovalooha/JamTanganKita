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
    
    public class WatchDetailController
	{
        public WatchDetailController()
		{

		}

        public static List<WatchDetail> getAllWatchDetail()
        {
            return WatchDetailHandler.GetAllWatchDetail();
        }

        public static List<WatchDetail> getWatchDetailList(int id)
        {
            return WatchDetailHandler.GetWatchDetailList(id);
        }

        public static WatchDetail getWatchDetail(int id)
        {
            return WatchDetailHandler.GetWatchDetailID(id);
        }

        public void delete(int id)
        {
            WatchDetailHandler.deleteWatchDetail(id);
        }

        public bool validateInsertWatchDetail(string name, string description, string newprice, string newstock, FileUpload image, out string errorMessage, string watchID)
        {

            WatchDetailRepository repo = new WatchDetailRepository();
            WatchDetailHandler handler = new WatchDetailHandler();
            errorMessage = "";
            string fileName = string.Empty;


            if (name.Length == 0 || name.Length >= 50)
            {
                errorMessage = "Name Must be filled and smaller than 50 characters.";
                return false;
            }
            else if (description.Length == 0 || description.Length >= 255)
            {
                errorMessage = "Description Must be filled and smaller than 255 characters";
                return false;
            }
            if(newprice.Length == 0)
			{
                errorMessage = "Price Must be filled";
                return false;
            }
            int price = Convert.ToInt32(newprice);
            if (price < 100000 || price > 1000000)
            {
                errorMessage = "Price Must be filled and between 100000 and 1000000";
                return false;
            }
            if(newstock.Length == 0)
			{
                errorMessage = "Stock must be filled";
                return false;
			}
            int stock = Convert.ToInt32(newstock);
            if (stock <= 0)
            {
                errorMessage = "Stock Must be filled and more than 0";
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
            WatchDetailHandler.insertWatchDetail(name, description, price, stock, fileName, watchID);
            return true;
        }

        public bool validateUpdateWatchDetail(int id, string name,string description, string newprice, string newstock, FileUpload image, out string errorMessage)
        {
            WatchDetailRepository repo = new WatchDetailRepository();
            errorMessage = "";
            string fileName = string.Empty;


            if (name.Length == 0 || name.Length >= 50)
            {
                errorMessage = "Name Must be filled and smaller than 50 characters.";
                return false;
            }
            else if (description.Length == 0 || description.Length >= 255)
            {
                errorMessage = "Description Must be filled and smaller than 255 characters";
                return false;
            }
            if (newprice.Length == 0)
            {
                errorMessage = "Price Must be filled";
                return false;
            }
            int price = Convert.ToInt32(newprice);
            if (price < 100000 || price > 1000000)
            {
                errorMessage = "Price Must be filled and between 100000 and 1000000";
                return false;
            }
            if (newstock.Length == 0)
            {
                errorMessage = "Stock must be filled";
                return false;
            }
            int stock = Convert.ToInt32(newstock);
            if (stock <= 0)
            {
                errorMessage = "Stock Must be filled and more than 0";
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
            //repo.update(id, name, description, price, stock, fileName);
            WatchDetailHandler.updateWatchDetail(id, name, description, price, stock, fileName);
            return true;
        }

    }

}