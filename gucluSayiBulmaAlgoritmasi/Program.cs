namespace gucluSayiBulmaAlgoritmasi
{
    internal class Program
    {
        /*
        Girilen sayının güçlü sayı olup olmadığını bulan program yazınız.
        (Güçlü Sayı :  basamaklarının faktör toplamının, sayının kendisine eşit olduğu sayıdır. 145 –> 1!+4!+5!=145)

        1-Başla
        2-Kullanıcıdan bir sayı al.
        3-Bir adet asıl sayıyı  gecici bir değişkene ata.(orijinal sayı )
        4-Toplama adında bir değişken ata.
        5-Sayının her basamağı için 
        5.1-son basamağını al(mod 10)
        5.2-bu masamağın faktöriyelini al 
        5.3-Faktöriyel sonucunu toplam ile topla
        5.4-Sayıyı 10'a bölerek basamak küçült.
        6-Toplam sonucu ile orjinal sayıyı karşılaştır.
        6.1-Orijinal sayı ile toplam eşit ise ekrana Güölü sayıdır yazdır.
        6.2-Orijinal sayı ile toplam eşit değilse Güçlü sayı değildir yazdır.
        7-Bitir.
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int number = Convert.ToInt32(Console.ReadLine());
            int orijinalSayi = number ;
            int toplam = 0;

            while (number > 0)
            {
                int basamak = number % 10;
                int faktoriyel = 1;

                for (int i = 1; i <= basamak; i++)
                {
                    faktoriyel = i * faktoriyel;

                }
                toplam += faktoriyel;
                number = number / 10;

            }
            if ( orijinalSayi == toplam )
            {
                Console.WriteLine("Girdiğiniz sayı güçlü sayıdır.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı güçlü sayı değildir.");
            }
        }
    }
}
