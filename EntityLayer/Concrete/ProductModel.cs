using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ProductModel
    {
        public int Id { set; get; } = 0;
        public string Viewimage { set; get; } = "";
        public string Content { set; get; } = "";
        public string Title { set; get; } = "";
        public string Tag { set; get; } = "";
        public int Type { set; get; } = 0;/* 1 resim 2 viedo 3 story resim 4 story video */
       
        public int Day { set; get; } = DateTime.Now.Day;
        public int Month { set; get; } = DateTime.Now.Month;
        public int Year { set; get; } = DateTime.Now.Year;
        public int Hour { set; get; } = DateTime.Now.Hour;
        public int Minutes { set; get; } = DateTime.Now.Minute;
        public int Status { set; get; } = 1;
        public virtual string Typex { set; get; } = "";
        public virtual string Statusx { set; get; } = "";
        /*
         1 zamanı bekliyor
         2 işlemde
         3 tamamlandı
         4 hata oluştu
         */

        public string ErrorLog { set; get; } = "";
    }
}
