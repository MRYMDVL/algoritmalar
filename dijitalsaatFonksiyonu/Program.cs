namespace dijitalsaatFonksiyonu
{
    internal class Program
    {
        static string SaniyeyiFormataCevir(int saniye)
        {
            int saat = saniye / 3600;
            int dakika = (saniye % 3600) / 60;
            int kalanSaniye = saniye % 60;

            return $"{saat:D2}:{dakika:D2}:{kalanSaniye:D2}";
        }



        static void Main(string[] args)
        {

            Console.Write("Saniye cinsinden bir süre girin: ");
            int tSaniye = int.Parse(Console.ReadLine());

            string dijitalSaat = SaniyeyiFormataCevir(tSaniye);
            Console.WriteLine("Dijital saat formatı: " + dijitalSaat);
        }
    }
}
