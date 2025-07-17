namespace selamlaFonksiyonu
{
    internal class Program
    {
        public static void SelamVer(string isim, string saat)
        {
            Console.WriteLine($"merhaba, {isim},{saat} itibari ile sistem başlatılmıştır");
        }
        static void Main(string[] args)
        {
            SelamVer("meryem", "13.00");
        }
    }
}
