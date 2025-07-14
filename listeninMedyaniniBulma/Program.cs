namespace listeninMedyaniniBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Bir listedeki tüm sayıların medyanını bulan bir fonksiyon yazın.*/
            int[] dizi = { 18, 77, 34, 11, 6 , 10, 7};
            Array.Sort(dizi); // 6,7,10,11,18,34,77
            double medyan = 0.0;
            if (dizi.Length % 2 != 0)
            {
                medyan=dizi[dizi.Length / 2];
            }
            else
            {
                medyan = (dizi[dizi.Length / 2 - 1] + dizi[dizi.Length / 2])/2.0;
            }
            Console.WriteLine($"medyan: {medyan}");

        }
    }
}
