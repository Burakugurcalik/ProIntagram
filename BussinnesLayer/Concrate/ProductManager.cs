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
    public class ProductManager : IProductService
    {
        ProductRepository repository;
        public ProductManager() { repository = new ProductRepository(); }
        public bool Delete(int Deleteid)
        {
          return  repository.Delete(Deleteid);
        }

        public ProductModel Get(int id)
        {
          return  repository.Get(id);
        }

        public bool Insert(ProductModel model)
        {
           return repository.Insert(model);
        }

        public List<ProductModel> List()
        {
            return repository.List();
        }

        public async void Snapshot(ProductModel model)
        {
            repository.Snapshot(model);
        }

        public bool Update(ProductModel model)
        {
            return repository.Update(model);
        }
    }
}
