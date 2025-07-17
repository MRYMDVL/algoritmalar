namespace ikiTarihArasındaKacGünVarFonksiyonu
{
    internal class Program
    {
        public static int TarihFarkiGoster(DateTime baslangic, DateTime bitis)
        {

            return (bitis - baslangic).Days;
        }

        static void Main(string[] args)
        {
            DateTime baslangic = new DateTime(2025, 7, 17); 
            DateTime bitis = new DateTime(2025, 8, 16);

            int gunSayisi = TarihFarkiGoster(baslangic,bitis);
            Console.WriteLine($"Başlangıç ve bitiş tarihleri arasında {gunSayisi} gün vardır.");

        }
    }
}
