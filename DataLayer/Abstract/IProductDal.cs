using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    public interface IProductDal
    {
        public Boolean Insert(ProductModel model);
        public Boolean Update(ProductModel model);
        public List<ProductModel> List();
        public ProductModel Get(int id);
        public Boolean Delete(int Deleteid);
        public  void Snapshot(ProductModel model);
    }
}
