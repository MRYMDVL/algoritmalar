namespace maxMinYerDegistimeAlgoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1.Başla
            2.Diziyi tanımla
            3.max ve min adında iki değişken tanımla
            3.1 max ve min değerlerine dizinin ilk elemanını ata
            4.max_index ve min_index adında iki değişken tanımla
            4.1 max_index ve min_index değerlerine 0 ata
            5.dizinin elemanlarını sırayla kontrol et
            5.1 eğer dizinin i. elemanı max değerinden büyükse max değerini güncelle ve max_index değerini i olarak ata
            5.2 eğer dizinin i. elemanı min değerinden küçükse min değerini güncelle ve min_index değerini i olaraak ata
            6. max_index ve min_indexteki değerleri değiştir
            7.yeni diziyi ekrana yazdır
            8.bitir
             
             
             
             */
            int[] dizi = { 2, 6, 9, 1, 4, 15 };
            int max = dizi[0];
            int min = dizi[0];
            int max_index = 0;
            int min_index = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > max) {

                    max = dizi[i];
                    max_index = i;



                }
                if (dizi[i] < min)
                {
                    min = dizi[i];
                    min_index = i;

                }
            }
            int temp = dizi[max_index];
            dizi[max_index] = dizi[min_index];
            dizi[min_index] = temp;

            foreach (int i in dizi)
            {
                Console.Write(i + " ");

            }



               
        }
    }
}
