using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class SepetManager
    {
        // naming convention
        public void Ekle(Mehsul mehsul)
        {
            Console.WriteLine("Sepete eklendi : " + mehsul.Adi );

        }
        public void Ekle2(string mehsulAdi, string melumat, double qiymet, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi : " + mehsulAdi);
        }
    }
}
