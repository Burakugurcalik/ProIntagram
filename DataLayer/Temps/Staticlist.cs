using EntityLayer;
using InstagramApiSharp.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Temps
{
    public class Staticlist
    {
        public static IInstaApi InstaApi;
        public static Boolean IsLogin = false;
        public static string Dbpac = "";
        public static string Username = "";
        public static string Pass = "";
        public static List<ProductModel> WorkerProducs = new List<ProductModel>();
    }
}
