namespace ikizAsalSayiBulmaAlgoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*1'den 1000'e kadar olan sayılar arasında ikiz asal (farkları 2 olan asal sayılar) çiftlerini bulun ve ekrana yazdırın.
             Ancak, toplam 10 çift bulduğunuzda döngüyü sonlandırın (break kullanarak). 
             Asal olmayan sayıları atlayın (continue kullanarak).*/

            /*
             1.Basla
             2.Bir sayac tanımla
             3.1 den 1000 e kadar gidecek bir for döngüsü başlat.
             4.Sayinin asal olup olmadığını AsalMi fonksiyonu ile kontrol et.
             4.1 Sayi asal değilse contiune ile atla
             4.2 Sayi asalsa sayı+2 kontrol et her ikisi de asal ise bunlar ikiz asal çifttir ve ekrana yazdırılır. 
             5.Sayaci bir arttıralım.
             6.Sayac 10'a eşitse döngüyü breakle kıralım.
             7.Bitir
             */

            int sayac = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (!AsalMi(i)) //AsalMi(i)==false
                {
                    continue;
                }
                if (AsalMi(i + 2)) //AsalMi(i+2)==true
                {
                    Console.WriteLine($"{i} ve {i + 2} değerleri ikiz asal sayıdır. ");
                    sayac++;

                    if (sayac == 15)
                    {
                        break;
                    }

                }

            }

        }
        static bool AsalMi(int sayi)
        {
            if (sayi < 2)
            {
                return false;
            }
            for (int i = 2; i <= (sayi / 2); i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
