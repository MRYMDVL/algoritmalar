namespace enKucukElemaninYeriniBulanAlgoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir dizideki en küçük elemanın, bu dizinin kaçıncı elemanı olduğunu bulan programı yazın.
            1-başla
            2-bir sayı dizisi oluştur
            3-dizinin ilk elemanını enkucukdeger olarak ata
            4-en küçük elemanın yerini index değerine ata
            5-dizideki tüm elemanları gez
            5.1-eğer eleman en küçük değerden küçükse enkucukdeger değişkenini güncelle
            5.2-indexi güncelle
            6-enkucukdegeri ve yerini yazdır
            7-bitir
             */
            int[] dizi = { 18, 34, 77, 1, 11, 3, 0 };
            int enkucukdeger = dizi[0];
            int index = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (enkucukdeger >= dizi[i])
                {
                    enkucukdeger = dizi[i];
                    index = i;
                }
            }
            Console.WriteLine($"dizideki en küçük eleman: {enkucukdeger} ve bulunduğu index {index}");
        }
    }
}
