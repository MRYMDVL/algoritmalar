namespace kelimlerinIlkHarfiniBuyukYazanFonksiyon
{
    internal class Program
    {
        static string BuyukHarfYapma(string cumle)
        {
            string[] kelimeler = cumle.Split(new char[] { ' ', '.', ',', '?', '!', ';' }, StringSplitOptions.RemoveEmptyEntries);


            for (int i = 0; i < kelimeler.Length; i++)
            {
                if (!string.IsNullOrEmpty(kelimeler[i]))
                {
                    kelimeler[i] = char.ToUpper(kelimeler[i][0]) + kelimeler[i].Substring(1).ToLower();
                }
            }
            return string.Join(".", kelimeler); //Join:Her kelimeyi arada bir boşluk bırakarak birleştirir.
        }
        static void Main()
        {
            Console.WriteLine("Lütfen bir cümle giriniz:");
            string cumle = Console.ReadLine();
            string yeniKelimeler = BuyukHarfYapma(cumle);
            Console.WriteLine(yeniKelimeler);
        }s
    }
}
