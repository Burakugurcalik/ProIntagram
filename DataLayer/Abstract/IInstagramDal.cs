using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    public interface IInstagramDal
    {
        public  void IsLogin(String _Username, String _Password);
        public  void UploadPhoto(ProductModel model);
        public  void UploadVieo(ProductModel model);
        public void UploadStoryPhoto(ProductModel model);
        public void UploadStoryVieo(ProductModel model);
        public  void IsLogout(String _Username, String _Password);
    }
}
