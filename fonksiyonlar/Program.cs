namespace fonksiyonlar
{
    internal class Program
    {
        #region //1-)Geriye değer döndürmeyen ve parametre almayan metod:
        static public void TelevizyonAc()
        {
            Console.WriteLine("Televizyon açıldı.");
        }
        static void TelevizyonKapat()
        {
            Console.WriteLine("Televizyon kapandı.");
        }
        #endregion
        #region 2-)Geriye değer döndürmeyen parametre alan metod:
        static public void SelamVer(string isim)
        {
            Console.WriteLine($"Merhaba {isim} hoşgeldin");
        }
        static public void YasKontrol(int yas)
        {
            if (yas < 18)
            {
                Console.WriteLine($"Yaşınız {yas} ehliyet alamazsınız.");
            }
            else
            {
                Console.WriteLine($"Yaşınız {yas} tebrikler ehliyet alabilirsiniz.");
            }
        }
        #endregion
        #region 3-)Geriye değer döndüren ve parametre almayan metod:
        static public int KareAlanHesapla()
        {
            int kenar = 16;
            //return kenar * kenar;
            int sonuc = kenar * kenar;
            return sonuc;
        }
        static public double UcgenAlanHesapla()
        {
            double taban = 7;
            double yukseklik = 9;
            double alan = (taban * yukseklik) / 2.0;
            return alan;
        }
        static public bool DersiGectiMi()
        {
            int vize = 50;
            int final = 30;
            int sonuc = (vize + final) / 2;
            if (sonuc < 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static public string BilgiGetir()
        {
            string isim = "Anıl Mert";
            string soyad = "Temel";
            string kisiBilgisi = isim + " " + soyad;
            return kisiBilgisi;

        }
        #endregion
        #region 4-)Geriye değer döndüren ve parametre alan metod:
        static public int KareAlanHesapla(int kenar)
        {
            //return kenar * kenar;
            int sonuc = kenar * kenar;
            return sonuc;
        }
        static public double UcgenAlanHesapla(double taban, double yukseklik)
        {
            double alan = (taban * yukseklik) / 2.0;
            return alan;
        }
        static public bool DersiGectiMi(int vize, int final)
        {
            int sonuc = (vize + final) / 2;
            if (sonuc < 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static public string BilgiGetir(string ad, string soyad)
        {
            string kisiBilgisi = ad + " " + soyad;
            return kisiBilgisi;

        }
        static public decimal KurHesapla(decimal miktar, decimal doviz)
        {
            decimal toplamPara = miktar * doviz;
            return toplamPara;
        }
        #endregion
        #region 5-)Recursive(Özyinelemeli) metod:Kendi kendine çağıran metodtur.    
        static public int FaktoriyelHesapla(int n)
        {
            if (n <= 1) return 1;

            return n * FaktoriyelHesapla(n - 1);
        }
        #endregion
        static void Main(string[] args)
        {
            /*METODLAR:
             Yazılımda fiili olarak gerçekleştirdiğimiz tüm işler bir metod olarak adlandırılır.
               -Belirli bir işi yerine getiren işlemleri tekrar tekrar yazmamak için kullanılır.
               -Metodlar classların içinde tanımlanır.
               -Metodlar nasıl tanımlanır:
                [erişim belirleyici] [geri dönüş tipi] [fonksiyon adı] (parametreler) {
                 metod içeriği
                }
            Erişim Belirleyiciler:
            public:Her yerden erişilebilir olmasını sağlar.
            private:Sadece bulunduğu classtan erişim sağlar.
            protected:Sadece miras alınan sınıflardan erişilebilir.
            internal:Aynı proje içinde erişilebilmesine olanak sağlar.
            protected internal:Aynı projede ki veya türetilmiş sınıflarda kullanılabilir.

            Metod Çeşitleri:
            1-)Geriye değer döndürmeyen ve parametre almayan metod:Bu tür metodlar void tanımlanır ve herhangi bir değer döndürmezler.
            2-)Geriye değer döndürmeyen parametre alan metod:Dışarıdan parametre alır fakat değer döndürmez.
            3-)Geriye değer döndüren ve parametre almayan metod:Bir parametre almaz ama bir değer döndürür.
            4-)Geriye değer döndüren ve parametre alan metod:Hem parametre alır hemde değer döndürür.
            5-)Recursive(Özyinelemeli) metod:Kendi kendine çağıran metodtur.    
            NOT:Metod Overloading(Metod Aşırı Yüklenmesi):Aynı isimde metodların farklı parametreler alarak çağrılmasıdır. 
             */

            //TelevizyonAc();
            //TelevizyonKapat();
            //SelamVer("Anıl");
            //YasKontrol(19);
            //int alan=KareAlanHesapla();
            //Console.WriteLine(KareAlanHesapla());
            //Console.WriteLine(alan);
            //double uAlan = UcgenAlanHesapla();
            //Console.WriteLine(uAlan);
            //Console.WriteLine(UcgenAlanHesapla());
            //bool basariliMi=DersiGectiMi();
            //Console.WriteLine(basariliMi);
            //string bilgi=BilgiGetir();
            //Console.WriteLine(bilgi);

            //int alan = KareAlanHesapla(5);
            //Console.WriteLine(alan);
            //double uAlan=UcgenAlanHesapla(5,9);
            //Console.WriteLine(uAlan);
            //bool sonuc = DersiGectiMi(70,50);
            //Console.WriteLine(sonuc);
            //string bilgi = BilgiGetir("Anıl", "Mert");
            //Console.WriteLine(bilgi);
            //decimal para = KurHesapla(157.5m,53);
            //Console.WriteLine(para);

            int facSonuc = FaktoriyelHesapla(5);
            Console.WriteLine(facSonuc);

        }

    }
}
