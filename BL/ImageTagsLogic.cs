using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BL
{
    public class ImageTagsLogic
    {
        public void Uplaod(HttpPostedFileBase file)
        {
            GoogleDriveAPIHelper g = new GoogleDriveAPIHelper();
            g.UplaodFileOnDrive(file);

        }
    }
}