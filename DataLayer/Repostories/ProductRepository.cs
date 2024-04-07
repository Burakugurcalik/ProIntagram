using DataLayer.Abstract;
using DataLayer.Temps;
using EntityLayer;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xabe.FFmpeg;
using static System.Net.Mime.MediaTypeNames;

namespace DataLayer.Repostories
{
    public class ProductRepository:IProductDal
    {
        public  Boolean Insert(ProductModel model)
        {

            try
            {
                model.Id = NextId();
                using (var db = new LiteDatabase(Staticlist.Dbpac))
                {
                    var ModelSource = db.GetCollection<ProductModel>("Products");

                    model.Status = 1;

                    ModelSource.Insert(model);
                };
                //if (model.Type==2 || model.Type==4)
                //{
                //   Snapshot(model);
                //}
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public Boolean Update(ProductModel model)
        {

            try
            {
                using (var db = new LiteDatabase(Staticlist.Dbpac))
                {
                    var ModelSource = db.GetCollection<ProductModel>("Products");
                    var newModelSource = model;
                    ModelSource.Update(model.Id, newModelSource);
                };
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<ProductModel> List()
        {
            List<ProductModel> list = new List<ProductModel>();
            using (var db = new LiteDatabase(Staticlist.Dbpac))
            {
                var Models = db.GetCollection<ProductModel>("Products");
                foreach (ProductModel item in Models.FindAll())
                {
                    if (item.Type == 1) { item.Typex = "Gönderi Resim"; }
                    if (item.Type == 2) { item.Typex = "Gönderi Video"; }
                    if (item.Type == 3) { item.Typex = "Story Resim"; }
                    if (item.Type == 4) { item.Typex = "Story Video"; }
                    if (item.Status == 1) { item.Statusx = "Bekliyor"; }
                    if (item.Status == 2) { item.Statusx = "İşlemde"; }
                    if (item.Status == 3) { item.Statusx = "Tamalamlandı"; }
                    if (item.Status == 4) { item.Statusx = "Hata Oluştu"+"("+item.ErrorLog+")"; }
                    /* 1 resim 2 viedo 3 story resim 4 story video */
                    /*
        0 zamanı bekliyor
        1 işlemde
        2 tamamlandı
        9 hata oluştu
        */
                    list.Add(item);


                }
            };
            return list;
        }

        public ProductModel Get(int id)
        { 
        ProductModel model = new ProductModel();
            using (var db = new LiteDatabase(Staticlist.Dbpac))
            {
                var ModelSource = db.GetCollection<ProductModel>("Products");
                model = ModelSource.FindById(id);

             
            };
            return model;
        }
        public Boolean Delete(int Deleteid)
        {

            try
            {

                using (var db = new LiteDatabase(Staticlist.Dbpac))
                {
                    var ErrorModelDelete = db.GetCollection<ProductModel>("Products");
                    ErrorModelDelete.DeleteMany(x => x.Id == Deleteid);

                };
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }


        }

        public int NextId()
        {
            int id = 1;
            try
            {
                using (var db = new LiteDatabase(Staticlist.Dbpac))
                {

                    var ErrorModel = db.GetCollection<ProductModel>("Products");
                    int ids = ErrorModel.Max(m => m.Id);
                    id = ids;
                    id++;

                };
            }
            catch (Exception)
            {

                id = 1;
            }

            return id;
        }
        public async void Snapshot(ProductModel model)
        {

            try
            {
                model.Viewimage = model.Content.Substring(0, model.Content.IndexOf('.')) + ".jpg";

                string ax = model.Content;
                var FFmpegpath = "C:\ffmpeg\bin";
                FFmpeg.SetExecutablesPath(FFmpegpath, ffmpegExeutableName: "FFmpeg");
                var conversion = await FFmpeg.Conversions.FromSnippet.Snapshot(model.Content, model.Viewimage, TimeSpan.FromSeconds(1));
                await conversion.Start();
               Update(model);
            }
            catch (Exception ex)
            {

                model.Status = 4;
                model.ErrorLog = ex.Message;
              Update(model);
            }

        }

    }
}
