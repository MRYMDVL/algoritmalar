using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_dersleri
{
    class Ogrenci
    {
        public string ad;
        public string soyad;
        public int yas;
        public void DersCalis()
        {
            Console.WriteLine($"{ad} Ders çalışıyor...");
        }
    }
    
}
