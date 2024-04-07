using BussinnesLayer.Abstract;
using DataLayer.Repostories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinnesLayer.Concrate
{
    public class InstagramManager : IInstagramService
    {
        InstagramRepository repository;
        public InstagramManager() {
            repository= new InstagramRepository();
        }

        public async void IsLogin(string _Username, string _Password)
        {
            repository.IsLogin(_Username, _Password);
        }

        public async void IsLogout(string _Username, string _Password)
        {
            repository.IsLogout(_Username, _Password);
        }

        public async void UploadPhoto(ProductModel model)
        {
           repository.UploadPhoto(model);
        }

        public async void UploadStoryPhoto(ProductModel model)
        {
           repository.UploadStoryPhoto(model);
        }

        public async void UploadStoryVieo(ProductModel model)
        {
            repository.UploadStoryVieo(model);
        }

        public async void UploadVieo(ProductModel model)
        {
           repository.UploadVieo(model);
        }
    }
}
