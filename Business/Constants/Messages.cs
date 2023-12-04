using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //static; sürekli newlemeyeceğiz program hayatı boyunca tek instance olacak.
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";//magic strings
        public static string ProductNameInvalid = "Ürün ismi en az 2 karakter olmalıdır";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
    }
}
