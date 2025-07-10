namespace yeniSifreOlusturmaAlgoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Kullanıcının şifresi, şifre değişimi için belirlenen bir soru ve cevabı olmalı. Kullanıcı sorunun cevabını doğru bildiğinde şifre değişimine izin verilmeli. Şifre değişimi işleminden sonra yeni şifre ekrana basılmalı.(Program kullanıcı soruyu doğru bilene kadar sormaya devam etmeli.) 
             
             * 1-Başla
             2-Önceden belirlenmiş bir güvenlik sorusu ve cevabı tanımla.
             3-yeni şifre değişkenini tanımla 
             4-Sonsuz döngü başlat:
             4.1-Kullanıcıya güvenlik sorusunu sor.
             4.2-Cevap doğruysa döngüyü kır (break).
             4.3-Yanlışsa uyarı ver ve soruyu tekrar sor.
             5-Doğru cevap verildikten sonra kullanıcıdan yeni şifre iste.
             6-Yeni şifreyi kaydet (yeniSifre değişkenine ata).
             7-Yeni şifreyi ekrana yazdır.
             8-Bitiş
             */
            string guvenlikSorusu = "Evcil Hayvanınız Adını Giriniz"; 
            string guvenlikCevabi = "Nemo"; 
            string yeniSifre = "";  
            while (true) // Sonsuz döngü
            {
                Console.WriteLine($"Güvenlik Sorusu : {guvenlikSorusu}");
                string kullaniciCevabi = Console.ReadLine(); 
                if (kullaniciCevabi.ToLower().Trim() == guvenlikCevabi.ToLower().Trim()) 
                {
                    Console.WriteLine("Cevap doğru!");
                    break; 
                }
                else
                {
                    Console.WriteLine("Yanlış cevap, lütfen tekrar deneyin."); 
                }
            }
            Console.Write("Yeni şifre girin: "); 
            yeniSifre = Console.ReadLine(); 
            Console.WriteLine("Yeni şifre başarıyla kaydedildi. Yeni şifreniz : " + yeniSifre); 
        }
    }
}
