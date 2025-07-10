namespace tekSayılarıAtlayıpÇiftSayılarıYazdıranAlgoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan sürekli olarak sayı girmesini isteyin. Kullanıcı negatif bir sayı girdiğinde,
            döngüyü sonlandırın (break kullanarak). Girilen tek sayıları atlayın ve sadece çift sayıları ekrana yazdırın
            (continue kullanarak).
            1.başla
            2.sonsuz bir döngü başlat
            3.kullanıcıdan bir sayi iste
            4.eğer negatif ise bitir
            5.eğer tek ise continou ile bu turu atla
            6.eğer çift ise yazdır
            7.bitir             
            */
            while (true)
            {
                Console.Write("Bir sayı girin: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi < 0)
                {
                    Console.WriteLine("Negatif sayı girildi.");
                    break;
                }
                if (sayi % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine("Çift sayı: " + sayi);
            }
        }
    }
}