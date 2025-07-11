namespace ikiSayininEbobu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İki sayının EBOB’unu bulan bir fonksiyon yazın.


            Console.WriteLine("Birinci sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int ekok = 0 ;
            int min = (sayi1 < sayi2) ? sayi1 : sayi2; //if else kullanımı 
            int ebob = 1;

            for (int i = min; i >= 1; i--)
            {
                if (sayi1 % i == 0 && (sayi2 % i) == 0)
                {
                    ebob = i;
                    break;
                }


            }
            Console.WriteLine($"{sayi1} ve {sayi2} ebobu = {ebob}");
            ekok = (sayi1 * sayi2) / ebob;
            Console.WriteLine($"{sayi1} ve {sayi2} ekoku = {ekok} ");

        }
        /*
        static int Ebob(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        */
    }
}
