namespace stringCümleFonksiyonu
{
    internal class Program
    {
        public static int KelimeSayisi(string cumle)
        {
            //cumle = cumle.Trim(); başınnda ve sonundaki boşlukları yok saymamıza yarıyor
            string[] kelimeler = cumle.Split(' ',StringSplitOptions.RemoveEmptyEntries); // tüm boşlukları yok saymamıza yarıyor
            return kelimeler.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz: ");
            string metin = Console.ReadLine();

            int kelimeSayisi = KelimeSayisi(metin);
            Console.WriteLine($"Metinde toplam {kelimeSayisi} kelime var.");
        }
    }
}
