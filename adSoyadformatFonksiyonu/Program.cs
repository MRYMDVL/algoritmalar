namespace adSoyadformatFonksiyonu
{
    internal class Program
    {
        static string buyukHarfKontrol(string ad, string soyad)
        {

            ad = char.ToUpper(ad[0]) + ad.Substring(1).ToLower(); //substring :bir string değierinin belirli bir indisten diğer indise kadar seçmemizi sağlar.
            soyad = char.ToUpper(soyad[0]) + soyad.Substring(1).ToLower();

            return ad + " " + soyad;
        }



        static void Main(string[] args)
        {
            // Kullanıcının ad soyad alıp,Ad  ve Soyadın ilk harfini alıp büyüteceğiz
            Console.WriteLine("Lütfen Adınızı giriniz:");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen Soyadınızı giriniz :");
            string soyad = Console.ReadLine();

            string sonuc = buyukHarfKontrol(ad, soyad);

            Console.WriteLine($"Adınız : {ad} ,Soyadınız : {soyad}. Adınızın formatlanmış hali : {sonuc}");

        }
    }
}
