using System.Security.Cryptography.X509Certificates;

namespace enUzunKelimeyiBulmaAlgoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Verilen metindeki en uzun kelimeyi bulan algoritma
            1-basla
            2-kullanicidan metin al
            3-en uzun kelimeyi tutan bir string olustur(string = enUzunKelime)
            4-kelime adinda bir string olustur(string kelime)
            5-metinde her karakter icin bir dongu kur
            5.1- eger karakter bosluk degilse karakteri kelimeye ata
            5.1.2- eger karakter bosluksa 'su anki kelime'nin uzunlugunu 'kelime' nin uzunlugu 'le karsilastir
            5.1.3- eger 'su anki kelime' daha uzunsa enUzunKelime'yi guncelle.
            5.1.4- su anki kelime yi bos yap
            6. dongu bittikten sonra su anki kelimenin uzunlugunu enUzunKelime ile karsilastir
            6.1- eger kelime uzunsa enUzunKelimeyi tekrar guncelle
            7. enUzunKelimeyi yazdir
          
             */
            string metin = Console.ReadLine();
            string enUzunKelime = "";
            string kelime = "";

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] != ' ')
                {
                    kelime += metin[i];
                }
                else
                {
                    if(kelime.Length > enUzunKelime.Length )
                    {
                        enUzunKelime = kelime;
                    }
                    kelime = "";
                }
            }
            if( enUzunKelime.Length < kelime.Length)
            {
                enUzunKelime = kelime;
            }
            
                Console.WriteLine(enUzunKelime);

           
        }
    }
}
