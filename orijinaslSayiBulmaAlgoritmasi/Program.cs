using System;

namespace orijinaslSayiBulmaAlgoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Basla
            2.kullanicidan 4 basamakli bir sayi al
            3.Sayinin ilk iki basamağını tutan ve son iki basamağını tutan değiskenler oluştur
            4.İki sayiyi hesapla
            4.1 son iki  basamağı sayinin 100 ile modunu alarak bul
            4.2 ilk iki basamağı bulmak için sayiyi 100 e böl
            5.Bu iki değeri topla
            6.Toplamın karesini al
            7.Sonuc sayiya eşitse orjinal sayidir
            7.1 sonuc sayiya eşit değilse orjinal sayi degildir.
            8.Bitir
             */

            Console.WriteLine("4 basamakli sayi giriniz");
            int number = Convert.ToInt32(Console.ReadLine());
            int sonBasamak, ilkBasamak = 0;

            sonBasamak = number % 100;
            ilkBasamak = number / 100;
            int toplam = ilkBasamak + sonBasamak;
            int kare = toplam * toplam;


            if (kare == number)
            {
                Console.WriteLine("Orjinal sayidir.");
            }
            else
            {
                Console.WriteLine("Orjinal sayi degildir.");
            }

        }
    }
}
