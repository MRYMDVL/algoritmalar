namespace gizliSifreAlgoritması
{
    internal class Program
    {
        
            /*
          1-Başla
          2-Kullanıcıdan isim soyisim ve dogum tarihi al 
          3-gizli şifre diye değişken oluştur.
          4- şifreoluşturucu diye fonksiyon oluştur.
          5- bu fonksiyon içinde ismin ilk 2 harfini büyük soyisimn son iki harfini küçük ve doğum tarihinin son iki rakamını al 
          ve gizli şifre değişkenine dönüştür.
          6-Ekrana gizli şifreyi yazdır.
          7-Bitir.
          */
            static string SifreOlusturucu(string isim, string soyisim, string dogumTarihi)
            {

                string ilkIki = isim.Substring(0, 2).ToUpper();             // ismin ilk 2 harfi büyük 
                string sonIki = soyisim.Substring(soyisim.Length - 2).ToLower(); // soyismin son 2 harfi küçük
                string tarihSonu = dogumTarihi.Substring(dogumTarihi.Length - 2); // doğum yılının son 2 rakamı

                string gizliSifre = ilkIki + sonIki + tarihSonu;
                return gizliSifre;
            }

        static void Main(string[] args)
        {
            Console.Write("İsminizi girin: ");
            string isim = Console.ReadLine();

            Console.Write("Soyisminizi girin: ");
            string soyisim = Console.ReadLine();

            Console.Write("Doğum yılınızı girin (örn: 1999): ");
            string dogumTarihi = Console.ReadLine();


            string gizliSifre = SifreOlusturucu(isim, soyisim, dogumTarihi);
            Console.WriteLine($"Gizli Şifreniz: {gizliSifre}");
        }
    }
}
