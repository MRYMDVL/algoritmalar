namespace indirimliFiyatBulmaAlgoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
         /*Kullanıcıdan bir ürünün fiyatını ve kategori kodunu alın. Eğer kategori kodu 1 ise %10, kategori kodu 2 ise %20, kategori kodu 3 ise %30 
         indirim yaparak yeni fiyatı hesaplayın ve ekrana yazdırın. Diğer durumlarda, "Geçersiz kategori" mesajı verin.
         1-başla
         2-kullanıcıdan fiyat al
         3-kullanıcıdan kod al
         4-indirim oranı tanımla
         4-eğer kod 1 ise indirimli fiyat değerini 0.10 olarak ata
         5-eğer kod 2 ise indirimli fiyat değerini 0.20 olarak ata
         6-eğer kod 3 ise  indirimli fiyat değerini 0.30 olarak ata
         7-yeni fiyatı hesapla yazdır 
         8-bitir
         */
            Console.WriteLine("fiyat girin");
            int fiyat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kod girin");
            int kod = Convert.ToInt32(Console.ReadLine());
            double indirimOrani = 0;
            if (kod == 1)
            {
                indirimOrani = 0.10;

            }
            else if (kod == 2)
            {
                indirimOrani = 0.20;
            }
            else if (kod == 3)
            {
                indirimOrani = 0.30;
            }
            else
            {
                Console.WriteLine("geçersiz kategori");
                return;
            }
            Console.WriteLine($"indirimli fiyat: {fiyat - (fiyat * indirimOrani)} tl");
        }
    }
}
