namespace kargoUcretiHesaplamaFonksiyonu
{
    internal class Program

    {
        public static double ToplamKargoUcreti(double mesafe, double agirlik)
        {
            double mesafeUcreti = 25.78;
            double agirlikUcreti = 35.89;
            double defaultUcret = 100;
            double toplamUcret = (mesafeUcreti * mesafe) + (agirlikUcreti * agirlik) + defaultUcret;
            return toplamUcret;

        }
        static void Main(string[] args)
        {
            double kargoUcreti = ToplamKargoUcreti(100,45);
            Console.WriteLine($"toplam kargo ücretiniz {kargoUcreti} tl dir");

        }
    }
}
