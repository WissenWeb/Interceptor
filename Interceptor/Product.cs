using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor
{
    public class Product : IProduct
    {
        public string GetName()
        {
            throw new Exception("Product sınıfı içerisinde her hangi bir aşamada hata alındı");
            return "Interceptor tarafından çalıştırıldım ve değer döndüm";
        }

        public int Sum(int one, int two)
        {

            return one + two;

        }
    }
    public interface IProduct
    {

        public int Sum(int one, int two);
        public string GetName();
        
    }
}
