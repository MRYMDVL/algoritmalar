namespace anagramAlgoritmasıı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            girdiğimiz iki kelimenin anagram olup olmadığını anlayan algoritma.
            1.başla
            2.kullanıcıdan iki kelime al
            3.eğer iki kelimenin uzunluğu eşit değilse anagram değildir yazdır,8.adıma git
            4.her iki kelimeyi karakter dizisine çevir
            5.her iki karakter dizisini sırala
            6.dizinin uzunluğu kadar döngü çevir
            6.1.kelimelerin aynı indekslerini karşılaştır
            6.2.eğer herhangi biri eşleşmiyorsa anagram değildir yazdır,8.adıma git
            7.tüm karakterler eşleşiyorusa anagramdır yazdır
            8.bitir
             */
            Console.WriteLine("Lütfen ilk kelimeyi giriniz: ");
            string ilkKelime = Console.ReadLine();
            Console.WriteLine("Lütfen ikinci kelimeyi giriniz: ");
            string ikinciKelime = Console.ReadLine();
            

            if (ilkKelime.Length != ikinciKelime.Length) 
            {   
                Console.WriteLine("Girdiğiniz kelimeler anagram değildir. ");
                return;
            }
            char[] dizi1 = ilkKelime.ToCharArray();
            char[] dizi2 = ikinciKelime.ToCharArray();
            Array.Sort(dizi1);
            Array.Sort(dizi2);

            for (int i = 0;i<dizi1.Length; i++)
            {
                if (dizi1[i] != dizi2[i])
                {
                    Console.WriteLine("Girdiğiniz kelimeler anagram değildir. ");
                    return;
                }
            }
            Console.WriteLine("Girdiğiniz kelimeler anagramdır.");


        }
    }
}
