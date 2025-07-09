namespace HarftenSonrasiniYazdirmamaAlgoritmasi
{
    internal class Program
    {
        /*
        1- basla
        2- kullanicidan bir metin al
        3- kullanicidan bir harf al
        4- metini donguye al
        4.1 metinin her karaakterini harfle esit mi kontrol et
        4.1.2 esit degilse yazdir
        4.2 esitse donguyu sonlandir(break;)
        5. bitis

         */
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            ConsoleKeyInfo keyInfo = Console.ReadKey(); // sadece harf almaya yariyor
            char harf = keyInfo.KeyChar;
            harf = char.ToLower(harf);

            Console.WriteLine();

            foreach(var i in text)
            {
                if (i != harf) { Console.Write(i); }
                else 
                { 
                    Console.Write(i);
                    break; 
                }
            }
        }
    }
}
